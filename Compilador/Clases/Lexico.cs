using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analizador_Lexico.Clases
{
    class Lexico
    {
        const int TOKREC = 5;
        const int MAXTOKENS = 500;
        string[] _lexemas;
        string[] _tokens;
        string _lexema;
        int _noTokens;
        int _i;
        int _iniToken;
        //se llama la clase automatas
        Automata oAFD;
        public Lexico()
        {
            //se inicializan los arreglos con el tamaño que esta definido en la variable MAXTOKENS
            _lexemas = new string[MAXTOKENS];
            _tokens = new string[MAXTOKENS];
            //se inicializa la instacia de la clase automatas
            oAFD = new Automata();
            _i = 0;
            _iniToken = 0;
            _noTokens = 0;
        }
        //esta funcion se encarga de retornar el numero de parejas token-lexema que fueron reconocidas durante el analisis
        public int NoTokens
        {
            get { return _noTokens; }
        }
        //se encarga de retornar el arreglo de lexemas
        public string[] Lexema
        {
            get { return _lexemas; }
        }
        //se encarga de retornar el arreglo de tokens
        public string[] Token
        {
            get { return _tokens; }
        }
        //se le asigna valores por defecto al iniciar el programa
        public void Inicia()
        {
            _i = 0;
            _iniToken = 0;
            _noTokens = 0;
        }
        //esta es la funcion que se encarga de analizar el texto que se proporciona
        public void Analiza(string texto)
        {
            bool recAuto; int noAuto;
            while (_i < texto.Length)
            {
                recAuto = false;
                noAuto = 0;
                for (; noAuto < TOKREC && !recAuto;)
                    //si el automata reconoce el texxto retorna true sino el contador aumenta
                    if (oAFD.Reconoce(texto, _iniToken, ref _i, noAuto))
                        recAuto = true;
                    else noAuto++;
                if (recAuto)
                {
                    _lexema = texto.Substring(_iniToken, _i - _iniToken);
                    switch (noAuto)
                    { 
                        //Automata delim(salto de linea, tabulacion...)
                        case 0: // _tokens[_noTokens] = "delim";
                            break;
                        //Automata id(letras y digitos)
                        case 1: if (EsId())
                                _tokens[_noTokens] = "id";
                            else
                                _tokens[_noTokens] = _lexema;
                            break;
                        //Automata num(numeros reales)
                        case 2: _tokens[_noTokens] = "num";
                            break;
                        //Automata otros(como por ejemplo |,;\+|-())
                        case 3: _tokens[_noTokens] = _lexema;
                            break;
                        //Automata cad(como por ejemplo, "[^\"]*\")
                        case 4: _tokens[_noTokens] = "cad"; break;
                    }
                    //esto es para evitar que se almacenen los delimitadores
                    if (noAuto != 0)
                        _lexemas[_noTokens++] = _lexema;
                }
                else
                    _i++;
                    _iniToken = _i;
            }
        }

        /*esta funcion retorna true si el lexema que se encuentre es un identificador de lo contrario retorna false si el lexema es una
          palabra reservada que se encuentra almacenada en el arreglo  */
        private bool EsId()
        {
            //palabras reservadas
            string[] palres = { "inicio", "fin", "const", "var", "entero", "real", "cadena", "leer", "visua" };
            for (int i = 0; i < palres.Length; i++)
                if (_lexema == palres[i]) return false;
            return true;
        }

    }
 }
