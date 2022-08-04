using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeploymentTask1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(InputTextBox1.Text);
            int y = Int32.Parse(InputTextBox2.Text);
            ResultOutputLabel.Text = (CustomMath.CustomMath.Add(x, y)).ToString();
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(InputTextBox1.Text);
            int y = Int32.Parse(InputTextBox2.Text);
            ResultOutputLabel.Text = (CustomMath.CustomMath.Subtract(x, y)).ToString();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(InputTextBox1.Text);
            int y = Int32.Parse(InputTextBox2.Text);
            ResultOutputLabel.Text = (CustomMath.CustomMath.Multiply(x, y)).ToString();
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(InputTextBox1.Text);
            int y = Int32.Parse(InputTextBox2.Text);
            ResultOutputLabel.Text = (CustomMath.CustomMath.Divide(x, y)).ToString();
        }

        private void WelcomeButton_Click(object sender, EventArgs e)
        {
            GreetingOutputLabel.Text = CustomGreeting.CustomGreeting.WelcomeGreeting(NameInput.Text);
        }

        private void GdayButton_Click(object sender, EventArgs e)
        {
            GreetingOutputLabel.Text = CustomGreeting.CustomGreeting.GdayGreeting(NameInput.Text);
        }

        private void WhatsUpButton_Click(object sender, EventArgs e)
        {
            GreetingOutputLabel.Text = CustomGreeting.CustomGreeting.WhatsUpGreeting(NameInput.Text);
        }
    }
}
