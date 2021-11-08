using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analizador_Semantico
{
    public class tabla_simbolos
    {
        //instanciamos la tabla de simbolos y la tabla de errores.
        public List<tabla_s> Tabla_Simbolos = new List<tabla_s>();
        tabla_errores Tabla_Errores = new tabla_errores();


        public tabla_simbolos()
        {

        }
        public List<tabla_s> TablaSimbolos
        {
            get { return Tabla_Simbolos; }
            set { Tabla_Simbolos = value; }
        }

        public void reinicialista()
        {
            Tabla_Simbolos.Clear();
        }

        //Se define la tabla de simbolos a utilizar
        public void inicialista()
        {
            tabla_s ts = new tabla_s("<#", "", -0, -0, -0, 0, "comentario", "inicio de un comentario de mas de una linea", "");
            Tabla_Simbolos.Add(ts);
            tabla_s ts1 = new tabla_s("#>", "", -0, -0, -0, 1, "comentario", "final de un comentario de mas de una linea", "");
            Tabla_Simbolos.Add(ts1);
            tabla_s ts2 = new tabla_s("<<", "", -0, -0, -0, 2, "comentario", "inicio de un comentario de una linea", "");
            Tabla_Simbolos.Add(ts2);
            tabla_s ts3 = new tabla_s(".float", "", -0, -0, -0, 3, "palabra reservada", "numero flotante", "");
            Tabla_Simbolos.Add(ts3);
            tabla_s ts4 = new tabla_s("{", "", -0, -0, -0, 4, "bloque", "inicio de un bloque", "");
            Tabla_Simbolos.Add(ts4);
            tabla_s ts5 = new tabla_s("}", "", -0, -0, -0, 5, "bloque", "final de un bloque", "");
            Tabla_Simbolos.Add(ts5);
            tabla_s ts6 = new tabla_s(".integer", "", -0, -0, -0, 6, "palabra reservada", "numero entero", "");
            Tabla_Simbolos.Add(ts6);
            tabla_s ts7 = new tabla_s(".double", "", -0, -0, -0, 8, "palabra reservada", "numero con decimales", "");
            Tabla_Simbolos.Add(ts7);
            tabla_s ts8 = new tabla_s(".String", "", -0, -0, -0, 9, "palabra reservada", "cadena de caracteres", "");
            Tabla_Simbolos.Add(ts8);
            tabla_s ts9 = new tabla_s(".booleano", "", -0, -0, -0, 10, "palabra reservada", "booleano true o false", "");
            Tabla_Simbolos.Add(ts9);
            tabla_s ts10 = new tabla_s("->", "", -0, -0, -0, 12, "asignacion", "simbolo de asignacion", "");
            Tabla_Simbolos.Add(ts10);
            tabla_s ts11 = new tabla_s(";", "", -0, -0, -0, 13, "posicionador", "final de linea", "");
            Tabla_Simbolos.Add(ts11);
            tabla_s ts12 = new tabla_s("'", "", -0, -0, -0, 14, "indicador de texto", "inicio y final de un texto", "");
            Tabla_Simbolos.Add(ts12);
            tabla_s ts13 = new tabla_s("/l", "", -0, -0, -0, 15, "posicionador", "salto de linea en un texto", "");
            Tabla_Simbolos.Add(ts13);
            tabla_s ts14 = new tabla_s("[", "", -0, -0, -0, 16, "arreglo", "inicio de asignacion de un arreglo", "");
            Tabla_Simbolos.Add(ts14);
            tabla_s ts15 = new tabla_s("]", "", -0, -0, -0, 17, "arreglo", "final de asignacion de un arreglo", "");
            Tabla_Simbolos.Add(ts15);
            tabla_s ts16 = new tabla_s("+", "", -0, -0, -0, 18, "operador", "suma", "");
            Tabla_Simbolos.Add(ts16);
            tabla_s ts17 = new tabla_s("-", "", -0, -0, -0, 20, "operador", "resta", "");
            Tabla_Simbolos.Add(ts17);
            tabla_s ts18 = new tabla_s("*", "", -0, -0, -0, 21, "operador", "multiplicacion", "");
            Tabla_Simbolos.Add(ts18);
            tabla_s ts19 = new tabla_s("/", "", -0, -0, -0, 22, "operador", "division", "");
            Tabla_Simbolos.Add(ts19);
            tabla_s ts20 = new tabla_s("~", "", -0, -0, -0, 23, "signo relacionador", "negacion", "");
            Tabla_Simbolos.Add(ts20);
            tabla_s ts21 = new tabla_s(">", "", -0, -0, -0, 24, "signo comparador", "mayor que", "");
            Tabla_Simbolos.Add(ts21);
            tabla_s ts22 = new tabla_s("<", "", -0, -0, -0, 25, "signo comparador", "menor que", "");
            Tabla_Simbolos.Add(ts22);
            tabla_s ts23 = new tabla_s(">->", "", -0, -0, -0, 26, "signo comparador", "mayor o igual que", "");
            Tabla_Simbolos.Add(ts23);
            tabla_s ts24 = new tabla_s("<->", "", -0, -0, -0, 27, "signo comparador", "menor o igual que", "");
            Tabla_Simbolos.Add(ts24);
            tabla_s ts25 = new tabla_s("&&", "", -0, -0, -0, 28, "signo relacionador", "expresion y (and)", "");
            Tabla_Simbolos.Add(ts25);
            tabla_s ts26 = new tabla_s("||", "", -0, -0, -0, 29, "signo relacionador", "expresion or", "");
            Tabla_Simbolos.Add(ts26);
            tabla_s ts27 = new tabla_s("->->", "", -0, -0, -0, 30, "signo comparador", "expresion igual", "");
            Tabla_Simbolos.Add(ts27);
            tabla_s ts28 = new tabla_s("!=", "", -0, -0, -0, 31, "signo comparador", "expresion distinto", "");
            Tabla_Simbolos.Add(ts28);
            tabla_s ts29 = new tabla_s(".si", "", -0, -0, -0, 32, "palabra reservada", "si tal condicion se cumple", "");
            Tabla_Simbolos.Add(ts29);
           
            tabla_s ts30 = new tabla_s(".ent", "", -0, -0, -0, 34, "palabra reservada", "si no se cumple la condicion", "");
            Tabla_Simbolos.Add(ts30);
            tabla_s ts31 = new tabla_s(".switch", "", -0, -0, -0, 35, "palabra reservada", "opciones (casos)", "");
            Tabla_Simbolos.Add(ts31);
            tabla_s ts32 = new tabla_s(".caso", "", -0, -0, -0, 36, "palabra reservada", "caso", "");
            Tabla_Simbolos.Add(ts32);
          
            tabla_s ts33 = new tabla_s(".mientras", "", -0, -0, -0, 38, "palabra reservada", "ciclo while", "");
            Tabla_Simbolos.Add(ts33);
            tabla_s ts34 = new tabla_s(".para", "", -0, -0, -0, 39, "palabra reservada", "ciclo for", "");
            Tabla_Simbolos.Add(ts34);
            tabla_s ts35 = new tabla_s(".foreach", "", -0, -0, -0, 40, "palabra reservada", "ciclo foreach", "");
            Tabla_Simbolos.Add(ts35);
            tabla_s ts36 = new tabla_s(".try", "", -0, -0, -0, 42, "palabra reservada", "intenta realizar el codigo contenido", "");
            Tabla_Simbolos.Add(ts36);
            tabla_s ts37 = new tabla_s(".catch", "", -0, -0, -0, 43, "palabra reservada", "muestra una accion a seguir en caso de error", "");
            Tabla_Simbolos.Add(ts37);
            tabla_s ts38 = new tabla_s(".imprim", "", -0, -0, -0, 44, "palabra reservada", "muestra en consola", "");
            Tabla_Simbolos.Add(ts38);
            tabla_s ts39 = new tabla_s(".Console.leeLine", "", -0, -0, -0, 45, "palabra reservada", "pide en consola", "");
            Tabla_Simbolos.Add(ts39);
            tabla_s ts40 = new tabla_s(".class", "", -0, -0, -0, 47, "palabra reservada", "clase", "");
            Tabla_Simbolos.Add(ts40);
            tabla_s ts41 = new tabla_s("(", "", -0, -0, -0, 48, "parametro", "inicia peticion de parametro", "");
            Tabla_Simbolos.Add(ts41);
            tabla_s ts42 = new tabla_s(")", "", -0, -0, -0, 49, "parametro", "termina peticion de parametro", "");
            Tabla_Simbolos.Add(ts42);
            tabla_s ts43 = new tabla_s("+", "", -0, -0, -0, 50, "concatenador", "concatena variables", "");
            Tabla_Simbolos.Add(ts43);
            tabla_s ts44 = new tabla_s(".break", "", -0, -0, -0, 50, "palabra reservada", "rompe un ciclo", "");
            Tabla_Simbolos.Add(ts44);
            tabla_s ts45 = new tabla_s(".long", "", -0, -0, -0, 50, "palabra reservada", "entero con signo", "");
            Tabla_Simbolos.Add(ts45);
            tabla_s ts46 = new tabla_s(".byte", "", -0, -0, -0, 50, "palabra reservada", "entero sin signo", "");
            Tabla_Simbolos.Add(ts46);
            tabla_s ts47 = new tabla_s(".short", "", -0, -0, -0, 50, "palabra reservada", "entero con signo", "");
            Tabla_Simbolos.Add(ts47);
            tabla_s ts48 = new tabla_s(".ent si", "", -0, -0, -0, 50, "palabra reservada", "entero con signo", "");
            Tabla_Simbolos.Add(ts48);
        }


        public List<tabla_s> llamatabla()
        {
            return Tabla_Simbolos;
        }

        public void añadir_obj(tabla_s Ts)
        {
            Tabla_Simbolos.Add(Ts);
        }

        public bool compararAL(string argsplit)
        {
            bool comp = false;
            foreach (var palabra in Tabla_Simbolos)
            {

                if (palabra.simbolo == argsplit)
                {
                    comp = true;
                    break;
                }
                else
                {
                    comp = false;
                }

            }
            return comp;
        }
        
        public bool busca_dupl()
        {
            bool flag = false;
            
            foreach (var sent1 in Tabla_Simbolos)
            {
                foreach (var sent2 in Tabla_Simbolos)
                {
                    if (sent1.ID == sent2.ID)
                    {

                        flag = true;

                        
                    }
                }
            }
            return flag;
        }

        public void comparacion_semantic()
        {

            foreach (var palabra in Tabla_Simbolos)
            {
                foreach (var palabra2 in Tabla_Simbolos)
                {
                    if (palabra.Simbolo == palabra2.Simbolo)
                    {
                        palabra2.Tipo_Dato = palabra.Tipo_Dato;
                    }
                }
            }

        }

        

        public int compararALRef(string argsplit)
        {
            int id = 0;
            foreach (var palabra in Tabla_Simbolos)
            {

                if (palabra.simbolo == argsplit)
                {
                    id = palabra.id;
                    break;
                }
                else
                {
                    id = 0;
                }

            }
            return id;
        }

        
        public int contlineas()
        {
            int numid = 0;
            foreach (var nlinea in Tabla_Simbolos)
            {
                numid = numid + 1;
            }
            return numid - 1;
        }
    }
}
