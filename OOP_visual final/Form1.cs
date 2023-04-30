using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_OOP
{
    public partial class Form1 : Form
    {
        private Button currentButton;

        
        public Form1()
        {
            InitializeComponent();
        }

       

        private void ActivateButton(object buttonSender)
        {
            if(buttonSender != null)
            {
                if(currentButton != (Button)buttonSender)
                {
                    DisableButton();
                    Color color = Color.Red;
                    currentButton = (Button)buttonSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.DarkCyan;
                    previousBtn.ForeColor = Color.White;

                }
            }
        }

        private void addColumnButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
