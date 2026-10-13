using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common.My;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

	public static MySettings Default => defaultInstance;

	[ApplicationScopedSetting]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Data Source=localhost;Initial Catalog=CMI;Integrated Security=True;Connect Timeout=30")]
	public string CMIConnectionString => Conversions.ToString(this["CMIConnectionString"]);

	[DebuggerNonUserCode]
	public MySettings()
	{
	}
}
