using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CandidateInformation.Models
{
    public class Qualifications
    {
        public int ID { get; set; }
        [Display(Name = "Type of Qaulification")]
        public string qualificationType { get; set; }
        [Display(Name = "Name of Qaulification")]
        public string qualificationName { get; set; }
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime startDate { get; set; }
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime endDate { get; set; }
    }
}