using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using SpellWork.Database;
using SpellWork.DBC.Structures;
using SpellWork.Extensions;
using SpellWork.Spell;

namespace SpellWork.Forms
{
    public sealed partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            splitContainer3.SplitterDistance = 128;

            Text = DBC.DBC.Version;

            _cbSpellFamilyName.SetEnumValues<SpellFamilyNames>("SpellFamilyName");
            _cbSpellAura.SetEnumValues<AuraType>("Aura");
            _cbSpellEffect.SetEnumValues<SpellEffects>("Effect");
            _cbTarget1.SetEnumValues<Targets>("Target A");
            _cbTarget2.SetEnumValues<Targets>("Target B");

            _cbProcSpellFamilyName.SetEnumValues<SpellFamilyNames>("SpellFamilyName");
            _cbProcSpellAura.SetEnumValues<AuraType>("Aura");
            _cbProcSpellEffect.SetEnumValues<SpellEffects>("Effect");
            _cbProcTarget1.SetEnumValues<Targets>("Target A");
            _cbProcTarget2.SetEnumValues<Targets>("Target B");

            _cbProcSpellFamilyTree.SetEnumValues<SpellFamilyNames>("SpellFamilyTree");
            _cbProcFitstSpellFamily.SetEnumValues<SpellFamilyNames>("SpellFamilyName");

            _clbSchools.SetFlags<SpellSchools>();
            _clbProcFlags.SetFlags<ProcFlags>("PROC_FLAG_");
            _clbProcFlagEx.SetFlags<ProcFlagsEx>("PROC_EX_");

            _cbSqlSpellFamily.SetEnumValues<SpellFamilyNames>("SpellFamilyName");

            _cbAdvancedFilter1.SetStructFields<SpellInfoHelper>();
            _cbAdvancedFilter2.SetStructFields<SpellInfoHelper>();

            _cbAdvancedFilter1CompareType.SetEnumValuesDirect<CompareType>(true);
            _cbAdvancedFilter2CompareType.SetEnumValuesDirect<CompareType>(true);

