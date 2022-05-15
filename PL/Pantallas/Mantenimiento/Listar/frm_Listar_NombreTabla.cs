using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Catalogos_Mantenimientos;
using BLL.Catalogos_Mantenimientos;

namespace PL.Pantallas.Mantenimiento.Listar
{
    public partial class frm_Listar_NombreTabla : Form
    {
        #region Variables Globales

        cls_Territorios_BLL Obj_Territorios_BLL = new cls_Territorios_BLL();
        cls_Territorios_DAL Obj_Territorios_DAL = new cls_Territorios_DAL();

        #endregion
        public frm_Listar_NombreTabla()
        {
            InitializeComponent();
        }

        private void tlc_btn_Nuevo_Click(object sender, EventArgs e)
        {
            Pantallas.Mantenimiento.Modificar.frm_Modificar_NombreTabla PantModificar = new Modificar.frm_Modificar_NombreTabla();
            PantModificar.ShowDialog();
        }

        private void tlc_btn_Modificar_Click(object sender, EventArgs e)
        {
            Pantallas.Mantenimiento.Modificar.frm_Modificar_NombreTabla PantModificar = new Modificar.frm_Modificar_NombreTabla();
            PantModificar.ShowDialog();
        }

        private void tlc_btn_Fitro_Click(object sender, EventArgs e)
        {
            
        }

        private void tlc_btn_Refrescar_Click(object sender, EventArgs e)
        {
            CragarDatos();
        }

        private void tls_btn_Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void tls_btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CragarDatos()
        {
            dgv_Territorios.DataSource = null;

            Obj_Territorios_BLL.ListarTerritorios(ref Obj_Territorios_DAL);

            if (Obj_Territorios_DAL.sMsjError == string.Empty)
            {
                dgv_Territorios.DataSource = Obj_Territorios_DAL.Dt;
            }
            else
            {
                MessageBox.Show("Se presento un error a la hora de ejecutar el listado de los terriyorios. \n\nERROR = [" + Obj_Territorios_DAL.sMsjError + " ].",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void frm_Listar_NombreTabla_Load(object sender, EventArgs e)
        {
            CragarDatos();
        }
    }
}
