using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuseumArchivalAppServer.Areas.StoredModel
{
    public class StoredItems
    {
        string ArchivalItemID = "";
        string ProvidenceID = "";

        public void setArchivalItemID(string archivalItemID)
        {
            ArchivalItemID = archivalItemID;
        }

        public string getArchivalItemID()
        {
            return ArchivalItemID;
        }

        public void setProvidenceID(string providenceID)
        {
            ProvidenceID = providenceID;
        }

        public string getProvidenceID()
        {
            return ProvidenceID;
        }
    }
}
