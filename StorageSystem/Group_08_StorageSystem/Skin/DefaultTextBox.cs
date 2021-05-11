using System;
using System.Windows.Forms;
using System.Drawing;

namespace Group_08_StorageSystem
{
    public class DefaultTextBox : TextBoxSkin
    {
        public override TextBox Op(TextBox textbox)
        {
            return textbox;
        }
    }
}
