using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SpellWork.Extensions
{
    public static class Extensions
    {
        /// <summary>
        /// Reads the NULL-terminated string from the current stream.
        /// </summary>
        /// <param name="reader">Stream to read from.</param>
        /// <returns>Resulting string.</returns>
        public static string ReadCString(this BinaryReader reader)
        {
            byte num;
            var temp = new List<byte>();

            while ((num = reader.ReadByte()) != 0)
            {
                temp.Add(num);
            }

            return Encoding.UTF8.GetString(temp.ToArray());
        }

        /// <summary>
        /// Reads the struct from the current stream.
        /// </summary>
        /// <typeparam name="T">Struct type.</typeparam>
        /// <param name="reader">Stream to read from.</param>
        /// <returns>Resulting struct.</returns>
        public static T ReadStruct<T>(this BinaryReader reader) where T : struct
        {
            var rawData = reader.ReadBytes(Marshal.SizeOf(typeof(T)));

            var handle = GCHandle.Alloc(rawData, GCHandleType.Pinned);
            var returnObject = (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));

            handle.Free();

            return returnObject;
        }

        public static StringBuilder AppendFormatIfNotNull(this StringBuilder builder, string format, params object[] arg)
        {
            return arg[0].ToUInt32() != 0 ? builder.AppendFormat(format, arg) : builder;
        }

        // Append Format Line
        public static StringBuilder AppendFormatLine(this StringBuilder builder, string format, params object[] arg0)
        {
            return builder.AppendFormat(format, arg0).AppendLine();
        }

        public static StringBuilder AppendFormatLineIfNotNull(this StringBuilder builder, string format, int arg)
        {
            return arg != 0 ? builder.AppendFormat(format, arg).AppendLine() : builder;
        }

        public static StringBuilder AppendFormatLineIfNotNull(this StringBuilder builder, string format, uint arg)
        {
            return arg != 0 ? builder.AppendFormat(format, arg).AppendLine() : builder;
        }

        public static uint ToUInt32(this Object val)
        {
            if (val == null)
                return 0;

            uint num;
            uint.TryParse(val.ToString(), out num);
            return num;
        }

        public static int ToInt32(this Object val)
        {
            if (val == null)
                return 0;

            int num;
            int.TryParse(val.ToString(), out num);
            return num;
        }

        public static float ToFloat(this Object val)
        {
            if (val == null)
                return 0.0f;

            float num;
            float.TryParse(val.ToString().Replace(',', '.'), out num);
            return num;
        }

        public static ulong ToUlong(this Object val)
        {
            if (val == null)
                return 0U;

            ulong num;
            ulong.TryParse(val.ToString(), out num);
            return num;
        }

        public static String NormalizeString(this String text, String remove)
        {
            var str = String.Empty;
            if (remove != String.Empty)
            {
                text = text.Replace(remove, String.Empty);
            }

            foreach (var s in text.Split('_'))
            {
                var i = 0;
                foreach (var c in s.ToCharArray())
                {
                    str += i == 0 ? c.ToString().ToUpper() : c.ToString().ToLower();
                    i++;
                }
                str += " ";
            }

            return str.Remove(str.Length - 1);
        }

        public static void SetCheckedItemFromFlag(this CheckedListBox name, uint value)
        {
            for (var i = 0; i < name.Items.Count; ++i)
                name.SetItemChecked(i, ((value / (1U << (i - 1))) % 2) != 0);
        }

        public static uint GetFlagsValue(this CheckedListBox name)
        {
            uint val = 0;
            for (var i = 0; i < name.CheckedIndices.Count; ++i)
                val |= 1U << (name.CheckedIndices[i]);

            return val;
        }

        public static void SetFlags<T>(this CheckedListBox clb)
        {
            clb.Items.Clear();

            foreach (var elem in Enum.GetValues(typeof(T)))
                clb.Items.Add(elem.ToString().NormalizeString(String.Empty));
        }

        public static void SetFlags<T>(this CheckedListBox clb, String remove)
        {
            clb.Items.Clear();

            foreach (var elem in Enum.GetValues(typeof(T)))
                clb.Items.Add(elem.ToString().NormalizeString(remove));
        }

        public static void SetFlags(this CheckedListBox clb, Type type, String remove)
        {
            clb.Items.Clear();

            foreach (var elem in Enum.GetValues(type))
                clb.Items.Add(elem.ToString().NormalizeString(remove));
        }

        public static void SetEnumValues<T>(this ComboBox cb, string noValue)
        {
            var dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("NAME");

            dt.Rows.Add(new Object[] { -1, noValue });

            foreach (var str in Enum.GetValues(typeof(T)))
                dt.Rows.Add(new Object[] { (int)str, "(" + ((int)str).ToString("000") + ") " + str });

            cb.DataSource = dt;
            cb.DisplayMember = "NAME";
            cb.ValueMember = "ID";
        }

        public static void SetEnumValuesDirect<T>(this ComboBox cb, Boolean setFirstValue)
        {
            cb.BeginUpdate();

            cb.Items.Clear();
            foreach (var value in Enum.GetValues(typeof(T)))
                cb.Items.Add(((Enum)value).GetFullName());

            if (setFirstValue && cb.Items.Count > 0)
                cb.SelectedIndex = 0;

            cb.EndUpdate();
        }

        public static void SetStructFields<T>(this ComboBox cb)
        {
            cb.Items.Clear();

            var dt = new DataTable();
            dt.Columns.Add("ID", typeof(MemberInfo));
            dt.Columns.Add("NAME", typeof(String));

            var type = typeof(T).GetMembers();
            var i = 0;
            foreach (var str in type)
            {
                if (!(str is FieldInfo) && !(str is PropertyInfo))
                    continue;

                var dr = dt.NewRow();
                dr["ID"] = str;
                dr["NAME"] = String.Format("({0:000}) {1}", i, str.Name);
                dt.Rows.Add(dr);
                ++i;
            }

            cb.DataSource    = dt;
            cb.DisplayMember = "NAME";
            cb.ValueMember   = "ID";
        }

        /// <summary>
        /// Compares the text on the partial occurrence of a string and ignore case
        /// </summary>
        /// <param name="text">The original text, which will search entry</param>
        /// <param name="compareText">String which will be matched with the original text</param>
        /// <returns>Boolean(true or false)</returns>
        public static bool ContainsText(this string text, string compareText)
        {
            return (text.ToUpper().IndexOf(compareText.ToUpper(), StringComparison.CurrentCultureIgnoreCase) != -1);
        }

        /// <summary>
        /// Compares the text on the partial occurrence of a string and ignore case
        /// </summary>
        /// <param name="text">The original text, which will search entry</param>
        /// <param name="compareText">Array strings which will be matched with the original text</param>
        /// <returns>Boolean(true or false)</returns>
        public static bool ContainsText(this string text, string[] compareText)
        {
            return compareText.Any(str => (text.IndexOf(str, StringComparison.CurrentCultureIgnoreCase) != -1));
        }

        public static bool ContainsElement(this uint[] array, uint[] value)
        {
            return array.Length == value.Length && array.Where((t, i) => (t & value[i]) != 0).Any();
        }

        public static bool Match(this DBC.Structures.SpellClassOptionsEntry opt, DBC.Structures.SpellClassOptionsEntry arg, uint[] mask)
        {
            if (opt.SpellFamilyName == arg.SpellFamilyName && opt.SpellFamilyFlags != null && opt.SpellFamilyFlags.ContainsElement(mask))
                return true;
            return false;
        }

        /// <summary>
        /// Checks if the specified value in a given array
        /// </summary>
        /// <param name="array">Array in which to search</param>
        /// <param name="value">Meaning Search</param>
        /// <returns>true or false</returns>
        public static bool ContainsElement(this uint[] array, uint value)
        {
            return array.Any(i => i == value);
        }

        public static bool ContainsElement(this int[] array, int value)
        {
            return array.Any(i => i == value);
        }

        public static T GetValue<T>(this Dictionary<uint, T> dictionary, uint key)
        {
            T value;
            dictionary.TryGetValue(key, out value);
            return value;
        }

        public static bool IsEmpty(this String str)
        {
            return str == String.Empty;
        }

        public static string GetFullName(this Enum @enum)
        {
            var field = @enum.GetType().GetField(@enum.ToString());
            if (field != null)
            {
                var attrs = (FullNameAttribute[])field.GetCustomAttributes(typeof(FullNameAttribute), false);

                if (attrs.Length > 0)
                    return attrs[0].FullName;
            }

            return @enum.ToString();
        }

        public static string FlagToString<T>(this int val)
        {
            string result = string.Empty;
            foreach (var elem in Enum.GetValues(typeof(T)))
            {
                if ((val & (1 << ((int)elem) - 1)) != 0)
                    result = String.Format("{0}{1}, ", result, (T)elem);
            }
            return result.Trim(new char[] { ' ', ',' });
        }

        public static string ToHex(this uint val)
        {
            return String.Format("0x{0:X}", val);
        }
    }

    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public class FullNameAttribute : Attribute
    {
        public string FullName { get; private set; }

        public FullNameAttribute(string fullName)
        {
            FullName = fullName;
        }
    }
}
