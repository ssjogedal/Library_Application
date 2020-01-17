using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Member
    {   
        [Key]
        public int MemberId { get; set; }
        [Required]
        public int PersonalId { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Loan> Loans { get; set; }

        public int Fine { get; set; }

        public Member() { }

        public Member(int _personalId, string _name)
        {
            Loans = new List<Loan>();

            this.PersonalId = _personalId;
            this.Name = _name;
            this.Loans = Loans;
        }

        public override string ToString()
        {
            return Name;
        }
    }

}
