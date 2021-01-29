using GameShop.NewFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop
{
    public interface IKampanyaService
    {
        void KampanyalıSatınAl(Game game, Campain campain, Gamer gamer);
    }
}
