using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace RecursosHumanos.My.Resources;

/// <summary>
///   Clase de recurso con establecimiento inflexible de tipos, para buscar cadenas traducidas, etc.
/// </summary>
[HideModuleName]
[CompilerGenerated]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[StandardModule]
internal sealed class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	/// <summary>
	///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(resourceMan, null))
			{
				ResourceManager resourceManager = new ResourceManager("RecursosHumanos.Resources", typeof(Resources).Assembly);
				resourceMan = resourceManager;
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap _exit
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("exit", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap add2
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("add2", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap alarmclock
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("alarmclock", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap arrow_left_green
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("arrow_left_green", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap arrow_right_green
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("arrow_right_green", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap Back_rrhh
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Back_rrhh", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap calendar
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("calendar", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap cargando
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("cargando", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap check2
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("check2", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap clock
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("clock", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap delete2
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("delete2", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap diseño_logo_sistema_de_recursos_humanos6
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("diseño logo sistema de recursos humanos6", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap diseño_logo_sistema_de_recursos_humanos7_copia
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("diseño logo sistema de recursos humanos7 copia", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap disk_blue
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("disk_blue", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap disk_blue1
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("disk_blue1", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap document_certificate
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("document_certificate", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap document_certificate1
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("document_certificate1", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap document_cup
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("document_cup", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap document_delete
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("document_delete", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap document_edit
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("document_edit", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap document_ok
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("document_ok", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap document_out
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("document_out", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap folder_important
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("folder_important", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap form_yellow
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("form_yellow", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap graphics_tablet
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("graphics-tablet", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap help2
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("help2", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap hourglass_go
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("hourglass_go", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap hourglass_go1
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("hourglass_go1", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap Logo_GRLL_ok
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Logo GRLL ok", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static byte[] ReportePorcentaje
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("ReportePorcentaje", resourceCulture));
			return (byte[])objectValue;
		}
	}

	internal static Bitmap view
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("view", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap view1
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("view1", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap yast_sysadmin
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("yast_sysadmin", resourceCulture));
			return (Bitmap)objectValue;
		}
	}
}
