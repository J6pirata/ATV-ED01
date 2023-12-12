public class Escola
{
    // Attribute
    private Curso[] cursos;

    
    public Escola()
    {
        this.cursos = new Curso[5];
    }

    public bool AdicionarCurso(Curso curso)
    {
      
        for (int i = 0; i < cursos.Length; i++)
        {
            if (cursos[i] == null)
            {
                cursos[i] = curso;
                return true;
            }
        }

        return false; 
    }

    public Curso PesquisarCurso(Curso curso)
    {
    
        for (int i = 0; i < cursos.Length; i++)
        {
            if (cursos[i] == curso)
            {
                return cursos[i];
            }
        }

        return null; 
    }

    
    public bool RemoverCurso(Curso curso)
    {
    
        for (int i = 0; i < cursos.Length; i++)
        {
            if (cursos[i] == curso)
            {
                cursos[i] = null;
                return true; 
            
        }

        return false;
    
}