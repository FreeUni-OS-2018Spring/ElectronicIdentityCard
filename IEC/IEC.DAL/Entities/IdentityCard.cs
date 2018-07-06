using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEC.DAL.Entities
{
    public class IdentityCard : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual Country Country { get; set; }
        public virtual Gender Gender { get; set; }
        public string PersonalNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DateOfExpiry { get; set; }
        public virtual City City { get; set; }
        public string CardNumber { get; set; }
        public string Organization { get; set; }

        public int CountryID { get; set; }
        public int GenderID { get; set; }
        public int CityID{ get; set; }
    }
}
