namespace TEST
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NumCapturas = new System.Windows.Forms.TextBox();
            this.Dec_Captures = new System.Windows.Forms.Button();
            this.Inc_Captures = new System.Windows.Forms.Button();
            this.Dec_Timer = new System.Windows.Forms.Button();
            this.TempSegundos = new System.Windows.Forms.TextBox();
            this.Inc_Timer = new System.Windows.Forms.Button();
            this.Empezar = new System.Windows.Forms.Button();
            this.Detener = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Detener_Manual_CB = new System.Windows.Forms.CheckBox();
            this.Segundos_CB = new System.Windows.Forms.CheckBox();
            this.Milisegundos_CB = new System.Windows.Forms.CheckBox();
            this.Auto_Click_CB = new System.Windows.Forms.CheckBox();
            this.Set_Mouse_Coordinates_CB = new System.Windows.Forms.CheckBox();
            this.x_coordinates = new System.Windows.Forms.TextBox();
            this.y_coordinates = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.x_area_001 = new System.Windows.Forms.TextBox();
            this.y_area_001 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.x_area_002 = new System.Windows.Forms.TextBox();
            this.y_area_002 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NumCapturas
            // 
            this.NumCapturas.Location = new System.Drawing.Point(140, 14);
            this.NumCapturas.Name = "NumCapturas";
            this.NumCapturas.ReadOnly = true;
            this.NumCapturas.Size = new System.Drawing.Size(67, 20);
            this.NumCapturas.TabIndex = 1;
            this.NumCapturas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Dec_Captures
            // 
            this.Dec_Captures.Location = new System.Drawing.Point(109, 12);
            this.Dec_Captures.Name = "Dec_Captures";
            this.Dec_Captures.Size = new System.Drawing.Size(25, 23);
            this.Dec_Captures.TabIndex = 2;
            this.Dec_Captures.Text = "-";
            this.Dec_Captures.UseVisualStyleBackColor = true;
            this.Dec_Captures.Click += new System.EventHandler(this.Mod_Value);
            // 
            // Inc_Captures
            // 
            this.Inc_Captures.Location = new System.Drawing.Point(213, 14);
            this.Inc_Captures.Name = "Inc_Captures";
            this.Inc_Captures.Size = new System.Drawing.Size(25, 23);
            this.Inc_Captures.TabIndex = 2;
            this.Inc_Captures.Text = "+";
            this.Inc_Captures.UseVisualStyleBackColor = true;
            this.Inc_Captures.Click += new System.EventHandler(this.Mod_Value);
            // 
            // Dec_Timer
            // 
            this.Dec_Timer.Enabled = false;
            this.Dec_Timer.Location = new System.Drawing.Point(109, 40);
            this.Dec_Timer.Name = "Dec_Timer";
            this.Dec_Timer.Size = new System.Drawing.Size(25, 23);
            this.Dec_Timer.TabIndex = 2;
            this.Dec_Timer.Text = "-";
            this.Dec_Timer.UseVisualStyleBackColor = true;
            this.Dec_Timer.Click += new System.EventHandler(this.Mod_Value);
            // 
            // TempSegundos
            // 
            this.TempSegundos.Location = new System.Drawing.Point(140, 43);
            this.TempSegundos.Name = "TempSegundos";
            this.TempSegundos.ReadOnly = true;
            this.TempSegundos.Size = new System.Drawing.Size(67, 20);
            this.TempSegundos.TabIndex = 1;
            this.TempSegundos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Inc_Timer
            // 
            this.Inc_Timer.AccessibleName = "";
            this.Inc_Timer.Enabled = false;
            this.Inc_Timer.Location = new System.Drawing.Point(213, 40);
            this.Inc_Timer.Name = "Inc_Timer";
            this.Inc_Timer.Size = new System.Drawing.Size(25, 23);
            this.Inc_Timer.TabIndex = 2;
            this.Inc_Timer.Text = "+";
            this.Inc_Timer.UseVisualStyleBackColor = true;
            this.Inc_Timer.Click += new System.EventHandler(this.Mod_Value);
            // 
            // Empezar
            // 
            this.Empezar.Location = new System.Drawing.Point(109, 165);
            this.Empezar.Name = "Empezar";
            this.Empezar.Size = new System.Drawing.Size(75, 23);
            this.Empezar.TabIndex = 0;
            this.Empezar.Text = "Empezar";
            this.Empezar.UseVisualStyleBackColor = true;
            this.Empezar.Click += new System.EventHandler(this.Button_Start_Press);
            // 
            // Detener
            // 
            this.Detener.Location = new System.Drawing.Point(213, 165);
            this.Detener.Name = "Detener";
            this.Detener.Size = new System.Drawing.Size(75, 23);
            this.Detener.TabIndex = 0;
            this.Detener.Text = "Detener";
            this.Detener.UseVisualStyleBackColor = true;
            this.Detener.Click += new System.EventHandler(this.Button_End_Press);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad Capturas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Intervalo";
            // 
            // Detener_Manual_CB
            // 
            this.Detener_Manual_CB.AutoSize = true;
            this.Detener_Manual_CB.Location = new System.Drawing.Point(244, 18);
            this.Detener_Manual_CB.Name = "Detener_Manual_CB";
            this.Detener_Manual_CB.Size = new System.Drawing.Size(131, 17);
            this.Detener_Manual_CB.TabIndex = 4;
            this.Detener_Manual_CB.Text = "Detener Manualmente";
            this.Detener_Manual_CB.UseVisualStyleBackColor = true;
            this.Detener_Manual_CB.Click += new System.EventHandler(this.Check_Box);
            // 
            // Segundos_CB
            // 
            this.Segundos_CB.AutoSize = true;
            this.Segundos_CB.Enabled = false;
            this.Segundos_CB.Location = new System.Drawing.Point(244, 43);
            this.Segundos_CB.Name = "Segundos_CB";
            this.Segundos_CB.Size = new System.Drawing.Size(74, 17);
            this.Segundos_CB.TabIndex = 4;
            this.Segundos_CB.Text = "Segundos";
            this.Segundos_CB.UseVisualStyleBackColor = true;
            this.Segundos_CB.Click += new System.EventHandler(this.Check_Box);
            // 
            // Milisegundos_CB
            // 
            this.Milisegundos_CB.AutoSize = true;
            this.Milisegundos_CB.Enabled = false;
            this.Milisegundos_CB.Location = new System.Drawing.Point(324, 43);
            this.Milisegundos_CB.Name = "Milisegundos_CB";
            this.Milisegundos_CB.Size = new System.Drawing.Size(87, 17);
            this.Milisegundos_CB.TabIndex = 4;
            this.Milisegundos_CB.Text = "Milisegundos";
            this.Milisegundos_CB.UseVisualStyleBackColor = true;
            this.Milisegundos_CB.Click += new System.EventHandler(this.Check_Box);
            // 
            // Auto_Click_CB
            // 
            this.Auto_Click_CB.AutoSize = true;
            this.Auto_Click_CB.Enabled = false;
            this.Auto_Click_CB.Location = new System.Drawing.Point(12, 106);
            this.Auto_Click_CB.Name = "Auto_Click_CB";
            this.Auto_Click_CB.Size = new System.Drawing.Size(74, 17);
            this.Auto_Click_CB.TabIndex = 5;
            this.Auto_Click_CB.Text = "Auto-Click";
            this.Auto_Click_CB.UseVisualStyleBackColor = true;
            this.Auto_Click_CB.Click += new System.EventHandler(this.Check_Box);
            // 
            // Set_Mouse_Coordinates_CB
            // 
            this.Set_Mouse_Coordinates_CB.AutoSize = true;
            this.Set_Mouse_Coordinates_CB.Enabled = false;
            this.Set_Mouse_Coordinates_CB.Location = new System.Drawing.Point(12, 129);
            this.Set_Mouse_Coordinates_CB.Name = "Set_Mouse_Coordinates_CB";
            this.Set_Mouse_Coordinates_CB.Size = new System.Drawing.Size(142, 17);
            this.Set_Mouse_Coordinates_CB.TabIndex = 6;
            this.Set_Mouse_Coordinates_CB.Text = "Establecer Coordenadas";
            this.Set_Mouse_Coordinates_CB.UseVisualStyleBackColor = true;
            this.Set_Mouse_Coordinates_CB.Click += new System.EventHandler(this.Check_Box);
            // 
            // x_coordinates
            // 
            this.x_coordinates.Enabled = false;
            this.x_coordinates.Location = new System.Drawing.Point(173, 127);
            this.x_coordinates.Name = "x_coordinates";
            this.x_coordinates.ReadOnly = true;
            this.x_coordinates.Size = new System.Drawing.Size(52, 20);
            this.x_coordinates.TabIndex = 7;
            this.x_coordinates.Text = "0";
            // 
            // y_coordinates
            // 
            this.y_coordinates.Enabled = false;
            this.y_coordinates.Location = new System.Drawing.Point(251, 127);
            this.y_coordinates.Name = "y_coordinates";
            this.y_coordinates.ReadOnly = true;
            this.y_coordinates.Size = new System.Drawing.Size(52, 20);
            this.y_coordinates.TabIndex = 7;
            this.y_coordinates.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Y";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Definir Area";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Define_Area);
            // 
            // x_area_001
            // 
            this.x_area_001.Enabled = false;
            this.x_area_001.Location = new System.Drawing.Point(113, 76);
            this.x_area_001.Name = "x_area_001";
            this.x_area_001.ReadOnly = true;
            this.x_area_001.Size = new System.Drawing.Size(52, 20);
            this.x_area_001.TabIndex = 7;
            this.x_area_001.Text = "0";
            // 
            // y_area_001
            // 
            this.y_area_001.Enabled = false;
            this.y_area_001.Location = new System.Drawing.Point(191, 76);
            this.y_area_001.Name = "y_area_001";
            this.y_area_001.ReadOnly = true;
            this.y_area_001.Size = new System.Drawing.Size(52, 20);
            this.y_area_001.TabIndex = 7;
            this.y_area_001.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "X1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Y1";
            // 
            // x_area_002
            // 
            this.x_area_002.Enabled = false;
            this.x_area_002.Location = new System.Drawing.Point(274, 77);
            this.x_area_002.Name = "x_area_002";
            this.x_area_002.ReadOnly = true;
            this.x_area_002.Size = new System.Drawing.Size(52, 20);
            this.x_area_002.TabIndex = 7;
            this.x_area_002.Text = "0";
            // 
            // y_area_002
            // 
            this.y_area_002.Enabled = false;
            this.y_area_002.Location = new System.Drawing.Point(352, 77);
            this.y_area_002.Name = "y_area_002";
            this.y_area_002.ReadOnly = true;
            this.y_area_002.Size = new System.Drawing.Size(52, 20);
            this.y_area_002.TabIndex = 7;
            this.y_area_002.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "X2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Y2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 200);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.y_area_002);
            this.Controls.Add(this.y_area_001);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.x_area_002);
            this.Controls.Add(this.x_area_001);
            this.Controls.Add(this.y_coordinates);
            this.Controls.Add(this.x_coordinates);
            this.Controls.Add(this.Set_Mouse_Coordinates_CB);
            this.Controls.Add(this.Auto_Click_CB);
            this.Controls.Add(this.Milisegundos_CB);
            this.Controls.Add(this.Segundos_CB);
            this.Controls.Add(this.Detener_Manual_CB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Inc_Timer);
            this.Controls.Add(this.Inc_Captures);
            this.Controls.Add(this.Dec_Timer);
            this.Controls.Add(this.Dec_Captures);
            this.Controls.Add(this.TempSegundos);
            this.Controls.Add(this.NumCapturas);
            this.Controls.Add(this.Detener);
            this.Controls.Add(this.Empezar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Auto Screen Capture";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NumCapturas;
        private System.Windows.Forms.Button Dec_Captures;
        private System.Windows.Forms.Button Inc_Captures;
        private System.Windows.Forms.Button Dec_Timer;
        private System.Windows.Forms.TextBox TempSegundos;
        private System.Windows.Forms.Button Inc_Timer;
        private System.Windows.Forms.Button Empezar;
        private System.Windows.Forms.Button Detener;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Detener_Manual_CB;
        private System.Windows.Forms.CheckBox Segundos_CB;
        private System.Windows.Forms.CheckBox Milisegundos_CB;
        private System.Windows.Forms.CheckBox Auto_Click_CB;
        private System.Windows.Forms.CheckBox Set_Mouse_Coordinates_CB;
        private System.Windows.Forms.TextBox x_coordinates;
        private System.Windows.Forms.TextBox y_coordinates;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox x_area_001;
        private System.Windows.Forms.TextBox y_area_001;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox x_area_002;
        private System.Windows.Forms.TextBox y_area_002;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

