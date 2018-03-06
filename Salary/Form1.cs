using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary
{
    public partial class Form1 : Form
    {
        List<string> all = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void validateFields()
        {
            if (textBoxHours.Text == "" ||
               textBoxSalaryPerHour.Text == "") 
            {
                MessageBox.Show("Моля попълнете празните полета!");
            }
        }

        private int salary()
        {
            return int.Parse(textBoxHours.Text)
                * int.Parse(textBoxSalaryPerHour.Text);
        }

        private void buttonClear_Click(object sender, EventArgs e) => Clear();
        void Clear()
        {
         textBoxHours.Clear();
         textBoxSalaryPerHour.Clear();               

         comboBoxName.Focus();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            validateFields();

            string output;
            output = salary().ToString();
            
            this.textBoxSalary.Text = output;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            validateFields();
            string output;
            output = this.comboBoxName.Text + ", ";
            output += "изработени часове: " + this.textBoxHours.Text + ", ";
            output += "заплата: " + this.textBoxSalary.Text;
            all.Add(output);
            this.richTextBoxAll.Text = string.Join("\n",all);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            System.IO.TextWriter txt = new System.IO.StreamWriter("Order.txt");
            txt.Write(richTextBoxAll.Text);
            txt.Close();

            MessageBox.Show("Файла е записан в папката, в която се изпълнява приложенето");
        }
    }
}
    

       