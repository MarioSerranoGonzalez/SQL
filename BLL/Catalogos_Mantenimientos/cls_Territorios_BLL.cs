using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.BD;
using DAL.Catalogos_Mantenimientos;
using System.Data;
using BLL.BD;
using BLL.Catalogos_Mantenimientos;

namespace BLL.Catalogos_Mantenimientos
{
    public class cls_Territorios_BLL
    {
        public void ListarTerritorios(ref cls_Territorios_DAL Obj_Territorios_DAL)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_DAL.sNombreTabla = "Tabla Territorios";
            Obj_BD_DAL.sNombreSP = @"dbo.SP_LISTAR_TERRITORIOS";
            Obj_BD_DAL.cAxn = 'L';

            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.Ds.Tables[0] != null)
            {
                Obj_Territorios_DAL.Dt = Obj_BD_DAL.Ds.Tables[0];
            }
            else
            {
                Obj_Territorios_DAL.Dt = null;
            }

            Obj_Territorios_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        }
        public void InsertarTerritorios()
        {

        }
        public void ModificarTerritorios()
        {

        }
        public void EliminarTerritorios()
        {

        }
    }
}
