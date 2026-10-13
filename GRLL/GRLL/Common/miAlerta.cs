using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common;

[Serializable]
public class miAlerta : MarshalByRefObject
{
	[method: DebuggerNonUserCode]
	public event Inserted OnInsertedEvent;

	[DebuggerNonUserCode]
	public miAlerta()
	{
	}

	public void InsertarAlerta(Alertita Alerta)
	{
		Interaction.MsgBox("insertado");
	}

	public List<Alertita> Obtenertiposalerta()
	{
		SQLConfiguracion configuracion = clsConexion.Configuracion;
		configuracion.AutenticacionIntegrada = false;
		configuracion.BaseDatos = "cmi";
		configuracion.Password = "";
		configuracion.Usuario = "sa";
		configuracion.Servidor = "ahorna\\sqlexpress";
		configuracion.TiempoConexion = 60;
		configuracion = null;
		List<Alertita> lista = new List<Alertita>();
		lista.Add(new Alertita
		{
			IdTipoAlerta = 1,
			Descripcion = "alerta1"
		});
		lista.Add(new Alertita
		{
			IdTipoAlerta = 2,
			Descripcion = "alerta2"
		});
		List<Alertita> Obtenertiposalerta;
		try
		{
			Obtenertiposalerta = lista;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Obtenertiposalerta = null;
			ProjectData.ClearProjectError();
		}
		finally
		{
			doInsertar("Se ha listado");
		}
		return Obtenertiposalerta;
	}

	public void doInsertar(string mensaje)
	{
		OnInsertedEvent?.Invoke(mensaje);
	}
}
