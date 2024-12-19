using SpellWork.Extensions;
using SpellWork.Spell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;

namespace SpellWork.Forms
{
    public partial class FormSearch : Form
    {
        private List<SpellInfo> _spellList = new List<SpellInfo>();

        public FormSearch()
        {
            InitializeComponent();
            // load items to control's
            _cbSpellFamily.SetEnumValues<SpellFamilyNames>("SpellFamilyName");
            _cbSpellAura.SetEnumValues<AuraType>("Aura");
            _cbSpellEffect.SetEnumValues<SpellEffects>("Effect");
            _cbTarget1.SetEnumValues<Targets>("Target A");
            _cbTarget2.SetEnumValues<Targets>("Target B");
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SpellInfo Spell { get; private set; }

        private void IdNameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AdvancedSearch();
        }

        private void AdvancedSearch()
        {
            var name = _tbIdName.Text;
            var id = name.ToUInt32();
            var ic = _tbIcon.Text.ToUInt32();
            var at = _tbAttribute.Text.ToUInt32();

            _spellList = (from spell in DBC.DBC.SpellInfoStore.Values
                          where
                              ((id == 0 || spell.ID == id) && (ic == 0 || spell.SpellIconFileDataID == ic) &&
                               (at == 0 || (spell.Attributes & at) != 0 || (spell.AttributesEx & at) != 0 ||
                                (spell.AttributesEx2 & at) != 0 || (spell.AttributesEx3 & at) != 0 ||
                                (spell.AttributesEx4 & at) != 0 || (spell.AttributesEx5 & at) != 0 ||
                                (spell.AttributesEx6 & at) != 0 || (spell.AttributesEx7 & at) != 0 || (spell.AttributesEx8 & at) != 0)) &&
                              (id != 0 || ic != 0 && at != 0) || spell.Name.ContainsText(name)
                          orderby spell.ID
                          select spell).ToList();

            _lvSpellList.VirtualListSize = _spellList.Count;
            groupBox1.Text = @"Spell Search count: " + _spellList.Count;

            if (_lvSpellList.SelectedIndices.Count > 0)
                _lvSpellList.Items[_lvSpellList.SelectedIndices[0]].Selected = false;
        }

        private void SpellFamilySelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex == 0)
                return;

            var bFamilyNames = _cbSpellFamily.SelectedIndex != 0;
            var fFamilyNames = _cbSpellFamily.SelectedValue.ToInt32();

            var bSpellAura = _cbSpellAura.SelectedIndex != 0;
            var fSpellAura = _cbSpellAura.SelectedValue.ToInt32();

            var bSpellEffect = _cbSpellEffect.SelectedIndex != 0;
            var fSpellEffect = _cbSpellEffect.SelectedValue.ToInt32();

            var bTarget1 = _cbTarget1.SelectedIndex != 0;
            var fTarget1 = _cbTarget1.SelectedValue.ToInt32();

            var bTarget2 = _cbTarget2.SelectedIndex != 0;
            var fTarget2 = _cbTarget2.SelectedValue.ToInt32();

            _spellList = (from spell in DBC.DBC.SpellInfoStore.Values
                          where
                              (!bFamilyNames || spell.SpellFamilyName == fFamilyNames) &&
                              (!bSpellEffect || spell.HasEffect((SpellEffects)fSpellEffect)) &&
                              (!bSpellAura || spell.HasAura((AuraType)fSpellAura)) &&
                              (!bTarget1 || spell.HasTargetA((Targets)fTarget1)) &&
                              (!bTarget2 || spell.HasTargetB((Targets)fTarget2))
                          orderby spell.ID
                          select spell).ToList();

            _lvSpellList.VirtualListSize = _spellList.Count();
            groupBox2.Text = @"Spell Filter " + @"count: " + _spellList.Count();

            if (_lvSpellList.SelectedIndices.Count > 0)
                _lvSpellList.Items[_lvSpellList.SelectedIndices[0]].Selected = false;
        }

        private void SpellListSelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lvSpellList.SelectedIndices.Count > 0)
                _spellList[_lvSpellList.SelectedIndices[0]].Write(_rtbSpellInfo);
        }

        private void OkClick(object sender, EventArgs e)
        {
            if (_lvSpellList.SelectedIndices.Count <= 0)
                return;

            Spell = _spellList[_lvSpellList.SelectedIndices[0]];
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelClick(object sender, EventArgs e)
        {
            Close();
        }

        private void SpellListRetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            e.Item = new ListViewItem(new[] { _spellList[e.ItemIndex].ID.ToString(), _spellList[e.ItemIndex].NameAndSubname, (_spellList[e.ItemIndex].Misc?.ID ?? 0).ToString() });
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            AdvancedSearch();
        }
    }
}
