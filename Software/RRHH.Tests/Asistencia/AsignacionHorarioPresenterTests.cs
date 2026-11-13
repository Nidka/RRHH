using System;
using System.Collections.Generic;
using RRHH.Application.Asistencia;
using RRHH.Domain.Asistencia;
using RRHH.Domain.Comun;
using RRHH.Presentation.Asistencia;
using RRHH.Tests.Fakes;
using Xunit;

namespace RRHH.Tests.Asistencia;

public class AsignacionHorarioPresenterTests
{
    [Fact]
    public void CargarYCancelarNoEscribenYGuardarSoloUnaVezCierra()
    {
        var repo=new Repositorio(); var vista=new Vista(); Crear(vista,repo);
        vista.Cargar(); Assert.True(vista.Habilitado); Assert.Equal(0,repo.Escrituras);
        vista.Guardar(); vista.Guardar(); Assert.Equal(1,repo.Escrituras); Assert.True(vista.Cerrado);
    }
    [Fact]
    public void CargaFallidaNoPermiteGuardar()
    {
        var repo=new Repositorio { Fallar=true }; var vista=new Vista(); Crear(vista,repo);
        vista.Cargar(); vista.Guardar(); Assert.False(vista.Habilitado); Assert.Equal(0,repo.Escrituras);
        Assert.NotEmpty(vista.Error);
    }
    [Fact]
    public void RangoInvalidoNoEscribeNiCierraYPermiteCorregir()
    {
        var repo=new Repositorio();var vista=new Vista { Hasta=new DateTime(2026,11,9) };Crear(vista,repo);
        vista.Cargar();vista.Guardar();Assert.Equal(0,repo.Escrituras);Assert.False(vista.Cerrado);
        Assert.True(vista.Habilitado);Assert.NotEmpty(vista.Error);
        vista.Hasta=new DateTime(2026,11,12);vista.Guardar();Assert.Equal(1,repo.Escrituras);
    }
    [Fact]
    public void EdicionCargaElNumeroSinEscribir()
    {
        var repo=new Repositorio();var vista=new Vista { Numero=7 };Crear(vista,repo);
        vista.Cargar(); Assert.Equal(7,vista.Cargada.Numero);Assert.Equal(0,repo.Escrituras);
    }
    [Fact]
    public void ConflictoDePersistenciaNoCierraYErrorTecnicoPermiteReintentar()
    {
        var repo=new Repositorio();var vista=new Vista();Crear(vista,repo);vista.Cargar();
        repo.Fallar=true;vista.Guardar();Assert.False(vista.Cerrado);Assert.True(vista.Habilitado);
        repo.Fallar=false;vista.Guardar();Assert.True(vista.Cerrado);
    }
    private static void Crear(Vista v,Repositorio r) => _=new AsignacionHorarioPresenter(v,
        new ObtenerDatosAsignacion(r),new ListarHorarios(new FakeHorarioRepository()),new AsignarHorarioPorPeriodo(r));

    private sealed class Repositorio : IHorarioTemporalRepository
    {
        public int Escrituras;public bool Fallar;
        public IReadOnlyList<HistoricoHorarioDto> Listar(int empleado,RangoFechas rango)=>Array.Empty<HistoricoHorarioDto>();
        public bool Eliminar(int empleado,int numero)=>false;
        public EmpleadoHorarioDto ObtenerEmpleado(int empleado) => Fallar ? throw new InvalidOperationException() : new EmpleadoHorarioDto();
        public AsignacionHorarioDto Obtener(int empleado,int numero) => new AsignacionHorarioDto { IdEmpleado=empleado,Numero=numero };
        public int Guardar(AsignacionHorario a) { if(Fallar) throw new InvalidOperationException();Escrituras++;return 7; }
    }
    private sealed class Vista : IAsignacionHorarioView
    {
        public int IdEmpleado=>1;public int Numero {get;set;}public int IdHorario=>1;
        public DateTime Desde=>new DateTime(2026,11,10);public DateTime Hasta {get;set;}=new DateTime(2026,11,12);
        public string Documento=>null;public string Sisgedo=>null;
        public event EventHandler CargarSolicitado;public event EventHandler GuardarSolicitado;
        public bool Habilitado;public bool Cerrado;public string Error;public AsignacionHorarioDto Cargada;
        public void Cargar()=>CargarSolicitado?.Invoke(this,EventArgs.Empty);
        public void Guardar()=>GuardarSolicitado?.Invoke(this,EventArgs.Empty);
        public void MostrarEmpleado(EmpleadoHorarioDto empleado) { }
        public void MostrarHorarios(IReadOnlyList<HorarioDto> horarios) { }
        public void MostrarAsignacion(AsignacionHorarioDto asignacion)=>Cargada=asignacion;
        public void HabilitarGuardar(bool habilitado)=>Habilitado=habilitado;
        public void MostrarError(string mensaje)=>Error=mensaje;
        public void CerrarGuardado()=>Cerrado=true;
    }
}
