using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCalculator
{
    enum MathOperation
    {
        Add = 0,
        Subtract = 1,
        Mulitplication = 2,
        Division = 3
    }

    public partial class CALC : Form
    {
        public CALC()
        {
            InitializeComponent();
        }

        public string inpuVal1 = string.Empty;
        public string inpuVal2 = string.Empty;
        public bool isOperationClicked = false;
        public string operationVariable = string.Empty;

        private void btn_add_Click(object sender, EventArgs e)
        {
            isOperationClicked = true;
            operationVariable = MathOperation.Add.ToString();
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            isOperationClicked = true;
            operationVariable = MathOperation.Subtract.ToString();
        }

        private void btn_multp_Click(object sender, EventArgs e)
        {
            isOperationClicked = true;
            operationVariable = MathOperation.Mulitplication.ToString();
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            isOperationClicked = true;
            operationVariable = MathOperation.Division.ToString();
        }

        public string Add(string input1, string input2)
        {
            string result = string.Empty;   
            if(input1 != string.Empty && input2 !=string.Empty)
            {
                result =( int.Parse(input1) + int.Parse(input2) ).ToString();
            }

            return result;
        }

        public string Subtract(string input1, string input2)
        {
            string result = string.Empty;
            if (input1 != string.Empty && input2 != string.Empty)
            {
                result = (int.Parse(input1) - int.Parse(input2)).ToString();
            }

            return result;
        }

        public string Multiplication(string input1, string input2)
        {
            string result = string.Empty;
            if (input1 != string.Empty && input2 != string.Empty)
            {
                result = (int.Parse(input1) * int.Parse(input2)).ToString();
            }

            return result;
        }

        public string Division(string input1, string input2)
        {
            string result = string.Empty;
            if (input1 != string.Empty && input2 != string.Empty)
            {
                result = (int.Parse(input1) / int.Parse(input2)).ToString();
            }

            return result;
        }

        public void AssignInputValue(object sender)
        {
            if (isOperationClicked == false)
            {
                inpuVal1 += ((Button)sender).Text ;
                txt_result.Text = inpuVal1;
            }
            else
            {
                inpuVal2 +=  ((Button)sender).Text;
                txt_result.Text = inpuVal2;
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            AssignInputValue(sender);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            AssignInputValue(sender);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            AssignInputValue(sender);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            AssignInputValue(sender);
        }
        private void btn_5_Click(object sender, EventArgs e)
        {
            AssignInputValue(sender);

        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            AssignInputValue(sender);

        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            AssignInputValue(sender);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            AssignInputValue(sender);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            AssignInputValue(sender);
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            AssignInputValue(sender);
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            if (operationVariable == "Add")
            {
                txt_result.Text = Add(inpuVal1, inpuVal2);
            }
            else if (operationVariable == "Subtract")
            {
                txt_result.Text = Subtract(inpuVal1, inpuVal2);
            }
            else if (operationVariable == "Mulitplication")
            {
                txt_result.Text = Multiplication(inpuVal1, inpuVal2);
            }
            else if (operationVariable == "Division")
            {
                txt_result.Text = Division(inpuVal1, inpuVal2);
            }

            isOperationClicked = false;
            operationVariable = string.Empty;
            inpuVal1 = string.Empty;
            inpuVal2 = string.Empty;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_result.Text = "";
        }

       
    }
}

