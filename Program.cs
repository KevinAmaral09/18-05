using System;

namespace POO_Personagens
{
    class Program
    {
        static void Main(string[] args)
        {
            personagens personagens = new personagens();

            Console.WriteLine("Olá, qual personagem você deseja escolher:   Personagem 1 - Rock Lee        Personagem 2 - Gaara");
            string personagem1 = (Console.ReadLine());
            string personagem2 = (Console.ReadLine());

            personagem1= "1";
            personagem2 = "2";
            

            if ( == "1")
            {
                Console.WriteLine(@"
|================================|
|              MENU              |
|--------------------------------|
|     Você escolheu Rock Lee:    |
|                                |
|                                |
|                                |
|================================|

                
");
                    Console.WriteLine("Você pode escolher, qual a idade de Rock Lee?");
                    int idade = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Qual sua armadura?");
                    string armadura = Console.ReadLine();
                    
                    Console.WriteLine("Quanto de vida ele tem?");
                    int pontoVida = int.Parse(Console.ReadLine());


            }
            else if(== 2)
            {
                Console.WriteLine(@"
|================================|
|              MENU              |
|--------------------------------|
|     Você escolheu Gaara:       |
|                                |
|                                |
|                                |
|================================|

                
");

                    Console.WriteLine("Você pode escolher, qual a idade de Gaara?");
                    int idade = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Qual sua armadura?");
                    string armadura = Console.ReadLine();
                    
                    Console.WriteLine("Quanto de vida ele tem?");
                    int pontoVida = int.Parse(Console.ReadLine());
           
           
             }

                    Console.WriteLine("Agora vamos pra luta: ");

                    Console.WriteLine(@"
|================================|
|              MENU              |
|--------------------------------|
|           Você deseja:         |
|      1 - Atacar                |
|      2 - Defender              |
|                                |
|================================|
");

                    

             


             



        }
    }
}
