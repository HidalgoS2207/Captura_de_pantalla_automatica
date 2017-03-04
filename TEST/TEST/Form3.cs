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
    public partial class Form3 : Form
    {
        bool[] points = { true , true};
        int[] first_point = { 0, 0 };
        int[] second_point = { 0, 0 };

        public Form3()
        {
            InitializeComponent();
        }

        public void set_point(object sender, EventArgs e)
        {
            if(points[0])
            {
                points[0] = false;

                first_point[0] = Cursor.Position.X;
                first_point[1] = Cursor.Position.Y;
            }
            else if(points[1])
            {
                points[1] = false;

                second_point[0] = Cursor.Position.X;
                second_point[1] = Cursor.Position.Y;

                if (second_point[0] < first_point[0] || second_point[1] < first_point[1])
                {
                    points[1] = true;

                    second_point[0] = first_point[0] + 1;
                    second_point[1] = first_point[1] + 1;
                }
                else
                {
                    //Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));

                    //Point point_001 = new Point(first_point[0], first_point[1]);
                    //Point point_002 = new Point(second_point[0], second_point[1]);

                    //PaintEventArgs paint_event_arguments = new PaintEventArgs()

                    //paint_event_arguments.Graphics.DrawLine(pen, point_001, point_002);
                }
            }
        }

        public void close_set_size_window(object sender, EventArgs e)
        {
            this.Close();
        }

        public int get_x_first_point()
        {
            return first_point[0];
        }

        public int get_x_second_point()
        {
            return second_point[0];
        }

        public int get_y_first_point()
        {
            return first_point[1];
        }

        public int get_y_second_point()
        {
            return second_point[1];
        }
    }
}
