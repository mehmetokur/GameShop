using GameShop.NewFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop
{
    public class CampainManager : IKampanyaService
    {
        public void KampanyalıSatınAl(Game game, Campain campain, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " adli kullanici " + game.GameName + " oyununu " + 
                campain.KampanyaİndirimMiktari + " indirim miktari ile " + campain.KampanyaAdi +
                " kampanyasindan faydalanarak bu oyunu satin almis bulunmaktadir.");
        }
    }
}
