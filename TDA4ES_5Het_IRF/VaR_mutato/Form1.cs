﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VaR_mutato
{
    public partial class Form1 : Form
    {
        PortfolioEntities context = new PortfolioEntities();
        
        public Form1()
        {
            InitializeComponent();
            
        }
    }
}
