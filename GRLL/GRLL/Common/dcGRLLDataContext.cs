using System;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Reflection;
using System.Xml.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common;

[Database(Name = "CMI")]
public class dcGRLLDataContext : DataContext
{
	private static MappingSource mappingSource = new AttributeMappingSource();

	public Table<Vivienda> Vivienda => GetTable<Vivienda>();

	public Table<Actividad> Actividad => GetTable<Actividad>();

	public Table<AFP> AFP => GetTable<AFP>();

	public Table<AguaViv> AguaViv => GetTable<AguaViv>();

	public Table<Alerta> Alerta => GetTable<Alerta>();

	public Table<Almacen> Almacen => GetTable<Almacen>();

	public Table<Almacen_Bien> Almacen_Bien => GetTable<Almacen_Bien>();

	public Table<AlumbradoViv> AlumbradoViv => GetTable<AlumbradoViv>();

	public Table<ANT_Anticipo> ANT_Anticipo => GetTable<ANT_Anticipo>();

	public Table<ANT_Movimiento> ANT_Movimiento => GetTable<ANT_Movimiento>();

	public Table<Aprobacion_Pedido> Aprobacion_Pedido => GetTable<Aprobacion_Pedido>();

	public Table<Archivo> Archivo => GetTable<Archivo>();

	public Table<asis_norm> asis_norm => GetTable<asis_norm>();

	public Table<AudActividad> AudActividad => GetTable<AudActividad>();

	public Table<AudEmpleado> AudEmpleado => GetTable<AudEmpleado>();

	public Table<AudEstrategia> AudEstrategia => GetTable<AudEstrategia>();

	public Table<AudEstructOrg> AudEstructOrg => GetTable<AudEstructOrg>();

	public Table<AudObjetivo> AudObjetivo => GetTable<AudObjetivo>();

	public Table<AudTablas> AudTablas => GetTable<AudTablas>();

	public Table<Banco> Banco => GetTable<Banco>();

	public Table<Bien> Bien => GetTable<Bien>();

	public Table<CAP_Visitante> CAP_Visitante => GetTable<CAP_Visitante>();

	public Table<Capacitacion> Capacitacion => GetTable<Capacitacion>();

	public Table<Cargo> Cargo => GetTable<Cargo>();

	public Table<CategoriaGasto> CategoriaGasto => GetTable<CategoriaGasto>();

	public Table<ChequeCaj> ChequeCaj => GetTable<ChequeCaj>();

	public Table<CJRDevolucionNorma> CJRDevolucionNorma => GetTable<CJRDevolucionNorma>();

	public Table<CJRDictamenComision> CJRDictamenComision => GetTable<CJRDictamenComision>();

	public Table<CJRIniciativa> CJRIniciativa => GetTable<CJRIniciativa>();

	public Table<CJRNormaRegional> CJRNormaRegional => GetTable<CJRNormaRegional>();

	public Table<CJRNotificacionNorma> CJRNotificacionNorma => GetTable<CJRNotificacionNorma>();

	public Table<CJROficio> CJROficio => GetTable<CJROficio>();

	public Table<CJROperador> CJROperador => GetTable<CJROperador>();

	public Table<CJRPromulgacionNorma> CJRPromulgacionNorma => GetTable<CJRPromulgacionNorma>();

	public Table<CJRProyectoNormativo> CJRProyectoNormativo => GetTable<CJRProyectoNormativo>();

	public Table<CJRPublicacion> CJRPublicacion => GetTable<CJRPublicacion>();

	public Table<CJRPublicacionNorma> CJRPublicacionNorma => GetTable<CJRPublicacionNorma>();

	public Table<CJRResSolicitudOpinion> CJRResSolicitudOpinion => GetTable<CJRResSolicitudOpinion>();

	public Table<CJRSesion> CJRSesion => GetTable<CJRSesion>();

	public Table<CJRSolicitudOpinion> CJRSolicitudOpinion => GetTable<CJRSolicitudOpinion>();

	public Table<CJRTemaIniciativa> CJRTemaIniciativa => GetTable<CJRTemaIniciativa>();

	public Table<CJRTipoAprobacion> CJRTipoAprobacion => GetTable<CJRTipoAprobacion>();

	public Table<CJRTipoMedio> CJRTipoMedio => GetTable<CJRTipoMedio>();

	public Table<CJRTipoNorma> CJRTipoNorma => GetTable<CJRTipoNorma>();

	public Table<CJRTipoProyecto> CJRTipoProyecto => GetTable<CJRTipoProyecto>();

	public Table<CJRTipoSesion> CJRTipoSesion => GetTable<CJRTipoSesion>();

	public Table<CJRTipoSolicitud> CJRTipoSolicitud => GetTable<CJRTipoSolicitud>();

	public Table<CJRTrasladoComision> CJRTrasladoComision => GetTable<CJRTrasladoComision>();

	public Table<Clase> Clase => GetTable<Clase>();

	public Table<ClasificadorIngreso> ClasificadorIngreso => GetTable<ClasificadorIngreso>();

	public Table<Comportamiento> Comportamiento => GetTable<Comportamiento>();

	public Table<ConservacionViv> ConservacionViv => GetTable<ConservacionViv>();

	public Table<Consolidado> Consolidado => GetTable<Consolidado>();

	public Table<Contrato> Contrato => GetTable<Contrato>();

	public Table<Cotizacion> Cotizacion => GetTable<Cotizacion>();

	public Table<Despacho> Despacho => GetTable<Despacho>();

	public Table<Deta_Consolidado> Deta_Consolidado => GetTable<Deta_Consolidado>();

	public Table<Deta_Cotizacion> Deta_Cotizacion => GetTable<Deta_Cotizacion>();

	public Table<Deta_Despacho> Deta_Despacho => GetTable<Deta_Despacho>();

	public Table<Deta_Distribucion> Deta_Distribucion => GetTable<Deta_Distribucion>();

	public Table<DetFacturaCaj> DetFacturaCaj => GetTable<DetFacturaCaj>();

	public Table<Discapacidad> Discapacidad => GetTable<Discapacidad>();

	public Table<Documento> Documento => GetTable<Documento>();

	public Table<Egreso> Egreso => GetTable<Egreso>();

	public Table<Empleado_Area> Empleado_Area => GetTable<Empleado_Area>();

	public Table<Empleado_Marcacion> Empleado_Marcacion => GetTable<Empleado_Marcacion>();

	public Table<Empleado_old> Empleado_old => GetTable<Empleado_old>();

	public Table<Especifica> Especifica => GetTable<Especifica>();

	public Table<Especifica_Det> Especifica_Det => GetTable<Especifica_Det>();

	public Table<EspecificaGasto> EspecificaGasto => GetTable<EspecificaGasto>();

	public Table<EstadoCivil> EstadoCivil => GetTable<EstadoCivil>();

	public Table<EstadoEstudio> EstadoEstudio => GetTable<EstadoEstudio>();

	public Table<EstadoPedido> EstadoPedido => GetTable<EstadoPedido>();

	public Table<EstadoSunat> EstadoSunat => GetTable<EstadoSunat>();

	public Table<Estrategia> Estrategia => GetTable<Estrategia>();

	public Table<EstructOrganiz> EstructOrganiz => GetTable<EstructOrganiz>();

	public Table<EvaluacionGestion> EvaluacionGestion => GetTable<EvaluacionGestion>();

	public Table<ExcretasViv> ExcretasViv => GetTable<ExcretasViv>();

	public Table<ExpLaboral> ExpLaboral => GetTable<ExpLaboral>();

	public Table<FacturaCaj> FacturaCaj => GetTable<FacturaCaj>();

	public Table<Familia> Familia => GetTable<Familia>();

	public Table<Familiar> Familiar => GetTable<Familiar>();

	public Table<ficha_personal> ficha_personal => GetTable<ficha_personal>();

	public Table<finalidad> finalidad => GetTable<finalidad>();

	public Table<Financiamiento> Financiamiento => GetTable<Financiamiento>();

	public Table<FormaPago> FormaPago => GetTable<FormaPago>();

	public Table<Funcion> Funcion => GetTable<Funcion>();

	public Table<GastoPublico> GastoPublico => GetTable<GastoPublico>();

	public Table<Generica> Generica => GetTable<Generica>();

	public Table<GenericaGasto> GenericaGasto => GetTable<GenericaGasto>();

	public Table<Grupo> Grupo => GetTable<Grupo>();

	public Table<Horario> Horario => GetTable<Horario>();

	public Table<horarios> horarios => GetTable<horarios>();

	public Table<Inconveniente> Inconveniente => GetTable<Inconveniente>();

	public Table<Ingreso> Ingreso => GetTable<Ingreso>();

	public Table<IngresoCaj> IngresoCaj => GetTable<IngresoCaj>();

	public Table<Institucion> Institucion => GetTable<Institucion>();

	public Table<InversPublica> InversPublica => GetTable<InversPublica>();

	public Table<InversXFuentF> InversXFuentF => GetTable<InversXFuentF>();

	public Table<KM_LogMensaje> KM_LogMensaje => GetTable<KM_LogMensaje>();

	public Table<KM_LogReprod> KM_LogReprod => GetTable<KM_LogReprod>();

	public Table<KM_Mensaje> KM_Mensaje => GetTable<KM_Mensaje>();

	public Table<KM_Motivo> KM_Motivo => GetTable<KM_Motivo>();

	public Table<KM_Orden> KM_Orden => GetTable<KM_Orden>();

	public Table<KM_Parametro> KM_Parametro => GetTable<KM_Parametro>();

	public Table<KM_PlayListAviso> KM_PlayListAviso => GetTable<KM_PlayListAviso>();

	public Table<KM_PlayListPrincipal> KM_PlayListPrincipal => GetTable<KM_PlayListPrincipal>();

	public Table<KM_TipoOperacion> KM_TipoOperacion => GetTable<KM_TipoOperacion>();

	public Table<KM_VideoList> KM_VideoList => GetTable<KM_VideoList>();

	public Table<Limitacion> Limitacion => GetTable<Limitacion>();

	public Table<Logros> Logros => GetTable<Logros>();

	public Table<Marcacion> Marcacion => GetTable<Marcacion>();

	public Table<marcaciones> marcaciones => GetTable<marcaciones>();

	public Table<MaterialViv> MaterialViv => GetTable<MaterialViv>();

	public Table<Meta_Area> Meta_Area => GetTable<Meta_Area>();

	public Table<ModalidadAplicacion> ModalidadAplicacion => GetTable<ModalidadAplicacion>();

	public Table<Movimiento> Movimiento => GetTable<Movimiento>();

	public Table<Nacionalidad> Nacionalidad => GetTable<Nacionalidad>();

	public Table<NroCuenta> NroCuenta => GetTable<NroCuenta>();

	public Table<Objetivo> Objetivo => GetTable<Objetivo>();

	public Table<Operacion> Operacion => GetTable<Operacion>();

	public Table<OrdenCompra> OrdenCompra => GetTable<OrdenCompra>();

	public Table<PapeletDepositCaj> PapeletDepositCaj => GetTable<PapeletDepositCaj>();

	public Table<Parametro_Periodo> Parametro_Periodo => GetTable<Parametro_Periodo>();

	public Table<Parametros> Parametros => GetTable<Parametros>();

	public Table<ParametrosCaja> ParametrosCaja => GetTable<ParametrosCaja>();

	public Table<ParametrosTrab> ParametrosTrab => GetTable<ParametrosTrab>();

	public Table<Pedido> Pedido => GetTable<Pedido>();

	public Table<Pedido_Despacho> Pedido_Despacho => GetTable<Pedido_Despacho>();

	public Table<PeriodoLaboral> PeriodoLaboral => GetTable<PeriodoLaboral>();

	public Table<PeriodoTrimestral> PeriodoTrimestral => GetTable<PeriodoTrimestral>();

	public Table<Permiso> Permiso => GetTable<Permiso>();

	public Table<Persona> Persona => GetTable<Persona>();

	public Table<PersonaSunat> PersonaSunat => GetTable<PersonaSunat>();

	public Table<PlanMayor> PlanMayor => GetTable<PlanMayor>();

	public Table<PresupuestoT> PresupuestoT => GetTable<PresupuestoT>();

	public Table<Programa> Programa => GetTable<Programa>();

	public Table<ProgramaNF> ProgramaNF => GetTable<ProgramaNF>();

	public Table<ProgramMes> ProgramMes => GetTable<ProgramMes>();

	public Table<Proveedor> Proveedor => GetTable<Proveedor>();

	public Table<Proveedor_Bien> Proveedor_Bien => GetTable<Proveedor_Bien>();

	public Table<Recomendacion> Recomendacion => GetTable<Recomendacion>();

	public Table<RefSIAF> RefSIAF => GetTable<RefSIAF>();

	public Table<RegAsisDiario> RegAsisDiario => GetTable<RegAsisDiario>();

	public Table<RegimenPension> RegimenPension => GetTable<RegimenPension>();

	public Table<Reporte_Asistencias> Reporte_Asistencias => GetTable<Reporte_Asistencias>();

	public Table<ReqXProgMes> ReqXProgMes => GetTable<ReqXProgMes>();

	public Table<ResponsableXUO> ResponsableXUO => GetTable<ResponsableXUO>();

	public Table<Rol> Rol => GetTable<Rol>();

	public Table<Rol_Acceso> Rol_Acceso => GetTable<Rol_Acceso>();

	public Table<RRHH_AcudeEnferm> RRHH_AcudeEnferm => GetTable<RRHH_AcudeEnferm>();

	public Table<RRHH_AspSocio> RRHH_AspSocio => GetTable<RRHH_AspSocio>();

	public Table<RRHH_DinamicaFamiliar> RRHH_DinamicaFamiliar => GetTable<RRHH_DinamicaFamiliar>();

	public Table<RRHH_Feriado> RRHH_Feriado => GetTable<RRHH_Feriado>();

	public Table<RRHH_FuncFam> RRHH_FuncFam => GetTable<RRHH_FuncFam>();

	public Table<RRHH_Preg1> RRHH_Preg1 => GetTable<RRHH_Preg1>();

	public Table<RRHH_Preg2> RRHH_Preg2 => GetTable<RRHH_Preg2>();

	public Table<RRHH_Preg3> RRHH_Preg3 => GetTable<RRHH_Preg3>();

	public Table<RRHH_RelacHermano> RRHH_RelacHermano => GetTable<RRHH_RelacHermano>();

	public Table<RRHH_RelacPareja> RRHH_RelacPareja => GetTable<RRHH_RelacPareja>();

	public Table<RRHH_RelacPH> RRHH_RelacPH => GetTable<RRHH_RelacPH>();

	public Table<RRHH_Salud> RRHH_Salud => GetTable<RRHH_Salud>();

	public Table<RRHH_TipoFamilia> RRHH_TipoFamilia => GetTable<RRHH_TipoFamilia>();

	public Table<Seguro> Seguro => GetTable<Seguro>();

	public Table<SistemaOpcion> SistemaOpcion => GetTable<SistemaOpcion>();

	public Table<SubGenerica> SubGenerica => GetTable<SubGenerica>();

	public Table<SubGenerica_Det> SubGenerica_Det => GetTable<SubGenerica_Det>();

	public Table<SubPrograma> SubPrograma => GetTable<SubPrograma>();

	public Table<sysLogEvent> sysLogEvent => GetTable<sysLogEvent>();

	public Table<TenenciaViv> TenenciaViv => GetTable<TenenciaViv>();

	public Table<TipoAdjudicacion> TipoAdjudicacion => GetTable<TipoAdjudicacion>();

	public Table<TipoAlerta> TipoAlerta => GetTable<TipoAlerta>();

	public Table<TipoComportamiento> TipoComportamiento => GetTable<TipoComportamiento>();

	public Table<TipoDocID> TipoDocID => GetTable<TipoDocID>();

	public Table<TipoEstudio> TipoEstudio => GetTable<TipoEstudio>();

	public Table<TipoFamiliar> TipoFamiliar => GetTable<TipoFamiliar>();

	public Table<TipoInstitucion> TipoInstitucion => GetTable<TipoInstitucion>();

	public Table<TipoMoneda> TipoMoneda => GetTable<TipoMoneda>();

	public Table<TipoMovimiento> TipoMovimiento => GetTable<TipoMovimiento>();

	public Table<TipoPermiso> TipoPermiso => GetTable<TipoPermiso>();

	public Table<TipoRecurso> TipoRecurso => GetTable<TipoRecurso>();

	public Table<TipoSangre> TipoSangre => GetTable<TipoSangre>();

	public Table<TipoTrabajador> TipoTrabajador => GetTable<TipoTrabajador>();

	public Table<TipoTransaccion> TipoTransaccion => GetTable<TipoTransaccion>();

	public Table<TipoViv> TipoViv => GetTable<TipoViv>();

	public Table<TitulosEmpleado> TitulosEmpleado => GetTable<TitulosEmpleado>();

	public Table<Tra_Acuerdo> Tra_Acuerdo => GetTable<Tra_Acuerdo>();

	public Table<Tra_Articulo_Acuerdo> Tra_Articulo_Acuerdo => GetTable<Tra_Articulo_Acuerdo>();

	public Table<TRAAdjunto> TRAAdjunto => GetTable<TRAAdjunto>();

	public Table<TRAEtapa_Cargo> TRAEtapa_Cargo => GetTable<TRAEtapa_Cargo>();

	public Table<TransferenciaBco> TransferenciaBco => GetTable<TransferenciaBco>();

	public Table<TRANumeracion> TRANumeracion => GetTable<TRANumeracion>();

	public Table<TRAProcedimiento_Requisito> TRAProcedimiento_Requisito => GetTable<TRAProcedimiento_Requisito>();

	public Table<TRARequisito> TRARequisito => GetTable<TRARequisito>();

	public Table<TRATipoDoc> TRATipoDoc => GetTable<TRATipoDoc>();

	public Table<TRATipoSilencio> TRATipoSilencio => GetTable<TRATipoSilencio>();

	public Table<TRATramite_Requisito> TRATramite_Requisito => GetTable<TRATramite_Requisito>();

	public Table<TRAUsuario_IP> TRAUsuario_IP => GetTable<TRAUsuario_IP>();

	public Table<UbicacionViv> UbicacionViv => GetTable<UbicacionViv>();

	public Table<Ubigeo> Ubigeo => GetTable<Ubigeo>();

	public Table<UnidadEquivalencia> UnidadEquivalencia => GetTable<UnidadEquivalencia>();

	public Table<UnidadMedida> UnidadMedida => GetTable<UnidadMedida>();

	public Table<UnidMed> UnidMed => GetTable<UnidMed>();

	public Table<Usuario> Usuario => GetTable<Usuario>();

	public Table<Usuario_Rol> Usuario_Rol => GetTable<Usuario_Rol>();

	public Table<VariableGestion> VariableGestion => GetTable<VariableGestion>();

	public Table<Variables> Variables => GetTable<Variables>();

	public Table<ViveCon> ViveCon => GetTable<ViveCon>();

	public Table<ANT_VS_Personal_GRLL> ANT_VS_Personal_GRLL => GetTable<ANT_VS_Personal_GRLL>();

	public Table<vs_tra_Usuario_Tramite_PC_IP> vs_tra_Usuario_Tramite_PC_IP => GetTable<vs_tra_Usuario_Tramite_PC_IP>();

	public Table<vActividad> vActividad => GetTable<vActividad>();

	public Table<vActividad_ProgramMes> vActividad_ProgramMes => GetTable<vActividad_ProgramMes>();

	public Table<vCJ_ClasificadorIngreso> vCJ_ClasificadorIngreso => GetTable<vCJ_ClasificadorIngreso>();

	public Table<vCJ_PersonaJuridica> vCJ_PersonaJuridica => GetTable<vCJ_PersonaJuridica>();

	public Table<vCJ_PersonaNatural> vCJ_PersonaNatural => GetTable<vCJ_PersonaNatural>();

	public Table<vCJ_PersonaNJ> vCJ_PersonaNJ => GetTable<vCJ_PersonaNJ>();

	public Table<vCJ_PlanMayor> vCJ_PlanMayor => GetTable<vCJ_PlanMayor>();

	public Table<vEmpleadoxpersona> vEmpleadoxpersona => GetTable<vEmpleadoxpersona>();

	public Table<vEstrategia> vEstrategia => GetTable<vEstrategia>();

	public Table<vEstructOrganiz> vEstructOrganiz => GetTable<vEstructOrganiz>();

	public Table<vEstructOrganizCmbObj> vEstructOrganizCmbObj => GetTable<vEstructOrganizCmbObj>();

	public Table<vistaUnidad> vistaUnidad => GetTable<vistaUnidad>();

	public Table<vObjetivo> vObjetivo => GetTable<vObjetivo>();

	public Table<vReqXProgMesXProgramMes> vReqXProgMesXProgramMes => GetTable<vReqXProgMesXProgramMes>();

	public Table<vs_ABA_AprobacionPedido> vs_ABA_AprobacionPedido => GetTable<vs_ABA_AprobacionPedido>();

	public Table<VS_ABA_BIENUNIMED> VS_ABA_BIENUNIMED => GetTable<VS_ABA_BIENUNIMED>();

	public Table<vs_aba_CorrelativoBien> vs_aba_CorrelativoBien => GetTable<vs_aba_CorrelativoBien>();

	public Table<vs_ABA_Departamentos> vs_ABA_Departamentos => GetTable<vs_ABA_Departamentos>();

	public Table<vs_ABA_Distritos> vs_ABA_Distritos => GetTable<vs_ABA_Distritos>();

	public Table<vs_ABA_ListarAprobacionesPedido> vs_ABA_ListarAprobacionesPedido => GetTable<vs_ABA_ListarAprobacionesPedido>();

	public Table<VS_ABA_LISTARBIEN_ALMACEN> VS_ABA_LISTARBIEN_ALMACEN => GetTable<VS_ABA_LISTARBIEN_ALMACEN>();

	public Table<vs_ABA_ListarBienes> vs_ABA_ListarBienes => GetTable<vs_ABA_ListarBienes>();

	public Table<vs_ABA_ListarCotizacion> vs_ABA_ListarCotizacion => GetTable<vs_ABA_ListarCotizacion>();

	public Table<vs_ABA_ListarDetalleCotizacion> vs_ABA_ListarDetalleCotizacion => GetTable<vs_ABA_ListarDetalleCotizacion>();

	public Table<vs_ABA_ListarDetalleOrden> vs_ABA_ListarDetalleOrden => GetTable<vs_ABA_ListarDetalleOrden>();

	public Table<vs_ABA_ListarDetallePedido> vs_ABA_ListarDetallePedido => GetTable<vs_ABA_ListarDetallePedido>();

	public Table<vs_ABA_ListarOrdenCompra> vs_ABA_ListarOrdenCompra => GetTable<vs_ABA_ListarOrdenCompra>();

	public Table<vs_ABA_ListarPedidos> vs_ABA_ListarPedidos => GetTable<vs_ABA_ListarPedidos>();

	public Table<VS_ABA_LISTARPROVEEDOR> VS_ABA_LISTARPROVEEDOR => GetTable<VS_ABA_LISTARPROVEEDOR>();

	public Table<vs_ABA_ListarTrabajador> vs_ABA_ListarTrabajador => GetTable<vs_ABA_ListarTrabajador>();

	public Table<VS_ABA_META> VS_ABA_META => GetTable<VS_ABA_META>();

	public Table<vs_aba_NroBien> vs_aba_NroBien => GetTable<vs_aba_NroBien>();

	public Table<vs_aba_NroMaxMovimiento> vs_aba_NroMaxMovimiento => GetTable<vs_aba_NroMaxMovimiento>();

	public Table<VS_ABA_NROMAXPERJ> VS_ABA_NROMAXPERJ => GetTable<VS_ABA_NROMAXPERJ>();

	public Table<VS_ABA_NROMAXPN> VS_ABA_NROMAXPN => GetTable<VS_ABA_NROMAXPN>();

	public Table<vs_ABA_Proveedor> vs_ABA_Proveedor => GetTable<vs_ABA_Proveedor>();

	public Table<vs_ABA_Proveedores> vs_ABA_Proveedores => GetTable<vs_ABA_Proveedores>();

	public Table<vs_ABA_Provincias> vs_ABA_Provincias => GetTable<vs_ABA_Provincias>();

	public Table<vs_ABA_Ubigeo> vs_ABA_Ubigeo => GetTable<vs_ABA_Ubigeo>();

	public Table<vs_ABA_UnidadEquivalencia> vs_ABA_UnidadEquivalencia => GetTable<vs_ABA_UnidadEquivalencia>();

	public Table<vs_CJr_Norma> vs_CJr_Norma => GetTable<vs_CJr_Norma>();

	public Table<vs_CJR_NormaReg> vs_CJR_NormaReg => GetTable<vs_CJR_NormaReg>();

	public Table<vs_CJR_OficioSol> vs_CJR_OficioSol => GetTable<vs_CJR_OficioSol>();

	public Table<vs_CJR_Proyecto> vs_CJR_Proyecto => GetTable<vs_CJR_Proyecto>();

	public Table<vs_CJr_ProyectoNor> vs_CJr_ProyectoNor => GetTable<vs_CJr_ProyectoNor>();

	public Table<vs_Faltas> vs_Faltas => GetTable<vs_Faltas>();

	public Table<vs_GetEmpleado> vs_GetEmpleado => GetTable<vs_GetEmpleado>();

	public Table<vs_PER_ListarEmpleados> vs_PER_ListarEmpleados => GetTable<vs_PER_ListarEmpleados>();

	public Table<vs_PTI_ListarOrganigrama> vs_PTI_ListarOrganigrama => GetTable<vs_PTI_ListarOrganigrama>();

	public Table<vs_RRHH_buscarEmpleado> vs_RRHH_buscarEmpleado => GetTable<vs_RRHH_buscarEmpleado>();

	public Table<vs_RRHH_FamFicha> vs_RRHH_FamFicha => GetTable<vs_RRHH_FamFicha>();

	public Table<vs_RRHH_FichaSocial> vs_RRHH_FichaSocial => GetTable<vs_RRHH_FichaSocial>();

	public Table<vs_SEG_usuario> vs_SEG_usuario => GetTable<vs_SEG_usuario>();

	public Table<VS_TRA_ACUERDO_ARTICULO> VS_TRA_ACUERDO_ARTICULO => GetTable<VS_TRA_ACUERDO_ARTICULO>();

	public Table<vs_tra_proc_etapa_area_cargo> vs_tra_proc_etapa_area_cargo => GetTable<vs_tra_proc_etapa_area_cargo>();

	public Table<vs_tra_Puntualidad_Tramite> vs_tra_Puntualidad_Tramite => GetTable<vs_tra_Puntualidad_Tramite>();

	public Table<vs_tra_usuario_area_cargo> vs_tra_usuario_area_cargo => GetTable<vs_tra_usuario_area_cargo>();

	public Table<vs_tra_Usuario_online> vs_tra_Usuario_online => GetTable<vs_tra_Usuario_online>();

	public Table<TRAProcedimiento> TRAProcedimiento => GetTable<TRAProcedimiento>();

	public Table<TRAEtapa_Procedimiento> TRAEtapa_Procedimiento => GetTable<TRAEtapa_Procedimiento>();

	public Table<vs_TRA_ListarProcedimiento> vs_TRA_ListarProcedimiento => GetTable<vs_TRA_ListarProcedimiento>();

	public Table<aba_vs_financiamiento> aba_vs_financiamiento => GetTable<aba_vs_financiamiento>();

	public Table<vs_tra_ListarProcArea> vs_tra_ListarProcArea => GetTable<vs_tra_ListarProcArea>();

	public Table<TRATramite> TRATramite => GetTable<TRATramite>();

	public Table<TRADocumento> TRADocumento => GetTable<TRADocumento>();

	public Table<vs_TRA_ListarTramite> vs_TRA_ListarTramite => GetTable<vs_TRA_ListarTramite>();

	public Table<vs_TRA_ListarProcedimientoMant> vs_TRA_ListarProcedimientoMant => GetTable<vs_TRA_ListarProcedimientoMant>();

	public Table<vs_TRA_ListarMovimiento> vs_TRA_ListarMovimiento => GetTable<vs_TRA_ListarMovimiento>();

	public Table<vs_TRA_ListarInicioArea> vs_TRA_ListarInicioArea => GetTable<vs_TRA_ListarInicioArea>();

	public Table<vs_TRA_ListarEtapaProcedimiento> vs_TRA_ListarEtapaProcedimiento => GetTable<vs_TRA_ListarEtapaProcedimiento>();

	public Table<vs_tra_ListarMovimientoTiempo> vs_tra_ListarMovimientoTiempo => GetTable<vs_tra_ListarMovimientoTiempo>();

