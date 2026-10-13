--
-- PostgreSQL database dump
--

\restrict bRT8lpLeP1yLGgcbJ8QjHUjOc1obE9uRWrwlXMdyqiyKMooMDtC9rxXMzl0Cdx3

-- Dumped from database version 18.3
-- Dumped by pg_dump version 18.3

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET transaction_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: AFP; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."AFP" (
    "IdAFP" integer NOT NULL,
    "DescripAFP" character varying(50),
    "DireccAFP" character varying(200),
    "TelefAFP" character varying(12),
    "NomContAFP" character varying(100)
);


--
-- Name: AguaViv; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."AguaViv" (
    "IdAgua" integer NOT NULL,
    "DescripAgua" character varying(33)
);


--
-- Name: AlumbradoViv; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."AlumbradoViv" (
    "IdAlumbrado" integer NOT NULL,
    "DescripAlumbrado" character varying(20)
);


--
-- Name: Asistencia; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."Asistencia" (
    "Fecha" timestamp without time zone NOT NULL,
    "IdEmpleado" integer NOT NULL,
    "Hor_Ent" character varying(8),
    "Hor_Sal" character varying(8),
    "Alm_Sal" character varying(8),
    "Alm_Ent" character varying(8),
    "Flag_Ent" boolean,
    "Flag_Sal" boolean,
    "Estado" boolean,
    "idHorario" integer,
    "Usuario" character varying(50),
    "PC" character varying(50)
);


--
-- Name: Asistencia_Aud; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."Asistencia_Aud" (
    id integer NOT NULL,
    "Fecha_aud" timestamp without time zone,
    "Usuario" character varying(50),
    "Pc" character varying(50),
    "Operacion" character varying(1),
    "idEmpleado" integer,
    "Fecha_Ant" character varying(50),
    "Hora_Sal_Ant" character varying(8),
    "Hora_Ent_Ant" character varying(8),
    "Hora_Sal_Act" character varying(8),
    "Hora_Ent_Act" character varying(8)
);


--
-- Name: AuxRRHH_ReporteAsistencia; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."AuxRRHH_ReporteAsistencia" (
    "idEmpleado" integer NOT NULL
);


--
-- Name: Capacitacion; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."Capacitacion" (
    "IdCapacitacion" integer NOT NULL,
    "NombreCurso" character varying(300),
    "FechaInicio" timestamp without time zone,
    "FechaFin" timestamp without time zone,
    "NumHoras" character varying(5),
    "InstitucionOrganizadora" character varying(300),
    "IdEmpleado" integer
);


--
-- Name: Cargo; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."Cargo" (
    "IdCargo" integer NOT NULL,
    "Cargo" character varying(50) NOT NULL,
    "Abreviatura" character varying(8)
);


--
-- Name: Comportamiento; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."Comportamiento" (
    "idComportamiento" integer NOT NULL,
    "Fecha" timestamp without time zone,
    "IdEmpleado" integer,
    "NumResol" character varying(200),
    "Titulo" character varying(1000),
    "Descripcion" character varying(2000),
    "idTipoComportamiento" integer
);


--
-- Name: ConservacionViv; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."ConservacionViv" (
    "IdConservacion" integer NOT NULL,
    "DescripConserva" character varying(17)
);


--
-- Name: Dim_Date; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."Dim_Date" (
    "DateKey" integer NOT NULL,
    "Date" timestamp without time zone NOT NULL,
    "Day" integer NOT NULL,
    "Weekday" integer NOT NULL,
    "WeekDayName" character varying(10) NOT NULL,
    "WeekDayName_Short" character varying(3) NOT NULL,
    "WeekDayName_FirstLetter" character varying(1) NOT NULL,
    "DayOfYear" integer NOT NULL,
    "WeekOfMonth" integer NOT NULL,
    "WeekOfYear" integer NOT NULL,
    "Month" integer NOT NULL,
    "MonthName" character varying(10) NOT NULL,
    "MonthName_Short" character varying(3) NOT NULL,
    "MonthName_FirstLetter" character varying(1) NOT NULL,
    "Quarter" integer NOT NULL,
    "QuarterName" character varying(6) NOT NULL,
    "Year" integer NOT NULL,
    "MMYYYY" character varying(6) NOT NULL,
    "MonthYear" character varying(7) NOT NULL,
    "IsWeekend" boolean NOT NULL,
    "IsHoliday" boolean
);


