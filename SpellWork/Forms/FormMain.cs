using SpellWork.Database;
using SpellWork.DBC.Structures;
using SpellWork.Extensions;
using SpellWork.Spell;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

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

            _cbAdvancedFilter1.SetStructFields<SpellInfo>();
            _cbAdvancedFilter2.SetStructFields<SpellInfo>();

            _cbAdvancedEffectFilter1.SetStructFields<SpellEffectInfo>();
            _cbAdvancedEffectFilter2.SetStructFields<SpellEffectInfo>();

            _cbAdvancedFilter1CompareType.SetEnumValuesDirect<CompareType>(true);
            _cbAdvancedFilter2CompareType.SetEnumValuesDirect<CompareType>(true);

            _cbAdvancedEffectFilter1CompareType.SetEnumValuesDirect<CompareType>(true);
            _cbAdvancedEffectFilter2CompareType.SetEnumValuesDirect<CompareType>(true);

            ConnStatus();
        }

        #region FORM

        private void ExitClick(object sender, EventArgs e)
        {
            Application.Exit();
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
                //MySqlConnection.AddDBItems();
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
            if (!((char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void LevelScalingClick(object sender, EventArgs e)
        {
            var scalingForm = new FormSpellScaling();
            var ret = scalingForm.ShowDialog(this);
            if (ret == DialogResult.OK)
            {
                DBC.DBC.SelectedLevel = scalingForm.SelectedLevel;
                DBC.DBC.SelectedItemLevel = scalingForm.SelectedItemLevel;
                DBC.DBC.SelectedMapDifficulty = scalingForm.SelectedMapDifficulty;
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
                _spellList[_lvSpellList.SelectedIndices[0]].Write(_rtSpellInfo);
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

            _spellList = (from spellInfo in DBC.DBC.SpellInfoStore.Values
                          where
                              ((id == 0 || spellInfo.ID == id) && (ic == 0 || spellInfo.SpellIconFileDataID == ic) &&
                               (at == 0 || (spellInfo.Attributes & at) != 0 || (spellInfo.AttributesEx & at) != 0 ||
                                (spellInfo.AttributesEx2 & at) != 0 || (spellInfo.AttributesEx3 & at) != 0 ||
                                (spellInfo.AttributesEx4 & at) != 0 || (spellInfo.AttributesEx5 & at) != 0 ||
                                (spellInfo.AttributesEx6 & at) != 0 || (spellInfo.AttributesEx7 & at) != 0 ||
                                (spellInfo.AttributesEx8 & at) != 0 || (spellInfo.AttributesEx9 & at) != 0 ||
                                (spellInfo.AttributesEx10 & at) != 0 || (spellInfo.AttributesEx11 & at) != 0 ||
                                (spellInfo.AttributesEx12 & at) != 0 || (spellInfo.AttributesEx13 & at) != 0 || 
                                (spellInfo.AttributesEx14 & at) != 0)) && ((id != 0 || ic != 0 && at != 0) ||
                                spellInfo.Name.ContainsText(name))
                          orderby spellInfo.ID
                          select spellInfo).ToList();

            _lvSpellList.VirtualListSize = _spellList.Count;
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

            // additional spell effect filters
            var advEffectVal1 = _tbAdvancedEffectFilter1Val.Text;
            var advEffectVal2 = _tbAdvancedEffectFilter2Val.Text;

            var fieldEffect1 = (MemberInfo)_cbAdvancedEffectFilter1.SelectedValue;
            var fieldEffect2 = (MemberInfo)_cbAdvancedEffectFilter2.SelectedValue;

            var use1EffectVal = !string.IsNullOrEmpty(advEffectVal1);
            var use2EffectVal = !string.IsNullOrEmpty(advEffectVal2);

            var fieldEffect1Ct = (CompareType)_cbAdvancedEffectFilter1CompareType.SelectedIndex;
            var fieldEffect2Ct = (CompareType)_cbAdvancedEffectFilter2CompareType.SelectedIndex;

            // additional filters
            var advVal1 = _tbAdvancedFilter1Val.Text;
            var advVal2 = _tbAdvancedFilter2Val.Text;

            var field1 = (MemberInfo)_cbAdvancedFilter1.SelectedValue;
            var field2 = (MemberInfo)_cbAdvancedFilter2.SelectedValue;

            var use1Val = !string.IsNullOrEmpty(advVal1);
            var use2Val = !string.IsNullOrEmpty(advVal2);

            var field1Ct = (CompareType)_cbAdvancedFilter1CompareType.SelectedIndex;
            var field2Ct = (CompareType)_cbAdvancedFilter2CompareType.SelectedIndex;

            _spellList = DBC.DBC.SpellInfoStore.Values.Where(
                spell => (!bFamilyNames || spell.SpellFamilyName == fFamilyNames) &&
                         (!bSpellEffect || spell.HasEffect((SpellEffects)fSpellEffect)) &&
                         (!bSpellAura || spell.HasAura((AuraType)fSpellAura)) &&
                         (!bTarget1 || spell.HasTargetA((Targets)fTarget1)) &&
                         (!bTarget2 || spell.HasTargetB((Targets)fTarget2)) &&
                         (!use1Val || spell.CreateFilter(field1, advVal1, field1Ct)) &&
                         (!use2Val || spell.CreateFilter(field2, advVal2, field2Ct)) &&
                         (spell.SpellEffectInfoStore.Any(effect =>
                         (!use1EffectVal || effect.Value.CreateFilter(fieldEffect1, advEffectVal1, fieldEffect1Ct)) &&
                         (!use2EffectVal || effect.Value.CreateFilter(fieldEffect2, advEffectVal2, fieldEffect2Ct)))))
                .OrderBy(spell => spell.ID)
                .ToList();

            _lvSpellList.VirtualListSize = _spellList.Count;
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
                SetProcAttribute(DBC.DBC.SpellInfoStore[e.Node.Name.ToInt32()]);
        }

        private void LvProcSpellListSelectedIndexChanged(object sender, EventArgs e)
        {
            var lv = (ListView)sender;
            if (lv.SelectedIndices.Count <= 0)
                return;
            SetProcAttribute(_spellProcList[lv.SelectedIndices[0]]);
            _lvProcAdditionalInfo.Items.Clear();
        }

        private void LvProcAdditionalInfoSelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lvProcAdditionalInfo.SelectedIndices.Count > 0)
                SetProcAttribute(DBC.DBC.SpellInfoStore[_lvProcAdditionalInfo.SelectedItems[0].SubItems[0].Text.ToInt32()]);
        }

        private void ClbSchoolsSelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProcInfo.SpellProc == null || ProcInfo.SpellProc.ID == 0)
                return;
            _bWrite.Enabled = true;
            GetProcAttribute(ProcInfo.SpellProc);
        }

        private void TbCooldownTextChanged(object sender, EventArgs e)
        {
            if (ProcInfo.SpellProc == null || ProcInfo.SpellProc.ID == 0)
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

            ProcInfo.Fill(_tvFamilyTree, spellfamily);
        }

        private void SetProcAttribute(SpellInfo spell)
        {
            spell.Write(_rtbProcSpellInfo);

            _cbProcSpellFamilyTree.SelectedValue = spell.SpellFamilyName;
            _clbProcFlags.SetCheckedItemFromFlag(spell.ProcFlags);
            _clbSchools.SetCheckedItemFromFlag(spell.SchoolMask);
            _cbProcFitstSpellFamily.SelectedValue = spell.SpellFamilyName;
            _tbPPM.Text = @"0"; // need correct value
            _tbChance.Text = spell.ProcChance.ToString();
            _tbCooldown.Text = (spell.RecoveryTime / 1000f).ToString(CultureInfo.InvariantCulture);
        }

        private void GetProcAttribute(SpellInfo spell)
        {
            var SpellFamilyFlags = _tvFamilyTree.GetMask();
            var statusproc =
                $"Spell ({spell.ID}) {spell.Name}. Proc Event ==> SchoolMask 0x{_clbSchools.GetFlagsValue():X2}, SpellFamily {_cbProcFitstSpellFamily.SelectedValue}, 0x{SpellFamilyFlags[0]:X8} {SpellFamilyFlags[1]:X8} {SpellFamilyFlags[2]:X8} {SpellFamilyFlags[3]:X8}, procFlag 0x{_clbProcFlags.GetFlagsValue():X8}, procEx 0x{_clbProcFlagEx.GetFlagsValue():X8}, PPMRate {_tbPPM.Text.ToFloat()}";

            _gSpellProcEvent.Text = "Spell Proc Event    " + statusproc;
        }

        private void Search()
        {
            var id = _tbProcSeach.Text.ToUInt32();

            _spellProcList = (from spell in DBC.DBC.SpellInfoStore.Values
                              where
                                  (id == 0 || spell.ID == id) &&
                                  (id != 0 || spell.Name.ContainsText(_tbProcSeach.Text))
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
                              orderby spell.ID
                              select spell).ToList();

            _lvProcSpellList.VirtualListSize = _spellProcList.Count();
            if (_lvProcSpellList.SelectedIndices.Count > 0)
                _lvProcSpellList.Items[_lvProcSpellList.SelectedIndices[0]].Selected = false;
        }

        private void FamilyTreeAfterCheck(object sender, TreeViewEventArgs e)
        {
            if (ProcInfo.SpellProc == null || !ProcInfo.Update)
                return;

            _bWrite.Enabled = true;
            _lvProcAdditionalInfo.Items.Clear();

            var mask = ((TreeView)sender).GetMask();

            var query = from spell in DBC.DBC.SpellInfoStore.Values
                        where
                            spell.SpellFamilyName == ProcInfo.SpellProc.SpellFamilyName &&
                            spell.SpellClassMask.ContainsElement(mask)
                        join sk in DBC.DBC.SkillLineAbility.Values on spell.ID equals sk.Spell into temp1
                        from skill in temp1.DefaultIfEmpty(new SkillLineAbilityEntry())
                        join skl in DBC.DBC.SkillLine on skill.SkillLine equals skl.Key into temp2
                        from SkillLine in temp2.DefaultIfEmpty()
                        orderby spell.ID, skill.SkillLine
                        select
                            new
                            {
                                SpellID = spell.ID,
                                SpellName = spell.Name + " " + spell.Description,
                                skill.SkillLine
                            };

            foreach (var lvi in
                query.Select(str => new ListViewItem(new[] { str.SpellID.ToString(), str.SpellName }) { ImageKey = str.SkillLine != 0 ? "plus.ico" : "munus.ico" }))
                _lvProcAdditionalInfo.Items.Add(lvi);

            GetProcAttribute(ProcInfo.SpellProc);
        }

        #endregion

        #region COMPARE PAGE

        private void CompareFilterSpellTextChanged(object sender, EventArgs e)
        {
            var spell1 = _tbCompareFilterSpell1.Text.ToInt32();
            var spell2 = _tbCompareFilterSpell2.Text.ToInt32();

            if (DBC.DBC.SpellInfoStore.ContainsKey(spell1) && DBC.DBC.SpellInfoStore.ContainsKey(spell2))
                SpellCompare.Compare(_rtbCompareSpell1, _rtbCompareSpell2, DBC.DBC.SpellInfoStore[spell1], DBC.DBC.SpellInfoStore[spell2]);
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
            if (string.IsNullOrEmpty(_rtbSqlLog.Text))
                return;

            var sd = new SaveFileDialog { Filter = @"SQL files|*.sql" };
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
                    break;
                }
                case "_bSqlProc":
                {
                    var val = _tbSqlProc.Text.ToUInt32();
                    var form = new FormCalculateFlags(typeof(ProcFlags), val, "PROC_FLAG_");
                    form.ShowDialog(this);
                    if (form.DialogResult == DialogResult.OK)
                        _tbSqlProc.Text = form.Flags.ToString();
                    break;
                }
                case "_bSqlProcEx":
                {
                    var val = _tbSqlProcEx.Text.ToUInt32();
                    var form = new FormCalculateFlags(typeof(ProcFlagsEx), val, "PROC_EX_");
                    form.ShowDialog(this);
                    if (form.DialogResult == DialogResult.OK)
                        _tbSqlProcEx.Text = form.Flags.ToString();
                    break;
                }
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

            if (string.IsNullOrEmpty(subquery) && !string.IsNullOrEmpty(_tbSqlManual.Text))
                subquery = "WHERE " + _tbSqlManual.Text;

            var query = $"SELECT * FROM `spell_proc_event` {subquery} ORDER BY entry";
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
            var comment = $"-- ({ProcInfo.SpellProc.ID}) {ProcInfo.SpellProc.Name}";
            // drop query
            var drop = $"DELETE FROM `spell_proc_event` WHERE `entry` IN ({ProcInfo.SpellProc.ID});";
            // insert query
            var insert =
                $"INSERT INTO `spell_proc_event` VALUES ({ProcInfo.SpellProc.ID}, 0x{_clbSchools.GetFlagsValue():X2}, 0x{_cbProcFitstSpellFamily.SelectedValue.ToUInt32():X2}, 0x{spellFamilyFlags[0]:X8}, 0x{spellFamilyFlags[1]:X8}, 0x{spellFamilyFlags[2]:X8}, 0x{spellFamilyFlags[3]:X8}, 0x{_clbProcFlags.GetFlagsValue():X8}, 0x{_clbProcFlagEx.GetFlagsValue():X8}, {_tbPPM.Text.Replace(',', '.')}, {_tbChance.Text.Replace(',', '.')}, {_tbCooldown.Text.Replace(',', '.')});";

            _rtbSqlLog.AppendText(comment + "\r\n" + drop + "\r\n" + insert + "\r\n\r\n");
            _rtbSqlLog.ColorizeCode();
            if (MySqlConnection.Connected)
                MySqlConnection.Insert(drop + insert);

            ((Button)sender).Enabled = false;
        }

        private void ProcParse(object sender)
        {
            var proc = MySqlConnection.SpellProcEvent[((ListView)sender).SelectedIndices[0]];
            var spell = DBC.DBC.SpellInfoStore[(int)proc.Id];
            ProcInfo.SpellProc = spell;

            spell.Write(_rtbProcSpellInfo);

            _clbSchools.SetCheckedItemFromFlag(proc.SchoolMask);
            _clbProcFlags.SetCheckedItemFromFlag(proc.ProcFlags);
            _clbProcFlagEx.SetCheckedItemFromFlag(proc.ProcEx);

            _cbProcSpellFamilyTree.SelectedValue = proc.SpellFamilyName;
            _cbProcFitstSpellFamily.SelectedValue = proc.SpellFamilyName;

            _tbPPM.Text = proc.PpmRate.ToString(CultureInfo.InvariantCulture);
            _tbChance.Text = proc.CustomChance.ToString(CultureInfo.InvariantCulture);
            _tbCooldown.Text = proc.Cooldown.ToString();

            _tvFamilyTree.SetMask(proc.SpellFamilyMask);

            tabControl1.SelectedIndex = 1;
        }

        #endregion

        #region VIRTUAL MODE

        private List<SpellInfo> _spellList = new List<SpellInfo>();
        private List<SpellEffectInfo> _spellEffectList = new List<SpellEffectInfo>();

        private List<SpellInfo> _spellProcList = new List<SpellInfo>();

        private void LvSpellListRetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            e.Item =
                new ListViewItem(new[] { _spellList[e.ItemIndex].ID.ToString(), _spellList[e.ItemIndex].Name, (_spellList[e.ItemIndex].Misc?.ID ?? 0).ToString() });
        }

        private void LvProcSpellListRetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            e.Item =
                new ListViewItem(new[] { _spellProcList[e.ItemIndex].ID.ToString(), _spellProcList[e.ItemIndex].Name });
        }

        private void LvSqlDataRetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            e.Item = new ListViewItem(MySqlConnection.SpellProcEvent[e.ItemIndex].ToArray());
        }

        #endregion
    }
}
