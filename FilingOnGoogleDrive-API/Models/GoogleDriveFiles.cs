using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilingOnGoogleDrive_API.Models
{
    public class GoogleDriveFiles
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public long? Size { get; set; }
        public long? Version { get; set; }
        public DateTime? CreatedTime { get; set; }
    }
}