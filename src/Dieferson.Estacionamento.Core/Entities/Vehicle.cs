namespace Dieferson.Estacionamento.Core.Entities;

public class Vehicle : BaseEntity
{
    public Vehicle(string licensePlate, int model, User user)
    {
        LicensePlate = licensePlate;
        Model = model;
        User = user;
    }

    public string LicensePlate { get; private set; }
    public int Model { get; private set; }
    public User User { get; private set; }
    public IList<PaymentTickets> PaymentTickets { get; private set; }
}