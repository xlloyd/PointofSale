using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PointofSale.Model
{
    public partial class frmCategoryAdd : SampleAdd
    {
        public frmCategoryAdd()
        {
            InitializeComponent();
        }

        private void frmCategoryAdd_Load(object sender, EventArgs e)
        {

        }

        public int id = 0;

        public override void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "Insert into category Values(@Name)";
            }
            else
            {
                qry = "Update category set catName = @Name where catID = @id ";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", TextName.Text);

            if( MainClass.SQL(qry, ht) > 0 )
            {
                guna2MessageDialog1.Show("Save successfully...");
                id = 0;
                TextName.Text = "";
                TextName.Focus();
            }
        }

        

    }
}
