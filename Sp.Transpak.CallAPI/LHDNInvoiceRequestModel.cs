using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sp.Transpak.CallAPI
{
    public class LHDNInvoiceRequestModel
    {
        public List<Document> documents { get; set; }
    }
    public class Document
    {
        public string format { get; set; }
        public string documentHash { get; set; }
        public string codeNumber { get; set; }
        public string document { get; set; }
    }
}
