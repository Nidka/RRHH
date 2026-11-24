// RF-04 y RF-05: agregar y eliminar motivos de permiso, por tipo.

import { api } from '../../componentes/api.js';
import { plantilla, alEnviar, opciones } from '../../componentes/formulario.js';
import { tabla } from '../../componentes/tabla.js';
import { chip, vacio } from '../../componentes/ui.js';
import { exito, mostrar } from '../../componentes/mensajes.js';

export async function montar(contenedor) {
  contenedor.append(plantilla(`
    <div class="rejilla formulario-y-resultado">
      <div>
        <form class="tarjeta formulario" data-formulario="alta">
          <label class="completo">Tipo de permiso<select name="tipo" required><option value="">Seleccione un tipo</option></select></label>
          <label class="completo">Descripción<input name="descripcion" maxlength="50" required placeholder="Ej. Capacitación externa"></label>
          <label>Abreviatura <small>(opcional)</small><input name="abreviatura" maxlength="3"></label>
          <label>Con goce de haber<select name="salario"><option value="">Sin indicar</option><option value="true">Sí</option><option value="false">No</option></select></label>
          <div class="acciones"><button class="btn btn-primario">Agregar motivo</button></div>
        </form>
        <form class="tarjeta formulario" data-formulario="baja" hidden>
          <label class="completo">Motivo a eliminar<select name="id" required><option value="">Seleccione un motivo</option></select></label>
          <label class="casilla completo"><input name="confirmar" type="checkbox" required>Confirmo la eliminación del motivo seleccionado</label>
          <div class="acciones"><button class="btn btn-peligro">Eliminar motivo</button></div>
        </form>
      </div>
      <section class="tarjeta sin-relleno">
        <div class="tarjeta-cabecera"><div><h2>Motivos del tipo seleccionado</h2><p>El catálogo se actualiza al agregar o eliminar.</p></div></div>
        <div class="resultados separado-chico"></div>
      </section>
    </div>`));
  const alta = contenedor.querySelector('[data-formulario=alta]');
  const baja = contenedor.querySelector('[data-formulario=baja]');
  const listado = contenedor.querySelector('.resultados');
  listado.append(vacio('Elija un tipo de permiso para ver sus motivos.', 'permisos'));

  async function listar() {
    const tipo = alta.elements.tipo.value;
    baja.hidden = true;
    baja.reset();
    if (!tipo) { listado.replaceChildren(vacio('Elija un tipo de permiso para ver sus motivos.', 'permisos')); return; }
    const filas = await api('motivos-permiso?tipo=' + encodeURIComponent(tipo));
    if (tipo !== alta.elements.tipo.value) return;
    tabla(listado, ['Código', 'Descripción', 'Abrev.', 'Goce de haber', 'Estado'],
      filas.map(f => [f.id, f.descripcion, f.abreviatura || '—',
        f.salario == null ? chip('Sin indicar') : chip(f.salario ? 'Con goce' : 'Sin goce', f.salario ? 'exito' : 'aviso'),
        chip(f.activo === false ? 'Inactivo' : 'Activo', f.activo === false ? '' : 'marca')]),
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
