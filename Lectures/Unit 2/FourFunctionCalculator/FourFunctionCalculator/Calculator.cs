using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourFunctionCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            AnswerButton.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            OperatorLabel.Text = "+";
            AnswerButton.Visible = true;
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            OperatorLabel.Text = "-";
            AnswerButton.Visible = true;
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            OperatorLabel.Text = "*";
            AnswerButton.Visible = true;
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            OperatorLabel.Text = "/";
            AnswerButton.Visible = true;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            LHS.Text = "0";
            RHS.Text = "0";
            OperatorLabel.Text = "";
            AnswerLabel.Text = "";

            AnswerButton.Visible = false;
        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            try
            {
                float LeftValue = float.Parse(LHS.Text);
                float RightValue = float.Parse(RHS.Text);
                Calculate(LeftValue, RightValue);
                AnswerLabel.ForeColor = Color.Black;
            }
            catch (FormatException)
            {
                AnswerLabel.ForeColor = Color.Red;
                AnswerLabel.Text = "Input value is not a valid number";
            }
            catch (OverflowException)
            {
                AnswerLabel.ForeColor = Color.Red;
                AnswerLabel.Text = "Input value is too large";
            }


        }

        private void Calculate(float LeftValue, float RightValue)
        {
            double Result;

            switch (OperatorLabel.Text)
            {
                case "+":
                    Result = LeftValue + RightValue;
                    break;
                case "-":
                    Result = LeftValue - RightValue;
                    AnswerLabel.Text = Result.ToString("G10");
                    break;
                case "*":
                    Result = LeftValue * RightValue;
                    AnswerLabel.Text = Result.ToString("G10");
                    break;
                case "/":
                    Result = LeftValue / RightValue;
                    AnswerLabel.Text = Result.ToString("G10");
                    break;
                default:
                    break;
            }
            AnswerLabel.Text = Result.ToString("G10");
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
