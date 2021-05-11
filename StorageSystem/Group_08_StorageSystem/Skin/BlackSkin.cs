/***********************************************************************
 * Module:  BlackSkin.cs
 * Author:  32828
 * Purpose: Definition of the Class Skin.BlackSkin
 ***********************************************************************/

using System;
using System.Windows.Forms;
using System.Drawing;

namespace Group_08_StorageSystem
{
   public class BlackSkin : AbstractFactory
   {
      public override FormSkin CreateForm()
      {
         // TODO: implement
          return new BlackForm();
      }
      
      public override TextBoxSkin CreateTextBox()
      {
         // TODO: implement
          return new BlackTextBox();
      }
      
      public override ButtonSkin CreateButton()
      {
         // TODO: implement
          return new BlackButton();
      }

      public override ComboBoxSkin CreateComboBox()
      {
          // TODO: implement
          return new BlackComboBox();
      }
   }
}