using PointofSale.repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = PointofSale.repo.Menu;

namespace PointofSale.View
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
          
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            string qry = @"SELECT *
               FROM products  ";

            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            MainClass.con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            MainClass.con.Close();
            frmPrint frm = new frmPrint();
            Menu cr = new Menu();

            cr.SetDatabaseLogon("sa", "1234");
            cr.SetDataSource(dt);
            frm.crystalReportViewer1.ReportSource = cr;
            frm.crystalReportViewer1.Refresh();
            frm.Show();
        }
        private void btnStaff_Click(object sender, EventArgs e)
        {
            string qry = @"SELECT *
               FROM staff  ";

            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            MainClass.con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            MainClass.con.Close();
            frmPrint frm = new frmPrint();
            Staff cr = new Staff();

            cr.SetDatabaseLogon("sa", "1234");
            cr.SetDataSource(dt);
            frm.crystalReportViewer1.ReportSource = cr;
            frm.crystalReportViewer1.Refresh();
            frm.Show();
        }

        private void btnSalesCat_Click(object sender, EventArgs e)
        {
            frmSalesByCategory frm = new frmSalesByCategory();
            frm.ShowDialog();
        }
    }
}
