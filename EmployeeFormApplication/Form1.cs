using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeFormApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>() { "HR", "Admin","Development","Sales","Marketing"};
            combodept.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bs = Convert.ToDouble(textSalary.Text);
            double hra = bs * 0.40;
            double ta = bs * 0.20;
            double da = bs * 0.10;
            double pf = bs * 0.12;

            double gross = (bs + hra + da + ta) - pf;

            texthra.Text = hra.ToString();
            textda.Text = da.ToString();
            textpf.Text = pf.ToString();
            textta.Text = ta.ToString();
            textgs.Text = gross.ToString();
        }

        private void Display_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"ID={textId} \n First Name={textFirstName.Text} \n Last Name={textLastName.Text} \nSalary={textSalary.Text}\nDepartment={combodept.Text}");
           
        }

        private void textId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
