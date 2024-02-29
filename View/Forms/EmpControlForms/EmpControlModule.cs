using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursachFileSaving.View.Forms.EmpControlForms
{
    public partial class EmpControlModule : Form
    {
        public EmpControlModule()
        {
            InitializeComponent();
        }

        private void BCMCancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
