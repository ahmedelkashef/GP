﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoEditor
{
    public partial class Motion : Form
    {
        public Motion()
        {
            InitializeComponent();
        }
        public Motion(Bitmap b)
        {
            InitializeComponent();
            pic_original.Image = b;
            pic_modified.Image = b;
        }
    }
}
