using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Frm_Hotel : Form
    {
        public Frm_Hotel()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_Comments Frm_Comments = new Frm_Comments();

            Frm_Comments.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(Frm_Comments);

            Frm_Comments.Show();
        }
    }
}
