namespace Catalog.Core.Products.Events;

public record ProductPriceChangedEvent(Product Product) : IDomainEvent;