﻿using Aplicacao.API.Controllers.Base;
using Aplicacao.Application.DTOs;
using Aplicacao.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Aplicacao.API.Controllers.v1
{
    /// <summary>
    /// Product
    /// </summary>
    //[Authorize("Bearer")]
    [ApiController]
    [ApiVersion("1")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ProductsController : BaseController<ProductDTO, int>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="appService"></param>
        public ProductsController(IProductAppService appService) : base(appService) { }
    }
}
