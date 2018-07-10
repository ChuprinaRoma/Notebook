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
    public partial class Tabla : UserControl
    {
        public Tabla()
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();
            SetUI.dataGridView = dataGridView1;
        }
    }
}
