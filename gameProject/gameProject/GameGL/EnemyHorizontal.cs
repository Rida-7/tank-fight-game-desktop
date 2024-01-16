using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameProject.GameGL
{
     class EnemyHorizontal : Enemy
    {
        public GameDirection gameDirection = GameDirection.Left;
        public EnemyHorizontal(Image img, GameCell startCell) : base(img, startCell)
        {
            this.CurrentCell = startCell;
        }

        public override void direction()
        {
            if (gameDirection == GameDirection.Left)
            {
                gameDirection = GameDirection.Right;
            }
            else if (gameDirection == GameDirection.Right)
            {
                gameDirection = GameDirection.Left;
            }
        }

        public override GameCell move()
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(gameDirection);
            this.CurrentCell = nextCell;

            if (currentCell == nextCell)
            {
                direction();
            }
            if (currentCell != nextCell && (nextCell.CurrentGameObject.GameObjectType != GameObjectType.WALL))
            {
                if (Collision.CheckCollision(currentCell))
                {
                    if (currentCell.CurrentGameObject.GameObjectType == GameObjectType.BULLET)
                    {
                        MainForm.addScore();
                        MainForm.decreaseHorizontalEnemyHealth();
                    }
                }
                currentCell.setGameObject(Game.getBlankObject());
            }

            return nextCell;
        }
    }
}
