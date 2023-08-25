
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Compiladoresclase
   
    
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

   
     

        private void button2_Click(object sender, EventArgs e)
        {
            salida.Text = " ";
             }

    private void Cargararchivo(object sender, EventArgs e)
        {
            Entrada.Text = File.ReadAllText("C:/Users/RAGUEX/Desktop/Prueba.Compiladores.txt");
        }

        private void cargardirectorio_Click(object sender, EventArgs e)
        {
            Directorio.Filter = ("Archivos de texto | * .txt");
            Directorio.ShowDialog();
            Entrada.Text = File.ReadAllText(Directorio.FileName); 

        }

        private void Limpiarentrada_Click(object sender, EventArgs e)
        {
            Entrada.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            salida.Text = Entrada.Text;
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (char car in Entrada.Text)
            {
                //fin de linea

                if (car == '\r')
                    salida.Text = salida.Text + " \t (Fin de Linea ) \t   " + Environment.NewLine;
                else
                //tabulador
              if (car == '\t')
                    salida.Text = salida.Text + "\t  (Tabulador) " + Environment.NewLine;
                else
                //espacio
                 if (car == ' ')
                    salida.Text = salida.Text + "\t (Espacio) " + Environment.NewLine;
                else
                //salto de linea
                if (car == '\n')
                    salida.Text = salida.Text + "\t (salto de linea ) " + Environment.NewLine;
                else
                    salida.Text = salida.Text + car.ToString() + Environment.NewLine;


            }
        }

     
        private void button2_Click_1(object sender, EventArgs e)
        {
            int linea;
            int columna;
            linea = 1;
            columna = 0;
          foreach (char car in Entrada.Text)
            {

                //utilizando un if 
                if (car == ' ')

                    //Para el espacio en blanco 
                {
                    columna = columna + 1;
                    salida.Text = salida.Text + " \t( ESPACIO EN BLANCO ) " + Environment.NewLine;
                }

                // para tabulador
                else if (car == '\t')
                {
                    columna = columna + 1;
                    salida.Text = salida.Text + " \t( TABULADOR Chr)" + Environment.NewLine;
                }
                //para fin de linea
                else if (car == '\r')
                {
                    columna = columna + 1;
                    salida.Text = salida.Text + " \t ( FIN DE LINEA CHR)" + Environment.NewLine;
                }

          //para salto de linea
                else if (car == '\n')
                {
                    columna = columna + 1;
                    salida.Text = salida.Text + "  \t( SALTO DE LINEA CHR )" + Environment.NewLine;
                    linea = linea + 1;
                    columna = 0;
                    //linea y columna 
                }
                else
                {
                    columna = columna + 1  ;
                    salida.Text = salida.Text + car.ToString() + "\t LINEA " + linea.ToString() + "\t COLUMNA " + columna.ToString() + Environment.NewLine;
                }


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
    }


  

