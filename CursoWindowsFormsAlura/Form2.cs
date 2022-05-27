using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsFormsAlura
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txt_Nome_KeyDown(object sender, KeyEventArgs e)
        {
            txt_Msg.AppendText("\r\n" + "Pressionei uma tecla: " + e.KeyCode + "\r\n");
            txt_Msg.AppendText("\t" + "código da tecla: " + ((int)e.KeyCode) + "\r\n");
            txt_Msg.AppendText("\t" + "Nome da tecla: " + e.KeyData + "\r\n");
            lbl_Lower.Text = e.KeyCode.ToString().ToLower();
            lblUpper.Text = e.KeyCode.ToString().ToUpper();
        }

        private void btn_Limpa_Click(object sender, EventArgs e)
        {
            txt_Msg.Text = "";
            txt_Nome.Text = "";
            lbl_Lower.Text = "";
            lblUpper.Text = "";
        }
    }
}
