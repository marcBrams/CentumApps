using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;

namespace CentumApps.Domain.Entities
{
    public class CDU_100
    {
        [Key]
        public int CDU_100_ID { get; set; }
        [DisplayName("Shift Supervisor")]
        public string ShiftSupervisor { get; set; }
        public DateTime? ReportDate { get; set; }
        public string Team {  get; set; }
        [DisplayName("Jam")]
        public string ShiftTime {  get; set; }
        public int? DesignKapasitas { get; set; }
        public int? Target {  get; set; }
        public int? Crude {  get; set; }
        public int? SRN { get; set; }
        public int? Kerosene { get; set; }
        public int? LGO {  get; set; }
        public int? HGO {  get; set; }
        [DisplayName("Residue To Tank")]
        public int? ResidueToTank {  get; set; }
        [DisplayName("Residue To HVU")]
        public int? ResidueToHVU { get; set; }
        [DisplayName("Residue Total")]
        public int? ResidueTotal { get; set; }
        [DisplayName("Cot 100 H1")]
        public int? Cot100_H1 { get; set; }
        [DisplayName("Cot 100 H2")]
        public int? Cot100_H2 { get; set; }
        [DisplayName("Press F.Zone")]
        public int? PressFZone {  get; set; }
        [DisplayName("Press Top T-1")]
        public int? PressTopT1 { get; set; }
        [DisplayName("Press 100 D-1")]
        public int? Press_100D1 {  get; set; }
        [DisplayName("Temp.Bot")]
        public int? TempBot { get; set; }
        [DisplayName("Top T-1")]
        public int? TempTopT1 { get; set; }
        [DisplayName("Flow Steam T-1")]
        public int? FlowSteam { get; set; }
        [DisplayName("Temp.Outlet 100 E7")]
        public int? TempOutlet { get; set; }
        [DisplayName("Press Pass H-1")]
        public int? PressPassH1 {  get; set; }
        [DisplayName("Press 100 E-7")]
        public int? PressPassE7 { get; set; }
        [DisplayName("Press S.W")]
        public int? Util_PressSW {  get; set; }
        [DisplayName("Flow S.W")]
        public int? Util_FlowSW { get; set; }
        [DisplayName("Press Steam")]
        public int? Util_PressSteam { get; set; }
        [DisplayName("Flow Steam")]
        public int? Util_FlowSteam {  get; set; }
        [DisplayName("Press C.W")]
        public int? Util_PressCW { get; set; }
        [DisplayName("Press Instrument Air")]
        public int? Util_PressInstrumenAir { get; set; }
        [DisplayName("Fuel Gas")]
        public int? Fuel_Gas { get; set; }
        [DisplayName("Fuel Oil")]
        public int? Fuel_Oil {  get; set; }
        [DisplayName("BFO 100 H1")]
        public int? Fuel_BFO_100H1 { get; set; }
        [DisplayName("BFG 100 H1")]
        public int? Fuel_BFG_100H1 { get; set; }
        [DisplayName("BPG 100 H1")]
        public int? Fuel_BPG_100H1 { get; set; }
        [DisplayName("BFO 100 H2")]
        public int? Fuel_BFO_100H2 { get; set; }
        [DisplayName("BFG 100 H2")]
        public int? Fuel_BFG_100H2 { get; set; }
        [DisplayName("BPG 100 H2")]
        public int? Fuel_BPG_100H2 { get; set; }
        [DisplayName("Clean BFO H1")]
        public int? Fuel_Clean_BFO_H1 { get; set; }
        [DisplayName("Clean BFG H1")]
        public int? Fuel_Clean_BFG_H1 { get; set; }
        [DisplayName("Clean BPG H1")]
        public int? Fuel_Clean_BPG_H1 { get; set; }
        [DisplayName("Amp. 100 P6 A/B")]
        public int? Fuel_Amp_100_P6 { get; set; }
        [DisplayName("Amp. 100 P9")]
        public int? Fuel_Amp_100_P9 { get; set; }
        [DisplayName("Colour LGO")]
        public int? Analisa_LGO { get; set; }
        [DisplayName("Colour HGO")]
        public int? Analisa_HGO { get; set; }
        [DisplayName("Rec. HGO")]
        public int? Analisa_Rec_HGO { get; set; }
        [DisplayName("F.P Kero")]
        public int? Analisa_FP_Kero { get; set; }
        [DisplayName("E.P Kero")]
        public int? Analisa_EP_Kero { get; set; }
        [DisplayName("PH Water Boot 100 D-1")]
        public int? Analisa_PHWater_Boot { get; set; }
        [DisplayName("EP SRN")]
        public int? Analisa_EP_SRN { get; set; }
        public string? KondisiKritis { get; set; }
        public string? KondisiOperasi { get; set; }
        public string? Pemeliharaan { get; set; }
        public int? Notes_Manpower { get; set; }
        public int? Notes_HT { get; set; }
        public int? Notes_Charger { get; set; }
        public int? Notes_Battery { get; set; }
        public int? Notes_GasTester { get; set; }
        public int? Notes_Sepeda {  get; set; }
        public int? Notes_MobilShift { get; set; }
        public string? Notes_MobilShiftCondition { get; set; }
        public int? Notes_Stopwatch { get; set; }
        public int? Notes_Calculator { get; set; }
        public int? Notes_AirGalonPenuh { get; set; }
        public int? Notes_AirGalonKosong { get; set; }
        public string? Notes_Lembur { get; set; }
        public int? Notes_HPBOC { get; set; }
        public int? Notes_Tensimeter { get; set; }
        public int? Notes_Oxymeter {  get; set; }
        public int? Notes_Dymo { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedAt {  get; set; }
        public string? UpdatedBy { get; set; }
        public bool? IsSubmitted { get; set; }


    }
}
