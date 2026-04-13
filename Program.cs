

1. Uma escola deseja registrar as notas finais dos alunos em
uma disciplina. Faça um algoritmo que leia as notas (entre 0
e 100) de diversos alunos e mostre ao final:
 A quantidade de alunos aprovados (nota ≥ 60)
 A quantidade de alunos reprovados (nota < 60)
 A média geral da turma
 A maior nota registrada
double nota = 0, media, soma = 0, maiornota = 0;
int aprovados = 0, reprovados = 0, quantidade = 0;

Console.WriteLine("Digite uma nota de 0 a 100 (ou negativa para sair):");
nota = double.Parse(Console.ReadLine());

while (nota >= 0 && nota <= 100)
{
    if (nota >= 60)
    {
        aprovados++;
    }
    else
    {
        reprovados++;
    }

    soma += nota;
    quantidade++;

    if (quantidade == 1 || nota > maiornota)
    {
        maiornota = nota;
    }

    Console.WriteLine("Digite outra nota (ou negativa para sair):");
    nota = double.Parse(Console.ReadLine());
}

if (quantidade > 0)
{
    media = soma / quantidade;

    Console.WriteLine($"Aprovados: {aprovados}");
    Console.WriteLine($"Reprovados: {reprovados}");
    Console.WriteLine($"Média turma: {media}");
    Console.WriteLine($"Maior nota: {maiornota}");
}
else
{
    Console.WriteLine("Nenhuma nota válida foi informada.");
} 


2. A prefeitura de uma cidade fez uma pesquisa entre seus
habitantes, coletando dados sobre o salário e número de
filhos de cada habitante. A prefeitura deseja saber:
 média do salário da população;
 média do número de filhos;
 maior salário;
 percentual de pessoas com salário até R$ 2.000,00.
 O final da leitura de dados se dará com a entrada de um
salário negativo. 


double salario = 0, somaSalario = 0, maiorSalario = 0;
int filhos = 0, somaFilhos = 0;

int totalPessoas = 0;
int ate2000 = 0;

Console.WriteLine("Digite o salario: ");
salario = double.Parse(Console.ReadLine());

while(salario >=0){
    Console.WriteLine("Digite o número de filhos:");
    filhos = int.Parse(Console.ReadLine());
    somaSalario += salario;
    somaFilhos += filhos;
    totalPessoas++;

    if (totalPessoas == 1 || salario > maiorSalario){
    maiorSalario = salario;
}
    if (salario <= 2000)
{
    ate2000++;
}
    Console.WriteLine("Digite o salário:");
    salario = double.Parse(Console.ReadLine());

}

double mediaSalario = somaSalario / totalPessoas;
double mediaFilhos = (double)somaFilhos / totalPessoas;
double percentual = (double)ate2000 / totalPessoas * 100;

Console.WriteLine($"Média de salário: {mediaSalario}");
Console.WriteLine($"Média de filhos: {mediaFilhos}");
Console.WriteLine($"Maior salário: {maiorSalario}");
Console.WriteLine($"Percentual até R$2000: {percentual}%");

