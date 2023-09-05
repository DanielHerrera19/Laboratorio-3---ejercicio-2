using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que categoria de hotel desesa: ");
            Console.WriteLine("0: Tres estrellas ");
            Console.WriteLine("1: Cinco estrellas ");
            int categoria = int.Parse(Console.ReadLine());

            Console.WriteLine("Cuantos dias se hospedara");
            int dias = int.Parse(Console.ReadLine());

            int pago = 0;
            int desayuno = 0;
            int pagofinal;

            switch (categoria)
            {
                case 0:
                    if (dias <= 5)
                    {
                        pago = dias * 100;
                    }
                    else if (dias <= 10)
                    {
                        pago = dias * 85;
                    }
                    else if (dias >= 11)
                    {
                        pago = dias * 70;
                    }
                    break;
                case 1:
                    if (dias <= 5)
                    {
                        pago = dias * 300;
                    }
                    else if (dias <= 10)
                    {
                        pago = dias * 270;
                    }
                    else if (dias >= 11)
                    {
                        pago = dias * 250;
                    }
                    break;
            }
            
            desayuno = dias * 7;
            pagofinal = desayuno + pago;
                Console.WriteLine("El pago que debe realizar es de: " + pagofinal + " soles");
                Console.ReadKey();
        }
    }
}