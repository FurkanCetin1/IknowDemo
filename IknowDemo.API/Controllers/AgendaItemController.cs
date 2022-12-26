using Azure.Identity;
using IknowDemo.Business.Abstract;
using IknowDemo.Business.Concrete;
using IknowDemo.Entities;
using Microsoft.AspNetCore.Mvc;

namespace IknowDemo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendaItemController : ControllerBase
    {
        private IAgendaItemService _agendaItemService;
        public AgendaItemController(IAgendaItemService agendaItemService)
        {
            _agendaItemService = agendaItemService;
        }

        [HttpGet]
        public List<AgendaItem> Get()
        {
            return _agendaItemService.GetAllAgendaItems();
        }

        [HttpGet("{id}")]
        public AgendaItem Get(int id)
        {
            return _agendaItemService.GetAgendaItemById(id);
        }

        [HttpPost]
        public AgendaItem Post([FromBody]AgendaItem agendaItem)
        {
            return _agendaItemService.CreateAgendaItem(agendaItem);
        }

        [HttpPut]
        public AgendaItem Put([FromBody] AgendaItem agendaItem)
        {
            return _agendaItemService.UpdateAgendaItem(agendaItem);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _agendaItemService.DeleteAgendaItem(id);
        }

        
    }
}
