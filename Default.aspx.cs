using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CommunityAssistDonationServiceReference;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        DonorRegisterServiceClient crsc = new DonorRegisterServiceClient();
        int key = crsc.Login(txtUserName.Text, txtPassword.Text);
        if (key != 0)
        {
            lblResult.Text = "Welcome";
            Session["userkey"] = key;
        }
        else
        {
            lblResult.Text = "Invalid Login";
        }

    }
}