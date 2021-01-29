using GameShop.NewFolder;
using System;

namespace GameShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oyuncu eklendi
            Gamer gamer1 = new Gamer { Id = 1, FirstName = "Mehmet", LastName = "Okur",TcNo = "123456789", YearOfBirth = "1988" };

            GamerManager gamerManager = new GamerManager(new GamerValatadionManager());
            gamerManager.Add(gamer1);

            //Oyun Eklendi
            Game game1 = new Game { ID = 1, GameName = "Lol" };
            Game game2 = new Game { ID = 2, GameName = "fifa 21" };
            GameManeger gameManeger = new GameManeger();
            gameManeger.Add(game1);
            gameManeger.Add(game2);

            //Oyun satın alma
            GameOwnerManager gameOwnerManager = new GameOwnerManager();
            gameOwnerManager.OwnGame(game1, gamer1);

            //Kampanya

            Campain campain1 = new Campain { KampanyaAdi = "yılbaşı", KampanyaİndirimMiktari = "% 50" };
            CampainManager campainManager = new CampainManager();
            campainManager.KampanyalıSatınAl(game1, campain1, gamer1);





        }

      
    }
}
