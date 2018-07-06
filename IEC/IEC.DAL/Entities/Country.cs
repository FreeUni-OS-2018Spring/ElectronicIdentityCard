using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEC.DAL.Entities
{
    public class Country : BaseEntity
    {
        public string Name { get; set; }
        public string ShortName { get; set; }

        public virtual ICollection<IdentityCard> IdentityCards { get; set; }

    }
}
