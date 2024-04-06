using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ortak_Kod_Yazma_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birim.Text = "0";
            adet.Text = "1";
            beyazesya.Checked = true;
            kirtasiye.Checked = false;
            gida.Checked = false;
        }

        private void birim_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double birimdouble = Convert.ToDouble(birim.Text);
                int adetint = Convert.ToInt32(adet.Text);
                double tutardouble = birimdouble * adetint;
                double kdvdouble = 0;

                if (beyazesya.Checked == true)
                {
                    kdvdouble = tutardouble * 0.25;
                }
                else if (kirtasiye.Checked == true)
                {
                    kdvdouble = tutardouble * 0.18;
                }
                else if (gida.Checked == true)
                {
                    kdvdouble = tutardouble * 0.01;
                }
                tutardouble = tutardouble + kdvdouble;
                if (bayi.Checked == true)
                {
                    tutardouble = tutardouble * 0.9;
                }
                kdv.Text = Convert.ToString(kdvdouble);
                tutar.Text = Convert.ToString(tutardouble);
            }
            catch (Exception)
            {

                
            }
            
        }
    }
}
