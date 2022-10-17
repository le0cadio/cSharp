int soma = 0, numero = 0;

do
{
    Console.WriteLine("Digite um número: (0 para parar)");
    numero = Convert.ToInt32(Console.ReadLine());
    soma += numero;
} while (numero != 0);

Console.WriteLine("A soma dos números digitados é: " + soma);









// int numero = 5;
// int contador = 0;


// while (contador <= 10)
// {
//    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//    contador ++;
// }







//laço de repetição FOR

// int numero = 2;

// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }
