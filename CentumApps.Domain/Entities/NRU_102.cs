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
    public class NRU_102
    {
        [Key]
        public int NRU_102_ID { get; set; }
        [ForeignKey("GP1")]
        public int GP1_ID { get; set; }
        public GP1 GP1 { get; set; }
        public int Target { get; set; }
        public int SR_Naphtha { get; set; }
        public int L_Naphtha { get; set; }
        public int H_Naphtha { get; set; }
        public int Cot_NR_H1 { get; set; }
        public int Ex_211_212 { get; set; }
        public int SRN_Ex_CDU { get; set; }     
    }
}