--
-- Name: Discapacidad; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."Discapacidad" (
    "IdDiscapacidad" integer NOT NULL,
    "Descrip_Discapacidad" character varying(12)
);


--
-- Name: Empleado; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."Empleado" (
    "IdEmpleado" integer NOT NULL,
    "Year" integer NOT NULL,
    "idAreaOrganiz" integer NOT NULL,
    "IdPersona" integer,
    "ExpSocial" character varying(20),
    "FechaIngreso" timestamp without time zone,
    "IdAFP" integer,
    "Brevete" character varying(12),
    "IdEstadoCivil" integer,
    "Sexo" character varying(1),
    "CtaCorriente" character varying(16),
    "NroAFP" character varying(20),
    "FechaAFP" timestamp without time zone,
    "IdSeguro" integer,
    "NroSeguro" character varying(20),
    "IdTipoSangre" integer,
    "DecLey" character varying(10),
    "Foto" text,
    "IdTipoTrabajador" integer,
    "Estado" character varying(1),
    "IdCargo" integer,
    "IdDiscapacidad" integer,
    "Profesion" character varying(80),
    "JefeHogar" boolean,
    "CargaFam" character varying(2),
    "NumHijos" character varying(2),
    "IdViveCon" integer,
    "ObsFam" character varying(500),
    "AspecSalud" character varying(1000),
    "AspecEducacion" character varying(1000),
    "AspecRecreacion" character varying(1000),
    "AspecPsico" character varying(1000),
    "AspecSocial" character varying(1000),
    "DiagnosSocial" character varying(1000),
    "IdNacionalidad" integer,
    "NumLibretaMilitar" character varying(10),
    "GradoInstruccion" character varying(80),
    "IdRegimenPen" integer,
    "NumRUC" character varying(12),
    "NumAutogenSalud" character varying(15),
    "NumResolCese" character varying(20),
    "FechaResolCese" timestamp without time zone,
    "NumResol20530" character varying(20),
    "FechaResol20530" timestamp without time zone,
    "NumResolPenMen" character varying(20),
    "FechaResolPenMen" timestamp without time zone,
    "NumResoIngreEsta" character varying(30),
    "FechaIngreEstado" timestamp without time zone,
    "FechaResolIngreEsta" timestamp without time zone,
    "NumResoIngreInstitu" character varying(30),
    "FechaResoIngreInstitu" timestamp without time zone,
    "idHorario" integer,
    "Userid" text,
    "idLocal" integer
);


--
-- Name: Empleado_Area; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."Empleado_Area" (
    "Year" integer NOT NULL,
    "idAreaOrganiz" integer NOT NULL,
    "IdEmpleado" integer NOT NULL
);


--
-- Name: EstadoCivil; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."EstadoCivil" (
    "IdEstadoCivil" integer NOT NULL,
    "DescripEstCivil" character varying(11),
    "AbrevEstCiv" character varying(3)
);


--
-- Name: EstadoEstudio; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."EstadoEstudio" (
    "IdEstadoEstudio" integer NOT NULL,
    "DescripEstadoEstudio" character varying(10)
);


--
-- Name: EstructOrganiz; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."EstructOrganiz" (
    "Year" integer NOT NULL,
    "idAreaOrganiz" integer NOT NULL,
    "AreaOrganizacional" character varying(200) NOT NULL,
    "Abrev" character varying(10) NOT NULL,
    "Sigla" character varying(6) NOT NULL,
    "PresupAnual" numeric,
    "PromedMensSueld" numeric,
    "NroTrabajaUO" integer,
    "Mision" character varying(1000),
    "Vision" character varying(1000),
    "IdPresupuesto" integer,
    "YearDe" integer,
    "idDependeDe" integer,
    "IdEmpleado" integer,
    "InversPublic" numeric,
    "ApruebaPedido" character varying(1),
    "MontoAprobacion" numeric,
    "PresupCompra" numeric,
    "PresupUtilizado" numeric
);


--
-- Name: EstudiosRealizado; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."EstudiosRealizado" (
    "IdTipoEstudios" integer NOT NULL,
    "IdEmpleado" integer NOT NULL,
    "Correlativo" integer NOT NULL,
    "CentroEstudios" character varying(150),
    "AñoInicio" timestamp without time zone,
    "Especialidad" character varying(100),
    "AñoTermino" timestamp without time zone,
    "IdEstadoEstudio" integer
);


