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
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.TblGuides.ToList();
            cbGuide.DisplayMember = "GuideName";
            cbGuide.ValueMember = "GuideID";
            cbGuide.DataSource = values;
        }
        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.TblLocations.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblLocation tblLocation = new TblLocation();
            tblLocation.LocationCity = txtName.Text;
            tblLocation.LocationCountry = txtCountry.Text;
            tblLocation.LocationCapacity = byte.Parse(nudCapacity.Value.ToString());
            tblLocation.LocationPrice = decimal.Parse(txtPrice.Text);
            tblLocation.DayNight = txtDayNight.Text;
            tblLocation.GuideID = int.Parse(cbGuide.SelectedValue.ToString());
            db.TblLocations.Add(tblLocation);
            db.SaveChanges();
            MessageBox.Show("Ekleme işlemi başarılı");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var removeValue = db.TblLocations.Find(id);
            db.TblLocations.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Silme işlemi başarılı");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var updateValue = db.TblLocations.Find(id);
            updateValue.LocationCity = txtName.Text;
            updateValue.LocationCountry = txtCountry.Text;
            updateValue.LocationCapacity = byte.Parse(nudCapacity.Value.ToString());
            updateValue.LocationPrice = decimal.Parse(txtPrice.Text);
            updateValue.DayNight = txtDayNight.Text;
            updateValue.GuideID = int.Parse(cbGuide.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi başarılı");
        }

        private void btnListWithID_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var values = db.TblLocations.Where(x => x.LocationID == id).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
