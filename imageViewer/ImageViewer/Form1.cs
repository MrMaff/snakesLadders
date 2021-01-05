using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ImageViewer
{

    

    public partial class Form1 : Form
    {

        public Bitmap myPicture;
        public int[,] myMap = new int[20, 20];

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_LoadImage_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
              
                myPicture = ConvertToBMP(openFileDialog1.FileName);
                pbc_viewer.Image = myPicture;
                lbl_Width.Text = myPicture.Width.ToString();
                lbl_Height.Text = myPicture.Height.ToString();

                for (int y = 0; y < 20; y++)
                {
                    for (int x = 0; x < 20; x++)
                    {
                        Color tempColour = myPicture.GetPixel(x, y);

                        if (tempColour.B < 125)
                        {
                            myMap[x, y] = 1;
                        }
                        else
                        {
                            myMap[x, y] = 0;
                        }
                    }
                }

                DisplayMap();
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        public Bitmap ConvertToBMP(string fileName)
        {
            Bitmap tempIMG = new Bitmap(20,20);

            using (Stream bmpStream = File.Open(fileName, FileMode.Open))
            {
                Image image = Image.FromStream(bmpStream);
                Graphics g = Graphics.FromImage(tempIMG);
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
                g.DrawImage(image, 0, 0, 20, 20);
               
            }

            return tempIMG;
        }

        public void DisplayMap()
        {
            string tempMap = "";

            for (int y = 0; y < 20; y++)
            {
                for (int x = 0; x < 20; x++)
                {
                    tempMap = tempMap + myMap[x, y].ToString();
                }
                tempMap = tempMap + System.Environment.NewLine;
            }
            tbx_Output.Text = tempMap;
        }
    }
}
