using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using SpellWork.Extensions;

namespace SpellWork.DBC
{
    static class DBCReader
    {
        /// <exception cref="Exception"><c>Exception</c>.</exception>
        /// <exception cref="FileNotFoundException"><c>FileNotFoundException</c>.</exception>
        public static Dictionary<uint, T> ReadDBC<T>(Dictionary<uint, string> strDict) where T : struct
        {
            var dict = new Dictionary<uint, T>();
            var fileName = Path.Combine(Properties.Settings.Default.DbcPath, typeof(T).Name + ".dbc").Replace("Entry", String.Empty);

            try
            {
                using (var reader = new BinaryReader(new FileStream(fileName, FileMode.Open, FileAccess.Read), Encoding.UTF8))
                {
                    if (!File.Exists(fileName))
                        CheckDirectory<T>();
                    // read dbc header
                    var header = reader.ReadStruct<DbcHeader>();
                    var size = Marshal.SizeOf(typeof(T));

                    if (!header.IsDBC)
                        throw new Exception(fileName + " is not DBC files!");

                    if (header.RecordSize != size)
                        throw new Exception(string.Format("Size of row in DBC file ({0}) != size of DBC struct ({1}) in DBC: {2}", header.RecordSize, size, fileName));

                    // read dbc data
                    for (var r = 0; r < header.RecordsCount; ++r)
                    {
                        var key = reader.ReadUInt32();
                        reader.BaseStream.Position -= 4;

                        var entry = reader.ReadStruct<T>();

                        dict.Add(key, entry);
                    }

                    // read dbc strings
                    if (strDict != null)
                    {
                        while (reader.BaseStream.Position != reader.BaseStream.Length)
                        {
                            var offset = (uint)(reader.BaseStream.Position - header.StartStringPosition);
                            var str = reader.ReadCString();
                            strDict.Add(offset, str);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                if (e is System.IO.DirectoryNotFoundException || e is System.IO.FileNotFoundException)
                {
                    CheckDirectory<T>();
                    return ReadDBC<T>(strDict);
                }
                
                throw;
            }

            return dict;
        }

        private static void CheckDirectory<T>()
        {
            System.Windows.Forms.FolderBrowserDialog fbd = new System.Windows.Forms.FolderBrowserDialog()
            {
                Description = "Select your DBC files path:",
                ShowNewFolderButton = false,
                RootFolder = Environment.SpecialFolder.MyComputer
            };

            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.DbcPath = fbd.SelectedPath;

                var fileName = Path.Combine(Properties.Settings.Default.DbcPath, typeof(T).Name + ".dbc").Replace("Entry", String.Empty);
                if (!File.Exists(fileName))
                    throw new FileNotFoundException();

                Properties.Settings.Default.Save();
            }
            else
                throw new Exception("You didn't select a valid path!");
        }
    }
}
