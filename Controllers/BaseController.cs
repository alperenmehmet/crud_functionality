using CRUDOperation_ASP.NET_Web_Application.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDOperation_ASP.NET_Web_Application.Controllers
{
    public class BaseController : Controller
    {
        public ApplicationDbContext dbContext;

        public BaseController() => dbContext = new ApplicationDbContext();

        protected override void Dispose(bool disposing) => dbContext.Dispose();
    }
}