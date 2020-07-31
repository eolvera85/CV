using System;
using System.Collections.Generic;
using System.Text;

namespace CV.Models
{
    public class Document
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public byte[] Contents { get; set; }

        public string ContentType { get; set; }
    }
}
