using DevExpress.XtraEditors;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace COME.Clases
{
    public static class BaseDeDatos
    {
        /// <summary>
        /// Regresa un objeto datatable cargado a partir del texto SQL especificado.
        /// </summary>
        /// <param name="sqlText">El SQL que se usará para cargar el datatable.</param>
        /// <returns>El datatable cargado (o vacío si el SQL no regresa registros.)</returns>
        public static DataTable CargaDataTable(string sqlText)
        {
            return CargaDataTable(sqlText, new DataTable());
        }

        /// <summary>
        /// Carga el objeto datatable especificado, a partir del un texto SQL.
        /// </summary>
        /// <param name="sqlText">El SQL que se usará para cargar el datatable.</param>
        /// <param name="tab">El datatable a cargar.</param>
        /// <returns>El datatable cargado (o vacío si el SQL no regresa registros.)</returns>
        public static DataTable CargaDataTable(string sqlText, DataTable tab)
        {
            using (FbConnection conn = new FbConnection(Configuracion.COME))
            {
                using (FbCommand cmd = new FbCommand(sqlText, conn))
                {
                    conn.Open();
                    using (FbDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        tab.Load(reader);
                    }
                }
            }

            return tab;
        }

        /// <summary>
        /// Carga el objeto datatable especificado, a partir de un objeto Command.
        /// </summary>
        /// <param name="cmd">El objeto Command que cargará el datatable.</param>
        /// <returns>Un datatable cargado (o vacío si el comando no regresa registros.)</returns>
        public static DataTable CargaDataTable(FbCommand cmd)
        {
            DataTable tab = new DataTable();

            using (FbConnection conn = new FbConnection(Configuracion.COME))
            {
                using (cmd)
                {
                    cmd.Connection = conn;
                    conn.Open();
                    using (FbDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        tab.Load(reader);
                    }
                }
            }

            return tab;
        }

        /// <summary>
        /// Ejecuta un comando SQL contra la base de datos.
        /// </summary>
        /// <param name="sqlText">El comando SQL a ejecutar.</param>
        /// <param name="tipo">El tipo de comando.</param>
        public static void EjecutaQry(string sqlText, CommandType tipo)
        {
            using (FbConnection conn = new FbConnection(Configuracion.COME))
            {
                using (FbCommand cmd = new FbCommand(sqlText, conn))
                {
                    cmd.CommandType = tipo;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Ejecuta un objeto Command contra la base de datos.
        /// </summary>
        /// <param name="cmd">El objeto Command a ejecutar.</param>
        public static void EjecutaCmd(FbCommand cmd)
        {
            using (FbConnection conn = new FbConnection(Configuracion.COME))
            {
                using (cmd)
                {
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// LLena una tabla con la consulta de un procedimiento.
        /// </summary>
        /// <param name="nombreSP">Nombre del procedimiento.</param>
        /// <param name="parm">Lista de parametros.</param>
        public static DataTable DatatableSP(string nombreSP, List<FbParameter> parms)
        {
            DataTable tab = new DataTable();
            using (FbConnection conn = new FbConnection(Configuracion.COME))
            {
                FbCommand cmd = new FbCommand(nombreSP, conn);
                foreach (FbParameter parm in parms)
                {
                    cmd.Parameters.Add(parm);
                }

                using (cmd)
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (FbDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        tab.Load(reader);
                    }
                }
            }
            return tab;
        }

        public static bool EjecutarSP(string nombreSP, List<FbParameter> parms, Modulo modulo, Accion accion)
        {
            using (FbConnection conn = new FbConnection(Configuracion.COME))
            {
                try
                {
                    FbCommand cmd = new FbCommand(nombreSP, conn);
                    foreach (FbParameter parm in parms)
                    {
                        cmd.Parameters.Add(parm);
                    }

                    using (cmd)
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }
                catch (FbException ex)
                {
                    string Message = string.Empty;

                    // Módulo donde ocurrio 
                    switch (modulo)
                    {
                        case Modulo.Clientes:

                            if ((accion == Accion.Registrar || accion == Accion.Modificar) && ex.ErrorCode == 335544665)
                            {
                                Message = "La clave del Cliente ya existe.";
                                break;
                            }

                            if (accion == Accion.Eliminar && ex.ErrorCode == 335544466)
                            {
                                Message = string.Format("Hay Mercancía relacionada con este cliente.", Environment.NewLine, ex.ErrorCode, ex.Message);
                                break;
                            }

                            Message = string.Format("Error inesperado.");
                            break;
#region
                            //// Acción que se realizo
                            //switch (accion)
                            //{
                            //    case Accion.Registrar:

                            //        // Code error resultante
                            //        switch (ex.ErrorCode)
                            //        {
                            //            case 335544665:
                            //                Message = "La clave del Cliente ya existe.";
                            //                break;
                            //            default:
                            //                Message = string.Format("Error Code:'{1}'{0}Message:'{2}'", Environment.NewLine, ex.ErrorCode, ex.Message);
                            //                break;
                            //        }
                            //        break;

                            //    case Accion.Modificar:
                            //        // Code error resultante
                            //        switch (ex.ErrorCode)
                            //        {
                            //            case 335544665:
                            //                Message = "La clave del Cliente ya existe.";
                            //                break;

                            //            default:
                            //                Message = string.Format("Error Code:'{1}'{0}Message:'{2}'", Environment.NewLine, ex.ErrorCode, ex.Message);
                            //                break;
                            //        }
                            //        break;

                            //    case Accion.Eliminar:
                            //        // Code error resultante
                            //        switch (ex.ErrorCode)
                            //        {
                            //            case 335544466:
                            //                Message = string.Format("Hay Mercancía relacionada con este cliente.", Environment.NewLine, ex.ErrorCode, ex.Message);
                            //                break;

                            //            default:
                            //                Message = string.Format("Error Code:'{1}'{0}Message:'{2}'", Environment.NewLine, ex.ErrorCode, ex.Message);
                            //                break;
                            //        }
                            //        break;
                            //}
#endregion
                    }

                    Log.Escribir(ex);
                    XtraMessageBox.Show(Message, string.Format("Error: {0} -> {1}", modulo, accion), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }                        
        }

        public static string TraeCampoSP(string nombreSP)
        {
            using (FbConnection conn = new FbConnection(Configuracion.COME))
            {
                FbCommand cmd = new FbCommand(nombreSP, conn);
                string valor = string.Empty;
                using (cmd)
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    valor = cmd.ExecuteScalar().ToString();
                }
                conn.Close();
                return valor;
            }
        }
    }
}
