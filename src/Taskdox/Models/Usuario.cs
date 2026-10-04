using System;
using System.Net.Mail;
using Taskdox.Models.Enums;

namespace Taskdox.Models;

public class Usuario : Entidade
{
    public Usuario(string email, string nomeCompleto, FuncaoUsuario funcao)
    {
        NomeCompleto = nomeCompleto;
        Email = email;
        Funcao = funcao;
    }   


    private FuncaoUsuario Funcao{get; set;}
    
    private string Email
    {
        get; set
        {
            if (!MailAddress.TryCreate(value, out var endereco) || endereco.Address != value.Trim())
                throw new ArgumentException("E-mail inválido!", nameof(value));

            field = value.Trim();
        }
    }

    private string NomeCompleto
    {
        get; set
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Nome inválido!", nameof(value));

            field = value.Trim();
        }
    }
}
