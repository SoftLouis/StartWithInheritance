using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartWithInheritance
{
    Vorm v;

    public partial class frmVormen : Form
    {
        public frmVormen()
        {
            InitializeComponent();
        }

        private void btnMaken_Click(object sender, EventArgs e)
        {
            UInt32 _grootte = Convert.ToUInt32(txtGrootte.Text);
            try
            {
                if (rdbCirkel.Checked == true)
                    v = new Cirkel(_grootte);
                else if (rdbVierkant.Checked == true)
                {
                    v = new Vierkant(_grootte);
                }
                //MessageBox.Show("Het maken van de cirkel is gelukt!");
                //MessageBox.Show("De cirkel heeft de straal " + c.Straal);
                picBord.Invalidate();
                lstVormen.Items.Add(v);
            }
            catch (Exception exc)
            {
                txtGrootte.BackColor = Color.Red;
            }
        }

        private void txtGrootte_TextChanged(object sender, EventArgs e)
        {
            txtGrootte.BackColor = Color.White;
        }

        private void picBord_Paint(object sender, PaintEventArgs e)
        {
            if (v != null)
                v.Paint(e.Graphics);

        }
    }
}
