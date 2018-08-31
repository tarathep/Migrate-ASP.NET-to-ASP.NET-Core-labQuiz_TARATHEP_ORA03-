using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace labQuiz_TARATHEP_ORA03_NETCore.Models
{
    public partial class Genders
    {
        
        public int genderId { get; set; }
        
        public string genderName { get; set; }
        
        public string genderDescription { get; set; }
    }
}
