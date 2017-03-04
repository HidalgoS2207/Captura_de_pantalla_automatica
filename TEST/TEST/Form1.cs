using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

public struct __tagMOUSEINPUT
{
    public uint dx;
    public uint dy;
    public uint mouseData;
    public uint dwFlags;
    public uint time;
    unsafe public uint* dwExtraInfo;
}

public struct __tagINPUT
{
    public uint mode;
    public __tagMOUSEINPUT t_mouse;
}

namespace TEST
{
    public partial class Form1 : Form
    {
        int counter;
        bool exit = true;
        string prefix = "0000";
        int capturasCounter = 0;
        Thread ScreenShotThread;

        double timer_last_value = 250;
        int capturas_last_value = 1;

        int x_coord = 0;
        int y_coord = 0;

        bool area_defined = false;

        [DllImport("user32.dll")]
        static extern int GetSystemMetrics(int value);

        int[] area_coord_001 = { 0, 0 };
        int[] area_coord_002 = { GetSystemMetrics(0), GetSystemMetrics(1) };

        __tagINPUT mouse_input;

        [DllImport("User32.dll")]
        unsafe private static extern uint SendInput(uint nInputs, __tagINPUT* mInput_p, int cbSize);
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);


        public Form1()
        {
            InitializeComponent();

            NumCapturas.Text = "1";
            TempSegundos.Text = "-";

            ScreenShotThread = new Thread(new ThreadStart(ScreenShotThreadStart));

            Milisegundos_CB.Checked = true;

            Detener_Manual_CB.Enabled = false;

            Empezar.Text = "Capturar";
            Detener.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {}

        private void Button_End_Press(object sender, EventArgs e)
        {
            exit = true;
            counter = 0;
            capturasCounter = 0;

            if(ScreenShotThread.IsAlive)
            {
                ScreenShotThread.Abort();
            }
        }

        private void Button_Start_Press(object sender, EventArgs e)
        {
            exit = false;
            counter = 0;
            
            if(ScreenShotThread.ThreadState == System.Threading.ThreadState.Stopped)
            {
                ScreenShotThread = new Thread(new ThreadStart(ScreenShotThreadStart));
            }

            ScreenShotThread.Start();
        }

        private void ScreenShotThreadStart()
        {
            if(Detener_Manual_CB.Checked)
            {
                NumCapturas.Text = "1000000";
            }

            capturasCounter = 0;
            counter = 0;

            if(Convert.ToInt32(NumCapturas.Text) != 1)
            {
                while (capturasCounter < Convert.ToInt32(NumCapturas.Text) + 1)
                {
                    if (!exit)
                    {
                        capturasCounter++;

                        if (capturasCounter == Convert.ToInt32(NumCapturas.Text) + 1)
                        {
                            exit = true;
                        }
                        else
                        {
                            int bitmap_x_size = 0;
                            int bitmap_y_size = 0;

                            int x_source = 0;
                            int y_source = 0;

                            if(!area_defined)
                            {
                                bitmap_x_size = Screen.PrimaryScreen.Bounds.Width;
                                bitmap_y_size = Screen.PrimaryScreen.Bounds.Height;

                                x_source = Screen.PrimaryScreen.Bounds.X;
                                y_source = Screen.PrimaryScreen.Bounds.Y;
                            }
                            else
                            {
                                bitmap_x_size = area_coord_002[0] - area_coord_001[0];
                                bitmap_y_size = area_coord_002[1] - area_coord_001[1];

                                x_source = area_coord_001[0];
                                y_source = area_coord_001[1];
                            }

                            Size capture_size = new Size(bitmap_x_size, bitmap_y_size);

                            Bitmap bmpCapture = new Bitmap(bitmap_x_size, bitmap_y_size);
                            Graphics gfxCaptura = Graphics.FromImage(bmpCapture);

                            //gfxCaptura.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size);
                            gfxCaptura.CopyFromScreen(x_source,y_source , 0, 0, capture_size);

                            counter++;

                            if (counter < 10)
                            {
                                prefix = "000";
                            }
                            else if (counter >= 10 && counter < 100)
                            {
                                prefix = "00";
                            }
                            else if (counter >= 100 && counter < 1000)
                            {
                                prefix = "0";
                            }

                            string nombre = "screenshot" + prefix + Convert.ToString(counter) + ".png";

                            bmpCapture.Save(nombre);
                        }
                    }
                    else
                    {
                        ScreenShotThread.Abort();
                    }

                    if (ScreenShotThread.IsAlive)
                    {
                        if(Auto_Click_CB.Checked) unsafe 
                        {
                                mouse_input.t_mouse.dx = (uint)(x_coord);
                                mouse_input.t_mouse.dy = (uint)(y_coord);
                                mouse_input.t_mouse.mouseData = 0x00;
                                mouse_input.t_mouse.dwFlags = 0x0002 | 0x0004;
                                mouse_input.t_mouse.time = 0;

                                mouse_input.mode = 0x00;

                                fixed (__tagINPUT* t_input = &mouse_input)
                                {
                                    SetCursorPos((int)mouse_input.t_mouse.dx, (int)mouse_input.t_mouse.dy);

                                    SendInput(1, t_input, sizeof(__tagINPUT));
                                }
                            }

                        if (Milisegundos_CB.Checked)
                        {
                            Thread.Sleep(Convert.ToInt32(TempSegundos.Text));
                        }
                        else
                        {
                            Thread.Sleep(Convert.ToInt32(Convert.ToDouble(TempSegundos.Text) * 1000));
                        }
                    }
                } //fin while principal
            }
            else
            {
                Bitmap bmpCapture = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                Graphics gfxCaptura = Graphics.FromImage(bmpCapture);

                gfxCaptura.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size);

                bmpCapture.Save("Captura.png");
            }

        }

