using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneHazard.API.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}