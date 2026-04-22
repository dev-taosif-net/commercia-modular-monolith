namespace Catalog.Core.Products.Events;

public record ProductCreatedEvent(Product Product): IDomainEvent;