--
-- Name: ExcretasViv; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."ExcretasViv" (
    "IdExcretas" integer NOT NULL,
    "DescripExcretas" character varying(33)
);


--
-- Name: ExpLaboral; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."ExpLaboral" (
    "IdEmpleado" integer NOT NULL,
    "IdExpLab" integer NOT NULL,
    "NomInstitucion" character varying(120),
    "Cargo" character varying(40),
    "FechaIngreso" timestamp without time zone,
    "FechaEgreso" timestamp without time zone,
    "UnidadOrganica" character varying(100),
    "IdTipoInstitucion" integer
);


--
-- Name: Familia; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."Familia" (
    "IdFamilia" character varying(4) NOT NULL,
    "Descripcion" character varying(140),
    "Observaciones" character varying(120),
    "IdClase" character varying(2) NOT NULL,
    "IdGrupo" character varying(3) NOT NULL
);


--
-- Name: Familiar; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."Familiar" (
    "IdEmpleado" integer NOT NULL,
    "IdPersona" integer NOT NULL,
    "FamSexo" character varying(1),
    "FamLugTrab" character varying(50),
    "IdEstadoCivil" integer,
    "NumAutogenSalud" character varying(15),
    "FamOcupacion" character varying(20),
    "FamGradoInstruc" character varying(15),
    "IdTipoFam" integer,
    "ViveCasa" boolean,
    "LaboraInstitucion" boolean,
    "IdDiscapacidad" integer,
    "Procedencia" character varying(50),
    "Enfermedad" character varying(200),
    "TiempoEnfermedad" character varying(200),
    "IdTipoSangre" integer
);


--
-- Name: Horario; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."Horario" (
    "idHorario" integer NOT NULL,
    "Ingreso1" character varying(8),
    "Salida1" character varying(8),
    "Ingreso2" character varying(8),
    "Salida2" character varying(8),
    "Descrip_Horario" character varying(20),
    "Estado" boolean,
    "SgtDia" boolean
);


--
-- Name: HorarioTemporal; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."HorarioTemporal" (
    "idEmpleado" integer NOT NULL,
    "N" integer NOT NULL,
    "FechaInicio" timestamp without time zone,
    "FechaFin" timestamp without time zone,
    "HorarioAsignado" integer,
    "NroDocumento" character varying(50),
    "Sisgedo" character varying(50),
    "FechaRegistro" timestamp without time zone
);


--
-- Name: Inconveniente; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."Inconveniente" (
    "IdObjetivo" integer NOT NULL,
    "Id_Actividad" integer NOT NULL,
    "IdInconveniente" integer NOT NULL,
    "Inconveniente" character varying(70) NOT NULL,
    "Importancia" integer NOT NULL,
    "Desventaja" character varying(70),
    "Observacion" character varying(300)
);


--
-- Name: Institucion; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."Institucion" (
    "IdInstitucion" integer NOT NULL,
    "Descripcion" character varying(120),
    "Direccion" character varying(120)
);


--
-- Name: Limitacion; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."Limitacion" (
    "IdLimitacion" integer NOT NULL,
    "Descripcion" character varying(500)
);


--
-- Name: Local; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."Local" (
    "idLocal" integer NOT NULL,
    "NombreLocal" character varying(50),
    "Estado" boolean
);


--
-- Name: Marcacion; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."Marcacion" (
    "Fecha" timestamp without time zone NOT NULL,
    "Estado" character varying(2),
    "IdEmpleado" integer NOT NULL,
    "Lugar" character varying(10),
    "idHorario" integer
);


--
-- Name: MaterialViv; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."MaterialViv" (
    "IdMaterial" integer NOT NULL,
    "DescripMaterial" character varying(12)
);


--
-- Name: MotivoBaja; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."MotivoBaja" (
    "idMotivoBaja" integer NOT NULL,
    "Descripcion" character varying(50)
);


--
-- Name: Motivo_Perm; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."Motivo_Perm" (
    "idMotivo" integer NOT NULL,
    "Descrip_Motivo" character varying(50),
    "Salario" boolean,
    "idTipoPermiso" integer,
    "Abrev" character varying(3),
    "TipoModalidad" character varying(1),
    "Activo" boolean
);


