/***********************************************************************
 * Module:  BlueTextBox.cs
 * Author:  32828
 * Purpose: Definition of the Class Skin.BlueTextBox
 ***********************************************************************/

using System;
using System.Windows.Forms;
using System.Drawing;

namespace Group_08_StorageSystem
{
   public class BlueTextBox : TextBoxSkin
   {
       public override TextBox Op(TextBox textbox)
       {
           textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
           textbox.ForeColor = System.Drawing.Color.Yellow;
           return textbox;
       }
   
   }
}