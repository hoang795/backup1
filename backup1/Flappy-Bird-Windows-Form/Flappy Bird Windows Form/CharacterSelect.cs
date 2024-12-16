using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Flappy_Bird_Windows_Form
{
    public partial class CharacterSelect : Form
    {
        public CharacterSelect()
        {
            InitializeComponent();
            textBox1.Click += PanelMode1_Click;
            textBox2.Click += PanelMode2_Click;

        }
        private void PanelMode1_Click(object sender, EventArgs e)
        {
            //Move to Mode 1 screen
            MessageBox.Show("You have chosen Mode 1");
            CharacterSelect mode1Form = new CharacterSelect();
            string modeName = "Mode 1";   // Example value for first argument
            string difficulty = "Normal"; // Example value for second argument

            // Create an instance of Form1 with the required arguments
            Form1 form1 = new Form1(modeName, difficulty);

            // Show Form1
            form1.Show();

            // Optionally hide the current form
            this.Hide();

        }
        private void PanelMode2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have chosen Mode 2");
            CharacterSelect mode;
            this.Hide();

        }

        private void CharacterSelect_Load(object sender, EventArgs e)
        {

        }
    }
}