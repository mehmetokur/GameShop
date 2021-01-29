﻿using GameShop.NewFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop
{
    class GameOwnerManager : IGameOwnerService
    {
        public void OwnGame(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+": "+game.GameName+" oyununu satın aldı");
        }
    }
}
