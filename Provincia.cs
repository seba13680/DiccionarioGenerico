using System;
using System.Collections.Generic;

namespace DiccionarioGenerico
{
     public class Provincia
    {
        public Provincia()
        {
            ProvinciasCapitales = new Dictionary<int, Tuple<string, string>>();

            ProvinciasCapitales.Add(1, new Tuple<string, string>("Buenos Aires", "La Plata"));
            ProvinciasCapitales.Add(2, new Tuple<string, string>("Catamarca", "San Fernando del Valle de Catamarca"));
            ProvinciasCapitales.Add(3, new Tuple<string, string>("Chaco", "Resistencia"));
            ProvinciasCapitales.Add(4, new Tuple<string, string>("Chubut", "Rawson"));
            ProvinciasCapitales.Add(5, new Tuple<string, string>("Córdoba", "Córdoba"));
            ProvinciasCapitales.Add(6, new Tuple<string, string>("Corrientes", "Corrientes"));
            ProvinciasCapitales.Add(7, new Tuple<string, string>("Entre Ríos", "Paraná"));
            ProvinciasCapitales.Add(8, new Tuple<string, string>("Formosa", "Formosa"));
            ProvinciasCapitales.Add(9, new Tuple<string, string>("Jujuy", "San Salvador de Jujuy"));
            ProvinciasCapitales.Add(10, new Tuple<string, string>("La Pampa", "Santa Rosa"));
            ProvinciasCapitales.Add(11, new Tuple<string, string>("La Rioja", "La Rioja"));
            ProvinciasCapitales.Add(12, new Tuple<string, string>("Mendoza", "Mendoza"));
            ProvinciasCapitales.Add(13, new Tuple<string, string>("Misiones", "Posadas"));
            ProvinciasCapitales.Add(14, new Tuple<string, string>("Neuquén", "Neuquén"));
            ProvinciasCapitales.Add(15, new Tuple<string, string>("Río Negro", "Viedma"));
            ProvinciasCapitales.Add(16, new Tuple<string, string>("Salta", "Salta"));
            ProvinciasCapitales.Add(17, new Tuple<string, string>("San Juan", "San Juan"));
            ProvinciasCapitales.Add(18, new Tuple<string, string>("San Luis", "San Luis"));
            ProvinciasCapitales.Add(19, new Tuple<string, string>("Santa Cruz", "Río Gallegos"));
            ProvinciasCapitales.Add(20, new Tuple<string, string>("Santa Fé", "Santa Fé"));
            ProvinciasCapitales.Add(21, new Tuple<string, string>("Santiago del Estero", "Santiago del Estero"));
            ProvinciasCapitales.Add(22, new Tuple<string, string>("Tierra del Fuego, Antártida e Islas del Atlántico Sur", "Ushuaia"));
            ProvinciasCapitales.Add(23, new Tuple<string, string>("Tucumán", "San Miguel De Tucumán"));
        }

        public Dictionary<int, Tuple<string, string>> ProvinciasCapitales { get; set; }

        public Tuple<string, string> Buscar(int BuscarProvincia)
        {
            return ProvinciasCapitales[BuscarProvincia];
        }
    }
}
