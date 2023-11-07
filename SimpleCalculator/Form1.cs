using System.Collections;

namespace SimpleCalculator
{
    public partial class MainForm : Form
    {

        private int maxLength = 13;
        private bool operatorSet = false;
        private bool operationStart = false;
        private bool operatorFinished = false;
        string? currentOperation;
        private Operations system = new Operations();
        private Queue operationQueue = new Queue();

        public MainForm()
        {
            InitializeComponent();

            //Initialized Components
            currentOperandTextBox.Text = "0";
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (currentOperandTextBox.Text != "0" && currentOperandTextBox.TextLength <= maxLength)
                currentOperandTextBox.Text += '0';

            if (operatorSet)
                operationStart = true;
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            if (currentOperandTextBox.Text == "0"
                || (operatorSet && currentOperandTextBox.Text == system.C.ToString())
                || (!operatorSet && currentOperandTextBox.Text == system.C.ToString()))
                currentOperandTextBox.Text = "1";
            else if (currentOperandTextBox.TextLength <= maxLength)
                currentOperandTextBox.Text += '1';

            if (operatorSet)
                operationStart = true;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            if (currentOperandTextBox.Text == "0"
                || (operatorSet && currentOperandTextBox.Text == system.C.ToString())
                || (!operatorSet && currentOperandTextBox.Text == system.C.ToString()))
                currentOperandTextBox.Text = "2";
            else if (currentOperandTextBox.TextLength <= maxLength)
                currentOperandTextBox.Text += '2';

            if (operatorSet)
                operationStart = true;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            if (currentOperandTextBox.Text == "0"
                || (operatorSet && currentOperandTextBox.Text == system.C.ToString())
                || (!operatorSet && currentOperandTextBox.Text == system.C.ToString()))
                currentOperandTextBox.Text = "3";
            else if (currentOperandTextBox.TextLength <= maxLength)
                currentOperandTextBox.Text += '3';

            if (operatorSet)
                operationStart = true;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (currentOperandTextBox.Text == "0"
                || (operatorSet && currentOperandTextBox.Text == system.C.ToString())
                || (!operatorSet && currentOperandTextBox.Text == system.C.ToString()))
                currentOperandTextBox.Text = "4";
            else if (currentOperandTextBox.TextLength <= maxLength)
                currentOperandTextBox.Text += '4';

            if (operatorSet)
                operationStart = true;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (currentOperandTextBox.Text == "0"
                || (operatorSet && currentOperandTextBox.Text == system.C.ToString())
                || (!operatorSet && currentOperandTextBox.Text == system.C.ToString()))
                currentOperandTextBox.Text = "5";
            else if (currentOperandTextBox.TextLength <= maxLength)
                currentOperandTextBox.Text += '5';

            if (operatorSet)
                operationStart = true;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (currentOperandTextBox.Text == "0"
                || (operatorSet && currentOperandTextBox.Text == system.C.ToString())
                || (!operatorSet && currentOperandTextBox.Text == system.C.ToString()))
                currentOperandTextBox.Text = "6";
            else if (currentOperandTextBox.TextLength <= maxLength)
                currentOperandTextBox.Text += '6';

            if (operatorSet)
                operationStart = true;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (currentOperandTextBox.Text == "0"
                || (operatorSet && currentOperandTextBox.Text == system.C.ToString())
                || (!operatorSet && currentOperandTextBox.Text == system.C.ToString()))
                currentOperandTextBox.Text = "7";
            else if (currentOperandTextBox.TextLength <= maxLength)
                currentOperandTextBox.Text += '7';

            if (operatorSet)
                operationStart = true;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            if (currentOperandTextBox.Text == "0"
                || (operatorSet && currentOperandTextBox.Text == system.C.ToString())
                || (!operatorSet && currentOperandTextBox.Text == system.C.ToString()))
                currentOperandTextBox.Text = "8";
            else if (currentOperandTextBox.TextLength <= maxLength)
                currentOperandTextBox.Text += '8';

            if (operatorSet)
                operationStart = true;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (currentOperandTextBox.Text == "0"
                || (operatorSet && currentOperandTextBox.Text == system.C.ToString())
                || (!operatorSet && currentOperandTextBox.Text == system.C.ToString()))
                currentOperandTextBox.Text = "9";
            else if (currentOperandTextBox.TextLength <= maxLength)
                currentOperandTextBox.Text += '9';

            if (operatorSet)
                operationStart = true;
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            if (currentOperandTextBox.Text.IndexOf('.') == -1)
                currentOperandTextBox.Text += '.';
            else if (currentOperandTextBox.Text == "0"
                || (operatorSet && currentOperandTextBox.Text == system.C.ToString())
                || (!operatorSet && currentOperandTextBox.Text == system.C.ToString()))
                currentOperandTextBox.Text = "0.";

            if (operatorSet)
                operationStart = true;
        }

        private void backSpaceButton_Click(object sender, EventArgs e)
        {
            if (currentOperandTextBox.Text.Length > 1)
            {
                char[] content = currentOperandTextBox.Text.ToCharArray();
                content[currentOperandTextBox.Text.Length - 1] = '\0';
                currentOperandTextBox.Text = String.Join("", content);
            }
            else if (currentOperandTextBox.TextLength == 1 && currentOperandTextBox.Text[0] != '0')
                currentOperandTextBox.Text = "0";
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            string specialFunctions = "equ";

            if (operationQueue.Count > 0)
            {
                if (specialFunctions.Contains(String.Format("{0}", operationQueue.Peek())))
                {
                    operationQueue.Dequeue();
                    operationStart = false;
                }
            }
           
            if (operationStart)
            {
                if (operationQueue.Count > 0)
                {
                    system.B = decimal.Parse(currentOperandTextBox.Text);
                    system.calculate(String.Format("{0}", operationQueue.Dequeue()));
                    secondOperandTextBox.Text = $"{system.C} + ";
                    operationQueue.Enqueue("add");
                }
            }
            else
            {
                operatorSet = true;

                if (operationQueue.Count > 0)
                {
                    if (String.Format("{0}", operationQueue.Peek()) != "add")
                    {
                        operationQueue.Dequeue();
                        operationQueue.Enqueue("add");
                    }
                }
                else
                {
                    operationQueue.Enqueue("add");
                }

                system.A = decimal.Parse(currentOperandTextBox.Text);
                secondOperandTextBox.Text = $"{system.A} + ";
            }
        }

