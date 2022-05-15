using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.Catalogos_Mantenimientos
{
    public class cls_Territorios_DAL
    {
        #region Variables Privadas

            private string _sTerritoryID, _sTerritoryDescription, _sMsjError;
            private int _iRegionID;
            private DataTable _Dt;

        #endregion

        #region Constructores

            public string sTerritoryID { get => _sTerritoryID; set => _sTerritoryID = value; }
            public string sTerritoryDescription { get => _sTerritoryDescription; set => _sTerritoryDescription = value; }
            public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
            public int iRegionID { get => _iRegionID; set => _iRegionID = value; }
            public DataTable Dt { get => _Dt; set => _Dt = value; }

        #endregion
    }
}
