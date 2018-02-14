using Microsoft.AspNetCore.Mvc;
using NotebookErrorReporter.Repositories;
using NotebookErrorReporter.ViewModels;

namespace NotebookErrorReporter.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        static NamesTicketsVM newError = new NamesTicketsVM();
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
            NamesTicketsVM.UserList = Repository.GetUserList();
            NamesTicketsVM.TicketList = Repository.GetTicketList();

            return View(NamesTicketsVM);
        }

        [HttpPost("report")]
        public IActionResult Report(Moduls.Ticket ticket)
        {
            Repository.Report(ticket);
            return RedirectToAction("index");
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