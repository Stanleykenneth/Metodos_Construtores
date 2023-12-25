using ExemploExplorando.Models;
using System.Globalization;

DateTime data = DateTime.Now; // Retorna a Data atual do sistema
Console.WriteLine(data);
Console.WriteLine(data.ToString("dd/MM/yy HH:mm"));
















// // FORMATANDO VALORES MONETÁRIOS

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 82.40M;

// Console.WriteLine($"{valorMonetario:C}");

// // FORMATANDO PORCENTAGEM

// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P"));
// Console.WriteLine($"{porcentagem:P}");

// // TRABALHANDO COM DIGITOS EM

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));



















// Pessoa p1 = new Pessoa("Fulano", "de Tal");
// // p1.nome = "Fulano";
// // p1.sobrenome = "de Tal";

// Pessoa p2 = new Pessoa("Beltrano", "da Silva");
// // p2.nome = "Beltrano";
// // p2.sobrenome = "da silva";


// Curso cursoDeCsharp = new Curso();
// cursoDeCsharp.Nome = "Curso de CShrap";
// cursoDeCsharp.Alunos = new List<Pessoa>();

// cursoDeCsharp.Adicionaraluno(p1);
// cursoDeCsharp.Adicionaraluno(p2);
// cursoDeCsharp.ListarAlunos();




































// Pessoa p1 = new Pessoa();

// p1.nome = "Kenneth";
// p1.sobrenome = "Stanley";
// p1.idade = 41;
// p1.Apresentar();