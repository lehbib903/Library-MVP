
using LibraryMVP.Logic.Prisenter;
using LibraryMVP.Views.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMVP.Views.Forms
{
    public partial class Frm_Category : Form, ICategory
    {
        CategoryPrisenter catPrisenter;

        public int ID { get => Convert.ToInt32(txtID.Text) ; set => txtID.Text = value.ToString(); }
        public string CatName { get =>txtName.Text ; set =>txtName.Text = value.ToString(); }

        public Frm_Category()
        {
            InitializeComponent();
            catPrisenter = new CategoryPrisenter(this);
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          bool check=  catPrisenter.catInsert();
            if (check)
            {
                MessageBox.Show("تم الإضافة بنجاح");
            }
            else
            {
                MessageBox.Show("لم يتم");
            }
        }
    }
}
