using System;

interface IPayable
{
    bool ProcessPayment(decimal amount);
}

interface IRefundable
{
    bool ProcessRefund(decimal amount, string reason);
}

abstract class PaymentGateway
{
    public string TransactionId { get; init; }
    public DateTime CreationDate { get; init; }
    public string Status { get; protected set; }

    protected PaymentGateway(string transactionId)
    {
        TransactionId = transactionId;
        CreationDate = DateTime.Now;
        Status = "Pending";
    }

    public abstract void ValidateConnection();

    public virtual void LogTransaction(string message)
    {
        Console.WriteLine(
            "[" + TransactionId + "] " + message);
    }
}

class MomoPayment : PaymentGateway, IPayable, IRefundable
{
    public string PhoneNumber { get; set; }

    public MomoPayment(
        string transactionId,
        string phoneNumber)
        : base(transactionId)
    {
        PhoneNumber = phoneNumber;
    }

    public override void ValidateConnection()
    {
        Console.WriteLine(
            "Đang kiểm tra kết nối API MoMo...");
    }

    public bool ProcessPayment(decimal amount)
    {
        if (amount <= 0 ||
            string.IsNullOrWhiteSpace(PhoneNumber))
        {
            Console.WriteLine(
                "Thông tin thanh toán không hợp lệ.");

            return false;
        }

        Status = "Success";

        LogTransaction(
            "Thanh toán thành công: " +
            amount.ToString("N0") + " VNĐ");

        return true;
    }

    public bool ProcessRefund(
        decimal amount,
        string reason)
    {
        if (amount <= 0 ||
            string.IsNullOrWhiteSpace(reason))
        {
            Console.WriteLine(
                "Thông tin hoàn tiền không hợp lệ.");

            return false;
        }

        Status = "Refunded";

        LogTransaction(
            "Hoàn tiền: " +
            amount.ToString("N0") +
            " VNĐ - " +
            reason);

        return true;
    }
}

class Program
{
    static void Main()
    {
        MomoPayment momo =
            new MomoPayment(
                "GD001",
                "0987654321");

        momo.ValidateConnection();

        IPayable payable = momo;
        payable.ProcessPayment(500000);

        Console.WriteLine(
            "Trạng thái: " + momo.Status);

        IRefundable refundable = momo;
        refundable.ProcessRefund(
            500000,
            "Khách hàng yêu cầu hoàn tiền");

        Console.WriteLine(
            "Trạng thái: " + momo.Status);
    }
}