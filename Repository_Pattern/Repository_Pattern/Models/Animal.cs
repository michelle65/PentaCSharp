﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Repository_Pattern.Models
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
