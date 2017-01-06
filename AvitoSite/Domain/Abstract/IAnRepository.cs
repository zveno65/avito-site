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
        void SaveAnnouncment(An annoncment);
        void DeleteAnnouncment(An annoncment);
    }
}
