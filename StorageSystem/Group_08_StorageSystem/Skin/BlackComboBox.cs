using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Group_08_StorageSystem
{
    public class BlackComboBox : ComboBoxSkin
    {
        public override ComboBox Op(ComboBox ComboBox)
        {
            ComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            return ComboBox;
        }

    }
}
