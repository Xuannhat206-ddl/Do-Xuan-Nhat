using System;
using System.Collections.Generic;

class DiscountCalculator
{
    public decimal ApplyDiscount(decimal totalAmount)
    {
        return totalAmount * 0.95m;
    }

    public decimal ApplyDiscount(
        decimal totalAmount,
        double percentage)
    {
        return totalAmount * (decimal)(1 - percentage / 100);
    }

    public decimal ApplyDiscount(
        decimal totalAmount,
        decimal fixedVoucher,
        decimal minimumOrder)
    {
        if (totalAmount >= minimumOrder)
            return totalAmount - fixedVoucher;

        return totalAmount;
    }
}

class DeliveryService
{
    public string OrderId { get; set; }
    public double DistanceKm { get; set; }

    public DeliveryService(string orderId, double distanceKm)
    {
        OrderId = orderId;
        DistanceKm = distanceKm;
    }

    public virtual decimal CalculateShippingFee()
    {
        return (decimal)DistanceKm * 5000;
    }
}

class ExpressDelivery : DeliveryService
{
    public ExpressDelivery(string orderId, double distanceKm)
        : base(orderId, distanceKm)
    {
    }

    public override decimal CalculateShippingFee()
    {
        decimal basicFee = base.CalculateShippingFee();
        return basicFee * 1.5m + 20000;
    }
}

class EcoDelivery : DeliveryService
{
    public EcoDelivery(string orderId, double distanceKm)
        : base(orderId, distanceKm)
    {
    }

    public override decimal CalculateShippingFee()
    {
        decimal basicFee = base.CalculateShippingFee();

        if (DistanceKm > 10)
            return basicFee * 0.9m;

        return basicFee;
    }
}

class Program
{
    static void Main()
    {
        DiscountCalculator calculator =
            new DiscountCalculator();

        Console.WriteLine(
            calculator.ApplyDiscount(1000000));

        Console.WriteLine(
            calculator.ApplyDiscount(1000000, 10));

        Console.WriteLine(
            calculator.ApplyDiscount(
                1000000,
                100000,
                500000));

        List<DeliveryService> deliveries =
            new List<DeliveryService>();

        deliveries.Add(
            new DeliveryService("DH01", 5));

        deliveries.Add(
            new ExpressDelivery("DH02", 5));

        deliveries.Add(
            new EcoDelivery("DH03", 15));

        foreach (DeliveryService delivery in deliveries)
        {
            Console.WriteLine(
                delivery.OrderId + " - " +
                delivery.CalculateShippingFee().ToString("N0") +
                " VNĐ");
        }
    }
}