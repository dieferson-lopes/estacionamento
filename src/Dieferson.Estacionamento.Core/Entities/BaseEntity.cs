using System;

namespace Dieferson.Estacionamento.Core.Entities;

public abstract class BaseEntity : IEquatable<BaseEntity>
{
    public  BaseEntity()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
    }
    public Guid Id { get; private set; } 
    public DateTime UpdatedAt { get; private set; } 
    public DateTime CreatedAt { get; private set; }

    public bool Equals(BaseEntity? other)
    {
        return this.Id == other?.Id;
    }

}