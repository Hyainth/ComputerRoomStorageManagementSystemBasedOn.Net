/***********************************************************************
 * Module:  YellowComboBox.cs
 * Author:  32828
 * Purpose: Definition of the Class Skin.YellowComboBox
 ***********************************************************************/

using System;
using System.Windows.Forms;
using System.Drawing;

namespace Group_08_StorageSystem
{
   public class YellowComboBox : ComboBoxSkin
   {
       public override ComboBox Op(ComboBox ComboBox)
       {
           ComboBox.BackColor = System.Drawing.Color.Yellow;
           ComboBox.ForeColor = System.Drawing.Color.Maroon;
           return ComboBox;
       }
   
   }
}