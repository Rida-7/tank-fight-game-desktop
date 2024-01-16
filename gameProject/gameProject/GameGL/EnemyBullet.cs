using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameProject.GameGL
{
    public class EnemyBullet : GameObject
    {
        GameDirection direction;
        bool active;

        public EnemyBullet(GameCell startCell, GameDirection direction, Image img) : base(GameObjectType.ENEMYBULLET, img)
        {
            this.CurrentCell = startCell;
            this.Direction = direction;
            this.Active = true;
        }

        public GameDirection Direction { get => direction; set => direction = value; }
        public bool Active { get => active; set => active = value; }
    }
}
