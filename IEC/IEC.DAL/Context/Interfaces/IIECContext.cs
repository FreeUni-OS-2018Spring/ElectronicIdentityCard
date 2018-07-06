using IEC.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEC.DAL.Context
{
    public interface IIECContext : IDisposable
    {
        IDbSet<City> Cities { get; set; }
        IDbSet<Country> Countries { get; set; }
        IDbSet<Gender> Genders { get; set; }
        IDbSet<IdentityCard> IdentityCards { get; set; }
    }
}
