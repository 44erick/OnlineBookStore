using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public interface IBookRepository
    {
        //making iqueryable to pass project object
        IQueryable<Project> Projects { get; }
    }
}