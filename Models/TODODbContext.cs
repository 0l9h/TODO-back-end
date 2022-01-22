using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace WebAPI.Models
{
    public class TODODbContext: DbContext
    {
        public TODODbContext(DbContextOptions<TODODbContext> options): base(options) {}

        public DbSet<MyTask> Tasks { get; set; }
    }
}
