using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.IO;

namespace MyPdfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class PdfService : IPdfService
    {
        public Stream GetPdf()
        {
            var pdfPath = "C:\\Users\\Ryan\\Documents\\Visual Studio 2013\\Projects\\MyPdfService\\MyPdfServiceApp\\helloworld.pdf";

            //PDF MIME type
            WebOperationContext.Current.OutgoingResponse.ContentType = "application/pdf";

            return File.OpenRead(pdfPath);
        }

        public string HiThere()
        {
            return "Hi there";
        }
    }
}
