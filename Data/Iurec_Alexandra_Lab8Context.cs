using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Iurec_Alexandra_Lab8.Models;

namespace Iurec_Alexandra_Lab8.Data
{
    public class Iurec_Alexandra_Lab8Context : DbContext
    {
        public Iurec_Alexandra_Lab8Context (DbContextOptions<Iurec_Alexandra_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Iurec_Alexandra_Lab8.Models.Book> Book { get; set; }

        public DbSet<Iurec_Alexandra_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Iurec_Alexandra_Lab8.Models.Category> Category { get; set; }
    }
}
