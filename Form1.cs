
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
using System.Text.RegularExpressions;
using System.Data.OleDb;


namespace Compiladoresclase
{
    public partial class Form1 : Form
    {

        static List<Token> tokens_pr = new List<Token>();
        static List<Token> tokens_op = new List<Token>();
        static List<Token> tokens_sp = new List<Token>();
        OleDbConnection conexion;
        static List<Token> tokens_Error = new List<Token>();

        public object MensageBox { get; private set; }

        public bool ExisteTokenOp(string token)
        {
            foreach (Token tk in tokens_op)
            {
                if (tk.str_token.Equals(token))
                {
                    return true;
                }
            }

            foreach (Token tk in tokens_sp)
            {
                if (tk.str_token.Equals(token))
                {
                    return true;
                }
            }
            return false;
        }

        public Form1()
        {
            InitializeComponent();

            conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\palabrasClave.accdb");

            tokens_pr.Add(new Token("Main", "Palabra Reservada"));
            tokens_pr.Add(new Token("Dim", "Palabra Reservada"));
            tokens_pr.Add(new Token("As", "Palabra Reservada"));
            tokens_pr.Add(new Token("Integer", "Palabra Reservada"));
            tokens_pr.Add(new Token("Decimal", "Palabra Reservada"));
            tokens_pr.Add(new Token("String", "Palabra Reservada"));
            tokens_pr.Add(new Token("If", "Palabra Reservada"));
            tokens_pr.Add(new Token("Then", "Palabra Reservada"));
            tokens_pr.Add(new Token("Else", "Palabra Reservada"));

            tokens_op.Add(new Token(":=", "Operador Asignación"));
            tokens_op.Add(new Token(">", "Operador Mayor que"));
            tokens_op.Add(new Token("<", "Operador Menor que"));
            tokens_op.Add(new Token("<>", "Operador Diferente"));
            tokens_op.Add(new Token("=", "Operador Igual"));
            tokens_op.Add(new Token("==", "Operador comparación Igual"));
            tokens_op.Add(new Token("+", "Operador Mas"));
            tokens_op.Add(new Token("-", "Operador Menos"));
            tokens_op.Add(new Token("*", "Operador Multiplicación"));
            tokens_op.Add(new Token("/", "Operador División"));
            tokens_op.Add(new Token("&&", "Operador And Conjunción"));
            tokens_op.Add(new Token("||", "Operador Or Disyunción"));
            tokens_op.Add(new Token("?", "Operador Pregunta"));


            tokens_sp.Add(new Token("(", "Signo de puntuación paréntesis abre"));
            tokens_sp.Add(new Token(")", "Signo de puntuación paréntesis cierra"));
            tokens_sp.Add(new Token("{", "Signo de puntuación llave abre"));
            tokens_sp.Add(new Token("}", "Signo de puntuación llave cierra"));
            tokens_sp.Add(new Token(";", "Signo de puntuación punto y coma"));
            tokens_sp.Add(new Token(".", "Signo de puntuación punto"));
            tokens_sp.Add(new Token(",", "Signo de puntuación coma"));
            tokens_sp.Add(new Token("\"", "Signo de puntuación comillas dobles"));
            tokens_sp.Add(new Token("/*", "Signo de puntuación inicia comentario"));
            tokens_sp.Add(new Token("*/", "Signo de puntuación termina comentario"));


            for (int i = 33; i < 48; i++)
            {
                if (!ExisteTokenOp(((char)i).ToString()))
                {
                    tokens_Error.Add(new Token(((char)i).ToString(), "Error de Operador"));
                }
            }

            for (int i = 58; i < 65; i++)
            {
                if (!ExisteTokenOp(((char)i).ToString()))
                {
                    tokens_Error.Add(new Token(((char)i).ToString(), "Error de Operador"));
                }
            }

            for (int i = 91; i < 96; i++)
            {
                if (!ExisteTokenOp(((char)i).ToString()))
                {
                    tokens_Error.Add(new Token(((char)i).ToString(), "Error de Operador"));
                }
            }

            for (int i = 123; i < 255; i++)
            {
                if (!ExisteTokenOp(((char)i).ToString()))
                {
                    tokens_Error.Add(new Token(((char)i).ToString(), "Error de Operador"));
                }
            }


            /*tokens_op.Add(new Token("$", "Error de Operador"));
            tokens_op.Add(new Token("%", "Error de Operador"));
            tokens_op.Add(new Token("#", "Error de Operador"));
            tokens_op.Add(new Token("|", "Error de Operador"));
            tokens_op.Add(new Token("&", "Error de Operador"));*/
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
                    columna = columna + 1;
                    salida.Text = salida.Text + car.ToString() + "\t LINEA " + linea.ToString() + "\t COLUMNA " + columna.ToString() + Environment.NewLine;
                }


            }
        }
        public static string DevolverTipo(string parame)
        {
            //MessageBox.Show(">" + parame + "<");
            string Respuesta = "";
            int SegundaValidacion = 0;
            switch (parame)
            {
                case ";":
                case "(":
                case ")":
                case "{":
                case "}":
                case ".":
                case ",":
                case "'":
                case "\"":
                case "*/":
                case "/*":
                    {
                        Respuesta = " ,Signos de puntuacion";
                        break;
                    }
                case "Main":
                case "Dim":
                case "As":
                case "Integer":
                case "Decimal":
                case "String":
                case "If":
                case "Then":
                case "Else":
                case "Integer\n":
                case "MostrarString":
                    {
                        Respuesta = " ,Palabras Reservadas";
                        break;

                    }

                case ":=":
                case ">":
                case "<":
                case "<>":
                case "=":
                case "+":
                case "-":
                case "*":
                case "/":
                case "&&":
                case "||":
                    {
                        Respuesta = " ,Operadores";
                        break;



                    }
                case "Variable1":
                case "Variable2":
                case "Variable3":
                case "Variable4":
                case "var1":
                case "var2":
                case "var3":
                case "Var1":
                case "Var2":
                case "Var3":
                    {

                        Respuesta = " ,Identificador";
                        break;
                    }

                default:
                    {

                        //Respuesta = " ,Error o Palabra No Reconocida";
                        Respuesta = " ,Identificador";
                        SegundaValidacion = 1;

                        break;
                    }



            }
            if (SegundaValidacion == 1)
            {
                //revisar si es un numero
                int i = 0;
                string s = parame;
                bool result = int.TryParse(s, out i); //i now = 108  


                if (result == true)
                {
                    Respuesta = " ,Es un numero";


                }


            }
            return Respuesta;
        }


        /*------------------ CODIGO AGREGADO -----------------------*/
        private bool ExisteUnOperador(string token)
        {
            foreach (Token tk in tokens_op)
            {
                if (tk.str_token.Equals(token))
                {
                    return true;
                }
            }
            return false;
        }

        public void analizar_programa()
        {
            string str_codigo = Entrada.Text.Trim();
            string TK_REPLACE = "";
            str_codigo = str_codigo.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " ");

            foreach (Token token in tokens_op)
            {
                TK_REPLACE = new string(' ', 1) + token.str_token + new string(' ', 1);
                str_codigo = str_codigo.Replace(token.str_token, TK_REPLACE);
            }

            foreach (Token token in tokens_sp)
            {
                TK_REPLACE = new string(' ', 1) + token.str_token + new string(' ', 1);
                str_codigo = str_codigo.Replace(token.str_token, TK_REPLACE);
            }

            str_codigo = Regex.Replace(str_codigo, @"\s+", " ");
            salida.Text = "";

            string[] array_str_codigo;
            List<string> str_cod_tokens = new List<string>();
            string tok = "", tok_sgt;
            int i = 0;
            array_str_codigo = str_codigo.Split(' ');
            bool abre_comentario = false;

            for (i = 0; i < array_str_codigo.Length; i++)
            {
                tok = array_str_codigo[i].Trim();

                if ((i + 1) < array_str_codigo.Length)
                {
                    tok_sgt = array_str_codigo[i + 1].Trim();
                }
                else
                {
                    tok_sgt = "";
                }

                if ((tok.Equals(":") && tok_sgt.Equals("=")) || (tok.Equals("<") && tok_sgt.Equals(">")) || (tok.Equals("=") && tok_sgt.Equals("=")))
                {
                    tok = tok + tok_sgt;
                    i = i + 1;
                }

                if (!abre_comentario && (tok.Equals("/") && tok_sgt.Equals("*")))
                {
                    tok = "";
                    i = i + 1;
                    abre_comentario = true;
                    str_cod_tokens.Add("/*");
                }

                if (abre_comentario && tok.Equals("*") && tok_sgt.Equals("/"))
                {
                    tok = "";
                    i = i + 1;
                    abre_comentario = false;
                    str_cod_tokens.Add("*/");
                }

                if (!abre_comentario)
                {
                    if (!tok.Equals(""))
                    {
                        str_cod_tokens.Add(tok);
                    }
                }
            }

            salida.Text = "";
            bool mostro = false;

            for (i = 0; i < str_cod_tokens.Count; i++)
            {
                tok = str_cod_tokens.ElementAt(i);
                mostro = MostrarTipo(tok);
                if (!mostro)
                {
                    MostrarTokensDesconocidos(str_cod_tokens, i);
                }
            }
        }

        private bool MostrarTipo(string str)
        {
            foreach (Token token in tokens_pr)
            {
                if (token.str_token.Equals(str))
                {
                    salida.Text = salida.Text + token.str_token + ",\t" + token.descripcion + "\n";

                    return true;
                }
            }

            foreach (Token token in tokens_Error)
            {
                if (token.str_token.Equals(str))
                {
                    MostrarErrores(token.str_token);
                    return true;
                }
            }

            foreach (Token token in tokens_op)
            {
                if (token.str_token.Equals(str))
                {
                    salida.Text = salida.Text + token.str_token + ",\t" + token.descripcion + "\n";

                    return true;
                }
            }

            foreach (Token token in tokens_sp)
            {
                if (token.str_token.Equals(str))
                {
                    salida.Text = salida.Text + token.str_token + ",\t" + token.descripcion + "\n";
                    return true;
                }
            }
            return false;
        }

        private void MostrarTokensDesconocidos(List<string> str_cod_tokens, int i)
        {
            bool mostro = false;
            string tok = str_cod_tokens.ElementAt(i);
            /* REGLAS PARA DETERMINAR LAS VARIABLES Y NUMEROS CON SUS TIPOS DE DATOS*/
            if (i > 0)
            {
                // comprobamos si es una variable declarada
                if (str_cod_tokens.ElementAt(i - 1).Equals("Dim"))
                {
                    salida.Text = salida.Text + tok + ",\tVariable(Id)\n";
                    mostro = true;
                }

                // comprobamos si es una variable, numero entero o deciaml
                // comprobamos si antes existe un operador
                if (ExisteUnOperador(str_cod_tokens.ElementAt(i - 1)))
                {
                    int k = 0;
                    bool result = int.TryParse(tok, out k);

                    if (result)
                    {
                        salida.Text = salida.Text + tok + ",\t Numero Entero\n";
                        mostro = true;
                    }
                    else
                    {
                        decimal x = 0;
                        result = decimal.TryParse(tok, out x);
                        if (result)
                        {
                            salida.Text = salida.Text + tok + ",\tNumero Decimal\n";
                            mostro = true;
                        }
                        else
                        {
                            salida.Text = salida.Text + tok + ",\tVariable(Id)\n";
                            mostro = true;
                        }
                    }
                }
            }

            if (i < (str_cod_tokens.Count - 1) && !mostro)
            {
                if (ExisteUnOperador(str_cod_tokens.ElementAt(i + 1)))
                {
                    int k = 0;
                    bool result = int.TryParse(tok, out k);

                    if (result)
                    {
                        salida.Text = salida.Text + tok + ",\t Numero Entero\n";
                        mostro = true;
                    }
                    else
                    {
                        decimal x = 0;
                        result = decimal.TryParse(tok, out x);
                        if (result)
                        {
                            salida.Text = salida.Text + tok + ",\tNumero Decimal\n";
                            mostro = true;
                        }
                        else
                        {
                            salida.Text = salida.Text + tok + ",\tVariable(Id)\n";
                            mostro = true;
                        }
                    }
                }
            }

            if (!mostro)
            {
                salida.Text = salida.Text + tok + ",\tPalabra desconocida\n";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rtxt_errors.Text = "";
            salida.Text = "";
            analizar_programa();
        }

        void MostrarErrores(string tokenError)
        {
            string text = Entrada.Text;
            char[] textarray = text.ToCharArray();
            int j = 1, k = 1;

            for (int i = 1; i < text.Length; i++)
            {
                if (textarray[i].Equals('\n'))
                {
                    j++;
                    k = 1;
                }
                else
                {
                    char[] chars = tokenError.ToCharArray();
                    if (textarray[i].Equals(chars[0]))
                    {

                        rtxt_errors.Text = rtxt_errors.Text + tokenError + ", Error linea " + j + " columna " + (k) + " error de operador" + "\n";

                    }
                    k++;
                }
            }
        }

        private void salida_TextChanged(object sender, EventArgs e)
        {

        }


        //TABLA TOKENS
        private void button6_Click(object sender, EventArgs e)
        {
            conexion.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM KeyWords", conexion);

            DataSet d = new DataSet();
            adapter.Fill(d);

            new datos(d).Show();
            conexion.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            string[] lineas = salida.Text.Split('\n');

            for (int i = 0; i < lineas.Length - 1; i++)
            {
                string[] column = lineas[i].Split(',');
                //MessageBox.Show(column[0].Trim());


                conexion.Open();
                string sql = "INSERT INTO KeyWords (Palabra, Descripcion) VALUES(@pala, @des);";
                OleDbCommand comando = new OleDbCommand(sql, conexion);

                comando.Parameters.AddWithValue("@pala", column[0].Trim());
                comando.Parameters.AddWithValue("@des", column[1].Trim());
                //resto parametros
                comando.ExecuteNonQuery();

                conexion.Close();

            }


            MessageBox.Show("Los datos se guardaron en la BD correctamente!!");

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            List<string> datos = new List<string>();
            try
            {
                datos = Entrada.Text.Split('{').ToList();
                if (datos[1] == "")
                {
                    salida.Text = "";
                    salida.Text = "Hay error en el codigo. Coloque las llaves correctamente";
                    return;
                }
            }
            catch (Exception)
            {
                salida.Text = "";
                salida.Text = "Hay error en el codigo. Coloque las llaves correctamente";
                return;
            }





            if (datos[0] == "Main()" || datos[0] == "Main() " || datos[0] == "Main()  ")
            {
                salida.Text = "";
                List<string> content = datos[1].Split(';').ToList();
                string codigo = content[0].Trim();

                Regex regexEspacio = new Regex(@"^\w+\s+\w+\s+\w+\s+\w+$");

                codigo = codigo.Trim('}');


                if (codigo != "")
                {
                    codigo = codigo.Trim();

                    if (regexEspacio.IsMatch(codigo))
                    {
                        Regex regexKeyDim = new Regex(@"^Dim");

                        if (regexKeyDim.IsMatch(codigo))
                        {
                            Regex regexKeyAs = new Regex(@"^Dim\s+\w+\s+As\s+\w+$");

                            if (regexKeyAs.IsMatch(codigo))
                            {

                                MessageBox.Show(codigo);

                                Regex regexTypeI = new Regex(@"^Dim\s+\w+\s+As\s+Integer$");
                                Regex regexTypeS = new Regex(@"^Dim\s+\w+\s+As\s+String");
                                Regex regexTypeD = new Regex(@"^Dim\s+\w+\s+As\s+Decimal");

                                if (regexTypeI.IsMatch(codigo) || regexTypeS.IsMatch(codigo) || regexTypeD.IsMatch(codigo))
                                {
                                    salida.Text = "";
                                    salida.Text = "No hay ningun error en el codigo. No olvidar el punto y coma ';'";

                                }
                                else
                                {
                                    salida.Text = "";
                                    salida.Text = "Hay error en el codigo. Solo se aceptan tipos de datos String Integer y Decimal";
                                }

                            }
                            else
                            {
                                salida.Text = "";
                                salida.Text = "Hay error en el codigo. La asignacion de tipo debe realizarse con As";

                            }

                        }
                        else
                        {
                            salida.Text = "";
                            salida.Text = "Hay error en el codigo. La declaracion de variables debe realizarse con Dim";

                        }
                    }
                    else
                    {
                        salida.Text = "";
                        salida.Text = "Error de sintaxis";
                    }

                }
                else
                {
                    salida.Text = "";
                    salida.Text = "El Main esta vacio";

                }


            }
            else
            {
                salida.Text = "";
                salida.Text = "Errores de sintaxis en Main";
            }

        }

        private void Entrada_TextChanged(object sender, EventArgs e)
        {

        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}




