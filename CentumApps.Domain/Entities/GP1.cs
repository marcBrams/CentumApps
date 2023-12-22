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
    public class GP1
    {
        public int GP1_ID { get; set; } 
        public string ShiftSupervisor { get; set; }
        public string ReportDate { get; set; }
        public string Shift { get; set; }
        public string ShiftTime { get; set; }
        public string KondisiKritis { get; set; }
        public string KondisiOperasi { get; set; }
        public string Pemeliharaan { get; set; }
        public int Manpower { get; set; }
        public int HT_Chager { get; set; }
        public int GasTester { get; set; }
        public int Sepeda { get; set; }
        public int MobilShift { get; set; }
        public int Stopwatch { get; set; }
        public int Calculator { get; set; }
        public int AirGalon { get; set; }
        public int Lembur { get; set; }
        public int HPBOC { get; set; }
        public int Oxymeter { get; set; }
        public int Strobo { get; set; }
        public Date CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public Date UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsSubmitted { get; set; }

    }
}
