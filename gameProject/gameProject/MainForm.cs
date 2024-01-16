using EZInput;
using gameProject.GameGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameProject
{
    public partial class MainForm : Form
    {
        GamePlayer player;
        public static int Score = 0;
        public static int PlayerHealth = 5;
        public static int VerticalEnemyHealth = 3;
        public static int HorizontalEnemyHealth = 3;
        public static int RandomEnemyHealth = 3;
        EnemyHorizontal horEnemy;
        EnemyVertical verEnemy;
        EnemyRandom randEnemy;
        static List<Enemy> enemies = new List<Enemy>();
        public static List<EnemyBullet> enemyBullets = new List<EnemyBullet>();
        public static List<Bullet> bullets = new List<Bullet>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GameGrid gameGrid = new GameGrid("maze1.txt", 28, 67);

            Image playerImage = Game.getCharacterImage('P');
            Image verticalEnemyImage = Game.getCharacterImage('V');
            Image horizontalEnemyImage = Game.getCharacterImage('H');
            Image randomEnemyImage = Game.getCharacterImage('R');
            Image bulletImage = Game.getCharacterImage('.');

            GameCell start = gameGrid.getCell(8, 10);
            GameCell ghostVCell = gameGrid.getCell(8, 6);
            GameCell ghostHCell = gameGrid.getCell(15, 6);
            GameCell ghostRCell = gameGrid.getCell(21, 7);
            gameLoop.Start();

            player = new GamePlayer(playerImage, start);
            verEnemy = new EnemyVertical(verticalEnemyImage, ghostVCell);
            horEnemy = new EnemyHorizontal(horizontalEnemyImage, ghostHCell);
            randEnemy = new EnemyRandom(randomEnemyImage, ghostRCell);

            enemies.Add(verEnemy);
            enemies.Add(horEnemy);
            enemies.Add(randEnemy);

            printMaze(gameGrid);
            
        }

        private void printMaze(GameGrid gameGrid)
        {
            for (int x = 0; x < gameGrid.Rows; x++)
            {
                for (int y = 0; y < gameGrid.Cols; y++)
                {
                    GameCell cell = gameGrid.getCell(x, y);

                    this.Controls.Add(cell.PictureBox);
                }
            }
        }

        private void moveEnemy()
        {
            foreach(Enemy e in enemies)
            {
                e.move();
            }
        }

        public static void generateBullet(GamePlayer pacman, GameDirection direction)
        {
            GameCell startCell = pacman.CurrentCell.nextBulletCell(direction);
            {
                if (startCell != null)
                {
                    Image bulletImage = Game.getCharacterImage('.');
                    Bullet bullet = new Bullet(startCell, direction, bulletImage);
                    bullets.Add(bullet);
                    startCell.setGameObject(bullet);
                    bullet.Active = true;
                }
            }
        }

        public void moveBullets()
        {
            List<Bullet> bulletsToRemove = new List<Bullet>();
            foreach(Bullet bullet in bullets)
            {
                GameCell currentCell = bullet.CurrentCell;
                GameCell nextCell = currentCell.nextBulletCell(bullet.Direction);
                if(nextCell != currentCell)
                {
                    if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.NONE || nextCell.CurrentGameObject.GameObjectType == GameObjectType.WALL)
                    {
                        currentCell.setGameObject(Game.getBlankObject());
                        bullet.CurrentCell = nextCell;
                        nextCell.setGameObject(bullet);
                        bullet.Active = true;
                    }
                    else
                    {
                        bullet.Active = false;
                    }
                }
                else
                {
                    bullet.Active = false;
                }
                if (!bullet.Active)
                {
                    bulletsToRemove.Add(bullet);
                }
            }
            foreach(Bullet bullet in bulletsToRemove)
            {
                bullet.CurrentCell.setGameObject(Game.getBlankObject());
                bullets.Remove(bullet);
            }
        }

        public static void decreaseVerticalEnemyHealth()
        {
            if (VerticalEnemyHealth > 0)
            {
                VerticalEnemyHealth = VerticalEnemyHealth - 1;
            }
            if (VerticalEnemyHealth == 0)
            {
                WinForm f = new WinForm();
                f.Show();
            }
        }

        public static void decreaseHorizontalEnemyHealth()
        {
            if (HorizontalEnemyHealth > 0)
            {
                HorizontalEnemyHealth = HorizontalEnemyHealth - 1;
            }
        }

        public static void decreaseRandomEnemyHealth()
        {
            if (RandomEnemyHealth > 0)
            {
                RandomEnemyHealth = RandomEnemyHealth - 1;
            }
        }

        public static void addScore()
        {
            Score = Score + 1;
            
        }

        public static void decreaseScore()
        {
            if (Score > 0)
            {
                Score = Score - 1;
            }
        }

        public static void decreasePlayerHealth()
        {
            if (PlayerHealth > 0)
            {
                PlayerHealth = PlayerHealth - 1;
            }
            if (PlayerHealth == 0)
            {
                LoseForm f = new LoseForm();
                f.Show();
            }
        }

        public static void generateEnemyBullet(Enemy pacman, GameDirection direction)
        {
            GameCell startCell = pacman.CurrentCell.nextBulletCell(direction);
            {
                if (startCell != null)
                {
                    Image bulletImage = Game.getCharacterImage('B');
                    EnemyBullet bullet = new EnemyBullet(startCell, direction, bulletImage);
                    enemyBullets.Add(bullet);
                    startCell.setGameObject(bullet);
                    bullet.Active = true;
                }
            }
        }

        public void moveEnemyBullets()
        {
            List<EnemyBullet> bulletsToRemove = new List<EnemyBullet>();
            foreach (EnemyBullet bullet in enemyBullets)
            {
                GameCell currentCell = bullet.CurrentCell;
                GameCell nextCell = currentCell.nextBulletCell(bullet.Direction);
                if (nextCell != currentCell)
                {
                    if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.NONE || nextCell.CurrentGameObject.GameObjectType == GameObjectType.WALL)
                    {
                        currentCell.setGameObject(Game.getBlankObject());
                        bullet.CurrentCell = nextCell;
                        nextCell.setGameObject(bullet);
                        bullet.Active = true;
                    }
                    else
                    {
                        bullet.Active = false;
                    }
                }
                else
                {
                    bullet.Active = false;
                }
                if (!bullet.Active)
                {
                    bulletsToRemove.Add(bullet);
                }
            }
            foreach (EnemyBullet bullet in bulletsToRemove)
            {
                bullet.CurrentCell.setGameObject(Game.getBlankObject());
                enemyBullets.Remove(bullet);
            }
        }

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                player.move(GameDirection.Left);
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                player.move(GameDirection.Right);
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                player.move(GameDirection.Up);
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                player.move(GameDirection.Down);
            }
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                generateBullet(player, GameDirection.Left);
            }
            moveBullets();
            generateEnemyBullet(verEnemy, GameDirection.Right);
            generateEnemyBullet(horEnemy, GameDirection.Up);
            generateEnemyBullet(randEnemy, GameDirection.Right);
            moveEnemy();
            moveEnemyBullets();
            lblScore.Text = "Score = " + Score.ToString();
            lblVerHealth.Text = "VerticalEnemyHealth = " + VerticalEnemyHealth.ToString();
            lblHorHealth.Text = "HorizontalEnemyHealth = " + HorizontalEnemyHealth.ToString();
            lblRandHealth.Text = "RandomEnemyHealth = " + RandomEnemyHealth.ToString();
            lblHealth.Text = "PlayerHealth = " + PlayerHealth.ToString();
            


        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            
        }
    }
}
