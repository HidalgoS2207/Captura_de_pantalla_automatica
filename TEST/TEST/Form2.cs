using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class Form2 : Form
    {
        int x_coordinates = 0;
        int y_coordinates = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void get_coordinates(object sender, EventArgs e)
        {
            x_coordinates = Cursor.Position.X;
            y_coordinates = Cursor.Position.Y;

            this.Close();
        }

        public int get_x()
        {
            return x_coordinates;
        }

        public int get_y()
        {
            return y_coordinates;
        }
    }
}
