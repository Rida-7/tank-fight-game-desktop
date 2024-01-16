using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameProject.GameGL
{
    public class GameCell
    {
        int row;
        int col;
        GameObject currentGameObject;
        GameGrid grid;
        PictureBox pictureBox;
        const int height = 20;
        const int width = 20;

        public GameCell(int row, int col, GameGrid grid)
        {
            this.row = row;
            this.col = col;
            PictureBox = new PictureBox();
            PictureBox.Left = col * width;
            PictureBox.Top = row * height;
            PictureBox.Size = new Size(width, height);
            PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox.BackColor = Color.Transparent;
            this.grid = grid;
        }

        public void setGameObject(GameObject gameObject)
        {
            currentGameObject = gameObject;
            PictureBox.Image = gameObject.Img;
        }

        public GameCell nextCell(GameDirection direction)
        {

            if (direction == GameDirection.Left)
            {
                if (this.col > 0)
                {
                    GameCell ncell = grid.getCell(row, col - 1);
                    if (ncell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return ncell;
                    }
                }
            }

            if (direction == GameDirection.Right)
            {
                if (this.col < grid.Cols - 1)
                {
                    GameCell ncell = grid.getCell(this.row, this.col + 1);
                    if (ncell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return ncell;
                    }
                }
            }

            if (direction == GameDirection.Up)
            {
                if (this.row > 0)
                {
                    GameCell ncell = grid.getCell(this.row - 1, this.col);
                    if (ncell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return ncell;
                    }
                }
            }

            if (direction == GameDirection.Down)
            {
                if (this.row < grid.Rows - 1)
                {
                    GameCell ncell = grid.getCell(this.row + 1, this.col);
                    if (ncell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return ncell;
                    }
                }
            }
            return this; // if can not return next cell return its own reference
        }

        public GameCell nextBulletCell(GameDirection direction)
        {

            if (direction == GameDirection.Left)
            {
                if (this.col > 0)
                {
                    GameCell ncell = grid.getCell(row, col - 1);
                    if (ncell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return ncell;
                    }
                }
            }

            if (direction == GameDirection.Right)
            {
                if (this.col < grid.Cols - 1)
                {
                    GameCell ncell = grid.getCell(this.row, this.col + 1);
                    if (ncell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return ncell;
                    }
                }
            }

            if (direction == GameDirection.Up)
            {
                if (this.row > 0)
                {
                    GameCell ncell = grid.getCell(this.row - 1, this.col);
                    if (ncell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return ncell;
                    }
                }
            }

            if (direction == GameDirection.Down)
            {
                if (this.row < grid.Rows - 1)
                {
                    GameCell ncell = grid.getCell(this.row + 1, this.col);
                    if (ncell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return ncell;
                    }
                }
            }
            return this;
        }

        public int X { get => row; set => row = value; }
        public int Y { get => col; set => col = value; }
        public GameObject CurrentGameObject { get => currentGameObject; set => currentGameObject = value; }
        public PictureBox PictureBox { get => pictureBox; set => pictureBox = value; }

        public GameObject GameObject
        {
            get => default;
            set
            {
            }
        }
    }
}
