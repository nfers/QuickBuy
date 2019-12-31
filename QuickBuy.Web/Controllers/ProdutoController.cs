﻿using Microsoft.AspNetCore.Mvc;
using QuickBuy.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
