
//  dsesnvolva um programa em c# que calcule a média de um aluno a partir de três notas fornecidas pelo usuário. O programa deve solicitar que o usuário insira as três notas e, em seguida, calcular a média aritmética dessas notas. Após calcular a média, o programa deve determinar a situação do aluno com base nos seguintes critérios: se a média for maior ou igual a 7, o aluno será considerado "Aprovado"; se a média estiver entre 4 (inclusivo) e 7 (exclusivo), o aluno estará "Em recuperação"; e se a média for menor que 4, o aluno será classificado como "Reprovado". O programa deve exibir a média calculada e a situação do aluno de forma clara e organizada. Este exercício tem como objetivo praticar o cálculo de médias e a utilização de estruturas condicionais em C#.

Console.WriteLine("digite a primeira nota");
double nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("digite a segunda nota");
double nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("digite a terceira nota");
double nota3 = double.Parse(Console.ReadLine());

// calcular a média 
double média = (nota1 + nota2 + nota3) / 3;
Console.Clear();

//verificar a situação do aluno 

if (média >= 7)
{
    Console.WriteLine($"Aluno(a) aprovado(a) Média: {média}");
}
else if (média <= 4)
{ 
    Console.WriteLine($"Alunoaa(a) recuperação: Média: {média}");
}
else
{
    Console.WriteLine($"Aluno(a) reprovado(a): Média: {média}");
}