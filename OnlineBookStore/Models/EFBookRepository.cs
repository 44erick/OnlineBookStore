using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public class EFBookRepository : IBookRepository
    {
        //private
        private OnlineBookStoreDBContext _context;

        //constructor
        public EFBookRepository(OnlineBookStoreDBContext context)
        {
            _context = context;
        }
        public IQueryable<Project> Projects => _context.Projects;
    }
} 