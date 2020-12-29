using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class MainForm : Form
    {


        private List<Figure> _cases = new List<Figure>();
        public MainForm()
        {
            InitializeComponent();
            ChooseRoute.Items.Add("up");
            ChooseRoute.Items.Add("down");
            ChooseRoute.Items.Add("right");
            ChooseRoute.Items.Add("left");
        }

        private void X1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '-')
            {
                e.Handled = true;
            }
        }

        private void Y1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '-')
            {
                e.Handled = true;
            }
        }

        private void X3TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '-')
            {
                e.Handled = true;
            }
        }

        private void Y3TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '-')
            {
                e.Handled = true;
            }
        }

        private void X2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '-')
            {
                e.Handled = true;
            }
        }

        private void X4TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '-')
            {
                e.Handled = true;
            }
        }

        private void Y2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '-')
            {
                e.Handled = true;
            }
        }



        private void X5TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '-')
            {
                e.Handled = true;
            }
        }

        private void Y5TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '-')
            {
                e.Handled = true;
            }
        }

        private void RouteText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void Y4TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '-')
            {
                e.Handled = true;
            }
        }

        private void RectangleCheck_CheckedChanged(object sender, EventArgs e)
        {
            NameBox.Enabled = true;
            X1TextBox.Enabled = true;
            X2TextBox.Enabled = true;
            X3TextBox.Enabled = true;
            X4TextBox.Enabled = true;
            X5TextBox.Enabled = false;
            Y1TextBox.Enabled = true;
            Y2TextBox.Enabled = true;
            Y3TextBox.Enabled = true;
            Y4TextBox.Enabled = true;
            Y5TextBox.Enabled = false;
        }

        private void PentagonCheck_CheckedChanged(object sender, EventArgs e)
        {
            NameBox.Enabled = true;
            X1TextBox.Enabled = true;
            X2TextBox.Enabled = true;
            X3TextBox.Enabled = true;
            X4TextBox.Enabled = true;
            X5TextBox.Enabled = true;
            Y1TextBox.Enabled = true;
            Y2TextBox.Enabled = true;
            Y3TextBox.Enabled = true;
            Y4TextBox.Enabled = true;
            Y5TextBox.Enabled = true;
        }

        private void ChooseRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            RouteText.Enabled = true;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            int count = 0;
            Factory figureFactory = new Factory();
            if (RectangleCheck.Checked)
            {
                if (X1TextBox.TextLength == 0 || X2TextBox.TextLength == 0 || X3TextBox.TextLength == 0 || X4TextBox.TextLength == 0 || Y1TextBox.TextLength == 0 || Y2TextBox.TextLength == 0 || Y3TextBox.TextLength == 0 || Y4TextBox.TextLength == 0)
                {
                    MessageBox.Show("Enter points");
                    return;
                }
                count = 4;

            }
            if (PentagonCheck.Checked)
            {
                if (X1TextBox.TextLength == 0 || X2TextBox.TextLength == 0 || X3TextBox.TextLength == 0 || X4TextBox.TextLength == 0 || X5TextBox.TextLength == 0 || Y1TextBox.TextLength == 0 || Y2TextBox.TextLength == 0 || Y3TextBox.TextLength == 0 || Y4TextBox.TextLength == 0 || Y5TextBox.TextLength == 0)
                {
                    MessageBox.Show("Enter points");
                    return;
                }
                count = 5;
            }
            if(NameBox.Text=="")
            {
                MessageBox.Show("Enter name");
                return;
            }

            Point[] points = new Point[count];
            RichTextBox[] textBoxesX = new RichTextBox[5] { X1TextBox, X2TextBox, X3TextBox, X4TextBox, X5TextBox };
            RichTextBox[] textBoxesY = new RichTextBox[5] { Y1TextBox, Y2TextBox, Y3TextBox, Y4TextBox, Y5TextBox };


            for (int i = 0; i < count; i++)
            {
                points[i].x = Convert.ToDouble(textBoxesX[i].Text);
                points[i].y = Convert.ToDouble(textBoxesY[i].Text);
            }
            Figure newElement = figureFactory.createFigure(points, count);
            _cases.Add(newElement);

            SelectFigure.Items.Add(NameBox.Text);
            richTextBox1.Text = NameBox.Text + " is\n" + newElement.ToStringFigure();

            NameBox.Text = "";


            for (int i = 0; i < count; i++)
            {
                textBoxesX[i].Text = "";
                textBoxesY[i].Text = "";
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            if (SelectFigure.Items.Count != 0 && SelectFigure.SelectedIndex != -1)
            {
                _cases.RemoveAt(SelectFigure.SelectedIndex);
                SelectFigure.Items.RemoveAt(SelectFigure.SelectedIndex);
                SelectFigure.Text = "";
            }
            else
            {
                MessageBox.Show("Choose something");
                return;
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (SelectFigure.Items.Count != 0 && SelectFigure.SelectedIndex != -1)
            {
                richTextBox1.Text = SelectFigure.SelectedItem + " is\n" + _cases[SelectFigure.SelectedIndex].ToStringFigure();
            }
            else
            {
                MessageBox.Show("Choose something");
                return;
            }
        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            if (SelectFigure.Items.Count == 0 && SelectFigure.SelectedIndex == -1)
            {
                MessageBox.Show("Choose something");
                return;
            }
            if (ChooseRoute.Items.Count == 0 && ChooseRoute.SelectedIndex == -1)
            {
                MessageBox.Show("Choose route");
                return;
            }
            if (RouteText.Text == "")
            {
                MessageBox.Show("Choose scale");
                return;
            }
   
            _cases[SelectFigure.SelectedIndex].Move(ChooseRoute.SelectedItem.ToString(), Convert.ToInt32(RouteText.Text));
            richTextBox1.Text = SelectFigure.SelectedItem + " is\n" + _cases[SelectFigure.SelectedIndex].ToStringFigure();
        }

        private void ChooseRoute_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            RouteText.Enabled = true;
        }
    }
}

