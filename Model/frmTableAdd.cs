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
    public partial class frmTableAdd : SampleAdd
    {
        public frmTableAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

        public override void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "Insert into tables Values(@Name)";
            }
            else
            {
                qry = "Update tables set tName = @Name where tID = @id ";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", TextName.Text);

            if (MainClass.SQL(qry, ht) > 0)
            {
                guna2MessageDialog1.Show("Save successfully...");
                id = 0;
                TextName.Focus();
            }
        }

    }
}
