using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Фоновая7_1
{
    public partial class Form1 : Form
    {
        Figure figura;
        public Form1()
        {
            InitializeComponent();
            RectangleRadioButton.Checked = false;
            RectangleRadioButton.Checked = true;
            RectangleRadioButton.Checked = false;
            RombRadioButton.Checked = false;
        }
        private void Show()
        {
            groupBox2.Visible = true;
            AreaLabel.Visible = true;
            PerimetrLabel.Visible = true;
            SideALabel.Visible = true;
            SideBLabel.Visible = true;
            IsSquareLabel.Visible = true;
        }
        private void Access()
        {
            SideTextBox.Enabled = true;
            HeightTextBox.Enabled = true;
            AngleTextBox.Enabled = true;
            CreateButton.Enabled = true;
            RedactButton.Enabled = true;
        }
        private void Clean()
        {
            SideTextBox.Text = "";
            HeightTextBox.Text = "";
            AngleTextBox.Text = "";
            RedactButton.Visible = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RectangleRadioButton_Click(object sender, EventArgs e)
        {
            Show();
            Access();
            Clean();
            Hide();
            AngleTextBox.Enabled = false;
        }

        private void RombRadioButton_Click(object sender, EventArgs e)
        {
            Show();
            Access();
            Clean();
            Hide();
            HeightTextBox.Enabled = false;
        }
        private void Hide()
        {
            AreaAnsLabel.Visible = false;
            PerimetrAnsLabel.Visible = false;
            SideAAnsLabel.Visible = false;
            SideBAnsLabel.Visible = false;
            IsSquareAnsLabel.Visible = false;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            CreateButton.Enabled = false;
            if (RectangleRadioButton.Checked == true)
            {
                try
                {
                    figura = new Rectangle(Convert.ToInt32(HeightTextBox.Text), Convert.ToInt32(SideTextBox.Text));
                    SideBAnsLabel.Text = Convert.ToString(figura.Height);
                }
                catch
                {
                    MessageBox.Show("Неправильный формат ввода", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (RombRadioButton.Checked == true)
            {
                try
                {
                    figura = new Romb(Convert.ToInt32(SideTextBox.Text), Convert.ToDouble(AngleTextBox.Text));
                    SideBAnsLabel.Text = Convert.ToString(figura.Width);
                }
                catch
                {
                    MessageBox.Show("Неправильный формат ввода", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            AreaAnsLabel.Text = Convert.ToString(figura.Area());
            PerimetrAnsLabel.Text = Convert.ToString(figura.Perimetr());
            SideAAnsLabel.Text = Convert.ToString(figura.Width);
            string ans;
            if (figura.Height == figura.Width) ans = "Da";
            else ans = "Net";
            IsSquareAnsLabel.Text = ans;
            AreaAnsLabel.Visible = true;
            PerimetrAnsLabel.Visible = true;
            SideAAnsLabel.Visible = true;
            SideBAnsLabel.Visible = true;
            IsSquareAnsLabel.Visible = true;
            RedactButton.Visible = true;
        }

        private void RedactButton_Click(object sender, EventArgs e)
        {
            if (RectangleRadioButton.Checked == true)
            {
                try
                {
                    figura.Width = Convert.ToInt32(SideTextBox.Text);
                    figura.Height = Convert.ToInt32(HeightTextBox.Text);
                    SideBAnsLabel.Text = Convert.ToString(figura.Height);
                }
                catch
                {
                    MessageBox.Show("Неправильный формат ввода", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (RombRadioButton.Checked == true)
            {
                try
                {
                    figura.Width = Convert.ToInt32(SideTextBox.Text);
                    figura.Alfa = Convert.ToDouble(AngleTextBox.Text);
                    SideBAnsLabel.Text = Convert.ToString(figura.Width);
                }
                catch
                {
                    MessageBox.Show("Неправильный формат ввода", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            AreaAnsLabel.Text = Convert.ToString(figura.Area());
            PerimetrAnsLabel.Text = Convert.ToString(figura.Perimetr());
            SideAAnsLabel.Text = Convert.ToString(figura.Width);
            string ans;
            if (figura.isQquare) ans = "Da";
            else ans = "Net";
            IsSquareAnsLabel.Text = ans;
        }
    }
}
