using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [StringLength(50)]
        public string CustomerName { get; set; }

        [StringLength(100)]
        public string CustomerAddress { get; set; }

        [StringLength(20)]
        public string CustomerContact { get; set; }

        [StringLength(20)]
        public string CustomerTaxNo { get; set; }
        public ICollection<Project> Projects { get; set; }

    }
}
