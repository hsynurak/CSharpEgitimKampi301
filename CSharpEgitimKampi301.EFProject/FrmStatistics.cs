using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            //Toplam Lokasyon Sayısı
            lblLocationCount.Text = db.TblLocations.Count().ToString();
            //Toplam Kontenjan Sayısı
            lblTotalCapacity.Text = db.TblLocations.Sum(x => x.LocationCapacity).ToString();
            //Toplam Rehber Sayısı
            lblGuideCount.Text = db.TblGuides.Count().ToString();
            //Ortalama Kontenjan Sayısı
            lblAverageCapacity.Text = db.TblLocations.Average(x => x.LocationCapacity).ToString();
            //Ortalama Tur Fiyatı
            lblAverageTourPrice.Text = db.TblLocations.Average(x => x.LocationPrice).Value.ToString("F2");
            //Türkiye Turlarının Ortalama Fiyatı
            lblTurkiyeAveragePrice.Text = db.TblLocations.Where(x=>x.LocationCountry == "Türkiye").Average(x=>x.LocationPrice).Value.ToString("F2");
            //Londra Gezisi Rehberi Adı
            var londonGuide = db.TblLocations.Where(x=> x.LocationCity == "Londra").Select(x=> x.TblGuide.GuideID).FirstOrDefault();
            lblLondonGuideName.Text = db.TblGuides.Where(x=>x.GuideID == londonGuide).Select(x => x.GuideName + " " + x.GuideSurname).FirstOrDefault();
            //En Yüksek Fiyatlı Tur
            var maxPrice = db.TblLocations.Max(x=>x.LocationPrice);
            lblMaxPriceTour.Text = db.TblLocations.Where(x=>x.LocationPrice == maxPrice).Select(x=>x.LocationCity).FirstOrDefault();
            //En Yüksek Kapasiteli Tur
            var maxCapacity = db.TblLocations.Max(x=>x.LocationCapacity);
            lblMaxCapacityTour.Text = db.TblLocations.Where(x=>x.LocationCapacity == maxCapacity).Select(x=>x.LocationCity).FirstOrDefault();
        }
    }
}
