using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc1
{
    public partial class Form1 : Form
    {
        Brain brain;
        public Form1()
        {
            InitializeComponent();
            DisplayMessage displayMessage = new DisplayMessage(SetDisplayMessage);
            brain = new Brain(displayMessage);
        }
        void SetDisplayMessage(string text)
        {
            textBox1.Text = text;
        }
        public void BtnPressedEvent(object sender, EventArgs args)
        {
            Button btn = sender as Button;
            brain.ProcessSignal(btn.Text);
        }
    }
}
