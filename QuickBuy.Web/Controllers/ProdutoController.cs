using Microsoft.AspNetCore.Mvc;
using QuickBuy.Domain.Contracts;

namespace QuickBuy.Web.Controllers
{
    [Route("api/[Controller]")]
    public class ProdutoController : Controller
    {
        private readonly IRepositoryProduct _produtoRepositorio;

        public ProdutoController(IRepositoryProduct produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }
    }
}
