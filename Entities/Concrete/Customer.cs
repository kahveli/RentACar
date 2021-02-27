using System;
using System.Collections.Generic;
using System.Text;
using Core.Entity;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public int CustomerId { get; set; }
        public string CompanyName { get; set; }
    }
}
