﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books form = new Books();
            form.Show();
        }

        private void readersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Readers form = new Readers();
            form.Show();
        }

        private void registryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registry form = new Registry();
            form.Show();
        }
    }
}
