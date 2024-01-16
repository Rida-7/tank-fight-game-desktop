using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameProject.GameGL
{
    public class Game
    {
        public GameGrid GameGrid
        {
            get => default;
            set
            {
            }
        }

        public static GameObject getBlankObject()
        {
            GameObject blankObject = new GameObject(GameObjectType.NONE, Properties.Resources.simplebox);
            return blankObject;
        }

        public static Image getCharacterImage(char displayCharacter)
        {
            Image img = Properties.Resources.simplebox;
            if (displayCharacter == '|' || displayCharacter == '?')
            {
                img = Properties.Resources.brickVertical;
            }
            else if (displayCharacter == '!' || displayCharacter == '_')
            {
                img = Properties.Resources.brickHorizontal___Copy;
            }
            else if (displayCharacter == 'P')
            {
                img = Properties.Resources.tank1;
            }
            else if (displayCharacter == '.')
            {
               img = Properties.Resources.bullet1;
            }
            else if (displayCharacter == 'B')
            {
                img = Properties.Resources.bullet2;
            }
            else if (displayCharacter == 'V')
            {
                img = Properties.Resources.tank2;
            }
            else if (displayCharacter == 'H')
            {
                img = Properties.Resources.tank3;
            }
            else if (displayCharacter == 'R')
            {
                img = Properties.Resources.tank4;
            }
            else if (displayCharacter == 'S')
            {
                img = Properties.Resources.tank5;
            }
            return img;
        }
    }
}
