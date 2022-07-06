using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Game
    {
        public static void Main()
        {
            Stage stage = new Stage();
            stage.Start();
            stage.DrawMonster();
        }
    }
}