	public Table<TRAMovimiento> TRAMovimiento => GetTable<TRAMovimiento>();

	public Table<Deta_Movimiento> Deta_Movimiento => GetTable<Deta_Movimiento>();

	public Table<aba_vs_RecepcionBien> aba_vs_RecepcionBien => GetTable<aba_vs_RecepcionBien>();

	public Table<vs_tra_listar_movimiento_tramite> vs_tra_listar_movimiento_tramite => GetTable<vs_tra_listar_movimiento_tramite>();

	public Table<vs_tra_listar_movimiento_tramite_G> vs_tra_listar_movimiento_tramite_G => GetTable<vs_tra_listar_movimiento_tramite_G>();

	public Table<Deta_Pedido> Deta_Pedido => GetTable<Deta_Pedido>();

	public Table<aba_vs_Deta_Consolidado_Contrato> aba_vs_Deta_Consolidado_Contrato => GetTable<aba_vs_Deta_Consolidado_Contrato>();

	public Table<Deta_Orden> Deta_Orden => GetTable<Deta_Orden>();

	public Table<vs_aba_MetaFull> vs_aba_MetaFull => GetTable<vs_aba_MetaFull>();

	public Table<vs_aba_Detalle> vs_aba_Detalle => GetTable<vs_aba_Detalle>();

	public Table<TipoDoc> TipoDoc => GetTable<TipoDoc>();

	public Table<vs_ABA_GastoPublico> vs_ABA_GastoPublico => GetTable<vs_ABA_GastoPublico>();

	public Table<vs_ABA_ListarMetas> vs_ABA_ListarMetas => GetTable<vs_ABA_ListarMetas>();

	public Table<ProgramaProp> ProgramaProp => GetTable<ProgramaProp>();

	public Table<Aba_Actividad> Aba_Actividad => GetTable<Aba_Actividad>();

	public Table<Componente> Componente => GetTable<Componente>();

	public Table<RRHH_TempFecha> RRHH_TempFechas => GetTable<RRHH_TempFecha>();

	public Table<Motivo_Perm> Motivo_Perms => GetTable<Motivo_Perm>();

	public Table<Meta> Metas => GetTable<Meta>();

	public Table<MotivoBaja> MotivoBajas => GetTable<MotivoBaja>();

	public Table<RRHH_Asegurado> RRHH_Asegurados => GetTable<RRHH_Asegurado>();

	public Table<EstudiosRealizado> EstudiosRealizados => GetTable<EstudiosRealizado>();

	public Table<Local> Locals => GetTable<Local>();

	public Table<Empleado> Empleados => GetTable<Empleado>();

	public Table<Asistencia> Asistencias => GetTable<Asistencia>();

	public Table<Rotacion> Rotacions => GetTable<Rotacion>();

	public Table<TipoResolucion> TipoResolucions => GetTable<TipoResolucion>();

	public Table<Resolucion> Resolucions => GetTable<Resolucion>();

	public Table<HorarioTemporal> HorarioTemporals => GetTable<HorarioTemporal>();

	public dcGRLLDataContext()
		: base("Data Source=localhost;Initial Catalog=CMI;Integrated Security=True;Connect Timeout=30", mappingSource)
	{
	}

	public dcGRLLDataContext(string connection)
		: base(connection, mappingSource)
	{
	}

	public dcGRLLDataContext(IDbConnection connection)
		: base(connection, mappingSource)
	{
	}

	public dcGRLLDataContext(string connection, MappingSource mappingSource)
		: base(connection, mappingSource)
	{
	}

	public dcGRLLDataContext(IDbConnection connection, MappingSource mappingSource)
		: base(connection, mappingSource)
	{
	}

