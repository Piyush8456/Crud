using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeesCrudOp.Models
{
    public class Pager
    {
        public int totalItems { get; set; }

        public int currentPage { get; set; }

        public int pageSie { get; set; }

        public int totalPages { get; set; }

        public int startPage { get; set; }

        public int EndPage { get; set; }

        public Pager()
        {

        }

        public Pager(int totalItems, int page, int pageSize = 10)
        {

        }

    }
}