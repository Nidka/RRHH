using System;
using System.Collections.Generic;
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
    public void LosModulosSiguenLaClasificacionDelEnunciado()
    {
        Assert.Equal(
            new[] { "Gestión de turnos", "Permisos y licencias", "Vacaciones", "Teletrabajo y presencialidad", "Reportes generales", "Mi cuenta" },
            CatalogoModulos.Todos.Select(m => m.Titulo));
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
}
