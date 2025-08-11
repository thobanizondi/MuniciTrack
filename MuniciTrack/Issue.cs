using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuniciTrack
{
    public class Issue
    {
        public int Id { get; set; }
        public string fullName { get; set; }    
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string AttachmentPath { get; set; }  // Stores file path
        public string Status { get; set; } = "Open";
    }
}