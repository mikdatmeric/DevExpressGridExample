using DevExpressGridExample.Entities.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpressGridExample.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Grid yazdırılabilir hale getiriliyor.
            gridView1.OptionsPrint.UsePrintStyles = true;
            gridView1.OptionsPrint.EnableAppearanceEvenRow = true;

            // Arama yapıldıktan sonra print ve export butonlarının aktif olması sağlanıyor
            panelControl1.Visible = false;

            // Mal Kodu textbox ını dolduruluyor.
            AutoCompleteStringCollection stringCollection = new AutoCompleteStringCollection();
            BLL.Islemler.MalKoduDoldur(stringCollection);
            txtMalKodu.AutoCompleteCustomSource = stringCollection;

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            panelControl1.Visible = true;
            int baslangicTarihi, bitisTarihi;
            string malKodu;
            bool kontrol = BLL.Islemler.VeriKontrol(txtBaslangicTarihi.Text, txtBitisTarihi.Text);
            if (kontrol)
            {
                baslangicTarihi = Convert.ToInt32(Convert.ToDateTime(txtBaslangicTarihi.Text).ToOADate());
                bitisTarihi = Convert.ToInt32(Convert.ToDateTime(txtBitisTarihi.Text).ToOADate());
                malKodu = txtMalKodu.Text;
                var veri = BLL.Islemler.VeriGetir(baslangicTarihi, bitisTarihi, malKodu);
                gridControl1.DataSource = veri;
            }
            else
            {
                MessageBox.Show("Başlangıç veya bitiş tarihlerini tarih formatına uygun şekilde giriniz.");
            }


        }

        private void smpBtnYazdır_Click(object sender, EventArgs e)
        {
            bool durum = BLL.Islemler.GridYazdırOnizleme(gridControl1);
            if (durum)
            {
                // Önizleme menüsü açılıyor.
                gridControl1.ShowPrintPreview();
            }
            else
            {
                MessageBox.Show("Tablomuzun yazdırılabilir özelliği aktif edilmemiştir.");
            }
        }

        private void smpBtnDosyayaKaydet_Click(object sender, EventArgs e)
        {
            GridDosyayaKaydet(gridView1);
        }

        private void GridDosyayaKaydet(DevExpress.XtraGrid.Views.Grid.GridView gridView1)
        {
            saveFileDialog1.FileName = "Stok Verisi(" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ")";
            saveFileDialog1.Filter = "XLS Dosyaları (*.xls)|*.xls";

            saveFileDialog1.InitialDirectory = "c:";

            //eğer saveFileDiaolog1 açıldığında Evet’e tıklanırsa

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                DevExpress.XtraPrinting.XlsExportOptions _Options = new DevExpress.XtraPrinting.XlsExportOptions();

                _Options.SheetName = "Stok Verisi(" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ")";

                gridView1.ExportToXls(saveFileDialog1.FileName, _Options);

                if (MessageBox.Show("Aktarılan dosyayı şimdi görmek ister misiniz?", "Excel dosyası", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    //Kaydedilen Excel Dosyasını açar.

                    System.Diagnostics.Process.Start(saveFileDialog1.FileName);
                }
            }
        }
    }
}
