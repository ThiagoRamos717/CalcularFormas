using CalcularAreaFormas.POO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CalcularAreaFormas.POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Formas triangulo = new Formas();
            Formas quadrado = new Formas();
            Formas circulo = new Formas();
            Formas retangulo = new Formas();
            Formas losango = new Formas();
            Formas paralelogramo = new Formas();
            Formas trapezio = new Formas();

            Formas[] figuras = new Formas[7];
            figuras[0] = triangulo;
            figuras[1] = quadrado;
            figuras[2] = circulo;
            figuras[3] = retangulo;
            figuras[4] = losango;
            figuras[5] = paralelogramo;
            figuras[6] = trapezio;

            int obj = 0;

            Console.WriteLine("╔═══════════════════╗");
            Console.WriteLine("║ Escolha o objeto: ║");
            Console.WriteLine("╔═══════════════════╗ ");
            Console.WriteLine("║ 1- Triângulo.     ║");
            Console.WriteLine("║ 2- Quadrado.      ║");
            Console.WriteLine("║ 3- Círculo.       ║");
            Console.WriteLine("║ 4- Retângulo.     ║");
            Console.WriteLine("║ 5- Losango.       ║");
            Console.WriteLine("║ 6- Paralelogramo. ║");
            Console.WriteLine("║ 7- Trapézio.      ║");
            Console.WriteLine("╚═══════════════════╝");
            obj = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (obj)
            {
                case 1:
                    Console.WriteLine("╔════════════════════════════╗");
                    Console.WriteLine("║ Você selecionou Triângulo! ║");
                    Console.WriteLine("╚════════════════════════════╝");
                    Console.WriteLine();
                    Console.WriteLine("Qual o valor da Altura?");
                    triangulo.BaseObjeto = double.Parse(Console.ReadLine());
                    Console.WriteLine("Qual o valor da Base?");
                    triangulo.Altura = double.Parse(Console.ReadLine());

                    //Calculando Área.
                    triangulo.Resultado = (triangulo.BaseObjeto * triangulo.Altura / 2);
                    Console.WriteLine("Área é de: {0}", triangulo.Resultado);

                    //Calculando Perímetro.
                    triangulo.Perimetro = (triangulo.Altura * 2 + triangulo.BaseObjeto);
                    Console.WriteLine("Perímetro: " + triangulo.Perimetro);
                    Console.ReadKey();
                    break;

                case 2:

                    Console.WriteLine("╔═══════════════════════════╗");
                    Console.WriteLine("║ Você selecionou Quadrado! ║");
                    Console.WriteLine("╚═══════════════════════════╝");
                    Console.WriteLine();
                    Console.WriteLine("Qual o valor da Altura?");
                    quadrado.Altura = int.Parse(Console.ReadLine());

                    //Calculando Área.
                    quadrado.Resultado = (quadrado.Altura * quadrado.Altura);
                    Console.WriteLine("Área : {0}", quadrado.Resultado);

                    //Calculando Perímetro.
                    quadrado.Perimetro = (quadrado.Altura * 4);
                    Console.WriteLine("Perímetro: " + quadrado.Perimetro);

                    Console.ReadKey();
                    break;

                case 3:

                    Console.WriteLine("╔══════════════════════════╗");
                    Console.WriteLine("║ Você selecionou Círculo! ║");
                    Console.WriteLine("╚══════════════════════════╝");
                    Console.WriteLine();
                    Console.WriteLine("Qual o valor do Raio?");
                    circulo.Raio = int.Parse(Console.ReadLine());

                    //Calculando Área.
                    circulo.Resultado = (Math.PI * Math.Pow(circulo.Raio, 2));
                    Console.WriteLine("Área é de: {0}", circulo.Resultado);

                    //Calculando Perímetro.
                    circulo.Perimetro = (2 * 3.14) * circulo.Raio;
                    Console.WriteLine("Perímetro: " + circulo.Perimetro);

                    Console.ReadKey();
                    break;

                case 4:

                    Console.WriteLine("╔════════════════════════════╗");
                    Console.WriteLine("║ Você selecionou Retângulo! ║");
                    Console.WriteLine("╚════════════════════════════╝");
                    Console.WriteLine();
                    Console.WriteLine("Qual o valor da Altura?");
                    retangulo.Altura = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual o valor da Base?");
                    retangulo.BaseObjeto = int.Parse(Console.ReadLine());

                    //Calculando Área.
                    retangulo.Resultado = (retangulo.BaseObjeto * retangulo.Altura);
                    Console.WriteLine("Área é de: {0}", retangulo.Resultado);

                    //Calculando Perímetro.
                    retangulo.Perimetro =  (retangulo.BaseObjeto + retangulo.Altura) * 2;
                    Console.WriteLine("Perímetro: " + retangulo.Perimetro);

                    Console.ReadKey();
                    break;

                case 5:

                    Console.WriteLine("╔══════════════════════════╗");
                    Console.WriteLine("║ Você selecionou Losango! ║");
                    Console.WriteLine("╚══════════════════════════╝");
                    Console.WriteLine();
                    Console.WriteLine("Qual a diagonal Maior?");
                    losango.DiagonalMaior = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual a diagonal Menor?");
                    losango.DiagonalMenor = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual é o valor do Lado?");
                    losango.Lado = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    //Calculando Área.
                    losango.Resultado = (losango.DiagonalMaior * losango.DiagonalMenor ) / 2;
                    Console.WriteLine("Área é de: {0}", losango.Resultado);
                    
                    //Calculando Perímetro.
                    losango.Perimetro = losango.Lado * 4;
                    Console.WriteLine("Perímetro: " + losango.Perimetro);

                    Console.ReadKey();
                    break;

                case 6:

                    Console.WriteLine("╔════════════════════════════════╗");
                    Console.WriteLine("║ Você selecionou Paralelogramo! ║");
                    Console.WriteLine("╚════════════════════════════════╝");
                    Console.WriteLine();
                    Console.WriteLine("Qual o valor da Altura?");
                    paralelogramo.Altura = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual o valor da Base?");
                    paralelogramo.BaseObjeto = int.Parse(Console.ReadLine());

                    //Calculando Área.
                    paralelogramo.Resultado = paralelogramo.Altura * paralelogramo.BaseObjeto;
                    Console.WriteLine("Área é de: {0}", paralelogramo.Resultado);

                    //Calculando Perímetro.
                    paralelogramo.Perimetro = (paralelogramo.Altura + paralelogramo.BaseObjeto) * 2;
                    Console.WriteLine("Perímetro: " + paralelogramo.Perimetro);

                    Console.ReadKey();
                    break;

                case 7:
                    
                    Console.WriteLine("╔═══════════════════════════╗");
                    Console.WriteLine("║ Você selecionou Trapézio! ║");
                    Console.WriteLine("╚═══════════════════════════╝");
                    Console.WriteLine();
                    Console.WriteLine("Qual o valor da base Maior?");
                    trapezio.BaseMaior = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual o valor da base Menor?");
                    trapezio.BaseMenor = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual o valor da Altura?");
                    trapezio.Altura = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual é o valor do Lado?");
                    trapezio.Lado = int.Parse(Console.ReadLine());

                    //Calculando Área.
                    trapezio.Resultado = (trapezio.BaseMaior + trapezio.BaseMenor) * trapezio.Altura / 2;
                    Console.WriteLine("Área: {0}", trapezio.Resultado);
                    
                    //Calculando Perímetro.
                    trapezio.Perimetro = (trapezio.Lado * 2) + trapezio.BaseMaior + trapezio.BaseMenor;
                    Console.WriteLine("Perímetro: " + trapezio.Perimetro);

                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine("---------------------------");
                    break;
            }
        }
    }
}


