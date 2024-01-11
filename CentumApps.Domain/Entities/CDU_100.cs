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
    public class CDU_100
    {
        [Key]
        public int CDU_100_ID { get; set; } 
        public string ShiftSupervisor { get; set; }
        public DateTime? ReportDate { get; set; }
        public string Shift {  get; set; }
        public string ShiftTime {  get; set; }
        public int DesignKapasitas { get; set; }
        public int Target {  get; set; }
        public int Crude {  get; set; }
        public int SRN { get; set; }
        public int Kerosene { get; set; }
        public int LGO {  get; set; }
        public int HGO {  get; set; }
        public int ResidueToTank {  get; set; }
        public int ResidueToHVU { get; set; }
        public int ResidueTotal { get; set; }
        public int Cot100_H1H2 { get; set; }
        public int PressFZone {  get; set; }
        public int Press_100D1 {  get; set; }
        public int TempBot { get; set; }
        public int FlowStream { get; set; }
        public int TempOutlet { get; set; }
        public int PressPass {  get; set; }
        public int Util_FlowSW {  get; set; }
        public int Util_FlowStream {  get; set; }
        public int Util_PressCW { get; set; }
        public int Util_PressInstrumenAir { get; set; }
        public int Fuel_Gas { get; set; }
        public int Fuel_Oil {  get; set; }
        public int Fuel_100H_1 { get; set; }
        public int Fuel_100H_2 { get; set; }
        public int Fuel_H1 { get; set; }
        public int Fuel_100P6 { get; set; }
        public int Analisa_ColourHGO { get; set; }
        public int Analisa_RecHGO { get; set; }
        public int Analisa_FPKero {get; set;}
        public int Analisa_PHWaterboot { get; set; }
        public int Analisa_EPSRN { get; set; }
        public string KondisiKritis { get; set; }
        public string KondisiOperasi { get; set; }
        public string Pemeliharaan { get; set; }
        public int Notes_Manpower { get; set; }
        public int Notes_HT_Charger { get; set; }
        public int Notes_GasTester { get; set; }
        public int Notes_Sepeda {  get; set; }
        public int Notes_MobilShift { get; set; }
        public int Notes_Stopwatch { get; set; }
        public int Notes_Calculator { get; set; }
        public int Notes_AirGalon { get; set; }
        public int Notes_Lembur { get; set; }
        public int Notes_HPBOC { get; set; }
        public int Notes_Oxymeter {  get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt {  get; set; }
        public string UpdatedBy { get; set; }
        public bool IsSubmitted { get; set; }


    }
}
