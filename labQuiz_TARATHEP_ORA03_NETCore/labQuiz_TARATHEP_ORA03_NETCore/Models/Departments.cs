using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace labQuiz_TARATHEP_ORA03_NETCore.Models
{
    public partial class departments
    {
        [Required]
        public string DeptNo { get; set; }
        [Required]
        public string DeptName { get; set; }
    }
}
