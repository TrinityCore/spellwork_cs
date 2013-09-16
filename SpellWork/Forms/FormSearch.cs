using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SpellWork.DBC;
using SpellWork.Extensions;
using SpellWork.Spell;

namespace SpellWork.Forms
{
    public partial class FormSearch : Form
    {
        private List<SpellEntry> _spellList = new List<SpellEntry>();

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

        public SpellEntry Spell { get; private set; }

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

            _spellList = (from spell in DBC.DBC.Spell.Values
                          where
                              ((id == 0 || spell.ID == id) && (ic == 0 || spell.SpellIconID == ic) &&
                               (at == 0 || (spell.Attributes & at) != 0 || (spell.AttributesEx & at) != 0 ||
                                (spell.AttributesEx2 & at) != 0 || (spell.AttributesEx3 & at) != 0 ||
                                (spell.AttributesEx4 & at) != 0 || (spell.AttributesEx5 & at) != 0 ||
                                (spell.AttributesEx6 & at) != 0 || (spell.AttributesEx7 & at) != 0)) &&
                              (id != 0 || ic != 0 && at != 0) || spell.SpellName.ContainsText(name)
                          select spell).ToList();

            _lvSpellList.VirtualListSize = _spellList.Count();
            groupBox1.Text = @"Spell Search count: " + _spellList.Count();

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

            _spellList = (from spell in DBC.DBC.Spell.Values
                          where
                              (!bFamilyNames || spell.SpellFamilyName == fFamilyNames) &&
                              (!bSpellEffect || spell.Effect.ContainsElement((uint)fSpellEffect)) &&
                              (!bSpellAura || spell.EffectApplyAuraName.ContainsElement((uint)fSpellAura)) &&
                              (!bTarget1 || spell.EffectImplicitTargetA.ContainsElement((uint)fTarget1)) &&
                              (!bTarget2 || spell.EffectImplicitTargetB.ContainsElement((uint)fTarget2))
                          select spell).ToList();

            _lvSpellList.VirtualListSize = _spellList.Count();
            groupBox2.Text = @"Spell Filter " + @"count: " + _spellList.Count();

            if (_lvSpellList.SelectedIndices.Count > 0)
                _lvSpellList.Items[_lvSpellList.SelectedIndices[0]].Selected = false;
        }

        private void SpellListSelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lvSpellList.SelectedIndices.Count > 0)
                new SpellInfo(_rtbSpellInfo, _spellList[_lvSpellList.SelectedIndices[0]]);
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
            e.Item = new ListViewItem(new[] {_spellList[e.ItemIndex].ID.ToString(), _spellList[e.ItemIndex].SpellNameRank});
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            AdvancedSearch();
        }
    }
}
