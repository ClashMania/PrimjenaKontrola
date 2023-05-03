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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string name, desc;

        public string Name1 { get => name; set => name = value; }
        public string Desc { get => desc; set => desc = value; }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            name = TxtBoxName.Text;
            desc = TxtBoxDesc.Text;
            DialogResult= DialogResult.OK;
        }
    }
}
