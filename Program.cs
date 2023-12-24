using ExemploExplorando.Models;

Pessoa p1 = new Pessoa();
p1.nome = "Fulano";
p1.sobrenome = "de Tal";

Pessoa p2 = new Pessoa();
p2.nome = "Beltrano";
p2.sobrenome = "da silva";


Curso cursoDeCsharp = new Curso();
cursoDeCsharp.Nome = "Curso de CShrap";
cursoDeCsharp.Alunos = new List<Pessoa>();

cursoDeCsharp.Adicionaraluno(p1);
cursoDeCsharp.Adicionaraluno(p2);
cursoDeCsharp.ListarAlunos();




































// Pessoa p1 = new Pessoa();

// p1.nome = "Kenneth";
// p1.sobrenome = "Stanley";
// p1.idade = 41;
// p1.Apresentar();