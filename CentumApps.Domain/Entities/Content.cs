using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentumApps.Domain.Entities
{
    public class Content
    {
        public int ContentId {  get; set; }
        public string ContentTitle { get; set; }
        public string ContentCategory { get; set; }
        //public string? ContentDescription { get; set; }
        //public IFormFile? Image { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? CreatedBy {  get; set; }
        public bool IsActive {  get; set; }


    }
}
