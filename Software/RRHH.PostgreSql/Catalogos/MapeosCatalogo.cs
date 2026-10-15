using System;
using System.Collections.Generic;
using RRHH.Domain.Catalogos;

namespace RRHH.PostgreSql.Catalogos;

/// <summary>
/// Tablas de BD/schema.sql que respaldan cada catálogo. Reemplazan a los
/// XxxMapper de GRLL (LINQ-to-SQL) usados por los formularios FrmMant*.
/// Las referencias reproducen las asociaciones con IsForeignKey de
/// dcGRLLDataContext; una prueba comprueba que no falte ninguna columna.
/// </summary>
public static class MapeosCatalogo
{
	private static readonly Dictionary<TipoCatalogo, MapeoCatalogo> Mapeos = new Dictionary<TipoCatalogo, MapeoCatalogo>
	{
		[TipoCatalogo.EstadoCivil] = new MapeoCatalogo("EstadoCivil", "IdEstadoCivil", "DescripEstCivil", "AbrevEstCiv",
			Ref("Empleado", "IdEstadoCivil"), Ref("Familiar", "IdEstadoCivil"), Ref("RRHH_Asegurado", "idEstadoCivil")),
		[TipoCatalogo.Cargo] = new MapeoCatalogo("Cargo", "IdCargo", "Cargo", "Abreviatura",
			Ref("Empleado", "IdCargo")),
		[TipoCatalogo.GrupoSanguineo] = new MapeoCatalogo("TipoSangre", "IdTipoSangre", "DescripTS", null,
			Ref("Empleado", "IdTipoSangre"), Ref("Familiar", "IdTipoSangre")),
		[TipoCatalogo.Nacionalidad] = new MapeoCatalogo("Nacionalidad", "IdNacionalidad", "Descripcion", "Abreviatura",
			Ref("Empleado", "IdNacionalidad")),
		[TipoCatalogo.RegimenPension] = new MapeoCatalogo("RegimenPension", "IdRegimenPen", "LeyRegimen", null,
			Ref("Empleado", "IdRegimenPen")),
		[TipoCatalogo.TipoDocumentoIdentidad] = new MapeoCatalogo("TipoDocID", "TipoDocID", "Descripcion", null,
			Ref("Persona", "TipoDocID")),
		[TipoCatalogo.TipoEstudio] = new MapeoCatalogo("TipoEstudio", "IdTipoEstudios", "DescripTipoEst", null,
			Ref("EstudiosRealizado", "IdTipoEstudios")),
		[TipoCatalogo.TipoInstitucion] = new MapeoCatalogo("TipoInstitucion", "IdTipoInstitucion", "DescripTipoInstitucion", null,
			Ref("ExpLaboral", "IdTipoInstitucion")),
		[TipoCatalogo.TipoPermiso] = new MapeoCatalogo("TipoPermiso", "idTipoPermiso", "DescripTipoPermiso", null,
			Ref("Motivo_Perm", "idTipoPermiso")),
		[TipoCatalogo.TipoTrabajador] = new MapeoCatalogo("TipoTrabajador", "IdTipoTrabajador", "Descripcion", "Observaciones",
			Ref("Empleado", "IdTipoTrabajador"))
	};

	public static MapeoCatalogo Para(TipoCatalogo tipo)
	{
		if (!Mapeos.TryGetValue(tipo, out MapeoCatalogo mapeo))
		{
			throw new ArgumentOutOfRangeException(nameof(tipo), tipo, "Catálogo sin mapeo PostgreSQL.");
		}

		return mapeo;
	}

	private static ReferenciaCatalogo Ref(string tabla, string columna) => new ReferenciaCatalogo(tabla, columna);
}
