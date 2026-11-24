// RF-04 y RF-05: agregar y eliminar motivos de permiso, por tipo.

import { api } from '../../componentes/api.js';
import { plantilla, alEnviar, opciones } from '../../componentes/formulario.js';
import { tabla } from '../../componentes/tabla.js';
import { exito, mostrar } from '../../componentes/mensajes.js';

export async function montar(contenedor) {
  contenedor.append(plantilla(`
    <form class="tarjeta" data-formulario="alta">
      <label>Tipo de permiso<select name="tipo" required><option value="">Seleccione un tipo</option></select></label>
      <label>Descripción<input name="descripcion" maxlength="50" required></label>
      <label>Abreviatura (opcional)<input name="abreviatura" maxlength="3"></label>
      <label>Con goce de haber<select name="salario"><option value="">Sin indicar</option><option value="true">Sí</option><option value="false">No</option></select></label>
      <div class="acciones"><button>Agregar motivo</button></div>
    </form>
    <h2>Motivos del tipo seleccionado</h2>
    <div class="resultados"><p class="vacio">Elija un tipo de permiso para ver sus motivos.</p></div>
    <form class="tarjeta peligro" data-formulario="baja" hidden>
      <label>Motivo a eliminar<select name="id" required><option value="">Seleccione un motivo</option></select></label>
      <label class="casilla"><input name="confirmar" type="checkbox" required>Confirmo la eliminación del motivo seleccionado</label>
      <div class="acciones"><button>Eliminar motivo</button></div>
    </form>`));
  const alta = contenedor.querySelector('[data-formulario=alta]');
  const baja = contenedor.querySelector('[data-formulario=baja]');
  const listado = contenedor.querySelector('.resultados');

  async function listar() {
    const tipo = alta.elements.tipo.value;
    baja.hidden = true;
    baja.reset();
    if (!tipo) { listado.replaceChildren(); return; }
    const filas = await api('motivos-permiso?tipo=' + encodeURIComponent(tipo));
    if (tipo !== alta.elements.tipo.value) return;
    tabla(listado, ['Código', 'Descripción', 'Abreviatura', 'Goce de haber', 'Modalidad'],
      filas.map(f => [f.id, f.descripcion, f.abreviatura ?? '', f.salario == null ? '—' : (f.salario ? 'Sí' : 'No'), f.modalidad ?? '']),
      'Este tipo no tiene motivos registrados.');
    opciones(baja.elements.id, filas, f => `${f.id} · ${f.descripcion}`);
    baja.hidden = filas.length === 0;
  }

  alta.elements.tipo.addEventListener('change', () => listar().catch(falla => mostrar(falla.message, 'error')));
  baja.elements.id.addEventListener('change', () => { baja.elements.confirmar.checked = false; });

  alEnviar(alta, async datos => {
    const entrada = Object.fromEntries(datos);
    entrada.tipo = Number(entrada.tipo);
    entrada.salario = entrada.salario === '' ? null : entrada.salario === 'true';
    const creado = await api('motivos-permiso', entrada);
    alta.elements.descripcion.value = '';
    alta.elements.abreviatura.value = '';
    exito(`Motivo ${creado.id} registrado.`);
    await listar();
  });

  alEnviar(baja, async datos => {
    const id = datos.get('id');
    await api('motivos-permiso/' + encodeURIComponent(id) + '/eliminar', {});
    exito(`Motivo ${id} eliminado.`);
    await listar();
  });

  opciones(alta.elements.tipo, await api('motivos-permiso/tipos'));
}
