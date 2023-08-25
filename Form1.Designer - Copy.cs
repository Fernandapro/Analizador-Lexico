namespace Compiladoresclase
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
            this.Entrada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.salida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Limpiarentrada = new System.Windows.Forms.Button();
            this.Limpiarsalida = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cargardirectorio = new System.Windows.Forms.Button();
            this.Directorio = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Entrada
            // 
            this.Entrada.BackColor = System.Drawing.SystemColors.Control;
            this.Entrada.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entrada.Location = new System.Drawing.Point(52, 36);
            this.Entrada.Multiline = true;
            this.Entrada.Name = "Entrada";
            this.Entrada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Entrada.Size = new System.Drawing.Size(365, 257);
            this.Entrada.TabIndex = 0;
            this.Entrada.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(130, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Programa de entrada";
            // 
            // salida
            // 
            this.salida.BackColor = System.Drawing.SystemColors.Control;
            this.salida.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.salida.Location = new System.Drawing.Point(473, 37);
            this.salida.Multiline = true;
            this.salida.Name = "salida";
            this.salida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.salida.Size = new System.Drawing.Size(352, 289);
            this.salida.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(615, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resultado";
            // 
            // Limpiarentrada
            // 
            this.Limpiarentrada.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Limpiarentrada.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpiarentrada.Location = new System.Drawing.Point(146, 299);
            this.Limpiarentrada.Name = "Limpiarentrada";
            this.Limpiarentrada.Size = new System.Drawing.Size(150, 27);
            this.Limpiarentrada.TabIndex = 2;
            this.Limpiarentrada.Text = "Limpiar entrada";
            this.Limpiarentrada.UseVisualStyleBackColor = false;
            this.Limpiarentrada.Click += new System.EventHandler(this.Limpiarentrada_Click);
            // 
            // Limpiarsalida
            // 
            this.Limpiarsalida.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Limpiarsalida.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpiarsalida.Location = new System.Drawing.Point(589, 332);
            this.Limpiarsalida.Name = "Limpiarsalida";
            this.Limpiarsalida.Size = new System.Drawing.Size(138, 29);
            this.Limpiarsalida.TabIndex = 5;
            this.Limpiarsalida.Text = "limpiar salida ";
            this.Limpiarsalida.UseVisualStyleBackColor = false;
            this.Limpiarsalida.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button3.Location = new System.Drawing.Point(52, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 24);
            this.button3.TabIndex = 6;
            this.button3.Text = "Cargar archivo";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Cargararchivo);
            // 
            // cargardirectorio
            // 
            this.cargardirectorio.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cargardirectorio.Location = new System.Drawing.Point(52, 379);
            this.cargardirectorio.Name = "cargardirectorio";
            this.cargardirectorio.Size = new System.Drawing.Size(98, 24);
            this.cargardirectorio.TabIndex = 7;
            this.cargardirectorio.Text = "cargar directorio";
            this.cargardirectorio.UseVisualStyleBackColor = false;
            this.cargardirectorio.Click += new System.EventHandler(this.cargardirectorio_Click);
            // 
            // Directorio
            // 
            this.Directorio.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Location = new System.Drawing.Point(52, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 24);
            this.button1.TabIndex = 8;
            this.button1.Text = "analisis lexico";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkGray;
            this.button4.Location = new System.Drawing.Point(159, 350);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "flujo de caracteres";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.Location = new System.Drawing.Point(159, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "linea y columna";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkGray;
            this.button5.Location = new System.Drawing.Point(304, 350);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "tokens";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cargardirectorio);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Limpiarsalida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salida);
            this.Controls.Add(this.Limpiarentrada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Entrada);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "USPG compiladores A 1900126";
            this.TransparencyKey = System.Drawing.Color.FloralWhite;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Entrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Limpiarentrada;
        private System.Windows.Forms.TextBox salida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Limpiarsalida;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button cargardirectorio;
        private System.Windows.Forms.OpenFileDialog Directorio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
    }
}

