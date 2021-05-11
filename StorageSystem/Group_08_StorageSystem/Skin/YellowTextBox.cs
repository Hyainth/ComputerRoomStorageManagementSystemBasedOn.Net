/***********************************************************************
 * Module:  YellowTextBox.cs
 * Author:  32828
 * Purpose: Definition of the Class Skin.YellowTextBox
 ***********************************************************************/

using System;
using System.Windows.Forms;
using System.Drawing;

namespace Group_08_StorageSystem
{
   public class YellowTextBox : TextBoxSkin
   {
       public override TextBox Op(TextBox textbox)
       {
           textbox.BackColor = System.Drawing.Color.Yellow;
           textbox.ForeColor = System.Drawing.Color.Maroon;
           return textbox;
       }
   
   }
}