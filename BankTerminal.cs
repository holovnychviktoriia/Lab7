namespace Lab7;

public class BankTerminal
{
    public event Action<int>? OnMoneyWithdraw;

    public void Withdraw(int amount)
    {
        Console.WriteLine($"Знімаємо {amount} грн");
        OnMoneyWithdraw?.Invoke(amount);
    }
}