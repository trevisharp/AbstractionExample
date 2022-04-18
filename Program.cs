using System;
using System.Collections.Generic;

#region Criação dos dados

Universidade uni = new Universidade();

Aluno aluno1 = new Aluno();
aluno1.Nome = "Davi 03";
aluno1.CPF = "111.111.111-11";
aluno1.Nascimento = new DateTime(2003, 10, 14);
aluno1.RA = 1;
aluno1.Senha = "palmitodefrango";

uni.Alunos.Add(aluno1);

Aluno aluno2 = new Aluno();
aluno2.Nome = "Ana Café";
aluno2.CPF = "222.222.222-22";
aluno2.Nascimento = new DateTime(2005, 10, 17);
aluno2.RA = 2;
aluno2.Senha = "xispita";

uni.Alunos.Add(aluno2);

Curso curso1 = new Curso();
curso1.ID = 1;
curso1.Nome = "Engenharia do Surf";
curso1.Tipo = TipoCurso.Engenharia;

uni.Cursos.Add(curso1);

Grade grade1 = new Grade();
grade1.ID = 1;
grade1.CursoID = 1;

uni.Grades.Add(grade1);

Matricula matricula1 = new Matricula();
matricula1.ID = 1;
matricula1.AlunoRA = 1;
matricula1.GradeID = 1;

uni.Matriculas.Add(matricula1);

Matricula matricula2 = new Matricula();
matricula2.ID = 2;
matricula2.AlunoRA = 2;
matricula2.GradeID = 1;

uni.Matriculas.Add(matricula2);

Disciplina disciplina1 = new Disciplina();
disciplina1.ID = 1;
disciplina1.Nome = "Manufaturamento de Pranchas";
disciplina1.CargaHoraria = 180;

uni.Disciplinas.Add(disciplina1);

Disciplina disciplina2 = new Disciplina();
disciplina2.ID = 2;
disciplina2.Nome = "Parafinamento I";
disciplina2.CargaHoraria = 60;

uni.Disciplinas.Add(disciplina2);

Disciplina disciplina3 = new Disciplina();
disciplina3.ID = 3;
disciplina3.Nome = "Grau Básico";
disciplina3.CargaHoraria = 120;

uni.Disciplinas.Add(disciplina3);

Disciplina disciplina4 = new Disciplina();
disciplina4.ID = 4;
disciplina4.Nome = "Grau Avançado";
disciplina4.CargaHoraria = 120;

uni.Disciplinas.Add(disciplina4);

PreRequisito prerequisto = new PreRequisito();
prerequisto.ID = 1;
prerequisto.GradeID = 1;
prerequisto.DisciplinaBasicaID = 3;
prerequisto.DisciplinaAvancadaID = 4;

uni.PreRequisitos.Add(prerequisto);

DisciplinaGrade disciplinagrade1 = new DisciplinaGrade();
disciplinagrade1.ID = 1;
disciplinagrade1.GradeID = 1;
disciplinagrade1.DisciplinaID = 1;

uni.DisciplinaGrades.Add(disciplinagrade1);

DisciplinaGrade disciplinagrade2 = new DisciplinaGrade();
disciplinagrade2.ID = 2;
disciplinagrade2.GradeID = 1;
disciplinagrade2.DisciplinaID = 2;

uni.DisciplinaGrades.Add(disciplinagrade2);

DisciplinaGrade disciplinagrade3 = new DisciplinaGrade();
disciplinagrade3.ID = 3;
disciplinagrade3.GradeID = 1;
disciplinagrade3.DisciplinaID = 3;

uni.DisciplinaGrades.Add(disciplinagrade3);

DisciplinaGrade disciplinagrade4 = new DisciplinaGrade();
disciplinagrade4.ID = 4;
disciplinagrade4.GradeID = 1;
disciplinagrade4.DisciplinaID = 4;

uni.DisciplinaGrades.Add(disciplinagrade4);

Professor professor1 = new Professor();
professor1.RA = 3;
professor1.Nome = "Algeu Pepes";
professor1.CPF = "987.654.321-82";
professor1.Senha = "superautopets";

uni.Professores.Add(professor1);

Professor professor2 = new Professor();
professor2.RA = 4;
professor2.Nome = "Edjalminha";
professor2.CPF = "789.456.123-73";
professor2.Senha = "amosenaiS2kawaidesune";

uni.Professores.Add(professor2);

Turma turma1 = new Turma();
turma1.ID = 1;
turma1.ProfessorID = 4;
turma1.DisciplinaID = 3;

uni.Turmas.Add(turma1);

