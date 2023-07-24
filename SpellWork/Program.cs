﻿using SpellWork.Forms;
using SpellWork.Properties;
using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpellWork
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var dbcPath = $"{Settings.Default.DbcPath}\\{Settings.Default.Locale}";
            if (!Directory.Exists(dbcPath))
            {
                MessageBox.Show($"Files in {Path.GetFullPath(dbcPath)} missing", @"Missing files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var splashScreen = new SplashScreen();

                Task.Run(async () =>
                {
                    await DBC.DBC.Load();

                    if (splashScreen.InvokeRequired)
                        splashScreen.Invoke(() => splashScreen.ShowMainForm());
                    else
                        splashScreen.ShowMainForm();
                });
                Application.Run(splashScreen);
            }
            catch (DirectoryNotFoundException dnfe)
            {
                MessageBox.Show(dnfe.Message, @"Missing required DBC file!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message, @"DBC file has wrong structure!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"SpellWork Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
