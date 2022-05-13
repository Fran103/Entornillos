using System;

 namespace FechaProg
{
        public class Fecha
        {
        private int d;
        private int m;
        private int a;
        private bool bisiesto;

        public int D { get; set; }
        public int M { get; set; }
        public int A { get; set; }

        //TODO validar los valores introducidos
        /// <summary>
        /// Constructor de Fecha sin parámetros
        /// Se establecen los valores a 1
        /// </summary>
        public Fecha()
            {
                D = 1;
                M = 1;
                A = 1;
            }
            /// <summary>
            /// Constructor de Fecha con 3 parámetros
            /// Si algún parámetro no es correcto se establece a 1
            /// </summary>
            /// <param name="mes">Mes</param>
            /// <param name="anyo">Anyo (entre 1 y 2500)</param>
            /// <param name="dia">Dia</param>
            /// <param name="bi">Indica si es bisiesto</param>
            public Fecha(int mes, int anyo, int dia)
            {
                if (anyo >= 1 && anyo <= 2500)
                {
                    this.A = anyo;
                }
                else
                {
                    this.A = 1;
                }
                if ((A % 400 == 0) || ((A % 4 == 0) && (A % 100 != 0)))
                    bisiesto = true;
                else bisiesto = false;
                if (mes >= 1 && mes <= 12)
                    this.M = mes;
                else
                    this.M = 1;
                int diasMes = 0;
                switch (M)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        diasMes = 31;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        diasMes = 30;
                        break;
                    case 2: // verificación de año bisiesto
                        if (bisiesto)
                            diasMes = 29;
                        else
                            diasMes = 28;
                        break;
                }
                
            if (dia >= 1 && dia <= diasMes)
                    this.D = dia;
                else
                    this.D = 1;
            }
            public bool EsBisiesto()
            {
                if ((A % 400 == 0) || ((A % 4 == 0) && (A % 100 != 0)))
                    bisiesto = true;
                else
                    bisiesto = false;
                return bisiesto;
            }
            /// <summary>
            /// Devuelve un string con la fecha en formato dia/mes/anyo
            /// </summary>
            /// <remarks> la palabra clave override indica que se sobreescribe el metodo ToString</remarks>
            /// <returns>un string con la fecha en formato dia/mes/anyo</returns>
            public override string ToString()
            {
                return D + "/" + M + "/" + A;
            }
        }
    
}