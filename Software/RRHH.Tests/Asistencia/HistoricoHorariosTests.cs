using System;
using System.Collections.Generic;
using RRHH.Application.Asistencia;
using RRHH.Domain.Asistencia;
using RRHH.Domain.Comun;
using Xunit;

namespace RRHH.Tests.Asistencia;

public class HistoricoHorariosTests
{
    [Fact]
    public void InterseccionIncluyeContencionYExtremosYOrdenaSinMezclarEmpleados()
    {
        var r=new Repo();var caso=new ConsultarHistoricoHorarios(r);
        var filas=caso.Ejecutar(1,new DateTime(2026,11,10),new DateTime(2026,11,12));
        Assert.Collection(filas,x=>Assert.Equal(3,x.N),x=>Assert.Equal(1,x.N));
        Assert.Equal(0,r.Escrituras);
    }
    [Fact]
    public void TodosIncluyeFechasAusentesYNoEscribe()
    {
        var r=new Repo();var filas=new ConsultarHistoricoHorarios(r).Ejecutar(1,null,null);
        Assert.Equal(4,filas.Count);Assert.Null(filas[3].FechaInicio);Assert.Equal(0,r.Escrituras);
    }
    [Theory]
    [InlineData(0,10,12)]
    [InlineData(1,12,10)]
    [InlineData(1,10,0)]
    public void EntradaInvalidaNoConsulta(int empleado,int desde,int hasta)
    {
        var r=new Repo();Assert.Throws<ReglaNegocioException>(()=>new ConsultarHistoricoHorarios(r).Ejecutar(empleado,
            new DateTime(2026,11,desde),hasta==0 ? (DateTime?)null : new DateTime(2026,11,hasta)));
        Assert.Equal(0,r.Lecturas);
    }
    private sealed class Repo : IHorarioTemporalRepository
    {
        public int Lecturas;public int Escrituras;
        public IReadOnlyList<HistoricoHorarioDto> Listar(int empleado,RangoFechas rango)
        {
            Lecturas++;return new[] {Fila(1,1,1,30),Fila(1,2,13,15),Fila(1,3,12,12),Fila(2,4,10,12),new HistoricoHorarioDto { IdEmpleado=1,N=5 }};
        }
        private static HistoricoHorarioDto Fila(int e,int n,int d,int h)=>new HistoricoHorarioDto { IdEmpleado=e,N=n,FechaInicio=new DateTime(2026,11,d),FechaFin=new DateTime(2026,11,h) };
        public bool Eliminar(int empleado,int numero) { Escrituras++;return true; }
        public AsignacionHorarioDto Obtener(int empleado,int numero)=>null;
        public EmpleadoHorarioDto ObtenerEmpleado(int empleado)=>null;
        public int Guardar(AsignacionHorario a) { Escrituras++;return 1; }
    }
}
