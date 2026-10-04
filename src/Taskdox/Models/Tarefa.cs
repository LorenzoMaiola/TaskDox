using System;

namespace Taskdox.Models;

public class Tarefa : Entidade
{

    public Tarefa(string descricao, Usuario programador, Usuario tester, string titulo)
    {
        Descricao = descricao;
        Programador = programador;
        Tester = tester;
        Titulo = titulo;
    }

    private string? Descricao { get; set; }
    private Usuario? Programador { get; set; }
    private Usuario? Tester { get; set; }
    private string Titulo
    {
        get; set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("A tarefa precisa ter um título!");

            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("O título precisa ter algum número ou letra");

            field = value.Trim();
        }
    }

}
