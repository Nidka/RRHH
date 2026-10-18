using RRHH.Domain.Comun;
using RRHH.Domain.Permisos;
using Xunit;

namespace RRHH.Tests.Permisos;

public class MotivoPermisoTests
{
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("   ")]
    public void DescripcionVaciaSeRechaza(string descripcion) =>
        Assert.Throws<ReglaNegocioException>(() => MotivoPermiso.Nuevo(1, descripcion, null, null, "P"));

    [Fact]
    public void LimitesDeColumnasYNormalizacion()
    {
        MotivoPermiso motivo = MotivoPermiso.Nuevo(1, "  Motivo  ", "  ABC  ", null, "P");
        Assert.Equal("Motivo", motivo.Descripcion);
        Assert.Equal("ABC", motivo.Abreviatura);
        Assert.Throws<ReglaNegocioException>(() => MotivoPermiso.Nuevo(1, new string('a', 51), "ABC", null, "P"));
        Assert.Throws<ReglaNegocioException>(() => MotivoPermiso.Nuevo(1, "Motivo", "ABCD", null, "P"));
        Assert.Equal(50, MotivoPermiso.Nuevo(1, new string('a', 50), null, null, "P").Descripcion.Length);
    }

    [Fact]
    public void EditarConservaCamposNoEditablesYNulabilidad()
    {
        MotivoPermiso anterior = MotivoPermiso.Reconstituir(9, 1, "Anterior", "A", null, "C", false);
        MotivoPermiso editado = anterior.Editar(" Nuevo ", " N ", null);
        Assert.Equal(9, editado.Id);
        Assert.Equal(1, editado.TipoPermisoId);
        Assert.Equal("C", editado.Modalidad);
        Assert.False(editado.Activo);
        Assert.Null(editado.Salario);
        Assert.Equal("Anterior", anterior.Descripcion);
    }

    [Theory]
    [InlineData(10, "P", true)]
    [InlineData(14, "C", true)]
    [InlineData(13, null, true)]
    [InlineData(3, null, false)]
    public void PoliticaConservaElAlcanceDeRoles(int rol, string modalidad, bool permitido)
    {
        var acceso = new AccesoMotivosPermiso(rol);
        Assert.Equal(permitido, acceso.Permitido);
        Assert.Equal(modalidad, acceso.Modalidad);
    }
}
