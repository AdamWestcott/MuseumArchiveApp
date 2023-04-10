using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuseumArchivalAppServer.Areas.StoredModel
{
    public class StoredItems
    {
        string ArchivalItemID = "";

        public void setArchivalItemID(string archivalItemID)
        {
            ArchivalItemID = archivalItemID;
        }

        public string getArchivalItemID()
        {
            return ArchivalItemID;
        }
    }
}
