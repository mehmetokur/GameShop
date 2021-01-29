using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop
{
     class GamerManager : IGamerService
    {


        IGamerValatationService _gamerValatationService;

        public GamerManager(IGamerValatationService gamerValatationService)
        {
            _gamerValatationService = gamerValatationService;

        }
        public void Add(Gamer gamer)
        {
            if (_gamerValatationService.Valatation(gamer)==true)
            {
                Console.WriteLine("Kayıt Yapıldı");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Yenilendi");
        }
    }
}