Turma turma2 = new Turma();
turma2.ID = 2;
turma2.ProfessorID = 4;
turma2.DisciplinaID = 4;

uni.Turmas.Add(turma2);

Turma turma3 = new Turma();
turma3.ID = 3;
turma3.ProfessorID = 3;
turma3.DisciplinaID = 2;

uni.Turmas.Add(turma3);

TurmaAluno turmaaluno1 = new TurmaAluno();
turmaaluno1.ID = 1;
turmaaluno1.AlunoID = 1;
turmaaluno1.TurmaID = 3;

uni.TurmaAlunos.Add(turmaaluno1);

TurmaAluno turmaaluno2 = new TurmaAluno();
turmaaluno2.ID = 1;
turmaaluno2.AlunoID = 2;
turmaaluno2.TurmaID = 3;

uni.TurmaAlunos.Add(turmaaluno2);

TurmaAluno turmaaluno3 = new TurmaAluno();
turmaaluno3.ID = 1;
turmaaluno3.AlunoID = 1;
turmaaluno3.TurmaID = 1;

uni.TurmaAlunos.Add(turmaaluno3);

#endregion

var disciplinas = grade1.GetDisciplinas(uni);
foreach (var disciplina in disciplinas)
{
    Console.WriteLine(disciplina.Nome);
}

public class Universidade
{
    public List<Aluno> Alunos { get; set; } = new List<Aluno>();
    public List<Curso> Cursos { get; set; } = new List<Curso>();
    public List<Grade> Grades { get; set; } = new List<Grade>();
    public List<Disciplina> Disciplinas { get; set; } = new List<Disciplina>();
    public List<Matricula> Matriculas { get; set; } = new List<Matricula>();
    public List<PreRequisito> PreRequisitos { get; set; } = new List<PreRequisito>();
    public List<DisciplinaGrade> DisciplinaGrades { get; set; } = new List<DisciplinaGrade>();
    public List<Professor> Professores { get; set; } = new List<Professor>();
    public List<Turma> Turmas { get; set; } = new List<Turma>();
    public List<TurmaAluno> TurmaAlunos { get; set; } = new List<TurmaAluno>();
}

public class Aluno
{
    public int RA { get; set; }
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Senha { get; set; }
    public DateTime Nascimento { get; set; }
}

public enum TipoCurso : byte
{
    Licenciatura = 1,
    Bacharelado = 2,
    Engenharia = 4,
    Tecnologo = 8
}

public class Curso
{
    public int ID { get; set; }
    public string Nome { get; set; }
    public TipoCurso Tipo { get; set; }
}

public class Grade
{
    public int ID { get; set; }
    public int CursoID { get; set; }

    public List<Disciplina> GetDisciplinas(Universidade uni)
    {
        List<Disciplina> disciplinas = new List<Disciplina>();

        foreach (DisciplinaGrade dg in uni.DisciplinaGrades)
        {
            if (dg.GradeID == this.ID)
            {
                int disciplinaid = dg.DisciplinaID;
                foreach (Disciplina disciplina in uni.Disciplinas)
                {
                    if (disciplinaid == disciplina.ID)
                    {
                        disciplinas.Add(disciplina);
                    }
                }
            }
        }
        return disciplinas;
    }
}

public class Disciplina
{
    public int ID { get; set; }
    public string Nome { get; set; }
    public int CargaHoraria { get; set; }
}

public class Matricula
{
    public int ID { get; set; }
    public int AlunoRA { get; set; }
    public int GradeID { get; set; }
}

public class DisciplinaGrade
{
    public int ID { get; set; }
    public int DisciplinaID { get; set; }
    public int GradeID { get; set; }
}

public class PreRequisito
{
    public int ID { get; set; }
    public int GradeID { get; set; }
    public int DisciplinaBasicaID { get; set; }
    public int DisciplinaAvancadaID { get; set; }
}

public class Professor
{
    public int RA { get; set; }
    public string Nome { get; set; }
    public string Senha { get; set; }
    public string CPF { get; set; }
}

public class Turma
{
    public int ID { get; set; }
    public int ProfessorID { get; set; }
    public int DisciplinaID { get; set; }
}

public class TurmaAluno
{
    public int ID { get; set; }
    public int AlunoID { get; set; }
    public int TurmaID { get; set; }
}

public class Nota
{
    public int ID { get; set; }
    public int TurmaAlunoID { get; set; }
    public double NotaRecebida { get; set; }
    public string Resultado
    {
        get
        {
            if (NotaRecebida < 7.0)
                return "Reprovado";
            else return "Aprovado";
        }
    }
}