        private void Mod_Value(object sender, EventArgs e)
        {
            Button butt = (Button)sender;

            if (!ScreenShotThread.IsAlive)
            {
                switch (butt.Name)
                {
                    case "Inc_Captures":
                        NumCapturas.Text = Convert.ToString((Convert.ToInt32(NumCapturas.Text)) + 1);

                        if(Convert.ToInt32(NumCapturas.Text) == 2)
                        {
                            Empezar.Text = "Comenzar";
                            Detener.Enabled = true;

                            Auto_Click_CB.Enabled = true;
                        }

                        if(!Inc_Timer.Enabled)
                        {
                            Inc_Timer.Enabled = true;
                            Dec_Timer.Enabled = true;

                            Segundos_CB.Enabled = true;
                            Milisegundos_CB.Enabled = true;

                            Detener_Manual_CB.Enabled = true;

                            TempSegundos.Text = Convert.ToString(timer_last_value);
                        }
                        break;
                    case "Dec_Captures":
                        if (Convert.ToInt32(NumCapturas.Text) >= 2)
                        {
                            NumCapturas.Text = Convert.ToString((Convert.ToInt32(NumCapturas.Text)) - 1);
                        }

                        if(Convert.ToInt32(NumCapturas.Text) == 1 && TempSegundos.Text != "-")
                        {
                            Inc_Timer.Enabled = false;
                            Dec_Timer.Enabled = false;

                            Segundos_CB.Enabled = false;
                            Milisegundos_CB.Enabled = false;

                            Detener_Manual_CB.Enabled = false;

                            timer_last_value = Convert.ToDouble(TempSegundos.Text);

                            TempSegundos.Text = "-";

                            Empezar.Text = "Capturar";
                            Detener.Enabled = false;

                            Auto_Click_CB.Enabled = false;
                        }
                        break;
                    case "Inc_Timer":
                        if(Milisegundos_CB.Checked)
                        {
                            TempSegundos.Text = Convert.ToString((Convert.ToInt32(TempSegundos.Text)) + 250);
                        }
                        else
                        {
                            TempSegundos.Text = Convert.ToString((Convert.ToDouble(TempSegundos.Text)) + 1);
                        }
                        
                        break;
                    case "Dec_Timer":
                        if(Milisegundos_CB.Checked)
                        {
                            if (Convert.ToInt32(TempSegundos.Text) >= 500)
                            {
                                TempSegundos.Text = Convert.ToString((Convert.ToInt32(TempSegundos.Text)) - 250);
                            }
                        }
                        else
                        {
                            if (Convert.ToDouble(TempSegundos.Text) >= 2)
                            {
                                TempSegundos.Text = Convert.ToString((Convert.ToDouble(TempSegundos.Text)) - 1);
                            }
                            else if(Convert.ToDouble(TempSegundos.Text) > 0.25)
                            {
                                Milisegundos_CB.Checked = !(Milisegundos_CB.Checked);
                                Segundos_CB.Checked = !(Segundos_CB.Checked);

                                TempSegundos.Text = Convert.ToString(Convert.ToDouble(TempSegundos.Text) * 1000);
                            }
                        }

                        break;
                    case "Reset_Timer":
                        TempSegundos.Text = "1";
                        break;
                }
            }
        }

