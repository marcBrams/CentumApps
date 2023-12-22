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
    public class PL2_300
    {
        [Key]
        public int PL2_300_ID { get; set; }
        [ForeignKey("GP2")]
        public int GP2_ID { get; set; }
        public GP2 GP2 { get; set; }
        public int NaphthaFeed { get; set; }
        public int ProductReformate { get; set; }
        public int ProductLPG { get; set; }
        public int GasV4V5V12 { get; set; }
        public int GasKeH2Plant { get; set; }
        public int GasKeHCU { get; set; }
        public int RecycleGas { get; set; }
        public int TempInletV1V2V3 { get; set; }
        public int TempOutletV1V2V3 { get; set; }
        public int H2HC { get; set; }
        public int PressV4V5 { get; set; }
        public int InjeksiPERC { get; set; }
        public int Steam_BFW_SteamProduct { get; set; }
        public int Steam_TempPressHPS { get; set; }
        public int Analisa_RVP_LN { get; set; }
        public int Analisa_OnRef { get; set; }
    }
}
