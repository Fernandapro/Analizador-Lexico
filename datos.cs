using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compiladoresclase
{
    public partial class datos : Form
    {
        public datos()
        {
            InitializeComponent();            
        }

        public datos(DataSet dt)
        {
            InitializeComponent();
            datosBD.DataSource = dt.Tables[0];
        }

        private void datos_Load(object sender, EventArgs e)
        {

        }
    }
}