	[Function(Name = "dbo.Aba_Actividad_Delete")]
	public int Aba_Actividad_Delete([Parameter(Name = "IdActividad", DbType = "Char(6)")] string idActividad, [Parameter(Name = "IdSubPrograma", DbType = "Char(4)")] string idSubPrograma, [Parameter(Name = "IdPrograma", DbType = "Char(3)")] string idPrograma, [Parameter(Name = "IdFuncion", DbType = "Char(2)")] string idFuncion, [Parameter(Name = "Anio", DbType = "Char(4)")] string anio)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idActividad, idSubPrograma, idPrograma, idFuncion, anio);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Actividad_GetAll")]
	public ISingleResult<Aba_Actividad_GetAllResult> Aba_Actividad_GetAll()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return (ISingleResult<Aba_Actividad_GetAllResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Actividad_GetBySubPrograma")]
	public ISingleResult<Aba_Actividad_GetBySubProgramaResult> Aba_Actividad_GetBySubPrograma([Parameter(Name = "IdFuncion", DbType = "Char(2)")] string idFuncion, [Parameter(Name = "Anio", DbType = "Char(4)")] string anio, [Parameter(Name = "IdPrograma", DbType = "Char(3)")] string idPrograma, [Parameter(Name = "IdSubPrograma", DbType = "Char(4)")] string idSubPrograma)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idFuncion, anio, idPrograma, idSubPrograma);
		return (ISingleResult<Aba_Actividad_GetBySubProgramaResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Actividad_GetOne")]
	public ISingleResult<Aba_Actividad_GetOneResult> Aba_Actividad_GetOne([Parameter(Name = "IdActividad", DbType = "Char(6)")] string idActividad, [Parameter(Name = "IdSubPrograma", DbType = "Char(4)")] string idSubPrograma, [Parameter(Name = "IdPrograma", DbType = "Char(3)")] string idPrograma, [Parameter(Name = "IdFuncion", DbType = "Char(2)")] string idFuncion, [Parameter(Name = "Anio", DbType = "Char(4)")] string anio)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idActividad, idSubPrograma, idPrograma, idFuncion, anio);
		return (ISingleResult<Aba_Actividad_GetOneResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Actividad_Insert")]
	public int Aba_Actividad_Insert([Parameter(Name = "IdActividad", DbType = "Char(8)")] string idActividad, [Parameter(Name = "Descripcion", DbType = "VarChar(255)")] string descripcion, [Parameter(Name = "IdSubPrograma", DbType = "Char(4)")] string idSubPrograma, [Parameter(Name = "IdPrograma", DbType = "Char(3)")] string idPrograma, [Parameter(Name = "IdFuncion", DbType = "Char(2)")] string idFuncion, [Parameter(Name = "Anio", DbType = "Char(4)")] string anio)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idActividad, descripcion, idSubPrograma, idPrograma, idFuncion, anio);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Actividad_Update")]
	public int Aba_Actividad_Update([Parameter(Name = "IdActividad", DbType = "Char(6)")] string idActividad, [Parameter(Name = "Descripcion", DbType = "VarChar(80)")] string descripcion, [Parameter(Name = "IdSubPrograma", DbType = "Char(4)")] string idSubPrograma, [Parameter(Name = "IdPrograma", DbType = "Char(3)")] string idPrograma, [Parameter(Name = "IdFuncion", DbType = "Char(2)")] string idFuncion, [Parameter(Name = "Anio", DbType = "Char(4)")] string anio)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idActividad, descripcion, idSubPrograma, idPrograma, idFuncion, anio);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Almacen_Listar")]
	public ISingleResult<Aba_Almacen_ListarResult> Aba_Almacen_Listar()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return (ISingleResult<Aba_Almacen_ListarResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Aprobacion_Pedido_Delete")]
	public int Aba_Aprobacion_Pedido_Delete([Parameter(Name = "IdPedido", DbType = "Char(6)")] string idPedido, [Parameter(Name = "IdAreaOrganiz", DbType = "Char(6)")] string idAreaOrganiz, [Parameter(Name = "Anio", DbType = "Int")] int? anio)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idPedido, idAreaOrganiz, anio);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Aprobacion_Pedido_DeleteByPedido")]
	public int Aba_Aprobacion_Pedido_DeleteByPedido([Parameter(Name = "IdPedido", DbType = "Char(6)")] string idPedido)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idPedido);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Aprobacion_Pedido_GetAll")]
	public int Aba_Aprobacion_Pedido_GetAll()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Aprobacion_Pedido_GetOne")]
	public int Aba_Aprobacion_Pedido_GetOne([Parameter(Name = "IdPedido", DbType = "Char(6)")] string idPedido, [Parameter(Name = "IdAreaOrganiz", DbType = "Char(6)")] string idAreaOrganiz, [Parameter(Name = "Anio", DbType = "Int")] int? anio)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idPedido, idAreaOrganiz, anio);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Aprobacion_Pedido_Insert")]
	public int Aba_Aprobacion_Pedido_Insert([Parameter(Name = "IdPedido", DbType = "Char(6)")] string idPedido, [Parameter(Name = "IdAreaOrganiz", DbType = "Char(6)")] string idAreaOrganiz, [Parameter(Name = "Anio", DbType = "Int")] int? anio, [Parameter(Name = "Estado", DbType = "Char(1)")] char? estado, [Parameter(Name = "Observaciones", DbType = "VarChar(120)")] string observaciones, [Parameter(Name = "IdTrabajador", DbType = "Int")] int? idTrabajador, [Parameter(Name = "Fecha", DbType = "DateTime")] DateTime? fecha)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idPedido, idAreaOrganiz, anio, estado, observaciones, idTrabajador, fecha);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Aprobacion_Pedido_Update")]
	public int Aba_Aprobacion_Pedido_Update([Parameter(Name = "IdPedido", DbType = "Char(6)")] string idPedido, [Parameter(Name = "IdAreaOrganiz", DbType = "Char(6)")] string idAreaOrganiz, [Parameter(Name = "Anio", DbType = "Int")] int? anio, [Parameter(Name = "Estado", DbType = "Char(1)")] char? estado, [Parameter(Name = "Observaciones", DbType = "VarChar(120)")] string observaciones, [Parameter(Name = "IdTrabajador", DbType = "Char(18)")] string idTrabajador, [Parameter(Name = "Fecha", DbType = "DateTime")] DateTime? fecha)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idPedido, idAreaOrganiz, anio, estado, observaciones, idTrabajador, fecha);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Bien_ListarNoAlmacen")]
	public ISingleResult<Aba_Bien_ListarNoAlmacenResult> Aba_Bien_ListarNoAlmacen([Parameter(DbType = "Char(2)")] string idalmacen)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idalmacen);
		return (ISingleResult<Aba_Bien_ListarNoAlmacenResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Bien_ListarPorAlmacen")]
	public ISingleResult<Aba_Bien_ListarPorAlmacenResult> Aba_Bien_ListarPorAlmacen([Parameter(DbType = "Char(2)")] string idAlmacen, [Parameter(DbType = "Char(3)")] string idbien)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idAlmacen, idbien);
		return (ISingleResult<Aba_Bien_ListarPorAlmacenResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Bien_StockPorAlmacen")]
	public ISingleResult<Aba_Bien_StockPorAlmacenResult> Aba_Bien_StockPorAlmacen([Parameter(DbType = "Char(2)")] string idAlmacen, [Parameter(DbType = "Char(13)")] string idbien)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idAlmacen, idbien);
		return (ISingleResult<Aba_Bien_StockPorAlmacenResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Clase_Delete")]
	public int Aba_Clase_Delete([Parameter(Name = "IdClase", DbType = "Char(2)")] string idClase, [Parameter(Name = "IdGrupo", DbType = "Char(3)")] string idGrupo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idClase, idGrupo);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Clase_GetAll")]
	public ISingleResult<Aba_Clase_GetAllResult> Aba_Clase_GetAll()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return (ISingleResult<Aba_Clase_GetAllResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Clase_GetByGrupo")]
	public ISingleResult<Aba_Clase_GetByGrupoResult> Aba_Clase_GetByGrupo([Parameter(Name = "IdGrupo", DbType = "Char(3)")] string idGrupo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idGrupo);
		return (ISingleResult<Aba_Clase_GetByGrupoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Clase_GetOne")]
	public ISingleResult<Aba_Clase_GetOneResult> Aba_Clase_GetOne([Parameter(Name = "IdClase", DbType = "Char(2)")] string idClase, [Parameter(Name = "IdGrupo", DbType = "Char(3)")] string idGrupo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idClase, idGrupo);
		return (ISingleResult<Aba_Clase_GetOneResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Clase_Insert")]
	public int Aba_Clase_Insert([Parameter(Name = "IdClase", DbType = "Char(2)")] string idClase, [Parameter(Name = "Descripcion", DbType = "VarChar(120)")] string descripcion, [Parameter(Name = "Observaciones", DbType = "VarChar(120)")] string observaciones, [Parameter(Name = "IdGrupo", DbType = "Char(3)")] string idGrupo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idClase, descripcion, observaciones, idGrupo);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Clase_Update")]
	public int Aba_Clase_Update([Parameter(Name = "IdClase", DbType = "Char(2)")] string idClase, [Parameter(Name = "Descripcion", DbType = "VarChar(120)")] string descripcion, [Parameter(Name = "Observaciones", DbType = "VarChar(120)")] string observaciones, [Parameter(Name = "IdGrupo", DbType = "Char(3)")] string idGrupo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idClase, descripcion, observaciones, idGrupo);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Componente_Delete")]
	public int Aba_Componente_Delete([Parameter(Name = "IdComponente", DbType = "Char(6)")] string idComponente, [Parameter(Name = "IdActividad", DbType = "Char(6)")] string idActividad, [Parameter(Name = "IdSubPrograma", DbType = "Char(4)")] string idSubPrograma, [Parameter(Name = "IdPrograma", DbType = "Char(3)")] string idPrograma, [Parameter(Name = "IdFuncion", DbType = "Char(2)")] string idFuncion, [Parameter(Name = "Anio", DbType = "Char(4)")] string anio)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idComponente, idActividad, idSubPrograma, idPrograma, idFuncion, anio);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Componente_GetAll")]
	public ISingleResult<Aba_Componente_GetAllResult> Aba_Componente_GetAll()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return (ISingleResult<Aba_Componente_GetAllResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Componente_GetByActividad")]
	public ISingleResult<Aba_Componente_GetByActividadResult> Aba_Componente_GetByActividad([Parameter(Name = "IdActividad", DbType = "Char(6)")] string idActividad, [Parameter(Name = "IdSubPrograma", DbType = "Char(6)")] string idSubPrograma, [Parameter(Name = "IdPrograma", DbType = "Char(3)")] string idPrograma, [Parameter(Name = "IdFuncion", DbType = "Char(2)")] string idFuncion, [Parameter(Name = "Anio", DbType = "Char(4)")] string anio)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idActividad, idSubPrograma, idPrograma, idFuncion, anio);
		return (ISingleResult<Aba_Componente_GetByActividadResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Componente_GetOne")]
	public ISingleResult<Aba_Componente_GetOneResult> Aba_Componente_GetOne([Parameter(Name = "IdComponente", DbType = "Char(6)")] string idComponente, [Parameter(Name = "IdActividad", DbType = "Char(6)")] string idActividad, [Parameter(Name = "IdSubPrograma", DbType = "Char(4)")] string idSubPrograma, [Parameter(Name = "IdPrograma", DbType = "Char(3)")] string idPrograma, [Parameter(Name = "IdFuncion", DbType = "Char(2)")] string idFuncion, [Parameter(Name = "Anio", DbType = "Char(4)")] string anio)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idComponente, idActividad, idSubPrograma, idPrograma, idFuncion, anio);
		return (ISingleResult<Aba_Componente_GetOneResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Componente_Insert")]
	public int Aba_Componente_Insert([Parameter(Name = "IdComponente", DbType = "Char(6)")] string idComponente, [Parameter(Name = "Descripcion", DbType = "VarChar(80)")] string descripcion, [Parameter(Name = "IdActividad", DbType = "Char(6)")] string idActividad, [Parameter(Name = "IdSubPrograma", DbType = "Char(4)")] string idSubPrograma, [Parameter(Name = "IdPrograma", DbType = "Char(3)")] string idPrograma, [Parameter(Name = "IdFuncion", DbType = "Char(2)")] string idFuncion, [Parameter(Name = "Anio", DbType = "Char(4)")] string anio)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idComponente, descripcion, idActividad, idSubPrograma, idPrograma, idFuncion, anio);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Componente_Update")]
	public int Aba_Componente_Update([Parameter(Name = "IdComponente", DbType = "Char(6)")] string idComponente, [Parameter(Name = "Descripcion", DbType = "VarChar(80)")] string descripcion, [Parameter(Name = "IdActividad", DbType = "Char(6)")] string idActividad, [Parameter(Name = "IdSubPrograma", DbType = "Char(4)")] string idSubPrograma, [Parameter(Name = "IdPrograma", DbType = "Char(3)")] string idPrograma, [Parameter(Name = "IdFuncion", DbType = "Char(2)")] string idFuncion, [Parameter(Name = "Anio", DbType = "Char(4)")] string anio)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idComponente, descripcion, idActividad, idSubPrograma, idPrograma, idFuncion, anio);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Consolidado_LIstarPorFecha")]
	public ISingleResult<Aba_Consolidado_LIstarPorFechaResult> Aba_Consolidado_LIstarPorFecha([Parameter(DbType = "DateTime")] DateTime? fechaDe, [Parameter(DbType = "DateTime")] DateTime? fechaA)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), fechaDe, fechaA);
		return (ISingleResult<Aba_Consolidado_LIstarPorFechaResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Contrato_ActualizarEstado")]
	public int Aba_Contrato_ActualizarEstado([Parameter(DbType = "Char(8)")] string idcontrato, [Parameter(DbType = "Int")] int? tipo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idcontrato, tipo);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Contrato_ListarPorConsolidado")]
	public ISingleResult<Aba_Contrato_ListarPorConsolidadoResult> Aba_Contrato_ListarPorConsolidado([Parameter(DbType = "Char(6)")] string idconsolidado)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idconsolidado);
		return (ISingleResult<Aba_Contrato_ListarPorConsolidadoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Contrato_ObtenerDetallado")]
	public ISingleResult<Aba_Contrato_ObtenerDetalladoResult> Aba_Contrato_ObtenerDetallado([Parameter(DbType = "Char(8)")] string idcontrato)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idcontrato);
		return (ISingleResult<Aba_Contrato_ObtenerDetalladoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Contrato_ObtenerListado")]
	public ISingleResult<Aba_Contrato_ObtenerListadoResult> Aba_Contrato_ObtenerListado([Parameter(DbType = "VarChar(40)")] string proveedor, [Parameter(DbType = "DateTime")] DateTime? fechaDe, [Parameter(DbType = "DateTime")] DateTime? fechaA, [Parameter(DbType = "Int")] int? tipo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), proveedor, fechaDe, fechaA, tipo);
		return (ISingleResult<Aba_Contrato_ObtenerListadoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Deta_Consolidado_BuenaPro")]
	public ISingleResult<Aba_Deta_Consolidado_BuenaProResult> Aba_Deta_Consolidado_BuenaPro([Parameter(Name = "IdConsolidado", DbType = "Char(6)")] string idConsolidado, [Parameter(Name = "IdProveedor", DbType = "Char(11)")] string idProveedor)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idConsolidado, idProveedor);
		return (ISingleResult<Aba_Deta_Consolidado_BuenaProResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Deta_Consolidado_Listar")]
	public ISingleResult<Aba_Deta_Consolidado_ListarResult> Aba_Deta_Consolidado_Listar([Parameter(Name = "IdConsolidado", DbType = "Char(6)")] string idConsolidado, [Parameter(Name = "IdProveedor", DbType = "Char(11)")] string idProveedor)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idConsolidado, idProveedor);
		return (ISingleResult<Aba_Deta_Consolidado_ListarResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Deta_Consolidado_ListarDetalle")]
	public ISingleResult<Aba_Deta_Consolidado_ListarDetalleResult> Aba_Deta_Consolidado_ListarDetalle([Parameter(DbType = "Char(6)")] string idconsolidado)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idconsolidado);
		return (ISingleResult<Aba_Deta_Consolidado_ListarDetalleResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Deta_Consolidado_ObtenerPorProveedor")]
	public ISingleResult<Aba_Deta_Consolidado_ObtenerPorProveedorResult> Aba_Deta_Consolidado_ObtenerPorProveedor([Parameter(DbType = "Char(11)")] string proveedor, [Parameter(DbType = "Int")] int? tipo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), proveedor, tipo);
		return (ISingleResult<Aba_Deta_Consolidado_ObtenerPorProveedorResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Deta_Cotizacion_SelectPorProveedor")]
	public ISingleResult<Aba_Deta_Cotizacion_SelectPorProveedorResult> Aba_Deta_Cotizacion_SelectPorProveedor([Parameter(DbType = "Char(11)")] string idproveedor, [Parameter(DbType = "Char(13)")] string idbien, [Parameter(DbType = "Char(6)")] string idconsolidado)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idproveedor, idbien, idconsolidado);
		return (ISingleResult<Aba_Deta_Cotizacion_SelectPorProveedorResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Deta_Distribucion_PorConsolidado")]
	public ISingleResult<Aba_Deta_Distribucion_PorConsolidadoResult> Aba_Deta_Distribucion_PorConsolidado([Parameter(DbType = "Char(6)")] string idconsolidado)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idconsolidado);
		return (ISingleResult<Aba_Deta_Distribucion_PorConsolidadoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Deta_Distribucion_PorOrdenCompra")]
	public ISingleResult<Aba_Deta_Distribucion_PorOrdenCompraResult> Aba_Deta_Distribucion_PorOrdenCompra([Parameter(DbType = "Char(8)")] string idorden, [Parameter(DbType = "Int")] int? tipo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idorden, tipo);
		return (ISingleResult<Aba_Deta_Distribucion_PorOrdenCompraResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Deta_Orden_ListarDespacho")]
	public ISingleResult<Aba_Deta_Orden_ListarDespachoResult> Aba_Deta_Orden_ListarDespacho([Parameter(DbType = "Char(8)")] string idOrden, [Parameter(DbType = "Char(2)")] string idAlmacen)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idOrden, idAlmacen);
		return (ISingleResult<Aba_Deta_Orden_ListarDespachoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Deta_Orden_PorOrden")]
	public ISingleResult<Aba_Deta_Orden_PorOrdenResult> Aba_Deta_Orden_PorOrden([Parameter(DbType = "Char(8)")] string idorden)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idorden);
		return (ISingleResult<Aba_Deta_Orden_PorOrdenResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Deta_Pedido_Delete")]
	public int Aba_Deta_Pedido_Delete([Parameter(Name = "IdMeta", DbType = "Int")] int? idMeta, [Parameter(Name = "IdBien", DbType = "Char(13)")] string idBien, [Parameter(Name = "IdPedido", DbType = "Char(6)")] string idPedido)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idMeta, idBien, idPedido);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Deta_Pedido_Delete_By_Pedido")]
	public int Aba_Deta_Pedido_Delete_By_Pedido([Parameter(Name = "IdPedido", DbType = "Char(6)")] string idPedido)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idPedido);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Deta_Pedido_GetAll")]
	public ISingleResult<Aba_Deta_Pedido_GetAllResult> Aba_Deta_Pedido_GetAll()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return (ISingleResult<Aba_Deta_Pedido_GetAllResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Deta_Pedido_GetOne")]
	public ISingleResult<Aba_Deta_Pedido_GetOneResult> Aba_Deta_Pedido_GetOne([Parameter(Name = "IdMeta", DbType = "Int")] int? idMeta, [Parameter(Name = "IdBien", DbType = "Char(13)")] string idBien, [Parameter(Name = "IdPedido", DbType = "Char(6)")] string idPedido)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idMeta, idBien, idPedido);
		return (ISingleResult<Aba_Deta_Pedido_GetOneResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Deta_Pedido_Insert")]
	public int Aba_Deta_Pedido_Insert([Parameter(Name = "IdMeta", DbType = "Char(6)")] string idMeta, [Parameter(Name = "IdBien", DbType = "Char(13)")] string idBien, [Parameter(Name = "IdPedido", DbType = "Char(6)")] string idPedido, [Parameter(Name = "Cantidad", DbType = "Decimal")] decimal? cantidad, [Parameter(Name = "Observaciones", DbType = "VarChar(120)")] string observaciones, [Parameter(Name = "MotivoRechazo", DbType = "VarChar(120)")] string motivoRechazo, [Parameter(Name = "Estado", DbType = "Char(1)")] char? estado, [Parameter(Name = "CantidadAprobada", DbType = "Decimal")] decimal? cantidadAprobada, [Parameter(Name = "Item", DbType = "Int")] int? item, [Parameter(Name = "Precio", DbType = "Decimal")] decimal? precio, [Parameter(Name = "Importe", DbType = "Decimal")] decimal? importe)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idMeta, idBien, idPedido, cantidad, observaciones, motivoRechazo, estado, cantidadAprobada, item, precio, importe);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Deta_pedido_PorConsolidado")]
	public ISingleResult<Aba_Deta_pedido_PorConsolidadoResult> Aba_Deta_pedido_PorConsolidado([Parameter(DbType = "Char(6)")] string idconsolidado)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idconsolidado);
		return (ISingleResult<Aba_Deta_pedido_PorConsolidadoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Deta_Pedido_Update")]
	public int Aba_Deta_Pedido_Update([Parameter(Name = "IdMeta", DbType = "Char(6)")] string idMeta, [Parameter(Name = "IdBien", DbType = "Char(13)")] string idBien, [Parameter(Name = "IdPedido", DbType = "Char(6)")] string idPedido, [Parameter(Name = "Cantidad", DbType = "Decimal")] decimal? cantidad, [Parameter(Name = "Observaciones", DbType = "VarChar(120)")] string observaciones, [Parameter(Name = "MotivoRechazo", DbType = "VarChar(120)")] string motivoRechazo, [Parameter(Name = "Estado", DbType = "Char(1)")] char? estado, [Parameter(Name = "CantidadAprobada", DbType = "Decimal")] decimal? cantidadAprobada, [Parameter(Name = "Item", DbType = "Int")] int? item, [Parameter(Name = "Precio", DbType = "Decimal")] decimal? precio, [Parameter(Name = "Importe", DbType = "Decimal")] decimal? importe)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idMeta, idBien, idPedido, cantidad, observaciones, motivoRechazo, estado, cantidadAprobada, item, precio, importe);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Familia_Delete")]
	public int Aba_Familia_Delete([Parameter(Name = "IdFamilia", DbType = "Char(4)")] string idFamilia, [Parameter(Name = "IdClase", DbType = "Char(2)")] string idClase, [Parameter(Name = "IdGrupo", DbType = "Char(3)")] string idGrupo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idFamilia, idClase, idGrupo);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Familia_GetAll")]
	public ISingleResult<Aba_Familia_GetAllResult> Aba_Familia_GetAll()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return (ISingleResult<Aba_Familia_GetAllResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Familia_GetByClase")]
	public ISingleResult<Aba_Familia_GetByClaseResult> Aba_Familia_GetByClase([Parameter(Name = "IdClase", DbType = "Char(2)")] string idClase, [Parameter(Name = "IdGrupo", DbType = "Char(3)")] string idGrupo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idClase, idGrupo);
		return (ISingleResult<Aba_Familia_GetByClaseResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Familia_GetOne")]
	public ISingleResult<Aba_Familia_GetOneResult> Aba_Familia_GetOne([Parameter(Name = "IdFamilia", DbType = "Char(4)")] string idFamilia, [Parameter(Name = "IdClase", DbType = "Char(2)")] string idClase, [Parameter(Name = "IdGrupo", DbType = "Char(3)")] string idGrupo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idFamilia, idClase, idGrupo);
		return (ISingleResult<Aba_Familia_GetOneResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Familia_Insert")]
	public int Aba_Familia_Insert([Parameter(Name = "IdFamilia", DbType = "Char(4)")] string idFamilia, [Parameter(Name = "Descripcion", DbType = "VarChar(140)")] string descripcion, [Parameter(Name = "Observaciones", DbType = "VarChar(120)")] string observaciones, [Parameter(Name = "IdClase", DbType = "Char(2)")] string idClase, [Parameter(Name = "IdGrupo", DbType = "Char(3)")] string idGrupo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idFamilia, descripcion, observaciones, idClase, idGrupo);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Familia_Update")]
	public int Aba_Familia_Update([Parameter(Name = "IdFamilia", DbType = "Char(4)")] string idFamilia, [Parameter(Name = "Descripcion", DbType = "VarChar(140)")] string descripcion, [Parameter(Name = "Observaciones", DbType = "VarChar(120)")] string observaciones, [Parameter(Name = "IdClase", DbType = "Char(2)")] string idClase, [Parameter(Name = "IdGrupo", DbType = "Char(3)")] string idGrupo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idFamilia, descripcion, observaciones, idClase, idGrupo);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Funcion_Delete")]
	public int Aba_Funcion_Delete([Parameter(Name = "IdFuncion", DbType = "Char(2)")] string idFuncion, [Parameter(Name = "Anio", DbType = "Char(4)")] string anio)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idFuncion, anio);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Funcion_GetAll")]
	public ISingleResult<Aba_Funcion_GetAllResult> Aba_Funcion_GetAll()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return (ISingleResult<Aba_Funcion_GetAllResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Funcion_GetOne")]
	public ISingleResult<Aba_Funcion_GetOneResult> Aba_Funcion_GetOne([Parameter(Name = "IdFuncion", DbType = "Char(2)")] string idFuncion, [Parameter(Name = "Anio", DbType = "Char(4)")] string anio)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idFuncion, anio);
		return (ISingleResult<Aba_Funcion_GetOneResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Funcion_Insert")]
	public int Aba_Funcion_Insert([Parameter(Name = "IdFuncion", DbType = "Char(2)")] string idFuncion, [Parameter(Name = "Anio", DbType = "Char(4)")] string anio, [Parameter(Name = "Descripcion", DbType = "VarChar(50)")] string descripcion)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idFuncion, anio, descripcion);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Funcion_Update")]
	public int Aba_Funcion_Update([Parameter(Name = "IdFuncion", DbType = "Char(2)")] string idFuncion, [Parameter(Name = "Anio", DbType = "Char(4)")] string anio, [Parameter(Name = "Descripcion", DbType = "VarChar(50)")] string descripcion)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idFuncion, anio, descripcion);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Grupo_Delete")]
	public int Aba_Grupo_Delete([Parameter(Name = "IdGrupo", DbType = "Char(3)")] string idGrupo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idGrupo);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Grupo_GetAll")]
	public ISingleResult<Aba_Grupo_GetAllResult> Aba_Grupo_GetAll()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return (ISingleResult<Aba_Grupo_GetAllResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Grupo_GetOne")]
	public ISingleResult<Aba_Grupo_GetOneResult> Aba_Grupo_GetOne([Parameter(Name = "IdGrupo", DbType = "Char(3)")] string idGrupo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idGrupo);
		return (ISingleResult<Aba_Grupo_GetOneResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Grupo_Insert")]
	public int Aba_Grupo_Insert([Parameter(Name = "IdGrupo", DbType = "Char(3)")] string idGrupo, [Parameter(Name = "Descripcion", DbType = "VarChar(120)")] string descripcion, [Parameter(Name = "Observaciones", DbType = "VarChar(120)")] string observaciones)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idGrupo, descripcion, observaciones);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Grupo_Update")]
	public int Aba_Grupo_Update([Parameter(Name = "IdGrupo", DbType = "Char(3)")] string idGrupo, [Parameter(Name = "Descripcion", DbType = "VarChar(120)")] string descripcion, [Parameter(Name = "Observaciones", DbType = "VarChar(120)")] string observaciones)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idGrupo, descripcion, observaciones);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.ABa_Meta_Area_Listar")]
	public ISingleResult<ABa_Meta_Area_ListarResult> ABa_Meta_Area_Listar([Parameter(DbType = "Char(6)")] string idmeta)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idmeta);
		return (ISingleResult<ABa_Meta_Area_ListarResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Meta_ListarAnio")]
	public ISingleResult<Aba_Meta_ListarAnioResult> Aba_Meta_ListarAnio([Parameter(Name = "Anio", DbType = "Char(4)")] string anio, [Parameter(DbType = "Char(100)")] string idcomponente)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), anio, idcomponente);
		return (ISingleResult<Aba_Meta_ListarAnioResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Meta_ListarSaldos")]
	public ISingleResult<Aba_Meta_ListarSaldosResult> Aba_Meta_ListarSaldos([Parameter(DbType = "Char(6)")] string idmeta)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idmeta);
		return (ISingleResult<Aba_Meta_ListarSaldosResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Movimiento_Listar")]
	public ISingleResult<Aba_Movimiento_ListarResult> Aba_Movimiento_Listar([Parameter(DbType = "Char(2)")] string idalmacen, [Parameter(DbType = "Char(2)")] string anio)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idalmacen, anio);
		return (ISingleResult<Aba_Movimiento_ListarResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Parametro_Periodo_Listar")]
	public ISingleResult<Aba_Parametro_Periodo_ListarResult> Aba_Parametro_Periodo_Listar([Parameter(DbType = "Char(6)")] string periodo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), periodo);
		return (ISingleResult<Aba_Parametro_Periodo_ListarResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Pedido_Delete")]
	public int Aba_Pedido_Delete([Parameter(Name = "IdPedido", DbType = "Char(6)")] string idPedido)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idPedido);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Pedido_GetAll")]
	public ISingleResult<Aba_Pedido_GetAllResult> Aba_Pedido_GetAll()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return (ISingleResult<Aba_Pedido_GetAllResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Pedido_GetOne")]
	public ISingleResult<Aba_Pedido_GetOneResult> Aba_Pedido_GetOne([Parameter(Name = "IdPedido", DbType = "Char(6)")] string idPedido)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idPedido);
		return (ISingleResult<Aba_Pedido_GetOneResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Pedido_Insert")]
	public int Aba_Pedido_Insert([Parameter(Name = "IdPedido", DbType = "Char(6)")] ref string idPedido, [Parameter(Name = "IdAreaOrganiz", DbType = "Int")] int? idAreaOrganiz, [Parameter(Name = "Fecha", DbType = "DateTime")] DateTime? fecha, [Parameter(Name = "Responsable", DbType = "Char(8)")] string responsable, [Parameter(Name = "Observaciones", DbType = "VarChar(120)")] string observaciones, [Parameter(Name = "Estado", DbType = "Char(2)")] string estado, [Parameter(Name = "FechaAprobacion", DbType = "DateTime")] DateTime? fechaAprobacion, [Parameter(Name = "FechaDespacho", DbType = "DateTime")] DateTime? fechaDespacho, [Parameter(Name = "Tipo", DbType = "Char(1)")] char? tipo, [Parameter(Name = "Anio", DbType = "Char(4)")] string anio, [Parameter(Name = "IdTipoDoc", DbType = "Char(2)")] string idTipoDoc, [Parameter(Name = "MontoPedido", DbType = "Decimal")] decimal? montoPedido, [Parameter(Name = "MontoAprobado", DbType = "Decimal")] decimal? montoAprobado, [Parameter(Name = "IdAreaUbicacion", DbType = "Int")] int? idAreaUbicacion, [Parameter(Name = "IdAreaAutorizacion", DbType = "Int")] int? idAreaAutorizacion, [Parameter(Name = "ObservacionesAprob", DbType = "VarChar(120)")] string observacionesAprob)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idPedido, idAreaOrganiz, fecha, responsable, observaciones, estado, fechaAprobacion, fechaDespacho, tipo, anio, idTipoDoc, montoPedido, montoAprobado, idAreaUbicacion, idAreaAutorizacion, observacionesAprob);
		idPedido = Conversions.ToString(result.GetParameterValue(0));
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Pedido_ListarPendientesConsolidar")]
	public ISingleResult<Aba_Pedido_ListarPendientesConsolidarResult> Aba_Pedido_ListarPendientesConsolidar([Parameter(DbType = "DateTime")] DateTime? fechade, [Parameter(DbType = "DateTime")] DateTime? fechaa)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), fechade, fechaa);
		return (ISingleResult<Aba_Pedido_ListarPendientesConsolidarResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Pedido_ListarPorEstado")]
	public ISingleResult<Aba_Pedido_ListarPorEstadoResult> Aba_Pedido_ListarPorEstado([Parameter(Name = "Tipo", DbType = "Char(1)")] char? tipo, [Parameter(Name = "Estado", DbType = "Char(2)")] string estado, [Parameter(Name = "EstadoDetalle", DbType = "Char(1)")] char? estadoDetalle, [Parameter(Name = "TipoDetalle", DbType = "Char(3)")] string tipoDetalle, [Parameter(Name = "Anio", DbType = "Char(4)")] string anio)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), tipo, estado, estadoDetalle, tipoDetalle, anio);
		return (ISingleResult<Aba_Pedido_ListarPorEstadoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Pedido_Update")]
	public int Aba_Pedido_Update([Parameter(Name = "IdPedido", DbType = "Char(6)")] string idPedido, [Parameter(Name = "IdAreaOrganiz", DbType = "Int")] int? idAreaOrganiz, [Parameter(Name = "Fecha", DbType = "DateTime")] DateTime? fecha, [Parameter(Name = "Responsable", DbType = "Char(8)")] string responsable, [Parameter(Name = "Estado", DbType = "Char(2)")] string estado, [Parameter(Name = "FechaAprobacion", DbType = "DateTime")] DateTime? fechaAprobacion, [Parameter(Name = "FechaDespacho", DbType = "DateTime")] DateTime? fechaDespacho, [Parameter(Name = "Tipo", DbType = "Char(1)")] char? tipo, [Parameter(Name = "Anio", DbType = "Char(4)")] string anio, [Parameter(Name = "IdTipoDoc", DbType = "Char(2)")] string idTipoDoc, [Parameter(Name = "MontoPedido", DbType = "Decimal")] decimal? montoPedido, [Parameter(Name = "MontoAprobado", DbType = "Decimal")] decimal? montoAprobado, [Parameter(Name = "IdAreaUbicacion", DbType = "Int")] int? idAreaUbicacion, [Parameter(Name = "IdAreaAutorizacion", DbType = "Int")] int? idAreaAutorizacion, [Parameter(Name = "Observaciones", DbType = "VarChar(120)")] string observaciones, [Parameter(Name = "ObservacionesAprob", DbType = "VarChar(120)")] string observacionesAprob)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idPedido, idAreaOrganiz, fecha, responsable, estado, fechaAprobacion, fechaDespacho, tipo, anio, idTipoDoc, montoPedido, montoAprobado, idAreaUbicacion, idAreaAutorizacion, observaciones, observacionesAprob);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Persona_Listar")]
	public ISingleResult<Aba_Persona_ListarResult> Aba_Persona_Listar([Parameter(DbType = "VarChar(80)")] string nombre, [Parameter(DbType = "Int")] int? tipodoc, [Parameter(DbType = "Char(14)")] string ruc, [Parameter(DbType = "Int")] int? tipo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), nombre, tipodoc, ruc, tipo);
		return (ISingleResult<Aba_Persona_ListarResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Programa_Delete")]
	public int Aba_Programa_Delete([Parameter(Name = "IdFuncion", DbType = "Char(2)")] string idFuncion, [Parameter(Name = "Anio", DbType = "Char(4)")] string anio, [Parameter(Name = "IdPrograma", DbType = "Char(3)")] string idPrograma)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idFuncion, anio, idPrograma);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Programa_GetAll")]
	public ISingleResult<Aba_Programa_GetAllResult> Aba_Programa_GetAll()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return (ISingleResult<Aba_Programa_GetAllResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Programa_GetByFuncion")]
	public ISingleResult<Aba_Programa_GetByFuncionResult> Aba_Programa_GetByFuncion([Parameter(Name = "IdFuncion", DbType = "Char(2)")] string idFuncion, [Parameter(Name = "Anio", DbType = "Char(4)")] string anio)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idFuncion, anio);
		return (ISingleResult<Aba_Programa_GetByFuncionResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Programa_GetOne")]
	public ISingleResult<Aba_Programa_GetOneResult> Aba_Programa_GetOne([Parameter(Name = "IdFuncion", DbType = "Char(2)")] string idFuncion, [Parameter(Name = "Anio", DbType = "Char(4)")] string anio, [Parameter(Name = "IdPrograma", DbType = "Char(3)")] string idPrograma)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idFuncion, anio, idPrograma);
		return (ISingleResult<Aba_Programa_GetOneResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Programa_Insert")]
	public int Aba_Programa_Insert([Parameter(Name = "IdFuncion", DbType = "Char(2)")] string idFuncion, [Parameter(Name = "Anio", DbType = "Char(4)")] string anio, [Parameter(Name = "IdPrograma", DbType = "Char(3)")] string idPrograma, [Parameter(Name = "Descripcion", DbType = "VarChar(80)")] string descripcion)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idFuncion, anio, idPrograma, descripcion);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Programa_Update")]
	public int Aba_Programa_Update([Parameter(Name = "IdFuncion", DbType = "Char(2)")] string idFuncion, [Parameter(Name = "Anio", DbType = "Char(4)")] string anio, [Parameter(Name = "IdPrograma", DbType = "Char(3)")] string idPrograma, [Parameter(Name = "Descripcion", DbType = "VarChar(80)")] string descripcion)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idFuncion, anio, idPrograma, descripcion);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_Proveedor_Listar")]
	public ISingleResult<Aba_Proveedor_ListarResult> Aba_Proveedor_Listar([Parameter(DbType = "VarChar(50)")] string nombre, [Parameter(DbType = "Char(12)")] string ruc, [Parameter(DbType = "Char(1)")] char? estado)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), nombre, ruc, estado);
		return (ISingleResult<Aba_Proveedor_ListarResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.aba_sp_Procedimiento_Req")]
	public ISingleResult<aba_sp_Procedimiento_ReqResult> aba_sp_Procedimiento_Req([Parameter(DbType = "Char(6)")] string codProc)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), codProc);
		return (ISingleResult<aba_sp_Procedimiento_ReqResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_SubPrograma_Delete")]
	public int Aba_SubPrograma_Delete([Parameter(Name = "IdFuncion", DbType = "Char(2)")] string idFuncion, [Parameter(Name = "Anio", DbType = "Char(4)")] string anio, [Parameter(Name = "IdPrograma", DbType = "Char(3)")] string idPrograma, [Parameter(Name = "IdSubPrograma", DbType = "Char(4)")] string idSubPrograma)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idFuncion, anio, idPrograma, idSubPrograma);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_SubPrograma_GetAll")]
	public ISingleResult<Aba_SubPrograma_GetAllResult> Aba_SubPrograma_GetAll()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return (ISingleResult<Aba_SubPrograma_GetAllResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_SubPrograma_GetByPrograma")]
	public ISingleResult<Aba_SubPrograma_GetByProgramaResult> Aba_SubPrograma_GetByPrograma([Parameter(Name = "IdFuncion", DbType = "Char(2)")] string idFuncion, [Parameter(Name = "Anio", DbType = "Char(4)")] string anio, [Parameter(Name = "IdPrograma", DbType = "Char(3)")] string idPrograma)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idFuncion, anio, idPrograma);
		return (ISingleResult<Aba_SubPrograma_GetByProgramaResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_SubPrograma_GetOne")]
	public ISingleResult<Aba_SubPrograma_GetOneResult> Aba_SubPrograma_GetOne([Parameter(Name = "IdFuncion", DbType = "Char(2)")] string idFuncion, [Parameter(Name = "Anio", DbType = "Char(4)")] string anio, [Parameter(Name = "IdPrograma", DbType = "Char(3)")] string idPrograma, [Parameter(Name = "IdSubPrograma", DbType = "Char(4)")] string idSubPrograma)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idFuncion, anio, idPrograma, idSubPrograma);
		return (ISingleResult<Aba_SubPrograma_GetOneResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_SubPrograma_Insert")]
	public int Aba_SubPrograma_Insert([Parameter(Name = "IdFuncion", DbType = "Char(2)")] string idFuncion, [Parameter(Name = "Anio", DbType = "Char(4)")] string anio, [Parameter(Name = "IdPrograma", DbType = "Char(3)")] string idPrograma, [Parameter(Name = "IdSubPrograma", DbType = "Char(4)")] string idSubPrograma, [Parameter(Name = "Descripcion", DbType = "VarChar(80)")] string descripcion)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idFuncion, anio, idPrograma, idSubPrograma, descripcion);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Aba_SubPrograma_Update")]
	public int Aba_SubPrograma_Update([Parameter(Name = "IdFuncion", DbType = "Char(2)")] string idFuncion, [Parameter(Name = "Anio", DbType = "Char(4)")] string anio, [Parameter(Name = "IdPrograma", DbType = "Char(3)")] string idPrograma, [Parameter(Name = "IdSubPrograma", DbType = "Char(4)")] string idSubPrograma, [Parameter(Name = "Descripcion", DbType = "VarChar(80)")] string descripcion)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idFuncion, anio, idPrograma, idSubPrograma, descripcion);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Actividad_Delete")]
	public int Actividad_Delete([Parameter(Name = "IdObjetivo", DbType = "Int")] int? idObjetivo, [Parameter(Name = "IdActividad", DbType = "Int")] int? idActividad)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idObjetivo, idActividad);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Actividad_GetAll")]
	public ISingleResult<Actividad_GetAllResult> Actividad_GetAll()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return (ISingleResult<Actividad_GetAllResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Actividad_GetOne")]
	public ISingleResult<Actividad_GetOneResult> Actividad_GetOne([Parameter(Name = "IdObjetivo", DbType = "Int")] int? idObjetivo, [Parameter(Name = "IdActividad", DbType = "Int")] int? idActividad)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idObjetivo, idActividad);
		return (ISingleResult<Actividad_GetOneResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Actividad_Insert")]
	public int Actividad_Insert([Parameter(Name = "IdObjetivo", DbType = "Int")] int? idObjetivo, [Parameter(Name = "IdActividad", DbType = "Int")] int? idActividad, [Parameter(Name = "NroActividad", DbType = "Int")] int? nroActividad, [Parameter(Name = "Actividad", DbType = "VarChar(300)")] string actividad, [Parameter(Name = "IdEmpleado", DbType = "Int")] int? idEmpleado, [Parameter(Name = "IdUnidMed", DbType = "Int")] int? idUnidMed, [Parameter(Name = "Meta", DbType = "Decimal")] decimal? meta, [Parameter(Name = "IsMeta", DbType = "VarChar(1)")] char? isMeta, [Parameter(Name = "MetaMin", DbType = "Decimal")] decimal? metaMin, [Parameter(Name = "TrabXActiv", DbType = "Int")] int? trabXActiv, [Parameter(Name = "HH", DbType = "Decimal")] decimal? hH, [Parameter(Name = "BienServ", DbType = "Decimal")] decimal? bienServ, [Parameter(Name = "Importancia", DbType = "Int")] int? importancia, [Parameter(Name = "Avance", DbType = "Decimal")] decimal? avance, [Parameter(Name = "AvanceAnual", DbType = "Decimal")] decimal? avanceAnual, [Parameter(Name = "FechaInicio", DbType = "SmallDateTime")] DateTime? fechaInicio, [Parameter(Name = "FechaFin", DbType = "SmallDateTime")] DateTime? fechaFin, [Parameter(Name = "UnidsOrgs", DbType = "VarChar(20)")] string unidsOrgs, [Parameter(Name = "IdPresupuesto", DbType = "Int")] int? idPresupuesto)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idObjetivo, idActividad, nroActividad, actividad, idEmpleado, idUnidMed, meta, isMeta, metaMin, trabXActiv, hH, bienServ, importancia, avance, avanceAnual, fechaInicio, fechaFin, unidsOrgs, idPresupuesto);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Actividad_Update")]
	public int Actividad_Update([Parameter(Name = "IdObjetivo", DbType = "Int")] int? idObjetivo, [Parameter(Name = "IdActividad", DbType = "Int")] int? idActividad, [Parameter(Name = "NroActividad", DbType = "Int")] int? nroActividad, [Parameter(Name = "Actividad", DbType = "VarChar(300)")] string actividad, [Parameter(Name = "IdEmpleado", DbType = "Int")] int? idEmpleado, [Parameter(Name = "IdUnidMed", DbType = "Int")] int? idUnidMed, [Parameter(Name = "Meta", DbType = "Decimal")] decimal? meta, [Parameter(Name = "IsMeta", DbType = "VarChar(1)")] char? isMeta, [Parameter(Name = "MetaMin", DbType = "Decimal")] decimal? metaMin, [Parameter(Name = "TrabXActiv", DbType = "Int")] int? trabXActiv, [Parameter(Name = "HH", DbType = "Decimal")] decimal? hH, [Parameter(Name = "BienServ", DbType = "Decimal")] decimal? bienServ, [Parameter(Name = "Importancia", DbType = "Int")] int? importancia, [Parameter(Name = "Avance", DbType = "Decimal")] decimal? avance, [Parameter(Name = "AvanceAnual", DbType = "Decimal")] decimal? avanceAnual, [Parameter(Name = "FechaInicio", DbType = "SmallDateTime")] DateTime? fechaInicio, [Parameter(Name = "FechaFin", DbType = "SmallDateTime")] DateTime? fechaFin, [Parameter(Name = "UnidsOrgs", DbType = "VarChar(20)")] string unidsOrgs, [Parameter(Name = "IdPresupuesto", DbType = "Int")] int? idPresupuesto)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idObjetivo, idActividad, nroActividad, actividad, idEmpleado, idUnidMed, meta, isMeta, metaMin, trabXActiv, hH, bienServ, importancia, avance, avanceAnual, fechaInicio, fechaFin, unidsOrgs, idPresupuesto);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.ANT_SP_BuscarAnticipo")]
	public ISingleResult<ANT_SP_BuscarAnticipoResult> ANT_SP_BuscarAnticipo([Parameter(Name = "IdAnticipo", DbType = "Char(10)")] string idAnticipo, [Parameter(Name = "IdEmpleado", DbType = "Char(10)")] string idEmpleado, [Parameter(Name = "Monto", DbType = "Money")] decimal? monto, [Parameter(Name = "Motivo", DbType = "Char(50)")] string motivo, [Parameter(Name = "Observacion", DbType = "Char(100)")] string observacion, [Parameter(Name = "FechaIni", DbType = "DateTime")] DateTime? fechaIni, [Parameter(Name = "FechaFin", DbType = "DateTime")] DateTime? fechaFin)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idAnticipo, idEmpleado, monto, motivo, observacion, fechaIni, fechaFin);
		return (ISingleResult<ANT_SP_BuscarAnticipoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.ANT_SP_BuscarMovimiento")]
	public ISingleResult<ANT_SP_BuscarMovimientoResult> ANT_SP_BuscarMovimiento([Parameter(Name = "IdMovimiento", DbType = "Char(10)")] string idMovimiento, [Parameter(Name = "IdAnticipo", DbType = "Char(10)")] string idAnticipo, [Parameter(Name = "Monto", DbType = "Money")] decimal? monto, [Parameter(Name = "Saldo", DbType = "Money")] decimal? saldo, [Parameter(Name = "FechaIni", DbType = "DateTime")] DateTime? fechaIni, [Parameter(Name = "FechaFin", DbType = "DateTime")] DateTime? fechaFin)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idMovimiento, idAnticipo, monto, saldo, fechaIni, fechaFin);
		return (ISingleResult<ANT_SP_BuscarMovimientoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.ExecFormulaC")]
	public int ExecFormulaC([Parameter(DbType = "VarChar(255)")] string cFormula, [Parameter(DbType = "VarChar(255)")] ref string cReturn)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), cFormula, cReturn);
		cReturn = Conversions.ToString(result.GetParameterValue(1));
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.ExecFormulaN")]
	public int ExecFormulaN([Parameter(DbType = "VarChar(255)")] string cFormula, [Parameter(DbType = "Decimal")] ref decimal? nReturn)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), cFormula, nReturn);
		object parameterValue = result.GetParameterValue(1);
		decimal? num = default(decimal?);
		nReturn = ((parameterValue != null) ? ((decimal?)parameterValue) : num);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.GetExecC")]
	public int GetExecC([Parameter(DbType = "VarChar(255)")] string cExec, [Parameter(DbType = "VarChar(255)")] ref string cReturn)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), cExec, cReturn);
		cReturn = Conversions.ToString(result.GetParameterValue(1));
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.GetExecN")]
	public int GetExecN([Parameter(DbType = "VarChar(255)")] string cExec, [Parameter(DbType = "Decimal")] ref decimal? nReturn)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), cExec, nReturn);
		object parameterValue = result.GetParameterValue(1);
		decimal? num = default(decimal?);
		nReturn = ((parameterValue != null) ? ((decimal?)parameterValue) : num);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.GRLL_Sistema_Listar")]
	public ISingleResult<GRLL_Sistema_ListarResult> GRLL_Sistema_Listar()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return (ISingleResult<GRLL_Sistema_ListarResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.GRLL_Usuario_Acceso")]
	public ISingleResult<GRLL_Usuario_AccesoResult> GRLL_Usuario_Acceso([Parameter(Name = "IdSistema", DbType = "Char(7)")] string idSistema, [Parameter(DbType = "Char(20)")] string login)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idSistema, login);
		return (ISingleResult<GRLL_Usuario_AccesoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.InsDetDist_nfilas")]
	public int InsDetDist_nfilas([Parameter(DbType = "Xml")] XElement myXML)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), myXML);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.InsDetOrd_nfilas")]
	public int InsDetOrd_nfilas([Parameter(DbType = "Xml")] XElement myXML)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), myXML);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.InsertFichaPers")]
	public int InsertFichaPers([Parameter(DbType = "VarChar(1000)")] string sCad)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), sCad);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.LINQ_sp_listartablas")]
	public ISingleResult<LINQ_sp_listartablasResult> LINQ_sp_listartablas()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return (ISingleResult<LINQ_sp_listartablasResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.p_Actividad")]
	public ISingleResult<p_ActividadResult> p_Actividad()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return (ISingleResult<p_ActividadResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.p_ActualizarEstraObj")]
	public int p_ActualizarEstraObj([Parameter(Name = "IdEstrategia", DbType = "Int")] int? idEstrategia, [Parameter(Name = "Estrategia", DbType = "VarChar(80)")] string estrategia, [Parameter(Name = "FechaInicio", DbType = "DateTime")] DateTime? fechaInicio, [Parameter(Name = "FechaCulminacion", DbType = "DateTime")] DateTime? fechaCulminacion, [Parameter(Name = "Objetivo", DbType = "VarChar(60)")] string objetivo, [Parameter(Name = "Id_Estrategia", DbType = "Int")] int? id_Estrategia)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idEstrategia, estrategia, fechaInicio, fechaCulminacion, objetivo, id_Estrategia);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.p_ActualizarEstrate")]
	public int p_ActualizarEstrate([Parameter(Name = "IdEstrategia", DbType = "Int")] int? idEstrategia, [Parameter(Name = "Estrategia", DbType = "VarChar(300)")] string estrategia, [Parameter(Name = "FechaInicio", DbType = "DateTime")] DateTime? fechaInicio, [Parameter(Name = "FechaCulminacion", DbType = "DateTime")] DateTime? fechaCulminacion)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idEstrategia, estrategia, fechaInicio, fechaCulminacion);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.p_ActualizarObj")]
	public int p_ActualizarObj([Parameter(Name = "IdObjetivo", DbType = "Int")] int? idObjetivo, [Parameter(Name = "Objetivo", DbType = "VarChar(60)")] string objetivo, [Parameter(Name = "FechaInicio", DbType = "DateTime")] DateTime? fechaInicio, [Parameter(Name = "FechaFin", DbType = "DateTime")] DateTime? fechaFin)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idObjetivo, objetivo, fechaInicio, fechaFin);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.p_DetalleActividad")]
	public int p_DetalleActividad()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.p_EstrategiaObj")]
	public int p_EstrategiaObj()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.p_InsertarDetalleActividad")]
	public int p_InsertarDetalleActividad([Parameter(Name = "Actividad", DbType = "VarChar(70)")] string actividad, [Parameter(Name = "Meta", DbType = "Int")] int? meta, [Parameter(DbType = "Int")] int? complejidad, [Parameter(DbType = "Int")] int? importancia, [Parameter(DbType = "Float")] double? cant_asignada, [Parameter(DbType = "Float")] double? presAsignado, [Parameter(DbType = "Float")] double? precio_unitario, [Parameter(DbType = "Float")] double? presup_propuesto, [Parameter(Name = "Id_Presupuesto", DbType = "Int")] int? id_Presupuesto, [Parameter(Name = "Id_Actividad", DbType = "Int")] int? id_Actividad, [Parameter(Name = "Material", DbType = "VarChar(20)")] string material, [Parameter(Name = "Tipo_recurso", DbType = "VarChar(20)")] string tipo_recurso, [Parameter(DbType = "Int")] int? cantidad, [Parameter(Name = "Id_Requerimiento", DbType = "Int")] int? id_Requerimiento)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), actividad, meta, complejidad, importancia, cant_asignada, presAsignado, precio_unitario, presup_propuesto, id_Presupuesto, id_Actividad, material, tipo_recurso, cantidad, id_Requerimiento);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.p_InsertarEstrat")]
	public int p_InsertarEstrat([Parameter(Name = "Estrategia", DbType = "VarChar(80)")] string estrategia, [Parameter(Name = "FechaInicio", DbType = "DateTime")] DateTime? fechaInicio, [Parameter(Name = "FechaCulminacion", DbType = "DateTime")] DateTime? fechaCulminacion, [Parameter(Name = "Objetivo", DbType = "VarChar(60)")] string objetivo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), estrategia, fechaInicio, fechaCulminacion, objetivo);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.p_InsertarEstrategia")]
	public int p_InsertarEstrategia([Parameter(Name = "Estrategia", DbType = "VarChar(80)")] string estrategia, [Parameter(Name = "FechaInicio", DbType = "DateTime")] DateTime? fechaInicio, [Parameter(Name = "FechaCulminacion", DbType = "DateTime")] DateTime? fechaCulminacion)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), estrategia, fechaInicio, fechaCulminacion);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.p_InsertarEstratObje")]
	public int p_InsertarEstratObje([Parameter(Name = "Estrategia", DbType = "VarChar(80)")] string estrategia, [Parameter(Name = "Objetivo", DbType = "VarChar(60)")] string objetivo, [Parameter(Name = "FechaInicio", DbType = "DateTime")] DateTime? fechaInicio, [Parameter(Name = "FechaCulminacion", DbType = "DateTime")] DateTime? fechaCulminacion, [Parameter(Name = "Id_Estrategia", DbType = "Int")] int? id_Estrategia)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), estrategia, objetivo, fechaInicio, fechaCulminacion, id_Estrategia);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.p_InsertarObjetivo")]
	public int p_InsertarObjetivo([Parameter(Name = "Objetivo", DbType = "VarChar(60)")] string objetivo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), objetivo);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.p_listaEstrategiaObj")]
	public ISingleResult<p_listaEstrategiaObjResult> p_listaEstrategiaObj()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return (ISingleResult<p_listaEstrategiaObjResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.p_ListDetaActividad")]
	public int p_ListDetaActividad()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.p_ListProgram")]
	public int p_ListProgram()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.p_ObjetivoActividad")]
	public ISingleResult<p_ObjetivoActividadResult> p_ObjetivoActividad()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return (ISingleResult<p_ObjetivoActividadResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.p_Programacion")]
	public int p_Programacion()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.p_sumaActividad")]
	public int p_sumaActividad()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.PTI_SP_UpDate_Empleado_Area")]
	public int PTI_SP_UpDate_Empleado_Area([Parameter(DbType = "Int")] int? idareaorganiz, [Parameter(DbType = "Int")] int? idempleado, [Parameter(DbType = "Int")] int? year)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idareaorganiz, idempleado, year);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.SIAB_Migracion_Actividades")]
	public int SIAB_Migracion_Actividades([Parameter(DbType = "Char(4)")] string anio)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), anio);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.SIAB_Migracion_Bienes")]
	public int SIAB_Migracion_Bienes()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.SIAB_Migracion_Componentes")]
	public int SIAB_Migracion_Componentes([Parameter(DbType = "Char(4)")] string anio)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), anio);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.SIAB_Migracion_DetalleDistribucion")]
	public int SIAB_Migracion_DetalleDistribucion([Parameter(DbType = "Char(8)")] string idorden, [Parameter(DbType = "Char(13)")] string idbien)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idorden, idbien);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.SIAB_Migracion_DetalleOrden")]
	public int SIAB_Migracion_DetalleOrden([Parameter(DbType = "Char(8)")] string idorden)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idorden);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.SIAB_Migracion_Metas")]
	public int SIAB_Migracion_Metas([Parameter(Name = "Anio", DbType = "Char(4)")] string anio)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), anio);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.SIAB_Migracion_OrdenCompra")]
	public int SIAB_Migracion_OrdenCompra([Parameter(Name = "Anio", DbType = "Char(4)")] string anio)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), anio);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.SIAB_Migracion_Proveedor")]
	public int SIAB_Migracion_Proveedor()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.sp_aba_BuscarBien")]
	public ISingleResult<sp_aba_BuscarBienResult> sp_aba_BuscarBien([Parameter(DbType = "Char(13)")] string idbien)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idbien);
		return (ISingleResult<sp_aba_BuscarBienResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.sp_aba_BuscarGasto")]
	public ISingleResult<sp_aba_BuscarGastoResult> sp_aba_BuscarGasto([Parameter(DbType = "VarChar(17)")] string idgasto)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idgasto);
		return (ISingleResult<sp_aba_BuscarGastoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.sp_aba_Corre_CodMeta")]
	public ISingleResult<sp_aba_Corre_CodMetaResult> sp_aba_Corre_CodMeta([Parameter(DbType = "Char(2)")] string idFuncion, [Parameter(DbType = "Char(3)")] string idPrograma, [Parameter(DbType = "Char(4)")] string idSubPrograma, [Parameter(DbType = "Char(7)")] string idActividad, [Parameter(DbType = "Char(7)")] string idComponente)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idFuncion, idPrograma, idSubPrograma, idActividad, idComponente);
		return (ISingleResult<sp_aba_Corre_CodMetaResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.SP_ABA_FILTRAR_BIEN_TIPO")]
	public ISingleResult<SP_ABA_FILTRAR_BIEN_TIPOResult> SP_ABA_FILTRAR_BIEN_TIPO([Parameter(Name = "IDBIEN", DbType = "Char(13)")] string iDBIEN)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), iDBIEN);
		return (ISingleResult<SP_ABA_FILTRAR_BIEN_TIPOResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.SP_ABA_FILTRARMETA")]
	public ISingleResult<SP_ABA_FILTRARMETAResult> SP_ABA_FILTRARMETA([Parameter(Name = "ANIO", DbType = "Char(4)")] string aNIO, [Parameter(Name = "IDMETA", DbType = "Char(6)")] string iDMETA)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), aNIO, iDMETA);
		return (ISingleResult<SP_ABA_FILTRARMETAResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.sp_ABA_ImpDetOrdenCBien")]
	public ISingleResult<sp_ABA_ImpDetOrdenCBienResult> sp_ABA_ImpDetOrdenCBien([Parameter(Name = "IdOrden", DbType = "Char(8)")] string idOrden, [Parameter(Name = "TipoOrden", DbType = "Char(1)")] char? tipoOrden)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idOrden, tipoOrden);
		return (ISingleResult<sp_ABA_ImpDetOrdenCBienResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.sp_ABA_ImpOrdenCBien")]
	public ISingleResult<sp_ABA_ImpOrdenCBienResult> sp_ABA_ImpOrdenCBien([Parameter(Name = "IdOrden", DbType = "Char(8)")] string idOrden, [Parameter(Name = "TipoOrden", DbType = "Char(1)")] char? tipoOrden)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idOrden, tipoOrden);
		return (ISingleResult<sp_ABA_ImpOrdenCBienResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.sp_aba_Insert_NROWS")]
	public int sp_aba_Insert_NROWS([Parameter(DbType = "Xml")] XElement myXML)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), myXML);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.sp_aba_NroMaxPer")]
	public ISingleResult<sp_aba_NroMaxPerResult> sp_aba_NroMaxPer([Parameter(DbType = "Char(1)")] char? tipoPer)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), tipoPer);
		return (ISingleResult<sp_aba_NroMaxPerResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.sp_aba_OrdenDetalle")]
	public ISingleResult<sp_aba_OrdenDetalleResult> sp_aba_OrdenDetalle([Parameter(Name = "TipoOrden", DbType = "Char(1)")] char? tipoOrden, [Parameter(Name = "IdOrden", DbType = "Char(8)")] string idOrden)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), tipoOrden, idOrden);
		return (ISingleResult<sp_aba_OrdenDetalleResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.sp_aba_UpDate_NROWS")]
	public int sp_aba_UpDate_NROWS([Parameter(DbType = "Xml")] XElement myXML)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), myXML);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.sp_aba_usuario_areaO")]
	public ISingleResult<sp_aba_usuario_areaOResult> sp_aba_usuario_areaO([Parameter(DbType = "Int")] int? anio, [Parameter(DbType = "Char(20)")] string login)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), anio, login);
		return (ISingleResult<sp_aba_usuario_areaOResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.sp_AbaNroMaxMovimiento")]
	public ISingleResult<sp_AbaNroMaxMovimientoResult> sp_AbaNroMaxMovimiento([Parameter(DbType = "Char(2)")] string anio)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), anio);
		return (ISingleResult<sp_AbaNroMaxMovimientoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.sp_busca_empleado")]
	public int sp_busca_empleado([Parameter(DbType = "Int")] int? idempleado, [Parameter(Name = "NumdocId", DbType = "VarChar(12)")] string numdocId, [Parameter(Name = "Apellido_Paterno", DbType = "VarChar(30)")] string apellido_Paterno, [Parameter(DbType = "Bit")] bool? activo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idempleado, numdocId, apellido_Paterno, activo);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.sp_prueba")]
	public ISingleResult<sp_pruebaResult> sp_prueba([Parameter(DbType = "Char(8)")] string fi, [Parameter(DbType = "Char(8)")] string ff)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), fi, ff);
		return (ISingleResult<sp_pruebaResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.sp_Rep_Principal")]
	public ISingleResult<sp_Rep_PrincipalResult> sp_Rep_Principal([Parameter(DbType = "NVarChar(200)")] string autor, [Parameter(DbType = "Int")] int? idOperador, [Parameter(Name = "IIniciativa", DbType = "DateTime")] DateTime? iIniciativa, [Parameter(Name = "FIniciativa", DbType = "DateTime")] DateTime? fIniciativa, [Parameter(Name = "INorma", DbType = "NVarChar(10)")] string iNorma, [Parameter(Name = "FNorma", DbType = "NVarChar(10)")] string fNorma, [Parameter(DbType = "Int")] int? idTipoProyec, [Parameter(DbType = "Int")] int? idTipoNorma)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), autor, idOperador, iIniciativa, fIniciativa, iNorma, fNorma, idTipoProyec, idTipoNorma);
		return (ISingleResult<sp_Rep_PrincipalResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.sp_RRHH_Busca_Empleado_tree")]
	public ISingleResult<sp_RRHH_Busca_Empleado_treeResult> sp_RRHH_Busca_Empleado_tree([Parameter(DbType = "Int")] int? idAreaOrganiz, [Parameter(DbType = "Int")] int? year, [Parameter(DbType = "Bit")] bool? estado, [Parameter(DbType = "Int")] int? tipotrabajador)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idAreaOrganiz, year, estado, tipotrabajador);
		return (ISingleResult<sp_RRHH_Busca_Empleado_treeResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.sp_snp_empleado_id")]
	public int sp_snp_empleado_id()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.sp_snp_persona_mover")]
	public int sp_snp_persona_mover()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.SP_Tra_Art_Nro")]
	public ISingleResult<SP_Tra_Art_NroResult> SP_Tra_Art_Nro([Parameter(Name = "Nro_Acuerdo", DbType = "NChar(10)")] string nro_Acuerdo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), nro_Acuerdo);
		return (ISingleResult<SP_Tra_Art_NroResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.sp_Tra_BuscarTramite")]
	public ISingleResult<sp_Tra_BuscarTramiteResult> sp_Tra_BuscarTramite([Parameter(DbType = "Char(8)")] string idTramite, [Parameter(DbType = "Char(6)")] string idProcedimiento, [Parameter(DbType = "Char(8)")] string idDocumento, [Parameter(DbType = "Char(2)")] string idTipoDoc, [Parameter(DbType = "Int")] int? idAreaOrganiz, [Parameter(Name = "MotivoRechazo", DbType = "VarChar(200)")] string motivoRechazo, [Parameter(Name = "PersonaRechazo", DbType = "Int")] int? personaRechazo, [Parameter(Name = "AreaRechazo", DbType = "Int")] int? areaRechazo, [Parameter(Name = "Estado", DbType = "Char(2)")] string estado, [Parameter(Name = "Asunto", DbType = "VarChar(250)")] string asunto, [Parameter(Name = "Referencia", DbType = "VarChar(250)")] string referencia, [Parameter(Name = "FechaAprobacion1", DbType = "DateTime")] DateTime? fechaAprobacion1, [Parameter(Name = "FechaAprobacion2", DbType = "DateTime")] DateTime? fechaAprobacion2, [Parameter(Name = "FechaRechazo1", DbType = "DateTime")] DateTime? fechaRechazo1, [Parameter(Name = "FechaRechazo2", DbType = "DateTime")] DateTime? fechaRechazo2, [Parameter(DbType = "DateTime")] DateTime? fechaIni, [Parameter(DbType = "DateTime")] DateTime? fechaFin)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idTramite, idProcedimiento, idDocumento, idTipoDoc, idAreaOrganiz, motivoRechazo, personaRechazo, areaRechazo, estado, asunto, referencia, fechaAprobacion1, fechaAprobacion2, fechaRechazo1, fechaRechazo2, fechaIni, fechaFin);
		return (ISingleResult<sp_Tra_BuscarTramiteResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.sp_tra_MaxIdRequisito")]
	public ISingleResult<sp_tra_MaxIdRequisitoResult> sp_tra_MaxIdRequisito()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return (ISingleResult<sp_tra_MaxIdRequisitoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.sp_Tra_TRA_ListarMovimiento")]
	public ISingleResult<sp_Tra_TRA_ListarMovimientoResult> sp_Tra_TRA_ListarMovimiento([Parameter(DbType = "Int")] int? idtramite)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idtramite);
		return (ISingleResult<sp_Tra_TRA_ListarMovimientoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.sp_Tra_TraListarTramite")]
	public ISingleResult<sp_Tra_TraListarTramiteResult> sp_Tra_TraListarTramite()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return (ISingleResult<sp_Tra_TraListarTramiteResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.sp_Tra_Usuario_AreaCargo")]
	public ISingleResult<sp_Tra_Usuario_AreaCargoResult> sp_Tra_Usuario_AreaCargo([Parameter(Name = "Login", DbType = "Char(20)")] string login)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), login);
		return (ISingleResult<sp_Tra_Usuario_AreaCargoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.sp_Tra_vs_TRA_ListarMovimiento")]
	public ISingleResult<sp_Tra_vs_TRA_ListarMovimientoResult> sp_Tra_vs_TRA_ListarMovimiento([Parameter(DbType = "Int")] int? idArea, [Parameter(DbType = "Int")] int? idcargo, [Parameter(DbType = "Char(2)")] string estado, [Parameter(DbType = "SmallDateTime")] DateTime? fIni, [Parameter(DbType = "SmallDateTime")] DateTime? fFin)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idArea, idcargo, estado, fIni, fFin);
		return (ISingleResult<sp_Tra_vs_TRA_ListarMovimientoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.sp_Tra_vs_TRA_ListarMovimientoTiempoXEstado")]
	public ISingleResult<sp_Tra_vs_TRA_ListarMovimientoTiempoXEstadoResult> sp_Tra_vs_TRA_ListarMovimientoTiempoXEstado([Parameter(DbType = "Int")] int? idArea, [Parameter(DbType = "Int")] int? idcargo, [Parameter(DbType = "Char(2)")] string estado, [Parameter(DbType = "SmallDateTime")] DateTime? fIni, [Parameter(DbType = "SmallDateTime")] DateTime? fFin)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idArea, idcargo, estado, fIni, fFin);
		return (ISingleResult<sp_Tra_vs_TRA_ListarMovimientoTiempoXEstadoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.sp_Tra_vs_TRA_ListarMovimientoXEstado")]
	public ISingleResult<sp_Tra_vs_TRA_ListarMovimientoXEstadoResult> sp_Tra_vs_TRA_ListarMovimientoXEstado([Parameter(DbType = "Int")] int? idArea, [Parameter(DbType = "Int")] int? idcargo, [Parameter(DbType = "Char(2)")] string estado, [Parameter(DbType = "SmallDateTime")] DateTime? fIni, [Parameter(DbType = "SmallDateTime")] DateTime? fFin)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idArea, idcargo, estado, fIni, fFin);
		return (ISingleResult<sp_Tra_vs_TRA_ListarMovimientoXEstadoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.sp_Tra_VS_TRA_ListarTramite")]
	public ISingleResult<sp_Tra_VS_TRA_ListarTramiteResult> sp_Tra_VS_TRA_ListarTramite([Parameter(DbType = "Int")] int? idArea, [Parameter(DbType = "Int")] int? idCargo, [Parameter(DbType = "SmallDateTime")] DateTime? fIni, [Parameter(DbType = "SmallDateTime")] DateTime? fFin)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idArea, idCargo, fIni, fFin);
		return (ISingleResult<sp_Tra_VS_TRA_ListarTramiteResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spActividad")]
	public int spActividad([Parameter(Name = "IdObjetivo", DbType = "Int")] int? idObjetivo, [Parameter(Name = "IdActividad", DbType = "Int")] int? idActividad, [Parameter(Name = "NroActividad", DbType = "Int")] int? nroActividad, [Parameter(Name = "Actividad", DbType = "VarChar(300)")] string actividad, [Parameter(Name = "IdEmpleado", DbType = "Int")] int? idEmpleado, [Parameter(Name = "IdUnidMed", DbType = "Int")] int? idUnidMed, [Parameter(Name = "Meta", DbType = "Decimal")] decimal? meta, [Parameter(Name = "IsMeta", DbType = "VarChar(1)")] char? isMeta, [Parameter(Name = "MetaMin", DbType = "Decimal")] decimal? metaMin, [Parameter(Name = "TrabXActiv", DbType = "Int")] int? trabXActiv, [Parameter(Name = "HH", DbType = "Decimal")] decimal? hH, [Parameter(Name = "BienServ", DbType = "Decimal")] decimal? bienServ, [Parameter(Name = "Importancia", DbType = "Int")] int? importancia, [Parameter(Name = "Avance", DbType = "Decimal")] decimal? avance, [Parameter(Name = "AvanceAnual", DbType = "Decimal")] decimal? avanceAnual, [Parameter(Name = "FechaInicio", DbType = "SmallDateTime")] DateTime? fechaInicio, [Parameter(Name = "FechaFin", DbType = "SmallDateTime")] DateTime? fechaFin, [Parameter(Name = "UnidsOrgs", DbType = "VarChar(20)")] string unidsOrgs, [Parameter(Name = "IdPresupuesto", DbType = "Int")] int? idPresupuesto, [Parameter(Name = "Observacion", DbType = "VarChar(500)")] string observacion)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idObjetivo, idActividad, nroActividad, actividad, idEmpleado, idUnidMed, meta, isMeta, metaMin, trabXActiv, hH, bienServ, importancia, avance, avanceAnual, fechaInicio, fechaFin, unidsOrgs, idPresupuesto, observacion);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spActividad_Exp")]
	public ISingleResult<spActividad_ExpResult> spActividad_Exp([Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(DbType = "Int")] int? idAreaOrganiz, [Parameter(Name = "IdObjetivo", DbType = "Int")] int? idObjetivo, [Parameter(Name = "IdActividad", DbType = "Int")] int? idActividad)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), year, idAreaOrganiz, idObjetivo, idActividad);
		return (ISingleResult<spActividad_ExpResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spActividad_InversPublicMax")]
	public ISingleResult<spActividad_InversPublicMaxResult> spActividad_InversPublicMax([Parameter(Name = "IdObjetivo", DbType = "Int")] int? idObjetivo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idObjetivo);
		return (ISingleResult<spActividad_InversPublicMaxResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spActividad_Select")]
	public ISingleResult<spActividad_SelectResult> spActividad_Select([Parameter(Name = "IdObjetivo", DbType = "Int")] int? idObjetivo, [Parameter(Name = "IdActividad", DbType = "Int")] int? idActividad)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idObjetivo, idActividad);
		return (ISingleResult<spActividad_SelectResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spActividad_Select_YearUO")]
	public int spActividad_Select_YearUO([Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(DbType = "Int")] int? idAreaOrganiz)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), year, idAreaOrganiz);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spActividadDel")]
	public int spActividadDel([Parameter(Name = "IdObjetivo", DbType = "Int")] int? idObjetivo, [Parameter(Name = "IdActividad", DbType = "Int")] int? idActividad)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idObjetivo, idActividad);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spBien_Exp")]
	public ISingleResult<spBien_ExpResult> spBien_Exp([Parameter(Name = "IdBien", DbType = "VarChar(13)")] string idBien, [Parameter(Name = "Tipo", DbType = "VarChar(1)")] char? tipo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idBien, tipo);
		return (ISingleResult<spBien_ExpResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spBien_Select")]
	public ISingleResult<spBien_SelectResult> spBien_Select([Parameter(Name = "IdBien", DbType = "VarChar(13)")] string idBien, [Parameter(Name = "Tipo", DbType = "VarChar(1)")] char? tipo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idBien, tipo);
		return (ISingleResult<spBien_SelectResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJ_Banco")]
	public int spCJ_Banco([Parameter(Name = "IdBanco", DbType = "Int")] ref int? idBanco, [Parameter(Name = "Nombre", DbType = "VarChar(50)")] string nombre, [Parameter(Name = "Abreviatura", DbType = "VarChar(10)")] string abreviatura, [Parameter(Name = "IdUbigeo", DbType = "VarChar(6)")] string idUbigeo, [Parameter(Name = "Direccion", DbType = "VarChar(80)")] string direccion)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idBanco, nombre, abreviatura, idUbigeo, direccion);
		object parameterValue = result.GetParameterValue(0);
		int? num = default(int?);
		idBanco = ((parameterValue != null) ? ((int?)parameterValue) : num);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spCJ_Banco_Select")]
	public ISingleResult<spCJ_Banco_SelectResult> spCJ_Banco_Select([Parameter(Name = "IdBanco", DbType = "Int")] int? idBanco)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idBanco);
		return (ISingleResult<spCJ_Banco_SelectResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJ_ChequeCaj")]
	public int spCJ_ChequeCaj([Parameter(Name = "IdCheque", DbType = "Int")] ref int? idCheque, [Parameter(Name = "IdBanco", DbType = "Int")] int? idBanco, [Parameter(Name = "NroCheque", DbType = "VarChar(15)")] string nroCheque, [Parameter(Name = "GiradorNro", DbType = "VarChar(15)")] string giradorNro, [Parameter(Name = "Plaza", DbType = "VarChar(1)")] char? plaza, [Parameter(Name = "Total", DbType = "Decimal")] decimal? total, [Parameter(Name = "Estado", DbType = "VarChar(1)")] char? estado, [Parameter(Name = "IdTipoMoneda", DbType = "Int")] int? idTipoMoneda)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idCheque, idBanco, nroCheque, giradorNro, plaza, total, estado, idTipoMoneda);
		object parameterValue = result.GetParameterValue(0);
		int? num = default(int?);
		idCheque = ((parameterValue != null) ? ((int?)parameterValue) : num);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spCJ_ChequeCaj_Select")]
	public ISingleResult<spCJ_ChequeCaj_SelectResult> spCJ_ChequeCaj_Select([Parameter(Name = "IdCheque", DbType = "Int")] int? idCheque, [Parameter(Name = "IdBanco", DbType = "Int")] int? idBanco, [Parameter(Name = "NroCheque", DbType = "VarChar(15)")] string nroCheque)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idCheque, idBanco, nroCheque);
		return (ISingleResult<spCJ_ChequeCaj_SelectResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJ_ClasificadorIngreso")]
	public int spCJ_ClasificadorIngreso([Parameter(Name = "Years", DbType = "Int")] ref int? years, [Parameter(Name = "Codigo", DbType = "Int")] ref int? codigo, [Parameter(Name = "CodigoClasif", DbType = "VarChar(3)")] string codigoClasif, [Parameter(Name = "Nombre", DbType = "VarChar(200)")] string nombre, [Parameter(Name = "Estado", DbType = "VarChar(1)")] char? estado, [Parameter(Name = "EsPresupuesto", DbType = "VarChar(1)")] char? esPresupuesto, [Parameter(Name = "YearsDe", DbType = "Int")] int? yearsDe, [Parameter(Name = "CodigoDe", DbType = "Int")] int? codigoDe)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), years, codigo, codigoClasif, nombre, estado, esPresupuesto, yearsDe, codigoDe);
		object parameterValue = result.GetParameterValue(0);
		int? num = default(int?);
		years = ((parameterValue != null) ? ((int?)parameterValue) : num);
		object parameterValue2 = result.GetParameterValue(1);
		codigo = ((parameterValue2 != null) ? ((int?)parameterValue2) : num);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spCJ_DetFacturaCaj")]
	public int spCJ_DetFacturaCaj([Parameter(Name = "Serie", DbType = "VarChar(4)")] string serie, [Parameter(Name = "Factura", DbType = "VarChar(6)")] string factura, [Parameter(Name = "IdDetFact", DbType = "Int")] int? idDetFact, [Parameter(Name = "Cantidad", DbType = "Decimal")] decimal? cantidad, [Parameter(Name = "UnidMedida", DbType = "VarChar(6)")] string unidMedida, [Parameter(Name = "Descripcion", DbType = "VarChar(500)")] string descripcion, [Parameter(Name = "PrecioUnit", DbType = "Decimal")] decimal? precioUnit)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), serie, factura, idDetFact, cantidad, unidMedida, descripcion, precioUnit);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spCJ_FacturaCaj")]
	public int spCJ_FacturaCaj([Parameter(Name = "Serie", DbType = "VarChar(4)")] string serie, [Parameter(Name = "Factura", DbType = "VarChar(6)")] string factura, [Parameter(Name = "IdPersona", DbType = "Int")] int? idPersona, [Parameter(Name = "NroIngreso", DbType = "Int")] int? nroIngreso, [Parameter(Name = "Total", DbType = "Decimal")] decimal? total, [Parameter(Name = "IGV", DbType = "Decimal")] decimal? iGV, [Parameter(Name = "Estado", DbType = "VarChar(1)")] char? estado, [Parameter(Name = "Years", DbType = "Int")] int? years)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), serie, factura, idPersona, nroIngreso, total, iGV, estado, years);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spCJ_FacturaCaj_Select")]
	public ISingleResult<spCJ_FacturaCaj_SelectResult> spCJ_FacturaCaj_Select([Parameter(Name = "Serie", DbType = "VarChar(4)")] string serie, [Parameter(Name = "Factura", DbType = "VarChar(6)")] string factura)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), serie, factura);
		return (ISingleResult<spCJ_FacturaCaj_SelectResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJ_FacturaCaj_SelectFech")]
	public ISingleResult<spCJ_FacturaCaj_SelectFechResult> spCJ_FacturaCaj_SelectFech([Parameter(Name = "FechaIng1", DbType = "DateTime")] DateTime? fechaIng1, [Parameter(Name = "FechaIng2", DbType = "DateTime")] DateTime? fechaIng2)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), fechaIng1, fechaIng2);
		return (ISingleResult<spCJ_FacturaCaj_SelectFechResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJ_FacturaCaj_SelectProv")]
	public ISingleResult<spCJ_FacturaCaj_SelectProvResult> spCJ_FacturaCaj_SelectProv([Parameter(Name = "Nombres", DbType = "VarChar(100)")] string nombres)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), nombres);
		return (ISingleResult<spCJ_FacturaCaj_SelectProvResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJ_IngresoCaj")]
	public int spCJ_IngresoCaj([Parameter(Name = "IdPersona", DbType = "Int")] int? idPersona, [Parameter(Name = "NroIngreso", DbType = "Int")] int? nroIngreso, [Parameter(Name = "Detalle", DbType = "VarChar(500)")] string detalle, [Parameter(Name = "Importe", DbType = "Decimal")] decimal? importe, [Parameter(Name = "IdTipoMoneda", DbType = "Int")] int? idTipoMoneda, [Parameter(Name = "FechaIng", DbType = "SmallDateTime")] DateTime? fechaIng, [Parameter(Name = "Estado", DbType = "VarChar(1)")] char? estado, [Parameter(Name = "Efectivo", DbType = "Decimal")] decimal? efectivo, [Parameter(Name = "Observacion", DbType = "VarChar(500)")] string observacion, [Parameter(Name = "IdBanco", DbType = "Int")] int? idBanco, [Parameter(Name = "NroPapeleta", DbType = "VarChar(10)")] string nroPapeleta, [Parameter(Name = "Debe", DbType = "Int")] int? debe, [Parameter(Name = "Years", DbType = "Int")] int? years, [Parameter(Name = "Codigo", DbType = "Int")] int? codigo, [Parameter(Name = "Haber", DbType = "Int")] int? haber, [Parameter(Name = "TotalDebe", DbType = "Decimal")] decimal? totalDebe, [Parameter(Name = "TotalHaber", DbType = "Decimal")] decimal? totalHaber, [Parameter(Name = "IdTransferencia", DbType = "Int")] int? idTransferencia, [Parameter(Name = "IdReferencia", DbType = "Int")] int? idReferencia, [Parameter(Name = "IdCheque", DbType = "Int")] int? idCheque)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idPersona, nroIngreso, detalle, importe, idTipoMoneda, fechaIng, estado, efectivo, observacion, idBanco, nroPapeleta, debe, years, codigo, haber, totalDebe, totalHaber, idTransferencia, idReferencia, idCheque);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spCJ_IngresoCaj_CON_Papeleta")]
	public ISingleResult<spCJ_IngresoCaj_CON_PapeletaResult> spCJ_IngresoCaj_CON_Papeleta([Parameter(Name = "IdBanco", DbType = "Int")] int? idBanco, [Parameter(Name = "NroPapeleta", DbType = "VarChar(10)")] string nroPapeleta)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idBanco, nroPapeleta);
		return (ISingleResult<spCJ_IngresoCaj_CON_PapeletaResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJ_IngresoCaj_Select")]
	public ISingleResult<spCJ_IngresoCaj_SelectResult> spCJ_IngresoCaj_Select([Parameter(Name = "Years", DbType = "Int")] int? years, [Parameter(Name = "NroIngreso", DbType = "Int")] int? nroIngreso, [Parameter(Name = "Nombres", DbType = "VarChar(100)")] string nombres)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), years, nroIngreso, nombres);
		return (ISingleResult<spCJ_IngresoCaj_SelectResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJ_IngresoCaj_SelectFech")]
	public ISingleResult<spCJ_IngresoCaj_SelectFechResult> spCJ_IngresoCaj_SelectFech([Parameter(Name = "FechaIng1", DbType = "DateTime")] DateTime? fechaIng1, [Parameter(Name = "FechaIng2", DbType = "DateTime")] DateTime? fechaIng2)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), fechaIng1, fechaIng2);
		return (ISingleResult<spCJ_IngresoCaj_SelectFechResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJ_IngresoCaj_SIN_Papeleta")]
	public ISingleResult<spCJ_IngresoCaj_SIN_PapeletaResult> spCJ_IngresoCaj_SIN_Papeleta()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return (ISingleResult<spCJ_IngresoCaj_SIN_PapeletaResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJ_NroCuenta")]
	public int spCJ_NroCuenta([Parameter(Name = "IdBanco", DbType = "Int")] ref int? idBanco, [Parameter(Name = "NroCta", DbType = "VarChar(12)")] string nroCta, [Parameter(Name = "IdTipoMoneda", DbType = "Int")] int? idTipoMoneda, [Parameter(Name = "Estado", DbType = "VarChar(1)")] char? estado)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idBanco, nroCta, idTipoMoneda, estado);
		object parameterValue = result.GetParameterValue(0);
		int? num = default(int?);
		idBanco = ((parameterValue != null) ? ((int?)parameterValue) : num);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spCJ_NroCuenta_Select")]
	public ISingleResult<spCJ_NroCuenta_SelectResult> spCJ_NroCuenta_Select([Parameter(Name = "IdBanco", DbType = "Int")] int? idBanco, [Parameter(Name = "NroCta", DbType = "VarChar(12)")] string nroCta, [Parameter(Name = "Estado", DbType = "VarChar(1)")] char? estado)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idBanco, nroCta, estado);
		return (ISingleResult<spCJ_NroCuenta_SelectResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJ_PapeletDepositCajSelectF")]
	public ISingleResult<spCJ_PapeletDepositCajSelectFResult> spCJ_PapeletDepositCajSelectF([Parameter(Name = "FechaPapelDep", DbType = "SmallDateTime")] DateTime? fechaPapelDep)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), fechaPapelDep);
		return (ISingleResult<spCJ_PapeletDepositCajSelectFResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJ_PapeletDepositCajSelectFF")]
	public ISingleResult<spCJ_PapeletDepositCajSelectFFResult> spCJ_PapeletDepositCajSelectFF([Parameter(Name = "Fecha1", DbType = "SmallDateTime")] DateTime? fecha1, [Parameter(Name = "Fecha2", DbType = "SmallDateTime")] DateTime? fecha2, [Parameter(Name = "Deposito", DbType = "Int")] int? deposito)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), fecha1, fecha2, deposito);
		return (ISingleResult<spCJ_PapeletDepositCajSelectFFResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJ_PapeletDepositCajSelectNroP")]
	public ISingleResult<spCJ_PapeletDepositCajSelectNroPResult> spCJ_PapeletDepositCajSelectNroP([Parameter(Name = "NroPapeleta", DbType = "VarChar(10)")] string nroPapeleta)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), nroPapeleta);
		return (ISingleResult<spCJ_PapeletDepositCajSelectNroPResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJ_Persona")]
	public int spCJ_Persona([Parameter(Name = "IdPersona", DbType = "Int")] ref int? idPersona, [Parameter(Name = "Nombres", DbType = "VarChar(100)")] string nombres, [Parameter(Name = "Apellido_Paterno", DbType = "VarChar(30)")] string apellido_Paterno, [Parameter(Name = "Apellido_Materno", DbType = "VarChar(30)")] string apellido_Materno, [Parameter(Name = "TipoDocID", DbType = "Int")] int? tipoDocID, [Parameter(Name = "NumDocID", DbType = "VarChar(12)")] string numDocID, [Parameter(Name = "Direccion", DbType = "VarChar(100)")] string direccion, [Parameter(Name = "Telefono", DbType = "VarChar(18)")] string telefono, [Parameter(Name = "Fax", DbType = "VarChar(18)")] string fax, [Parameter(Name = "Email", DbType = "VarChar(50)")] string email, [Parameter(Name = "IdUbigeo", DbType = "VarChar(6)")] string idUbigeo, [Parameter(Name = "TipoPersona", DbType = "VarChar(1)")] char? tipoPersona, [Parameter(Name = "FechaNacimiento", DbType = "DateTime")] DateTime? fechaNacimiento, [Parameter(Name = "FechaRegistro", DbType = "DateTime")] DateTime? fechaRegistro, [Parameter(Name = "NumCelular", DbType = "VarChar(15)")] string numCelular)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idPersona, nombres, apellido_Paterno, apellido_Materno, tipoDocID, numDocID, direccion, telefono, fax, email, idUbigeo, tipoPersona, fechaNacimiento, fechaRegistro, numCelular);
		object parameterValue = result.GetParameterValue(0);
		int? num = default(int?);
		idPersona = ((parameterValue != null) ? ((int?)parameterValue) : num);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spCJ_Persona_Select")]
	public ISingleResult<spCJ_Persona_SelectResult> spCJ_Persona_Select([Parameter(Name = "IdPersona", DbType = "Int")] int? idPersona)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idPersona);
		return (ISingleResult<spCJ_Persona_SelectResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJ_PlanMayor")]
	public int spCJ_PlanMayor([Parameter(Name = "Years", DbType = "Int")] ref int? years, [Parameter(Name = "Codigo", DbType = "Int")] ref int? codigo, [Parameter(Name = "CodigoCtb", DbType = "VarChar(2)")] string codigoCtb, [Parameter(Name = "Descripcion", DbType = "VarChar(250)")] string descripcion, [Parameter(Name = "YearsDe", DbType = "Int")] int? yearsDe, [Parameter(Name = "CodigoDe", DbType = "Int")] int? codigoDe)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), years, codigo, codigoCtb, descripcion, yearsDe, codigoDe);
		object parameterValue = result.GetParameterValue(0);
		int? num = default(int?);
		years = ((parameterValue != null) ? ((int?)parameterValue) : num);
		object parameterValue2 = result.GetParameterValue(1);
		codigo = ((parameterValue2 != null) ? ((int?)parameterValue2) : num);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spCJ_RefSIAF")]
	public int spCJ_RefSIAF([Parameter(Name = "IdReferencia", DbType = "Int")] int? idReferencia, [Parameter(Name = "NroRef", DbType = "VarChar(25)")] string nroRef, [Parameter(Name = "CPNro", DbType = "VarChar(25)")] string cPNro, [Parameter(Name = "TotalCP", DbType = "Decimal")] decimal? totalCP, [Parameter(Name = "IdTipoMoneda", DbType = "Int")] int? idTipoMoneda)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idReferencia, nroRef, cPNro, totalCP, idTipoMoneda);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spCJ_RefSIAF_Select")]
	public ISingleResult<spCJ_RefSIAF_SelectResult> spCJ_RefSIAF_Select([Parameter(Name = "IdReferencia", DbType = "Int")] int? idReferencia)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idReferencia);
		return (ISingleResult<spCJ_RefSIAF_SelectResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJ_TipoMoneda")]
	public int spCJ_TipoMoneda([Parameter(Name = "IdTipoMoneda", DbType = "Int")] ref int? idTipoMoneda, [Parameter(Name = "Descripcion", DbType = "VarChar(50)")] string descripcion, [Parameter(Name = "Abreviatura", DbType = "VarChar(5)")] string abreviatura)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idTipoMoneda, descripcion, abreviatura);
		object parameterValue = result.GetParameterValue(0);
		int? num = default(int?);
		idTipoMoneda = ((parameterValue != null) ? ((int?)parameterValue) : num);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spCJ_TipoMoneda_Select")]
	public ISingleResult<spCJ_TipoMoneda_SelectResult> spCJ_TipoMoneda_Select([Parameter(Name = "IdTipoMoneda", DbType = "Int")] int? idTipoMoneda)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idTipoMoneda);
		return (ISingleResult<spCJ_TipoMoneda_SelectResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJ_TipoMoneda_Select_Grid")]
	public ISingleResult<spCJ_TipoMoneda_Select_GridResult> spCJ_TipoMoneda_Select_Grid([Parameter(Name = "IdTipoMoneda", DbType = "Int")] int? idTipoMoneda)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idTipoMoneda);
		return (ISingleResult<spCJ_TipoMoneda_Select_GridResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJ_TransferenciaBco")]
	public int spCJ_TransferenciaBco([Parameter(Name = "IdTransferencia", DbType = "Int")] ref int? idTransferencia, [Parameter(Name = "IdBancoDe", DbType = "Int")] int? idBancoDe, [Parameter(Name = "NroCtaDe", DbType = "VarChar(12)")] string nroCtaDe, [Parameter(Name = "IdBancoA", DbType = "Int")] int? idBancoA, [Parameter(Name = "NroCtaA", DbType = "VarChar(12)")] string nroCtaA, [Parameter(Name = "Total", DbType = "Decimal")] decimal? total, [Parameter(Name = "IdTipoMonedaA", DbType = "Int")] int? idTipoMonedaA)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idTransferencia, idBancoDe, nroCtaDe, idBancoA, nroCtaA, total, idTipoMonedaA);
		object parameterValue = result.GetParameterValue(0);
		int? num = default(int?);
		idTransferencia = ((parameterValue != null) ? ((int?)parameterValue) : num);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spCJ_TransferenciaBco_Select")]
	public ISingleResult<spCJ_TransferenciaBco_SelectResult> spCJ_TransferenciaBco_Select([Parameter(Name = "IdTransferencia", DbType = "Int")] int? idTransferencia, [Parameter(Name = "IdBancoDe", DbType = "Int")] int? idBancoDe, [Parameter(Name = "IdBancoA", DbType = "Int")] int? idBancoA)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idTransferencia, idBancoDe, idBancoA);
		return (ISingleResult<spCJ_TransferenciaBco_SelectResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJ_vClasificadorIngreso")]
	public ISingleResult<spCJ_vClasificadorIngresoResult> spCJ_vClasificadorIngreso([Parameter(Name = "Years", DbType = "Int")] int? years, [Parameter(Name = "Codigo", DbType = "Int")] int? codigo, [Parameter(Name = "CodigoDe", DbType = "Int")] int? codigoDe)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), years, codigo, codigoDe);
		return (ISingleResult<spCJ_vClasificadorIngresoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJ_vClasificadorIngreso_Lst")]
	public ISingleResult<spCJ_vClasificadorIngreso_LstResult> spCJ_vClasificadorIngreso_Lst([Parameter(Name = "Years", DbType = "Int")] int? years, [Parameter(Name = "Codigo", DbType = "Int")] int? codigo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), years, codigo);
		return (ISingleResult<spCJ_vClasificadorIngreso_LstResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJ_vPlanMayor")]
	public ISingleResult<spCJ_vPlanMayorResult> spCJ_vPlanMayor([Parameter(Name = "Years", DbType = "Int")] int? years, [Parameter(Name = "Codigo", DbType = "Int")] int? codigo, [Parameter(Name = "CodigoDe", DbType = "Int")] int? codigoDe)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), years, codigo, codigoDe);
		return (ISingleResult<spCJ_vPlanMayorResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJ_vPlanMayor_Lst")]
	public ISingleResult<spCJ_vPlanMayor_LstResult> spCJ_vPlanMayor_Lst([Parameter(Name = "Years", DbType = "Int")] int? years, [Parameter(Name = "Codigo", DbType = "Int")] int? codigo, [Parameter(Name = "CodigoDe", DbType = "Int")] int? codigoDe)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), years, codigo, codigoDe);
		return (ISingleResult<spCJ_vPlanMayor_LstResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJR_BuscarNorma")]
	public ISingleResult<spCJR_BuscarNormaResult> spCJR_BuscarNorma([Parameter(Name = "NumOrdenanza", DbType = "VarChar(200)")] string numOrdenanza, [Parameter(Name = "NumProyecto", DbType = "VarChar(200)")] string numProyecto, [Parameter(DbType = "DateTime")] DateTime? fecha)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), numOrdenanza, numProyecto, fecha);
		return (ISingleResult<spCJR_BuscarNormaResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJR_BuscarPresetInicia")]
	public ISingleResult<spCJR_BuscarPresetIniciaResult> spCJR_BuscarPresetInicia([Parameter(Name = "NumOficioIniciativa", DbType = "VarChar(200)")] string numOficioIniciativa, [Parameter(DbType = "VarChar(2000)")] string tema, [Parameter(DbType = "DateTime")] DateTime? fecha, [Parameter(DbType = "Int")] int? operador)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), numOficioIniciativa, tema, fecha, operador);
		return (ISingleResult<spCJR_BuscarPresetIniciaResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJR_BuscarProyNormativo")]
	public ISingleResult<spCJR_BuscarProyNormativoResult> spCJR_BuscarProyNormativo([Parameter(Name = "NumOficioIniciativa", DbType = "VarChar(200)")] string numOficioIniciativa, [Parameter(Name = "NumProyecto", DbType = "VarChar(200)")] string numProyecto, [Parameter(DbType = "VarChar(2000)")] string tema, [Parameter(DbType = "Int")] int? operador)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), numOficioIniciativa, numProyecto, tema, operador);
		return (ISingleResult<spCJR_BuscarProyNormativoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJR_llenarDictamenes")]
	public ISingleResult<spCJR_llenarDictamenesResult> spCJR_llenarDictamenes([Parameter(Name = "NumProyecto", DbType = "VarChar(200)")] string numProyecto, [Parameter(DbType = "Int")] int? tipoproyect)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), numProyecto, tipoproyect);
		return (ISingleResult<spCJR_llenarDictamenesResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJR_llenarEmpleados")]
	public ISingleResult<spCJR_llenarEmpleadosResult> spCJR_llenarEmpleados()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return (ISingleResult<spCJR_llenarEmpleadosResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJR_llenarIniciativa")]
	public ISingleResult<spCJR_llenarIniciativaResult> spCJR_llenarIniciativa()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return (ISingleResult<spCJR_llenarIniciativaResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJR_llenarNormaRegional")]
	public ISingleResult<spCJR_llenarNormaRegionalResult> spCJR_llenarNormaRegional()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return (ISingleResult<spCJR_llenarNormaRegionalResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJR_llenarNotificaciones")]
	public ISingleResult<spCJR_llenarNotificacionesResult> spCJR_llenarNotificaciones([Parameter(Name = "NumNorma", DbType = "VarChar(200)")] string numNorma, [Parameter(DbType = "Int")] int? tiponorma)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), numNorma, tiponorma);
		return (ISingleResult<spCJR_llenarNotificacionesResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJR_llenarObservacionNorma")]
	public ISingleResult<spCJR_llenarObservacionNormaResult> spCJR_llenarObservacionNorma([Parameter(Name = "NumProyecto", DbType = "VarChar(200)")] string numProyecto, [Parameter(Name = "TipoProyec", DbType = "Int")] int? tipoProyec)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), numProyecto, tipoProyec);
		return (ISingleResult<spCJR_llenarObservacionNormaResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJR_llenarOfiTraslado")]
	public ISingleResult<spCJR_llenarOfiTrasladoResult> spCJR_llenarOfiTraslado([Parameter(Name = "NumProyecto", DbType = "VarChar(120)")] string numProyecto, [Parameter(DbType = "Int")] int? tipoProyec)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), numProyecto, tipoProyec);
		return (ISingleResult<spCJR_llenarOfiTrasladoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJR_llenarOperadores")]
	public ISingleResult<spCJR_llenarOperadoresResult> spCJR_llenarOperadores()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return (ISingleResult<spCJR_llenarOperadoresResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJR_llenarOperadoresActivos")]
	public ISingleResult<spCJR_llenarOperadoresActivosResult> spCJR_llenarOperadoresActivos()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return (ISingleResult<spCJR_llenarOperadoresActivosResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJR_llenarPromulgaciones")]
	public ISingleResult<spCJR_llenarPromulgacionesResult> spCJR_llenarPromulgaciones([Parameter(Name = "NumProyecto", DbType = "VarChar(200)")] string numProyecto, [Parameter(DbType = "Int")] int? tipoproyect)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), numProyecto, tipoproyect);
		return (ISingleResult<spCJR_llenarPromulgacionesResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJR_llenarProyNormativo")]
	public ISingleResult<spCJR_llenarProyNormativoResult> spCJR_llenarProyNormativo()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return (ISingleResult<spCJR_llenarProyNormativoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJR_llenarPublicaciones")]
	public ISingleResult<spCJR_llenarPublicacionesResult> spCJR_llenarPublicaciones([Parameter(Name = "NumNorma", DbType = "VarChar(200)")] string numNorma, [Parameter(DbType = "Int")] int? tiponorma)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), numNorma, tiponorma);
		return (ISingleResult<spCJR_llenarPublicacionesResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJR_llenarSesiones")]
	public ISingleResult<spCJR_llenarSesionesResult> spCJR_llenarSesiones([Parameter(Name = "NumProyecto", DbType = "VarChar(200)")] string numProyecto, [Parameter(DbType = "Int")] int? tipoproyect)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), numProyecto, tipoproyect);
		return (ISingleResult<spCJR_llenarSesionesResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJR_llenarSolLegal")]
	public ISingleResult<spCJR_llenarSolLegalResult> spCJR_llenarSolLegal([Parameter(Name = "NumOficioIniciativa", DbType = "VarChar(200)")] string numOficioIniciativa, [Parameter(DbType = "Int")] int? numtema)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), numOficioIniciativa, numtema);
		return (ISingleResult<spCJR_llenarSolLegalResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJR_llenarSolPubliNorma")]
	public ISingleResult<spCJR_llenarSolPubliNormaResult> spCJR_llenarSolPubliNorma([Parameter(Name = "NumNorma", DbType = "VarChar(200)")] string numNorma, [Parameter(DbType = "Int")] int? tiponorma)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), numNorma, tiponorma);
		return (ISingleResult<spCJR_llenarSolPubliNormaResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJR_llenarSolTec")]
	public ISingleResult<spCJR_llenarSolTecResult> spCJR_llenarSolTec([Parameter(Name = "NumOficioIniciativa", DbType = "VarChar(200)")] string numOficioIniciativa, [Parameter(DbType = "Int")] int? numtema)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), numOficioIniciativa, numtema);
		return (ISingleResult<spCJR_llenarSolTecResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJR_Rep_Acuerdos")]
	public ISingleResult<spCJR_Rep_AcuerdosResult> spCJR_Rep_Acuerdos([Parameter(DbType = "Int")] int? idTipoNorma, [Parameter(Name = "IFechaOrdenanza", DbType = "DateTime")] DateTime? iFechaOrdenanza, [Parameter(Name = "FFechaOrdenanza", DbType = "DateTime")] DateTime? fFechaOrdenanza)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idTipoNorma, iFechaOrdenanza, fFechaOrdenanza);
		return (ISingleResult<spCJR_Rep_AcuerdosResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJR_RepIniciativa")]
	public int spCJR_RepIniciativa()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spCJR_Report_General")]
	public ISingleResult<spCJR_Report_GeneralResult> spCJR_Report_General([Parameter(DbType = "VarChar(200)")] string autor, [Parameter(DbType = "Int")] int? operador, [Parameter(Name = "FechaIIniciativa", DbType = "DateTime")] DateTime? fechaIIniciativa, [Parameter(Name = "FechaFIniciativa", DbType = "DateTime")] DateTime? fechaFIniciativa, [Parameter(Name = "FechaINorma", DbType = "DateTime")] DateTime? fechaINorma, [Parameter(Name = "FechaFNorma", DbType = "DateTime")] DateTime? fechaFNorma)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), autor, operador, fechaIIniciativa, fechaFIniciativa, fechaINorma, fechaFNorma);
		return (ISingleResult<spCJR_Report_GeneralResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spCJR_Report_OfiTema")]
	public ISingleResult<spCJR_Report_OfiTemaResult> spCJR_Report_OfiTema([Parameter(DbType = "VarChar(200)")] string autor, [Parameter(DbType = "Int")] int? operador, [Parameter(Name = "FechaIIniciativa", DbType = "DateTime")] DateTime? fechaIIniciativa, [Parameter(Name = "FechaFIniciativa", DbType = "DateTime")] DateTime? fechaFIniciativa, [Parameter(Name = "FechaINorma", DbType = "DateTime")] DateTime? fechaINorma, [Parameter(Name = "FechaFNorma", DbType = "DateTime")] DateTime? fechaFNorma)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), autor, operador, fechaIIniciativa, fechaFIniciativa, fechaINorma, fechaFNorma);
		return (ISingleResult<spCJR_Report_OfiTemaResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.SpCJR_ReportCJR_Nuevo")]
	public ISingleResult<SpCJR_ReportCJR_NuevoResult> SpCJR_ReportCJR_Nuevo([Parameter(DbType = "VarChar(200)")] string autor, [Parameter(DbType = "Int")] int? operador, [Parameter(Name = "FechaIIniciativa", DbType = "DateTime")] DateTime? fechaIIniciativa, [Parameter(Name = "FechaFIniciativa", DbType = "DateTime")] DateTime? fechaFIniciativa)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), autor, operador, fechaIIniciativa, fechaFIniciativa);
		return (ISingleResult<SpCJR_ReportCJR_NuevoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.SpCJR_ReportCJR_Nuevo_p")]
	public ISingleResult<SpCJR_ReportCJR_Nuevo_pResult> SpCJR_ReportCJR_Nuevo_p([Parameter(DbType = "VarChar(200)")] string autor, [Parameter(DbType = "Int")] int? operador, [Parameter(Name = "FechaIIniciativa", DbType = "DateTime")] DateTime? fechaIIniciativa, [Parameter(Name = "FechaFIniciativa", DbType = "DateTime")] DateTime? fechaFIniciativa)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), autor, operador, fechaIIniciativa, fechaFIniciativa);
		return (ISingleResult<SpCJR_ReportCJR_Nuevo_pResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spEmpleadito")]
	public ISingleResult<spEmpleaditoResult> spEmpleadito([Parameter(DbType = "Int")] int? idareaorganiz)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idareaorganiz);
		return (ISingleResult<spEmpleaditoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spEmpleado")]
	public int spEmpleado([Parameter(Name = "IdEmpleado", DbType = "Int")] int? idEmpleado, [Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(DbType = "Int")] int? idAreaOrganiz, [Parameter(Name = "IdPersona", DbType = "Int")] int? idPersona, [Parameter(Name = "IdTipoTrabajador", DbType = "Int")] int? idTipoTrabajador, [Parameter(Name = "IdCargo", DbType = "Int")] int? idCargo, [Parameter(Name = "Estado", DbType = "Int")] int? estado)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idEmpleado, year, idAreaOrganiz, idPersona, idTipoTrabajador, idCargo, estado);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spEmpleado_Exp")]
	public ISingleResult<spEmpleado_ExpResult> spEmpleado_Exp([Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(DbType = "Int")] int? idAreaOrganiz, [Parameter(Name = "IdEmpleado", DbType = "Int")] int? idEmpleado, [Parameter(Name = "Estado", DbType = "Char(1)")] char? estado)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), year, idAreaOrganiz, idEmpleado, estado);
		return (ISingleResult<spEmpleado_ExpResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spEmpleado_NotIn_All_Solo_Pla")]
	public ISingleResult<spEmpleado_NotIn_All_Solo_PlaResult> spEmpleado_NotIn_All_Solo_Pla([Parameter(Name = "Year", DbType = "Int")] int? year)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), year);
		return (ISingleResult<spEmpleado_NotIn_All_Solo_PlaResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spEmpleado_Select")]
	public ISingleResult<spEmpleado_SelectResult> spEmpleado_Select([Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(DbType = "Int")] int? idAreaOrganiz, [Parameter(Name = "IdEmpleado", DbType = "Int")] int? idEmpleado, [Parameter(Name = "Estado", DbType = "Char(1)")] char? estado)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), year, idAreaOrganiz, idEmpleado, estado);
		return (ISingleResult<spEmpleado_SelectResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spEmpleado_Select_Activ_UO")]
	public ISingleResult<spEmpleado_Select_Activ_UOResult> spEmpleado_Select_Activ_UO([Parameter(Name = "IdObjetivo", DbType = "Int")] int? idObjetivo, [Parameter(Name = "IdEmpleado", DbType = "Int")] int? idEmpleado, [Parameter(Name = "Estado", DbType = "Char(1)")] char? estado)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idObjetivo, idEmpleado, estado);
		return (ISingleResult<spEmpleado_Select_Activ_UOResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spEmpleado_Select_NotIn")]
	public ISingleResult<spEmpleado_Select_NotInResult> spEmpleado_Select_NotIn([Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(DbType = "Int")] int? idAreaOrganiz)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), year, idAreaOrganiz);
		return (ISingleResult<spEmpleado_Select_NotInResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spEmpleado_Select_Solo_Pla")]
	public int spEmpleado_Select_Solo_Pla([Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(DbType = "Int")] int? idAreaOrganiz, [Parameter(Name = "IdEmpleado", DbType = "Int")] int? idEmpleado, [Parameter(Name = "Estado", DbType = "Char(1)")] char? estado)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), year, idAreaOrganiz, idEmpleado, estado);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spEmpleado_SNP_Select_NotIn")]
	public ISingleResult<spEmpleado_SNP_Select_NotInResult> spEmpleado_SNP_Select_NotIn([Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(DbType = "Int")] int? idAreaOrganiz)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), year, idAreaOrganiz);
		return (ISingleResult<spEmpleado_SNP_Select_NotInResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spEmpleado_SNP_Select_NotIn_All")]
	public ISingleResult<spEmpleado_SNP_Select_NotIn_AllResult> spEmpleado_SNP_Select_NotIn_All([Parameter(Name = "Year", DbType = "Int")] int? year)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), year);
		return (ISingleResult<spEmpleado_SNP_Select_NotIn_AllResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spEstrategia")]
	public int spEstrategia([Parameter(Name = "IdEstrategia", DbType = "Int")] int? idEstrategia, [Parameter(DbType = "Int")] int? idAreaOrganiz, [Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(Name = "Estrategia", DbType = "VarChar(500)")] string estrategia, [Parameter(Name = "FechaInicio", DbType = "SmallDateTime")] DateTime? fechaInicio, [Parameter(Name = "FechaCulminacion", DbType = "SmallDateTime")] DateTime? fechaCulminacion, [Parameter(Name = "IdPresupuesto", DbType = "Int")] int? idPresupuesto)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idEstrategia, idAreaOrganiz, year, estrategia, fechaInicio, fechaCulminacion, idPresupuesto);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spEstrategia_Exp")]
	public ISingleResult<spEstrategia_ExpResult> spEstrategia_Exp([Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(DbType = "Int")] int? idAreaOrganiz, [Parameter(Name = "IdEstrategia", DbType = "Int")] int? idEstrategia)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), year, idAreaOrganiz, idEstrategia);
		return (ISingleResult<spEstrategia_ExpResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spEstrategia_Select")]
	public ISingleResult<spEstrategia_SelectResult> spEstrategia_Select([Parameter(DbType = "Int")] int? idAreaOrganiz, [Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(Name = "IdEstrategia", DbType = "Int")] int? idEstrategia)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idAreaOrganiz, year, idEstrategia);
		return (ISingleResult<spEstrategia_SelectResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spEstrategiaDel")]
	public int spEstrategiaDel([Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(DbType = "Int")] int? idAreaOrganiz, [Parameter(Name = "IdEstrategia", DbType = "Int")] int? idEstrategia)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), year, idAreaOrganiz, idEstrategia);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spEstructOrganiz")]
	public int spEstructOrganiz([Parameter(DbType = "Int")] int? idAreaOrganiz, [Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(Name = "AreaOrganizacional", DbType = "VarChar(80)")] string areaOrganizacional, [Parameter(Name = "Abrev", DbType = "VarChar(10)")] string abrev, [Parameter(Name = "Sigla", DbType = "VarChar(6)")] string sigla, [Parameter(Name = "PresupAnual", DbType = "Decimal")] decimal? presupAnual, [Parameter(Name = "PromedMensSueld", DbType = "Decimal")] decimal? promedMensSueld, [Parameter(Name = "NroTrabajaUO", DbType = "Int")] int? nroTrabajaUO, [Parameter(DbType = "Int")] int? idDependeDe, [Parameter(Name = "YearDe", DbType = "Int")] int? yearDe, [Parameter(Name = "IdPresupuesto", DbType = "Int")] int? idPresupuesto, [Parameter(Name = "Mision", DbType = "VarChar(1000)")] string mision, [Parameter(Name = "Vision", DbType = "VarChar(1000)")] string vision, [Parameter(Name = "IdEmpleado", DbType = "Int")] int? idEmpleado, [Parameter(Name = "IsPersonal", DbType = "Char(1)")] char? isPersonal, [Parameter(Name = "InversPublic", DbType = "Decimal")] decimal? inversPublic)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idAreaOrganiz, year, areaOrganizacional, abrev, sigla, presupAnual, promedMensSueld, nroTrabajaUO, idDependeDe, yearDe, idPresupuesto, mision, vision, idEmpleado, isPersonal, inversPublic);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spEstructOrganiz_Exp")]
	public ISingleResult<spEstructOrganiz_ExpResult> spEstructOrganiz_Exp([Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(DbType = "Int")] int? idAreaOrganiz, [Parameter(Name = "AreaOrganizacional", DbType = "VarChar(80)")] string areaOrganizacional, [Parameter(DbType = "Int")] int? idDependeDe)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), year, idAreaOrganiz, areaOrganizacional, idDependeDe);
		return (ISingleResult<spEstructOrganiz_ExpResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spEstructOrganiz_Select")]
	public ISingleResult<spEstructOrganiz_SelectResult> spEstructOrganiz_Select([Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(DbType = "Int")] int? idAreaOrganiz, [Parameter(Name = "AreaOrganizacional", DbType = "VarChar(80)")] string areaOrganizacional, [Parameter(DbType = "Int")] int? idDependeDe)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), year, idAreaOrganiz, areaOrganizacional, idDependeDe);
		return (ISingleResult<spEstructOrganiz_SelectResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spEstructOrganiz_Select_Lst")]
	public ISingleResult<spEstructOrganiz_Select_LstResult> spEstructOrganiz_Select_Lst([Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(Name = "OrderNama", DbType = "Int")] int? orderNama)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), year, orderNama);
		return (ISingleResult<spEstructOrganiz_Select_LstResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spEstructOrganizDel")]
	public int spEstructOrganizDel([Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(DbType = "Int")] int? idAreaOrganiz)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), year, idAreaOrganiz);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spFinanciamiento")]
	public int spFinanciamiento([Parameter(Name = "IdFinanciamiento", DbType = "Char(2)")] string idFinanciamiento, [Parameter(Name = "Descripcion", DbType = "VarChar(55)")] string descripcion)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idFinanciamiento, descripcion);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spFinanciamiento_Exp")]
	public ISingleResult<spFinanciamiento_ExpResult> spFinanciamiento_Exp([Parameter(Name = "IdFinanciamiento", DbType = "Int")] int? idFinanciamiento)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idFinanciamiento);
		return (ISingleResult<spFinanciamiento_ExpResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spFinanciamiento_Select")]
	public ISingleResult<spFinanciamiento_SelectResult> spFinanciamiento_Select([Parameter(Name = "IdFinanciamiento", DbType = "Int")] int? idFinanciamiento)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idFinanciamiento);
		return (ISingleResult<spFinanciamiento_SelectResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spGetOC")]
	public int spGetOC([Parameter(DbType = "VarChar(512)")] string cWhere)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), cWhere);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spgrupo")]
	public int spgrupo([Parameter(DbType = "Char(3)")] string idgrupo, [Parameter(DbType = "VarChar(120)")] string descripcion, [Parameter(DbType = "VarChar(120)")] string observaciones, [Parameter(DbType = "Int")] int? idtipo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idgrupo, descripcion, observaciones, idtipo);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spInversPublica")]
	public int spInversPublica([Parameter(Name = "IdInverPublica", DbType = "Int")] int? idInverPublica, [Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(DbType = "Int")] int? idAreaOrganiz, [Parameter(Name = "Total", DbType = "Decimal")] decimal? total)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idInverPublica, year, idAreaOrganiz, total);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spInversPublica_Exp")]
	public ISingleResult<spInversPublica_ExpResult> spInversPublica_Exp([Parameter(Name = "IdInverPublica", DbType = "Int")] int? idInverPublica, [Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(DbType = "Int")] int? idAreaOrganiz)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idInverPublica, year, idAreaOrganiz);
		return (ISingleResult<spInversPublica_ExpResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spInversPublica_Select")]
	public ISingleResult<spInversPublica_SelectResult> spInversPublica_Select([Parameter(Name = "IdInverPublica", DbType = "Int")] int? idInverPublica, [Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(DbType = "Int")] int? idAreaOrganiz)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idInverPublica, year, idAreaOrganiz);
		return (ISingleResult<spInversPublica_SelectResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spInversPublicaDel")]
	public int spInversPublicaDel([Parameter(Name = "IdInverPublica", DbType = "Int")] int? idInverPublica)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idInverPublica);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spInversXFuentF")]
	public ISingleResult<spInversXFuentFResult> spInversXFuentF([Parameter(Name = "IdInverPublica", DbType = "Int")] int? idInverPublica, [Parameter(Name = "IdFinanciamiento", DbType = "Char(2)")] ref string idFinanciamiento, [Parameter(Name = "Inversion", DbType = "Decimal")] decimal? inversion)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idInverPublica, idFinanciamiento, inversion);
		idFinanciamiento = Conversions.ToString(result.GetParameterValue(1));
		return (ISingleResult<spInversXFuentFResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spInversXFuentF_Exp")]
	public ISingleResult<spInversXFuentF_ExpResult> spInversXFuentF_Exp([Parameter(Name = "IdInverPublica", DbType = "Int")] int? idInverPublica)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idInverPublica);
		return (ISingleResult<spInversXFuentF_ExpResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spInversXFuentF_Select")]
	public ISingleResult<spInversXFuentF_SelectResult> spInversXFuentF_Select([Parameter(Name = "IdInverPublica", DbType = "Int")] int? idInverPublica)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idInverPublica);
		return (ISingleResult<spInversXFuentF_SelectResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spKM_GetNextVideoPlayAviso")]
	public ISingleResult<spKM_GetNextVideoPlayAvisoResult> spKM_GetNextVideoPlayAviso([Parameter(DbType = "Int")] int? orden)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), orden);
		return (ISingleResult<spKM_GetNextVideoPlayAvisoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spKM_GetNextVideoPlayPrinc")]
	public ISingleResult<spKM_GetNextVideoPlayPrincResult> spKM_GetNextVideoPlayPrinc([Parameter(DbType = "Int")] int? orden)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), orden);
		return (ISingleResult<spKM_GetNextVideoPlayPrincResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spKM_GetPlayAviso")]
	public ISingleResult<spKM_GetPlayAvisoResult> spKM_GetPlayAviso()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return (ISingleResult<spKM_GetPlayAvisoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spKM_GetPlayPrinc")]
	public ISingleResult<spKM_GetPlayPrincResult> spKM_GetPlayPrinc()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return (ISingleResult<spKM_GetPlayPrincResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spKM_GetSgtCola")]
	public ISingleResult<spKM_GetSgtColaResult> spKM_GetSgtCola([Parameter(DbType = "Char(10)")] string fecha)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), fecha);
		return (ISingleResult<spKM_GetSgtColaResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spKM_GetVideoList")]
	public ISingleResult<spKM_GetVideoListResult> spKM_GetVideoList()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return (ISingleResult<spKM_GetVideoListResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spKM_repAtencion")]
	public ISingleResult<spKM_repAtencionResult> spKM_repAtencion([Parameter(DbType = "Int")] int? atendido, [Parameter(DbType = "Int")] int? noatendido, [Parameter(DbType = "Int")] int? llamado, [Parameter(DbType = "Int")] int? idTipoOperacion, [Parameter(DbType = "Int")] int? idmotivo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), atendido, noatendido, llamado, idTipoOperacion, idmotivo);
		return (ISingleResult<spKM_repAtencionResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spKM_RepMensajes")]
	public ISingleResult<spKM_RepMensajesResult> spKM_RepMensajes([Parameter(DbType = "NVarChar(12)")] string fechaInicio, [Parameter(DbType = "NVarChar(12)")] string fechatermino)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), fechaInicio, fechatermino);
		return (ISingleResult<spKM_RepMensajesResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spKM_ReportPersAtendxCaj")]
	public ISingleResult<spKM_ReportPersAtendxCajResult> spKM_ReportPersAtendxCaj([Parameter(DbType = "NVarChar(8)")] string fechaI, [Parameter(DbType = "NVarChar(8)")] string fechaF)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), fechaI, fechaF);
		return (ISingleResult<spKM_ReportPersAtendxCajResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spKM_repTiempoAtencion")]
	public ISingleResult<spKM_repTiempoAtencionResult> spKM_repTiempoAtencion([Parameter(DbType = "NVarChar(12)")] string fechaInicio, [Parameter(DbType = "NVarChar(12)")] string fechatermino)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), fechaInicio, fechatermino);
		return (ISingleResult<spKM_repTiempoAtencionResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spKM_repTipoTramite")]
	public ISingleResult<spKM_repTipoTramiteResult> spKM_repTipoTramite([Parameter(DbType = "NVarChar(12)")] string fechaInicio, [Parameter(DbType = "NVarChar(12)")] string fechatermino)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), fechaInicio, fechatermino);
		return (ISingleResult<spKM_repTipoTramiteResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spKM_repTotalAtendidos")]
	public ISingleResult<spKM_repTotalAtendidosResult> spKM_repTotalAtendidos([Parameter(DbType = "NVarChar(12)")] string fechaInicio, [Parameter(DbType = "NVarChar(12)")] string fechatermino)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), fechaInicio, fechatermino);
		return (ISingleResult<spKM_repTotalAtendidosResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spKM_RepVideos")]
	public ISingleResult<spKM_RepVideosResult> spKM_RepVideos([Parameter(DbType = "NVarChar(12)")] string fechaInicio, [Parameter(DbType = "NVarChar(12)")] string fechatermino)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), fechaInicio, fechatermino);
		return (ISingleResult<spKM_RepVideosResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spLimit_Recomen_Logro_Print")]
	public ISingleResult<spLimit_Recomen_Logro_PrintResult> spLimit_Recomen_Logro_Print([Parameter(Name = "Ids", DbType = "VarChar(20)")] string ids)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), ids);
		return (ISingleResult<spLimit_Recomen_Logro_PrintResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spLimitacion")]
	public int spLimitacion([Parameter(Name = "IdLimitacion", DbType = "Int")] int? idLimitacion, [Parameter(Name = "Descripcion", DbType = "VarChar(500)")] string descripcion)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idLimitacion, descripcion);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spLimitacion_Exp")]
	public ISingleResult<spLimitacion_ExpResult> spLimitacion_Exp([Parameter(Name = "IdLimitacion", DbType = "Int")] int? idLimitacion)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idLimitacion);
		return (ISingleResult<spLimitacion_ExpResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spLimitacion_Recomendacion_TV")]
	public ISingleResult<spLimitacion_Recomendacion_TVResult> spLimitacion_Recomendacion_TV([Parameter(Name = "Ids", DbType = "VarChar(20)")] string ids)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), ids);
		return (ISingleResult<spLimitacion_Recomendacion_TVResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spLimitacion_Select")]
	public ISingleResult<spLimitacion_SelectResult> spLimitacion_Select([Parameter(Name = "IdLimitacion", DbType = "Int")] int? idLimitacion)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idLimitacion);
		return (ISingleResult<spLimitacion_SelectResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.splistarcolumnas")]
	public int splistarcolumnas([Parameter(DbType = "NVarChar(128)")] string table)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), table);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.splistartablas")]
	public ISingleResult<splistartablasResult> splistartablas()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return (ISingleResult<splistartablasResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spLogros")]
	public int spLogros([Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(DbType = "Int")] int? idAreaOrganiz, [Parameter(Name = "Trimestre", DbType = "Int")] int? trimestre, [Parameter(Name = "IdLogros", DbType = "Int")] int? idLogros, [Parameter(Name = "Descripcion", DbType = "VarChar(8000)")] string descripcion)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), year, idAreaOrganiz, trimestre, idLogros, descripcion);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spLogros_Exp")]
	public ISingleResult<spLogros_ExpResult> spLogros_Exp([Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(DbType = "Int")] int? idAreaOrganiz, [Parameter(Name = "Trimestre", DbType = "Int")] int? trimestre, [Parameter(Name = "IdLogros", DbType = "Int")] int? idLogros)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), year, idAreaOrganiz, trimestre, idLogros);
		return (ISingleResult<spLogros_ExpResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spLogros_Limitacion_TV")]
	public ISingleResult<spLogros_Limitacion_TVResult> spLogros_Limitacion_TV([Parameter(Name = "Ids", DbType = "VarChar(20)")] string ids)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), ids);
		return (ISingleResult<spLogros_Limitacion_TVResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spLogros_Select")]
	public ISingleResult<spLogros_SelectResult> spLogros_Select([Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(DbType = "Int")] int? idAreaOrganiz, [Parameter(Name = "Trimestre", DbType = "Int")] int? trimestre, [Parameter(Name = "IdLogros", DbType = "Int")] int? idLogros)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), year, idAreaOrganiz, trimestre, idLogros);
		return (ISingleResult<spLogros_SelectResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spLogrosLimitacion_TV")]
	public ISingleResult<spLogrosLimitacion_TVResult> spLogrosLimitacion_TV([Parameter(Name = "IdYearIdArea", DbType = "VarChar(20)")] string idYearIdArea)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idYearIdArea);
		return (ISingleResult<spLogrosLimitacion_TVResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spMeses_Select")]
	public ISingleResult<spMeses_SelectResult> spMeses_Select([Parameter(Name = "IdMes", DbType = "Int")] int? idMes)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idMes);
		return (ISingleResult<spMeses_SelectResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spObjet_Avance_Select")]
	public ISingleResult<spObjet_Avance_SelectResult> spObjet_Avance_Select([Parameter(Name = "IdObjetivo", DbType = "Int")] int? idObjetivo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idObjetivo);
		return (ISingleResult<spObjet_Avance_SelectResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spObjetivo")]
	public int spObjetivo([Parameter(DbType = "Int")] int? idAreaOrganiz, [Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(Name = "IdEstrategia", DbType = "Int")] int? idEstrategia, [Parameter(Name = "IdObjetivo", DbType = "Int")] int? idObjetivo, [Parameter(Name = "Objetivo", DbType = "VarChar(500)")] string objetivo, [Parameter(Name = "FechaInicio", DbType = "SmallDateTime")] DateTime? fechaInicio, [Parameter(Name = "FechaFin", DbType = "SmallDateTime")] DateTime? fechaFin, [Parameter(Name = "IdPresupuesto", DbType = "Int")] int? idPresupuesto, [Parameter(Name = "AvanceAnual", DbType = "Decimal")] decimal? avanceAnual, [Parameter(Name = "AvanceGlobal", DbType = "Decimal")] decimal? avanceGlobal, [Parameter(Name = "Meta", DbType = "Decimal")] decimal? meta, [Parameter(Name = "Importancia", DbType = "Int")] int? importancia, [Parameter(Name = "IdUnidMed", DbType = "Int")] int? idUnidMed, [Parameter(Name = "IdObjetivoAlternativo", DbType = "Int")] int? idObjetivoAlternativo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idAreaOrganiz, year, idEstrategia, idObjetivo, objetivo, fechaInicio, fechaFin, idPresupuesto, avanceAnual, avanceGlobal, meta, importancia, idUnidMed, idObjetivoAlternativo);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spObjetivo_Exp")]
	public ISingleResult<spObjetivo_ExpResult> spObjetivo_Exp([Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(DbType = "Int")] int? idAreaOrganiz, [Parameter(Name = "IdEstrategia", DbType = "Int")] int? idEstrategia, [Parameter(Name = "IdObjetivo", DbType = "Int")] int? idObjetivo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), year, idAreaOrganiz, idEstrategia, idObjetivo);
		return (ISingleResult<spObjetivo_ExpResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spObjetivo_Select")]
	public ISingleResult<spObjetivo_SelectResult> spObjetivo_Select([Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(DbType = "Int")] int? idAreaOrganiz, [Parameter(Name = "IdEstrategia", DbType = "Int")] int? idEstrategia, [Parameter(Name = "IdObjetivo", DbType = "Int")] int? idObjetivo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), year, idAreaOrganiz, idEstrategia, idObjetivo);
		return (ISingleResult<spObjetivo_SelectResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spObjetivoDel")]
	public int spObjetivoDel([Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(DbType = "Int")] int? idAreaOrganiz, [Parameter(Name = "IdEstrategia", DbType = "Int")] int? idEstrategia, [Parameter(Name = "IdObjetivo", DbType = "Int")] int? idObjetivo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), year, idAreaOrganiz, idEstrategia, idObjetivo);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spParametrosTrab")]
	public ISingleResult<spParametrosTrabResult> spParametrosTrab([Parameter(Name = "IdParametros", DbType = "Int")] int? idParametros, [Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(Name = "HorasTrabajo", DbType = "Int")] int? horasTrabajo, [Parameter(Name = "SemasTrabajo", DbType = "Int")] int? semasTrabajo, [Parameter(Name = "DiasTrabajo", DbType = "Int")] int? diasTrabajo, [Parameter(Name = "ProgramaP", DbType = "Int")] int? programaP, [Parameter(Name = "M1", DbType = "Int")] int? m1, [Parameter(Name = "M2", DbType = "Int")] int? m2, [Parameter(Name = "M3", DbType = "Int")] int? m3, [Parameter(Name = "M4", DbType = "Int")] int? m4, [Parameter(Name = "M5", DbType = "Int")] int? m5, [Parameter(Name = "M6", DbType = "Int")] int? m6, [Parameter(Name = "M7", DbType = "Int")] int? m7, [Parameter(Name = "M8", DbType = "Int")] int? m8, [Parameter(Name = "M9", DbType = "Int")] int? m9, [Parameter(Name = "M10", DbType = "Int")] int? m10, [Parameter(Name = "M11", DbType = "Int")] int? m11, [Parameter(Name = "M12", DbType = "Int")] int? m12, [Parameter(DbType = "Bit")] bool? activo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idParametros, year, horasTrabajo, semasTrabajo, diasTrabajo, programaP, m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, activo);
		return (ISingleResult<spParametrosTrabResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spParametrosTrab_Exp")]
	public ISingleResult<spParametrosTrab_ExpResult> spParametrosTrab_Exp([Parameter(Name = "IdParametros", DbType = "Int")] int? idParametros, [Parameter(Name = "Year", DbType = "Int")] int? year)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idParametros, year);
		return (ISingleResult<spParametrosTrab_ExpResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spParametrosTrab_Select")]
	public ISingleResult<spParametrosTrab_SelectResult> spParametrosTrab_Select([Parameter(Name = "IdParametros", DbType = "Int")] int? idParametros, [Parameter(Name = "Year", DbType = "Int")] int? year)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idParametros, year);
		return (ISingleResult<spParametrosTrab_SelectResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spPresupuestoT")]
	public int spPresupuestoT([Parameter(Name = "IdPresupuesto", DbType = "Int")] ref int? idPresupuesto, [Parameter(Name = "M01P", DbType = "Decimal")] decimal? m01P, [Parameter(Name = "M02P", DbType = "Decimal")] decimal? m02P, [Parameter(Name = "M03P", DbType = "Decimal")] decimal? m03P, [Parameter(Name = "M04P", DbType = "Decimal")] decimal? m04P, [Parameter(Name = "M05P", DbType = "Decimal")] decimal? m05P, [Parameter(Name = "M06P", DbType = "Decimal")] decimal? m06P, [Parameter(Name = "M07P", DbType = "Decimal")] decimal? m07P, [Parameter(Name = "M08P", DbType = "Decimal")] decimal? m08P, [Parameter(Name = "M09P", DbType = "Decimal")] decimal? m09P, [Parameter(Name = "M10P", DbType = "Decimal")] decimal? m10P, [Parameter(Name = "M11P", DbType = "Decimal")] decimal? m11P, [Parameter(Name = "M12P", DbType = "Decimal")] decimal? m12P)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idPresupuesto, m01P, m02P, m03P, m04P, m05P, m06P, m07P, m08P, m09P, m10P, m11P, m12P);
		object parameterValue = result.GetParameterValue(0);
		int? num = default(int?);
		idPresupuesto = ((parameterValue != null) ? ((int?)parameterValue) : num);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spPresupuestoT_Exp")]
	public ISingleResult<spPresupuestoT_ExpResult> spPresupuestoT_Exp([Parameter(Name = "IdPresupuesto", DbType = "Int")] int? idPresupuesto)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idPresupuesto);
		return (ISingleResult<spPresupuestoT_ExpResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spPresupuestoT_Select")]
	public ISingleResult<spPresupuestoT_SelectResult> spPresupuestoT_Select([Parameter(Name = "IdPresupuesto", DbType = "Int")] int? idPresupuesto)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idPresupuesto);
		return (ISingleResult<spPresupuestoT_SelectResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spProgramMes")]
	public ISingleResult<spProgramMesResult> spProgramMes([Parameter(Name = "IdObjetivo", DbType = "Int")] int? idObjetivo, [Parameter(Name = "IdActividad", DbType = "Int")] int? idActividad, [Parameter(Name = "IdMes", DbType = "Int")] int? idMes, [Parameter(Name = "Programada", DbType = "Decimal")] decimal? programada, [Parameter(Name = "Ejecutada", DbType = "Decimal")] decimal? ejecutada, [Parameter(Name = "Acumulada", DbType = "Decimal")] decimal? acumulada)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idObjetivo, idActividad, idMes, programada, ejecutada, acumulada);
		return (ISingleResult<spProgramMesResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spProgramMes_Exp")]
	public ISingleResult<spProgramMes_ExpResult> spProgramMes_Exp([Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(DbType = "Int")] int? idAreaOrganiz, [Parameter(Name = "IdObjetivo", DbType = "Int")] int? idObjetivo, [Parameter(Name = "IdActividad", DbType = "Int")] int? idActividad, [Parameter(Name = "IdMes", DbType = "Int")] int? idMes)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), year, idAreaOrganiz, idObjetivo, idActividad, idMes);
		return (ISingleResult<spProgramMes_ExpResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spProgramMes_Select")]
	public ISingleResult<spProgramMes_SelectResult> spProgramMes_Select([Parameter(Name = "IdObjetivo", DbType = "Int")] int? idObjetivo, [Parameter(Name = "IdActividad", DbType = "Int")] int? idActividad, [Parameter(Name = "IdMes", DbType = "Int")] int? idMes)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idObjetivo, idActividad, idMes);
		return (ISingleResult<spProgramMes_SelectResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spProgramMesDel")]
	public int spProgramMesDel([Parameter(Name = "IdObjetivo", DbType = "Int")] int? idObjetivo, [Parameter(Name = "IdActividad", DbType = "Int")] int? idActividad, [Parameter(Name = "IdMes", DbType = "Int")] int? idMes)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idObjetivo, idActividad, idMes);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spPTI_Reducc_actividad")]
	public int spPTI_Reducc_actividad([Parameter(DbType = "Int")] int? idobjetivo, [Parameter(DbType = "Int")] int? idactividad)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idobjetivo, idactividad);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spPTI_Reducc_Estrategia")]
	public int spPTI_Reducc_Estrategia([Parameter(DbType = "Int")] int? area)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), area);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spPTI_Reducc_Estrategia2")]
	public int spPTI_Reducc_Estrategia2([Parameter(DbType = "Int")] int? area)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), area);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spPTI_Reducc_inconv")]
	public int spPTI_Reducc_inconv([Parameter(DbType = "Int")] int? idobjetivo, [Parameter(DbType = "Int")] int? idactividad, [Parameter(DbType = "Int")] int? idInconveniente)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idobjetivo, idactividad, idInconveniente);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spPTI_Reducc_Objetivo")]
	public int spPTI_Reducc_Objetivo([Parameter(DbType = "Int")] int? idobjetivo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idobjetivo);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spPTI_Reducc_programmes")]
	public int spPTI_Reducc_programmes([Parameter(DbType = "Int")] int? idobjetivo, [Parameter(DbType = "Int")] int? idactividad, [Parameter(DbType = "Int")] int? idMes)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idobjetivo, idactividad, idMes);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spPTI_Reducc_ReqxProgMes")]
	public int spPTI_Reducc_ReqxProgMes([Parameter(DbType = "Int")] int? idobjetivo, [Parameter(DbType = "Int")] int? idactividad, [Parameter(DbType = "Int")] int? idMes, [Parameter(DbType = "Char(13)")] string idBien)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idobjetivo, idactividad, idMes, idBien);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spRecomendacion")]
	public int spRecomendacion([Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(DbType = "Int")] int? idAreaOrganiz, [Parameter(Name = "Trimestre", DbType = "Int")] int? trimestre, [Parameter(Name = "IdRecomend", DbType = "Int")] int? idRecomend, [Parameter(Name = "IdLimitacion", DbType = "Int")] int? idLimitacion, [Parameter(Name = "Limitacion", DbType = "VarChar(500)")] string limitacion, [Parameter(Name = "Descripcion", DbType = "VarChar(500)")] string descripcion)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), year, idAreaOrganiz, trimestre, idRecomend, idLimitacion, limitacion, descripcion);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spRecomendacion_Exp")]
	public ISingleResult<spRecomendacion_ExpResult> spRecomendacion_Exp([Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(DbType = "Int")] int? idAreaOrganiz, [Parameter(Name = "Trimestre", DbType = "Int")] int? trimestre, [Parameter(Name = "IdRecomend", DbType = "Int")] int? idRecomend, [Parameter(Name = "IdLimitacion", DbType = "Int")] int? idLimitacion)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), year, idAreaOrganiz, trimestre, idRecomend, idLimitacion);
		return (ISingleResult<spRecomendacion_ExpResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRecomendacion_Select")]
	public ISingleResult<spRecomendacion_SelectResult> spRecomendacion_Select([Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(DbType = "Int")] int? idAreaOrganiz, [Parameter(Name = "Trimestre", DbType = "Int")] int? trimestre, [Parameter(Name = "IdRecomend", DbType = "Int")] int? idRecomend, [Parameter(Name = "IdLimitacion", DbType = "Int")] int? idLimitacion)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), year, idAreaOrganiz, trimestre, idRecomend, idLimitacion);
		return (ISingleResult<spRecomendacion_SelectResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spReqXProgMes")]
	public ISingleResult<spReqXProgMesResult> spReqXProgMes([Parameter(Name = "IdObjetivo", DbType = "Int")] int? idObjetivo, [Parameter(Name = "IdActividad", DbType = "Int")] int? idActividad, [Parameter(Name = "IdMes", DbType = "Int")] int? idMes, [Parameter(Name = "IdBien", DbType = "VarChar(13)")] string idBien, [Parameter(Name = "Cantidad", DbType = "Decimal")] decimal? cantidad, [Parameter(Name = "IdUnidadMedida", DbType = "VarChar(4)")] string idUnidadMedida, [Parameter(Name = "CostoEstimado", DbType = "Decimal")] decimal? costoEstimado, [Parameter(Name = "CantidadConsumida", DbType = "Decimal")] decimal? cantidadConsumida, [Parameter(Name = "CostoReal", DbType = "Decimal")] decimal? costoReal)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idObjetivo, idActividad, idMes, idBien, cantidad, idUnidadMedida, costoEstimado, cantidadConsumida, costoReal);
		return (ISingleResult<spReqXProgMesResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spReqXProgMes_Exp")]
	public ISingleResult<spReqXProgMes_ExpResult> spReqXProgMes_Exp([Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(DbType = "Int")] int? idAreaOrganiz, [Parameter(Name = "IdMes", DbType = "Int")] int? idMes)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), year, idAreaOrganiz, idMes);
		return (ISingleResult<spReqXProgMes_ExpResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spReqXProgMes_Select")]
	public ISingleResult<spReqXProgMes_SelectResult> spReqXProgMes_Select([Parameter(Name = "IdObjetivo", DbType = "Int")] int? idObjetivo, [Parameter(Name = "IdActividad", DbType = "Int")] int? idActividad, [Parameter(Name = "IdMes", DbType = "Int")] int? idMes, [Parameter(Name = "IdBien", DbType = "VarChar(13)")] string idBien)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idObjetivo, idActividad, idMes, idBien);
		return (ISingleResult<spReqXProgMes_SelectResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spResponsableXUO_Exp")]
	public ISingleResult<spResponsableXUO_ExpResult> spResponsableXUO_Exp([Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(DbType = "Int")] int? idAreaOrganiz, [Parameter(Name = "IdResponsable", DbType = "Int")] int? idResponsable)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), year, idAreaOrganiz, idResponsable);
		return (ISingleResult<spResponsableXUO_ExpResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_ActualizaEmpleado")]
	public int spRRHH_ActualizaEmpleado([Parameter(Name = "CodPer", DbType = "Int")] int? codPer, [Parameter(DbType = "Int")] int? codEmple, [Parameter(DbType = "Int")] int? year, [Parameter(DbType = "Int")] int? idorganiz, [Parameter(Name = "TipoDocIdent", DbType = "Int")] int? tipoDocIdent, [Parameter(Name = "NumDoc", DbType = "Char(12)")] string numDoc, [Parameter(Name = "Apellido_Paterno", DbType = "VarChar(30)")] string apellido_Paterno, [Parameter(Name = "Apellido_Materno", DbType = "VarChar(30)")] string apellido_Materno, [Parameter(Name = "Nombres", DbType = "VarChar(100)")] string nombres, [Parameter(DbType = "Char(6)")] string ubigeoNac, [Parameter(DbType = "DateTime")] DateTime? fechaNac, [Parameter(Name = "Direccion", DbType = "VarChar(100)")] string direccion, [Parameter(Name = "Fono", DbType = "VarChar(15)")] string fono, [Parameter(Name = "FonoLab", DbType = "VarChar(15)")] string fonoLab, [Parameter(Name = "FonoCel", DbType = "VarChar(15)")] string fonoCel, [Parameter(Name = "FonoOtro", DbType = "VarChar(15)")] string fonoOtro, [Parameter(Name = "Mail", DbType = "VarChar(50)")] string mail, [Parameter(Name = "UbigeoDireccion", DbType = "Char(6)")] string ubigeoDireccion, [Parameter(DbType = "Int")] int? idNacionalidad, [Parameter(DbType = "Char(1)")] char? sexo, [Parameter(DbType = "Int")] int? idEstCivil, [Parameter(DbType = "Int")] int? idDiscapacidad, [Parameter(DbType = "VarChar(20)")] string expSocial, [Parameter(Name = "FechaIngreso", DbType = "SmallDateTime")] DateTime? fechaIngreso, [Parameter(DbType = "Int")] int? idtiposangre, [Parameter(DbType = "VarChar(12)")] string brevete, [Parameter(DbType = "VarChar(10)")] string libmilitar, [Parameter(DbType = "VarChar(80)")] string gradoinstrucc, [Parameter(DbType = "VarChar(12)")] string numruc, [Parameter(DbType = "Int")] int? idtipoTrabajador, [Parameter(Name = "Foto", DbType = "Image")] Binary foto)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), codPer, codEmple, year, idorganiz, tipoDocIdent, numDoc, apellido_Paterno, apellido_Materno, nombres, ubigeoNac, fechaNac, direccion, fono, fonoLab, fonoCel, fonoOtro, mail, ubigeoDireccion, idNacionalidad, sexo, idEstCivil, idDiscapacidad, expSocial, fechaIngreso, idtiposangre, brevete, libmilitar, gradoinstrucc, numruc, idtipoTrabajador, foto);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spRRHH_busca_archivos")]
	public ISingleResult<spRRHH_busca_archivosResult> spRRHH_busca_archivos([Parameter(Name = "CodEmple", DbType = "Int")] int? codEmple)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), codEmple);
		return (ISingleResult<spRRHH_busca_archivosResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_busca_Disciplina")]
	public ISingleResult<spRRHH_busca_DisciplinaResult> spRRHH_busca_Disciplina([Parameter(Name = "CodEmple", DbType = "Int")] int? codEmple)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), codEmple);
		return (ISingleResult<spRRHH_busca_DisciplinaResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_busca_empleado")]
	public ISingleResult<spRRHH_busca_empleadoResult> spRRHH_busca_empleado([Parameter(DbType = "Int")] int? idempleado, [Parameter(Name = "NumdocId", DbType = "VarChar(12)")] string numdocId, [Parameter(Name = "Apellido_Paterno", DbType = "VarChar(30)")] string apellido_Paterno, [Parameter(DbType = "Bit")] bool? activo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idempleado, numdocId, apellido_Paterno, activo);
		return (ISingleResult<spRRHH_busca_empleadoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_BuscarEmpleado_Codigo")]
	public ISingleResult<spRRHH_BuscarEmpleado_CodigoResult> spRRHH_BuscarEmpleado_Codigo([Parameter(DbType = "Int")] int? codigo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), codigo);
		return (ISingleResult<spRRHH_BuscarEmpleado_CodigoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_buscarEstudios")]
	public ISingleResult<spRRHH_buscarEstudiosResult> spRRHH_buscarEstudios([Parameter(Name = "CodEmple", DbType = "Int")] int? codEmple)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), codEmple);
		return (ISingleResult<spRRHH_buscarEstudiosResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_BuscarExpLab")]
	public ISingleResult<spRRHH_BuscarExpLabResult> spRRHH_BuscarExpLab([Parameter(Name = "CodEmple", DbType = "Int")] int? codEmple)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), codEmple);
		return (ISingleResult<spRRHH_BuscarExpLabResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_BuscarFamiliares")]
	public ISingleResult<spRRHH_BuscarFamiliaresResult> spRRHH_BuscarFamiliares([Parameter(DbType = "Int")] int? idempleado)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idempleado);
		return (ISingleResult<spRRHH_BuscarFamiliaresResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_EliminarEmpleado")]
	public int spRRHH_EliminarEmpleado([Parameter(DbType = "Int")] int? codEmple)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), codEmple);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spRRHH_Faltas")]
	public ISingleResult<spRRHH_FaltasResult> spRRHH_Faltas([Parameter(DbType = "Char(10)")] string fecha, [Parameter(DbType = "Int")] int? idTipoTrabajador, [Parameter(DbType = "Int")] int? idAreaOrganiz, [Parameter(Name = "Anio", DbType = "Int")] int? anio)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), fecha, idTipoTrabajador, idAreaOrganiz, anio);
		return (ISingleResult<spRRHH_FaltasResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_Ficha_DatosPersonales")]
	public ISingleResult<spRRHH_Ficha_DatosPersonalesResult> spRRHH_Ficha_DatosPersonales([Parameter(Name = "CodEmple", DbType = "Int")] int? codEmple)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), codEmple);
		return (ISingleResult<spRRHH_Ficha_DatosPersonalesResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_Ficha_Det_Familiar")]
	public ISingleResult<spRRHH_Ficha_Det_FamiliarResult> spRRHH_Ficha_Det_Familiar([Parameter(Name = "CodEmple", DbType = "Int")] int? codEmple)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), codEmple);
		return (ISingleResult<spRRHH_Ficha_Det_FamiliarResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_Ficha_Det_Familiar_Salud")]
	public ISingleResult<spRRHH_Ficha_Det_Familiar_SaludResult> spRRHH_Ficha_Det_Familiar_Salud([Parameter(Name = "CodEmple", DbType = "Int")] int? codEmple)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), codEmple);
		return (ISingleResult<spRRHH_Ficha_Det_Familiar_SaludResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_Ficha_Estudio_Capacitacion")]
	public ISingleResult<spRRHH_Ficha_Estudio_CapacitacionResult> spRRHH_Ficha_Estudio_Capacitacion([Parameter(Name = "CodEmple", DbType = "Int")] int? codEmple)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), codEmple);
		return (ISingleResult<spRRHH_Ficha_Estudio_CapacitacionResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_Ficha_Estudio_Realizado")]
	public ISingleResult<spRRHH_Ficha_Estudio_RealizadoResult> spRRHH_Ficha_Estudio_Realizado([Parameter(Name = "CodEmple", DbType = "Int")] int? codEmple)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), codEmple);
		return (ISingleResult<spRRHH_Ficha_Estudio_RealizadoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_Ficha_Estudio_Titulo")]
	public ISingleResult<spRRHH_Ficha_Estudio_TituloResult> spRRHH_Ficha_Estudio_Titulo([Parameter(Name = "CodEmple", DbType = "Int")] int? codEmple)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), codEmple);
		return (ISingleResult<spRRHH_Ficha_Estudio_TituloResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_Ficha_ExpLab")]
	public ISingleResult<spRRHH_Ficha_ExpLabResult> spRRHH_Ficha_ExpLab([Parameter(Name = "CodEmple", DbType = "Int")] int? codEmple)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), codEmple);
		return (ISingleResult<spRRHH_Ficha_ExpLabResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_Ficha_ExpLab_Datos")]
	public ISingleResult<spRRHH_Ficha_ExpLab_DatosResult> spRRHH_Ficha_ExpLab_Datos([Parameter(Name = "CodEmple", DbType = "Int")] int? codEmple)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), codEmple);
		return (ISingleResult<spRRHH_Ficha_ExpLab_DatosResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_Ficha_Ingreso_Egreso")]
	public ISingleResult<spRRHH_Ficha_Ingreso_EgresoResult> spRRHH_Ficha_Ingreso_Egreso([Parameter(Name = "CodEmple", DbType = "Int")] int? codEmple)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), codEmple);
		return (ISingleResult<spRRHH_Ficha_Ingreso_EgresoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_Ficha_Vivienda")]
	public ISingleResult<spRRHH_Ficha_ViviendaResult> spRRHH_Ficha_Vivienda([Parameter(Name = "CodEmple", DbType = "Int")] int? codEmple)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), codEmple);
		return (ISingleResult<spRRHH_Ficha_ViviendaResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_GetAsistencias")]
	public ISingleResult<spRRHH_GetAsistenciasResult> spRRHH_GetAsistencias([Parameter(DbType = "Char(8)")] string dia)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), dia);
		return (ISingleResult<spRRHH_GetAsistenciasResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_GetPeriodoLaboralByEmpleado")]
	public ISingleResult<spRRHH_GetPeriodoLaboralByEmpleadoResult> spRRHH_GetPeriodoLaboralByEmpleado([Parameter(DbType = "Int")] int? idEmpleado)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idEmpleado);
		return (ISingleResult<spRRHH_GetPeriodoLaboralByEmpleadoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_GrabarEmpleado")]
	public int spRRHH_GrabarEmpleado([Parameter(DbType = "Int")] int? year, [Parameter(DbType = "Int")] int? idorganiz, [Parameter(Name = "TipoDocIdent", DbType = "Int")] int? tipoDocIdent, [Parameter(Name = "NumDoc", DbType = "Char(12)")] string numDoc, [Parameter(Name = "Apellido_Paterno", DbType = "VarChar(30)")] string apellido_Paterno, [Parameter(Name = "Apellido_Materno", DbType = "VarChar(30)")] string apellido_Materno, [Parameter(Name = "Nombres", DbType = "VarChar(100)")] string nombres, [Parameter(DbType = "Char(6)")] string ubigeoNac, [Parameter(DbType = "DateTime")] DateTime? fechaNac, [Parameter(Name = "Direccion", DbType = "VarChar(100)")] string direccion, [Parameter(Name = "Fono", DbType = "VarChar(15)")] string fono, [Parameter(Name = "FonoLab", DbType = "VarChar(15)")] string fonoLab, [Parameter(Name = "FonoCel", DbType = "VarChar(15)")] string fonoCel, [Parameter(Name = "FonoOtro", DbType = "VarChar(15)")] string fonoOtro, [Parameter(Name = "Mail", DbType = "VarChar(50)")] string mail, [Parameter(Name = "UbigeoDireccion", DbType = "Char(6)")] string ubigeoDireccion, [Parameter(DbType = "Int")] int? idNacionalidad, [Parameter(DbType = "Char(1)")] char? sexo, [Parameter(DbType = "Int")] int? idEstCivil, [Parameter(DbType = "Int")] int? idDiscapacidad, [Parameter(DbType = "VarChar(20)")] string expSocial, [Parameter(Name = "FechaIngreso", DbType = "SmallDateTime")] DateTime? fechaIngreso, [Parameter(DbType = "Int")] int? idtiposangre, [Parameter(DbType = "VarChar(12)")] string brevete, [Parameter(DbType = "VarChar(10)")] string libmilitar, [Parameter(DbType = "VarChar(80)")] string gradoinstrucc, [Parameter(DbType = "VarChar(12)")] string numruc, [Parameter(DbType = "Int")] int? idtipoTrabajador, [Parameter(Name = "Foto", DbType = "Image")] Binary foto)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), year, idorganiz, tipoDocIdent, numDoc, apellido_Paterno, apellido_Materno, nombres, ubigeoNac, fechaNac, direccion, fono, fonoLab, fonoCel, fonoOtro, mail, ubigeoDireccion, idNacionalidad, sexo, idEstCivil, idDiscapacidad, expSocial, fechaIngreso, idtiposangre, brevete, libmilitar, gradoinstrucc, numruc, idtipoTrabajador, foto);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spRRHH_llenarPermiso")]
	public ISingleResult<spRRHH_llenarPermisoResult> spRRHH_llenarPermiso([Parameter(Name = "IdEmpleado", DbType = "Int")] int? idEmpleado, [Parameter(DbType = "Int")] int? idTipoPermiso, [Parameter(DbType = "Int")] int? idmotivo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idEmpleado, idTipoPermiso, idmotivo);
		return (ISingleResult<spRRHH_llenarPermisoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_mig_ActEmple")]
	public int spRRHH_mig_ActEmple([Parameter(Name = "FechaResolIngreInstitu", DbType = "DateTime")] DateTime? fechaResolIngreInstitu, [Parameter(Name = "NumResolIngreInstitu", DbType = "VarChar(20)")] string numResolIngreInstitu, [Parameter(Name = "FechaIngreEstado", DbType = "DateTime")] DateTime? fechaIngreEstado, [Parameter(Name = "FechaResolIngreEsta", DbType = "DateTime")] DateTime? fechaResolIngreEsta, [Parameter(Name = "NumResolIngreEsta", DbType = "VarChar(20)")] string numResolIngreEsta, [Parameter(DbType = "VarChar(15)")] string numAutogenSalud, [Parameter(DbType = "VarChar(11)")] string numRUC, [Parameter(Name = "GradoInstruccion", DbType = "VarChar(80)")] string gradoInstruccion, [Parameter(Name = "NumLibretaMilitar", DbType = "VarChar(10)")] string numLibretaMilitar, [Parameter(DbType = "Char(1)")] char? sexo, [Parameter(Name = "NroAFP", DbType = "VarChar(20)")] string nroAFP, [Parameter(Name = "FechaAFP", DbType = "DateTime")] DateTime? fechaAFP, [Parameter(DbType = "Int")] int? idAFP, [Parameter(DbType = "VarChar(12)")] string brevete, [Parameter(DbType = "DateTime")] DateTime? fechaIngreso, [Parameter(DbType = "Int")] int? idempleado)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), fechaResolIngreInstitu, numResolIngreInstitu, fechaIngreEstado, fechaResolIngreEsta, numResolIngreEsta, numAutogenSalud, numRUC, gradoInstruccion, numLibretaMilitar, sexo, nroAFP, fechaAFP, idAFP, brevete, fechaIngreso, idempleado);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spRRHH_mig_Cargos")]
	public int spRRHH_mig_Cargos([Parameter(Name = "Cargo", DbType = "VarChar(300)")] string cargo, [Parameter(Name = "Cod", DbType = "Int")] int? cod)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), cargo, cod);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spRRHH_mig_Cargos_Emple")]
	public int spRRHH_mig_Cargos_Emple([Parameter(DbType = "Int")] int? idcargo, [Parameter(DbType = "Int")] int? idEmpleado)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idcargo, idEmpleado);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spRRHH_mig_Emp_10")]
	public int spRRHH_mig_Emp_10([Parameter(Name = "FechaIngreso", DbType = "DateTime")] DateTime? fechaIngreso, [Parameter(DbType = "Char(1)")] char? sexo, [Parameter(DbType = "VarChar(12)")] string brevete, [Parameter(DbType = "VarChar(15)")] string numAutogenSalud, [Parameter(Name = "NumLibretaMilitar", DbType = "VarChar(10)")] string numLibretaMilitar, [Parameter(DbType = "VarChar(11)")] string numRUC, [Parameter(Name = "GradoInstruccion", DbType = "VarChar(80)")] string gradoInstruccion, [Parameter(Name = "NroAFP", DbType = "VarChar(20)")] string nroAFP, [Parameter(DbType = "Int")] int? idpersona)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), fechaIngreso, sexo, brevete, numAutogenSalud, numLibretaMilitar, numRUC, gradoInstruccion, nroAFP, idpersona);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spRRHH_mig_Insertar_dem")]
	public int spRRHH_mig_Insertar_dem([Parameter(DbType = "Int")] int? idComportamiento, [Parameter(DbType = "DateTime")] DateTime? fecha, [Parameter(DbType = "Int")] int? idempleado, [Parameter(DbType = "VarChar(200)")] string numresol, [Parameter(DbType = "VarChar(1000)")] string titulo, [Parameter(DbType = "VarChar(2000)")] string descripcion)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idComportamiento, fecha, idempleado, numresol, titulo, descripcion);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spRRHH_mig_Insertar_Mer")]
	public int spRRHH_mig_Insertar_Mer([Parameter(DbType = "Int")] int? idComportamiento, [Parameter(DbType = "DateTime")] DateTime? fecha, [Parameter(DbType = "Int")] int? idempleado, [Parameter(DbType = "VarChar(200)")] string numresol, [Parameter(DbType = "VarChar(1000)")] string titulo, [Parameter(DbType = "VarChar(2000)")] string descripcion)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idComportamiento, fecha, idempleado, numresol, titulo, descripcion);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spRRHH_mig_persona_10")]
	public int spRRHH_mig_persona_10([Parameter(DbType = "DateTime")] DateTime? fechaNacimiento, [Parameter(DbType = "NVarChar(100)")] string direccion, [Parameter(DbType = "NVarChar(15)")] string telefono, [Parameter(DbType = "Char(6)")] string ubigeo, [Parameter(DbType = "Char(6)")] string ubigeodir, [Parameter(DbType = "VarChar(15)")] string cel, [Parameter(DbType = "Char(12)")] string dni)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), fechaNacimiento, direccion, telefono, ubigeo, ubigeodir, cel, dni);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spRRHH_mig_REgPen")]
	public int spRRHH_mig_REgPen([Parameter(DbType = "Int")] int? idregimenpen, [Parameter(DbType = "Int")] int? idAFP, [Parameter(DbType = "Int")] int? idTipoSangre, [Parameter(DbType = "Int")] int? idEstadoCivil, [Parameter(DbType = "Int")] int? idpersona)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idregimenpen, idAFP, idTipoSangre, idEstadoCivil, idpersona);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spRRHH_Rep_cargos")]
	public ISingleResult<spRRHH_Rep_cargosResult> spRRHH_Rep_cargos([Parameter(DbType = "Int")] int? idCargo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idCargo);
		return (ISingleResult<spRRHH_Rep_cargosResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_Report_CuadroPer")]
	public ISingleResult<spRRHH_Report_CuadroPerResult> spRRHH_Report_CuadroPer([Parameter(Name = "Tipo", DbType = "Int")] int? tipo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), tipo);
		return (ISingleResult<spRRHH_Report_CuadroPerResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_Report_Cumple")]
	public ISingleResult<spRRHH_Report_CumpleResult> spRRHH_Report_Cumple([Parameter(DbType = "Int")] int? mes)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), mes);
		return (ISingleResult<spRRHH_Report_CumpleResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_Report_FechaIngreso")]
	public ISingleResult<spRRHH_Report_FechaIngresoResult> spRRHH_Report_FechaIngreso([Parameter(Name = "FechaIni", DbType = "DateTime")] DateTime? fechaIni, [Parameter(Name = "FechaFin", DbType = "DateTime")] DateTime? fechaFin, [Parameter(DbType = "Int")] int? tipo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), fechaIni, fechaFin, tipo);
		return (ISingleResult<spRRHH_Report_FechaIngresoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_Report_Oficina")]
	public ISingleResult<spRRHH_Report_OficinaResult> spRRHH_Report_Oficina([Parameter(DbType = "VarChar(100)")] string sigla)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), sigla);
		return (ISingleResult<spRRHH_Report_OficinaResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_Report_Oficina_Unico")]
	public ISingleResult<spRRHH_Report_Oficina_UnicoResult> spRRHH_Report_Oficina_Unico([Parameter(DbType = "Int")] int? idarea)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idarea);
		return (ISingleResult<spRRHH_Report_Oficina_UnicoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_RepPlanillaAsistencias")]
	public int spRRHH_RepPlanillaAsistencias([Parameter(Name = "Fechas", DbType = "NVarChar(4000)")] string fechas, [Parameter(DbType = "Char(1)")] char? idTipoTrabajador)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), fechas, idTipoTrabajador);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spSEG_CrearUserSql")]
	public int spSEG_CrearUserSql([Parameter(DbType = "Char(20)")] string usuario)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), usuario);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spSEG_listarUserRol")]
	public ISingleResult<spSEG_listarUserRolResult> spSEG_listarUserRol([Parameter(DbType = "Int")] int? rol)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), rol);
		return (ISingleResult<spSEG_listarUserRolResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spSEG_ListarUsuarios")]
	public ISingleResult<spSEG_ListarUsuariosResult> spSEG_ListarUsuarios()
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod());
		return (ISingleResult<spSEG_ListarUsuariosResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spSEG_llenarInterfaz")]
	public ISingleResult<spSEG_llenarInterfazResult> spSEG_llenarInterfaz([Parameter(Name = "CodMod", DbType = "VarChar(7)")] string codMod)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), codMod);
		return (ISingleResult<spSEG_llenarInterfazResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spSEG_llenarInterfaz_Rol")]
	public ISingleResult<spSEG_llenarInterfaz_RolResult> spSEG_llenarInterfaz_Rol([Parameter(Name = "CodMod", DbType = "VarChar(7)")] string codMod, [Parameter(DbType = "Int")] int? codRol)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), codMod, codRol);
		return (ISingleResult<spSEG_llenarInterfaz_RolResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spSEG_llenarUsuarios")]
	public ISingleResult<spSEG_llenarUsuariosResult> spSEG_llenarUsuarios([Parameter(DbType = "VarChar(100)")] string apellido)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), apellido);
		return (ISingleResult<spSEG_llenarUsuariosResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spSEG_VerfUsuario")]
	public ISingleResult<spSEG_VerfUsuarioResult> spSEG_VerfUsuario([Parameter(DbType = "VarChar(200)")] string login)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), login);
		return (ISingleResult<spSEG_VerfUsuarioResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spUnidadMedida")]
	public int spUnidadMedida([Parameter(Name = "IdUnidadMedida", DbType = "VarChar(4)")] string idUnidadMedida, [Parameter(Name = "Descripcion", DbType = "VarChar(30)")] string descripcion, [Parameter(Name = "Abreviado", DbType = "VarChar(4)")] string abreviado)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idUnidadMedida, descripcion, abreviado);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spUnidadMedida_Exp")]
	public ISingleResult<spUnidadMedida_ExpResult> spUnidadMedida_Exp([Parameter(Name = "IdUnidadMedida", DbType = "VarChar(4)")] string idUnidadMedida)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idUnidadMedida);
		return (ISingleResult<spUnidadMedida_ExpResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spUnidadMedida_Select")]
	public ISingleResult<spUnidadMedida_SelectResult> spUnidadMedida_Select([Parameter(Name = "IdUnidadMedida", DbType = "VarChar(4)")] string idUnidadMedida)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idUnidadMedida);
		return (ISingleResult<spUnidadMedida_SelectResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spUnidMed")]
	public int spUnidMed([Parameter(Name = "IdUnidMed", DbType = "Int")] int? idUnidMed, [Parameter(Name = "Descripcion", DbType = "VarChar(100)")] string descripcion, [Parameter(Name = "Abreviatura", DbType = "VarChar(6)")] string abreviatura)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idUnidMed, descripcion, abreviatura);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spUnidMed_Exp")]
	public ISingleResult<spUnidMed_ExpResult> spUnidMed_Exp([Parameter(Name = "IdUnidMed", DbType = "Int")] int? idUnidMed)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idUnidMed);
		return (ISingleResult<spUnidMed_ExpResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spUnidMed_Select")]
	public ISingleResult<spUnidMed_SelectResult> spUnidMed_Select([Parameter(Name = "IdUnidMed", DbType = "Int")] int? idUnidMed)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idUnidMed);
		return (ISingleResult<spUnidMed_SelectResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.TRA_Adjunto_ListarPorTramite")]
	public ISingleResult<TRA_Adjunto_ListarPorTramiteResult> TRA_Adjunto_ListarPorTramite([Parameter(Name = "IdMovimiento", DbType = "Char(10)")] string idMovimiento, [Parameter(Name = "IdTramite", DbType = "Char(8)")] string idTramite, [Parameter(Name = "Tipo", DbType = "Int")] int? tipo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idMovimiento, idTramite, tipo);
		return (ISingleResult<TRA_Adjunto_ListarPorTramiteResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.TRA_GET_IP_USUARIO")]
	public ISingleResult<TRA_GET_IP_USUARIOResult> TRA_GET_IP_USUARIO([Parameter(Name = "IDPROCEDIMIENTO", DbType = "VarChar(6)")] string iDPROCEDIMIENTO, [Parameter(Name = "IDETAPAPROC", DbType = "VarChar(8)")] string iDETAPAPROC)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), iDPROCEDIMIENTO, iDETAPAPROC);
		return (ISingleResult<TRA_GET_IP_USUARIOResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.TRA_Movimiento_ListaPorTramite")]
	public ISingleResult<TRA_Movimiento_ListaPorTramiteResult> TRA_Movimiento_ListaPorTramite([Parameter(DbType = "Char(8)")] string idtramite)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idtramite);
		return (ISingleResult<TRA_Movimiento_ListaPorTramiteResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.TRA_ProcedimientoRequisito_Listar")]
	public ISingleResult<TRA_ProcedimientoRequisito_ListarResult> TRA_ProcedimientoRequisito_Listar([Parameter(DbType = "Char(20)")] string tracodigo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), tracodigo);
		return (ISingleResult<TRA_ProcedimientoRequisito_ListarResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Tra_ReporteTicket")]
	public ISingleResult<Tra_ReporteTicketResult> Tra_ReporteTicket([Parameter(DbType = "Char(8)")] string idtramite, [Parameter(DbType = "Char(10)")] string idmov, [Parameter(DbType = "VarChar(50)")] string recibe)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idtramite, idmov, recibe);
		return (ISingleResult<Tra_ReporteTicketResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Tra_Sp_Validar_Item_Etapa")]
	public ISingleResult<Tra_Sp_Validar_Item_EtapaResult> Tra_Sp_Validar_Item_Etapa([Parameter(Name = "IdProc", DbType = "Char(6)")] string idProc, [Parameter(DbType = "TinyInt")] byte? item)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idProc, item);
		return (ISingleResult<Tra_Sp_Validar_Item_EtapaResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.TRA_Verificaratraso", IsComposable = true)]
	public int? TRA_Verificaratraso([Parameter(DbType = "Int")] int? tiempodias, [Parameter(DbType = "Float")] double? tiempohrs, [Parameter(DbType = "DateTime")] DateTime? fechaingreso)
	{
		object returnValue = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), tiempodias, tiempohrs, fechaingreso).ReturnValue;
		int? result = default(int?);
		if (returnValue == null)
		{
			return result;
		}
		return (int?)returnValue;
	}

	[Function(Name = "dbo.SIGLA_PADRE", IsComposable = true)]
	public string SIGLA_PADRE([Parameter(Name = "Valor", DbType = "Int")] int? valor, [Parameter(Name = "Year", DbType = "Int")] int? year)
	{
		return Conversions.ToString(ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), valor, year).ReturnValue);
	}

	[Function(Name = "dbo.SIGLA_PADRE_MAX", IsComposable = true)]
	public string SIGLA_PADRE_MAX([Parameter(Name = "Valor", DbType = "Int")] int? valor, [Parameter(Name = "Year", DbType = "Int")] int? year)
	{
		return Conversions.ToString(ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), valor, year).ReturnValue);
	}

	[Function(Name = "dbo.TRA_ObtenerNumeroRecepcion", IsComposable = true)]
	public decimal? TRA_ObtenerNumeroRecepcion([Parameter(Name = "Area", DbType = "Int")] int? area, [Parameter(Name = "Anio", DbType = "Int")] int? anio)
	{
		object returnValue = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), area, anio).ReturnValue;
		decimal? result = default(decimal?);
		if (returnValue == null)
		{
			return result;
		}
		return (decimal?)returnValue;
	}

	[Function(Name = "dbo.Tra_sp_UpdateBatchEtapaProcStd")]
	public int Tra_sp_UpdateBatchEtapaProcStd([Parameter(DbType = "Char(8)")] string idetaproc, [Parameter(DbType = "Char(6)")] string idprocedimiento, [Parameter(DbType = "Char(8)")] string std)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idetaproc, idprocedimiento, std);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.Tra_sp_UpdateBatchEtapaProcAlt")]
	public int Tra_sp_UpdateBatchEtapaProcAlt([Parameter(DbType = "Char(8)")] string idetaproc, [Parameter(DbType = "Char(6)")] string idprocedimiento, [Parameter(Name = "Alt", DbType = "Char(8)")] string alt)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idetaproc, idprocedimiento, alt);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.sp_aba_BuscarMeta")]
	public ISingleResult<sp_aba_BuscarMetaResult> sp_aba_BuscarMeta([Parameter(DbType = "Char(6)")] string meta, [Parameter(Name = "Anio", DbType = "Char(4)")] string anio)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), meta, anio);
		return (ISingleResult<sp_aba_BuscarMetaResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.sp_aba_BuscarOrdenFULL")]
	public ISingleResult<sp_aba_BuscarOrdenFULLResult> sp_aba_BuscarOrdenFULL([Parameter(DbType = "Char(1)")] char? tipoorden, [Parameter(DbType = "Char(8)")] string idorden, [Parameter(DbType = "DateTime")] DateTime? fechaIni, [Parameter(DbType = "DateTime")] DateTime? fechaFin, [Parameter(DbType = "Char(2)")] string idfinanciamiento, [Parameter(DbType = "Char(6)")] string codigoSIAF, [Parameter(DbType = "Char(11)")] string idproveedor, [Parameter(DbType = "VarChar(120)")] string asunto, [Parameter(DbType = "VarChar(180)")] string uso, [Parameter(DbType = "VarChar(600)")] string observaciones, [Parameter(DbType = "VarChar(150)")] string referencia, [Parameter(DbType = "Char(13)")] string idbien, [Parameter(DbType = "VarChar(17)")] string idgasto, [Parameter(DbType = "Char(6)")] string meta, [Parameter(DbType = "Char(4)")] string metaanio, [Parameter(Name = "option", DbType = "Bit")] bool? option)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), tipoorden, idorden, fechaIni, fechaFin, idfinanciamiento, codigoSIAF, idproveedor, asunto, uso, observaciones, referencia, idbien, idgasto, meta, metaanio, option);
		return (ISingleResult<sp_aba_BuscarOrdenFULLResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.sp_tra_Sum_Tiempo_etapa")]
	public ISingleResult<sp_tra_Sum_Tiempo_etapaResult> sp_tra_Sum_Tiempo_etapa([Parameter(DbType = "Char(6)")] string idproc)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idproc);
		return (ISingleResult<sp_tra_Sum_Tiempo_etapaResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.tra_sp_vs_tra_ListarProcedimientoEtapa")]
	public ISingleResult<tra_sp_vs_tra_ListarProcedimientoEtapaResult> tra_sp_vs_tra_ListarProcedimientoEtapa([Parameter(DbType = "Char(8)")] string idprocedimiento)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idprocedimiento);
		return (ISingleResult<tra_sp_vs_tra_ListarProcedimientoEtapaResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.TRA_TramiteRequisito_Listar")]
	public ISingleResult<TRA_TramiteRequisito_ListarResult> TRA_TramiteRequisito_Listar([Parameter(DbType = "Char(8)")] string idtramite, [Parameter(DbType = "Char(20)")] string tracodigo, [Parameter(DbType = "Int")] int? tipo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idtramite, tracodigo, tipo);
		return (ISingleResult<TRA_TramiteRequisito_ListarResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Date", IsComposable = true)]
	public DateTime? Date([Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(Name = "Month", DbType = "Int")] int? month, [Parameter(Name = "Day", DbType = "Int")] int? day)
	{
		object returnValue = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), year, month, day).ReturnValue;
		DateTime? result = default(DateTime?);
		if (returnValue == null)
		{
			return result;
		}
		return (DateTime?)returnValue;
	}

	[Function(Name = "dbo.DateTime", IsComposable = true)]
	public DateTime? DateTime([Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(Name = "Month", DbType = "Int")] int? month, [Parameter(Name = "Day", DbType = "Int")] int? day, [Parameter(Name = "Hour", DbType = "Int")] int? hour, [Parameter(Name = "Minute", DbType = "Int")] int? minute, [Parameter(Name = "Second", DbType = "Int")] int? second)
	{
		object returnValue = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), year, month, day, hour, minute, second).ReturnValue;
		DateTime? result = default(DateTime?);
		if (returnValue == null)
		{
			return result;
		}
		return (DateTime?)returnValue;
	}

	[Function(Name = "dbo.F_tra_F_salida_tramite", IsComposable = true)]
	public DateTime? F_tra_F_salida_tramite([Parameter(Name = "IdTramite", DbType = "Char(10)")] string idTramite)
	{
		object returnValue = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idTramite).ReturnValue;
		DateTime? result = default(DateTime?);
		if (returnValue == null)
		{
			return result;
		}
		return (DateTime?)returnValue;
	}

	[Function(Name = "dbo.Factorial", IsComposable = true)]
	public int? Factorial([Parameter(DbType = "SmallInt")] short? valor)
	{
		object returnValue = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), valor).ReturnValue;
		int? result = default(int?);
		if (returnValue == null)
		{
			return result;
		}
		return (int?)returnValue;
	}

	[Function(Name = "dbo.fClasificadorCodigo", IsComposable = true)]
	public string fClasificadorCodigo([Parameter(Name = "Years", DbType = "Int")] int? years, [Parameter(Name = "CodigoDe", DbType = "Int")] int? codigoDe, [Parameter(Name = "CodigoClasif", DbType = "VarChar(3)")] string codigoClasif)
	{
		return Conversions.ToString(ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), years, codigoDe, codigoClasif).ReturnValue);
	}

	[Function(Name = "dbo.fCodigoPLanMayor", IsComposable = true)]
	public string fCodigoPLanMayor([Parameter(Name = "Years", DbType = "Int")] int? years, [Parameter(Name = "CodigoDe", DbType = "Int")] int? codigoDe)
	{
		return Conversions.ToString(ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), years, codigoDe).ReturnValue);
	}

	[Function(Name = "dbo.fCtaPlanMAyorNivel", IsComposable = true)]
	public string fCtaPlanMAyorNivel([Parameter(Name = "Years", DbType = "Int")] int? years, [Parameter(Name = "Codigo", DbType = "Int")] int? codigo, [Parameter(Name = "Nivel", DbType = "Int")] int? nivel)
	{
		return Conversions.ToString(ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), years, codigo, nivel).ReturnValue);
	}

	[Function(Name = "dbo.fDarResponsableArea", IsComposable = true)]
	public string fDarResponsableArea([Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(Name = "IdAreaOrganiz", DbType = "Int")] int? idAreaOrganiz)
	{
		return Conversions.ToString(ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), year, idAreaOrganiz).ReturnValue);
	}

	[Function(Name = "dbo.fecha", IsComposable = true)]
	public string fecha()
	{
		return Conversions.ToString(ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod()).ReturnValue);
	}

	[Function(Name = "dbo.Get_Time", IsComposable = true)]
	public DateTime? Get_Time([Parameter(Name = "Hour", DbType = "Int")] int? hour, [Parameter(Name = "Minute", DbType = "Int")] int? minute, [Parameter(Name = "Second", DbType = "Int")] int? second)
	{
		object returnValue = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), hour, minute, second).ReturnValue;
		DateTime? result = default(DateTime?);
		if (returnValue == null)
		{
			return result;
		}
		return (DateTime?)returnValue;
	}

	[Function(Name = "dbo.Fecha10_8", IsComposable = true)]
	public string Fecha10_8([Parameter(Name = "Fecha", DbType = "VarChar(10)")] string fecha)
	{
		return Conversions.ToString(ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), fecha).ReturnValue);
	}

	[Function(Name = "dbo.Fecha10_8_YMD", IsComposable = true)]
	public string Fecha10_8_YMD([Parameter(Name = "Fecha", DbType = "VarChar(10)")] string fecha)
	{
		return Conversions.ToString(ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), fecha).ReturnValue);
	}

	[Function(Name = "dbo.Fecha8_10", IsComposable = true)]
	public string Fecha8_10([Parameter(Name = "Fecha", DbType = "VarChar(8)")] string fecha)
	{
		return Conversions.ToString(ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), fecha).ReturnValue);
	}

	[Function(Name = "dbo.Get_Date", IsComposable = true)]
	public DateTime? Get_Date([Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(Name = "Month", DbType = "Int")] int? month, [Parameter(Name = "Day", DbType = "Int")] int? day)
	{
		object returnValue = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), year, month, day).ReturnValue;
		DateTime? result = default(DateTime?);
		if (returnValue == null)
		{
			return result;
		}
		return (DateTime?)returnValue;
	}

	[Function(Name = "dbo.Get_DateTime", IsComposable = true)]
	public DateTime? Get_DateTime([Parameter(Name = "Year", DbType = "Int")] int? year, [Parameter(Name = "Month", DbType = "Int")] int? month, [Parameter(Name = "Day", DbType = "Int")] int? day, [Parameter(Name = "Hour", DbType = "Int")] int? hour, [Parameter(Name = "Minute", DbType = "Int")] int? minute, [Parameter(Name = "Second", DbType = "Int")] int? second)
	{
		object returnValue = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), year, month, day, hour, minute, second).ReturnValue;
		DateTime? result = default(DateTime?);
		if (returnValue == null)
		{
			return result;
		}
		return (DateTime?)returnValue;
	}

	[Function(Name = "dbo.GetToken", IsComposable = true)]
	public string GetToken([Parameter(DbType = "VarChar(1024)")] string cCadena, [Parameter(DbType = "VarChar(10)")] string cCharToken)
	{
		return Conversions.ToString(ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), cCadena, cCharToken).ReturnValue);
	}

	[Function(Name = "dbo.Time", IsComposable = true)]
	public DateTime? Time([Parameter(Name = "Hour", DbType = "Int")] int? hour, [Parameter(Name = "Minute", DbType = "Int")] int? minute, [Parameter(Name = "Second", DbType = "Int")] int? second)
	{
		object returnValue = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), hour, minute, second).ReturnValue;
		DateTime? result = default(DateTime?);
		if (returnValue == null)
		{
			return result;
		}
		return (DateTime?)returnValue;
	}

	[Function(Name = "dbo.TRA_CargoRechazo", IsComposable = true)]
	public int? TRA_CargoRechazo([Parameter(Name = "IdEmpRechazo", DbType = "Int")] int? idEmpRechazo)
	{
		object returnValue = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idEmpRechazo).ReturnValue;
		int? result = default(int?);
		if (returnValue == null)
		{
			return result;
		}
		return (int?)returnValue;
	}

	[Function(Name = "dbo.Tra_Fun_Item_SecSTD", IsComposable = true)]
	public int? Tra_Fun_Item_SecSTD([Parameter(DbType = "Char(6)")] string idprocedimiento, [Parameter(DbType = "Char(8)")] string idetapaproc)
	{
		object returnValue = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idprocedimiento, idetapaproc).ReturnValue;
		int? result = default(int?);
		if (returnValue == null)
		{
			return result;
		}
		return (int?)returnValue;
	}

	[Function(Name = "dbo.TRA_EtapaProcedimiento_ObtenerSiguiente", IsComposable = true)]
	public string TRA_EtapaProcedimiento_ObtenerSiguiente([Parameter(DbType = "Char(6)")] string idProcedimiento)
	{
		return Conversions.ToString(ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idProcedimiento).ReturnValue);
	}

	[Function(Name = "dbo.Tra_Existe_Acuerdo", IsComposable = true)]
	public bool? Tra_Existe_Acuerdo([Parameter(Name = "Nro_Acuerdo", DbType = "VarChar(10)")] string nro_Acuerdo)
	{
		object returnValue = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), nro_Acuerdo).ReturnValue;
		bool? result = default(bool?);
		if (returnValue == null)
		{
			return result;
		}
		return (bool?)returnValue;
	}

	[Function(Name = "dbo.TRA_F_Salida_Oficial", IsComposable = true)]
	public DateTime? TRA_F_Salida_Oficial([Parameter(DbType = "Int")] int? tiempodias, [Parameter(DbType = "Float")] double? tiempohrs, [Parameter(DbType = "DateTime")] DateTime? fechaingreso)
	{
		object returnValue = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), tiempodias, tiempohrs, fechaingreso).ReturnValue;
		DateTime? result = default(DateTime?);
		if (returnValue == null)
		{
			return result;
		}
		return (DateTime?)returnValue;
	}

	[Function(Name = "dbo.Tra_HoraTOMin", IsComposable = true)]
	public int? Tra_HoraTOMin([Parameter(DbType = "Float")] double? nHoras)
	{
		object returnValue = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), nHoras).ReturnValue;
		int? result = default(int?);
		if (returnValue == null)
		{
			return result;
		}
		return (int?)returnValue;
	}

	[Function(Name = "dbo.TRA_NroDiaAdd", IsComposable = true)]
	public int? TRA_NroDiaAdd([Parameter(Name = "NroHora", DbType = "Float")] double? nroHora)
	{
		object returnValue = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), nroHora).ReturnValue;
		int? result = default(int?);
		if (returnValue == null)
		{
			return result;
		}
		return (int?)returnValue;
	}

	[Function(Name = "dbo.TRA_NroMinReal", IsComposable = true)]
	public int? TRA_NroMinReal([Parameter(Name = "NroHora", DbType = "Float")] double? nroHora)
	{
		object returnValue = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), nroHora).ReturnValue;
		int? result = default(int?);
		if (returnValue == null)
		{
			return result;
		}
		return (int?)returnValue;
	}

	[Function(Name = "dbo.TRA_NroHora2Min", IsComposable = true)]
	public int? TRA_NroHora2Min([Parameter(Name = "NroHora", DbType = "Float")] double? nroHora)
	{
		object returnValue = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), nroHora).ReturnValue;
		int? result = default(int?);
		if (returnValue == null)
		{
			return result;
		}
		return (int?)returnValue;
	}

	[Function(Name = "dbo.TRA_NroHoraReal", IsComposable = true)]
	public int? TRA_NroHoraReal([Parameter(Name = "NroHora", DbType = "Float")] double? nroHora)
	{
		object returnValue = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), nroHora).ReturnValue;
		int? result = default(int?);
		if (returnValue == null)
		{
			return result;
		}
		return (int?)returnValue;
	}

	[Function(Name = "dbo.TRA_Tiempo", IsComposable = true)]
	public string TRA_Tiempo([Parameter(Name = "NroDia", DbType = "Int")] int? nroDia, [Parameter(Name = "NroHora", DbType = "Float")] double? nroHora)
	{
		return Conversions.ToString(ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), nroDia, nroHora).ReturnValue);
	}

	[Function(Name = "dbo.Tra_TiempoTotal", IsComposable = true)]
	public string Tra_TiempoTotal([Parameter(DbType = "Int")] int? nDias, [Parameter(DbType = "Float")] double? nHoras)
	{
		return Conversions.ToString(ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), nDias, nHoras).ReturnValue);
	}

	[Function(Name = "dbo.sp_tra_ContarMov")]
	public ISingleResult<sp_tra_ContarMovResult> sp_tra_ContarMov([Parameter(DbType = "VarChar(20)")] string login, [Parameter(DbType = "VarChar(10)")] string estadoReal)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), login, estadoReal);
		return (ISingleResult<sp_tra_ContarMovResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Get_DateFinishTra", IsComposable = true)]
	public DateTime? Get_DateFinishTra([Parameter(DbType = "DateTime")] DateTime? dat, [Parameter(DbType = "Int")] int? intD, [Parameter(DbType = "Int")] int? intH, [Parameter(DbType = "Int")] int? intM)
	{
		object returnValue = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), dat, intD, intH, intM).ReturnValue;
		DateTime? result = default(DateTime?);
		if (returnValue == null)
		{
			return result;
		}
		return (DateTime?)returnValue;
	}

	[Function(Name = "dbo.Verificar_DiaLaboral", IsComposable = true)]
	public DateTime? Verificar_DiaLaboral([Parameter(DbType = "DateTime")] DateTime? dat2)
	{
		object returnValue = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), dat2).ReturnValue;
		DateTime? result = default(DateTime?);
		if (returnValue == null)
		{
			return result;
		}
		return (DateTime?)returnValue;
	}

	[Function(Name = "dbo.VerificarTiempoLaboral", IsComposable = true)]
	public DateTime? VerificarTiempoLaboral([Parameter(DbType = "DateTime")] DateTime? dat)
	{
		object returnValue = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), dat).ReturnValue;
		DateTime? result = default(DateTime?);
		if (returnValue == null)
		{
			return result;
		}
		return (DateTime?)returnValue;
	}

	[Function(Name = "dbo.FormatDateLaboral", IsComposable = true)]
	public DateTime? FormatDateLaboral([Parameter(DbType = "DateTime")] DateTime? dat)
	{
		object returnValue = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), dat).ReturnValue;
		DateTime? result = default(DateTime?);
		if (returnValue == null)
		{
			return result;
		}
		return (DateTime?)returnValue;
	}

	[Function(Name = "dbo.Tra_T_Restante_Excedido", IsComposable = true)]
	public string Tra_T_Restante_Excedido([Parameter(DbType = "DateTime")] DateTime? fsalida, [Parameter(DbType = "DateTime")] DateTime? ftranscurrido)
	{
		return Conversions.ToString(ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), fsalida, ftranscurrido).ReturnValue);
	}

	[Function(Name = "dbo.Aba_sp_Retrieve_Pedido")]
	public ISingleResult<Aba_sp_Retrieve_PedidoResult> Aba_sp_Retrieve_Pedido([Parameter(DbType = "Char(6)")] string idpedido, [Parameter(DbType = "Char(1)")] char? tipoP, [Parameter(DbType = "Char(2)")] string estadoP, [Parameter(DbType = "Char(4)")] string year)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idpedido, tipoP, estadoP, year);
		return (ISingleResult<Aba_sp_Retrieve_PedidoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_sp_Retrieve_Deta_Pedido")]
	public ISingleResult<Aba_sp_Retrieve_Deta_PedidoResult> Aba_sp_Retrieve_Deta_Pedido([Parameter(DbType = "Char(6)")] string idpedido, [Parameter(DbType = "Char(3)")] string tipoD, [Parameter(DbType = "Char(4)")] string year, [Parameter(DbType = "Char(2)")] string estadoD)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idpedido, tipoD, year, estadoD);
		return (ISingleResult<Aba_sp_Retrieve_Deta_PedidoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.Aba_Deta_Consolidado_PorContrato")]
	public ISingleResult<Aba_Deta_Consolidado_PorContratoResult> Aba_Deta_Consolidado_PorContrato([Parameter(DbType = "Char(8)")] string idcontrato, [Parameter(DbType = "Char(1)")] char? tipoOrden, [Parameter(DbType = "Int")] int? tipo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idcontrato, tipoOrden, tipo);
		return (ISingleResult<Aba_Deta_Consolidado_PorContratoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.aba_sp_deta_consolidado_contrato")]
	public ISingleResult<aba_sp_deta_consolidado_contratoResult> aba_sp_deta_consolidado_contrato([Parameter(DbType = "Char(8)")] string idcontrato, [Parameter(DbType = "Int")] int? saldo)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idcontrato, saldo);
		return (ISingleResult<aba_sp_deta_consolidado_contratoResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.sp_aba_CorrNroTipoDoc")]
	public int sp_aba_CorrNroTipoDoc([Parameter(DbType = "Char(2)")] string idTipoDoc, [Parameter(Name = "Anio", DbType = "Char(4)")] string anio)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idTipoDoc, anio);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spRRHH_RepAsisdiarria")]
	public ISingleResult<spRRHH_RepAsisdiarriaResult> spRRHH_RepAsisdiarria([Parameter(Name = "FechaI", DbType = "NVarChar(8)")] string fechaI, [Parameter(Name = "FechaF", DbType = "NVarChar(8)")] string fechaF, [Parameter(Name = "DNI", DbType = "NVarChar(8)")] string dNI, [Parameter(DbType = "Int")] int? area, [Parameter(DbType = "Int")] int? tipo, [Parameter(DbType = "Char(4)")] string anio, [Parameter(DbType = "Int")] int? x)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), fechaI, fechaF, dNI, area, tipo, anio, x);
		return (ISingleResult<spRRHH_RepAsisdiarriaResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_GetMinTarde")]
	public ISingleResult<spRRHH_GetMinTardeResult> spRRHH_GetMinTarde([Parameter(Name = "FI", DbType = "VarChar(8)")] string fI, [Parameter(Name = "FF", DbType = "VarChar(8)")] string fF, [Parameter(Name = "IdTipoTrabajador", DbType = "Char(1)")] char? idTipoTrabajador)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), fI, fF, idTipoTrabajador);
		return (ISingleResult<spRRHH_GetMinTardeResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_GetDiasAsistidos")]
	public ISingleResult<spRRHH_GetDiasAsistidosResult> spRRHH_GetDiasAsistidos([Parameter(Name = "FI", DbType = "VarChar(8)")] string fI, [Parameter(Name = "FF", DbType = "VarChar(8)")] string fF, [Parameter(Name = "IdTipoTrabajador", DbType = "Char(1)")] char? idTipoTrabajador)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), fI, fF, idTipoTrabajador);
		return (ISingleResult<spRRHH_GetDiasAsistidosResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_TempFecha_Insert")]
	public int spRRHH_TempFecha_Insert([Parameter(Name = "Fecha", DbType = "DateTime")] DateTime? fecha)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), fecha);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spRRHH_getMotivo_perm")]
	public ISingleResult<spRRHH_getMotivo_permResult> spRRHH_getMotivo_perm([Parameter(DbType = "Int")] int? idTipoPermiso, [Parameter(Name = "TipoModalidad", DbType = "Char(1)")] char? tipoModalidad)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idTipoPermiso, tipoModalidad);
		return (ISingleResult<spRRHH_getMotivo_permResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_GetRecordAsistenciasSemanales")]
	public ISingleResult<spRRHH_GetRecordAsistenciasSemanalesResult> spRRHH_GetRecordAsistenciasSemanales([Parameter(Name = "FI", DbType = "NVarChar(8)")] string fI, [Parameter(DbType = "NVarChar(8)")] string ff, [Parameter(Name = "IdTipoTrabajador", DbType = "Int")] int? idTipoTrabajador)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), fI, ff, idTipoTrabajador);
		return (ISingleResult<spRRHH_GetRecordAsistenciasSemanalesResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.sp_Update_Empleado_idHorario_By_idEmpleado")]
	public int sp_Update_Empleado_idHorario_By_idEmpleado([Parameter(DbType = "Int")] int? idEmpleado, [Parameter(DbType = "Int")] int? idHorario)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idEmpleado, idHorario);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spRRHH_GetReporteAsistencia")]
	public int spRRHH_GetReporteAsistencia([Parameter(Name = "FI", DbType = "NVarChar(8)")] string fI, [Parameter(DbType = "NVarChar(8)")] string ff, [Parameter(Name = "Anio", DbType = "Int")] int? anio, [Parameter(DbType = "Int")] int? idTipoTrabajador)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), fI, ff, anio, idTipoTrabajador);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.sp_Listar_Empleado_Horario")]
	public ISingleResult<sp_Listar_Empleado_HorarioResult> sp_Listar_Empleado_Horario([Parameter(Name = "IdTipoTrabajador", DbType = "Int")] int? idTipoTrabajador, [Parameter(Name = "Apellido_Paterno", DbType = "NVarChar(30)")] string apellido_Paterno)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idTipoTrabajador, apellido_Paterno);
		return (ISingleResult<sp_Listar_Empleado_HorarioResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_RepPermisos")]
	public ISingleResult<spRRHH_RepPermisosResult> spRRHH_RepPermisos([Parameter(Name = "FechaInicio", DbType = "NVarChar(8)")] string fechaInicio, [Parameter(Name = "FechaFin", DbType = "NVarChar(8)")] string fechaFin, [Parameter(DbType = "Int")] int? idTipoPermiso, [Parameter(DbType = "Int")] int? idmotivo, [Parameter(DbType = "Int")] int? idtipoEmpleado)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), fechaInicio, fechaFin, idTipoPermiso, idmotivo, idtipoEmpleado);
		return (ISingleResult<spRRHH_RepPermisosResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.sp_aba_BuscarOrden")]
	public ISingleResult<sp_aba_BuscarOrdenResult> sp_aba_BuscarOrden([Parameter(DbType = "Char(1)")] char? tipoorden, [Parameter(DbType = "Char(8)")] string idorden, [Parameter(DbType = "DateTime")] DateTime? fechaIni, [Parameter(DbType = "DateTime")] DateTime? fechaFin, [Parameter(DbType = "Char(2)")] string idfinanciamiento, [Parameter(DbType = "Char(6)")] string codigoSIAF, [Parameter(DbType = "Char(11)")] string idproveedor, [Parameter(DbType = "VarChar(120)")] string asunto, [Parameter(DbType = "VarChar(180)")] string uso, [Parameter(DbType = "VarChar(600)")] string observaciones, [Parameter(DbType = "VarChar(150)")] string referencia, [Parameter(DbType = "Char(13)")] string idbien, [Parameter(DbType = "VarChar(17)")] string idgasto, [Parameter(DbType = "Char(6)")] string meta, [Parameter(Name = "option", DbType = "Bit")] bool? option)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), tipoorden, idorden, fechaIni, fechaFin, idfinanciamiento, codigoSIAF, idproveedor, asunto, uso, observaciones, referencia, idbien, idgasto, meta, option);
		return (ISingleResult<sp_aba_BuscarOrdenResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.sp_Listar_Empleado_Local")]
	public ISingleResult<sp_Listar_Empleado_LocalResult> sp_Listar_Empleado_Local([Parameter(Name = "IdTipoTrabajador", DbType = "Int")] int? idTipoTrabajador, [Parameter(Name = "Apellido_Paterno", DbType = "NVarChar(30)")] string apellido_Paterno)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idTipoTrabajador, apellido_Paterno);
		return (ISingleResult<sp_Listar_Empleado_LocalResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.sp_Update_Empleado_idLocal_By_idEmpleado")]
	public int sp_Update_Empleado_idLocal_By_idEmpleado([Parameter(DbType = "Int")] int? idEmpleado, [Parameter(DbType = "Int")] int? idLocal)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idEmpleado, idLocal);
		return Conversions.ToInteger(result.ReturnValue);
	}

	[Function(Name = "dbo.spRRHH_ListarRotaciones")]
	public ISingleResult<spRRHH_ListarRotacionesResult> spRRHH_ListarRotaciones([Parameter(DbType = "Int")] int? idEmpleado)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idEmpleado);
		return (ISingleResult<spRRHH_ListarRotacionesResult>)result.ReturnValue;
	}

	[Function(Name = "dbo.spRRHH_ListarResolucion")]
	public ISingleResult<spRRHH_ListarResolucionResult> spRRHH_ListarResolucion([Parameter(DbType = "Int")] int? idEmpleado)
	{
		IExecuteResult result = ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), idEmpleado);
		return (ISingleResult<spRRHH_ListarResolucionResult>)result.ReturnValue;
	}
}
