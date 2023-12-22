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
    public class CCR_310
    {
        [Key]
        public int CCR_310_ID { get; set; }
        [ForeignKey("GP2")]
        public int GP2_ID { get; set; }
        public GP2 GP2 { get; set; }
        public int FlowControlHopper { get; set; }
        public int UpperLowerAir { get; set; }
        public int InjeksiPERC { get; set; }
        public int Analisa_CarbonContent { get; set; }
        public int Analisa_CIContent { get; set; }
        
    }
}