--
-- Name: Nacionalidad; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."Nacionalidad" (
    "IdNacionalidad" integer NOT NULL,
    "Descripcion" character varying(50),
    "Abreviatura" character varying(3)
);


--
-- Name: PeriodoLaboral; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."PeriodoLaboral" (
    "IdEmpleado" integer NOT NULL,
    "NroPeriodo" integer NOT NULL,
    "NumResoIngreInstitu" character varying(30),
    "FechaSalida" timestamp without time zone,
    "FechaResoIngreInstitu" timestamp without time zone,
    "FechaIngreso" timestamp without time zone,
    "Judicial" boolean,
    "Obs" character varying(2000)
);


--
-- Name: Permiso; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."Permiso" (
    "IdEmpleado" integer NOT NULL,
    "NPermiso" integer NOT NULL,
    "FechaInicio" timestamp without time zone,
    "FechaFin" timestamp without time zone,
    "Hora_Sal" character varying(8),
    "Hora_Ret" character varying(8),
    "Dia" boolean,
    "Retorno" boolean,
    "idMotivo" integer,
    "Lugar" character varying(20),
    "Referencia" character varying(100),
    "Autorizacion" character varying(50),
    "Obs" character varying(200),
    "AutorizacionRRHH" character varying(50),
    "Autorizado" boolean
);


--
-- Name: Permiso_Aud; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."Permiso_Aud" (
    id integer NOT NULL,
    fecha_aud timestamp without time zone,
    "Usuario" character varying(50),
    "Pc" character varying(50),
    operacion character varying(1),
    "idEmpleado" integer,
    "NPermiso" integer,
    "FechaInicio_Ant" timestamp without time zone,
    "FechaFin_Ant" timestamp without time zone,
    "idMotivo_Ant" integer,
    "Referencia_Ant" character varying(150),
    "Autorizacion_Ant" character varying(150),
    "Obs_Ant" character varying(150),
    "FechaInicio_Act" timestamp without time zone,
    "FechaFin_Act" timestamp without time zone,
    "idMotivo_Act" integer,
    "Referencia_Act" character varying(150),
    "Autorizacion_Act" character varying(150),
    "Obs_Act" character varying(150)
);


--
-- Name: Persona; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."Persona" (
    "IdPersona" integer NOT NULL,
    "Nombres" character varying(100),
    "Apellido_Paterno" character varying(30),
    "Apellido_Materno" character varying(30),
    "TipoDocID" integer,
    "NumDocID" character varying(12),
    "Direccion" character varying(100),
    "Telefono" character varying(15),
    "Fax" character varying(15),
    "Email" character varying(50),
    "IdUbigeo" character varying(6),
    "UbigeoDireccion" character varying(6),
    "TipoPersona" character varying(1),
    "FechaNacimiento" timestamp without time zone,
    "FechaRegistro" timestamp without time zone,
    "NumCelular" character varying(15),
    "FonoCentroLab" character varying(15)
);


--
-- Name: RRHH_AcudeEnferm; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."RRHH_AcudeEnferm" (
    "idAcudeEnferm" integer NOT NULL,
    "AcudeEnfermDescrip" character varying(16)
);


--
-- Name: RRHH_Asegurado; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."RRHH_Asegurado" (
    "idEmpleado" integer NOT NULL,
    "NroBeneficiario" integer NOT NULL,
    "idPersona" integer,
    "idEstadoCivil" integer,
    "Sexo" character varying(1),
    "VinculoFamiliar" character varying(50),
    "NroPartida" character varying(50),
    "NroResolMayorIndiscap" character varying(50),
    "FechaInicioVinculo" timestamp without time zone,
    "idMotivoBaja" integer,
    "NroPartidaDef" character varying(50),
    "OtrosMotivos" character varying(50),
    "FechaFinVinculo" timestamp without time zone,
    "Reevaluar" character varying(1)
);


--
-- Name: RRHH_AspSocio; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."RRHH_AspSocio" (
    "idAspSocio" integer NOT NULL,
    "IdEmpleado" integer,
    "idPregunta1" integer,
    "idPregunta2" integer,
    "idPregunta3" integer,
    "PrincipProblemas" character varying(400),
    "PropMejoraInstitu" character varying(400),
    hobby character varying(400),
    "ActRecreaInstitu" character varying(400)
);


