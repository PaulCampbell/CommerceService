using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpArch.Domain.DomainModel;

namespace DW.Commerce.Rest.Domain
{
    public class Category : Entity
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual IList<Product> Products { get; set; }
    }
}
