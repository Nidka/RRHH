using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace RecursosHumanos.My;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
[CompilerGenerated]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

	private static bool addedHandler;

	private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());

	public static MySettings Default
	{
		get
		{
			if (!addedHandler)
			{
				object obj = addedHandlerLockObject;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				Monitor.Enter(obj);
				try
				{
					if (!addedHandler)
					{
						MyProject.Application.Shutdown += [EditorBrowsable(EditorBrowsableState.Advanced)] [DebuggerNonUserCode] (object sender, EventArgs e) =>
						{
							if (MyProject.Application.SaveMySettingsOnExit)
							{
								MySettingsProperty.Settings.Save();
							}
						};
						addedHandler = true;
					}
				}
				finally
				{
					Monitor.Exit(obj);
				}
			}
			return defaultInstance;
		}
	}

	[DefaultSettingValue("")]
	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public string Usuario => Conversions.ToString(this["Usuario"]);

	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	[DefaultSettingValue("CMI")]
	public string BaseDatos => Conversions.ToString(this["BaseDatos"]);

	[ApplicationScopedSetting]
	[DefaultSettingValue("localhost")]
	[DebuggerNonUserCode]
	public string Servidor => Conversions.ToString(this["Servidor"]);

	[DefaultSettingValue("False")]
	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	public bool AutenticacionIntegrada => Conversions.ToBoolean(this["AutenticacionIntegrada"]);

	[ApplicationScopedSetting]
	[DefaultSettingValue("30")]
	[DebuggerNonUserCode]
	public int TiempoConexion => Conversions.ToInteger(this["TiempoConexion"]);

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("2013")]
	public string AnioActual
	{
		get
		{
			return Conversions.ToString(this["AnioActual"]);
		}
		set
		{
			this["AnioActual"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("D:\\Sistema_GRLL\\Logo_GRLL.jpg")]
	public string RutaLogo
	{
		get
		{
			return Conversions.ToString(this["RutaLogo"]);
		}
		set
		{
			this["RutaLogo"] = value;
		}
	}

	[SpecialSetting(SpecialSetting.ConnectionString)]
	[DefaultSettingValue("Data Source=localhost;Initial Catalog=CMI;Integrated Security=True;Connect Timeout=30")]
	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	public string CMIConnectionString => Conversions.ToString(this["CMIConnectionString"]);

	[DebuggerNonUserCode]
	public MySettings()
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerNonUserCode]
	private static void AutoSaveSettings(object sender, EventArgs e)
	{
		if (MyProject.Application.SaveMySettingsOnExit)
		{
			MySettingsProperty.Settings.Save();
		}
	}
}
