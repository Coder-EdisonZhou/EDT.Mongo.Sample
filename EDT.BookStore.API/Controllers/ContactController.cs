using AutoMapper;
using EDT.BookStore.API.Models;
using EDT.BookStore.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EDT.BookStore.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IContactService _contactService;

        public ContactController(IMapper mapper, IContactService contactService)
        {
            _mapper = mapper;
            _contactService = contactService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IList<ContactViewModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(IList<ContactViewModel>), StatusCodes.Status204NoContent)]
        public async Task<ActionResult<IList<ContactViewModel>>> Get()
        {
            var contacts = await _contactService.GetAsync();
            if (contacts == null)
            {
                return NoContent();
            }

            return Ok(_mapper.Map<IList<ContactViewModel>>(contacts));
        }
    }
}
