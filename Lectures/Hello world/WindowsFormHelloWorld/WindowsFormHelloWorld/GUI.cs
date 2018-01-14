using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormHelloWorld
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private void ButtonHasBeenClicked(object sender, EventArgs e)
        {
            Test.Text = "Hello, world!";
        }

    }
}
