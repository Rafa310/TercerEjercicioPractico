using System;

namespace Tercer_Ejercicio_Práctico
{
    class Program
    {
        static void Main(string[] args)
        {
            string user, pass, work;
            
            
            int error = 0;
            int[] login = new int[2];
            Double Bonus = 0;
            for (int i = 0; i <= 2; i = i + 1)
            {
                string user1 = "rafael", user2 = "camille", user3 = "Tabibito";
                string generalpass = "151099";
                {
                    Console.WriteLine("bienvenido");
                    Console.WriteLine("Ingrese su usuario y contraseña: ");
                    Console.Write("Usuario: ");
                    user = Console.ReadLine();
                    Console.Write("Contraseña: ");
                    pass = Console.ReadLine();
                    Console.ReadKey();



                    {
                        for (i = 0; i <= 2; i = i + 1)
                        {
                            

                            if (pass == generalpass && user==user1 || pass == generalpass && user == user2 || pass == generalpass && user == user3)
                            {
                                Console.Clear();
                                Console.WriteLine("entraste");
                                Console.ReadKey();
                                Console.Clear();
                                double hours = 0, salary = 0, liquidsal = 0, constant = 0, ISSS = 0, AFP = 0, Rent = 0;



                                Console.WriteLine("Ingrese las horas trabajadas.");
                                hours = Double.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese cual es su cargo");
                                work = Console.ReadLine();
                                if (hours <= 0)
                                {
                                    Console.WriteLine("Ingrese nuevamente los datos.");
                                    i = i - 1;
                                }
                                if (hours <= 160)
                                {
                                    salary = hours * 9.75;
                                }
                                else if (hours > 160)
                                {
                                    constant = 160 * 9.75;
                                    salary = (hours - 160) * 11.50 + constant;

                                }

                                ISSS = salary * 0.0525;
                                AFP = salary * 0.0688;
                                Rent = salary * 0.1;
                                liquidsal = salary - ISSS - AFP - Rent;
                                //Arriba fue calculado el salario liquido realizando los descuentos.
                                if (work == "Gerente" || work == "gerente")
                                {
                                    Bonus = liquidsal * 0.1;
                                    liquidsal = liquidsal + Bonus;
                                }
                                if (work == "Asistente" || work == "asistente")
                                {
                                    Bonus = liquidsal * 0.05;
                                    liquidsal = liquidsal + Bonus;
                                }
                                if (work == "Secretaria" || work == "secretaria")
                                {
                                    Bonus = liquidsal * 0.03;
                                    liquidsal = liquidsal + Bonus;
                                }
                                if (work != "Gerente" || work != "gerente" || work != "Asistente" || work != "asistente" || work != "Secretaria" || work != "secretaria")
                                {
                                    Bonus = liquidsal * 0.02;
                                    liquidsal = liquidsal + Bonus;
                                }
                                Console.WriteLine("Muchas gracias " + user + " sus descuentos son: ");
                                Console.WriteLine("ISSS: $" + ISSS);
                                Console.WriteLine("AFP: $" + AFP);
                                Console.WriteLine("RENTA: $" + Rent);
                                Console.ReadKey();
                                Console.WriteLine("Y su sueldo es: ");
                                Console.WriteLine("Sueldo base: $" + salary);
                                Console.WriteLine("Al aplicarle descuentos y el bono de $" + Bonus + " el total es: ");
                                Console.WriteLine("Sueldo neto: $" + liquidsal);
                                Console.ReadKey();
                                Console.Clear();
                            }

                            else if (pass != generalpass)
                            {
                                if (error <= 3)
                                    Console.WriteLine("intente denuevo");
                                error = error + 1;
                            }



                        }



                    }
                }

            }
        }
    }
}
