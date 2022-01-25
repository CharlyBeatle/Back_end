namespace APIMusica.Business.Clases
{
    #region Librerias
    using APIMusica.Business.DTO;
    using APIMusica.Business.Enums;
    using System;
    using System.Collections.Generic;
    #endregion
    public class ClsDictado
    {
        #region Variables y Propiedades
        private Random random = new Random();
        #endregion

        #region Métodos y Funciones

        /// <summary>
        /// Función que realiza la generación de un nuevo dictado
        /// </summary>
        /// <param name="dificultad"></param>
        /// <returns></returns>
        public Dictado GenerarDictado(int dificultad)
        {
            Dictado dictado = new Dictado();
            dictado.Compas = new List<string>();
            var metrica = GenerarMetrica(dificultad);
            dictado.Metrica = metrica.ValorMetrica;
            dictado.MetricaNotas = metrica;
            var cantidadCompas = ObtenerCantidadCompas(dificultad);
            dictado.CantidadCompas = cantidadCompas;
            var nota = GenerarNota();
            dictado.Nota = nota;
            dictado.TextoDictado = string.Format("M: {0} \n| ",dictado.Metrica);
            for (int i = 0; i < cantidadCompas; i++)
            {
                var compas = GenerarCompas(nota, metrica);
                dictado.Compas.Add(compas);
                if(i == 0)
                {
                    dictado.TextoDictado = string.Format("{0}{1}", dictado.TextoDictado, compas);
                } else
                {
                    dictado.TextoDictado = string.Format("{0}|{1}", dictado.TextoDictado, compas);
                }          
            }
            dictado.TextoDictado = string.Format("{0}|", dictado.TextoDictado);
            return dictado;
        }

        /// <summary>
        /// Función que establece la nota que va a llevar el dictado
        /// </summary>
        /// <returns></returns>
        private string GenerarNota()
        {
            var nota = string.Empty;

            var indiceNota = random.Next(1, 7);

            switch (indiceNota)
            {
                case 1: nota = NotaEnum.Do; break;
                case 2: nota = NotaEnum.Re; break;
                case 3: nota = NotaEnum.Mi; break;
                case 4: nota = NotaEnum.Fa; break;
                case 5: nota = NotaEnum.Sol; break;
                case 6: nota = NotaEnum.La; break;
                case 7: nota = NotaEnum.Si; break;
            }
            return nota;
        }

        /// <summary>
        /// Función que define la métrica que tendra el dictado
        /// </summary>
        /// <param name="dificultad">Nivel de dificultad del dictado</param>
        /// <returns></returns>
        private Metrica GenerarMetrica(int dificultad)
        {
            var metrica = new Metrica();
            var indiceMetrica = 0;

            // Se genera un aleatorio de índice de Métrica deacuerdo a la dificutad
            switch (dificultad)
            {
                // Facil
                case 1: indiceMetrica = random.Next(1, 2); break;
                // Intermedio
                case 2: indiceMetrica = random.Next(1, 4); break;
                // Dificil
                case 3: indiceMetrica = random.Next(1, 5); break;

            }

            // Se selecciona métrica de acuerdo a Índice
            switch (indiceMetrica)
            {
                // 2/4
                case 1: metrica = MetricaEnum.Metrica24; break;
                // 3/4
                case 2: metrica = MetricaEnum.Metrica34; break;
                // 2/2
                case 3: metrica = MetricaEnum.Metrica22; break;
                // 4/4
                case 4: metrica = MetricaEnum.Metrica44; break;
                // 6/8
                case 5: metrica = MetricaEnum.Metrica68; break;
            }
            return metrica;
        }

        /// <summary>
        /// Función que genera los compases del dictado
        /// </summary>
        /// <param name="nota"></param>
        /// <param name="compas"></param>
        /// <returns></returns>
        private string GenerarCompas(string nota, Metrica metrica)
        {
            var compas = string.Empty;
            string notaCompas = string.Empty;
            var total = int.Parse(metrica.ValorMetrica.Split('/')[0]);
            double conteo = 0;
            Figura fig = new Figura();
            while (conteo != total)
            {
                fig = metrica.Figuras[random.Next(0, metrica.Figuras.Count - 1)];
                notaCompas = string.Format("{0}{1}",nota, (int)fig.IndiceFigura);
                if (fig.IndiceFigura != FiguraEnum.BlancaPuntillo && fig.IndiceFigura != FiguraEnum.NegraPuntillo)
                {
                    notaCompas = string.Format("{0}{1}", random.Next(0, 1) == 1 ? NotaEnum.Silencio : nota, (int)fig.IndiceFigura);
                }

                if (conteo + fig.Valor <= total)
                {
                    compas = string.Format("{0} {1}", compas, notaCompas);
                    conteo += fig.Valor;
                }
            }
            return compas;
        }

        private bool EvaluarNota()
        {
            return true;
        }

        /// <summary>
        /// Función que establece la cantidad de compases que tendra el dictado, deacuerdo a su dificultad
        /// </summary>
        /// <param name="dificultad"></param>
        /// <returns></returns>
        private int ObtenerCantidadCompas(int dificultad)
        {
            int cantidad = 0;
            switch (dificultad)
            {
                // Facil
                case 1: cantidad = 4; break;
                // Intermedio
                case 2: cantidad = 4; break;
                // Dificil
                case 3: cantidad = 8; break;

            }
            return cantidad;
        }

        #endregion
    }
}
