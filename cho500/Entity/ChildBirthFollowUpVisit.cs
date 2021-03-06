﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace cho500.Entity
{
    public class ChildBirthFollowUpVisit
    {
        [Key]
        public int Id { get; set; }
        public int AgeInWeeks { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateOfFollowup { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
  
        public string Diagnosis { get; set; }
        public string Notes { get; set; }
    
        public int PhysicianID { get; set; } 
        public virtual Physician Physician{ get; set; }
        public int PersonID { get; set; }
        public virtual ChildHealthRecord ChildHealthRecord { get; set; }
    }
}