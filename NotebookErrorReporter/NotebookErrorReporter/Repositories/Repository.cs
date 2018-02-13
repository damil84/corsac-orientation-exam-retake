using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotebookErrorReporter.Entities;

namespace NotebookErrorReporter.Repositories
{
    public class Repository
    {
        public Context Context { get; set; }
        public Repository(Context context)
        {
            Context = context;
        }

    }
}
