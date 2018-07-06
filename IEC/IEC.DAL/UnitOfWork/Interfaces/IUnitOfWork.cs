using IEC.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEC.DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ICityRepository Cities { get; }
        ICountryRepository Countries { get; }
        IGenderRepository Genders { get; }
        IIdentityCardRepository IdentityCards { get; }

        int Save();
    }
}