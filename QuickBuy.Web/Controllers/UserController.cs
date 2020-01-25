using Microsoft.AspNetCore.Mvc;
using QuickBuy.Domain.Contracts;
using QuickBuy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickBuy.Web.Controllers
{
    [Route("api/[Controller]")]
    public class UserController : Controller
    {
        private readonly IRepositoryUser _userRepository;

        public UserController(IRepositoryUser userRepository)
        {
            _userRepository = userRepository;

        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_userRepository.FindAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]User usuario)
        {

            try
            {
                _userRepository.Add(usuario);

                return Created("api/user", usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
