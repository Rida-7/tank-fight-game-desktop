using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameProject.GameGL
{
     class EnemyVertical : Enemy
    {
        public GameDirection gameDirection = GameDirection.Up;
        public EnemyVertical(Image img, GameCell startCell) : base(img, startCell)
        {
            this.CurrentCell = startCell;
        }

        public override void direction()
        {
            if (gameDirection == GameDirection.Up)
            {
                gameDirection = GameDirection.Down;
            }
            else if (gameDirection == GameDirection.Down)
            {
                gameDirection = GameDirection.Up;
            }
        }

        public override GameCell move()
        {
            GameCell CurrentCell = this.CurrentCell;
            GameCell nextCell = CurrentCell.nextCell(gameDirection);
            this.CurrentCell = nextCell;
            if (CurrentCell == nextCell)
            {
                direction();
            }
            if (CurrentCell != nextCell && (nextCell.CurrentGameObject.GameObjectType != GameObjectType.WALL))
            {
                if (Collision.CheckCollision(CurrentCell))
                {
                    if (CurrentCell.CurrentGameObject.GameObjectType == GameObjectType.BULLET)
                    {
                        MainForm.addScore();
                        MainForm.decreaseVerticalEnemyHealth();
                    }
                }
                CurrentCell.setGameObject(Game.getBlankObject());
            }

            return nextCell;
        }
    }
}
