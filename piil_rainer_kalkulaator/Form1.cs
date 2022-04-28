using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace piil_rainer_kalkulaator
{
    public partial class Form1 : Form
    {
        public string myarv1;
        public string myarv2;

        public Form1()
        {
            InitializeComponent();
        }
        matemaatika tehted = new matemaatika();
        private void arvestaBtn_Click(object sender, EventArgs e)
        {
            myarv1 = arv1Text.Text;
            myarv2 = arv2Text.Text;
            try
            {
                if(myarv1.Length != 0 && myarv2.Length != 0)
                {

                if (!myarv1.Contains(".") && !myarv2.Contains("."))
            {
                    myarv1 =   myarv1.Replace(",", ".");
                    myarv2 =  myarv2.Replace(",", ".");


                    if (chkLiida.Checked)
                    {
                        tehted.arv1 = Convert.ToSingle(myarv1);
                        tehted.arv2 = Convert.ToSingle(myarv2);
                        vastus.Text = tehted.liitmine();

                    }
                    else if (chkLahuta.Checked)
                    {
                        tehted.arv1 = Convert.ToSingle(myarv1);
                        tehted.arv2 = Convert.ToSingle(myarv2);
                    vastus.Text = tehted.lahutamine();
                    }
                    else if (chkKorruta.Checked)
                    {
                        tehted.arv1 = Convert.ToSingle(myarv1);
                        tehted.arv2 = Convert.ToSingle(myarv2);
                        vastus.Text = tehted.korrutamine();
                    }
                    else if (chkJaga.Checked)
                    {
                        tehted.arv1 = Convert.ToSingle(myarv1);
                        tehted.arv2 = Convert.ToSingle(myarv2);
                        vastus.Text = tehted.jagamine();

                    }
                    else
                    {
                            MessageBox.Show("Vali tehe", "Teade",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                }
                else
                {
                    MessageBox.Show("Kasuta punkti asemel koma", "Viga",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
                else
                {
                    MessageBox.Show("Sisesta arvud", "Teade",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                }
                catch
                {
                    MessageBox.Show("Vaata kas sisestatud on numbrid", "Viga",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           

        }
    }
}
