using System;
using System.Linq;

namespace EjercicioLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Delegados
            //Se definen con func<int,int> donde el primer valor es el que retorna, y los siguientes los parametros que recibe
            //Un delegado siempr retorna algo
            //Func<double, double> exp = CalcularExponente;
            //Console.WriteLine($"Resultado: {exp}");

            //Func<int,int> 
           

            
          


            /*Obtener todos los proyetos mayores a 6 y menores a 12 */
            
            Proyecto proy = new Proyecto();
            proy.proyectos = proy.AgregarProyecto2();
            var lista = proy.proyectos;
            Console.ReadLine();

            Console.WriteLine("proyectos cuya duracion sea mayor a 6 y menor a 12");
            var ProyectosEntre = lista.Where(x => x.Duracion > 6 && x.Duracion < 12).ToList();
            proy.ImprimirProyectos(ProyectosEntre);
            Console.ReadLine();

            Console.WriteLine("Proyectos que empiecen por la letra  'B'");
            var proyectosB = from p in lista
                             where (p.Nombre.StartsWith("B"))
                             select p;
            proy.ImprimirProyectos(proyectosB.ToList());
            Console.ReadLine();

            Console.WriteLine("-----------Obtener todos los proyectos cuyo codigo sea multiplo de 7-----------");
            var proyectMul = lista.Where(x => x.Codigo % 7 == 0).ToList();
            proy.ImprimirProyectos(proyectMul);
            Console.ReadLine();


            Console.WriteLine("-----------Agrupar los proyectos que tenga una duracion superior a 6 y inferior a 10 y los que sean mayor a 10-----------");

            Console.ReadLine();



            Console.WriteLine("-----------obtener el promedio de la duracion de todos los proyectos-----------");
            var avgDura = lista.Average(x => x.Codigo);
            Console.WriteLine("el promedio de la duracion es: " + avgDura);
            Console.ReadLine();


            Console.WriteLine("-----------obtener el nombre del proyecto con mas duracion-----------");
            var maxDura = lista.Max(x => x.Duracion);
            var name = lista.Where(x => x.Duracion == maxDura).Select(x => x.Nombre).FirstOrDefault();
            Console.WriteLine("el proyecto con mas duracion es: " + name);
            Console.ReadLine();

            Console.WriteLine("**Seleccionar el nombre y el area del proyecto con duracion mayor a 6**");
        
            var Dura= lista.Where(x => x.Duracion > 6);
            var NameArea = lista.Where(x => x.Duracion >6).Select(x => x.Nombre, x => x.Area).FirsOrDefault();
           
            Console.ReadLine();

            Console.WriteLine("-----------verificar si existe un proyecto con una duracion superior a 24-----------");
            var takew = lista.TakeWhile(x => x.Duracion>24).ToList();
            proy.ImprimirProyectos(takew);
            Console.ReadLine();

            Console.WriteLine("-----------sumar las duraciones de los proyectos cuyo codigo sea superior a 20-----------");
            var sumaMay = lista.Where(x => x.Codigo > 2o).Sum(x => x.Codigo);
            Console.WriteLine("el proyecto con mas duracion es: " + sumaMay);
            Console.ReadLine();















            //Proyecto project = new Proyecto();
            //    project.proyectos = project.AgregarProyecto2();
            //    project.ImprimirProyectos();
            //    Console.ReadKey();
        }
        //public double CalcularExponente(double x, double y)
        //{
        //    return Math.Pow(x, y);
        //}



    }
    
    }




