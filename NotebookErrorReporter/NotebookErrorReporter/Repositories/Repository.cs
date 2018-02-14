using System.Collections.Generic;
using System.Linq;
using NotebookErrorReporter.Entities;
using NotebookErrorReporter.Moduls;

namespace NotebookErrorReporter.Repositories
{
    public class Repository
    {
        public Context Context { get; set; }
        public Repository(Context context)
        {
            Context = context;
        }

        public List<User> GetUserList()
        {
            return Context.Users.ToList();
        }

        public List<Ticket> GetTicketList()
        {
            return Context.Tickets.ToList();
        }

        public object Filter(string query)
        {
            return Context.Tickets.Where(t => t.Manufacturer.Equals(query)).ToList();
        }

        public void Report(Ticket ticket)
        {

            Context.Tickets.Add(ticket);
            Context.SaveChanges();
        }
    }
}