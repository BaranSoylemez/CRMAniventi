using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [StringLength(20)]
        public string UserName { get; set; }

        [StringLength(20)]
        public string UserSurname { get; set; }

        [StringLength(20)]
        public string UserTitle { get; set; }

        [StringLength(20)]
        public string Usermail { get; set; }

        public ICollection<Project> Projects { get; set; }
        


    }
}
