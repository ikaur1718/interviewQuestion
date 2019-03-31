using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterviewQuestions.Models
{
    public class Questions
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answers { get; set; }
        public string Type { get; set; }
        public int CompanyId { get; set; }
        public virtual ICollection<Company> Companies { get; set; }

    }
}