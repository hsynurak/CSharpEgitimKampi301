using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpEgitimKampi301.EntityLayer.Conrete;
using CSharpEgitimKampi301BusinessLayer.Abstract;
using CSharpEgitimKampi301BusinessLayer.Concrete;
using CSharpEgitimKampi301DataAccessLayer.EntityFramework;

namespace CSharpEgitimKampi301.PresentationLayer
{
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;
        public FrmCategory()
        {
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var categoryValues = _categoryService.TGetAll();
            dataGridView1.DataSource = categoryValues;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtCategoryName.Text;
            if (rbActive.Checked)
            {
                category.CategoryStatus = true;
            }
            else if (rbPassive.Checked)
            {
                category.CategoryStatus = false;
            }
            _categoryService.TInsert(category);
            MessageBox.Show("Kategori Eklendi");    
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int deletedID = int.Parse(txtCategoryID.Text);
            var deletedValues = _categoryService.TGetById(deletedID);
            _categoryService.TDelete(deletedValues);
            MessageBox.Show("Kategori Silindi");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            int updatedID = int.Parse(txtCategoryID.Text);
            var updatedValues = _categoryService.TGetById(updatedID);
            updatedValues.CategoryName = txtCategoryName.Text;
            updatedValues.CategoryStatus = rbActive.Checked ? true : false;
            _categoryService.TUpdate(updatedValues);
            MessageBox.Show("Kategori Güncellendi");
        }

        private void btnListWithID_Click(object sender, EventArgs e)
        {
            int choosedID = int.Parse(txtCategoryID.Text);
            var choosenValues = _categoryService.TGetById(choosedID);
            dataGridView1.DataSource = choosenValues;
        }
    }
}
