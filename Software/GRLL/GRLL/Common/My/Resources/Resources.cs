using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common.My.Resources;

/// <summary>
///   Clase de recurso con establecimiento inflexible de tipos, para buscar cadenas traducidas, etc.
/// </summary>
[StandardModule]
[HideModuleName]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
[CompilerGenerated]
public sealed class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	/// <summary>
	///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(resourceMan, null))
			{
				ResourceManager temp = new ResourceManager("GRLL.Common.Resources", typeof(Resources).Assembly);
				resourceMan = temp;
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static CultureInfo Culture
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

	public static Bitmap button_cancel
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("button_cancel", resourceCulture));
			return (Bitmap)obj;
		}
	}

	public static Bitmap cancel
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("cancel", resourceCulture));
			return (Bitmap)obj;
		}
	}

	public static Bitmap copy16
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("copy16", resourceCulture));
			return (Bitmap)obj;
		}
	}

	public static Bitmap filefind
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("filefind", resourceCulture));
			return (Bitmap)obj;
		}
	}

	public static Bitmap filesave
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("filesave", resourceCulture));
			return (Bitmap)obj;
		}
	}

	public static Bitmap paste16
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("paste16", resourceCulture));
			return (Bitmap)obj;
		}
	}

	public static Bitmap printer
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("printer", resourceCulture));
			return (Bitmap)obj;
		}
	}

	public static byte[] ReportesTablas
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("ReportesTablas", resourceCulture));
			return (byte[])obj;
		}
	}

	public static Bitmap resultset_first
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("resultset_first", resourceCulture));
			return (Bitmap)obj;
		}
	}

	public static Bitmap resultset_last
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("resultset_last", resourceCulture));
			return (Bitmap)obj;
		}
	}

	public static Bitmap resultset_next
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("resultset_next", resourceCulture));
			return (Bitmap)obj;
		}
	}

	public static Bitmap resultset_previous
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("resultset_previous", resourceCulture));
			return (Bitmap)obj;
		}
	}
}
