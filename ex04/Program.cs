//tipos de dados 

string name = "gabriela";
Console.WriteLine("o nome do usuario é:"    name);

int idade = 19; 
// console.writeLine("A idade do usuario é: " + idade + " anos" );
Console.WriteLine($"A idade do usuario é: {idade} anos ");

float carteira = 2.63f;

char classificação = 'A';
Console.WriteLine($"O CLIENTE É DO TIPO {classificação}");

bool dinheiroNaconta = true;
Console.WriteLine(dinheiroNaconta);

double limiteCredito = 2000.0;
Console.WriteLine("seu limite de crédito é: " + limiteCredito);

string sobrenome = "silva";

string nomeCompleto = name + sobrenome;
Console.WriteLine(nomeCompleto);

double valorConta = 53.73;
Console.WriteLine($"o valor na conta é:{valorConta}");

double limiteTotal = valorConta + limiteCredito;
Console.WriteLine($"o saldo + o limite é {limiteTotal}");


