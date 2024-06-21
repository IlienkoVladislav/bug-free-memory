public class DocumentFactory
{
    public Document CreateDocument(string type)
    {
        switch (type.ToLower())
        {
            case "pdf":
                return new PDFDocument();
            case "word":
                return new WordDocument();
            case "excel":
                return new ExcelDocument();
            default:
                throw new ArgumentException($"Invalid document type: {type}");
        }
    }
}
