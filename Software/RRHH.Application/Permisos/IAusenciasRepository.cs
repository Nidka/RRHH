using System.Collections.Generic;
using RRHH.Domain.Comun;

namespace RRHH.Application.Permisos;

/// <summary>
/// Contrato de consulta del reporte de ausencias por periodo (RF-18) sobre <c>public."Permiso"</c>
/// y <c>public."Motivo_Perm"</c>. Reemplaza a <c>RRHHClass.spRRHH_RepPermisos</c>, que filtraba solo por
/// la fecha de inicio del permiso.
/// </summary>
public interface IAusenciasRepository
{
	/// <summary>
	/// Permisos que comparten al menos un día con <paramref name="rango"/>: parcialmente dentro, que empiezan
	/// antes o terminan después, o que contienen todo el periodo.
	/// </summary>
	/// <param name="rango">Periodo consultado, ambos extremos incluidos.</param>
	/// <param name="idMotivo">Si tiene valor, solo permisos de ese motivo; <c>null</c> incluye todos.</param>
	IReadOnlyList<AusenciaRegistrada> ListarSolapadas(RangoFechas rango, int? idMotivo);

	/// <summary>Motivos del catálogo, para el filtro de la pantalla, ordenados por descripción.</summary>
	IReadOnlyList<MotivoAusenciaDto> ListarMotivos();
}
