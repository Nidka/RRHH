# Anexo 1A. Árbol completo del espacio de trabajo

[Volver a origen y entorno](01_origen_entorno.md). Inventario de nombres al inicio del informe: incluye archivos locales ignorados, bin/obj y documentación previa si existen. No se leyó .env ni datos de sus secretos. Se omiten únicamente objetos internos .git, enlaces simbólicos y estos archivos de salida para evitar autorreferencia. No confundir archivo presente con archivo versionado o proyecto compilado.

1519 archivos físicos; 1313 entradas versionadas según git ls-files. La presencia de .git y el historial sí acreditan control de versiones local. La comparación con el ejecutable original requiere su inventario/hash externo.

Este inventario es histórico, del corte `138dbce`: el borrador local `docs/t2/INFORME_T2.docx` que aparece en el árbol fue retirado antes de publicar el análisis. El informe académico se entrega por separado; ese archivo no forma parte del repositorio.


```text
RRHH/
├── .github/
│   └── pull_request_template.md
├── BD/
│   ├── migrations/
│   │   └── 20261015_01_complete_module_tables.sql
│   ├── export-schema.cmd
│   ├── export-schema.ps1
│   ├── password-auth.sql
│   ├── README.md
│   └── schema.sql
├── docs/
│   ├── t2/
│   │   ├── aportes/
│   │   │   ├── TEC-003/
│   │   │   │   └── ANALISIS_TEC_003.md
│   │   │   └── TEC-004/
│   │   │       ├── CARACTERIZACION.md
│   │   │       └── README.md
│   │   ├── diagramas/
│   │   │   ├── TEC-003/
│   │   │   │   ├── flujo-asistencia.md
│   │   │   │   ├── flujo-feriados-antes-despues.md
│   │   │   │   └── flujo-reportes.md
│   │   │   └── TEC-004/
│   │   │       ├── svg/
│   │   │       │   ├── flujos-funcionales-1.svg
│   │   │       │   ├── flujos-funcionales-2.svg
│   │   │       │   ├── flujos-funcionales-3.svg
│   │   │       │   ├── motivos-antes-despues-1.svg
│   │   │       │   ├── motivos-antes-despues-2.svg
│   │   │       │   └── motivos-antes-despues-3.svg
│   │   │       ├── FLUJOS_FUNCIONALES.md
│   │   │       └── MOTIVOS_ANTES_DESPUES.md
│   │   ├── evidencias/
│   │   │   ├── TEC-001/
│   │   │   │   └── validacion-local.txt
│   │   │   ├── TEC-003/
│   │   │   │   └── EVIDENCIAS_TEC_003.md
│   │   │   ├── TEC-004/
│   │   │   │   ├── catalogos-solo-lectura.txt
│   │   │   │   ├── compilacion-net48.txt
│   │   │   │   ├── ejecutar_pruebas_portables.py
│   │   │   │   ├── resultado-portable.txt
│   │   │   │   └── resumen-portable.json
│   │   │   └── VERIFICACION_BD_2026-10-16.txt
│   │   ├── ANALISIS_Y_PREPARACION_T2.md
│   │   ├── AVANCE_CODIGO_Y_SUSTENTACION.md
│   │   ├── CONTROL_CAMBIOS.csv
│   │   ├── ENTREGA_Y_EVIDENCIAS.md
│   │   ├── ESTADO_0a4b6a8.md
│   │   ├── INFORME_T2.docx
│   │   ├── MATRIZ_REQUERIMIENTOS.csv
│   │   ├── PLAN_EQUIPO.md
│   │   ├── PRIMERA_PRUEBA.md
│   │   ├── PROMPT_GENERAL_REFACTORIZACION.md
│   │   ├── PROMPTS_POR_INTEGRANTE.md
│   │   └── README.md
│   └── .DS_Store
├── Software/
│   ├── ClassRRHH/
│   │   ├── ClassRRHH/
│   │   │   ├── My/
│   │   │   │   ├── Resources/
│   │   │   │   │   └── Resources.cs
│   │   │   │   ├── InternalXmlHelper.cs
│   │   │   │   ├── MyApplication.cs
│   │   │   │   ├── MyComputer.cs
│   │   │   │   ├── MyProject.cs
│   │   │   │   ├── MySettings.cs
│   │   │   │   └── MySettingsProperty.cs
│   │   │   ├── AsistenciaAccess.cs
│   │   │   ├── FamiliaresClass.cs
│   │   │   ├── FichaSocialClass.cs
│   │   │   └── RRHHClass.cs
│   │   ├── obj/
│   │   │   ├── ClassRRHH.csproj.nuget.dgspec.json
│   │   │   ├── ClassRRHH.csproj.nuget.g.props
│   │   │   ├── ClassRRHH.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   ├── Properties/
│   │   │   └── AssemblyInfo.cs
│   │   ├── app.ico
│   │   └── ClassRRHH.csproj
│   ├── ClsCtrls/
│   │   ├── ClsCtrls/
│   │   │   ├── My/
│   │   │   │   ├── Resources/
│   │   │   │   │   └── Resources.cs
│   │   │   │   ├── InternalXmlHelper.cs
│   │   │   │   ├── MyApplication.cs
│   │   │   │   ├── MyComputer.cs
│   │   │   │   ├── MyProject.cs
│   │   │   │   ├── MySettings.cs
│   │   │   │   └── MySettingsProperty.cs
│   │   │   ├── Clases.cs
│   │   │   ├── ClsStrToken.cs
│   │   │   ├── Combito.cs
│   │   │   └── ModVar.cs
│   │   ├── Properties/
│   │   │   └── AssemblyInfo.cs
│   │   ├── app.ico
│   │   └── ClsCtrls.csproj
│   ├── CustomFeaturedMessageBox/
│   │   ├── Custom_Featured_MessageBox/
│   │   │   ├── Properties/
│   │   │   │   ├── Resources.cs
│   │   │   │   └── Settings.cs
│   │   │   ├── XMessageBox.cs
│   │   │   ├── XMessageBoxButtons.cs
│   │   │   ├── XMessageBoxIcon.cs
│   │   │   └── XTextBox.cs
│   │   ├── Properties/
│   │   │   └── AssemblyInfo.cs
│   │   ├── Custom Featured MessageBox.csproj
│   │   └── Custom_Featured_MessageBox.Properties.Resources.resx
│   ├── docs/
│   │   ├── adr/
│   │   │   └── 0001-mvp-sobre-capas.md
│   │   ├── ARQUITECTURA.md
│   │   ├── PLAN_REFACTORIZACION.md
│   │   └── POSTGRESQL_MIGRATION.md
│   ├── GRLL/
│   │   ├── GRLL/
│   │   │   └── Common/
│   │   │       ├── My/
│   │   │       │   ├── Resources/
│   │   │       │   │   └── Resources.cs
│   │   │       │   ├── MyApplication.cs
│   │   │       │   ├── MyComputer.cs
│   │   │       │   ├── MyProject.cs
│   │   │       │   ├── MySettings.cs
│   │   │       │   └── MySettingsProperty.cs
│   │   │       ├── Aba_Actividad.cs
│   │   │       ├── Aba_Actividad_GetAllResult.cs
│   │   │       ├── Aba_Actividad_GetBySubProgramaResult.cs
│   │   │       ├── Aba_Actividad_GetOneResult.cs
│   │   │       ├── Aba_Almacen_ListarResult.cs
│   │   │       ├── Aba_Bien_ListarNoAlmacenResult.cs
│   │   │       ├── Aba_Bien_ListarPorAlmacenResult.cs
│   │   │       ├── Aba_Bien_StockPorAlmacenResult.cs
│   │   │       ├── Aba_Clase_GetAllResult.cs
│   │   │       ├── Aba_Clase_GetByGrupoResult.cs
│   │   │       ├── Aba_Clase_GetOneResult.cs
│   │   │       ├── Aba_Componente_GetAllResult.cs
│   │   │       ├── Aba_Componente_GetByActividadResult.cs
│   │   │       ├── Aba_Componente_GetOneResult.cs
│   │   │       ├── Aba_Consolidado_LIstarPorFechaResult.cs
│   │   │       ├── Aba_Contrato_ListarPorConsolidadoResult.cs
│   │   │       ├── Aba_Contrato_ObtenerDetalladoResult.cs
│   │   │       ├── Aba_Contrato_ObtenerListadoResult.cs
│   │   │       ├── Aba_Deta_Consolidado_BuenaProResult.cs
│   │   │       ├── Aba_Deta_Consolidado_ListarDetalleResult.cs
│   │   │       ├── Aba_Deta_Consolidado_ListarResult.cs
│   │   │       ├── Aba_Deta_Consolidado_ObtenerPorProveedorResult.cs
│   │   │       ├── Aba_Deta_Consolidado_PorContratoResult.cs
│   │   │       ├── Aba_Deta_Cotizacion_SelectPorProveedorResult.cs
│   │   │       ├── Aba_Deta_Distribucion_PorConsolidadoResult.cs
│   │   │       ├── Aba_Deta_Distribucion_PorOrdenCompraResult.cs
│   │   │       ├── Aba_Deta_Orden_ListarDespachoResult.cs
│   │   │       ├── Aba_Deta_Orden_PorOrdenResult.cs
│   │   │       ├── Aba_Deta_Pedido_GetAllResult.cs
│   │   │       ├── Aba_Deta_Pedido_GetOneResult.cs
│   │   │       ├── Aba_Deta_pedido_PorConsolidadoResult.cs
│   │   │       ├── Aba_Familia_GetAllResult.cs
│   │   │       ├── Aba_Familia_GetByClaseResult.cs
│   │   │       ├── Aba_Familia_GetOneResult.cs
│   │   │       ├── Aba_Funcion_GetAllResult.cs
│   │   │       ├── Aba_Funcion_GetOneResult.cs
│   │   │       ├── Aba_Grupo_GetAllResult.cs
│   │   │       ├── Aba_Grupo_GetOneResult.cs
│   │   │       ├── ABa_Meta_Area_ListarResult.cs
│   │   │       ├── Aba_Meta_ListarAnioResult.cs
│   │   │       ├── Aba_Meta_ListarSaldosResult.cs
│   │   │       ├── Aba_Movimiento_ListarResult.cs
│   │   │       ├── Aba_Parametro_Periodo_ListarResult.cs
│   │   │       ├── Aba_Pedido_GetAllResult.cs
│   │   │       ├── Aba_Pedido_GetOneResult.cs
│   │   │       ├── Aba_Pedido_ListarPendientesConsolidarResult.cs
│   │   │       ├── Aba_Pedido_ListarPorEstadoResult.cs
│   │   │       ├── Aba_Persona_ListarResult.cs
│   │   │       ├── Aba_Programa_GetAllResult.cs
│   │   │       ├── Aba_Programa_GetByFuncionResult.cs
│   │   │       ├── Aba_Programa_GetOneResult.cs
│   │   │       ├── Aba_Proveedor_ListarResult.cs
│   │   │       ├── aba_sp_deta_consolidado_contratoResult.cs
│   │   │       ├── aba_sp_Procedimiento_ReqResult.cs
│   │   │       ├── Aba_sp_Retrieve_Deta_PedidoResult.cs
│   │   │       ├── Aba_sp_Retrieve_PedidoResult.cs
│   │   │       ├── Aba_SubPrograma_GetAllResult.cs
│   │   │       ├── Aba_SubPrograma_GetByProgramaResult.cs
│   │   │       ├── Aba_SubPrograma_GetOneResult.cs
│   │   │       ├── aba_vs_Deta_Consolidado_Contrato.cs
│   │   │       ├── aba_vs_Deta_Consolidado_ContratoMapper.cs
│   │   │       ├── aba_vs_financiamiento.cs
│   │   │       ├── aba_vs_financiamientoMapper.cs
│   │   │       ├── aba_vs_RecepcionBien.cs
│   │   │       ├── aba_vs_RecepcionBienMapper.cs
│   │   │       ├── Actividad.cs
│   │   │       ├── Actividad_GetAllResult.cs
│   │   │       ├── Actividad_GetOneResult.cs
│   │   │       ├── AFP.cs
│   │   │       ├── AFPMapper.cs
│   │   │       ├── AguaViv.cs
│   │   │       ├── AguaVivMapper.cs
│   │   │       ├── Alerta.cs
│   │   │       ├── AlertaMapper.cs
│   │   │       ├── Alertita.cs
│   │   │       ├── Almacen.cs
│   │   │       ├── Almacen_Bien.cs
│   │   │       ├── Almacen_BienMapper.cs
│   │   │       ├── AlmacenMapper.cs
│   │   │       ├── AlumbradoViv.cs
│   │   │       ├── AlumbradoVivMapper.cs
│   │   │       ├── ANT_Anticipo.cs
│   │   │       ├── ANT_Movimiento.cs
│   │   │       ├── ANT_SP_BuscarAnticipoResult.cs
│   │   │       ├── ANT_SP_BuscarMovimientoResult.cs
│   │   │       ├── ANT_VS_Personal_GRLL.cs
│   │   │       ├── Aprobacion_Pedido.cs
│   │   │       ├── Aprobacion_PedidoMapper.cs
│   │   │       ├── Archivo.cs
│   │   │       ├── ArchivoMapper.cs
│   │   │       ├── asis_norm.cs
│   │   │       ├── Asistencia.cs
│   │   │       ├── AsistenciaMapper.cs
│   │   │       ├── AudActividad.cs
│   │   │       ├── AudEmpleado.cs
│   │   │       ├── AudEstrategia.cs
│   │   │       ├── AudEstructOrg.cs
│   │   │       ├── AudObjetivo.cs
│   │   │       ├── AudTablas.cs
│   │   │       ├── AutoCompleteEventArgs.cs
│   │   │       ├── Banco.cs
│   │   │       ├── BancoMapper.cs
│   │   │       ├── Bien.cs
│   │   │       ├── BienMapper.cs
│   │   │       ├── CAP_Visitante.cs
│   │   │       ├── Capacitacion.cs
│   │   │       ├── CapacitacionMapper.cs
│   │   │       ├── Cargo.cs
│   │   │       ├── CargoMapper.cs
│   │   │       ├── CategoriaGasto.cs
│   │   │       ├── CategoriaGastoMapper.cs
│   │   │       ├── ChequeCaj.cs
│   │   │       ├── ChequeCajMapper.cs
│   │   │       ├── CJRDevolucionNorma.cs
│   │   │       ├── CJRDevolucionNormaMapper.cs
│   │   │       ├── CJRDictamenComision.cs
│   │   │       ├── CJRDictamenComisionMapper.cs
│   │   │       ├── CJRIniciativa.cs
│   │   │       ├── CJRIniciativaMapper.cs
│   │   │       ├── CJRNormaRegional.cs
│   │   │       ├── CJRNormaRegionalMapper.cs
│   │   │       ├── CJRNotificacionNorma.cs
│   │   │       ├── CJRNotificacionNormaMapper.cs
│   │   │       ├── CJROficio.cs
│   │   │       ├── CJROficiosMapper.cs
│   │   │       ├── CJROperador.cs
│   │   │       ├── CJROperadorMapper.cs
│   │   │       ├── CJRPromulgacionNorma.cs
│   │   │       ├── CJRPromulgacionNormaMapper.cs
│   │   │       ├── CJRProyectoNormativo.cs
│   │   │       ├── CJRProyectoNormativoMapper.cs
│   │   │       ├── CJRPublicacion.cs
│   │   │       ├── CJRPublicacionesMapper.cs
│   │   │       ├── CJRPublicacionNorma.cs
│   │   │       ├── CJRPublicacionNormaMapper.cs
│   │   │       ├── CJRResSolicitudOpinion.cs
│   │   │       ├── CJRResSolicitudOpinionMapper.cs
│   │   │       ├── CJRSesion.cs
│   │   │       ├── CJRSesionMapper.cs
│   │   │       ├── CJRSolicitudOpinion.cs
│   │   │       ├── CJRSolicitudOpinionMapper.cs
│   │   │       ├── CJRTemaIniciativa.cs
│   │   │       ├── CJRTemaIniciativaMapper.cs
│   │   │       ├── CJRTipoAprobacion.cs
│   │   │       ├── CJRTipoAprobacionMapper.cs
│   │   │       ├── CJRTipoMedio.cs
│   │   │       ├── CJRTipoMedioMapper.cs
│   │   │       ├── CJRTipoNorma.cs
│   │   │       ├── CJRTipoNormaMapper.cs
│   │   │       ├── CJRTipoProyecto.cs
│   │   │       ├── CJRTipoProyectoMapper.cs
│   │   │       ├── CJRTipoSesion.cs
│   │   │       ├── CJRTipoSesionMapper.cs
│   │   │       ├── CJRTipoSolicitud.cs
│   │   │       ├── CJRTrasladoComision.cs
│   │   │       ├── CJRTrasladoComisionMapper.cs
│   │   │       ├── Clase.cs
│   │   │       ├── ClaseCbo.cs
│   │   │       ├── ClaseMapper.cs
│   │   │       ├── ClaseTipo.cs
│   │   │       ├── ClasificadorIngreso.cs
│   │   │       ├── ClasificadorIngresoMapper.cs
│   │   │       ├── clsConexion.cs
│   │   │       ├── ClsExcel.cs
│   │   │       ├── ClsFunciones.cs
│   │   │       ├── ClsIList.cs
│   │   │       ├── clsLogin.cs
│   │   │       ├── ClsNroLetras.cs
│   │   │       ├── ClsTipoDatos.cs
│   │   │       ├── ClsTUbigeo.cs
│   │   │       ├── clsVariables.cs
│   │   │       ├── Componente.cs
│   │   │       ├── Comportamiento.cs
│   │   │       ├── ComportamientoMapper.cs
│   │   │       ├── ConservacionViv.cs
│   │   │       ├── ConservacionVivMapper.cs
│   │   │       ├── Consolidado.cs
│   │   │       ├── ConsolidadoMapper.cs
│   │   │       ├── Contrato.cs
│   │   │       ├── Cotizacion.cs
│   │   │       ├── CotizacionMapper.cs
│   │   │       ├── dcGRLLDataContext.cs
│   │   │       ├── Despacho.cs
│   │   │       ├── Deta_Consolidado.cs
│   │   │       ├── Deta_ConsolidadoMapper.cs
│   │   │       ├── Deta_Cotizacion.cs
│   │   │       ├── Deta_CotizacionMapper.cs
│   │   │       ├── Deta_Despacho.cs
│   │   │       ├── Deta_Distribucion.cs
│   │   │       ├── Deta_DistribucionMapper.cs
│   │   │       ├── Deta_Movimiento.cs
│   │   │       ├── Deta_MovimientoMapper.cs
│   │   │       ├── Deta_Orden.cs
│   │   │       ├── Deta_OrdenMapper.cs
│   │   │       ├── Deta_Pedido.cs
│   │   │       ├── Deta_PedidoMapper.cs
│   │   │       ├── DetFacturaCaj.cs
│   │   │       ├── DetFacturaCajMapper.cs
│   │   │       ├── Discapacidad.cs
│   │   │       ├── Documento.cs
│   │   │       ├── DocumentoMapper.cs
│   │   │       ├── Egreso.cs
│   │   │       ├── EgresoMapper.cs
│   │   │       ├── Empleado.cs
│   │   │       ├── Empleado_Area.cs
│   │   │       ├── Empleado_Marcacion.cs
│   │   │       ├── Empleado_old.cs
│   │   │       ├── EmpleadoMapper.cs
│   │   │       ├── Especifica.cs
│   │   │       ├── Especifica_Det.cs
│   │   │       ├── EspecificaGasto.cs
│   │   │       ├── EspecificaGastoMapper.cs
│   │   │       ├── EstadoCivil.cs
│   │   │       ├── EstadoCivilMapper.cs
│   │   │       ├── EstadoEstudio.cs
│   │   │       ├── EstadoEstudioMapper.cs
│   │   │       ├── EstadoPedido.cs
│   │   │       ├── EstadoPedidoMapper.cs
│   │   │       ├── EstadoSunat.cs
│   │   │       ├── Estrategia.cs
│   │   │       ├── EstructOrganiz.cs
│   │   │       ├── EstructOrganizMapper.cs
│   │   │       ├── EstudiosRealizado.cs
│   │   │       ├── EstudiosRealizadoMapper.cs
│   │   │       ├── EvaluacionGestion.cs
│   │   │       ├── ExcretasViv.cs
│   │   │       ├── ExcretasVivMapper.cs
│   │   │       ├── ExpLaboral.cs
│   │   │       ├── ExpLaboralMapper.cs
│   │   │       ├── FacturaCaj.cs
│   │   │       ├── FacturaCajMapper.cs
│   │   │       ├── Familia.cs
│   │   │       ├── FamiliaMapper.cs
│   │   │       ├── Familiar.cs
│   │   │       ├── FamiliarMapper.cs
│   │   │       ├── ficha_personal.cs
│   │   │       ├── finalidad.cs
│   │   │       ├── FinalidadMapper.cs
│   │   │       ├── Financiamiento.cs
│   │   │       ├── FinanciamientoMapper.cs
│   │   │       ├── FlatBoxEventArgs.cs
│   │   │       ├── fLogin.cs
│   │   │       ├── FormaPago.cs
│   │   │       ├── frmBase.cs
│   │   │       ├── frmBase1.cs
│   │   │       ├── frmBaseImg.cs
│   │   │       ├── frmBaseMant.cs
│   │   │       ├── FrmConsulta.cs
│   │   │       ├── FrmMaestro.cs
│   │   │       ├── frmMantBaseFTS.cs
│   │   │       ├── frmMantBaseFTSb.cs
│   │   │       ├── frmPrueba.cs
│   │   │       ├── Funcion.cs
│   │   │       ├── GastoPublico.cs
│   │   │       ├── GastoPublicoMapper.cs
│   │   │       ├── Generica.cs
│   │   │       ├── GenericaGasto.cs
│   │   │       ├── GenericaGastoMapper.cs
│   │   │       ├── GenericMapper.cs
│   │   │       ├── GRLL_Sistema_ListarResult.cs
│   │   │       ├── GRLL_Usuario_AccesoResult.cs
│   │   │       ├── Grupo.cs
│   │   │       ├── GrupoMapper.cs
│   │   │       ├── Horario.cs
│   │   │       ├── HorarioMapper.cs
│   │   │       ├── horarios.cs
│   │   │       ├── HorarioTemporal.cs
│   │   │       ├── HorarioTemporalMapper.cs
│   │   │       ├── Inconveniente.cs
│   │   │       ├── Ingreso.cs
│   │   │       ├── IngresoCaj.cs
│   │   │       ├── IngresoCajMapper.cs
│   │   │       ├── IngresoMapper.cs
│   │   │       ├── Inserted.cs
│   │   │       ├── Institucion.cs
│   │   │       ├── InversPublica.cs
│   │   │       ├── InversXFuentF.cs
│   │   │       ├── KM_LogMensaje.cs
│   │   │       ├── KM_LogMensajeMapper.cs
│   │   │       ├── KM_LogReprod.cs
│   │   │       ├── KM_LogReprodMapper.cs
│   │   │       ├── KM_Mensaje.cs
│   │   │       ├── KM_MensajeMapper.cs
│   │   │       ├── KM_Motivo.cs
│   │   │       ├── KM_MotivoMapper.cs
│   │   │       ├── KM_Orden.cs
│   │   │       ├── KM_OrdenMapper.cs
│   │   │       ├── KM_Parametro.cs
│   │   │       ├── KM_ParametroMapper.cs
│   │   │       ├── KM_PlayListAviso.cs
│   │   │       ├── KM_PlayListAvisoMapper.cs
│   │   │       ├── KM_PlayListPrincipal.cs
│   │   │       ├── KM_PlayListPrincipalMapper.cs
│   │   │       ├── KM_TipoOperacion.cs
│   │   │       ├── KM_TipoOperacionMapper.cs
│   │   │       ├── KM_VideoList.cs
│   │   │       ├── KM_VideoListMapper.cs
│   │   │       ├── Limitacion.cs
│   │   │       ├── LINQ_sp_listartablasResult.cs
│   │   │       ├── Local.cs
│   │   │       ├── LocalMapper.cs
│   │   │       ├── LoginForm.cs
│   │   │       ├── Logros.cs
│   │   │       ├── Marcacion.cs
│   │   │       ├── marcaciones.cs
│   │   │       ├── MarcacionMapper.cs
│   │   │       ├── MaterialViv.cs
│   │   │       ├── MaterialVivMapper.cs
│   │   │       ├── Meta.cs
│   │   │       ├── Meta_Area.cs
│   │   │       ├── Meta_AreaMapper.cs
│   │   │       ├── MetaMapper.cs
│   │   │       ├── miAlerta.cs
│   │   │       ├── ModalidadAplicacion.cs
│   │   │       ├── ModalidadAplicacionMapper.cs
│   │   │       ├── ModFunciones.cs
│   │   │       ├── Motivo_Perm.cs
│   │   │       ├── Motivo_PermMapper.cs
│   │   │       ├── MotivoBaja.cs
│   │   │       ├── MotivoBajaMapper.cs
│   │   │       ├── Movimiento.cs
│   │   │       ├── MovimientoMapper.cs
│   │   │       ├── Nacionalidad.cs
│   │   │       ├── NacionalidadMapper.cs
│   │   │       ├── NroCuenta.cs
│   │   │       ├── NroCuentaMapper.cs
│   │   │       ├── Objetivo.cs
│   │   │       ├── Operacion.cs
│   │   │       ├── OperacionMapper.cs
│   │   │       ├── OrdenCompra.cs
│   │   │       ├── OrdenCompraMapper.cs
│   │   │       ├── p_ActividadResult.cs
│   │   │       ├── p_listaEstrategiaObjResult.cs
│   │   │       ├── p_ObjetivoActividadResult.cs
│   │   │       ├── PapeletDepositCaj.cs
│   │   │       ├── PapeletDepositCajMapper.cs
│   │   │       ├── Parametro_Periodo.cs
│   │   │       ├── Parametro_PeriodoMapper.cs
│   │   │       ├── Parametros.cs
│   │   │       ├── ParametrosCaja.cs
│   │   │       ├── ParametrosCajaMapper.cs
│   │   │       ├── ParametrosMapper.cs
│   │   │       ├── ParametrosTrab.cs
│   │   │       ├── Pedido.cs
│   │   │       ├── Pedido_Despacho.cs
│   │   │       ├── PedidoMapper.cs
│   │   │       ├── PeriodoLaboral.cs
│   │   │       ├── PeriodoLaboralMapper.cs
│   │   │       ├── PeriodoTrimestral.cs
│   │   │       ├── Permiso.cs
│   │   │       ├── PermisoMapper.cs
│   │   │       ├── Persona.cs
│   │   │       ├── PersonaMapper.cs
│   │   │       ├── PersonaSunat.cs
│   │   │       ├── PlanMayor.cs
│   │   │       ├── PlanMayorMapper.cs
│   │   │       ├── PresupuestoT.cs
│   │   │       ├── Programa.cs
│   │   │       ├── ProgramaNF.cs
│   │   │       ├── ProgramaProp.cs
│   │   │       ├── ProgramaPropMapper.cs
│   │   │       ├── ProgramMes.cs
│   │   │       ├── Proveedor.cs
│   │   │       ├── Proveedor_Bien.cs
│   │   │       ├── Proveedor_BienMapper.cs
│   │   │       ├── ProveedorMapper.cs
│   │   │       ├── RangoFecha.cs
│   │   │       ├── Recomendacion.cs
│   │   │       ├── RefSIAF.cs
│   │   │       ├── RefSIAFMapper.cs
│   │   │       ├── RegAsisDiario.cs
│   │   │       ├── RegimenPension.cs
│   │   │       ├── RegimenPensionMapper.cs
│   │   │       ├── Reporte_Asistencias.cs
│   │   │       ├── ReqXProgMes.cs
│   │   │       ├── Resolucion.cs
│   │   │       ├── ResolucionMapper.cs
│   │   │       ├── ResponsableXUO.cs
│   │   │       ├── Rol.cs
│   │   │       ├── Rol_Acceso.cs
│   │   │       ├── Rol_AccesoMapper.cs
│   │   │       ├── RolMapper.cs
│   │   │       ├── Rotacion.cs
│   │   │       ├── RotacionMapper.cs
│   │   │       ├── RRHH_AcudeEnferm.cs
│   │   │       ├── RRHH_AcudeEnfermMapper.cs
│   │   │       ├── RRHH_Asegurado.cs
│   │   │       ├── RRHH_AseguradoMapper.cs
│   │   │       ├── RRHH_AspSocio.cs
│   │   │       ├── RRHH_AspSocioMapper.cs
│   │   │       ├── RRHH_DinamicaFamiliar.cs
│   │   │       ├── RRHH_DinamicaFamiliarMapper.cs
│   │   │       ├── RRHH_Feriado.cs
│   │   │       ├── RRHH_FeriadoMapper.cs
│   │   │       ├── RRHH_FuncFam.cs
│   │   │       ├── RRHH_FuncFamMapper.cs
│   │   │       ├── RRHH_Preg1.cs
│   │   │       ├── RRHH_Preg1Mapper.cs
│   │   │       ├── RRHH_Preg2.cs
│   │   │       ├── RRHH_Preg2Mapper.cs
│   │   │       ├── RRHH_Preg3.cs
│   │   │       ├── RRHH_Preg3Mapper.cs
│   │   │       ├── RRHH_RelacHermano.cs
│   │   │       ├── RRHH_RelacHermanoMapper.cs
│   │   │       ├── RRHH_RelacPareja.cs
│   │   │       ├── RRHH_RelacParejaMapper.cs
│   │   │       ├── RRHH_RelacPH.cs
│   │   │       ├── RRHH_RelacPHMapper.cs
│   │   │       ├── RRHH_Salud.cs
│   │   │       ├── RRHH_SaludMapper.cs
│   │   │       ├── RRHH_TempFecha.cs
│   │   │       ├── RRHH_TempFechaMapper.cs
│   │   │       ├── RRHH_TipoFamilia.cs
│   │   │       ├── RRHH_TipoFamiliaMapper.cs
│   │   │       ├── Seguro.cs
│   │   │       ├── SeguroMapper.cs
│   │   │       ├── SettingLogin.cs
│   │   │       ├── SistemaOpcion.cs
│   │   │       ├── SistemaOpcionMapper.cs
│   │   │       ├── sp_aba_BuscarBienResult.cs
│   │   │       ├── sp_aba_BuscarGastoResult.cs
│   │   │       ├── sp_aba_BuscarMetaResult.cs
│   │   │       ├── sp_aba_BuscarOrdenFULLResult.cs
│   │   │       ├── sp_aba_BuscarOrdenResult.cs
│   │   │       ├── sp_aba_Corre_CodMetaResult.cs
│   │   │       ├── SP_ABA_FILTRAR_BIEN_TIPOResult.cs
│   │   │       ├── SP_ABA_FILTRARMETAResult.cs
│   │   │       ├── sp_ABA_ImpDetOrdenCBienResult.cs
│   │   │       ├── sp_ABA_ImpOrdenCBienResult.cs
│   │   │       ├── sp_aba_NroMaxPerResult.cs
│   │   │       ├── sp_aba_OrdenDetalleResult.cs
│   │   │       ├── sp_aba_usuario_areaOResult.cs
│   │   │       ├── sp_AbaNroMaxMovimientoResult.cs
│   │   │       ├── sp_Listar_Empleado_HorarioResult.cs
│   │   │       ├── sp_Listar_Empleado_LocalResult.cs
│   │   │       ├── sp_pruebaResult.cs
│   │   │       ├── sp_Rep_PrincipalResult.cs
│   │   │       ├── sp_RRHH_Busca_Empleado_treeResult.cs
│   │   │       ├── SP_Tra_Art_NroResult.cs
│   │   │       ├── sp_Tra_BuscarTramiteResult.cs
│   │   │       ├── sp_tra_ContarMovResult.cs
│   │   │       ├── sp_tra_MaxIdRequisitoResult.cs
│   │   │       ├── sp_tra_Sum_Tiempo_etapaResult.cs
│   │   │       ├── sp_Tra_TRA_ListarMovimientoResult.cs
│   │   │       ├── sp_Tra_TraListarTramiteResult.cs
│   │   │       ├── sp_Tra_Usuario_AreaCargoResult.cs
│   │   │       ├── sp_Tra_vs_TRA_ListarMovimientoResult.cs
│   │   │       ├── sp_Tra_vs_TRA_ListarMovimientoTiempoXEstadoResult.cs
│   │   │       ├── sp_Tra_vs_TRA_ListarMovimientoXEstadoResult.cs
│   │   │       ├── sp_Tra_VS_TRA_ListarTramiteResult.cs
│   │   │       ├── spActividad_ExpResult.cs
│   │   │       ├── spActividad_InversPublicMaxResult.cs
│   │   │       ├── spActividad_SelectResult.cs
│   │   │       ├── spBien_ExpResult.cs
│   │   │       ├── spBien_SelectResult.cs
│   │   │       ├── spCJ_Banco_SelectResult.cs
│   │   │       ├── spCJ_ChequeCaj_SelectResult.cs
│   │   │       ├── spCJ_FacturaCaj_SelectFechResult.cs
│   │   │       ├── spCJ_FacturaCaj_SelectProvResult.cs
│   │   │       ├── spCJ_FacturaCaj_SelectResult.cs
│   │   │       ├── spCJ_IngresoCaj_CON_PapeletaResult.cs
│   │   │       ├── spCJ_IngresoCaj_SelectFechResult.cs
│   │   │       ├── spCJ_IngresoCaj_SelectResult.cs
│   │   │       ├── spCJ_IngresoCaj_SIN_PapeletaResult.cs
│   │   │       ├── spCJ_NroCuenta_SelectResult.cs
│   │   │       ├── spCJ_PapeletDepositCajSelectFFResult.cs
│   │   │       ├── spCJ_PapeletDepositCajSelectFResult.cs
│   │   │       ├── spCJ_PapeletDepositCajSelectNroPResult.cs
│   │   │       ├── spCJ_Persona_SelectResult.cs
│   │   │       ├── spCJ_RefSIAF_SelectResult.cs
│   │   │       ├── spCJ_TipoMoneda_Select_GridResult.cs
│   │   │       ├── spCJ_TipoMoneda_SelectResult.cs
│   │   │       ├── spCJ_TransferenciaBco_SelectResult.cs
│   │   │       ├── spCJ_vClasificadorIngreso_LstResult.cs
│   │   │       ├── spCJ_vClasificadorIngresoResult.cs
│   │   │       ├── spCJ_vPlanMayor_LstResult.cs
│   │   │       ├── spCJ_vPlanMayorResult.cs
│   │   │       ├── spCJR_BuscarNormaResult.cs
│   │   │       ├── spCJR_BuscarPresetIniciaResult.cs
│   │   │       ├── spCJR_BuscarProyNormativoResult.cs
│   │   │       ├── spCJR_llenarDictamenesResult.cs
│   │   │       ├── spCJR_llenarEmpleadosResult.cs
│   │   │       ├── spCJR_llenarIniciativaResult.cs
│   │   │       ├── spCJR_llenarNormaRegionalResult.cs
│   │   │       ├── spCJR_llenarNotificacionesResult.cs
│   │   │       ├── spCJR_llenarObservacionNormaResult.cs
│   │   │       ├── spCJR_llenarOfiTrasladoResult.cs
│   │   │       ├── spCJR_llenarOperadoresActivosResult.cs
│   │   │       ├── spCJR_llenarOperadoresResult.cs
│   │   │       ├── spCJR_llenarPromulgacionesResult.cs
│   │   │       ├── spCJR_llenarProyNormativoResult.cs
│   │   │       ├── spCJR_llenarPublicacionesResult.cs
│   │   │       ├── spCJR_llenarSesionesResult.cs
│   │   │       ├── spCJR_llenarSolLegalResult.cs
│   │   │       ├── spCJR_llenarSolPubliNormaResult.cs
│   │   │       ├── spCJR_llenarSolTecResult.cs
│   │   │       ├── spCJR_Rep_AcuerdosResult.cs
│   │   │       ├── spCJR_Report_GeneralResult.cs
│   │   │       ├── spCJR_Report_OfiTemaResult.cs
│   │   │       ├── SpCJR_ReportCJR_Nuevo_pResult.cs
│   │   │       ├── SpCJR_ReportCJR_NuevoResult.cs
│   │   │       ├── spEmpleaditoResult.cs
│   │   │       ├── spEmpleado_ExpResult.cs
│   │   │       ├── spEmpleado_NotIn_All_Solo_PlaResult.cs
│   │   │       ├── spEmpleado_Select_Activ_UOResult.cs
│   │   │       ├── spEmpleado_Select_NotInResult.cs
│   │   │       ├── spEmpleado_SelectResult.cs
│   │   │       ├── spEmpleado_SNP_Select_NotIn_AllResult.cs
│   │   │       ├── spEmpleado_SNP_Select_NotInResult.cs
│   │   │       ├── spEstrategia_ExpResult.cs
│   │   │       ├── spEstrategia_SelectResult.cs
│   │   │       ├── spEstructOrganiz_ExpResult.cs
│   │   │       ├── spEstructOrganiz_Select_LstResult.cs
│   │   │       ├── spEstructOrganiz_SelectResult.cs
│   │   │       ├── spFinanciamiento_ExpResult.cs
│   │   │       ├── spFinanciamiento_SelectResult.cs
│   │   │       ├── spInversPublica_ExpResult.cs
│   │   │       ├── spInversPublica_SelectResult.cs
│   │   │       ├── spInversXFuentF_ExpResult.cs
│   │   │       ├── spInversXFuentF_SelectResult.cs
│   │   │       ├── spInversXFuentFResult.cs
│   │   │       ├── spKM_GetNextVideoPlayAvisoResult.cs
│   │   │       ├── spKM_GetNextVideoPlayPrincResult.cs
│   │   │       ├── spKM_GetPlayAvisoResult.cs
│   │   │       ├── spKM_GetPlayPrincResult.cs
│   │   │       ├── spKM_GetSgtColaResult.cs
│   │   │       ├── spKM_GetVideoListResult.cs
│   │   │       ├── spKM_repAtencionResult.cs
│   │   │       ├── spKM_RepMensajesResult.cs
│   │   │       ├── spKM_ReportPersAtendxCajResult.cs
│   │   │       ├── spKM_repTiempoAtencionResult.cs
│   │   │       ├── spKM_repTipoTramiteResult.cs
│   │   │       ├── spKM_repTotalAtendidosResult.cs
│   │   │       ├── spKM_RepVideosResult.cs
│   │   │       ├── spLimit_Recomen_Logro_PrintResult.cs
│   │   │       ├── spLimitacion_ExpResult.cs
│   │   │       ├── spLimitacion_Recomendacion_TVResult.cs
│   │   │       ├── spLimitacion_SelectResult.cs
│   │   │       ├── splistartablasResult.cs
│   │   │       ├── spLogros_ExpResult.cs
│   │   │       ├── spLogros_Limitacion_TVResult.cs
│   │   │       ├── spLogros_SelectResult.cs
│   │   │       ├── spLogrosLimitacion_TVResult.cs
│   │   │       ├── spMeses_SelectResult.cs
│   │   │       ├── spObjet_Avance_SelectResult.cs
│   │   │       ├── spObjetivo_ExpResult.cs
│   │   │       ├── spObjetivo_SelectResult.cs
│   │   │       ├── spParametrosTrab_ExpResult.cs
│   │   │       ├── spParametrosTrab_SelectResult.cs
│   │   │       ├── spParametrosTrabResult.cs
│   │   │       ├── spPresupuestoT_ExpResult.cs
│   │   │       ├── spPresupuestoT_SelectResult.cs
│   │   │       ├── spProgramMes_ExpResult.cs
│   │   │       ├── spProgramMes_SelectResult.cs
│   │   │       ├── spProgramMesResult.cs
│   │   │       ├── spRecomendacion_ExpResult.cs
│   │   │       ├── spRecomendacion_SelectResult.cs
│   │   │       ├── spReqXProgMes_ExpResult.cs
│   │   │       ├── spReqXProgMes_SelectResult.cs
│   │   │       ├── spReqXProgMesResult.cs
│   │   │       ├── spResponsableXUO_ExpResult.cs
│   │   │       ├── spRRHH_busca_archivosResult.cs
│   │   │       ├── spRRHH_busca_DisciplinaResult.cs
│   │   │       ├── spRRHH_busca_empleadoResult.cs
│   │   │       ├── spRRHH_BuscarEmpleado_CodigoResult.cs
│   │   │       ├── spRRHH_buscarEstudiosResult.cs
│   │   │       ├── spRRHH_BuscarExpLabResult.cs
│   │   │       ├── spRRHH_BuscarFamiliaresResult.cs
│   │   │       ├── spRRHH_FaltasResult.cs
│   │   │       ├── spRRHH_Ficha_DatosPersonalesResult.cs
│   │   │       ├── spRRHH_Ficha_Det_Familiar_SaludResult.cs
│   │   │       ├── spRRHH_Ficha_Det_FamiliarResult.cs
│   │   │       ├── spRRHH_Ficha_Estudio_CapacitacionResult.cs
│   │   │       ├── spRRHH_Ficha_Estudio_RealizadoResult.cs
│   │   │       ├── spRRHH_Ficha_Estudio_TituloResult.cs
│   │   │       ├── spRRHH_Ficha_ExpLab_DatosResult.cs
│   │   │       ├── spRRHH_Ficha_ExpLabResult.cs
│   │   │       ├── spRRHH_Ficha_Ingreso_EgresoResult.cs
│   │   │       ├── spRRHH_Ficha_ViviendaResult.cs
│   │   │       ├── spRRHH_GetAsistenciasResult.cs
│   │   │       ├── spRRHH_GetDiasAsistidosResult.cs
│   │   │       ├── spRRHH_GetMinTardeResult.cs
│   │   │       ├── spRRHH_getMotivo_permResult.cs
│   │   │       ├── spRRHH_GetPeriodoLaboralByEmpleadoResult.cs
│   │   │       ├── spRRHH_GetRecordAsistenciasSemanalesResult.cs
│   │   │       ├── spRRHH_ListarResolucionResult.cs
│   │   │       ├── spRRHH_ListarRotacionesResult.cs
│   │   │       ├── spRRHH_llenarPermisoResult.cs
│   │   │       ├── spRRHH_Rep_cargosResult.cs
│   │   │       ├── spRRHH_RepAsisdiarriaResult.cs
│   │   │       ├── spRRHH_Report_CuadroPerResult.cs
│   │   │       ├── spRRHH_Report_CumpleResult.cs
│   │   │       ├── spRRHH_Report_FechaIngresoResult.cs
│   │   │       ├── spRRHH_Report_Oficina_UnicoResult.cs
│   │   │       ├── spRRHH_Report_OficinaResult.cs
│   │   │       ├── spRRHH_RepPermisosResult.cs
│   │   │       ├── spSEG_listarUserRolResult.cs
│   │   │       ├── spSEG_ListarUsuariosResult.cs
│   │   │       ├── spSEG_llenarInterfaz_RolResult.cs
│   │   │       ├── spSEG_llenarInterfazResult.cs
│   │   │       ├── spSEG_llenarUsuariosResult.cs
│   │   │       ├── spSEG_VerfUsuarioResult.cs
│   │   │       ├── spUnidadMedida_ExpResult.cs
│   │   │       ├── spUnidadMedida_SelectResult.cs
│   │   │       ├── spUnidMed_ExpResult.cs
│   │   │       ├── spUnidMed_SelectResult.cs
│   │   │       ├── SQLConfiguracion.cs
│   │   │       ├── SubGenerica.cs
│   │   │       ├── SubGenerica_Det.cs
│   │   │       ├── SubPrograma.cs
│   │   │       ├── sysLogEvent.cs
│   │   │       ├── TenenciaViv.cs
│   │   │       ├── TenenciaVivMapper.cs
│   │   │       ├── TEstiloCelda.cs
│   │   │       ├── TipoAdjudicacion.cs
│   │   │       ├── TipoAlerta.cs
│   │   │       ├── TipoAlertaMapper.cs
│   │   │       ├── TipoComportamiento.cs
│   │   │       ├── TipoComportamientoMapper.cs
│   │   │       ├── TipoDoc.cs
│   │   │       ├── TipoDocID.cs
│   │   │       ├── TipoDocIDMapper.cs
│   │   │       ├── TipoDocMapper.cs
│   │   │       ├── TipoEstudio.cs
│   │   │       ├── TipoEstudioMapper.cs
│   │   │       ├── TipoFamiliar.cs
│   │   │       ├── TipoInstitucion.cs
│   │   │       ├── TipoInstitucionMapper.cs
│   │   │       ├── TipoMoneda.cs
│   │   │       ├── TipoMonedaMapper.cs
│   │   │       ├── TipoMovimiento.cs
│   │   │       ├── TipoMovimientoMapper.cs
│   │   │       ├── TipoPermiso.cs
│   │   │       ├── TipoPermisoMapper.cs
│   │   │       ├── TipoRecurso.cs
│   │   │       ├── TipoRecursoMapper.cs
│   │   │       ├── TipoResolucion.cs
│   │   │       ├── TipoResolucionMapper.cs
│   │   │       ├── TipoSangre.cs
│   │   │       ├── TipoSangreMapper.cs
│   │   │       ├── TipoTrabajador.cs
│   │   │       ├── TipoTrabajadorMapper.cs
│   │   │       ├── TipoTransaccion.cs
│   │   │       ├── TipoViv.cs
│   │   │       ├── TipoVivMapper.cs
│   │   │       ├── TitulosEmpleado.cs
│   │   │       ├── TitulosEmpleadoMapper.cs
│   │   │       ├── Tra_Acuerdo.cs
│   │   │       ├── Tra_AcuerdoMapper.cs
│   │   │       ├── TRA_Adjunto_ListarPorTramiteResult.cs
│   │   │       ├── Tra_Articulo_Acuerdo.cs
│   │   │       ├── Tra_Articulo_AcuerdoMapper.cs
│   │   │       ├── TRA_GET_IP_USUARIOResult.cs
│   │   │       ├── TRA_Movimiento_ListaPorTramiteResult.cs
│   │   │       ├── TRA_ProcedimientoRequisito_ListarResult.cs
│   │   │       ├── Tra_ReporteTicketResult.cs
│   │   │       ├── Tra_Sp_Validar_Item_EtapaResult.cs
│   │   │       ├── tra_sp_vs_tra_ListarProcedimientoEtapaResult.cs
│   │   │       ├── TRA_TramiteRequisito_ListarResult.cs
│   │   │       ├── TRAAdjunto.cs
│   │   │       ├── TRAAdjuntoMapper.cs
│   │   │       ├── TRADocumento.cs
│   │   │       ├── TRADocumentoMapper.cs
│   │   │       ├── TRAEtapa_Cargo.cs
│   │   │       ├── TRAEtapa_CargoMapper.cs
│   │   │       ├── TRAEtapa_Procedimiento.cs
│   │   │       ├── TRAEtapa_ProcedimientoMapper.cs
│   │   │       ├── TRAMovimiento.cs
│   │   │       ├── TRAMovimientoMapper.cs
│   │   │       ├── TransferenciaBco.cs
│   │   │       ├── TransferenciaBcoMapper.cs
│   │   │       ├── TransparentLabel.cs
│   │   │       ├── TRANumeracion.cs
│   │   │       ├── TRANumeracionMapper.cs
│   │   │       ├── TRAProcedimiento.cs
│   │   │       ├── TRAProcedimiento_Requisito.cs
│   │   │       ├── TRAProcedimiento_RequisitoMapper.cs
│   │   │       ├── TRAProcedimientoMapper.cs
│   │   │       ├── TRARequisito.cs
│   │   │       ├── TRARequisitoMapper.cs
│   │   │       ├── TRATipoDoc.cs
│   │   │       ├── TRATipoDocMapper.cs
│   │   │       ├── TRATipoSilencio.cs
│   │   │       ├── TRATipoSilencioMapper.cs
│   │   │       ├── TRATramite.cs
│   │   │       ├── TRATramite_Requisito.cs
│   │   │       ├── TRATramite_RequisitoMapper.cs
│   │   │       ├── TRATramiteMapper.cs
│   │   │       ├── TRAUsuario_IP.cs
│   │   │       ├── TRAUsuario_IPMapper.cs
│   │   │       ├── UbicacionViv.cs
│   │   │       ├── UbicacionVivMapper.cs
│   │   │       ├── Ubigeo.cs
│   │   │       ├── UbigeoMapper.cs
│   │   │       ├── ucBuscaClienteProveedor.cs
│   │   │       ├── ucBuscaDato.cs
│   │   │       ├── ucButton.cs
│   │   │       ├── ucCboAnio.cs
│   │   │       ├── ucCboMes.cs
│   │   │       ├── ucComboBox.cs
│   │   │       ├── ucDataGridView.cs
│   │   │       ├── ucDateTime.cs
│   │   │       ├── ucFechas.cs
│   │   │       ├── ucFill.cs
│   │   │       ├── ucFindFile.cs
│   │   │       ├── ucFoto.cs
│   │   │       ├── ucLabel.cs
│   │   │       ├── ucListData.cs
│   │   │       ├── ucLogin.cs
│   │   │       ├── ucMyBottom.cs
│   │   │       ├── ucNavButton.cs
│   │   │       ├── ucPanel.cs
│   │   │       ├── ucText.cs
│   │   │       ├── ucTextBox.cs
│   │   │       ├── ucTextCombo.cs
│   │   │       ├── ucToolStripMaestro.cs
│   │   │       ├── ucTView1T.cs
│   │   │       ├── ucTViewNT.cs
│   │   │       ├── ucTViewV1T.cs
│   │   │       ├── ucTViewVNT.cs
│   │   │       ├── ucTVWVista.cs
│   │   │       ├── ucUbigeoCmb.cs
│   │   │       ├── ucUbigeoCombito.cs
│   │   │       ├── ucUbigeoLinq.cs
│   │   │       ├── UnidadEquivalencia.cs
│   │   │       ├── UnidadMedida.cs
│   │   │       ├── UnidadMedidaMapper.cs
│   │   │       ├── UnidMed.cs
│   │   │       ├── Usuario.cs
│   │   │       ├── Usuario_Rol.cs
│   │   │       ├── Usuario_RolMapper.cs
│   │   │       ├── UsuarioMapper.cs
│   │   │       ├── vActividad.cs
│   │   │       ├── vActividad_ProgramMes.cs
│   │   │       ├── VariableGestion.cs
│   │   │       ├── Variables.cs
│   │   │       ├── vCJ_ClasificadorIngreso.cs
│   │   │       ├── vCJ_ClasificadorIngresoMapper.cs
│   │   │       ├── vCJ_PersonaJuridica.cs
│   │   │       ├── vCJ_PersonaJuridicaMapper.cs
│   │   │       ├── vCJ_PersonaNatural.cs
│   │   │       ├── vCJ_PersonaNaturalMapper.cs
│   │   │       ├── vCJ_PersonaNJ.cs
│   │   │       ├── vCJ_PersonaNJMapper.cs
│   │   │       ├── vCJ_PlanMayor.cs
│   │   │       ├── vCJ_PlanMayorMapper.cs
│   │   │       ├── vEmpleadoxpersona.cs
│   │   │       ├── vEstrategia.cs
│   │   │       ├── vEstructOrganiz.cs
│   │   │       ├── vEstructOrganizCmbObj.cs
│   │   │       ├── vEstructOrganizMapper.cs
│   │   │       ├── VistaNode.cs
│   │   │       ├── vistaUnidad.cs
│   │   │       ├── ViveCon.cs
│   │   │       ├── ViveConMapper.cs
│   │   │       ├── Vivienda.cs
│   │   │       ├── ViviendaMapper.cs
│   │   │       ├── vObjetivo.cs
│   │   │       ├── vReqXProgMesXProgramMes.cs
│   │   │       ├── vs_ABA_AprobacionPedido.cs
│   │   │       ├── VS_ABA_BIENUNIMED.cs
│   │   │       ├── VS_ABA_BIENUNIMEDMapper.cs
│   │   │       ├── vs_aba_CorrelativoBien.cs
│   │   │       ├── vs_aba_CorrelativoBienMapper.cs
│   │   │       ├── vs_ABA_Departamentos.cs
│   │   │       ├── vs_aba_Detalle.cs
│   │   │       ├── vs_aba_DetalleMapper.cs
│   │   │       ├── vs_ABA_Distritos.cs
│   │   │       ├── vs_ABA_GastoPublico.cs
│   │   │       ├── vs_ABA_GastoPublicoMapper.cs
│   │   │       ├── vs_ABA_ListarAprobacionesPedido.cs
│   │   │       ├── VS_ABA_LISTARBIEN_ALMACEN.cs
│   │   │       ├── VS_ABA_LISTARBIEN_ALMACENMapper.cs
│   │   │       ├── vs_ABA_ListarBieneMapper.cs
│   │   │       ├── vs_ABA_ListarBienes.cs
│   │   │       ├── vs_ABA_ListarCotizacion.cs
│   │   │       ├── vs_ABA_ListarCotizacionMapper.cs
│   │   │       ├── vs_ABA_ListarDetalleCotizacion.cs
│   │   │       ├── vs_ABA_ListarDetalleCotizacionMapper.cs
│   │   │       ├── vs_ABA_ListarDetalleOrden.cs
│   │   │       ├── vs_ABA_ListarDetallePedido.cs
│   │   │       ├── vs_ABA_ListarDetallePedidoMapper.cs
│   │   │       ├── vs_ABA_ListarMetas.cs
│   │   │       ├── vs_aba_listarmetasMapper.cs
│   │   │       ├── vs_ABA_ListarOrdenCompra.cs
│   │   │       ├── vs_ABA_ListarOrdenCompraMapper.cs
│   │   │       ├── vs_ABA_ListarPedidoMapper.cs
│   │   │       ├── vs_ABA_ListarPedidos.cs
│   │   │       ├── VS_ABA_LISTARPROVEEDOR.cs
│   │   │       ├── VS_ABA_LISTARPROVEEDORMapper.cs
│   │   │       ├── vs_ABA_ListarTrabajador.cs
│   │   │       ├── VS_ABA_META.cs
│   │   │       ├── vs_aba_MetaFull.cs
│   │   │       ├── vs_aba_metafullMapper.cs
│   │   │       ├── VS_ABA_METAMapper.cs
│   │   │       ├── vs_aba_NroBien.cs
│   │   │       ├── vs_aba_NroBienMapper.cs
│   │   │       ├── vs_aba_NroMaxMovimiento.cs
│   │   │       ├── VS_ABA_NROMAXPERJ.cs
│   │   │       ├── VS_ABA_NROMAXPERJMapper.cs
│   │   │       ├── VS_ABA_NROMAXPN.cs
│   │   │       ├── vs_ABA_Proveedor.cs
│   │   │       ├── vs_ABA_Proveedores.cs
│   │   │       ├── vs_aba_proveedorMapper.cs
│   │   │       ├── vs_ABA_Provincias.cs
│   │   │       ├── vs_ABA_Ubigeo.cs
│   │   │       ├── vs_ABA_UnidadEquivalencia.cs
│   │   │       ├── vs_CJr_Norma.cs
│   │   │       ├── vs_CJR_NormaReg.cs
│   │   │       ├── vs_CJR_OficioSol.cs
│   │   │       ├── vs_CJR_Proyecto.cs
│   │   │       ├── vs_CJr_ProyectoNor.cs
│   │   │       ├── vs_Faltas.cs
│   │   │       ├── vs_GetEmpleado.cs
│   │   │       ├── vs_PER_ListarEmpleadoMapper.cs
│   │   │       ├── vs_PER_ListarEmpleados.cs
│   │   │       ├── vs_PTI_ListarOrganigrama.cs
│   │   │       ├── vs_RRHH_buscarEmpleado.cs
│   │   │       ├── vs_RRHH_FamFicha.cs
│   │   │       ├── vs_RRHH_FichaSocial.cs
│   │   │       ├── vs_SEG_usuario.cs
│   │   │       ├── VS_TRA_ACUERDO_ARTICULO.cs
│   │   │       ├── VS_TRA_ACUERDO_ARTICULOMapper.cs
│   │   │       ├── vs_tra_listar_movimiento_tramite.cs
│   │   │       ├── vs_tra_listar_movimiento_tramite_G.cs
│   │   │       ├── vs_tra_listar_movimiento_tramiteGMapper.cs
│   │   │       ├── vs_tra_listar_movimiento_tramiteMapper.cs
│   │   │       ├── vs_TRA_ListarEtapaProcedimiento.cs
│   │   │       ├── vs_TRA_ListarEtapaProcedimientoMapper.cs
│   │   │       ├── vs_TRA_ListarInicioArea.cs
│   │   │       ├── vs_TRA_ListarInicioAreaMapper.cs
│   │   │       ├── vs_TRA_ListarMovimiento.cs
│   │   │       ├── vs_TRA_ListarMovimientoMapper.cs
│   │   │       ├── vs_tra_ListarMovimientoTiempo.cs
│   │   │       ├── vs_tra_ListarMovimientoTiempoMapper.cs
│   │   │       ├── vs_tra_ListarProcArea.cs
│   │   │       ├── vs_tra_ListarProcAreaMapper.cs
│   │   │       ├── vs_TRA_ListarProcedimiento.cs
│   │   │       ├── vs_TRA_ListarProcedimientoMant.cs
│   │   │       ├── vs_TRA_ListarProcedimientoMapper.cs
│   │   │       ├── vs_TRA_ListarTramite.cs
│   │   │       ├── vs_TRA_ListarTramiteMapper.cs
│   │   │       ├── vs_tra_proc_etapa_area_cargo.cs
│   │   │       ├── vs_tra_proc_etapa_area_cargoMapper.cs
│   │   │       ├── vs_tra_Puntualidad_Tramite.cs
│   │   │       ├── vs_tra_usuario_area_cargo.cs
│   │   │       ├── vs_tra_usuario_area_cargoMapper.cs
│   │   │       ├── vs_tra_Usuario_online.cs
│   │   │       ├── vs_tra_Usuario_onlineMapper.cs
│   │   │       └── vs_tra_Usuario_Tramite_PC_IP.cs
│   │   ├── Properties/
│   │   │   └── AssemblyInfo.cs
│   │   ├── app.ico
│   │   ├── GRLL.Common.fLogin.resx
│   │   ├── GRLL.Common.frmBase.resx
│   │   ├── GRLL.Common.frmBase1.resx
│   │   ├── GRLL.Common.frmBaseImg.resx
│   │   ├── GRLL.Common.frmBaseMant.resx
│   │   ├── GRLL.Common.FrmMaestro.resx
│   │   ├── GRLL.Common.frmMantBaseFTS.resx
│   │   ├── GRLL.Common.frmMantBaseFTSb.resx
│   │   ├── GRLL.Common.frmPrueba.resx
│   │   ├── GRLL.Common.LoginForm.resx
│   │   ├── GRLL.Common.Resources.resx
│   │   ├── GRLL.Common.TransparentLabel.resx
│   │   ├── GRLL.Common.ucBuscaDato.resx
│   │   ├── GRLL.Common.ucFindFile.resx
│   │   ├── GRLL.Common.ucFoto.resx
│   │   ├── GRLL.Common.ucLogin.resx
│   │   ├── GRLL.csproj
│   │   └── VB-AnonymousType_0.cs
│   ├── GRLL.Common.Rutinas/
│   │   ├── GRLL/
│   │   │   └── Common/
│   │   │       └── Conversiones/
│   │   │           └── Rutinas/
│   │   │               └── Conversa.cs
│   │   ├── Properties/
│   │   │   └── AssemblyInfo.cs
│   │   └── GRLL.Common.Rutinas.csproj
│   ├── lib/
│   │   ├── legacy/
│   │   │   └── README.md
│   │   └── resource-runtime/
│   │       ├── README.md
│   │       ├── System.Buffers.dll
│   │       ├── System.Memory.dll
│   │       ├── System.Numerics.Vectors.dll
│   │       ├── System.Resources.Extensions.dll
│   │       └── System.Runtime.CompilerServices.Unsafe.dll
│   ├── RecursosHumanos/
│   │   ├── Properties/
│   │   │   └── AssemblyInfo.cs
│   │   ├── RecursosHumanos/
│   │   │   ├── DataSet1TableAdapters/
│   │   │   │   ├── spRRHH_busca_DisciplinaTableAdapter.cs
│   │   │   │   ├── spRRHH_FaltasTableAdapter.cs
│   │   │   │   ├── spRRHH_Ficha_DatosPersonalesTableAdapter.cs
│   │   │   │   ├── spRRHH_Ficha_Det_Familiar_SaludTableAdapter.cs
│   │   │   │   ├── spRRHH_Ficha_Det_FamiliarTableAdapter.cs
│   │   │   │   ├── spRRHH_Ficha_Estudio_CapacitacionTableAdapter.cs
│   │   │   │   ├── spRRHH_Ficha_Estudio_RealizadoTableAdapter.cs
│   │   │   │   ├── spRRHH_Ficha_Estudio_TituloTableAdapter.cs
│   │   │   │   ├── spRRHH_Ficha_ExpLab_DatosTableAdapter.cs
│   │   │   │   ├── spRRHH_Ficha_ExpLabTableAdapter.cs
│   │   │   │   ├── spRRHH_Ficha_Ingreso_EgresoTableAdapter.cs
│   │   │   │   ├── spRRHH_Ficha_ViviendaTableAdapter.cs
│   │   │   │   ├── spRRHH_Rep_cargosTableAdapter.cs
│   │   │   │   ├── spRRHH_Rep_profesionTableAdapter.cs
│   │   │   │   ├── spRRHH_RepAsisdiarriaTableAdapter.cs
│   │   │   │   ├── spRRHH_Report_CuadroPerTableAdapter.cs
│   │   │   │   ├── spRRHH_Report_CumpleTableAdapter.cs
│   │   │   │   ├── spRRHH_Report_FechaIngresoTableAdapter.cs
│   │   │   │   ├── spRRHH_Report_OficinaTableAdapter.cs
│   │   │   │   ├── spRRHH_RepPermisosTableAdapter.cs
│   │   │   │   └── TableAdapterManager.cs
│   │   │   ├── DataSet_PorcentajeTableAdapters/
│   │   │   │   └── QueriesTableAdapter.cs
│   │   │   ├── My/
│   │   │   │   ├── Resources/
│   │   │   │   │   └── Resources.cs
│   │   │   │   ├── InternalXmlHelper.cs
│   │   │   │   ├── MyApplication.cs
│   │   │   │   ├── MyComputer.cs
│   │   │   │   ├── MyProject.cs
│   │   │   │   ├── MySettings.cs
│   │   │   │   └── MySettingsProperty.cs
│   │   │   ├── AcercaDe.cs
│   │   │   ├── CompositionRoot.cs
│   │   │   ├── DataSet1.cs
│   │   │   ├── DataSet_Porcentaje.cs
│   │   │   ├── FrmAsignarHorario.cs
│   │   │   ├── FrmAsignarHorario_Lector.cs
│   │   │   ├── FrmAsistenciaManual.cs
│   │   │   ├── FrmBuscarDerechohabiente.cs
│   │   │   ├── FrmBuscarPersona.cs
│   │   │   ├── FrmCapacitaciones.cs
│   │   │   ├── FrmConsultaAsistDiaria.cs
│   │   │   ├── FrmConsultaAsistencias.cs
│   │   │   ├── FrmConsultaFaltas.cs
│   │   │   ├── FrmConsultaHorarioEsp.cs
│   │   │   ├── FrmConsultaPermisos.cs
│   │   │   ├── FrmDisciplina.cs
│   │   │   ├── FrmDocumentos.cs
│   │   │   ├── FrmEstudiosRealizados.cs
│   │   │   ├── FrmExpLaboral.cs
│   │   │   ├── FrmFamiliar.cs
│   │   │   ├── FrmFeriado.cs
│   │   │   ├── FrmFichaSocial.cs
│   │   │   ├── FrmHorarioEsp.cs
│   │   │   ├── FrmHorarios.cs
│   │   │   ├── FrmHorasTrabajadas.cs
│   │   │   ├── FrmImportarAsistencia.cs
│   │   │   ├── FrmImportarAsistenciaBio.cs
│   │   │   ├── FrmImportarAsistenciaCONSEJO.cs
│   │   │   ├── FrmImportarAsistenciaFueraSEDE.cs
│   │   │   ├── FrmImportarAsistenciaPROIND.cs
│   │   │   ├── FrmListaArchivos.cs
│   │   │   ├── FrmListaOrganica.cs
│   │   │   ├── FrmLocalAsignado.cs
│   │   │   ├── FrmLogin.cs
│   │   │   ├── FrmMantCargos.cs
│   │   │   ├── FrmMantDocFile.cs
│   │   │   ├── FrmMantEmpleado_Basico.cs
│   │   │   ├── FrmMantEstCivil.cs
│   │   │   ├── FrmMantGrupoSanguineo.cs
│   │   │   ├── FrmMantHorarios.cs
│   │   │   ├── FrmMantMotivo.cs
│   │   │   ├── FrmMantNacionalidades.cs
│   │   │   ├── FrmMantRegimen.cs
│   │   │   ├── FrmMantTipoDocIdent.cs
│   │   │   ├── FrmMantTipoEstudio.cs
│   │   │   ├── FrmMantTipoInst.cs
│   │   │   ├── FrmMantTipoPerm.cs
│   │   │   ├── FrmMantTipoTrab.cs
│   │   │   ├── FrmMarcacionesAutorizadas.cs
│   │   │   ├── FrmMotivoPermiso.cs
│   │   │   ├── FrmNuevaFicha.cs
│   │   │   ├── FrmPeriodoLaboral.cs
│   │   │   ├── FrmPermiso.cs
│   │   │   ├── FrmRegistroAsegurado.cs
│   │   │   ├── FrmRelacionSalidaAutorizada.cs
│   │   │   ├── FrmRepAsistenciaDia.cs
│   │   │   ├── FrmRepFaltas.cs
│   │   │   ├── FrmReport_Cargos.cs
│   │   │   ├── FrmReport_Empleado_Ingre.cs
│   │   │   ├── FrmReport_Selc_Oficina.cs
│   │   │   ├── FrmReport_Selec_Fechas.cs
│   │   │   ├── FrmReport_Selec_Oficina.cs
│   │   │   ├── FrmReport_Selec_Pliego.cs
│   │   │   ├── FrmReport_SelecMes.cs
│   │   │   ├── FrmReportCuadro.cs
│   │   │   ├── FrmReportCumple.cs
│   │   │   ├── FrmReporteEstadistico.cs
│   │   │   ├── FrmReporteProfesion.cs
│   │   │   ├── FrmReportFicha.cs
│   │   │   ├── FrmRepPermisoDispl.cs
│   │   │   ├── FrmRepPermisos.cs
│   │   │   ├── FrmResoluciones.cs
│   │   │   ├── FrmRotaciones.cs
│   │   │   ├── FrmSalida.cs
│   │   │   ├── FrmSobreTiempo.cs
│   │   │   ├── FrmSuspenderAsistencia.cs
│   │   │   ├── FrmTitulos.cs
│   │   │   ├── IFormularioCatalogo.cs
│   │   │   ├── MainMDI.cs
│   │   │   ├── Module1.cs
│   │   │   ├── PostgreSqlDiagnostic.cs
│   │   │   ├── PostgreSqlLegacyContext.cs
│   │   │   ├── PostgreSqlLegacyMapper.cs
│   │   │   ├── PostgreSqlUbigeoControl.cs
│   │   │   ├── Rep_CuadroPersonal.cs
│   │   │   ├── Rep_Profesion.cs
│   │   │   ├── Report_Cargos.cs
│   │   │   ├── Report_Cumple.cs
│   │   │   ├── Report_Emple_Ingreso.cs
│   │   │   ├── Report_Ficha_Escalaf.cs
│   │   │   ├── Report_FichaSocial_L.cs
│   │   │   ├── Report_Oficinas.cs
│   │   │   ├── Report_Porcentaje.cs
│   │   │   ├── RRHH.cs
│   │   │   ├── TreeListOperationCollapseExpandToLevel.cs
│   │   │   ├── VistaCatalogoGrid.cs
│   │   │   ├── XtraReportFaltas.cs
│   │   │   ├── XtraReportFaltas_Area.cs
│   │   │   └── XtraRepPermiso.cs
│   │   ├── app.config
│   │   ├── app.ico
│   │   ├── packages.lock.json
│   │   ├── RecursosHumanos.AcercaDe.resx
│   │   ├── RecursosHumanos.csproj
│   │   ├── RecursosHumanos.exe.licenses
│   │   ├── RecursosHumanos.FrmBuscarPersona.resx
│   │   ├── RecursosHumanos.FrmCapacitaciones.resx
│   │   ├── RecursosHumanos.FrmDisciplina.resx
│   │   ├── RecursosHumanos.FrmDocumentos.resx
│   │   ├── RecursosHumanos.FrmEstudiosRealizados.resx
│   │   ├── RecursosHumanos.FrmExpLaboral.resx
│   │   ├── RecursosHumanos.FrmFamiliar.resx
│   │   ├── RecursosHumanos.FrmFichaSocial.resx
│   │   ├── RecursosHumanos.FrmListaArchivos.resx
│   │   ├── RecursosHumanos.FrmListaOrganica.resx
│   │   ├── RecursosHumanos.FrmMantCargos.resx
│   │   ├── RecursosHumanos.FrmMantDocFile.resx
│   │   ├── RecursosHumanos.FrmMantEmpleado_Basico.resx
│   │   ├── RecursosHumanos.FrmMantEstCivil.resx
│   │   ├── RecursosHumanos.FrmMantGrupoSanguineo.resx
│   │   ├── RecursosHumanos.FrmMantHorarios.resx
│   │   ├── RecursosHumanos.FrmMantNacionalidades.resx
│   │   ├── RecursosHumanos.FrmMantRegimen.resx
│   │   ├── RecursosHumanos.FrmMantTipoDocIdent.resx
│   │   ├── RecursosHumanos.FrmMantTipoEstudio.resx
│   │   ├── RecursosHumanos.FrmMantTipoInst.resx
│   │   ├── RecursosHumanos.FrmMantTipoPerm.resx
│   │   ├── RecursosHumanos.FrmMantTipoTrab.resx
│   │   ├── RecursosHumanos.FrmPeriodoLaboral.resx
│   │   ├── RecursosHumanos.FrmPermiso.resx
│   │   ├── RecursosHumanos.FrmRepFaltas.resx
│   │   ├── RecursosHumanos.FrmReport_Cargos.resx
│   │   ├── RecursosHumanos.FrmReport_Empleado_Ingre.resx
│   │   ├── RecursosHumanos.FrmReport_Selec_Fechas.resx
│   │   ├── RecursosHumanos.FrmReport_Selec_Oficina.resx
│   │   ├── RecursosHumanos.FrmReport_Selec_Pliego.resx
│   │   ├── RecursosHumanos.FrmReport_SelecMes.resx
│   │   ├── RecursosHumanos.FrmReportCuadro.resx
│   │   ├── RecursosHumanos.FrmReportCumple.resx
│   │   ├── RecursosHumanos.FrmReporteProfesion.resx
│   │   ├── RecursosHumanos.FrmReportFicha.resx
│   │   ├── RecursosHumanos.FrmRepPermisoDispl.resx
│   │   ├── RecursosHumanos.FrmResoluciones.resx
│   │   ├── RecursosHumanos.FrmRotaciones.resx
│   │   ├── RecursosHumanos.FrmTitulos.resx
│   │   ├── RecursosHumanos.MainMDI.resx
│   │   └── RecursosHumanos.Resources.resx
│   ├── referencia/
│   │   ├── AsistenciaImport/
│   │   │   ├── Launcher/
│   │   │   │   ├── AsistenciaImportLauncher.vbproj
│   │   │   │   ├── Program.vb
│   │   │   │   └── README.md
│   │   │   ├── AsistenciaAccess.vb
│   │   │   ├── AsistenciaAccess_Original_Legacy.vb
│   │   │   ├── AsistenciaImport.vbproj
│   │   │   ├── FrmImportarAsistencia.Designer.vb
│   │   │   ├── FrmImportarAsistencia.vb
│   │   │   ├── IAsistenciaService.vb
│   │   │   ├── ImportadorConsejo.vb
│   │   │   ├── ImportadorFueraSede.vb
│   │   │   ├── ImportadorProind.vb
│   │   │   ├── ImportadorSedeBase.vb
│   │   │   ├── ImportadorSedePrincipal.vb
│   │   │   ├── ISedeImportador.vb
│   │   │   ├── README_REFACTOR_OCP.md
│   │   │   ├── SedeImportadorFactory.vb
│   │   │   └── TipoSede.vb
│   │   └── README.md
│   ├── RRHH.Application/
│   │   ├── Asistencia/
│   │   │   ├── EliminarFeriado.cs
│   │   │   ├── EliminarHorario.cs
│   │   │   ├── FeriadoDto.cs
│   │   │   ├── GuardarHorario.cs
│   │   │   ├── HorarioDto.cs
│   │   │   ├── IFeriadoRepository.cs
│   │   │   ├── IHorarioRepository.cs
│   │   │   ├── ListarFeriados.cs
│   │   │   ├── ListarHorarios.cs
│   │   │   ├── ObtenerHorario.cs
│   │   │   ├── RegistrarFeriado.cs
│   │   │   └── RegistrarFeriadoDto.cs
│   │   ├── bin/
│   │   │   └── Debug/
│   │   │       └── net48/
│   │   │           ├── RRHH.Application.dll
│   │   │           ├── RRHH.Application.pdb
│   │   │           ├── RRHH.Domain.dll
│   │   │           ├── RRHH.Domain.pdb
│   │   │           ├── System.Buffers.dll
│   │   │           ├── System.Memory.dll
│   │   │           ├── System.Numerics.Vectors.dll
│   │   │           ├── System.Resources.Extensions.dll
│   │   │           └── System.Runtime.CompilerServices.Unsafe.dll
│   │   ├── Catalogos/
│   │   │   ├── EliminarItemCatalogo.cs
│   │   │   ├── GuardarItemCatalogo.cs
│   │   │   ├── ICatalogoRepository.cs
│   │   │   ├── ItemCatalogoDto.cs
│   │   │   └── ListarCatalogo.cs
│   │   ├── Comun/
│   │   │   ├── RegistroEnUsoException.cs
│   │   │   └── ResultadoOperacion.cs
│   │   ├── obj/
│   │   │   ├── Debug/
│   │   │   │   └── net48/
│   │   │   │       ├── .NETFramework,Version=v4.8.AssemblyAttributes.cs
│   │   │   │       ├── RRHH.Application.AssemblyInfo.cs
│   │   │   │       ├── RRHH.Application.AssemblyInfoInputs.cache
│   │   │   │       ├── RRHH.Application.assets.cache
│   │   │   │       ├── RRHH.Application.csproj.AssemblyReference.cache
│   │   │   │       ├── RRHH.Application.csproj.CopyComplete
│   │   │   │       ├── RRHH.Application.csproj.CoreCompileInputs.cache
│   │   │   │       ├── RRHH.Application.csproj.FileListAbsolute.txt
│   │   │   │       ├── RRHH.Application.dll
│   │   │   │       ├── RRHH.Application.GeneratedMSBuildEditorConfig.editorconfig
│   │   │   │       ├── RRHH.Application.pdb
│   │   │   │       └── RRHH.Application.sourcelink.json
│   │   │   ├── project.assets.json
│   │   │   ├── project.nuget.cache
│   │   │   ├── RRHH.Application.csproj.nuget.dgspec.json
│   │   │   ├── RRHH.Application.csproj.nuget.g.props
│   │   │   └── RRHH.Application.csproj.nuget.g.targets
│   │   ├── Permisos/
│   │   │   ├── EliminarMotivoPermiso.cs
│   │   │   ├── GuardarMotivoPermiso.cs
│   │   │   ├── IMotivoPermisoRepository.cs
│   │   │   ├── ListarMotivosPermiso.cs
│   │   │   ├── MotivoPermisoDto.cs
│   │   │   └── ObtenerMotivoPermiso.cs
│   │   ├── Seguridad/
│   │   │   ├── AccesoUsuario.cs
│   │   │   ├── IAccesoUsuarioRepository.cs
│   │   │   ├── ObtenerAccesoUsuario.cs
│   │   │   └── Pbkdf2PasswordHasher.cs
│   │   └── RRHH.Application.csproj
│   ├── RRHH.Domain/
│   │   ├── Asistencia/
│   │   │   ├── Feriado.cs
│   │   │   └── Horario.cs
│   │   ├── bin/
│   │   │   └── Debug/
│   │   │       └── net48/
│   │   │           ├── RRHH.Domain.dll
│   │   │           ├── RRHH.Domain.pdb
│   │   │           ├── System.Buffers.dll
│   │   │           ├── System.Memory.dll
│   │   │           ├── System.Numerics.Vectors.dll
│   │   │           ├── System.Resources.Extensions.dll
│   │   │           └── System.Runtime.CompilerServices.Unsafe.dll
│   │   ├── Catalogos/
│   │   │   ├── DefinicionCatalogo.cs
│   │   │   ├── DefinicionesCatalogo.cs
│   │   │   ├── ItemCatalogo.cs
│   │   │   └── TipoCatalogo.cs
│   │   ├── Comun/
│   │   │   └── ReglaNegocioException.cs
│   │   ├── obj/
│   │   │   ├── Debug/
│   │   │   │   └── net48/
│   │   │   │       ├── .NETFramework,Version=v4.8.AssemblyAttributes.cs
│   │   │   │       ├── RRHH.Domain.AssemblyInfo.cs
│   │   │   │       ├── RRHH.Domain.AssemblyInfoInputs.cache
│   │   │   │       ├── RRHH.Domain.assets.cache
│   │   │   │       ├── RRHH.Domain.csproj.AssemblyReference.cache
│   │   │   │       ├── RRHH.Domain.csproj.CopyComplete
│   │   │   │       ├── RRHH.Domain.csproj.CoreCompileInputs.cache
│   │   │   │       ├── RRHH.Domain.csproj.FileListAbsolute.txt
│   │   │   │       ├── RRHH.Domain.dll
│   │   │   │       ├── RRHH.Domain.GeneratedMSBuildEditorConfig.editorconfig
│   │   │   │       ├── RRHH.Domain.pdb
│   │   │   │       └── RRHH.Domain.sourcelink.json
│   │   │   ├── project.assets.json
│   │   │   ├── project.nuget.cache
│   │   │   ├── RRHH.Domain.csproj.nuget.dgspec.json
│   │   │   ├── RRHH.Domain.csproj.nuget.g.props
│   │   │   └── RRHH.Domain.csproj.nuget.g.targets
│   │   ├── Permisos/
│   │   │   ├── AccesoMotivosPermiso.cs
│   │   │   └── MotivoPermiso.cs
│   │   └── RRHH.Domain.csproj
│   ├── RRHH.PostgreSql/
│   │   ├── Asistencia/
│   │   │   ├── PostgreSqlFeriadoRepository.cs
│   │   │   └── PostgreSqlHorarioRepository.cs
│   │   ├── bin/
│   │   │   └── Debug/
│   │   │       └── net48/
│   │   │           ├── Microsoft.Bcl.AsyncInterfaces.dll
│   │   │           ├── Npgsql.dll
│   │   │           ├── RRHH.Application.dll
│   │   │           ├── RRHH.Application.pdb
│   │   │           ├── RRHH.Domain.dll
│   │   │           ├── RRHH.Domain.pdb
│   │   │           ├── RRHH.PostgreSql.dll
│   │   │           ├── RRHH.PostgreSql.pdb
│   │   │           ├── System.Buffers.dll
│   │   │           ├── System.Memory.dll
│   │   │           ├── System.Numerics.Vectors.dll
│   │   │           ├── System.Resources.Extensions.dll
│   │   │           ├── System.Runtime.CompilerServices.Unsafe.dll
│   │   │           ├── System.Text.Encodings.Web.dll
│   │   │           ├── System.Text.Json.dll
│   │   │           ├── System.Threading.Tasks.Extensions.dll
│   │   │           └── System.ValueTuple.dll
│   │   ├── Catalogos/
│   │   │   ├── MapeoCatalogo.cs
│   │   │   ├── MapeosCatalogo.cs
│   │   │   ├── PostgreSqlCatalogoRepository.cs
│   │   │   └── ReferenciaCatalogo.cs
│   │   ├── obj/
│   │   │   ├── Debug/
│   │   │   │   └── net48/
│   │   │   │       ├── .NETFramework,Version=v4.8.AssemblyAttributes.cs
│   │   │   │       ├── RRHH.PostgreSql.AssemblyInfo.cs
│   │   │   │       ├── RRHH.PostgreSql.AssemblyInfoInputs.cache
│   │   │   │       ├── RRHH.PostgreSql.assets.cache
│   │   │   │       ├── RRHH.PostgreSql.csproj.AssemblyReference.cache
│   │   │   │       ├── RRHH.PostgreSql.csproj.CopyComplete
│   │   │   │       ├── RRHH.PostgreSql.csproj.CoreCompileInputs.cache
│   │   │   │       ├── RRHH.PostgreSql.csproj.FileListAbsolute.txt
│   │   │   │       ├── RRHH.PostgreSql.dll
│   │   │   │       ├── RRHH.PostgreSql.GeneratedMSBuildEditorConfig.editorconfig
│   │   │   │       ├── RRHH.PostgreSql.pdb
│   │   │   │       └── RRHH.PostgreSql.sourcelink.json
│   │   │   ├── project.assets.json
│   │   │   ├── project.nuget.cache
│   │   │   ├── RRHH.PostgreSql.csproj.nuget.dgspec.json
│   │   │   ├── RRHH.PostgreSql.csproj.nuget.g.props
│   │   │   └── RRHH.PostgreSql.csproj.nuget.g.targets
│   │   ├── Permisos/
│   │   │   └── PostgreSqlMotivoPermisoRepository.cs
│   │   ├── Seguridad/
│   │   │   └── PostgreSqlAccesoUsuarioRepository.cs
│   │   ├── EnvironmentFile.cs
│   │   ├── IdentificadorSql.cs
│   │   ├── packages.lock.json
│   │   ├── PostgreSqlConnectionFactory.cs
│   │   ├── PostgreSqlExecutor.cs
│   │   ├── PostgreSqlParameterValue.cs
│   │   └── RRHH.PostgreSql.csproj
│   ├── RRHH.Presentation/
│   │   ├── Asistencia/
│   │   │   ├── FeriadoPresenter.cs
│   │   │   ├── HorarioEditorPresenter.cs
│   │   │   ├── HorariosPresenter.cs
│   │   │   ├── IFeriadoView.cs
│   │   │   ├── IHorarioEditorView.cs
│   │   │   └── IHorariosView.cs
│   │   ├── bin/
│   │   │   └── Debug/
│   │   │       └── net48/
│   │   │           ├── RRHH.Application.dll
│   │   │           ├── RRHH.Application.pdb
│   │   │           ├── RRHH.Domain.dll
│   │   │           ├── RRHH.Domain.pdb
│   │   │           ├── RRHH.Presentation.dll
│   │   │           ├── RRHH.Presentation.pdb
│   │   │           ├── System.Buffers.dll
│   │   │           ├── System.Memory.dll
│   │   │           ├── System.Numerics.Vectors.dll
│   │   │           ├── System.Resources.Extensions.dll
│   │   │           └── System.Runtime.CompilerServices.Unsafe.dll
│   │   ├── Catalogos/
│   │   │   ├── CatalogoFilaEventArgs.cs
│   │   │   ├── CatalogoPresenter.cs
│   │   │   └── ICatalogoView.cs
│   │   ├── obj/
│   │   │   ├── Debug/
│   │   │   │   └── net48/
│   │   │   │       ├── .NETFramework,Version=v4.8.AssemblyAttributes.cs
│   │   │   │       ├── RRHH.Presentation.AssemblyInfo.cs
│   │   │   │       ├── RRHH.Presentation.AssemblyInfoInputs.cache
│   │   │   │       ├── RRHH.Presentation.assets.cache
│   │   │   │       ├── RRHH.Presentation.csproj.AssemblyReference.cache
│   │   │   │       ├── RRHH.Presentation.csproj.CopyComplete
│   │   │   │       ├── RRHH.Presentation.csproj.CoreCompileInputs.cache
│   │   │   │       ├── RRHH.Presentation.csproj.FileListAbsolute.txt
│   │   │   │       ├── RRHH.Presentation.dll
│   │   │   │       ├── RRHH.Presentation.GeneratedMSBuildEditorConfig.editorconfig
│   │   │   │       ├── RRHH.Presentation.pdb
│   │   │   │       └── RRHH.Presentation.sourcelink.json
│   │   │   ├── project.assets.json
│   │   │   ├── project.nuget.cache
│   │   │   ├── RRHH.Presentation.csproj.nuget.dgspec.json
│   │   │   ├── RRHH.Presentation.csproj.nuget.g.props
│   │   │   └── RRHH.Presentation.csproj.nuget.g.targets
│   │   ├── Permisos/
│   │   │   ├── IMotivoPermisoEditorView.cs
│   │   │   ├── IMotivosPermisoView.cs
│   │   │   ├── MotivoPermisoEditorPresenter.cs
│   │   │   └── MotivosPermisoPresenter.cs
│   │   └── RRHH.Presentation.csproj
│   ├── RRHH.Tests/
│   │   ├── Arquitectura/
│   │   │   └── DependenciasEntreCapasTests.cs
│   │   ├── Asistencia/
│   │   │   ├── FeriadoPresenterTests.cs
│   │   │   ├── FeriadoTests.cs
│   │   │   ├── HorarioPostgreSqlTests.cs
│   │   │   ├── HorariosPresenterTests.cs
│   │   │   ├── HorarioTests.cs
│   │   │   └── RegistrarFeriadoTests.cs
│   │   ├── bin/
│   │   │   └── Debug/
│   │   │       └── net48/
│   │   │           ├── cs/
│   │   │           │   ├── Microsoft.TestPlatform.CoreUtilities.resources.dll
│   │   │           │   └── Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
│   │   │           ├── de/
│   │   │           │   ├── Microsoft.TestPlatform.CoreUtilities.resources.dll
│   │   │           │   └── Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
│   │   │           ├── es/
│   │   │           │   ├── Microsoft.TestPlatform.CoreUtilities.resources.dll
│   │   │           │   └── Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
│   │   │           ├── fr/
│   │   │           │   ├── Microsoft.TestPlatform.CoreUtilities.resources.dll
│   │   │           │   └── Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
│   │   │           ├── it/
│   │   │           │   ├── Microsoft.TestPlatform.CoreUtilities.resources.dll
│   │   │           │   └── Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
│   │   │           ├── ja/
│   │   │           │   ├── Microsoft.TestPlatform.CoreUtilities.resources.dll
│   │   │           │   └── Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
│   │   │           ├── ko/
│   │   │           │   ├── Microsoft.TestPlatform.CoreUtilities.resources.dll
│   │   │           │   └── Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
│   │   │           ├── pl/
│   │   │           │   ├── Microsoft.TestPlatform.CoreUtilities.resources.dll
│   │   │           │   └── Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
│   │   │           ├── pt-BR/
│   │   │           │   ├── Microsoft.TestPlatform.CoreUtilities.resources.dll
│   │   │           │   └── Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
│   │   │           ├── ru/
│   │   │           │   ├── Microsoft.TestPlatform.CoreUtilities.resources.dll
│   │   │           │   └── Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
│   │   │           ├── tr/
│   │   │           │   ├── Microsoft.TestPlatform.CoreUtilities.resources.dll
│   │   │           │   └── Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
│   │   │           ├── zh-Hans/
│   │   │           │   ├── Microsoft.TestPlatform.CoreUtilities.resources.dll
│   │   │           │   └── Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
│   │   │           ├── zh-Hant/
│   │   │           │   ├── Microsoft.TestPlatform.CoreUtilities.resources.dll
│   │   │           │   └── Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
│   │   │           ├── .msCoverageSourceRootsMapping_RRHH.Tests
│   │   │           ├── Microsoft.Bcl.AsyncInterfaces.dll
│   │   │           ├── Microsoft.TestPlatform.CoreUtilities.dll
│   │   │           ├── Microsoft.TestPlatform.PlatformAbstractions.dll
│   │   │           ├── Microsoft.VisualStudio.CodeCoverage.Shim.dll
│   │   │           ├── Microsoft.VisualStudio.TestPlatform.ObjectModel.dll
│   │   │           ├── Npgsql.dll
│   │   │           ├── RRHH.Application.dll
│   │   │           ├── RRHH.Application.pdb
│   │   │           ├── RRHH.Domain.dll
│   │   │           ├── RRHH.Domain.pdb
│   │   │           ├── RRHH.PostgreSql.dll
│   │   │           ├── RRHH.PostgreSql.pdb
│   │   │           ├── RRHH.Presentation.dll
│   │   │           ├── RRHH.Presentation.pdb
│   │   │           ├── RRHH.Tests.dll
│   │   │           ├── RRHH.Tests.dll.config
│   │   │           ├── RRHH.Tests.pdb
│   │   │           ├── System.Buffers.dll
│   │   │           ├── System.Collections.Immutable.dll
│   │   │           ├── System.Memory.dll
│   │   │           ├── System.Numerics.Vectors.dll
│   │   │           ├── System.Reflection.Metadata.dll
│   │   │           ├── System.Resources.Extensions.dll
│   │   │           ├── System.Runtime.CompilerServices.Unsafe.dll
│   │   │           ├── System.Text.Encodings.Web.dll
│   │   │           ├── System.Text.Json.dll
│   │   │           ├── System.Threading.Tasks.Extensions.dll
│   │   │           ├── System.ValueTuple.dll
│   │   │           ├── xunit.abstractions.dll
│   │   │           ├── xunit.assert.dll
│   │   │           ├── xunit.core.dll
│   │   │           ├── xunit.execution.desktop.dll
│   │   │           ├── xunit.runner.reporters.net452.dll
│   │   │           ├── xunit.runner.utility.net452.dll
│   │   │           └── xunit.runner.visualstudio.testadapter.dll
│   │   ├── Catalogos/
│   │   │   ├── CatalogoPresenterTests.cs
│   │   │   ├── DefinicionCatalogoTests.cs
│   │   │   └── MapeosCatalogoTests.cs
│   │   ├── Fakes/
│   │   │   ├── FakeCatalogoRepository.cs
│   │   │   ├── FakeCatalogoView.cs
│   │   │   ├── FakeFeriadoRepository.cs
│   │   │   ├── FakeFeriadoView.cs
│   │   │   ├── FakeHorarioRepository.cs
│   │   │   └── FakeMotivoPermisoRepository.cs
│   │   ├── obj/
│   │   │   ├── Debug/
│   │   │   │   └── net48/
│   │   │   │       ├── .NETFramework,Version=v4.8.AssemblyAttributes.cs
│   │   │   │       ├── RRHH.Tests.AssemblyInfo.cs
│   │   │   │       ├── RRHH.Tests.AssemblyInfoInputs.cache
│   │   │   │       ├── RRHH.Tests.assets.cache
│   │   │   │       ├── RRHH.Tests.csproj.AssemblyReference.cache
│   │   │   │       ├── RRHH.Tests.csproj.CopyComplete
│   │   │   │       ├── RRHH.Tests.csproj.CoreCompileInputs.cache
│   │   │   │       ├── RRHH.Tests.csproj.FileListAbsolute.txt
│   │   │   │       ├── RRHH.Tests.csproj.SuggestedBindingRedirects.cache
│   │   │   │       ├── RRHH.Tests.dll
│   │   │   │       ├── RRHH.Tests.dll.config
│   │   │   │       ├── RRHH.Tests.GeneratedMSBuildEditorConfig.editorconfig
│   │   │   │       ├── RRHH.Tests.pdb
│   │   │   │       └── RRHH.Tests.sourcelink.json
│   │   │   ├── project.assets.json
│   │   │   ├── project.nuget.cache
│   │   │   ├── RRHH.Tests.csproj.nuget.dgspec.json
│   │   │   ├── RRHH.Tests.csproj.nuget.g.props
│   │   │   └── RRHH.Tests.csproj.nuget.g.targets
│   │   ├── Permisos/
│   │   │   ├── GestionMotivosPermisoTests.cs
│   │   │   ├── MotivoPermisoPostgreSqlTests.cs
│   │   │   ├── MotivoPermisoTests.cs
│   │   │   └── MotivosPresenterTests.cs
│   │   ├── Seguridad/
│   │   │   ├── ObtenerAccesoUsuarioTests.cs
│   │   │   └── Pbkdf2PasswordHasherTests.cs
│   │   └── RRHH.Tests.csproj
│   ├── scripts/
│   │   ├── build.cmd
│   │   ├── build.ps1
│   │   ├── check-postgresql.cmd
│   │   ├── check-postgresql.ps1
│   │   ├── set-user-password.cmd
│   │   ├── set-user-password.ps1
│   │   ├── setup-dependencies.cmd
│   │   └── setup-legacy-dependencies.ps1
│   ├── Seguridad/
│   │   ├── obj/
│   │   │   ├── project.assets.json
│   │   │   ├── project.nuget.cache
│   │   │   ├── Seguridad.csproj.nuget.dgspec.json
│   │   │   ├── Seguridad.csproj.nuget.g.props
│   │   │   └── Seguridad.csproj.nuget.g.targets
│   │   ├── Properties/
│   │   │   └── AssemblyInfo.cs
│   │   ├── Seguridad/
│   │   │   ├── My/
│   │   │   │   ├── Resources/
│   │   │   │   │   └── Resources.cs
│   │   │   │   ├── InternalXmlHelper.cs
│   │   │   │   ├── MyApplication.cs
│   │   │   │   ├── MyComputer.cs
│   │   │   │   ├── MyProject.cs
│   │   │   │   ├── MySettings.cs
│   │   │   │   └── MySettingsProperty.cs
│   │   │   └── Seguridad.cs
│   │   ├── app.ico
│   │   └── Seguridad.csproj
│   ├── TabStrip/
│   │   ├── FarsiLibrary/
│   │   │   └── Win/
│   │   │       ├── BaseClasses/
│   │   │       │   └── BaseStyledPanel.cs
│   │   │       ├── Design/
│   │   │       │   ├── FATabStripDesigner.cs
│   │   │       │   ├── FATabStripItemDesigner.cs
│   │   │       │   └── ICaptionSupport.cs
│   │   │       ├── Helpers/
│   │   │       │   ├── CollectionChange.cs
│   │   │       │   ├── CollectionClear.cs
│   │   │       │   └── CollectionWithEvents.cs
│   │   │       ├── FATabStrip.cs
│   │   │       ├── FATabStripCloseButton.cs
│   │   │       ├── FATabStripItem.cs
│   │   │       ├── FATabStripItemChangeTypes.cs
│   │   │       ├── FATabStripItemCollection.cs
│   │   │       ├── FATabStripMenuGlyph.cs
│   │   │       ├── HitTestResult.cs
│   │   │       ├── TabStripItemChangedEventArgs.cs
│   │   │       ├── TabStripItemChangedHandler.cs
│   │   │       ├── TabStripItemClosingEventArgs.cs
│   │   │       ├── TabStripItemClosingHandler.cs
│   │   │       └── ThemeTypes.cs
│   │   ├── Properties/
│   │   │   └── AssemblyInfo.cs
│   │   ├── FarsiLibrary.Win.FATabStrip.bmp
│   │   └── TabStrip.csproj
│   ├── Directory.Build.props
│   ├── Directory.Build.targets
│   └── RRHH.sln
├── specs/
│   ├── CR-003-permisos-solapados.md
│   ├── PLANTILLA.md
│   ├── README.md
│   ├── TEC-001-horarios.md
│   ├── TEC-002-integridad-bd.md
│   ├── TEC-003-feriados.md
│   └── TEC-004-motivos-permiso.md
├── .env
├── .env.example
├── .gitattributes
├── .gitignore
├── AGENTS.md
├── CLAUDE.md
├── CONTRIBUTING.md
└── README.md
```

## Manifiesto de fuentes analizadas

Cada C# se analizó estructuralmente; SHA-256 permite reproducir el corte. Las líneas son del archivo local al leerlo. Los archivos de código no fueron modificados por este análisis.

| Archivo | Líneas | SHA-256 | Estado | Evidencia |
|---|---|---|---|---|
| Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs | 348 | af3083bb0a8d4f847497c00700e081ad99f6326e87ce39a8f8cf9d9d26b66b79 | Versionado | [Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:1](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L1) |
| Software/ClassRRHH/ClassRRHH/FamiliaresClass.cs | 44 | 74cf8ef9a65198dedd247ad32ac821889f084c7e60ccd9a6e212b5ca62e06b19 | Versionado | [Software/ClassRRHH/ClassRRHH/FamiliaresClass.cs:1](../../Software/ClassRRHH/ClassRRHH/FamiliaresClass.cs#L1) |
| Software/ClassRRHH/ClassRRHH/FichaSocialClass.cs | 45 | 9c88030c94ca55c8d8fe4af0120d044b6ff29b8b5bfd297b48e98c107c017d57 | Versionado | [Software/ClassRRHH/ClassRRHH/FichaSocialClass.cs:1](../../Software/ClassRRHH/ClassRRHH/FichaSocialClass.cs#L1) |
| Software/ClassRRHH/ClassRRHH/My/InternalXmlHelper.cs | 256 | aea540b815fb245bae489446dd45cc8f48878f14dc6f45ac3f6d29cb674ce708 | Versionado | [Software/ClassRRHH/ClassRRHH/My/InternalXmlHelper.cs:1](../../Software/ClassRRHH/ClassRRHH/My/InternalXmlHelper.cs#L1) |
| Software/ClassRRHH/ClassRRHH/My/MyApplication.cs | 16 | 3e069c0ac81dc8ac4714920593cccc8536b72484b237c56994d6590089fb2f75 | Versionado | [Software/ClassRRHH/ClassRRHH/My/MyApplication.cs:1](../../Software/ClassRRHH/ClassRRHH/My/MyApplication.cs#L1) |
| Software/ClassRRHH/ClassRRHH/My/MyComputer.cs | 17 | a8e9ed9421b7b5dd4411c379dd93bb60b3586a2dd2e3e7a88ffb8c38d4f6282c | Versionado | [Software/ClassRRHH/ClassRRHH/My/MyComputer.cs:1](../../Software/ClassRRHH/ClassRRHH/My/MyComputer.cs#L1) |
| Software/ClassRRHH/ClassRRHH/My/MyProject.cs | 151 | 8919175eb8ffa19f874c7f5db37218f5fdee70fb1847da6ca2787e52fc2d5a9d | Versionado | [Software/ClassRRHH/ClassRRHH/My/MyProject.cs:1](../../Software/ClassRRHH/ClassRRHH/My/MyProject.cs#L1) |
| Software/ClassRRHH/ClassRRHH/My/MySettings.cs | 113 | a0cf5ef4bf724763a7c20e184f0262b158ad8f42c812698b346cd0504937a37e | Versionado | [Software/ClassRRHH/ClassRRHH/My/MySettings.cs:1](../../Software/ClassRRHH/ClassRRHH/My/MySettings.cs#L1) |
| Software/ClassRRHH/ClassRRHH/My/MySettingsProperty.cs | 17 | b57aa2ea848c8f38a575fc6a65f088edbf539d5b5428ed13bce3fd1b29aaaffe | Versionado | [Software/ClassRRHH/ClassRRHH/My/MySettingsProperty.cs:1](../../Software/ClassRRHH/ClassRRHH/My/MySettingsProperty.cs#L1) |
| Software/ClassRRHH/ClassRRHH/My/Resources/Resources.cs | 55 | 818dd1db087fedcb86c3c71575adf4dfd23aedf6d757c690f1ed882ec1517bcc | Versionado | [Software/ClassRRHH/ClassRRHH/My/Resources/Resources.cs:1](../../Software/ClassRRHH/ClassRRHH/My/Resources/Resources.cs#L1) |
| Software/ClassRRHH/ClassRRHH/RRHHClass.cs | 1384 | 09a7304535f3db92b28e4291c83df81fa3dc1d171ad6bee04597d3bbf1730c49 | Versionado | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1) |
| Software/ClassRRHH/Properties/AssemblyInfo.cs | 15 | 569cd4307c8807050885037e546c255a2fd26351d512a4e68890e8c147faa4a1 | Versionado | [Software/ClassRRHH/Properties/AssemblyInfo.cs:1](../../Software/ClassRRHH/Properties/AssemblyInfo.cs#L1) |
| Software/ClsCtrls/ClsCtrls/Clases.cs | 2417 | 70f1a11e631077978bb4635b5fe53b3f8dbb9168e4d4828f9027cd24537820a8 | Versionado | [Software/ClsCtrls/ClsCtrls/Clases.cs:1](../../Software/ClsCtrls/ClsCtrls/Clases.cs#L1) |
| Software/ClsCtrls/ClsCtrls/ClsStrToken.cs | 216 | 5febe52eb55cfcae9f8e6174f32dcc429d6c915d35c3d3ff8727d55869c6f301 | Versionado | [Software/ClsCtrls/ClsCtrls/ClsStrToken.cs:1](../../Software/ClsCtrls/ClsCtrls/ClsStrToken.cs#L1) |
| Software/ClsCtrls/ClsCtrls/Combito.cs | 904 | 85ba5588d5b0d135a0ce00fdc18eaf255cb53d50ae5bf0da58333e79b4234220 | Versionado | [Software/ClsCtrls/ClsCtrls/Combito.cs:1](../../Software/ClsCtrls/ClsCtrls/Combito.cs#L1) |
| Software/ClsCtrls/ClsCtrls/ModVar.cs | 13 | 71ff0a0c202bdac224790429894782f75a300d288ccfe6031bd1eebd651dd1f4 | Versionado | [Software/ClsCtrls/ClsCtrls/ModVar.cs:1](../../Software/ClsCtrls/ClsCtrls/ModVar.cs#L1) |
| Software/ClsCtrls/ClsCtrls/My/InternalXmlHelper.cs | 214 | 771297f45f8dcf80ee5b6d56279c38b8208371cc052da1882c13cba939724e67 | Versionado | [Software/ClsCtrls/ClsCtrls/My/InternalXmlHelper.cs:1](../../Software/ClsCtrls/ClsCtrls/My/InternalXmlHelper.cs#L1) |
| Software/ClsCtrls/ClsCtrls/My/MyApplication.cs | 16 | 6d301a6b121b9aa6278f0dae4dc6501c993804ca65e5c9478fda45fb7b915e21 | Versionado | [Software/ClsCtrls/ClsCtrls/My/MyApplication.cs:1](../../Software/ClsCtrls/ClsCtrls/My/MyApplication.cs#L1) |
| Software/ClsCtrls/ClsCtrls/My/MyComputer.cs | 17 | b5e6f9b21b2d537e01eb247f2eab4d026983ad265ec9a7e6495c7a240329d4f4 | Versionado | [Software/ClsCtrls/ClsCtrls/My/MyComputer.cs:1](../../Software/ClsCtrls/ClsCtrls/My/MyComputer.cs#L1) |
| Software/ClsCtrls/ClsCtrls/My/MyProject.cs | 151 | 2f616425a76a0c9cfcb7355164affe4e2382869b923e33c286de68caca5817b6 | Versionado | [Software/ClsCtrls/ClsCtrls/My/MyProject.cs:1](../../Software/ClsCtrls/ClsCtrls/My/MyProject.cs#L1) |
| Software/ClsCtrls/ClsCtrls/My/MySettings.cs | 22 | 8a07d3c0e0d29e2d872ad128ec9a7983edf91f36eee5af21c619afce4cdc5333 | Versionado | [Software/ClsCtrls/ClsCtrls/My/MySettings.cs:1](../../Software/ClsCtrls/ClsCtrls/My/MySettings.cs#L1) |
| Software/ClsCtrls/ClsCtrls/My/MySettingsProperty.cs | 17 | db36e16b092e6ab3070caf2fb0907337601b6eb4b1854fa81bfb963dd9c309f0 | Versionado | [Software/ClsCtrls/ClsCtrls/My/MySettingsProperty.cs:1](../../Software/ClsCtrls/ClsCtrls/My/MySettingsProperty.cs#L1) |
| Software/ClsCtrls/ClsCtrls/My/Resources/Resources.cs | 49 | 736e6adcbf54dd5536c96b1d9ef3cfcda953ae9f3e105e7f0e9db3d7189d2c4f | Versionado | [Software/ClsCtrls/ClsCtrls/My/Resources/Resources.cs:1](../../Software/ClsCtrls/ClsCtrls/My/Resources/Resources.cs#L1) |
| Software/ClsCtrls/Properties/AssemblyInfo.cs | 15 | ba5439e1f23f72cf898a44dc0c0c373b7f418f0fe88d85e3f82971f971888976 | Versionado | [Software/ClsCtrls/Properties/AssemblyInfo.cs:1](../../Software/ClsCtrls/Properties/AssemblyInfo.cs#L1) |
| Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/Properties/Resources.cs | 95 | 386ae305a44eec87a2229c27a752f9b4b35bfced41a486a6129474c0a2671712 | Versionado | [Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/Properties/Resources.cs:1](../../Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/Properties/Resources.cs#L1) |
| Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/Properties/Settings.cs | 14 | e239834446db16faf1dd67a530bf3fdb54bfdacd5523dcc84e9caf37d0e9bea5 | Versionado | [Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/Properties/Settings.cs:1](../../Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/Properties/Settings.cs#L1) |
| Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs | 402 | f591a577d731be1f11c8b244a6cd8ce09ef477b0264b72a44024b11ab86b194b | Versionado | [Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs:1](../../Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs#L1) |
| Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBoxButtons.cs | 10 | 0848b070cd6068cbcdcf94759e49969e12060338ba825a812f886e4bf40098de | Versionado | [Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBoxButtons.cs:1](../../Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBoxButtons.cs#L1) |
| Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBoxIcon.cs | 10 | e93293f00d32382298031de1cb85e39db13d8f5c2c586da1a5f6e175cdac1dfe | Versionado | [Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBoxIcon.cs:1](../../Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBoxIcon.cs#L1) |
| Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XTextBox.cs | 14 | e13a6d0a2824d71ec27d058d6e40556fa28405418c1fbb43137a1efb014018bf | Versionado | [Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XTextBox.cs:1](../../Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XTextBox.cs#L1) |
| Software/CustomFeaturedMessageBox/Properties/AssemblyInfo.cs | 16 | 56df3d6d90c1fb2b913fc55feb425fea8762a762d4dcd98b12fbc25defab2a8a | Versionado | [Software/CustomFeaturedMessageBox/Properties/AssemblyInfo.cs:1](../../Software/CustomFeaturedMessageBox/Properties/AssemblyInfo.cs#L1) |
| Software/GRLL.Common.Rutinas/GRLL/Common/Conversiones/Rutinas/Conversa.cs | 492 | dc6c9808f09448e409d8ac62d7262d21302f843c3d0c5a54c9615fd92164fe63 | Versionado | [Software/GRLL.Common.Rutinas/GRLL/Common/Conversiones/Rutinas/Conversa.cs:1](../../Software/GRLL.Common.Rutinas/GRLL/Common/Conversiones/Rutinas/Conversa.cs#L1) |
| Software/GRLL.Common.Rutinas/Properties/AssemblyInfo.cs | 16 | e54102252eb93af3a2f4dfa0958fe88fc5f072c6a4894587031c8a26cd57ae71 | Versionado | [Software/GRLL.Common.Rutinas/Properties/AssemblyInfo.cs:1](../../Software/GRLL.Common.Rutinas/Properties/AssemblyInfo.cs#L1) |
| Software/GRLL/GRLL/Common/ABa_Meta_Area_ListarResult.cs | 96 | 1a6482e90aafe1e7dce81dd9b45e475a5652654f1988886ebef8cf7ea3a3c575 | Versionado | [Software/GRLL/GRLL/Common/ABa_Meta_Area_ListarResult.cs:1](../../Software/GRLL/GRLL/Common/ABa_Meta_Area_ListarResult.cs#L1) |
| Software/GRLL/GRLL/Common/AFP.cs | 166 | c01f6be28f9e3afdbeae209318e45bedc89966be6ae032c2f58c1fc30946a635 | Versionado | [Software/GRLL/GRLL/Common/AFP.cs:1](../../Software/GRLL/GRLL/Common/AFP.cs#L1) |
| Software/GRLL/GRLL/Common/AFPMapper.cs | 17 | 3e302dbaf551e2f58e307f881691a5d8eed91f11141b16327620d8501d769a2c | Versionado | [Software/GRLL/GRLL/Common/AFPMapper.cs:1](../../Software/GRLL/GRLL/Common/AFPMapper.cs#L1) |
| Software/GRLL/GRLL/Common/ANT_Anticipo.cs | 194 | 19b87b05ace4d7f56b47748c8b05718b467d512144f349b342b06dec279745aa | Versionado | [Software/GRLL/GRLL/Common/ANT_Anticipo.cs:1](../../Software/GRLL/GRLL/Common/ANT_Anticipo.cs#L1) |
| Software/GRLL/GRLL/Common/ANT_Movimiento.cs | 134 | d843757445c9dcc54fa2d547bad52ca01b5f142e98f4e8288b0bb3bb8d2d26b3 | Versionado | [Software/GRLL/GRLL/Common/ANT_Movimiento.cs:1](../../Software/GRLL/GRLL/Common/ANT_Movimiento.cs#L1) |
| Software/GRLL/GRLL/Common/ANT_SP_BuscarAnticipoResult.cs | 115 | a8f8f2792e85db27d17c5e9ed8000358a58ad712b016cf8fea3f62a58b99dced | Versionado | [Software/GRLL/GRLL/Common/ANT_SP_BuscarAnticipoResult.cs:1](../../Software/GRLL/GRLL/Common/ANT_SP_BuscarAnticipoResult.cs#L1) |
| Software/GRLL/GRLL/Common/ANT_SP_BuscarMovimientoResult.cs | 97 | 1e0a267b5db4c5639e123db4d027110b552b37f226a305f310b68a9041a4e21d | Versionado | [Software/GRLL/GRLL/Common/ANT_SP_BuscarMovimientoResult.cs:1](../../Software/GRLL/GRLL/Common/ANT_SP_BuscarMovimientoResult.cs#L1) |
| Software/GRLL/GRLL/Common/ANT_VS_Personal_GRLL.cs | 79 | bc33a999d36d064fbc30ce878e7a08cea0caaedd5fb8f80b270d0f469af4c547 | Versionado | [Software/GRLL/GRLL/Common/ANT_VS_Personal_GRLL.cs:1](../../Software/GRLL/GRLL/Common/ANT_VS_Personal_GRLL.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Actividad.cs | 270 | f1bae1d9147a295b0b474cbee05e85935ee4abdfcb2e0950838e7629d73d6a21 | Versionado | [Software/GRLL/GRLL/Common/Aba_Actividad.cs:1](../../Software/GRLL/GRLL/Common/Aba_Actividad.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Actividad_GetAllResult.cs | 114 | d7c25dbf6cf8be1f680d7d6525d11f1122d3e24f79d17e19f86b73bfaa304c61 | Versionado | [Software/GRLL/GRLL/Common/Aba_Actividad_GetAllResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Actividad_GetAllResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Actividad_GetBySubProgramaResult.cs | 114 | 5a00eadf01c55bf659f829dbb0bca4356771f0c33ff1251b82280d7e9297364d | Versionado | [Software/GRLL/GRLL/Common/Aba_Actividad_GetBySubProgramaResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Actividad_GetBySubProgramaResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Actividad_GetOneResult.cs | 114 | e4af099fef3f1ba6cde733560c877896def0918327f62e8f140e86240be51cf9 | Versionado | [Software/GRLL/GRLL/Common/Aba_Actividad_GetOneResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Actividad_GetOneResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Almacen_ListarResult.cs | 96 | 921f3a067217b7170ea2a15599b4c12e417ec6413fef84625dab3bbd184aa74b | Versionado | [Software/GRLL/GRLL/Common/Aba_Almacen_ListarResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Almacen_ListarResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Bien_ListarNoAlmacenResult.cs | 132 | 957cdb7ef23a6d0d1db8fbc07d5cb4c9f9a486df50903087b67a7df440f3677d | Versionado | [Software/GRLL/GRLL/Common/Aba_Bien_ListarNoAlmacenResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Bien_ListarNoAlmacenResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Bien_ListarPorAlmacenResult.cs | 186 | 1bb413138c269a16f7216380969decb0a0171710e1e57db0860547ce13cccedb | Versionado | [Software/GRLL/GRLL/Common/Aba_Bien_ListarPorAlmacenResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Bien_ListarPorAlmacenResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Bien_StockPorAlmacenResult.cs | 186 | 4f21d54b06a194eb0338639af0d15880d0ef4019079f963c61ac01548f7bd91d | Versionado | [Software/GRLL/GRLL/Common/Aba_Bien_StockPorAlmacenResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Bien_StockPorAlmacenResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Clase_GetAllResult.cs | 78 | 534252acc43711769ec5c88cbc26f778ad55b13bf12e553ef06cd0d45aa0c84a | Versionado | [Software/GRLL/GRLL/Common/Aba_Clase_GetAllResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Clase_GetAllResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Clase_GetByGrupoResult.cs | 78 | 4a0ec1484c0f373bc6b867a5353e731348dd39458b88d4cc423488372a4c9d17 | Versionado | [Software/GRLL/GRLL/Common/Aba_Clase_GetByGrupoResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Clase_GetByGrupoResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Clase_GetOneResult.cs | 78 | ef7d09e5f65759c39cc4e7ef677441cc7c36b42a3ef3eac0fcaf94a7be5d9590 | Versionado | [Software/GRLL/GRLL/Common/Aba_Clase_GetOneResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Clase_GetOneResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Componente_GetAllResult.cs | 132 | 873a31374b9a58139cc5af5e84e8c96af39b3d03935625eaa090f2f16c97edbe | Versionado | [Software/GRLL/GRLL/Common/Aba_Componente_GetAllResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Componente_GetAllResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Componente_GetByActividadResult.cs | 132 | 8363147965074a1de334e628ee8f4c19fe541efa71cf10d6f660fa9281f0e418 | Versionado | [Software/GRLL/GRLL/Common/Aba_Componente_GetByActividadResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Componente_GetByActividadResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Componente_GetOneResult.cs | 132 | 668d5ce361a04a370d3e0477d191ed6b84164eab6606c2c21abcc550e6810e88 | Versionado | [Software/GRLL/GRLL/Common/Aba_Componente_GetOneResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Componente_GetOneResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Consolidado_LIstarPorFechaResult.cs | 151 | 4d0586d338e0580c928e3168e73b398d960e2704018b30b9c7fb0167fa507a9c | Versionado | [Software/GRLL/GRLL/Common/Aba_Consolidado_LIstarPorFechaResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Consolidado_LIstarPorFechaResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Contrato_ListarPorConsolidadoResult.cs | 78 | 898fe93c0694468ca82e5a7e6d0899ab478483ac65b3b03ffc3ead9d06d5f43f | Versionado | [Software/GRLL/GRLL/Common/Aba_Contrato_ListarPorConsolidadoResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Contrato_ListarPorConsolidadoResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Contrato_ObtenerDetalladoResult.cs | 295 | a2fab7f5450c76b0158bb968a4f74696e02dc2643a5c801935e01db46672bf0a | Versionado | [Software/GRLL/GRLL/Common/Aba_Contrato_ObtenerDetalladoResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Contrato_ObtenerDetalladoResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Contrato_ObtenerListadoResult.cs | 151 | b4808cb953cba8c00ef44ce7c95ed9db39f76df156b0b6349919258693f514b6 | Versionado | [Software/GRLL/GRLL/Common/Aba_Contrato_ObtenerListadoResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Contrato_ObtenerListadoResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Deta_Consolidado_BuenaProResult.cs | 204 | 9bf430ff4da287c294040a9cce47c9561e52afb65ce9897a83909b18e83ad2e4 | Versionado | [Software/GRLL/GRLL/Common/Aba_Deta_Consolidado_BuenaProResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Deta_Consolidado_BuenaProResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Deta_Consolidado_ListarDetalleResult.cs | 222 | 84512d355932b5b2b1d21ec5ad0d8e1aa1d793bac4a2327d541e36ec0dd4f5ea | Versionado | [Software/GRLL/GRLL/Common/Aba_Deta_Consolidado_ListarDetalleResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Deta_Consolidado_ListarDetalleResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Deta_Consolidado_ListarResult.cs | 294 | 3b781c6895af2903af510ac718b0ad151d300ef34da2e500f3aaf49fc226614a | Versionado | [Software/GRLL/GRLL/Common/Aba_Deta_Consolidado_ListarResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Deta_Consolidado_ListarResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Deta_Consolidado_ObtenerPorProveedorResult.cs | 97 | 15130809d23055cd339ab9822b1885e80154d81d2c2f9fbb487b76cfa5849c50 | Versionado | [Software/GRLL/GRLL/Common/Aba_Deta_Consolidado_ObtenerPorProveedorResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Deta_Consolidado_ObtenerPorProveedorResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Deta_Consolidado_PorContratoResult.cs | 420 | ca51dc72487fb668c94ebd82ae8005f73a4aecefb95ac0f0a953d4e9aa2eef89 | Versionado | [Software/GRLL/GRLL/Common/Aba_Deta_Consolidado_PorContratoResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Deta_Consolidado_PorContratoResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Deta_Cotizacion_SelectPorProveedorResult.cs | 115 | 6730401faf30fb5be69e150301665dc6343bb71b8810807dfeeaca0e532bc363 | Versionado | [Software/GRLL/GRLL/Common/Aba_Deta_Cotizacion_SelectPorProveedorResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Deta_Cotizacion_SelectPorProveedorResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Deta_Distribucion_PorConsolidadoResult.cs | 204 | 4980452387fc52c9ea1d06802960dcfaa12197fa60a54cc64bb3769df62410d3 | Versionado | [Software/GRLL/GRLL/Common/Aba_Deta_Distribucion_PorConsolidadoResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Deta_Distribucion_PorConsolidadoResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Deta_Distribucion_PorOrdenCompraResult.cs | 204 | 33552f2e5b135b89208fb83ca9309e36fd7de13dd8830c4313fcb252663db99c | Versionado | [Software/GRLL/GRLL/Common/Aba_Deta_Distribucion_PorOrdenCompraResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Deta_Distribucion_PorOrdenCompraResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Deta_Orden_ListarDespachoResult.cs | 240 | 6132168c305f386b2db3f0b0afc6ddc8dcd6f0f2c42779103eb6ab14880e9bf9 | Versionado | [Software/GRLL/GRLL/Common/Aba_Deta_Orden_ListarDespachoResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Deta_Orden_ListarDespachoResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Deta_Orden_PorOrdenResult.cs | 168 | e76b5aceed05b62cfb70e8dedf0cb081cc2f10eb65e340b08b4403b7f46c4589 | Versionado | [Software/GRLL/GRLL/Common/Aba_Deta_Orden_PorOrdenResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Deta_Orden_PorOrdenResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Deta_Pedido_GetAllResult.cs | 204 | 4863425d6e22b575e95f6876a665ec21d5502104c4aa6ca3be3bf65e1c939951 | Versionado | [Software/GRLL/GRLL/Common/Aba_Deta_Pedido_GetAllResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Deta_Pedido_GetAllResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Deta_Pedido_GetOneResult.cs | 204 | dec1eec8f6399175c25eca797fb3770b3ab0ba38baac6529fe72223adc16ee69 | Versionado | [Software/GRLL/GRLL/Common/Aba_Deta_Pedido_GetOneResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Deta_Pedido_GetOneResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Deta_pedido_PorConsolidadoResult.cs | 96 | 038254f79d3768871f755b5a67ae6f09060b7f301a2993da167b96e61efe5ed4 | Versionado | [Software/GRLL/GRLL/Common/Aba_Deta_pedido_PorConsolidadoResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Deta_pedido_PorConsolidadoResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Familia_GetAllResult.cs | 96 | bffb290de79431dc3c0f988ae4339f790f7f8f8a63fd648ac96b1ca798637cdc | Versionado | [Software/GRLL/GRLL/Common/Aba_Familia_GetAllResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Familia_GetAllResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Familia_GetByClaseResult.cs | 96 | 08b089f1b903e97edd3902606be1ff7cc5c6d0aed7fd895dd7955b3be7454381 | Versionado | [Software/GRLL/GRLL/Common/Aba_Familia_GetByClaseResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Familia_GetByClaseResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Familia_GetOneResult.cs | 96 | f2c45c64afd6acf8149fcc79e52775984edf9b2d5b7bb75c36e8d90e69aa2ce7 | Versionado | [Software/GRLL/GRLL/Common/Aba_Familia_GetOneResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Familia_GetOneResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Funcion_GetAllResult.cs | 60 | dcb54c560b4a7338f11790550f9ac36aa418af55700d228de26eddbcb4109c3c | Versionado | [Software/GRLL/GRLL/Common/Aba_Funcion_GetAllResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Funcion_GetAllResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Funcion_GetOneResult.cs | 60 | 1f50da3787be7bc104bcae513f9dcceb9e648f0ef79bc0eb7143414cb71749fb | Versionado | [Software/GRLL/GRLL/Common/Aba_Funcion_GetOneResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Funcion_GetOneResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Grupo_GetAllResult.cs | 60 | f30fc159850e6b354683ddba006fa606d030e0ea03778d722f06757a5c4aa12b | Versionado | [Software/GRLL/GRLL/Common/Aba_Grupo_GetAllResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Grupo_GetAllResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Grupo_GetOneResult.cs | 60 | efe9b17a770c3fdad4b5e586987511b864949f5ec7cf8c9bdf702aa601b345b7 | Versionado | [Software/GRLL/GRLL/Common/Aba_Grupo_GetOneResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Grupo_GetOneResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Meta_ListarAnioResult.cs | 222 | 1c121df77ad633a1e7c38823ba04c2b175c2d08513d04341c17bb248bb7eebac | Versionado | [Software/GRLL/GRLL/Common/Aba_Meta_ListarAnioResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Meta_ListarAnioResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Meta_ListarSaldosResult.cs | 114 | d545b0b10a044aa8d1d3e3c3a774b46ec17b69b26de6f6553071a80c5157f5ef | Versionado | [Software/GRLL/GRLL/Common/Aba_Meta_ListarSaldosResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Meta_ListarSaldosResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Movimiento_ListarResult.cs | 187 | ca310b8f4417a52589a90f4fb8102f6e4e59f9c0a1e4a6e3c7d8df993c041a52 | Versionado | [Software/GRLL/GRLL/Common/Aba_Movimiento_ListarResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Movimiento_ListarResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Parametro_Periodo_ListarResult.cs | 78 | a1e7e24bde9033d8e63ea540b52310edb46dc18d3c5d83f1ffeebf2375927ace | Versionado | [Software/GRLL/GRLL/Common/Aba_Parametro_Periodo_ListarResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Parametro_Periodo_ListarResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Pedido_GetAllResult.cs | 277 | a70ad3be5a4dbc8d03be83b81831d738f44909fffd386aa4fa4c83df8a989f28 | Versionado | [Software/GRLL/GRLL/Common/Aba_Pedido_GetAllResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Pedido_GetAllResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Pedido_GetOneResult.cs | 277 | 1656d6b36b61c6eb62c73b4fd17191c61603789186f7a88a425c4217f43e690d | Versionado | [Software/GRLL/GRLL/Common/Aba_Pedido_GetOneResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Pedido_GetOneResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Pedido_ListarPendientesConsolidarResult.cs | 115 | 97087305981a602fea38513fc0e9c50aeb45413279246ecd8124b3b19e832c70 | Versionado | [Software/GRLL/GRLL/Common/Aba_Pedido_ListarPendientesConsolidarResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Pedido_ListarPendientesConsolidarResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Pedido_ListarPorEstadoResult.cs | 295 | 279b7ffa79ca9b125bfc843f3468822493bcb61ccfd70cd4858f56c817c4abb7 | Versionado | [Software/GRLL/GRLL/Common/Aba_Pedido_ListarPorEstadoResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Pedido_ListarPorEstadoResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Persona_ListarResult.cs | 133 | a2c326628ad36a6cdfda875d629e562cb771bbc9516ad121f62e63b783a34f4c | Versionado | [Software/GRLL/GRLL/Common/Aba_Persona_ListarResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Persona_ListarResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Programa_GetAllResult.cs | 78 | 8fd9610fa7922cc5f35ed44c590e3c5bca7762b22b33fc71cb01f7df178cc0d5 | Versionado | [Software/GRLL/GRLL/Common/Aba_Programa_GetAllResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Programa_GetAllResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Programa_GetByFuncionResult.cs | 78 | 80cc0807b040ead68967a5018f3451bd8839aab588d0fc8249e3c2c918616e4f | Versionado | [Software/GRLL/GRLL/Common/Aba_Programa_GetByFuncionResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Programa_GetByFuncionResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Programa_GetOneResult.cs | 78 | 1f6ef2c232d7154c854f77b8098235beda971307767bc2502a57ebd155715fb6 | Versionado | [Software/GRLL/GRLL/Common/Aba_Programa_GetOneResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Programa_GetOneResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_Proveedor_ListarResult.cs | 223 | 3ce36cb07e252bf00d6dc649806159fbbbd7dda7a255aab933211442dc4d5292 | Versionado | [Software/GRLL/GRLL/Common/Aba_Proveedor_ListarResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_Proveedor_ListarResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_SubPrograma_GetAllResult.cs | 96 | a145789d5e3f6930c11c49d6afa2b03b9c3cbe3ef4ec2e99eeb2c8be1f3d760b | Versionado | [Software/GRLL/GRLL/Common/Aba_SubPrograma_GetAllResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_SubPrograma_GetAllResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_SubPrograma_GetByProgramaResult.cs | 96 | 8655dce5cc40678833b9d75f2936ebed59177305e42ad8a8e7e2f18cce7c3b1f | Versionado | [Software/GRLL/GRLL/Common/Aba_SubPrograma_GetByProgramaResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_SubPrograma_GetByProgramaResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_SubPrograma_GetOneResult.cs | 96 | 2a9154de279f796840c2012dafedb6ba76b3b58a7ea1bb35dff7dc2980d4de31 | Versionado | [Software/GRLL/GRLL/Common/Aba_SubPrograma_GetOneResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_SubPrograma_GetOneResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_sp_Retrieve_Deta_PedidoResult.cs | 312 | 838b3938dd64cd83fa5f6132c555c51aca71e5dd38faa8cce351bdad45fe997d | Versionado | [Software/GRLL/GRLL/Common/Aba_sp_Retrieve_Deta_PedidoResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_sp_Retrieve_Deta_PedidoResult.cs#L1) |
| Software/GRLL/GRLL/Common/Aba_sp_Retrieve_PedidoResult.cs | 439 | 9409cbf69f3555e34fe64bc8ba23f2967f3733e90d9b6b7c5f5b3dc4cfddb70d | Versionado | [Software/GRLL/GRLL/Common/Aba_sp_Retrieve_PedidoResult.cs:1](../../Software/GRLL/GRLL/Common/Aba_sp_Retrieve_PedidoResult.cs#L1) |
| Software/GRLL/GRLL/Common/Actividad.cs | 575 | a90aa1f38753992127c73af24fb0487f26711e821ba26a8e0cb47423847ec7b7 | Versionado | [Software/GRLL/GRLL/Common/Actividad.cs:1](../../Software/GRLL/GRLL/Common/Actividad.cs#L1) |
| Software/GRLL/GRLL/Common/Actividad_GetAllResult.cs | 349 | b8f0d02e2e134e752e7265fe15ed6bd23bd016654530c1b7e137a81e20539430 | Versionado | [Software/GRLL/GRLL/Common/Actividad_GetAllResult.cs:1](../../Software/GRLL/GRLL/Common/Actividad_GetAllResult.cs#L1) |
| Software/GRLL/GRLL/Common/Actividad_GetOneResult.cs | 349 | 56ae3fa4d09a24dc66719dd6288f42f1eabe735343f28a3b3d986b542ced6dbb | Versionado | [Software/GRLL/GRLL/Common/Actividad_GetOneResult.cs:1](../../Software/GRLL/GRLL/Common/Actividad_GetOneResult.cs#L1) |
| Software/GRLL/GRLL/Common/AguaViv.cs | 106 | a0527502376ec8e9d8f0a2284b6f9b1b10c3b25e7786f07d62ccdd1b4ee94bef | Versionado | [Software/GRLL/GRLL/Common/AguaViv.cs:1](../../Software/GRLL/GRLL/Common/AguaViv.cs#L1) |
| Software/GRLL/GRLL/Common/AguaVivMapper.cs | 17 | 5fda027749c4829cc070228a734ea84eb7b2521de310cd80d7625acc89d66911 | Versionado | [Software/GRLL/GRLL/Common/AguaVivMapper.cs:1](../../Software/GRLL/GRLL/Common/AguaVivMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Alerta.cs | 425 | 038bb6764cc79cee273a1b8b4cdc33b588649a64c120dae295823018c3d63b9c | Versionado | [Software/GRLL/GRLL/Common/Alerta.cs:1](../../Software/GRLL/GRLL/Common/Alerta.cs#L1) |
| Software/GRLL/GRLL/Common/AlertaMapper.cs | 17 | 895690911dd000bfad090b0afd0ce823e5b075cc69196f450a0a7d7446e82b8c | Versionado | [Software/GRLL/GRLL/Common/AlertaMapper.cs:1](../../Software/GRLL/GRLL/Common/AlertaMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Alertita.cs | 47 | caf25171d41930e690422aa98f7338fa7af82d8b563a5c74bb7101e0ed6ea77b | Versionado | [Software/GRLL/GRLL/Common/Alertita.cs:1](../../Software/GRLL/GRLL/Common/Alertita.cs#L1) |
| Software/GRLL/GRLL/Common/Almacen.cs | 262 | be9bb580e704901d7d398815d438afae325c1338dda2946a2ac8b52448f0d243 | Versionado | [Software/GRLL/GRLL/Common/Almacen.cs:1](../../Software/GRLL/GRLL/Common/Almacen.cs#L1) |
| Software/GRLL/GRLL/Common/AlmacenMapper.cs | 17 | 6957acf69f93d2b943084a9e4a21bef47c3fd4187f21ba4a9f6e6cc8916bfd3b | Versionado | [Software/GRLL/GRLL/Common/AlmacenMapper.cs:1](../../Software/GRLL/GRLL/Common/AlmacenMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Almacen_Bien.cs | 178 | 7422d6bb9ba1734273fd369bf20445eedc8e5f4768c4718a6f5e278bf1952b38 | Versionado | [Software/GRLL/GRLL/Common/Almacen_Bien.cs:1](../../Software/GRLL/GRLL/Common/Almacen_Bien.cs#L1) |
| Software/GRLL/GRLL/Common/Almacen_BienMapper.cs | 17 | 2556691c67040e75629fd7001f43b40710cb79a38d096f725a93cf312cb9f125 | Versionado | [Software/GRLL/GRLL/Common/Almacen_BienMapper.cs:1](../../Software/GRLL/GRLL/Common/Almacen_BienMapper.cs#L1) |
| Software/GRLL/GRLL/Common/AlumbradoViv.cs | 106 | 2adb49cfa0655228fc7426e28cb8c66c741bf1c57a7afffb9d422182c399cca5 | Versionado | [Software/GRLL/GRLL/Common/AlumbradoViv.cs:1](../../Software/GRLL/GRLL/Common/AlumbradoViv.cs#L1) |
| Software/GRLL/GRLL/Common/AlumbradoVivMapper.cs | 17 | d33f904f15e3e021cc9cefb696797d9832a6ab2431ad0d5c2569b52a295a92f7 | Versionado | [Software/GRLL/GRLL/Common/AlumbradoVivMapper.cs:1](../../Software/GRLL/GRLL/Common/AlumbradoVivMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Aprobacion_Pedido.cs | 259 | ffbd34ec645b1631444cda2e6eaad124981f387503bbf6a352f28422a5f4265e | Versionado | [Software/GRLL/GRLL/Common/Aprobacion_Pedido.cs:1](../../Software/GRLL/GRLL/Common/Aprobacion_Pedido.cs#L1) |
| Software/GRLL/GRLL/Common/Aprobacion_PedidoMapper.cs | 17 | 3b702574052eeeee5b2ef19c97da9f1d8766c1cc42e515d3c05bc9ef2d11341e | Versionado | [Software/GRLL/GRLL/Common/Aprobacion_PedidoMapper.cs:1](../../Software/GRLL/GRLL/Common/Aprobacion_PedidoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Archivo.cs | 239 | e1115002aed2baeb16fcca009899d76776cb6b18aefdc2ff22f0b58276668e57 | Versionado | [Software/GRLL/GRLL/Common/Archivo.cs:1](../../Software/GRLL/GRLL/Common/Archivo.cs#L1) |
| Software/GRLL/GRLL/Common/ArchivoMapper.cs | 17 | f909a8b5aeb860fd2d78facb6f6c0d56b460931beb14c4a63f2987a42b19aa11 | Versionado | [Software/GRLL/GRLL/Common/ArchivoMapper.cs:1](../../Software/GRLL/GRLL/Common/ArchivoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Asistencia.cs | 319 | d0475a345222aa9725ca3dd75979c76426fd859161bdd4b8349ba9caf4580f02 | Versionado | [Software/GRLL/GRLL/Common/Asistencia.cs:1](../../Software/GRLL/GRLL/Common/Asistencia.cs#L1) |
| Software/GRLL/GRLL/Common/AsistenciaMapper.cs | 17 | c468993b2b105bcf51cc2a82f70bf10bba20551d61aa8e08e5e0257c3635e9c7 | Versionado | [Software/GRLL/GRLL/Common/AsistenciaMapper.cs:1](../../Software/GRLL/GRLL/Common/AsistenciaMapper.cs#L1) |
| Software/GRLL/GRLL/Common/AudActividad.cs | 534 | c6fa4cc0c9726091cd2894623052754af9ce3209bfd0f4a958fff833966aed86 | Versionado | [Software/GRLL/GRLL/Common/AudActividad.cs:1](../../Software/GRLL/GRLL/Common/AudActividad.cs#L1) |
| Software/GRLL/GRLL/Common/AudEmpleado.cs | 535 | c76e227ef30c22a2009fac0e6d881555d92c9cba4eea60a9e8775718fcb695e2 | Versionado | [Software/GRLL/GRLL/Common/AudEmpleado.cs:1](../../Software/GRLL/GRLL/Common/AudEmpleado.cs#L1) |
| Software/GRLL/GRLL/Common/AudEstrategia.cs | 274 | 2333e63f60f64b2b659645a88cb2fe4a54ad166bdbd108de5077d35cc6990b4e | Versionado | [Software/GRLL/GRLL/Common/AudEstrategia.cs:1](../../Software/GRLL/GRLL/Common/AudEstrategia.cs#L1) |
| Software/GRLL/GRLL/Common/AudEstructOrg.cs | 414 | f0b7013033678a3c53f20cdd78e0d5e9b1b81ae1d5a2ce1ce80fcee4fe58821b | Versionado | [Software/GRLL/GRLL/Common/AudEstructOrg.cs:1](../../Software/GRLL/GRLL/Common/AudEstructOrg.cs#L1) |
| Software/GRLL/GRLL/Common/AudObjetivo.cs | 394 | c5f82b41d88d8113566452d2a7dd1442965ca20c0cd229deae731fc3eff5e490 | Versionado | [Software/GRLL/GRLL/Common/AudObjetivo.cs:1](../../Software/GRLL/GRLL/Common/AudObjetivo.cs#L1) |
| Software/GRLL/GRLL/Common/AudTablas.cs | 194 | 20b01692f066f40ded6ba7cccf343a86aca1f2b07539711bbcb854c067234696 | Versionado | [Software/GRLL/GRLL/Common/AudTablas.cs:1](../../Software/GRLL/GRLL/Common/AudTablas.cs#L1) |
| Software/GRLL/GRLL/Common/AutoCompleteEventArgs.cs | 13 | 7bd2cd0d4e2f9e76dafcffc24389f01d61e75e2b2d951bc4588f83970ca07038 | Versionado | [Software/GRLL/GRLL/Common/AutoCompleteEventArgs.cs:1](../../Software/GRLL/GRLL/Common/AutoCompleteEventArgs.cs#L1) |
| Software/GRLL/GRLL/Common/Banco.cs | 166 | cbf98b7302ea9b88200b151d2ad968607546c6708c93ee79b888fab73e0d20f9 | Versionado | [Software/GRLL/GRLL/Common/Banco.cs:1](../../Software/GRLL/GRLL/Common/Banco.cs#L1) |
| Software/GRLL/GRLL/Common/BancoMapper.cs | 17 | a4459d474adff6c781bd6cc4bd7537734a11c2e0407f5b0f7e0a20ea920e85f3 | Versionado | [Software/GRLL/GRLL/Common/BancoMapper.cs:1](../../Software/GRLL/GRLL/Common/BancoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Bien.cs | 559 | 2d53f44c74efb7153d4dbc578be6839537f1e919a6e948edf833db341db2e8c9 | Versionado | [Software/GRLL/GRLL/Common/Bien.cs:1](../../Software/GRLL/GRLL/Common/Bien.cs#L1) |
| Software/GRLL/GRLL/Common/BienMapper.cs | 17 | 3c5007d984978ac3eedd05c82e2458c9ce99c67b69add0754f47c401a1eaf4dc | Versionado | [Software/GRLL/GRLL/Common/BienMapper.cs:1](../../Software/GRLL/GRLL/Common/BienMapper.cs#L1) |
| Software/GRLL/GRLL/Common/CAP_Visitante.cs | 94 | c61e651c95e7ea51f95094b9b9d69f4c7b60005f97c97684f15e5155359791b2 | Versionado | [Software/GRLL/GRLL/Common/CAP_Visitante.cs:1](../../Software/GRLL/GRLL/Common/CAP_Visitante.cs#L1) |
| Software/GRLL/GRLL/Common/CJRDevolucionNorma.cs | 184 | aae6d6b7e7a958f66175176dd970f7f292cef84569b51b76bc7ad95164f37902 | Versionado | [Software/GRLL/GRLL/Common/CJRDevolucionNorma.cs:1](../../Software/GRLL/GRLL/Common/CJRDevolucionNorma.cs#L1) |
| Software/GRLL/GRLL/Common/CJRDevolucionNormaMapper.cs | 17 | a8dfd9e319074a79aade2faab1b03fe9086aa544c7eeba5d34197e41674f6d02 | Versionado | [Software/GRLL/GRLL/Common/CJRDevolucionNormaMapper.cs:1](../../Software/GRLL/GRLL/Common/CJRDevolucionNormaMapper.cs#L1) |
| Software/GRLL/GRLL/Common/CJRDictamenComision.cs | 245 | ade04051190bfb6286049b2f0c5baf9bf030ac28fbf6a6aceca03974be7e49fb | Versionado | [Software/GRLL/GRLL/Common/CJRDictamenComision.cs:1](../../Software/GRLL/GRLL/Common/CJRDictamenComision.cs#L1) |
| Software/GRLL/GRLL/Common/CJRDictamenComisionMapper.cs | 17 | 9523b99a427c314e2e99ca36d36e2d6d5c21ef58eefa9032c968a372815f7d45 | Versionado | [Software/GRLL/GRLL/Common/CJRDictamenComisionMapper.cs:1](../../Software/GRLL/GRLL/Common/CJRDictamenComisionMapper.cs#L1) |
| Software/GRLL/GRLL/Common/CJRIniciativa.cs | 302 | a16326cce605a1076b577aa1ff1f6a633ef66ee372cb32bc264e72f011115222 | Versionado | [Software/GRLL/GRLL/Common/CJRIniciativa.cs:1](../../Software/GRLL/GRLL/Common/CJRIniciativa.cs#L1) |
| Software/GRLL/GRLL/Common/CJRIniciativaMapper.cs | 17 | 45faef8da7805775e9139e94075c37900705b9ddc2c559ee80d05d6b08f8a40c | Versionado | [Software/GRLL/GRLL/Common/CJRIniciativaMapper.cs:1](../../Software/GRLL/GRLL/Common/CJRIniciativaMapper.cs#L1) |
| Software/GRLL/GRLL/Common/CJRNormaRegional.cs | 309 | edbf50b7a79e60c7dbcac37226ac5b0e48992040af6fb753078408592106744c | Versionado | [Software/GRLL/GRLL/Common/CJRNormaRegional.cs:1](../../Software/GRLL/GRLL/Common/CJRNormaRegional.cs#L1) |
| Software/GRLL/GRLL/Common/CJRNormaRegionalMapper.cs | 17 | b77399a4e29bd25769f9759fa067912111ce993c3beeb5128378c1e4b2c20863 | Versionado | [Software/GRLL/GRLL/Common/CJRNormaRegionalMapper.cs:1](../../Software/GRLL/GRLL/Common/CJRNormaRegionalMapper.cs#L1) |
| Software/GRLL/GRLL/Common/CJRNotificacionNorma.cs | 184 | 3e7c5a70c4624a6d09b623d8bb1ad70872b538796a2fbc0d1202f44dbc4b8d2d | Versionado | [Software/GRLL/GRLL/Common/CJRNotificacionNorma.cs:1](../../Software/GRLL/GRLL/Common/CJRNotificacionNorma.cs#L1) |
| Software/GRLL/GRLL/Common/CJRNotificacionNormaMapper.cs | 17 | 1347d81d1585c1309b2fcf675d069e93f77d15ad30c20f60e3ae65bfa2b3cfeb | Versionado | [Software/GRLL/GRLL/Common/CJRNotificacionNormaMapper.cs:1](../../Software/GRLL/GRLL/Common/CJRNotificacionNormaMapper.cs#L1) |
| Software/GRLL/GRLL/Common/CJROficio.cs | 358 | cb56baff31d61c6c5fe4301a54b7d95c63948eecbf8e58ab4aaa5cd56b9a0d7a | Versionado | [Software/GRLL/GRLL/Common/CJROficio.cs:1](../../Software/GRLL/GRLL/Common/CJROficio.cs#L1) |
| Software/GRLL/GRLL/Common/CJROficiosMapper.cs | 17 | 8e0c3b71ec5b00c95bb5cbe128a1ae28f280e2962f37da8b4d951f87207f9e32 | Versionado | [Software/GRLL/GRLL/Common/CJROficiosMapper.cs:1](../../Software/GRLL/GRLL/Common/CJROficiosMapper.cs#L1) |
| Software/GRLL/GRLL/Common/CJROperador.cs | 146 | f53bef69ad1b6b7af4a8650bb670667fabc335b9ab18b857f02a9022977da729 | Versionado | [Software/GRLL/GRLL/Common/CJROperador.cs:1](../../Software/GRLL/GRLL/Common/CJROperador.cs#L1) |
| Software/GRLL/GRLL/Common/CJROperadorMapper.cs | 17 | 3a8121bbacc94d69898c1cf981cf74cd8deada06ddd054674a9c53397fbf07cf | Versionado | [Software/GRLL/GRLL/Common/CJROperadorMapper.cs:1](../../Software/GRLL/GRLL/Common/CJROperadorMapper.cs#L1) |
| Software/GRLL/GRLL/Common/CJRPromulgacionNorma.cs | 184 | fd197c19dad1dbf8a051d45bc009e1f0c35ca8e0c30dbfa45e647e8b4879085d | Versionado | [Software/GRLL/GRLL/Common/CJRPromulgacionNorma.cs:1](../../Software/GRLL/GRLL/Common/CJRPromulgacionNorma.cs#L1) |
| Software/GRLL/GRLL/Common/CJRPromulgacionNormaMapper.cs | 17 | ca315e5945b8550bcfcc6144bc13f31b90ea8e5522efa364972cadd4d35a628e | Versionado | [Software/GRLL/GRLL/Common/CJRPromulgacionNormaMapper.cs:1](../../Software/GRLL/GRLL/Common/CJRPromulgacionNormaMapper.cs#L1) |
| Software/GRLL/GRLL/Common/CJRProyectoNormativo.cs | 372 | e44e6d312d0338a4cf358f7e6477307daf4baa52db608f743bbeb87c03265b95 | Versionado | [Software/GRLL/GRLL/Common/CJRProyectoNormativo.cs:1](../../Software/GRLL/GRLL/Common/CJRProyectoNormativo.cs#L1) |
| Software/GRLL/GRLL/Common/CJRProyectoNormativoMapper.cs | 17 | 8d3ffbd261552710a284450eb73336357d7d8b19fe0d4010bd006a456c8e0ff0 | Versionado | [Software/GRLL/GRLL/Common/CJRProyectoNormativoMapper.cs:1](../../Software/GRLL/GRLL/Common/CJRProyectoNormativoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/CJRPublicacion.cs | 245 | 0daa55b300ce4140ddbab9cdf032e5700d29749b935b2c5b745858836d72cb61 | Versionado | [Software/GRLL/GRLL/Common/CJRPublicacion.cs:1](../../Software/GRLL/GRLL/Common/CJRPublicacion.cs#L1) |
| Software/GRLL/GRLL/Common/CJRPublicacionNorma.cs | 184 | 00e1cc42dd91682923b0419508f4314e6b202cab35741563838ed30eded01569 | Versionado | [Software/GRLL/GRLL/Common/CJRPublicacionNorma.cs:1](../../Software/GRLL/GRLL/Common/CJRPublicacionNorma.cs#L1) |
| Software/GRLL/GRLL/Common/CJRPublicacionNormaMapper.cs | 17 | 03749565f28ebc4a5143b714497259eba1fccdcba9c5e28c553484d370df371f | Versionado | [Software/GRLL/GRLL/Common/CJRPublicacionNormaMapper.cs:1](../../Software/GRLL/GRLL/Common/CJRPublicacionNormaMapper.cs#L1) |
| Software/GRLL/GRLL/Common/CJRPublicacionesMapper.cs | 17 | a36ccf22a89a84519908299062c24dedc2edcfed31668e44d64726ca6d546cd6 | Versionado | [Software/GRLL/GRLL/Common/CJRPublicacionesMapper.cs:1](../../Software/GRLL/GRLL/Common/CJRPublicacionesMapper.cs#L1) |
| Software/GRLL/GRLL/Common/CJRResSolicitudOpinion.cs | 178 | 7e17e36e2b4496c9d60b74acc3d1db2be2dbabf4a94907d5c58a7ab519f27507 | Versionado | [Software/GRLL/GRLL/Common/CJRResSolicitudOpinion.cs:1](../../Software/GRLL/GRLL/Common/CJRResSolicitudOpinion.cs#L1) |
| Software/GRLL/GRLL/Common/CJRResSolicitudOpinionMapper.cs | 17 | 5a02d7771133e963ae5e7d4383a237364cec07ca34f050a273018907c7d60c71 | Versionado | [Software/GRLL/GRLL/Common/CJRResSolicitudOpinionMapper.cs:1](../../Software/GRLL/GRLL/Common/CJRResSolicitudOpinionMapper.cs#L1) |
| Software/GRLL/GRLL/Common/CJRSesion.cs | 225 | 5fe07e4009a035d2f7abb0e05fd9e29875d5a94fae7747bdc3e0d810676e9d26 | Versionado | [Software/GRLL/GRLL/Common/CJRSesion.cs:1](../../Software/GRLL/GRLL/Common/CJRSesion.cs#L1) |
| Software/GRLL/GRLL/Common/CJRSesionMapper.cs | 17 | a96b281d86a304599c1ccf5659382c64f8b16703f9d068a0a9d998b3d7b4d674 | Versionado | [Software/GRLL/GRLL/Common/CJRSesionMapper.cs:1](../../Software/GRLL/GRLL/Common/CJRSesionMapper.cs#L1) |
| Software/GRLL/GRLL/Common/CJRSolicitudOpinion.cs | 326 | d3191fafc56bd8f733f3b5beea9c08f6a62b4312380ddb2adb4e529772278ff0 | Versionado | [Software/GRLL/GRLL/Common/CJRSolicitudOpinion.cs:1](../../Software/GRLL/GRLL/Common/CJRSolicitudOpinion.cs#L1) |
| Software/GRLL/GRLL/Common/CJRSolicitudOpinionMapper.cs | 17 | 0500836bf1856672d08de4771bc218519892d606ca014d94c81fa5b81da18b89 | Versionado | [Software/GRLL/GRLL/Common/CJRSolicitudOpinionMapper.cs:1](../../Software/GRLL/GRLL/Common/CJRSolicitudOpinionMapper.cs#L1) |
| Software/GRLL/GRLL/Common/CJRTemaIniciativa.cs | 294 | 7365ae41006737f52024d527dd490bdb541229dbe59e85e71c2da0eb2c921897 | Versionado | [Software/GRLL/GRLL/Common/CJRTemaIniciativa.cs:1](../../Software/GRLL/GRLL/Common/CJRTemaIniciativa.cs#L1) |
| Software/GRLL/GRLL/Common/CJRTemaIniciativaMapper.cs | 17 | b416da5d8d6ab6ef2b0d5a796af6eba8bf041880ce753848af61143c871148ea | Versionado | [Software/GRLL/GRLL/Common/CJRTemaIniciativaMapper.cs:1](../../Software/GRLL/GRLL/Common/CJRTemaIniciativaMapper.cs#L1) |
| Software/GRLL/GRLL/Common/CJRTipoAprobacion.cs | 106 | 538a0ce654f2134746fa955c5e0c372dffb3eb8f775d0ca02706e980aeb11b36 | Versionado | [Software/GRLL/GRLL/Common/CJRTipoAprobacion.cs:1](../../Software/GRLL/GRLL/Common/CJRTipoAprobacion.cs#L1) |
| Software/GRLL/GRLL/Common/CJRTipoAprobacionMapper.cs | 17 | cee34b38a16ade48ef536f15a0c8e0256784a858c473c54c41e973d02fcd07af | Versionado | [Software/GRLL/GRLL/Common/CJRTipoAprobacionMapper.cs:1](../../Software/GRLL/GRLL/Common/CJRTipoAprobacionMapper.cs#L1) |
| Software/GRLL/GRLL/Common/CJRTipoMedio.cs | 106 | c5076846a1b7e8154ccf6dcf8e06335984264aa9c67cb6ff5b0afee75fb6535b | Versionado | [Software/GRLL/GRLL/Common/CJRTipoMedio.cs:1](../../Software/GRLL/GRLL/Common/CJRTipoMedio.cs#L1) |
| Software/GRLL/GRLL/Common/CJRTipoMedioMapper.cs | 17 | 1925c4e0a1e7b36540f37f4301213228330510e6c334e68fec4a23e58c25710e | Versionado | [Software/GRLL/GRLL/Common/CJRTipoMedioMapper.cs:1](../../Software/GRLL/GRLL/Common/CJRTipoMedioMapper.cs#L1) |
| Software/GRLL/GRLL/Common/CJRTipoNorma.cs | 106 | a9b5ffd01473de2e4a601ed3e469490695a6a572152acfdc27e1497b5ddf778b | Versionado | [Software/GRLL/GRLL/Common/CJRTipoNorma.cs:1](../../Software/GRLL/GRLL/Common/CJRTipoNorma.cs#L1) |
| Software/GRLL/GRLL/Common/CJRTipoNormaMapper.cs | 17 | 049938987bf69a19c9a053108dbf5899e5225e5bd94197af6e28eb4c4123590a | Versionado | [Software/GRLL/GRLL/Common/CJRTipoNormaMapper.cs:1](../../Software/GRLL/GRLL/Common/CJRTipoNormaMapper.cs#L1) |
| Software/GRLL/GRLL/Common/CJRTipoProyecto.cs | 106 | 417dcf433c959ce68c434c164d10270553d33f2de4521fe5036bed732ab16b13 | Versionado | [Software/GRLL/GRLL/Common/CJRTipoProyecto.cs:1](../../Software/GRLL/GRLL/Common/CJRTipoProyecto.cs#L1) |
| Software/GRLL/GRLL/Common/CJRTipoProyectoMapper.cs | 17 | b42b43aa92153d06609d0ce4183d59d4afd4147fe252e37b0a977bd2caffce0c | Versionado | [Software/GRLL/GRLL/Common/CJRTipoProyectoMapper.cs:1](../../Software/GRLL/GRLL/Common/CJRTipoProyectoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/CJRTipoSesion.cs | 106 | 8030e8eabd1e9749584687cf2f1d79026b16c506d4ef5ff5a4aad32abd02c23c | Versionado | [Software/GRLL/GRLL/Common/CJRTipoSesion.cs:1](../../Software/GRLL/GRLL/Common/CJRTipoSesion.cs#L1) |
| Software/GRLL/GRLL/Common/CJRTipoSesionMapper.cs | 17 | 0ce9ff8966543882182d4ba3c1686494802c6d58a257ca6d65b6d1d05314fbb8 | Versionado | [Software/GRLL/GRLL/Common/CJRTipoSesionMapper.cs:1](../../Software/GRLL/GRLL/Common/CJRTipoSesionMapper.cs#L1) |
| Software/GRLL/GRLL/Common/CJRTipoSolicitud.cs | 73 | 331475770be2de8c122951eaab95a9d2c24178bc757f193febf38f2072796141 | Versionado | [Software/GRLL/GRLL/Common/CJRTipoSolicitud.cs:1](../../Software/GRLL/GRLL/Common/CJRTipoSolicitud.cs#L1) |
| Software/GRLL/GRLL/Common/CJRTrasladoComision.cs | 184 | de0f04e0f2711dcc18809ca4ef026dcc924e8b23e379ef6211f2b26b8f716eca | Versionado | [Software/GRLL/GRLL/Common/CJRTrasladoComision.cs:1](../../Software/GRLL/GRLL/Common/CJRTrasladoComision.cs#L1) |
| Software/GRLL/GRLL/Common/CJRTrasladoComisionMapper.cs | 17 | 7ec39f82ccc011f55ddf61bf291cdea391b405eadd05d413f76ecdc8d4a03a52 | Versionado | [Software/GRLL/GRLL/Common/CJRTrasladoComisionMapper.cs:1](../../Software/GRLL/GRLL/Common/CJRTrasladoComisionMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Capacitacion.cs | 219 | ee3bc83613f3864d845670c2002443f91c130798308de6aa4ddd9d438a977e12 | Versionado | [Software/GRLL/GRLL/Common/Capacitacion.cs:1](../../Software/GRLL/GRLL/Common/Capacitacion.cs#L1) |
| Software/GRLL/GRLL/Common/CapacitacionMapper.cs | 17 | 787d660ba3587d603cd9309c65a2ed885ee3dabc98bf006859039497f3bc3816 | Versionado | [Software/GRLL/GRLL/Common/CapacitacionMapper.cs:1](../../Software/GRLL/GRLL/Common/CapacitacionMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Cargo.cs | 126 | 271f56f7ef6ed262378fd8cf4d81b244ce91cc3cd2b0e4b61dc8b0fff31f11da | Versionado | [Software/GRLL/GRLL/Common/Cargo.cs:1](../../Software/GRLL/GRLL/Common/Cargo.cs#L1) |
| Software/GRLL/GRLL/Common/CargoMapper.cs | 17 | cb94775ef13790e79a189860fdfd737a619ca83f7bb8cd9b54d9a4e7ad11e8eb | Versionado | [Software/GRLL/GRLL/Common/CargoMapper.cs:1](../../Software/GRLL/GRLL/Common/CargoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/CategoriaGasto.cs | 106 | 1a6c478d729c4227b47503bb148822d78dda82ba07b291fa7246a77d8e8e0398 | Versionado | [Software/GRLL/GRLL/Common/CategoriaGasto.cs:1](../../Software/GRLL/GRLL/Common/CategoriaGasto.cs#L1) |
| Software/GRLL/GRLL/Common/CategoriaGastoMapper.cs | 17 | 2d246f75d42b40941772b0386287aaefd0871390b0961b30844434891dd622e5 | Versionado | [Software/GRLL/GRLL/Common/CategoriaGastoMapper.cs:1](../../Software/GRLL/GRLL/Common/CategoriaGastoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/ChequeCaj.cs | 226 | 5098427fb745ede87403172769f7ef4f48e422a9568f42626826972d30c8541e | Versionado | [Software/GRLL/GRLL/Common/ChequeCaj.cs:1](../../Software/GRLL/GRLL/Common/ChequeCaj.cs#L1) |
| Software/GRLL/GRLL/Common/ChequeCajMapper.cs | 17 | d8a60c4c1a03d9db809d0f4c68982db09108fc7c190ac10f06e98bc4981a0f51 | Versionado | [Software/GRLL/GRLL/Common/ChequeCajMapper.cs:1](../../Software/GRLL/GRLL/Common/ChequeCajMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Clase.cs | 186 | e111fd45c1030f1129fc40b2d59266eeb5fbd536df4419fce6ca247d4281c43f | Versionado | [Software/GRLL/GRLL/Common/Clase.cs:1](../../Software/GRLL/GRLL/Common/Clase.cs#L1) |
| Software/GRLL/GRLL/Common/ClaseCbo.cs | 40 | 3359470d892e174f7bf67d87ce5108e500a7e1ae629aa2451b0a66cf04f35b72 | Versionado | [Software/GRLL/GRLL/Common/ClaseCbo.cs:1](../../Software/GRLL/GRLL/Common/ClaseCbo.cs#L1) |
| Software/GRLL/GRLL/Common/ClaseMapper.cs | 17 | d591ceecb56eb2dfb84c4003ee3b8d5accfcf222dbfe25255c4fca69b9a9e0e5 | Versionado | [Software/GRLL/GRLL/Common/ClaseMapper.cs:1](../../Software/GRLL/GRLL/Common/ClaseMapper.cs#L1) |
| Software/GRLL/GRLL/Common/ClaseTipo.cs | 39 | 8cb68138f06d3f8a16b06312a5ecdc517ee58bdab42999452d62e72fec716f49 | Versionado | [Software/GRLL/GRLL/Common/ClaseTipo.cs:1](../../Software/GRLL/GRLL/Common/ClaseTipo.cs#L1) |
| Software/GRLL/GRLL/Common/ClasificadorIngreso.cs | 300 | 609d4a7f4094f677253519857b821ea5e69dcbedeca462d401df776b82b7182a | Versionado | [Software/GRLL/GRLL/Common/ClasificadorIngreso.cs:1](../../Software/GRLL/GRLL/Common/ClasificadorIngreso.cs#L1) |
| Software/GRLL/GRLL/Common/ClasificadorIngresoMapper.cs | 17 | 2ff3287c4c840877a2d210d44c433b3266b085d152ada3de4c80625c08ae62d7 | Versionado | [Software/GRLL/GRLL/Common/ClasificadorIngresoMapper.cs:1](../../Software/GRLL/GRLL/Common/ClasificadorIngresoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/ClsExcel.cs | 299 | 91a7f38a276addcc777b7f807cb2d6ef14db679122268f069bb6aa37f2fad93c | Versionado | [Software/GRLL/GRLL/Common/ClsExcel.cs:1](../../Software/GRLL/GRLL/Common/ClsExcel.cs#L1) |
| Software/GRLL/GRLL/Common/ClsFunciones.cs | 114 | 0142d7eb6a792d95fd543c97e46617fa2f3f9c9666c4967531c0d60d3e5d6f96 | Versionado | [Software/GRLL/GRLL/Common/ClsFunciones.cs:1](../../Software/GRLL/GRLL/Common/ClsFunciones.cs#L1) |
| Software/GRLL/GRLL/Common/ClsIList.cs | 216 | bad0526eb805154ceffebac5c28ec8096684e17ea2c90e40e9ff8d6efabbe563 | Versionado | [Software/GRLL/GRLL/Common/ClsIList.cs:1](../../Software/GRLL/GRLL/Common/ClsIList.cs#L1) |
| Software/GRLL/GRLL/Common/ClsNroLetras.cs | 320 | 0710ca03899ba67ddc430f557ad985405b23e9fabf41faf96c62aea6154e7afa | Versionado | [Software/GRLL/GRLL/Common/ClsNroLetras.cs:1](../../Software/GRLL/GRLL/Common/ClsNroLetras.cs#L1) |
| Software/GRLL/GRLL/Common/ClsTUbigeo.cs | 28 | 10ad74dc2633f15746d56f7a3b72c7f0958dbc48cd0e2adac70a3fbb5182ba6a | Versionado | [Software/GRLL/GRLL/Common/ClsTUbigeo.cs:1](../../Software/GRLL/GRLL/Common/ClsTUbigeo.cs#L1) |
| Software/GRLL/GRLL/Common/ClsTipoDatos.cs | 90 | 456129e4dee0c402bd2406e6bd52d2ab3632d2578d45401cc2dd03ce8ae72ce2 | Versionado | [Software/GRLL/GRLL/Common/ClsTipoDatos.cs:1](../../Software/GRLL/GRLL/Common/ClsTipoDatos.cs#L1) |
| Software/GRLL/GRLL/Common/Componente.cs | 296 | b6595e24d28bc969cb8656d8a8e345071bcbc3507f7244e17aa51bfdd16d9104 | Versionado | [Software/GRLL/GRLL/Common/Componente.cs:1](../../Software/GRLL/GRLL/Common/Componente.cs#L1) |
| Software/GRLL/GRLL/Common/Comportamiento.cs | 259 | 24816d1e1e947f7333cdd73c216ff930e0ade5dcb39f4ff375077c43369147ba | Versionado | [Software/GRLL/GRLL/Common/Comportamiento.cs:1](../../Software/GRLL/GRLL/Common/Comportamiento.cs#L1) |
| Software/GRLL/GRLL/Common/ComportamientoMapper.cs | 17 | f88a66826a7573b7de5cb82d2d3e1ca91d7a374d6332fd2cb7c8034705d51e6e | Versionado | [Software/GRLL/GRLL/Common/ComportamientoMapper.cs:1](../../Software/GRLL/GRLL/Common/ComportamientoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/ConservacionViv.cs | 106 | 30fe50f59483b76b663ca716bab10e14f06e3c752e548b6db7d3a6b213ece185 | Versionado | [Software/GRLL/GRLL/Common/ConservacionViv.cs:1](../../Software/GRLL/GRLL/Common/ConservacionViv.cs#L1) |
| Software/GRLL/GRLL/Common/ConservacionVivMapper.cs | 17 | 3f8a482b3fc4c304adac57678c4a93bb0053243b69807ee1aaba4d074523df40 | Versionado | [Software/GRLL/GRLL/Common/ConservacionVivMapper.cs:1](../../Software/GRLL/GRLL/Common/ConservacionVivMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Consolidado.cs | 411 | 550e2b7cec5fb074f40dfa6a9c5e8fea82e271b3c479b688062055d03a9bf6b5 | Versionado | [Software/GRLL/GRLL/Common/Consolidado.cs:1](../../Software/GRLL/GRLL/Common/Consolidado.cs#L1) |
| Software/GRLL/GRLL/Common/ConsolidadoMapper.cs | 17 | 38af091a97fb3cdb551749a71462dcd376d2b6affc2d18cb8af274491f6dcb96 | Versionado | [Software/GRLL/GRLL/Common/ConsolidadoMapper.cs:1](../../Software/GRLL/GRLL/Common/ConsolidadoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Contrato.cs | 263 | c1bf4ecf4192842541a53a511ee113889c5a08b984f365dabd3d84740d97a494 | Versionado | [Software/GRLL/GRLL/Common/Contrato.cs:1](../../Software/GRLL/GRLL/Common/Contrato.cs#L1) |
| Software/GRLL/GRLL/Common/Cotizacion.cs | 267 | 32bc73c42d311d297afaf7adf92319373932ac4ef2025f4f8c8ef5658cac55af | Versionado | [Software/GRLL/GRLL/Common/Cotizacion.cs:1](../../Software/GRLL/GRLL/Common/Cotizacion.cs#L1) |
| Software/GRLL/GRLL/Common/CotizacionMapper.cs | 17 | 29910912ae0720b523519da79063c281f0d25fb916956b04c87bf608bd5ee91c | Versionado | [Software/GRLL/GRLL/Common/CotizacionMapper.cs:1](../../Software/GRLL/GRLL/Common/CotizacionMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Despacho.cs | 227 | 3c82105dd1471ba145c0e5bd059e044e7edc0d9ecb0ad297702b183916821f74 | Versionado | [Software/GRLL/GRLL/Common/Despacho.cs:1](../../Software/GRLL/GRLL/Common/Despacho.cs#L1) |
| Software/GRLL/GRLL/Common/DetFacturaCaj.cs | 224 | dc3c5aa72892ee73150373983fe6574b937d8a5600099033ad9aaea594b892d0 | Versionado | [Software/GRLL/GRLL/Common/DetFacturaCaj.cs:1](../../Software/GRLL/GRLL/Common/DetFacturaCaj.cs#L1) |
| Software/GRLL/GRLL/Common/DetFacturaCajMapper.cs | 17 | d4b2c1c65d0d9d986399909c75f3cff492e398ea0937abb527038225b28ab105 | Versionado | [Software/GRLL/GRLL/Common/DetFacturaCajMapper.cs:1](../../Software/GRLL/GRLL/Common/DetFacturaCajMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Deta_Consolidado.cs | 378 | 93b2c76d2983cdb5b13108c04e79a0cc317e71c78cbdfcbc05e32d259df1b44b | Versionado | [Software/GRLL/GRLL/Common/Deta_Consolidado.cs:1](../../Software/GRLL/GRLL/Common/Deta_Consolidado.cs#L1) |
| Software/GRLL/GRLL/Common/Deta_ConsolidadoMapper.cs | 17 | b9bfba62d907ea8be3180f9ac18b7205a99a25478ad4e3e91fab7445babaf1c9 | Versionado | [Software/GRLL/GRLL/Common/Deta_ConsolidadoMapper.cs:1](../../Software/GRLL/GRLL/Common/Deta_ConsolidadoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Deta_Cotizacion.cs | 238 | 051611a8993783e93dd947fdfee3fff5628e39717e06b6bd1eca188189c8bcf4 | Versionado | [Software/GRLL/GRLL/Common/Deta_Cotizacion.cs:1](../../Software/GRLL/GRLL/Common/Deta_Cotizacion.cs#L1) |
| Software/GRLL/GRLL/Common/Deta_CotizacionMapper.cs | 17 | 5ac19c1595f941a1ae9a4f57a0ae28060eed56cd9d1b9dc705eeaf58d6ba2aa8 | Versionado | [Software/GRLL/GRLL/Common/Deta_CotizacionMapper.cs:1](../../Software/GRLL/GRLL/Common/Deta_CotizacionMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Deta_Despacho.cs | 164 | 981317f4f99a3eb96c6bc96db47709241b600da548b954fcf31c72a5f61ad39b | Versionado | [Software/GRLL/GRLL/Common/Deta_Despacho.cs:1](../../Software/GRLL/GRLL/Common/Deta_Despacho.cs#L1) |
| Software/GRLL/GRLL/Common/Deta_Distribucion.cs | 370 | ac8d1d9929921043b5b7f7dabc62ab6211b182df0269bc306b2fb72230cca744 | Versionado | [Software/GRLL/GRLL/Common/Deta_Distribucion.cs:1](../../Software/GRLL/GRLL/Common/Deta_Distribucion.cs#L1) |
| Software/GRLL/GRLL/Common/Deta_DistribucionMapper.cs | 17 | b859b63fb74c8793965e6a6b7190e7728e48ec45cc736d4424c7e9f60c1ad48f | Versionado | [Software/GRLL/GRLL/Common/Deta_DistribucionMapper.cs:1](../../Software/GRLL/GRLL/Common/Deta_DistribucionMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Deta_Movimiento.cs | 278 | ce7ad69bbda4afaa42e533b47a61dbfcdfc1976e7d6c6df09f054fa4865b30e0 | Versionado | [Software/GRLL/GRLL/Common/Deta_Movimiento.cs:1](../../Software/GRLL/GRLL/Common/Deta_Movimiento.cs#L1) |
| Software/GRLL/GRLL/Common/Deta_MovimientoMapper.cs | 17 | cf223212e615b78e1c1ca196aa6e8ad18aa1b43476198aa32f722b101b05cbd4 | Versionado | [Software/GRLL/GRLL/Common/Deta_MovimientoMapper.cs:1](../../Software/GRLL/GRLL/Common/Deta_MovimientoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Deta_Orden.cs | 472 | ab869d40dcba36d5ec1ba3b110f2ca496b8bab170be9402e1228db7b633b2af3 | Versionado | [Software/GRLL/GRLL/Common/Deta_Orden.cs:1](../../Software/GRLL/GRLL/Common/Deta_Orden.cs#L1) |
| Software/GRLL/GRLL/Common/Deta_OrdenMapper.cs | 17 | 1ce87b98c5d577b21abc32828697c7bdef3fc37cc49dcab010d70797ed140567 | Versionado | [Software/GRLL/GRLL/Common/Deta_OrdenMapper.cs:1](../../Software/GRLL/GRLL/Common/Deta_OrdenMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Deta_Pedido.cs | 418 | 891269d2df4278c10de692f2cbf8cac874c2544311717b248d22ccf848d3bb5a | Versionado | [Software/GRLL/GRLL/Common/Deta_Pedido.cs:1](../../Software/GRLL/GRLL/Common/Deta_Pedido.cs#L1) |
| Software/GRLL/GRLL/Common/Deta_PedidoMapper.cs | 17 | 29df9f721a131a83571027415a77097a1fbd571b9c3b971d099c54742853967e | Versionado | [Software/GRLL/GRLL/Common/Deta_PedidoMapper.cs:1](../../Software/GRLL/GRLL/Common/Deta_PedidoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Discapacidad.cs | 134 | 781c38a95fe76972788a7ce74614a8dfed949fe97cf2211028af06d4c5b4fa74 | Versionado | [Software/GRLL/GRLL/Common/Discapacidad.cs:1](../../Software/GRLL/GRLL/Common/Discapacidad.cs#L1) |
| Software/GRLL/GRLL/Common/Documento.cs | 106 | 082f74021eadeaa44a6bd930726fda2ce12f2fc224636f1dd83b619cbd4ab861 | Versionado | [Software/GRLL/GRLL/Common/Documento.cs:1](../../Software/GRLL/GRLL/Common/Documento.cs#L1) |
| Software/GRLL/GRLL/Common/DocumentoMapper.cs | 17 | f088b7e108941a9fffb60b0b1fe44becb498048c20416f6c5bbd8a4e5481d33f | Versionado | [Software/GRLL/GRLL/Common/DocumentoMapper.cs:1](../../Software/GRLL/GRLL/Common/DocumentoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Egreso.cs | 418 | ec039dfcb887d4c8a242922a8d714d414fada54fa101bf7f71d69ca74ab53218 | Versionado | [Software/GRLL/GRLL/Common/Egreso.cs:1](../../Software/GRLL/GRLL/Common/Egreso.cs#L1) |
| Software/GRLL/GRLL/Common/EgresoMapper.cs | 17 | 2dbe552c4e211f69216a3202882f9f742436fb1f0198c5fc954ac97085321ea1 | Versionado | [Software/GRLL/GRLL/Common/EgresoMapper.cs:1](../../Software/GRLL/GRLL/Common/EgresoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Empleado.cs | 2413 | 98d2be8c5b890c5dc055852319c7d88e71c05aed587b3e3d3a62085ec7d6c56f | Versionado | [Software/GRLL/GRLL/Common/Empleado.cs:1](../../Software/GRLL/GRLL/Common/Empleado.cs#L1) |
| Software/GRLL/GRLL/Common/EmpleadoMapper.cs | 17 | 3fa7fa82eedfd6ca7a6f7665112cfed58612317d8fc5584b14c50296f24c7803 | Versionado | [Software/GRLL/GRLL/Common/EmpleadoMapper.cs:1](../../Software/GRLL/GRLL/Common/EmpleadoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Empleado_Area.cs | 184 | f76eaac0e4004e19e4f5f94cafa9771f6263792d4008c080e370bc05c37edb7a | Versionado | [Software/GRLL/GRLL/Common/Empleado_Area.cs:1](../../Software/GRLL/GRLL/Common/Empleado_Area.cs#L1) |
| Software/GRLL/GRLL/Common/Empleado_Marcacion.cs | 477 | d4b466121dc4e614533bc02e3dde1c7b19d0124b8e73548e9090377161638c76 | Versionado | [Software/GRLL/GRLL/Common/Empleado_Marcacion.cs:1](../../Software/GRLL/GRLL/Common/Empleado_Marcacion.cs#L1) |
| Software/GRLL/GRLL/Common/Empleado_old.cs | 675 | 050bb10cdcc80cad7f7c55604a86ebd8e1154f472fa8aa694449ec31874037a5 | Versionado | [Software/GRLL/GRLL/Common/Empleado_old.cs:1](../../Software/GRLL/GRLL/Common/Empleado_old.cs#L1) |
| Software/GRLL/GRLL/Common/Especifica.cs | 270 | c031ec4d730dc1451ad79c9c0511c8794adab074209dee77fffdccd3cbeb7466 | Versionado | [Software/GRLL/GRLL/Common/Especifica.cs:1](../../Software/GRLL/GRLL/Common/Especifica.cs#L1) |
| Software/GRLL/GRLL/Common/EspecificaGasto.cs | 106 | d3ddf5d4e975d2bfeff2648f2c3e72aa1ab48045a6280884c8d7076a03f9a710 | Versionado | [Software/GRLL/GRLL/Common/EspecificaGasto.cs:1](../../Software/GRLL/GRLL/Common/EspecificaGasto.cs#L1) |
| Software/GRLL/GRLL/Common/EspecificaGastoMapper.cs | 17 | e19c2f6124f192785fe601c3de80054043942f33c9554c05b2715803e3c462d8 | Versionado | [Software/GRLL/GRLL/Common/EspecificaGastoMapper.cs:1](../../Software/GRLL/GRLL/Common/EspecificaGastoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Especifica_Det.cs | 268 | 1bac7240190065868c99e70b3b8ef6760b507ae79071759b2eac0ef40aa27af1 | Versionado | [Software/GRLL/GRLL/Common/Especifica_Det.cs:1](../../Software/GRLL/GRLL/Common/Especifica_Det.cs#L1) |
| Software/GRLL/GRLL/Common/EstadoCivil.cs | 182 | acb71d43ca5c008d9f9a8d7a9cf1c22fa4bb55dc98c6d064168fa8abedaf97ae | Versionado | [Software/GRLL/GRLL/Common/EstadoCivil.cs:1](../../Software/GRLL/GRLL/Common/EstadoCivil.cs#L1) |
| Software/GRLL/GRLL/Common/EstadoCivilMapper.cs | 17 | b481fb6f8c36800917b2da99f26b9727b4139d79d9617da99246d03bddf0f5eb | Versionado | [Software/GRLL/GRLL/Common/EstadoCivilMapper.cs:1](../../Software/GRLL/GRLL/Common/EstadoCivilMapper.cs#L1) |
| Software/GRLL/GRLL/Common/EstadoEstudio.cs | 106 | 71be5e7f1eeb7e638a0c588c955641840420a6dc7440221481c75ccc1423bccc | Versionado | [Software/GRLL/GRLL/Common/EstadoEstudio.cs:1](../../Software/GRLL/GRLL/Common/EstadoEstudio.cs#L1) |
| Software/GRLL/GRLL/Common/EstadoEstudioMapper.cs | 17 | ecf60e876dd3040ac05df1a250dac5a34ef03e3a0f31d75cd7a82d19b20bbaa0 | Versionado | [Software/GRLL/GRLL/Common/EstadoEstudioMapper.cs:1](../../Software/GRLL/GRLL/Common/EstadoEstudioMapper.cs#L1) |
| Software/GRLL/GRLL/Common/EstadoPedido.cs | 93 | 09affbbb7f72de246bbe110cc0ab6222da5aa7ea94fd8ee4f6024fdc671f2584 | Versionado | [Software/GRLL/GRLL/Common/EstadoPedido.cs:1](../../Software/GRLL/GRLL/Common/EstadoPedido.cs#L1) |
| Software/GRLL/GRLL/Common/EstadoPedidoMapper.cs | 17 | 4e816650a137b846f19089dd2b3ae33e4a8eaad2d6c01725dbe623627cc6f354 | Versionado | [Software/GRLL/GRLL/Common/EstadoPedidoMapper.cs:1](../../Software/GRLL/GRLL/Common/EstadoPedidoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/EstadoSunat.cs | 106 | 5aa41b697995c230639f21476081b50ae427c873107c0632180a70d3e6cba437 | Versionado | [Software/GRLL/GRLL/Common/EstadoSunat.cs:1](../../Software/GRLL/GRLL/Common/EstadoSunat.cs#L1) |
| Software/GRLL/GRLL/Common/Estrategia.cs | 253 | dfc5028cbba32587361fb42b5b605d272e17ac4211aaa0311ce647b2a92482e1 | Versionado | [Software/GRLL/GRLL/Common/Estrategia.cs:1](../../Software/GRLL/GRLL/Common/Estrategia.cs#L1) |
| Software/GRLL/GRLL/Common/EstructOrganiz.cs | 828 | 76e7460bf1d1cd928e15e9137df84fe6f649413e9de98d64133a103a343a8fb0 | Versionado | [Software/GRLL/GRLL/Common/EstructOrganiz.cs:1](../../Software/GRLL/GRLL/Common/EstructOrganiz.cs#L1) |
| Software/GRLL/GRLL/Common/EstructOrganizMapper.cs | 17 | a3ffc9c272e25c7cb2427349020639b6b325d324699eacca7889235f80a8508b | Versionado | [Software/GRLL/GRLL/Common/EstructOrganizMapper.cs:1](../../Software/GRLL/GRLL/Common/EstructOrganizMapper.cs#L1) |
| Software/GRLL/GRLL/Common/EstudiosRealizado.cs | 319 | c3298cd7c3b3c849a4b6c60a32deb93605391e90863bd10ac0c8052dc1832529 | Versionado | [Software/GRLL/GRLL/Common/EstudiosRealizado.cs:1](../../Software/GRLL/GRLL/Common/EstudiosRealizado.cs#L1) |
| Software/GRLL/GRLL/Common/EstudiosRealizadoMapper.cs | 17 | 9ad1429640cd2f79388f8dfac75e2691c0e187113bb0b3445ae1002af894fccb | Versionado | [Software/GRLL/GRLL/Common/EstudiosRealizadoMapper.cs:1](../../Software/GRLL/GRLL/Common/EstudiosRealizadoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/EvaluacionGestion.cs | 284 | 9d17af9206fdb0367a565b456efecf8a8b78d99f0f7f62cd99aeae14b435f13b | Versionado | [Software/GRLL/GRLL/Common/EvaluacionGestion.cs:1](../../Software/GRLL/GRLL/Common/EvaluacionGestion.cs#L1) |
| Software/GRLL/GRLL/Common/ExcretasViv.cs | 106 | 9b767a16d87e0c66b59a58ca4bc8a76d81c53cafedb54605e30f98e8ab0308bd | Versionado | [Software/GRLL/GRLL/Common/ExcretasViv.cs:1](../../Software/GRLL/GRLL/Common/ExcretasViv.cs#L1) |
| Software/GRLL/GRLL/Common/ExcretasVivMapper.cs | 17 | 7c8da430655a87f66eaca3631775a2b43654b4c7bb6b147ec1df1c0ac7aadb2f | Versionado | [Software/GRLL/GRLL/Common/ExcretasVivMapper.cs:1](../../Software/GRLL/GRLL/Common/ExcretasVivMapper.cs#L1) |
| Software/GRLL/GRLL/Common/ExpLaboral.cs | 279 | dd46a16b18edea617a6cabf81046f609b16d66627ab77427fa42235017237df5 | Versionado | [Software/GRLL/GRLL/Common/ExpLaboral.cs:1](../../Software/GRLL/GRLL/Common/ExpLaboral.cs#L1) |
| Software/GRLL/GRLL/Common/ExpLaboralMapper.cs | 17 | ce80fa12b3b6f705dd043529f3749cbe14f9e8c53668b9e8c13e54a1f991981d | Versionado | [Software/GRLL/GRLL/Common/ExpLaboralMapper.cs:1](../../Software/GRLL/GRLL/Common/ExpLaboralMapper.cs#L1) |
| Software/GRLL/GRLL/Common/FacturaCaj.cs | 278 | 6398c7ab625b275f50b85c623c8a63c66535ff8dc5a497bddf408ede45e27b62 | Versionado | [Software/GRLL/GRLL/Common/FacturaCaj.cs:1](../../Software/GRLL/GRLL/Common/FacturaCaj.cs#L1) |
| Software/GRLL/GRLL/Common/FacturaCajMapper.cs | 17 | bbfea215f6b0346802e4e6144385dfcd88ebec5f4f8f9505d0011ebee7470e5b | Versionado | [Software/GRLL/GRLL/Common/FacturaCajMapper.cs:1](../../Software/GRLL/GRLL/Common/FacturaCajMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Familia.cs | 212 | d36fb94289156134de729724efc64d136439f1b47f32e9ca0034ae13fb712565 | Versionado | [Software/GRLL/GRLL/Common/Familia.cs:1](../../Software/GRLL/GRLL/Common/Familia.cs#L1) |
| Software/GRLL/GRLL/Common/FamiliaMapper.cs | 17 | ba287a1a65392cf6931bf907e7f1c3569b4ae364eae2098922e33fd9278f7a1e | Versionado | [Software/GRLL/GRLL/Common/FamiliaMapper.cs:1](../../Software/GRLL/GRLL/Common/FamiliaMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Familiar.cs | 598 | 7c0b44c0a0268904622ad998127c992624aab7fcefb6c592ebe39968d77c9505 | Versionado | [Software/GRLL/GRLL/Common/Familiar.cs:1](../../Software/GRLL/GRLL/Common/Familiar.cs#L1) |
| Software/GRLL/GRLL/Common/FamiliarMapper.cs | 17 | bf7ee4a119512de9cf21ba2741e8b22656b8f8cf902ba970b2fc0704bbbe0aa7 | Versionado | [Software/GRLL/GRLL/Common/FamiliarMapper.cs:1](../../Software/GRLL/GRLL/Common/FamiliarMapper.cs#L1) |
| Software/GRLL/GRLL/Common/FinalidadMapper.cs | 17 | fbf2226e6bf13db550b337d88aad5639c53b2442340497a933494f366bb08918 | Versionado | [Software/GRLL/GRLL/Common/FinalidadMapper.cs:1](../../Software/GRLL/GRLL/Common/FinalidadMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Financiamiento.cs | 162 | bf4ed674f6627efac00faddc9a876e2cb43b51b0ec91d584e1f9b796fab1cfdd | Versionado | [Software/GRLL/GRLL/Common/Financiamiento.cs:1](../../Software/GRLL/GRLL/Common/Financiamiento.cs#L1) |
| Software/GRLL/GRLL/Common/FinanciamientoMapper.cs | 17 | ef80ed00c1e73e556fdbe11e0591cd80045bb07e8844eea67326f3f2299be94b | Versionado | [Software/GRLL/GRLL/Common/FinanciamientoMapper.cs:1](../../Software/GRLL/GRLL/Common/FinanciamientoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/FlatBoxEventArgs.cs | 17 | ee98c7250621d1e3e66ae6ac23bdc78953f9ff87c11e4d53d39c702bba616d65 | Versionado | [Software/GRLL/GRLL/Common/FlatBoxEventArgs.cs:1](../../Software/GRLL/GRLL/Common/FlatBoxEventArgs.cs#L1) |
| Software/GRLL/GRLL/Common/FormaPago.cs | 73 | 8736b36a8f48800983ea906213a796b05d6bdf55e90a9a1d168fd2f5e74ab9e0 | Versionado | [Software/GRLL/GRLL/Common/FormaPago.cs:1](../../Software/GRLL/GRLL/Common/FormaPago.cs#L1) |
| Software/GRLL/GRLL/Common/FrmConsulta.cs | 192 | 3f1023d06486ca9a67be37e143db219cc229ecd56151ca96480ceefc7b1d6a23 | Versionado | [Software/GRLL/GRLL/Common/FrmConsulta.cs:1](../../Software/GRLL/GRLL/Common/FrmConsulta.cs#L1) |
| Software/GRLL/GRLL/Common/FrmMaestro.cs | 1157 | 0a4086998e2e420ac2d3565a2ec0b25e6d4199fbbe1e0a1183ee339a63c59c8f | Versionado | [Software/GRLL/GRLL/Common/FrmMaestro.cs:1](../../Software/GRLL/GRLL/Common/FrmMaestro.cs#L1) |
| Software/GRLL/GRLL/Common/Funcion.cs | 126 | de83bb0cbccb21686202717afa10dd19de8052980321b1ddcb39201b7194c3fb | Versionado | [Software/GRLL/GRLL/Common/Funcion.cs:1](../../Software/GRLL/GRLL/Common/Funcion.cs#L1) |
| Software/GRLL/GRLL/Common/GRLL_Sistema_ListarResult.cs | 42 | 744f64d9e8c43d9748c70b7ca7b1e59503013034999c775aeec5a6ff0c25a84d | Versionado | [Software/GRLL/GRLL/Common/GRLL_Sistema_ListarResult.cs:1](../../Software/GRLL/GRLL/Common/GRLL_Sistema_ListarResult.cs#L1) |
| Software/GRLL/GRLL/Common/GRLL_Usuario_AccesoResult.cs | 96 | af809a58ffcaa7f1fbb1f98c7da605904d5938cec1a0c1b41bfc5df442772426 | Versionado | [Software/GRLL/GRLL/Common/GRLL_Usuario_AccesoResult.cs:1](../../Software/GRLL/GRLL/Common/GRLL_Usuario_AccesoResult.cs#L1) |
| Software/GRLL/GRLL/Common/GastoPublico.cs | 318 | 7ad612f3dfb087180c0c942e2967ca5126a0fe10228804c81e06b9697ac8ebec | Versionado | [Software/GRLL/GRLL/Common/GastoPublico.cs:1](../../Software/GRLL/GRLL/Common/GastoPublico.cs#L1) |
| Software/GRLL/GRLL/Common/GastoPublicoMapper.cs | 17 | 2a5544c6d8095099f3a93b234257471170f184402b76b6ad98c15b6171fc9dbb | Versionado | [Software/GRLL/GRLL/Common/GastoPublicoMapper.cs:1](../../Software/GRLL/GRLL/Common/GastoPublicoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/GenericMapper.cs | 442 | df4659838383551bcbdf7fa2a49030af44caafbf64f1cac79504b3b578546e15 | Versionado | [Software/GRLL/GRLL/Common/GenericMapper.cs:1](../../Software/GRLL/GRLL/Common/GenericMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Generica.cs | 192 | 55d9ff6734782c1b0aff3dbc071059e4820e6e84de21f25e679de11c804ab2eb | Versionado | [Software/GRLL/GRLL/Common/Generica.cs:1](../../Software/GRLL/GRLL/Common/Generica.cs#L1) |
| Software/GRLL/GRLL/Common/GenericaGasto.cs | 106 | ecd66c6f14ee5e76882c3694c04f34a795e6785ac0b7a4edf767b86f8e39de92 | Versionado | [Software/GRLL/GRLL/Common/GenericaGasto.cs:1](../../Software/GRLL/GRLL/Common/GenericaGasto.cs#L1) |
| Software/GRLL/GRLL/Common/GenericaGastoMapper.cs | 17 | be1099b445b7e146915cb7fd58dc7bd6c2432d8118f38876011963542d90c832 | Versionado | [Software/GRLL/GRLL/Common/GenericaGastoMapper.cs:1](../../Software/GRLL/GRLL/Common/GenericaGastoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Grupo.cs | 126 | 09b01d5ef0b3707af73c84e66fedb1f7e5bc03aa9f32f195afe288e9d914b8f9 | Versionado | [Software/GRLL/GRLL/Common/Grupo.cs:1](../../Software/GRLL/GRLL/Common/Grupo.cs#L1) |
| Software/GRLL/GRLL/Common/GrupoMapper.cs | 17 | 5145fa1aca4adb93f69ef03a6b894e8b3add0c27707905cb8dc61b2615ccf7af | Versionado | [Software/GRLL/GRLL/Common/GrupoMapper.cs:1](../../Software/GRLL/GRLL/Common/GrupoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Horario.cs | 234 | dc60d48c5aa2296e0fce8cd43701abb435ba1df48902bac84d3d79e7ae35d032 | Versionado | [Software/GRLL/GRLL/Common/Horario.cs:1](../../Software/GRLL/GRLL/Common/Horario.cs#L1) |
| Software/GRLL/GRLL/Common/HorarioMapper.cs | 17 | 368ef268a988006798a6d55c8e815c3b9a184270313fc5ca1201980749e75aab | Versionado | [Software/GRLL/GRLL/Common/HorarioMapper.cs:1](../../Software/GRLL/GRLL/Common/HorarioMapper.cs#L1) |
| Software/GRLL/GRLL/Common/HorarioTemporal.cs | 259 | 83e60682ea726c5c5ae487248c030aeaa120769fe0cc4cf73f482914a1707ad9 | Versionado | [Software/GRLL/GRLL/Common/HorarioTemporal.cs:1](../../Software/GRLL/GRLL/Common/HorarioTemporal.cs#L1) |
| Software/GRLL/GRLL/Common/HorarioTemporalMapper.cs | 17 | b41c8c77bd7518690898321d8fcda9c52871e66d1f3a2f298f5830431f10ff20 | Versionado | [Software/GRLL/GRLL/Common/HorarioTemporalMapper.cs:1](../../Software/GRLL/GRLL/Common/HorarioTemporalMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Inconveniente.cs | 224 | 7b175efb471c6f024d03f15e61bf4643287be2da3b4e007b12a986c4917f87c6 | Versionado | [Software/GRLL/GRLL/Common/Inconveniente.cs:1](../../Software/GRLL/GRLL/Common/Inconveniente.cs#L1) |
| Software/GRLL/GRLL/Common/Ingreso.cs | 318 | 8974763b43a08c245504b0c0eeb8e3f6c38eedd58e0e3f4d3c46e4885729d7e5 | Versionado | [Software/GRLL/GRLL/Common/Ingreso.cs:1](../../Software/GRLL/GRLL/Common/Ingreso.cs#L1) |
| Software/GRLL/GRLL/Common/IngresoCaj.cs | 803 | b7845ae7c9edc0898f0d656ab7e6b95d868213020dc4553bfcc89b38f6d3870f | Versionado | [Software/GRLL/GRLL/Common/IngresoCaj.cs:1](../../Software/GRLL/GRLL/Common/IngresoCaj.cs#L1) |
| Software/GRLL/GRLL/Common/IngresoCajMapper.cs | 17 | f6fe09ecbd570959a8e5bd2d5e34df8cbf9f53c21925b12944898e350a047c52 | Versionado | [Software/GRLL/GRLL/Common/IngresoCajMapper.cs:1](../../Software/GRLL/GRLL/Common/IngresoCajMapper.cs#L1) |
| Software/GRLL/GRLL/Common/IngresoMapper.cs | 17 | 5c1ac438d267e4ba3709d56e94e6edc0a78edf011494a703b2701d592dd849ff | Versionado | [Software/GRLL/GRLL/Common/IngresoMapper.cs:1](../../Software/GRLL/GRLL/Common/IngresoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Inserted.cs | 6 | dc3f92b8e596ad7978c6646b91f3a4a0a95f006fc818c54f75121ce9f49a1083 | Versionado | [Software/GRLL/GRLL/Common/Inserted.cs:1](../../Software/GRLL/GRLL/Common/Inserted.cs#L1) |
| Software/GRLL/GRLL/Common/Institucion.cs | 126 | bba0be5f98b25970a85d23ef4e16130f6ef98b9f621a4058a718fd62c240026a | Versionado | [Software/GRLL/GRLL/Common/Institucion.cs:1](../../Software/GRLL/GRLL/Common/Institucion.cs#L1) |
| Software/GRLL/GRLL/Common/InversPublica.cs | 192 | 31f076bd3fb786bba9d93df730269dbebec79492dcb86c7beff961e897a0818b | Versionado | [Software/GRLL/GRLL/Common/InversPublica.cs:1](../../Software/GRLL/GRLL/Common/InversPublica.cs#L1) |
| Software/GRLL/GRLL/Common/InversXFuentF.cs | 178 | 1f1034ce30d4cd2527db3ccc7e28ee1634209570c578197fe8b21cde36d93c05 | Versionado | [Software/GRLL/GRLL/Common/InversXFuentF.cs:1](../../Software/GRLL/GRLL/Common/InversXFuentF.cs#L1) |
| Software/GRLL/GRLL/Common/KM_LogMensaje.cs | 159 | 6d14a2f95a8f68a10444fdb93c20f795c10b53364ae3ca779ee65149791723f4 | Versionado | [Software/GRLL/GRLL/Common/KM_LogMensaje.cs:1](../../Software/GRLL/GRLL/Common/KM_LogMensaje.cs#L1) |
| Software/GRLL/GRLL/Common/KM_LogMensajeMapper.cs | 17 | 09a173c17fd1b2fd35abf29a3ed02654bc172f06613798b87c87722a5c6d2c6d | Versionado | [Software/GRLL/GRLL/Common/KM_LogMensajeMapper.cs:1](../../Software/GRLL/GRLL/Common/KM_LogMensajeMapper.cs#L1) |
| Software/GRLL/GRLL/Common/KM_LogReprod.cs | 179 | a5881139e6a78dc2b6a6b2832d7743ec78c66a97cbaeb7ebcf878368a478dea1 | Versionado | [Software/GRLL/GRLL/Common/KM_LogReprod.cs:1](../../Software/GRLL/GRLL/Common/KM_LogReprod.cs#L1) |
| Software/GRLL/GRLL/Common/KM_LogReprodMapper.cs | 17 | 3d5d858c05e7da575cdecc1f552fce38a2237360f13fb9bd31078ca3d22fa62e | Versionado | [Software/GRLL/GRLL/Common/KM_LogReprodMapper.cs:1](../../Software/GRLL/GRLL/Common/KM_LogReprodMapper.cs#L1) |
| Software/GRLL/GRLL/Common/KM_Mensaje.cs | 126 | 762be919e28c1536aaa6cb968270b8bd76eaa200dbe95b4fcabf56a8fe959f22 | Versionado | [Software/GRLL/GRLL/Common/KM_Mensaje.cs:1](../../Software/GRLL/GRLL/Common/KM_Mensaje.cs#L1) |
| Software/GRLL/GRLL/Common/KM_MensajeMapper.cs | 17 | 3ecce9405f3a229769fe490ba8f9891555c91876c37b9686c6ee2ae3c418972d | Versionado | [Software/GRLL/GRLL/Common/KM_MensajeMapper.cs:1](../../Software/GRLL/GRLL/Common/KM_MensajeMapper.cs#L1) |
| Software/GRLL/GRLL/Common/KM_Motivo.cs | 106 | e497e2c3a38072ea17817d22b97d0067bc7588f5e4baa55f917137651e00a2e4 | Versionado | [Software/GRLL/GRLL/Common/KM_Motivo.cs:1](../../Software/GRLL/GRLL/Common/KM_Motivo.cs#L1) |
| Software/GRLL/GRLL/Common/KM_MotivoMapper.cs | 17 | 3610901f85b8a0bde1dee2d4a531b1115e60a9264819e224bff58acf02518e70 | Versionado | [Software/GRLL/GRLL/Common/KM_MotivoMapper.cs:1](../../Software/GRLL/GRLL/Common/KM_MotivoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/KM_Orden.cs | 359 | a41b2fdbf783fe766d2cd3577b652e177b0fe43a0d548f22a4ed139f29ba03cf | Versionado | [Software/GRLL/GRLL/Common/KM_Orden.cs:1](../../Software/GRLL/GRLL/Common/KM_Orden.cs#L1) |
| Software/GRLL/GRLL/Common/KM_OrdenMapper.cs | 17 | 4577fc7c3fb5d417596aec614ce938b7325050890b806516cc1ca77cf5ccb42a | Versionado | [Software/GRLL/GRLL/Common/KM_OrdenMapper.cs:1](../../Software/GRLL/GRLL/Common/KM_OrdenMapper.cs#L1) |
| Software/GRLL/GRLL/Common/KM_Parametro.cs | 93 | 10938b1f0287a895e786758767b2d79d5a82995bd4125eb05cd03fb7f3c6489a | Versionado | [Software/GRLL/GRLL/Common/KM_Parametro.cs:1](../../Software/GRLL/GRLL/Common/KM_Parametro.cs#L1) |
| Software/GRLL/GRLL/Common/KM_ParametroMapper.cs | 17 | 4c2456e85655d8614b50e625b23606d4f452b4684768dee3db8e4a23352704b9 | Versionado | [Software/GRLL/GRLL/Common/KM_ParametroMapper.cs:1](../../Software/GRLL/GRLL/Common/KM_ParametroMapper.cs#L1) |
| Software/GRLL/GRLL/Common/KM_PlayListAviso.cs | 138 | 669e999297feb6e7ddcd25897d26a4927f3330a226a4a102b9361d38e279f497 | Versionado | [Software/GRLL/GRLL/Common/KM_PlayListAviso.cs:1](../../Software/GRLL/GRLL/Common/KM_PlayListAviso.cs#L1) |
| Software/GRLL/GRLL/Common/KM_PlayListAvisoMapper.cs | 17 | 03ce9ef19f62a5288bea3a494dea7f181b8bad940b2aafe2f32b49e29e6d3358 | Versionado | [Software/GRLL/GRLL/Common/KM_PlayListAvisoMapper.cs:1](../../Software/GRLL/GRLL/Common/KM_PlayListAvisoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/KM_PlayListPrincipal.cs | 138 | 38c4e0b50373fe87b563e2d62421fcf1464269994e3b7583fddb8135c03c2208 | Versionado | [Software/GRLL/GRLL/Common/KM_PlayListPrincipal.cs:1](../../Software/GRLL/GRLL/Common/KM_PlayListPrincipal.cs#L1) |
| Software/GRLL/GRLL/Common/KM_PlayListPrincipalMapper.cs | 17 | 54dff9df08d71383035b47bda63e8680e8ae6c9ab248d7e7f4ff619eb743bfe1 | Versionado | [Software/GRLL/GRLL/Common/KM_PlayListPrincipalMapper.cs:1](../../Software/GRLL/GRLL/Common/KM_PlayListPrincipalMapper.cs#L1) |
| Software/GRLL/GRLL/Common/KM_TipoOperacion.cs | 126 | 72165e2bdf64de1527d11bd836f2cb52bde450031774ecec0de1ddf6c8db73e9 | Versionado | [Software/GRLL/GRLL/Common/KM_TipoOperacion.cs:1](../../Software/GRLL/GRLL/Common/KM_TipoOperacion.cs#L1) |
| Software/GRLL/GRLL/Common/KM_TipoOperacionMapper.cs | 17 | ddfedb46bdaa24f7166d4784b3f8f1ffdf5cd323a0c6e03560d3e61eed4dd024 | Versionado | [Software/GRLL/GRLL/Common/KM_TipoOperacionMapper.cs:1](../../Software/GRLL/GRLL/Common/KM_TipoOperacionMapper.cs#L1) |
| Software/GRLL/GRLL/Common/KM_VideoList.cs | 222 | ec8b14dc90900d6ea183a837d623a992b659e0a49eed039db6d52da44dc0d6ee | Versionado | [Software/GRLL/GRLL/Common/KM_VideoList.cs:1](../../Software/GRLL/GRLL/Common/KM_VideoList.cs#L1) |
| Software/GRLL/GRLL/Common/KM_VideoListMapper.cs | 17 | cbcefdaf0c0f5138c0a46dedc1807eda39c61113bc724477e887c907ce9e31cf | Versionado | [Software/GRLL/GRLL/Common/KM_VideoListMapper.cs:1](../../Software/GRLL/GRLL/Common/KM_VideoListMapper.cs#L1) |
| Software/GRLL/GRLL/Common/LINQ_sp_listartablasResult.cs | 60 | 5e7976128aa763f8b70f3a8caba0c580a9b97e9192794fc8c13ab652546a730e | Versionado | [Software/GRLL/GRLL/Common/LINQ_sp_listartablasResult.cs:1](../../Software/GRLL/GRLL/Common/LINQ_sp_listartablasResult.cs#L1) |
| Software/GRLL/GRLL/Common/Limitacion.cs | 106 | 5991b6fd7d808d1b3f895f3df38b13070d45378cdb414805efa6394770c034d3 | Versionado | [Software/GRLL/GRLL/Common/Limitacion.cs:1](../../Software/GRLL/GRLL/Common/Limitacion.cs#L1) |
| Software/GRLL/GRLL/Common/Local.cs | 126 | 011134eee7f7102df5ac2ab65e2fa76a2cbd68eeb8513f3d5519fc176343d252 | Versionado | [Software/GRLL/GRLL/Common/Local.cs:1](../../Software/GRLL/GRLL/Common/Local.cs#L1) |
| Software/GRLL/GRLL/Common/LocalMapper.cs | 17 | a4bb6987b01669df196e3b93db014f433eec018a93496b89914f1d1a26340c49 | Versionado | [Software/GRLL/GRLL/Common/LocalMapper.cs:1](../../Software/GRLL/GRLL/Common/LocalMapper.cs#L1) |
| Software/GRLL/GRLL/Common/LoginForm.cs | 372 | f680fc3267d2c8c1d56829c7f678f9e117cf7403384e93125d4c19791b98bda6 | Versionado | [Software/GRLL/GRLL/Common/LoginForm.cs:1](../../Software/GRLL/GRLL/Common/LoginForm.cs#L1) |
| Software/GRLL/GRLL/Common/Logros.cs | 184 | 2b30a188caf2792109b1bcea9e3711882bdfcd57c560fd0a300efdd63a5e188d | Versionado | [Software/GRLL/GRLL/Common/Logros.cs:1](../../Software/GRLL/GRLL/Common/Logros.cs#L1) |
| Software/GRLL/GRLL/Common/Marcacion.cs | 139 | 70bd0c8a7d398cba102c1dd67caedc6f19f096bbbda2ffc60bada21db1217755 | Versionado | [Software/GRLL/GRLL/Common/Marcacion.cs:1](../../Software/GRLL/GRLL/Common/Marcacion.cs#L1) |
| Software/GRLL/GRLL/Common/MarcacionMapper.cs | 17 | 3bdad0720300c4bb631d75a04e18ca4a5a718458417a2f829caf4638692a486e | Versionado | [Software/GRLL/GRLL/Common/MarcacionMapper.cs:1](../../Software/GRLL/GRLL/Common/MarcacionMapper.cs#L1) |
| Software/GRLL/GRLL/Common/MaterialViv.cs | 106 | beb4a13acfcab3344f575c86c67cc1698c70ae6f9523ff81b53d6e5fcf1c53a2 | Versionado | [Software/GRLL/GRLL/Common/MaterialViv.cs:1](../../Software/GRLL/GRLL/Common/MaterialViv.cs#L1) |
| Software/GRLL/GRLL/Common/MaterialVivMapper.cs | 17 | e527c347fb3fe651ba875556ed135aa4f41dade29f6ea22c0981a1ecbd8f6538 | Versionado | [Software/GRLL/GRLL/Common/MaterialVivMapper.cs:1](../../Software/GRLL/GRLL/Common/MaterialVivMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Meta.cs | 514 | fceda00c12f3678163bb9c47c32a11d977c1b4a559e5add71dd126d0239571cc | Versionado | [Software/GRLL/GRLL/Common/Meta.cs:1](../../Software/GRLL/GRLL/Common/Meta.cs#L1) |
| Software/GRLL/GRLL/Common/MetaMapper.cs | 17 | cadb91a12dac7c0b2c10c28431f70d9ecc35e9cb0754eb9f574e46e54d52d56b | Versionado | [Software/GRLL/GRLL/Common/MetaMapper.cs:1](../../Software/GRLL/GRLL/Common/MetaMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Meta_Area.cs | 144 | f51d4f6836121729ca111808a7ff7f4a65c20aa4a5e65719c94d279c8a7e0ff9 | Versionado | [Software/GRLL/GRLL/Common/Meta_Area.cs:1](../../Software/GRLL/GRLL/Common/Meta_Area.cs#L1) |
| Software/GRLL/GRLL/Common/Meta_AreaMapper.cs | 17 | f68785aede4d0b261c9532a88bcef654695feac1c0811e476b0bdc36b21beebb | Versionado | [Software/GRLL/GRLL/Common/Meta_AreaMapper.cs:1](../../Software/GRLL/GRLL/Common/Meta_AreaMapper.cs#L1) |
| Software/GRLL/GRLL/Common/ModFunciones.cs | 32 | 55e7c78cdc2c56dfc0644decada3656993a728b59053db2a64ceaab5ff078e5c | Versionado | [Software/GRLL/GRLL/Common/ModFunciones.cs:1](../../Software/GRLL/GRLL/Common/ModFunciones.cs#L1) |
| Software/GRLL/GRLL/Common/ModalidadAplicacion.cs | 106 | ffa2b3022d1bd24fda54ffbcb37ca764ceb29691112904dcf2353e3fbfb5cfd9 | Versionado | [Software/GRLL/GRLL/Common/ModalidadAplicacion.cs:1](../../Software/GRLL/GRLL/Common/ModalidadAplicacion.cs#L1) |
| Software/GRLL/GRLL/Common/ModalidadAplicacionMapper.cs | 17 | e7a88b532bc70673bc29cdf8086ecd13e4ead4a7fe89c4cf639244ba3a6c6067 | Versionado | [Software/GRLL/GRLL/Common/ModalidadAplicacionMapper.cs:1](../../Software/GRLL/GRLL/Common/ModalidadAplicacionMapper.cs#L1) |
| Software/GRLL/GRLL/Common/MotivoBaja.cs | 106 | 648eb7af7ffa9bab4a3b9322a6dc98d70af77c5802d44add8d8eb2c60aa2b30b | Versionado | [Software/GRLL/GRLL/Common/MotivoBaja.cs:1](../../Software/GRLL/GRLL/Common/MotivoBaja.cs#L1) |
| Software/GRLL/GRLL/Common/MotivoBajaMapper.cs | 17 | 3f0fc495917e1681f188e655107b84880c0df91a25cefa20fa489a0e82448bb0 | Versionado | [Software/GRLL/GRLL/Common/MotivoBajaMapper.cs:1](../../Software/GRLL/GRLL/Common/MotivoBajaMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Motivo_Perm.cs | 246 | c3983e717051fd7cbfdac478f934f91f458f837917d4f042355d0dedeb698839 | Versionado | [Software/GRLL/GRLL/Common/Motivo_Perm.cs:1](../../Software/GRLL/GRLL/Common/Motivo_Perm.cs#L1) |
| Software/GRLL/GRLL/Common/Motivo_PermMapper.cs | 17 | c7ca447cca99f1d1f730eb6683d18c2b1d89da68778e0ac466e11d090232cfb0 | Versionado | [Software/GRLL/GRLL/Common/Motivo_PermMapper.cs:1](../../Software/GRLL/GRLL/Common/Motivo_PermMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Movimiento.cs | 467 | 125f0c6801618f0e384704188ee8d90e2626ab8d0dec4366ecfdb9e623323f7f | Versionado | [Software/GRLL/GRLL/Common/Movimiento.cs:1](../../Software/GRLL/GRLL/Common/Movimiento.cs#L1) |
| Software/GRLL/GRLL/Common/MovimientoMapper.cs | 17 | 8fd32a7e459c91b3d39ecc76c00e1c179861d8b6922d8a64370bbfcb6da20f31 | Versionado | [Software/GRLL/GRLL/Common/MovimientoMapper.cs:1](../../Software/GRLL/GRLL/Common/MovimientoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/My/MyApplication.cs | 16 | b27f44be7b230ef5797e86a6ad8edbf7da965f499999240443b733e2d3541141 | Versionado | [Software/GRLL/GRLL/Common/My/MyApplication.cs:1](../../Software/GRLL/GRLL/Common/My/MyApplication.cs#L1) |
| Software/GRLL/GRLL/Common/My/MyComputer.cs | 17 | 984e3c490672d7e823af394ba94a02a568df5d2cc30c28d7f4c5acfa05d0a395 | Versionado | [Software/GRLL/GRLL/Common/My/MyComputer.cs:1](../../Software/GRLL/GRLL/Common/My/MyComputer.cs#L1) |
| Software/GRLL/GRLL/Common/My/MyProject.cs | 151 | 2bf135ca6e00b4293650a3bafe88ff43db61716f2c871c7f9cada7853e0f642b | Versionado | [Software/GRLL/GRLL/Common/My/MyProject.cs:1](../../Software/GRLL/GRLL/Common/My/MyProject.cs#L1) |
| Software/GRLL/GRLL/Common/My/MySettings.cs | 29 | b23b1125eebc0de25c2a11fb47897595a7236c9e03c083d2fb0faa41394dee2f | Versionado | [Software/GRLL/GRLL/Common/My/MySettings.cs:1](../../Software/GRLL/GRLL/Common/My/MySettings.cs#L1) |
| Software/GRLL/GRLL/Common/My/MySettingsProperty.cs | 17 | ab56323ec04d5dba9803d3b4a9111cbba4ccfb350aab7d4ec1ee564fea45f924 | Versionado | [Software/GRLL/GRLL/Common/My/MySettingsProperty.cs:1](../../Software/GRLL/GRLL/Common/My/MySettingsProperty.cs#L1) |
| Software/GRLL/GRLL/Common/My/Resources/Resources.cs | 164 | 3e4ee62a54b26247bbaaea3c2fc6321cfaf3257c8a76203a96592118c8934421 | Versionado | [Software/GRLL/GRLL/Common/My/Resources/Resources.cs:1](../../Software/GRLL/GRLL/Common/My/Resources/Resources.cs#L1) |
| Software/GRLL/GRLL/Common/Nacionalidad.cs | 126 | b61466dccdb49cc6c30f61654fc10b80d30e0e45480c0b4ca7003c2e46cb7978 | Versionado | [Software/GRLL/GRLL/Common/Nacionalidad.cs:1](../../Software/GRLL/GRLL/Common/Nacionalidad.cs#L1) |
| Software/GRLL/GRLL/Common/NacionalidadMapper.cs | 17 | ee9e41cbde35b50fcad787edc9ed4480e6f1f0d7b67798e587077c12167ae470 | Versionado | [Software/GRLL/GRLL/Common/NacionalidadMapper.cs:1](../../Software/GRLL/GRLL/Common/NacionalidadMapper.cs#L1) |
| Software/GRLL/GRLL/Common/NroCuenta.cs | 174 | 6bd709fda822b7c10510c869fa5db63891e4a12ae5b235fd3faf9d6e00c3bab7 | Versionado | [Software/GRLL/GRLL/Common/NroCuenta.cs:1](../../Software/GRLL/GRLL/Common/NroCuenta.cs#L1) |
| Software/GRLL/GRLL/Common/NroCuentaMapper.cs | 17 | 58683d7c7a5266525bb3371bf39291e60565a2825aa776c1a6a15148b4d37163 | Versionado | [Software/GRLL/GRLL/Common/NroCuentaMapper.cs:1](../../Software/GRLL/GRLL/Common/NroCuentaMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Objetivo.cs | 391 | efe351b78ad4eade0fbf0ef1077ad6385db2b708115726976cbc300f7fdc6c2a | Versionado | [Software/GRLL/GRLL/Common/Objetivo.cs:1](../../Software/GRLL/GRLL/Common/Objetivo.cs#L1) |
| Software/GRLL/GRLL/Common/Operacion.cs | 138 | f403c6a4c389d7e6ce161b8f73ac7f25cb98161a8cceb65484029607a973259c | Versionado | [Software/GRLL/GRLL/Common/Operacion.cs:1](../../Software/GRLL/GRLL/Common/Operacion.cs#L1) |
| Software/GRLL/GRLL/Common/OperacionMapper.cs | 17 | 29505685953e626efec305f55c407aaba2a1fbc1a350f188ad37dde491c35e59 | Versionado | [Software/GRLL/GRLL/Common/OperacionMapper.cs:1](../../Software/GRLL/GRLL/Common/OperacionMapper.cs#L1) |
| Software/GRLL/GRLL/Common/OrdenCompra.cs | 875 | 2fe50f025d8379ec98bd97c9640a3c06a7b9ac78ffb92382e7e43e6c9229b247 | Versionado | [Software/GRLL/GRLL/Common/OrdenCompra.cs:1](../../Software/GRLL/GRLL/Common/OrdenCompra.cs#L1) |
| Software/GRLL/GRLL/Common/OrdenCompraMapper.cs | 17 | 4faadc7006382717a9af7dc5cb934e144537f6d45a5d21e84bf4879640b476b8 | Versionado | [Software/GRLL/GRLL/Common/OrdenCompraMapper.cs:1](../../Software/GRLL/GRLL/Common/OrdenCompraMapper.cs#L1) |
| Software/GRLL/GRLL/Common/PapeletDepositCaj.cs | 339 | 7e38bee303a1dd8b42fca052f82b30c46fdb609a50199f8b7a5224d646645640 | Versionado | [Software/GRLL/GRLL/Common/PapeletDepositCaj.cs:1](../../Software/GRLL/GRLL/Common/PapeletDepositCaj.cs#L1) |
| Software/GRLL/GRLL/Common/PapeletDepositCajMapper.cs | 17 | 30fe405a8400e87e2070e53cb3abc1f0221803d91eb711825cefa8dd2069f134 | Versionado | [Software/GRLL/GRLL/Common/PapeletDepositCajMapper.cs:1](../../Software/GRLL/GRLL/Common/PapeletDepositCajMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Parametro_Periodo.cs | 138 | 0b37e38e57f1cee6d3fe9ff2cff7cb1551ce0a6812fe92d821149e8f9197664c | Versionado | [Software/GRLL/GRLL/Common/Parametro_Periodo.cs:1](../../Software/GRLL/GRLL/Common/Parametro_Periodo.cs#L1) |
| Software/GRLL/GRLL/Common/Parametro_PeriodoMapper.cs | 17 | a846e7a40025efa473f4b893093e7b756fc99e669e2afc1eea78e8dc67b6e1d6 | Versionado | [Software/GRLL/GRLL/Common/Parametro_PeriodoMapper.cs:1](../../Software/GRLL/GRLL/Common/Parametro_PeriodoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Parametros.cs | 106 | 957cec98bf469fb882d078814d1245f76db4879aa0fcc6de275062a7f67a26b6 | Versionado | [Software/GRLL/GRLL/Common/Parametros.cs:1](../../Software/GRLL/GRLL/Common/Parametros.cs#L1) |
| Software/GRLL/GRLL/Common/ParametrosCaja.cs | 153 | 09cc37e46732eecc75de7ae57a607b53bee714aa3afb3371bbdc3087c16543f4 | Versionado | [Software/GRLL/GRLL/Common/ParametrosCaja.cs:1](../../Software/GRLL/GRLL/Common/ParametrosCaja.cs#L1) |
| Software/GRLL/GRLL/Common/ParametrosCajaMapper.cs | 17 | 05297768d806b58446479ced83418376233b69a67f335faf68780840c3a756f7 | Versionado | [Software/GRLL/GRLL/Common/ParametrosCajaMapper.cs:1](../../Software/GRLL/GRLL/Common/ParametrosCajaMapper.cs#L1) |
| Software/GRLL/GRLL/Common/ParametrosMapper.cs | 17 | f74e2e613820b0595daab4cd69d949b46e56f20300edcce32bd680e3b47a326e | Versionado | [Software/GRLL/GRLL/Common/ParametrosMapper.cs:1](../../Software/GRLL/GRLL/Common/ParametrosMapper.cs#L1) |
| Software/GRLL/GRLL/Common/ParametrosTrab.cs | 453 | 48d9560bc24e5426500d6f61a3d0cecbe1e789cc53e4eee71a31d76a43a386d5 | Versionado | [Software/GRLL/GRLL/Common/ParametrosTrab.cs:1](../../Software/GRLL/GRLL/Common/ParametrosTrab.cs#L1) |
| Software/GRLL/GRLL/Common/Pedido.cs | 623 | 10c793038fe3913aff033a888df65762d95b673170595a405b1586281c686b16 | Versionado | [Software/GRLL/GRLL/Common/Pedido.cs:1](../../Software/GRLL/GRLL/Common/Pedido.cs#L1) |
| Software/GRLL/GRLL/Common/PedidoMapper.cs | 17 | f8a9ab4bb6e6fcf366c3a63def269545b4513869dee08365012494627964c531 | Versionado | [Software/GRLL/GRLL/Common/PedidoMapper.cs:1](../../Software/GRLL/GRLL/Common/PedidoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Pedido_Despacho.cs | 158 | fc5121ba0b6cff52dc5d574d0e85dcfa14422df0504ca0785b2ca3fad40b404f | Versionado | [Software/GRLL/GRLL/Common/Pedido_Despacho.cs:1](../../Software/GRLL/GRLL/Common/Pedido_Despacho.cs#L1) |
| Software/GRLL/GRLL/Common/PeriodoLaboral.cs | 239 | bee7e6997d1760cf93493b1c57599ee43972907073f3c8314b381e7f3d27b532 | Versionado | [Software/GRLL/GRLL/Common/PeriodoLaboral.cs:1](../../Software/GRLL/GRLL/Common/PeriodoLaboral.cs#L1) |
| Software/GRLL/GRLL/Common/PeriodoLaboralMapper.cs | 17 | 3e6faa16eadf1bfc15a9a9a57535ce1a2196e53410f48a19757d90f449431aa9 | Versionado | [Software/GRLL/GRLL/Common/PeriodoLaboralMapper.cs:1](../../Software/GRLL/GRLL/Common/PeriodoLaboralMapper.cs#L1) |
| Software/GRLL/GRLL/Common/PeriodoTrimestral.cs | 113 | 78a8f18c61a8635d5f7de694fc462de4ca47f0fd8ab656ca126381a87c4d9aad | Versionado | [Software/GRLL/GRLL/Common/PeriodoTrimestral.cs:1](../../Software/GRLL/GRLL/Common/PeriodoTrimestral.cs#L1) |
| Software/GRLL/GRLL/Common/Permiso.cs | 379 | edc70757d08618c8075c3ff14af1404a565bb7fd40ee740125c40aba5fa1f216 | Versionado | [Software/GRLL/GRLL/Common/Permiso.cs:1](../../Software/GRLL/GRLL/Common/Permiso.cs#L1) |
| Software/GRLL/GRLL/Common/PermisoMapper.cs | 17 | 312a48c7cfda34f24c863d8ce3087b83b4103656c9ff87b5dbb1ba2f3779a9ca | Versionado | [Software/GRLL/GRLL/Common/PermisoMapper.cs:1](../../Software/GRLL/GRLL/Common/PermisoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Persona.cs | 519 | 5bd34c8c3e017b3694dbde60c4f0125222650f14738f1e53387231a8c3344890 | Versionado | [Software/GRLL/GRLL/Common/Persona.cs:1](../../Software/GRLL/GRLL/Common/Persona.cs#L1) |
| Software/GRLL/GRLL/Common/PersonaMapper.cs | 17 | 9ca6b785a34eb1813982cd9b8230c0a4077daa274ea396bea0e480c6073bb9c3 | Versionado | [Software/GRLL/GRLL/Common/PersonaMapper.cs:1](../../Software/GRLL/GRLL/Common/PersonaMapper.cs#L1) |
| Software/GRLL/GRLL/Common/PersonaSunat.cs | 106 | e77968999fc99dbc1b834a9909d4fbd82fd2c28b5b63be32cf59c43368e70e86 | Versionado | [Software/GRLL/GRLL/Common/PersonaSunat.cs:1](../../Software/GRLL/GRLL/Common/PersonaSunat.cs#L1) |
| Software/GRLL/GRLL/Common/PlanMayor.cs | 288 | 765f5404040d6181660957886a8a8a825cf44be6c0c484e80c9e52f18f8e45ef | Versionado | [Software/GRLL/GRLL/Common/PlanMayor.cs:1](../../Software/GRLL/GRLL/Common/PlanMayor.cs#L1) |
| Software/GRLL/GRLL/Common/PlanMayorMapper.cs | 17 | 15e0e1a9649486751c78621da68d62f0eb5e0f3d2c759a5e6747c380265be533 | Versionado | [Software/GRLL/GRLL/Common/PlanMayorMapper.cs:1](../../Software/GRLL/GRLL/Common/PlanMayorMapper.cs#L1) |
| Software/GRLL/GRLL/Common/PresupuestoT.cs | 493 | 6d564033a26036e73066e7768643354161486588d5d5483af4ecf05c60a86369 | Versionado | [Software/GRLL/GRLL/Common/PresupuestoT.cs:1](../../Software/GRLL/GRLL/Common/PresupuestoT.cs#L1) |
| Software/GRLL/GRLL/Common/ProgramMes.cs | 232 | 8a3294802e2c7abc68dfe68aa83d9cad41824c611a1811e6a376d81c809f6ec4 | Versionado | [Software/GRLL/GRLL/Common/ProgramMes.cs:1](../../Software/GRLL/GRLL/Common/ProgramMes.cs#L1) |
| Software/GRLL/GRLL/Common/Programa.cs | 192 | 679177dd5d2de1c2906256eb25e50b51b47e688e2fb61bbf3c4549071c756f7b | Versionado | [Software/GRLL/GRLL/Common/Programa.cs:1](../../Software/GRLL/GRLL/Common/Programa.cs#L1) |
| Software/GRLL/GRLL/Common/ProgramaNF.cs | 153 | c6a6e5659a62d6d0310b176cfc80a79e0436df713b7e99b4da23b30e49a992d6 | Versionado | [Software/GRLL/GRLL/Common/ProgramaNF.cs:1](../../Software/GRLL/GRLL/Common/ProgramaNF.cs#L1) |
| Software/GRLL/GRLL/Common/ProgramaProp.cs | 244 | 2785c2855438d858fd46bd8bff19a0d7cf5ead0d5b67d32e45f90fbb14b422e6 | Versionado | [Software/GRLL/GRLL/Common/ProgramaProp.cs:1](../../Software/GRLL/GRLL/Common/ProgramaProp.cs#L1) |
| Software/GRLL/GRLL/Common/ProgramaPropMapper.cs | 17 | 2287799035b2262bd89e477f99f61239d5ecdf234670d4c61ea93bca2a5e2a96 | Versionado | [Software/GRLL/GRLL/Common/ProgramaPropMapper.cs:1](../../Software/GRLL/GRLL/Common/ProgramaPropMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Proveedor.cs | 498 | 6a72f2ed1fb823e8122078c9109c1d04ad6226046fb8284a91d2a8bdbf6e9bfa | Versionado | [Software/GRLL/GRLL/Common/Proveedor.cs:1](../../Software/GRLL/GRLL/Common/Proveedor.cs#L1) |
| Software/GRLL/GRLL/Common/ProveedorMapper.cs | 17 | 10a8d87be71c3b40f7e0e5f05e95312400aea796161ff50f5a0bedf882c40065 | Versionado | [Software/GRLL/GRLL/Common/ProveedorMapper.cs:1](../../Software/GRLL/GRLL/Common/ProveedorMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Proveedor_Bien.cs | 198 | 944cf8cdb5dd43072d17bf2ce120b83c1038ecb83a023e9871ee76ed958af4ce | Versionado | [Software/GRLL/GRLL/Common/Proveedor_Bien.cs:1](../../Software/GRLL/GRLL/Common/Proveedor_Bien.cs#L1) |
| Software/GRLL/GRLL/Common/Proveedor_BienMapper.cs | 17 | fdb580da3b57d4752ee6c90da3f5dd0c74fb8598fe53ab1cc9fb3c363f58d36a | Versionado | [Software/GRLL/GRLL/Common/Proveedor_BienMapper.cs:1](../../Software/GRLL/GRLL/Common/Proveedor_BienMapper.cs#L1) |
| Software/GRLL/GRLL/Common/RRHH_AcudeEnferm.cs | 106 | c435bb61fe4da194b5887f96c5d5d7a051b20d1ffa2e5b0b888cb1c982f711a7 | Versionado | [Software/GRLL/GRLL/Common/RRHH_AcudeEnferm.cs:1](../../Software/GRLL/GRLL/Common/RRHH_AcudeEnferm.cs#L1) |
| Software/GRLL/GRLL/Common/RRHH_AcudeEnfermMapper.cs | 17 | cd65e9d3775829b0887e81663d0873fb0db1355b311f1b1ef86be48a71ac6bb2 | Versionado | [Software/GRLL/GRLL/Common/RRHH_AcudeEnfermMapper.cs:1](../../Software/GRLL/GRLL/Common/RRHH_AcudeEnfermMapper.cs#L1) |
| Software/GRLL/GRLL/Common/RRHH_Asegurado.cs | 479 | a84dba08d3c54abd5eb867de36491be09851c12a5b1eccca79d03a9e354ea12a | Versionado | [Software/GRLL/GRLL/Common/RRHH_Asegurado.cs:1](../../Software/GRLL/GRLL/Common/RRHH_Asegurado.cs#L1) |
| Software/GRLL/GRLL/Common/RRHH_AseguradoMapper.cs | 17 | af4aaa82b7c89b28aad2e15bd475ef1f1d254fed5810925a8f2190b85ef37376 | Versionado | [Software/GRLL/GRLL/Common/RRHH_AseguradoMapper.cs:1](../../Software/GRLL/GRLL/Common/RRHH_AseguradoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/RRHH_AspSocio.cs | 378 | fb31b897fab1e4534349d5ec8dfe0033b986ae0929492f0ec367360be8b839cb | Versionado | [Software/GRLL/GRLL/Common/RRHH_AspSocio.cs:1](../../Software/GRLL/GRLL/Common/RRHH_AspSocio.cs#L1) |
| Software/GRLL/GRLL/Common/RRHH_AspSocioMapper.cs | 17 | f8c1c47072a3073d492c3449774b627d356044c910f9379fcdd110fb5bb00c95 | Versionado | [Software/GRLL/GRLL/Common/RRHH_AspSocioMapper.cs:1](../../Software/GRLL/GRLL/Common/RRHH_AspSocioMapper.cs#L1) |
| Software/GRLL/GRLL/Common/RRHH_DinamicaFamiliar.cs | 378 | 789e55248668ad9ee08d0552f06cadb7d7e2eed6b080374d74dc4051648f54ee | Versionado | [Software/GRLL/GRLL/Common/RRHH_DinamicaFamiliar.cs:1](../../Software/GRLL/GRLL/Common/RRHH_DinamicaFamiliar.cs#L1) |
| Software/GRLL/GRLL/Common/RRHH_DinamicaFamiliarMapper.cs | 17 | 61b2740dcb1255c3dfb1d900ec466a8e7500fd1add6c0adc5e31ca027eca9b82 | Versionado | [Software/GRLL/GRLL/Common/RRHH_DinamicaFamiliarMapper.cs:1](../../Software/GRLL/GRLL/Common/RRHH_DinamicaFamiliarMapper.cs#L1) |
| Software/GRLL/GRLL/Common/RRHH_Feriado.cs | 94 | c62648b43cbfeb56166d72003b8018c91e44b9fe704d863c1bdc0da39709c203 | Versionado | [Software/GRLL/GRLL/Common/RRHH_Feriado.cs:1](../../Software/GRLL/GRLL/Common/RRHH_Feriado.cs#L1) |
| Software/GRLL/GRLL/Common/RRHH_FeriadoMapper.cs | 17 | f92d6adab4fc650261a1dffc4bca20a5bb05fe51dada19304156038175e67778 | Versionado | [Software/GRLL/GRLL/Common/RRHH_FeriadoMapper.cs:1](../../Software/GRLL/GRLL/Common/RRHH_FeriadoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/RRHH_FuncFam.cs | 298 | ad55a152d28e859af7a44c8b019600b7fc4ac12ad36b439d5693e3005640e021 | Versionado | [Software/GRLL/GRLL/Common/RRHH_FuncFam.cs:1](../../Software/GRLL/GRLL/Common/RRHH_FuncFam.cs#L1) |
| Software/GRLL/GRLL/Common/RRHH_FuncFamMapper.cs | 17 | 51251c926b1f0a7e37dba1bc16cd2e44cb409a7dea3b4202588a3910fa6610ce | Versionado | [Software/GRLL/GRLL/Common/RRHH_FuncFamMapper.cs:1](../../Software/GRLL/GRLL/Common/RRHH_FuncFamMapper.cs#L1) |
| Software/GRLL/GRLL/Common/RRHH_Preg1.cs | 106 | ea56bb3733639a240208280551e75091108c5323297e1f2723446e694a88495d | Versionado | [Software/GRLL/GRLL/Common/RRHH_Preg1.cs:1](../../Software/GRLL/GRLL/Common/RRHH_Preg1.cs#L1) |
| Software/GRLL/GRLL/Common/RRHH_Preg1Mapper.cs | 17 | eb56fc76c75c1bb67d33937ccc6391fbc29ac1761c6e492d2524c903271b4af6 | Versionado | [Software/GRLL/GRLL/Common/RRHH_Preg1Mapper.cs:1](../../Software/GRLL/GRLL/Common/RRHH_Preg1Mapper.cs#L1) |
| Software/GRLL/GRLL/Common/RRHH_Preg2.cs | 106 | 40fec10cf65dafac3ef8cb53ccdf431ad9ef3f3ed1dffe3ed1858ba580ad2df0 | Versionado | [Software/GRLL/GRLL/Common/RRHH_Preg2.cs:1](../../Software/GRLL/GRLL/Common/RRHH_Preg2.cs#L1) |
| Software/GRLL/GRLL/Common/RRHH_Preg2Mapper.cs | 17 | c8d1244184c6781ffec46efefb2486e52dc20596911dd82e36f2bd3a514053bb | Versionado | [Software/GRLL/GRLL/Common/RRHH_Preg2Mapper.cs:1](../../Software/GRLL/GRLL/Common/RRHH_Preg2Mapper.cs#L1) |
| Software/GRLL/GRLL/Common/RRHH_Preg3.cs | 106 | b64f77ad23a5f1d5dce2aba725292381fa812d0764aceae04ad342215e41a99e | Versionado | [Software/GRLL/GRLL/Common/RRHH_Preg3.cs:1](../../Software/GRLL/GRLL/Common/RRHH_Preg3.cs#L1) |
| Software/GRLL/GRLL/Common/RRHH_Preg3Mapper.cs | 17 | b6e7c97b700d2644c649f99ec55d4867d9dbb625a015aeb31eebef849cc2111e | Versionado | [Software/GRLL/GRLL/Common/RRHH_Preg3Mapper.cs:1](../../Software/GRLL/GRLL/Common/RRHH_Preg3Mapper.cs#L1) |
| Software/GRLL/GRLL/Common/RRHH_RelacHermano.cs | 106 | 1742a7016ea850cb31fd194b0e21266e6056ff74ee4842e0082e2dfa7fd54106 | Versionado | [Software/GRLL/GRLL/Common/RRHH_RelacHermano.cs:1](../../Software/GRLL/GRLL/Common/RRHH_RelacHermano.cs#L1) |
| Software/GRLL/GRLL/Common/RRHH_RelacHermanoMapper.cs | 17 | 3487862a6fe56eaf73c46db5ea646df0cee774cf0db6f0d56196fd168b14fa78 | Versionado | [Software/GRLL/GRLL/Common/RRHH_RelacHermanoMapper.cs:1](../../Software/GRLL/GRLL/Common/RRHH_RelacHermanoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/RRHH_RelacPH.cs | 106 | 00aac0149dbdbb57d7ed5e97238a01841fc0ba3041e57d9f1082592548ad4a6b | Versionado | [Software/GRLL/GRLL/Common/RRHH_RelacPH.cs:1](../../Software/GRLL/GRLL/Common/RRHH_RelacPH.cs#L1) |
| Software/GRLL/GRLL/Common/RRHH_RelacPHMapper.cs | 17 | 796abe06784e21ff8cf81c486089839c279376438c43306a44e31af081f8c402 | Versionado | [Software/GRLL/GRLL/Common/RRHH_RelacPHMapper.cs:1](../../Software/GRLL/GRLL/Common/RRHH_RelacPHMapper.cs#L1) |
| Software/GRLL/GRLL/Common/RRHH_RelacPareja.cs | 106 | 78d5d2f1fb6f9f80d2ea6a7ca4970aa1ad3b4c57e23d61b8e7c05614b5925e93 | Versionado | [Software/GRLL/GRLL/Common/RRHH_RelacPareja.cs:1](../../Software/GRLL/GRLL/Common/RRHH_RelacPareja.cs#L1) |
| Software/GRLL/GRLL/Common/RRHH_RelacParejaMapper.cs | 17 | a416f8d2c9e6e7befe9a801f9e2adfcfdaa66cb1ffba05322a5b3ee1982c9221 | Versionado | [Software/GRLL/GRLL/Common/RRHH_RelacParejaMapper.cs:1](../../Software/GRLL/GRLL/Common/RRHH_RelacParejaMapper.cs#L1) |
| Software/GRLL/GRLL/Common/RRHH_Salud.cs | 298 | 7d324f489855c61780125fa670f48b1595c0c77ce91023b0c9a005bae40c2c17 | Versionado | [Software/GRLL/GRLL/Common/RRHH_Salud.cs:1](../../Software/GRLL/GRLL/Common/RRHH_Salud.cs#L1) |
| Software/GRLL/GRLL/Common/RRHH_SaludMapper.cs | 17 | 77f276fd3be81f46429b7300eac8e0c134618c3e1ce6ab0d45b7dc88648bb388 | Versionado | [Software/GRLL/GRLL/Common/RRHH_SaludMapper.cs:1](../../Software/GRLL/GRLL/Common/RRHH_SaludMapper.cs#L1) |
| Software/GRLL/GRLL/Common/RRHH_TempFecha.cs | 74 | 3e48abe1907d17095abc2ff16ff0d2b9d3e9dfa2ebdfca7b176153f2bd70103f | Versionado | [Software/GRLL/GRLL/Common/RRHH_TempFecha.cs:1](../../Software/GRLL/GRLL/Common/RRHH_TempFecha.cs#L1) |
| Software/GRLL/GRLL/Common/RRHH_TempFechaMapper.cs | 17 | 93e64b4063a9b0c37f222a550cbdea546a8c5530b58d97d85afea962db48c67a | Versionado | [Software/GRLL/GRLL/Common/RRHH_TempFechaMapper.cs:1](../../Software/GRLL/GRLL/Common/RRHH_TempFechaMapper.cs#L1) |
| Software/GRLL/GRLL/Common/RRHH_TipoFamilia.cs | 106 | e5906febd41d147a1935e89ae58c7537ece5e9bd0ef1d05e7e0064720a5bbfb5 | Versionado | [Software/GRLL/GRLL/Common/RRHH_TipoFamilia.cs:1](../../Software/GRLL/GRLL/Common/RRHH_TipoFamilia.cs#L1) |
| Software/GRLL/GRLL/Common/RRHH_TipoFamiliaMapper.cs | 17 | 59511acac86a6774f2ebac73724277bab4b3af1541ec10143dc35017093bbfd7 | Versionado | [Software/GRLL/GRLL/Common/RRHH_TipoFamiliaMapper.cs:1](../../Software/GRLL/GRLL/Common/RRHH_TipoFamiliaMapper.cs#L1) |
| Software/GRLL/GRLL/Common/RangoFecha.cs | 47 | 28b91b71ca0ca75ab769c38d63f22768a65e9fbf6eeb4157c108d9a90b602334 | Versionado | [Software/GRLL/GRLL/Common/RangoFecha.cs:1](../../Software/GRLL/GRLL/Common/RangoFecha.cs#L1) |
| Software/GRLL/GRLL/Common/Recomendacion.cs | 264 | 48450e8966a990524cb096d6b0e0b68482b7d50273f447349b33ed3a98e6572f | Versionado | [Software/GRLL/GRLL/Common/Recomendacion.cs:1](../../Software/GRLL/GRLL/Common/Recomendacion.cs#L1) |
| Software/GRLL/GRLL/Common/RefSIAF.cs | 166 | f3a93979d5d6edb4089b4e9a1869da050fd320b62f59c64179f8405c4b40c6c9 | Versionado | [Software/GRLL/GRLL/Common/RefSIAF.cs:1](../../Software/GRLL/GRLL/Common/RefSIAF.cs#L1) |
| Software/GRLL/GRLL/Common/RefSIAFMapper.cs | 17 | 2b17305ae8d3bcbedcffd234a75338bff882bdfebf8c652ce60d41d5468878a6 | Versionado | [Software/GRLL/GRLL/Common/RefSIAFMapper.cs:1](../../Software/GRLL/GRLL/Common/RefSIAFMapper.cs#L1) |
| Software/GRLL/GRLL/Common/RegAsisDiario.cs | 134 | 5e4f2821af6723796b101dceaa701c669830a4cd87c6d01e3e85cb2aeb7c9d98 | Versionado | [Software/GRLL/GRLL/Common/RegAsisDiario.cs:1](../../Software/GRLL/GRLL/Common/RegAsisDiario.cs#L1) |
| Software/GRLL/GRLL/Common/RegimenPension.cs | 106 | 65f4b28cbcfab842a25e042b1bc222aa103898d7d7e8afbc457cc54fd0b96259 | Versionado | [Software/GRLL/GRLL/Common/RegimenPension.cs:1](../../Software/GRLL/GRLL/Common/RegimenPension.cs#L1) |
| Software/GRLL/GRLL/Common/RegimenPensionMapper.cs | 17 | 64229f84fee1f608cb6af06870afabc188a893ec1dffa98e77c014f1910ecd8b | Versionado | [Software/GRLL/GRLL/Common/RegimenPensionMapper.cs:1](../../Software/GRLL/GRLL/Common/RegimenPensionMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Reporte_Asistencias.cs | 114 | bd8ef8551628dec8fd39ce524c5f77fe0a22ab29c55c0ca33ad145cea3252b58 | Versionado | [Software/GRLL/GRLL/Common/Reporte_Asistencias.cs:1](../../Software/GRLL/GRLL/Common/Reporte_Asistencias.cs#L1) |
| Software/GRLL/GRLL/Common/ReqXProgMes.cs | 310 | 8727a8f4cd0c9a158699f96bf4c1c6323e07cb1d9307c1930dddedf557422dc1 | Versionado | [Software/GRLL/GRLL/Common/ReqXProgMes.cs:1](../../Software/GRLL/GRLL/Common/ReqXProgMes.cs#L1) |
| Software/GRLL/GRLL/Common/Resolucion.cs | 219 | 3f828cd90c1dec6b1684b47804a1d3a535f75131433ce46f38b91258210e2b86 | Versionado | [Software/GRLL/GRLL/Common/Resolucion.cs:1](../../Software/GRLL/GRLL/Common/Resolucion.cs#L1) |
| Software/GRLL/GRLL/Common/ResolucionMapper.cs | 17 | 4e9a294b8c2289de69972668e99f54953f6b8b126eac16607b2936c3a027760a | Versionado | [Software/GRLL/GRLL/Common/ResolucionMapper.cs:1](../../Software/GRLL/GRLL/Common/ResolucionMapper.cs#L1) |
| Software/GRLL/GRLL/Common/ResponsableXUO.cs | 194 | 29826ee5994760b77689bc143a2aa767328275290594cf9a6a2098e66ef35f87 | Versionado | [Software/GRLL/GRLL/Common/ResponsableXUO.cs:1](../../Software/GRLL/GRLL/Common/ResponsableXUO.cs#L1) |
| Software/GRLL/GRLL/Common/Rol.cs | 154 | 47fa2ac9cf374de9bd99c1bf9e1c41f6092260f94a9aed11289e5ebad795e1ee | Versionado | [Software/GRLL/GRLL/Common/Rol.cs:1](../../Software/GRLL/GRLL/Common/Rol.cs#L1) |
| Software/GRLL/GRLL/Common/RolMapper.cs | 17 | 5eb651887b61a140a996d4644558f807fc6dd1b7f7c5cf99e13d735346743c34 | Versionado | [Software/GRLL/GRLL/Common/RolMapper.cs:1](../../Software/GRLL/GRLL/Common/RolMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Rol_Acceso.cs | 178 | f22a32125f1c6d16db70afa183b1f7aef795f5421c494b3991592fd74162c647 | Versionado | [Software/GRLL/GRLL/Common/Rol_Acceso.cs:1](../../Software/GRLL/GRLL/Common/Rol_Acceso.cs#L1) |
| Software/GRLL/GRLL/Common/Rol_AccesoMapper.cs | 17 | acc4f17014ad44dd326dca56d5358c8ed838cc497b598d3a6062cf5b10ead62d | Versionado | [Software/GRLL/GRLL/Common/Rol_AccesoMapper.cs:1](../../Software/GRLL/GRLL/Common/Rol_AccesoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Rotacion.cs | 245 | 42871d0d311de2b48935ca1af494fc0dc0866a63c143398df2d01b8c602398d8 | Versionado | [Software/GRLL/GRLL/Common/Rotacion.cs:1](../../Software/GRLL/GRLL/Common/Rotacion.cs#L1) |
| Software/GRLL/GRLL/Common/RotacionMapper.cs | 17 | 689f313f096e75255d67e5dd0d4a43029cd4a5862200ed67b6394c3091312027 | Versionado | [Software/GRLL/GRLL/Common/RotacionMapper.cs:1](../../Software/GRLL/GRLL/Common/RotacionMapper.cs#L1) |
| Software/GRLL/GRLL/Common/SP_ABA_FILTRARMETAResult.cs | 42 | 3c2e751d7a612f38eb3209602741e45faaa22fe093861079095ae81c0e9e6c21 | Versionado | [Software/GRLL/GRLL/Common/SP_ABA_FILTRARMETAResult.cs:1](../../Software/GRLL/GRLL/Common/SP_ABA_FILTRARMETAResult.cs#L1) |
| Software/GRLL/GRLL/Common/SP_ABA_FILTRAR_BIEN_TIPOResult.cs | 241 | ff350b212bc4d07936b37325dbed1f45b861ebfb2e312be3066b851f7672a490 | Versionado | [Software/GRLL/GRLL/Common/SP_ABA_FILTRAR_BIEN_TIPOResult.cs:1](../../Software/GRLL/GRLL/Common/SP_ABA_FILTRAR_BIEN_TIPOResult.cs#L1) |
| Software/GRLL/GRLL/Common/SP_Tra_Art_NroResult.cs | 24 | aaa979aef7b11ff04ac3e6ef7d802ee763cdc3d6d1f08d8447e403d3909442ad | Versionado | [Software/GRLL/GRLL/Common/SP_Tra_Art_NroResult.cs:1](../../Software/GRLL/GRLL/Common/SP_Tra_Art_NroResult.cs#L1) |
| Software/GRLL/GRLL/Common/SQLConfiguracion.cs | 106 | c659772480ca563565abe781fc864a4a9467afc4796b8064c12c85c7f11f5ec0 | Versionado | [Software/GRLL/GRLL/Common/SQLConfiguracion.cs:1](../../Software/GRLL/GRLL/Common/SQLConfiguracion.cs#L1) |
| Software/GRLL/GRLL/Common/Seguro.cs | 146 | 82ad0e7aa5ef9b3859cad3452d4c87bbd00b7959298d8d7cc86b417b0a7f4857 | Versionado | [Software/GRLL/GRLL/Common/Seguro.cs:1](../../Software/GRLL/GRLL/Common/Seguro.cs#L1) |
| Software/GRLL/GRLL/Common/SeguroMapper.cs | 17 | 8f49e9c9a8832ca7f4c5dc9b2d5c8c6d88bbfda4f52e470b7ac38fe2c14f92a3 | Versionado | [Software/GRLL/GRLL/Common/SeguroMapper.cs:1](../../Software/GRLL/GRLL/Common/SeguroMapper.cs#L1) |
| Software/GRLL/GRLL/Common/SettingLogin.cs | 67 | 75074395cdd2cb90e4584f01875cb324c19213586b6482c1b07a338576b6cd7a | Versionado | [Software/GRLL/GRLL/Common/SettingLogin.cs:1](../../Software/GRLL/GRLL/Common/SettingLogin.cs#L1) |
| Software/GRLL/GRLL/Common/SistemaOpcion.cs | 174 | ce02151aa63086716e59ee1538305c7bf6064b5a9b8001be1853017170c92605 | Versionado | [Software/GRLL/GRLL/Common/SistemaOpcion.cs:1](../../Software/GRLL/GRLL/Common/SistemaOpcion.cs#L1) |
| Software/GRLL/GRLL/Common/SistemaOpcionMapper.cs | 17 | d21644575a652a5b3dc77cedc3be9881e5ce876d963e16f3d0503ba3130c6c59 | Versionado | [Software/GRLL/GRLL/Common/SistemaOpcionMapper.cs:1](../../Software/GRLL/GRLL/Common/SistemaOpcionMapper.cs#L1) |
| Software/GRLL/GRLL/Common/SpCJR_ReportCJR_NuevoResult.cs | 259 | 0a5304c6e976ad6e904d58ef9a883803a5beca4c5bfe0e4f942a77fed71a91ac | Versionado | [Software/GRLL/GRLL/Common/SpCJR_ReportCJR_NuevoResult.cs:1](../../Software/GRLL/GRLL/Common/SpCJR_ReportCJR_NuevoResult.cs#L1) |
| Software/GRLL/GRLL/Common/SpCJR_ReportCJR_Nuevo_pResult.cs | 349 | 74a703679dd0ef7d003cd17f6adeeffd4f7ee50584a3cece68557923dac8dd5b | Versionado | [Software/GRLL/GRLL/Common/SpCJR_ReportCJR_Nuevo_pResult.cs:1](../../Software/GRLL/GRLL/Common/SpCJR_ReportCJR_Nuevo_pResult.cs#L1) |
| Software/GRLL/GRLL/Common/SubGenerica.cs | 218 | d5a085bd630f8ac4af4c469581b7760830e5405c8ec84724f266618a7f7271b5 | Versionado | [Software/GRLL/GRLL/Common/SubGenerica.cs:1](../../Software/GRLL/GRLL/Common/SubGenerica.cs#L1) |
| Software/GRLL/GRLL/Common/SubGenerica_Det.cs | 244 | 5dd6524791aa35724c06819a8569a43328efee47971ced64c99294d146613121 | Versionado | [Software/GRLL/GRLL/Common/SubGenerica_Det.cs:1](../../Software/GRLL/GRLL/Common/SubGenerica_Det.cs#L1) |
| Software/GRLL/GRLL/Common/SubPrograma.cs | 218 | 822bd30b7fa6e9dfbc25e8f11b2edef668b7147cb4660a824914de6f92aae1e1 | Versionado | [Software/GRLL/GRLL/Common/SubPrograma.cs:1](../../Software/GRLL/GRLL/Common/SubPrograma.cs#L1) |
| Software/GRLL/GRLL/Common/TEstiloCelda.cs | 97 | bac8c02d4a4454a8655839144dd1377bde3894f3e940de5bf46be6adf991a43a | Versionado | [Software/GRLL/GRLL/Common/TEstiloCelda.cs:1](../../Software/GRLL/GRLL/Common/TEstiloCelda.cs#L1) |
| Software/GRLL/GRLL/Common/TRAAdjunto.cs | 270 | 24c8efa773838f4de53098f13f1195290d2a8f4f40817f9a75a3a1a6b220deff | Versionado | [Software/GRLL/GRLL/Common/TRAAdjunto.cs:1](../../Software/GRLL/GRLL/Common/TRAAdjunto.cs#L1) |
| Software/GRLL/GRLL/Common/TRAAdjuntoMapper.cs | 17 | 42c943bcadf1b6d9555b458edec08798f8d33d15fc01264daead324e11365eeb | Versionado | [Software/GRLL/GRLL/Common/TRAAdjuntoMapper.cs:1](../../Software/GRLL/GRLL/Common/TRAAdjuntoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/TRADocumento.cs | 315 | e1336a20881ff519a2dff6192523f63bea21776268e361af18281e42c4c59753 | Versionado | [Software/GRLL/GRLL/Common/TRADocumento.cs:1](../../Software/GRLL/GRLL/Common/TRADocumento.cs#L1) |
| Software/GRLL/GRLL/Common/TRADocumentoMapper.cs | 17 | 2bd30c01daebaa25336ddf5e9580c6086fac71b50facc39c3a76fd1ee02e843d | Versionado | [Software/GRLL/GRLL/Common/TRADocumentoMapper.cs:1](../../Software/GRLL/GRLL/Common/TRADocumentoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/TRAEtapa_Cargo.cs | 118 | 1c360ee9f7b5080fe3ba7ca03d35b13a27b1fb0ac77163343af8306bbb66c8ad | Versionado | [Software/GRLL/GRLL/Common/TRAEtapa_Cargo.cs:1](../../Software/GRLL/GRLL/Common/TRAEtapa_Cargo.cs#L1) |
| Software/GRLL/GRLL/Common/TRAEtapa_CargoMapper.cs | 17 | 368f56d029536ca4c8d4de8be7d95a2ae76a5d35e5325f0e84d83819e8516845 | Versionado | [Software/GRLL/GRLL/Common/TRAEtapa_CargoMapper.cs:1](../../Software/GRLL/GRLL/Common/TRAEtapa_CargoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/TRAEtapa_Procedimiento.cs | 540 | 7a3331802f462fb2de5da59b5cd3065edfd426d571e5156101bc6fe111021b73 | Versionado | [Software/GRLL/GRLL/Common/TRAEtapa_Procedimiento.cs:1](../../Software/GRLL/GRLL/Common/TRAEtapa_Procedimiento.cs#L1) |
| Software/GRLL/GRLL/Common/TRAEtapa_ProcedimientoMapper.cs | 17 | ea349934d1b7cf285666a5af865e2f88c91a4426f10dd98ac68f060566acca45 | Versionado | [Software/GRLL/GRLL/Common/TRAEtapa_ProcedimientoMapper.cs:1](../../Software/GRLL/GRLL/Common/TRAEtapa_ProcedimientoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/TRAMovimiento.cs | 547 | 601b519768cb005442ccec3bfef72431f5b0ecdb28ca53fba9fc435389b17afc | Versionado | [Software/GRLL/GRLL/Common/TRAMovimiento.cs:1](../../Software/GRLL/GRLL/Common/TRAMovimiento.cs#L1) |
| Software/GRLL/GRLL/Common/TRAMovimientoMapper.cs | 17 | 71d02bd0a82f83451a88d99907125981e285bc94d176ac5f6a564161f9de6e98 | Versionado | [Software/GRLL/GRLL/Common/TRAMovimientoMapper.cs:1](../../Software/GRLL/GRLL/Common/TRAMovimientoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/TRANumeracion.cs | 204 | 3f9b98b5a5769b8c87016f44e78e67a29c34f5a4757627463e2546aba2b49976 | Versionado | [Software/GRLL/GRLL/Common/TRANumeracion.cs:1](../../Software/GRLL/GRLL/Common/TRANumeracion.cs#L1) |
| Software/GRLL/GRLL/Common/TRANumeracionMapper.cs | 17 | 8f12f77c18d13821eb7dd5c824bd699437cbf204130a82d16ae4e137370a23da | Versionado | [Software/GRLL/GRLL/Common/TRANumeracionMapper.cs:1](../../Software/GRLL/GRLL/Common/TRANumeracionMapper.cs#L1) |
| Software/GRLL/GRLL/Common/TRAProcedimiento.cs | 455 | c93ec01715cb13c3919af3f7fad6072c4cc97cf9b9f65203c2a9876aea9189fb | Versionado | [Software/GRLL/GRLL/Common/TRAProcedimiento.cs:1](../../Software/GRLL/GRLL/Common/TRAProcedimiento.cs#L1) |
| Software/GRLL/GRLL/Common/TRAProcedimientoMapper.cs | 17 | 2e13df55295037d5da173bbcb72f5f2ce12ce8afa59759f1fd5c6541203b2086 | Versionado | [Software/GRLL/GRLL/Common/TRAProcedimientoMapper.cs:1](../../Software/GRLL/GRLL/Common/TRAProcedimientoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/TRAProcedimiento_Requisito.cs | 158 | 9dd1071796022cb724744053cbd17b22964f9e959abb565f4a84ce981bccb958 | Versionado | [Software/GRLL/GRLL/Common/TRAProcedimiento_Requisito.cs:1](../../Software/GRLL/GRLL/Common/TRAProcedimiento_Requisito.cs#L1) |
| Software/GRLL/GRLL/Common/TRAProcedimiento_RequisitoMapper.cs | 17 | 4bfdddbb085e51b05d57f7f9d564d564886c7f26a175a6656ce266a65c076a29 | Versionado | [Software/GRLL/GRLL/Common/TRAProcedimiento_RequisitoMapper.cs:1](../../Software/GRLL/GRLL/Common/TRAProcedimiento_RequisitoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/TRARequisito.cs | 134 | b8c3e25567e50a524347e26a09f3e16bdf7165a623d3cbb17f6a6aff5bc6f72c | Versionado | [Software/GRLL/GRLL/Common/TRARequisito.cs:1](../../Software/GRLL/GRLL/Common/TRARequisito.cs#L1) |
| Software/GRLL/GRLL/Common/TRARequisitoMapper.cs | 17 | 2d9dfbb1eaf84c546826e7901bdf8512da40a63b4abcf371807cbf052e5f6582 | Versionado | [Software/GRLL/GRLL/Common/TRARequisitoMapper.cs:1](../../Software/GRLL/GRLL/Common/TRARequisitoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/TRATipoDoc.cs | 134 | 7917fc63acb66380c771958a9ad3ae19920aed807ac8da23d8414c4693d62742 | Versionado | [Software/GRLL/GRLL/Common/TRATipoDoc.cs:1](../../Software/GRLL/GRLL/Common/TRATipoDoc.cs#L1) |
| Software/GRLL/GRLL/Common/TRATipoDocMapper.cs | 17 | dd407bb41c252de29c9b0c329ab1debbccafb1859386b193769c3c5e5e3ac632 | Versionado | [Software/GRLL/GRLL/Common/TRATipoDocMapper.cs:1](../../Software/GRLL/GRLL/Common/TRATipoDocMapper.cs#L1) |
| Software/GRLL/GRLL/Common/TRATipoSilencio.cs | 106 | 79967306cc5f06c32dc802e6cbee5ebb03a3d6263b7f40ce4b3d867976edf04c | Versionado | [Software/GRLL/GRLL/Common/TRATipoSilencio.cs:1](../../Software/GRLL/GRLL/Common/TRATipoSilencio.cs#L1) |
| Software/GRLL/GRLL/Common/TRATipoSilencioMapper.cs | 17 | 97890c8f0d7907c535bc017c46c8810d6f378e83e71266a25ea37ce2c74fab48 | Versionado | [Software/GRLL/GRLL/Common/TRATipoSilencioMapper.cs:1](../../Software/GRLL/GRLL/Common/TRATipoSilencioMapper.cs#L1) |
| Software/GRLL/GRLL/Common/TRATramite.cs | 503 | c7a17b35a3ba3e98283c191994e8fc50d9c9222902b4a8c4462bb93168da3cca | Versionado | [Software/GRLL/GRLL/Common/TRATramite.cs:1](../../Software/GRLL/GRLL/Common/TRATramite.cs#L1) |
| Software/GRLL/GRLL/Common/TRATramiteMapper.cs | 17 | fc59da1fb5483e1e1855d894118b3b0f068d2ee7599deba1516758847c79d6ac | Versionado | [Software/GRLL/GRLL/Common/TRATramiteMapper.cs:1](../../Software/GRLL/GRLL/Common/TRATramiteMapper.cs#L1) |
| Software/GRLL/GRLL/Common/TRATramite_Requisito.cs | 178 | 0192ddccf619230e54b4544a2da79eb3354f0f51da9b490c448f73c4adc4702d | Versionado | [Software/GRLL/GRLL/Common/TRATramite_Requisito.cs:1](../../Software/GRLL/GRLL/Common/TRATramite_Requisito.cs#L1) |
| Software/GRLL/GRLL/Common/TRATramite_RequisitoMapper.cs | 17 | 8325571e74bbccfc51a942e9c446769d5a61918280336357b142b5e7b0173d34 | Versionado | [Software/GRLL/GRLL/Common/TRATramite_RequisitoMapper.cs:1](../../Software/GRLL/GRLL/Common/TRATramite_RequisitoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/TRAUsuario_IP.cs | 113 | 3349c84d9e597f12e4f92d4495bc46de247155499811e67580ac49a96d218e10 | Versionado | [Software/GRLL/GRLL/Common/TRAUsuario_IP.cs:1](../../Software/GRLL/GRLL/Common/TRAUsuario_IP.cs#L1) |
| Software/GRLL/GRLL/Common/TRAUsuario_IPMapper.cs | 17 | 2f7c5bdc2e3cfd381d504a0f379e5026b34f88c0d2055e735f2010687f575f3e | Versionado | [Software/GRLL/GRLL/Common/TRAUsuario_IPMapper.cs:1](../../Software/GRLL/GRLL/Common/TRAUsuario_IPMapper.cs#L1) |
| Software/GRLL/GRLL/Common/TRA_Adjunto_ListarPorTramiteResult.cs | 187 | c305a0229d0a58dd7535e983b34dcf4d48e8c8f134147fe24f017d589662aa47 | Versionado | [Software/GRLL/GRLL/Common/TRA_Adjunto_ListarPorTramiteResult.cs:1](../../Software/GRLL/GRLL/Common/TRA_Adjunto_ListarPorTramiteResult.cs#L1) |
| Software/GRLL/GRLL/Common/TRA_GET_IP_USUARIOResult.cs | 24 | 866f620afa84255ccc5cc72ede1a183713ce5d2beb5a1f36df9fa602179403fc | Versionado | [Software/GRLL/GRLL/Common/TRA_GET_IP_USUARIOResult.cs:1](../../Software/GRLL/GRLL/Common/TRA_GET_IP_USUARIOResult.cs#L1) |
| Software/GRLL/GRLL/Common/TRA_Movimiento_ListaPorTramiteResult.cs | 115 | 40c8e2668310295ef11ee556c727fb7bab22abb028b630b24da6edf2895c1ef5 | Versionado | [Software/GRLL/GRLL/Common/TRA_Movimiento_ListaPorTramiteResult.cs:1](../../Software/GRLL/GRLL/Common/TRA_Movimiento_ListaPorTramiteResult.cs#L1) |
| Software/GRLL/GRLL/Common/TRA_ProcedimientoRequisito_ListarResult.cs | 78 | 45658016716f4b70355420ac790105373fe3603c2f8fafa9805e528fe8442ee7 | Versionado | [Software/GRLL/GRLL/Common/TRA_ProcedimientoRequisito_ListarResult.cs:1](../../Software/GRLL/GRLL/Common/TRA_ProcedimientoRequisito_ListarResult.cs#L1) |
| Software/GRLL/GRLL/Common/TRA_TramiteRequisito_ListarResult.cs | 78 | 9e95b8f73c053844006e5466db9871877e28e4de8a4ef09f6b6ed59d58353acc | Versionado | [Software/GRLL/GRLL/Common/TRA_TramiteRequisito_ListarResult.cs:1](../../Software/GRLL/GRLL/Common/TRA_TramiteRequisito_ListarResult.cs#L1) |
| Software/GRLL/GRLL/Common/TenenciaViv.cs | 106 | 16d6f991db691eaf0089d43fac382cdfbbd020d7dcbffc8d8501b7d1a392e633 | Versionado | [Software/GRLL/GRLL/Common/TenenciaViv.cs:1](../../Software/GRLL/GRLL/Common/TenenciaViv.cs#L1) |
| Software/GRLL/GRLL/Common/TenenciaVivMapper.cs | 17 | d35dfbe50167304bc4dd4a598715ad8be4d2965d9afa671155509ab10b59d6c0 | Versionado | [Software/GRLL/GRLL/Common/TenenciaVivMapper.cs:1](../../Software/GRLL/GRLL/Common/TenenciaVivMapper.cs#L1) |
| Software/GRLL/GRLL/Common/TipoAdjudicacion.cs | 106 | 12b1ebf85d60332de3be6f8abe5a2bda10abe163e00b014906ecc559eb1cf3c2 | Versionado | [Software/GRLL/GRLL/Common/TipoAdjudicacion.cs:1](../../Software/GRLL/GRLL/Common/TipoAdjudicacion.cs#L1) |
| Software/GRLL/GRLL/Common/TipoAlerta.cs | 106 | bf4e10369ebb416fd0b5aa1519b34d49edf706bf171d80ff2ae40f5018d18e8c | Versionado | [Software/GRLL/GRLL/Common/TipoAlerta.cs:1](../../Software/GRLL/GRLL/Common/TipoAlerta.cs#L1) |
| Software/GRLL/GRLL/Common/TipoAlertaMapper.cs | 17 | fa4bb4e37b63e84f6ec431e0041cfde6e5380f5df82357bb2cf4757e7c9b5a9a | Versionado | [Software/GRLL/GRLL/Common/TipoAlertaMapper.cs:1](../../Software/GRLL/GRLL/Common/TipoAlertaMapper.cs#L1) |
| Software/GRLL/GRLL/Common/TipoComportamiento.cs | 106 | 06dffa5da9f8513576d346b4512248e4313f4865dafedfb730ace4f528818bdc | Versionado | [Software/GRLL/GRLL/Common/TipoComportamiento.cs:1](../../Software/GRLL/GRLL/Common/TipoComportamiento.cs#L1) |
| Software/GRLL/GRLL/Common/TipoComportamientoMapper.cs | 17 | 356a1e0d501441e8e475e32f0420547ae9fe420e0e420cc3dc0dc7fdee77a199 | Versionado | [Software/GRLL/GRLL/Common/TipoComportamientoMapper.cs:1](../../Software/GRLL/GRLL/Common/TipoComportamientoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/TipoDoc.cs | 133 | 7e2f29026500c8cff5491353a81f823880043fabd5b35392d01e1136406b5b1b | Versionado | [Software/GRLL/GRLL/Common/TipoDoc.cs:1](../../Software/GRLL/GRLL/Common/TipoDoc.cs#L1) |
| Software/GRLL/GRLL/Common/TipoDocID.cs | 73 | 22419e7f3690bea2a4334fc944d0cbe7f344aa559a1db8294e4dbf24cee95b5d | Versionado | [Software/GRLL/GRLL/Common/TipoDocID.cs:1](../../Software/GRLL/GRLL/Common/TipoDocID.cs#L1) |
| Software/GRLL/GRLL/Common/TipoDocIDMapper.cs | 17 | 7d1a7207913fc3e23bf3ec0c18487d0fcc3ce9f79645d72865049a4414c7ca6e | Versionado | [Software/GRLL/GRLL/Common/TipoDocIDMapper.cs:1](../../Software/GRLL/GRLL/Common/TipoDocIDMapper.cs#L1) |
| Software/GRLL/GRLL/Common/TipoDocMapper.cs | 17 | 9864810f3f9bc7216a037b51f4f842f4cb31b67cb375e256b4edb175f1e7181f | Versionado | [Software/GRLL/GRLL/Common/TipoDocMapper.cs:1](../../Software/GRLL/GRLL/Common/TipoDocMapper.cs#L1) |
| Software/GRLL/GRLL/Common/TipoEstudio.cs | 106 | a3b4eaf804c9ac81c4a88b0b44ac550b02a895a32cd852703428b477ccae0fbb | Versionado | [Software/GRLL/GRLL/Common/TipoEstudio.cs:1](../../Software/GRLL/GRLL/Common/TipoEstudio.cs#L1) |
| Software/GRLL/GRLL/Common/TipoEstudioMapper.cs | 17 | abb2c18c5469409a72d1afaff8a8849089aa6b8528d7b55a02109ed94017d245 | Versionado | [Software/GRLL/GRLL/Common/TipoEstudioMapper.cs:1](../../Software/GRLL/GRLL/Common/TipoEstudioMapper.cs#L1) |
| Software/GRLL/GRLL/Common/TipoFamiliar.cs | 106 | 860387ba3962c3d7bfc27be89fbcdc5f724fd6c21fb3805606800585879bfd83 | Versionado | [Software/GRLL/GRLL/Common/TipoFamiliar.cs:1](../../Software/GRLL/GRLL/Common/TipoFamiliar.cs#L1) |
| Software/GRLL/GRLL/Common/TipoInstitucion.cs | 106 | 4c7f7ebd6a9ab87991a403008c373d66e697240bd0177331c4e8830ceceb25a1 | Versionado | [Software/GRLL/GRLL/Common/TipoInstitucion.cs:1](../../Software/GRLL/GRLL/Common/TipoInstitucion.cs#L1) |
| Software/GRLL/GRLL/Common/TipoInstitucionMapper.cs | 17 | b40074ec437e55da4df48764894a8b23157cd96e13c75c262cf3670658d29a99 | Versionado | [Software/GRLL/GRLL/Common/TipoInstitucionMapper.cs:1](../../Software/GRLL/GRLL/Common/TipoInstitucionMapper.cs#L1) |
| Software/GRLL/GRLL/Common/TipoMoneda.cs | 93 | 818488e0061ada78fd8ab89061b43996840aaac751496cb34f9ee9753300553d | Versionado | [Software/GRLL/GRLL/Common/TipoMoneda.cs:1](../../Software/GRLL/GRLL/Common/TipoMoneda.cs#L1) |
| Software/GRLL/GRLL/Common/TipoMonedaMapper.cs | 17 | c6801f40141f7c76c5144903b3b39db546ebf782c9a6128b8b0323346fa55e83 | Versionado | [Software/GRLL/GRLL/Common/TipoMonedaMapper.cs:1](../../Software/GRLL/GRLL/Common/TipoMonedaMapper.cs#L1) |
| Software/GRLL/GRLL/Common/TipoMovimiento.cs | 146 | a903f6d3ec23c63945aa71442c8af8b277879ad204d17d35790696a36d570b6b | Versionado | [Software/GRLL/GRLL/Common/TipoMovimiento.cs:1](../../Software/GRLL/GRLL/Common/TipoMovimiento.cs#L1) |
| Software/GRLL/GRLL/Common/TipoMovimientoMapper.cs | 17 | ecb1d200cd5d2b6f270d7e06fb9909ac2b9a86ff68f6df24aeb1f35f769bfae6 | Versionado | [Software/GRLL/GRLL/Common/TipoMovimientoMapper.cs:1](../../Software/GRLL/GRLL/Common/TipoMovimientoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/TipoPermiso.cs | 106 | f5e0352456b7999d80bb51e7d04f9f6aef0b175463592edd47c74816cf4b5cc1 | Versionado | [Software/GRLL/GRLL/Common/TipoPermiso.cs:1](../../Software/GRLL/GRLL/Common/TipoPermiso.cs#L1) |
| Software/GRLL/GRLL/Common/TipoPermisoMapper.cs | 17 | 43794c084815449ed6e2f66f72c1dfc33d546a077671f624384bc5ab2aa6bdaa | Versionado | [Software/GRLL/GRLL/Common/TipoPermisoMapper.cs:1](../../Software/GRLL/GRLL/Common/TipoPermisoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/TipoRecurso.cs | 106 | 7d2f8f77c6f907dda6817458ca49cffcc1349b6d25a6d2154db32c20f050c438 | Versionado | [Software/GRLL/GRLL/Common/TipoRecurso.cs:1](../../Software/GRLL/GRLL/Common/TipoRecurso.cs#L1) |
| Software/GRLL/GRLL/Common/TipoRecursoMapper.cs | 17 | ab4f5db0cd1453e770e354f3503b98de6d60aa0bd00cbe4fa458eb4931f2dacd | Versionado | [Software/GRLL/GRLL/Common/TipoRecursoMapper.cs:1](../../Software/GRLL/GRLL/Common/TipoRecursoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/TipoResolucion.cs | 106 | e821962f6b10f9bbf6b911b91a0648b21d0b1100bd68bf7e2f1643c92d6b6344 | Versionado | [Software/GRLL/GRLL/Common/TipoResolucion.cs:1](../../Software/GRLL/GRLL/Common/TipoResolucion.cs#L1) |
| Software/GRLL/GRLL/Common/TipoResolucionMapper.cs | 17 | 251738dbaba2ecda6ab56eae04ac288e8a9e6f0d3dd0aa70120e25ae1639a73a | Versionado | [Software/GRLL/GRLL/Common/TipoResolucionMapper.cs:1](../../Software/GRLL/GRLL/Common/TipoResolucionMapper.cs#L1) |
| Software/GRLL/GRLL/Common/TipoSangre.cs | 134 | 5de5d035938b20bf7833c696fbf2ecc81e3c0497ad7beafb977a6859cfcfd423 | Versionado | [Software/GRLL/GRLL/Common/TipoSangre.cs:1](../../Software/GRLL/GRLL/Common/TipoSangre.cs#L1) |
| Software/GRLL/GRLL/Common/TipoSangreMapper.cs | 17 | fc5068b283420c01a6aeac8da219fb4605a0158f37b72cfd47b8d1bc65d09bb0 | Versionado | [Software/GRLL/GRLL/Common/TipoSangreMapper.cs:1](../../Software/GRLL/GRLL/Common/TipoSangreMapper.cs#L1) |
| Software/GRLL/GRLL/Common/TipoTrabajador.cs | 126 | f61d469c3316b4099555a2bb3d7981d8dfc8c5bcadf2e9028323b2fc848c008f | Versionado | [Software/GRLL/GRLL/Common/TipoTrabajador.cs:1](../../Software/GRLL/GRLL/Common/TipoTrabajador.cs#L1) |
| Software/GRLL/GRLL/Common/TipoTrabajadorMapper.cs | 17 | e76009c59eba1d216c25f154004218c9288018a57722691415d8fb648ec1f752 | Versionado | [Software/GRLL/GRLL/Common/TipoTrabajadorMapper.cs:1](../../Software/GRLL/GRLL/Common/TipoTrabajadorMapper.cs#L1) |
| Software/GRLL/GRLL/Common/TipoTransaccion.cs | 126 | 4e0dbb217acc73269fa3676f3be3d5c7d7bb3e7f377539b7b3b35646f2b86e79 | Versionado | [Software/GRLL/GRLL/Common/TipoTransaccion.cs:1](../../Software/GRLL/GRLL/Common/TipoTransaccion.cs#L1) |
| Software/GRLL/GRLL/Common/TipoViv.cs | 106 | 5e78e4d1f5fd71c62902500e4a4d3c65f30194e2b65537a8d99e657726dd0395 | Versionado | [Software/GRLL/GRLL/Common/TipoViv.cs:1](../../Software/GRLL/GRLL/Common/TipoViv.cs#L1) |
| Software/GRLL/GRLL/Common/TipoVivMapper.cs | 17 | 900914232168f3dac9db5d8268625bb36222f0911086c40212fe9548ff6d8d75 | Versionado | [Software/GRLL/GRLL/Common/TipoVivMapper.cs:1](../../Software/GRLL/GRLL/Common/TipoVivMapper.cs#L1) |
| Software/GRLL/GRLL/Common/TitulosEmpleado.cs | 179 | 1420b409922a0765637875631fe9c4917fea77c76e421b7ca08e40ecd2b72ae9 | Versionado | [Software/GRLL/GRLL/Common/TitulosEmpleado.cs:1](../../Software/GRLL/GRLL/Common/TitulosEmpleado.cs#L1) |
| Software/GRLL/GRLL/Common/TitulosEmpleadoMapper.cs | 17 | c8d24cb033a04a18477fd697079deb9123f54c60730af49fd19633d57ad2020b | Versionado | [Software/GRLL/GRLL/Common/TitulosEmpleadoMapper.cs:1](../../Software/GRLL/GRLL/Common/TitulosEmpleadoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Tra_Acuerdo.cs | 106 | 5859df8120bc1dd9f158359c612cb601e58bc0118e886d5acb70ae682b6886db | Versionado | [Software/GRLL/GRLL/Common/Tra_Acuerdo.cs:1](../../Software/GRLL/GRLL/Common/Tra_Acuerdo.cs#L1) |
| Software/GRLL/GRLL/Common/Tra_AcuerdoMapper.cs | 17 | 7eb9d7cac4a92a9fcbfd058e7048d427b75b3b4b614c6887aa3891ecbe3e2c35 | Versionado | [Software/GRLL/GRLL/Common/Tra_AcuerdoMapper.cs:1](../../Software/GRLL/GRLL/Common/Tra_AcuerdoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Tra_Articulo_Acuerdo.cs | 178 | 243ad306a44e1186b364962b9a624a36462c7fae36b42d43837de315e30f9150 | Versionado | [Software/GRLL/GRLL/Common/Tra_Articulo_Acuerdo.cs:1](../../Software/GRLL/GRLL/Common/Tra_Articulo_Acuerdo.cs#L1) |
| Software/GRLL/GRLL/Common/Tra_Articulo_AcuerdoMapper.cs | 17 | 9989d0c15c760fbcd07f2255be7e554b14a7d36e047f02d30eaa82993e503eae | Versionado | [Software/GRLL/GRLL/Common/Tra_Articulo_AcuerdoMapper.cs:1](../../Software/GRLL/GRLL/Common/Tra_Articulo_AcuerdoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Tra_ReporteTicketResult.cs | 241 | 5ac9e0c51207e6455416dac834a20cdd11bd95a93feb02a2f1c8d1cd8f201774 | Versionado | [Software/GRLL/GRLL/Common/Tra_ReporteTicketResult.cs:1](../../Software/GRLL/GRLL/Common/Tra_ReporteTicketResult.cs#L1) |
| Software/GRLL/GRLL/Common/Tra_Sp_Validar_Item_EtapaResult.cs | 312 | 7376a7962caab6c01e9d7a876349ef5c30cdcad818ae15feb0f03312ea5af6a4 | Versionado | [Software/GRLL/GRLL/Common/Tra_Sp_Validar_Item_EtapaResult.cs:1](../../Software/GRLL/GRLL/Common/Tra_Sp_Validar_Item_EtapaResult.cs#L1) |
| Software/GRLL/GRLL/Common/TransferenciaBco.cs | 298 | 99d55b4f71af29494db0e88fed7d411d78e539201c951a62556daddf0059f09a | Versionado | [Software/GRLL/GRLL/Common/TransferenciaBco.cs:1](../../Software/GRLL/GRLL/Common/TransferenciaBco.cs#L1) |
| Software/GRLL/GRLL/Common/TransferenciaBcoMapper.cs | 17 | 33fb69e485af967627e17f94c44857a383db027a3d4115b658a29a64f011f94a | Versionado | [Software/GRLL/GRLL/Common/TransferenciaBcoMapper.cs:1](../../Software/GRLL/GRLL/Common/TransferenciaBcoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/TransparentLabel.cs | 139 | b9bc6f748afb8e20f0537f2f0b78dc77bce1d57b666edb51cd0e8fc96be41440 | Versionado | [Software/GRLL/GRLL/Common/TransparentLabel.cs:1](../../Software/GRLL/GRLL/Common/TransparentLabel.cs#L1) |
| Software/GRLL/GRLL/Common/UbicacionViv.cs | 106 | dc3666fbd1a50ad62ae1b2ac796f99548113801b986ede615525a1659dcf9730 | Versionado | [Software/GRLL/GRLL/Common/UbicacionViv.cs:1](../../Software/GRLL/GRLL/Common/UbicacionViv.cs#L1) |
| Software/GRLL/GRLL/Common/UbicacionVivMapper.cs | 17 | 990a78a5c779b0853880d00ce78ad27a36d8993a777309b4852d5d26c2d90f7c | Versionado | [Software/GRLL/GRLL/Common/UbicacionVivMapper.cs:1](../../Software/GRLL/GRLL/Common/UbicacionVivMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Ubigeo.cs | 166 | eda7d35b1d276c11aec62828480378922ab8b14bb4c90756153569ddd4c895e4 | Versionado | [Software/GRLL/GRLL/Common/Ubigeo.cs:1](../../Software/GRLL/GRLL/Common/Ubigeo.cs#L1) |
| Software/GRLL/GRLL/Common/UbigeoMapper.cs | 17 | 1a8da5dd781526a3442283d8fe7f183ada400a7797a459ad187ba750c648ecbb | Versionado | [Software/GRLL/GRLL/Common/UbigeoMapper.cs:1](../../Software/GRLL/GRLL/Common/UbigeoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/UnidMed.cs | 154 | e75fe6f4f0044a1f5ffdf2ca9b2aa4b789bd233a010bd7d25bd1c29790333af1 | Versionado | [Software/GRLL/GRLL/Common/UnidMed.cs:1](../../Software/GRLL/GRLL/Common/UnidMed.cs#L1) |
| Software/GRLL/GRLL/Common/UnidadEquivalencia.cs | 93 | 8e82c936dac556d1955377ffe70bb38f721236b615f486f9c0266ed935583171 | Versionado | [Software/GRLL/GRLL/Common/UnidadEquivalencia.cs:1](../../Software/GRLL/GRLL/Common/UnidadEquivalencia.cs#L1) |
| Software/GRLL/GRLL/Common/UnidadMedida.cs | 154 | a421906fa6b2ee9c46fcd8599d6fff8ba222c4a30579121f653faff24b980224 | Versionado | [Software/GRLL/GRLL/Common/UnidadMedida.cs:1](../../Software/GRLL/GRLL/Common/UnidadMedida.cs#L1) |
| Software/GRLL/GRLL/Common/UnidadMedidaMapper.cs | 17 | 7f92e5bbc6e92e6ed6e8b215730d4fdd19899340ddea55175acb2ff91bcc419f | Versionado | [Software/GRLL/GRLL/Common/UnidadMedidaMapper.cs:1](../../Software/GRLL/GRLL/Common/UnidadMedidaMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Usuario.cs | 283 | 64e458a26af6f2cbbc61bc3b82cc8639869b93443c4693b40b47e8e8d3f26ead | Versionado | [Software/GRLL/GRLL/Common/Usuario.cs:1](../../Software/GRLL/GRLL/Common/Usuario.cs#L1) |
| Software/GRLL/GRLL/Common/UsuarioMapper.cs | 17 | 7db0a1e07d9987a1fd709371105d74f9ccbd81151ce7e1258a67c664c79a92ff | Versionado | [Software/GRLL/GRLL/Common/UsuarioMapper.cs:1](../../Software/GRLL/GRLL/Common/UsuarioMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Usuario_Rol.cs | 158 | f97375d522f44c9c9ea627d329f90c3c454b2a7765223fa93fc094b1dad87e44 | Versionado | [Software/GRLL/GRLL/Common/Usuario_Rol.cs:1](../../Software/GRLL/GRLL/Common/Usuario_Rol.cs#L1) |
| Software/GRLL/GRLL/Common/Usuario_RolMapper.cs | 17 | 5906a65bd0de8ed96c9088d40115ac653a24833aec85ee69a8ae2943802b5d0f | Versionado | [Software/GRLL/GRLL/Common/Usuario_RolMapper.cs:1](../../Software/GRLL/GRLL/Common/Usuario_RolMapper.cs#L1) |
| Software/GRLL/GRLL/Common/VS_ABA_BIENUNIMED.cs | 115 | 49733460045827c0b48911f40f12823787a81d3906411438a31b848a09728ae1 | Versionado | [Software/GRLL/GRLL/Common/VS_ABA_BIENUNIMED.cs:1](../../Software/GRLL/GRLL/Common/VS_ABA_BIENUNIMED.cs#L1) |
| Software/GRLL/GRLL/Common/VS_ABA_BIENUNIMEDMapper.cs | 17 | ef230d05aef387d3bf9d6ffda44015f2aad77ae704e1dc780bf08b7183ab9583 | Versionado | [Software/GRLL/GRLL/Common/VS_ABA_BIENUNIMEDMapper.cs:1](../../Software/GRLL/GRLL/Common/VS_ABA_BIENUNIMEDMapper.cs#L1) |
| Software/GRLL/GRLL/Common/VS_ABA_LISTARBIEN_ALMACEN.cs | 79 | a98e3b7db41fae64a9023e0d077a9677e633e316da2de2fdb40f81c2ceb6a661 | Versionado | [Software/GRLL/GRLL/Common/VS_ABA_LISTARBIEN_ALMACEN.cs:1](../../Software/GRLL/GRLL/Common/VS_ABA_LISTARBIEN_ALMACEN.cs#L1) |
| Software/GRLL/GRLL/Common/VS_ABA_LISTARBIEN_ALMACENMapper.cs | 17 | f8d7293e761b659f28535599fdd9b008f53a0e94135304bfae6aae1f06cc22c4 | Versionado | [Software/GRLL/GRLL/Common/VS_ABA_LISTARBIEN_ALMACENMapper.cs:1](../../Software/GRLL/GRLL/Common/VS_ABA_LISTARBIEN_ALMACENMapper.cs#L1) |
| Software/GRLL/GRLL/Common/VS_ABA_LISTARPROVEEDOR.cs | 97 | d3ed58f6a00165130afabdbfe0b7de87ae5552c3765925de8570a886fa998de9 | Versionado | [Software/GRLL/GRLL/Common/VS_ABA_LISTARPROVEEDOR.cs:1](../../Software/GRLL/GRLL/Common/VS_ABA_LISTARPROVEEDOR.cs#L1) |
| Software/GRLL/GRLL/Common/VS_ABA_LISTARPROVEEDORMapper.cs | 17 | 1f5ceb646551ceea71f37cf550c9ac34bf5cf462f09a52b8cbaba52aac46f67a | Versionado | [Software/GRLL/GRLL/Common/VS_ABA_LISTARPROVEEDORMapper.cs:1](../../Software/GRLL/GRLL/Common/VS_ABA_LISTARPROVEEDORMapper.cs#L1) |
| Software/GRLL/GRLL/Common/VS_ABA_META.cs | 43 | 68d04dffd3fff0533c720b0986f55556e7dd21fd8e31a6de07d4ca5b5c46ed43 | Versionado | [Software/GRLL/GRLL/Common/VS_ABA_META.cs:1](../../Software/GRLL/GRLL/Common/VS_ABA_META.cs#L1) |
| Software/GRLL/GRLL/Common/VS_ABA_METAMapper.cs | 17 | 422809e23e8e4d5b52eb9eda808750758c2ee2b2b3388aa1ad3dc656e56ef7b5 | Versionado | [Software/GRLL/GRLL/Common/VS_ABA_METAMapper.cs:1](../../Software/GRLL/GRLL/Common/VS_ABA_METAMapper.cs#L1) |
| Software/GRLL/GRLL/Common/VS_ABA_NROMAXPERJ.cs | 25 | 88f9b47b2314e3bfbf03de835caea3ec1686c3210dc89687cf3d0cab19d269c7 | Versionado | [Software/GRLL/GRLL/Common/VS_ABA_NROMAXPERJ.cs:1](../../Software/GRLL/GRLL/Common/VS_ABA_NROMAXPERJ.cs#L1) |
| Software/GRLL/GRLL/Common/VS_ABA_NROMAXPERJMapper.cs | 17 | 24c561678e3c849401f9dc07a416ee66505d1a2d0d983bdcd179048757537f9a | Versionado | [Software/GRLL/GRLL/Common/VS_ABA_NROMAXPERJMapper.cs:1](../../Software/GRLL/GRLL/Common/VS_ABA_NROMAXPERJMapper.cs#L1) |
| Software/GRLL/GRLL/Common/VS_ABA_NROMAXPN.cs | 25 | ba699f53dcce0834a76e8219806057ff669a27e2832626acafdb39281663b0da | Versionado | [Software/GRLL/GRLL/Common/VS_ABA_NROMAXPN.cs:1](../../Software/GRLL/GRLL/Common/VS_ABA_NROMAXPN.cs#L1) |
| Software/GRLL/GRLL/Common/VS_TRA_ACUERDO_ARTICULO.cs | 97 | aa31335f069a1bc5b5ac959f2e2744c0a634bb31b8b061170b9486a94ed9d808 | Versionado | [Software/GRLL/GRLL/Common/VS_TRA_ACUERDO_ARTICULO.cs:1](../../Software/GRLL/GRLL/Common/VS_TRA_ACUERDO_ARTICULO.cs#L1) |
| Software/GRLL/GRLL/Common/VS_TRA_ACUERDO_ARTICULOMapper.cs | 17 | 508c37518269a52c456375580635d878982f53230a31fe4fe39d1988d4137274 | Versionado | [Software/GRLL/GRLL/Common/VS_TRA_ACUERDO_ARTICULOMapper.cs:1](../../Software/GRLL/GRLL/Common/VS_TRA_ACUERDO_ARTICULOMapper.cs#L1) |
| Software/GRLL/GRLL/Common/VariableGestion.cs | 146 | 76a071ef0c3f63961ba5eaac9a48617b3db49d72b2f48f7c9085d1c6e0a84495 | Versionado | [Software/GRLL/GRLL/Common/VariableGestion.cs:1](../../Software/GRLL/GRLL/Common/VariableGestion.cs#L1) |
| Software/GRLL/GRLL/Common/Variables.cs | 187 | 4fb87ab8db1c95f9e6023b114ef21652a8db44dcc7fa04b18f7ea4f5a18b675d | Versionado | [Software/GRLL/GRLL/Common/Variables.cs:1](../../Software/GRLL/GRLL/Common/Variables.cs#L1) |
| Software/GRLL/GRLL/Common/VistaNode.cs | 135 | 5f7f3325eded3eb44b210e20277f93ce0d00d8fcea0e822f3cfe764d9bacdc0f | Versionado | [Software/GRLL/GRLL/Common/VistaNode.cs:1](../../Software/GRLL/GRLL/Common/VistaNode.cs#L1) |
| Software/GRLL/GRLL/Common/ViveCon.cs | 106 | a3b555a7080c851c0fd89f596eed2b584c94cefb0ec34a4a09aeb59e8326408d | Versionado | [Software/GRLL/GRLL/Common/ViveCon.cs:1](../../Software/GRLL/GRLL/Common/ViveCon.cs#L1) |
| Software/GRLL/GRLL/Common/ViveConMapper.cs | 17 | e6482aaf50a0039871cf5f2f9a6ec401334cfe2366ea689ccbd60cb133840943 | Versionado | [Software/GRLL/GRLL/Common/ViveConMapper.cs:1](../../Software/GRLL/GRLL/Common/ViveConMapper.cs#L1) |
| Software/GRLL/GRLL/Common/Vivienda.cs | 838 | 11e565a3a3b0fd7629186d7fe2d6bf26b59dd41fcf05ce21e55eaabdd7283caf | Versionado | [Software/GRLL/GRLL/Common/Vivienda.cs:1](../../Software/GRLL/GRLL/Common/Vivienda.cs#L1) |
| Software/GRLL/GRLL/Common/ViviendaMapper.cs | 17 | f2f8b8eec48e0faa9b84bb2d867488a0647da3930dbec159817b1a33ef42ba06 | Versionado | [Software/GRLL/GRLL/Common/ViviendaMapper.cs:1](../../Software/GRLL/GRLL/Common/ViviendaMapper.cs#L1) |
| Software/GRLL/GRLL/Common/aba_sp_Procedimiento_ReqResult.cs | 78 | 49ee4feba69f0e9fc6640e7a22a93f33c47697af0f8303e08dc88e70792944b1 | Versionado | [Software/GRLL/GRLL/Common/aba_sp_Procedimiento_ReqResult.cs:1](../../Software/GRLL/GRLL/Common/aba_sp_Procedimiento_ReqResult.cs#L1) |
| Software/GRLL/GRLL/Common/aba_sp_deta_consolidado_contratoResult.cs | 438 | 587890d545a33cc140b3c38c56749f14ad028e9bc6abb1cc3479eb0cf75986fb | Versionado | [Software/GRLL/GRLL/Common/aba_sp_deta_consolidado_contratoResult.cs:1](../../Software/GRLL/GRLL/Common/aba_sp_deta_consolidado_contratoResult.cs#L1) |
| Software/GRLL/GRLL/Common/aba_vs_Deta_Consolidado_Contrato.cs | 422 | 59cf5b5a06ef01c76b8745d40adae84feab0b8c2170b6750a1f2a1a41ab668d5 | Versionado | [Software/GRLL/GRLL/Common/aba_vs_Deta_Consolidado_Contrato.cs:1](../../Software/GRLL/GRLL/Common/aba_vs_Deta_Consolidado_Contrato.cs#L1) |
| Software/GRLL/GRLL/Common/aba_vs_Deta_Consolidado_ContratoMapper.cs | 17 | a57f0c521fbc23b34ac911bc3c96465e175d3a805eaf573b498320f435454683 | Versionado | [Software/GRLL/GRLL/Common/aba_vs_Deta_Consolidado_ContratoMapper.cs:1](../../Software/GRLL/GRLL/Common/aba_vs_Deta_Consolidado_ContratoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/aba_vs_RecepcionBien.cs | 278 | 48ca810528fd9a58e701aac0cd96533a5d8d701bc3e485834aaf1835f8689806 | Versionado | [Software/GRLL/GRLL/Common/aba_vs_RecepcionBien.cs:1](../../Software/GRLL/GRLL/Common/aba_vs_RecepcionBien.cs#L1) |
| Software/GRLL/GRLL/Common/aba_vs_RecepcionBienMapper.cs | 17 | 75a41cd59aa2fc1690c076e863383897fef9998e669e55d8b09ee0bab1b52b5e | Versionado | [Software/GRLL/GRLL/Common/aba_vs_RecepcionBienMapper.cs:1](../../Software/GRLL/GRLL/Common/aba_vs_RecepcionBienMapper.cs#L1) |
| Software/GRLL/GRLL/Common/aba_vs_financiamiento.cs | 43 | f430f3deed9621babbc110010fe5147a519c46f0b162c0034b8f9cb82e0e2f38 | Versionado | [Software/GRLL/GRLL/Common/aba_vs_financiamiento.cs:1](../../Software/GRLL/GRLL/Common/aba_vs_financiamiento.cs#L1) |
| Software/GRLL/GRLL/Common/aba_vs_financiamientoMapper.cs | 17 | c835d0de04c361808e7ab5dc96b274460b4dff0ff8d541abf245711f648833f1 | Versionado | [Software/GRLL/GRLL/Common/aba_vs_financiamientoMapper.cs:1](../../Software/GRLL/GRLL/Common/aba_vs_financiamientoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/asis_norm.cs | 152 | 70d1490955f178dd005e86c2fe366ac3d054a0911e2f07eba9868bafdaa0bd0f | Versionado | [Software/GRLL/GRLL/Common/asis_norm.cs:1](../../Software/GRLL/GRLL/Common/asis_norm.cs#L1) |
| Software/GRLL/GRLL/Common/clsConexion.cs | 298 | cbdc711a6e19a752f0d2cbe9499952726c820b131acd3fe5fa94cccbbf190804 | Versionado | [Software/GRLL/GRLL/Common/clsConexion.cs:1](../../Software/GRLL/GRLL/Common/clsConexion.cs#L1) |
| Software/GRLL/GRLL/Common/clsLogin.cs | 380 | aac6028bf8161c4bacd760d467d1f235918d4a23e3cdc86ac8ec8ad7f580980a | Versionado | [Software/GRLL/GRLL/Common/clsLogin.cs:1](../../Software/GRLL/GRLL/Common/clsLogin.cs#L1) |
| Software/GRLL/GRLL/Common/clsVariables.cs | 36 | ce08fac9e30df001f9143140a9a8efc2b29d35a07b6ad7e473efa64573f34359 | Versionado | [Software/GRLL/GRLL/Common/clsVariables.cs:1](../../Software/GRLL/GRLL/Common/clsVariables.cs#L1) |
| Software/GRLL/GRLL/Common/dcGRLLDataContext.cs | 3888 | 1b1d8c68202d757b61862cc176ac088ba42aeef0e37dc9ea31641091f634583d | Versionado | [Software/GRLL/GRLL/Common/dcGRLLDataContext.cs:1](../../Software/GRLL/GRLL/Common/dcGRLLDataContext.cs#L1) |
| Software/GRLL/GRLL/Common/fLogin.cs | 426 | 3ed4eaa92d9c629ea0518a1bfb3ecc14f9c603c6707e3785e49d80a4f7f41e8e | Versionado | [Software/GRLL/GRLL/Common/fLogin.cs:1](../../Software/GRLL/GRLL/Common/fLogin.cs#L1) |
| Software/GRLL/GRLL/Common/ficha_personal.cs | 477 | 4b9e450e873e3e86f4b76674a3b3f46bb13d6bd38ab84d0e9b741907d3b7de51 | Versionado | [Software/GRLL/GRLL/Common/ficha_personal.cs:1](../../Software/GRLL/GRLL/Common/ficha_personal.cs#L1) |
| Software/GRLL/GRLL/Common/finalidad.cs | 93 | b21abb153ac6dedfba664aa4e2bf9c6eefb56722f49075a5cbb56e5cd9637119 | Versionado | [Software/GRLL/GRLL/Common/finalidad.cs:1](../../Software/GRLL/GRLL/Common/finalidad.cs#L1) |
| Software/GRLL/GRLL/Common/frmBase.cs | 962 | 057378beda4ef9fe5e286930d86b43f245f97d451f48b0befde3b4906e58fb4c | Versionado | [Software/GRLL/GRLL/Common/frmBase.cs:1](../../Software/GRLL/GRLL/Common/frmBase.cs#L1) |
| Software/GRLL/GRLL/Common/frmBase1.cs | 934 | 8a9ec9211666d6e117325067e7972c3140d5f06ce6b00a6436a658d55f5fe514 | Versionado | [Software/GRLL/GRLL/Common/frmBase1.cs:1](../../Software/GRLL/GRLL/Common/frmBase1.cs#L1) |
| Software/GRLL/GRLL/Common/frmBaseImg.cs | 92 | 63c875ff5344186e63e20903427746cc83caac63238fedf20ecc5f113b949d60 | Versionado | [Software/GRLL/GRLL/Common/frmBaseImg.cs:1](../../Software/GRLL/GRLL/Common/frmBaseImg.cs#L1) |
| Software/GRLL/GRLL/Common/frmBaseMant.cs | 3194 | af2443770ad6fb9be1ce0a3b901732068f998798e03979c10c199ed81f4f930b | Versionado | [Software/GRLL/GRLL/Common/frmBaseMant.cs:1](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L1) |
| Software/GRLL/GRLL/Common/frmMantBaseFTS.cs | 2933 | df34c9cf3f8ec27cdfaf2dd0902aecbdee2b19a02a22178c7b4b73b7eea1c9d3 | Versionado | [Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:1](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L1) |
| Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs | 2479 | 3b81417b184009fafa550298a7eadd068aa157b4ab9c540335b84a8241816d82 | Versionado | [Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs:1](../../Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs#L1) |
| Software/GRLL/GRLL/Common/frmPrueba.cs | 600 | d1e85836b7daba05598fce85c9f6826ae584f3b62731437fade42fd2b381e2da | Versionado | [Software/GRLL/GRLL/Common/frmPrueba.cs:1](../../Software/GRLL/GRLL/Common/frmPrueba.cs#L1) |
| Software/GRLL/GRLL/Common/horarios.cs | 115 | 116e84b5e2721ed24ebf1e05b4332849be33360ed128152f389739a5b88b9084 | Versionado | [Software/GRLL/GRLL/Common/horarios.cs:1](../../Software/GRLL/GRLL/Common/horarios.cs#L1) |
| Software/GRLL/GRLL/Common/marcaciones.cs | 80 | daa638c4314eee4483a6fcbb063cf90a0aada15035130629d24af51baa4eaf5a | Versionado | [Software/GRLL/GRLL/Common/marcaciones.cs:1](../../Software/GRLL/GRLL/Common/marcaciones.cs#L1) |
| Software/GRLL/GRLL/Common/miAlerta.cs | 69 | cb52eaab338c0e38bacc5ca897c689c25aa56c6350bd08fb7dae7d5e33b91168 | Versionado | [Software/GRLL/GRLL/Common/miAlerta.cs:1](../../Software/GRLL/GRLL/Common/miAlerta.cs#L1) |
| Software/GRLL/GRLL/Common/p_ActividadResult.cs | 42 | 9b1d5cd9c3ef491ea99672f3c1d6bf4811f7ca1544f8676c0ba1f084ef20d2f8 | Versionado | [Software/GRLL/GRLL/Common/p_ActividadResult.cs:1](../../Software/GRLL/GRLL/Common/p_ActividadResult.cs#L1) |
| Software/GRLL/GRLL/Common/p_ObjetivoActividadResult.cs | 60 | 6abbea43d7551549d74f518829ff6cf0e369a4543c0a503352e3c7f9f475d20d | Versionado | [Software/GRLL/GRLL/Common/p_ObjetivoActividadResult.cs:1](../../Software/GRLL/GRLL/Common/p_ObjetivoActividadResult.cs#L1) |
| Software/GRLL/GRLL/Common/p_listaEstrategiaObjResult.cs | 42 | 85593192439289ba76d9a33ded336dea9c17d0cf3d54fe48f0b0b4912d40e73b | Versionado | [Software/GRLL/GRLL/Common/p_listaEstrategiaObjResult.cs:1](../../Software/GRLL/GRLL/Common/p_listaEstrategiaObjResult.cs#L1) |
| Software/GRLL/GRLL/Common/spActividad_ExpResult.cs | 366 | 4c4a85b19c58bfb35fac023612298d669a6c0cd74f36f0f20f088d80dcafabbc | Versionado | [Software/GRLL/GRLL/Common/spActividad_ExpResult.cs:1](../../Software/GRLL/GRLL/Common/spActividad_ExpResult.cs#L1) |
| Software/GRLL/GRLL/Common/spActividad_InversPublicMaxResult.cs | 42 | 903d7fff142fca990c612056420819652efa871da83c0d6979d2f6cd8983667e | Versionado | [Software/GRLL/GRLL/Common/spActividad_InversPublicMaxResult.cs:1](../../Software/GRLL/GRLL/Common/spActividad_InversPublicMaxResult.cs#L1) |
| Software/GRLL/GRLL/Common/spActividad_SelectResult.cs | 583 | c4c7539abaca2846ff9ba60ec65e8811b4574f18cd2aa4e8936981748ad329b4 | Versionado | [Software/GRLL/GRLL/Common/spActividad_SelectResult.cs:1](../../Software/GRLL/GRLL/Common/spActividad_SelectResult.cs#L1) |
| Software/GRLL/GRLL/Common/spBien_ExpResult.cs | 222 | 3b2c6f14af4e331c986a0426498f14b5b16f43527c74f2dc28eee061314e21a8 | Versionado | [Software/GRLL/GRLL/Common/spBien_ExpResult.cs:1](../../Software/GRLL/GRLL/Common/spBien_ExpResult.cs#L1) |
| Software/GRLL/GRLL/Common/spBien_SelectResult.cs | 222 | ad13a9b0358cd77b94fa1745b5fd650ca02ab0df1541d58519c49f33b7de9c3e | Versionado | [Software/GRLL/GRLL/Common/spBien_SelectResult.cs:1](../../Software/GRLL/GRLL/Common/spBien_SelectResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJR_BuscarNormaResult.cs | 61 | a6532a99f3d418ea81f3b100c3790b2ffd7453291bbdb00605e3ded6bb173304 | Versionado | [Software/GRLL/GRLL/Common/spCJR_BuscarNormaResult.cs:1](../../Software/GRLL/GRLL/Common/spCJR_BuscarNormaResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJR_BuscarPresetIniciaResult.cs | 133 | d30379299ff807235a262faa4fe909cbc53124e9c5010659fe8f5466bf6580e9 | Versionado | [Software/GRLL/GRLL/Common/spCJR_BuscarPresetIniciaResult.cs:1](../../Software/GRLL/GRLL/Common/spCJR_BuscarPresetIniciaResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJR_BuscarProyNormativoResult.cs | 78 | 26792f52310241334c90748fce926292219137a269f9133ada99083b41840414 | Versionado | [Software/GRLL/GRLL/Common/spCJR_BuscarProyNormativoResult.cs:1](../../Software/GRLL/GRLL/Common/spCJR_BuscarProyNormativoResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJR_Rep_AcuerdosResult.cs | 78 | 61da09c0e2b30c76cb86a7773eeca3dca74376ea6ad3a6f6a00797bdd8d167db | Versionado | [Software/GRLL/GRLL/Common/spCJR_Rep_AcuerdosResult.cs:1](../../Software/GRLL/GRLL/Common/spCJR_Rep_AcuerdosResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJR_Report_GeneralResult.cs | 601 | 5c8458d2f0be9671a240a1f93e814eea03e4165da8dec5722a6599d1112f4d60 | Versionado | [Software/GRLL/GRLL/Common/spCJR_Report_GeneralResult.cs:1](../../Software/GRLL/GRLL/Common/spCJR_Report_GeneralResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJR_Report_OfiTemaResult.cs | 42 | d08f6588816d8b34ab11e6a506ecdbc026f7fc60fd4fd6356214a925048da387 | Versionado | [Software/GRLL/GRLL/Common/spCJR_Report_OfiTemaResult.cs:1](../../Software/GRLL/GRLL/Common/spCJR_Report_OfiTemaResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJR_llenarDictamenesResult.cs | 115 | 3ee2bae265832bfb25a4747b2b41ee9d4973ba021ab4967dd2719d46ec329fd7 | Versionado | [Software/GRLL/GRLL/Common/spCJR_llenarDictamenesResult.cs:1](../../Software/GRLL/GRLL/Common/spCJR_llenarDictamenesResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJR_llenarEmpleadosResult.cs | 42 | 123c085263878753ab0b6088dec44031621c9febbce1ef0f23d8580e4fb238df | Versionado | [Software/GRLL/GRLL/Common/spCJR_llenarEmpleadosResult.cs:1](../../Software/GRLL/GRLL/Common/spCJR_llenarEmpleadosResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJR_llenarIniciativaResult.cs | 169 | f5eb4dd1a3ca55993e774bdb380085bf6afacba37c6ac3666f41e1c96c05ccad | Versionado | [Software/GRLL/GRLL/Common/spCJR_llenarIniciativaResult.cs:1](../../Software/GRLL/GRLL/Common/spCJR_llenarIniciativaResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJR_llenarNormaRegionalResult.cs | 133 | 19569f17674653a2fd6072c61f23489008c267a782d9e3111cdc5a419d63cb1f | Versionado | [Software/GRLL/GRLL/Common/spCJR_llenarNormaRegionalResult.cs:1](../../Software/GRLL/GRLL/Common/spCJR_llenarNormaRegionalResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJR_llenarNotificacionesResult.cs | 61 | 673e54491b279a6f92640fa5cd22aaffa1ad53ec0d6600cf8d3fec4828088c96 | Versionado | [Software/GRLL/GRLL/Common/spCJR_llenarNotificacionesResult.cs:1](../../Software/GRLL/GRLL/Common/spCJR_llenarNotificacionesResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJR_llenarObservacionNormaResult.cs | 61 | c00f29b1e2d77f542efe3dc2eab564ccf4d6ba7540db5ee64c4c72918eb3e76c | Versionado | [Software/GRLL/GRLL/Common/spCJR_llenarObservacionNormaResult.cs:1](../../Software/GRLL/GRLL/Common/spCJR_llenarObservacionNormaResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJR_llenarOfiTrasladoResult.cs | 43 | 02bad45d141b2bfc309c7a832da1ce965f1bbd35faac50dedf01a31378aeba3b | Versionado | [Software/GRLL/GRLL/Common/spCJR_llenarOfiTrasladoResult.cs:1](../../Software/GRLL/GRLL/Common/spCJR_llenarOfiTrasladoResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJR_llenarOperadoresActivosResult.cs | 60 | 4718b8248b7380681f0ffa5726519556b0708ff9e937cb3cc4550a6d2db90af9 | Versionado | [Software/GRLL/GRLL/Common/spCJR_llenarOperadoresActivosResult.cs:1](../../Software/GRLL/GRLL/Common/spCJR_llenarOperadoresActivosResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJR_llenarOperadoresResult.cs | 60 | f6f1a61c73d0fd76cd218d6cb6c634e4d2e0f86e30d79a445e5fbb5b794274fd | Versionado | [Software/GRLL/GRLL/Common/spCJR_llenarOperadoresResult.cs:1](../../Software/GRLL/GRLL/Common/spCJR_llenarOperadoresResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJR_llenarPromulgacionesResult.cs | 61 | 84abfe0538cab4ee4643ebc83f79151f44ae2933422249bb333f333cca1fc95d | Versionado | [Software/GRLL/GRLL/Common/spCJR_llenarPromulgacionesResult.cs:1](../../Software/GRLL/GRLL/Common/spCJR_llenarPromulgacionesResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJR_llenarProyNormativoResult.cs | 150 | e87870066ead7dbe50366c053e68e0be4befb8549adddfaf2825ccc97eb30f52 | Versionado | [Software/GRLL/GRLL/Common/spCJR_llenarProyNormativoResult.cs:1](../../Software/GRLL/GRLL/Common/spCJR_llenarProyNormativoResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJR_llenarPublicacionesResult.cs | 151 | 033f13b9e044521c8301f8da49602068c9bed8b535129e27a9f4a532f0e79154 | Versionado | [Software/GRLL/GRLL/Common/spCJR_llenarPublicacionesResult.cs:1](../../Software/GRLL/GRLL/Common/spCJR_llenarPublicacionesResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJR_llenarSesionesResult.cs | 97 | f0ef610d9f0809be329a6fd7d466312d6356b87a244cce664b3ed39e5679b2aa | Versionado | [Software/GRLL/GRLL/Common/spCJR_llenarSesionesResult.cs:1](../../Software/GRLL/GRLL/Common/spCJR_llenarSesionesResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJR_llenarSolLegalResult.cs | 78 | 210530f9c91d044de89303f5e61fdeb2a75f043df603f7cf92bd7c05910c5dde | Versionado | [Software/GRLL/GRLL/Common/spCJR_llenarSolLegalResult.cs:1](../../Software/GRLL/GRLL/Common/spCJR_llenarSolLegalResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJR_llenarSolPubliNormaResult.cs | 61 | a6035c9d8f0e36b6fa1a534b1fb6cd1b5204dea88a95ab7f892b09a48da05efd | Versionado | [Software/GRLL/GRLL/Common/spCJR_llenarSolPubliNormaResult.cs:1](../../Software/GRLL/GRLL/Common/spCJR_llenarSolPubliNormaResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJR_llenarSolTecResult.cs | 78 | 24f05873ff0bf00c86e3d20b4bd8acfbaec9a6f1b4b111ef89b71ffabc9009cb | Versionado | [Software/GRLL/GRLL/Common/spCJR_llenarSolTecResult.cs:1](../../Software/GRLL/GRLL/Common/spCJR_llenarSolTecResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJ_Banco_SelectResult.cs | 96 | 158b0177322bc2a449701fa0651e9478b0ac760f5b1f09f9d8da01aed4d6b524 | Versionado | [Software/GRLL/GRLL/Common/spCJ_Banco_SelectResult.cs:1](../../Software/GRLL/GRLL/Common/spCJ_Banco_SelectResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJ_ChequeCaj_SelectResult.cs | 222 | 666a4afd3968e20d1d5691ad38f0bb65acda37f51f6a3bbcbe7543bd64f61532 | Versionado | [Software/GRLL/GRLL/Common/spCJ_ChequeCaj_SelectResult.cs:1](../../Software/GRLL/GRLL/Common/spCJ_ChequeCaj_SelectResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJ_FacturaCaj_SelectFechResult.cs | 330 | d2e5f79f687533a99705f8c37dd3ec63896b847a8494cb104d60d2bb9a048138 | Versionado | [Software/GRLL/GRLL/Common/spCJ_FacturaCaj_SelectFechResult.cs:1](../../Software/GRLL/GRLL/Common/spCJ_FacturaCaj_SelectFechResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJ_FacturaCaj_SelectProvResult.cs | 330 | f179ee3ebf1c92e8983f65e08bc5f08c33e26ec6ba3684ec32950650d117fa32 | Versionado | [Software/GRLL/GRLL/Common/spCJ_FacturaCaj_SelectProvResult.cs:1](../../Software/GRLL/GRLL/Common/spCJ_FacturaCaj_SelectProvResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJ_FacturaCaj_SelectResult.cs | 330 | 5a566698894b9e798fccf1e4433d46264b5834d9cddcce60401c05d505e7142b | Versionado | [Software/GRLL/GRLL/Common/spCJ_FacturaCaj_SelectResult.cs:1](../../Software/GRLL/GRLL/Common/spCJ_FacturaCaj_SelectResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJ_IngresoCaj_CON_PapeletaResult.cs | 276 | ffa263bf8de5c8296d7141b49a88b09f8c81e0a83b589577b3534378b163a3d6 | Versionado | [Software/GRLL/GRLL/Common/spCJ_IngresoCaj_CON_PapeletaResult.cs:1](../../Software/GRLL/GRLL/Common/spCJ_IngresoCaj_CON_PapeletaResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJ_IngresoCaj_SIN_PapeletaResult.cs | 276 | 59007f9893f994a4a4c17f65b806426347fc85898e5c4d65e75527d5e3b64c08 | Versionado | [Software/GRLL/GRLL/Common/spCJ_IngresoCaj_SIN_PapeletaResult.cs:1](../../Software/GRLL/GRLL/Common/spCJ_IngresoCaj_SIN_PapeletaResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJ_IngresoCaj_SelectFechResult.cs | 564 | 38134ea785c2968e9a2458f34a1e9683a01269a365816b726e32e7ebe8844c9f | Versionado | [Software/GRLL/GRLL/Common/spCJ_IngresoCaj_SelectFechResult.cs:1](../../Software/GRLL/GRLL/Common/spCJ_IngresoCaj_SelectFechResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJ_IngresoCaj_SelectResult.cs | 564 | 235476edaadf5d3f535e6eb1d449d87fed70f2397aa9529532c1e186be3ab621 | Versionado | [Software/GRLL/GRLL/Common/spCJ_IngresoCaj_SelectResult.cs:1](../../Software/GRLL/GRLL/Common/spCJ_IngresoCaj_SelectResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJ_NroCuenta_SelectResult.cs | 150 | 5b5f9d39e022cd684be6f927ed40836a9d3776e30a7fdc501141ad4da2da30da | Versionado | [Software/GRLL/GRLL/Common/spCJ_NroCuenta_SelectResult.cs:1](../../Software/GRLL/GRLL/Common/spCJ_NroCuenta_SelectResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJ_PapeletDepositCajSelectFFResult.cs | 258 | b155d6d03a7e674351992c2b1f82c16e040fe3d9f81ab366c59e98294c47d1ab | Versionado | [Software/GRLL/GRLL/Common/spCJ_PapeletDepositCajSelectFFResult.cs:1](../../Software/GRLL/GRLL/Common/spCJ_PapeletDepositCajSelectFFResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJ_PapeletDepositCajSelectFResult.cs | 258 | d697dfdd944fea175a7ecff0b4e9ef9805f07ab74d4aca1b25fc529ac89e4241 | Versionado | [Software/GRLL/GRLL/Common/spCJ_PapeletDepositCajSelectFResult.cs:1](../../Software/GRLL/GRLL/Common/spCJ_PapeletDepositCajSelectFResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJ_PapeletDepositCajSelectNroPResult.cs | 258 | a0f0980865ff3ac3a1869a3fca81b090f37e5e20b7851a421878bbc395c2040f | Versionado | [Software/GRLL/GRLL/Common/spCJ_PapeletDepositCajSelectNroPResult.cs:1](../../Software/GRLL/GRLL/Common/spCJ_PapeletDepositCajSelectNroPResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJ_Persona_SelectResult.cs | 240 | a8b6fc586a676f5358615ec3c0d8866401117b02c6718ccbaa66ec03ea96e758 | Versionado | [Software/GRLL/GRLL/Common/spCJ_Persona_SelectResult.cs:1](../../Software/GRLL/GRLL/Common/spCJ_Persona_SelectResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJ_RefSIAF_SelectResult.cs | 132 | bfe048279c634eff07fc213a3fa9d39d72414d4813b462ab8fe91e595451e4cb | Versionado | [Software/GRLL/GRLL/Common/spCJ_RefSIAF_SelectResult.cs:1](../../Software/GRLL/GRLL/Common/spCJ_RefSIAF_SelectResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJ_TipoMoneda_SelectResult.cs | 60 | 64b60d0980f88ce01c2e4615de84be42cc36bba2b1f26d959bb523a35e7d31fe | Versionado | [Software/GRLL/GRLL/Common/spCJ_TipoMoneda_SelectResult.cs:1](../../Software/GRLL/GRLL/Common/spCJ_TipoMoneda_SelectResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJ_TipoMoneda_Select_GridResult.cs | 78 | a522a964aaa8e6ed7ffa4ddbb334ef2f3b65f822cab70822b6f9b207542fd9e0 | Versionado | [Software/GRLL/GRLL/Common/spCJ_TipoMoneda_Select_GridResult.cs:1](../../Software/GRLL/GRLL/Common/spCJ_TipoMoneda_Select_GridResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJ_TransferenciaBco_SelectResult.cs | 222 | de19819de1298e4c446c28fc07d7f738bcc6a7609ad88df9d86cfebb25b2ce31 | Versionado | [Software/GRLL/GRLL/Common/spCJ_TransferenciaBco_SelectResult.cs:1](../../Software/GRLL/GRLL/Common/spCJ_TransferenciaBco_SelectResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJ_vClasificadorIngresoResult.cs | 204 | 19a954fc1da67d25486c6841d982c10a1140d3ee36dc24cef002d933cbe831d2 | Versionado | [Software/GRLL/GRLL/Common/spCJ_vClasificadorIngresoResult.cs:1](../../Software/GRLL/GRLL/Common/spCJ_vClasificadorIngresoResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJ_vClasificadorIngreso_LstResult.cs | 204 | 9a8be32decff36b6a8a651e7e0ee5055154384a3767755886331a6decf60bc2c | Versionado | [Software/GRLL/GRLL/Common/spCJ_vClasificadorIngreso_LstResult.cs:1](../../Software/GRLL/GRLL/Common/spCJ_vClasificadorIngreso_LstResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJ_vPlanMayorResult.cs | 168 | e0acdfb1f35803b929e7eb9754a5ec58573392b090af11a451c037b4f99be6a1 | Versionado | [Software/GRLL/GRLL/Common/spCJ_vPlanMayorResult.cs:1](../../Software/GRLL/GRLL/Common/spCJ_vPlanMayorResult.cs#L1) |
| Software/GRLL/GRLL/Common/spCJ_vPlanMayor_LstResult.cs | 168 | b4c68f5cd582b17e29bbd2d138f57554362f71d520da91d140ca17263ac4295a | Versionado | [Software/GRLL/GRLL/Common/spCJ_vPlanMayor_LstResult.cs:1](../../Software/GRLL/GRLL/Common/spCJ_vPlanMayor_LstResult.cs#L1) |
| Software/GRLL/GRLL/Common/spEmpleaditoResult.cs | 42 | 79fb7aa7a37b2007032decd1b3b8f2f829bd35230e2c9d4da2b15641c5c15408 | Versionado | [Software/GRLL/GRLL/Common/spEmpleaditoResult.cs:1](../../Software/GRLL/GRLL/Common/spEmpleaditoResult.cs#L1) |
| Software/GRLL/GRLL/Common/spEmpleado_ExpResult.cs | 368 | cef5f715814796680d53366057d39a0487ded8e3dd449bbc724e5abd324f342a | Versionado | [Software/GRLL/GRLL/Common/spEmpleado_ExpResult.cs:1](../../Software/GRLL/GRLL/Common/spEmpleado_ExpResult.cs#L1) |
| Software/GRLL/GRLL/Common/spEmpleado_NotIn_All_Solo_PlaResult.cs | 367 | 606be143597f82ddb39f2ae4d51e448f444e5ddcbc2463c8ca30d484bce4ba36 | Versionado | [Software/GRLL/GRLL/Common/spEmpleado_NotIn_All_Solo_PlaResult.cs:1](../../Software/GRLL/GRLL/Common/spEmpleado_NotIn_All_Solo_PlaResult.cs#L1) |
| Software/GRLL/GRLL/Common/spEmpleado_SNP_Select_NotInResult.cs | 114 | 5ccf8afed007d139b2002dd951af060d67baa44492d23c1c344fe647c056b00e | Versionado | [Software/GRLL/GRLL/Common/spEmpleado_SNP_Select_NotInResult.cs:1](../../Software/GRLL/GRLL/Common/spEmpleado_SNP_Select_NotInResult.cs#L1) |
| Software/GRLL/GRLL/Common/spEmpleado_SNP_Select_NotIn_AllResult.cs | 96 | 4170b4113a806e42b3b0de288b361271ddf07d038a58a8a2212f5e0a77df57db | Versionado | [Software/GRLL/GRLL/Common/spEmpleado_SNP_Select_NotIn_AllResult.cs:1](../../Software/GRLL/GRLL/Common/spEmpleado_SNP_Select_NotIn_AllResult.cs#L1) |
| Software/GRLL/GRLL/Common/spEmpleado_SelectResult.cs | 312 | be0ca4f825d6fff744e952de35e7575c42772096098a7fc1eedfe3e889ddb687 | Versionado | [Software/GRLL/GRLL/Common/spEmpleado_SelectResult.cs:1](../../Software/GRLL/GRLL/Common/spEmpleado_SelectResult.cs#L1) |
| Software/GRLL/GRLL/Common/spEmpleado_Select_Activ_UOResult.cs | 330 | 68b409c888f196f75f8349c894e66614dee2b6752d80f4dbc4227488500cf0f7 | Versionado | [Software/GRLL/GRLL/Common/spEmpleado_Select_Activ_UOResult.cs:1](../../Software/GRLL/GRLL/Common/spEmpleado_Select_Activ_UOResult.cs#L1) |
| Software/GRLL/GRLL/Common/spEmpleado_Select_NotInResult.cs | 96 | 2eac96b1b8c5e7e3bab066607c893f89beb222431a3b414dd2acdcd8fddff09a | Versionado | [Software/GRLL/GRLL/Common/spEmpleado_Select_NotInResult.cs:1](../../Software/GRLL/GRLL/Common/spEmpleado_Select_NotInResult.cs#L1) |
| Software/GRLL/GRLL/Common/spEstrategia_ExpResult.cs | 132 | ff3a6c2ea0bb9988f2559c802df189df990edfb9eb2cc39f708995a8e055af6d | Versionado | [Software/GRLL/GRLL/Common/spEstrategia_ExpResult.cs:1](../../Software/GRLL/GRLL/Common/spEstrategia_ExpResult.cs#L1) |
| Software/GRLL/GRLL/Common/spEstrategia_SelectResult.cs | 133 | 955eb47bac5ea5c42c08c8985783b69a8a98e49e0b3b9fd8ba60e36471281798 | Versionado | [Software/GRLL/GRLL/Common/spEstrategia_SelectResult.cs:1](../../Software/GRLL/GRLL/Common/spEstrategia_SelectResult.cs#L1) |
| Software/GRLL/GRLL/Common/spEstructOrganiz_ExpResult.cs | 312 | 83aa17c606c40b8b555b5b36df24f926cfc1012c1270576b445efc333d08c7dd | Versionado | [Software/GRLL/GRLL/Common/spEstructOrganiz_ExpResult.cs:1](../../Software/GRLL/GRLL/Common/spEstructOrganiz_ExpResult.cs#L1) |
| Software/GRLL/GRLL/Common/spEstructOrganiz_SelectResult.cs | 780 | 321f0d26ba27a7fa8f41a7268c536a898aaaff8894679795701d9ea0649434c3 | Versionado | [Software/GRLL/GRLL/Common/spEstructOrganiz_SelectResult.cs:1](../../Software/GRLL/GRLL/Common/spEstructOrganiz_SelectResult.cs#L1) |
| Software/GRLL/GRLL/Common/spEstructOrganiz_Select_LstResult.cs | 42 | cb44cd1b8ed0a17d15c0375d1ae6d4d28fb7cf1311ffe488ae72d4bedfdd6aeb | Versionado | [Software/GRLL/GRLL/Common/spEstructOrganiz_Select_LstResult.cs:1](../../Software/GRLL/GRLL/Common/spEstructOrganiz_Select_LstResult.cs#L1) |
| Software/GRLL/GRLL/Common/spFinanciamiento_ExpResult.cs | 42 | fcdf1791bd5b740b67f1852fafdd47e1217449c78b441c101dbe7af394445457 | Versionado | [Software/GRLL/GRLL/Common/spFinanciamiento_ExpResult.cs:1](../../Software/GRLL/GRLL/Common/spFinanciamiento_ExpResult.cs#L1) |
| Software/GRLL/GRLL/Common/spFinanciamiento_SelectResult.cs | 42 | b6b615ca8dc41014b8d33ccd590cf3c02c394360684ad052f95dee646343286f | Versionado | [Software/GRLL/GRLL/Common/spFinanciamiento_SelectResult.cs:1](../../Software/GRLL/GRLL/Common/spFinanciamiento_SelectResult.cs#L1) |
| Software/GRLL/GRLL/Common/spInversPublica_ExpResult.cs | 78 | 91c1f34ef8050bd92cadb1a4682a33a4905edfcfff09afd2d0b8931a223f9598 | Versionado | [Software/GRLL/GRLL/Common/spInversPublica_ExpResult.cs:1](../../Software/GRLL/GRLL/Common/spInversPublica_ExpResult.cs#L1) |
| Software/GRLL/GRLL/Common/spInversPublica_SelectResult.cs | 78 | 90ad02dd527c40379f02540f39ce1228ec85ecf97e498ebbaaedfc17268c049f | Versionado | [Software/GRLL/GRLL/Common/spInversPublica_SelectResult.cs:1](../../Software/GRLL/GRLL/Common/spInversPublica_SelectResult.cs#L1) |
| Software/GRLL/GRLL/Common/spInversXFuentFResult.cs | 24 | fdd113cb6c3d11d4e6435fbb72e6ebaa8960d8425c3de9ebff1fc0308b1a5c56 | Versionado | [Software/GRLL/GRLL/Common/spInversXFuentFResult.cs:1](../../Software/GRLL/GRLL/Common/spInversXFuentFResult.cs#L1) |
| Software/GRLL/GRLL/Common/spInversXFuentF_ExpResult.cs | 60 | 74ae2ff78cc11d4dd58ce669eebda1f05d82e85481f25f294bbb897834cb6192 | Versionado | [Software/GRLL/GRLL/Common/spInversXFuentF_ExpResult.cs:1](../../Software/GRLL/GRLL/Common/spInversXFuentF_ExpResult.cs#L1) |
| Software/GRLL/GRLL/Common/spInversXFuentF_SelectResult.cs | 60 | d133ad99d2211336261af17f8f2cac4f3fe39a2b5033ffb484aecddf1f773726 | Versionado | [Software/GRLL/GRLL/Common/spInversXFuentF_SelectResult.cs:1](../../Software/GRLL/GRLL/Common/spInversXFuentF_SelectResult.cs#L1) |
| Software/GRLL/GRLL/Common/spKM_GetNextVideoPlayAvisoResult.cs | 132 | 4a26eea27aac0611bc421d8a8e9dd67f6e489cd2570d52cb91fb5a3626e3efcb | Versionado | [Software/GRLL/GRLL/Common/spKM_GetNextVideoPlayAvisoResult.cs:1](../../Software/GRLL/GRLL/Common/spKM_GetNextVideoPlayAvisoResult.cs#L1) |
| Software/GRLL/GRLL/Common/spKM_GetNextVideoPlayPrincResult.cs | 132 | 884d6e6e99a4b14eb448b5005d7a7d297c961e8fb1cb51abcad2a7746ef51fc3 | Versionado | [Software/GRLL/GRLL/Common/spKM_GetNextVideoPlayPrincResult.cs:1](../../Software/GRLL/GRLL/Common/spKM_GetNextVideoPlayPrincResult.cs#L1) |
| Software/GRLL/GRLL/Common/spKM_GetPlayAvisoResult.cs | 114 | dbdbe3529f0ba2dbc482251bb5ca5e828fd231cdfe5dcbabb0d2ed343d7d77df | Versionado | [Software/GRLL/GRLL/Common/spKM_GetPlayAvisoResult.cs:1](../../Software/GRLL/GRLL/Common/spKM_GetPlayAvisoResult.cs#L1) |
| Software/GRLL/GRLL/Common/spKM_GetPlayPrincResult.cs | 132 | 45cd623a21087d0e1f53ddd46e097dbe0cb2ae1f4864197acb690bb0bcf3ce65 | Versionado | [Software/GRLL/GRLL/Common/spKM_GetPlayPrincResult.cs:1](../../Software/GRLL/GRLL/Common/spKM_GetPlayPrincResult.cs#L1) |
| Software/GRLL/GRLL/Common/spKM_GetSgtColaResult.cs | 277 | 131cb9191c55bf89d12ccc75fdb50053114247dbdf7d068c4bfb308e7ea712e4 | Versionado | [Software/GRLL/GRLL/Common/spKM_GetSgtColaResult.cs:1](../../Software/GRLL/GRLL/Common/spKM_GetSgtColaResult.cs#L1) |
| Software/GRLL/GRLL/Common/spKM_GetVideoListResult.cs | 96 | 973237f9c2312d58f2f1cb95a06de571f8e31dc9fb0f28c51982d444ed42c683 | Versionado | [Software/GRLL/GRLL/Common/spKM_GetVideoListResult.cs:1](../../Software/GRLL/GRLL/Common/spKM_GetVideoListResult.cs#L1) |
| Software/GRLL/GRLL/Common/spKM_RepMensajesResult.cs | 79 | 91de2e4859f71b8b6e78a79ff83e3043972d905a61bac36f00535023c20a2cfa | Versionado | [Software/GRLL/GRLL/Common/spKM_RepMensajesResult.cs:1](../../Software/GRLL/GRLL/Common/spKM_RepMensajesResult.cs#L1) |
| Software/GRLL/GRLL/Common/spKM_RepVideosResult.cs | 79 | ba6b5653db357cdae32b1e1b671b5aa36f08470ec08ceb39fdf0fd2fef6ac7d2 | Versionado | [Software/GRLL/GRLL/Common/spKM_RepVideosResult.cs:1](../../Software/GRLL/GRLL/Common/spKM_RepVideosResult.cs#L1) |
| Software/GRLL/GRLL/Common/spKM_ReportPersAtendxCajResult.cs | 60 | c4123c84d35f372868e7c8c1fcf9e46bf587c4f39aa7aa5051faa1d1a2a670ab | Versionado | [Software/GRLL/GRLL/Common/spKM_ReportPersAtendxCajResult.cs:1](../../Software/GRLL/GRLL/Common/spKM_ReportPersAtendxCajResult.cs#L1) |
| Software/GRLL/GRLL/Common/spKM_repAtencionResult.cs | 151 | c9c9f993b8a39826b15afb35689b0bac3a87c56533b3c768cf782aa30676dad2 | Versionado | [Software/GRLL/GRLL/Common/spKM_repAtencionResult.cs:1](../../Software/GRLL/GRLL/Common/spKM_repAtencionResult.cs#L1) |
| Software/GRLL/GRLL/Common/spKM_repTiempoAtencionResult.cs | 259 | f9dd5ce9e10c78a613805077a8f0e6615748720bd79184fee7af985b9d81d5e7 | Versionado | [Software/GRLL/GRLL/Common/spKM_repTiempoAtencionResult.cs:1](../../Software/GRLL/GRLL/Common/spKM_repTiempoAtencionResult.cs#L1) |
| Software/GRLL/GRLL/Common/spKM_repTipoTramiteResult.cs | 61 | fd1e46ef08bb75ce92050c96674ec78d5cba949d426f8b6c4124eba40a6c59ec | Versionado | [Software/GRLL/GRLL/Common/spKM_repTipoTramiteResult.cs:1](../../Software/GRLL/GRLL/Common/spKM_repTipoTramiteResult.cs#L1) |
| Software/GRLL/GRLL/Common/spKM_repTotalAtendidosResult.cs | 79 | d1c1bb50b17892b015a3c0b24a0dbc1cf3077eeab092751c87fd9edd42f9110a | Versionado | [Software/GRLL/GRLL/Common/spKM_repTotalAtendidosResult.cs:1](../../Software/GRLL/GRLL/Common/spKM_repTotalAtendidosResult.cs#L1) |
| Software/GRLL/GRLL/Common/spLimit_Recomen_Logro_PrintResult.cs | 60 | fae3ae647a8cff7297c6eeefd622c8edfa0a9772823f89f3398ef68790ddb72e | Versionado | [Software/GRLL/GRLL/Common/spLimit_Recomen_Logro_PrintResult.cs:1](../../Software/GRLL/GRLL/Common/spLimit_Recomen_Logro_PrintResult.cs#L1) |
| Software/GRLL/GRLL/Common/spLimitacion_ExpResult.cs | 42 | a20976a61ee3e618b96c34e202489b82c4f5dac5fcb5bc5de8bfdc622c1b7305 | Versionado | [Software/GRLL/GRLL/Common/spLimitacion_ExpResult.cs:1](../../Software/GRLL/GRLL/Common/spLimitacion_ExpResult.cs#L1) |
| Software/GRLL/GRLL/Common/spLimitacion_Recomendacion_TVResult.cs | 114 | ea787ae08795748b8349efcb7583c0aec17035e6e93e32dad508928f00150703 | Versionado | [Software/GRLL/GRLL/Common/spLimitacion_Recomendacion_TVResult.cs:1](../../Software/GRLL/GRLL/Common/spLimitacion_Recomendacion_TVResult.cs#L1) |
| Software/GRLL/GRLL/Common/spLimitacion_SelectResult.cs | 42 | d0a2fa8d305d114c6363aab74b220e9af86776a74aaf08f0cc12134cbcde4db9 | Versionado | [Software/GRLL/GRLL/Common/spLimitacion_SelectResult.cs:1](../../Software/GRLL/GRLL/Common/spLimitacion_SelectResult.cs#L1) |
| Software/GRLL/GRLL/Common/spLogrosLimitacion_TVResult.cs | 42 | a15e8861ce67a64e220747ead5def34687f9bf1fc59cea4bc7786e2d23668d6d | Versionado | [Software/GRLL/GRLL/Common/spLogrosLimitacion_TVResult.cs:1](../../Software/GRLL/GRLL/Common/spLogrosLimitacion_TVResult.cs#L1) |
| Software/GRLL/GRLL/Common/spLogros_ExpResult.cs | 96 | 032d5be56ad5f61baf30299d4aa37a74b047e17b25a11f49b3fdc6dea9aa1fae | Versionado | [Software/GRLL/GRLL/Common/spLogros_ExpResult.cs:1](../../Software/GRLL/GRLL/Common/spLogros_ExpResult.cs#L1) |
| Software/GRLL/GRLL/Common/spLogros_Limitacion_TVResult.cs | 114 | 6c21e96a66583d767e8e3249451420267a997b4b550371b850e01fea55bc04e5 | Versionado | [Software/GRLL/GRLL/Common/spLogros_Limitacion_TVResult.cs:1](../../Software/GRLL/GRLL/Common/spLogros_Limitacion_TVResult.cs#L1) |
| Software/GRLL/GRLL/Common/spLogros_SelectResult.cs | 96 | f028f0656a9a176c4d705cbe2e3be8f0862c49d822482a001c901bc62209bcca | Versionado | [Software/GRLL/GRLL/Common/spLogros_SelectResult.cs:1](../../Software/GRLL/GRLL/Common/spLogros_SelectResult.cs#L1) |
| Software/GRLL/GRLL/Common/spMeses_SelectResult.cs | 42 | 22e74c303fea893566c7eae8f4c308127dd2b1b04112a2f439315679b1923193 | Versionado | [Software/GRLL/GRLL/Common/spMeses_SelectResult.cs:1](../../Software/GRLL/GRLL/Common/spMeses_SelectResult.cs#L1) |
| Software/GRLL/GRLL/Common/spObjet_Avance_SelectResult.cs | 384 | 515e082177c4fe6c838b7100d4bfe30ce7d6184fa898e75b0868b9178467003f | Versionado | [Software/GRLL/GRLL/Common/spObjet_Avance_SelectResult.cs:1](../../Software/GRLL/GRLL/Common/spObjet_Avance_SelectResult.cs#L1) |
| Software/GRLL/GRLL/Common/spObjetivo_ExpResult.cs | 240 | f7ce71d88af7d7d301e880bfe80c4450016f10f2dafe47dae743fa55355b5aa1 | Versionado | [Software/GRLL/GRLL/Common/spObjetivo_ExpResult.cs:1](../../Software/GRLL/GRLL/Common/spObjetivo_ExpResult.cs#L1) |
| Software/GRLL/GRLL/Common/spObjetivo_SelectResult.cs | 385 | d0bc7cd52f97f0f195eb571aa864b8ec187c0e3d066010218516cf9b8d12bd43 | Versionado | [Software/GRLL/GRLL/Common/spObjetivo_SelectResult.cs:1](../../Software/GRLL/GRLL/Common/spObjetivo_SelectResult.cs#L1) |
| Software/GRLL/GRLL/Common/spParametrosTrabResult.cs | 42 | 8aa87ccd7090f1ad681026ec921b4e4a9c0ba9607cf34300fb2bbc679fffb070 | Versionado | [Software/GRLL/GRLL/Common/spParametrosTrabResult.cs:1](../../Software/GRLL/GRLL/Common/spParametrosTrabResult.cs#L1) |
| Software/GRLL/GRLL/Common/spParametrosTrab_ExpResult.cs | 384 | ed99e35bdbff3a5118c91edeeca3791bc63b9d5ead0c593bf66854189385d8d8 | Versionado | [Software/GRLL/GRLL/Common/spParametrosTrab_ExpResult.cs:1](../../Software/GRLL/GRLL/Common/spParametrosTrab_ExpResult.cs#L1) |
| Software/GRLL/GRLL/Common/spParametrosTrab_SelectResult.cs | 348 | d297fd774b80f79622c8f156ab02c83ee8636473a9db717a2893c6211ea70ce0 | Versionado | [Software/GRLL/GRLL/Common/spParametrosTrab_SelectResult.cs:1](../../Software/GRLL/GRLL/Common/spParametrosTrab_SelectResult.cs#L1) |
| Software/GRLL/GRLL/Common/spPresupuestoT_ExpResult.cs | 420 | 41dc17f324930876d117258b333d9a36b4b8f869bed80eb984bd0717dae145ea | Versionado | [Software/GRLL/GRLL/Common/spPresupuestoT_ExpResult.cs:1](../../Software/GRLL/GRLL/Common/spPresupuestoT_ExpResult.cs#L1) |
| Software/GRLL/GRLL/Common/spPresupuestoT_SelectResult.cs | 420 | 30b92bb226e985927f390254fcdc6aaa59c0e182fa220ff79dddb4a5fa21725d | Versionado | [Software/GRLL/GRLL/Common/spPresupuestoT_SelectResult.cs:1](../../Software/GRLL/GRLL/Common/spPresupuestoT_SelectResult.cs#L1) |
| Software/GRLL/GRLL/Common/spProgramMesResult.cs | 24 | 7d7b11aadac39550247fd9a68bd4f408a99d769b6a46201d4618d1fa44c6cf2b | Versionado | [Software/GRLL/GRLL/Common/spProgramMesResult.cs:1](../../Software/GRLL/GRLL/Common/spProgramMesResult.cs#L1) |
| Software/GRLL/GRLL/Common/spProgramMes_ExpResult.cs | 114 | c9444d41f4e83e2786b88746d9db87f27176bd1de605c1ca15c7edd28e1bc38e | Versionado | [Software/GRLL/GRLL/Common/spProgramMes_ExpResult.cs:1](../../Software/GRLL/GRLL/Common/spProgramMes_ExpResult.cs#L1) |
| Software/GRLL/GRLL/Common/spProgramMes_SelectResult.cs | 114 | fa24604dba3ba09402c280c6bae5ea2e52adbf2d7691c1212b2d319f75442eaa | Versionado | [Software/GRLL/GRLL/Common/spProgramMes_SelectResult.cs:1](../../Software/GRLL/GRLL/Common/spProgramMes_SelectResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_BuscarEmpleado_CodigoResult.cs | 530 | 18a860528f780af823eed1a8c872b5e74177779f90545745c579508d013c4d3c | Versionado | [Software/GRLL/GRLL/Common/spRRHH_BuscarEmpleado_CodigoResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_BuscarEmpleado_CodigoResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_BuscarExpLabResult.cs | 151 | f32c47ee6a4ba6f75165b4c2b858f6b8c62dbafa104304f1c07ad6fc5a486a66 | Versionado | [Software/GRLL/GRLL/Common/spRRHH_BuscarExpLabResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_BuscarExpLabResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_BuscarFamiliaresResult.cs | 169 | 7bffd5bf995679b0745b783d012e6c9a8ecfdd6030474c2d75f3fbd0a64baefb | Versionado | [Software/GRLL/GRLL/Common/spRRHH_BuscarFamiliaresResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_BuscarFamiliaresResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_FaltasResult.cs | 204 | 88fce5b368128cbb8113ed3674368dd40b163dfc89a3de1979f9aa5260f2141e | Versionado | [Software/GRLL/GRLL/Common/spRRHH_FaltasResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_FaltasResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_Ficha_DatosPersonalesResult.cs | 1142 | 715c0a6f10e6ebb27daff127cd2162ff871ad0149bf79096e63555dad6c649d5 | Versionado | [Software/GRLL/GRLL/Common/spRRHH_Ficha_DatosPersonalesResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_Ficha_DatosPersonalesResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_Ficha_Det_FamiliarResult.cs | 150 | a36a83f832472908028b2540dd0dffdb43e9d337f7151c00abfcfa2241ccbd39 | Versionado | [Software/GRLL/GRLL/Common/spRRHH_Ficha_Det_FamiliarResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_Ficha_Det_FamiliarResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_Ficha_Det_Familiar_SaludResult.cs | 114 | f74715f027c9b1572a7c930430f9969cd2866ed8a5a2b34625c7fe85aaa0c5d6 | Versionado | [Software/GRLL/GRLL/Common/spRRHH_Ficha_Det_Familiar_SaludResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_Ficha_Det_Familiar_SaludResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_Ficha_Estudio_CapacitacionResult.cs | 133 | c9eb792a8dd035cfba3871934dd5f971e30f8ac38d873b306a49cde5ab80a882 | Versionado | [Software/GRLL/GRLL/Common/spRRHH_Ficha_Estudio_CapacitacionResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_Ficha_Estudio_CapacitacionResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_Ficha_Estudio_RealizadoResult.cs | 97 | 1772c7bee908e0c7aab226be2484ef03a7084b1ca6f17559f1ec978928e48fd7 | Versionado | [Software/GRLL/GRLL/Common/spRRHH_Ficha_Estudio_RealizadoResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_Ficha_Estudio_RealizadoResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_Ficha_Estudio_TituloResult.cs | 97 | 99e855b1027fb50fe4cc30c85e712b1d63587b4486f193a7223814065e163d44 | Versionado | [Software/GRLL/GRLL/Common/spRRHH_Ficha_Estudio_TituloResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_Ficha_Estudio_TituloResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_Ficha_ExpLabResult.cs | 115 | da7f149876d0997b463a19b83741fec5cf8a2b98981f4ec0e5fa44a2647874f7 | Versionado | [Software/GRLL/GRLL/Common/spRRHH_Ficha_ExpLabResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_Ficha_ExpLabResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_Ficha_ExpLab_DatosResult.cs | 349 | c3397499de7ee59073592e2b4ebc740c6f5abdaedae6639f836f23b9d49c71f7 | Versionado | [Software/GRLL/GRLL/Common/spRRHH_Ficha_ExpLab_DatosResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_Ficha_ExpLab_DatosResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_Ficha_Ingreso_EgresoResult.cs | 492 | c378d62beeb676f107751c4a9cf5b400aed00bc25d2c224d4e956ac55c8c1268 | Versionado | [Software/GRLL/GRLL/Common/spRRHH_Ficha_Ingreso_EgresoResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_Ficha_Ingreso_EgresoResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_Ficha_ViviendaResult.cs | 366 | 496256fcc7b66acc79ae1d711195ab22b911d37953a40c96ffaba598437157d4 | Versionado | [Software/GRLL/GRLL/Common/spRRHH_Ficha_ViviendaResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_Ficha_ViviendaResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_GetAsistenciasResult.cs | 61 | f4cec242fbaa132538f67595441f866eb02510e9edfcd451608f2b154039e773 | Versionado | [Software/GRLL/GRLL/Common/spRRHH_GetAsistenciasResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_GetAsistenciasResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_GetDiasAsistidosResult.cs | 42 | be1dc0413d1eac1e2d67ce101959e351525d12497786e0c3506ad2a059462860 | Versionado | [Software/GRLL/GRLL/Common/spRRHH_GetDiasAsistidosResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_GetDiasAsistidosResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_GetMinTardeResult.cs | 60 | 6e9161a30b4a3f9e0bb2a2dccb8d1633ef19c7d5e045a0a1d01a76528b154881 | Versionado | [Software/GRLL/GRLL/Common/spRRHH_GetMinTardeResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_GetMinTardeResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_GetPeriodoLaboralByEmpleadoResult.cs | 151 | 31753064ae7fe854381ccb84900d3b969b4aec5f88969222c839705050a14f56 | Versionado | [Software/GRLL/GRLL/Common/spRRHH_GetPeriodoLaboralByEmpleadoResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_GetPeriodoLaboralByEmpleadoResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_GetRecordAsistenciasSemanalesResult.cs | 114 | c9aa42cd3d3597f07767424e7fc7fcc08c3d8cd73291ef0a8698df83ac2ee487 | Versionado | [Software/GRLL/GRLL/Common/spRRHH_GetRecordAsistenciasSemanalesResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_GetRecordAsistenciasSemanalesResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_ListarResolucionResult.cs | 79 | 05ce996c0d8ecba6eabd3ac5bfc633699c416cae9cc2aa666a15374ea61c3758 | Versionado | [Software/GRLL/GRLL/Common/spRRHH_ListarResolucionResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_ListarResolucionResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_ListarRotacionesResult.cs | 79 | 1742aea55a9be9d6b00a747bbf68d42a61be2c434e35ff433f2dbd897e7e3887 | Versionado | [Software/GRLL/GRLL/Common/spRRHH_ListarRotacionesResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_ListarRotacionesResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_RepAsisdiarriaResult.cs | 78 | 879c719e4bf7e9ef0f1a04c4c1d4f294512d20d7ae51c6d130ab0d0eb2b6406e | Versionado | [Software/GRLL/GRLL/Common/spRRHH_RepAsisdiarriaResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_RepAsisdiarriaResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_RepPermisosResult.cs | 151 | 8dfc4a6274c25a0136384551220b63ee6a5cf24c4e599dd5ede5cf16bc181d27 | Versionado | [Software/GRLL/GRLL/Common/spRRHH_RepPermisosResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_RepPermisosResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_Rep_cargosResult.cs | 96 | 66b9c27a2561c62758044f5fb7a4a956f6cbbc88f31f9922307b821e3fde328d | Versionado | [Software/GRLL/GRLL/Common/spRRHH_Rep_cargosResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_Rep_cargosResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_Report_CuadroPerResult.cs | 150 | 8e6e860963aa868afb5de248651464bed99c9f16e9f4182c18718ab571900659 | Versionado | [Software/GRLL/GRLL/Common/spRRHH_Report_CuadroPerResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_Report_CuadroPerResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_Report_CumpleResult.cs | 132 | 8c540f6281d2db653357317c5be4926f25e88752416313d14d86f0c05f405cfe | Versionado | [Software/GRLL/GRLL/Common/spRRHH_Report_CumpleResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_Report_CumpleResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_Report_FechaIngresoResult.cs | 115 | 646e74ff3b9c1388a25dad2cc479332d9bcda380fe45ccc484fcae6443a160cf | Versionado | [Software/GRLL/GRLL/Common/spRRHH_Report_FechaIngresoResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_Report_FechaIngresoResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_Report_OficinaResult.cs | 78 | b38f209e5ae951d5bf4e8a27da06f61fda07952f7d391b181da64aa33c36450e | Versionado | [Software/GRLL/GRLL/Common/spRRHH_Report_OficinaResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_Report_OficinaResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_Report_Oficina_UnicoResult.cs | 96 | ae55781e2356e3e93c94978995507352da0c6d838d088d5fb665f926ec346b57 | Versionado | [Software/GRLL/GRLL/Common/spRRHH_Report_Oficina_UnicoResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_Report_Oficina_UnicoResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_busca_DisciplinaResult.cs | 133 | 798ebe77858906d93a478040f8e524022a5e5c5ced4f7ab951e4d2e143ed731e | Versionado | [Software/GRLL/GRLL/Common/spRRHH_busca_DisciplinaResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_busca_DisciplinaResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_busca_archivosResult.cs | 133 | f0fb77dbdd68f7bc6383e60bf87cb2fc24405d2c8ad30224dd713f9afbbdd7d2 | Versionado | [Software/GRLL/GRLL/Common/spRRHH_busca_archivosResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_busca_archivosResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_busca_empleadoResult.cs | 114 | 6f989cf95b841bd073626fdf168ab1de84a56ae17f09340d24f7d047cf47d46c | Versionado | [Software/GRLL/GRLL/Common/spRRHH_busca_empleadoResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_busca_empleadoResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_buscarEstudiosResult.cs | 133 | 1ae0cb1cb383778590a06f938d2f8527029e9261f6b025b13a1e811eba0ae99a | Versionado | [Software/GRLL/GRLL/Common/spRRHH_buscarEstudiosResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_buscarEstudiosResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_getMotivo_permResult.cs | 114 | af349ab71ae02cf2c232abc827d07a220d26f43b348c3b854c6d1f04914e2bce | Versionado | [Software/GRLL/GRLL/Common/spRRHH_getMotivo_permResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_getMotivo_permResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRRHH_llenarPermisoResult.cs | 241 | 2d528104cb112d7aec508abf4a9db216808f98f802a41f3fb373179115c2e027 | Versionado | [Software/GRLL/GRLL/Common/spRRHH_llenarPermisoResult.cs:1](../../Software/GRLL/GRLL/Common/spRRHH_llenarPermisoResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRecomendacion_ExpResult.cs | 132 | ef53a31bcb9c2b094b879b60fefa08b627ad0119825193a97a05a465d8b21f2a | Versionado | [Software/GRLL/GRLL/Common/spRecomendacion_ExpResult.cs:1](../../Software/GRLL/GRLL/Common/spRecomendacion_ExpResult.cs#L1) |
| Software/GRLL/GRLL/Common/spRecomendacion_SelectResult.cs | 132 | fc7cb673da2ad3d0db59942ce624426ad9943c1417e2bb58e92c612200088326 | Versionado | [Software/GRLL/GRLL/Common/spRecomendacion_SelectResult.cs:1](../../Software/GRLL/GRLL/Common/spRecomendacion_SelectResult.cs#L1) |
| Software/GRLL/GRLL/Common/spReqXProgMesResult.cs | 24 | a3ea9cbf5a28577f9ed244c64dd25efc35bd80b90785619614be9a3548ca5d22 | Versionado | [Software/GRLL/GRLL/Common/spReqXProgMesResult.cs:1](../../Software/GRLL/GRLL/Common/spReqXProgMesResult.cs#L1) |
| Software/GRLL/GRLL/Common/spReqXProgMes_ExpResult.cs | 168 | fb607c1fdb93618932ed3297011cb8638e8ad565318926de0fdf2c1ab53f71b0 | Versionado | [Software/GRLL/GRLL/Common/spReqXProgMes_ExpResult.cs:1](../../Software/GRLL/GRLL/Common/spReqXProgMes_ExpResult.cs#L1) |
| Software/GRLL/GRLL/Common/spReqXProgMes_SelectResult.cs | 222 | b397cfb5069383e5b6bfd1b33afe9145db1398aeee93012f64988e39c9da3d70 | Versionado | [Software/GRLL/GRLL/Common/spReqXProgMes_SelectResult.cs:1](../../Software/GRLL/GRLL/Common/spReqXProgMes_SelectResult.cs#L1) |
| Software/GRLL/GRLL/Common/spResponsableXUO_ExpResult.cs | 150 | cb5e6856e007b88ffbbacf2a3a73746bb55d0d56ee8fa4c1c3aa5660ee4565f7 | Versionado | [Software/GRLL/GRLL/Common/spResponsableXUO_ExpResult.cs:1](../../Software/GRLL/GRLL/Common/spResponsableXUO_ExpResult.cs#L1) |
| Software/GRLL/GRLL/Common/spSEG_ListarUsuariosResult.cs | 78 | f3d2863d77172826a2db8fd94800f2b18270e60733ea186f8a151a6f89af9c11 | Versionado | [Software/GRLL/GRLL/Common/spSEG_ListarUsuariosResult.cs:1](../../Software/GRLL/GRLL/Common/spSEG_ListarUsuariosResult.cs#L1) |
| Software/GRLL/GRLL/Common/spSEG_VerfUsuarioResult.cs | 24 | 637096233046bbe5f6d7bbbefbfa7fd61e5ea9c599137da30ece8231891ab6e7 | Versionado | [Software/GRLL/GRLL/Common/spSEG_VerfUsuarioResult.cs:1](../../Software/GRLL/GRLL/Common/spSEG_VerfUsuarioResult.cs#L1) |
| Software/GRLL/GRLL/Common/spSEG_listarUserRolResult.cs | 96 | 178605a7cc85094c186f05808a81feec9c425bdde32a0f41f0ac4192e5b96f03 | Versionado | [Software/GRLL/GRLL/Common/spSEG_listarUserRolResult.cs:1](../../Software/GRLL/GRLL/Common/spSEG_listarUserRolResult.cs#L1) |
| Software/GRLL/GRLL/Common/spSEG_llenarInterfazResult.cs | 114 | 2104ec7ff8b39f461519799468579e089c4285ed20ca1e4e086ae80beb66d097 | Versionado | [Software/GRLL/GRLL/Common/spSEG_llenarInterfazResult.cs:1](../../Software/GRLL/GRLL/Common/spSEG_llenarInterfazResult.cs#L1) |
| Software/GRLL/GRLL/Common/spSEG_llenarInterfaz_RolResult.cs | 114 | 71c83bf510a687dd2b31835eca8f5c15796e233bf035c6bc5a350967aa0a8838 | Versionado | [Software/GRLL/GRLL/Common/spSEG_llenarInterfaz_RolResult.cs:1](../../Software/GRLL/GRLL/Common/spSEG_llenarInterfaz_RolResult.cs#L1) |
| Software/GRLL/GRLL/Common/spSEG_llenarUsuariosResult.cs | 132 | 21118edfbd4e4529d6b65c81c23c9b5ea0d1f9834f7be9b7739ad75601f386eb | Versionado | [Software/GRLL/GRLL/Common/spSEG_llenarUsuariosResult.cs:1](../../Software/GRLL/GRLL/Common/spSEG_llenarUsuariosResult.cs#L1) |
| Software/GRLL/GRLL/Common/spUnidMed_ExpResult.cs | 60 | 5a01ccf01944d6282241169479531cdd4c2acb473ff9954445d16de4af719564 | Versionado | [Software/GRLL/GRLL/Common/spUnidMed_ExpResult.cs:1](../../Software/GRLL/GRLL/Common/spUnidMed_ExpResult.cs#L1) |
| Software/GRLL/GRLL/Common/spUnidMed_SelectResult.cs | 60 | c183cfc82d7641c4b42619b1eb67ee4fb4e25551820d23af33b5c11484c1618e | Versionado | [Software/GRLL/GRLL/Common/spUnidMed_SelectResult.cs:1](../../Software/GRLL/GRLL/Common/spUnidMed_SelectResult.cs#L1) |
| Software/GRLL/GRLL/Common/spUnidadMedida_ExpResult.cs | 60 | 9fbf91536726e3786d18f64b27ad2d69cf2fb7e198f93dcfddb5f2c6c1050ac6 | Versionado | [Software/GRLL/GRLL/Common/spUnidadMedida_ExpResult.cs:1](../../Software/GRLL/GRLL/Common/spUnidadMedida_ExpResult.cs#L1) |
| Software/GRLL/GRLL/Common/spUnidadMedida_SelectResult.cs | 60 | 89750a3b92fbb020bf0a8bf2934d502d26d4f4ed415f5f54ae6e0a6a5a916791 | Versionado | [Software/GRLL/GRLL/Common/spUnidadMedida_SelectResult.cs:1](../../Software/GRLL/GRLL/Common/spUnidadMedida_SelectResult.cs#L1) |
| Software/GRLL/GRLL/Common/sp_ABA_ImpDetOrdenCBienResult.cs | 240 | 5359de6f7c5027e7d67df7c74271c669c83bd7c1781a012ea6e204cd84bcbf11 | Versionado | [Software/GRLL/GRLL/Common/sp_ABA_ImpDetOrdenCBienResult.cs:1](../../Software/GRLL/GRLL/Common/sp_ABA_ImpDetOrdenCBienResult.cs#L1) |
| Software/GRLL/GRLL/Common/sp_ABA_ImpOrdenCBienResult.cs | 421 | 1e2c09ba13f20c0b9cd92754f81667e79b487d02f7bcadda5096e5ef8d3b0c08 | Versionado | [Software/GRLL/GRLL/Common/sp_ABA_ImpOrdenCBienResult.cs:1](../../Software/GRLL/GRLL/Common/sp_ABA_ImpOrdenCBienResult.cs#L1) |
| Software/GRLL/GRLL/Common/sp_AbaNroMaxMovimientoResult.cs | 42 | 2040d1d0c2b752a1e32e26bac52d55d177d7a6e0ac65efdd06d41b4ec80c96bd | Versionado | [Software/GRLL/GRLL/Common/sp_AbaNroMaxMovimientoResult.cs:1](../../Software/GRLL/GRLL/Common/sp_AbaNroMaxMovimientoResult.cs#L1) |
| Software/GRLL/GRLL/Common/sp_Listar_Empleado_HorarioResult.cs | 114 | 2787c796fb0d7a777b534f93d958a40e65fb5017997882f81b44f017b00e9b94 | Versionado | [Software/GRLL/GRLL/Common/sp_Listar_Empleado_HorarioResult.cs:1](../../Software/GRLL/GRLL/Common/sp_Listar_Empleado_HorarioResult.cs#L1) |
| Software/GRLL/GRLL/Common/sp_Listar_Empleado_LocalResult.cs | 114 | 5af5043925ec0b6494fb3420868bfb0db6db3fe6c810aae2b0e8d45321344cc4 | Versionado | [Software/GRLL/GRLL/Common/sp_Listar_Empleado_LocalResult.cs:1](../../Software/GRLL/GRLL/Common/sp_Listar_Empleado_LocalResult.cs#L1) |
| Software/GRLL/GRLL/Common/sp_RRHH_Busca_Empleado_treeResult.cs | 96 | 8542fa16ac2706489654a4dca654978c8f6d87c84d569e9b774c297631368484 | Versionado | [Software/GRLL/GRLL/Common/sp_RRHH_Busca_Empleado_treeResult.cs:1](../../Software/GRLL/GRLL/Common/sp_RRHH_Busca_Empleado_treeResult.cs#L1) |
| Software/GRLL/GRLL/Common/sp_Rep_PrincipalResult.cs | 150 | 042b57b73e5c25d0608dbef0b4244f3290f145805139076b4f6011f59743040b | Versionado | [Software/GRLL/GRLL/Common/sp_Rep_PrincipalResult.cs:1](../../Software/GRLL/GRLL/Common/sp_Rep_PrincipalResult.cs#L1) |
| Software/GRLL/GRLL/Common/sp_Tra_BuscarTramiteResult.cs | 313 | 43bdf0d6ebab2e327d2bd294e7c79fad4d4aaa0f06dce42eb09bb7404f233947 | Versionado | [Software/GRLL/GRLL/Common/sp_Tra_BuscarTramiteResult.cs:1](../../Software/GRLL/GRLL/Common/sp_Tra_BuscarTramiteResult.cs#L1) |
| Software/GRLL/GRLL/Common/sp_Tra_TRA_ListarMovimientoResult.cs | 547 | c79dba1a16f1dcde814441a607a926b7a8c15db19f65d5031a8b3a198da44d3d | Versionado | [Software/GRLL/GRLL/Common/sp_Tra_TRA_ListarMovimientoResult.cs:1](../../Software/GRLL/GRLL/Common/sp_Tra_TRA_ListarMovimientoResult.cs#L1) |
| Software/GRLL/GRLL/Common/sp_Tra_TraListarTramiteResult.cs | 457 | d49bcfa52ceaed36f476c3375f55b934fd345d1f2783ae67924f84d693d8d682 | Versionado | [Software/GRLL/GRLL/Common/sp_Tra_TraListarTramiteResult.cs:1](../../Software/GRLL/GRLL/Common/sp_Tra_TraListarTramiteResult.cs#L1) |
| Software/GRLL/GRLL/Common/sp_Tra_Usuario_AreaCargoResult.cs | 42 | 6e91ec55e69ca4d457a205301ff08b8480d656b15bbbb949895be615aa5cd6bd | Versionado | [Software/GRLL/GRLL/Common/sp_Tra_Usuario_AreaCargoResult.cs:1](../../Software/GRLL/GRLL/Common/sp_Tra_Usuario_AreaCargoResult.cs#L1) |
| Software/GRLL/GRLL/Common/sp_Tra_VS_TRA_ListarTramiteResult.cs | 475 | cd4eebc7b6ea8c054673c750ed050433f6cc47dea452e61100265a96f0cb487e | Versionado | [Software/GRLL/GRLL/Common/sp_Tra_VS_TRA_ListarTramiteResult.cs:1](../../Software/GRLL/GRLL/Common/sp_Tra_VS_TRA_ListarTramiteResult.cs#L1) |
| Software/GRLL/GRLL/Common/sp_Tra_vs_TRA_ListarMovimientoResult.cs | 547 | 42c4d805659f2f60e53a369c3ac3f659d623211e5fb602e8f0322d51aeb4cc8c | Versionado | [Software/GRLL/GRLL/Common/sp_Tra_vs_TRA_ListarMovimientoResult.cs:1](../../Software/GRLL/GRLL/Common/sp_Tra_vs_TRA_ListarMovimientoResult.cs#L1) |
| Software/GRLL/GRLL/Common/sp_Tra_vs_TRA_ListarMovimientoTiempoXEstadoResult.cs | 637 | 5b828e28815086d256378d774f5ae570ae104b65673e3905e332c2b88400e680 | Versionado | [Software/GRLL/GRLL/Common/sp_Tra_vs_TRA_ListarMovimientoTiempoXEstadoResult.cs:1](../../Software/GRLL/GRLL/Common/sp_Tra_vs_TRA_ListarMovimientoTiempoXEstadoResult.cs#L1) |
| Software/GRLL/GRLL/Common/sp_Tra_vs_TRA_ListarMovimientoXEstadoResult.cs | 547 | f06ec0aa347ffc0d98f99de7c53908f9c36f065f652271782ccaa5db28d42422 | Versionado | [Software/GRLL/GRLL/Common/sp_Tra_vs_TRA_ListarMovimientoXEstadoResult.cs:1](../../Software/GRLL/GRLL/Common/sp_Tra_vs_TRA_ListarMovimientoXEstadoResult.cs#L1) |
| Software/GRLL/GRLL/Common/sp_aba_BuscarBienResult.cs | 24 | ccbc484bf43e427731a7e57374d7bb498202f12b7dca70833e5fd352cf1f8c54 | Versionado | [Software/GRLL/GRLL/Common/sp_aba_BuscarBienResult.cs:1](../../Software/GRLL/GRLL/Common/sp_aba_BuscarBienResult.cs#L1) |
| Software/GRLL/GRLL/Common/sp_aba_BuscarGastoResult.cs | 24 | 7e6803371ebc69d281dd8ee0d2dc0a7a719b6fa8a09b92c029370d80ff4c3e8b | Versionado | [Software/GRLL/GRLL/Common/sp_aba_BuscarGastoResult.cs:1](../../Software/GRLL/GRLL/Common/sp_aba_BuscarGastoResult.cs#L1) |
| Software/GRLL/GRLL/Common/sp_aba_BuscarMetaResult.cs | 24 | 6b5ac157b0d3fa58137d379d45b6a1a3510eb9a2059345ff2b718d4bd2e4c418 | Versionado | [Software/GRLL/GRLL/Common/sp_aba_BuscarMetaResult.cs:1](../../Software/GRLL/GRLL/Common/sp_aba_BuscarMetaResult.cs#L1) |
| Software/GRLL/GRLL/Common/sp_aba_BuscarOrdenFULLResult.cs | 223 | 3dd94483d8d41df3e1ce582875c646d0cd52dd94c151e1386d0b3ed98757e992 | Versionado | [Software/GRLL/GRLL/Common/sp_aba_BuscarOrdenFULLResult.cs:1](../../Software/GRLL/GRLL/Common/sp_aba_BuscarOrdenFULLResult.cs#L1) |
| Software/GRLL/GRLL/Common/sp_aba_BuscarOrdenResult.cs | 241 | 3a31faafc08d1455b22022d0d724d7522e8f99e69b9b9ccb87b4942e26cef97c | Versionado | [Software/GRLL/GRLL/Common/sp_aba_BuscarOrdenResult.cs:1](../../Software/GRLL/GRLL/Common/sp_aba_BuscarOrdenResult.cs#L1) |
| Software/GRLL/GRLL/Common/sp_aba_Corre_CodMetaResult.cs | 24 | a4414748eb9d4dcc3e7a279ddbc8d0bf67bef16c2499498b079992a22f89390b | Versionado | [Software/GRLL/GRLL/Common/sp_aba_Corre_CodMetaResult.cs:1](../../Software/GRLL/GRLL/Common/sp_aba_Corre_CodMetaResult.cs#L1) |
| Software/GRLL/GRLL/Common/sp_aba_NroMaxPerResult.cs | 24 | 6a0c3567e17a39c97adf475f791aa9a1d2dbf30d33466bca2e12ae9d0a8bca50 | Versionado | [Software/GRLL/GRLL/Common/sp_aba_NroMaxPerResult.cs:1](../../Software/GRLL/GRLL/Common/sp_aba_NroMaxPerResult.cs#L1) |
| Software/GRLL/GRLL/Common/sp_aba_OrdenDetalleResult.cs | 258 | 32096a82546a8c1e9a4f9b91c8710d96172ea0c1ac34cc01f8c81ebd6f0bf343 | Versionado | [Software/GRLL/GRLL/Common/sp_aba_OrdenDetalleResult.cs:1](../../Software/GRLL/GRLL/Common/sp_aba_OrdenDetalleResult.cs#L1) |
| Software/GRLL/GRLL/Common/sp_aba_usuario_areaOResult.cs | 78 | 5ef66117fdff495f5cb2012e6c2d8e08d975896791c5f3ece9ca9f8819f10977 | Versionado | [Software/GRLL/GRLL/Common/sp_aba_usuario_areaOResult.cs:1](../../Software/GRLL/GRLL/Common/sp_aba_usuario_areaOResult.cs#L1) |
| Software/GRLL/GRLL/Common/sp_pruebaResult.cs | 60 | bf3b8b3f98ed39636e8fe2b8a93c4ff4365d97de21e4c46b304a7ea9323d6fcf | Versionado | [Software/GRLL/GRLL/Common/sp_pruebaResult.cs:1](../../Software/GRLL/GRLL/Common/sp_pruebaResult.cs#L1) |
| Software/GRLL/GRLL/Common/sp_tra_ContarMovResult.cs | 655 | 15ddba54ea30b182fb212d232b72e792b14820a55b531097115c2c0d2417fae5 | Versionado | [Software/GRLL/GRLL/Common/sp_tra_ContarMovResult.cs:1](../../Software/GRLL/GRLL/Common/sp_tra_ContarMovResult.cs#L1) |
| Software/GRLL/GRLL/Common/sp_tra_MaxIdRequisitoResult.cs | 24 | 8f6356df4f02a69528507ff8ab010b9fc8f10b54ffb6a7fc464b635621ff74ec | Versionado | [Software/GRLL/GRLL/Common/sp_tra_MaxIdRequisitoResult.cs:1](../../Software/GRLL/GRLL/Common/sp_tra_MaxIdRequisitoResult.cs#L1) |
| Software/GRLL/GRLL/Common/sp_tra_Sum_Tiempo_etapaResult.cs | 60 | ab06694017c2d039f693bfc27a008c41eb224e83d7fbd5c6a41a2e6c255b0776 | Versionado | [Software/GRLL/GRLL/Common/sp_tra_Sum_Tiempo_etapaResult.cs:1](../../Software/GRLL/GRLL/Common/sp_tra_Sum_Tiempo_etapaResult.cs#L1) |
| Software/GRLL/GRLL/Common/splistartablasResult.cs | 42 | 5aa92196cc70dd162deecef13014e8de0a8f7f3e01208996833d829a254a1054 | Versionado | [Software/GRLL/GRLL/Common/splistartablasResult.cs:1](../../Software/GRLL/GRLL/Common/splistartablasResult.cs#L1) |
| Software/GRLL/GRLL/Common/sysLogEvent.cs | 134 | 4ad41e260598405e9b2c27a002bb69e1745d7d00d10774ca82c9a4f362bbef60 | Versionado | [Software/GRLL/GRLL/Common/sysLogEvent.cs:1](../../Software/GRLL/GRLL/Common/sysLogEvent.cs#L1) |
| Software/GRLL/GRLL/Common/tra_sp_vs_tra_ListarProcedimientoEtapaResult.cs | 402 | 8a14c6ec8572e12f154103ffc2bea7433c1685d039e1c3ac2b7551524637fde5 | Versionado | [Software/GRLL/GRLL/Common/tra_sp_vs_tra_ListarProcedimientoEtapaResult.cs:1](../../Software/GRLL/GRLL/Common/tra_sp_vs_tra_ListarProcedimientoEtapaResult.cs#L1) |
| Software/GRLL/GRLL/Common/ucBuscaClienteProveedor.cs | 363 | 46bc054f4ad1f257f62ead5d211ea50d3090632ebd56c2ffe5d2c72c49d76c9f | Versionado | [Software/GRLL/GRLL/Common/ucBuscaClienteProveedor.cs:1](../../Software/GRLL/GRLL/Common/ucBuscaClienteProveedor.cs#L1) |
| Software/GRLL/GRLL/Common/ucBuscaDato.cs | 742 | 57296ad8756bd3445f8dbbcb4b7c0ea41875f430d3067ac1380a6d6541a025c2 | Versionado | [Software/GRLL/GRLL/Common/ucBuscaDato.cs:1](../../Software/GRLL/GRLL/Common/ucBuscaDato.cs#L1) |
| Software/GRLL/GRLL/Common/ucButton.cs | 78 | 1681b7c6ec88ca9d202f4fe84762cd53b5e4d27a3fcc5f07ebd0c347613ab284 | Versionado | [Software/GRLL/GRLL/Common/ucButton.cs:1](../../Software/GRLL/GRLL/Common/ucButton.cs#L1) |
| Software/GRLL/GRLL/Common/ucCboAnio.cs | 68 | 9a4a8ea6b284a5fc92684c7191f609ec3f1063aec591285648e6a2da2223e824 | Versionado | [Software/GRLL/GRLL/Common/ucCboAnio.cs:1](../../Software/GRLL/GRLL/Common/ucCboAnio.cs#L1) |
| Software/GRLL/GRLL/Common/ucCboMes.cs | 74 | 1e35faee3a898698ac397d1c9a2c9160defb2a6baed5c7fab10fb2ae5a0f0c1d | Versionado | [Software/GRLL/GRLL/Common/ucCboMes.cs:1](../../Software/GRLL/GRLL/Common/ucCboMes.cs#L1) |
| Software/GRLL/GRLL/Common/ucComboBox.cs | 312 | ffb8da5557241299aa7793cb7a7289c5e7209d7eae53df5be6a5e26474f4861d | Versionado | [Software/GRLL/GRLL/Common/ucComboBox.cs:1](../../Software/GRLL/GRLL/Common/ucComboBox.cs#L1) |
| Software/GRLL/GRLL/Common/ucDataGridView.cs | 510 | 38429103b60b93b8d672df2e591e5f7067ef61cb36eb49bc893be3409e40d5cf | Versionado | [Software/GRLL/GRLL/Common/ucDataGridView.cs:1](../../Software/GRLL/GRLL/Common/ucDataGridView.cs#L1) |
| Software/GRLL/GRLL/Common/ucDateTime.cs | 147 | 32052542e2254feaec9b5b2b3bd2545f2d20099c67c6b5f8083f00c9e50671c1 | Versionado | [Software/GRLL/GRLL/Common/ucDateTime.cs:1](../../Software/GRLL/GRLL/Common/ucDateTime.cs#L1) |
| Software/GRLL/GRLL/Common/ucFechas.cs | 196 | bbdfef8161af35c42dea0c8c04dc3776d1cf20ffd8ca4698aaf897b3db226ae7 | Versionado | [Software/GRLL/GRLL/Common/ucFechas.cs:1](../../Software/GRLL/GRLL/Common/ucFechas.cs#L1) |
| Software/GRLL/GRLL/Common/ucFill.cs | 743 | bcadb2270ad2a430539391dc07e8a6666d4182a6a2358ad4fdfe3056abe55e5b | Versionado | [Software/GRLL/GRLL/Common/ucFill.cs:1](../../Software/GRLL/GRLL/Common/ucFill.cs#L1) |
| Software/GRLL/GRLL/Common/ucFindFile.cs | 443 | 303883f3d39793f205caa39c21ee6c22d14fe73269ed5d63bfeed30f63e0451b | Versionado | [Software/GRLL/GRLL/Common/ucFindFile.cs:1](../../Software/GRLL/GRLL/Common/ucFindFile.cs#L1) |
| Software/GRLL/GRLL/Common/ucFoto.cs | 487 | e8d3b01432d14649f92e45a92a55adfc74940b6d5d5696c304c28d2aaebe5eb0 | Versionado | [Software/GRLL/GRLL/Common/ucFoto.cs:1](../../Software/GRLL/GRLL/Common/ucFoto.cs#L1) |
| Software/GRLL/GRLL/Common/ucLabel.cs | 126 | 73d23e3014ec1ce2fd887ef29adc6dfaea56aa8580023418d735fbccc543fbdb | Versionado | [Software/GRLL/GRLL/Common/ucLabel.cs:1](../../Software/GRLL/GRLL/Common/ucLabel.cs#L1) |
| Software/GRLL/GRLL/Common/ucListData.cs | 729 | de78424e7c78e65c8d98303270ff8d7ee9892c2851dea747b7532d66665441a2 | Versionado | [Software/GRLL/GRLL/Common/ucListData.cs:1](../../Software/GRLL/GRLL/Common/ucListData.cs#L1) |
| Software/GRLL/GRLL/Common/ucLogin.cs | 509 | 4ff59a262a1c061d7586df42efac578c391312da2bd2f0746bc969a2f4f02358 | Versionado | [Software/GRLL/GRLL/Common/ucLogin.cs:1](../../Software/GRLL/GRLL/Common/ucLogin.cs#L1) |
| Software/GRLL/GRLL/Common/ucMyBottom.cs | 41 | 8db87e162c0199d5de8e2ff85dd48efa07701e0726677a138f9f6c0ce02949db | Versionado | [Software/GRLL/GRLL/Common/ucMyBottom.cs:1](../../Software/GRLL/GRLL/Common/ucMyBottom.cs#L1) |
| Software/GRLL/GRLL/Common/ucNavButton.cs | 280 | 7791062c73b8436c6ade381154e61719aaf7c2df3b700468ec295654aa357009 | Versionado | [Software/GRLL/GRLL/Common/ucNavButton.cs:1](../../Software/GRLL/GRLL/Common/ucNavButton.cs#L1) |
| Software/GRLL/GRLL/Common/ucPanel.cs | 121 | fc535682c243b32d17b601d91dd8c4782d252679b5a619bb5fc4845b14e3a3c5 | Versionado | [Software/GRLL/GRLL/Common/ucPanel.cs:1](../../Software/GRLL/GRLL/Common/ucPanel.cs#L1) |
| Software/GRLL/GRLL/Common/ucTVWVista.cs | 739 | 3d3fa4a182027cfcb2b550f1fcf090bd0dbc14e28387cad7b7b091351e5b707a | Versionado | [Software/GRLL/GRLL/Common/ucTVWVista.cs:1](../../Software/GRLL/GRLL/Common/ucTVWVista.cs#L1) |
| Software/GRLL/GRLL/Common/ucTView1T.cs | 733 | 33c8997db1b620efaa73d2ec1609e8a0b2f161a68b1190af763f18d9e927cf3f | Versionado | [Software/GRLL/GRLL/Common/ucTView1T.cs:1](../../Software/GRLL/GRLL/Common/ucTView1T.cs#L1) |
| Software/GRLL/GRLL/Common/ucTViewNT.cs | 1517 | 42cd0ce27c4b8a48071c85f89446ee064abffdb3355b821e06892a504144b2c1 | Versionado | [Software/GRLL/GRLL/Common/ucTViewNT.cs:1](../../Software/GRLL/GRLL/Common/ucTViewNT.cs#L1) |
| Software/GRLL/GRLL/Common/ucTViewV1T.cs | 747 | bce93b04ac91b87d59b92df942900e74823db00c5c4db53249e059b392e48e00 | Versionado | [Software/GRLL/GRLL/Common/ucTViewV1T.cs:1](../../Software/GRLL/GRLL/Common/ucTViewV1T.cs#L1) |
| Software/GRLL/GRLL/Common/ucTViewVNT.cs | 1526 | 7292fea257a66de3dfe823fd084e8bd9ea2eca2dd47350a19c74310d72ee3691 | Versionado | [Software/GRLL/GRLL/Common/ucTViewVNT.cs:1](../../Software/GRLL/GRLL/Common/ucTViewVNT.cs#L1) |
| Software/GRLL/GRLL/Common/ucText.cs | 674 | 47a342c066d688ac2a44459b9fe49940e09eb90dd817ad1fc60280704c24b930 | Versionado | [Software/GRLL/GRLL/Common/ucText.cs:1](../../Software/GRLL/GRLL/Common/ucText.cs#L1) |
| Software/GRLL/GRLL/Common/ucTextBox.cs | 580 | e7fa77989fd3ee4aa5caacab8a723afb0e528284045430337e5d5ba70dbe2865 | Versionado | [Software/GRLL/GRLL/Common/ucTextBox.cs:1](../../Software/GRLL/GRLL/Common/ucTextBox.cs#L1) |
| Software/GRLL/GRLL/Common/ucTextCombo.cs | 370 | b76873391db8c265e95985b0727ccea1161c38831f8b8f0df812f4c67902d5a6 | Versionado | [Software/GRLL/GRLL/Common/ucTextCombo.cs:1](../../Software/GRLL/GRLL/Common/ucTextCombo.cs#L1) |
| Software/GRLL/GRLL/Common/ucToolStripMaestro.cs | 402 | 88767ddd6adf8312237ba6b48b804fd80ce8752d633788157ebfe1636060e5b1 | Versionado | [Software/GRLL/GRLL/Common/ucToolStripMaestro.cs:1](../../Software/GRLL/GRLL/Common/ucToolStripMaestro.cs#L1) |
| Software/GRLL/GRLL/Common/ucUbigeoCmb.cs | 781 | b138b7d4d968142225a26151e4a510669b03b8877c9573938437e5f0868b6a7c | Versionado | [Software/GRLL/GRLL/Common/ucUbigeoCmb.cs:1](../../Software/GRLL/GRLL/Common/ucUbigeoCmb.cs#L1) |
| Software/GRLL/GRLL/Common/ucUbigeoCombito.cs | 863 | fd94508bade9a8c3ec500cfd4980ba6e6d4a0e4f2326645895e16080a569b2df | Versionado | [Software/GRLL/GRLL/Common/ucUbigeoCombito.cs:1](../../Software/GRLL/GRLL/Common/ucUbigeoCombito.cs#L1) |
| Software/GRLL/GRLL/Common/ucUbigeoLinq.cs | 972 | dab9e71285a4ba1b5f98809c70cef30864382c274a54dce49d402eab3bdbb8a9 | Versionado | [Software/GRLL/GRLL/Common/ucUbigeoLinq.cs:1](../../Software/GRLL/GRLL/Common/ucUbigeoLinq.cs#L1) |
| Software/GRLL/GRLL/Common/vActividad.cs | 674 | d093912837b876109d1aab08241e8154f0aa61c260f7827510c6b795742ab05a | Versionado | [Software/GRLL/GRLL/Common/vActividad.cs:1](../../Software/GRLL/GRLL/Common/vActividad.cs#L1) |
| Software/GRLL/GRLL/Common/vActividad_ProgramMes.cs | 115 | 029f0e9aea8f3e34aac8ac8df9937a8d6807987d5955e658e6657c5447ca21fc | Versionado | [Software/GRLL/GRLL/Common/vActividad_ProgramMes.cs:1](../../Software/GRLL/GRLL/Common/vActividad_ProgramMes.cs#L1) |
| Software/GRLL/GRLL/Common/vCJ_ClasificadorIngreso.cs | 205 | faa35aad3cc07ab1c70f046eaf70da5ebc932d8417e3e8c3697309d1c9d28c65 | Versionado | [Software/GRLL/GRLL/Common/vCJ_ClasificadorIngreso.cs:1](../../Software/GRLL/GRLL/Common/vCJ_ClasificadorIngreso.cs#L1) |
| Software/GRLL/GRLL/Common/vCJ_ClasificadorIngresoMapper.cs | 17 | caac75e5c2795442fab38ae643029edb2e6988a7a7e35d7c39587252f6de4fdf | Versionado | [Software/GRLL/GRLL/Common/vCJ_ClasificadorIngresoMapper.cs:1](../../Software/GRLL/GRLL/Common/vCJ_ClasificadorIngresoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/vCJ_PersonaJuridica.cs | 223 | 5f8beb1816fa90d6cd026e4729fa0ecced11fd695561a2caedf792e02eb7408b | Versionado | [Software/GRLL/GRLL/Common/vCJ_PersonaJuridica.cs:1](../../Software/GRLL/GRLL/Common/vCJ_PersonaJuridica.cs#L1) |
| Software/GRLL/GRLL/Common/vCJ_PersonaJuridicaMapper.cs | 17 | 60d3299c92acef66e59e86569d6f58bb6ed824994fe639ea36b33dbbab2832fb | Versionado | [Software/GRLL/GRLL/Common/vCJ_PersonaJuridicaMapper.cs:1](../../Software/GRLL/GRLL/Common/vCJ_PersonaJuridicaMapper.cs#L1) |
| Software/GRLL/GRLL/Common/vCJ_PersonaNJ.cs | 241 | e876214637fd053923af53d773833cabb3f5f9c680ccac0ca95f753e136ef233 | Versionado | [Software/GRLL/GRLL/Common/vCJ_PersonaNJ.cs:1](../../Software/GRLL/GRLL/Common/vCJ_PersonaNJ.cs#L1) |
| Software/GRLL/GRLL/Common/vCJ_PersonaNJMapper.cs | 17 | c5dfa52b0e3ebfa9dc25f3cff9b92b456de6ea4e9e2eaa06bd525bc9ff26533e | Versionado | [Software/GRLL/GRLL/Common/vCJ_PersonaNJMapper.cs:1](../../Software/GRLL/GRLL/Common/vCJ_PersonaNJMapper.cs#L1) |
| Software/GRLL/GRLL/Common/vCJ_PersonaNatural.cs | 223 | 9f44e76c87cc70dec86dc157d8fb4a340200dd546526d1345dc485d30eb3e858 | Versionado | [Software/GRLL/GRLL/Common/vCJ_PersonaNatural.cs:1](../../Software/GRLL/GRLL/Common/vCJ_PersonaNatural.cs#L1) |
| Software/GRLL/GRLL/Common/vCJ_PersonaNaturalMapper.cs | 17 | 788f647be114adc2ee10bf70e69f7963e2281c9d5eff41c2d0cee103a89c2554 | Versionado | [Software/GRLL/GRLL/Common/vCJ_PersonaNaturalMapper.cs:1](../../Software/GRLL/GRLL/Common/vCJ_PersonaNaturalMapper.cs#L1) |
| Software/GRLL/GRLL/Common/vCJ_PlanMayor.cs | 187 | 9413a72af26bf7368fea510347aef3ae35aab02898f8817e4f6f25b5084bcbae | Versionado | [Software/GRLL/GRLL/Common/vCJ_PlanMayor.cs:1](../../Software/GRLL/GRLL/Common/vCJ_PlanMayor.cs#L1) |
| Software/GRLL/GRLL/Common/vCJ_PlanMayorMapper.cs | 17 | c986687663d1d3dd25cc8789db8e38a79a370d01fc5fef853ae45277d88a1faf | Versionado | [Software/GRLL/GRLL/Common/vCJ_PlanMayorMapper.cs:1](../../Software/GRLL/GRLL/Common/vCJ_PlanMayorMapper.cs#L1) |
| Software/GRLL/GRLL/Common/vEmpleadoxpersona.cs | 116 | b601126d7d76e72160b48db37d8f5e8d2b27d5bc36a3839b559f8199ae8f0855 | Versionado | [Software/GRLL/GRLL/Common/vEmpleadoxpersona.cs:1](../../Software/GRLL/GRLL/Common/vEmpleadoxpersona.cs#L1) |
| Software/GRLL/GRLL/Common/vEstrategia.cs | 170 | 1ea6dd5de5e9de75f080c9b8e110655fa173843c915eb00958ae187eec0dc087 | Versionado | [Software/GRLL/GRLL/Common/vEstrategia.cs:1](../../Software/GRLL/GRLL/Common/vEstrategia.cs#L1) |
| Software/GRLL/GRLL/Common/vEstructOrganiz.cs | 529 | 88b1f82195c8dda2a719d0eae0da9241d02dbd2f8f3903fe12d37d3e292bb1b7 | Versionado | [Software/GRLL/GRLL/Common/vEstructOrganiz.cs:1](../../Software/GRLL/GRLL/Common/vEstructOrganiz.cs#L1) |
| Software/GRLL/GRLL/Common/vEstructOrganizCmbObj.cs | 151 | b9b9dbc07fe1019d837aea3abc3d2ebaa81ca5ec9d4a187e0ebd007fd96f5993 | Versionado | [Software/GRLL/GRLL/Common/vEstructOrganizCmbObj.cs:1](../../Software/GRLL/GRLL/Common/vEstructOrganizCmbObj.cs#L1) |
| Software/GRLL/GRLL/Common/vEstructOrganizMapper.cs | 17 | 8d615c5f72fcbd22ec7322b2c73cb3b3a358373fb6daefb005fa917f89a42385 | Versionado | [Software/GRLL/GRLL/Common/vEstructOrganizMapper.cs:1](../../Software/GRLL/GRLL/Common/vEstructOrganizMapper.cs#L1) |
| Software/GRLL/GRLL/Common/vObjetivo.cs | 205 | 4ec838e22b5b8192e4df099e6470a12ecad8afbe437db2ccdf1db1c3fc7dac2d | Versionado | [Software/GRLL/GRLL/Common/vObjetivo.cs:1](../../Software/GRLL/GRLL/Common/vObjetivo.cs#L1) |
| Software/GRLL/GRLL/Common/vReqXProgMesXProgramMes.cs | 259 | 0fdb5fcb111efdf1b406b4ed627e9263abda46171655f02863f2e71e9f013d7c | Versionado | [Software/GRLL/GRLL/Common/vReqXProgMesXProgramMes.cs:1](../../Software/GRLL/GRLL/Common/vReqXProgMesXProgramMes.cs#L1) |
| Software/GRLL/GRLL/Common/vistaUnidad.cs | 43 | cd4db19687bc3ee0091aadc02a85141a70b55246aedd4e315922e7ab30e4a825 | Versionado | [Software/GRLL/GRLL/Common/vistaUnidad.cs:1](../../Software/GRLL/GRLL/Common/vistaUnidad.cs#L1) |
| Software/GRLL/GRLL/Common/vs_ABA_AprobacionPedido.cs | 260 | 6e0f0353f4892f354a075f206b98fa7f26fa4379fe7a8b66acbe068c5a34a8df | Versionado | [Software/GRLL/GRLL/Common/vs_ABA_AprobacionPedido.cs:1](../../Software/GRLL/GRLL/Common/vs_ABA_AprobacionPedido.cs#L1) |
| Software/GRLL/GRLL/Common/vs_ABA_Departamentos.cs | 61 | f26406985b663b20e06e3ab67d3c512e03b340c5381cc4c8bd01294daa5bdf7c | Versionado | [Software/GRLL/GRLL/Common/vs_ABA_Departamentos.cs:1](../../Software/GRLL/GRLL/Common/vs_ABA_Departamentos.cs#L1) |
| Software/GRLL/GRLL/Common/vs_ABA_Distritos.cs | 133 | 56c26d35822525ca25f890468eb6ca9528317b037073e07cf6d9aa672ec77f1f | Versionado | [Software/GRLL/GRLL/Common/vs_ABA_Distritos.cs:1](../../Software/GRLL/GRLL/Common/vs_ABA_Distritos.cs#L1) |
| Software/GRLL/GRLL/Common/vs_ABA_GastoPublico.cs | 61 | 914c325438bd3f39b34f821d2363e1be9f29a9d350562ecdc8939d3938586a14 | Versionado | [Software/GRLL/GRLL/Common/vs_ABA_GastoPublico.cs:1](../../Software/GRLL/GRLL/Common/vs_ABA_GastoPublico.cs#L1) |
| Software/GRLL/GRLL/Common/vs_ABA_GastoPublicoMapper.cs | 17 | cfdb9615805b24f372146255aa5b1da73b8abc5cb0dee9de02142cbaf50ac1b6 | Versionado | [Software/GRLL/GRLL/Common/vs_ABA_GastoPublicoMapper.cs:1](../../Software/GRLL/GRLL/Common/vs_ABA_GastoPublicoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/vs_ABA_ListarAprobacionesPedido.cs | 170 | 43d9efc148f7b80c6f5eaa83ac2ae1aca5af2675acbd22972b238e126f1850f5 | Versionado | [Software/GRLL/GRLL/Common/vs_ABA_ListarAprobacionesPedido.cs:1](../../Software/GRLL/GRLL/Common/vs_ABA_ListarAprobacionesPedido.cs#L1) |
| Software/GRLL/GRLL/Common/vs_ABA_ListarBieneMapper.cs | 17 | 80f185f538fae4218f6a7197736e1b7ccbd7ff7cd53b1d3f5f5c7cc9145e5417 | Versionado | [Software/GRLL/GRLL/Common/vs_ABA_ListarBieneMapper.cs:1](../../Software/GRLL/GRLL/Common/vs_ABA_ListarBieneMapper.cs#L1) |
| Software/GRLL/GRLL/Common/vs_ABA_ListarBienes.cs | 314 | 7854b7d22733bdc1ce2dff269b4a62bebac3c8b4ad26c7c41cc10e0b0511d42e | Versionado | [Software/GRLL/GRLL/Common/vs_ABA_ListarBienes.cs:1](../../Software/GRLL/GRLL/Common/vs_ABA_ListarBienes.cs#L1) |
| Software/GRLL/GRLL/Common/vs_ABA_ListarCotizacion.cs | 116 | 36ae6c699d10ac1094b918d74a55c5f5c5758b6227ba66c7b36fc19cd295e668 | Versionado | [Software/GRLL/GRLL/Common/vs_ABA_ListarCotizacion.cs:1](../../Software/GRLL/GRLL/Common/vs_ABA_ListarCotizacion.cs#L1) |
| Software/GRLL/GRLL/Common/vs_ABA_ListarCotizacionMapper.cs | 17 | 1100c9b0df8e2cfb03c48523442332c02b1fb4a01d673920f071c329564a1183 | Versionado | [Software/GRLL/GRLL/Common/vs_ABA_ListarCotizacionMapper.cs:1](../../Software/GRLL/GRLL/Common/vs_ABA_ListarCotizacionMapper.cs#L1) |
| Software/GRLL/GRLL/Common/vs_ABA_ListarDetalleCotizacion.cs | 169 | 0d56fa8f00e8ffc93ab4f066b044afd1202932e3141b3ffb5e2ce01474f9b6c6 | Versionado | [Software/GRLL/GRLL/Common/vs_ABA_ListarDetalleCotizacion.cs:1](../../Software/GRLL/GRLL/Common/vs_ABA_ListarDetalleCotizacion.cs#L1) |
| Software/GRLL/GRLL/Common/vs_ABA_ListarDetalleCotizacionMapper.cs | 17 | 958d9036eac7f801e4515f78b2c5ea3f78b76638966d9ee284e487e430bfc51b | Versionado | [Software/GRLL/GRLL/Common/vs_ABA_ListarDetalleCotizacionMapper.cs:1](../../Software/GRLL/GRLL/Common/vs_ABA_ListarDetalleCotizacionMapper.cs#L1) |
| Software/GRLL/GRLL/Common/vs_ABA_ListarDetalleOrden.cs | 205 | 8cd23956552ed2ed3af7e1cdf49a61c856c43af794843d303c84a235e2e7ee91 | Versionado | [Software/GRLL/GRLL/Common/vs_ABA_ListarDetalleOrden.cs:1](../../Software/GRLL/GRLL/Common/vs_ABA_ListarDetalleOrden.cs#L1) |
| Software/GRLL/GRLL/Common/vs_ABA_ListarDetallePedido.cs | 295 | 35a433b1d5d402f0b64929b1e6120ac2b8f651acb8fbf0bcc49a2ee12fdd1276 | Versionado | [Software/GRLL/GRLL/Common/vs_ABA_ListarDetallePedido.cs:1](../../Software/GRLL/GRLL/Common/vs_ABA_ListarDetallePedido.cs#L1) |
| Software/GRLL/GRLL/Common/vs_ABA_ListarDetallePedidoMapper.cs | 17 | 9db898b0fbf6ad95410a31c94cde44792d66976b7b8e2ee9399b7c04b6ed617e | Versionado | [Software/GRLL/GRLL/Common/vs_ABA_ListarDetallePedidoMapper.cs:1](../../Software/GRLL/GRLL/Common/vs_ABA_ListarDetallePedidoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/vs_ABA_ListarMetas.cs | 151 | 50489baa515b74cf483bf03307e846e3991a9b5007f96c979193bcc288fd2298 | Versionado | [Software/GRLL/GRLL/Common/vs_ABA_ListarMetas.cs:1](../../Software/GRLL/GRLL/Common/vs_ABA_ListarMetas.cs#L1) |
| Software/GRLL/GRLL/Common/vs_ABA_ListarOrdenCompra.cs | 188 | 5041adfde3fd2f92d38d965dbe26ee5158a6d59b7f822a5f6d2853c4559cb37b | Versionado | [Software/GRLL/GRLL/Common/vs_ABA_ListarOrdenCompra.cs:1](../../Software/GRLL/GRLL/Common/vs_ABA_ListarOrdenCompra.cs#L1) |
| Software/GRLL/GRLL/Common/vs_ABA_ListarOrdenCompraMapper.cs | 17 | 1be7c93ba5d603fc5998d615236fe92fa7dbd2721393f8ea6641604f5f3e0407 | Versionado | [Software/GRLL/GRLL/Common/vs_ABA_ListarOrdenCompraMapper.cs:1](../../Software/GRLL/GRLL/Common/vs_ABA_ListarOrdenCompraMapper.cs#L1) |
| Software/GRLL/GRLL/Common/vs_ABA_ListarPedidoMapper.cs | 17 | a5874ac9a6281fb81161de4f8d4b0918135e7ab0782505b5ae436a909abb4901 | Versionado | [Software/GRLL/GRLL/Common/vs_ABA_ListarPedidoMapper.cs:1](../../Software/GRLL/GRLL/Common/vs_ABA_ListarPedidoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/vs_ABA_ListarPedidos.cs | 296 | ae3a6f4d3efa837f0973afee13108a21b204cdd76f5baa3e119d70d5b2db8505 | Versionado | [Software/GRLL/GRLL/Common/vs_ABA_ListarPedidos.cs:1](../../Software/GRLL/GRLL/Common/vs_ABA_ListarPedidos.cs#L1) |
| Software/GRLL/GRLL/Common/vs_ABA_ListarTrabajador.cs | 61 | 168c2c4cf6904d9aefe9eb7fdcd912cd1e653977588678079e8f768024a8516a | Versionado | [Software/GRLL/GRLL/Common/vs_ABA_ListarTrabajador.cs:1](../../Software/GRLL/GRLL/Common/vs_ABA_ListarTrabajador.cs#L1) |
| Software/GRLL/GRLL/Common/vs_ABA_Proveedor.cs | 224 | 87879b5087ce9f112ecd15dcc26be0eb50a04cd681e14572711cc7be665570a4 | Versionado | [Software/GRLL/GRLL/Common/vs_ABA_Proveedor.cs:1](../../Software/GRLL/GRLL/Common/vs_ABA_Proveedor.cs#L1) |
| Software/GRLL/GRLL/Common/vs_ABA_Proveedores.cs | 224 | 86fffc024071a2007e04bf260d8e5feac83426aed3230dc20730cc9b67ac14c8 | Versionado | [Software/GRLL/GRLL/Common/vs_ABA_Proveedores.cs:1](../../Software/GRLL/GRLL/Common/vs_ABA_Proveedores.cs#L1) |
| Software/GRLL/GRLL/Common/vs_ABA_Provincias.cs | 97 | 873acf3137e6001760e77c95bc3649da7174c5506c3ba0de9565111f5bad432f | Versionado | [Software/GRLL/GRLL/Common/vs_ABA_Provincias.cs:1](../../Software/GRLL/GRLL/Common/vs_ABA_Provincias.cs#L1) |
| Software/GRLL/GRLL/Common/vs_ABA_Ubigeo.cs | 97 | 7f814359e7d2ab5e8e90d39699be62442c7352185f403bee023798ecd62bf9c1 | Versionado | [Software/GRLL/GRLL/Common/vs_ABA_Ubigeo.cs:1](../../Software/GRLL/GRLL/Common/vs_ABA_Ubigeo.cs#L1) |
| Software/GRLL/GRLL/Common/vs_ABA_UnidadEquivalencia.cs | 133 | 985f87606b67e8e5ed2be27cf8a2500ae1f1d03dda578b537436203457044619 | Versionado | [Software/GRLL/GRLL/Common/vs_ABA_UnidadEquivalencia.cs:1](../../Software/GRLL/GRLL/Common/vs_ABA_UnidadEquivalencia.cs#L1) |
| Software/GRLL/GRLL/Common/vs_CJR_NormaReg.cs | 188 | 8fb5e456f8bb8758f57225808d23bbeb5666f49793c6a75c3cede9dfbdf27c0f | Versionado | [Software/GRLL/GRLL/Common/vs_CJR_NormaReg.cs:1](../../Software/GRLL/GRLL/Common/vs_CJR_NormaReg.cs#L1) |
| Software/GRLL/GRLL/Common/vs_CJR_OficioSol.cs | 260 | 3932c140e0b67cbbafafb68e91860fb506632fa22db942ed2e24253175e98a8f | Versionado | [Software/GRLL/GRLL/Common/vs_CJR_OficioSol.cs:1](../../Software/GRLL/GRLL/Common/vs_CJR_OficioSol.cs#L1) |
| Software/GRLL/GRLL/Common/vs_CJR_Proyecto.cs | 350 | 2b3966ae96992d33b3c9e8ef7e5abe3af6365e70f845c37de57070e32cc0c825 | Versionado | [Software/GRLL/GRLL/Common/vs_CJR_Proyecto.cs:1](../../Software/GRLL/GRLL/Common/vs_CJR_Proyecto.cs#L1) |
| Software/GRLL/GRLL/Common/vs_CJr_Norma.cs | 260 | 8dae63b9f5ddea54422c89bfad7c1ca1502e3ef3527a34705fc8e08919af829c | Versionado | [Software/GRLL/GRLL/Common/vs_CJr_Norma.cs:1](../../Software/GRLL/GRLL/Common/vs_CJr_Norma.cs#L1) |
| Software/GRLL/GRLL/Common/vs_CJr_ProyectoNor.cs | 314 | 3b0d6a88d7268f28246e32dd8f324843b7a6152d293d533ff699cbb70c849c75 | Versionado | [Software/GRLL/GRLL/Common/vs_CJr_ProyectoNor.cs:1](../../Software/GRLL/GRLL/Common/vs_CJr_ProyectoNor.cs#L1) |
| Software/GRLL/GRLL/Common/vs_Faltas.cs | 224 | 029698238f231e8d5622eaacc1dbf5d629d2be62fb7bca4a2cc6c7218c514438 | Versionado | [Software/GRLL/GRLL/Common/vs_Faltas.cs:1](../../Software/GRLL/GRLL/Common/vs_Faltas.cs#L1) |
| Software/GRLL/GRLL/Common/vs_GetEmpleado.cs | 205 | b2566142cd52f87ddd1cb10e8afb1aee3537071db6c45183a724f6d749d51550 | Versionado | [Software/GRLL/GRLL/Common/vs_GetEmpleado.cs:1](../../Software/GRLL/GRLL/Common/vs_GetEmpleado.cs#L1) |
| Software/GRLL/GRLL/Common/vs_PER_ListarEmpleadoMapper.cs | 17 | 4c73b324f21f82c21b78bfe2ef3aa7024a02000eb5bbe3d52aa66bdc167313b4 | Versionado | [Software/GRLL/GRLL/Common/vs_PER_ListarEmpleadoMapper.cs:1](../../Software/GRLL/GRLL/Common/vs_PER_ListarEmpleadoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/vs_PER_ListarEmpleados.cs | 169 | 45bf9bb36a5b8ba60b0e7ad3728cad35eb65e4f60969c1026693cf2209f5bb5f | Versionado | [Software/GRLL/GRLL/Common/vs_PER_ListarEmpleados.cs:1](../../Software/GRLL/GRLL/Common/vs_PER_ListarEmpleados.cs#L1) |
| Software/GRLL/GRLL/Common/vs_PTI_ListarOrganigrama.cs | 133 | 0ee0589c9007c99981aa66d423d90f4722874efc8e80146808fca60d4c37366a | Versionado | [Software/GRLL/GRLL/Common/vs_PTI_ListarOrganigrama.cs:1](../../Software/GRLL/GRLL/Common/vs_PTI_ListarOrganigrama.cs#L1) |
| Software/GRLL/GRLL/Common/vs_RRHH_FamFicha.cs | 151 | f5bfa5dcfd692334a10ac7c091b5f658e8e7c237f51fac6372790632fb89b234 | Versionado | [Software/GRLL/GRLL/Common/vs_RRHH_FamFicha.cs:1](../../Software/GRLL/GRLL/Common/vs_RRHH_FamFicha.cs#L1) |
| Software/GRLL/GRLL/Common/vs_RRHH_FichaSocial.cs | 1323 | 34e220fd08a51501e04da44b36a1a83b88057d98794e26ec43d1c6b537201005 | Versionado | [Software/GRLL/GRLL/Common/vs_RRHH_FichaSocial.cs:1](../../Software/GRLL/GRLL/Common/vs_RRHH_FichaSocial.cs#L1) |
| Software/GRLL/GRLL/Common/vs_RRHH_buscarEmpleado.cs | 169 | 730e260f6738fc3bcb2d17656e25bf6344b0d71889e50a1cb903749562844cd3 | Versionado | [Software/GRLL/GRLL/Common/vs_RRHH_buscarEmpleado.cs:1](../../Software/GRLL/GRLL/Common/vs_RRHH_buscarEmpleado.cs#L1) |
| Software/GRLL/GRLL/Common/vs_SEG_usuario.cs | 97 | f9b2ab0006995a476bc602e2f2274b901860820a0b91d4b9265f0966b4157abc | Versionado | [Software/GRLL/GRLL/Common/vs_SEG_usuario.cs:1](../../Software/GRLL/GRLL/Common/vs_SEG_usuario.cs#L1) |
| Software/GRLL/GRLL/Common/vs_TRA_ListarEtapaProcedimiento.cs | 367 | 98a44529b858708e05c00d6f38ecd21cf1d198a53f134dc1fd5b3bd7a303a282 | Versionado | [Software/GRLL/GRLL/Common/vs_TRA_ListarEtapaProcedimiento.cs:1](../../Software/GRLL/GRLL/Common/vs_TRA_ListarEtapaProcedimiento.cs#L1) |
| Software/GRLL/GRLL/Common/vs_TRA_ListarEtapaProcedimientoMapper.cs | 17 | 76d1d8687bedddc819162bbe6430f451c104aef0e6755dde1f05ffbf90edd880 | Versionado | [Software/GRLL/GRLL/Common/vs_TRA_ListarEtapaProcedimientoMapper.cs:1](../../Software/GRLL/GRLL/Common/vs_TRA_ListarEtapaProcedimientoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/vs_TRA_ListarInicioArea.cs | 169 | 1860597a8539904960b0cd2addafcb70980976d02de5477b1b4f640555ae4db3 | Versionado | [Software/GRLL/GRLL/Common/vs_TRA_ListarInicioArea.cs:1](../../Software/GRLL/GRLL/Common/vs_TRA_ListarInicioArea.cs#L1) |
| Software/GRLL/GRLL/Common/vs_TRA_ListarInicioAreaMapper.cs | 17 | 617ecfb3d22c6e42a4b496f8922882067d9a6575598f1587c3e60af84cdf5028 | Versionado | [Software/GRLL/GRLL/Common/vs_TRA_ListarInicioAreaMapper.cs:1](../../Software/GRLL/GRLL/Common/vs_TRA_ListarInicioAreaMapper.cs#L1) |
| Software/GRLL/GRLL/Common/vs_TRA_ListarMovimiento.cs | 548 | 79d698b610cb667f92323ae9b90475b9c8c4df64256def6522d425b9c344c7f6 | Versionado | [Software/GRLL/GRLL/Common/vs_TRA_ListarMovimiento.cs:1](../../Software/GRLL/GRLL/Common/vs_TRA_ListarMovimiento.cs#L1) |
| Software/GRLL/GRLL/Common/vs_TRA_ListarMovimientoMapper.cs | 17 | c2794a9382091534f681c7148ad6ceb440670a830fea1225403b58ae5072979c | Versionado | [Software/GRLL/GRLL/Common/vs_TRA_ListarMovimientoMapper.cs:1](../../Software/GRLL/GRLL/Common/vs_TRA_ListarMovimientoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/vs_TRA_ListarProcedimiento.cs | 313 | da4e83a55a3a5401d0bd12570679e584f53867c6e077161e6cb8a5dd02240d96 | Versionado | [Software/GRLL/GRLL/Common/vs_TRA_ListarProcedimiento.cs:1](../../Software/GRLL/GRLL/Common/vs_TRA_ListarProcedimiento.cs#L1) |
| Software/GRLL/GRLL/Common/vs_TRA_ListarProcedimientoMant.cs | 223 | 5ff6e48cdf8ab552c796069c874f240f857e829aaa567f82bcc48de361ae63d8 | Versionado | [Software/GRLL/GRLL/Common/vs_TRA_ListarProcedimientoMant.cs:1](../../Software/GRLL/GRLL/Common/vs_TRA_ListarProcedimientoMant.cs#L1) |
| Software/GRLL/GRLL/Common/vs_TRA_ListarProcedimientoMapper.cs | 17 | 691836bd3c9a3e51eccb4492f66be6da1e38dfe1c400251c6d0f208fbfef1dc6 | Versionado | [Software/GRLL/GRLL/Common/vs_TRA_ListarProcedimientoMapper.cs:1](../../Software/GRLL/GRLL/Common/vs_TRA_ListarProcedimientoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/vs_TRA_ListarTramite.cs | 458 | 8078b2b3a2381ced3f5143985d11ab58151cf1b38c9370c3b3275cbddf6fddf3 | Versionado | [Software/GRLL/GRLL/Common/vs_TRA_ListarTramite.cs:1](../../Software/GRLL/GRLL/Common/vs_TRA_ListarTramite.cs#L1) |
| Software/GRLL/GRLL/Common/vs_TRA_ListarTramiteMapper.cs | 17 | 5d36a2a3783537525b8ede738682e79f043f0442394dedf6b3d1fc0e7e8d0f03 | Versionado | [Software/GRLL/GRLL/Common/vs_TRA_ListarTramiteMapper.cs:1](../../Software/GRLL/GRLL/Common/vs_TRA_ListarTramiteMapper.cs#L1) |
| Software/GRLL/GRLL/Common/vs_aba_CorrelativoBien.cs | 79 | 5f9595bcc90c436d885ced2cfcfe4d666c0f24bf48149b87533cdd8c1973b362 | Versionado | [Software/GRLL/GRLL/Common/vs_aba_CorrelativoBien.cs:1](../../Software/GRLL/GRLL/Common/vs_aba_CorrelativoBien.cs#L1) |
| Software/GRLL/GRLL/Common/vs_aba_CorrelativoBienMapper.cs | 17 | 9fbfef25becf13adb772cb86896fe04513a39403253cc5dfad156dd1aaae1b21 | Versionado | [Software/GRLL/GRLL/Common/vs_aba_CorrelativoBienMapper.cs:1](../../Software/GRLL/GRLL/Common/vs_aba_CorrelativoBienMapper.cs#L1) |
| Software/GRLL/GRLL/Common/vs_aba_Detalle.cs | 313 | 3993206d24afe6fab7becc480df7bd823785b6443eff7dd24605e8ac2f8a23b9 | Versionado | [Software/GRLL/GRLL/Common/vs_aba_Detalle.cs:1](../../Software/GRLL/GRLL/Common/vs_aba_Detalle.cs#L1) |
| Software/GRLL/GRLL/Common/vs_aba_DetalleMapper.cs | 17 | db0d4a5ca408d71fcb9cad89a9f1b1890c9980306220a7cb0c7a545f5b33bca8 | Versionado | [Software/GRLL/GRLL/Common/vs_aba_DetalleMapper.cs:1](../../Software/GRLL/GRLL/Common/vs_aba_DetalleMapper.cs#L1) |
| Software/GRLL/GRLL/Common/vs_aba_MetaFull.cs | 61 | 17c88760beff025825aaa22387ec985412a017cd3810a041cf03a6088dfcd5d3 | Versionado | [Software/GRLL/GRLL/Common/vs_aba_MetaFull.cs:1](../../Software/GRLL/GRLL/Common/vs_aba_MetaFull.cs#L1) |
| Software/GRLL/GRLL/Common/vs_aba_NroBien.cs | 79 | 92f69b5cdd2f1c46a7dce1bcafc1910e393db8cfff6fc21feed7fbeb7be85364 | Versionado | [Software/GRLL/GRLL/Common/vs_aba_NroBien.cs:1](../../Software/GRLL/GRLL/Common/vs_aba_NroBien.cs#L1) |
| Software/GRLL/GRLL/Common/vs_aba_NroBienMapper.cs | 17 | 0e9fe3724aae07e6cd6c53392f7efc5e8773551181017214b40b712c249fd3bd | Versionado | [Software/GRLL/GRLL/Common/vs_aba_NroBienMapper.cs:1](../../Software/GRLL/GRLL/Common/vs_aba_NroBienMapper.cs#L1) |
| Software/GRLL/GRLL/Common/vs_aba_NroMaxMovimiento.cs | 61 | b459d940194be310e060f8f8c29397bf251e1070bc210058e93f5fa2bc8ae337 | Versionado | [Software/GRLL/GRLL/Common/vs_aba_NroMaxMovimiento.cs:1](../../Software/GRLL/GRLL/Common/vs_aba_NroMaxMovimiento.cs#L1) |
| Software/GRLL/GRLL/Common/vs_aba_listarmetasMapper.cs | 17 | 2e664f2d68e556158e69caa356dbd879cc416b858274c4a7f1073da5b3973922 | Versionado | [Software/GRLL/GRLL/Common/vs_aba_listarmetasMapper.cs:1](../../Software/GRLL/GRLL/Common/vs_aba_listarmetasMapper.cs#L1) |
| Software/GRLL/GRLL/Common/vs_aba_metafullMapper.cs | 17 | ca6c0a68212db81f995052cc2abc3a6b3230aa4a417718f78148dfd9c20121ca | Versionado | [Software/GRLL/GRLL/Common/vs_aba_metafullMapper.cs:1](../../Software/GRLL/GRLL/Common/vs_aba_metafullMapper.cs#L1) |
| Software/GRLL/GRLL/Common/vs_aba_proveedorMapper.cs | 17 | 0b13ae0e2e1d2453e02baff8e48a7d261e1dba17983c2114607a8baa1be53292 | Versionado | [Software/GRLL/GRLL/Common/vs_aba_proveedorMapper.cs:1](../../Software/GRLL/GRLL/Common/vs_aba_proveedorMapper.cs#L1) |
| Software/GRLL/GRLL/Common/vs_tra_ListarMovimientoTiempo.cs | 656 | 7bb2db38e333688c132cc2bfb06da2f0eff5bb3d70e4b6d2177c012556c28101 | Versionado | [Software/GRLL/GRLL/Common/vs_tra_ListarMovimientoTiempo.cs:1](../../Software/GRLL/GRLL/Common/vs_tra_ListarMovimientoTiempo.cs#L1) |
| Software/GRLL/GRLL/Common/vs_tra_ListarMovimientoTiempoMapper.cs | 17 | a574904a38bd1a0ddbad5349a56e08cef2488d2e9def40f7a9ee23093954bb70 | Versionado | [Software/GRLL/GRLL/Common/vs_tra_ListarMovimientoTiempoMapper.cs:1](../../Software/GRLL/GRLL/Common/vs_tra_ListarMovimientoTiempoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/vs_tra_ListarProcArea.cs | 205 | bc636a91db35c391264644c51d47ad6e0f69997c1639337cf251b1a5e4fea7fb | Versionado | [Software/GRLL/GRLL/Common/vs_tra_ListarProcArea.cs:1](../../Software/GRLL/GRLL/Common/vs_tra_ListarProcArea.cs#L1) |
| Software/GRLL/GRLL/Common/vs_tra_ListarProcAreaMapper.cs | 17 | 0825d397a2abc558deb00e094f3f886e120e6c5e167b0280dd04b9d3318a8a2c | Versionado | [Software/GRLL/GRLL/Common/vs_tra_ListarProcAreaMapper.cs:1](../../Software/GRLL/GRLL/Common/vs_tra_ListarProcAreaMapper.cs#L1) |
| Software/GRLL/GRLL/Common/vs_tra_Puntualidad_Tramite.cs | 134 | 8042a10468c9e3e812b632cfa0fb5ce97a9bf713b90f972eadb45abb7cb5d704 | Versionado | [Software/GRLL/GRLL/Common/vs_tra_Puntualidad_Tramite.cs:1](../../Software/GRLL/GRLL/Common/vs_tra_Puntualidad_Tramite.cs#L1) |
| Software/GRLL/GRLL/Common/vs_tra_Usuario_Tramite_PC_IP.cs | 79 | 14b508ee5322952eaf7d62ffb3f0915b827d55be9ef68765d09d0bce1691b0ea | Versionado | [Software/GRLL/GRLL/Common/vs_tra_Usuario_Tramite_PC_IP.cs:1](../../Software/GRLL/GRLL/Common/vs_tra_Usuario_Tramite_PC_IP.cs#L1) |
| Software/GRLL/GRLL/Common/vs_tra_Usuario_online.cs | 259 | a1ef445bca13760871a651f3606707aa3f3e867ece1110c49a8271cca4eca188 | Versionado | [Software/GRLL/GRLL/Common/vs_tra_Usuario_online.cs:1](../../Software/GRLL/GRLL/Common/vs_tra_Usuario_online.cs#L1) |
| Software/GRLL/GRLL/Common/vs_tra_Usuario_onlineMapper.cs | 17 | 0000dedb04935d91220525add061792ff081827a91c4caa961025d48cd94f360 | Versionado | [Software/GRLL/GRLL/Common/vs_tra_Usuario_onlineMapper.cs:1](../../Software/GRLL/GRLL/Common/vs_tra_Usuario_onlineMapper.cs#L1) |
| Software/GRLL/GRLL/Common/vs_tra_listar_movimiento_tramite.cs | 1034 | f4c3d79d5848ae36fcdd082a62ef9f3539582aa6eeda6f04f800a1533c1a314c | Versionado | [Software/GRLL/GRLL/Common/vs_tra_listar_movimiento_tramite.cs:1](../../Software/GRLL/GRLL/Common/vs_tra_listar_movimiento_tramite.cs#L1) |
| Software/GRLL/GRLL/Common/vs_tra_listar_movimiento_tramiteGMapper.cs | 17 | c149abc72adf172f57c3d867602d05de7f0016e1939cbb55441db622fd30a967 | Versionado | [Software/GRLL/GRLL/Common/vs_tra_listar_movimiento_tramiteGMapper.cs:1](../../Software/GRLL/GRLL/Common/vs_tra_listar_movimiento_tramiteGMapper.cs#L1) |
| Software/GRLL/GRLL/Common/vs_tra_listar_movimiento_tramiteMapper.cs | 17 | ee61b85ee40355c470ea7878956d2bccf0e9a66d21392cb1731b61e024d3db14 | Versionado | [Software/GRLL/GRLL/Common/vs_tra_listar_movimiento_tramiteMapper.cs:1](../../Software/GRLL/GRLL/Common/vs_tra_listar_movimiento_tramiteMapper.cs#L1) |
| Software/GRLL/GRLL/Common/vs_tra_listar_movimiento_tramite_G.cs | 998 | 0f465fe731f557ce2e46075e03fc6762a51ddad685ccbef1f4e75bd21c21c6f6 | Versionado | [Software/GRLL/GRLL/Common/vs_tra_listar_movimiento_tramite_G.cs:1](../../Software/GRLL/GRLL/Common/vs_tra_listar_movimiento_tramite_G.cs#L1) |
| Software/GRLL/GRLL/Common/vs_tra_proc_etapa_area_cargo.cs | 151 | f7acf893a360d1757de7b626a7a42a67b96b887122971a956e0fdd369a9fa698 | Versionado | [Software/GRLL/GRLL/Common/vs_tra_proc_etapa_area_cargo.cs:1](../../Software/GRLL/GRLL/Common/vs_tra_proc_etapa_area_cargo.cs#L1) |
| Software/GRLL/GRLL/Common/vs_tra_proc_etapa_area_cargoMapper.cs | 17 | 84c81d8832f349b24cd345e9af560772cd0942938b13c08654bb400a80c9c6c3 | Versionado | [Software/GRLL/GRLL/Common/vs_tra_proc_etapa_area_cargoMapper.cs:1](../../Software/GRLL/GRLL/Common/vs_tra_proc_etapa_area_cargoMapper.cs#L1) |
| Software/GRLL/GRLL/Common/vs_tra_usuario_area_cargo.cs | 205 | 1059feade546ebbc079d4f876e33ad03f8af44a08bf534627cfb9200024f95d7 | Versionado | [Software/GRLL/GRLL/Common/vs_tra_usuario_area_cargo.cs:1](../../Software/GRLL/GRLL/Common/vs_tra_usuario_area_cargo.cs#L1) |
| Software/GRLL/GRLL/Common/vs_tra_usuario_area_cargoMapper.cs | 17 | eeee4088579c5d9168e7c696c9c2b2ca6dbb363d79ae6deda00871738e9a9c65 | Versionado | [Software/GRLL/GRLL/Common/vs_tra_usuario_area_cargoMapper.cs:1](../../Software/GRLL/GRLL/Common/vs_tra_usuario_area_cargoMapper.cs#L1) |
| Software/GRLL/Properties/AssemblyInfo.cs | 15 | e55ca91da2387e2305d945ba940e3f3b4e32f7cb7202952ed958d1c908782ff0 | Versionado | [Software/GRLL/Properties/AssemblyInfo.cs:1](../../Software/GRLL/Properties/AssemblyInfo.cs#L1) |
| Software/GRLL/VB-AnonymousType_0.cs | 0 | e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855 | Versionado | [Software/GRLL/VB-AnonymousType_0.cs (archivo vacío)](../../Software/GRLL/VB-AnonymousType_0.cs) |
| Software/RRHH.Application/Asistencia/EliminarFeriado.cs | 28 | ec714ce7a03986686eaac8e7f53cffd62e11dd93108daca7482366d562f8b772 | Versionado | [Software/RRHH.Application/Asistencia/EliminarFeriado.cs:1](../../Software/RRHH.Application/Asistencia/EliminarFeriado.cs#L1) |
| Software/RRHH.Application/Asistencia/EliminarHorario.cs | 24 | 941d0f0225f2e6d03b11e52760c4a031798bb77feca7f53b0dad12b583504c42 | Versionado | [Software/RRHH.Application/Asistencia/EliminarHorario.cs:1](../../Software/RRHH.Application/Asistencia/EliminarHorario.cs#L1) |
| Software/RRHH.Application/Asistencia/FeriadoDto.cs | 15 | 8701089731e5bd6d49c0db9337bf83c5afe36073ee6f7d572c26827f30684a51 | Versionado | [Software/RRHH.Application/Asistencia/FeriadoDto.cs:1](../../Software/RRHH.Application/Asistencia/FeriadoDto.cs#L1) |
| Software/RRHH.Application/Asistencia/GuardarHorario.cs | 31 | ff87acb49d97e2fc3814567ec3d5c7bcb7f540a81b133c5d295d830115c24a3d | Versionado | [Software/RRHH.Application/Asistencia/GuardarHorario.cs:1](../../Software/RRHH.Application/Asistencia/GuardarHorario.cs#L1) |
| Software/RRHH.Application/Asistencia/HorarioDto.cs | 13 | 8b107f0b2cd5c713e370f95f5ba8abd437f3f6954669bdce9dbe07c3ba0537df | Versionado | [Software/RRHH.Application/Asistencia/HorarioDto.cs:1](../../Software/RRHH.Application/Asistencia/HorarioDto.cs#L1) |
| Software/RRHH.Application/Asistencia/IFeriadoRepository.cs | 23 | 274267b91b4a473ecf69bf3e43dba8d2503f5445ea8d25bd088723d109bd331e | Versionado | [Software/RRHH.Application/Asistencia/IFeriadoRepository.cs:1](../../Software/RRHH.Application/Asistencia/IFeriadoRepository.cs#L1) |
| Software/RRHH.Application/Asistencia/IHorarioRepository.cs | 19 | 02028aa4039df243806a2e96d280d89c21c4d912fce6c0d7e9b689f7c087f93b | Versionado | [Software/RRHH.Application/Asistencia/IHorarioRepository.cs:1](../../Software/RRHH.Application/Asistencia/IHorarioRepository.cs#L1) |
| Software/RRHH.Application/Asistencia/ListarFeriados.cs | 30 | c02988393211d4aaafa5a3fc05e5fd44c21b49b642116269cfe2acff3508a470 | Versionado | [Software/RRHH.Application/Asistencia/ListarFeriados.cs:1](../../Software/RRHH.Application/Asistencia/ListarFeriados.cs#L1) |
| Software/RRHH.Application/Asistencia/ListarHorarios.cs | 12 | 45406bae21b1889e667c196e00b394f896ea64c9fc2843cb3f902d5476b71133 | Versionado | [Software/RRHH.Application/Asistencia/ListarHorarios.cs:1](../../Software/RRHH.Application/Asistencia/ListarHorarios.cs#L1) |
| Software/RRHH.Application/Asistencia/ObtenerHorario.cs | 17 | df55d8193366039d0ad258767792aff0b15c1c6603653b30703c4ebab62f3bf1 | Versionado | [Software/RRHH.Application/Asistencia/ObtenerHorario.cs:1](../../Software/RRHH.Application/Asistencia/ObtenerHorario.cs#L1) |
| Software/RRHH.Application/Asistencia/RegistrarFeriado.cs | 49 | 7d4a75a838ec70badf9aa091d64fff3edd3f9f610287c83e84d975ce6d608185 | Versionado | [Software/RRHH.Application/Asistencia/RegistrarFeriado.cs:1](../../Software/RRHH.Application/Asistencia/RegistrarFeriado.cs#L1) |
| Software/RRHH.Application/Asistencia/RegistrarFeriadoDto.cs | 15 | b1358bfea85f6b22cb9271efe5df42027438f5aebd3771067914e765ed34c2d5 | Versionado | [Software/RRHH.Application/Asistencia/RegistrarFeriadoDto.cs:1](../../Software/RRHH.Application/Asistencia/RegistrarFeriadoDto.cs#L1) |
| Software/RRHH.Application/Catalogos/EliminarItemCatalogo.cs | 27 | 1f93b1f1567ca2896bdc42e6e11b6ffe8f3320ccbde079e2b074e34c1c92d67b | Versionado | [Software/RRHH.Application/Catalogos/EliminarItemCatalogo.cs:1](../../Software/RRHH.Application/Catalogos/EliminarItemCatalogo.cs#L1) |
| Software/RRHH.Application/Catalogos/GuardarItemCatalogo.cs | 54 | 6fd1fe8ca1a50d5790d07a82fc5d41ce3088e56f49ab77d678cc60ec8ef1cc7d | Versionado | [Software/RRHH.Application/Catalogos/GuardarItemCatalogo.cs:1](../../Software/RRHH.Application/Catalogos/GuardarItemCatalogo.cs#L1) |
| Software/RRHH.Application/Catalogos/ICatalogoRepository.cs | 20 | f5c58d1586120d760883d9779f91812ac7d8f27e8da9ef20a5671f4d76bffe14 | Versionado | [Software/RRHH.Application/Catalogos/ICatalogoRepository.cs:1](../../Software/RRHH.Application/Catalogos/ICatalogoRepository.cs#L1) |
| Software/RRHH.Application/Catalogos/ItemCatalogoDto.cs | 17 | e5f5685517039041a44df2a351960598c4b2c3de445f5895410d0270de94bf54 | Versionado | [Software/RRHH.Application/Catalogos/ItemCatalogoDto.cs:1](../../Software/RRHH.Application/Catalogos/ItemCatalogoDto.cs#L1) |
| Software/RRHH.Application/Catalogos/ListarCatalogo.cs | 27 | c08c6c58fb517761044b8f89e30f57121811568ca5472f54c036fd8cb47f92a5 | Versionado | [Software/RRHH.Application/Catalogos/ListarCatalogo.cs:1](../../Software/RRHH.Application/Catalogos/ListarCatalogo.cs#L1) |
| Software/RRHH.Application/Comun/RegistroEnUsoException.cs | 15 | c788db563c994abafdc4f6ddb5f1726e5680c4389a46c306898c497dfe55b602 | Versionado | [Software/RRHH.Application/Comun/RegistroEnUsoException.cs:1](../../Software/RRHH.Application/Comun/RegistroEnUsoException.cs#L1) |
| Software/RRHH.Application/Comun/ResultadoOperacion.cs | 20 | 21fccc99e8520991d201f37c6f6edd76b4274eee737ad84730da663cff07183f | Versionado | [Software/RRHH.Application/Comun/ResultadoOperacion.cs:1](../../Software/RRHH.Application/Comun/ResultadoOperacion.cs#L1) |
| Software/RRHH.Application/Permisos/EliminarMotivoPermiso.cs | 41 | afea6f5a9f1f08e9e40ac887de8b7c803d590b6ca53d90fa6ec3f0783a082409 | Versionado | [Software/RRHH.Application/Permisos/EliminarMotivoPermiso.cs:1](../../Software/RRHH.Application/Permisos/EliminarMotivoPermiso.cs#L1) |
| Software/RRHH.Application/Permisos/GuardarMotivoPermiso.cs | 57 | 21ae8bfd66ee9720ad9e87a8a1f002471641d21cee80342ec0bbbb05f4c3063e | Versionado | [Software/RRHH.Application/Permisos/GuardarMotivoPermiso.cs:1](../../Software/RRHH.Application/Permisos/GuardarMotivoPermiso.cs#L1) |
| Software/RRHH.Application/Permisos/IMotivoPermisoRepository.cs | 32 | 64e3b4c57f4f30bd46647bf37928d0c6f15d218322a1319b55e394ad7b4cc00a | Versionado | [Software/RRHH.Application/Permisos/IMotivoPermisoRepository.cs:1](../../Software/RRHH.Application/Permisos/IMotivoPermisoRepository.cs#L1) |
| Software/RRHH.Application/Permisos/ListarMotivosPermiso.cs | 29 | a787de5633e4813b2b255ab5dba5f23cafa67a193dae4c722509e10390bde185 | Versionado | [Software/RRHH.Application/Permisos/ListarMotivosPermiso.cs:1](../../Software/RRHH.Application/Permisos/ListarMotivosPermiso.cs#L1) |
| Software/RRHH.Application/Permisos/MotivoPermisoDto.cs | 23 | 6858d690753be12727ab0fee9fc857aba5ae7f2a6e2117cea580ce2187c90324 | Versionado | [Software/RRHH.Application/Permisos/MotivoPermisoDto.cs:1](../../Software/RRHH.Application/Permisos/MotivoPermisoDto.cs#L1) |
| Software/RRHH.Application/Permisos/ObtenerMotivoPermiso.cs | 28 | 35bc277493d8a934a85062f9e312ce18554a9b094b2aeb393c607e591b630155 | Versionado | [Software/RRHH.Application/Permisos/ObtenerMotivoPermiso.cs:1](../../Software/RRHH.Application/Permisos/ObtenerMotivoPermiso.cs#L1) |
| Software/RRHH.Application/Seguridad/AccesoUsuario.cs | 34 | 65ad4608bb809644c685bfa1d78350fffaa81a463a6029b4c3c2f8b8e70c40c5 | Versionado | [Software/RRHH.Application/Seguridad/AccesoUsuario.cs:1](../../Software/RRHH.Application/Seguridad/AccesoUsuario.cs#L1) |
| Software/RRHH.Application/Seguridad/IAccesoUsuarioRepository.cs | 12 | 9fad2b508e79491ead72673307cf867e186cb9bc40f7ec36554475aaf271afb8 | Versionado | [Software/RRHH.Application/Seguridad/IAccesoUsuarioRepository.cs:1](../../Software/RRHH.Application/Seguridad/IAccesoUsuarioRepository.cs#L1) |
| Software/RRHH.Application/Seguridad/ObtenerAccesoUsuario.cs | 31 | d363c1f54005ad7e34f2cb58516ce703df20dc8a779f6d33af717393b862cae5 | Versionado | [Software/RRHH.Application/Seguridad/ObtenerAccesoUsuario.cs:1](../../Software/RRHH.Application/Seguridad/ObtenerAccesoUsuario.cs#L1) |
| Software/RRHH.Application/Seguridad/Pbkdf2PasswordHasher.cs | 103 | e1d48b1ff96b441f5d61620865ae296a8796336c3b3e7d17e01aa54dbf3fe8f0 | Versionado | [Software/RRHH.Application/Seguridad/Pbkdf2PasswordHasher.cs:1](../../Software/RRHH.Application/Seguridad/Pbkdf2PasswordHasher.cs#L1) |
| Software/RRHH.Domain/Asistencia/Feriado.cs | 74 | a9f2d760648365db09947056a1c2bf5f513dd33d660f754f5a487cb2f2861cd2 | Versionado | [Software/RRHH.Domain/Asistencia/Feriado.cs:1](../../Software/RRHH.Domain/Asistencia/Feriado.cs#L1) |
| Software/RRHH.Domain/Asistencia/Horario.cs | 55 | 98bb3f0cdd6fb3c12bd383f96359216d9eda9f66855bae994cfc846000cbe5a9 | Versionado | [Software/RRHH.Domain/Asistencia/Horario.cs:1](../../Software/RRHH.Domain/Asistencia/Horario.cs#L1) |
| Software/RRHH.Domain/Catalogos/DefinicionCatalogo.cs | 78 | 3eefe4c6ac27954c444a78dd160a9cc422838bb55654a9218f27eef9ce174310 | Versionado | [Software/RRHH.Domain/Catalogos/DefinicionCatalogo.cs:1](../../Software/RRHH.Domain/Catalogos/DefinicionCatalogo.cs#L1) |
| Software/RRHH.Domain/Catalogos/DefinicionesCatalogo.cs | 36 | cb615154153f2f566e63589a5191beaa78569e4760a878fe1b030c4cafaa0a64 | Versionado | [Software/RRHH.Domain/Catalogos/DefinicionesCatalogo.cs:1](../../Software/RRHH.Domain/Catalogos/DefinicionesCatalogo.cs#L1) |
| Software/RRHH.Domain/Catalogos/ItemCatalogo.cs | 58 | 29879c994a1b7de3f3e55c05cfb07e750121f82a288b9244788057cdfe422973 | Versionado | [Software/RRHH.Domain/Catalogos/ItemCatalogo.cs:1](../../Software/RRHH.Domain/Catalogos/ItemCatalogo.cs#L1) |
| Software/RRHH.Domain/Catalogos/TipoCatalogo.cs | 16 | 28efb4f800f2df759a470f98dd6ab1a6ec8b1cf86e35ad9ec6c20a04a7871f38 | Versionado | [Software/RRHH.Domain/Catalogos/TipoCatalogo.cs:1](../../Software/RRHH.Domain/Catalogos/TipoCatalogo.cs#L1) |
| Software/RRHH.Domain/Comun/ReglaNegocioException.cs | 15 | c585db754482b4b6bc4ee89d5ed2ce65813a52ffe8199a31021494fff677d8c1 | Versionado | [Software/RRHH.Domain/Comun/ReglaNegocioException.cs:1](../../Software/RRHH.Domain/Comun/ReglaNegocioException.cs#L1) |
| Software/RRHH.Domain/Permisos/AccesoMotivosPermiso.cs | 36 | 1dbc3e672d7295c3b57c068c068e39581acd1ff7669436a4bfd8214b78d9b190 | Versionado | [Software/RRHH.Domain/Permisos/AccesoMotivosPermiso.cs:1](../../Software/RRHH.Domain/Permisos/AccesoMotivosPermiso.cs#L1) |
| Software/RRHH.Domain/Permisos/MotivoPermiso.cs | 62 | 95274fb98a0c0b0e0c923896618d6d48925691835c49bae4cbff893054cb4714 | Versionado | [Software/RRHH.Domain/Permisos/MotivoPermiso.cs:1](../../Software/RRHH.Domain/Permisos/MotivoPermiso.cs#L1) |
| Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs | 109 | 7433612e55ea4c8713c78adfadeb355e8515935f77f20452ce530ebf24857445 | Versionado | [Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs:1](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs#L1) |
| Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs | 142 | a0d9209dbdff35b130017abc36c8bae18c2943e9263debcbf9835ad57956e9af | Versionado | [Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs:1](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs#L1) |
| Software/RRHH.PostgreSql/Catalogos/MapeoCatalogo.cs | 37 | 2a0b37bbcadace97578d3588392e93b7c8e8149172db2f38c120ea4cd4b05831 | Versionado | [Software/RRHH.PostgreSql/Catalogos/MapeoCatalogo.cs:1](../../Software/RRHH.PostgreSql/Catalogos/MapeoCatalogo.cs#L1) |
| Software/RRHH.PostgreSql/Catalogos/MapeosCatalogo.cs | 50 | 33e31432d001a2e8bcc2535d0438623d90ba76c9751a925ddb4260608bef5d06 | Versionado | [Software/RRHH.PostgreSql/Catalogos/MapeosCatalogo.cs:1](../../Software/RRHH.PostgreSql/Catalogos/MapeosCatalogo.cs#L1) |
| Software/RRHH.PostgreSql/Catalogos/PostgreSqlCatalogoRepository.cs | 146 | ae33ce5bc9067c4c145fe47e132f09661edefaf8a01979821736a41975883bb4 | Versionado | [Software/RRHH.PostgreSql/Catalogos/PostgreSqlCatalogoRepository.cs:1](../../Software/RRHH.PostgreSql/Catalogos/PostgreSqlCatalogoRepository.cs#L1) |
| Software/RRHH.PostgreSql/Catalogos/ReferenciaCatalogo.cs | 21 | 7b988b26d11f130308ad425e1f56d409092f13bc4f82208f0547ae92407b2dc5 | Versionado | [Software/RRHH.PostgreSql/Catalogos/ReferenciaCatalogo.cs:1](../../Software/RRHH.PostgreSql/Catalogos/ReferenciaCatalogo.cs#L1) |
| Software/RRHH.PostgreSql/EnvironmentFile.cs | 97 | 4bd1ef9a97bea120ad72f97683668abdeba59ae9b1641a70c55d32c37c6ce705 | Versionado | [Software/RRHH.PostgreSql/EnvironmentFile.cs:1](../../Software/RRHH.PostgreSql/EnvironmentFile.cs#L1) |
| Software/RRHH.PostgreSql/IdentificadorSql.cs | 30 | 6bd8d7968f193a7badbe8f9382977b5b1942041f218bc1080d10aaa69e839a11 | Versionado | [Software/RRHH.PostgreSql/IdentificadorSql.cs:1](../../Software/RRHH.PostgreSql/IdentificadorSql.cs#L1) |
| Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs | 162 | b52ba90c2f9710589481f21d0cf656e56a27d724282b98834d4dbf00d58f863c | Versionado | [Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs:1](../../Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs#L1) |
| Software/RRHH.PostgreSql/PostgreSqlConnectionFactory.cs | 133 | 0932d86ec25278198e5e28a778b0a3c6fde4b25a3b72838eaeb28d9a61052d74 | Versionado | [Software/RRHH.PostgreSql/PostgreSqlConnectionFactory.cs:1](../../Software/RRHH.PostgreSql/PostgreSqlConnectionFactory.cs#L1) |
| Software/RRHH.PostgreSql/PostgreSqlExecutor.cs | 131 | 07495ffe76817bb6d93b0698d94148f3517643d1175043f8a2d0916257b66446 | Versionado | [Software/RRHH.PostgreSql/PostgreSqlExecutor.cs:1](../../Software/RRHH.PostgreSql/PostgreSqlExecutor.cs#L1) |
| Software/RRHH.PostgreSql/PostgreSqlParameterValue.cs | 17 | 1b3ae194ce6e31db54c431c74b4b4ef1e0e9069a799374d64a9bc9303d259079 | Versionado | [Software/RRHH.PostgreSql/PostgreSqlParameterValue.cs:1](../../Software/RRHH.PostgreSql/PostgreSqlParameterValue.cs#L1) |
| Software/RRHH.PostgreSql/Seguridad/PostgreSqlAccesoUsuarioRepository.cs | 116 | 4846a2e8d698912884d97440f4ca0e38383854d879d5ae1e41d73f6f43705e4e | Versionado | [Software/RRHH.PostgreSql/Seguridad/PostgreSqlAccesoUsuarioRepository.cs:1](../../Software/RRHH.PostgreSql/Seguridad/PostgreSqlAccesoUsuarioRepository.cs#L1) |
| Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs | 112 | 477f1d80730156584c545fb8b50eb5ece7355e6a8365b7c1166f4557ecbf8cb8 | Versionado | [Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs:1](../../Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs#L1) |
| Software/RRHH.Presentation/Asistencia/HorarioEditorPresenter.cs | 58 | 2cefbfc862bafe6559cf81c90706eb68d6c2eaa90835ef85b788cd89b760ae61 | Versionado | [Software/RRHH.Presentation/Asistencia/HorarioEditorPresenter.cs:1](../../Software/RRHH.Presentation/Asistencia/HorarioEditorPresenter.cs#L1) |
| Software/RRHH.Presentation/Asistencia/HorariosPresenter.cs | 69 | 33fd08ab93ffab004bc3a44330faf1b6ed20e5dc6ccaa07d8fbf2bcd931598bd | Versionado | [Software/RRHH.Presentation/Asistencia/HorariosPresenter.cs:1](../../Software/RRHH.Presentation/Asistencia/HorariosPresenter.cs#L1) |
| Software/RRHH.Presentation/Asistencia/IFeriadoView.cs | 33 | aa9f445e3a10aeabdbcc260112a5b7b26aad0090401e9870034b3ebb51682565 | Versionado | [Software/RRHH.Presentation/Asistencia/IFeriadoView.cs:1](../../Software/RRHH.Presentation/Asistencia/IFeriadoView.cs#L1) |
| Software/RRHH.Presentation/Asistencia/IHorarioEditorView.cs | 24 | 77b72efde6a16ad3a6c09d804f65828d28a413b31d35de14ea0ad100b437ec4f | Versionado | [Software/RRHH.Presentation/Asistencia/IHorarioEditorView.cs:1](../../Software/RRHH.Presentation/Asistencia/IHorarioEditorView.cs#L1) |
| Software/RRHH.Presentation/Asistencia/IHorariosView.cs | 22 | 0c2b4f62c33af07c0735e627b2fe6d5e244003590a27e4def9bf208c3afb0c9d | Versionado | [Software/RRHH.Presentation/Asistencia/IHorariosView.cs:1](../../Software/RRHH.Presentation/Asistencia/IHorariosView.cs#L1) |
| Software/RRHH.Presentation/Catalogos/CatalogoFilaEventArgs.cs | 24 | 2a6847dff33222ca77a28b7a0ae8c91b0fc57a881db3c57e067995f22b7f1e08 | Versionado | [Software/RRHH.Presentation/Catalogos/CatalogoFilaEventArgs.cs:1](../../Software/RRHH.Presentation/Catalogos/CatalogoFilaEventArgs.cs#L1) |
| Software/RRHH.Presentation/Catalogos/CatalogoPresenter.cs | 118 | 6d7d8c14eceac8a2c56daf2fc0a3547ae727f3d7f00e77b97652c250aa649071 | Versionado | [Software/RRHH.Presentation/Catalogos/CatalogoPresenter.cs:1](../../Software/RRHH.Presentation/Catalogos/CatalogoPresenter.cs#L1) |
| Software/RRHH.Presentation/Catalogos/ICatalogoView.cs | 38 | b239cbff40a389f53629c5d258d82bdffd2361942cbf821a41ad7db8eeedc298 | Versionado | [Software/RRHH.Presentation/Catalogos/ICatalogoView.cs:1](../../Software/RRHH.Presentation/Catalogos/ICatalogoView.cs#L1) |
| Software/RRHH.Presentation/Permisos/IMotivoPermisoEditorView.cs | 22 | 5192eceb3458349f8520bd26f9ee8df467bfc095e84a6b18c47b8758d6ec99c7 | Versionado | [Software/RRHH.Presentation/Permisos/IMotivoPermisoEditorView.cs:1](../../Software/RRHH.Presentation/Permisos/IMotivoPermisoEditorView.cs#L1) |
| Software/RRHH.Presentation/Permisos/IMotivosPermisoView.cs | 31 | d8512c61e7f50554eff35e70661f07671df9e37d43f82858517fb284c616eb87 | Versionado | [Software/RRHH.Presentation/Permisos/IMotivosPermisoView.cs:1](../../Software/RRHH.Presentation/Permisos/IMotivosPermisoView.cs#L1) |
| Software/RRHH.Presentation/Permisos/MotivoPermisoEditorPresenter.cs | 64 | fac1c18a0f5b50c40fed83f950e4bc9c255cf91689685b3e8f4ff889013010b3 | Versionado | [Software/RRHH.Presentation/Permisos/MotivoPermisoEditorPresenter.cs:1](../../Software/RRHH.Presentation/Permisos/MotivoPermisoEditorPresenter.cs#L1) |
| Software/RRHH.Presentation/Permisos/MotivosPermisoPresenter.cs | 97 | 8186c2c8b4ee393dcc85184c0de7f51591a1cbed99cef346af3af09bf06a829d | Versionado | [Software/RRHH.Presentation/Permisos/MotivosPermisoPresenter.cs:1](../../Software/RRHH.Presentation/Permisos/MotivosPermisoPresenter.cs#L1) |
| Software/RRHH.Tests/Arquitectura/DependenciasEntreCapasTests.cs | 84 | be455ad23d3f602ea561d8cfa22b5f872e5c52d2c32e856f00c94e1e25ac9698 | Versionado | [Software/RRHH.Tests/Arquitectura/DependenciasEntreCapasTests.cs:1](../../Software/RRHH.Tests/Arquitectura/DependenciasEntreCapasTests.cs#L1) |
| Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs | 152 | de5d94be086790214064e16e851804198c5bc1ca3235b803fdecc05e541bb508 | Versionado | [Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs:1](../../Software/RRHH.Tests/Asistencia/FeriadoPresenterTests.cs#L1) |
| Software/RRHH.Tests/Asistencia/FeriadoTests.cs | 74 | 55f0d3fa48c8a5627c9586f7726cd39cebfeb0df2cb625579c85442eeaede5ee | Versionado | [Software/RRHH.Tests/Asistencia/FeriadoTests.cs:1](../../Software/RRHH.Tests/Asistencia/FeriadoTests.cs#L1) |
| Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs | 178 | 909e1abac34974b995433ab2808ac347ded80bfa58e1789cf1165edf66228bbc | Versionado | [Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs:1](../../Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs#L1) |
| Software/RRHH.Tests/Asistencia/HorarioTests.cs | 54 | 7b03f1a556693d069cf1080f3aa4c49b63f51b234793631bc9c5dd19e47e995c | Versionado | [Software/RRHH.Tests/Asistencia/HorarioTests.cs:1](../../Software/RRHH.Tests/Asistencia/HorarioTests.cs#L1) |
| Software/RRHH.Tests/Asistencia/HorariosPresenterTests.cs | 167 | 9b35b59a250b61dfa197ebfa04f615889b55ae01d378205522e18b3f9a55e142 | Versionado | [Software/RRHH.Tests/Asistencia/HorariosPresenterTests.cs:1](../../Software/RRHH.Tests/Asistencia/HorariosPresenterTests.cs#L1) |
| Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs | 185 | 27059c1d95853435796d5d5dfb8806b10de1970f8be73ab18cd8254752bd41fa | Versionado | [Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs:1](../../Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs#L1) |
| Software/RRHH.Tests/Catalogos/CatalogoPresenterTests.cs | 172 | de86e7ad26d42c6546ca051162baa391f542d0544f5f6c494c274bd567bcfb07 | Versionado | [Software/RRHH.Tests/Catalogos/CatalogoPresenterTests.cs:1](../../Software/RRHH.Tests/Catalogos/CatalogoPresenterTests.cs#L1) |
| Software/RRHH.Tests/Catalogos/DefinicionCatalogoTests.cs | 81 | 3c702c4247bb8470896a3ce9dc909f33953897ddc1c8c6ca072ce156d5d4e742 | Versionado | [Software/RRHH.Tests/Catalogos/DefinicionCatalogoTests.cs:1](../../Software/RRHH.Tests/Catalogos/DefinicionCatalogoTests.cs#L1) |
| Software/RRHH.Tests/Catalogos/MapeosCatalogoTests.cs | 143 | 72d310562ac15e404d39ef00565e54b560e9e5d75ad44a80a26e4909c0ae3405 | Versionado | [Software/RRHH.Tests/Catalogos/MapeosCatalogoTests.cs:1](../../Software/RRHH.Tests/Catalogos/MapeosCatalogoTests.cs#L1) |
| Software/RRHH.Tests/Fakes/FakeCatalogoRepository.cs | 63 | 7fd09679e956690540a248b57ce624f151559d5885dd9b4caee8e1a7bbb8a25a | Versionado | [Software/RRHH.Tests/Fakes/FakeCatalogoRepository.cs:1](../../Software/RRHH.Tests/Fakes/FakeCatalogoRepository.cs#L1) |
| Software/RRHH.Tests/Fakes/FakeCatalogoView.cs | 66 | c8180db58e1d8ca4a6d51d0907124700b5254ea3bf6bc6722b96da0f6accdb00 | Versionado | [Software/RRHH.Tests/Fakes/FakeCatalogoView.cs:1](../../Software/RRHH.Tests/Fakes/FakeCatalogoView.cs#L1) |
| Software/RRHH.Tests/Fakes/FakeFeriadoRepository.cs | 78 | 1cbc7ba3b3009d2cd8362a2bf342f0677957679e9e6ace61ea7e5c743878aa60 | Versionado | [Software/RRHH.Tests/Fakes/FakeFeriadoRepository.cs:1](../../Software/RRHH.Tests/Fakes/FakeFeriadoRepository.cs#L1) |
| Software/RRHH.Tests/Fakes/FakeFeriadoView.cs | 68 | aea860b440cf27c886792906dc8f473b922149ca2cc515ddd555c1891993c7e6 | Versionado | [Software/RRHH.Tests/Fakes/FakeFeriadoView.cs:1](../../Software/RRHH.Tests/Fakes/FakeFeriadoView.cs#L1) |
| Software/RRHH.Tests/Fakes/FakeHorarioRepository.cs | 49 | cfecd93c4221f4b9cae3119c06122e9ebdeb97de28c0078d7e9d452e50caf222 | Versionado | [Software/RRHH.Tests/Fakes/FakeHorarioRepository.cs:1](../../Software/RRHH.Tests/Fakes/FakeHorarioRepository.cs#L1) |
| Software/RRHH.Tests/Fakes/FakeMotivoPermisoRepository.cs | 56 | d71b3967e5faab07d07bdd21fd94b44cdb1706b4cd0cb4a1ba3ea3998322953f | Versionado | [Software/RRHH.Tests/Fakes/FakeMotivoPermisoRepository.cs:1](../../Software/RRHH.Tests/Fakes/FakeMotivoPermisoRepository.cs#L1) |
| Software/RRHH.Tests/Permisos/GestionMotivosPermisoTests.cs | 106 | 7554fd98ab44d66813d251616594963431ed47dbc84728f207fff103190ce6d7 | Versionado | [Software/RRHH.Tests/Permisos/GestionMotivosPermisoTests.cs:1](../../Software/RRHH.Tests/Permisos/GestionMotivosPermisoTests.cs#L1) |
| Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs | 213 | 8dcc9ef2355992682794621e556eacde4d777d835cddbc23eab354d1473e7dab | Versionado | [Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs:1](../../Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs#L1) |
| Software/RRHH.Tests/Permisos/MotivoPermisoTests.cs | 51 | 356066f47cd88adb3e8bdaa4379724c7897fceb8b358d51c480776b2f9a3990b | Versionado | [Software/RRHH.Tests/Permisos/MotivoPermisoTests.cs:1](../../Software/RRHH.Tests/Permisos/MotivoPermisoTests.cs#L1) |
| Software/RRHH.Tests/Permisos/MotivosPresenterTests.cs | 177 | 9f71794836ee782229a11115da4664495de9a8246befbf9e9cda1a99bdd54d4b | Versionado | [Software/RRHH.Tests/Permisos/MotivosPresenterTests.cs:1](../../Software/RRHH.Tests/Permisos/MotivosPresenterTests.cs#L1) |
| Software/RRHH.Tests/Seguridad/ObtenerAccesoUsuarioTests.cs | 68 | 4bfbfdab69a790857c869ab8d724d3de8891e0e69d201ea0f5d9981046351aca | Versionado | [Software/RRHH.Tests/Seguridad/ObtenerAccesoUsuarioTests.cs:1](../../Software/RRHH.Tests/Seguridad/ObtenerAccesoUsuarioTests.cs#L1) |
| Software/RRHH.Tests/Seguridad/Pbkdf2PasswordHasherTests.cs | 24 | 4fdb3429ed94dc7d3ddca9732824d144e6f89107fa6a8f76ec898797ed681e02 | Versionado | [Software/RRHH.Tests/Seguridad/Pbkdf2PasswordHasherTests.cs:1](../../Software/RRHH.Tests/Seguridad/Pbkdf2PasswordHasherTests.cs#L1) |
| Software/RecursosHumanos/Properties/AssemblyInfo.cs | 15 | 50825b596f8feb9cc87215d12ed8e519210cb59b73848078c5c54a6654263a4d | Versionado | [Software/RecursosHumanos/Properties/AssemblyInfo.cs:1](../../Software/RecursosHumanos/Properties/AssemblyInfo.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/AcercaDe.cs | 460 | 197f6626722a61765379287868ecf560b8da2f2f713726fbbece382eaed39e8f | Versionado | [Software/RecursosHumanos/RecursosHumanos/AcercaDe.cs:1](../../Software/RecursosHumanos/RecursosHumanos/AcercaDe.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/CompositionRoot.cs | 128 | a7a621d226b44753790104de95acb226730a36c599328beacaf2dfa21eceb8f9 | Versionado | [Software/RecursosHumanos/RecursosHumanos/CompositionRoot.cs:1](../../Software/RecursosHumanos/RecursosHumanos/CompositionRoot.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/DataSet1.cs | 18347 | 1acfd43981a0572512ba5048a8008f7af3f65087637fa58343387025c027a5f5 | Versionado | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:1](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/TableAdapterManager.cs | 432 | 7d6e6bdf7532efbfe0073ddb0064a24ec58d0f91ac13557a0d3d140abbbbeb8f | Versionado | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/TableAdapterManager.cs:1](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/TableAdapterManager.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_FaltasTableAdapter.cs | 344 | 27c21776099b0e3a4c0e2f5e1e62887b7aaa179039905322ab1f2a8c5c00efa9 | Versionado | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_FaltasTableAdapter.cs:1](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_FaltasTableAdapter.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_DatosPersonalesTableAdapter.cs | 342 | c8aa81c5c07ce33598c9e732a5078c1bbd2f1753e6d0ec1af3050547678b6d81 | Versionado | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_DatosPersonalesTableAdapter.cs:1](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_DatosPersonalesTableAdapter.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_Det_FamiliarTableAdapter.cs | 290 | 0e08c67ef26444198ab76caa4f42f17f7edf3082b7700b725222cdbeb470f41f | Versionado | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_Det_FamiliarTableAdapter.cs:1](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_Det_FamiliarTableAdapter.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_Det_Familiar_SaludTableAdapter.cs | 288 | 817ec74b25db996d7aaace62e80b9023787a4a59ef5bbca433a96608741be250 | Versionado | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_Det_Familiar_SaludTableAdapter.cs:1](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_Det_Familiar_SaludTableAdapter.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_Estudio_CapacitacionTableAdapter.cs | 286 | cde10f27b211c16e2e19ee8e349b36ea25b51a3718ccf7113d93ae49a89e26c6 | Versionado | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_Estudio_CapacitacionTableAdapter.cs:1](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_Estudio_CapacitacionTableAdapter.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_Estudio_RealizadoTableAdapter.cs | 284 | a4cd3857f0ab4179330fc14ea81e4c31b21622f647461f1874d1805d3e7a8615 | Versionado | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_Estudio_RealizadoTableAdapter.cs:1](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_Estudio_RealizadoTableAdapter.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_Estudio_TituloTableAdapter.cs | 287 | 8caea91ae5a9b79652dceedc28ce37c867b9517a8668467f8e9d8c3db34680c7 | Versionado | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_Estudio_TituloTableAdapter.cs:1](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_Estudio_TituloTableAdapter.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_ExpLabTableAdapter.cs | 288 | 52b35f3891bbb17e455e1af78b9294dc614d4968c2be565523d767bc7251c789 | Versionado | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_ExpLabTableAdapter.cs:1](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_ExpLabTableAdapter.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_ExpLab_DatosTableAdapter.cs | 298 | 2767ceb9f21756a30ed346bf9aa7124aa715f8f187346c308dce3057730a0bd6 | Versionado | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_ExpLab_DatosTableAdapter.cs:1](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_ExpLab_DatosTableAdapter.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_Ingreso_EgresoTableAdapter.cs | 309 | 428f23d34a065fa5fb79c64da22cc77c926f19e4fef305c3af71a2be407f0706 | Versionado | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_Ingreso_EgresoTableAdapter.cs:1](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_Ingreso_EgresoTableAdapter.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_ViviendaTableAdapter.cs | 299 | 49b185b0952fddb0b5d6182d46a1247d94517ae13971885f7dd226f6b1942314 | Versionado | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_ViviendaTableAdapter.cs:1](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_ViviendaTableAdapter.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_RepAsisdiarriaTableAdapter.cs | 303 | 2e99498fd225c264cb136d4fadd43abb467ba1d35bf3ef4be47caba90643954b | Versionado | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_RepAsisdiarriaTableAdapter.cs:1](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_RepAsisdiarriaTableAdapter.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_RepPermisosTableAdapter.cs | 338 | c3543740a98b3f7b65c17b551f2d7aa2555e88dcf7d61a40e6113fa0f53174a1 | Versionado | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_RepPermisosTableAdapter.cs:1](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_RepPermisosTableAdapter.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Rep_cargosTableAdapter.cs | 284 | 86474e95337e6e0d0fec0109ec4ea0ca238094bd20947447d4a2fa2e5ef1a431 | Versionado | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Rep_cargosTableAdapter.cs:1](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Rep_cargosTableAdapter.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Rep_profesionTableAdapter.cs | 287 | 2ca56b2fee6c48b738e71d4020596c4f0d970ae04f1b9d272141b7b31637f560 | Versionado | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Rep_profesionTableAdapter.cs:1](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Rep_profesionTableAdapter.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Report_CuadroPerTableAdapter.cs | 290 | e1362bec96008d002e0b3fe6b604353e6d77584a48bdc36be0b289406afdcfaf | Versionado | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Report_CuadroPerTableAdapter.cs:1](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Report_CuadroPerTableAdapter.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Report_CumpleTableAdapter.cs | 289 | 298b83713688a1749061e37dfc452e88aa7394400f1fe214687391ce21ad97ca | Versionado | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Report_CumpleTableAdapter.cs:1](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Report_CumpleTableAdapter.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Report_FechaIngresoTableAdapter.cs | 319 | 27adccdc7519c8975a3a17c4ca5e2c74a1dd9447c70832ade3c27c263af7498f | Versionado | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Report_FechaIngresoTableAdapter.cs:1](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Report_FechaIngresoTableAdapter.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Report_OficinaTableAdapter.cs | 285 | 1dd3eee567626ea84974722af0415a916ec655eb6abcc0cdf6f370f91eccf3a7 | Versionado | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Report_OficinaTableAdapter.cs:1](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Report_OficinaTableAdapter.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_busca_DisciplinaTableAdapter.cs | 286 | 6b469e8ac4b27cc92a992e116464f919bbeaf0fb160a512a454079f21abe6425 | Versionado | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_busca_DisciplinaTableAdapter.cs:1](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_busca_DisciplinaTableAdapter.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/DataSet_Porcentaje.cs | 300 | 0014c35f3a8b6debcfdd73ebf7547f81044bd31b6bbdb044de12cdaabde72532 | Versionado | [Software/RecursosHumanos/RecursosHumanos/DataSet_Porcentaje.cs:1](../../Software/RecursosHumanos/RecursosHumanos/DataSet_Porcentaje.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/DataSet_PorcentajeTableAdapters/QueriesTableAdapter.cs | 191 | 6f84afa768b51b036c28e66476add19cbbe590ec70a58809392b0e74876945a3 | Versionado | [Software/RecursosHumanos/RecursosHumanos/DataSet_PorcentajeTableAdapters/QueriesTableAdapter.cs:1](../../Software/RecursosHumanos/RecursosHumanos/DataSet_PorcentajeTableAdapters/QueriesTableAdapter.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmAsignarHorario.cs | 750 | c4c174f09583f202fcddbc1f4aafac7a5f80e3bd550302c6ed32cc567f6cc56a | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmAsignarHorario.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmAsignarHorario.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmAsignarHorario_Lector.cs | 598 | 75094db731083956ced016aec87a0c6b70955a3719f3cfd714fdb9e912f31370 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmAsignarHorario_Lector.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmAsignarHorario_Lector.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmAsistenciaManual.cs | 1050 | f4bb5fe082485f11ca6ee7df5d43710ed3e055108980d66470e38f6ee2b7e42e | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmAsistenciaManual.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmAsistenciaManual.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmBuscarDerechohabiente.cs | 495 | 10ff14db944d865edc157b7224dc431a919779d2181baed4c342deb3976472e2 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmBuscarDerechohabiente.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmBuscarDerechohabiente.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs | 1792 | 242c93a974c5ab50b925f79acaec3a7b889731445dbb03e53dbd816bc574f0d0 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmCapacitaciones.cs | 572 | a10f08c8b0c191a58a383b7a462845fb05dc468ca6d3ae3fa378fa052b59b2a5 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmCapacitaciones.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmCapacitaciones.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistDiaria.cs | 1158 | 327582b74194fcef295c82ed1cbe756e1dc252b8b11cbd5607548839aa9344ae | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistDiaria.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistDiaria.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistencias.cs | 1278 | 213b56aeb19e17a1c424194260ac9e38f44568efa0c124f78028719c17c81654 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistencias.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistencias.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmConsultaFaltas.cs | 895 | d3fbd9b2a46d24b7c57bbdf9b9504817a9d9b677df71ad60ec4bb12ceb20c477 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmConsultaFaltas.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaFaltas.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmConsultaHorarioEsp.cs | 1189 | d8e7e5ddd0be914a1ff4e4f435837f9c6556edbe7c80d1b134fc3f9aaa7e3afe | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmConsultaHorarioEsp.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaHorarioEsp.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmConsultaPermisos.cs | 1624 | 7575caf8cbfad310d272e8f4c3b9a6c50fec688b94cc4a1a458caec32b2b1a89 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmConsultaPermisos.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaPermisos.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmDisciplina.cs | 594 | 4c8ae70b9671960b753ed45144a5dfce74a53bea9a9de95c8c6f8531ce06022b | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmDisciplina.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmDisciplina.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmDocumentos.cs | 613 | a4ad2ee10c7cdcbda6f10dffaaa187a239c1bf815b3aea04bd31cfeaa01eb727 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmDocumentos.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmDocumentos.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmEstudiosRealizados.cs | 706 | fde6a757b6b373ba15490995bbc059e28b1a6772ca704f3a3218dfd347db9c95 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmEstudiosRealizados.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmEstudiosRealizados.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmExpLaboral.cs | 763 | bcf3e0eaea4e4273053999134acbfc1e4ba7d7c1ff4a2725df49ca8fc24be39c | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmExpLaboral.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmExpLaboral.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmFamiliar.cs | 1929 | 64f62259f343596dab73fe0ed2feeb74c9bbea50fb730e789842dbc9689bb45e | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmFamiliar.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmFamiliar.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs | 615 | 86b544894232c74d45a98e40efb2e7d22ddac7030244d6c712b56bd32ecd75dc | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs | 14363 | b0a52c8da5708c0840187e620547a71ef8effb4985a0d59139d7ee6d89abefbe | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmHorarioEsp.cs | 1024 | b0594e687ca3eb594874c5d5d774dc404e55154a852bae0fe6603f714df3b4fb | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmHorarioEsp.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmHorarioEsp.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmHorarios.cs | 603 | e6f710fc30bc1d8a57ee27e56e8e53f1c351b082ca390c998c6b50db92fcbc12 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmHorarios.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmHorarios.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmHorasTrabajadas.cs | 867 | ad11aa1573eb53773090893095efb6c5686056cfb4538edb157c325d5a80e639 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmHorasTrabajadas.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmHorasTrabajadas.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistencia.cs | 426 | 501b03e13838d94158bbd045488a78b627db355752680068beb9fc0a1adf397a | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistencia.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistencia.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaBio.cs | 390 | 788b81d78c65c1426244631c2886aa040217ad135b9b3ee096cfdd09ad4e0acb | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaBio.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaBio.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaCONSEJO.cs | 415 | 629afa2a930a4c4a12005d55a5d261423cc39f21ef9af3f2e7a97832622b994b | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaCONSEJO.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaCONSEJO.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaFueraSEDE.cs | 612 | 4554f727efe16cc7b33047a046c3d534bff57dcbe3ea628d69f79dd795eb9513 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaFueraSEDE.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaFueraSEDE.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaPROIND.cs | 445 | 5bb2c1096ab420ad7fecf1fc64ed112181dd525f19a84603086c9c9730f152f1 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaPROIND.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaPROIND.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmListaArchivos.cs | 688 | d269e847e041f06fe97c55904d7d845b0f7be9cf77366d70eaeb9ec94fca22e5 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmListaArchivos.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmListaArchivos.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmListaOrganica.cs | 1227 | 3d2a976c82054ed568162b05a6ed18b075d4b52a38628c19c99955e02b735eec | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmListaOrganica.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmListaOrganica.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmLocalAsignado.cs | 731 | 58cda8aaf5e988f513e25ea96c4a435820d5392d13bd190f72bda17dedcf7bb5 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmLocalAsignado.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmLocalAsignado.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmLogin.cs | 194 | 8a8b4f264c73f1e1238043d544ec64f5da2d0da249068591cdfcb4c25eec9d41 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmLogin.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmLogin.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmMantCargos.cs | 674 | 256b3ea839f8cb4b5a5f0774f5faa5181b07fcadb9507e09ed05e329a8abddeb | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmMantCargos.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmMantCargos.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmMantDocFile.cs | 791 | 308d173c94ca394ea7b9e8f3929d7210be0a65c76a5e7cb6045c83c38a5c9990 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmMantDocFile.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmMantDocFile.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmMantEmpleado_Basico.cs | 3110 | aaca977ab0e41c0bc6eb33e53575253cc5b9433ad9eb356defeda6adb9aba9c9 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmMantEmpleado_Basico.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmMantEmpleado_Basico.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmMantEstCivil.cs | 670 | f4d4915a54488b3ef699c21711dda636fb38663843ae7cb5db61e7079746f591 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmMantEstCivil.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmMantEstCivil.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmMantGrupoSanguineo.cs | 646 | c90b6063c93f79c05c27b1ac11cceab187972df64211b11bc727d20605815f2b | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmMantGrupoSanguineo.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmMantGrupoSanguineo.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmMantHorarios.cs | 625 | 55350a20570d6d7fa85259d9d181557ac20067ad7aad208109b6ddc419fb5ff0 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmMantHorarios.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmMantHorarios.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmMantMotivo.cs | 387 | 2a2c226a4ae39deddd6ba1cff0478aea85b2ad3c8c4291e1197789d313737176 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmMantMotivo.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmMantMotivo.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmMantNacionalidades.cs | 698 | 1f3e42585ff27fb47baff73415c9640df4ded35f01842fc1e0281e3d8a88a661 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmMantNacionalidades.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmMantNacionalidades.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmMantRegimen.cs | 644 | a5f03fc362c3c5517fe43a3a8441880d9e8705c06cb79bdaa2377ca7d2aa29fa | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmMantRegimen.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmMantRegimen.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmMantTipoDocIdent.cs | 667 | 1e253a625391fd003d30a020357d9f13a189a5c236494f31954fc3ddd9e7a2dd | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmMantTipoDocIdent.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoDocIdent.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmMantTipoEstudio.cs | 668 | a653c7568790bade8af037b4b2f56466e8187d997cfb68081e88d683ce2300e2 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmMantTipoEstudio.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoEstudio.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmMantTipoInst.cs | 667 | b3c66407f0b04744cd9c3db12ca7f6a1e3dc6f89ca92df5d5ebde86a16740c71 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmMantTipoInst.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoInst.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmMantTipoPerm.cs | 547 | 51405605306c5e2396fb52577ca243f809d9bac5894ee570484f2a68e7f6a2be | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmMantTipoPerm.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoPerm.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmMantTipoTrab.cs | 671 | 0ec4661af732d9aed22452740c7296c74f3df6de55a6fa8ee5d31f760dcc3404 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmMantTipoTrab.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoTrab.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmMarcacionesAutorizadas.cs | 1474 | fae17f6c78aeeae12326670a0814e822472892993fe09aa4a1de92a027662719 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmMarcacionesAutorizadas.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmMarcacionesAutorizadas.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs | 555 | 758b14a64b3da4a9281fa6be9836ffc48112cf357e9cd853b8ee6ccb5d7934fc | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmNuevaFicha.cs | 94 | fe6de1676dac2be4b933516764219c2c27912f1ff05473d4619220596c49ddcf | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmNuevaFicha.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmNuevaFicha.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmPeriodoLaboral.cs | 659 | 3e50f4ec90f5605a5b7359bb1f3641c5cbc45119aaea12fe3996e25d8553c685 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmPeriodoLaboral.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmPeriodoLaboral.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs | 1610 | fdc33d91bf700dbefe5ec1b9962bf9e20984d2ffa84b6ee1b782f1c73e94aec7 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmRegistroAsegurado.cs | 1806 | cb86065a63a9520d6cda9ba02a7897ad433a3d938374ba1746e6ce42a798a148 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmRegistroAsegurado.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmRegistroAsegurado.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmRelacionSalidaAutorizada.cs | 219 | 72d16749b6c400b225e855d8e1cd78830940d6788c292d87cba6d6b467757288 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmRelacionSalidaAutorizada.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmRelacionSalidaAutorizada.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmRepAsistenciaDia.cs | 978 | 9ce0706ce071ee850915dbf454485f72093224b8e0431bdeb7b5d574892da4c7 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmRepAsistenciaDia.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmRepAsistenciaDia.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmRepFaltas.cs | 1795 | b9edc9ea30f07447ea916e5da4c3a139a81c13cd8a57903bc5883ffcb125dbcc | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmRepFaltas.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmRepFaltas.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmRepPermisoDispl.cs | 1784 | bb9aeca53c4a8a3e84c47608e2b964304e8be96e307babb9375850edbbbf656c | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmRepPermisoDispl.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmRepPermisoDispl.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmRepPermisos.cs | 941 | a1f4b589090276a9a861056937144617db45765765602109e08d375d7a9f57d0 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmRepPermisos.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmRepPermisos.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmReportCuadro.cs | 1765 | 0adfac1f40e8199c70cb6591a735bbe2e3d5b17f70c192b92e94efbeb226b1f4 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmReportCuadro.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmReportCuadro.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmReportCumple.cs | 1797 | d8704d35e35c276f54acb9f276921fbf761616b9a46a445814570ccb0ecb3850 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmReportCumple.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmReportCumple.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmReportFicha.cs | 1779 | 7b89fd7052237de9abb47097d05f16c1b6d8d4feb9c33d487a6fac5a879bad5d | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmReportFicha.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmReportFicha.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmReport_Cargos.cs | 1972 | ca4736186dad6a6fa4ee2f10d5daca1b6f9302997d2f9445b1b7c8f04abd1bd6 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmReport_Cargos.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Cargos.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmReport_Empleado_Ingre.cs | 1774 | 34e03daa5112956c558864eb47c8427c69004cdede526bda6461f7b382ccb4bd | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmReport_Empleado_Ingre.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Empleado_Ingre.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmReport_Selc_Oficina.cs | 476 | 92366060b0d214e5c40bc3c1e648196595bd1a4cf7607b5031409f783ec8366c | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmReport_Selc_Oficina.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Selc_Oficina.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmReport_SelecMes.cs | 296 | d833088206925afe9ed51fb2cc13d47bf04a23cce26a7024604e8254375e95e7 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmReport_SelecMes.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_SelecMes.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Fechas.cs | 370 | f0e36d9e2d08db7d7eed7e90efdf3df1fb1b0bc0144534449fd96c1a2095640c | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Fechas.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Fechas.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Oficina.cs | 1791 | 2efafb406efd733cb067daf43dd3de36c855350c0891e94fe637ef7fad7a22ce | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Oficina.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Oficina.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Pliego.cs | 269 | 7068cd74f043f15e175aaed4cc8a9da7f0dcb618ddd8ece78b95467b74aec9fb | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Pliego.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Pliego.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmReporteEstadistico.cs | 1192 | ace9cc65fb5e28db6488e2c04988faf52f9bad56466d5fdaba87cd6830cd81ab | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmReporteEstadistico.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmReporteEstadistico.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmReporteProfesion.cs | 2041 | 04c2ea47ff97c328b5d839845b416dad3346d800024e41e7b6ab39218d740954 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmReporteProfesion.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmReporteProfesion.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmResoluciones.cs | 450 | 374637c26b018523760ff5fe40d2dfc1a6f8d774c247a028eb20726393db802b | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmResoluciones.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmResoluciones.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmRotaciones.cs | 461 | baf9406bc63fe7bd9266fae738b50c57caa69715d7d88b7c9fa1ca49a74cd9ee | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmRotaciones.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmRotaciones.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmSalida.cs | 781 | 3424edcde5342beca3c08f23fdb8b4ebf380fe5fab44e338635aa2c67e2f1548 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmSalida.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmSalida.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmSobreTiempo.cs | 725 | bc4038e7359162aeb17bef0442974a5f560f8558c20bb63fd1d1e8173157c312 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmSobreTiempo.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmSobreTiempo.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmSuspenderAsistencia.cs | 686 | 42d73175a3a63a01312c57ffc80631bb5e96e573c0e17a013074c74ec3b4e737 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmSuspenderAsistencia.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmSuspenderAsistencia.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/FrmTitulos.cs | 550 | d4b2f11680cbb7a8c5943ee2ba28771fa005fff10dd69d411bd1a5573e6820f0 | Versionado | [Software/RecursosHumanos/RecursosHumanos/FrmTitulos.cs:1](../../Software/RecursosHumanos/RecursosHumanos/FrmTitulos.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/IFormularioCatalogo.cs | 10 | 871b103badc7cde0e117e14ab47acc82e7aba91a5067c7b40164d2fb58d70dff | Versionado | [Software/RecursosHumanos/RecursosHumanos/IFormularioCatalogo.cs:1](../../Software/RecursosHumanos/RecursosHumanos/IFormularioCatalogo.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/MainMDI.cs | 2938 | 168f87b974423c176e1bd7fbf03745b9f9afc444f64fa5c3af07c68ce926b08c | Versionado | [Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:1](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/Module1.cs | 12 | 8f3701c7acd5e792d12d5a78862f99224e214bcacacd4b4d04c67929084b725e | Versionado | [Software/RecursosHumanos/RecursosHumanos/Module1.cs:1](../../Software/RecursosHumanos/RecursosHumanos/Module1.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/My/InternalXmlHelper.cs | 256 | f51cdab4b556be97c5b222434776b78263125418f02aa54128a9343e485ab316 | Versionado | [Software/RecursosHumanos/RecursosHumanos/My/InternalXmlHelper.cs:1](../../Software/RecursosHumanos/RecursosHumanos/My/InternalXmlHelper.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/My/MyApplication.cs | 95 | ee2f6ff13545be8db5318818df63287d20591e3913415e1ec029e117aa84d6d8 | Versionado | [Software/RecursosHumanos/RecursosHumanos/My/MyApplication.cs:1](../../Software/RecursosHumanos/RecursosHumanos/My/MyApplication.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/My/MyComputer.cs | 17 | b80ddd7185fc26297ae2f0d2a8da0115826b2b0d07b44a847874abdc95a64d6f | Versionado | [Software/RecursosHumanos/RecursosHumanos/My/MyComputer.cs:1](../../Software/RecursosHumanos/RecursosHumanos/My/MyComputer.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/My/MyProject.cs | 2048 | 27f8f732dca9d801a39499ad81af87e7cb27a93313e0fb6ad6a1449d3ba788a3 | Versionado | [Software/RecursosHumanos/RecursosHumanos/My/MyProject.cs:1](../../Software/RecursosHumanos/RecursosHumanos/My/MyProject.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/My/MySettings.cs | 130 | a68f11f31a05aa9ae78125e0275dafcdc20a38431a9d72e0ce8a60efadc26589 | Versionado | [Software/RecursosHumanos/RecursosHumanos/My/MySettings.cs:1](../../Software/RecursosHumanos/RecursosHumanos/My/MySettings.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/My/MySettingsProperty.cs | 17 | 0df27c5b0175506bcad055ddbee395e2a06ced83fe03edd0231266803296746c | Versionado | [Software/RecursosHumanos/RecursosHumanos/My/MySettingsProperty.cs:1](../../Software/RecursosHumanos/RecursosHumanos/My/MySettingsProperty.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/My/Resources/Resources.cs | 353 | 02cd3967d0a027b493ce80f8f1edcede3ed9d633732e9963e83d861ce83280ca | Versionado | [Software/RecursosHumanos/RecursosHumanos/My/Resources/Resources.cs:1](../../Software/RecursosHumanos/RecursosHumanos/My/Resources/Resources.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/PostgreSqlDiagnostic.cs | 162 | 951c4b0d9a5f70353852f03a3c11549be305322801c385eddf42921424644286 | Versionado | [Software/RecursosHumanos/RecursosHumanos/PostgreSqlDiagnostic.cs:1](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlDiagnostic.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs | 182 | e5cee23f3524b6c9a86631621db9e1b6b99784314254497a0c4794c552aea37b | Versionado | [Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:1](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs | 401 | 35d9df5232c9744df45acaf7d10da8b401acee68a51311264b36d43de56e1fb1 | Versionado | [Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs:1](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/PostgreSqlUbigeoControl.cs | 197 | df2336aa5a7476d8d56e29601a05812091b3ff4be5001ff12056dcfe1f1fee96 | Versionado | [Software/RecursosHumanos/RecursosHumanos/PostgreSqlUbigeoControl.cs:1](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlUbigeoControl.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/RRHH.cs | 30 | d1413cc1f11b9119d545a4425ff576a93c7b179ace0129bc54a0a86dd5519e79 | Versionado | [Software/RecursosHumanos/RecursosHumanos/RRHH.cs:1](../../Software/RecursosHumanos/RecursosHumanos/RRHH.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs | 803 | 8bc53434212d92577ada0a8236f14ada201c3a8390f73f90cbfd895383972c97 | Versionado | [Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs:1](../../Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs | 796 | 11e1f8d7dc848c3128affd40c633af14052949afa4015b11841da12b8aa44487 | Versionado | [Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs:1](../../Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs | 839 | 4109bfc1eba7bfd5aaa74415f8d168a1d60e51fcd946abbadb203833f76a0609 | Versionado | [Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs:1](../../Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs | 825 | 2c27bd9ca2269ad796e2fb843021e06fe6b282eefc371f2e3b59dc6769c34a89 | Versionado | [Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs:1](../../Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs | 1006 | b85cc35226a2fd4a4f0cf5b09ca2f22d9f7a1a2f725e6936cee5b34cba7266f8 | Versionado | [Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs:1](../../Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs | 13208 | 6515eb65b8c8303cb9e4d78e6ccbea22375cdc7603e3b2c36efe7cbba9b5c745 | Versionado | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:1](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs | 8417 | 155173ae89ee9b4ac77d00f568a4f0b0f548fcac8ddec3bbb1926733f661b336 | Versionado | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:1](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/Report_Oficinas.cs | 358 | 94b86f9a4e557c2b71a94739d912667ee79e4881d18834b3d7c1edbd4dfdaf54 | Versionado | [Software/RecursosHumanos/RecursosHumanos/Report_Oficinas.cs:1](../../Software/RecursosHumanos/RecursosHumanos/Report_Oficinas.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/Report_Porcentaje.cs | 158 | 0870709d2eb5eb011924d637eb4e22018055c6c9b74587c456d05c30b568877f | Versionado | [Software/RecursosHumanos/RecursosHumanos/Report_Porcentaje.cs:1](../../Software/RecursosHumanos/RecursosHumanos/Report_Porcentaje.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/TreeListOperationCollapseExpandToLevel.cs | 28 | b3bacbce06aca67a0ea6b6f002b6e23573416844c8bf0d54aee561a9e2f38028 | Versionado | [Software/RecursosHumanos/RecursosHumanos/TreeListOperationCollapseExpandToLevel.cs:1](../../Software/RecursosHumanos/RecursosHumanos/TreeListOperationCollapseExpandToLevel.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/VistaCatalogoGrid.cs | 206 | b349e4fe5dbee7788c9733d4ec50e10807f1de6c702869ec25c95b1b6f307ca5 | Versionado | [Software/RecursosHumanos/RecursosHumanos/VistaCatalogoGrid.cs:1](../../Software/RecursosHumanos/RecursosHumanos/VistaCatalogoGrid.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs | 972 | d0a1a26259ddff184a2314e0c07db2d278698e6b29d9777a3cb0b78339a5c4a8 | Versionado | [Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs:1](../../Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs | 652 | e28fae82b1ece5305d170a295af29fc8762a4b06789ba5ec8d047226fc96b174 | Versionado | [Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs:1](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs#L1) |
| Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas_Area.cs | 453 | f802177845085d2ada1f608a4b0974f15dd3215f5a0bf4e8ff3d6892d3cfc21d | Versionado | [Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas_Area.cs:1](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas_Area.cs#L1) |
| Software/Seguridad/Properties/AssemblyInfo.cs | 15 | 0553b37d4c9f1268dd3efb20796c0ba4c4f7206fbf381d6decd9084068c90a1a | Versionado | [Software/Seguridad/Properties/AssemblyInfo.cs:1](../../Software/Seguridad/Properties/AssemblyInfo.cs#L1) |
| Software/Seguridad/Seguridad/My/InternalXmlHelper.cs | 256 | d8afee82b641e127ff6d80a28421734b63f93d439eaf7426612cbcfc0276ffbe | Versionado | [Software/Seguridad/Seguridad/My/InternalXmlHelper.cs:1](../../Software/Seguridad/Seguridad/My/InternalXmlHelper.cs#L1) |
| Software/Seguridad/Seguridad/My/MyApplication.cs | 16 | 3f48b565dfc7c73f31b5881e4f6c37cc5ffd7f617ed1b3820d59f069af66ce31 | Versionado | [Software/Seguridad/Seguridad/My/MyApplication.cs:1](../../Software/Seguridad/Seguridad/My/MyApplication.cs#L1) |
| Software/Seguridad/Seguridad/My/MyComputer.cs | 17 | a83e5baab0a83f6febbf68690d4cf62ba8dbae2aa7a62dde77c331a792e649d6 | Versionado | [Software/Seguridad/Seguridad/My/MyComputer.cs:1](../../Software/Seguridad/Seguridad/My/MyComputer.cs#L1) |
| Software/Seguridad/Seguridad/My/MyProject.cs | 151 | 9d5dfd9be392e642bf276d03da93ffbbb1a6b62422005cd6f1f49dea420fa15d | Versionado | [Software/Seguridad/Seguridad/My/MyProject.cs:1](../../Software/Seguridad/Seguridad/My/MyProject.cs#L1) |
| Software/Seguridad/Seguridad/My/MySettings.cs | 22 | 286a38a6fce8aa0f1af9a23eccf6caca853578e504ea9781cb00fd1c17af88aa | Versionado | [Software/Seguridad/Seguridad/My/MySettings.cs:1](../../Software/Seguridad/Seguridad/My/MySettings.cs#L1) |
| Software/Seguridad/Seguridad/My/MySettingsProperty.cs | 17 | 2609636d0114308901795382ca1598698c7d6ce6eebc61fcf12776e2b3dc9d3a | Versionado | [Software/Seguridad/Seguridad/My/MySettingsProperty.cs:1](../../Software/Seguridad/Seguridad/My/MySettingsProperty.cs#L1) |
| Software/Seguridad/Seguridad/My/Resources/Resources.cs | 49 | 666205250e55eb2b88d9ce3588d83c3803c58f888c9b26b8ebb21d3fa67efa8f | Versionado | [Software/Seguridad/Seguridad/My/Resources/Resources.cs:1](../../Software/Seguridad/Seguridad/My/Resources/Resources.cs#L1) |
| Software/Seguridad/Seguridad/Seguridad.cs | 101 | f5f35bfeddcb8c94486504f26f667bdb6ed12e9b3014c50f9676e578e0cc3eca | Versionado | [Software/Seguridad/Seguridad/Seguridad.cs:1](../../Software/Seguridad/Seguridad/Seguridad.cs#L1) |
| Software/TabStrip/FarsiLibrary/Win/BaseClasses/BaseStyledPanel.cs | 71 | 11f11c6be8cf366caf5ea59bda00695fa18367b5a9b9977f2e642e2909195419 | Versionado | [Software/TabStrip/FarsiLibrary/Win/BaseClasses/BaseStyledPanel.cs:1](../../Software/TabStrip/FarsiLibrary/Win/BaseClasses/BaseStyledPanel.cs#L1) |
| Software/TabStrip/FarsiLibrary/Win/Design/FATabStripDesigner.cs | 129 | c3ba24727a4819ff42298d90e2e7817714628b2c9c64107f56930d2e933202f7 | Versionado | [Software/TabStrip/FarsiLibrary/Win/Design/FATabStripDesigner.cs:1](../../Software/TabStrip/FarsiLibrary/Win/Design/FATabStripDesigner.cs#L1) |
| Software/TabStrip/FarsiLibrary/Win/Design/FATabStripItemDesigner.cs | 66 | 25b31fe416df0583ebfc3d4ca6965e9b8fefc8418280f35a4baf25077c5a5604 | Versionado | [Software/TabStrip/FarsiLibrary/Win/Design/FATabStripItemDesigner.cs:1](../../Software/TabStrip/FarsiLibrary/Win/Design/FATabStripItemDesigner.cs#L1) |
| Software/TabStrip/FarsiLibrary/Win/Design/ICaptionSupport.cs | 6 | e5c880674e3ead35538554f1e234e550652d00e54237c46c2a50138f235db19a | Versionado | [Software/TabStrip/FarsiLibrary/Win/Design/ICaptionSupport.cs:1](../../Software/TabStrip/FarsiLibrary/Win/Design/ICaptionSupport.cs#L1) |
| Software/TabStrip/FarsiLibrary/Win/FATabStrip.cs | 797 | ef76aead06a4804c60ed9d3d5f610f915446a6519945dbb8e35376aed8d39ea5 | Versionado | [Software/TabStrip/FarsiLibrary/Win/FATabStrip.cs:1](../../Software/TabStrip/FarsiLibrary/Win/FATabStrip.cs#L1) |
| Software/TabStrip/FarsiLibrary/Win/FATabStripCloseButton.cs | 58 | aa81033cb5c32af41e4ef65e54dd2813dfc173fdbde0f7473587cff1f6b4a323 | Versionado | [Software/TabStrip/FarsiLibrary/Win/FATabStripCloseButton.cs:1](../../Software/TabStrip/FarsiLibrary/Win/FATabStripCloseButton.cs#L1) |
| Software/TabStrip/FarsiLibrary/Win/FATabStripItem.cs | 255 | 4a58279f1ffd24662c98e808c889c0b1cd1151ea6f05522c0fd18200236db389 | Versionado | [Software/TabStrip/FarsiLibrary/Win/FATabStripItem.cs:1](../../Software/TabStrip/FarsiLibrary/Win/FATabStripItem.cs#L1) |
| Software/TabStrip/FarsiLibrary/Win/FATabStripItemChangeTypes.cs | 9 | 44edf2724f2332831d4d52c5d9453c1c4ad1b3730a300d8b497e0eccf7e501ec | Versionado | [Software/TabStrip/FarsiLibrary/Win/FATabStripItemChangeTypes.cs:1](../../Software/TabStrip/FarsiLibrary/Win/FATabStripItemChangeTypes.cs#L1) |
| Software/TabStrip/FarsiLibrary/Win/FATabStripItemCollection.cs | 253 | 6b744233056fb8e09f38b118e0877883acd84aaded016d4a15c468efabb4d934 | Versionado | [Software/TabStrip/FarsiLibrary/Win/FATabStripItemCollection.cs:1](../../Software/TabStrip/FarsiLibrary/Win/FATabStripItemCollection.cs#L1) |
| Software/TabStrip/FarsiLibrary/Win/FATabStripMenuGlyph.cs | 70 | e544c3810fd8e489b0e414c61bee383fcc45d1d31fb51c1561d941196b708946 | Versionado | [Software/TabStrip/FarsiLibrary/Win/FATabStripMenuGlyph.cs:1](../../Software/TabStrip/FarsiLibrary/Win/FATabStripMenuGlyph.cs#L1) |
| Software/TabStrip/FarsiLibrary/Win/Helpers/CollectionChange.cs | 3 | a89a50c90b3da78e2208aae6d7e05914804f20ead36094025c576e84af5509d3 | Versionado | [Software/TabStrip/FarsiLibrary/Win/Helpers/CollectionChange.cs:1](../../Software/TabStrip/FarsiLibrary/Win/Helpers/CollectionChange.cs#L1) |
| Software/TabStrip/FarsiLibrary/Win/Helpers/CollectionClear.cs | 3 | e855b82e6e13b3ab6d26362e9229130d59ff534deda73a40597fc591ee0d6978 | Versionado | [Software/TabStrip/FarsiLibrary/Win/Helpers/CollectionClear.cs:1](../../Software/TabStrip/FarsiLibrary/Win/Helpers/CollectionClear.cs#L1) |
| Software/TabStrip/FarsiLibrary/Win/Helpers/CollectionWithEvents.cs | 98 | a67a833a0e2a6e2c0463eec7d7445c54d63fdb14724dbe9f71498431f0e4fd49 | Versionado | [Software/TabStrip/FarsiLibrary/Win/Helpers/CollectionWithEvents.cs:1](../../Software/TabStrip/FarsiLibrary/Win/Helpers/CollectionWithEvents.cs#L1) |
| Software/TabStrip/FarsiLibrary/Win/HitTestResult.cs | 9 | df095a3ffedb47545d5b65a8fe44194d4fcc07a860b468204e0c5d21410b7781 | Versionado | [Software/TabStrip/FarsiLibrary/Win/HitTestResult.cs:1](../../Software/TabStrip/FarsiLibrary/Win/HitTestResult.cs#L1) |
| Software/TabStrip/FarsiLibrary/Win/TabStripItemChangedEventArgs.cs | 20 | 3bbef24041fc05b336bedac5149c32d91ff8d62f9ee907133a3c9da9986646ec | Versionado | [Software/TabStrip/FarsiLibrary/Win/TabStripItemChangedEventArgs.cs:1](../../Software/TabStrip/FarsiLibrary/Win/TabStripItemChangedEventArgs.cs#L1) |
| Software/TabStrip/FarsiLibrary/Win/TabStripItemChangedHandler.cs | 3 | ee9a4413882947c9c9cf1a9dda27cd687095d6cf7f4a02302e35a4ffdf405671 | Versionado | [Software/TabStrip/FarsiLibrary/Win/TabStripItemChangedHandler.cs:1](../../Software/TabStrip/FarsiLibrary/Win/TabStripItemChangedHandler.cs#L1) |
| Software/TabStrip/FarsiLibrary/Win/TabStripItemClosingEventArgs.cs | 39 | 3dd97b9173a3021181791dd2490233bfafcdcf5a53f97263e65f23dd8334a83c | Versionado | [Software/TabStrip/FarsiLibrary/Win/TabStripItemClosingEventArgs.cs:1](../../Software/TabStrip/FarsiLibrary/Win/TabStripItemClosingEventArgs.cs#L1) |
| Software/TabStrip/FarsiLibrary/Win/TabStripItemClosingHandler.cs | 3 | 67f92896214e554dab294f0e3abddbf8afb89ebdc4e39763ea2d93074e9d9ff3 | Versionado | [Software/TabStrip/FarsiLibrary/Win/TabStripItemClosingHandler.cs:1](../../Software/TabStrip/FarsiLibrary/Win/TabStripItemClosingHandler.cs#L1) |
| Software/TabStrip/FarsiLibrary/Win/ThemeTypes.cs | 8 | 38ea7232f8107a6e2bc70aa6400d571cb9e0cd9c59c89fe2f21b98d42feff90a | Versionado | [Software/TabStrip/FarsiLibrary/Win/ThemeTypes.cs:1](../../Software/TabStrip/FarsiLibrary/Win/ThemeTypes.cs#L1) |
| Software/TabStrip/Properties/AssemblyInfo.cs | 16 | adc27b69e3e3bf1983b8226fd6b0134894f8e4788518f74e49cf163e12706763 | Versionado | [Software/TabStrip/Properties/AssemblyInfo.cs:1](../../Software/TabStrip/Properties/AssemblyInfo.cs#L1) |
