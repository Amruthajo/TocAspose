using Aspose.Words;

namespace AsposeWordToc.Services
{
    public class CreateDocService
    {
        public CreateDocService()
        {
        }

        public void CreateDocument()
        {
            // The path to the documents directory.
            string dataDir = AppDomain.CurrentDomain.BaseDirectory;
            // Initialize document.
            Aspose.Words.Document doc = new Aspose.Words.Document();
            DocumentBuilder builder = new DocumentBuilder(doc);


            builder.Writeln("TABLE OF CONTENTS");

            // Insert a table of contents at the beginning of the document.
            builder.InsertTableOfContents("\\o \"1-4\" \\h \\z \\u");

            // Start the actual document content on the second page.
            builder.InsertBreak(BreakType.PageBreak);

            // Build a document with complex structure by applying different heading styles thus creating TOC entries.
            builder.ParagraphFormat.StyleIdentifier = StyleIdentifier.Heading1;
            builder.Writeln("LOREM IPSUM DOLOR SIT AMET");
            for (int i = 0; i < 100; i++)
            {
                // Inserting data which is a HTML 
                builder.InsertHtml("<p>LOREM IPSUM DOLOR SIT AMET</p>");
                builder.InsertBreak(BreakType.PageBreak);
            }

            doc.UpdateFields();
            doc.UpdatePageLayout();
            dataDir = dataDir + "DocumentBuilderInsertTO.pdf";
            doc.Save(dataDir);
        }
    }
}