            ConnStatus();
        }

        #region FORM

        private void ExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutClick(object sender, EventArgs e)
        {
            var ab = new FormAboutBox();
            ab.ShowDialog();
        }

        private void TabControl1SelectedIndexChanged(object sender, EventArgs e)
        {
            _cbProcFlag.Visible = _bWrite.Visible = ((TabControl)sender).SelectedIndex == 1;
        }

        private void SettingsClick(object sender, EventArgs e)
        {
            var frm = new FormSettings();
            frm.ShowDialog(this);
            ConnStatus();
        }

        private void FormMainResize(object sender, EventArgs e)
        {
            try
            {
                _scCompareRoot.SplitterDistance = (((Form)sender).Size.Width / 2) - 25;
                _chName.Width = (((Form)sender).Size.Width - 140);
            }
            // ReSharper disable EmptyGeneralCatchClause
            catch (Exception)
            // ReSharper restore EmptyGeneralCatchClause
            {
            }
        }

        private void ConnStatus()
        {
            MySqlConnection.TestConnect();

            if (MySqlConnection.Connected)
            {
                _dbConnect.Text = @"Connection successful.";
                _dbConnect.ForeColor = Color.Green;
                Database.MySqlConnection.AddDBItems();
            }
            else
            {
                _dbConnect.Text = @"No DB Connected";
                _dbConnect.ForeColor = Color.Red;
            }
        }

        private void ConnectedClick(object sender, EventArgs e)
        {
            MySqlConnection.TestConnect();

            if (MySqlConnection.Connected)
                MessageBox.Show(@"Connection is successful!", @"MySQL Connections!", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            else
                MessageBox.Show(@"Connection failed!", @"ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            ConnStatus();
        }

        private void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void LevelScalingClick(object sender, EventArgs e)
        {
            var scalingForm = new FormSpellScaling();
            var ret = scalingForm.ShowDialog(this);
            if (ret == DialogResult.OK)
            {
                DBC.DBC.SelectedLevel = scalingForm.SelectedLevel;
                switch (tabControl1.SelectedIndex)
                {
                    case 0:
                        LvSpellListSelectedIndexChanged(null, null);
                        break;
                    case 1:
                        LvProcSpellListSelectedIndexChanged(null, null);
                        break;
                    case 2:
                        CompareFilterSpellTextChanged(null, null);
                        break;
                    case 3:
                        break;
                }
            }
        }

        #endregion

        #region SPELL INFO PAGE

        private void LvSpellListSelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lvSpellList.SelectedIndices.Count > 0)
                new SpellInfo(_rtSpellInfo, _spellList[_lvSpellList.SelectedIndices[0]]);
        }

        private void TbSearchIdKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AdvancedSearch();
        }

        private void BSearchClick(object sender, EventArgs e)
        {
            AdvancedSearch();
        }

        private void CbSpellFamilyNamesSelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex != 0)
                AdvancedFilter();
        }

        private void TbAdvansedFilterValKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AdvancedFilter();
        }

        private void AdvancedSearch()
        {
            var name = _tbSearchId.Text;
            var id = name.ToUInt32();
            var ic = _tbSearchIcon.Text.ToUInt32();
            var at = _tbSearchAttributes.Text.ToUInt32();

            _spellList = (from spell in DBC.DBC.SpellInfoStore.Values
                          where
                              ((id == 0 || spell.ID == id) && (ic == 0 || spell.SpellIconID == ic) &&
                               (at == 0 || (spell.Attributes & at) != 0 || (spell.AttributesEx & at) != 0 ||
                                (spell.AttributesEx2 & at) != 0 || (spell.AttributesEx3 & at) != 0 ||
                                (spell.AttributesEx4 & at) != 0 || (spell.AttributesEx5 & at) != 0 ||
                                (spell.AttributesEx6 & at) != 0 || (spell.AttributesEx7 & at) != 0 ||
                                (spell.AttributesEx8 & at) != 0 || (spell.AttributesEx9 & at) != 0) ||
                                (spell.AttributesEx10 & at) != 0 || (spell.AttributesEx11 & at) != 0 ||
                                (spell.AttributesEx12 & at) != 0 || (spell.AttributesEx13 & at) != 0) &&
                              ((id != 0 || ic != 0 && at != 0) || spell.SpellName.ContainsText(name))
                          select spell).ToList();

            _lvSpellList.VirtualListSize = _spellList.Count();
            if (_lvSpellList.SelectedIndices.Count > 0)
                _lvSpellList.Items[_lvSpellList.SelectedIndices[0]].Selected = false;
        }

        private void AdvancedFilter()
        {
            var bFamilyNames = _cbSpellFamilyName.SelectedIndex != 0;
            var fFamilyNames = _cbSpellFamilyName.SelectedValue.ToInt32();

            var bSpellAura = _cbSpellAura.SelectedIndex != 0;
            var fSpellAura = _cbSpellAura.SelectedValue.ToInt32();

            var bSpellEffect = _cbSpellEffect.SelectedIndex != 0;
            var fSpellEffect = _cbSpellEffect.SelectedValue.ToInt32();

            var bTarget1 = _cbTarget1.SelectedIndex != 0;
            var fTarget1 = _cbTarget1.SelectedValue.ToInt32();

            var bTarget2 = _cbTarget2.SelectedIndex != 0;
            var fTarget2 = _cbTarget2.SelectedValue.ToInt32();

            // additional filtert
            var advVal1 = _tbAdvancedFilter1Val.Text;
            var advVal2 = _tbAdvancedFilter2Val.Text;

            var field1 = (MemberInfo)_cbAdvancedFilter1.SelectedValue;
            var field2 = (MemberInfo)_cbAdvancedFilter2.SelectedValue;

            var use1Val = advVal1 != string.Empty;
            var use2Val = advVal2 != string.Empty;

            var field1Ct = (CompareType)_cbAdvancedFilter1CompareType.SelectedIndex;
            var field2Ct = (CompareType)_cbAdvancedFilter2CompareType.SelectedIndex;

            _spellList = (from spell in DBC.DBC.SpellInfoStore.Values
                          where
                              (!bFamilyNames || spell.SpellFamilyName == fFamilyNames) &&
                              (!bSpellEffect || spell.HasEffect((SpellEffects)fSpellEffect)) &&
                              (!bSpellAura || spell.HasAura((AuraType)fSpellAura)) &&
                              (!bTarget1 || spell.HasTargetA((Targets)fTarget1)) &&
                              (!bTarget2 || spell.HasTargetB((Targets)fTarget2)) &&
                              (!use1Val || spell.CreateFilter(field1, advVal1, field1Ct)) &&
                              (!use2Val || spell.CreateFilter(field2, advVal2, field2Ct))
                          select spell).ToList();

            _lvSpellList.VirtualListSize = _spellList.Count();
            if (_lvSpellList.SelectedIndices.Count > 0)
                _lvSpellList.Items[_lvSpellList.SelectedIndices[0]].Selected = false;
        }

        #endregion

        #region SPELL PROC INFO PAGE

        private void CbProcSpellFamilyNameSelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex > 0)
                ProcFilter();
        }

        private void CbProcFlagCheckedChanged(object sender, EventArgs e)
        {
            splitContainer3.SplitterDistance = ((CheckBox)sender).Checked ? 240 : 128;
        }

        private void TvFamilyTreeAfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level > 0)
                SetProcAtribute(DBC.DBC.SpellInfoStore[e.Node.Name.ToUInt32()]);
        }

        private void LvProcSpellListSelectedIndexChanged(object sender, EventArgs e)
        {
            var lv = (ListView)sender;
            if (lv.SelectedIndices.Count <= 0)
                return;
            SetProcAtribute(_spellProcList[lv.SelectedIndices[0]]);
            _lvProcAdditionalInfo.Items.Clear();
        }

        private void LvProcAdditionalInfoSelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lvProcAdditionalInfo.SelectedIndices.Count > 0)
                SetProcAtribute(DBC.DBC.SpellInfoStore[_lvProcAdditionalInfo.SelectedItems[0].SubItems[0].Text.ToUInt32()]);
        }

        private void ClbSchoolsSelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProcInfo.SpellProc.ID == 0)
                return;
            _bWrite.Enabled = true;
            GetProcAttribute(ProcInfo.SpellProc);
        }

        private void TbCooldownTextChanged(object sender, EventArgs e)
        {
            if (ProcInfo.SpellProc.ID == 0)
                return;
            _bWrite.Enabled = true;
            GetProcAttribute(ProcInfo.SpellProc);
        }

        private void BProcSearchClick(object sender, EventArgs e)
        {
            Search();
        }

        private void TbSearchKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search();
        }

        private void TvFamilyTreeSelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex == 0)
                return;
            _tvFamilyTree.Nodes.Clear();
            var spellfamily = (SpellFamilyNames)(((ComboBox)sender).SelectedValue.ToInt32());

            new ProcInfo(_tvFamilyTree, spellfamily);
        }

        private void SetProcAtribute(SpellInfoHelper spell)
        {
            new SpellInfo(_rtbProcSpellInfo, spell);

            _cbProcSpellFamilyTree.SelectedValue = spell.SpellFamilyName;
            _clbProcFlags.SetCheckedItemFromFlag(spell.ProcFlags);
            _clbSchools.SetCheckedItemFromFlag(spell.SchoolMask);
            _cbProcFitstSpellFamily.SelectedValue = spell.SpellFamilyName;
            _tbPPM.Text = @"0"; // need correct value
            _tbChance.Text = spell.ProcChance.ToString();
            _tbCooldown.Text = (spell.RecoveryTime / 1000f).ToString();
        }

        private void GetProcAttribute(SpellInfoHelper spell)
        {
            var spellFamilyFlags = _tvFamilyTree.GetMask();
            var statusproc =
                String.Format(
                    "Spell ({0}) {1}. Proc Event ==> SchoolMask 0x{2:X2}, SpellFamily {4}, 0x{4:X8} {5:X8} {6:X8} {7:X8}, procFlag 0x{8:X8}, procEx 0x{9:X8}, PPMRate {10}",
                    spell.ID, spell.SpellNameRank, _clbSchools.GetFlagsValue(), _cbProcFitstSpellFamily.ValueMember,
                    spellFamilyFlags[0], spellFamilyFlags[1], spellFamilyFlags[2], spellFamilyFlags[3], _clbProcFlags.GetFlagsValue(),
                    _clbProcFlagEx.GetFlagsValue(), _tbPPM.Text.ToFloat());

            _gSpellProcEvent.Text = @"Spell Proc Event    " + statusproc;
        }

        private void Search()
        {
            var id = _tbProcSeach.Text.ToUInt32();

            _spellProcList = (from spell in DBC.DBC.SpellInfoStore.Values
                              where
                                  (id == 0 || spell.ID == id) &&
                                  (id != 0 || spell.SpellName.ContainsText(_tbProcSeach.Text))
                              select spell).ToList();

            _lvProcSpellList.VirtualListSize = _spellProcList.Count;
            if (_lvProcSpellList.SelectedIndices.Count > 0)
                _lvProcSpellList.Items[_lvProcSpellList.SelectedIndices[0]].Selected = false;
        }

        private void ProcFilter()
        {
            var bFamilyNames = _cbProcSpellFamilyName.SelectedIndex != 0;
            var fFamilyNames = _cbProcSpellFamilyName.SelectedValue.ToInt32();

            var bSpellAura = _cbProcSpellAura.SelectedIndex != 0;
            var fSpellAura = _cbProcSpellAura.SelectedValue.ToInt32();

            var bSpellEffect = _cbProcSpellEffect.SelectedIndex != 0;
            var fSpellEffect = _cbProcSpellEffect.SelectedValue.ToInt32();

            var bTarget1 = _cbProcTarget1.SelectedIndex != 0;
            var fTarget1 = _cbProcTarget1.SelectedValue.ToInt32();

            var bTarget2 = _cbProcTarget2.SelectedIndex != 0;
            var fTarget2 = _cbProcTarget2.SelectedValue.ToInt32();

            _spellProcList = (from spell in DBC.DBC.SpellInfoStore.Values
                              where
                                  (!bFamilyNames || spell.SpellFamilyName == fFamilyNames) &&
                                  (!bSpellEffect || spell.HasEffect((SpellEffects)fSpellEffect)) &&
                                  (!bSpellAura || spell.HasAura((AuraType)fSpellAura)) &&
                                  (!bTarget1 || spell.HasTargetA((Targets)fTarget1)) &&
                                  (!bTarget2 || spell.HasTargetB((Targets)fTarget2))
                              select spell).ToList();

            _lvProcSpellList.VirtualListSize = _spellProcList.Count();
            if (_lvProcSpellList.SelectedIndices.Count > 0)
                _lvProcSpellList.Items[_lvProcSpellList.SelectedIndices[0]].Selected = false;
        }

        private void FamilyTreeAfterCheck(object sender, TreeViewEventArgs e)
        {
            if (!ProcInfo.Update)
                return;

            _bWrite.Enabled = true;
            _lvProcAdditionalInfo.Items.Clear();

            var mask = ((TreeView)sender).GetMask();

            var query = from spell in DBC.DBC.SpellInfoStore.Values
                        where
                            spell.SpellFamilyName == ProcInfo.SpellProc.SpellFamilyName &&
                            spell.SpellFamilyFlags.ContainsElement(mask)
                        join sk in DBC.DBC.SkillLineAbility.Values on spell.ID equals sk.SpellId into temp1
                        from skill in temp1.DefaultIfEmpty(new SkillLineAbilityEntry())
                        //join skl in DBC.SkillLine on Skill.Value.SkillId equals skl.Value.ID into temp2
                        //from SkillLine in temp2.DefaultIfEmpty()
                        orderby skill.Id descending
                        select
                            new
                            {
                                SpellID = spell.ID,
                                SpellName = spell.SpellNameRank + " " + spell.Description,
                                skill.SkillId
                            };

            foreach (var lvi in
                query.Select(str => new ListViewItem(new[] {str.SpellID.ToString(), str.SpellName}) {ImageKey = str.SkillId != 0 ? "plus.ico" : "munus.ico"}))
                _lvProcAdditionalInfo.Items.Add(lvi);

            GetProcAttribute(ProcInfo.SpellProc);
        }

        #endregion

        #region COMPARE PAGE

        private void CompareFilterSpellTextChanged(object sender, EventArgs e)
        {
            var spell1 = _tbCompareFilterSpell1.Text.ToUInt32();
            var spell2 = _tbCompareFilterSpell2.Text.ToUInt32();

            if (DBC.DBC.SpellInfoStore.ContainsKey(spell1) && DBC.DBC.SpellInfoStore.ContainsKey(spell2))
                new SpellCompare(_rtbCompareSpell1, _rtbCompareSpell2, DBC.DBC.SpellInfoStore[spell1], DBC.DBC.SpellInfoStore[spell2]);
        }

        private void CompareSearch1Click(object sender, EventArgs e)
        {
            var form = new FormSearch();
            form.ShowDialog(this);
            if (form.DialogResult == DialogResult.OK)
                _tbCompareFilterSpell1.Text = form.Spell.ID.ToString();
            form.Dispose();
        }

        private void CompareSearch2Click(object sender, EventArgs e)
        {
            var form = new FormSearch();
            form.ShowDialog(this);
            if (form.DialogResult == DialogResult.OK)
                _tbCompareFilterSpell2.Text = form.Spell.ID.ToString();
            form.Dispose();
        }

        #endregion

        #region SQL PAGE

        private void SqlDataListMouseDoubleClick(object sender, MouseEventArgs e)
        {
            ProcParse(sender);
        }

        private void SqlDataListKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ProcParse(sender);
        }

        private void SqlToBaseClick(object sender, EventArgs e)
        {
            if (MySqlConnection.Connected)
                MySqlConnection.Insert(_rtbSqlLog.Text);
            else
                MessageBox.Show(@"Can't connect to database!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SqlSaveClick(object sender, EventArgs e)
        {
            if (_rtbSqlLog.Text == String.Empty)
                return;

            var sd = new SaveFileDialog {Filter = @"SQL files|*.sql"};
            if (sd.ShowDialog() == DialogResult.OK)
                using (var sw = new StreamWriter(sd.FileName, false, Encoding.UTF8))
                    sw.Write(_rtbSqlLog.Text);
        }

        private void CalcProcFlagsClick(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "_bSqlSchool":
                {
                    var val = _tbSqlSchool.Text.ToUInt32();
                    var form = new FormCalculateFlags(typeof(SpellSchools), val, string.Empty);
                    form.ShowDialog(this);
                    if (form.DialogResult == DialogResult.OK)
                        _tbSqlSchool.Text = form.Flags.ToString();
                }
                    break;
                case "_bSqlProc":
                {
                    var val = _tbSqlProc.Text.ToUInt32();
                    var form = new FormCalculateFlags(typeof(ProcFlags), val, "PROC_FLAG_");
                    form.ShowDialog(this);
                    if (form.DialogResult == DialogResult.OK)
                        _tbSqlProc.Text = form.Flags.ToString();
                }
                    break;
                case "_bSqlProcEx":
                {
                    var val = _tbSqlProcEx.Text.ToUInt32();
                    var form = new FormCalculateFlags(typeof(ProcFlagsEx), val, "PROC_EX_");
                    form.ShowDialog(this);
                    if (form.DialogResult == DialogResult.OK)
                        _tbSqlProcEx.Text = form.Flags.ToString();
                }
                    break;
            }
        }

        private void SelectClick(object sender, EventArgs e)
        {
            if (!MySqlConnection.Connected)
            {
                MessageBox.Show(@"Can't connect to database!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var sb = new StringBuilder("WHERE");
            var compare = _cbBinaryCompare.Checked ? "&" : "=";

            if (_cbSqlSpellFamily.SelectedValue.ToInt32() != -1)
                sb.AppendFormat(" SpellFamilyName = {0} &&", _cbSqlSpellFamily.SelectedValue.ToInt32());

            sb.AppendFormatIfNotNull(" SchoolMask {1} {0} &&", _tbSqlSchool.Text.ToInt32(), compare);
            sb.AppendFormatIfNotNull(" procFlags {1} {0} &&", _tbSqlProc.Text.ToInt32(), compare);
            sb.AppendFormatIfNotNull(" procEx {1} {0}", _tbSqlProcEx.Text.ToInt32(), compare);

            var subquery = sb.ToString() == "WHERE" ? string.Empty : sb.ToString();
            
            if (subquery == string.Empty && _tbSqlManual.Text != string.Empty)
                subquery = "WHERE " + _tbSqlManual.Text;

            var query = String.Format("SELECT * FROM `spell_proc_event` {0} ORDER BY entry", subquery);
            try
            {
                MySqlConnection.SelectProc(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            _lvDataList.VirtualListSize = MySqlConnection.SpellProcEvent.Count;
            if (_lvDataList.SelectedIndices.Count > 0)
                _lvDataList.Items[_lvDataList.SelectedIndices[0]].Selected = false;

            // check bad spell and drop
            foreach (var str in MySqlConnection.Dropped)
                _rtbSqlLog.AppendText(str);
        }

        private void WriteClick(object sender, EventArgs e)
        {
            var spellFamilyFlags = _tvFamilyTree.GetMask();
            // spell comment
            var comment = String.Format("-- ({0}) {1}", ProcInfo.SpellProc.ID, ProcInfo.SpellProc.SpellNameRank);
            // drop query
            var drop = String.Format("DELETE FROM `spell_proc_event` WHERE `entry` IN ({0});", ProcInfo.SpellProc.ID);
            // insert query
            var insert =
                String.Format(
                    "INSERT INTO `spell_proc_event` VALUES ({0}, 0x{1:X2}, 0x{2:X2}, 0x{3:X8}, 0x{4:X8}, 0x{5:X8}, 0x{6:X8}, 0x{7:X8}, 0x{8:X8}, {9}, {10}, {11});",
                    ProcInfo.SpellProc.ID, _clbSchools.GetFlagsValue(), _cbProcFitstSpellFamily.SelectedValue.ToUInt32(),
                    spellFamilyFlags[0], spellFamilyFlags[1], spellFamilyFlags[2], spellFamilyFlags[3], _clbProcFlags.GetFlagsValue(),
                    _clbProcFlagEx.GetFlagsValue(), _tbPPM.Text.Replace(',', '.'), _tbChance.Text.Replace(',', '.'),
                    _tbCooldown.Text.Replace(',', '.'));

            _rtbSqlLog.AppendText(comment + "\r\n" + drop + "\r\n" + insert + "\r\n\r\n");
            _rtbSqlLog.ColorizeCode();
            if (MySqlConnection.Connected)
                MySqlConnection.Insert(drop + insert);

            ((Button)sender).Enabled = false;
        }

        private void ProcParse(object sender)
        {
            var proc = MySqlConnection.SpellProcEvent[((ListView)sender).SelectedIndices[0]];
            var spell = DBC.DBC.SpellInfoStore[proc.Id];
            ProcInfo.SpellProc = spell;

            new SpellInfo(_rtbProcSpellInfo, spell);

            _clbSchools.SetCheckedItemFromFlag(proc.SchoolMask);
            _clbProcFlags.SetCheckedItemFromFlag(proc.ProcFlags);
            _clbProcFlagEx.SetCheckedItemFromFlag(proc.ProcEx);

            _cbProcSpellFamilyTree.SelectedValue = proc.SpellFamilyName;
            _cbProcFitstSpellFamily.SelectedValue = proc.SpellFamilyName;

            _tbPPM.Text = proc.PpmRate.ToString();
            _tbChance.Text = proc.CustomChance.ToString();
            _tbCooldown.Text = proc.Cooldown.ToString();

            _tvFamilyTree.SetMask(proc.SpellFamilyMask);

            tabControl1.SelectedIndex = 1;
        }

        #endregion

        #region VIRTUAL MODE

        private List<SpellInfoHelper> _spellList = new List<SpellInfoHelper>();

        private List<SpellInfoHelper> _spellProcList = new List<SpellInfoHelper>();

        private void LvSpellListRetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            e.Item =
                new ListViewItem(new[] {_spellList[e.ItemIndex].ID.ToString(), _spellList[e.ItemIndex].SpellNameRank});
        }

        private void LvProcSpellListRetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            e.Item =
                new ListViewItem(new[]
                                 {_spellProcList[e.ItemIndex].ID.ToString(), _spellProcList[e.ItemIndex].SpellNameRank});
        }

        private void LvSqlDataRetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            e.Item = new ListViewItem(MySqlConnection.SpellProcEvent[e.ItemIndex].ToArray());
        }

        #endregion
    }
}
