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
    public class NHDT_200
    {
        [Key]
        public int NHDT_200_ID { get; set; }
        [ForeignKey("GP2")]
        public int GP2_ID { get; set; }
        public GP2 GP2 { get; set; }
        public int TotalFeedNaphtha { get; set; }
        public int ProductTRNaphtha { get; set; }
        public int ProductLNaphtha { get; set; }
        public int GasV6 { get; set; }
        public int MakeUpGas { get; set; }
        public int QuenchingGas { get; set; }
        public int H2HC { get; set; }
        public int TempInOut_V1 { get; set; }
        public int TempInOut_V101 { get; set; }
        public int TK05 { get; set; }
        public int Rec_PressV5 { get; set; }
        public int ExCDU { get; set; }
        public int ExDCU_TK05 { get; set; }
        public int keTK { get; set; }
        public int Ke300_TK06 { get; set; }
        public int Ex211_212 { get; set; }
    }
}
