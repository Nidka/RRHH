using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using RRHH.Application.Navegacion;
using Xunit;

namespace RRHH.Tests.Navegacion;

/// <summary>
/// CR-019: la navegación de escritorio y web sale de una sola lista de módulos.
/// Estas pruebas fijan que cada requerimiento del área usuaria tiene una pantalla
/// y que lo que ve cada rol depende solo de sus permisos.
/// </summary>
public sealed class CatalogoModulosTests
{
    private static IEnumerable<PantallaModulo> Pantallas => CatalogoModulos.Todos.SelectMany(m => m.Pantallas);

    [Fact]
    public void CadaUnoDeLosDieciochoRequerimientosTieneAlMenosUnaPantalla()
    {
        var cubiertos = new HashSet<string>(Pantallas.SelectMany(p => p.Requerimientos));
        var faltantes = Enumerable.Range(1, 18).Select(n => $"RF-{n:00}").Where(rf => !cubiertos.Contains(rf)).ToList();

        Assert.Empty(faltantes);
    }

    [Fact]
    public void LosModulosSiguenLaClasificacionDelEnunciadoYLuegoPersonal()
    {
        // A-E del enunciado; Personal (CR-020) no pertenece a esa clasificación y va después.
        Assert.Equal(
            new[] { "Gestión de turnos", "Permisos y licencias", "Vacaciones", "Teletrabajo y presencialidad", "Reportes generales", "Personal", "Mi cuenta" },
            CatalogoModulos.Todos.Select(m => m.Titulo));
    }

    [Fact]
    public void ElRegistroDeEmpleadosExigeSuPropioPermisoYNoCuentaComoRequerimiento()
    {
        var visibles = CatalogoModulos.Visibles(p => p == PermisoModulo.Personal);

        var modulo = Assert.Single(visibles);
        Assert.Equal("personal", modulo.Clave);
        var pantalla = Assert.Single(modulo.Pantallas);
        Assert.Equal("registro-empleados", pantalla.Clave);
        Assert.Empty(pantalla.Requerimientos);
    }

    [Fact]
    public void LasClavesSonUnicasYSirvenComoNombreDeArchivo()
    {
        var claves = CatalogoModulos.Todos.Select(m => m.Clave).Concat(Pantallas.Select(p => p.Clave)).ToList();

        Assert.Equal(claves.Count, claves.Distinct().Count());
        Assert.All(claves, clave => Assert.Matches(new Regex("^[a-z0-9]+(-[a-z0-9]+)*$"), clave));
    }

    [Fact]
    public void NingunTituloConservaElRotuloDePrototipo()
    {
        var titulos = CatalogoModulos.Todos.Select(m => m.Titulo).Concat(Pantallas.Select(p => p.Titulo));

        Assert.DoesNotContain(titulos, t => t.IndexOf("piloto", StringComparison.OrdinalIgnoreCase) >= 0);
    }

    [Fact]
    public void ConSoloElPermisoDeVacacionesSeVeSoloElModuloDeVacaciones()
    {
        var visibles = CatalogoModulos.Visibles(p => p == PermisoModulo.Vacaciones);

        var modulo = Assert.Single(visibles);
        Assert.Equal("vacaciones", modulo.Clave);
        Assert.Equal(4, modulo.Pantallas.Count);
    }

    [Fact]
    public void UnModuloConPermisosMixtosMuestraSoloLasPantallasPermitidas()
    {
        var visibles = CatalogoModulos.Visibles(p => p == PermisoModulo.Asistencia);

        Assert.Equal(new[] { "teletrabajo", "reportes" }, visibles.Select(m => m.Clave));
        Assert.Equal(new[] { "presencialidad" }, visibles[0].Pantallas.Select(p => p.Clave));
        Assert.Equal(new[] { "asistencia-feriados" }, visibles[1].Pantallas.Select(p => p.Clave));
    }

    [Fact]
    public void ElAutoservicioSoloVeMiCuenta()
    {
        var visibles = CatalogoModulos.Visibles(p => p == PermisoModulo.Autoconsulta);

        Assert.Equal("mi-cuenta", Assert.Single(visibles).Clave);
    }

    [Fact]
    public void SinPermisosNoHayModulos()
    {
        Assert.Empty(CatalogoModulos.Visibles(_ => false));
    }

    [Fact]
    public void ConTodosLosPermisosSeVenTodasLasPantallas()
    {
        Assert.Equal(Pantallas.Count(), CatalogoModulos.Visibles(_ => true).Sum(m => m.Pantallas.Count));
    }

    [Fact]
    public void VisiblesExigeLaFuncionDePermisos()
    {
        Assert.Throws<ArgumentNullException>(() => CatalogoModulos.Visibles(null));
    }

    /// <summary>La web carga js/modulos/&lt;módulo&gt;/&lt;pantalla&gt;.js por clave: una entrada sin archivo rompería el menú.</summary>
    [Fact]
    public void CadaPantallaTieneSuArchivoEnLaWebYNoSobranArchivos()
    {
        string raiz = CarpetaModulosWeb();
        var esperados = CatalogoModulos.Todos
            .SelectMany(m => m.Pantallas.Select(p => Path.Combine(raiz, m.Clave, p.Clave + ".js")))
            .OrderBy(ruta => ruta, StringComparer.Ordinal).ToList();
        var existentes = Directory.GetFiles(raiz, "*.js", SearchOption.AllDirectories)
            .OrderBy(ruta => ruta, StringComparer.Ordinal).ToList();

        Assert.Equal(esperados, existentes);
    }

    private static string CarpetaModulosWeb()
    {
        var carpeta = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
        while (carpeta != null)
        {
            string ruta = Path.Combine(carpeta.FullName, "Software", "RRHH.Web", "wwwroot", "js", "modulos");
            if (Directory.Exists(ruta)) return ruta;
            carpeta = carpeta.Parent;
        }
        throw new DirectoryNotFoundException("Ejecutar las pruebas dentro del checkout que contiene Software/RRHH.Web.");
    }
}
