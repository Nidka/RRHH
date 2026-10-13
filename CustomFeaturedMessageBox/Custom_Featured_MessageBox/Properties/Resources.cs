using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Custom_Featured_MessageBox.Properties;

[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
[CompilerGenerated]
internal class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(resourceMan, null))
			{
				ResourceManager resourceManager = new ResourceManager("Custom_Featured_MessageBox.Properties.Resources", typeof(Resources).Assembly);
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

	internal static Bitmap Delete
	{
		get
		{
			object @object = ResourceManager.GetObject("Delete", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static Bitmap Error
	{
		get
		{
			object @object = ResourceManager.GetObject("Error", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static Bitmap Information
	{
		get
		{
			object @object = ResourceManager.GetObject("Information", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static Bitmap QuestionMark
	{
		get
		{
			object @object = ResourceManager.GetObject("QuestionMark", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static Bitmap Warning
	{
		get
		{
			object @object = ResourceManager.GetObject("Warning", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal Resources()
	{
	}
}
