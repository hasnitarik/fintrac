using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace fintrac.Models
{
    public class Advisor
    {
        [Key]
        public string advisorId{get;set;}
        public string FirstName{get;set;}
        public string LastName{get;set;}
        public string Phone{get;set;}
        public string Email{get;set;}
        public string City{get;set;}
        public string BranchLocation{get;set;}
        public string PostalCode{get;set;}
        public string Password{get;set;}
        public string BankName{get;set;}
    }
}