using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Program : Telefono
    {
        static void Main(string[] args)


        {
            Console.WriteLine("------------------MENU DE OPCIONES----------------------");
            Console.WriteLine("                                                        ");
            Console.WriteLine("              1. TELEFONOS INTELIGENTES                 ");
            Console.WriteLine("               2. TELEFONOS BASICOS                     ");
            Console.WriteLine("                 3.Agregar productos                    ");
            Console.WriteLine("                 4.Mostrar inventario                   ");
            Console.WriteLine("                      5. salir                          ");
            Console.Write("------------------DIGITE LA OPCION---------------------");
            int opcion = Convert.ToInt32(Console.ReadLine());
            List<Telefono> InventarioTelefonos = new List<Telefono>();
            switch (opcion)
            {

                case 1:
                    
                   
                    TelefonoInteligente inteligente = new TelefonoInteligente
                    {
                        Marca = "Samsung",
                        Modelo = "Galaxy S22 Ultra",
                        Precio = 23773.88,
                        Stock = 30,
                        SistemaOperativo = "Android 12",
                        MemoriaRAM = 12
                    };

                    inteligente.MostrarInformacionInteligente();
                    Console.WriteLine("---------------------------------------------------------------------------------------------------");
                    break;
                case 2:

                    TelefonoBasico basico = new TelefonoBasico
                    {
                        Marca = "redmi",
                        Modelo = "Smartphone Xiaomi Redmi Note 13 Pro",
                        Precio = 7498,
                        Stock = 30,
                        TieneRadioFM = true,
                        Tienelinterna = true
                    };
                    basico.MostrarInformacionBasico();
                    Console.WriteLine("---------------------------------------------------------------------------------------------------");

                    break;

                case 3:
                    Console.WriteLine("Seleccione el tipo de producto a agregar:");
                    Console.WriteLine("1. Galaxy S22 Ultra");
                    Console.WriteLine("2. Smartphone Xiaomi Redmi Note 13 Pro");
                    Console.WriteLine("3. nuevos dipositivo" +
                        "");
                    int productoSeleccionado = Convert.ToInt32(Console.ReadLine());

                    switch (productoSeleccionado)
                    {
                        case 1:
                            AgregarProducto("Samsung", "Galaxy S22 Ultra", 27733.88, 30, InventarioTelefonos);
                            break;
                        case 2:
                            AgregarProducto("Redmi", "Smartphone Xiaomi Redmi Note 13 Pro", 7498, 30, InventarioTelefonos);
                            break;
                        case 3:
                            Console.WriteLine("Ingrese los detalles del nuevo producto:");
                            Console.Write("Marca: ");
                            string marca = Console.ReadLine();
                            Console.Write("Modelo: ");
                            string modelo = Console.ReadLine();
                            Console.Write("Precio: ");
                            double precio = double.Parse(Console.ReadLine());
                            Console.Write("Stock: ");
                            int stock = Int32.Parse(Console.ReadLine());
                            AgregarProducto(marca, modelo, precio, stock, InventarioTelefonos);
                            break;
                        default:
                            Console.WriteLine("Producto no reconocido. Intenta nuevamente.");
                            break;
                    }
                    break;
                case 4:
                    MostrarInventario(InventarioTelefonos);
                    break;

                case 5:
                    Console.WriteLine("Saliendo...");
                    break;
                default:

                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                    break;
            }

              void AgregarProducto(string marca, string modelo, double precio, int stock, List<Telefono> inventario)
             {
                var nuevoTelefono = new Telefono { Marca = marca, Modelo = modelo, Precio = precio, Stock = stock };
                inventario.Add(nuevoTelefono);
                Console.WriteLine($"Producto '{modelo}' agregado exitosamente al inventario.");
             }

            void MostrarInventario(List<Telefono> inventario)
            {
                if (InventarioTelefonos.Count > 0)
                {
                    Console.WriteLine("---------------INVENTARIO DE TELEFONOS:------------------");
                    foreach (var telefono in InventarioTelefonos)
                    {
                        Console.WriteLine($"Marca: {telefono.Marca}, Modelo: {telefono.Modelo}, Precio: {telefono.Precio}, Stock: {telefono.Stock}");
                    }
                }
                else
                {
                    Console.WriteLine("El inventario está vacío.");
                }
            }
        }
    }
}

            
        





