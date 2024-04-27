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

namespace PointofSale.Model
{
    public partial class frmCheckout : SampleAdd
    {
        public frmCheckout()
        {
            InitializeComponent();
        }

        public double amt;
        public int MainID = 0;

        private void txtRecieved_TextChanged(object sender, EventArgs e)
        {
            double change = 0;

            double.TryParse(TxtBillAmount.Text, out double amt);
            double.TryParse(txtRecieved.Text, out double receipt);
            
            change = Math.Abs(amt - receipt);

            txtChange.Text = change.ToString();
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            string qry = @"  Update tblMain set total = @total, received = @rec, change = @change, 
status = 'Paid' where MainID = @id ";

            Hashtable ht = new Hashtable();
            ht.Add("@id", MainID);
            ht.Add(@"total", TxtBillAmount.Text);
            ht.Add("@rec", txtRecieved.Text);
            ht.Add("@change", txtChange.Text);

            if (MainClass.SQL(qry, ht)>0) 
            {
            
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Show("Saved Successfully...");
                this.Close();
            
            }
        }

        private void frmCheckout_Load(object sender, EventArgs e)
        {
            TxtBillAmount.Text = amt.ToString();
        }
    }
}
