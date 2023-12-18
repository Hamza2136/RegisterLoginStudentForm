using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDetailsLoginResgister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            if(tbname.Text!=string.Empty && tbrollno.Text!=string.Empty && tbdepartment.Text!=string.Empty &&tbsession.Text !=string.Empty && tbuniversity.Text != string.Empty && tbusername.Text!=string.Empty && tbpassword.Text != string.Empty && tbcpassword.Text!=string.Empty ) {
                if(tbpassword.Text == tbcpassword.Text )
                {
                    StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Users\\" + tbusername.Text + ".txt");
                    sw.WriteLine(tbpassword.Text);
                    sw.WriteLine(tbname.Text);
                    sw.WriteLine(tbrollno.Text);
                    sw.WriteLine(tbdepartment.Text);
                    sw.WriteLine(tbsession.Text);
                    sw.WriteLine(tbuniversity.Text);
                    sw.Close();
                    MessageBox.Show("User Registered Successfully");
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Password doesn't matched");
                    tbpassword.Clear();
                    tbcpassword.Clear();
                }
                
            }
            else
            {
                MessageBox.Show("All fields are required");
            }
        }

        private void rbtnlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
