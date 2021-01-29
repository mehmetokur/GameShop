using GameShop.NewFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop
{
    interface IGameOwnerService
    {
        void OwnGame(Game game, Gamer gamer);

    }
}
