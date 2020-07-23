﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControlTienda.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Category
    {
        public int Id { get; set; }

        [MaxLength (35)]
        public string Name { get; set; }
        [MaxLength (250)]
        public string Description { get; set; }
    }
}
