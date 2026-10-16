-- Tablas usadas por modulos recuperados que no estaban incluidas en el dump PostgreSQL.
-- Es idempotente para poder aplicarse tanto en Neon como en entornos locales.

CREATE TABLE IF NOT EXISTS public."Documento" (
    "idDocumento" integer NOT NULL,
    "DescripDocumento" character varying(50),
    CONSTRAINT "PK_Documento" PRIMARY KEY ("idDocumento")
);

CREATE TABLE IF NOT EXISTS public."Archivo" (
    "idDocumento" integer NOT NULL,
    "IdEmpleado" integer NOT NULL,
    "FechaIngreDoc" timestamp without time zone,
    "FechaVenDoc" timestamp without time zone,
    "NumRef" character varying(20),
    "Obs" character varying(120),
    CONSTRAINT "PK_Archivo" PRIMARY KEY ("idDocumento", "IdEmpleado"),
    CONSTRAINT "FK_Archivo_Documento" FOREIGN KEY ("idDocumento")
        REFERENCES public."Documento" ("idDocumento")
);

CREATE TABLE IF NOT EXISTS public."Ingreso" (
    "IdIngreso" integer NOT NULL,
    "IdEmpleado" integer,
    "Remuneracion" numeric(8,2),
    "Honorarios" numeric(8,2),
    "AlqPredio" numeric(8,2),
    "AlqBienes" numeric(8,2),
    "CapitalesColocados" numeric(8,2),
    "Dietas" numeric(8,2),
    "Negocios" numeric(8,2),
    "Otros" numeric(8,2),
    "IngresoMiembros" numeric(8,2),
    "NumPersonaAportan" character varying(2),
    CONSTRAINT "PK_Ingreso" PRIMARY KEY ("IdIngreso")
);

CREATE TABLE IF NOT EXISTS public."Egreso" (
    "IdEgreso" integer NOT NULL,
    "IdEmpleado" integer,
    "Alimentacion" numeric(8,2),
    "Vivienda" numeric(8,2),
    "Educacion" numeric(8,2),
    "Salud" numeric(8,2),
    "Vestido" numeric(8,2),
    "Recreacion" numeric(8,2),
    "Prestamos" numeric(8,2),
    "Otros" numeric(8,2),
    "Transporte" numeric(8,2),
    "EnergiaElec" numeric(8,2),
    "Agua" numeric(8,2),
    "BajaPolicia" numeric(8,2),
    "Telefono" numeric(8,2),
    "SeguroPriv" numeric(8,2),
    "TarjCredito" numeric(8,2),
    CONSTRAINT "PK_Egreso" PRIMARY KEY ("IdEgreso")
);

CREATE INDEX IF NOT EXISTS "IX_Archivo_IdEmpleado" ON public."Archivo" ("IdEmpleado");
CREATE INDEX IF NOT EXISTS "IX_Ingreso_IdEmpleado" ON public."Ingreso" ("IdEmpleado");
CREATE INDEX IF NOT EXISTS "IX_Egreso_IdEmpleado" ON public."Egreso" ("IdEmpleado");
