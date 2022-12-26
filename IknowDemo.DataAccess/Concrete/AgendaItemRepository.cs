using IknowDemo.DataAccess.Abstract;
using IknowDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IknowDemo.DataAccess.Concrete
{
    public class AgendaItemRepository : IAgendaItemRepository
    {
        public AgendaItem CreateAgendaItem(AgendaItem agendaItem)
        {
            using (var agendaItemDbContext = new AgendaDbContext())
            {
                agendaItemDbContext.AgendaItems.Add(agendaItem);
                agendaItemDbContext.SaveChanges();
                return agendaItem;
            }
        }

        public void DeleteAgendaItem(int id)
        {
            using (var agendaItemDbContext = new AgendaDbContext())
            {
                var deletedAgendaItem = GetAgendaItemById(id);
                agendaItemDbContext.AgendaItems.Remove(deletedAgendaItem);
                agendaItemDbContext.SaveChanges();
            }
        }

        public AgendaItem GetAgendaItemById(int id)
        {
            using (var agendaItemDbContext = new AgendaDbContext())
            {
                return agendaItemDbContext.AgendaItems.Find(id);
            }
        }

        public List<AgendaItem> GetAllAgendaItems()
        {
            using(var agendaItemDbContext = new AgendaDbContext())
            {
                return agendaItemDbContext.AgendaItems.ToList();
            }
        }

        public AgendaItem UpdateAgendaItem(AgendaItem agendaItem)
        {
            using (var agendaItemDbContext = new AgendaDbContext())
            {
                agendaItemDbContext.AgendaItems.Update(agendaItem);
                agendaItemDbContext.SaveChanges();
                return agendaItem;
            }
        }
    }
}
