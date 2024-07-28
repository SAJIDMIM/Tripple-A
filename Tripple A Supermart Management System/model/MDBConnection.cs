using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//without this statement the sql won't be able to run 

namespace Tripple_A_Supermart_Management_System.model
{
    
    public class MDBConnection
    {
        private static SqlConnection con;
        public static SqlConnection createConnection()
        {

            con = new SqlConnection(@"Data Source=DESKTOP-97OVCDU\MSSQLSERVER01;Initial Catalog=Tripple_A;Integrated Security=True");
            
            return con;
        }
        
       
        
    }
   
}
