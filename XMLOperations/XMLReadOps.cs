using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLOperations
{
    public class XMLReadOps
    {
        public string FolderPath { get; set; }
        public string[] RequiredFiles { get; set; }

        public XMLReadOps()
        {
            //TODO:P1 bring these hardcoded values to config
            RequiredFiles = new string[4];
            RequiredFiles[0] = "[Content_Types].xml";
            RequiredFiles[1] = "customizations.xml";
            RequiredFiles[2] = "filteredcomponents.xml";
            RequiredFiles[3] = "solution.xml";
            //END TODO
        }

        public bool ValidateRequiredFiles()
        {
            try
            {
                string path = FolderPath;
                string[] getAllFilesName = Directory.GetFiles(path);
                
                //TODO:P2 LINQ should be used here instead of foreach loop
                foreach (var fileName in RequiredFiles)
                {
                    if (!RequiredFiles.Contains(fileName))
                    {
                        return false;
                    }
                }
                //END TODO
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public XmlNode GetWebResourcesNodes(string fileName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(FolderPath + "\\" + fileName);
            XmlNode webResourcesNode = doc.ChildNodes[0].SelectSingleNode("WebResources");
            if (webResourcesNode != null)
                return webResourcesNode;
            return null;
        }
    }
}
