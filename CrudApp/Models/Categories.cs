﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudApp.Models
{
    public class Categories : BaseEntity
    {
        
        public string Description { get; set; }

        [Display(Name = "OluşturulmaTarihi")]
        [DataType("DateTime")]
        public override DateTime CreDate { get => base.CreDate; set => base.CreDate = value; }
        // override ile base'den gelen abstract veya virtual üyeyi
        // ezebiliyoruz. 


    }
}
