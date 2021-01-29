using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.NewFolder
{
    public class GameManeger : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun Eklendi");
        }

        public void Deleted(Game game)
        {
            Console.WriteLine("Oyun Silindi");
        }

        public void Uptade(Game game)
        {
            Console.WriteLine("Oyun Güncellendi");
        }
    }
}
