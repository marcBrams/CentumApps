using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace CentumApps.Domain.Entities
{
    public class Content
    {
        public int ContentId {  get; set; }
        [Display(Name = "Judul Konten")]
        public string ContentTitle { get; set; }
        [Display(Name = "Kategori")]
        public string ContentCategory { get; set; }
        [Display(Name = "Deskripsi")]
        public string? ContentDescription { get; set; }
        [NotMapped]
        public IFormFile? Image { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? CreatedBy {  get; set; }
        [Display(Name = "Status")]
        public bool IsActive {  get; set; }


    }
}
