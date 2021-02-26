using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ECOLE_SECONDAIRE.CLASS_DATA_BASE
{
    class MYCONNECTION
    {
        public static SqlConnection con = new SqlConnection("server='DESKTOP-N05KP32\\SA';database=ECOLE_PRIMAIRE;uid=SA;pwd=aliconnorecho");

    }
}
