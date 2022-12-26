using IknowDemo.Business.Abstract;
using IknowDemo.DataAccess.Abstract;
using IknowDemo.DataAccess.Concrete;
using IknowDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IknowDemo.Business.Concrete
{
    public class AgendaItemManager : IAgendaItemService
    {
        private IAgendaItemRepository _agendaItemRepository;

        public AgendaItemManager(IAgendaItemRepository agendaItemRepository)
        {
            _agendaItemRepository = agendaItemRepository;
        }
        public AgendaItem CreateAgendaItem(AgendaItem agendaItem)
        {
            return _agendaItemRepository.CreateAgendaItem(agendaItem);
        }

        public void DeleteAgendaItem(int id)
        {
            _agendaItemRepository.DeleteAgendaItem(id);
        }

        public AgendaItem GetAgendaItemById(int id)
        {
            if (id > 0)
            {
                return _agendaItemRepository.GetAgendaItemById(id);
            }
            throw new Exception("Id can not be less than 1");
        }

        public List<AgendaItem> GetAllAgendaItems()
        {
            return _agendaItemRepository.GetAllAgendaItems();
        }

        public AgendaItem UpdateAgendaItem(AgendaItem agendaItem)
        {
            return _agendaItemRepository.UpdateAgendaItem(agendaItem);
        }
    }
}
