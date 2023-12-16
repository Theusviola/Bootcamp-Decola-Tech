using Exemplosexplorando.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Leonardo";
p1.Idade = 20;

Pessoa p2 = new Pessoa();
p2.Nome = "Eduardo";
p2.Idade = 20;

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();