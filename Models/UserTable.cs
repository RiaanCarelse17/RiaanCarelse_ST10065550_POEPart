using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;

namespace RiaanCarelse_ST10065550_POEPart1.Models
{
    public class UserTable
    {


       
        public static string con_string = "dbs-vc-riaan-st10065550.database.windows.net,1433;Initial Catalog=db-vc-riaan-st10065550;Persist Security Info=False;User ID=riaan;Password=Rcc03rkc;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";

        public static SqlConnection con = new SqlConnection(con_string);



        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }





        public int insert_User(userTable m)
        {

            try
            {
                string sql = "INSERT INTO userTable (userName, userSurname, userEmail) VALUES (@Name, @Surname, @Email)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Name", m.Name);
                cmd.Parameters.AddWithValue("@Surname", m.Surname);
                cmd.Parameters.AddWithValue("@Email", m.Email);
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();
                return rowsAffected;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it appropriately
                // For now, rethrow the exception
                throw ex;
            }


        }

    }
}
