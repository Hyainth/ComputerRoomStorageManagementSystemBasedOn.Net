using System;
using System.Windows.Forms;
using System.Drawing;

namespace Group_08_StorageSystem
{
    public class DefaultSkin : AbstractFactory
    {
        public override FormSkin CreateForm()
        {
            // TODO: implement
            return new DefaultForm();
        }

        public override TextBoxSkin CreateTextBox()
        {
            // TODO: implement
            return new DefaultTextBox();
        }

        public override ButtonSkin CreateButton()
        {
            // TODO: implement
            return new DefaultButton();
        }

        public override ComboBoxSkin CreateComboBox()
        {
            // TODO: implement
            return new DefaultComboBox();
        }
    }
}
