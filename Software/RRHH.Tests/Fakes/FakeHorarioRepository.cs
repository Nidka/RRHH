using System;
using System.Collections.Generic;
using RRHH.Application.Asistencia;
using RRHH.Application.Comun;
using RRHH.Domain.Asistencia;

namespace RRHH.Tests.Fakes;

/// <summary>Repositorio en memoria para verificar casos de uso y navegación sin BD ni UI.</summary>
public sealed class FakeHorarioRepository : IHorarioRepository
{
    public List<HorarioDto> Datos { get; } = new List<HorarioDto>();
    public int Lecturas { get; private set; }
    public int Escrituras { get; private set; }
    public bool EnUso { get; set; }
    public bool Fallar { get; set; }

    public IReadOnlyList<HorarioDto> Listar()
    {
        if (Fallar) throw new InvalidOperationException("Fallo simulado");
        Lecturas++;
        return Datos;
    }
    public HorarioDto Obtener(int id)
    {
        if (Fallar) throw new InvalidOperationException("Fallo simulado");
        Lecturas++;
        return Datos.Find(x => x.Id == id);
    }
    public int Insertar(Horario horario)
    {
        if (Fallar) throw new InvalidOperationException("Fallo simulado");
        Escrituras++;
        return 42;
    }
    public bool Actualizar(Horario horario)
    {
        if (Fallar) throw new InvalidOperationException("Fallo simulado");
        Escrituras++;
        return Datos.Exists(x => x.Id == horario.Id);
    }
    public bool Eliminar(int id)
    {
        if (EnUso) throw new RegistroEnUsoException("Horario referenciado", null);
        if (Fallar) throw new InvalidOperationException("Fallo simulado");
        Escrituras++;
        return Datos.RemoveAll(x => x.Id == id) > 0;
    }
}