--
-- Name: RRHH_DinamicaFamiliar; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."RRHH_DinamicaFamiliar" (
    "idDinamica" integer NOT NULL,
    "IdEmpleado" integer,
    "idTipoFam" integer,
    "idRelaPareja" integer,
    "idRelaPH" integer,
    "idRelacHermano" integer,
    "Observacion" character varying(200)
);


--
-- Name: RRHH_Feriado; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."RRHH_Feriado" (
    "idFeriado" integer NOT NULL,
    "Fecha" timestamp without time zone,
    "Motivo" character varying(200)
);


--
-- Name: RRHH_FuncFam; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."RRHH_FuncFam" (
    "idFuncFamiliar" integer NOT NULL,
    "IdEmpleado" integer,
    "Com1" character varying(2),
    "Com2" character varying(2),
    "Afec1" character varying(2),
    "Afec2" character varying(2),
    "Decis1" character varying(2),
    "Decis2" character varying(2),
    "Soc1" character varying(2),
    "Soc2" character varying(2),
    "Soc3" character varying(2)
);


--
-- Name: RRHH_Preg1; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."RRHH_Preg1" (
    "idPregunta1" integer NOT NULL,
    "Respues1" character varying(83)
);


--
-- Name: RRHH_Preg2; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."RRHH_Preg2" (
    "idPregunta2" integer NOT NULL,
    "Respues2" character varying(22)
);


--
-- Name: RRHH_Preg3; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."RRHH_Preg3" (
    "idPregunta3" integer NOT NULL,
    "Respues3" character varying(23)
);


--
-- Name: RRHH_RelacHermano; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."RRHH_RelacHermano" (
    "idRelacHermano" integer NOT NULL,
    "RelacHermanoDescrip" character varying(12)
);


--
-- Name: RRHH_RelacPH; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."RRHH_RelacPH" (
    "idRelacPH" integer NOT NULL,
    "RelacPHDescrip" character varying(14)
);


--
-- Name: RRHH_RelacPareja; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."RRHH_RelacPareja" (
    "idRelacPareja" integer NOT NULL,
    "RelacParejaDescrip" character varying(12)
);


--
-- Name: RRHH_Salud; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."RRHH_Salud" (
    "idSalud" integer NOT NULL,
    "IdEmpleado" integer,
    "EnferCronica" boolean,
    "EnferCronicaDescrip" character varying(200),
    "FamDiscapacidad" boolean,
    "FamDiscapDescrip" character varying(200),
    "Alergico" boolean,
    "AlergicoDescrip" character varying(200),
    "idAcudeEnferm" integer
);


--
-- Name: RRHH_TempFecha; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."RRHH_TempFecha" (
    "Fecha" timestamp without time zone,
    id integer NOT NULL
);


--
-- Name: RRHH_TipoFamilia; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."RRHH_TipoFamilia" (
    "idTipoFam" integer NOT NULL,
    "TipoFamDescrip" character varying(10)
);


--
-- Name: RegAsisDiario; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."RegAsisDiario" (
    "Fecha" timestamp without time zone NOT NULL,
    "IdEmpleado" integer NOT NULL,
    "MinNormales" character varying(4),
    "MinTarde" character varying(18),
    "Estado" character varying(3)
);


--
-- Name: RegimenPension; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."RegimenPension" (
    "IdRegimenPen" integer NOT NULL,
    "LeyRegimen" character varying(5)
);


--
-- Name: Reporte_Asistencias; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."Reporte_Asistencias" (
    "Fecha" timestamp without time zone NOT NULL,
    "IdEmpleado" integer NOT NULL,
    "Estado" character varying(1),
    "Mt" numeric
);


--
-- Name: Resolucion; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."Resolucion" (
    "idEmpleado" integer NOT NULL,
    "idResolucion" integer NOT NULL,
    "idTipoResolucion" integer,
    "FechaResolucion" timestamp without time zone,
    "NumeroResolucion" character varying(50)
);


--
-- Name: ResponsableXUO; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."ResponsableXUO" (
    "IdResponsable" integer NOT NULL,
    "Year" integer,
    "idAreaOrganiz" integer,
    "AreaOrganizacional" character varying(80),
    "idDependeDe" integer,
    "IdEmpleado" integer,
    "F_Inicio" timestamp without time zone,
    "F_Termino" timestamp without time zone
);


