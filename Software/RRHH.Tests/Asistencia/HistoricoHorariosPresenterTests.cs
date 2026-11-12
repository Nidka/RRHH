using System;
using System.Collections.Generic;
using RRHH.Application.Asistencia;
using RRHH.Domain.Asistencia;
using RRHH.Domain.Comun;
using RRHH.Presentation.Asistencia;
using Xunit;

namespace RRHH.Tests.Asistencia;

public class HistoricoHorariosPresenterTests
{
    [Fact]
    public void AbrirConsultarYCancelarEditorNoBorranNiGuardan()
    {
        var r=new Repo();var v=new Vista();Crear(v,r);v.Cargar();v.Agregar();v.Editar();
        Assert.Equal(0,r.Bajas);Assert.Equal(2,v.Editores);Assert.Equal(1,r.Consultas);
    }
    [Fact]
    public void CancelarBajaNoEscribeYConfirmarBorraSoloSeleccionada()
    {
        var r=new Repo();var v=new Vista();Crear(v,r);v.Cargar();v.Eliminar();Assert.Equal(0,r.Bajas);
        v.Confirmacion=true;v.Eliminar();Assert.Equal(1,r.Bajas);Assert.Equal(7,r.NumeroBorrado);
        Assert.Equal(2,r.Consultas);
    }
    [Fact]
    public void ConsultaFallidaLimpiaFilasYNoPermiteBajaDeResultadoAnterior()
    {
        var r=new Repo();var v=new Vista();Crear(v,r);v.Cargar();r.Fallar=true;v.Consultar();
        v.Confirmacion=true;v.Eliminar();Assert.Empty(v.Filas);Assert.Equal(0,r.Bajas);Assert.NotEmpty(v.Error);
        r.Fallar=false;v.Consultar();Assert.Single(v.Filas);
    }
    private static void Crear(Vista v,Repo r)=>_=new HistoricoHorariosPresenter(v,new ObtenerDatosAsignacion(r),
        new ConsultarHistoricoHorarios(r),new EliminarAsignacionHorario(r));
    private sealed class Repo:IHorarioTemporalRepository
    {
        public int Bajas;public int Consultas;public int NumeroBorrado;public bool Fallar;
        public EmpleadoHorarioDto ObtenerEmpleado(int e)=>new EmpleadoHorarioDto();
        public AsignacionHorarioDto Obtener(int e,int n)=>null;
        public int Guardar(AsignacionHorario a)=>throw new InvalidOperationException("La consulta no debe guardar");
        public bool Eliminar(int e,int n) { Bajas++;NumeroBorrado=n;return true; }
        public IReadOnlyList<HistoricoHorarioDto> Listar(int e,RangoFechas rango)
        {
            if(Fallar) throw new InvalidOperationException("Fallo ficticio");Consultas++;
            return new[] {new HistoricoHorarioDto {IdEmpleado=1,N=7}};
        }
    }
    private sealed class Vista:IHistoricoHorariosView
    {
        public int IdEmpleado=>1;public int? NumeroSeleccionado=>7;public DateTime? Desde=>null;public DateTime? Hasta=>null;
        public bool Confirmacion;public int Editores;public string Error;public IReadOnlyList<HistoricoHorarioDto> Filas=Array.Empty<HistoricoHorarioDto>();
        public event EventHandler CargarSolicitado;public event EventHandler ConsultarSolicitado;
        public event EventHandler AgregarSolicitado;public event EventHandler EditarSolicitado;public event EventHandler EliminarSolicitado;
        public void Cargar()=>CargarSolicitado?.Invoke(this,EventArgs.Empty);public void Consultar()=>ConsultarSolicitado?.Invoke(this,EventArgs.Empty);
        public void Agregar()=>AgregarSolicitado?.Invoke(this,EventArgs.Empty);public void Editar()=>EditarSolicitado?.Invoke(this,EventArgs.Empty);
        public void Eliminar()=>EliminarSolicitado?.Invoke(this,EventArgs.Empty);
        public void MostrarEmpleado(EmpleadoHorarioDto e) { }
        public void MostrarFilas(IReadOnlyList<HistoricoHorarioDto> filas)=>Filas=filas;
        public bool AbrirEditor(int numero) { Editores++;return false; }
        public bool ConfirmarEliminar()=>Confirmacion;
        public void Habilitar(bool habilitado) { }
        public void MostrarError(string mensaje)=>Error=mensaje;
    }
}
