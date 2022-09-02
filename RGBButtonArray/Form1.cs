using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGBButtonArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int columns = 5;
            int rows = 5;

            int size = 100;
            int padding = 10;
            Point location = Point.Empty;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Button button = new Button();
                    button.Size = new Size(size, size);
                    button.Location = location;
                    location.X += padding + size;
                    button.Text = $"{i * 5 + j + 1}";

                    Random random = new Random();
                    button.BackColor = Color.FromArgb(random.Next(Int32.MaxValue));

                    button.Click += ButtonClick;
                    this.Controls.Add(button);
                }
                location.Y += padding + size;
                location.X -= (padding + size) * columns;
            }
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            this.Controls.Remove(button);
        }
    }
}
