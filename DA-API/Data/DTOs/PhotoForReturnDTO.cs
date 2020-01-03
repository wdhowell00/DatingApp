using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA_API.Data.DTOs
{
    public class PhotoForReturnDTO
    {
        public int Id { get; set; }
        public string PhotoUrl { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }
        public string PublicId { get; set; }
    }
}
