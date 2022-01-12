using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudApp.Models
{
    public class Customers : BaseEntity
    {
        
        public string ContactTitle { get; set; }

        public string ContactPhone { get; set; }
    }
}
