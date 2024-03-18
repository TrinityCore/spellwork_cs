using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SpellWork.DBC.Structures;
using SpellWork.Extensions;

namespace SpellWork.Spell
{
    public static class ProcInfo
    {
        public static SpellInfo SpellProc { get; set; }
        public static bool Update = true;

        public static void Fill(TreeView familyTree, SpellFamilyNames spellfamily)
        {
            familyTree.Nodes.Clear();

            var spells = from spell in DBC.DBC.SpellInfoStore.Values
                         where spell.SpellFamilyName == (uint)spellfamily

                         join sk in DBC.DBC.SkillLineAbility.Values on spell.ID equals sk.Spell into temp1
                         from skill in temp1.DefaultIfEmpty(new SkillLineAbilityEntry())

                         join skl in DBC.DBC.SkillLine on skill.SkillLine equals skl.Key into temp2
                         from skillLine in temp2.DefaultIfEmpty()

                         select new
                         {
                             spell,
                             skill.SkillLine,
                             skillLine = skillLine.Value
                         };

            for (var i = 0; i < 128; ++i)
            {
                var mask = new uint[4];

                if (i < 32)
                    mask[0] = 1U << i;
                else if (i < 64)
                    mask[1] = 1U << (i - 32);
                else if (i < 96)
                    mask[2] = 1U << (i - 64);
                else
                    mask[3] = 1U << (i - 96);

                var node   = new TreeNode
                {
                    Text = $"0x{mask[3]:X8} {mask[2]:X8} {mask[1]:X8} {mask[0]:X8}",
                    ImageKey = @"family.ico"
                };
                familyTree.Nodes.Add(node);
            }

            foreach (var elem in spells)
            {
                var spell = elem.spell;
                var isSkill = elem.SkillLine != 0;

                var name    = new StringBuilder();
                var toolTip = new StringBuilder();

                name.AppendFormat("{0} - {1} ", spell.ID, spell.Name);

                toolTip.AppendFormatLine("Spell Name: {0}",  spell.Name);
                toolTip.AppendFormatLine("Description: {0}", spell.Description);
                toolTip.AppendFormatLine("ToolTip: {0}",     spell.Tooltip);

                if (isSkill)
                {
                    name.AppendFormat("(Skill: ({0}) {1}) ", elem.SkillLine, elem.skillLine.DisplayName_lang);

                    toolTip.AppendLine();
                    toolTip.AppendFormatLine("Skill Name: {0}", elem.skillLine.DisplayName_lang);
                    toolTip.AppendFormatLine("Description: {0}", elem.skillLine.Description_lang);
                }

                name.AppendFormat("({0})", ((SpellSchoolMask)spell.SchoolMask).ToString().NormalizeString("MASK_"));

                foreach (TreeNode node in familyTree.Nodes)
                {
                    var mask = new uint[4];

                    if (node.Index < 32)
                        mask[0] = 1U << node.Index;
                    else if (node.Index < 64)
                        mask[1] = 1U << (node.Index - 32);
                    else if (node.Index < 96)
                        mask[2] = 1U << (node.Index - 64);
                    else
                        mask[3] = 1U << (node.Index - 96);

                    if ((!spell.SpellFamilyFlags.ContainsElement(mask)))
                        continue;

                    var child       = node.Nodes.Add(name.ToString());
                    child.Name      = spell.ID.ToString();
                    child.ImageKey  = isSkill ? "plus.ico" : "munus.ico";
                    child.ForeColor = isSkill ? Color.Blue : Color.Red;
                    child.ToolTipText = toolTip.ToString();
                }
            }
        }
    }
}
