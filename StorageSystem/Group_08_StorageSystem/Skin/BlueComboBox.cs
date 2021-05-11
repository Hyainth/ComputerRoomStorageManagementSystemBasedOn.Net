/***********************************************************************
 * Module:  BlueComboBox.cs
 * Author:  32828
 * Purpose: Definition of the Class Skin.BlueComboBox
 ***********************************************************************/

using System;
using System.Windows.Forms;
using System.Drawing;

namespace Group_08_StorageSystem
{
   public class BlueComboBox : ComboBoxSkin
   {
       public override ComboBox Op(ComboBox ComboBox)
       {
           ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
           ComboBox.ForeColor = System.Drawing.Color.Yellow;
           return ComboBox;
       }
   
   }
}