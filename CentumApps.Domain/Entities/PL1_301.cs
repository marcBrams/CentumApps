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
    public class PL1_301
    {
        [Key]
        public int PL1_301_ID { get; set; }
        [ForeignKey("GP1")]
        public int GP1_ID { get; set; }
        public GP1 GP1 { get; set; }
        public int H_Naphtha { get; set; }
        public int TR_Naphtha { get; set; }
        public int ProductReformate { get; set; }
        public int ProductLPG { get; set; }
        public int InOutTempR1 { get; set; }
        public int H2 { get; set; }
        public int InTempR2R3R4 { get; set; }
        public int OutTempR2R3R4 { get; set; }
        public int RecGasH2HC { get; set; }
        public int InjeksiPERC { get; set; }
        public int DeltaP_E1R1 { get; set; }
        public int Produksi_FuelGasNRU { get; set; }
        public int Produksi_FuelGasHBNPL1 { get; set; }
        public int Produksi_OffGasHBNPL1 { get; set; }
        public int Produksi_Total { get; set; }
        public int Steam_PressTemp { get; set; }
        public int Steam_BFWProduct { get; set; }
        public int Steam_RatePCS1AB { get; set; }
        public int Analisa_IBP_H_NaphthaNRU { get; set; }
        public int Analisa_RVP_LNReformate { get; set; }
        public int Analisa_ON_Reformate { get; set; }
        public int Analisa_C2C5LPG { get; set; }
        public int Analisa_H2_PLD5 { get; set; }
        public int Analisa_H20_PLD5 { get; set; }
        public int Analisa_H2S_PLD5 { get; set; }
        public int Analisa_HCL_PLD5 { get; set; }
        public int Analisa_PHWB_PLD1 { get; set; }
    }
}
