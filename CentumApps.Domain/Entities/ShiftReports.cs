using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CentumApps.Domain.Entities
{
    public class ShiftReports
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReportId { get; set; } 
        public string ReportDate { get; set; }
        public string Status { get; set; } 
        public string Team { get; set; }
        public string Area { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public bool IsSubmitted { get; set; }

    }
}
