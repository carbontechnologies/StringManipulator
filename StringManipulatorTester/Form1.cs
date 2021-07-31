using CarbonTechnologies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringManipulatorTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string teststring = StringManipulator.FindStringBetween2Strings(
                "This is a bunch of instance words.",
                "This is a",
                "instance"); ;

            if (teststring == " bunch of ")
                MessageBox.Show("Passed");
            else
                MessageBox.Show("Failed");



            MessageBox.Show(StringManipulator.RemoveTextFromString("This is a bunch of instance words.", "instance"));

            teststring = StringManipulator.FindStringBetween2Strings(
                "123456789",
                "234",
                "78");

            if (teststring == "56")
                MessageBox.Show("Passed");
            else
                MessageBox.Show("Failed");

            teststring = StringManipulator.GetFileNameFromFullPath(@"C:\Users\Public\myfile.txt");

            if(teststring == "myfile.txt")
                MessageBox.Show("Passed");
            else
                MessageBox.Show("Failed");




        }
    }
}
