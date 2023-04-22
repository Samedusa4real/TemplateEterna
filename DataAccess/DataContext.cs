using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TemplateTask.Models;

namespace TemplateTask.DataAccess
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }

        public DbSet<ServiceFeatures> Service { get; set; }

        public DbSet<HomeFeatures> HomeFeatures { get; set; }
    }
}
