using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "Ubigeo")]
public class ClsTUbigeo
{
	[Column]
	public string IdUbigeo;

	[Column]
	public string Departamento;

	[Column]
	public string Provincia;

	[Column]
	public string Distrito;

	[Column]
	public string Descripcion;

	[DebuggerNonUserCode]
	public ClsTUbigeo()
	{
	}
}
