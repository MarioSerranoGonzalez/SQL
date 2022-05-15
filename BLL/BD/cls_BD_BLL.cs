using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.BD;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BLL.BD
{
    public class cls_BD_BLL
    {
        public void AbrirCnx(ref cls_BD_DAL Obj_BD_DAL)
        {
            try
            {
                if (Obj_BD_DAL.Obj_SqlCnx == null)
                {
                    //1.Generer o instanciar el obj cnx
                    Obj_BD_DAL.Obj_SqlCnx = new SqlConnection(ConfigurationManager.ConnectionStrings["SQL_AUT"].ToString().Trim());
                }
               
                //2.Abrir la Cnx de Base datos
                if (Obj_BD_DAL.Obj_SqlCnx.State == ConnectionState.Closed)
                {
                    Obj_BD_DAL.Obj_SqlCnx.Open();
                    Obj_BD_DAL.sMsjError = string.Empty;
                }
                else
                {
                    Obj_BD_DAL.sMsjError = "El objeto de conexion a la base de datos ya esta abierto, no puede abrirlo de nuevo. ";
                }
            }
            catch (SqlException ex)
            {
                Obj_BD_DAL.sMsjError = ex.Message.ToString();
            }
        }
        public void CerrarCnx(ref cls_BD_DAL Obj_BD_DAL)
        {
            try
            {
                //1.Validar el estado de la conexion
                if (Obj_BD_DAL.Obj_SqlCnx.State == ConnectionState.Open)
                {
                    Obj_BD_DAL.Obj_SqlCnx.Close();
                    Obj_BD_DAL.sMsjError = string.Empty;

                }
                else
                {
                    Obj_BD_DAL.sMsjError = "El objeto de conexion a la base de datos ya esta cerrado, no puede cerrarlo de nuevo. ";
                }
            }
            catch (SqlException ex)
            {
                Obj_BD_DAL.sMsjError = ex.Message.ToString();
            }

        }           
        public void ExecDataAdapter(ref cls_BD_DAL Obj_BD_DAL)
        {
            try
            {
                if (Obj_BD_DAL.Obj_SqlCnx == null)
                {
                    Obj_BD_DAL.Obj_SqlCnx = new SqlConnection(ConfigurationManager.ConnectionStrings["SQL_AUT"].ToString().Trim());
                }

                if (Obj_BD_DAL.Obj_SqlCnx.State == ConnectionState.Closed)
                {
                    Obj_BD_DAL.Obj_SqlCnx.Open();
                }

                //Crear e instanciar el objeto SQLDataadapter
                Obj_BD_DAL.Obj_SqlDap = new SqlDataAdapter(Obj_BD_DAL.sNombreSP,Obj_BD_DAL.Obj_SqlCnx);

                //Darle la seguridad al DAP
                Obj_BD_DAL.Obj_SqlDap.SelectCommand.CommandType = CommandType.StoredProcedure;

                //instanciar el Data Set
                Obj_BD_DAL.Ds = new DataSet();

                //ejecutamos el proceso en la BD
                Obj_BD_DAL.Obj_SqlDap.Fill(Obj_BD_DAL.Ds, Obj_BD_DAL.sNombreTabla);

                Obj_BD_DAL.sMsjError = string.Empty;
            }
            catch (SqlException ex)
            {
                Obj_BD_DAL.sMsjError = ex.Message.ToString();
            }
            finally
            {
                if (Obj_BD_DAL.Obj_SqlCnx.State == ConnectionState.Open)
                {
                    Obj_BD_DAL.Obj_SqlCnx.Close();
                }

                Obj_BD_DAL.Obj_SqlCnx.Dispose();
            }
        }
        public void ExecCommand(ref cls_BD_DAL Obj_BD_DAL)
        {
            try
            {
                Obj_BD_DAL.sMsjError = string.Empty;
            }
            catch (SqlException ex)
            {
                Obj_BD_DAL.sMsjError = ex.Message.ToString();
            }
            finally
            {
                if (Obj_BD_DAL.Obj_SqlCnx.State == ConnectionState.Open)
                {
                    Obj_BD_DAL.Obj_SqlCnx.Close();
                }

                Obj_BD_DAL.Obj_SqlCnx.Dispose();
            }
        }
    }
}
