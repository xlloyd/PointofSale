using System;
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
    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        public string orderType = "";
        public int driverID = 0;
        public string cusName = "";

        public int mainID = 0;

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            if (orderType == "Take-Out")
            {
                lblDriver.Visible = false;
                cbDriver.Visible = false;
            }

            string qry = "SELECT staffID AS id, sName AS name FROM staff WHERE sRole LIKE 'Driver'";

            MainClass.CBFill(qry, cbDriver);

            if (mainID > 0)
            {
                cbDriver.SelectedIndex = driverID;
            }
        }

        private void cbDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            driverID = Convert.ToInt32(cbDriver.SelectedValue);
        }
    }
}
