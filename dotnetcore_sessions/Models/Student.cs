﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetcore_sessions.Models
{
    public class Student
    {
     
        public int Id { get; set; }
     
        public string? Name { get; set; }
        public string? City { get; set; }
    }
}
