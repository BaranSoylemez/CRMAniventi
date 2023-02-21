using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Quote
    {
        [Key]
        public int QuoteID { get; set; }
        
        public decimal QuoteCost { get; set; }

        [StringLength(10)]
        public string QuoteCurrency { get; set; }        

        [StringLength(10)]
        public string QuoteDate { get; set; }

        [StringLength(50)]
        public string QuotePayment { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}
