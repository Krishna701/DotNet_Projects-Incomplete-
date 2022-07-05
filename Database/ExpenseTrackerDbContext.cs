using ExpenseTrackerProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTrackerProject.Database
{
    public class ExpenseTrackerDbContext:DbContext
    {
        public ExpenseTrackerDbContext(DbContextOptions<ExpenseTrackerDbContext> options): base(options)
        {
            
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Expense> Expenses { get; set; }


    }
}
