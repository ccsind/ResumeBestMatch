using GroupDocs.Search.Results;
using System;

namespace GroupDocs.Search.Examples.CSharp.GettingStarted
{
    class HelloWorld
    {
        public static void Run(string searchWord)
        {
            string indexFolder = @"./GettingStarted/HelloWorld";
            string documentsFolder = Utils.DocumentsPath;
            string query = searchWord;

            Utils.PrintHeaderFromPath(indexFolder);

            // Creating index in the specified folder
            Index index = new Index(indexFolder);

            // Indexing documents from the specified folder
            index.Add(documentsFolder);

            // Searching in index
            SearchResult result = index.Search(query);

            Utils.TraceResult(query, result);
        }
    }
}
