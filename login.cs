using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win1.loginf;
namespace Win1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.number = Convert.ToInt32(num.Text);
            add.date = Convert.ToDateTime(date.Text);
            add.invnumber = Convert.ToInt32(invnum.Text);
            add.objname = objname.Text;
            add.count = Convert.ToInt32(count.Text);    
            add.price = Convert.ToDouble(price.Text);
            MessageBox.Show(add.save());
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
