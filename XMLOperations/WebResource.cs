using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLOperations
{
    public class WebResource
    {
        public string WebResourceId { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public int WebResourceType { get; set; }
        public string IntroducedVersion { get; set; }
        public int IsEnabledForMobileClient { get; set; }
        public int IsCustomizable { get; set; }
        public int CanBeDeleted { get; set; }
        public int IsHidden { get; set; }
        public string FileName { get; set; }
    }
}
