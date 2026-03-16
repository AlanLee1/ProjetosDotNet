class Program
{
    static void Main(string[] args)
    {
        //Music
        Gender gender = new Gender();
        gender.Name = "Rock";

        Album albumDoQueen = new Album("A night at the Opera");
        Banda queen = new Banda("Queen");

        queen.AddAlbum(albumDoQueen);

        Musica musica1 = new Musica(queen, "Love of my life")
        {
            Duration = 213,
            Gender = gender,
            Available = true
        };

        Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
        {
            Duration = 354,
            Gender = gender,
            Available = false
        };

        musica1.ShowTechnicalSpecifications();
        musica2.ShowTechnicalSpecifications();

        albumDoQueen.AddMusic(musica1);
        albumDoQueen.AddMusic(musica2);
        // albumDoQueen.ShowMusicWithAlbum();

        queen.ShowDiscography();


        //Bank
        // var holder = new HolderAccount();
        // holder.Name = "Felipe";

        // var conta = new BankAccount(1, holder, "123");
        // conta.ShowInfos();
        // conta.Deposit(10, "123");
        // conta.Withdraw(5, "123");
    }
}