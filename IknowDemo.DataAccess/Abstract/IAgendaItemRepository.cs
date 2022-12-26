using IknowDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IknowDemo.DataAccess.Abstract
{
    public interface IAgendaItemRepository
    {
        List<AgendaItem> GetAllAgendaItems();

        AgendaItem GetAgendaItemById(int id);
        AgendaItem CreateAgendaItem(AgendaItem agendaItem);
        AgendaItem UpdateAgendaItem(AgendaItem agendaItem);
        void DeleteAgendaItem(int id);
    }
}
