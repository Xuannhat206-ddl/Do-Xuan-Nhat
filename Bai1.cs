using System;

class BankAccount
{
    private static long _nextAccountNumber = 1000000001;

    public long AccountNumber { get; init; }

    private string _accountHolder;

    public string AccountHolder
    {
        get { return _accountHolder; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Tên chủ tài khoản không được để trống.");

            _accountHolder = value;
        }
    }

    private decimal _balance;

    public decimal Balance
    {
        get { return _balance; }
        private set { _balance = value; }
    }

    public BankAccount(string accountHolder, decimal initialBalance)
    {
        if (initialBalance < 50000)
            throw new ArgumentException("Số dư ban đầu phải từ 50.000 VNĐ.");

        AccountNumber = _nextAccountNumber++;
        AccountHolder = accountHolder;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Số tiền nạp phải lớn hơn 0.");

        Balance += amount;
    }

    public bool Withdraw(decimal amount)
    {
        if (amount <= 0)
            return false;

        if (Balance - amount < 50000)
            return false;

        Balance -= amount;
        return true;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Số tài khoản: " + AccountNumber);
        Console.WriteLine("Chủ tài khoản: " + AccountHolder);
        Console.WriteLine("Số dư: " + Balance.ToString("N0") + " VNĐ");
    }
}

class Program
{
    static void Main()
    {
        try
        {
            BankAccount account1 =
                new BankAccount("Nguyen Van A", 1000000);

            BankAccount account2 =
                new BankAccount("Tran Thi B", 2000000);

            account1.DisplayInfo();
            Console.WriteLine();

            account2.DisplayInfo();
            Console.WriteLine();

            account1.Deposit(500000);
            account1.DisplayInfo();
            Console.WriteLine();

            bool result = account1.Withdraw(300000);

            Console.WriteLine(result
                ? "Rút tiền thành công."
                : "Rút tiền thất bại.");

            result = account1.Withdraw(2000000);

            Console.WriteLine(result
                ? "Rút tiền thành công."
                : "Rút tiền thất bại.");

            BankAccount account3 =
                new BankAccount("Le Van C", 30000);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Lỗi: " + ex.Message);
        }
    }
}