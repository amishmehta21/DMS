using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DMSBE;
using DMSDAL;

namespace DMSBAL
{
    public class MiscellaneousMasterBAL
    {
        #region Methods

        public bool AddMiscellaneous(MiscellaneousMasterBE MiscBE)
        {
            MiscellaneousMasterDAL MiscDAL = new MiscellaneousMasterDAL();
            if (MiscDAL.AddMiscellaneous(MiscBE))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ModifyMiscellaneous(MiscellaneousMasterBE MiscBE)
        {
            MiscellaneousMasterDAL MiscDAL = new MiscellaneousMasterDAL();
            if (MiscDAL.ModifyMiscellaneous(MiscBE))
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public bool ShowMiscellaneous(ref DataTable dt)
        {
            MiscellaneousMasterDAL MiscDAL = new MiscellaneousMasterDAL();
            if (MiscDAL.ShowMiscellaneous(ref dt))
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        #endregion Methods
    }


}
