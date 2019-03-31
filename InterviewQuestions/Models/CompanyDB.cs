using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace InterviewQuestions.Models
{
    [Table("Company")]
    public class CompanyDB : DbContext
    {
        public DbSet<Company> companies { get; set; }
        public DbSet<Questions> questions { get; set; }

    }
}