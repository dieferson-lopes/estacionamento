namespace Dieferson.Estacionamento.Core.Entities;

public class User : BaseEntity
{
    public User(string name, int cpf, DateTime birthDate)
    {
        Name = name;
        Cpf = cpf;
        BirthDate = birthDate;
    }

    public string Name { get; private set; }
    public int Cpf { get; private set; }
    public DateTime BirthDate { get; private set; }
    public IList<Vehicle> Vehicles { get; private set;}

}