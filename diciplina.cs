public class Disciplina
{
    
    private int id;
    private string descricao;
    private Aluno[] alunos;

  
    public Disciplina(int id, string descricao)
    {
        this.id = id;
        this.descricao = descricao;
        this.alunos = new Aluno[15];
    }

    
    public bool MatricularAluno(Aluno aluno)
    {
        for (int i = 0; i < alunos.Length; i++)
        {
            if (alunos[i] == null)
            {
                alunos[i] = aluno;
                return true; 
            }
        }

        return false; 
    }

    public bool DesmatricularAluno(Aluno aluno)
    {
        for (int i = 0; i < alunos.Length; i++)
        {
            if (alunos[i] == aluno)
            {
                alunos[i] = null;
                return true; 
                }
                }
    }
}