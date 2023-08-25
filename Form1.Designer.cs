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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Limpiarentrada = new System.Windows.Forms.Button();
			this.Limpiarsalida = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.cargardirectorio = new System.Windows.Forms.Button();
			this.Directorio = new System.Windows.Forms.OpenFileDialog();
			this.button1 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btn_tokens = new System.Windows.Forms.Button();
			this.Entrada = new System.Windows.Forms.RichTextBox();
			this.salida = new System.Windows.Forms.RichTextBox();
			this.rtxt_errors = new System.Windows.Forms.RichTextBox();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(150, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(166, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "Programa de entrada";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(626, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 19);
			this.label2.TabIndex = 4;
			this.label2.Text = "Resultado";
			// 
			// Limpiarentrada
			// 
			this.Limpiarentrada.BackColor = System.Drawing.Color.Yellow;
			this.Limpiarentrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Limpiarentrada.Location = new System.Drawing.Point(153, 57);
			this.Limpiarentrada.Name = "Limpiarentrada";
			this.Limpiarentrada.Size = new System.Drawing.Size(167, 47);
			this.Limpiarentrada.TabIndex = 2;
			this.Limpiarentrada.Text = "Limpiar entrada";
			this.Limpiarentrada.UseVisualStyleBackColor = false;
			this.Limpiarentrada.Click += new System.EventHandler(this.Limpiarentrada_Click);
			// 
			// Limpiarsalida
			// 
			this.Limpiarsalida.BackColor = System.Drawing.Color.Yellow;
			this.Limpiarsalida.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Limpiarsalida.ForeColor = System.Drawing.Color.Black;
			this.Limpiarsalida.Location = new System.Drawing.Point(601, 50);
			this.Limpiarsalida.Name = "Limpiarsalida";
			this.Limpiarsalida.Size = new System.Drawing.Size(144, 54);
			this.Limpiarsalida.TabIndex = 5;
			this.Limpiarsalida.Text = "limpiar salida ";
			this.Limpiarsalida.UseVisualStyleBackColor = false;
			this.Limpiarsalida.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.DodgerBlue;
			this.button3.Location = new System.Drawing.Point(618, 386);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(118, 42);
			this.button3.TabIndex = 6;
			this.button3.Text = "Cargar archivo";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Cargararchivo);
			// 
			// cargardirectorio
			// 
			this.cargardirectorio.BackColor = System.Drawing.Color.Orchid;
			this.cargardirectorio.Location = new System.Drawing.Point(618, 333);
			this.cargardirectorio.Name = "cargardirectorio";
			this.cargardirectorio.Size = new System.Drawing.Size(118, 47);
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
			this.button1.BackColor = System.Drawing.Color.Fuchsia;
			this.button1.Location = new System.Drawing.Point(479, 333);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(121, 47);
			this.button1.TabIndex = 8;
			this.button1.Text = "analisis lexico";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Blue;
			this.button4.Location = new System.Drawing.Point(479, 386);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(121, 42);
			this.button4.TabIndex = 10;
			this.button4.Text = "flujo de caracteres";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.MediumPurple;
			this.button2.Location = new System.Drawing.Point(479, 434);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(121, 40);
			this.button2.TabIndex = 11;
			this.button2.Text = "linea y columna";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// btn_tokens
			// 
			this.btn_tokens.BackColor = System.Drawing.Color.Violet;
			this.btn_tokens.Location = new System.Drawing.Point(742, 333);
			this.btn_tokens.Name = "btn_tokens";
			this.btn_tokens.Size = new System.Drawing.Size(117, 47);
			this.btn_tokens.TabIndex = 12;
			this.btn_tokens.Text = "tokens";
			this.btn_tokens.UseVisualStyleBackColor = false;
			this.btn_tokens.Click += new System.EventHandler(this.button5_Click);
			// 
			// Entrada
			// 
			this.Entrada.BackColor = System.Drawing.Color.RoyalBlue;
			this.Entrada.ForeColor = System.Drawing.Color.White;
			this.Entrada.Location = new System.Drawing.Point(29, 110);
			this.Entrada.Name = "Entrada";
			this.Entrada.Size = new System.Drawing.Size(427, 364);
			this.Entrada.TabIndex = 13;
			this.Entrada.Text = "";
			this.Entrada.TextChanged += new System.EventHandler(this.Entrada_TextChanged);
			// 
			// salida
			// 
			this.salida.BackColor = System.Drawing.Color.DarkBlue;
			this.salida.ForeColor = System.Drawing.Color.White;
			this.salida.Location = new System.Drawing.Point(478, 110);
			this.salida.Name = "salida";
			this.salida.Size = new System.Drawing.Size(380, 134);
			this.salida.TabIndex = 14;
			this.salida.Text = "";
			this.salida.TextChanged += new System.EventHandler(this.salida_TextChanged);
			// 
			// rtxt_errors
			// 
			this.rtxt_errors.BackColor = System.Drawing.Color.RoyalBlue;
			this.rtxt_errors.ForeColor = System.Drawing.Color.Yellow;
			this.rtxt_errors.Location = new System.Drawing.Point(479, 264);
			this.rtxt_errors.Name = "rtxt_errors";
			this.rtxt_errors.Size = new System.Drawing.Size(380, 63);
			this.rtxt_errors.TabIndex = 15;
			this.rtxt_errors.Text = "";
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.BlueViolet;
			this.button6.Location = new System.Drawing.Point(742, 386);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(116, 42);
			this.button6.TabIndex = 17;
			this.button6.Text = "Tabla tokens";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.Blue;
			this.button7.Location = new System.Drawing.Point(742, 434);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(117, 40);
			this.button7.TabIndex = 19;
			this.button7.Text = "Guardar en tabla";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Blue;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(952, 529);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.rtxt_errors);
			this.Controls.Add(this.salida);
			this.Controls.Add(this.Entrada);
			this.Controls.Add(this.btn_tokens);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.cargardirectorio);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.Limpiarsalida);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Limpiarentrada);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Name = "Form1";
			this.Text = "USPG compiladores A 1900126";
			this.TransparencyKey = System.Drawing.Color.FloralWhite;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Limpiarentrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Limpiarsalida;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button cargardirectorio;
        private System.Windows.Forms.OpenFileDialog Directorio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_tokens;
        private System.Windows.Forms.RichTextBox Entrada;
        private System.Windows.Forms.RichTextBox salida;
        private System.Windows.Forms.RichTextBox rtxt_errors;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

