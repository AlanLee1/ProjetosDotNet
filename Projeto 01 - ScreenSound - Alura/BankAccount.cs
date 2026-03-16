class BankAccount
{
    public int Id { get; private set; }
    public HolderAccount HolderAccount { get; private set; }
    public string Agency { get; private set; }
    public string NumberAccount { get; private set; }
    public decimal Balance { get; private set; }
    public string Password { get; private set; }

    public BankAccount(int id, HolderAccount holderAccount, string password)
    {
        Id = id;
        HolderAccount = holderAccount;
        Agency = "0001";
        NumberAccount = Random.Shared.Next(1000, 2000).ToString();
        Password = password;
        Balance = 0m;
    }

    public void ShowInfos()
    {
        System.Console.WriteLine($"Id: {Id}");
        System.Console.WriteLine($"Holder Name: {HolderAccount.Name}");
        System.Console.WriteLine($"Agency: {Agency}");
        System.Console.WriteLine($"Account: {NumberAccount}");
        System.Console.WriteLine($"Balance: {Balance}");
        System.Console.WriteLine($"Password: {Password}");
    }

    public int Somar(int a, int b) => a + b;
    Func<int, int> quadrado = x => x * x;

    public void Test()
    {
        var a = Somar(1, 2);

        var b = quadrado(2);
    }

    public void Deposit(decimal value, string password)
    {
        if (value <= 0)
            throw new ArgumentException("Invalid Value");

        if (Authenticate(password))
            Balance += value;

        System.Console.WriteLine($"Current balance = {Balance}");
    }

    public void Withdraw(decimal value, string password)
    {
        if (Balance <= 0)
            throw new ArgumentException("It was not possible to withdraw");

        if (Authenticate(password))
            Balance -= value;

        System.Console.WriteLine($"Current balance = {Balance}");

    }

    public bool Authenticate(string password)
    {
        // StringComparison é um modo de comparação 
        // de strings baseado no valor binário (Unicode code point)
        // compara caractere por caractere, pelo código numérico,
        // sem considerar cultura ou idioma
        return string.Equals(password, Password, StringComparison.Ordinal);
    }
}

class HolderAccount
{
    public string Name { get; set; }

}