using NotebookErrorReporter.Moduls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotebookErrorReporter.ViewModels
{
    public class NamesTicketsVM
    {
        public List<User> NameList { get; set; }
        public List<Ticket> TicketList { get; set; }
    }
}