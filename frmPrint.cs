﻿using System;
using System.Windows.Forms;

namespace PointofSale
{
    public partial class frmPrint : Form
    {
        public frmPrint()
        {
            InitializeComponent();
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            btnMax.PerformClick();
        }
    }
}
