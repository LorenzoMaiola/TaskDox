namespace Taskdox.Models;
public abstract class Entidade
{
    private Guid Id {get; init;} = Guid.NewGuid();
}