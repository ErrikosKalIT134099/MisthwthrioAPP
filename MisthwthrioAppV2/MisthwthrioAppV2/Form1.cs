using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisthwthrioAppV2
{
    public partial class MainForm : Form
    {
        int egguhsh;
        public MainForm()
        {
            InitializeComponent();
        }

        public int checkEgguhshMethod()
        {
            if (egguhshCheckBox.Checked)
            {
                egguhshLB.Visible = false;
                egguhshTB.Visible = false;
                egguhsh = int.Parse(misthomaTB.Text);

            }
            if (!egguhshCheckBox.Checked)
            {
                egguhshLB.Visible = true;
                egguhshTB.Visible = true;
                egguhsh= int.Parse(egguhshTB.Text);
            }

            return egguhsh;
        }

        private void createBTN_Click(object sender, EventArgs e)
        {
            previewForm priv = new previewForm(ekmisthotisCB.Text,nameTB.Text,surnameTB.Text,katoikiaMisthwthTB.Text,adtTB.Text,afmTB.Text,addressTB.Text,cityTB.Text,orofosCB.Text,int.Parse(misthomaTB.Text),checkEgguhshMethod(),xrhshRTB.Text,double.Parse(tetMetraTB.Text),datePicker.Text);
            priv.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void egguhshCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkEgguhshMethod();
        }
    }
}
