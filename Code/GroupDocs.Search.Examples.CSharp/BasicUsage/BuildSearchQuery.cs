using GroupDocs.Search.Common;
using GroupDocs.Search.Events;
using GroupDocs.Search.Examples.CSharp.AdvancedUsage.Searching;
using GroupDocs.Search.Highlighters;
using GroupDocs.Search.Options;
using GroupDocs.Search.Results;
using System;

namespace GroupDocs.Search.Examples.CSharp.BasicUsage
{
    class BuildSearchQuery
    {
        public static void Run(string seacrhWord)//, string yearRange,string dateRange, string searchPhrase, string search2words, string wilfCardSearch)
        {
            string indexFolder = @"./BasicUsage/BuildSearchQuery";
            string documentsFolder = Utils.DocumentsPath;

            Utils.PrintHeaderFromPath(indexFolder);

            // Creating index in the specified folder
            Index index = new Index(indexFolder);

            // Subscribe to the event
            index.Events.ErrorOccurred += (sender, args) =>
            {
                Console.WriteLine(args.Message); // Writing error messages to the console
            };

            // Indexing documents from the specified folder
            index.Add(documentsFolder);

			// Simple search query
			//{
			//    string query = seacrhWord;
			//    SearchResult result = index.Search(query);
			//    Console.WriteLine("Query: " + query);
			//    Console.WriteLine("Documents: " + result.DocumentCount);
			//    Console.WriteLine("Occurrences: " + result.OccurrenceCount);
			//    Console.WriteLine();
			//}
            /*
            if(!string.IsNullOrWhiteSpace(wilfCardSearch)) 
			// Wildcard search query
            {
                string query = wilfCardSearch;

				SearchResult result = index.Search(query); // Search for words 'affect', 'effect', ets.
                Console.WriteLine("Query: " + query);
                Console.WriteLine("Documents: " + result.DocumentCount);
                Console.WriteLine("Occurrences: " + result.OccurrenceCount);
                Console.WriteLine();
            }
            */
            // Faceted search query
            {
                string query = "Content: "+ seacrhWord;
				Console.WriteLine("Content: " + seacrhWord);
				SearchResult result = index.Search(query); // Search for word 'magna' only in 'Content' field
				PrintResult(result);
				
                
                //Console.WriteLine("Documents: " + result.DocumentCount);
                //Console.WriteLine("Occurrences: " + result.OccurrenceCount);
                //Console.WriteLine();
            }
            /*
            if(!string.IsNullOrEmpty(yearRange))
            // Numeric range search query
            {
                //string query = "2000 ~~ 3000";
                SearchResult result = index.Search(yearRange); // Search for numbers from 2000 to 3000
                Console.WriteLine("Query: " + yearRange);
                PrintResult(result);
				//Console.WriteLine("Documents: " + result.DocumentCount);
				//Console.WriteLine("Occurrences: " + result.OccurrenceCount);
				//Console.WriteLine();
			}

            if(!string.IsNullOrEmpty(dateRange))
            // Date range search query
            {
                SearchOptions options = new SearchOptions(); // Creating a search options object
                options.DateFormats.Clear(); // Removing default date formats

                // Creating a date format pattern 'MM/dd/yyyy'
                DateFormatElement[] elements = new DateFormatElement[]
                {
                    DateFormatElement.MonthTwoDigits,
                    DateFormatElement.DateSeparator,
                    DateFormatElement.DayOfMonthTwoDigits,
                    DateFormatElement.DateSeparator,
                    DateFormatElement.YearFourDigits,
                };
                DateFormat dateFormat = new DateFormat(elements, "/");
                options.DateFormats.Add(dateFormat); // Adding the date format pattern to the date format collection

                string query = dateRange; // Dates in the search query are always specified in the format 'yyyy-MM-dd'
                SearchResult result = index.Search(query, options); // Search in index
                Console.WriteLine("Query: " + query);
				PrintResult(result);
				//Console.WriteLine("Documents: " + result.DocumentCount);
				//Console.WriteLine("Occurrences: " + result.OccurrenceCount);
				//Console.WriteLine();
			}
            /*
            // Regular expression search query
            {
                string query = "^(.)\\1{2,}"; // The caret character at the beginning indicates that this is a regular expression search query
                SearchResult result = index.Search(query); // Search for three or more identical characters in a row
                Console.WriteLine("Query: " + query);
                Console.WriteLine("Documents: " + result.DocumentCount);
                Console.WriteLine("Occurrences: " + result.OccurrenceCount);
                Console.WriteLine();
            }
            */
            /*
            // Boolean search query
            {
                string query = "justo AND NOT 3456";
                SearchResult result = index.Search(query);
                Console.WriteLine("Query: " + query);
                Console.WriteLine("Documents: " + result.DocumentCount);
                Console.WriteLine("Occurrences: " + result.OccurrenceCount);
                Console.WriteLine();
            }
            
            if(!string.IsNullOrEmpty(search2words))
            // Boolean search query 2
            {
                //string query = "FileName: Engl?(1~3) OR Content: (3456 AND consequat)";
                // Search for documents whose paths contain 'English', 'England', ets., or documents containing both '3456' and 'consequat' in the content
                SearchResult result = index.Search(search2words);
                Console.WriteLine("Query: " + search2words);
				PrintResult(result);
				//Console.WriteLine("Documents: " + result.DocumentCount);
				//Console.WriteLine("Occurrences: " + result.OccurrenceCount);
				//Console.WriteLine();
			}
            if(!string.IsNullOrEmpty(searchPhrase))
			// Phrase search query
			{
                string query = searchPhrase;

				SearchResult result = index.Search(query); // Search for the phrase 'ipsum dolor sit amet'
                Console.WriteLine("Query: " + query);
				PrintResult(result);
				//Console.WriteLine("Documents: " + result.DocumentCount);
				//Console.WriteLine("Occurrences: " + result.OccurrenceCount);
				//Console.WriteLine();
			}
            */
        }

        public static void PrintResult(SearchResult result)
        {
			Console.WriteLine("Documents found: " + result.DocumentCount);
			Console.WriteLine("Total occurrences found: " + result.OccurrenceCount);
			for (int i = 0; i < result.DocumentCount; i++)
			{
				FoundDocument document = result.GetFoundDocument(i);
				Console.WriteLine("\tDocument: " + document.DocumentInfo.FilePath);
				Console.WriteLine("\tOccurrences: " + document.OccurrenceCount);
			}

			// Highlight occurrences in text
			if (result.DocumentCount > 0)
			{
				FoundDocument document = result.GetFoundDocument(0); // Getting the first found document
				string path = @"./BasicUsage/Highlighted.html";
				OutputAdapter outputAdapter = new FileOutputAdapter(OutputFormat.Html, path); // Creating the output adapter to a file
				DocumentHighlighter highlighter = new DocumentHighlighter(outputAdapter); // Creating the highlighter object
				//index.Highlight(document, highlighter); // Generating output HTML formatted document with highlighted search results

				Console.WriteLine();
				//Console.WriteLine("Generated HTML file can be opened with Internet browser.");
				//Console.WriteLine("The file can be found by the following path:");
				//Console.WriteLine(Path.GetFullPath(path));
			}
		}
    }
}
