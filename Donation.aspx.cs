using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CommunityAssistDonationServiceReference;

public partial class Donation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userkey"] ==null)
        {
            Response.Redirect("Default.aspx");
        }
    }
    protected void btnDonation_Click(object sender, EventArgs e)
    {
        DonorRegisterServiceClient dsc = new DonorRegisterServiceClient();
        CommunityAssistDonationServiceReference.Donation d = new CommunityAssistDonationServiceReference.Donation();
        decimal amount;
        int key = (int)Session["userkey"];
        bool goodAmount = decimal.TryParse(txtDonation.Text, out amount);
        if (goodAmount)
        {
            d.DonationAmount = amount;
            d.DonationDate = DateTime.Now;
            d.PersonKey = key;
            dsc.Donate(d);
            lblResult.Text = "thank you";
        }
        else
        {
            Response.Write("<script>alert('Enter a valid number')</script>");
        }
        
    }
}