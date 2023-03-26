using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CanSıkıntısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double alis;
        double satis;

  
        private void button1_Click(object sender, EventArgs e)
        {
         
        }
        //873

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void kar2_Click(object sender, EventArgs e)
        {
            if (kar2.Checked==true)
            {
                double alis = Convert.ToDouble(txtAllis.Text);
                double satis = Convert.ToDouble(txtSatis.Text= (( alis) / 100 * 2 + alis).ToString());
                txtKar.Text = (satis - alis).ToString();
            }
        }

        private void kar4_CheckedChanged(object sender, EventArgs e)
        {
            if (kar4.Checked == true)
            {
                double alis = Convert.ToDouble(txtAllis.Text);
                double satis = Convert.ToDouble(txtSatis.Text = ((alis) / 100 * 4 + alis).ToString());
                txtKar.Text = (satis - alis).ToString();
            }
        }

        private void kar3_CheckedChanged(object sender, EventArgs e)
        {
            if (kar3.Checked == true)
            {
                double alis = Convert.ToDouble(txtAllis.Text);
                double satis = Convert.ToDouble(txtSatis.Text = ((alis) / 100 * 3 + alis).ToString());
                txtKar.Text = (satis - alis).ToString();
            }
        }

        private void kar5_CheckedChanged(object sender, EventArgs e)
        {
            if (kar5.Checked == true)
            {
                double alis = Convert.ToDouble(txtAllis.Text);
                double satis = Convert.ToDouble(txtSatis.Text = ((alis) / 100 * 5 + alis).ToString());
                txtKar.Text = (satis - alis).ToString();
            }
        }

        private void kar6_CheckedChanged(object sender, EventArgs e)
        {
            if (kar6.Checked == true)
            {
                double alis = Convert.ToDouble(txtAllis.Text);
                double satis = Convert.ToDouble(txtSatis.Text = ((alis) / 100 * 6 + alis).ToString());
                txtKar.Text = (satis - alis).ToString();
            }

        }

        private void kar7_CheckedChanged(object sender, EventArgs e)
        {
            if (kar7.Checked == true)
            {
                double alis = Convert.ToDouble(txtAllis.Text);
                double satis = Convert.ToDouble(txtSatis.Text = ((alis) / 100 * 7 + alis).ToString());
                txtKar.Text = (satis - alis).ToString();
            }
        }

        private void kar8_CheckedChanged(object sender, EventArgs e)
        {
            if (kar8.Checked == true)
            {
                double alis = Convert.ToDouble(txtAllis.Text);
                double satis = Convert.ToDouble(txtSatis.Text = ((alis) / 100 * 8 + alis).ToString());
                txtKar.Text = (satis - alis).ToString();
            }
        }

        private void kar9_CheckedChanged(object sender, EventArgs e)
        {
            if (kar9.Checked == true)
            {
                double alis = Convert.ToDouble(txtAllis.Text);
                double satis = Convert.ToDouble(txtSatis.Text = ((alis) / 100 * 9 + alis).ToString());
                txtKar.Text = (satis - alis).ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double alis = Convert.ToDouble(txtAllis.Text);
            double satis = Convert.ToDouble(txtSatis.Text);
            //double karorani = Convert.ToDouble((satis - alis)/satis*100);
            txtKar.Text = (satis - alis).ToString();
            //txtKarOrani.Text= (Convert.ToDouble((alis - satis) / alis * 100)).ToString()
        }
    }
    }
