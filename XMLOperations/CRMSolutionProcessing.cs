using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLOperations
{
    public class CRMSolutionProcessing
    {
        public CRMSolutionProcessing() { }
        public void processCRMSolutionFiles(string filePath)
        {
            string solutionFolderPath = Path.GetDirectoryName(filePath);

            string[] RootDirectories = Directory.GetDirectories(solutionFolderPath);
            XMLReadOps xmlOps = new XMLReadOps();
            xmlOps.FolderPath = solutionFolderPath;
            XmlNode webResourcesNode = null;
            if (xmlOps.ValidateRequiredFiles())
            {
                webResourcesNode = xmlOps.GetWebResourcesNodes(Path.GetFileName(xmlOps.RequiredFiles[1]));
            }
            if (webResourcesNode != null)
            {
                XmlNodeList webResourceNodesList = webResourcesNode.SelectNodes("WebResource");
                WebResource wrObj = new WebResource();
                foreach (XmlNode webResourceNode in webResourceNodesList)
                {
                    //wrObj.WebResourceId = webResourceNode.ChildNodes[0].InnerXml;
                    wrObj.Name = webResourceNode.ChildNodes[1].InnerXml;
                    //wrObj.DisplayName = webResourceNode.ChildNodes[2].InnerXml;
                    //wrObj.WebResourceType = Convert.ToInt16(webResourceNode.ChildNodes[3].InnerXml);
                    //wrObj.IntroducedVersion = webResourceNode.ChildNodes[4].InnerXml;
                    //wrObj.IsEnabledForMobileClient = Convert.ToInt16(webResourceNode.ChildNodes[5].InnerXml);
                    //wrObj.IsCustomizable = Convert.ToInt16(webResourceNode.ChildNodes[6].InnerXml);
                    //wrObj.CanBeDeleted = Convert.ToInt16(webResourceNode.ChildNodes[7].InnerXml);
                    //wrObj.IsHidden = Convert.ToInt16(webResourceNode.ChildNodes[8].InnerXml);
                    wrObj.FileName = webResourceNode.ChildNodes[9].InnerXml;


                    string currentFileName = RootDirectories[1] + "\\" + wrObj.FileName.Split('/')[2];
                    string updateFileName = RootDirectories[1] + "\\" + wrObj.Name.Replace("/", @"\");
                    System.IO.FileInfo file = new System.IO.FileInfo(updateFileName);
                    file.Directory.Create();
                    System.IO.File.Move(currentFileName, updateFileName);
                }
            }
        }
    }
}
