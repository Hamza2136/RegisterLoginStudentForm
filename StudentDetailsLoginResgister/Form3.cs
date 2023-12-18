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
using static System.Collections.Specialized.BitVector32;
using System.Xml.Linq;

namespace StudentDetailsLoginResgister
{
    public partial class Form3 : Form
    {
        public Form3(string name, string rollno, string department, string session, string university)
        {
            InitializeComponent();
            lname.Text = name;
            lrollno.Text = rollno;
            ldepartment.Text = department;
            lsession.Text = session;
            luniversity.Text = university;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
