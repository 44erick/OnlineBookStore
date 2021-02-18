using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    //inherits from DbContext file
    public class OnlineBookStoreDBContext : DbContext
    {
        //constructor to inherit base options
        public OnlineBookStoreDBContext(DbContextOptions<OnlineBookStoreDBContext> options) : base(options)
        {

        }
        //return dbcontext
        public DbSet<Project> Projects { get; set; }
    }
}