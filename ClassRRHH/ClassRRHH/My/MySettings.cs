using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace ClassRRHH.My;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[CompilerGenerated]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

	public static MySettings Default => defaultInstance;

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string Serie
	{
		get
		{
			return Conversions.ToString(this["Serie"]);
		}
		set
		{
			this["Serie"] = value;
		}
	}

	[DefaultSettingValue("")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string SEDE
	{
		get
		{
			return Conversions.ToString(this["SEDE"]);
		}
		set
		{
			this["SEDE"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string Aplicacion
	{
		get
		{
			return Conversions.ToString(this["Aplicacion"]);
		}
		set
		{
			this["Aplicacion"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	[UserScopedSetting]
	public string Version
	{
		get
		{
			return Conversions.ToString(this["Version"]);
		}
		set
		{
			this["Version"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	[UserScopedSetting]
	public string Key
	{
		get
		{
			return Conversions.ToString(this["Key"]);
		}
		set
		{
			this["Key"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	public string App
	{
		get
		{
			return Conversions.ToString(this["App"]);
		}
		set
		{
			this["App"] = value;
		}
	}

	[DebuggerNonUserCode]
	public MySettings()
	{
	}
}
