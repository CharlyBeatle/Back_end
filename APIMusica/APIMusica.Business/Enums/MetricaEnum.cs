using APIMusica.Business.DTO;
using System.Collections.Generic;

namespace APIMusica.Business.Enums
{
    public static class MetricaEnum
    {
        /// <summary>
        /// Métrica 2/4
        /// </summary>
        public static Metrica Metrica24 = new Metrica
        {
            ValorMetrica = "2/4",
            Figuras = new List<Figura> {
                 new Figura {  IndiceFigura = FiguraEnum.Corchea, NombreFigura = "Semi Corchea",  Valor = 0.5 },
                 new Figura {  IndiceFigura = FiguraEnum.Negra, NombreFigura = "Corchea",  Valor = 1 },
                 new Figura {  IndiceFigura = FiguraEnum.NegraPuntillo, NombreFigura = "Corchea Puntillo",  Valor = 1.5 },
                 new Figura {  IndiceFigura = FiguraEnum.Blanca,NombreFigura = "Negra",  Valor = 2 }
            }
        };

        /// <summary>
        /// Métrica 3/4
        /// </summary>
        public static Metrica Metrica34 = new Metrica
        {
            ValorMetrica = "3/4",
            Figuras = new List<Figura> {
                 new Figura {  IndiceFigura = FiguraEnum.Corchea,  NombreFigura = "Corchea",Valor = 0.5 },
                 new Figura {  IndiceFigura = FiguraEnum.Negra,  NombreFigura = "Negra",Valor = 1 },
                 new Figura {  IndiceFigura = FiguraEnum.NegraPuntillo,  NombreFigura = "Negra Puntillo",Valor = 1.5 },
                 new Figura {  IndiceFigura = FiguraEnum.Blanca,  NombreFigura = "Blanca",Valor = 2 },
                 new Figura {  IndiceFigura = FiguraEnum.BlancaPuntillo,  NombreFigura = "Blanca Puntillo",Valor = 3 }
            }
        };

        /// <summary>
        /// Métrica 3/4
        /// </summary>
        public static Metrica Metrica22 = new Metrica
        {
            ValorMetrica = "2/2",
            Figuras = new List<Figura> {
                 new Figura {  IndiceFigura = FiguraEnum.Corchea,  NombreFigura = "Corchea",Valor = 0.25 },
                 new Figura {  IndiceFigura = FiguraEnum.Negra,  NombreFigura = "Negra",Valor = 0.5 },
                 new Figura {  IndiceFigura = FiguraEnum.Blanca, NombreFigura = "Blanca", Valor = 1 },
                 new Figura {  IndiceFigura = FiguraEnum.BlancaPuntillo,  NombreFigura = "Blanca Puntillo",Valor = 1.5 },
                 new Figura {  IndiceFigura = FiguraEnum.Redonda,  NombreFigura = "Redonda",Valor = 2 }
            }
        };

        /// <summary>
        /// Métrica 4/4
        /// </summary>
        public static Metrica Metrica44 = new Metrica
        {
            ValorMetrica = "4/4",
            Figuras = new List<Figura> {
                 new Figura {  IndiceFigura = FiguraEnum.Corchea,  NombreFigura = "Corchea",Valor = 0.5 },
                 new Figura {  IndiceFigura = FiguraEnum.Negra,  NombreFigura = "Negra",Valor = 1 },
                 new Figura {  IndiceFigura = FiguraEnum.NegraPuntillo,  NombreFigura = "Negra Puntillo",Valor = 1.5 },
                 new Figura {  IndiceFigura = FiguraEnum.Blanca,  NombreFigura = "Blanca",Valor = 2 },
                 new Figura {  IndiceFigura = FiguraEnum.BlancaPuntillo,  NombreFigura = "Blanca Puntillo",Valor = 3 },
                 new Figura {  IndiceFigura = FiguraEnum.Redonda,  NombreFigura = "Redonda",Valor = 4 }
            }
        };

        /// <summary>
        /// Métrica 6/8
        /// </summary>
        public static Metrica Metrica68 = new Metrica
        {
            ValorMetrica = "6/8",
            Figuras = new List<Figura> {
                 new Figura {  IndiceFigura = FiguraEnum.Corchea,  NombreFigura = "Corchea",Valor = 1 },
                 new Figura {  IndiceFigura = FiguraEnum.Negra,  NombreFigura = "Negra",Valor = 2 },
                 new Figura {  IndiceFigura = FiguraEnum.NegraPuntillo,  NombreFigura = "Negra Puntillo",Valor = 3 },
                 new Figura {  IndiceFigura = FiguraEnum.Blanca,  NombreFigura = "Blanca",Valor = 4 },
                 new Figura {  IndiceFigura = FiguraEnum.BlancaPuntillo,  NombreFigura = "Blanca Puntillo",Valor = 6 }
            }
        };


    }
}
