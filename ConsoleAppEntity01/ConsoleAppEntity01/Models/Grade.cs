﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntity01.Models
{
    public class Grade
    {

        public int Id { get; set; }
        public string? GradeName { get; set; }
        public string? Section { get; set; }

        public IList<Student?> Students { get; set; }
    }
    
}
