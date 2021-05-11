/***********************************************************************
 * Module:  BlueSkin.cs
 * Author:  32828
 * Purpose: Definition of the Class Skin.BlueSkin
 ***********************************************************************/

using System;
using System.Windows.Forms;
using System.Drawing;

namespace Group_08_StorageSystem
{
   public class BlueSkin : AbstractFactory
   {
      public override FormSkin CreateForm()
      {
         // TODO: implement
          return new BlueForm();
      }
      
      public override TextBoxSkin CreateTextBox()
      {
         // TODO: implement
          return new BlueTextBox();
      }
      
      public override ButtonSkin CreateButton()
      {
         // TODO: implement
          return new BlueButton();
      }

      public override ComboBoxSkin CreateComboBox()
      {
          // TODO: implement
          return new BlueComboBox();
      }
   }
}