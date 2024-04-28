﻿
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.OleDb;
using PointofSale.repo;

namespace PointofSale.Model
{
    public partial class frmBills : SampleAdd
    {
        public frmBills()
        {
            InitializeComponent();
        }

        public int MainID = 0;
       
        private void frmBills_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            
            string qry = @"select MainID, TableName, WaiterName, orderType, status, total from tblMain where status <> 'Pending' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvvid);
            lb.Items.Add(dgvtable);
            lb.Items.Add(dgvWaiter);
            lb.Items.Add(dgvType);
            lb.Items.Add(dgvStatus);
            lb.Items.Add(dgvTotal);


            MainClass.LoadData(qry, guna2DataGridView1, lb);
        }

        private void guna2DataGridView1_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {

                MainID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvvid"].Value);
                this.Close();

            }

            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
               MainID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvvid"].Value);
                string qry = @"SELECT *
               FROM tblMain m
               INNER JOIN tblDetails d ON d.MainID = m.MainID
               INNER JOIN products p ON p.pID = d.ProID
               WHERE m.MainID = " + MainID + " ";

                SqlCommand cmd = new SqlCommand(qry, MainClass.con);
                MainClass.con.Open();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                MainClass.con.Close();

                frmPrint frm = new frmPrint();
                bill cr = new bill();

                cr.SetDatabaseLogon("sa", "1234");
                cr.SetDataSource(dt);
                frm.crystalReportViewer1.ReportSource = cr;
                frm.crystalReportViewer1.Refresh();
                frm.Show();


            }
        }
    }
}

