using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analizador_Semantico
{
    class tabla_errores
    {
        //instanciamos la tabla de errores en formato de lista
        public List<tabla_e> Tabla_Errores = new List<tabla_e>();
        public List<tabla_e> Tabla_Erroresed = new List<tabla_e>();
        public List<string> Tabla_E = new List<string>();


        public tabla_errores()
        {

        }
        public List<tabla_e> TablaErrores
        {
            get { return Tabla_Errores; }
            set { Tabla_Errores = value; }
        }
        public void reinicialista()
        {
            Tabla_Errores.Clear();
            Tabla_Erroresed.Clear();
            Tabla_E.Clear();
        }
        public void inicialestaE()
        {

            tabla_e te = new tabla_e(0, "valor incorrecto", "escriba el valor aceptado por el tipo de variable", "valor diferente al aceptado por el tipo");
            Tabla_Errores.Add(te);

            tabla_e te1 = new tabla_e(1, "se espera un valor", "escriba un valor para la variable ", "se espera un valor despues de...");
            Tabla_Errores.Add(te1);


            tabla_e te3 = new tabla_e(3, "error aritmetico", "revise la operación que esta realizando", "excepciones producidas durante operaciones aritméticas");
            Tabla_Errores.Add(te3);

            tabla_e te4 = new tabla_e(4, "error dividir por cero ", "escoja otro numero que no sea el 0 para dividir", "posible incongruencia en divicion,o en cualquier operación");
            Tabla_Errores.Add(te4);

            tabla_e te5 = new tabla_e(5, "error de conversion de tipo", "verifique que los tipos de las variables sea el mismo ", "Se produce cuando tiene lugar un error en tiempo de ejecución en una conversión explícita de un tipo base a una interfaz o a un tipo derivado.");
            Tabla_Errores.Add(te5);

            tabla_e te6 = new tabla_e(6, "error referencia nula", "revise que esta dando un valor a la variable", "Se produce al intentar hacer referencia a un objeto cuyo valor es null.");
            Tabla_Errores.Add(te6);

            tabla_e te7 = new tabla_e(7, "error de desbordamiento", "asegurese del tamaño del resultado ", "Se produce cuando una operación aritmética en un contexto produce un desbordamiento.");
            Tabla_Errores.Add(te7);
            tabla_e te8 = new tabla_e(8, "error de Ambito", "asegurese de que las llaves '{' tengan su contraparte '}' ", "Se produce cuando hay alguna llave sin cerrar, ambito incompleto");
            Tabla_Errores.Add(te8);
            tabla_e te9 = new tabla_e(9, "sintaxis desconocida", "asegurese de que la sintaxis sea correcta ", "Se produce cuando se desconoce la sintaxis de la sentencia");
            Tabla_Errores.Add(te9);
            tabla_e te10 = new tabla_e(10, "sintaxis erronea", "asegurese de que la sintaxis sea correcta, verifique espacios ", "Se produce cuando la sintaxis de la sentencia contiene algun error");
            Tabla_Errores.Add(te10);
            tabla_e te11 = new tabla_e(11, "warning", "asegurese de que las variables no esten repetidas ", "Se produce cuando mas de una variable estan inicializadas con el mismo nombre");
            Tabla_Errores.Add(te11);


        }

        public List<tabla_e> llamatablaE()
        {
            return Tabla_Erroresed;
        }

        public List<string> llamaErrores()
        {
            return Tabla_E;
        } 

        public void agrega_error_l(int id, int nl)
        {
            foreach (var error in Tabla_Errores)
            {

                if (error.Id == id)
                {
                    tabla_e er = new tabla_e();
                    er.Descripcion = error.Descripcion;
                    er.Recomendacion = error.Recomendacion;
                    er.Error = error.Error;
                    er.num_linea = nl;
                    Tabla_Erroresed.Add(er);
                    Tabla_E.Add(er.Descripcion);
                }

            }

        }
        public void agrega_error(int id)
        {
            foreach (var error in Tabla_Errores)
            {

                if (error.Id == id)
                {
                    tabla_e er = new tabla_e();
                    er.Descripcion = error.Descripcion;
                    er.Recomendacion = error.Recomendacion;
                    er.Id = error.Id;
                    Tabla_Erroresed.Add(er);
                    Tabla_E.Add(er.Descripcion);
                }

            }

        }

    }
}
