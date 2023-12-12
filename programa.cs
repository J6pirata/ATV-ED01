using System;

class programa
{
    static Escola escola = new Escola();

    static void Main()
    {
        int opcao;
        do
        {
            Console.WriteLine("Escola Management System");
            Console.WriteLine("0. Sair");
            Console.WriteLine("1. Adicionar curso");
            Console.WriteLine("2. Pesquisar curso (mostrar inclusive as disciplinas associadas)");
            Console.WriteLine("3. Remover curso (não pode ter nenhuma disciplina associada)");
            Console.WriteLine("4. Adicionar disciplina no curso");
            Console.WriteLine("5. Pesquisar disciplina (mostrar inclusive os alunos matriculados)");
            Console.WriteLine("6. Remover disciplina do curso (não pode ter nenhum aluno matriculado)");
            Console.WriteLine("7. Matricular aluno na disciplina");
            Console.WriteLine("8. Remover aluno da disciplina");
            Console.WriteLine("9. Pesquisar aluno (informar seu nome e em quais disciplinas ele está matriculado)");

            Console.Write("Escolha uma opção: ");
            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                ExecuteOption(opcao);
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }

        } while (opcao != 0);
    }

    static void ExecuteOption(int opcao)
    {
        switch (opcao)
        {
            case 1:
                AdicionarCurso();
                break;
            case 2:
                PesquisarCurso();
                break;
            case 3:
                RemoverCurso();
                break;
            case 4:
                AdicionarDisciplinaNoCurso();
                break;
            case 5:
                PesquisarDisciplina();
                break;
            case 6:
                RemoverDisciplinaDoCurso();
                break;
            case 7:
                MatricularAlunoNaDisciplina();
                break;
            case 8:
                RemoverAlunoDaDisciplina();
                break;
            case 9:
                PesquisarAluno();
                break;
            case 0:
                Console.WriteLine("Saindo do programa.");
                break;
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    }

    static void AdicionarCurso()
    {
        Console.Write("Digite o ID do curso: ");
        int courseId = int.Parse(Console.ReadLine());

        Console.Write("Digite a descrição do curso: ");
        string courseDescription = Console.ReadLine();

        Curso curso = new Curso(courseId, courseDescription);
        if (escola.AdicionarCurso(curso))
        {
            Console.WriteLine("Curso adicionado com sucesso.");
        }
        else
        {
            Console.WriteLine("Não foi possível adicionar o curso. Limite de cursos atingido.");
        }
    }

    static void PesquisarCurso()
    {
        Console.Write("Digite o ID do curso que deseja pesquisar: ");
        int courseId = int.Parse(Console.ReadLine());

        Curso curso = new Curso(courseId, ""); 
        Curso ProcuraCurso = escola.PesquisarCurso(curso);

        if (foundCurso != null)
        {
            Console.WriteLine($"Curso encontrado: {ProcuraCurso.Descricao}");

            // Display associated disciplines
            foreach (Disciplina disciplina in ProcuraCurso.Disciplinas)
            {
                Console.WriteLine($"Disciplina: {disciplina.Descricao}");
            
            }
        }
        else
        {
            Console.WriteLine("Curso não encontrado.");
        }
    }

    static void RemoverCurso()
    {
        Console.Write("Digite o ID do curso que deseja remover: ");
        int courseId = int.Parse(Console.ReadLine());

        Curso curso = new Curso(courseId, "");  
        if (escola.RemoverCurso(curso))
        {
            Console.WriteLine("Curso removido com sucesso.");
        }
        else
        {
            Console.WriteLine("Não foi possível remover o curso. Certifique-se de que não há disciplinas associadas.");
        }
    }