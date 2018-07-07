using IEC.DAL.Context;
using IEC.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IEC.Web
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }

        private void BindData()
        {
            using (var uwork = new UnitOfWork(new IECContext()))
            {
                dgvCards.DataSource = uwork.IdentityCards.GetAll().ToList();
                dgvCards.DataBind();

                var birthPlaces = uwork.Cities.GetAll().ToList().Select(c => new ListItem(c.Name, c.ID.ToString())).ToList();
                birthPlaces.Insert(0, new ListItem("ყველა", "0"));
                lstBirthPlace.DataSource = birthPlaces;
                lstBirthPlace.DataTextField = "text";
                lstBirthPlace.DataValueField = "value";
                lstBirthPlace.DataBind();
            }

        }


        protected void btnSearch_Click(object sender, EventArgs e)
        {
            using (var uwork = new UnitOfWork(new IECContext()))
            {
                var ids = uwork.IdentityCards.GetAll();
                if (!string.IsNullOrEmpty(txtName.Text))
                    ids = ids.Where(id => (id.FirstName + " " + id.LastName).Contains(txtName.Text));

                if (!string.IsNullOrEmpty(txtPersonalNumber.Text))
                    ids = ids.Where(id => id.PersonalNumber == txtPersonalNumber.Text);

                if (!string.IsNullOrEmpty(dtBirthDateFrom.Text))
                {
                    var birthDateFrom = DateTime.Parse(dtBirthDateFrom.Text).Date;
                    ids = ids.Where(id => id.BirthDate >= birthDateFrom);
                }

                if (!string.IsNullOrEmpty(dtBirthDatTo.Text))
                {
                    var birthDateTo = DateTime.Parse(dtBirthDatTo.Text).Date;
                    ids = ids.Where(id => id.BirthDate <= birthDateTo);
                }

                if (!string.IsNullOrEmpty(dtDateOfExpiryFrom.Text))
                {
                    var dateOfExpiry = DateTime.Parse(dtDateOfExpiryFrom.Text).Date;
                    ids = ids.Where(id => id.BirthDate >= dateOfExpiry);
                }

                if (!string.IsNullOrEmpty(dtDateOfExpiryTo.Text))
                {
                    var dateOfExpiry = DateTime.Parse(dtDateOfExpiryTo.Text).Date;
                    ids = ids.Where(id => id.BirthDate <= dateOfExpiry);
                }

                var selectedCity = int.Parse(lstBirthPlace.SelectedValue);
                if (selectedCity != 0)
                {
                    ids = ids.Where(id => id.CityID == selectedCity);
                }

                dgvCards.DataSource = ids.ToList();
                dgvCards.DataBind();
            }
        }

        protected void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtPersonalNumber.Text = string.Empty;
            dtBirthDateFrom.Text = string.Empty;
            dtBirthDatTo.Text = string.Empty;
            dtDateOfExpiryFrom.Text = string.Empty;
            dtDateOfExpiryTo.Text = string.Empty;
            BindData();
        }

        protected void dgvCards_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "deleteRecord")
            {
                int recordID = int.Parse(e.CommandArgument.ToString());
                using (var uwork = new UnitOfWork(new IECContext()))
                {
                    uwork.IdentityCards.Remove(recordID);
                    uwork.Save();
                    BindData();
                }
            }
            else if (e.CommandName == "editRecord")
            {
                int recordID = int.Parse(e.CommandArgument.ToString());
                Response.Redirect("edit.aspx?id=" + recordID);
            }
        }
    }
}