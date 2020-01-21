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
    public class ProductController : Controller
    {
        private readonly IRepositoryProduct _productRepository;

        public ProductController(IRepositoryProduct productRepository)
        {
            _productRepository = productRepository;
            
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_productRepository.FindAll());
            }catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Product produto)
        {

            try
            {
                _productRepository.Add(produto);

                return Created("api/product", produto);
            }catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
