using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameProject.GameGL
{
    public class GamePlayer : GameObject
    {
        public GamePlayer(Image img, GameCell startCell) : base(GameObjectType.PLAYER, img)
        {
            this.CurrentCell = startCell;
        }

        public GameCell move(GameDirection direction)
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = CurrentCell.nextCell(direction);
            this.CurrentCell = nextCell;
            if (currentCell != nextCell)
            {
                if (Collision.CheckCollision(currentCell))
                {
                    if ( currentCell.CurrentGameObject.GameObjectType == GameObjectType.ENEMY)
                    {
                        MainForm.decreasePlayerHealth();
                    }
                    if (currentCell.CurrentGameObject.GameObjectType == GameObjectType.ENEMYBULLET)
                    {
                        MainForm.decreaseScore();
                    }
                }

                currentCell.setGameObject(Game.getBlankObject());
            }

            return nextCell;
        }
    }
}
