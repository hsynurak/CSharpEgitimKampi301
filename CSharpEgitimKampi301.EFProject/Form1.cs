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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.TblGuides.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblGuide tblGuide = new TblGuide();
            tblGuide.GuideName = txtName.Text;
            tblGuide.GuideSurname = txtSurname.Text;
            db.TblGuides.Add(tblGuide);
            db.SaveChanges();
            MessageBox.Show("Rehber Eklendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var removeValue = db.TblGuides.Find(id);
            if (removeValue != null)
            {
                db.TblGuides.Remove(removeValue);
                db.SaveChanges();
                MessageBox.Show("Rehber Silindi");
            }
            else
            {
                MessageBox.Show("Rehber Bulunamadı");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var updateValue = db.TblGuides.Find(id);
            updateValue.GuideName = txtName.Text;
            updateValue.GuideSurname = txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber Güncellendi");
        }

        private void btnListWithID_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var values = db.TblGuides.Where(x => x.GuideID == id).ToList();
            if (values.Count > 0)
            {
                dataGridView1.DataSource = values;
            }
            else
            {
                MessageBox.Show("Rehber Bulunamadı");
            }
        }
    }
}
