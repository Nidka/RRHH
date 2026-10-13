using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace RecursosHumanos.My;

[HideModuleName]
[StandardModule]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class MyProject
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class MyForms
	{
		public AcercaDe m_AcercaDe;

		public FrmAsignarHorario m_FrmAsignarHorario;

		public FrmAsignarHorario_Lector m_FrmAsignarHorario_Lector;

		public FrmAsistenciaManual m_FrmAsistenciaManual;

		public FrmBuscarDerechohabiente m_FrmBuscarDerechohabiente;

		public FrmBuscarPersona m_FrmBuscarPersona;

		public FrmCapacitaciones m_FrmCapacitaciones;

		public FrmConsultaAsistDiaria m_FrmConsultaAsistDiaria;

		public FrmConsultaAsistencias m_FrmConsultaAsistencias;

		public FrmConsultaFaltas m_FrmConsultaFaltas;

		public FrmConsultaHorarioEsp m_FrmConsultaHorarioEsp;

		public FrmConsultaPermisos m_FrmConsultaPermisos;

		public FrmDisciplina m_FrmDisciplina;

		public FrmDocumentos m_FrmDocumentos;

		public FrmEstudiosRealizados m_FrmEstudiosRealizados;

		public FrmExpLaboral m_FrmExpLaboral;

		public FrmFamiliar m_FrmFamiliar;

		public FrmFeriado m_FrmFeriado;

		public FrmFichaSocial m_FrmFichaSocial;

		public FrmHorarioEsp m_FrmHorarioEsp;

		public FrmHorarios m_FrmHorarios;

		public FrmHorasTrabajadas m_FrmHorasTrabajadas;

		public FrmImportarAsistencia m_FrmImportarAsistencia;

		public FrmImportarAsistenciaBio m_FrmImportarAsistenciaBio;

		public FrmImportarAsistenciaCONSEJO m_FrmImportarAsistenciaCONSEJO;

		public FrmImportarAsistenciaFueraSEDE m_FrmImportarAsistenciaFueraSEDE;

		public FrmImportarAsistenciaPROIND m_FrmImportarAsistenciaPROIND;

		public FrmListaArchivos m_FrmListaArchivos;

		public FrmListaOrganica m_FrmListaOrganica;

		public FrmLocalAsignado m_FrmLocalAsignado;

		public FrmLogin m_FrmLogin;

		public FrmMantCargos m_FrmMantCargos;

		public FrmMantDocFile m_FrmMantDocFile;

		public FrmMantEmpleado_Basico m_FrmMantEmpleado_Basico;

		public FrmMantEstCivil m_FrmMantEstCivil;

		public FrmMantGrupoSanguineo m_FrmMantGrupoSanguineo;

		public FrmMantHorarios m_FrmMantHorarios;

		public FrmMantMotivo m_FrmMantMotivo;

		public FrmMantNacionalidades m_FrmMantNacionalidades;

		public FrmMantRegimen m_FrmMantRegimen;

		public FrmMantTipoDocIdent m_FrmMantTipoDocIdent;

		public FrmMantTipoEstudio m_FrmMantTipoEstudio;

		public FrmMantTipoInst m_FrmMantTipoInst;

		public FrmMantTipoPerm m_FrmMantTipoPerm;

		public FrmMantTipoTrab m_FrmMantTipoTrab;

		public FrmMarcacionesAutorizadas m_FrmMarcacionesAutorizadas;

		public FrmMotivoPermiso m_FrmMotivoPermiso;

		public FrmNuevaFicha m_FrmNuevaFicha;

		public FrmPeriodoLaboral m_FrmPeriodoLaboral;

		public FrmPermiso m_FrmPermiso;

		public FrmRegistroAsegurado m_FrmRegistroAsegurado;

		public FrmRelacionSalidaAutorizada m_FrmRelacionSalidaAutorizada;

		public FrmRepAsistenciaDia m_FrmRepAsistenciaDia;

		public FrmRepFaltas m_FrmRepFaltas;

		public FrmReport_Cargos m_FrmReport_Cargos;

		public FrmReport_Empleado_Ingre m_FrmReport_Empleado_Ingre;

		public FrmReport_Selc_Oficina m_FrmReport_Selc_Oficina;

		public FrmReport_Selec_Fechas m_FrmReport_Selec_Fechas;

		public FrmReport_Selec_Oficina m_FrmReport_Selec_Oficina;

		public FrmReport_Selec_Pliego m_FrmReport_Selec_Pliego;

		public FrmReport_SelecMes m_FrmReport_SelecMes;

		public FrmReportCuadro m_FrmReportCuadro;

		public FrmReportCumple m_FrmReportCumple;

		public FrmReporteEstadistico m_FrmReporteEstadistico;

		public FrmReporteProfesion m_FrmReporteProfesion;

		public FrmReportFicha m_FrmReportFicha;

		public FrmRepPermisoDispl m_FrmRepPermisoDispl;

		public FrmRepPermisos m_FrmRepPermisos;

		public FrmResoluciones m_FrmResoluciones;

		public FrmRotaciones m_FrmRotaciones;

		public FrmSalida m_FrmSalida;

		public FrmSobreTiempo m_FrmSobreTiempo;

		public FrmSuspenderAsistencia m_FrmSuspenderAsistencia;

		public FrmTitulos m_FrmTitulos;

		public MainMDI m_MainMDI;

		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		public AcercaDe AcercaDe
		{
			[DebuggerNonUserCode]
			get
			{
				m_AcercaDe = Create__Instance__(m_AcercaDe);
				return m_AcercaDe;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_AcercaDe)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_AcercaDe);
				}
			}
		}

		public FrmAsignarHorario FrmAsignarHorario
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmAsignarHorario = Create__Instance__(m_FrmAsignarHorario);
				return m_FrmAsignarHorario;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmAsignarHorario)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmAsignarHorario);
				}
			}
		}

		public FrmAsignarHorario_Lector FrmAsignarHorario_Lector
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmAsignarHorario_Lector = Create__Instance__(m_FrmAsignarHorario_Lector);
				return m_FrmAsignarHorario_Lector;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmAsignarHorario_Lector)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmAsignarHorario_Lector);
				}
			}
		}

		public FrmAsistenciaManual FrmAsistenciaManual
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmAsistenciaManual = Create__Instance__(m_FrmAsistenciaManual);
				return m_FrmAsistenciaManual;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmAsistenciaManual)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmAsistenciaManual);
				}
			}
		}

		public FrmBuscarDerechohabiente FrmBuscarDerechohabiente
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmBuscarDerechohabiente = Create__Instance__(m_FrmBuscarDerechohabiente);
				return m_FrmBuscarDerechohabiente;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmBuscarDerechohabiente)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmBuscarDerechohabiente);
				}
			}
		}

		public FrmBuscarPersona FrmBuscarPersona
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmBuscarPersona = Create__Instance__(m_FrmBuscarPersona);
				return m_FrmBuscarPersona;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmBuscarPersona)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmBuscarPersona);
				}
			}
		}

		public FrmCapacitaciones FrmCapacitaciones
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmCapacitaciones = Create__Instance__(m_FrmCapacitaciones);
				return m_FrmCapacitaciones;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmCapacitaciones)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmCapacitaciones);
				}
			}
		}

		public FrmConsultaAsistDiaria FrmConsultaAsistDiaria
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmConsultaAsistDiaria = Create__Instance__(m_FrmConsultaAsistDiaria);
				return m_FrmConsultaAsistDiaria;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmConsultaAsistDiaria)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmConsultaAsistDiaria);
				}
			}
		}

		public FrmConsultaAsistencias FrmConsultaAsistencias
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmConsultaAsistencias = Create__Instance__(m_FrmConsultaAsistencias);
				return m_FrmConsultaAsistencias;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmConsultaAsistencias)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmConsultaAsistencias);
				}
			}
		}

		public FrmConsultaFaltas FrmConsultaFaltas
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmConsultaFaltas = Create__Instance__(m_FrmConsultaFaltas);
				return m_FrmConsultaFaltas;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmConsultaFaltas)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmConsultaFaltas);
				}
			}
		}

		public FrmConsultaHorarioEsp FrmConsultaHorarioEsp
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmConsultaHorarioEsp = Create__Instance__(m_FrmConsultaHorarioEsp);
				return m_FrmConsultaHorarioEsp;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmConsultaHorarioEsp)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmConsultaHorarioEsp);
				}
			}
		}

		public FrmConsultaPermisos FrmConsultaPermisos
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmConsultaPermisos = Create__Instance__(m_FrmConsultaPermisos);
				return m_FrmConsultaPermisos;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmConsultaPermisos)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmConsultaPermisos);
				}
			}
		}

		public FrmDisciplina FrmDisciplina
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmDisciplina = Create__Instance__(m_FrmDisciplina);
				return m_FrmDisciplina;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmDisciplina)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmDisciplina);
				}
			}
		}

		public FrmDocumentos FrmDocumentos
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmDocumentos = Create__Instance__(m_FrmDocumentos);
				return m_FrmDocumentos;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmDocumentos)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmDocumentos);
				}
			}
		}

		public FrmEstudiosRealizados FrmEstudiosRealizados
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmEstudiosRealizados = Create__Instance__(m_FrmEstudiosRealizados);
				return m_FrmEstudiosRealizados;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmEstudiosRealizados)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmEstudiosRealizados);
				}
			}
		}

		public FrmExpLaboral FrmExpLaboral
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmExpLaboral = Create__Instance__(m_FrmExpLaboral);
				return m_FrmExpLaboral;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmExpLaboral)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmExpLaboral);
				}
			}
		}

		public FrmFamiliar FrmFamiliar
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmFamiliar = Create__Instance__(m_FrmFamiliar);
				return m_FrmFamiliar;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmFamiliar)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmFamiliar);
				}
			}
		}

		public FrmFeriado FrmFeriado
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmFeriado = Create__Instance__(m_FrmFeriado);
				return m_FrmFeriado;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmFeriado)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmFeriado);
				}
			}
		}

		public FrmFichaSocial FrmFichaSocial
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmFichaSocial = Create__Instance__(m_FrmFichaSocial);
				return m_FrmFichaSocial;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmFichaSocial)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmFichaSocial);
				}
			}
		}

		public FrmHorarioEsp FrmHorarioEsp
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmHorarioEsp = Create__Instance__(m_FrmHorarioEsp);
				return m_FrmHorarioEsp;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmHorarioEsp)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmHorarioEsp);
				}
			}
		}

		public FrmHorarios FrmHorarios
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmHorarios = Create__Instance__(m_FrmHorarios);
				return m_FrmHorarios;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmHorarios)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmHorarios);
				}
			}
		}

		public FrmHorasTrabajadas FrmHorasTrabajadas
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmHorasTrabajadas = Create__Instance__(m_FrmHorasTrabajadas);
				return m_FrmHorasTrabajadas;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmHorasTrabajadas)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmHorasTrabajadas);
				}
			}
		}

		public FrmImportarAsistencia FrmImportarAsistencia
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmImportarAsistencia = Create__Instance__(m_FrmImportarAsistencia);
				return m_FrmImportarAsistencia;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmImportarAsistencia)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmImportarAsistencia);
				}
			}
		}

		public FrmImportarAsistenciaBio FrmImportarAsistenciaBio
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmImportarAsistenciaBio = Create__Instance__(m_FrmImportarAsistenciaBio);
				return m_FrmImportarAsistenciaBio;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmImportarAsistenciaBio)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmImportarAsistenciaBio);
				}
			}
		}

		public FrmImportarAsistenciaCONSEJO FrmImportarAsistenciaCONSEJO
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmImportarAsistenciaCONSEJO = Create__Instance__(m_FrmImportarAsistenciaCONSEJO);
				return m_FrmImportarAsistenciaCONSEJO;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmImportarAsistenciaCONSEJO)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmImportarAsistenciaCONSEJO);
				}
			}
		}

		public FrmImportarAsistenciaFueraSEDE FrmImportarAsistenciaFueraSEDE
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmImportarAsistenciaFueraSEDE = Create__Instance__(m_FrmImportarAsistenciaFueraSEDE);
				return m_FrmImportarAsistenciaFueraSEDE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmImportarAsistenciaFueraSEDE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmImportarAsistenciaFueraSEDE);
				}
			}
		}

		public FrmImportarAsistenciaPROIND FrmImportarAsistenciaPROIND
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmImportarAsistenciaPROIND = Create__Instance__(m_FrmImportarAsistenciaPROIND);
				return m_FrmImportarAsistenciaPROIND;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmImportarAsistenciaPROIND)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmImportarAsistenciaPROIND);
				}
			}
		}

		public FrmListaArchivos FrmListaArchivos
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmListaArchivos = Create__Instance__(m_FrmListaArchivos);
				return m_FrmListaArchivos;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmListaArchivos)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmListaArchivos);
				}
			}
		}

		public FrmListaOrganica FrmListaOrganica
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmListaOrganica = Create__Instance__(m_FrmListaOrganica);
				return m_FrmListaOrganica;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmListaOrganica)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmListaOrganica);
				}
			}
		}

		public FrmLocalAsignado FrmLocalAsignado
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmLocalAsignado = Create__Instance__(m_FrmLocalAsignado);
				return m_FrmLocalAsignado;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmLocalAsignado)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmLocalAsignado);
				}
			}
		}

		public FrmLogin FrmLogin
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmLogin = Create__Instance__(m_FrmLogin);
				return m_FrmLogin;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmLogin)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmLogin);
				}
			}
		}

		public FrmMantCargos FrmMantCargos
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmMantCargos = Create__Instance__(m_FrmMantCargos);
				return m_FrmMantCargos;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmMantCargos)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmMantCargos);
				}
			}
		}

		public FrmMantDocFile FrmMantDocFile
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmMantDocFile = Create__Instance__(m_FrmMantDocFile);
				return m_FrmMantDocFile;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmMantDocFile)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmMantDocFile);
				}
			}
		}

		public FrmMantEmpleado_Basico FrmMantEmpleado_Basico
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmMantEmpleado_Basico = Create__Instance__(m_FrmMantEmpleado_Basico);
				return m_FrmMantEmpleado_Basico;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmMantEmpleado_Basico)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmMantEmpleado_Basico);
				}
			}
		}

		public FrmMantEstCivil FrmMantEstCivil
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmMantEstCivil = Create__Instance__(m_FrmMantEstCivil);
				return m_FrmMantEstCivil;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmMantEstCivil)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmMantEstCivil);
				}
			}
		}

		public FrmMantGrupoSanguineo FrmMantGrupoSanguineo
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmMantGrupoSanguineo = Create__Instance__(m_FrmMantGrupoSanguineo);
				return m_FrmMantGrupoSanguineo;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmMantGrupoSanguineo)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmMantGrupoSanguineo);
				}
			}
		}

		public FrmMantHorarios FrmMantHorarios
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmMantHorarios = Create__Instance__(m_FrmMantHorarios);
				return m_FrmMantHorarios;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmMantHorarios)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmMantHorarios);
				}
			}
		}

		public FrmMantMotivo FrmMantMotivo
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmMantMotivo = Create__Instance__(m_FrmMantMotivo);
				return m_FrmMantMotivo;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmMantMotivo)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmMantMotivo);
				}
			}
		}

		public FrmMantNacionalidades FrmMantNacionalidades
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmMantNacionalidades = Create__Instance__(m_FrmMantNacionalidades);
				return m_FrmMantNacionalidades;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmMantNacionalidades)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmMantNacionalidades);
				}
			}
		}

		public FrmMantRegimen FrmMantRegimen
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmMantRegimen = Create__Instance__(m_FrmMantRegimen);
				return m_FrmMantRegimen;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmMantRegimen)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmMantRegimen);
				}
			}
		}

		public FrmMantTipoDocIdent FrmMantTipoDocIdent
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmMantTipoDocIdent = Create__Instance__(m_FrmMantTipoDocIdent);
				return m_FrmMantTipoDocIdent;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmMantTipoDocIdent)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmMantTipoDocIdent);
				}
			}
		}

		public FrmMantTipoEstudio FrmMantTipoEstudio
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmMantTipoEstudio = Create__Instance__(m_FrmMantTipoEstudio);
				return m_FrmMantTipoEstudio;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmMantTipoEstudio)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmMantTipoEstudio);
				}
			}
		}

		public FrmMantTipoInst FrmMantTipoInst
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmMantTipoInst = Create__Instance__(m_FrmMantTipoInst);
				return m_FrmMantTipoInst;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmMantTipoInst)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmMantTipoInst);
				}
			}
		}

		public FrmMantTipoPerm FrmMantTipoPerm
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmMantTipoPerm = Create__Instance__(m_FrmMantTipoPerm);
				return m_FrmMantTipoPerm;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmMantTipoPerm)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmMantTipoPerm);
				}
			}
		}

		public FrmMantTipoTrab FrmMantTipoTrab
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmMantTipoTrab = Create__Instance__(m_FrmMantTipoTrab);
				return m_FrmMantTipoTrab;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmMantTipoTrab)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmMantTipoTrab);
				}
			}
		}

		public FrmMarcacionesAutorizadas FrmMarcacionesAutorizadas
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmMarcacionesAutorizadas = Create__Instance__(m_FrmMarcacionesAutorizadas);
				return m_FrmMarcacionesAutorizadas;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmMarcacionesAutorizadas)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmMarcacionesAutorizadas);
				}
			}
		}

		public FrmMotivoPermiso FrmMotivoPermiso
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmMotivoPermiso = Create__Instance__(m_FrmMotivoPermiso);
				return m_FrmMotivoPermiso;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmMotivoPermiso)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmMotivoPermiso);
				}
			}
		}

		public FrmNuevaFicha FrmNuevaFicha
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmNuevaFicha = Create__Instance__(m_FrmNuevaFicha);
				return m_FrmNuevaFicha;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmNuevaFicha)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmNuevaFicha);
				}
			}
		}

		public FrmPeriodoLaboral FrmPeriodoLaboral
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmPeriodoLaboral = Create__Instance__(m_FrmPeriodoLaboral);
				return m_FrmPeriodoLaboral;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmPeriodoLaboral)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmPeriodoLaboral);
				}
			}
		}

		public FrmPermiso FrmPermiso
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmPermiso = Create__Instance__(m_FrmPermiso);
				return m_FrmPermiso;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmPermiso)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmPermiso);
				}
			}
		}

		public FrmRegistroAsegurado FrmRegistroAsegurado
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmRegistroAsegurado = Create__Instance__(m_FrmRegistroAsegurado);
				return m_FrmRegistroAsegurado;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmRegistroAsegurado)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmRegistroAsegurado);
				}
			}
		}

		public FrmRelacionSalidaAutorizada FrmRelacionSalidaAutorizada
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmRelacionSalidaAutorizada = Create__Instance__(m_FrmRelacionSalidaAutorizada);
				return m_FrmRelacionSalidaAutorizada;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmRelacionSalidaAutorizada)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmRelacionSalidaAutorizada);
				}
			}
		}

		public FrmRepAsistenciaDia FrmRepAsistenciaDia
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmRepAsistenciaDia = Create__Instance__(m_FrmRepAsistenciaDia);
				return m_FrmRepAsistenciaDia;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmRepAsistenciaDia)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmRepAsistenciaDia);
				}
			}
		}

		public FrmRepFaltas FrmRepFaltas
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmRepFaltas = Create__Instance__(m_FrmRepFaltas);
				return m_FrmRepFaltas;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmRepFaltas)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmRepFaltas);
				}
			}
		}

		public FrmReport_Cargos FrmReport_Cargos
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmReport_Cargos = Create__Instance__(m_FrmReport_Cargos);
				return m_FrmReport_Cargos;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmReport_Cargos)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmReport_Cargos);
				}
			}
		}

		public FrmReport_Empleado_Ingre FrmReport_Empleado_Ingre
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmReport_Empleado_Ingre = Create__Instance__(m_FrmReport_Empleado_Ingre);
				return m_FrmReport_Empleado_Ingre;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmReport_Empleado_Ingre)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmReport_Empleado_Ingre);
				}
			}
		}

		public FrmReport_Selc_Oficina FrmReport_Selc_Oficina
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmReport_Selc_Oficina = Create__Instance__(m_FrmReport_Selc_Oficina);
				return m_FrmReport_Selc_Oficina;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmReport_Selc_Oficina)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmReport_Selc_Oficina);
				}
			}
		}

		public FrmReport_Selec_Fechas FrmReport_Selec_Fechas
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmReport_Selec_Fechas = Create__Instance__(m_FrmReport_Selec_Fechas);
				return m_FrmReport_Selec_Fechas;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmReport_Selec_Fechas)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmReport_Selec_Fechas);
				}
			}
		}

		public FrmReport_Selec_Oficina FrmReport_Selec_Oficina
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmReport_Selec_Oficina = Create__Instance__(m_FrmReport_Selec_Oficina);
				return m_FrmReport_Selec_Oficina;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmReport_Selec_Oficina)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmReport_Selec_Oficina);
				}
			}
		}

		public FrmReport_Selec_Pliego FrmReport_Selec_Pliego
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmReport_Selec_Pliego = Create__Instance__(m_FrmReport_Selec_Pliego);
				return m_FrmReport_Selec_Pliego;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmReport_Selec_Pliego)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmReport_Selec_Pliego);
				}
			}
		}

		public FrmReport_SelecMes FrmReport_SelecMes
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmReport_SelecMes = Create__Instance__(m_FrmReport_SelecMes);
				return m_FrmReport_SelecMes;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmReport_SelecMes)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmReport_SelecMes);
				}
			}
		}

		public FrmReportCuadro FrmReportCuadro
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmReportCuadro = Create__Instance__(m_FrmReportCuadro);
				return m_FrmReportCuadro;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmReportCuadro)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmReportCuadro);
				}
			}
		}

		public FrmReportCumple FrmReportCumple
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmReportCumple = Create__Instance__(m_FrmReportCumple);
				return m_FrmReportCumple;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmReportCumple)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmReportCumple);
				}
			}
		}

		public FrmReporteEstadistico FrmReporteEstadistico
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmReporteEstadistico = Create__Instance__(m_FrmReporteEstadistico);
				return m_FrmReporteEstadistico;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmReporteEstadistico)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmReporteEstadistico);
				}
			}
		}

		public FrmReporteProfesion FrmReporteProfesion
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmReporteProfesion = Create__Instance__(m_FrmReporteProfesion);
				return m_FrmReporteProfesion;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmReporteProfesion)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmReporteProfesion);
				}
			}
		}

		public FrmReportFicha FrmReportFicha
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmReportFicha = Create__Instance__(m_FrmReportFicha);
				return m_FrmReportFicha;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmReportFicha)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmReportFicha);
				}
			}
		}

		public FrmRepPermisoDispl FrmRepPermisoDispl
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmRepPermisoDispl = Create__Instance__(m_FrmRepPermisoDispl);
				return m_FrmRepPermisoDispl;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmRepPermisoDispl)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmRepPermisoDispl);
				}
			}
		}

		public FrmRepPermisos FrmRepPermisos
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmRepPermisos = Create__Instance__(m_FrmRepPermisos);
				return m_FrmRepPermisos;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmRepPermisos)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmRepPermisos);
				}
			}
		}

		public FrmResoluciones FrmResoluciones
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmResoluciones = Create__Instance__(m_FrmResoluciones);
				return m_FrmResoluciones;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmResoluciones)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmResoluciones);
				}
			}
		}

		public FrmRotaciones FrmRotaciones
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmRotaciones = Create__Instance__(m_FrmRotaciones);
				return m_FrmRotaciones;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmRotaciones)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmRotaciones);
				}
			}
		}

		public FrmSalida FrmSalida
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmSalida = Create__Instance__(m_FrmSalida);
				return m_FrmSalida;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmSalida)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmSalida);
				}
			}
		}

		public FrmSobreTiempo FrmSobreTiempo
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmSobreTiempo = Create__Instance__(m_FrmSobreTiempo);
				return m_FrmSobreTiempo;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmSobreTiempo)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmSobreTiempo);
				}
			}
		}

		public FrmSuspenderAsistencia FrmSuspenderAsistencia
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmSuspenderAsistencia = Create__Instance__(m_FrmSuspenderAsistencia);
				return m_FrmSuspenderAsistencia;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmSuspenderAsistencia)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmSuspenderAsistencia);
				}
			}
		}

		public FrmTitulos FrmTitulos
		{
			[DebuggerNonUserCode]
			get
			{
				m_FrmTitulos = Create__Instance__(m_FrmTitulos);
				return m_FrmTitulos;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FrmTitulos)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmTitulos);
				}
			}
		}

		public MainMDI MainMDI
		{
			[DebuggerNonUserCode]
			get
			{
				m_MainMDI = Create__Instance__(m_MainMDI);
				return m_MainMDI;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_MainMDI)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_MainMDI);
				}
			}
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T Instance) where T : Form, new()
		{
			if (Instance == null || (Instance.IsDisposed ? true : false))
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(T)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(T), null);
				try
				{
					return new T();
				}
				catch (TargetInvocationException ex) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					ProjectData.SetProjectError(ex);
					return ex.InnerException != null;
				}).Invoke())
				{
					string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message);
					throw new InvalidOperationException(resourceString, ex.InnerException);
				}
				finally
				{
					m_FormBeingCreated.Remove(typeof(T));
				}
			}
			return Instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance) where T : Form
		{
			instance.Dispose();
			instance = null;
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyForms()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal new Type GetType()
		{
			return typeof(MyForms);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class MyWebServices
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal new Type GetType()
		{
			return typeof(MyWebServices);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance)
		{
			instance = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public MyWebServices()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class ThreadSafeObjectProvider<T> where T : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static T m_ThreadStaticValue;

		internal T GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new T();
				}
				return m_ThreadStaticValue;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ThreadSafeObjectProvider()
		{
		}
	}

	private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();

	private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();

	private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider = new ThreadSafeObjectProvider<User>();

	private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();

	private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();

	[HelpKeyword("My.Computer")]
	internal static MyComputer Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static MyApplication Application
	{
		[DebuggerHidden]
		get
		{
			return m_AppObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			return m_UserObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static MyForms Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static MyWebServices WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
