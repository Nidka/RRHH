using System;
using System.Collections.Generic;
using RRHH.Domain.Asistencia;

namespace RRHH.Application.Asistencia;

/// <summary>
/// Contrato de persistencia para los días feriados no laborables.
/// </summary>
public interface IFeriadoRepository
{
	IReadOnlyList<Feriado> Listar();

	bool ExisteFecha(DateTime fecha);

	/// <summary>
	/// Verifica la unicidad por día calendario e inserta el feriado de forma atómica.
	/// Devuelve <c>false</c> cuando ya existe un feriado para ese día calendario.
	/// </summary>
	bool InsertarSiNoExisteFecha(Feriado feriado, out int idAsignado);

	bool Eliminar(int id);
}
