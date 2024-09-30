using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorApplication;

namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        CalculatorClass cal;
        public FrmCalculator()
        {
            InitializeComponent();
            cal = new CalculatorClass();

            cbOperator.Items.Add("+");
            cbOperator.Items.Add("-");
            cbOperator.Items.Add("*");
            cbOperator.Items.Add("/");
        }

        private void cbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtBoxInput1.Text);
            double num2 = Convert.ToDouble(txtBoxInput2.Text);

            switch (cbOperator.SelectedItem.ToString())
            {
                case "+":
                    cal.CalculateEvent += new Formula<double>(cal.GetSum);
                    lblDisplayTotal.Text = cal.GetSum(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetSum);
                    break;
                case "-":
                    cal.CalculateEvent += new Formula<double>(cal.GetDifference);
                    lblDisplayTotal.Text = cal.GetDifference(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetDifference);
                    break;
                case "*":
                    cal.CalculateEvent += new Formula<double>(cal.GetProduct);
                    lblDisplayTotal.Text = cal.GetProduct(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetProduct);
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        cal.CalculateEvent += new Formula<double>(cal.GetQuotient);
                        lblDisplayTotal.Text = cal.GetQuotient(num1, num2).ToString();
                        cal.CalculateEvent -= new Formula<double>(cal.GetQuotient);
                    }
                    else
                    {
                        lblDisplayTotal.Text = "Cannot divide by zero!";
                    }
                    break;
            }
        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
