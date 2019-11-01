using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data.SqlTypes;
using MySql.Data.Entity;
using System.Text;

namespace DogeBanking
{
    public class Connection
    {
        public void Con() 
        { 

        MySqlConnection connection = new MySqlConnection("Data Source=localhost;Initial Catalog=dogebank;User ID=root; Password=;");
             
        }

    }
}
