﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automatas_final.view
{
    public partial class ExAuto : Form
    {
        public ExAuto(DataTable data)
        {
            InitializeComponent();
            dgvAutomata.DataSource = data;
        }
    }
}
