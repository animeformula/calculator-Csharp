using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        private Stack<string> history = new Stack<string>(); //new history for showtext.text to track
        public Form1()
        {
            InitializeComponent();
        }

        private void Num1Btn_Click(object sender, EventArgs e)
        {
            showText.Text += 1;
        }

        private void Num2Btn_Click(object sender, EventArgs e)
        {
            showText.Text += 2;
        }

        private void Num3Btn_Click(object sender, EventArgs e)
        {
            showText.Text += 3;
        }

        private void Num4Btn_Click(object sender, EventArgs e)
        {
            showText.Text += 4;
        }

        private void Num5Btn_Click(object sender, EventArgs e)
        {
            showText.Text += 5;
        }

        private void Num6Btn_Click(object sender, EventArgs e)
        {
            showText.Text += 6;
        }

        private void Num7Btn_click(object sender, EventArgs e)
        {
            showText.Text += 7;
        }

        private void Num8Btn_Click(object sender, EventArgs e)
        {
            showText.Text += 8;
        }

        private void Num9Btn_Click(object sender, EventArgs e)
        {
            showText.Text += 9;
        }

        private void Num0Btn_Click(object sender, EventArgs e)
        {
            showText.Text += 0;
        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            showText.Text += ".";
        }

        private void ModuleBtn_Click(object sender, EventArgs e)
        {
            showText.Text += "%";
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            showText.Text += "+";
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            showText.Text += "-";
        }

        private void MultiBtn_Click(object sender, EventArgs e)
        {
            showText.Text += "*";
        }

        private void DevideBtn_Click(object sender, EventArgs e)
        {
            showText.Text += "/";
        }

        private void DeleteAllBtn_Click(object sender, EventArgs e)
        {
            showText.Text = "";
        }

        private void DeleteNumBtn_Click(object sender, EventArgs e)
        {
            history.Push(showText.Text); // pushing to the text to the stack before deleting to track in undo.

            if (showText.Text.Length > 0) // then deletes if length is more than 0.
            {
                showText.Text = showText.Text.Remove(showText.Text.Length - 1);
            }
            else // if nothing is in the textbox itll give this error.
            {
                MessageBox.Show("Enter a valid number.", "Error!");
            }
        }

        private void UndoBtn_Click(object sender, EventArgs e)
        {
            if (history.Count > 0) // if then stack is greater than zero meaning has somthing in it itll pop it
            {                      // in the text box thats how the undo btn works
                showText.Text = history.Pop();
            }
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            try 
            {
                var result = new DataTable().Compute(showText.Text, null);
                showText.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!");
            }
        }
    }
}
