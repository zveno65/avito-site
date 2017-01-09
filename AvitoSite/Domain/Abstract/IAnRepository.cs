using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstract
{
    public interface IAnRepository
    {
        IEnumerable<An> Announcments { get;}
        void DeleteAnnouncment(An announcement);
        void SaveAnnouncment(An announcement);
    }
}
