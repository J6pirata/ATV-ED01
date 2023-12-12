public class Curso
{

    private int id;
    private string descricao;
    private Disciplina[] disciplinas;

    
    public Curso(int id, string descricao)
    {
        this.id = id;
        this.descricao = descricao;
        this.disciplinas = new Disciplina[12];
    }

    
    public bool AdicionarDisciplina(Disciplina disciplina)
    {
        
        for (int i = 0; i < disciplinas.Length; i++)
        {
            if (disciplinas[i] == null)
            {
                disciplinas[i] = disciplina;
                return true; 
            }
        }

        return false; 
    }


    public Disciplina PesquisarDisciplina(Disciplina disciplina)
    {
        
        for (int i = 0; i < disciplinas.Length; i++)
        {
            if (disciplinas[i] == disciplina)
            {
                return disciplinas[i];
            }
        }

        return null; 
    }

    
    public bool RemoverDisciplina(Disciplina disciplina)
    {
        for (int i = 0; i < disciplinas.Length; i++)
        {
            if (disciplinas[i] == disciplina)
            {
                disciplinas[i] = null;
                return true; 
            }
        }

        return false; 
    }
}