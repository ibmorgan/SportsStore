using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Abstract
{
    interface IOrderProcessor
    {
        void ProcessOrder(Cart cart, ShippingDetails shippingDetails);
    }
}
