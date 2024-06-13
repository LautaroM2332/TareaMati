using System.Xml.Serialization;

namespace TareaMati
{
    public class Producto
    {
        public string[] productos = new string[10];
        public int[] precio = new int[10];
       
        public Producto()
        {

        }

        public void Mostrar()
        {
            for (int i = 0; i < productos.Length; i++) 
            {
                Console.WriteLine($"El nombre del producto es {productos[i]}, tiene un precio de ${precio[i]}");
            }
            Console.WriteLine($"__________________________\nLa cantidad de productos son: {productos.Length}");
        }
    }
}
