/***********************************************************************
 * Module:  BlackTextBox.cs
 * Author:  32828
 * Purpose: Definition of the Class Skin.BlackTextBox
 ***********************************************************************/

using System;
using System.Windows.Forms;
using System.Drawing;

namespace Group_08_StorageSystem
{
   public class BlackTextBox : TextBoxSkin
   {
      public override TextBox Op(TextBox textbox)
      {
          textbox.BackColor = System.Drawing.SystemColors.InactiveBorder;
          textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
          return textbox;
      }
   
   }
}