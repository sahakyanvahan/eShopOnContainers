namespace Coupon.API.IntegrationEvents.Events;

using Microsoft.eShopOnContainers.BuildingBlocks.EventBus.Events;

public record OrderCouponConfirmedIntegrationEvent : IntegrationEvent
{
    public int OrderId { get; }

    public int Discount { get; }

    public OrderCouponConfirmedIntegrationEvent(int orderId, int discount)
    {
        OrderId = orderId;
        Discount = discount;
    }
}