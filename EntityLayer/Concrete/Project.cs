using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Project
    {
        [Key]
        public int ProjectID { get; set; }

        [StringLength(100)]
        public string ProjectName { get; set; }

        [StringLength(200)]
        public string ProjectDesc { get; set; }
        public decimal ProjectCost { get; set; }       

        [StringLength(10)]
        public string ProjectCurrency { get; set; }
        public bool ProjectStatus { get; set; }
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
        public int QuoteID { get; set; }
        public virtual Quote Quote { get; set; }
        public int CommentID { get; set; }
        public virtual Comment Comment { get; set; }
        //public ICollection<Quote> Quotes { get; set; }
        //public ICollection<Comment> Comments { get; set; }

    }
}
