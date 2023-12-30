﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class District
    {
        [Key]
        public int Id { get; set; }
        public int TownId { get; set; }
        public string Description { get; set; }
    }
}
