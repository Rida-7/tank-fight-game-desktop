using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameProject.GameGL
{
     class EnemyRandom : Enemy
    {
        GameDirection gameDirection;
        public EnemyRandom(Image img, GameCell startCell) : base(img, startCell)
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
            else if (gameDirection == GameDirection.Left)
            {
                gameDirection = GameDirection.Right;
            }
            else if (gameDirection == GameDirection.Right)
            {
                gameDirection = GameDirection.Left;
            }
        }
        public void setRandomDirection()
        {
            Random r = new Random();
            int value = r.Next(4);
            if (value == 0)
            {
                gameDirection = GameDirection.Left;
            }
            else if (value == 1)
            {
                gameDirection = GameDirection.Right;
            }
            else if (value == 2)
            {
                gameDirection = GameDirection.Up;
            }
            else if (value == 3)
            {
                gameDirection = GameDirection.Down;
            }
        }

        public override GameCell move()
        {
            setRandomDirection();
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(gameDirection);
            this.CurrentCell = nextCell;
            if (currentCell != nextCell && (nextCell.CurrentGameObject.GameObjectType != GameObjectType.WALL))
            {
                if (Collision.CheckCollision(currentCell))
                {
                    if (currentCell.CurrentGameObject.GameObjectType == GameObjectType.BULLET)
                    {
                        MainForm.addScore();
                        MainForm.decreaseRandomEnemyHealth();
                    }
                }
                currentCell.setGameObject(Game.getBlankObject());
            }
            if (currentCell == nextCell)
            {
                direction();
            }

            return nextCell;
        }
    }
}
