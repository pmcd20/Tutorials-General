using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestApiTest
{

    /// <summary>
    /// Example taken from Video by Tim Corey
    /// https://www.youtube.com/watch?v=aWePkE2ReGw
    /// </summary>
    public partial class Form1 : Form
    {

        private int maxNumber = 0;
        private int currentNumber = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private  void Form1_Load(object sender, EventArgs e)
        {
            ApiHelper.InitializeClient();
            btnNext.Enabled = false;

            
        }


        public async Task LoadImage(int imageNumber = 0)
        {
            var comic = await ComicProcessor.LoadComic(imageNumber);

            if (imageNumber == 0)
            {
                maxNumber = comic.Num;
            }

            currentNumber = comic.Num;

            //var uriSource = new Uri(comic.Img, UriKind.Absolute);
            //comicImage.Source = new BitmapImage()
            pictureBox1.ImageLocation = comic.Img;

        }

        private async void Form1_Shown(object sender, EventArgs e)
        {
            await LoadImage();
        }

        private async void btnPrevious_Click(object sender, EventArgs e)
        {
            Visibles();
            if (currentNumber > 1)
            {
                currentNumber -= 1;
                btnNext.Enabled = true;
                await LoadImage(currentNumber);

                if (currentNumber  ==1)
                {
                    btnPrevious.Enabled = false;
                }
            }
        }


        private async void btnNext_Click(object sender, EventArgs e)
        {
            Visibles();
            if (currentNumber < maxNumber)
            {
                currentNumber += 1;
                btnPrevious.Enabled = true;
                await LoadImage(currentNumber);

                if (currentNumber == maxNumber)
                {
                    btnNext.Enabled = false;
                }

            }
        }

        private async void btnSun_Click(object sender, EventArgs e)
        {
            Visibles(false);
            var sunInfo = await  SunProcessor.LoadSun();
            txtSunrise.Text = sunInfo.Sunrise.ToLocalTime().ToShortTimeString();
            txtSunset.Text = sunInfo.SunSet.ToLocalTime().ToShortTimeString();
        }


        private void  Visibles(bool picVis = true)
        {
         
                pictureBox1.Visible = picVis;
                groupSun.Visible = !picVis;
       


            Application.DoEvents();
        }

      
    }
}
