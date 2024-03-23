using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class BleBle
    {
        private readonly Form2 _form2;
        private readonly Form1 _form1;
        public BleBle()
        {
                _form2 = new Form2();
            _form1 = new Form1();
        }

        public void form2Changer(Form1 form1)
        {
            _form2.Visible = true;
            form1.Visible = false;

            _form2.labelText = "Działa";
        }
    }
}
