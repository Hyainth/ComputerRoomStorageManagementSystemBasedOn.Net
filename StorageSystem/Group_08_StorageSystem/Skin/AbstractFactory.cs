/***********************************************************************
 * Module:  AbstractFactory.cs
 * Author:  32828
 * Purpose: Definition of the Class Skin.AbstractFactory
 ***********************************************************************/

using System;
using System.Windows.Forms;
using System.Drawing;

namespace Group_08_StorageSystem
{
    public abstract class AbstractFactory
    {
        public abstract FormSkin CreateForm();

        public abstract TextBoxSkin CreateTextBox();

        public abstract ButtonSkin CreateButton();

        public abstract ComboBoxSkin CreateComboBox();

        public Label labelOP( Label label)
        {
            label.BackColor = Color.Transparent;
            return label;
        }

        public PictureBox PicBoxOP(PictureBox picBox)
        {
            picBox.BackColor = Color.Transparent;
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            return picBox;
        }

        public static string SkinStyle = "";


    }
}