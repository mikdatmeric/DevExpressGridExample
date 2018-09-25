using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpressGridExample.Entities.Model
{
    public class StokVeri
    {
        public int SiraNo { get; set; }
        public string IslemTuru { get; set; }
        public string EvrakNo { get; set; }
        public string Tarih { get; set; }
        public decimal GirisMiktar { get; set; }
        public decimal CikisMiktar { get; set; }
        public decimal StokMiktar { get; set; }

    }
}
