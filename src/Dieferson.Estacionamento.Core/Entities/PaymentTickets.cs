namespace Dieferson.Estacionamento.Core.Entities;

public class PaymentTickets : BaseEntity
{
    public PaymentTickets(Vehicle vehicle, DateTime dateEntry, Parking parking)
    {
        Vehicle = vehicle;
        DateEntry = dateEntry;
        DateDeparture = null;
        Parking = parking;
        Payment = null;
    }
    public DateTime DateEntry { get; private set; }
    public DateTime? DateDeparture { get; private set; }
    public float? Payment { get; private set; }
    public Parking Parking { get; private set; }
    public Vehicle Vehicle { get; private set; }

}