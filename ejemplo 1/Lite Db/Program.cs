using LiteDB;
using System;
using System.Linq;

// Define la clase de modelo para los clientes
public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string[] Phones { get; set; }
    public bool IsActive { get; set; }
}

namespace Litedb2
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Abre la base de datos (o la crea si no existe)
            using (var db = new LiteDatabase(@"C:\Users\francisco.paniagua\tempMyData.db"))
            {
                // Obtiene una colección (o la crea si no existe)
                var col = db.GetCollection<Customer>("customers");

                // Crea una nueva instancia de cliente
                var customer = new Customer
                {
                    Name = "josnelll",
                    Phones = new string[] { "8098-5456", "4600-8654" },
                    IsActive = true
                };

                // Inserta un nuevo documento de cliente (el Id se autoincrementa)
                col.Insert(customer);

                // Actualiza un documento dentro de la colección (el cliente recién insertado en este caso)
                customer.Name = "josnell";
                col.Update(customer);

                // Indexa el documento usando la propiedad Name
                col.EnsureIndex(x => x.Name);

                // Utiliza LINQ para consultar documentos (filtrar, ordenar, transformar)
                var results = col.Query()
                    .Where(x => x.Name.StartsWith("J")) // Filtra los clientes cuyo nombre comience con "J"
                    .OrderBy(x => x.Name) // Ordena los resultados por nombre
                    .Select(x => new { x.Name, NameUpper = x.Name.ToUpper() }) // Proyecta solo el nombre y su versión en mayúsculas
                    .Limit(10) // Limita los resultados a 10
                    .ToList(); // Convierte los resultados en una lista

                // Crea un índice en los números de teléfono (usando expresiones). Es un índice multi-clave.
                col.EnsureIndex(x => x.Phones);

                // Ahora podemos consultar los clientes por número de teléfono
                var r = col.FindOne(x => x.Phones.Contains("8188-5525"));
            }
        }
    }
}
