﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection.Models
{
    public class Course
    {
        [Key]
        [Required]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
    }
}
