﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOSM1
{
    public partial class ProductsUserControl : UserControl
    {
        public ProductsUserControl()
        {
            InitializeComponent();
        }
        public ProductsUserControl(long CategoryID)
        {
            InitializeComponent();
        }
        public ProductsUserControl(string SearchArgument)
        {
            InitializeComponent();
        }
    }
}