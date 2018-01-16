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
            string Result = "";

            try
            {
                float LeftValue = float.Parse(LHS.Text);
                float RightValue = float.Parse(RHS.Text);
                Result = Calculate(LeftValue, RightValue, Result);
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
            finally
            {

                AnswerLabel.Text = Result;
            }


        }

        private string Calculate(float LeftValue, float RightValue, string Result)
        {

            switch (OperatorLabel.Text)
            {
                case "+":
                    Result = (LeftValue + RightValue).ToString();
                    break;
                case "-":
                    Result = (LeftValue - RightValue).ToString();
                    break;
                case "*":
                    Result = (LeftValue * RightValue).ToString();
                    break;
                case "/":
                    Result = (LeftValue / RightValue).ToString();
                    break;
                default:
                    break;
            }
            CheckForInfinity(Result);
            return Result;
        }

        private void CheckForInfinity(string Result)
        {
            if (Result.Equals("Infinity"))
            {
                AnswerLabel.ForeColor = Color.Red;
                AnswerLabel.Text = "Input is not a valid number";
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
