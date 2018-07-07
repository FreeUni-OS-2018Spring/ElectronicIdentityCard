using IEC.DAL.Context;
using IEC.DAL.Entities;
using IEC.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEC.BLL.Validators
{
    public class IDentityCardsValidator
    {
        public bool IsValidID(IdentityCard identityCard)
        {
            if (string.IsNullOrEmpty(identityCard.CardNumber))
                return false;

            if (string.IsNullOrEmpty(identityCard.FirstName))
                return false;

            if (string.IsNullOrEmpty(identityCard.LastName))
                return false;

            if (string.IsNullOrEmpty(identityCard.Organization))
                return false;

            if (string.IsNullOrEmpty(identityCard.PersonalNumber))
                return false;

            if (identityCard.BirthDate == DateTime.MinValue)
                return false;

            if (identityCard.CityID == 0)
                return false;

            if (identityCard.CountryID == 0)
                return false;

            if (identityCard.GenderID == 0)
                return false;

            if (identityCard.DateOfExpiry == DateTime.MinValue)
                return false;

            if (identityCard.IssueDate == DateTime.MinValue)
                return false;

            if (identityCard.BirthDate > DateTime.Now || identityCard.IssueDate > DateTime.Now)
                return false;

            using (var uwork = new UnitOfWork(new IECContext()))
            {
                var dbID = uwork.IdentityCards.Get(i => i.PersonalNumber == identityCard.PersonalNumber);
                if (dbID != null && dbID.ID != identityCard.ID)
                    return false;
            }

            return true;
        }
    }
}
