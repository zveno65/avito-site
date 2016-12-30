using Domain.Abstract;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class EFAnRepository : IAnRepository
    {
        EFDbContext context = new EFDbContext();
        public IEnumerable<An> announcment
        {
            get { return context.Announcments; }
        }
    }
}
