using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelInformationEL.Entities
{
    public class Personnel
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string TcNo { get; set; }
        public bool Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Education { get; set; }
        public string Job { get; set; }
    }
}
