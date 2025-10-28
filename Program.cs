using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    class Program
    {
        public class App
        {
            static void Main()
            {


                Quadrado quadrado1 = new Quadrado(5);  
                quadrado1.Area();
                quadrado1.Perimetro();

                Retangulo retangulo1 = new Retangulo(5, 10);
                retangulo1.Area();
                retangulo1.Perimetro();

                Circulo circulo1 = new Circulo(4);
                circulo1.Area();
                circulo1.Perimetro();

            }
            public interface FormaGeometrica
            {     
                void Area();
                void Perimetro();
            }
            public class Quadrado : FormaGeometrica
            {
                
                protected double Lado;


                public Quadrado(double lado){

                    Lado = lado;

                }

                public void Area(){
                    
                    double area = Lado * Lado;
                    Console.WriteLine("A area do quadrado é = " + area);

                }
                public void Perimetro(){    
                   
                     double perimetro = Lado * 4;
                     Console.WriteLine("O perimetro do quadrado é = " + perimetro);                                       
                }
            }
                public class Retangulo : FormaGeometrica
                {

                    protected double Base;
                    protected double Altura;

                    public Retangulo(double _base, double altura)
                    {

                        Base = _base;
                        Altura = altura;
                    }

                    public void Area()
                    {

                        double area = Base * Altura;
                        Console.WriteLine("A area do retangulo é = " + area);

                    }
                    public void Perimetro()
                    {

                        double perimetro = 2 * (Base + Altura);
                        Console.WriteLine("O perimetro do retangulo é = " + perimetro);
                    }

                }

            public class Circulo : FormaGeometrica
            {

                protected double Raio;

                public Circulo(double raio)
                {

                    Raio = raio;
                }

                public void Area()
                {

                    double area = Math.PI * (Raio * Raio);
                    Console.WriteLine("A area do circulo é = " + area);

                }
                public void Perimetro()
                {

                    double perimetro = 2 * (Math.PI * Raio);
                    Console.WriteLine("O perimetro do retangulo é = " + perimetro);
                }
            
             }
           }
        }      
     } 
    
  
 

