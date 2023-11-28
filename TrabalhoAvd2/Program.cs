using TrabalhoAvd2;

class Program
{
    static List<Pessoa> pessoas = new List<Pessoa>();
    static List<Disciplina> disciplinas = new List<Disciplina>();

    static void Main(string[] args)
    {
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("=== Sistema de Gestão Escolar ===");
            Console.WriteLine("1. Adicionar Aluno");
            Console.WriteLine("2. Adicionar Professor");
            Console.WriteLine("3. Adicionar Disciplina");
            Console.WriteLine("4. Visualizar Alunos e Professores");
            Console.WriteLine("5. Visualizar Disciplinas");
            Console.WriteLine("6. Sair");

            Console.Write("Escolha uma opção: ");
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        AdicionarAluno();
                        break;
                    case 2:
                        AdicionarProfessor();
                        break;
                    case 3:
                        AdicionarDisciplina();
                        break;
                    case 4:
                        VisualizarPessoas();
                        break;
                    case 5:
                        VisualizarDisciplinas();
                        break;
                    case 6:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, tente novamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número.");
            }

            Console.WriteLine();
        }
    }

    static void AdicionarAluno()
    {
        Console.WriteLine("=== Adicionar Aluno ===");
        Aluno novoAluno = new Aluno();

        Console.Write("Nome do aluno: ");
        novoAluno.Nome = Console.ReadLine();

        Console.Write("Idade do aluno: ");
        if (int.TryParse(Console.ReadLine(), out int idade))
        {
            novoAluno.Idade = idade;
        }
        else
        {
            Console.WriteLine("Idade inválida. Usando 0 como padrão.");
            novoAluno.Idade = 0;
        }

        Console.Write("Turma do aluno: ");
        novoAluno.Turma = Console.ReadLine();

        pessoas.Add(novoAluno);
        Console.WriteLine("Aluno adicionado com sucesso!");
    }

    static void AdicionarProfessor()
    {
        Console.WriteLine("=== Adicionar Professor ===");
        Professor novoProfessor = new Professor();

        Console.Write("Nome do professor: ");
        novoProfessor.Nome = Console.ReadLine();

        Console.WriteLine("Idade do professor:");
        if (int.TryParse(Console.ReadLine(), out int idade))
        {
            novoProfessor.Idade = idade;
        }
        else
        {
            Console.WriteLine("Idade inválida. Usando 0 como padrão.");
            novoProfessor.Idade = 0;
        }
        Console.Write("Disciplina do professor: ");
        novoProfessor.Disciplina = Console.ReadLine();

        pessoas.Add(novoProfessor);
        Console.WriteLine("Professor adicionado com sucesso!");
    }

    static void AdicionarDisciplina()
    {
        Console.WriteLine("=== Adicionar Disciplina ===");
        Disciplina novaDisciplina = new Disciplina();

        Console.Write("Nome da disciplina: ");
        novaDisciplina.Nome = Console.ReadLine();

        Console.Write("Professor da disciplina: ");
        novaDisciplina.Professor = Console.ReadLine();

        disciplinas.Add(novaDisciplina);
        Console.WriteLine("Disciplina adicionada com sucesso!");
    }

    static void VisualizarPessoas()
    {
        Console.WriteLine("=== Alunos e Professores ===");
        if (pessoas.Count == 0)
        {
            Console.WriteLine("Nenhum aluno ou professor cadastrado.");
        }
        else
        {
            foreach (var pessoa in pessoas)
            {
                pessoa.Exibir();
            }
        }
    }

    static void VisualizarDisciplinas()
    {
        Console.WriteLine("=== Disciplinas ===");
        if (disciplinas.Count == 0)
        {
            Console.WriteLine("Nenhuma disciplina cadastrada.");
        }
        else
        {
            foreach (var disciplina in disciplinas)
            {
                disciplina.Exibir();
            }
        }
    }
}