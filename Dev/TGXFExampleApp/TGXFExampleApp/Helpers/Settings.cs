using System;
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace TGXFExampleApp.Helpers
{
    public class Settings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        private static bool _fingerprintEnrollmentFromLogin;


        #region constants
        private const string SettingsKey = "settings_key";
        private static readonly string SettingsDefault = string.Empty;

        private const string UsernameKey = "username_key";
        private static readonly string UsernameDefault = string.Empty;
        #endregion

        #region settings
        public static string GeneralSettings
        {
            get
            {
                return AppSettings.GetValueOrDefault(SettingsKey, SettingsDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(SettingsKey, value);
            }
        }

        public static string Username
        {
            get
            {
                return AppSettings.GetValueOrDefault(UsernameKey, UsernameDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(UsernameKey, value);
            }
        }
        #endregion
    }
}
