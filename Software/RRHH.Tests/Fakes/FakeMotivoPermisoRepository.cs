using System;
using System.Collections.Generic;
using System.Linq;
using RRHH.Application.Comun;
using RRHH.Application.Permisos;
using RRHH.Domain.Permisos;

namespace RRHH.Tests.Fakes;

public sealed class FakeMotivoPermisoRepository : IMotivoPermisoRepository
{
    public List<MotivoPermiso> Registros { get; } = new List<MotivoPermiso>();
    public HashSet<int> EnUso { get; } = new HashSet<int>();
    public int Escrituras { get; private set; }
    public int Consultas { get; private set; }
    public int Listados { get; private set; }
    public string UltimaModalidad { get; private set; }
    public bool Fallar { get; set; }
    public bool ConflictoActualizacion { get; set; }

    public IReadOnlyList<MotivoPermisoDto> Listar(int tipo, string modalidad)
    {
        Listados++;
        UltimaModalidad = modalidad;
        return Registros.Where(m => m.TipoPermisoId == tipo && (modalidad == null || m.Modalidad == modalidad))
            .Select(MotivoPermisoDto.Desde).ToList();
    }
    public MotivoPermiso Obtener(int id) { Consultas++; return Registros.SingleOrDefault(m => m.Id == id); }
    public int Insertar(MotivoPermiso motivo)
    {
        if (Fallar) throw new InvalidOperationException("Conexión interrumpida");
        Escrituras++;
        int id = Registros.Count == 0 ? 1 : Registros.Max(m => m.Id) + 1;
        Registros.Add(MotivoPermiso.Reconstituir(id, motivo.TipoPermisoId, motivo.Descripcion,
            motivo.Abreviatura, motivo.Salario, motivo.Modalidad, motivo.Activo));
        return id;
    }
    public bool Actualizar(MotivoPermiso motivo)
    {
        if (Fallar) throw new InvalidOperationException("Conexión interrumpida");
        if (ConflictoActualizacion) return false;
        int index = Registros.FindIndex(m => m.Id == motivo.Id);
        if (index < 0) return false;
        Escrituras++;
        Registros[index] = motivo;
        return true;
    }
    public bool Eliminar(int id, string modalidad)
    {
        MotivoPermiso motivo = Registros.SingleOrDefault(m => m.Id == id);
        if (motivo == null || (modalidad != null && modalidad != motivo.Modalidad)) return false;
        if (EnUso.Contains(id)) throw new RegistroEnUsoException("En uso", null);
        Escrituras++;
        return Registros.Remove(motivo);
    }
}
