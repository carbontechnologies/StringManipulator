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
                MessageBox.Show("FindStringBetween2Strings: Passed");
            else
                MessageBox.Show("FindStringBetween2Strings: Failed");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            StringManipulator.WriteKeyToFile(@"C:\mytrials3.txt", "Mykey", "MyValue");

            if("MyValue" == StringManipulator.ReadKeyFromFile(@"C:\mytrials3.txt", "Mykey"))
                MessageBox.Show("Key-Value Pair: Passed");
            else
                MessageBox.Show("Key-Value Pair: Failed");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string teststring = "This is a bunch of instance words.";
            string toberemoved = " instance";

            string result = StringManipulator.RemoveTextFromString(teststring, toberemoved);

            if (result == "This is a bunch of words.")
                MessageBox.Show("RemoveTextFromString: Passed");
            else
                MessageBox.Show("RemoveTextFromString: Failed");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string teststring = StringManipulator.GetFileNameFromFullPath(@"C:\Users\Public\myfile.txt");

            if (teststring == "myfile.txt")
                MessageBox.Show("GetFileNameFromFullPath: Passed");
            else
                MessageBox.Show("GetFileNameFromFullPath: Failed");
        }
    }
}
