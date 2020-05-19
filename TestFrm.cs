using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProblemRegistration
{
    public partial class TestFrm : Form
    {
        public TestFrm()
        {
            InitializeComponent();
        }
        public string textLblSC
        {
            get { return lblSC.Text; }
            set { lblSC.Text = value; }
        }
        public string textLblPlan
        {
            get { return lblPlan.Text; }
            set { lblPlan.Text = value; }
        }

        private void TestFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
