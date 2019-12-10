using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA_API.Data.DTOs
{
    public class PhotosForDetailDTO
    {
        public int Id { get; set; }
        public string PhotoUrl { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }
    }
}
