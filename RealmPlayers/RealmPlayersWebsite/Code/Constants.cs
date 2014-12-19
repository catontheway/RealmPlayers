﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealmPlayersServer
{
    public class Constants
    {
        public static bool DebugMode = false;
        public static string RPPDbDir = VF_RealmPlayersDatabase.Utility.DefaultServerLocation + "VF_RealmPlayersData\\RPPDatabase\\";
        public static string RPPDbWriteDir = VF_RealmPlayersDatabase.Utility.DefaultServerLocation + "VF_RealmPlayersData\\RPPDatabase\\";

        private static bool m_Initialized = false;
        public static void AssertInitialize()
        {
            if (m_Initialized == false)
            {
                if (DebugMode == true)
                {
                    RPPDbWriteDir = VF_RealmPlayersDatabase.Utility.DefaultServerLocation + "VF_RealmPlayersData\\RPPDatabaseDebug\\";
                }
                if (System.IO.Directory.Exists(RPPDbDir) == false)
                {
                    RPPDbDir = RPPDbDir.Replace(VF_RealmPlayersDatabase.Utility.DefaultServerLocation, VF_RealmPlayersDatabase.Utility.DefaultDebugLocation);
                    RPPDbWriteDir = RPPDbWriteDir.Replace(VF_RealmPlayersDatabase.Utility.DefaultServerLocation, VF_RealmPlayersDatabase.Utility.DefaultDebugLocation);
                }
                m_Initialized = true;
            }
        }
    }
}