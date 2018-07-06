using IEC.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEC.DAL.Context
{
    public class IECContext : DbContext, IIECContext
    {
        public IECContext() : base("name=IECConnection")
        {
        }

        public IDbSet<City> Cities { get; set; }
        public IDbSet<Country> Countries { get; set; }
        public IDbSet<Gender> Genders { get; set; }
        public IDbSet<IdentityCard> IdentityCards { get; set; }
    }
}
