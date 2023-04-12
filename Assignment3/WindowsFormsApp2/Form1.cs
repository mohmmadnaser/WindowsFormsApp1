using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textskills_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void textExperience_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)


        {

            string name;
            int age;
            string Skills;
            string Experience;

            if (string.IsNullOrEmpty(textname.Text) || string.IsNullOrEmpty(textage.Text)
             ||  string.IsNullOrEmpty(textskills.Text)|| string.IsNullOrEmpty(textskills.Text)
                
                )
            {
                MessageBox.Show("Please enter valid data in all fields");
            }
            else
            {
                name = textname.Text;
                age = int.Parse(textage.Text);
                Skills = textskills.Text;
                Experience = textskills.Text;

                MessageBox.Show("Name: " + name + "\n" + "Age: " + age.ToString() + "\n"+ "Skills :" + Skills+ "\n" +"Experience :"+ Experience);
                
                   
            }
        }
    }
}
