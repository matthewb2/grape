using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            //pictureBox1.Image = Image.FromFile("cherry-clipart.png");
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //close dialog
            this.Close();

        }
    }
}
