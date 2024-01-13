using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases__y_objetos
{
    internal class ComissionEmployee
    {
        ////propiedades o atributos de un empleado por comision
        //private string firstName;
        //private string lastName;
        //private int socialSecurityNumber;
        //private decimal salary;

        ////propiedades o menotos getters y setters
        //public string FirstName
        //{
        //    get
        //    {
        //        return firstName;
        //    }
        //    set
        //    {
        //        firstName = value;
        //    }
        //}

        //propiedades autogeneradas

        public string FirstName { get; }
        public string LastName { get; }
        public string SocialSecurityNumber { get; }

        //atributos
        private decimal grossSales;
        private decimal commissionRate;

        //propiedades para controlar los accesos a los atributos
        public decimal GrossSales
        {
            get
            {
                return grossSales;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error, las ventas totales deben ser 0 o mas");
                    return;
                }
                grossSales = value;
            }
        }

        public decimal CommissionRate
        {
            get
            {
                return commissionRate;
            }
            set
            {
                if (value < 0 || value >= 1)
                {
                    Console.WriteLine("La tasa de comisiones debe ser menor que 1");
                    return;
                }
                commissionRate = value;
            }
        }

        //constructor
        public ComissionEmployee(string firstName, string lastName, string socialSecurityNumber, decimal grossSales, decimal commissionRate)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
            GrossSales = grossSales;
            CommissionRate = commissionRate;
        }

        public ComissionEmployee(string firstName, string lastName, string socialSecurityNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
        }

        //metodos para brindar los sevicios de clase
        public decimal Earnings()
        {
            return commissionRate * grossSales;
        }

        public override string ToString()
        {
            return $"Empleado por comisión: {FirstName} {LastName}\n" +
                $"Numero de seguridad social: {SocialSecurityNumber}\n" +
                $"Ventas Brutas: {GrossSales:C}\n" +
                $"Tasa de comisiones: {CommissionRate}\n" +
                $"Ganancias del empleado: {Earnings():C}\n";
        }
    }
}
