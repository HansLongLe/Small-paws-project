using System.Collections.Generic;
using System.Threading.Tasks;
using Client.Authentication;
using Client.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Client.Data.Certificate;

namespace Client.Pages
{
    /// <summary>
    /// C# code for viewing certificates page.
    /// </summary>
    public class CertificatesPrintRazor : ComponentBase
    {
        /// <summary>
        /// A list of certificates.
        /// </summary>
        protected IList<Certificate> Certificates { get; set; }
        
        /// <summary>
        /// Injected NavigationManager for navigating through pages.
        /// </summary>
        [Inject] private NavigationManager NavigationManager { get; set; }
        
        /// <summary>
        /// Injected certificate service for getting certificates.
        /// </summary>
        [Inject] private ICertificateService CertificateService { get; set; }
        
        /// <summary>
        /// Injected AuthenticationStateProvider for getting user's id.
        /// </summary>
        [Inject] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }


        /// <summary>
        /// Method used for getting certificates for logged in user when page is loaded.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            var user = ((CustomAuthenticationStateProvider) AuthenticationStateProvider).GetCachedUser();
            Certificates = await CertificateService.GetCertificatesByUserId(user.UserId);
        }

        // protected async Task<PdfLoadedDocument> GetDocumentFromByteArray(byte[] document)
        // {
        //     // string inputFile =  
        //     PdfLoadedDocument loadedDocument = new PdfLoadedDocument(document, true);
        //     PdfPageBase page = loadedDocument.Pages.Add();
        //     PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 20);
        //     PdfDocumentView viewer = new PdfDocumentView();
        //     viewer.Load(loadedDocument);
        //     
        //
        //
        //
        //     return loadedDocument;
        //     // Document doc = new Document();
        //     // Page page = doc.Pages.Add();
        //     // MemoryStream outstream = new MemoryStream();
        //     // MemoryStream mystream = new MemoryStream(document);
        //     //
        //     // Bitmap b = new Bitmap(mystream);
        //     // page.PageInfo.Margin.Bottom = 0;
        //     // page.PageInfo.Margin.Top = 0;
        //     // page.PageInfo.Margin.Left = 0;
        //     // page.PageInfo.Margin.Right = 0;
        //     //
        //     // page.CropBox = new Aspose.Pdf.Rectangle(0, 0, b.Width, b.Height);
        //     // Aspose.Pdf.Image image1 = new Aspose.Pdf.Image();
        //     // page.Paragraphs.Add(image1);
        //     // image1.ImageStream = mystream;
        //     //
        //     // doc.Save(outstream, SaveFormat.Pdf);
        //     // mystream.Close();
        //     // return doc;
        //
        // }


        // // loadedDocument.Save();
        // // Console.WriteLine("Saved the document");
        // // loadedDocument.Close();
        // byte[] fileByteArray = File.ReadAllBytes(Path.Combine(System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath, "MyPDF.pdf"));
        // Response.AddHeader("Content-disposition", String.Format("attachment; filename={0}.pdf", "MyTestFile"));
        // Response.ContentType = "application/octet-stream";
        // Response.BinaryWrite(fileByteArray);

//        }
    }
}