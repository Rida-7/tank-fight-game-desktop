using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameProject.GameGL
{
    public class GameObject
    {
        char displayCharacter;
        GameObjectType gameObjectType;
        GameCell currentCell;
        Image img;

        public GameObject(GameObjectType type, char displayCharacter)
        {
            this.displayCharacter = displayCharacter;
            this.gameObjectType = type;

        }

        public GameObject(GameObjectType type, Image img)
        {
            this.gameObjectType = type;
            this.Img = img;
        }

        public static GameObjectType getGameObjectType(char displayCharacter)
        {

            if (displayCharacter == '|' || displayCharacter == '_' || displayCharacter == '!' || displayCharacter == '?')
            {
                return GameObjectType.WALL;
            }
            if (displayCharacter == '.')
            {
                return GameObjectType.BULLET;
            }
            if (displayCharacter == 'B')
            {
                return GameObjectType.ENEMYBULLET;
            }

            

            return GameObjectType.NONE;
        }
        public char DisplayCharacter { get => displayCharacter; set => displayCharacter = value; }
        public GameObjectType GameObjectType { get => gameObjectType; set => gameObjectType = value; }
        public GameCell CurrentCell
        {
            get => currentCell;
            set
            {
                currentCell = value;
                currentCell.setGameObject(this);
            }
        }

        public Image Img { get => img; set => img = value; }

    }
}
