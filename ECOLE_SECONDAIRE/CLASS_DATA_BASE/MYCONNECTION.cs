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
        public static SqlConnection con = new SqlConnection("Data Source=EXAUCE\\SA;Initial Catalog=ECOLE_PRIMAIRE;User ID=sa;Password=aliconnorecho");

    }
}