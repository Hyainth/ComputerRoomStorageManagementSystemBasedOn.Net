/***********************************************************************
 * Module:  BlackForm.cs
 * Author:  32828
 * Purpose: Definition of the Class Skin.BlackForm
 ***********************************************************************/

using System;
using System.Windows.Forms;
using System.Drawing;

namespace Group_08_StorageSystem
{
   public class BlackForm : FormSkin
   {
       public override Form Op(Form form)
       {
           form.BackgroundImage = Image.FromFile(Application.StartupPath + @"\pic\backGroundGray2.png");
           form.BackgroundImageLayout = ImageLayout.Stretch;
           return form;
       }
   
   }
}