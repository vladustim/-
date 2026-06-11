using System.Drawing;

namespace кокулятор
{
    public partial class Form1 : Form
    {
        private double firstNumber = 0;
        private string operation = "";
        private bool isOperationSelected = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddHandlers(this);

            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void AddHandlers(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Button button)
                {
                    if (button.Text.Length > 0)
                    {
                        if (char.IsDigit(button.Text[0]) || button.Text == ".")
                            button.Click += NumberButton_Click;

                        if (button.Text == "+" || button.Text == "-" ||
                            button.Text == "*" || button.Text == "/" || button.Text == "%")
                            button.Click += OperationButton_Click;

                        if (button.Text == "=")
                            button.Click += EqualButton_Click;

                        if (button.Text == "CE")
                            button.Click += ClearButton_Click;

                        if (button.Text == "←")
                            button.Click += BackspaceButton_Click;
                    }
                }

                if (control.HasChildren)
                {
                    AddHandlers(control);
                }
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
                AddDigit("0");

            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
                AddDigit("1");

            if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
                AddDigit("2");

            if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
                AddDigit("3");

            if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
                AddDigit("4");

            if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
                AddDigit("5");

            if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
                AddDigit("6");

            if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
                AddDigit("7");

            if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
                AddDigit("8");

            if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
                AddDigit("9");
        }

        private void AddDigit(string value)
        {
            if (isOperationSelected || lblDisplay.Text == "Помилка")
            {
                lblDisplay.Text = "0";
                isOperationSelected = false;
            }

            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = value;
            }
            else
            {
                lblDisplay.Text += value;
            }
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!lblDisplay.Text.Contains("."))
                {
                    lblDisplay.Text += ".";
                }

                return;
            }

            AddDigit(button.Text);
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            firstNumber = Convert.ToDouble(lblDisplay.Text.Replace('.', ','));
            operation = button.Text;
            isOperationSelected = true;
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            double secondNumber = Convert.ToDouble(lblDisplay.Text.Replace('.', ','));

            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;

                case "-":
                    result = firstNumber - secondNumber;
                    break;

                case "*":
                    result = firstNumber * secondNumber;
                    break;

                case "%":
                    result = firstNumber * secondNumber / 100;
                    break;

                case "/":
                    if (secondNumber == 0)
                    {
                        lblDisplay.Text = "Помилка";
                        return;
                    }

                    result = firstNumber / secondNumber;
                    break;
            }

            lblDisplay.Text = result.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            firstNumber = 0;
            operation = "";
            isOperationSelected = false;
        }

        private void radioOn_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOn.Checked)
            {
                foreach (Control control in tlpButtonsPanel.Controls)
                {
                    control.Enabled = true;
                }

                KeyPreview = true;
            }
        }

        private void radioOff_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOff.Checked)
            {
                foreach (Control control in tlpButtonsPanel.Controls)
                {
                    control.Enabled = false;
                }

                KeyPreview = false;
                lblDisplay.Text = "";
            }
        }

        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length > 1)
            {
                lblDisplay.Text = lblDisplay.Text.Substring(0, lblDisplay.Text.Length - 1);
            }
            else
            {
                lblDisplay.Text = "0";
            }
        }

        private void lblDisplay_TextChanged(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length <= 3)
            {
                lblDisplay.ForeColor = Color.Black;
            }
            else if (lblDisplay.Text.Length <= 8)
            {
                lblDisplay.ForeColor = Color.DarkGreen;
            }
            else
            {
                lblDisplay.ForeColor = Color.DarkRed;
            }
        }

        private void btnce_Click(object sender, EventArgs e)
        {
            using (ConfirmClearForm confirm =
           new ConfirmClearForm())
            {
                DialogResult result =
                    confirm.ShowDialog();

                if (result == DialogResult.Yes)
                {
                    lblDisplay.Text = "0";
                }
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {

        }
    }
}
