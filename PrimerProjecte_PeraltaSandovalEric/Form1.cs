﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerProjecte_PeraltaSandovalEric
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ctrlPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dadesMestresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sortirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void peticióModulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Petició_Mòdul f = new Petició_Mòdul();

            f.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
