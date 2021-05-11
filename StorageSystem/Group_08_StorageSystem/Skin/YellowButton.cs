/***********************************************************************
 * Module:  YellowButton.cs
 * Author:  32828
 * Purpose: Definition of the Class Skin.YellowButton
 ***********************************************************************/

using System;
using System.Windows.Forms;
using System.Drawing;

namespace Group_08_StorageSystem
{
    public class YellowButton : ButtonSkin
    {
        public override Button Op(Button button)
        {
            button.BackColor = System.Drawing.Color.Yellow;
            button.ForeColor = System.Drawing.Color.Maroon;
            button.BackgroundImage = Image.FromFile(Application.StartupPath + @"/pic/backGroundYellow1.png");
            button.BackgroundImageLayout = ImageLayout.Stretch;
            return button;
        }

    }
}