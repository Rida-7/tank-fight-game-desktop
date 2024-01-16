using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameProject.GameGL
{
    public class Bullet : GameObject
    {
        GameDirection direction;
        bool active;

        public Bullet(GameCell startCell, GameDirection direction, Image img) : base(GameObjectType.BULLET, img)
        {
            this.CurrentCell = startCell;
            this.Direction = direction;
            this.Active = true;
        }

        public GameDirection Direction { get => direction; set => direction = value; }
        public bool Active { get => active; set => active = value; }
    }
}
