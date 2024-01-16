using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameProject.GameGL
{
    public class Collision
    {
        public GamePlayer GamePlayer
        {
            get => default;
            set
            {
            }
        }

        public static bool CheckCollision(GameCell cell)
        {
            if (cell.CurrentGameObject.GameObjectType == GameObjectType.BULLET || cell.CurrentGameObject.GameObjectType == GameObjectType.ENEMY)
            {
                return true;
            }

            return false;
        }
    }
}
