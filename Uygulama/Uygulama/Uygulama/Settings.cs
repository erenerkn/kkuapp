using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Uygulama
{
    public class Settings
	{
		static ISettings getSettings => CrossSettings.Current;
		public static string Key
		{
			get => CrossSettings.Current.GetValueOrDefault(App.key, "");
			set => CrossSettings.Current.AddOrUpdateValue(App.key, value);
		}
		public static void Delete()
		{
			CrossSettings.Current.Remove(App.key);
		}
		public static string Key2
		{
			get => CrossSettings.Current.GetValueOrDefault(App.key2, "");
			set => CrossSettings.Current.AddOrUpdateValue(App.key2, value);
		}
		public static void Delete2()
		{
			CrossSettings.Current.Remove(App.key2);
		}
	}
}
