using IEC.DAL.Context;
using IEC.DAL.Entities;
using IEC.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IEC.Web
{
    public partial class New : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                InitData();
            }
        }

        private void InitData()
        {
            using (var uwork = new UnitOfWork(new IECContext()))
            {
                lstBirthPlaces.DataSource = uwork.Cities.GetAll().ToList().Select(c => new ListItem(c.Name, c.ID.ToString()));
                lstBirthPlaces.DataTextField = "text";
                lstBirthPlaces.DataValueField = "value";
                lstBirthPlaces.DataBind();

                lstCitizenship.DataSource = uwork.Countries.GetAll().ToList().Select(c => new ListItem(c.Name, c.ID.ToString()));
                lstCitizenship.DataTextField = "text";
                lstCitizenship.DataValueField = "value";
                lstCitizenship.DataBind();

                lstGenders.DataSource = uwork.Genders.GetAll().ToList().Select(c => new ListItem(c.Name, c.ID.ToString()));
                lstGenders.DataTextField = "text";
                lstGenders.DataValueField = "value";
                lstGenders.DataBind();

            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            DateTime birthDate;
            if (!DateTime.TryParse(dtBirthDate.Text, out birthDate))
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "დაბადების თარიღი შეავსეთ სწორად.";
                return;
            }

            DateTime experationDate;
            if (!DateTime.TryParse(dtDateOfExpiry.Text, out experationDate))
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "მოქმედების ვადა შეავსეთ სწორად.";
                return;
            }

            DateTime issueDate;
            if (!DateTime.TryParse(dtIssueDate.Text, out issueDate))
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "გაცემის თარიღი შეავსეთ სწორად.";
                return;
            }

            var identityCard = new IdentityCard
            {
                BirthDate = birthDate,
                CardNumber = txtNumber.Text,
                CityID = int.Parse(lstBirthPlaces.SelectedItem.Value),
                CountryID = int.Parse(lstCitizenship.SelectedItem.Value),
                DateOfExpiry = experationDate,
                GenderID = int.Parse(lstGenders.SelectedItem.Value),
                IssueDate = issueDate,
                Organization = txtOrganization.Text,
                PersonalNumber = txtPersonalNumber.Text,
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text
            };

            using (var uwork = new UnitOfWork(new IECContext()))
            {
                uwork.IdentityCards.Add(identityCard);
                uwork.Save();
                Response.Redirect("Default.aspx");
            }
        }
    }
}