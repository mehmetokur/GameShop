using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop
{
    class GamerValatadionManager : IGamerValatationService
    {

       
        public bool Valatation(Gamer gamer)
        {
            if (gamer.Id==1&&gamer.FirstName=="Mehmet"&&gamer.LastName=="Okur"&&gamer.TcNo=="123456789"&&gamer.YearOfBirth=="1988")
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
