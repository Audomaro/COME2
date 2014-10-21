using System.Configuration;

namespace COME.Clases
{
    public static class Configuracion
    {
        /// <summary>
        /// Cadena de conexion hacia la base de datos de COME.
        /// </summary>
        public static string COME
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["come"].ToString();
            }
        }

        public static string SkinSeleccionado 
        {
            get
            {
                return AppSettingsObtener("skinSeleccionado");
            }
            set
            {
                AppSettingsGuardar("skinSeleccionado", value);
            }
        }

        private static string AppSettingsObtener(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
        
        private static void AppSettingsGuardar(string key, string value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
