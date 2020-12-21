using moments_web.Business_Layer;
using moments_web.Business_Obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace moments_web.UAC
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                User_Master _objUser = new User_Master();
                Signup_BL _objSingup = new Signup_BL();

                _objUser.FirstName = txtFirstName.Text.Trim();
                _objUser.LastName = txtLastName.Text.Trim();
                _objUser.Email = txtEmail.Text.Trim();
                _objUser.Phone = txtPhone.Text.Trim();
                _objUser.Username = txtUsername.Text.Trim();
                _objUser.Password = txtPassword.Text.Trim();

                bool IsSave = _objSingup.CreateUser(_objUser);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}