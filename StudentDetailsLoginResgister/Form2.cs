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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(tbusername.Text != string.Empty && tbpassword.Text!= string.Empty)
            {
                try
                {
                    StreamReader sr = new StreamReader(Application.StartupPath + "\\Users\\" + tbusername.Text + ".txt");
                    string password = sr.ReadLine();
                    if(tbpassword.Text == password)
                    {
                        string name = sr.ReadLine();
                        string rollno = sr.ReadLine() ;
                        string department = sr.ReadLine() ;
                        string session = sr.ReadLine();
                        string university = sr.ReadLine();
                        sr.Close();
                        Form3 form3 = new Form3(name,rollno,department,session,university);
                        form3.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password doesn't match");
                        tbpassword.Clear();
                    }
                }
                catch {
                    MessageBox.Show("User Does not exists Please Register");
                }
            }
            else
            {
                MessageBox.Show("All fields are required please fill them");
            }
        }

        private void lbtnregister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
