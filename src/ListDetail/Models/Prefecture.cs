using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListDetail.Models
{
    public class Prefecture
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static void Initialize(DbContext context)
        {
            var t = context.Set<Prefecture>();
            if (!t.Any())
            {
                t.AddRange(
                    new Prefecture() { Name = "北海道" }
                );
                context.SaveChanges();
            }
        }
    }
}
