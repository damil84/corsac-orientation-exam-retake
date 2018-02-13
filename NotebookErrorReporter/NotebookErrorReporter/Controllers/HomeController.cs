using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotebookErrorReporter.Repositories;
using NotebookErrorReporter.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NotebookErrorReporter.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public Repository Repository { get; set; }
        public NamesTicketsVM NamesTicketsVM { get; set; }

        public HomeController(Repository repository, NamesTicketsVM namesTicketsVM)
        {
            Repository = repository;
            NamesTicketsVM = namesTicketsVM;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View(NamesTicketsVM);
        }

        [HttpGet("list")]
        public IActionResult List()
        {
            NamesTicketsVM.UserList = Repository.GetUserList();
            NamesTicketsVM.TicketList = Repository.GetTicketList();
            return View(NamesTicketsVM);
        }
    }
}
