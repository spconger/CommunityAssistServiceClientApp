using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CommunityAssistDonationServiceReference;

public partial class Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        DonorRegisterServiceClient dsc = new DonorRegisterServiceClient();
        Person p = new Person();
        p.PersonFirstName = txtFirst.Text;
        p.PersonLastName = txtLast.Text;
        p.PersonPlainPassword = txtPassword.Text;
        p.PersonUsername = txtEmail.Text;
        p.PersonEntryDate = DateTime.Now;

        PersonAddress pa = new PersonAddress();
        pa.Apartment = txtApartment.Text;
        pa.Street = txtStreet.Text;
        pa.City = txtCity.Text;
        pa.State = txtState.Text;
        pa.Zip = txtZip.Text;
        pa.Person = p;

        dsc.Register(p, pa);

        lblResult.Text = "consider donating";

    }
}