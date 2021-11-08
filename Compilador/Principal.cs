using Analizador_Lexico.Clases;
using Analizador_Semantico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compilador
{
    public partial class Principal : Form
    {
        Lexico Analiza_Lexico = new Lexico();

        int cantLineas = 0;

        int cantErrores = 0;

        tabla_errores tabla_errorres = new tabla_errores();
        tabla_simbolos tabla_simb = new tabla_simbolos();
        tabla_simbolos tabla_simb2 = new tabla_simbolos();
        tabla_simbolos tabla_simb3 = new tabla_simbolos();

        public Principal()
        {
            InitializeComponent();
        }

        private void rTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void leer_texto(string texto)
        {
         
            int contador_Ambitoi = 0;
            int contador_Ambitf = 0;
            int ambito = 0;

         
            int contador_Ambitoi2 = 0;
            int contador_Ambitf2 = 0;
            int ambito2 = 0;

            int contador_asig = 0;

            string Rtexto = "";

            Rtexto = rText.Text;

            try
            {
                string[] palabra_sep;
                int num_lineas = rText.Lines.Length;

                int num_line_token = 0;

                while (Rtexto != "")
                {
                    //separamos las palabras divididas por espacios
                    palabra_sep = rText.Text.Split(' ');
                    foreach (var palabra in palabra_sep)
                    {
                        num_line_token = num_line_token + 1;

                        if (palabra.Contains("{"))
                        {
                            contador_Ambitoi = contador_Ambitoi + 1;
                        }
                        if (palabra.Contains("}"))
                        {
                            contador_Ambitf = contador_Ambitf + 1;
                        }
                        if (palabra.Contains("("))
                        {
                            contador_Ambitoi2 = contador_Ambitoi2 + 1;
                        }
                        if (palabra.Contains(")"))
                        {
                            contador_Ambitf2 = contador_Ambitf2 + 1;
                        }
                        if(palabra.Contains("="))
                        {
                            contador_asig = contador_asig + 1;
                        }
                        ambito = contador_Ambitoi;
                        ambito2 = contador_Ambitoi2;

                        

                        /*en esta parte se compara si la palabra esta dentro de la tabla de simbolos que tenemos predefinida
                         con mi lenguaje*/
                        if (tabla_simb2.compararAL(palabra.ToString()) && palabra != null)
                        {
                            palabra.Split('\n');
                            tabla_s obj = new tabla_s(palabra, "", num_line_token, -0, ambito, tabla_simb2.compararALRef(palabra.ToString()), "palabra nueva", "palabra contenida en la tabla de simbolos", "");
                            tabla_simb.añadir_obj(obj);
                            tabla_simb3.añadir_obj(obj);

                        }
                        //si dicha palabra no esta contenida dentro de la tabla de simbolos, pues procedemos a insertarla
                        else
                        {
                            string[] palabra_rp = palabra.Split('\n');
                            if (Regex.IsMatch(palabra, @"[a-zA-Z]") && palabra != null)
                            {
                                tabla_s obj = new tabla_s(palabra, "", num_line_token, -0, ambito, tabla_simb2.contlineas() + 1, "palabra nueva", "palabra que no coincide con la Tabla de simbolos,pero no se considera error", "");
                                tabla_simb.añadir_obj(obj);

                                foreach (var palabra_c in palabra_rp)
                                {
                                    tabla_s obj2 = new tabla_s(palabra_c, "", num_line_token, -0, ambito, tabla_simb2.contlineas() + 1, "palabra nueva", "palabra que no coincide con la Tabla de simbolos,pero no se considera error", "");
                                    tabla_simb3.añadir_obj(obj2);
                                }


                               
                            }
                            else if (Regex.IsMatch(palabra, @"\d{1}|\d{2}|\d{3}|\d{4}|\d{5}") && palabra != null)
                            {
                                tabla_s obj = new tabla_s(palabra, "", num_line_token, -0, ambito, tabla_simb2.contlineas() + 1, "palabra nueva", "palabra que no coincide con la Tabla de simbolos,pero no se considera error", "");
                                tabla_simb.añadir_obj(obj);

                                foreach (var palabra_c in palabra_rp)
                                {
                                    tabla_s obj2 = new tabla_s(palabra_c, "", num_line_token, -0, ambito, tabla_simb2.contlineas() + 1, "palabra nueva", "palabra que no coincide con la Tabla de simbolos,pero no se considera error", "");
                                    tabla_simb3.añadir_obj(obj2);
                                }
                            }
                            else if (palabra != null && palabra == "->")
                            {
                                tabla_s obj = new tabla_s(palabra, "", num_line_token, -0, ambito, tabla_simb2.contlineas() + 1, "palabra nueva", "palabra que no coincide con la Tabla de simbolos,pero no se considera error", "");
                                tabla_simb.añadir_obj(obj);

                                foreach (var palabra_c in palabra_rp)
                                {
                                    tabla_s obj2 = new tabla_s(palabra_c, "", num_line_token, -0, ambito, tabla_simb2.contlineas() + 1, "palabra nueva", "palabra que no coincide con la Tabla de simbolos,pero no se considera error", "");
                                    tabla_simb3.añadir_obj(obj2);
                                }
                            }
                        }
                    }
                    //hasta aqui se realiza el analisis lexico


                    palabra_sep = null;
                    Rtexto = "";
                    cantLineas = num_lineas;
                }

                //verificamos si existe algun error de ambitos
                if (contador_Ambitf != contador_Ambitoi)
                {
                    tabla_errorres.agrega_error(8);

                    rtSintactico.Text += "se han detectado errores en las llaves utilizadas\n";
                    cantErrores++;

                }
                if (contador_Ambitf2 != contador_Ambitoi2)
                {
                    
                    rtSintactico.Text += "se han detectado errores en los parentesis utilizados \n";
                    cantErrores++;

                }

                if(contador_asig > 0)
                {
                    rtSintactico.Text += "se han detectado error en sintaxis con el operador de asignacion\n";
                    cantErrores++;
                }



            }
            catch (ArgumentNullException)
            {

                MessageBox.Show("Error");

                tabla_errorres.agrega_error(2);
                rtSintactico.Text += "se han detectado error al realizar analisis lexico\n";
                cantErrores++;
            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }


        }

        //esta funcion se encarga de unir los tokens que anteriormente fueron divididos.
        public string[] une_tokens()
        {
            string sentencia = null;
            int tam = 1;
            string[] sentencias = new string[tam + 1];

            int comp = 0;

            string tipov = "";
            List<string> Ltoken = new List<string>();

            for (int i = 1; i <= tam; i++)
            {
                foreach (var token in tabla_simb.llamatabla())
                {
                    if (token.num_linea == i && token != null)
                    {
                        if (comp == 0 && Regex.IsMatch(token.Simbolo, @"(.integer|.float|.double|.booleano|.String)$"))
                        {

                            token.Tipo_Dato = token.Simbolo;
                            tipov = token.Simbolo;
                        }


                        if (comp != 0)
                        {
                            sentencia = sentencia + " " + token.simbolo.ToString();
                            token.Tipo_Dato = tipov;
                        }
                        else
                        {
                            sentencia = sentencia + token.simbolo.ToString();
                            comp = 1;
                        }

                    }
                    else
                    {

                        sentencia = sentencia + " " + token.simbolo.ToString();
                    }
                }
                sentencias[i] = sentencia;
                sentencia = null;
                comp = 0;
                tipov = "";
            }

            return sentencias;
        }

        //para realizar analisis sintactico y semantico
        public void Analisis_Sint_Sem(string[] sentencias)
        {
            List<string> sintaxiss = new List<string>();

            int cantidad = 0;

            for (int j = 0; j < sentencias.Length; j++)
            {
                if (sentencias[j] != null)
                    cantidad = Regex.Matches(sentencias[j], "\n").Count;

            }

            for (int i = 1; i < sentencias.Length; i++)
            {


                if (sentencias[i] != null)
                {
                    for (int a = 0; a < cantidad; a++)
                    {
                        if (sentencias[i].Contains(".integer") && !sintaxiss.Contains(".integer"))
                        {
                            sintaxiss.Add(".integer");
                            rtSintactico.Text += "se ha declarado una variable como entero\n";

                            //para analisis semantico
                            string[] separanum;
                            separanum = sentencias[i].Split(' ');


                            try
                            {
                                //convierto la sintaxis de mi lenguaje al del c#
                                sentencias[i] = sentencias[i].Replace(".integer", "int");
                                if (sentencias[i].Contains("->"))
                                    sentencias[i] = sentencias[i].Replace("->", "=");

                                string datos =  string.Join("", sentencias[i]);

                                string[] int_datos = datos.Split('\n');

                                Match m = Regex.Match(int_datos[0], @"\d{1}|\d{2}|\d{3}|\d{4}|\d{5}");

                                string num = string.Empty;

                                if (m.Success)
                                {
                                    num = m.Value;
                                    MessageBox.Show("Respuesta" + num.ToString());
                                    rtSemantico.Text += "el valor correspondiente a la variable de tipo entero es correcto";
                                }
                                else
                                {
                                    cantErrores++;
                                    rtSintactico.Text += "se han detectado error en sintaxis, escriba el valor aceptado por el tipo de variable .integer \n";
                                    rtSemantico.Text += "el valor correspondiente a la variable de tipo entero es incorrecto";
                                }

                            }
                            catch (FormatException e)
                            {

                                tabla_errorres.agrega_error_l(0, i);
                                cantErrores++;
                            }
                            catch (IndexOutOfRangeException e)
                            {

                                tabla_errorres.agrega_error_l(10, i);
                                cantErrores++;
                                MessageBox.Show("Error en sintaxis");
                                rtSintactico.Text += "se han detectado error en sintaxis\n";

                            }
                            

                        } 

                        else if (sentencias[i].Contains(".double") && !sintaxiss.Contains(".double"))
                        {
                            sintaxiss.Add(".double");
                            rtSintactico.Text += "se ha declarado una variable como double\n";

                            //para analisis semantico
                            string[] separanum;
                            separanum = sentencias[i].Split(' ');
                            try
                            {
                                //convierto la sintaxis de mi lenguaje al del c#
                                sentencias[i] = sentencias[i].Replace(".double", "double");
                                if (sentencias[i].Contains("->"))
                                    sentencias[i] = sentencias[i].Replace("->", "=");

                                sentencias[i] = sentencias[i].Replace(";", "");

                                Match m = Regex.Match(sentencias[i], @"^(\d|-)?(\d|,)*\.?\d*$");
                               
                                string num = string.Empty;

                                if (m.Success)
                                {
                                    num = m.Value;
                                }
                                else
                                {
                                    cantErrores++;
                                    rtSintactico.Text += "se han detectado error en sintaxis, escriba el valor aceptado por el tipo de variable .double \n";
                                }

                                

                            }
                            catch (FormatException e)
                            {
                                tabla_errorres.agrega_error_l(0, i);
                                rtSintactico.Text += "se han detectado error en sintaxis, escriba el valor aceptado por el tipo de variable\n";
                                MessageBox.Show("No es un numero double");
                                cantErrores++;

                            }
                            catch (IndexOutOfRangeException e)
                            {

                                tabla_errorres.agrega_error_l(10, i);
                                rtSintactico.Text += "se han detectado error en sintaxis\n";
                                MessageBox.Show("Error en sintaxis");
                                cantErrores++;

                            }


                        }
                        else if (sentencias[i].Contains(".String") && !sintaxiss.Contains(".String"))
                        {
                            sintaxiss.Add(".String");
                            rtSintactico.Text += "se ha declarado una variable como string\n";
                            //convierto la sintaxis de mi lenguaje al del c#
                            sentencias[i] = sentencias[i].Replace(".String", "String");
                            if (sentencias[i].Contains("->"))
                                sentencias[i] = sentencias[i].Replace("->", "=");

                        }
                        else if (sentencias[i].Contains(".booleano") && !sintaxiss.Contains(".booleano"))
                        {
                            sintaxiss.Add(".booleano");
                            rtSintactico.Text += "se ha declarado una variable como booleana\n";

                            //para analisis semantico
                            string[] separavar;
                            separavar = sentencias[i].Split(' ');
                            try
                            {
                                sentencias[i] = sentencias[i].Replace(".booleano", "bool");
                                if (sentencias[i].Contains("->"))
                                    sentencias[i] = sentencias[i].Replace("->", "=");

                                bool var;
                                var = bool.Parse(separavar[3]);


                            }
                            catch (FormatException e)
                            {

                                MessageBox.Show("No es una variable bool");
                                rtSintactico.Text += "se han detectado error en sintaxis, escriba el valor aceptado por el tipo de variable\n";
                                tabla_errorres.agrega_error_l(0, i);
                            }

                        }
                        else if (sentencias[i].Contains("<<") && !sintaxiss.Contains(".<<"))
                        {
                            sintaxiss.Add(".<<");
                            rtSintactico.Text += "se ha detectado un comentario\n";
                            sentencias[i] = sentencias[i].Replace("<<", "//");
                            if (sentencias[i].Contains("->"))
                                sentencias[i] = sentencias[i].Replace("->", "=");
                        }
                        else if (Regex.IsMatch(sentencias[i], @"[a-z]\s+:\s[a-z]|(\w)*\s\+\s(\w)*|\d(0,32000)*\s;$") && !sintaxiss.Contains("->"))
                        {
                            sintaxiss.Add("->");
                            rtSintactico.Text += "se ha detectado una sentencia de asignacion\n";
                            if (sentencias[i].Contains("->"))
                                sentencias[i] = sentencias[i].Replace("->", "=");

                            //para analisis semantico
                            string tpv1 = "";
                            string tpv2 = "";
                            string tpv3 = "";

                            string[] separavar;
                            separavar = sentencias[i].Split(' ');

                            if (Regex.IsMatch(sentencias[i], @"[a-z]\s+:\s(\w)*\s\+\s(\w)*\s;$"))
                            {

                                foreach (var token in tabla_simb.llamatabla())
                                {
                                    if (token.Simbolo == separavar[0])
                                    {
                                        tpv1 = token.Tipo_Dato;
                                    }
                                    if (token.Simbolo == separavar[2])
                                    {
                                        tpv2 = token.Tipo_Dato;
                                    }
                                    if (token.Simbolo == separavar[4])
                                    {
                                        tpv3 = token.Tipo_Dato;
                                    }

                                }
                                if (tpv1 == tpv2 && tpv2 == tpv3 && tpv1 != "")
                                {
                                    MessageBox.Show("el tipo de las variables son el mismo");
                                }
                            }
                            if (Regex.IsMatch(sentencias[i], @"[a-z]\s+:\s(\w)*\s\-\s(\w)*\s;$"))
                            {

                                foreach (var token in tabla_simb.llamatabla())
                                {
                                    if (token.Simbolo == separavar[0])
                                    {
                                        tpv1 = token.Tipo_Dato;
                                    }
                                    if (token.Simbolo == separavar[2])
                                    {
                                        tpv2 = token.Tipo_Dato;
                                    }
                                    if (token.Simbolo == separavar[4])
                                    {
                                        tpv3 = token.Tipo_Dato;
                                    }

                                }
                                if (tpv1 == tpv2 && tpv2 == tpv3 && tpv1 != "")
                                {
                                    MessageBox.Show("El tipo de las variables son iguales");
                                }
                            }
                            if (Regex.IsMatch(sentencias[i], @"[a-z]\s+:\s(\w)*\s\/\s(\w)*\s;$"))
                            {

                                foreach (var token in tabla_simb.llamatabla())
                                {
                                    if (token.Simbolo == separavar[0])
                                    {
                                        tpv1 = token.Tipo_Dato;
                                    }
                                    if (token.Simbolo == separavar[2])
                                    {
                                        tpv2 = token.Tipo_Dato;
                                    }
                                    if (token.Simbolo == separavar[4])
                                    {
                                        tpv3 = token.Tipo_Dato;
                                    }

                                }
                                if (tpv1 == tpv2 && tpv2 == tpv3 && tpv1 != "")
                                {
                                    MessageBox.Show("El tipo de las variables son iguales");
                                }
                            }
                            if (Regex.IsMatch(sentencias[i], @"[a-z]\s+:\s(\w)*\s\*\s(\w)*\s;$"))
                            {

                                foreach (var token in tabla_simb.llamatabla())
                                {
                                    if (token.Simbolo == separavar[0])
                                    {
                                        tpv1 = token.Tipo_Dato;
                                    }
                                    if (token.Simbolo == separavar[2])
                                    {
                                        tpv2 = token.Tipo_Dato;
                                    }
                                    if (token.Simbolo == separavar[4])
                                    {
                                        tpv3 = token.Tipo_Dato;
                                    }

                                }
                                if (tpv1 == tpv2 && tpv2 == tpv3 && tpv1 != "")
                                {
                                    MessageBox.Show("El tipo de las variables son iguales");
                                }
                            }

                        }
                        else if (Regex.IsMatch(sentencias[i], @"^{$"))
                        {
                            rtSintactico.Text += "se ha detectado un inicio de ambito\n";
                        }
                        else if (Regex.IsMatch(sentencias[i], @"^}$"))
                        {
                            rtSintactico.Text += "se ha detectado un fin de ambito\n";
                        }
                        else if (sentencias[i].Contains(".si") && !sintaxiss.Contains(".si"))
                        {
                            sintaxiss.Add(".si");
                            rtSintactico.Text += "se ha detectado un comienzo de si\n";
                            sentencias[i] = sentencias[i].Replace(".si", "if");
                        }
                        else if (sentencias[i].Contains(".ent si") && !sintaxiss.Contains(".ent si"))
                        {
                            sintaxiss.Add(".ent si");
                            rtSintactico.Text += "se ha detectado un comienzo de ent si\n";
                            sentencias[i] = sentencias[i].Replace(".ent si", "else if");
                        }
                        else if (sentencias[i].Contains(".ent") && !sintaxiss.Contains(".ent"))
                        {
                            sintaxiss.Add(".ent");
                            rtSintactico.Text += "se ha detectado un comienzo de ent\n";
                            sentencias[i] = sentencias[i].Replace(".ent", "else");
                        }
                        else if (sentencias[i].Contains(".switch") && !sintaxiss.Contains(".switch"))
                        {
                            sintaxiss.Add(".switch");
                            rtSintactico.Text += "se ha detectado un comienzo de switch\n";
                            sentencias[i] = sentencias[i].Replace(".switch", "switch");
                        }
                        else if (sentencias[i].Contains(".caso") && !sintaxiss.Contains(".caso"))
                        {
                            sintaxiss.Add(".caso");
                            rtSintactico.Text += "se ha detectado un comienzo de case\n";
                            sentencias[i] = sentencias[i].Replace(".caso", "case");
                        }
                        else if (sentencias[i].Contains("break") && !sintaxiss.Contains(".break"))
                        {
                            sintaxiss.Add(".break");
                            rtSintactico.Text += "se ha detectado el break del case\n";
                            sentencias[i] = sentencias[i].Replace(".break", "break");
                        }
                        else if (sentencias[i].Contains(".mientras") && !sintaxiss.Contains(".mientras"))
                        {
                            sintaxiss.Add(".mientras");
                            rtSintactico.Text += "se ha detectado una sentencia mientras\n";
                            sentencias[i] = sentencias[i].Replace(".mientras", "while");
                        }

                        else if (sentencias[i].Contains(".imprim") && !sintaxiss.Contains(".imprim"))
                        {
                            sintaxiss.Add(".imprim");
                            rtSintactico.Text += "se ha detectado una sentencia imprim\n";
                            sentencias[i] = sentencias[i].Replace(".imprim", "Console.WriteLine");

                        }
                       
                    }

                }
            }
            for (int i = 0; i < sentencias.Length; i++)
            {
                if (sentencias[i] != null)
                    rcodGen.Text += sentencias[i];
            }

            if (cantErrores == 0)
                rtSintactico.Text += "no se han detectado errores en sintaxis\n";

        }


        private void btnALexico_Click(object sender, EventArgs e)
        {
            //=============BLOQUE ANALISIS LEXICO===============================

            //se llama la funcion inicia de la clase lexico
            Analiza_Lexico.Inicia();
            //le pasamos como parametro el texto a la funcion analiza
            Analiza_Lexico.Analiza(rText.Text);
            dgvTOKEN_LEXEMA.Rows.Clear();
            //si la funcion NoTokens retoran 0,e tonces se agrega al datagridview
            if (Analiza_Lexico.NoTokens > 0)
                dgvTOKEN_LEXEMA.Rows.Add(Analiza_Lexico.NoTokens);

            //mientras i sea menor que el valor que retorna la funcion agregara el toek y el lexema al datagridview
            for (int i = 0; i < Analiza_Lexico.NoTokens; i++)
            {
                dgvTOKEN_LEXEMA.Rows[i].Cells[0].Value = Analiza_Lexico.Token[i];
                dgvTOKEN_LEXEMA.Rows[i].Cells[1].Value = Analiza_Lexico.Lexema[i];
            }
            //FIN BLOQUE

            //==================BLOQUE GENERACION DE CODIGO=============================

            //inicializamos la tabla de errores
            tabla_errorres.inicialestaE();
            //funcion que se encarga de leer el texto y a la vez aplicar el analisis lexico 
            leer_texto(rText.Text);

            //esta funcion se encarga de unir los tokens de cada linea de codigo
            string[] sent = une_tokens();

            //se realiza la comparacion semantica de la tabla de simbolos
            tabla_simb.comparacion_semantic();

            //funcion que se encarga de realizar tanto el analisis sintactico como el semantico
            Analisis_Sint_Sem(sent);
            //FIN BLOQUE

            //=================BLOQUE TABLA DE SIMBOLOS================================
            dgvTsimb.DataSource = null;
            dgvTsimb.Rows.Clear();
            dgvTsimb.DataSource = tabla_simb3.llamatabla();
            //FIN BLOQUE

        }

        private void dgvTOKEN_LEXEMA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvTOKEN_LEXEMA.Rows.Clear();
            dgvTsimb.DataSource = null;
            dgvTsimb.Rows.Clear();
            rText.Text = "";
            rText.Focus();
            rcodGen.Text = "";
            rtSintactico.Text = "";
            rtSemantico.Text = "";
            tabla_simb = new tabla_simbolos();
           // tabla_simb2 = new tabla_simbolos_lnv();
            tabla_simb3 = new tabla_simbolos();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabla_simb2.inicialista();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rcodGen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
