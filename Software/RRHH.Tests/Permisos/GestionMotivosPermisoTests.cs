using RRHH.Application.Permisos;
using RRHH.Domain.Comun;
using RRHH.Domain.Permisos;
using RRHH.Tests.Fakes;
using Xunit;

namespace RRHH.Tests.Permisos;

public class GestionMotivosPermisoTests
{
    private readonly FakeMotivoPermisoRepository _repo = new FakeMotivoPermisoRepository();
    private static MotivoPermisoDto Nuevo() => new MotivoPermisoDto
        { TipoPermisoId = 1, Descripcion = " Motivo ", Abreviatura = " A ", Salario = null };

    [Fact]
    public void AltaEnTablaVaciaAsignaIdYModalidadDeSesion()
    {
        MotivoPermisoDto dto = Nuevo();
        dto.Modalidad = "C"; // una entrada de vista no puede cambiar el alcance del rol
        var resultado = new GuardarMotivoPermiso(_repo, new AccesoMotivosPermiso(10)).Ejecutar(dto);
        Assert.True(resultado.Exitoso);
        Assert.Equal(1, dto.Id);
        Assert.Equal("P", Assert.Single(_repo.Registros).Modalidad);
        Assert.Equal("Motivo", dto.Descripcion);
    }

    [Theory]
    [InlineData(0, "Motivo")]
    [InlineData(1, " ")]
    public void DatosInvalidosNoLleganALaEscritura(int tipo, string descripcion)
    {
        var dto = Nuevo(); dto.TipoPermisoId = tipo; dto.Descripcion = descripcion;
        Assert.False(new GuardarMotivoPermiso(_repo, new AccesoMotivosPermiso(10)).Ejecutar(dto).Exitoso);
        Assert.Equal(0, _repo.Escrituras);
    }

    [Fact]
    public void EdicionDeRol13NoReactivaNiPierdeModalidad()
    {
        _repo.Registros.Add(MotivoPermiso.Reconstituir(8, 1, "Anterior", "A", true, "C", false));
        var dto = Nuevo(); dto.Id = 8;
        Assert.True(new GuardarMotivoPermiso(_repo, new AccesoMotivosPermiso(13)).Ejecutar(dto).Exitoso);
        MotivoPermiso guardado = Assert.Single(_repo.Registros);
        Assert.Equal("C", guardado.Modalidad);
        Assert.False(guardado.Activo);
    }

    [Fact]
    public void EdicionFueraDeModalidadSeRechaza()
    {
        _repo.Registros.Add(MotivoPermiso.Reconstituir(8, 1, "Anterior", "A", true, "C", true));
        var dto = Nuevo(); dto.Id = 8;
        Assert.False(new GuardarMotivoPermiso(_repo, new AccesoMotivosPermiso(10)).Ejecutar(dto).Exitoso);
        Assert.Equal(0, _repo.Escrituras);
    }

    [Fact]
    public void TipoDistintoYRegistroAusenteSeRechazan()
    {
        var dto = Nuevo(); dto.Id = 8;
        var guardar = new GuardarMotivoPermiso(_repo, new AccesoMotivosPermiso(13));
        Assert.False(guardar.Ejecutar(dto).Exitoso);
        _repo.Registros.Add(MotivoPermiso.Reconstituir(8, 2, "Anterior", "A", true, null, null));
        Assert.False(guardar.Ejecutar(dto).Exitoso);
        Assert.Equal(0, _repo.Escrituras);
    }

    [Fact]
    public void RolNoPermitidoNoConsultaNiEscribe()
    {
        var acceso = new AccesoMotivosPermiso(3);
        Assert.Throws<ReglaNegocioException>(() => new ObtenerMotivoPermiso(_repo, acceso).Ejecutar(1));
        Assert.False(new GuardarMotivoPermiso(_repo, acceso).Ejecutar(Nuevo()).Exitoso);
        Assert.False(new EliminarMotivoPermiso(_repo, acceso).Ejecutar(1).Exitoso);
        Assert.Equal(0, _repo.Consultas);
        Assert.Equal(0, _repo.Escrituras);
    }

    [Theory]
    [InlineData(10, "P", 1)]
    [InlineData(14, "C", 1)]
    [InlineData(13, null, 3)]
    public void ListadoRespetaModalidadYSigueMostrandoInactivos(int rol, string modalidad, int cantidad)
    {
        _repo.Registros.Add(MotivoPermiso.Reconstituir(1, 1, "P", null, null, "P", false));
        _repo.Registros.Add(MotivoPermiso.Reconstituir(2, 1, "C", null, null, "C", true));
        _repo.Registros.Add(MotivoPermiso.Reconstituir(3, 1, "General", null, null, null, null));
        var listar = new ListarMotivosPermiso(_repo, new AccesoMotivosPermiso(rol));
        Assert.Empty(listar.Ejecutar(0));
        Assert.Equal(0, _repo.Listados);
        Assert.Equal(cantidad, listar.Ejecutar(1).Count);
        Assert.Equal(modalidad, _repo.UltimaModalidad);
    }

    [Fact]
    public void MotivoReferenciadoNoSeElimina()
    {
        _repo.Registros.Add(MotivoPermiso.Reconstituir(1, 1, "En uso", null, null, "P", true));
        _repo.EnUso.Add(1);
        var resultado = new EliminarMotivoPermiso(_repo, new AccesoMotivosPermiso(10)).Ejecutar(1);
        Assert.False(resultado.Exitoso);
        Assert.Contains("historial", resultado.Mensaje);
        Assert.Single(_repo.Registros);
        Assert.Equal(0, _repo.Escrituras);
    }
}
