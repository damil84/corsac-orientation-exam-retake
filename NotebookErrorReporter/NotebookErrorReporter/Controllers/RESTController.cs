using Microsoft.AspNetCore.Mvc;
using NotebookErrorReporter.Repositories;

namespace NotebookErrorReporter.Controllers
{
    public class RESTController : Controller
    {
        private Repository Repository;

        public RESTController(Repository Repository)
        {
            this.Repository = Repository;
        }

        [HttpGet("list/query")]
        public IActionResult ReportQuery([FromRoute]string query)
        {
            return Json(new { result = "ok", data = Repository.Filter(query) });
        }
    }
}