using System;
using System.Data.SqlClient;
using System.Globalization;

/*Conexión más cruda de conectarse a una base de datos.
 *Con consultas directas*/

namespace BaseDeDatos
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                
                BeerDB db = new BeerDB("VENTANAS10", "CSharpDB", "test", "elfruto");
                
                db.Connect();
                List<Beer> beers = db.GetAll();             
                db.Close();

                foreach(Beer beer in beers)
                {
                    //para usar el title case tengo que poner el using globalization y toda
                    //esta mierda 👇👇👇
                    Console.WriteLine(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(beer.Name));
                }

            }catch (SqlException ex)
            {
                Console.WriteLine("No pudimos conetarnos.");
                Console.WriteLine(ex.Message);
            }
            
           
        }
    }

}