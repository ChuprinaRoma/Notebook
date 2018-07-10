using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notebook
{
    public partial class CRUDPanel : UserControl
    {
        ManagerNotebook managerNotebook = null;
        public CRUDPanel()
        {
            InitializeComponent();
            managerNotebook = new ManagerNotebook();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                managerNotebook.Create(Convert.ToInt32(idT.Text), fNameT.Text, lNameT.Text, Convert.ToInt32(numberT.Text));
                idT.Text = "";
                fNameT.Text = "";
                lNameT.Text = "";
                numberT.Text = "";
            }
            catch (Exception) { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                managerNotebook.Delet(Convert.ToInt32(idT.Text));
            }
            catch (Exception) { }
        }
    }
}
