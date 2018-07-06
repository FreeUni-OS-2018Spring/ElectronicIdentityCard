using IEC.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace IEC.DAL.Repository
{
    public class CountryRepository : Repository<Country>, ICountryRepository
    {
        public CountryRepository(DbContext context) : base(context)
        {
        }
    }
}
