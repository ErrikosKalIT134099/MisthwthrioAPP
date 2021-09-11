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
        public MainForm()
        {
            InitializeComponent();
        }

        private void createBTN_Click(object sender, EventArgs e)
        {
            previewForm priv = new previewForm(ekmisthotisCB.Text,nameTB.Text,surnameTB.Text,katoikiaMisthwthTB.Text,adtTB.Text,afmTB.Text);
            priv.ShowDialog();
        }
    }
}
