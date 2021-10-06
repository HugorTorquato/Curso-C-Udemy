namespace Enumerados1.Entities.Enums
{
    enum OrderStatus : int
    {
        // Indica implicitament o valor do enumerado, mas pode especificar com um "= 0"
        PendingPayment,
        Processing,
        Shipping,
        Delivered

    }
}
