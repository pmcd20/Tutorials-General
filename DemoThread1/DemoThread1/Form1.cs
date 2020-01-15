using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoThread1
{
    public partial class Form1 : Form
    {
        SampleClass sc;
        long counter = 0;

        public Form1()
        {
            InitializeComponent();
            sc = new SampleClass();
            lblCounter.Text = counter.ToString();
            
        }

       
        private void btnRunThread_Click(object sender, EventArgs e)
        {
            try
            {


                txtDemo.Text = "";
                MyMessage msg = new MyMessage(PrintToTextBox);
                sc.DoWork(msg);
                sc.Method2(msg);

                txtDemo.Text += "Last Call of btn" + Environment.NewLine;
                sc.Dispose();

                if (sc == null)
                {
                    txtDemo.Text += "sc object is null" + Environment.NewLine;
                }

            }

            catch (Exception ex)
            {
                PrintToTextBox(ex.ToString());
            }
        }

        private void PrintToTextBox(string msg)
            {

                if (InvokeRequired)
                {
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        txtDemo.Text += msg + Environment.NewLine;
                    });
                }
                else
                {
                    txtDemo.Text += msg + Environment.NewLine;
                }


            }

        private void BtnCounter_Click(object sender, EventArgs e)
        {
            counter++;
            lblCounter.Text = counter.ToString();
            Application.DoEvents();
        }

        private void txtDemo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCounter_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }
