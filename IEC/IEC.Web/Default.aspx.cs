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
                BindGrid();
            }
        }

        public class C
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string PersonalNumber { get; set; }
            public string Gender { get; set; }
            public string BirthDate { get; set; }
            public string DateOfExpiry { get; set; }
        }

        private void BindGrid()
        {

            dgvUsers.DataSource = new List<C>()
            {
                new C(){BirthDate = "b", DateOfExpiry = "d", FirstName = "test", Gender="d", LastName = "m", PersonalNumber = "ads", ID = 1},
                new C(){BirthDate = "b", DateOfExpiry = "d", FirstName = "test", Gender="d", LastName = "m", PersonalNumber = "ads", ID = 2},
                new C(){BirthDate = "b", DateOfExpiry = "d", FirstName = "test", Gender="d", LastName = "m", PersonalNumber = "ads", ID = 3},
            };
            dgvUsers.DataBind();
        }

        protected void Insert(object sender, EventArgs e)
        {
           
   
        }

        protected void OnRowEditing(object sender, GridViewEditEventArgs e)
        {
      
        }

        protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e)
        {
          
        }

        protected void OnRowCancelingEdit(object sender, EventArgs e)
        {
        }

        protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            
        }

        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
          
        }

        protected void OnPaging(object sender, GridViewPageEventArgs e)
        {
      
        }
    }
}