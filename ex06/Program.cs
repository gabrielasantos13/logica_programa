// solicitar 2 numeros ao usuario e realizar teste logico 

Console.WriteLine("N1");
double N1 = double.Parse(Console.ReadLine());

Console.WriteLine("N2");
double N2 = double.Parse(Console.ReadLine());

Console.WriteLine($"N1 é maior que N2? resposta: {N1 > N2 }" );
Console.WriteLine($"N1 é maior ou igual a N2? resposta: {N1 >= N2}");
Console.WriteLine($"N1 é menor que N2? resposta: {N1 < N2}");
Console.WriteLine($"N1 é menor ou igual a N2? resposta: {N1 <= N2}");
Console.WriteLine($"N1 é igual a N2? resposta: {N1 == N2}");
Console.WriteLine($"N1 é diferente a N2? resposta? {N1!=N2}");
Console.WriteLine($"N1 ou N2 são maior que zero? resposta: {(N1 > 0|| N2 > 0)}");
Console.WriteLine($"N1 e N2 são maior que zero? resposta; {(N1 > 0 && N2 > 0)}");



