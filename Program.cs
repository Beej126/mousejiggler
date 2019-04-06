#region header

// MouseJiggle - Program.cs
// 
// Alistair J. R. Young
// Arkane Systems
// 
// Copyright Arkane Systems 2012-2013.
// 
// Created: 2013-08-24 12:41 PM

#endregion

using System;
using System.Threading;
using System.Windows.Forms;

namespace ArkaneSystems.MouseJiggle
{
    internal static class Program
    {
        //public static bool ZenJiggling = true;

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main (string[] args)
        {
            Mutex instance = new Mutex(false, "single instance: ArkaneSystems.MouseJiggle");

            if (instance.WaitOne(0, false))
            {
                // Check for command-line switches.
                //foreach (string arg in args)
                //{
                //    if ((System.String.Compare (arg.ToUpperInvariant (), "--ZEN", System.StringComparison.Ordinal) == 0) ||
                //        (System.String.Compare (arg.ToUpperInvariant (), "-Z", System.StringComparison.Ordinal) == 0))
                //        ZenJiggling = true;
                //}

                Application.EnableVisualStyles ();
                Application.SetCompatibleTextRenderingDefault (false);
                Application.Run (new MainForm ());
            }

            instance.Close ();
        }
    }
}
