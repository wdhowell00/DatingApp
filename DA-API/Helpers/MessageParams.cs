using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA_API.Helpers
{
    public class MessageParams
    {
        //Pagination
        private const int MaxPageSize = 25;
        public int PageNumber { get; set; } = 1;
        private int pageSize = 10;

        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }

        //Filtering
        public int UserId { get; set; }

        public string MessageContainer { get; set; } = "Unread";
    }
}
