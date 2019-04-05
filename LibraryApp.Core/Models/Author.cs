using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public class Author : FullAuditedEntity
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }
        [Required]
        [Display(Name = "Display Name")]
        [StringLength(64, ErrorMessage = "Maximum Length is 64")]
        public string DisplayName { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        public DateTime? DeathDate { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
