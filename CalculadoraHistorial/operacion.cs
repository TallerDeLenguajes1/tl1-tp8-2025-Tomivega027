namespace CalculosHistorial
{
    public class Operacion
    {
        private double resultadoAnterior; // Almacena el resultado previo al cálculo actual
        private double nuevoValor; //El valor con el que se opera sobre el resultadoAnterior
        private TipoOperacion operacion;// El tipo de operación realizada
        public double ResultadoAnterior { get => resultadoAnterior; set => resultadoAnterior = value; }
        public double NuevoValor { get => nuevoValor; set => nuevoValor = value; }
        public TipoOperacion Tipo { get => operacion; set => operacion = value; }

        public double Resultado
        {
            /* Lógica para calcular o devolver el resultado */
            get
            {
            switch (operacion)
                {
                    case TipoOperacion.Suma:
                        return resultadoAnterior + nuevoValor;
                    case TipoOperacion.Resta:
                        return resultadoAnterior - nuevoValor;
                    case TipoOperacion.Multiplicacion:
                        return resultadoAnterior * nuevoValor;
                    case TipoOperacion.Division:
                        return resultadoAnterior / nuevoValor;
                    case TipoOperacion.Limpiar:
                        return 0;
                    default:
                        return 0;
                }
            }

        }
        // Propiedad pública para acceder al nuevo valor utilizado en la operación

        // Constructor u otros métodos necesarios para inicializar y gestionar la operación
        // ...
        //contructor para inicializar valores:
        public Operacion(double resultadoAnterior, double nuevoValor, TipoOperacion operacion)
        {
            this.resultadoAnterior = resultadoAnterior;
            this.nuevoValor = nuevoValor;
            this.operacion = operacion;    
        }
    }

        public enum TipoOperacion {
            Suma,
            Resta,
            Multiplicacion,
            Division,
            Limpiar // Representa la acción de borrar el resultado actual o el historial
        }

    }

