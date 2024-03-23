using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public string labelText
        {
            get { return label1.Text;}
            set
            {
                label1.Text = value;
            }
        }
        public Form2()
        {
            InitializeComponent();
        }
    }
}
