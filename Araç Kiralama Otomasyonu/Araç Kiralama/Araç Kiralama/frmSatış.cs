﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araç_Kiralama
{
    public partial class frmSatış : Form
    {
        public frmSatış()
        {
            InitializeComponent();
        }

        Araç_Kiralama arac = new Araç_Kiralama();

        private void frmSatış_Load(object sender, EventArgs e)
        {
            string sorgu2 = "select * from satış";

            using (SqlDataAdapter adtr2 = new SqlDataAdapter())
            {
                dataGridView1.DataSource = arac.listele(adtr2, sorgu2);
            }

            arac.satışhesapla(label1);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
