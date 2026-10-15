using RRHH.Presentation.Catalogos;

namespace RecursosHumanos;

/// <summary>Formulario FrmMant* de un catálogo simple, migrado a MVP.</summary>
internal interface IFormularioCatalogo
{
	/// <summary>Vista que conecta CompositionRoot con el CatalogoPresenter.</summary>
	ICatalogoView Vista { get; }
}
