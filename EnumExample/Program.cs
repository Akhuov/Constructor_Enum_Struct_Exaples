
Console.WriteLine();

List<Document> documents = new List<Document>();

AddDocument(DocumentType.Inner);
AddDocument(DocumentType.Outgoing);
AddDocument(DocumentType.Incoming);

List<Document> innerDocuments = documents.Where(x => x.Type == DocumentType.Inner).ToList();

foreach (Document innerDocument in innerDocuments) Console.WriteLine(innerDocument.Name);

Console.ReadLine();

void AddDocument(DocumentType type)
{
    for (int i = 0; i < 100; i++)
    {
        var document = new Document()
        {
            Name = type.ToString() + " " + i.ToString(),
            Type = type,
        };
        documents.Add(document);
    }
}

internal enum DocumentType
{
    Incoming,
    Inner,
    Outgoing,
}

class Document
{
    public string Name { get; set; }

    public DocumentType Type { get; set; }
}

class Member
{
    public string Name { get; set; }
}
