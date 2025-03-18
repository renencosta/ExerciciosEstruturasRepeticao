//1. Contagem de 1 a 20**
//Crie um programa que exiba os números de 1 a 20 na tela.

for (int i = 1; i <= 20; i++ )
{
    Console.WriteLine(i);
}

//2. Validação de senha**
//Peça ao usuário para inserir a senha "1234". Continue pedindo até que ele acerte.

int senha;
do
{
    Console.WriteLine("Informe a senha: ");
    senha = int.Parse(Console.ReadLine());
} while (senha != 1234);
Console.WriteLine("Senha correta");

//3. Tabuada de um número**
//Peça ao usuário um número e exiba a tabuada dele de 1 a 10.

Console.WriteLine("Informe um número: ");
int tabuada = int.Parse(Console.ReadLine());

for (int i = 1; i <=10; i++)
{
    Console.WriteLine(tabuada*i);
}

//4. Contagem regressiva**
//Peça um número ao usuário e faça uma contagem regressiva até 0.

//5. Média de notas**
//Solicite notas ao usuário (entre 0 e 10) até que ele insira um número inválido. Depois, exiba a média das notas.

//6. Somatório de números positivos**
//Escreva um programa que peça números ao usuário e some-os, parando quando o usuário inserir um número negativo.

//7. Número primo**
//Peça ao usuário um número e determine se ele é primo.

//8. Sequência de Fibonacci**
//Peça um número N ao usuário e exiba os N primeiros termos da sequência de Fibonacci.

//9. Adivinhe o número**
//O programa escolhe um número aleatório entre 1 e 100. O usuário tenta adivinhar e o programa dá dicas.
