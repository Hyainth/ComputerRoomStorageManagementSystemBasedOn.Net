/***********************************************************************
 * Module:  BlackButton.cs
 * Author:  32828
 * Purpose: Definition of the Class Skin.BlackButton
 ***********************************************************************/

using System;
using System.Windows.Forms;
using System.Drawing;

namespace Group_08_StorageSystem
{
   public class BlackButton : ButtonSkin
   {
       public override Button Op(Button button)
      {
          button.BackColor = System.Drawing.SystemColors.InactiveBorder;
          button.ForeColor = System.Drawing.Color.Black;
          button.BackgroundImage = Image.FromFile(Application.StartupPath + @"/pic/backGroundGray3.png");
          button.BackgroundImageLayout = ImageLayout.Stretch;
          return button;
      }
   
   }
}