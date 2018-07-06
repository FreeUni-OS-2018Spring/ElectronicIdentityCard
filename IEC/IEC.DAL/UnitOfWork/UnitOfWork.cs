using IEC.DAL.Context;
using IEC.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEC.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IECContext _context;

        public IECContext Context
        {
            get { return _context; }
        }

        public UnitOfWork(IECContext context)
        {
            _context = (IECContext)context;
            Cities = new CityRepository(_context);
            Countries = new CountryRepository(_context);
            Genders = new GenderRepository(_context);
            IdentityCards = new IdentityCardRepository(_context);

        }

        public ICityRepository Cities { get; private set; }
        public ICountryRepository Countries { get; private set; }
        public IGenderRepository Genders { get; private set; }
        public IIdentityCardRepository IdentityCards { get; private set; }

        public void Dispose()
        {
            if (_context != null)
                _context.Dispose();

            Cities.Dispose();
            Countries.Dispose();
            Genders.Dispose();
            IdentityCards.Dispose();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
