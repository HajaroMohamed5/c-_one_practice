using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asssignment1
{
    public partial class lbname : Form
    {
       

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void lblname_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
       {
            //clearing textboxes
            txtname.Clear();
            txtstudentid.Clear();
            txtdepartment.Text = "";
            txtsemester.Text = String.Empty;

            //clearing label
            lbloutput.Text = "";

            //clearing textboxes
            txtname.Clear();
            txtstudentid.Clear();
            txtdepartment.Text = "";
            txtsemester.Text = String.Empty;

            //clearing label
            lbloutput.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsshowinfo_Click(object sender, EventArgs e)
        {
            //input creating variables
            String Sname, department, semester;
            int sID;

            //initial values to variables
            Sname = txtname.Text;
            sID = int.Parse(txtstudentid.Text);
            department = txtdepartment.Text;
            semester = txtsemester.Text;

            //process
            String fullinfo;
            fullinfo = "Name :" + Sname + " ID : " + sID +
                "  Department : " + department
                + " semester " + semester;
            // output
            lbloutput.Text = fullinfo;
          
        }

        private void txtstudentid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdepartment_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsemester_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbldepartment_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                this.Close();

        }

        private void lbloutput_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void lblstudentid_Click(object sender, EventArgs e)
        {

        }

        private void lblsemester_Click(object sender, EventArgs e)
        {

        }
    }
}
