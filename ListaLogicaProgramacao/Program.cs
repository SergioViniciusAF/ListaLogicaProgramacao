using System;

namespace ListaLogicaProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double media = 0;
                double gastoCombustivel = 0;
                double salarioComissao = 0;

                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("1 Leia dois números, calcule a média entre eles e mostre o resultado na tela ");
                Console.WriteLine("2 Saber o consumo médio de um automóvel");
                Console.WriteLine("3 solicitar o nome do vendedor,seu salario fixo,valor em vendas,imprimir o nome,salario fixo e com comissão de 15%");
                Console.WriteLine("Opção escolhida: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("digite um numero");
                        double numero1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("digite outro numero");
                        double numero2 = double.Parse(Console.ReadLine());
                        media = (numero1 + numero2) / 2;

                        Console.WriteLine("A Media é: " + media);
                        break;
                    case 2:

                        Console.WriteLine("Qual distancia total percorrida?");
                        double distanciaTotal= double.Parse(Console.ReadLine());
                        Console.WriteLine("Quantos Litros de combustivel, foram gasto?");
                        double combustivel = double.Parse(Console.ReadLine());
                        gastoCombustivel = distanciaTotal / combustivel;

                        Console.WriteLine("Consumo de Combustivel por Km é: " + gastoCombustivel);
                        break;
                     case 3:
                        Console.WriteLine("Digite Seu Nome");
                        string nome = Console.ReadLine();

                        Console.WriteLine("Digite Seu Salario");
                        double salario = double.Parse(Console.ReadLine());
                        Console.WriteLine("Valor em vendas no mês");
                        double vendas = double.Parse(Console.ReadLine());
                        salarioComissao = salario+ vendas* 15/100;

                        Console.WriteLine("O vendedor : " + nome);
                        Console.WriteLine("Seu Salario é R$:" + salario);
                        Console.WriteLine("Vendeu R$ :" + vendas);
                        Console.WriteLine("Salario com Comissão de 15% R$ :" + salarioComissao);
                        break;


                    default:
                        Console.WriteLine("Opção não encontrada");

                        break;
                }
                
            }
            catch (Exception)
            {

                Console.WriteLine("Não é Possivel fazer o cálculo");
            }
          

        }
    }
}
