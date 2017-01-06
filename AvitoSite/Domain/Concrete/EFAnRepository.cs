using Domain.Abstract;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class EFAnRepository: IAnRepository
    {
        EFDbContext context = new EFDbContext();
        public IEnumerable<An> Announcments
        {
            get { return context.Announcments; }
        }

        public void DeleteAnnouncment(An annoncment)
        {
            An dbEntry = context.Announcments.Find(annoncment.ID);
            if (dbEntry != null)
            {
                context.Announcments.Remove(dbEntry);
            }

            context.SaveChanges();
        }

        public void SaveAnnouncment(An annoncment)
        {
            if (annoncment.ID == Guid.Empty || annoncment.ID == null)
            {
                An a = new An();
                a.ID = Guid.NewGuid();
                a.CategoryID = annoncment.CategoryID;
                Guid idd = new Guid("9B857D89-1D72-483F-8844-3C198B837C02");
                a.AccountID = idd;
                a.DateStart = annoncment.DateStart;
                a.DateFinish = annoncment.DateFinish;
                a.Name = annoncment.Name;
                a.Price = annoncment.Price;
                a.Description = annoncment.Description;
                context.Announcments.Add(a);
            }
            else
            {
                An dbEntry = context.Announcments.Find(annoncment.ID);
                if (dbEntry != null)
                {
                    dbEntry.Name = annoncment.Name;
                    dbEntry.Price = annoncment.Price;
                    dbEntry.Description = annoncment.Description;
                }
            }
            context.SaveChanges();
        }
    }
}
