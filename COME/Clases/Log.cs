using FirebirdSql.Data.FirebirdClient;
using System;
using System.IO;

namespace COME.Clases
{
    public static class Log
    {
        public static void Escribir(FbException Ex)
        {
            using (StreamWriter fs = new StreamWriter(@"COME_Log.txt", true))
            {
                fs.WriteLine("<-------------------------------------------------------[\tLog Ini\t]------------------------------------------------------->");
                fs.WriteLine(string.Format("\tFecha: {0}", DateTime.Now.ToLongDateString()));
                fs.WriteLine(string.Format("\tHora: {0}", DateTime.Now.ToLongTimeString()));
                fs.WriteLine(string.Format("\tVersión SO: {0}", Environment.OSVersion));
                fs.WriteLine(string.Format("\tSO x64: {0}", Environment.Is64BitOperatingSystem));
                fs.WriteLine(string.Format("\tProcesador x64: {0}", Environment.Is64BitProcess));
                fs.WriteLine(string.Format("\tCódigo: {0}", Ex.ErrorCode));
                fs.WriteLine(string.Format("\tErrores: {0}", Ex.Errors));
                fs.WriteLine(string.Format("\tMensaje: {0}", Ex.Message));
                fs.WriteLine("");        
            }
        }

        public static void Escribir(params string[] datos)
        {
            using (StreamWriter fs = new StreamWriter(@"COME_Log.txt", true))
            {
                fs.WriteLine("<-------------------------------------------------------[\tLog Ini\t]------------------------------------------------------->");
                foreach(string dato in datos)
                {
                    fs.WriteLine(string.Format("\t{0}", dato));
                }
                fs.WriteLine("");
            }
        }
    }
}
