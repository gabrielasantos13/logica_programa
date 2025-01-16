Console.WriteLine("informe o primeiro numero");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("informe o segundo numero");
double num2 = double.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine("soma : " + (num1 + num2));
Console.WriteLine("subitração :" + (num1 - num2));
Console.WriteLine("multiplicação : " + (num1 * num2));
Console.WriteLine("divisão : " + ( num1 / num2));

if (num2 != 0)
{
    Console.WriteLine("divisão ; " + (num1 / num2));

}else
{
    Console.WriteLine("divisão por zero não permitida ");
}
