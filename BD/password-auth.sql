BEGIN;

ALTER TABLE public."Usuario"
    ADD COLUMN IF NOT EXISTS "PasswordHash" character varying(128),
    ADD COLUMN IF NOT EXISTS "PasswordSalt" character varying(128),
    ADD COLUMN IF NOT EXISTS "PasswordIterations" integer,
    ADD COLUMN IF NOT EXISTS "PasswordChangedAt" timestamp with time zone;

COMMENT ON COLUMN public."Usuario"."PasswordHash" IS
    'Hash PBKDF2-SHA256 codificado en Base64; nunca contiene texto plano.';
COMMENT ON COLUMN public."Usuario"."PasswordSalt" IS
    'Salt aleatorio del hash, codificado en Base64.';
COMMENT ON COLUMN public."Usuario"."PasswordIterations" IS
    'Cantidad de iteraciones PBKDF2 usadas para derivar PasswordHash.';

COMMIT;
