using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1UTSPBO
{
    public class LoginmhsContext
    {
        string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=232804;Database=pbo2024;CommandTimeout=10";
        public Loginmhs AuthLoginmhs(int NIM, string Password)
        {
            Loginmhs login = new Loginmhs();
            string query = string.Format(@"select t1.NIM. t2.Password
                from Data_mhs t1 inner join Data_mhs t2 ON t2.NIM
                where t1.NIM = : NIM and t1.Password;");

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter(":NIM", NIM));
                    cmd.Parameters.Add(new NpgsqlParameter(":Password", Password));
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                }
            }

        }


    }
}