--
-- Name: Rol; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."Rol" (
    "IdRol" integer NOT NULL,
    "Descripcion" character varying(30),
    "IdSistema" character varying(7)
);


--
-- Name: Rol_Acceso; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."Rol_Acceso" (
    "IdRol" integer NOT NULL,
    "Permiso" character varying(8),
    "IdSistemaOpcion" character varying(7) NOT NULL
);


--
-- Name: Rotacion; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."Rotacion" (
    "idEmpleado" integer NOT NULL,
    "idRotacion" integer NOT NULL,
    "FechaMemo" timestamp without time zone,
    "NroMemo" character varying(50),
    "idAreaOrganiz" integer,
    "Year" integer NOT NULL
);


--
-- Name: SistemaOpcion; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."SistemaOpcion" (
    "IdSistemaOpcion" character varying(7) NOT NULL,
    "Descripcion" character varying(150),
    "ConClave" boolean,
    "Clave" character varying(30)
);


--
-- Name: TenenciaViv; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."TenenciaViv" (
    "IdTenencia" integer NOT NULL,
    "DescripTenencia" character varying(30)
);


--
-- Name: TipoComportamiento; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."TipoComportamiento" (
    "idTipoComportamiento" integer NOT NULL,
    "TipoCompDescrip" character varying(8)
);


--
-- Name: TipoDoc; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."TipoDoc" (
    "IdTipodoc" character varying(2) NOT NULL,
    "Descripcion" character varying(40),
    "Numero" integer,
    "Serie" integer,
    "Anio" character varying(4) NOT NULL
);


--
-- Name: TipoDocID; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."TipoDocID" (
    "TipoDocID" integer NOT NULL,
    "Descripcion" character varying(40)
);


--
-- Name: TipoEstudio; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."TipoEstudio" (
    "IdTipoEstudios" integer NOT NULL,
    "DescripTipoEst" character varying(15)
);


--
-- Name: TipoFamiliar; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."TipoFamiliar" (
    "IdTipoFam" integer NOT NULL,
    "DescripTipoFam" character varying(10)
);


--
-- Name: TipoInstitucion; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."TipoInstitucion" (
    "IdTipoInstitucion" integer NOT NULL,
    "DescripTipoInstitucion" character varying(15)
);


--
-- Name: TipoMoneda; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."TipoMoneda" (
    "IdTipoMoneda" integer NOT NULL,
    "Descripcion" character varying(50),
    "Abreviatura" character varying(5)
);


--
-- Name: TipoMovimiento; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."TipoMovimiento" (
    "IdTipoMovimiento" character varying(1) NOT NULL,
    "Descripcion" character varying(40),
    "IdTipodoc" character varying(2) NOT NULL,
    "TipoOperacion" character varying(1)
);


--
-- Name: TipoPermiso; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."TipoPermiso" (
    "idTipoPermiso" integer NOT NULL,
    "DescripTipoPermiso" character varying(50)
);


--
-- Name: TipoRecurso; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."TipoRecurso" (
    "IdTipoRecurso" character varying(3) NOT NULL,
    "Descripcion" character varying(120)
);


--
-- Name: TipoResolucion; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."TipoResolucion" (
    "idTipoResolucion" integer NOT NULL,
    "DescripTipoResolucion" character varying(50)
);


--
-- Name: TipoSangre; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."TipoSangre" (
    "IdTipoSangre" integer NOT NULL,
    "DescripTS" character varying(5)
);


--
-- Name: TipoTrabajador; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."TipoTrabajador" (
    "IdTipoTrabajador" integer NOT NULL,
    "Descripcion" character varying(30),
    "Observaciones" character varying(150)
);


--
-- Name: TipoTransaccion; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."TipoTransaccion" (
    "Anio" character varying(5) NOT NULL,
    "IdTipoTransaccion" character varying(2) NOT NULL,
    "Descripcion" character varying(100)
);


--
-- Name: TipoViv; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."TipoViv" (
    "IdTipo" integer NOT NULL,
    "DescripTipo" character varying(20)
);


--
-- Name: TitulosEmpleado; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."TitulosEmpleado" (
    "NumColegiatura" character varying(20) NOT NULL,
    "DenominacionGrado" character varying(100),
    "Institucion" character varying(60),
    "Fecha" timestamp without time zone,
    "IdEmpleado" integer
);


