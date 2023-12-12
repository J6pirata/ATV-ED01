public class Aluno
{
    // Attributes
    private int id;
    private string nome;

    // Constructor
    public Aluno(int id, string nome)
    {
        this.id = id;
        this.nome = nome;
    }

    // Method to check if the student can enroll in a course
    public bool PodeMatricular(Curso curso)
    {
    
        return curso != null;
    }
}