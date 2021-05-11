/***********************************************************************
 * Module:  BlueForm.cs
 * Author:  32828
 * Purpose: Definition of the Class Skin.BlueForm
 ***********************************************************************/

using System;
using System.Windows.Forms;
using System.Drawing;

namespace Group_08_StorageSystem
{
   public class BlueForm : FormSkin
   {
       public override Form Op(Form form)
       {
           form.BackgroundImage = Image.FromFile(Application.StartupPath + @"\pic\backGroundPurple1.png");
           form.BackgroundImageLayout = ImageLayout.Stretch;
           return form;
       }
   
   }
}