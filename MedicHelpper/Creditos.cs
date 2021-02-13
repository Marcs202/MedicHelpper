using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicHelpper
{
    public partial class Creditos : Form
    {
        public Creditos()
        {
            InitializeComponent();
          
        }
        private void pctAtras_Click(object sender, EventArgs e)
        {
            Timer_creditos.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();
            LoginMedicHelppercs log = new LoginMedicHelppercs();
            log.Show();
        }
    }
}
