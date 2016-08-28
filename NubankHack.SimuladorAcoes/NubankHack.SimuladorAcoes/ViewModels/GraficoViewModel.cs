using System.Collections.Generic;

namespace NubankHack.SimuladorAcoes.ViewModels
{
    public class GraficoViewModel
    {
        public int IdEmpresa { get; set; }
        public List<CoordenadasGrafico> Coordenadas { get; set; }
    }

    public class CoordenadasGrafico
    {
        public int x { get; set; }
        public decimal y { get; set; }
    }

    public static class GetDataGrafico
    {
        public static List<GraficoViewModel> GetListDadosGrafico()
        {
            return new List<GraficoViewModel>()
            {
                                new GraficoViewModel() {
                    IdEmpresa = 1,
                    Coordenadas = new List<CoordenadasGrafico>() {
                        new CoordenadasGrafico() { x = 10, y = 19.35m },
                        new CoordenadasGrafico() { x = 11, y = 19.31m },
                        new CoordenadasGrafico() { x = 12, y = 19.38m },
                        new CoordenadasGrafico() { x = 13, y = 19.16m },
                        new CoordenadasGrafico() { x = 14, y = 19.23m },
                        new CoordenadasGrafico() { x = 15, y = 19.13m },
                        new CoordenadasGrafico() { x = 16, y = 19.19m },
                        new CoordenadasGrafico() { x = 17, y = 19.19m },
                    }
               },
                new GraficoViewModel() {
                    IdEmpresa = 2,
                    Coordenadas = new List<CoordenadasGrafico>() {
                        new CoordenadasGrafico() { x = 10, y = 12.53m },
                        new CoordenadasGrafico() { x = 11, y = 12.63m },
                        new CoordenadasGrafico() { x = 12, y = 12.80m },
                        new CoordenadasGrafico() { x = 13, y = 12.70m },
                        new CoordenadasGrafico() { x = 14, y = 12.66m },
                        new CoordenadasGrafico() { x = 15, y = 12.54m },
                        new CoordenadasGrafico() { x = 16, y = 12.50m },
                        new CoordenadasGrafico() { x = 17, y = 12.55m },
                    }
               },
                new GraficoViewModel() {
                    IdEmpresa = 3,
                    Coordenadas = new List<CoordenadasGrafico>() {
                        new CoordenadasGrafico() { x = 10, y = 15.41m },
                        new CoordenadasGrafico() { x = 11, y = 15.50m },
                        new CoordenadasGrafico() { x = 12, y = 15.62m },
                        new CoordenadasGrafico() { x = 13, y = 15.52m },
                        new CoordenadasGrafico() { x = 14, y = 15.46m },
                        new CoordenadasGrafico() { x = 15, y = 15.10m },
                        new CoordenadasGrafico() { x = 16, y = 15.04m },
                        new CoordenadasGrafico() { x = 17, y = 15.07m },
                    }
               },
                new GraficoViewModel() {
                    IdEmpresa = 4,
                    Coordenadas = new List<CoordenadasGrafico>() {
                        new CoordenadasGrafico() { x = 10, y = 28.90m },
                        new CoordenadasGrafico() { x = 11, y = 28.97m },
                        new CoordenadasGrafico() { x = 12, y = 29.04m },
                        new CoordenadasGrafico() { x = 13, y = 29.15m },
                        new CoordenadasGrafico() { x = 14, y = 29.14m },
                        new CoordenadasGrafico() { x = 15, y = 28.92m },
                        new CoordenadasGrafico() { x = 16, y = 28.77m },
                        new CoordenadasGrafico() { x = 17, y = 28.91m },
                    }
               },
                new GraficoViewModel() {
                    IdEmpresa = 5,
                    Coordenadas = new List<CoordenadasGrafico>() {
                        new CoordenadasGrafico() { x = 10, y = 14.13m },
                        new CoordenadasGrafico() { x = 11, y = 14.09m },
                        new CoordenadasGrafico() { x = 12, y = 14.06m },
                        new CoordenadasGrafico() { x = 13, y = 14.06m },
                        new CoordenadasGrafico() { x = 14, y = 14.09m },
                        new CoordenadasGrafico() { x = 15, y = 14.06m },
                        new CoordenadasGrafico() { x = 16, y = 14.11m },
                        new CoordenadasGrafico() { x = 17, y = 14.14m },
                    }
               },
                new GraficoViewModel() {
                    IdEmpresa = 6,
                    Coordenadas = new List<CoordenadasGrafico>() {
                        new CoordenadasGrafico() { x = 10, y = 30.20m },
                        new CoordenadasGrafico() { x = 11, y = 30.11m },
                        new CoordenadasGrafico() { x = 12, y = 30.13m },
                        new CoordenadasGrafico() { x = 13, y = 30.28m },
                        new CoordenadasGrafico() { x = 14, y = 30.31m },
                        new CoordenadasGrafico() { x = 15, y = 30.30m },
                        new CoordenadasGrafico() { x = 16, y = 30.27m },
                        new CoordenadasGrafico() { x = 17, y = 30.49m },
                    }
               },
                new GraficoViewModel() {
                    IdEmpresa = 7,
                    Coordenadas = new List<CoordenadasGrafico>() {
                        new CoordenadasGrafico() { x = 10, y = 2.40m },
                        new CoordenadasGrafico() { x = 11, y = 2.33m },
                        new CoordenadasGrafico() { x = 12, y = 2.42m },
                        new CoordenadasGrafico() { x = 13, y = 2.41m },
                        new CoordenadasGrafico() { x = 14, y = 2.46m },
                        new CoordenadasGrafico() { x = 15, y = 2.39m },
                        new CoordenadasGrafico() { x = 16, y = 2.38m },
                        new CoordenadasGrafico() { x = 17, y = 2.37m },
                    }
               },
                new GraficoViewModel() {
                    IdEmpresa = 8,
                    Coordenadas = new List<CoordenadasGrafico>() {
                        new CoordenadasGrafico() { x = 10, y = 6.30m },
                        new CoordenadasGrafico() { x = 11, y = 6.18m },
                        new CoordenadasGrafico() { x = 12, y = 6.18m },
                        new CoordenadasGrafico() { x = 13, y = 6.18m },
                        new CoordenadasGrafico() { x = 14, y = 6.18m },
                        new CoordenadasGrafico() { x = 15, y = 6.18m },
                        new CoordenadasGrafico() { x = 16, y = 6.23m },
                        new CoordenadasGrafico() { x = 17, y = 6.10m },
                    }
               },
                new GraficoViewModel() {
                    IdEmpresa = 9,
                    Coordenadas = new List<CoordenadasGrafico>() {
                        new CoordenadasGrafico() { x = 10, y = 2.86m },
                        new CoordenadasGrafico() { x = 11, y = 2.82m },
                        new CoordenadasGrafico() { x = 12, y = 2.76m },
                        new CoordenadasGrafico() { x = 13, y = 2.78m },
                        new CoordenadasGrafico() { x = 14, y = 2.79m },
                        new CoordenadasGrafico() { x = 15, y = 2.76m },
                        new CoordenadasGrafico() { x = 16, y = 2.76m },
                        new CoordenadasGrafico() { x = 17, y = 2.74m },
                    }
               },
                new GraficoViewModel() {
                    IdEmpresa = 10,
                    Coordenadas = new List<CoordenadasGrafico>() {
                        new CoordenadasGrafico() { x = 10, y = 12.20m },
                        new CoordenadasGrafico() { x = 11, y = 12.20m },
                        new CoordenadasGrafico() { x = 12, y = 12.20m },
                        new CoordenadasGrafico() { x = 13, y = 12.42m },
                        new CoordenadasGrafico() { x = 14, y = 12.40m },
                        new CoordenadasGrafico() { x = 15, y = 12.40m },
                        new CoordenadasGrafico() { x = 16, y = 12.48m },
                        new CoordenadasGrafico() { x = 17, y = 12.48m },
                    }
               },
                new GraficoViewModel() {
                    IdEmpresa = 11,
                    Coordenadas = new List<CoordenadasGrafico>() {
                        new CoordenadasGrafico() { x = 10, y = 2.20m },
                        new CoordenadasGrafico() { x = 11, y = 2.26m },
                        new CoordenadasGrafico() { x = 12, y = 2.26m },
                        new CoordenadasGrafico() { x = 13, y = 2.20m },
                        new CoordenadasGrafico() { x = 14, y = 2.15m },
                        new CoordenadasGrafico() { x = 15, y = 2.20m },
                        new CoordenadasGrafico() { x = 16, y = 2.20m },
                        new CoordenadasGrafico() { x = 17, y = 2.21m },
                    }
               },

            };
        }
    }
}