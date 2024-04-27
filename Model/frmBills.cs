﻿using System;
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

            }


            }
        }
    }

