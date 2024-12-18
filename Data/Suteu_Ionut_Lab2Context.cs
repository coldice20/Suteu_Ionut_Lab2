using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Suteu_Ionut_Lab2.Models;

namespace Suteu_Ionut_Lab2.Data
{
    public class Suteu_Ionut_Lab2Context : DbContext
    {
        public Suteu_Ionut_Lab2Context (DbContextOptions<Suteu_Ionut_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Suteu_Ionut_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Suteu_Ionut_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Suteu_Ionut_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Suteu_Ionut_Lab2.Models.Category> Category { get; set; } = default!;
        public DbSet<Suteu_Ionut_Lab2.Models.Member> Member { get; set; } = default!;
        public DbSet<Suteu_Ionut_Lab2.Models.Borrowing> Borrowing { get; set; } = default!;
    }
}
