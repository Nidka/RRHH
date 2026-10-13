using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ClassRRHH;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.My.Resources;

namespace RecursosHumanos;

[DesignerGenerated]
public class MainMDI : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("MenuStrip1")]
	private MenuStrip _MenuStrip1;

	[AccessedThroughProperty("ToolStripMenuItem1")]
	private ToolStripMenuItem _ToolStripMenuItem1;

	[AccessedThroughProperty("PersonalToolStripMenuItem")]
	private ToolStripMenuItem _PersonalToolStripMenuItem;

	[AccessedThroughProperty("StatusStrip1")]
	private StatusStrip _StatusStrip1;

	[AccessedThroughProperty("ToolStrip1")]
	private ToolStrip _ToolStrip1;

	[AccessedThroughProperty("ToolStripButton1")]
	private ToolStripButton _ToolStripButton1;

	[AccessedThroughProperty("SalirToolStripMenuItem")]
	private ToolStripMenuItem _SalirToolStripMenuItem;

	[AccessedThroughProperty("MantenimientosToolStripMenuItem")]
	private ToolStripMenuItem _MantenimientosToolStripMenuItem;

	[AccessedThroughProperty("ListaPersonalToolStripMenuItem")]
	private ToolStripMenuItem _ListaPersonalToolStripMenuItem;

	[AccessedThroughProperty("MantenimientosToolStripMenuItem1")]
	private ToolStripMenuItem _MantenimientosToolStripMenuItem1;

	[AccessedThroughProperty("CargosToolStripMenuItem")]
	private ToolStripMenuItem _CargosToolStripMenuItem;

	[AccessedThroughProperty("GruposSanguineosToolStripMenuItem")]
	private ToolStripMenuItem _GruposSanguineosToolStripMenuItem;

	[AccessedThroughProperty("CondicionLaboralToolStripMenuItem")]
	private ToolStripMenuItem _CondicionLaboralToolStripMenuItem;

	[AccessedThroughProperty("NacionalidadesToolStripMenuItem")]
	private ToolStripMenuItem _NacionalidadesToolStripMenuItem;

	[AccessedThroughProperty("RegimenDePensioneToolStripMenuItem")]
	private ToolStripMenuItem _RegimenDePensioneToolStripMenuItem;

	[AccessedThroughProperty("EstadoCivilToolStripMenuItem")]
	private ToolStripMenuItem _EstadoCivilToolStripMenuItem;

	[AccessedThroughProperty("TipoDeInstituciónToolStripMenuItem")]
	private ToolStripMenuItem _TipoDeInstituciónToolStripMenuItem;

	[AccessedThroughProperty("TipoDeDocumentoIdentidadToolStripMenuItem")]
	private ToolStripMenuItem _TipoDeDocumentoIdentidadToolStripMenuItem;

	[AccessedThroughProperty("TipoEstudiosToolStripMenuItem")]
	private ToolStripMenuItem _TipoEstudiosToolStripMenuItem;

	[AccessedThroughProperty("BusquedaToolStripMenuItem")]
	private ToolStripMenuItem _BusquedaToolStripMenuItem;

	[AccessedThroughProperty("CumpleañosToolStripMenuItem")]
	private ToolStripMenuItem _CumpleañosToolStripMenuItem;

	[AccessedThroughProperty("PersonalPorOficinaToolStripMenuItem")]
	private ToolStripMenuItem _PersonalPorOficinaToolStripMenuItem;

	[AccessedThroughProperty("PersonalPorFechaDeIngresoToolStripMenuItem")]
	private ToolStripMenuItem _PersonalPorFechaDeIngresoToolStripMenuItem;

	[AccessedThroughProperty("ToolStripStatusLabel1")]
	private ToolStripStatusLabel _ToolStripStatusLabel1;

	[AccessedThroughProperty("TSSL_Usuario")]
	private ToolStripStatusLabel _TSSL_Usuario;

	[AccessedThroughProperty("ToolStripButton2")]
	private ToolStripButton _ToolStripButton2;

	[AccessedThroughProperty("CargosToolStripMenuItem1")]
	private ToolStripMenuItem _CargosToolStripMenuItem1;

	[AccessedThroughProperty("AyudaToolStripMenuItem")]
	private ToolStripMenuItem _AyudaToolStripMenuItem;

	[AccessedThroughProperty("AyudaToolStripMenuItem1")]
	private ToolStripMenuItem _AyudaToolStripMenuItem1;

	[AccessedThroughProperty("ToolStripSeparator2")]
	private ToolStripSeparator _ToolStripSeparator2;

	[AccessedThroughProperty("AcercaDeToolStripMenuItem")]
	private ToolStripMenuItem _AcercaDeToolStripMenuItem;

	[AccessedThroughProperty("ToolStripButton3")]
	private ToolStripButton _ToolStripButton3;

	[AccessedThroughProperty("ToolStripSeparator3")]
	private ToolStripSeparator _ToolStripSeparator3;

	[AccessedThroughProperty("ToolStripButton4")]
	private ToolStripButton _ToolStripButton4;

	[AccessedThroughProperty("RegistroNuevoToolStripMenuItem")]
	private ToolStripMenuItem _RegistroNuevoToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator1")]
	private ToolStripSeparator _ToolStripSeparator1;

	[AccessedThroughProperty("TipoDocFilePersonalToolStripMenuItem")]
	private ToolStripMenuItem _TipoDocFilePersonalToolStripMenuItem;

	[AccessedThroughProperty("ToolStripButton5")]
	private ToolStripButton _ToolStripButton5;

	[AccessedThroughProperty("ToolStripSeparator4")]
	private ToolStripSeparator _ToolStripSeparator4;

	[AccessedThroughProperty("ToolStripButton7")]
	private ToolStripButton _ToolStripButton7;

	[AccessedThroughProperty("ToolStripButton10")]
	private ToolStripButton _ToolStripButton10;

	[AccessedThroughProperty("MotivoDePermisoToolStripMenuItem")]
	private ToolStripMenuItem _MotivoDePermisoToolStripMenuItem;

	[AccessedThroughProperty("TipoDePermisoToolStripMenuItem")]
	private ToolStripMenuItem _TipoDePermisoToolStripMenuItem;

	[AccessedThroughProperty("FeriadosToolStripMenuItem1")]
	private ToolStripMenuItem _FeriadosToolStripMenuItem1;

	[AccessedThroughProperty("AsistenciasToolStripMenuItem")]
	private ToolStripMenuItem _AsistenciasToolStripMenuItem;

	[AccessedThroughProperty("FaltasToolStripMenuItem")]
	private ToolStripMenuItem _FaltasToolStripMenuItem;

	[AccessedThroughProperty("PermisosToolStripMenuItem")]
	private ToolStripMenuItem _PermisosToolStripMenuItem;

	[AccessedThroughProperty("AsistenciaDiaToolStripMenuItem")]
	private ToolStripMenuItem _AsistenciaDiaToolStripMenuItem;

	[AccessedThroughProperty("HorariosToolStripMenuItem")]
	private ToolStripMenuItem _HorariosToolStripMenuItem;

	[AccessedThroughProperty("RecordAsistenciasSemanalesToolStripMenuItem")]
	private ToolStripMenuItem _RecordAsistenciasSemanalesToolStripMenuItem;

	[AccessedThroughProperty("ImportacionToolStripMenuItem")]
	private ToolStripMenuItem _ImportacionToolStripMenuItem;

	[AccessedThroughProperty("ImportarAsistenciasToolStripMenuItem")]
	private ToolStripMenuItem _ImportarAsistenciasToolStripMenuItem;

	[AccessedThroughProperty("AsignarHorariosToolStripMenuItem1")]
	private ToolStripMenuItem _AsignarHorariosToolStripMenuItem1;

	[AccessedThroughProperty("ImportacionAsistenciasNOSEDEToolStripMenuItem")]
	private ToolStripMenuItem _ImportacionAsistenciasNOSEDEToolStripMenuItem;

	[AccessedThroughProperty("ToolStripButton6")]
	private ToolStripButton _ToolStripButton6;

	[AccessedThroughProperty("ToolStripSeparator5")]
	private ToolStripSeparator _ToolStripSeparator5;

	[AccessedThroughProperty("PersonalPorProfesionToolStripMenuItem")]
	private ToolStripMenuItem _PersonalPorProfesionToolStripMenuItem;

	[AccessedThroughProperty("AsistenciaDiaSeleccionToolStripMenuItem")]
	private ToolStripMenuItem _AsistenciaDiaSeleccionToolStripMenuItem;

	[AccessedThroughProperty("ImportarAsistenciasPROINDToolStripMenuItem")]
	private ToolStripMenuItem _ImportarAsistenciasPROINDToolStripMenuItem;

	[AccessedThroughProperty("AsignarLocalToolStripMenuItem")]
	private ToolStripMenuItem _AsignarLocalToolStripMenuItem;

	[AccessedThroughProperty("ImportarAsistenciasCONSEJOToolStripMenuItem")]
	private ToolStripMenuItem _ImportarAsistenciasCONSEJOToolStripMenuItem;

	[AccessedThroughProperty("ImportacionBiometricoToolStripMenuItem")]
	private ToolStripMenuItem _ImportacionBiometricoToolStripMenuItem;

	[AccessedThroughProperty("EstadisticoPermisosToolStripMenuItem")]
	private ToolStripMenuItem _EstadisticoPermisosToolStripMenuItem;

	private FrmListaOrganica objListaOrganica;

	private FrmBuscarPersona objFrmPersonal;

	private FrmMantCargos ObjMantCargo;

	private FrmMantGrupoSanguineo ObjMantGrupoSangrineo;

	private FrmMantTipoTrab ObjMantTipoTrab;

	private FrmMantRegimen ObjMantRegimen;

	private FrmMantNacionalidades ObjMantNacionalidad;

	private FrmMantEstCivil ObjMantEstCivil;

	private FrmMantTipoInst ObjMantTipoInst;

	private FrmMantTipoDocIdent ObjFrmMantTipoDocIdent;

	private FrmMantTipoEstudio ObjFrmMantTipoEstudio;

	private FrmReport_Selec_Pliego ObjFicha;

	private FrmMantDocFile ObjMantFile;

	private FrmHorarios ObjHorario;

	private FrmConsultaFaltas ObjFrmConsultaFaltas;

	private FrmConsultaAsistencias ObjFrmConsultaAsistencias;

	private FrmFeriado ObjFrmFeriado;

	private FrmMotivoPermiso ObjFrmMotivoPermiso;

	private FrmMantTipoPerm ObjFrmMantTipoPerm;

	private FrmRepPermisos oFrmRepPermisos;

	private FrmReport_Cargos objFrmReportCargos;

	private FrmReport_Selec_Fechas objFrmReportCumple;

	private FrmReport_SelecMes objFrmReportCumplea;

	private FrmReport_Selc_Oficina objFrmReportCumpleb;

	private FrmConsultaAsistDiaria oFrmConsultaAsistDiaria;

	private FrmPermiso oFrmPermiso;

	private AcercaDe objAcercaDe;

	private FrmHorasTrabajadas oFrmHorasTrabajadas;

	private FrmImportarAsistencia oFrmImportarAsistencia;

	private FrmAsignarHorario oFrmAsignarHorario;

	private FrmImportarAsistenciaFueraSEDE oFrmImportarAsistenciaFueraSEDE;

	private FrmSobreTiempo oFrmSobreTiempo;

	private FrmReporteProfesion oFrmReporteProfesion;

	private FrmRepAsistenciaDia oFrmRepAsistenciaDia;

	private FrmImportarAsistenciaPROIND oFrmImportarAsistenciaPROIND;

	private FrmLocalAsignado oFrmLocalAsignado;

	private FrmImportarAsistenciaCONSEJO oFrmImportarAsistenciaCONSEJO;

	private FrmImportarAsistenciaBio oFrmImportarAsistenciaBio;

	private FrmReporteEstadistico oFrmReporteEstadistico;

	internal MenuStrip MenuStrip1
	{
		[DebuggerNonUserCode]
		get
		{
			return _MenuStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MenuStrip1 = value;
		}
	}

	internal ToolStripMenuItem ToolStripMenuItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripMenuItem1 = value;
		}
	}

	internal ToolStripMenuItem PersonalToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _PersonalToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = PersonalToolStripMenuItem_Click;
			if (_PersonalToolStripMenuItem != null)
			{
				_PersonalToolStripMenuItem.Click -= value2;
			}
			_PersonalToolStripMenuItem = value;
			if (_PersonalToolStripMenuItem != null)
			{
				_PersonalToolStripMenuItem.Click += value2;
			}
		}
	}

	internal StatusStrip StatusStrip1
	{
		[DebuggerNonUserCode]
		get
		{
			return _StatusStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_StatusStrip1 = value;
		}
	}

	internal ToolStrip ToolStrip1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStrip1 = value;
		}
	}

	internal ToolStripButton ToolStripButton1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = ToolStripButton1_Click;
			if (_ToolStripButton1 != null)
			{
				_ToolStripButton1.Click -= value2;
			}
			_ToolStripButton1 = value;
			if (_ToolStripButton1 != null)
			{
				_ToolStripButton1.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem SalirToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _SalirToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = SalirToolStripMenuItem_Click;
			if (_SalirToolStripMenuItem != null)
			{
				_SalirToolStripMenuItem.Click -= value2;
			}
			_SalirToolStripMenuItem = value;
			if (_SalirToolStripMenuItem != null)
			{
				_SalirToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem MantenimientosToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _MantenimientosToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MantenimientosToolStripMenuItem = value;
		}
	}

	internal ToolStripMenuItem ListaPersonalToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListaPersonalToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = ListaPersonalToolStripMenuItem_Click;
			if (_ListaPersonalToolStripMenuItem != null)
			{
				_ListaPersonalToolStripMenuItem.Click -= value2;
			}
			_ListaPersonalToolStripMenuItem = value;
			if (_ListaPersonalToolStripMenuItem != null)
			{
				_ListaPersonalToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem MantenimientosToolStripMenuItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _MantenimientosToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MantenimientosToolStripMenuItem1 = value;
		}
	}

	internal ToolStripMenuItem CargosToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _CargosToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = CargosToolStripMenuItem_Click;
			if (_CargosToolStripMenuItem != null)
			{
				_CargosToolStripMenuItem.Click -= value2;
			}
			_CargosToolStripMenuItem = value;
			if (_CargosToolStripMenuItem != null)
			{
				_CargosToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem GruposSanguineosToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _GruposSanguineosToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = GruposSanguineosToolStripMenuItem_Click;
			if (_GruposSanguineosToolStripMenuItem != null)
			{
				_GruposSanguineosToolStripMenuItem.Click -= value2;
			}
			_GruposSanguineosToolStripMenuItem = value;
			if (_GruposSanguineosToolStripMenuItem != null)
			{
				_GruposSanguineosToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem CondicionLaboralToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _CondicionLaboralToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = CondicionLaboralToolStripMenuItem_Click;
			if (_CondicionLaboralToolStripMenuItem != null)
			{
				_CondicionLaboralToolStripMenuItem.Click -= value2;
			}
			_CondicionLaboralToolStripMenuItem = value;
			if (_CondicionLaboralToolStripMenuItem != null)
			{
				_CondicionLaboralToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem NacionalidadesToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _NacionalidadesToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = NacionalidadesToolStripMenuItem_Click;
			if (_NacionalidadesToolStripMenuItem != null)
			{
				_NacionalidadesToolStripMenuItem.Click -= value2;
			}
			_NacionalidadesToolStripMenuItem = value;
			if (_NacionalidadesToolStripMenuItem != null)
			{
				_NacionalidadesToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem RegimenDePensioneToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _RegimenDePensioneToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = RegimenDePensioneToolStripMenuItem_Click;
			if (_RegimenDePensioneToolStripMenuItem != null)
			{
				_RegimenDePensioneToolStripMenuItem.Click -= value2;
			}
			_RegimenDePensioneToolStripMenuItem = value;
			if (_RegimenDePensioneToolStripMenuItem != null)
			{
				_RegimenDePensioneToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem EstadoCivilToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _EstadoCivilToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = EstadoCivilToolStripMenuItem_Click;
			if (_EstadoCivilToolStripMenuItem != null)
			{
				_EstadoCivilToolStripMenuItem.Click -= value2;
			}
			_EstadoCivilToolStripMenuItem = value;
			if (_EstadoCivilToolStripMenuItem != null)
			{
				_EstadoCivilToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem TipoDeInstituciónToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _TipoDeInstituciónToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = TipoDeInstituciónToolStripMenuItem_Click;
			if (_TipoDeInstituciónToolStripMenuItem != null)
			{
				_TipoDeInstituciónToolStripMenuItem.Click -= value2;
			}
			_TipoDeInstituciónToolStripMenuItem = value;
			if (_TipoDeInstituciónToolStripMenuItem != null)
			{
				_TipoDeInstituciónToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem TipoDeDocumentoIdentidadToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _TipoDeDocumentoIdentidadToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = TipoDeDocumentoIdentidadToolStripMenuItem_Click;
			if (_TipoDeDocumentoIdentidadToolStripMenuItem != null)
			{
				_TipoDeDocumentoIdentidadToolStripMenuItem.Click -= value2;
			}
			_TipoDeDocumentoIdentidadToolStripMenuItem = value;
			if (_TipoDeDocumentoIdentidadToolStripMenuItem != null)
			{
				_TipoDeDocumentoIdentidadToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem TipoEstudiosToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _TipoEstudiosToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = TipoEstudiosToolStripMenuItem_Click;
			if (_TipoEstudiosToolStripMenuItem != null)
			{
				_TipoEstudiosToolStripMenuItem.Click -= value2;
			}
			_TipoEstudiosToolStripMenuItem = value;
			if (_TipoEstudiosToolStripMenuItem != null)
			{
				_TipoEstudiosToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem BusquedaToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _BusquedaToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BusquedaToolStripMenuItem_Click;
			if (_BusquedaToolStripMenuItem != null)
			{
				_BusquedaToolStripMenuItem.Click -= value2;
			}
			_BusquedaToolStripMenuItem = value;
			if (_BusquedaToolStripMenuItem != null)
			{
				_BusquedaToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem CumpleañosToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _CumpleañosToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = CumpleañosToolStripMenuItem_Click;
			if (_CumpleañosToolStripMenuItem != null)
			{
				_CumpleañosToolStripMenuItem.Click -= value2;
			}
			_CumpleañosToolStripMenuItem = value;
			if (_CumpleañosToolStripMenuItem != null)
			{
				_CumpleañosToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem PersonalPorOficinaToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _PersonalPorOficinaToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = PersonalPorOficinaToolStripMenuItem_Click;
			if (_PersonalPorOficinaToolStripMenuItem != null)
			{
				_PersonalPorOficinaToolStripMenuItem.Click -= value2;
			}
			_PersonalPorOficinaToolStripMenuItem = value;
			if (_PersonalPorOficinaToolStripMenuItem != null)
			{
				_PersonalPorOficinaToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem PersonalPorFechaDeIngresoToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _PersonalPorFechaDeIngresoToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = PersonalPorFechaDeIngresoToolStripMenuItem_Click;
			if (_PersonalPorFechaDeIngresoToolStripMenuItem != null)
			{
				_PersonalPorFechaDeIngresoToolStripMenuItem.Click -= value2;
			}
			_PersonalPorFechaDeIngresoToolStripMenuItem = value;
			if (_PersonalPorFechaDeIngresoToolStripMenuItem != null)
			{
				_PersonalPorFechaDeIngresoToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripStatusLabel ToolStripStatusLabel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripStatusLabel1 = value;
		}
	}

	internal ToolStripStatusLabel TSSL_Usuario
	{
		[DebuggerNonUserCode]
		get
		{
			return _TSSL_Usuario;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TSSL_Usuario = value;
		}
	}

	internal ToolStripButton ToolStripButton2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripButton2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = ToolStripButton2_Click;
			if (_ToolStripButton2 != null)
			{
				_ToolStripButton2.Click -= value2;
			}
			_ToolStripButton2 = value;
			if (_ToolStripButton2 != null)
			{
				_ToolStripButton2.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem CargosToolStripMenuItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _CargosToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = CargosToolStripMenuItem1_Click;
			if (_CargosToolStripMenuItem1 != null)
			{
				_CargosToolStripMenuItem1.Click -= value2;
			}
			_CargosToolStripMenuItem1 = value;
			if (_CargosToolStripMenuItem1 != null)
			{
				_CargosToolStripMenuItem1.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem AyudaToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _AyudaToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_AyudaToolStripMenuItem = value;
		}
	}

	internal ToolStripMenuItem AyudaToolStripMenuItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _AyudaToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_AyudaToolStripMenuItem1 = value;
		}
	}

	internal ToolStripSeparator ToolStripSeparator2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator2 = value;
		}
	}

	internal ToolStripMenuItem AcercaDeToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _AcercaDeToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = AcercaDeToolStripMenuItem_Click;
			if (_AcercaDeToolStripMenuItem != null)
			{
				_AcercaDeToolStripMenuItem.Click -= value2;
			}
			_AcercaDeToolStripMenuItem = value;
			if (_AcercaDeToolStripMenuItem != null)
			{
				_AcercaDeToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripButton ToolStripButton3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripButton3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = ToolStripButton3_Click;
			if (_ToolStripButton3 != null)
			{
				_ToolStripButton3.Click -= value2;
			}
			_ToolStripButton3 = value;
			if (_ToolStripButton3 != null)
			{
				_ToolStripButton3.Click += value2;
			}
		}
	}

	internal ToolStripSeparator ToolStripSeparator3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator3 = value;
		}
	}

	internal ToolStripButton ToolStripButton4
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripButton4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripButton4 = value;
		}
	}

	internal ToolStripMenuItem RegistroNuevoToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _RegistroNuevoToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = RegistroNuevoToolStripMenuItem_Click;
			if (_RegistroNuevoToolStripMenuItem != null)
			{
				_RegistroNuevoToolStripMenuItem.Click -= value2;
			}
			_RegistroNuevoToolStripMenuItem = value;
			if (_RegistroNuevoToolStripMenuItem != null)
			{
				_RegistroNuevoToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripSeparator ToolStripSeparator1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator1 = value;
		}
	}

	internal ToolStripMenuItem TipoDocFilePersonalToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _TipoDocFilePersonalToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = TipoDocFilePersonalToolStripMenuItem_Click;
			if (_TipoDocFilePersonalToolStripMenuItem != null)
			{
				_TipoDocFilePersonalToolStripMenuItem.Click -= value2;
			}
			_TipoDocFilePersonalToolStripMenuItem = value;
			if (_TipoDocFilePersonalToolStripMenuItem != null)
			{
				_TipoDocFilePersonalToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripButton ToolStripButton5
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripButton5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = ToolStripButton5_Click;
			if (_ToolStripButton5 != null)
			{
				_ToolStripButton5.Click -= value2;
			}
			_ToolStripButton5 = value;
			if (_ToolStripButton5 != null)
			{
				_ToolStripButton5.Click += value2;
			}
		}
	}

	internal ToolStripSeparator ToolStripSeparator4
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator4 = value;
		}
	}

	internal ToolStripButton ToolStripButton7
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripButton7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = ToolStripButton7_Click;
			if (_ToolStripButton7 != null)
			{
				_ToolStripButton7.Click -= value2;
			}
			_ToolStripButton7 = value;
			if (_ToolStripButton7 != null)
			{
				_ToolStripButton7.Click += value2;
			}
		}
	}

	internal ToolStripButton ToolStripButton10
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripButton10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = ToolStripButton10_Click;
			if (_ToolStripButton10 != null)
			{
				_ToolStripButton10.Click -= value2;
			}
			_ToolStripButton10 = value;
			if (_ToolStripButton10 != null)
			{
				_ToolStripButton10.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem MotivoDePermisoToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _MotivoDePermisoToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = MotivoDePermisoToolStripMenuItem_Click;
			if (_MotivoDePermisoToolStripMenuItem != null)
			{
				_MotivoDePermisoToolStripMenuItem.Click -= value2;
			}
			_MotivoDePermisoToolStripMenuItem = value;
			if (_MotivoDePermisoToolStripMenuItem != null)
			{
				_MotivoDePermisoToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem TipoDePermisoToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _TipoDePermisoToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = TipoDePermisoToolStripMenuItem_Click;
			if (_TipoDePermisoToolStripMenuItem != null)
			{
				_TipoDePermisoToolStripMenuItem.Click -= value2;
			}
			_TipoDePermisoToolStripMenuItem = value;
			if (_TipoDePermisoToolStripMenuItem != null)
			{
				_TipoDePermisoToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem FeriadosToolStripMenuItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _FeriadosToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = FeriadosToolStripMenuItem1_Click;
			if (_FeriadosToolStripMenuItem1 != null)
			{
				_FeriadosToolStripMenuItem1.Click -= value2;
			}
			_FeriadosToolStripMenuItem1 = value;
			if (_FeriadosToolStripMenuItem1 != null)
			{
				_FeriadosToolStripMenuItem1.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem AsistenciasToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _AsistenciasToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = AsistenciasToolStripMenuItem_Click;
			if (_AsistenciasToolStripMenuItem != null)
			{
				_AsistenciasToolStripMenuItem.Click -= value2;
			}
			_AsistenciasToolStripMenuItem = value;
			if (_AsistenciasToolStripMenuItem != null)
			{
				_AsistenciasToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem FaltasToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _FaltasToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = FaltasToolStripMenuItem_Click;
			if (_FaltasToolStripMenuItem != null)
			{
				_FaltasToolStripMenuItem.Click -= value2;
			}
			_FaltasToolStripMenuItem = value;
			if (_FaltasToolStripMenuItem != null)
			{
				_FaltasToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem PermisosToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _PermisosToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = PermisosToolStripMenuItem_Click_1;
			if (_PermisosToolStripMenuItem != null)
			{
				_PermisosToolStripMenuItem.Click -= value2;
			}
			_PermisosToolStripMenuItem = value;
			if (_PermisosToolStripMenuItem != null)
			{
				_PermisosToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem AsistenciaDiaToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _AsistenciaDiaToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = AsistenciaDiaToolStripMenuItem_Click;
			if (_AsistenciaDiaToolStripMenuItem != null)
			{
				_AsistenciaDiaToolStripMenuItem.Click -= value2;
			}
			_AsistenciaDiaToolStripMenuItem = value;
			if (_AsistenciaDiaToolStripMenuItem != null)
			{
				_AsistenciaDiaToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem HorariosToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _HorariosToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = HorariosToolStripMenuItem_Click;
			if (_HorariosToolStripMenuItem != null)
			{
				_HorariosToolStripMenuItem.Click -= value2;
			}
			_HorariosToolStripMenuItem = value;
			if (_HorariosToolStripMenuItem != null)
			{
				_HorariosToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem RecordAsistenciasSemanalesToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _RecordAsistenciasSemanalesToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = RecordAsistenciasSemanalesToolStripMenuItem_Click;
			if (_RecordAsistenciasSemanalesToolStripMenuItem != null)
			{
				_RecordAsistenciasSemanalesToolStripMenuItem.Click -= value2;
			}
			_RecordAsistenciasSemanalesToolStripMenuItem = value;
			if (_RecordAsistenciasSemanalesToolStripMenuItem != null)
			{
				_RecordAsistenciasSemanalesToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem ImportacionToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImportacionToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ImportacionToolStripMenuItem = value;
		}
	}

	internal ToolStripMenuItem ImportarAsistenciasToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImportarAsistenciasToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = ImportarAsistenciasToolStripMenuItem_Click;
			if (_ImportarAsistenciasToolStripMenuItem != null)
			{
				_ImportarAsistenciasToolStripMenuItem.Click -= value2;
			}
			_ImportarAsistenciasToolStripMenuItem = value;
			if (_ImportarAsistenciasToolStripMenuItem != null)
			{
				_ImportarAsistenciasToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem AsignarHorariosToolStripMenuItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _AsignarHorariosToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = AsignarHorariosToolStripMenuItem1_Click;
			if (_AsignarHorariosToolStripMenuItem1 != null)
			{
				_AsignarHorariosToolStripMenuItem1.Click -= value2;
			}
			_AsignarHorariosToolStripMenuItem1 = value;
			if (_AsignarHorariosToolStripMenuItem1 != null)
			{
				_AsignarHorariosToolStripMenuItem1.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem ImportacionAsistenciasNOSEDEToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImportacionAsistenciasNOSEDEToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = ImportacionAsistenciasNOSEDEToolStripMenuItem_Click;
			if (_ImportacionAsistenciasNOSEDEToolStripMenuItem != null)
			{
				_ImportacionAsistenciasNOSEDEToolStripMenuItem.Click -= value2;
			}
			_ImportacionAsistenciasNOSEDEToolStripMenuItem = value;
			if (_ImportacionAsistenciasNOSEDEToolStripMenuItem != null)
			{
				_ImportacionAsistenciasNOSEDEToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripButton ToolStripButton6
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripButton6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = ToolStripButton6_Click;
			if (_ToolStripButton6 != null)
			{
				_ToolStripButton6.Click -= value2;
			}
			_ToolStripButton6 = value;
			if (_ToolStripButton6 != null)
			{
				_ToolStripButton6.Click += value2;
			}
		}
	}

	internal ToolStripSeparator ToolStripSeparator5
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator5 = value;
		}
	}

	internal ToolStripMenuItem PersonalPorProfesionToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _PersonalPorProfesionToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = PersonalPorProfesionToolStripMenuItem_Click;
			if (_PersonalPorProfesionToolStripMenuItem != null)
			{
				_PersonalPorProfesionToolStripMenuItem.Click -= value2;
			}
			_PersonalPorProfesionToolStripMenuItem = value;
			if (_PersonalPorProfesionToolStripMenuItem != null)
			{
				_PersonalPorProfesionToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem AsistenciaDiaSeleccionToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _AsistenciaDiaSeleccionToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = AsistenciaDiaSeleccionToolStripMenuItem_Click;
			if (_AsistenciaDiaSeleccionToolStripMenuItem != null)
			{
				_AsistenciaDiaSeleccionToolStripMenuItem.Click -= value2;
			}
			_AsistenciaDiaSeleccionToolStripMenuItem = value;
			if (_AsistenciaDiaSeleccionToolStripMenuItem != null)
			{
				_AsistenciaDiaSeleccionToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem ImportarAsistenciasPROINDToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImportarAsistenciasPROINDToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = ImportarAsistenciasPROINDToolStripMenuItem_Click;
			if (_ImportarAsistenciasPROINDToolStripMenuItem != null)
			{
				_ImportarAsistenciasPROINDToolStripMenuItem.Click -= value2;
			}
			_ImportarAsistenciasPROINDToolStripMenuItem = value;
			if (_ImportarAsistenciasPROINDToolStripMenuItem != null)
			{
				_ImportarAsistenciasPROINDToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem AsignarLocalToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _AsignarLocalToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = AsignarLocalToolStripMenuItem_Click;
			if (_AsignarLocalToolStripMenuItem != null)
			{
				_AsignarLocalToolStripMenuItem.Click -= value2;
			}
			_AsignarLocalToolStripMenuItem = value;
			if (_AsignarLocalToolStripMenuItem != null)
			{
				_AsignarLocalToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem ImportarAsistenciasCONSEJOToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImportarAsistenciasCONSEJOToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = ImportarAsistenciasCONSEJOToolStripMenuItem_Click;
			if (_ImportarAsistenciasCONSEJOToolStripMenuItem != null)
			{
				_ImportarAsistenciasCONSEJOToolStripMenuItem.Click -= value2;
			}
			_ImportarAsistenciasCONSEJOToolStripMenuItem = value;
			if (_ImportarAsistenciasCONSEJOToolStripMenuItem != null)
			{
				_ImportarAsistenciasCONSEJOToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem ImportacionBiometricoToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImportacionBiometricoToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = ImportacionBiometricoToolStripMenuItem_Click;
			if (_ImportacionBiometricoToolStripMenuItem != null)
			{
				_ImportacionBiometricoToolStripMenuItem.Click -= value2;
			}
			_ImportacionBiometricoToolStripMenuItem = value;
			if (_ImportacionBiometricoToolStripMenuItem != null)
			{
				_ImportacionBiometricoToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem EstadisticoPermisosToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _EstadisticoPermisosToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = EstadisticoPermisosToolStripMenuItem_Click;
			if (_EstadisticoPermisosToolStripMenuItem != null)
			{
				_EstadisticoPermisosToolStripMenuItem.Click -= value2;
			}
			_EstadisticoPermisosToolStripMenuItem = value;
			if (_EstadisticoPermisosToolStripMenuItem != null)
			{
				_EstadisticoPermisosToolStripMenuItem.Click += value2;
			}
		}
	}

	[DebuggerNonUserCode]
	public MainMDI()
	{
		base.FormClosing += MainMDI_FormClosing;
		base.Load += MainMDI_Load;
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecursosHumanos.MainMDI));
		this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
		this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.PersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.BusquedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
		this.RegistroNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.AsignarHorariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.AsignarLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.MantenimientosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.CargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.GruposSanguineosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.CondicionLaboralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.NacionalidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.RegimenDePensioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.EstadoCivilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.TipoDeInstituciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.TipoDeDocumentoIdentidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.TipoEstudiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.TipoDocFilePersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.MotivoDePermisoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.TipoDePermisoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.FeriadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.HorariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ImportacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ImportarAsistenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ImportarAsistenciasPROINDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ImportarAsistenciasCONSEJOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ImportacionBiometricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ImportacionAsistenciasNOSEDEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.MantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ListaPersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.CumpleañosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.PersonalPorOficinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.PersonalPorFechaDeIngresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.CargosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.AsistenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.FaltasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.PermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.AsistenciaDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.RecordAsistenciasSemanalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.PersonalPorProfesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.AsistenciaDiaSeleccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.AyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.AyudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
		this.AcercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.SalirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
		this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
		this.TSSL_Usuario = new System.Windows.Forms.ToolStripStatusLabel();
		this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
		this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
		this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
		this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
		this.ToolStripButton5 = new System.Windows.Forms.ToolStripButton();
		this.ToolStripButton6 = new System.Windows.Forms.ToolStripButton();
		this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
		this.ToolStripButton7 = new System.Windows.Forms.ToolStripButton();
		this.ToolStripButton10 = new System.Windows.Forms.ToolStripButton();
		this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
		this.ToolStripButton4 = new System.Windows.Forms.ToolStripButton();
		this.ToolStripButton3 = new System.Windows.Forms.ToolStripButton();
		this.EstadisticoPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.MenuStrip1.SuspendLayout();
		this.StatusStrip1.SuspendLayout();
		this.ToolStrip1.SuspendLayout();
		this.SuspendLayout();
		this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[6] { this.ToolStripMenuItem1, this.MantenimientosToolStripMenuItem1, this.ImportacionToolStripMenuItem, this.MantenimientosToolStripMenuItem, this.AyudaToolStripMenuItem, this.SalirToolStripMenuItem });
		System.Windows.Forms.MenuStrip menuStrip = this.MenuStrip1;
		System.Drawing.Point location = new System.Drawing.Point(0, 0);
		menuStrip.Location = location;
		this.MenuStrip1.Name = "MenuStrip1";
		System.Windows.Forms.MenuStrip menuStrip2 = this.MenuStrip1;
		System.Drawing.Size size = new System.Drawing.Size(683, 24);
		menuStrip2.Size = size;
		this.MenuStrip1.TabIndex = 1;
		this.MenuStrip1.Text = "MenuStrip1";
		this.ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[6] { this.PersonalToolStripMenuItem, this.BusquedaToolStripMenuItem, this.ToolStripSeparator1, this.RegistroNuevoToolStripMenuItem, this.AsignarHorariosToolStripMenuItem1, this.AsignarLocalToolStripMenuItem });
		this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
		System.Windows.Forms.ToolStripMenuItem toolStripMenuItem = this.ToolStripMenuItem1;
		size = new System.Drawing.Size(64, 20);
		toolStripMenuItem.Size = size;
		this.ToolStripMenuItem1.Text = "P&ersonal";
		this.PersonalToolStripMenuItem.Name = "PersonalToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem = this.PersonalToolStripMenuItem;
		size = new System.Drawing.Size(174, 22);
		personalToolStripMenuItem.Size = size;
		this.PersonalToolStripMenuItem.Text = "Relacion &Personal";
		this.BusquedaToolStripMenuItem.Name = "BusquedaToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem busquedaToolStripMenuItem = this.BusquedaToolStripMenuItem;
		size = new System.Drawing.Size(174, 22);
		busquedaToolStripMenuItem.Size = size;
		this.BusquedaToolStripMenuItem.Text = "&Búsqueda Personal";
		this.ToolStripSeparator1.Name = "ToolStripSeparator1";
		System.Windows.Forms.ToolStripSeparator toolStripSeparator = this.ToolStripSeparator1;
		size = new System.Drawing.Size(171, 6);
		toolStripSeparator.Size = size;
		this.RegistroNuevoToolStripMenuItem.Name = "RegistroNuevoToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem registroNuevoToolStripMenuItem = this.RegistroNuevoToolStripMenuItem;
		size = new System.Drawing.Size(174, 22);
		registroNuevoToolStripMenuItem.Size = size;
		this.RegistroNuevoToolStripMenuItem.Text = "&Nuevo Personal";
		this.AsignarHorariosToolStripMenuItem1.Name = "AsignarHorariosToolStripMenuItem1";
		System.Windows.Forms.ToolStripMenuItem asignarHorariosToolStripMenuItem = this.AsignarHorariosToolStripMenuItem1;
		size = new System.Drawing.Size(174, 22);
		asignarHorariosToolStripMenuItem.Size = size;
		this.AsignarHorariosToolStripMenuItem1.Text = "Asignar Horarios";
		this.AsignarLocalToolStripMenuItem.Name = "AsignarLocalToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem asignarLocalToolStripMenuItem = this.AsignarLocalToolStripMenuItem;
		size = new System.Drawing.Size(174, 22);
		asignarLocalToolStripMenuItem.Size = size;
		this.AsignarLocalToolStripMenuItem.Text = "Asignar Local";
		this.MantenimientosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[14]
		{
			this.CargosToolStripMenuItem, this.GruposSanguineosToolStripMenuItem, this.CondicionLaboralToolStripMenuItem, this.NacionalidadesToolStripMenuItem, this.RegimenDePensioneToolStripMenuItem, this.EstadoCivilToolStripMenuItem, this.TipoDeInstituciónToolStripMenuItem, this.TipoDeDocumentoIdentidadToolStripMenuItem, this.TipoEstudiosToolStripMenuItem, this.TipoDocFilePersonalToolStripMenuItem,
			this.MotivoDePermisoToolStripMenuItem, this.TipoDePermisoToolStripMenuItem, this.FeriadosToolStripMenuItem1, this.HorariosToolStripMenuItem
		});
		this.MantenimientosToolStripMenuItem1.Name = "MantenimientosToolStripMenuItem1";
		System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem = this.MantenimientosToolStripMenuItem1;
		size = new System.Drawing.Size(106, 20);
		mantenimientosToolStripMenuItem.Size = size;
		this.MantenimientosToolStripMenuItem1.Text = "&Mantenimientos";
		this.CargosToolStripMenuItem.Name = "CargosToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem cargosToolStripMenuItem = this.CargosToolStripMenuItem;
		size = new System.Drawing.Size(233, 22);
		cargosToolStripMenuItem.Size = size;
		this.CargosToolStripMenuItem.Text = "&Cargos";
		this.GruposSanguineosToolStripMenuItem.Name = "GruposSanguineosToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem gruposSanguineosToolStripMenuItem = this.GruposSanguineosToolStripMenuItem;
		size = new System.Drawing.Size(233, 22);
		gruposSanguineosToolStripMenuItem.Size = size;
		this.GruposSanguineosToolStripMenuItem.Text = "Grupos &Sanguineos";
		this.CondicionLaboralToolStripMenuItem.Name = "CondicionLaboralToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem condicionLaboralToolStripMenuItem = this.CondicionLaboralToolStripMenuItem;
		size = new System.Drawing.Size(233, 22);
		condicionLaboralToolStripMenuItem.Size = size;
		this.CondicionLaboralToolStripMenuItem.Text = "Condicion &Laboral";
		this.NacionalidadesToolStripMenuItem.Name = "NacionalidadesToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem nacionalidadesToolStripMenuItem = this.NacionalidadesToolStripMenuItem;
		size = new System.Drawing.Size(233, 22);
		nacionalidadesToolStripMenuItem.Size = size;
		this.NacionalidadesToolStripMenuItem.Text = "&Nacionalidades";
		this.RegimenDePensioneToolStripMenuItem.Name = "RegimenDePensioneToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem regimenDePensioneToolStripMenuItem = this.RegimenDePensioneToolStripMenuItem;
		size = new System.Drawing.Size(233, 22);
		regimenDePensioneToolStripMenuItem.Size = size;
		this.RegimenDePensioneToolStripMenuItem.Text = "&Regimen de Pensiones";
		this.EstadoCivilToolStripMenuItem.Name = "EstadoCivilToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem estadoCivilToolStripMenuItem = this.EstadoCivilToolStripMenuItem;
		size = new System.Drawing.Size(233, 22);
		estadoCivilToolStripMenuItem.Size = size;
		this.EstadoCivilToolStripMenuItem.Text = "&Estado Civil";
		this.TipoDeInstituciónToolStripMenuItem.Name = "TipoDeInstituciónToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem tipoDeInstituciónToolStripMenuItem = this.TipoDeInstituciónToolStripMenuItem;
		size = new System.Drawing.Size(233, 22);
		tipoDeInstituciónToolStripMenuItem.Size = size;
		this.TipoDeInstituciónToolStripMenuItem.Text = "Tipo de &Institución";
		this.TipoDeDocumentoIdentidadToolStripMenuItem.Name = "TipoDeDocumentoIdentidadToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem tipoDeDocumentoIdentidadToolStripMenuItem = this.TipoDeDocumentoIdentidadToolStripMenuItem;
		size = new System.Drawing.Size(233, 22);
		tipoDeDocumentoIdentidadToolStripMenuItem.Size = size;
		this.TipoDeDocumentoIdentidadToolStripMenuItem.Text = "Tipo de &Documento Identidad";
		this.TipoEstudiosToolStripMenuItem.Name = "TipoEstudiosToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem tipoEstudiosToolStripMenuItem = this.TipoEstudiosToolStripMenuItem;
		size = new System.Drawing.Size(233, 22);
		tipoEstudiosToolStripMenuItem.Size = size;
		this.TipoEstudiosToolStripMenuItem.Text = "Tipo E&studios";
		this.TipoDocFilePersonalToolStripMenuItem.Name = "TipoDocFilePersonalToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem tipoDocFilePersonalToolStripMenuItem = this.TipoDocFilePersonalToolStripMenuItem;
		size = new System.Drawing.Size(233, 22);
		tipoDocFilePersonalToolStripMenuItem.Size = size;
		this.TipoDocFilePersonalToolStripMenuItem.Text = "Tipo Doc. File Personal";
		this.MotivoDePermisoToolStripMenuItem.Name = "MotivoDePermisoToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem motivoDePermisoToolStripMenuItem = this.MotivoDePermisoToolStripMenuItem;
		size = new System.Drawing.Size(233, 22);
		motivoDePermisoToolStripMenuItem.Size = size;
		this.MotivoDePermisoToolStripMenuItem.Text = "Motivo de Permiso";
		this.TipoDePermisoToolStripMenuItem.Name = "TipoDePermisoToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem tipoDePermisoToolStripMenuItem = this.TipoDePermisoToolStripMenuItem;
		size = new System.Drawing.Size(233, 22);
		tipoDePermisoToolStripMenuItem.Size = size;
		this.TipoDePermisoToolStripMenuItem.Text = "Tipo de Permiso";
		this.FeriadosToolStripMenuItem1.Name = "FeriadosToolStripMenuItem1";
		System.Windows.Forms.ToolStripMenuItem feriadosToolStripMenuItem = this.FeriadosToolStripMenuItem1;
		size = new System.Drawing.Size(233, 22);
		feriadosToolStripMenuItem.Size = size;
		this.FeriadosToolStripMenuItem1.Text = "Feriados";
		this.HorariosToolStripMenuItem.Name = "HorariosToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem horariosToolStripMenuItem = this.HorariosToolStripMenuItem;
		size = new System.Drawing.Size(233, 22);
		horariosToolStripMenuItem.Size = size;
		this.HorariosToolStripMenuItem.Text = "Horarios";
		this.ImportacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[5] { this.ImportarAsistenciasToolStripMenuItem, this.ImportarAsistenciasPROINDToolStripMenuItem, this.ImportarAsistenciasCONSEJOToolStripMenuItem, this.ImportacionBiometricoToolStripMenuItem, this.ImportacionAsistenciasNOSEDEToolStripMenuItem });
		this.ImportacionToolStripMenuItem.Name = "ImportacionToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem importacionToolStripMenuItem = this.ImportacionToolStripMenuItem;
		size = new System.Drawing.Size(84, 20);
		importacionToolStripMenuItem.Size = size;
		this.ImportacionToolStripMenuItem.Text = "Importacion";
		this.ImportarAsistenciasToolStripMenuItem.Name = "ImportarAsistenciasToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem importarAsistenciasToolStripMenuItem = this.ImportarAsistenciasToolStripMenuItem;
		size = new System.Drawing.Size(249, 22);
		importarAsistenciasToolStripMenuItem.Size = size;
		this.ImportarAsistenciasToolStripMenuItem.Text = "Importar Asistencias - SEDE";
		this.ImportarAsistenciasToolStripMenuItem.Visible = false;
		this.ImportarAsistenciasPROINDToolStripMenuItem.Name = "ImportarAsistenciasPROINDToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem importarAsistenciasPROINDToolStripMenuItem = this.ImportarAsistenciasPROINDToolStripMenuItem;
		size = new System.Drawing.Size(249, 22);
		importarAsistenciasPROINDToolStripMenuItem.Size = size;
		this.ImportarAsistenciasPROINDToolStripMenuItem.Text = "Importar Asistencias - PROIND";
		this.ImportarAsistenciasPROINDToolStripMenuItem.Visible = false;
		this.ImportarAsistenciasCONSEJOToolStripMenuItem.Name = "ImportarAsistenciasCONSEJOToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem importarAsistenciasCONSEJOToolStripMenuItem = this.ImportarAsistenciasCONSEJOToolStripMenuItem;
		size = new System.Drawing.Size(249, 22);
		importarAsistenciasCONSEJOToolStripMenuItem.Size = size;
		this.ImportarAsistenciasCONSEJOToolStripMenuItem.Text = "Importar Asistencias - CONSEJO";
		this.ImportarAsistenciasCONSEJOToolStripMenuItem.Visible = false;
		this.ImportacionBiometricoToolStripMenuItem.Name = "ImportacionBiometricoToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem importacionBiometricoToolStripMenuItem = this.ImportacionBiometricoToolStripMenuItem;
		size = new System.Drawing.Size(249, 22);
		importacionBiometricoToolStripMenuItem.Size = size;
		this.ImportacionBiometricoToolStripMenuItem.Text = "Importacion Biometrico";
		this.ImportacionAsistenciasNOSEDEToolStripMenuItem.Name = "ImportacionAsistenciasNOSEDEToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem importacionAsistenciasNOSEDEToolStripMenuItem = this.ImportacionAsistenciasNOSEDEToolStripMenuItem;
		size = new System.Drawing.Size(249, 22);
		importacionAsistenciasNOSEDEToolStripMenuItem.Size = size;
		this.ImportacionAsistenciasNOSEDEToolStripMenuItem.Text = "Importacion Asistencias - OTROS";
		this.MantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[13]
		{
			this.ListaPersonalToolStripMenuItem, this.CumpleañosToolStripMenuItem, this.PersonalPorOficinaToolStripMenuItem, this.PersonalPorFechaDeIngresoToolStripMenuItem, this.CargosToolStripMenuItem1, this.AsistenciasToolStripMenuItem, this.FaltasToolStripMenuItem, this.PermisosToolStripMenuItem, this.AsistenciaDiaToolStripMenuItem, this.RecordAsistenciasSemanalesToolStripMenuItem,
			this.PersonalPorProfesionToolStripMenuItem, this.AsistenciaDiaSeleccionToolStripMenuItem, this.EstadisticoPermisosToolStripMenuItem
		});
		this.MantenimientosToolStripMenuItem.Name = "MantenimientosToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem2 = this.MantenimientosToolStripMenuItem;
		size = new System.Drawing.Size(65, 20);
		mantenimientosToolStripMenuItem2.Size = size;
		this.MantenimientosToolStripMenuItem.Text = "&Reportes";
		this.ListaPersonalToolStripMenuItem.Name = "ListaPersonalToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem listaPersonalToolStripMenuItem = this.ListaPersonalToolStripMenuItem;
		size = new System.Drawing.Size(232, 22);
		listaPersonalToolStripMenuItem.Size = size;
		this.ListaPersonalToolStripMenuItem.Text = "Lista &Personal";
		this.CumpleañosToolStripMenuItem.Name = "CumpleañosToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem cumpleañosToolStripMenuItem = this.CumpleañosToolStripMenuItem;
		size = new System.Drawing.Size(232, 22);
		cumpleañosToolStripMenuItem.Size = size;
		this.CumpleañosToolStripMenuItem.Text = "&Cumpleaños";
		this.PersonalPorOficinaToolStripMenuItem.Name = "PersonalPorOficinaToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem personalPorOficinaToolStripMenuItem = this.PersonalPorOficinaToolStripMenuItem;
		size = new System.Drawing.Size(232, 22);
		personalPorOficinaToolStripMenuItem.Size = size;
		this.PersonalPorOficinaToolStripMenuItem.Text = "Personal por &Oficina";
		this.PersonalPorFechaDeIngresoToolStripMenuItem.Name = "PersonalPorFechaDeIngresoToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem personalPorFechaDeIngresoToolStripMenuItem = this.PersonalPorFechaDeIngresoToolStripMenuItem;
		size = new System.Drawing.Size(232, 22);
		personalPorFechaDeIngresoToolStripMenuItem.Size = size;
		this.PersonalPorFechaDeIngresoToolStripMenuItem.Text = "Personal por &Fecha de Ingreso";
		this.CargosToolStripMenuItem1.Name = "CargosToolStripMenuItem1";
		System.Windows.Forms.ToolStripMenuItem cargosToolStripMenuItem2 = this.CargosToolStripMenuItem1;
		size = new System.Drawing.Size(232, 22);
		cargosToolStripMenuItem2.Size = size;
		this.CargosToolStripMenuItem1.Text = "Personal por &Cargos";
		this.AsistenciasToolStripMenuItem.Name = "AsistenciasToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem asistenciasToolStripMenuItem = this.AsistenciasToolStripMenuItem;
		size = new System.Drawing.Size(232, 22);
		asistenciasToolStripMenuItem.Size = size;
		this.AsistenciasToolStripMenuItem.Text = "Planilla Asistencias";
		this.FaltasToolStripMenuItem.Name = "FaltasToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem faltasToolStripMenuItem = this.FaltasToolStripMenuItem;
		size = new System.Drawing.Size(232, 22);
		faltasToolStripMenuItem.Size = size;
		this.FaltasToolStripMenuItem.Text = "Faltas";
		this.PermisosToolStripMenuItem.Name = "PermisosToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem permisosToolStripMenuItem = this.PermisosToolStripMenuItem;
		size = new System.Drawing.Size(232, 22);
		permisosToolStripMenuItem.Size = size;
		this.PermisosToolStripMenuItem.Text = "Permisos";
		this.AsistenciaDiaToolStripMenuItem.Name = "AsistenciaDiaToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem asistenciaDiaToolStripMenuItem = this.AsistenciaDiaToolStripMenuItem;
		size = new System.Drawing.Size(232, 22);
		asistenciaDiaToolStripMenuItem.Size = size;
		this.AsistenciaDiaToolStripMenuItem.Text = "Asistencia Dia";
		this.RecordAsistenciasSemanalesToolStripMenuItem.Name = "RecordAsistenciasSemanalesToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem recordAsistenciasSemanalesToolStripMenuItem = this.RecordAsistenciasSemanalesToolStripMenuItem;
		size = new System.Drawing.Size(232, 22);
		recordAsistenciasSemanalesToolStripMenuItem.Size = size;
		this.RecordAsistenciasSemanalesToolStripMenuItem.Text = "Record Asistencias Semanales";
		this.PersonalPorProfesionToolStripMenuItem.Name = "PersonalPorProfesionToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem personalPorProfesionToolStripMenuItem = this.PersonalPorProfesionToolStripMenuItem;
		size = new System.Drawing.Size(232, 22);
		personalPorProfesionToolStripMenuItem.Size = size;
		this.PersonalPorProfesionToolStripMenuItem.Text = "Personal por Profesion";
		this.AsistenciaDiaSeleccionToolStripMenuItem.Name = "AsistenciaDiaSeleccionToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem asistenciaDiaSeleccionToolStripMenuItem = this.AsistenciaDiaSeleccionToolStripMenuItem;
		size = new System.Drawing.Size(232, 22);
		asistenciaDiaSeleccionToolStripMenuItem.Size = size;
		this.AsistenciaDiaSeleccionToolStripMenuItem.Text = "Asistencia Dia - Seleccion";
		this.AyudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.AyudaToolStripMenuItem1, this.ToolStripSeparator2, this.AcercaDeToolStripMenuItem });
		this.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem = this.AyudaToolStripMenuItem;
		size = new System.Drawing.Size(53, 20);
		ayudaToolStripMenuItem.Size = size;
		this.AyudaToolStripMenuItem.Text = "&Ayuda";
		this.AyudaToolStripMenuItem1.Image = RecursosHumanos.My.Resources.Resources.help2;
		this.AyudaToolStripMenuItem1.Name = "AyudaToolStripMenuItem1";
		System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem2 = this.AyudaToolStripMenuItem1;
		size = new System.Drawing.Size(135, 22);
		ayudaToolStripMenuItem2.Size = size;
		this.AyudaToolStripMenuItem1.Text = "Ayuda";
		this.ToolStripSeparator2.Name = "ToolStripSeparator2";
		System.Windows.Forms.ToolStripSeparator toolStripSeparator2 = this.ToolStripSeparator2;
		size = new System.Drawing.Size(132, 6);
		toolStripSeparator2.Size = size;
		this.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem = this.AcercaDeToolStripMenuItem;
		size = new System.Drawing.Size(135, 22);
		acercaDeToolStripMenuItem.Size = size;
		this.AcercaDeToolStripMenuItem.Text = "Acerca de...";
		this.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem = this.SalirToolStripMenuItem;
		size = new System.Drawing.Size(41, 20);
		salirToolStripMenuItem.Size = size;
		this.SalirToolStripMenuItem.Text = "&Salir";
		this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.ToolStripStatusLabel1, this.TSSL_Usuario });
		System.Windows.Forms.StatusStrip statusStrip = this.StatusStrip1;
		location = new System.Drawing.Point(0, 452);
		statusStrip.Location = location;
		this.StatusStrip1.Name = "StatusStrip1";
		System.Windows.Forms.StatusStrip statusStrip2 = this.StatusStrip1;
		size = new System.Drawing.Size(683, 22);
		statusStrip2.Size = size;
		this.StatusStrip1.TabIndex = 2;
		this.StatusStrip1.Text = "StatusStrip1";
		this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
		System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel = this.ToolStripStatusLabel1;
		size = new System.Drawing.Size(50, 17);
		toolStripStatusLabel.Size = size;
		this.ToolStripStatusLabel1.Text = "Usuario:";
		this.TSSL_Usuario.Name = "TSSL_Usuario";
		System.Windows.Forms.ToolStripStatusLabel tSSL_Usuario = this.TSSL_Usuario;
		size = new System.Drawing.Size(0, 17);
		tSSL_Usuario.Size = size;
		this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[11]
		{
			this.ToolStripButton1, this.ToolStripButton2, this.ToolStripSeparator3, this.ToolStripButton5, this.ToolStripButton6, this.ToolStripSeparator5, this.ToolStripButton7, this.ToolStripButton10, this.ToolStripSeparator4, this.ToolStripButton4,
			this.ToolStripButton3
		});
		System.Windows.Forms.ToolStrip toolStrip = this.ToolStrip1;
		location = new System.Drawing.Point(0, 24);
		toolStrip.Location = location;
		this.ToolStrip1.Name = "ToolStrip1";
		System.Windows.Forms.ToolStrip toolStrip2 = this.ToolStrip1;
		size = new System.Drawing.Size(683, 25);
		toolStrip2.Size = size;
		this.ToolStrip1.TabIndex = 3;
		this.ToolStrip1.Text = "ToolStrip1";
		this.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.ToolStripButton1.Image = RecursosHumanos.My.Resources.Resources.yast_sysadmin;
		this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.ToolStripButton1.Name = "ToolStripButton1";
		System.Windows.Forms.ToolStripButton toolStripButton = this.ToolStripButton1;
		size = new System.Drawing.Size(23, 22);
		toolStripButton.Size = size;
		this.ToolStripButton1.Text = "Relacion de Personal";
		this.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.ToolStripButton2.Image = RecursosHumanos.My.Resources.Resources.view1;
		this.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.ToolStripButton2.Name = "ToolStripButton2";
		System.Windows.Forms.ToolStripButton toolStripButton2 = this.ToolStripButton2;
		size = new System.Drawing.Size(23, 22);
		toolStripButton2.Size = size;
		this.ToolStripButton2.Text = "Busqueda de Personal";
		this.ToolStripSeparator3.Name = "ToolStripSeparator3";
		System.Windows.Forms.ToolStripSeparator toolStripSeparator3 = this.ToolStripSeparator3;
		size = new System.Drawing.Size(6, 25);
		toolStripSeparator3.Size = size;
		this.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.ToolStripButton5.Image = RecursosHumanos.My.Resources.Resources.form_yellow;
		this.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.ToolStripButton5.Name = "ToolStripButton5";
		System.Windows.Forms.ToolStripButton toolStripButton3 = this.ToolStripButton5;
		size = new System.Drawing.Size(23, 22);
		toolStripButton3.Size = size;
		this.ToolStripButton5.Text = "Reporte Asistencias";
		this.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.ToolStripButton6.Image = RecursosHumanos.My.Resources.Resources.hourglass_go;
		this.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.ToolStripButton6.Name = "ToolStripButton6";
		System.Windows.Forms.ToolStripButton toolStripButton4 = this.ToolStripButton6;
		size = new System.Drawing.Size(23, 22);
		toolStripButton4.Size = size;
		this.ToolStripButton6.Text = "Ver Sobretiempo";
		this.ToolStripSeparator5.Name = "ToolStripSeparator5";
		System.Windows.Forms.ToolStripSeparator toolStripSeparator4 = this.ToolStripSeparator5;
		size = new System.Drawing.Size(6, 25);
		toolStripSeparator4.Size = size;
		this.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.ToolStripButton7.Image = RecursosHumanos.My.Resources.Resources.alarmclock;
		this.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.ToolStripButton7.Name = "ToolStripButton7";
		System.Windows.Forms.ToolStripButton toolStripButton5 = this.ToolStripButton7;
		size = new System.Drawing.Size(23, 22);
		toolStripButton5.Size = size;
		this.ToolStripButton7.Text = "Horarios";
		this.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.ToolStripButton10.Image = RecursosHumanos.My.Resources.Resources.calendar;
		this.ToolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.ToolStripButton10.Name = "ToolStripButton10";
		System.Windows.Forms.ToolStripButton toolStripButton6 = this.ToolStripButton10;
		size = new System.Drawing.Size(23, 22);
		toolStripButton6.Size = size;
		this.ToolStripButton10.Text = "Agregar Feriados";
		this.ToolStripSeparator4.Name = "ToolStripSeparator4";
		System.Windows.Forms.ToolStripSeparator toolStripSeparator5 = this.ToolStripSeparator4;
		size = new System.Drawing.Size(6, 25);
		toolStripSeparator5.Size = size;
		this.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.ToolStripButton4.Image = RecursosHumanos.My.Resources.Resources.help2;
		this.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.ToolStripButton4.Name = "ToolStripButton4";
		System.Windows.Forms.ToolStripButton toolStripButton7 = this.ToolStripButton4;
		size = new System.Drawing.Size(23, 22);
		toolStripButton7.Size = size;
		this.ToolStripButton4.Text = "Ayuda";
		this.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.ToolStripButton3.Image = RecursosHumanos.My.Resources.Resources._exit;
		this.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.ToolStripButton3.Name = "ToolStripButton3";
		System.Windows.Forms.ToolStripButton toolStripButton8 = this.ToolStripButton3;
		size = new System.Drawing.Size(23, 22);
		toolStripButton8.Size = size;
		this.ToolStripButton3.Text = "Salir";
		this.EstadisticoPermisosToolStripMenuItem.Name = "EstadisticoPermisosToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem estadisticoPermisosToolStripMenuItem = this.EstadisticoPermisosToolStripMenuItem;
		size = new System.Drawing.Size(232, 22);
		estadisticoPermisosToolStripMenuItem.Size = size;
		this.EstadisticoPermisosToolStripMenuItem.Text = "Estadistico Permisos";
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackgroundImage = RecursosHumanos.My.Resources.Resources.Back_rrhh;
		this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		size = new System.Drawing.Size(683, 474);
		this.ClientSize = size;
		this.Controls.Add(this.ToolStrip1);
		this.Controls.Add(this.StatusStrip1);
		this.Controls.Add(this.MenuStrip1);
		this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		this.IsMdiContainer = true;
		this.MainMenuStrip = this.MenuStrip1;
		this.Name = "MainMDI";
		this.Text = "Sistema Recursos Humanos";
		this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
		this.MenuStrip1.ResumeLayout(false);
		this.MenuStrip1.PerformLayout();
		this.StatusStrip1.ResumeLayout(false);
		this.StatusStrip1.PerformLayout();
		this.ToolStrip1.ResumeLayout(false);
		this.ToolStrip1.PerformLayout();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void PersonalToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (objListaOrganica == null || (objListaOrganica.IsDisposed ? true : false))
		{
			objListaOrganica = new FrmListaOrganica();
		}
		else
		{
			objListaOrganica.BringToFront();
		}
		objListaOrganica.MdiParent = this;
		objListaOrganica.WindowState = FormWindowState.Maximized;
		objListaOrganica.Show();
	}

	private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void MainMDI_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (MessageBox.Show("Esta seguro de Salir del Sistema?", "Salir Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
		{
			e.Cancel = true;
		}
	}

	private void MainMDI_Load(object sender, EventArgs e)
	{
		FrmLogin frmLogin = new FrmLogin();
		frmLogin.ShowDialog(this);
		if (frmLogin.DialogResult == DialogResult.OK)
		{
			// El nombre ya fue obtenido mediante PostgreSQL durante el login.
			TSSL_Usuario.Text = frmLogin.EmployeeDisplayName;
		}
		else
		{
			Close();
		}
		if ((RRHH.Bienestar && RRHH.Bienestar) ? true : false)
		{
			MantenimientosToolStripMenuItem1.Visible = false;
			ToolStripButton5.Visible = false;
			ToolStripButton7.Visible = false;
			ToolStripButton10.Visible = false;
			MantenimientosToolStripMenuItem.Visible = false;
			RegistroNuevoToolStripMenuItem.Visible = false;
			ToolStripSeparator1.Visible = false;
			ToolStripSeparator4.Visible = false;
			HorariosToolStripMenuItem.Visible = false;
			RecordAsistenciasSemanalesToolStripMenuItem.Visible = false;
			ImportacionToolStripMenuItem.Visible = false;
			AsignarHorariosToolStripMenuItem1.Visible = false;
			ToolStripButton6.Visible = false;
			ImportarAsistenciasPROINDToolStripMenuItem.Visible = false;
		}
		else if ((RRHH.Partida == 1) | (RRHH.Partida == 2))
		{
			ToolStripButton5.Visible = false;
			ToolStripButton7.Visible = false;
			ToolStripButton10.Visible = false;
			ToolStripSeparator4.Visible = false;
			MotivoDePermisoToolStripMenuItem.Visible = false;
			FeriadosToolStripMenuItem1.Visible = false;
			TipoDePermisoToolStripMenuItem.Visible = false;
			AsistenciaDiaToolStripMenuItem.Visible = false;
			PermisosToolStripMenuItem.Visible = false;
			FaltasToolStripMenuItem.Visible = false;
			AsistenciasToolStripMenuItem.Visible = false;
			HorariosToolStripMenuItem.Visible = false;
			RecordAsistenciasSemanalesToolStripMenuItem.Visible = false;
			ImportacionToolStripMenuItem.Visible = false;
			AsignarHorariosToolStripMenuItem1.Visible = false;
			ImportarAsistenciasPROINDToolStripMenuItem.Visible = false;
		}
		else if ((RRHH.Asistencias && RRHH.Asistencias) ? true : false)
		{
			ImportacionToolStripMenuItem.Visible = true;
			RegistroNuevoToolStripMenuItem.Visible = false;
			ToolStripSeparator1.Visible = false;
			CargosToolStripMenuItem.Visible = false;
			GruposSanguineosToolStripMenuItem.Visible = false;
			CondicionLaboralToolStripMenuItem.Visible = false;
			NacionalidadesToolStripMenuItem.Visible = false;
			RegimenDePensioneToolStripMenuItem.Visible = false;
			EstadoCivilToolStripMenuItem.Visible = false;
			TipoDeInstituciónToolStripMenuItem.Visible = false;
			TipoDeDocumentoIdentidadToolStripMenuItem.Visible = false;
			TipoEstudiosToolStripMenuItem.Visible = false;
			TipoDocFilePersonalToolStripMenuItem.Visible = false;
			CargosToolStripMenuItem1.Visible = false;
			PersonalPorFechaDeIngresoToolStripMenuItem.Visible = false;
			PersonalPorOficinaToolStripMenuItem.Visible = false;
			CumpleañosToolStripMenuItem.Visible = false;
			ListaPersonalToolStripMenuItem.Visible = false;
			RecordAsistenciasSemanalesToolStripMenuItem.Visible = true;
		}
	}

	private void ListaPersonalToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ObjFicha == null || (ObjFicha.IsDisposed ? true : false))
		{
			ObjFicha = new FrmReport_Selec_Pliego();
		}
		else
		{
			ObjFicha.BringToFront();
		}
		ObjFicha.MdiParent = this;
		ObjFicha.StartPosition = FormStartPosition.CenterParent;
		ObjFicha.Show();
	}

	private void CargosToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ObjMantCargo == null || (ObjMantCargo.IsDisposed ? true : false))
		{
			ObjMantCargo = new FrmMantCargos();
		}
		else
		{
			ObjMantCargo.BringToFront();
		}
		ObjMantCargo.MdiParent = this;
		ObjMantCargo.Show();
	}

	private void GruposSanguineosToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ObjMantGrupoSangrineo == null || (ObjMantGrupoSangrineo.IsDisposed ? true : false))
		{
			ObjMantGrupoSangrineo = new FrmMantGrupoSanguineo();
		}
		else
		{
			ObjMantGrupoSangrineo.BringToFront();
		}
		ObjMantGrupoSangrineo.MdiParent = this;
		ObjMantGrupoSangrineo.Show();
	}

	private void CondicionLaboralToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ObjMantTipoTrab == null || (ObjMantTipoTrab.IsDisposed ? true : false))
		{
			ObjMantTipoTrab = new FrmMantTipoTrab();
		}
		else
		{
			ObjMantTipoTrab.BringToFront();
		}
		ObjMantTipoTrab.MdiParent = this;
		ObjMantTipoTrab.Show();
	}

	private void RegimenDePensioneToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ObjMantRegimen == null || (ObjMantRegimen.IsDisposed ? true : false))
		{
			ObjMantRegimen = new FrmMantRegimen();
		}
		else
		{
			ObjMantRegimen.BringToFront();
		}
		ObjMantRegimen.MdiParent = this;
		ObjMantRegimen.Show();
	}

	private void NacionalidadesToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ObjMantNacionalidad == null || (ObjMantNacionalidad.IsDisposed ? true : false))
		{
			ObjMantNacionalidad = new FrmMantNacionalidades();
		}
		else
		{
			ObjMantNacionalidad.BringToFront();
		}
		ObjMantNacionalidad.MdiParent = this;
		ObjMantNacionalidad.Show();
	}

	private void EstadoCivilToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ObjMantEstCivil == null || (ObjMantEstCivil.IsDisposed ? true : false))
		{
			ObjMantEstCivil = new FrmMantEstCivil();
		}
		else
		{
			ObjMantEstCivil.BringToFront();
		}
		ObjMantEstCivil.MdiParent = this;
		ObjMantEstCivil.Show();
	}

	private void TipoDeInstituciónToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ObjMantTipoInst == null || (ObjMantTipoInst.IsDisposed ? true : false))
		{
			ObjMantTipoInst = new FrmMantTipoInst();
		}
		else
		{
			ObjMantTipoInst.BringToFront();
		}
		ObjMantTipoInst.MdiParent = this;
		ObjMantTipoInst.Show();
	}

	private void TipoDeDocumentoIdentidadToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ObjFrmMantTipoDocIdent == null || (ObjFrmMantTipoDocIdent.IsDisposed ? true : false))
		{
			ObjFrmMantTipoDocIdent = new FrmMantTipoDocIdent();
		}
		else
		{
			ObjFrmMantTipoDocIdent.BringToFront();
		}
		ObjFrmMantTipoDocIdent.MdiParent = this;
		ObjFrmMantTipoDocIdent.Show();
	}

	private void TipoEstudiosToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ObjFrmMantTipoEstudio == null || (ObjFrmMantTipoEstudio.IsDisposed ? true : false))
		{
			ObjFrmMantTipoEstudio = new FrmMantTipoEstudio();
		}
		else
		{
			ObjFrmMantTipoEstudio.BringToFront();
		}
		ObjFrmMantTipoEstudio.MdiParent = this;
		ObjFrmMantTipoEstudio.Show();
	}

	private void BusquedaToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (objFrmPersonal == null || (objFrmPersonal.IsDisposed ? true : false))
		{
			objFrmPersonal = new FrmBuscarPersona();
		}
		else
		{
			objFrmPersonal.BringToFront();
		}
		objFrmPersonal.MdiParent = this;
		objFrmPersonal.Show();
	}

	private void CumpleañosToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (objFrmReportCumplea == null || (objFrmReportCumplea.IsDisposed ? true : false))
		{
			objFrmReportCumplea = new FrmReport_SelecMes();
		}
		else
		{
			objFrmReportCumplea.BringToFront();
		}
		objFrmReportCumplea.MdiParent = this;
		objFrmReportCumplea.StartPosition = FormStartPosition.CenterParent;
		objFrmReportCumplea.Show();
	}

	private void PersonalPorOficinaToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (objFrmReportCumpleb == null || (objFrmReportCumpleb.IsDisposed ? true : false))
		{
			objFrmReportCumpleb = new FrmReport_Selc_Oficina();
		}
		else
		{
			objFrmReportCumpleb.BringToFront();
		}
		objFrmReportCumpleb.MdiParent = this;
		objFrmReportCumpleb.StartPosition = FormStartPosition.CenterParent;
		objFrmReportCumpleb.Show();
	}

	private void PersonalPorFechaDeIngresoToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (objFrmReportCumple == null || (objFrmReportCumple.IsDisposed ? true : false))
		{
			objFrmReportCumple = new FrmReport_Selec_Fechas();
		}
		else
		{
			objFrmReportCumple.BringToFront();
		}
		objFrmReportCumple.MdiParent = this;
		objFrmReportCumple.StartPosition = FormStartPosition.CenterParent;
		objFrmReportCumple.Show();
	}

	private void ToolStripButton1_Click(object sender, EventArgs e)
	{
		if (objListaOrganica == null || (objListaOrganica.IsDisposed ? true : false))
		{
			objListaOrganica = new FrmListaOrganica();
		}
		else
		{
			objListaOrganica.BringToFront();
		}
		objListaOrganica.MdiParent = this;
		objListaOrganica.WindowState = FormWindowState.Maximized;
		objListaOrganica.Show();
	}

	private void ToolStripButton2_Click(object sender, EventArgs e)
	{
		if (objFrmPersonal == null || (objFrmPersonal.IsDisposed ? true : false))
		{
			objFrmPersonal = new FrmBuscarPersona();
		}
		else
		{
			objFrmPersonal.BringToFront();
		}
		objFrmPersonal.MdiParent = this;
		objFrmPersonal.Show();
	}

	private void CargosToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (objFrmReportCargos == null || (objFrmReportCargos.IsDisposed ? true : false))
		{
			objFrmReportCargos = new FrmReport_Cargos();
		}
		else
		{
			objFrmReportCargos.BringToFront();
		}
		objFrmReportCargos.MdiParent = this;
		objFrmReportCargos.WindowState = FormWindowState.Maximized;
		objFrmReportCargos.Show();
	}

	private void ToolStripButton3_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void RegistroNuevoToolStripMenuItem_Click(object sender, EventArgs e)
	{
		FrmMantEmpleado_Basico frmMantEmpleado_Basico = new FrmMantEmpleado_Basico();
		frmMantEmpleado_Basico.ShowDialog();
	}

	private void TipoDocFilePersonalToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ObjMantFile == null || (ObjMantFile.IsDisposed ? true : false))
		{
			ObjMantFile = new FrmMantDocFile();
		}
		else
		{
			ObjMantFile.BringToFront();
		}
		ObjMantFile.MdiParent = this;
		ObjMantFile.Show();
	}

	private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (objAcercaDe == null || (objAcercaDe.IsDisposed ? true : false))
		{
			objAcercaDe = new AcercaDe();
		}
		else
		{
			objAcercaDe.BringToFront();
		}
		objAcercaDe.MdiParent = this;
		objAcercaDe.WindowState = FormWindowState.Normal;
		objAcercaDe.StartPosition = FormStartPosition.CenterParent;
		objAcercaDe.Show();
	}

	private void PermisosToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (oFrmPermiso == null || (oFrmPermiso.IsDisposed ? true : false))
		{
			oFrmPermiso = new FrmPermiso();
		}
		else
		{
			oFrmPermiso.BringToFront();
		}
		oFrmPermiso.MdiParent = this;
		oFrmPermiso.Show();
	}

	private void ToolStripButton7_Click(object sender, EventArgs e)
	{
		if (ObjHorario == null || (ObjHorario.IsDisposed ? true : false))
		{
			ObjHorario = new FrmHorarios();
		}
		else
		{
			ObjHorario.BringToFront();
		}
		ObjHorario.MdiParent = this;
		ObjHorario.Show();
	}

	private void ToolStripButton5_Click(object sender, EventArgs e)
	{
		if (ObjFrmConsultaAsistencias == null || (ObjFrmConsultaAsistencias.IsDisposed ? true : false))
		{
			ObjFrmConsultaAsistencias = new FrmConsultaAsistencias();
		}
		else
		{
			ObjFrmConsultaAsistencias.BringToFront();
		}
		ObjFrmConsultaAsistencias.MdiParent = this;
		ObjFrmConsultaAsistencias.WindowState = FormWindowState.Normal;
		ObjFrmConsultaAsistencias.Show();
	}

	private void ToolStripButton8_Click(object sender, EventArgs e)
	{
		if (ObjFrmMantTipoPerm == null || (ObjFrmMantTipoPerm.IsDisposed ? true : false))
		{
			ObjFrmMantTipoPerm = new FrmMantTipoPerm();
		}
		else
		{
			ObjFrmMantTipoPerm.BringToFront();
		}
		ObjFrmMantTipoPerm.MdiParent = this;
		ObjFrmMantTipoPerm.Show();
	}

	private void ToolStripButton9_Click(object sender, EventArgs e)
	{
		if (ObjFrmMotivoPermiso == null || (ObjFrmMotivoPermiso.IsDisposed ? true : false))
		{
			ObjFrmMotivoPermiso = new FrmMotivoPermiso();
		}
		else
		{
			ObjFrmMotivoPermiso.BringToFront();
		}
		ObjFrmMotivoPermiso.MdiParent = this;
		ObjFrmMotivoPermiso.Show();
	}

	private void ToolStripButton10_Click(object sender, EventArgs e)
	{
		if (ObjFrmFeriado == null || (ObjFrmFeriado.IsDisposed ? true : false))
		{
			ObjFrmFeriado = new FrmFeriado();
		}
		else
		{
			ObjFrmFeriado.BringToFront();
		}
		ObjFrmFeriado.MdiParent = this;
		ObjFrmFeriado.Show();
	}

	private void MotivoDePermisoToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ObjFrmMotivoPermiso == null || (ObjFrmMotivoPermiso.IsDisposed ? true : false))
		{
			ObjFrmMotivoPermiso = new FrmMotivoPermiso();
		}
		else
		{
			ObjFrmMotivoPermiso.BringToFront();
		}
		ObjFrmMotivoPermiso.MdiParent = this;
		ObjFrmMotivoPermiso.Show();
	}

	private void TipoDePermisoToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ObjFrmMantTipoPerm == null || (ObjFrmMantTipoPerm.IsDisposed ? true : false))
		{
			ObjFrmMantTipoPerm = new FrmMantTipoPerm();
		}
		else
		{
			ObjFrmMantTipoPerm.BringToFront();
		}
		ObjFrmMantTipoPerm.MdiParent = this;
		ObjFrmMantTipoPerm.Show();
	}

	private void FeriadosToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (ObjFrmFeriado == null || (ObjFrmFeriado.IsDisposed ? true : false))
		{
			ObjFrmFeriado = new FrmFeriado();
		}
		else
		{
			ObjFrmFeriado.BringToFront();
		}
		ObjFrmFeriado.MdiParent = this;
		ObjFrmFeriado.Show();
	}

	private void PermisosToolStripMenuItem_Click_1(object sender, EventArgs e)
	{
		if (oFrmRepPermisos == null || (oFrmRepPermisos.IsDisposed ? true : false))
		{
			oFrmRepPermisos = new FrmRepPermisos();
		}
		else
		{
			oFrmRepPermisos.BringToFront();
		}
		oFrmRepPermisos.MdiParent = this;
		oFrmRepPermisos.StartPosition = FormStartPosition.CenterParent;
		oFrmRepPermisos.Show();
	}

	private void FaltasToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ObjFrmConsultaFaltas == null || (ObjFrmConsultaFaltas.IsDisposed ? true : false))
		{
			ObjFrmConsultaFaltas = new FrmConsultaFaltas();
		}
		else
		{
			ObjFrmConsultaFaltas.BringToFront();
		}
		ObjFrmConsultaFaltas.MdiParent = this;
		ObjFrmConsultaFaltas.Show();
	}

	private void AsistenciasToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ObjFrmConsultaAsistencias == null || (ObjFrmConsultaAsistencias.IsDisposed ? true : false))
		{
			ObjFrmConsultaAsistencias = new FrmConsultaAsistencias();
		}
		else
		{
			ObjFrmConsultaAsistencias.BringToFront();
		}
		ObjFrmConsultaAsistencias.MdiParent = this;
		ObjFrmConsultaAsistencias.Show();
	}

	private void AsistenciaDiaToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (oFrmConsultaAsistDiaria == null || (oFrmConsultaAsistDiaria.IsDisposed ? true : false))
		{
			oFrmConsultaAsistDiaria = new FrmConsultaAsistDiaria();
			oFrmConsultaAsistDiaria.MdiParent = this;
			oFrmConsultaAsistDiaria.WindowState = FormWindowState.Normal;
			oFrmConsultaAsistDiaria.Show();
		}
		else
		{
			oFrmConsultaAsistDiaria.BringToFront();
		}
	}

	private void HorariosToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ObjHorario == null || (ObjHorario.IsDisposed ? true : false))
		{
			ObjHorario = new FrmHorarios();
		}
		else
		{
			ObjHorario.BringToFront();
		}
		ObjHorario.MdiParent = this;
		ObjHorario.Show();
	}

	private void RecordAsistenciasSemanalesToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (oFrmHorasTrabajadas == null || (oFrmHorasTrabajadas.IsDisposed ? true : false))
		{
			oFrmHorasTrabajadas = new FrmHorasTrabajadas();
		}
		else
		{
			oFrmHorasTrabajadas.BringToFront();
		}
		oFrmHorasTrabajadas.MdiParent = this;
		oFrmHorasTrabajadas.Show();
	}

	private void ImportarAsistenciasToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (oFrmImportarAsistencia == null || (oFrmImportarAsistencia.IsDisposed ? true : false))
		{
			oFrmImportarAsistencia = new FrmImportarAsistencia();
		}
		else
		{
			oFrmImportarAsistencia.BringToFront();
		}
		oFrmImportarAsistencia.MdiParent = this;
		oFrmImportarAsistencia.Show();
	}

	private void AsignarHorariosToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	private void AsignarHorariosToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (oFrmAsignarHorario == null || (oFrmAsignarHorario.IsDisposed ? true : false))
		{
			oFrmAsignarHorario = new FrmAsignarHorario();
		}
		else
		{
			oFrmAsignarHorario.BringToFront();
		}
		oFrmAsignarHorario.MdiParent = this;
		oFrmAsignarHorario.Show();
	}

	private void ImportacionAsistenciasNOSEDEToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (oFrmImportarAsistenciaFueraSEDE == null || (oFrmImportarAsistenciaFueraSEDE.IsDisposed ? true : false))
		{
			oFrmImportarAsistenciaFueraSEDE = new FrmImportarAsistenciaFueraSEDE();
		}
		else
		{
			oFrmImportarAsistenciaFueraSEDE.BringToFront();
		}
		oFrmImportarAsistenciaFueraSEDE.MdiParent = this;
		oFrmImportarAsistenciaFueraSEDE.Show();
	}

	private void ToolStripButton6_Click(object sender, EventArgs e)
	{
		if (oFrmSobreTiempo == null || (oFrmSobreTiempo.IsDisposed ? true : false))
		{
			oFrmSobreTiempo = new FrmSobreTiempo();
		}
		else
		{
			oFrmSobreTiempo.BringToFront();
		}
		oFrmSobreTiempo.MdiParent = this;
		oFrmSobreTiempo.WindowState = FormWindowState.Normal;
		oFrmSobreTiempo.Show();
	}

	private void PersonalPorProfesionToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (oFrmReporteProfesion == null || (oFrmReporteProfesion.IsDisposed ? true : false))
		{
			oFrmReporteProfesion = new FrmReporteProfesion();
		}
		else
		{
			oFrmReporteProfesion.BringToFront();
		}
		oFrmReporteProfesion.MdiParent = this;
		oFrmReporteProfesion.WindowState = FormWindowState.Normal;
		oFrmReporteProfesion.Show();
	}

	private void AsistenciaDiaSeleccionToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (oFrmRepAsistenciaDia == null || (oFrmRepAsistenciaDia.IsDisposed ? true : false))
		{
			oFrmRepAsistenciaDia = new FrmRepAsistenciaDia();
		}
		else
		{
			oFrmRepAsistenciaDia.BringToFront();
		}
		oFrmRepAsistenciaDia.MdiParent = this;
		oFrmRepAsistenciaDia.WindowState = FormWindowState.Normal;
		oFrmRepAsistenciaDia.Show();
	}

	private void ImportarAsistenciasPROINDToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (oFrmImportarAsistenciaPROIND == null || (oFrmImportarAsistenciaPROIND.IsDisposed ? true : false))
		{
			oFrmImportarAsistenciaPROIND = new FrmImportarAsistenciaPROIND();
		}
		else
		{
			oFrmImportarAsistenciaPROIND.BringToFront();
		}
		oFrmImportarAsistenciaPROIND.MdiParent = this;
		oFrmImportarAsistenciaPROIND.Show();
	}

	private void AsignarLocalToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (oFrmLocalAsignado == null || (oFrmLocalAsignado.IsDisposed ? true : false))
		{
			oFrmLocalAsignado = new FrmLocalAsignado();
		}
		else
		{
			oFrmLocalAsignado.BringToFront();
		}
		oFrmLocalAsignado.MdiParent = this;
		oFrmLocalAsignado.Show();
	}

	private void ImportarAsistenciasCONSEJOToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (oFrmImportarAsistenciaCONSEJO == null || (oFrmImportarAsistenciaCONSEJO.IsDisposed ? true : false))
		{
			oFrmImportarAsistenciaCONSEJO = new FrmImportarAsistenciaCONSEJO();
		}
		else
		{
			oFrmImportarAsistenciaCONSEJO.BringToFront();
		}
		oFrmImportarAsistenciaCONSEJO.MdiParent = this;
		oFrmImportarAsistenciaCONSEJO.Show();
	}

	private void ImportacionBiometricoToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (oFrmImportarAsistenciaBio == null || (oFrmImportarAsistenciaBio.IsDisposed ? true : false))
		{
			oFrmImportarAsistenciaBio = new FrmImportarAsistenciaBio();
		}
		else
		{
			oFrmImportarAsistenciaBio.BringToFront();
		}
		oFrmImportarAsistenciaBio.MdiParent = this;
		oFrmImportarAsistenciaBio.Show();
	}

	private void EstadisticoPermisosToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (oFrmReporteEstadistico == null || (oFrmReporteEstadistico.IsDisposed ? true : false))
		{
			oFrmReporteEstadistico = new FrmReporteEstadistico();
		}
		else
		{
			oFrmReporteEstadistico.BringToFront();
		}
		oFrmReporteEstadistico.MdiParent = this;
		oFrmReporteEstadistico.Show();
	}
}
