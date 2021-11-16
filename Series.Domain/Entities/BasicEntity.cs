using System;
namespace Series.Domain.Entities
{
    public abstract class BasicEntity
    {
        public Guid Id { get; protected set; }
    }
}