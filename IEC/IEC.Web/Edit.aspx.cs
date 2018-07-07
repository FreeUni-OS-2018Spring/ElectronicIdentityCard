using IEC.BLL.Validators;
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
    public partial class Edit : System.Web.UI.Page
    {
        private readonly IDentityCardsValidator _validator;

        public Edit()
        {
            _validator = new IDentityCardsValidator();
        }

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


                var idQuery = Request.QueryString["id"];
                int id;
                if (int.TryParse(idQuery, out id))
                {
                    var identityCard = uwork.IdentityCards.Get(id);
                    txtFirstName.Text = identityCard.FirstName;
                    txtLastName.Text = identityCard.LastName;
                    txtNumber.Text = identityCard.CardNumber;
                    txtOrganization.Text = identityCard.Organization;
                    txtPersonalNumber.Text = identityCard.PersonalNumber;
                    dtBirthDate.Text = identityCard.BirthDate.ToString("yyyy-MM-dd");
                    dtDateOfExpiry.Text = identityCard.DateOfExpiry.ToString("yyyy-MM-dd");
                    dtIssueDate.Text = identityCard.IssueDate.ToString("yyyy-MM-dd");
                    lstBirthPlaces.SelectedValue = identityCard.CityID.ToString();
                    lstCitizenship.SelectedValue = identityCard.CountryID.ToString();
                    lstGenders.SelectedValue = identityCard.GenderID.ToString();
                    hdnID.Value = identityCard.ID.ToString();
                }
                else
                {
                    Response.Redirect("Default.aspx");
                }

            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
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

            using (var uwork = new UnitOfWork(new IECContext()))
            {
                var identitCard = uwork.IdentityCards.Get(int.Parse(hdnID.Value));
                identitCard.BirthDate = birthDate;
                identitCard.CardNumber = txtNumber.Text;
                identitCard.CityID = int.Parse(lstBirthPlaces.SelectedItem.Value);
                identitCard.CountryID = int.Parse(lstCitizenship.SelectedItem.Value);
                identitCard.DateOfExpiry = experationDate;
                identitCard.GenderID = int.Parse(lstGenders.SelectedItem.Value);
                identitCard.IssueDate = issueDate;
                identitCard.Organization = txtOrganization.Text;
                identitCard.PersonalNumber = txtPersonalNumber.Text;
                identitCard.LastName = txtLastName.Text;
                identitCard.FirstName = txtFirstName.Text;

                if (!_validator.IsValidID(identitCard))
                {
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "მონაცემები არასწორადაა შეყვანილი.";
                    return;
                }
                else
                {
                    uwork.Save();
                    Response.Redirect("Default.aspx");
                }
            }

        }
    }
}