using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PankMtlRinksUpdater
{
    class Program
    {
        const string RINK_FILES_FOLDER = "../../PatinerMontrealFiles/";
        const string MTL_QC_CANADA_PATH = "http://www.patinermontreal.ca/";
        const string MTL_QC_CANADA_FILE = "data.json";

        static void Main(string[] args)
        {
            FileManager lMontrealData = new FileManager();

            lMontrealData.DownloadFile(MTL_QC_CANADA_PATH, MTL_QC_CANADA_FILE, RINK_FILES_FOLDER);

            

        }
    }
}
