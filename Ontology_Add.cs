using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expertsystem
{
    public partial class Ontology_Add: Form
    {
        public Ontology_Add()
        {
            InitializeComponent();
        }

        public void button1_Click(Object sender, EventArgs e)
        {
            Expert_System f1 = (Expert_System)this.Owner;
            f1.Set_Newrules(textBox1.Text);
            this.Close();
        }
    }
}
