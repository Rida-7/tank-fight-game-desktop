using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameProject.GameGL
{
    abstract public class  Enemy : GameObject
    {
        public Enemy(Image img, GameCell startCell) : base(GameObjectType.ENEMY, img)
        {
            this.CurrentCell = startCell;
        }

        public abstract void direction();
        public abstract GameCell move();

    }
}
