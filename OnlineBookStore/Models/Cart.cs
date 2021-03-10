using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public void AddItem(Project proj, int qty)
        {
            CartLine line = Lines
                .Where(p => p.Project.BookID == proj.BookID)
                .FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Project = proj,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }


        public void RemoveLine(Project proj) =>
            Lines.RemoveAll(x => x.Project.BookID == proj.BookID);

        public void Clear() => Lines.Clear();

        //might not work check book instead
        public decimal ComputeTotalSum() => (decimal)Lines.Sum(e => e.Project.Price * e.Quantity);
 
        public class CartLine
        {
            public int CartLineID { get; set; }
            public Project Project { get; set; }
            public int Quantity { get; set; }
        }
    }
}
