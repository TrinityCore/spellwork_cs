using SpellWork.Extensions;
using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace SpellWork.Forms
{
    public sealed partial class FormCalculateFlags : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public uint Flags { get; private set; }

        public FormCalculateFlags(Type data, uint value, string remove)
        {
            InitializeComponent();

            _clbCalcFlags.SetFlags(data, remove);
            _clbCalcFlags.SetCheckedItemFromFlag(value);

            Text = @"Calculate " + data.Name;
        }

        private void BOkClick(object sender, EventArgs e)
        {
            Flags = _clbCalcFlags.GetFlagsValue();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BNoClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ClbCalcFlagsSelectedValueChanged(object sender, EventArgs e)
        {
            Flags = _clbCalcFlags.GetFlagsValue();
            _lFlagValue.Text = @"Value: " + Flags;
        }
    }
}