--
-- Name: UbicacionViv; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."UbicacionViv" (
    "IdUbicacion" integer NOT NULL,
    "DescripUbicacion" character varying(22)
);


--
-- Name: Ubigeo; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."Ubigeo" (
    "IdUbigeo" character varying(6) NOT NULL,
    "Departamento" character varying(2) NOT NULL,
    "Provincia" character varying(2) NOT NULL,
    "Distrito" character varying(2) NOT NULL,
    "Descripcion" character varying(120)
);


--
-- Name: UnidadMedida; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."UnidadMedida" (
    "IdUnidadMedida" character varying(4) NOT NULL,
    "Descripcion" character varying(30),
    "Abreviado" character varying(4)
);


--
-- Name: Usuario; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."Usuario" (
    "IdUsuario" integer NOT NULL,
    "Login" character varying(20),
    "Descripcion" character varying(40),
    "Fecha" timestamp without time zone,
    "Estado" boolean,
    "IdEmpleado" integer
);


--
-- Name: Usuario_Rol; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."Usuario_Rol" (
    "IdUsuario" integer NOT NULL,
    "IdRol" integer NOT NULL
);


--
-- Name: ViveCon; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."ViveCon" (
    "IdViveCon" integer NOT NULL,
    "DescripViveCon" character varying(27)
);


--
-- Name: Vivienda; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."Vivienda" (
    "IdEmpleado" integer,
    "IdVivienda" integer NOT NULL,
    "IdTenencia" integer,
    "IdTipo" integer,
    "IdMaterial" integer,
    "IdConservacion" integer,
    "NumDormitorio" character varying(2),
    "NumServHig" character varying(2),
    "IdUbicacion" integer,
    "IdAlumbrado" integer,
    "OtroAlumbrado" character varying(50),
    "IdAgua" integer,
    "OtroAgua" character varying(50),
    "IdExcretas" integer,
    "OtroExcreta" character varying(50),
    "NumCompart" character varying(2),
    "Observacion" character varying(200),
    "NumPerDorm" character varying(2),
    "Telefono" boolean,
    "Cable" boolean,
    "Internet" boolean,
    "Otros" boolean
);


--
-- Name: asis_norm; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.asis_norm (
    "Fec_Asi" timestamp without time zone NOT NULL,
    "Hor_Ent" character varying(8) NOT NULL,
    "Hor_Sal" character varying(8) NOT NULL,
    pers_cod integer NOT NULL,
    flag_ent character varying(1),
    flag_sal character varying(1),
    alm_sal character varying(8),
    alm_ent character varying(8)
);


--
-- Name: aspnet_Applications; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."aspnet_Applications" (
    "ApplicationName" character varying(256) NOT NULL,
    "LoweredApplicationName" character varying(256) NOT NULL,
    "ApplicationId" text NOT NULL,
    "Description" character varying(256)
);


--
-- Name: aspnet_Membership; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."aspnet_Membership" (
    "ApplicationId" text NOT NULL,
    "UserId" text NOT NULL,
    "Password" character varying(128) NOT NULL,
    "PasswordFormat" integer NOT NULL,
    "PasswordSalt" character varying(128) NOT NULL,
    "MobilePIN" character varying(16),
    "Email" character varying(256),
    "LoweredEmail" character varying(256),
    "PasswordQuestion" character varying(256),
    "PasswordAnswer" character varying(128),
    "IsApproved" boolean NOT NULL,
    "IsLockedOut" boolean NOT NULL,
    "CreateDate" timestamp without time zone NOT NULL,
    "LastLoginDate" timestamp without time zone NOT NULL,
    "LastPasswordChangedDate" timestamp without time zone NOT NULL,
    "LastLockoutDate" timestamp without time zone NOT NULL,
    "FailedPasswordAttemptCount" integer NOT NULL,
    "FailedPasswordAttemptWindowStart" timestamp without time zone NOT NULL,
    "FailedPasswordAnswerAttemptCount" integer NOT NULL,
    "FailedPasswordAnswerAttemptWindowStart" timestamp without time zone CONSTRAINT "aspnet_Membership_FailedPasswordAnswerAttemptWindowSta_not_null" NOT NULL,
    "Comment" text
);


