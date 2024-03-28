//CONTEXTO 
//A Dona Mariana precisa de um sistema para calcular operações matemáticas simples, como adição, subtração, multiplicação e divisão entre dois números. 


//Requisito 01 
//Nossa calculadora deve ter a possibilidade de somar dois números
//Requisito 02 
//Nossa calculadora deve ter a possibilidade de fazer várias operações de soma
//Requisito 03 
//Nossa calculadora deve ter a possibilidade fazer várias operações de soma e de subtração
//Requisito 04 
//Nossa calculadora deve ter a possibilidade fazer as quatro operações básicas da matemática
//Requisito 05 
//Nossa calculadora deve realizar as operações com "0"
//Requisito 06
//Nossa calculadora deve validar a opções do menu 
//Requisito 07
//Nossa calculadora deve realizar as operações com números com duas casas decimais


string decisao = "";
string operador;

do
{
    Console.Clear();
    Console.WriteLine("### Calculadora da Mariana     ###");
    Console.WriteLine("### Vamos escolher a operacao: ###");

    Console.WriteLine("\nDigite uma das teclas para op desejada: ");
    Console.WriteLine("## Soma (s) ");
    Console.WriteLine("## Multiplicação (m) ");
    Console.WriteLine("## Subtração (u) ");
    Console.WriteLine("## Divisão (d) ");
    operador = Console.ReadLine();

    //operacao

    if (operador == "s" || operador == "m" || operador == "u" || operador == "d")
    {
        Console.WriteLine("Primeiro número: ");
        decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Segundo número: ");
        decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());


        switch (operador)
        {
            case "s":
                Console.WriteLine($"Soma: {(primeiroNumero + segundoNumero)}");
                break;

            case "u":
                Console.WriteLine($"Subtração: {(primeiroNumero - segundoNumero)}");
                break;

            case "m":
                Console.WriteLine($"Multiplicação: {(primeiroNumero * segundoNumero)}");
                break;

            case "d":

                if (segundoNumero == 0)
                {
                    Console.WriteLine("Não foi possivel dividir com número 0! ");
                }
                else
                {
                    decimal result = primeiroNumero / segundoNumero;
                    Console.WriteLine($"Divisão: {result.ToString("F2")}");
                }
                break;
            default:
                break;
        }
    }
    else
    {
        Console.WriteLine("Variavel invalida");
    }
    Console.WriteLine("Deseja realizar outra operação?");
    Console.WriteLine("Sim(s)  ou não (n)");
    decisao = Console.ReadLine();



} while (decisao == "s");

Console.WriteLine("Obrigado Mariana, até a próxima! :)");