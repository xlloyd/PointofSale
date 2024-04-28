using PointofSale.Model;
using PointofSale.View;
using System;
using System.Windows.Forms;

namespace PointofSale
{
    public partial class frmMain : Form
    {
        

        public static object Instance { get; internal set; }

        public frmMain()
        {
            InitializeComponent();
        }

        
        public void AddControls(Form f)
        {
            ControlsPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            ControlsPanel.Controls.Add(f);
            f.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddControls(new frmHome());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AddControls(new frmStaffView());
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            AddControls(new frmProductView());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUser.Text = MainClass.USER;
            
        }

        private void CenterPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCateg_Click(object sender, EventArgs e)
        {
            AddControls(new frmCategoryView());
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            AddControls(new frmTableView());
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            frmPOS frm = new frmPOS();
            frm.Show();
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            AddControls(new frmkitchenView());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            AddControls(new frmReports());
        }
    }
}
