using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitialiseConnections(bool database, bool textFiles)
        {
            if (database)
            {
                // TODO - Set up SQL connector properly

                SQLConnector sql = new SQLConnector();
                Connections.Add(sql);
            }

            if (textFiles)
            {
                // TODO - Create Text Connection

                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
    }
}