#!/usr/bin/env python3
"""Genera la sentencia SQL que fija la clave de un usuario web de RRHH (PBKDF2-SHA256, 210000 iteraciones).

No guarda ni imprime la clave. Uso:
    python3 deploy/generar-hash-password.py operador          # pide la clave por teclado
    USUARIO_PASSWORD='...' python3 deploy/generar-hash-password.py operador | psql "$DATABASE_URL"

El usuario debe existir ya en public."Usuario" con su rol y su empleado vinculados.
"""
import base64
import getpass
import hashlib
import os
import secrets
import sys

ITERACIONES = 210_000

def main() -> int:
    if len(sys.argv) != 2 or not sys.argv[1].strip():
        print(__doc__, file=sys.stderr)
        return 2
    login = sys.argv[1].strip()
    clave = os.environ.get("USUARIO_PASSWORD") or getpass.getpass("Clave nueva (mínimo 12 caracteres): ")
    if len(clave) < 12:
        print("La clave debe tener al menos 12 caracteres.", file=sys.stderr)
        return 1
    sal = secrets.token_bytes(16)
    derivada = hashlib.pbkdf2_hmac("sha256", clave.encode("utf-8"), sal, ITERACIONES, dklen=32)
    literal = lambda texto: "'" + texto.replace("'", "''") + "'"
    print(
        'UPDATE public."Usuario" SET '
        f'"PasswordHash" = {literal(base64.b64encode(derivada).decode())}, '
        f'"PasswordSalt" = {literal(base64.b64encode(sal).decode())}, '
        f'"PasswordIterations" = {ITERACIONES}, "PasswordChangedAt" = now() '
        f'WHERE "Login" = {literal(login)};'
    )
    return 0

if __name__ == "__main__":
    sys.exit(main())
