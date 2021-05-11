/***********************************************************************
 * Module:  BlueButton.cs
 * Author:  32828
 * Purpose: Definition of the Class Skin.BlueButton
 ***********************************************************************/

using System;
using System.Windows.Forms;
using System.Drawing;

namespace Group_08_StorageSystem
{
   public class BlueButton : ButtonSkin
   {
       public override Button Op(Button button)
      {
          button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
          button.ForeColor = System.Drawing.Color.Purple;
          button.BackgroundImage = Image.FromFile(Application.StartupPath + @"/pic/backGroundPurple1.png");
          button.BackgroundImageLayout = ImageLayout.Stretch;
          return button;
      }
   
   }
}