        private void Check_Box(object sender, EventArgs e)
        {
            CheckBox CB = ((CheckBox )sender);

            switch(CB.Name)
            {
                case "Detener_Manual_CB":
                        NumCapturas.Enabled = !NumCapturas.Enabled;

                        if (!NumCapturas.Enabled)
                        {
                            capturas_last_value = Convert.ToInt32(NumCapturas.Text);
                            NumCapturas.Text = "-";

                            Inc_Captures.Enabled = !Inc_Captures.Enabled;
                            Dec_Captures.Enabled = !Dec_Captures.Enabled;
                        }
                        else
                        {
                            NumCapturas.Text = Convert.ToString(capturas_last_value);

                            Inc_Captures.Enabled = !Inc_Captures.Enabled;
                            Dec_Captures.Enabled = !Dec_Captures.Enabled;    
                        }
                    break;
                case "Segundos_CB":
                    if(Segundos_CB.Checked)
                    {
                        TempSegundos.Text = Convert.ToString(Convert.ToDouble(TempSegundos.Text) / 1000);
                    }
                    else
                    {
                        TempSegundos.Text = Convert.ToString(Convert.ToDouble(TempSegundos.Text) * 1000);
                    }
                    

                    Milisegundos_CB.Checked = !(Milisegundos_CB.Checked);
                    break;
                case "Milisegundos_CB":
                    if(Milisegundos_CB.Checked)
                    {
                        TempSegundos.Text = Convert.ToString(Convert.ToDouble(TempSegundos.Text) * 1000);
                    }
                    else
                    {
                        TempSegundos.Text = Convert.ToString(Convert.ToDouble(TempSegundos.Text) / 1000);
                    }
                    

                    Segundos_CB.Checked = !(Segundos_CB.Checked);
                    break;
                case "Auto_Click_CB":
                    if(Auto_Click_CB.Checked)
                    {
                        Set_Mouse_Coordinates_CB.Enabled = true;
                    }
                    else
                    {
                        Set_Mouse_Coordinates_CB.Enabled = false;

                        if (Set_Mouse_Coordinates_CB.Checked)
                        {
                            Set_Mouse_Coordinates_CB.Checked = false;
                        }

                        x_coord = 0;
                        y_coord = 0;

                        x_coordinates.Text = "0";
                        y_coordinates.Text = "0";
                    }
                    break;
                case "Set_Mouse_Coordinates_CB":
                    if(Set_Mouse_Coordinates_CB.Checked)
                    {
                        Form2 form2 = new Form2();
                        form2.ShowDialog();

                        x_coord = form2.get_x();
                        y_coord = form2.get_y();

                        x_coordinates.Text = Convert.ToString(x_coord);
                        y_coordinates.Text = Convert.ToString(y_coord);

                        Set_Mouse_Coordinates_CB.Enabled = false;
                    }
                    break;
            }
        }

        private void Define_Area(object sender, EventArgs e)
        {
            area_defined = true;

            Form3 form3 = new Form3();
            form3.ShowDialog();

            area_coord_001[0] = form3.get_x_first_point();
            area_coord_001[1] = form3.get_y_first_point();

            area_coord_002[0] = form3.get_x_second_point();
            area_coord_002[1] = form3.get_y_second_point();

            x_area_001.Text = Convert.ToString(area_coord_001[0]);
            y_area_001.Text = Convert.ToString(area_coord_001[1]);

            x_area_002.Text = Convert.ToString(area_coord_002[0]);
            y_area_002.Text = Convert.ToString(area_coord_002[1]);
        }
    }
}
