using System;
using System.Windows.Forms;

namespace FractionCalculatorWithGUI_Final
{
    public partial class MainForm : Form
    {
        private enum DISPLAY_MODE { CURRENT_VALUE, ACCUMULATOR }
        private enum FractionValue { numerator, denominator }
        private FractionValue fractionValue = FractionValue.numerator;
        private enum OPERATION { ADD, SUB, MUL, DIV }
        private Fraction accumulator = new Fraction();
        private OPERATION currentOperation = OPERATION.ADD;
        private Fraction currentValue = new Fraction();
        private DISPLAY_MODE displayMode = DISPLAY_MODE.CURRENT_VALUE;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void textBoxDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateDisplay()
        {
            switch (displayMode)
            {
                case DISPLAY_MODE.ACCUMULATOR:
                    textBoxDisplay.Text = accumulator.ToString();
                    break;

                case DISPLAY_MODE.CURRENT_VALUE:
                    textBoxDisplay.Text = currentValue.ToString();
                    break;
            }
        }

        private void buttonSlash_Click(object sender, EventArgs e)
        {
            fractionValue = FractionValue.denominator;
            textBoxDisplay.Text = currentValue.ToString() + "/";

            UpdateDisplay();
        }

        private void NumberKeyHit(int number)
        {
            displayMode = DISPLAY_MODE.CURRENT_VALUE;
            if (fractionValue == FractionValue.numerator)
            {
                currentValue.numerator = currentValue.numerator * 10 + number;
            }
            else
            {
                currentValue.denominator = currentValue.denominator * 10 + number;
            }
            UpdateDisplay();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            NumberKeyHit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumberKeyHit(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumberKeyHit(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NumberKeyHit(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NumberKeyHit(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NumberKeyHit(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NumberKeyHit(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NumberKeyHit(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NumberKeyHit(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NumberKeyHit(9);
        }

        private void OperationKeyHit(OPERATION op)
        {
            PerformOperation();
            currentOperation = op;
            currentValue = new Fraction();
            fractionValue = FractionValue.numerator;
            UpdateDisplay();
        }

        private void PerformOperation()
        {
            switch (currentOperation)
            {
                case OPERATION.ADD:
                    accumulator += currentValue;
                    break;

                case OPERATION.SUB:
                    accumulator -= currentValue;
                    break;

                case OPERATION.MUL:
                    accumulator *= currentValue;
                    break;

                case OPERATION.DIV:
                    accumulator /= currentValue;
                    break;
            }

            currentValue = new Fraction();
            fractionValue = FractionValue.numerator;
            displayMode = DISPLAY_MODE.ACCUMULATOR;
            UpdateDisplay();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            OperationKeyHit(OPERATION.ADD);
        }
        //Operational Buttons
  

        private void buttonEquals_Click(object sender, EventArgs e)
        {
           PerformOperation();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            OperationKeyHit(OPERATION.SUB);
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            OperationKeyHit(OPERATION.DIV);
        }

        private void buttonTimes_Click(object sender, EventArgs e)
        {
            OperationKeyHit(OPERATION.MUL);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            currentValue = new Fraction();
            fractionValue = FractionValue.numerator;
            UpdateDisplay();
        }

        private void buttonAllClear_Click(object sender, EventArgs e)
        {
            currentValue = new Fraction();
            accumulator= new Fraction();
            fractionValue = FractionValue.numerator;
            currentOperation = OPERATION.ADD;
            UpdateDisplay();
        }

        
    }
}