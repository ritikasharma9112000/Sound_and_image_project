using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sound_and_image_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            System.IO.Stream myStream = myAssembly.GetManifestResourceStream("ProjectName.Resources.ImageFileName.jpg");

            Bitmap bmp_Object = new Bitmap(myStream);

            PictureBox_Name.Image = bmp_Object;


        }
    }
}
