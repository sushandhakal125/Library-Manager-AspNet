using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Authors.DTO
{
    public class CreateAuthorInput
    {
        public string DisplayName { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime? DeathDate { get; set; }
    }
}
