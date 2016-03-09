using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace fintrac.Models
{
    public class Offer
    {
        [Key]
        public string OId { get; set; }
        public string bankName { get; set; }
        public string offerTitle { get; set; }
        public string offerName { get; set; }
        public string offerDescription { get; set; }
        public string serviceName { get; set; }
        public string offerPostalCode { get; set; }

        }
}