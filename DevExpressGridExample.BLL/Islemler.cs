using DevExpress.XtraGrid;
using DevExpressGridExample.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpressGridExample.BLL
{
    public static class Islemler
    {
        public static bool GridYazdırOnizleme(GridControl grid)
        {
            bool durum = true;
            // Check whether the GridControl can be previewed.
            if (!grid.IsPrintingAvailable)
            {
                durum = false;
            }
            return durum;
        }

        public static bool VeriKontrol(string baslangicTarih,string bitisTarih)
        {
            bool durum;
            try
            {
                int baslangicTarihi = Convert.ToInt32((Convert.ToDateTime(baslangicTarih)).ToOADate());
                int bitisTarihi = Convert.ToInt32((Convert.ToDateTime(bitisTarih)).ToOADate());
                durum = true;
            }
            catch (Exception ex)
            {
                durum = false;
            }
            return durum;
        }

        public static void MalKoduDoldur(AutoCompleteStringCollection stringCollection)
        {
            using (Entities.Entity.EntitiesDataContext db = new Entities.Entity.EntitiesDataContext())
            {
                var lst = (from k in db.STIs 
                            select new { k.MalKodu}
                    ).Distinct().ToList();
                foreach (var item in lst)
                {
                    stringCollection.Add(item.MalKodu);
                }
            }
           
        }

        public static List<StokVeri> VeriGetir(int baslangicTarihi, int bitisTarihi, string malKodu)
        {
            using (Entities.Entity.EntitiesDataContext db = new Entities.Entity.EntitiesDataContext())
            {
                int sira = 1;
                decimal stok = 0;
                List<StokVeri> stokVeris = (from k in db.sp_veridoldur(baslangicTarihi, bitisTarihi, malKodu)
                                            select new StokVeri()
                                            {
                                                IslemTuru = k.IslemTur == 0 ? "Giriş" : "Çıkış",
                                                EvrakNo = k.EvrakNo,
                                                Tarih = k.Tarih.Value.ToString("yyyy-MM-dd"),
                                                GirisMiktar = k.GirisMiktar,
                                                CikisMiktar = k.CikisMiktar
                                            }).ToList();

                foreach (StokVeri item in stokVeris)
                {
                    item.SiraNo = sira;
                    if (item.IslemTuru=="Giriş")
                    {
                        stok += item.GirisMiktar;
                        item.StokMiktar = stok;
                    }
                    else
                    {
                        stok -= item.CikisMiktar;
                        item.StokMiktar = stok;
                    }
                    sira++;
                }
                return stokVeris;
            }
        }
    }
}
