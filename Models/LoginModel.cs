namespace RiaanCarelse_ST10065550_POEPart1.Models
{
    public class LoginModel
    {
        public static string con_string = "Server=tcp:dbs-vc-riaan-st10065550.database.windows.net,1433;Initial Catalog=db-vc-riaan-st10065550;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Authentication=\"Active Directory Default\";";


        public int SelectUser(string email, string name)
        {
            int userId = -1; // Default value if user is not found
            using (SqlConnection con = new SqlConnection(con_string))
            {
                string sql = "SELECT userID FROM userTable WHERE userEmail = @Email AND userName = @Name";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Name", name);
                try
                {
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        userId = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    // Log the exception or handle it appropriately
                    // For now, rethrow the exception
                    throw ex;
                }
            }
            return userId;
        }

    }
}
