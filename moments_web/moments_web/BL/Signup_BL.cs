using moments_web.Business_Obj;
using moments_web.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace moments_web.Business_Layer
{
    public class Signup_BL
    {
        public bool CreateUser(User_Master _objUser)
        {
            
            bool IsSave = false;
            SqlConnection sqlCon = new SqlConnection(Db_Connect.conStr);
            SqlCommand sqlCom = new SqlCommand();

            try
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
                sqlCon.Open();
                sqlCom = new SqlCommand("INSERT INTO [dbo].[User_Master] ([FirstName],[LastName],[Username],[Password],[Email],[Phone]) VALUES (@FirstName,@LastName,@Username,@Password,@Email,@Phone)", sqlCon);
                sqlCom.CommandType = CommandType.Text;
                sqlCom.Parameters.AddWithValue("@FirstName", _objUser.FirstName);
                sqlCom.Parameters.AddWithValue("@LastName", _objUser.LastName);
                sqlCom.Parameters.AddWithValue("@Email", _objUser.Email);
                sqlCom.Parameters.AddWithValue("@Phone", _objUser.Phone);
                sqlCom.Parameters.AddWithValue("@Username", _objUser.Username);
                sqlCom.Parameters.AddWithValue("@Password", _objUser.Password);           

                sqlCom.ExecuteNonQuery();
                IsSave = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlCom.Dispose();
                sqlCon.Close();
            }
            return IsSave;
        }
    }
}
