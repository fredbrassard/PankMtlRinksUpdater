using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PankMtlRinksUpdater
{
    class FileManager
    {
        private string aNewFile = string.Empty;
        private string aPreviousFile = string.Empty;

        public FileManager()
        {

        }

        public void DownloadFile(string iPath, string iFileName, string iDestinationPath)
        {
            string myStringWebResource = null;

            // Create a new WebClient instance.
            using (System.Net.WebClient myWebClient = new System.Net.WebClient())
            {
                myStringWebResource = iPath + iFileName;
                // Download the Web resource and save it into the current filesystem folder.
               
                myWebClient.DownloadFile(myStringWebResource, iDestinationPath + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + iFileName);
            }
        }

        public static bool AreFilesIdentical(string path1, string path2)
        {
            using (BinaryReader lLatest = new BinaryReader(File.Open(path1, FileMode.Open)))
            {
                using (BinaryReader lPrevious = new BinaryReader(File.Open(path2, FileMode.Open)))
                {
                    
                    if (lLatest.BaseStream.Length == lPrevious.BaseStream.Length)
                    {
                        while (lLatest.BaseStream.Position < lLatest.BaseStream.Length)
                        {
                            if (lLatest.ReadByte() != lPrevious.ReadByte())
                            {
                                return false;
                            }
                        }
                        return true;
                    }
                    return false;
                }
            }
        }
    }
}
