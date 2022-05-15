using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using BLL.BD;
using DAL.BD;

namespace PL.Pantallas.Tipo_de_Cambio
{
    public partial class frm_TipoCambio : Form
    {
        #region Variables Globales

        cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
        cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

        #endregion
        public frm_TipoCambio()
        {
            InitializeComponent();
        }

        private void frm_TipoCambio_Load(object sender, EventArgs e)
        {
            txt_PI.Text = ConfigurationManager.AppSettings["PI"].ToString();
            txt_Dolar.Text = ConfigurationManager.AppSettings["TC_DOLARE"].ToString();
            txt_Euro.Text = ConfigurationManager.AppSettings["TC_EURO"].ToString();
        }

        private void btn_Abrir_Click(object sender, EventArgs e)
        {
            Obj_BD_BLL.AbrirCnx(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError != string.Empty)
            {
                MessageBox.Show("Se presento el siguiente error a la hora de conectar a la base de datos. \n\n" +
                                "ERROR = [ " + Obj_BD_DAL.sMsjError + " ]. \n");
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Obj_BD_BLL.CerrarCnx(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError != string.Empty)
            {
                MessageBox.Show("Se presento el siguiente error a la hora de cerrar la base de datos. \n\n" +
                                "ERROR = [ " + Obj_BD_DAL.sMsjError + " ]. \n");
            }
        }

        private void IrBD()
        {

        }
    }
}
