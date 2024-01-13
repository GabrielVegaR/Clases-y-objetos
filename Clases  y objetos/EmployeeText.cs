using System.Runtime.ExceptionServices;
using System.Text.Json.Serialization;

namespace Clases__y_objetos
{
    internal class EmployeeText
    {
        static void Main(string[] args)
        {
            //var empleado = new ComissionEmployee("juana", "reyes", "123456", 1000.00M, 0.06M);

            //Console.WriteLine("Informacion de un empleado por comision\n");
            //Console.WriteLine(empleado.ToString());

            ComissionEmployee empleado = null;

            while (true)
            {
                int opcion;
                string firtsName;
                string lastName;
                string socialSecurityNumber;
                decimal grossSales;
                decimal commissionRate;

                Console.WriteLine("1.- crear un empleado por comisión");
                Console.WriteLine("2.- Ver datos del empleado");

                Console.Write("seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch(opcion)
                {
                    case 1:
                        Console.Write("Dijite el nombre del empleado: ");
                        firtsName = Console.ReadLine();
                        Console.Write("Dijite el apellido del empleado: ");
                        lastName = Console.ReadLine();
                        Console.Write("Dijite el numero de seguridad social del empleado: ");
                        socialSecurityNumber = Console.ReadLine();
                        Console.Write("Dijita las ventas brutas del empleado: ");
                        grossSales = decimal.Parse(Console.ReadLine());
                        Console.Write("Dijite la tasa de comisines del empleado: ");
                        commissionRate = decimal.Parse(Console.ReadLine());
                        empleado = new ComissionEmployee(firtsName, lastName, socialSecurityNumber, grossSales, commissionRate);
                        break;

                    case 2:
                        Console.WriteLine(empleado.ToString());
                        break;

                }
            }
        }
    }
}