        private void differenceButton_Click(object sender, EventArgs e)
        {
            string specialFunctions = "equ";

            if (operationQueue.Count > 0)
            {
                if (specialFunctions.Contains(String.Format("{0}", operationQueue.Peek())))
                {
                    operationQueue.Dequeue();
                    operationStart = false;
                }
            }

            if (operationStart)
            {
                if (operationQueue.Count > 0)
                {
                    system.B = decimal.Parse(currentOperandTextBox.Text);
                    system.calculate(String.Format("{0}", operationQueue.Dequeue()));
                    secondOperandTextBox.Text = $"{system.C} - ";
                    operationQueue.Enqueue("sub");
                }
            }
            else
            {
                operatorSet = true;

                if (operationQueue.Count > 0)
                {
                    if (String.Format("{0}", operationQueue.Peek()) != "sub")
                    {
                        operationQueue.Dequeue();
                        operationQueue.Enqueue("sub");
                    }
                }
                else
                {
                    operationQueue.Enqueue("sub");
                }

                system.A = decimal.Parse(currentOperandTextBox.Text);
                secondOperandTextBox.Text = $"{system.A} - ";
            }
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            string specialFunctions = "equ";

            if (operationQueue.Count > 0)
            {
                if (specialFunctions.Contains(String.Format("{0}", operationQueue.Peek())))
                {
                    operationQueue.Dequeue();
                    operationStart = false;
                }
            }

            if (operationStart)
            {
                if (operationQueue.Count > 0)
                {
                    system.B = decimal.Parse(currentOperandTextBox.Text);
                    system.calculate(String.Format("{0}", operationQueue.Dequeue()));
                    secondOperandTextBox.Text = $"{system.C} × ";
                    operationQueue.Enqueue("add");
                }
            }
            else
            {
                operatorSet = true;

                if (operationQueue.Count > 0)
                {
                    if (String.Format("{0}", operationQueue.Peek()) != "mul")
                    {
                        operationQueue.Dequeue();
                        operationQueue.Enqueue("mul");
                    }
                }
                else
                {
                    operationQueue.Enqueue("mul");
                }

                system.A = decimal.Parse(currentOperandTextBox.Text);
                secondOperandTextBox.Text = $"{system.A} × ";
            }
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            string specialFunctions = "equ";

            if (operationQueue.Count > 0)
            {
                if (specialFunctions.Contains(String.Format("{0}", operationQueue.Peek())))
                {
                    operationQueue.Dequeue();
                    operationStart = false;
                }
            }

            if (operationStart)
            {
                if (operationQueue.Count > 0)
                {
                    system.B = decimal.Parse(currentOperandTextBox.Text);
                    system.calculate(String.Format("{0}", operationQueue.Dequeue()));
                    secondOperandTextBox.Text = $"{system.C} ÷ ";
                    operationQueue.Enqueue("div");
                }
            }
            else
            {
                operatorSet = true;

                if (operationQueue.Count > 0)
                {
                    if (String.Format("{0}", operationQueue.Peek()) != "div")
                    {
                        operationQueue.Dequeue();
                        operationQueue.Enqueue("div");
                    }
                }
                else
                {
                    operationQueue.Enqueue("div");
                }

                system.A = decimal.Parse(currentOperandTextBox.Text);
                secondOperandTextBox.Text = $"{system.A} ÷ ";
            }
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            char Operator = ' ';

            if (operationQueue.Count > 0)
            {
                if(String.Format("{0}", operationQueue.Peek()) != "equ")
                {
                    currentOperation = String.Format("{0}", operationQueue.Dequeue());
                    system.B = decimal.Parse(currentOperandTextBox.Text);
                    system.calculate(currentOperation);
                    operationQueue.Enqueue("equ");
                }
                else
                {
                    system.A = system.C;
                    system.calculate(currentOperation);
                }

                if (currentOperation == "add")
                    Operator = '+';
                else if (currentOperation == "sub")
                    Operator = '-';
                else if (currentOperation == "mul")
                    Operator = '×';
                else if (currentOperation == "div")
                    Operator = '÷';

                secondOperandTextBox.Text = String.Format("{0} {1} {2} = ", system.A, Operator, system.B);
                currentOperandTextBox.Text = $"{system.C}";
            }
        }

        private void percentageButton_Click(object sender, EventArgs e)
        {
        }

        private void oneOverXButton_Click(object sender, EventArgs e)
        {
        }

        private void currentOperandTextBox_TextChanged(object sender, EventArgs e)
        {
        }
        private void positveNegativeButton_Click(object sender, EventArgs e)
        {
            decimal value = decimal.Parse(currentOperandTextBox.Text) * -1;
            currentOperandTextBox.Text = $"{value}";
        }

        private void acButton_Click(object sender, EventArgs e)
        {
            currentOperandTextBox.Text = "0";
            secondOperandTextBox.Text = "";
            currentOperation = "";
            operationStart = false;
            operatorSet = false;
            system.reset();
            operationQueue.Clear();
        }

        private void ceButton_Click(object sender, EventArgs e)
        {
            currentOperandTextBox.Text = "0";
        }
    }
}