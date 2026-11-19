using RRHH.Domain.Asistencia;
using Xunit;

namespace RRHH.Tests.Asistencia;

public sealed class AsistenciaConsolidadaTests
{
    [Theory]
    [InlineData(true,true,true,true,"Ausencia",true)]
    [InlineData(true,false,true,true,"Presencial",true)]
    [InlineData(true,false,false,true,"Remoto",false)]
    [InlineData(true,false,false,false,"Sin registro",false)]
    [InlineData(false,true,true,true,"No laborable",false)]
    [InlineData(true,false,true,false,"Presencial",false)]
    [InlineData(true,true,false,false,"Ausencia",false)]
    public void RF15PrioridadExcluyenteYConflictos(bool laborable,bool ausencia,bool presencial,bool remoto,string categoria,bool inconsistencia)
    {
        var resultado=ClasificacionAsistenciaDia.Resolver(laborable,ausencia,presencial,remoto);
        Assert.Equal(categoria,resultado.Categoria);Assert.Equal(inconsistencia,resultado.Inconsistencia);
    }
}
