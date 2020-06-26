using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TextProcessorApplication.Models;

namespace TextProcessorApplication.DataService
{
    sealed class Context : DbContext
    {
        public DbSet<Word> Words { get; set; }

        public Context()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=TextProcessor;Integrated Security=True;");

        }
    }
}
