using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace labQuiz_TARATHEP_ORA03_NETCore.Models
{
    public partial class Employees
    {
        [Required]
        public int empNo { get; set; }
        [Required]
        public string titleName { get; set; }
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required]
        public string gender { get; set; }
        [Required]
        public string department { get; set; }
        [Required]
        public decimal? salary { get; set; }
    }
}
