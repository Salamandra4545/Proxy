using System;

// Интерфейс для банковского счета
public interface IBankAccount
{
    void Deposit(decimal amount);
    void Withdraw(decimal amount);
    decimal GetBalance();
}

// Реальный класс банковского счета
public class RealBankAccount : IBankAccount
{
    private decimal _balance;

    public void Deposit(decimal amount)
    {
        _balance += amount;
        Console.WriteLine($"Внесено {amount}. Текущий баланс: {_balance}");
    }

    public void Withdraw(decimal amount)
    {
        if (_balance >= amount)
        {
            _balance -= amount;
            Console.WriteLine($"Снято {amount}. Текущий баланс: {_balance}");
        }
        else
        {
            Console.WriteLine("Недостаточно средств.");
        }
    }

    public decimal GetBalance()
    {
        return _balance;
    }
}

// Класс заместителя для банковского счета
public class BankAccountProxy : IBankAccount
{
    private readonly RealBankAccount _realBankAccount;

    public BankAccountProxy(RealBankAccount realBankAccount)
    {
        _realBankAccount = realBankAccount;
    }

    public void Deposit(decimal amount)
    {
        _realBankAccount.Deposit(amount);
    }

    public void Withdraw(decimal amount)
    {
        // Здесь можно добавить дополнительные проверки или ведение журнала
        _realBankAccount.Withdraw(amount);
    }

    public decimal GetBalance()
    {
        return _realBankAccount.GetBalance();
    }
}

// Клиентский код
class Program
{
    static void Main(string[] args)
    {
        RealBankAccount realAccount = new RealBankAccount();
        BankAccountProxy proxyAccount = new BankAccountProxy(realAccount);

        proxyAccount.Deposit(100);
        proxyAccount.Withdraw(50);
        Console.WriteLine($"Баланс: {proxyAccount.GetBalance()}");
    }
}