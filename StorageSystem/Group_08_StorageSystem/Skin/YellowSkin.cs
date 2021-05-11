/***********************************************************************
 * Module:  YellowSkin.cs
 * Author:  32828
 * Purpose: Definition of the Class Skin.YellowSkin
 ***********************************************************************/

using System;
using System.Windows.Forms;
using System.Drawing;

namespace Group_08_StorageSystem
{
   public class YellowSkin : AbstractFactory
   {
      public override FormSkin CreateForm()
      {
         // TODO: implement
          return new YellowForm();
      }
      
      public override TextBoxSkin CreateTextBox()
      {
         // TODO: implement
          return new YellowTextBox();
      }
      
      public override ButtonSkin CreateButton()
      {
         // TODO: implement
          return new YellowButton();
      }

      public override ComboBoxSkin CreateComboBox()
      {
          // TODO: implement
          return new YellowComboBox();
      }
   }
}