using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SpellWork.Extensions;
using SpellWork.Properties;

namespace SpellWork.Database
{
    public static class MySqlConnection
    {
        private static MySql.Data.MySqlClient.MySqlConnection _conn;
        private static MySqlCommand _command;

        public static bool Connected { get; private set; }
        public static List<string> Dropped = new List<string>();
        public static List<SpellProcEventEntry> SpellProcEvent = new List<SpellProcEventEntry>();

        private static string ConnectionString
        {
            get
            {
                if (Settings.Default.Host == ".")
                    return
                        $"Server=localhost;Pipe={Settings.Default.PortOrPipe};UserID={Settings.Default.User};Password={Settings.Default.Pass};Database={Settings.Default.WorldDbName};CharacterSet=utf8;ConnectionTimeout=5;ConnectionProtocol=Pipe;";

                return
                    $"Server={Settings.Default.Host};Port={Settings.Default.PortOrPipe};UserID={Settings.Default.User};Password={Settings.Default.Pass};Database={Settings.Default.WorldDbName};CharacterSet=utf8;ConnectionTimeout=5;";
            }
        }

        private static string GetSpellName(uint id)
        {
            if (DBC.DBC.SpellInfoStore.ContainsKey((int)id))
                return DBC.DBC.SpellInfoStore[(int)id].Name;

            Dropped.Add($"DELETE FROM `spell_proc_event` WHERE `entry` IN ({id.ToUInt32()});\r\n");
            return string.Empty;
        }

        public static ArrayList GetScriptNames(uint id)
        {
            ArrayList scripts = new ArrayList();
            string query = $"SELECT * FROM `spell_script_names` where `spell_id` = {id};";
            using (_conn = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
            {
                _command = new MySqlCommand(query, _conn);
                _conn.Open();

                using (var reader = _command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var scriptName = reader.GetString(1);
                        scripts.Add(scriptName);
                    }
                }
            }
            return scripts;
        }

        public static void SelectProc(string query)
        {
            using (_conn = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
            {
                _command = new MySqlCommand(query, _conn);
                _conn.Open();
                SpellProcEvent.Clear();

                using (var reader = _command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var spellId = reader.GetUInt32(0);
                        SpellProcEvent.Add(new SpellProcEventEntry
                        {
                            Id                  = spellId,
                            SpellName           = GetSpellName(spellId),
                            SchoolMask          = reader.GetByte(1),
                            SpellFamilyName     = reader.GetUInt16(2),
                            SpellFamilyMask     = new[]
                            {
                                reader.GetUInt32(3),
                                reader.GetUInt32(4),
                                reader.GetUInt32(5)
                            },
                            ProcFlags           = reader.GetUInt32(6),
                            ProcEx              = reader.GetUInt32(7),
                            PpmRate             = reader.GetFloat(8),
                            CustomChance        = reader.GetFloat(9),
                            Cooldown            = reader.GetUInt32(10)
                        });
                    }
                }
            }
        }

        public static void Insert(string query)
        {
            _conn    = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString);
            _command = new MySqlCommand(query, _conn);
            _conn.Open();
            _command.ExecuteNonQuery();
            _command.Connection.Close();
        }

        /*
        public static void AddDBItems()
        {
            // In order to reduce the search time, we make the first selection of all items that have spellid
            var query = @"SELECT    t.entry,
                            t.name,
                            t.description,
                            t.spellid_1,
                            t.spellid_2,
                            t.spellid_3,
                            t.spellid_4,
                            t.spellid_5
                FROM
                    `item_template` t
                WHERE
                    t.spellid_1 <> 0 ||
                    t.spellid_2 <> 0 ||
                    t.spellid_3 <> 0 ||
                    t.spellid_4 <> 0 ||
                    t.spellid_5 <> 0;";

            using (_conn = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
            {
                _command = new MySqlCommand(query, _conn);
                _conn.Open();

                using (var reader = _command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DBC.DBC.ItemTemplate.Add(new Item
                        {
                            Entry               = reader.GetUInt32(0),
                            Name                = reader.GetString(1),
                            Description         = reader.GetString(2),
                            SpellId             = new[]
                            {
                                reader.GetInt32(3),
                                reader.GetInt32(4),
                                reader.GetInt32(5),
                                reader.GetInt32(6),
                                reader.GetInt32(7)
                            }
                        });
                    }
                }
             }
        }
        */

        public static void TestConnect()
        {
            if (!Settings.Default.UseDbConnect)
            {
                Connected = false;
                return;
            }

            try
            {
                _conn = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString);
                _conn.Open();
                _conn.Close();
                Connected = true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Errno {ex.Number}{Environment.NewLine}{ex.Message}");
                Connected = false;
            }
            catch
            {
                Connected = false;
            }
        }
    }
}
