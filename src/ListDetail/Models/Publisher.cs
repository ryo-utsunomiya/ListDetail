using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ListDetail.Models
{
    public class Publisher
    {
        public int Id { get; set; }

        [Display(Name = "出版社名")]
        public string Name { get; set; }

        public virtual ICollection<Book> Book { get; set; }
    }
}
