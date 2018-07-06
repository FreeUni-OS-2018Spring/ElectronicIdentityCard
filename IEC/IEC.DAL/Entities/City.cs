﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEC.DAL.Entities
{
    public class City : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<IdentityCard> IdentityCards { get; set; }
    }
}
