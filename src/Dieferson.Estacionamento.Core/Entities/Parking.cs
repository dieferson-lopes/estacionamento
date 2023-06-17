namespace Dieferson.Estacionamento.Core.Entities;

public class Parking : BaseEntity
{
    public Parking(int capacityCarOrVan, int actualCapacityCarOrVan, int capacityMotocycle, int actualCapacityMotocycle)
    {
        CapacityCarOrVan = capacityCarOrVan;
        ActualCapacityCarOrVan = actualCapacityCarOrVan;
        CapacityMotocycle = capacityMotocycle;
        ActualCapacityMotocycle = actualCapacityMotocycle;
    }

    public int CapacityCarOrVan { get; private set; }
    public int ActualCapacityCarOrVan { get; private set; }
    public int CapacityMotocycle { get; private set; }
    public int ActualCapacityMotocycle { get; private set; }
    public IList<PaymentTickets> PaymentTickets { get; private set; }
}