--
-- Name: aspnet_Paths; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."aspnet_Paths" (
    "ApplicationId" text NOT NULL,
    "PathId" text NOT NULL,
    "Path" character varying(256) NOT NULL,
    "LoweredPath" character varying(256) NOT NULL
);


--
-- Name: aspnet_PersonalizationAllUsers; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."aspnet_PersonalizationAllUsers" (
    "PathId" text NOT NULL,
    "PageSettings" text NOT NULL,
    "LastUpdatedDate" timestamp without time zone NOT NULL
);


--
-- Name: aspnet_PersonalizationPerUser; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."aspnet_PersonalizationPerUser" (
    "Id" text NOT NULL,
    "PathId" text,
    "UserId" text,
    "PageSettings" text NOT NULL,
    "LastUpdatedDate" timestamp without time zone NOT NULL
);


--
-- Name: aspnet_Profile; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."aspnet_Profile" (
    "UserId" text NOT NULL,
    "PropertyNames" text NOT NULL,
    "PropertyValuesString" text NOT NULL,
    "PropertyValuesBinary" text NOT NULL,
    "LastUpdatedDate" timestamp without time zone NOT NULL
);


--
-- Name: aspnet_Roles; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."aspnet_Roles" (
    "ApplicationId" text NOT NULL,
    "RoleId" text NOT NULL,
    "RoleName" character varying(256) NOT NULL,
    "LoweredRoleName" character varying(256) NOT NULL,
    "Description" character varying(256)
);


--
-- Name: aspnet_SchemaVersions; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."aspnet_SchemaVersions" (
    "Feature" character varying(128) NOT NULL,
    "CompatibleSchemaVersion" character varying(128) NOT NULL,
    "IsCurrentVersion" boolean NOT NULL
);


--
-- Name: aspnet_Users; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."aspnet_Users" (
    "ApplicationId" text NOT NULL,
    "UserId" text NOT NULL,
    "UserName" character varying(256) NOT NULL,
    "LoweredUserName" character varying(256) NOT NULL,
    "MobileAlias" character varying(16),
    "IsAnonymous" boolean NOT NULL,
    "LastActivityDate" timestamp without time zone NOT NULL
);


--
-- Name: aspnet_UsersInRoles; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."aspnet_UsersInRoles" (
    "UserId" text NOT NULL,
    "RoleId" text NOT NULL
);


--
-- Name: aspnet_WebEvent_Events; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."aspnet_WebEvent_Events" (
    "EventId" character varying(32) NOT NULL,
    "EventTimeUtc" timestamp without time zone NOT NULL,
    "EventTime" timestamp without time zone NOT NULL,
    "EventType" character varying(256) NOT NULL,
    "EventSequence" numeric NOT NULL,
    "EventOccurrence" numeric NOT NULL,
    "EventCode" integer NOT NULL,
    "EventDetailCode" integer NOT NULL,
    "Message" character varying(1024),
    "ApplicationPath" character varying(256),
    "ApplicationVirtualPath" character varying(256),
    "MachineName" character varying(256) NOT NULL,
    "RequestUrl" character varying(1024),
    "ExceptionType" character varying(256),
    "Details" text
);


--
-- Name: dtproperties; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.dtproperties (
    id integer NOT NULL,
    objectid integer,
    property character varying(64) NOT NULL,
    value character varying(255),
    uvalue character varying(255),
    lvalue text,
    version integer NOT NULL
);


--
-- Name: marcaciones; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.marcaciones (
    "Fecha" timestamp without time zone NOT NULL,
    "Valor" character varying(15) NOT NULL,
    "Estado" character varying(2),
    "Proceso" character varying(1)
);


--
-- Name: sysLogEvent; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public."sysLogEvent" (
    fecha timestamp without time zone,
    "Aplicacion" character varying(100),
    "PC" character varying(30),
    "Login" character varying(100),
    usuario character varying(100),
    "Evento" character varying(100),
    "Sentencia" character varying(2000)
);


--
-- Name: sysdiagrams; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.sysdiagrams (
    name character varying(128) NOT NULL,
    principal_id integer NOT NULL,
    diagram_id integer NOT NULL,
    version integer,
    definition text
);


--
-- PostgreSQL database dump complete
--

\unrestrict bRT8lpLeP1yLGgcbJ8QjHUjOc1obE9uRWrwlXMdyqiyKMooMDtC9rxXMzl0Cdx3
