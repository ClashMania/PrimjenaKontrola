using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimjenaKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            if( comboBox1.Text == "Notepad")
            {
                System.Diagnostics.Process.Start("notepad.exe");
            }

            if (comboBox1.Text == "Paint")
            {
                System.Diagnostics.Process.Start("mspaint.exe");
            }
        }

        private void Chb_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox.Checked == true)
            {
                groupBox1.Visible = true;
            }

            if(checkBox.Checked == false)
            {
                groupBox1.Visible = false;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            richTextBox1.Clear();
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Odaberite neko dugme", "Obavještenje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2= new Form2();
            if(form2.ShowDialog(Owner) == DialogResult.OK)
            {
                textBox1.AppendText(form2.Name1);
                richTextBox1.AppendText(form2.Desc);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Jeste li ste sigurni da želite zatvoriti aplikaciju?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
