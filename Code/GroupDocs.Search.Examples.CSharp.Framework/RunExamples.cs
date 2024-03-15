using GroupDocs.Search.Examples.CSharp.BasicUsage;
using System;

namespace GroupDocs.Search.Examples.CSharp
{
	class RunExamples
    {
        static void Main(string[] args)
        {
			//Console.WriteLine("Open RunExamples.cs. \nIn the Main() method, uncomment the example that you want to run.");
			//Console.WriteLine("=====================================================");

			//NOTE: Please uncomment the example you want to try out

			string seachWord = "ASP.NET";
            string searchPath = @"C:\Users\khada\OneDrive\Desktop\kajal\Work\Resume\";
            /*search2words  = "Cognizant AND 2020 ~~ 2024";
			 searchPhrase = "\"ipsum dolor sit amet\"";
            dateRange = "daterange(2000-01-01 ~~ 2001-06-15)";
            yearRange = "2020 ~~ 2024";
            wilfCardSearch = "?NET";
			 * */
            //string search2words = "Cognizant AND 2020 ~~ 2024";
            //         string wilfCardSearch = string.Empty;// "?NET";//?NET --not working
            //         string searchPhrase = string.Empty;//  "\"ipsum dolor sit amet\""; 
            //         string yearRange = "2020 ~~ 2024";
            //         string dateRange = string.Empty;// "daterange(2000-01-01 ~~ 2001-06-15)";
            #region Getting Started ----------------------------------------------------------------------------------------------------

            //HelloWorld.Run(seachWord);

            #endregion Getting Started ----------------------------------------------------------------------------------------------------

            #region Basic Usage ----------------------------------------------------------------------------------------------------

            //BuildYourFirstSearchSolution.RunSynchronousIndexing(seachWord);
            //BuildYourFirstSearchSolution.RunAsynchronousIndexing();

            //BuildSearchQuery.Run(seachWord);//, yearRange, dateRange, searchPhrase, search2words, wilfCardSearch);

            //WorkWithSearchResults.ObtainSearchResultInformation(seachWord, searchPath);
            //WorkWithSearchResults.HighlightSearchResults(seachWord);

            //GetSupportedFileFormats.Run();

            #endregion Basic Usage ----------------------------------------------------------------------------------------------------

            #region Advanced Usage ----------------------------------------------------------------------------------------------------

            // Creating an Index ----------------------------------------------------------------------------------------------------

            //UsingEvents.OperationFinishedEvent();
            //UsingEvents.ErrorOccurredEvent();
            //UsingEvents.OperationProgressChangedEvent();
            //UsingEvents.OptimizationProgressChangedEvent();
            //UsingEvents.PasswordRequiredEvent();
            //UsingEvents.FileIndexingEvent();
            //UsingEvents.StatusChangedEvent();
            //UsingEvents.SearchPhaseCompletedEvent();

            //UsingIndexRepository.Run();

            // Indexing ----------------------------------------------------------------------------------------------------

            //CharacterReplacementDuringIndexing.Run();

            //CharacterTypes.RegularCharacters();
            //CharacterTypes.BlendedCharacters();

            //CustomTextExtractors.Run();

            //DeleteIndexedDocuments.Run();

            //DeleteIndexedPaths.Run();

            //DocumentAttributes.ChangeAttributes();
            //DocumentAttributes.AddAttributesDuringIndexing();

            //DocumentFilteringDuringIndexing.SettingAFilter();
            //DocumentFilteringDuringIndexing.CreationTimeFilters();
            //DocumentFilteringDuringIndexing.ModificationTimeFilters();
            //DocumentFilteringDuringIndexing.FilePathFilters();
            //DocumentFilteringDuringIndexing.FileLengthFilters();
            //DocumentFilteringDuringIndexing.FileExtensionFilter();
            //DocumentFilteringDuringIndexing.LogicalNotFilter();
            //DocumentFilteringDuringIndexing.LogicalAndFilter();
            //DocumentFilteringDuringIndexing.LogicalOrFilter();

            //DocumentRenaming.Run();

            //IndexingAdditionalFields.Run();

            //IndexingFromDifferentSources.IndexingFromFile();
            //IndexingFromDifferentSources.IndexingFromStream();
            //IndexingFromDifferentSources.IndexingFromStructure();
            //IndexingFromDifferentSources.IndexingFromUrl();
            //IndexingFromDifferentSources.IndexingFromFtp();
            //IndexingFromDifferentSources.IndexingFromAmazon();
            //IndexingFromDifferentSources.IndexingFromAzure();

            //IndexingMetadataOfDocuments.Run();

            //IndexingOptionsProperties.CancellationProperty();
            //IndexingOptionsProperties.IsAsyncProperty();
            //IndexingOptionsProperties.ThreadsProperty();
            //IndexingOptionsProperties.MetadataIndexingOptionsProperty();

            //IndexingPasswordProtectedDocuments.IndexingUsingThePasswordDictionary();
            //IndexingPasswordProtectedDocuments.IndexingUsingThePasswordRequiredEvent();

            //IndexingReports.Run();

            //IndexingWithStopWords.Run();

            //Logging.UseOfStandardFileLogger();
            //Logging.ImplementingCustomLogger();

            //MergeIndexes.Run();

            //OcrSupport.UseAsposeOcrConnector();
            //OcrSupport.UseTesseractOcrConnector();

            //OptimizeIndex.Run();

            //SeparateDataExtraction.Run();

            //StoringTextOfIndexedDocuments.Run();

            //TextFileEncodingDetection.Run();

            //UpdateIndex.UpdateIndexedDocuments();
            //UpdateIndex.UpdateIndexVersion();

            // Searching ----------------------------------------------------------------------------------------------------

            //BooleanSearch.OperatorAnd();
            //BooleanSearch.OperatorOr();
            //BooleanSearch.OperatorNot();
            //BooleanSearch.ComplexQueries();

            //CaseSensitiveSearch.QueryInTextForm();
            //CaseSensitiveSearch.QueryInObjectForm();

            //DateRangeSearch.CreatingDateRangeSearchQueries();
            //DateRangeSearch.SpecifyingDateRangeSearchFormats();

            //DocumentFilteringInSearchResult.SettingAFilter();
            //DocumentFilteringInSearchResult.FilePathFilters();
            //DocumentFilteringInSearchResult.FileExtensionFilter();
            //DocumentFilteringInSearchResult.AttributeFilter();
            //DocumentFilteringInSearchResult.CombiningFilters();

            //FacetedSearch.SimpleFacetedSearch();
            //FacetedSearch.ComplexQuery();
            //FacetedSearch.UsingStandardFieldNames();

            //FuzzySearch.SettingFuzzySearchAlgorithm();
            //FuzzySearch.SettingStepFunction();

            //GettingIndexedDocuments.GettingDocuments();
            //GettingIndexedDocuments.GettingTextOfIndexedDocuments();

            //HighlightingSearchResults.HighlightingInEntireDocument();
            //HighlightingSearchResults.HighlightingInFragments();

            //HomophoneSearch.Run();

            //KeyboardLayoutCorrection.Run();

            //NumericRangeSearch.Run();

            //OutputAdapters.Run();

            //PhraseSearch.SimplePhraseSearch();
            //PhraseSearch.PhraseSearchWithWildcards();
            //PhraseSearch.PhraseSearchWithWildcards2();

            //QueriesInTextAndObjectForm.Run();

            //RegularExpressionSearch.Run();

            //ReverseImageSearch.Run();

            //SearchByChunks.Run();

            //SearchForDifferentWordForms.Run();

            //SearchReports.Run();

            //SearchResults.Run();

            //SpellChecking.Run();

            //SynonymSearch.Run();

            //UsingAliases.Run();

            //WildcardSearch.QueryInTextForm();

            // Managing Dictionaries ----------------------------------------------------------------------------------------------------

            //AliasDictionary.Run();

            //Alphabet.Run();

            //CharacterReplacements.Run();

            //DocumentPasswords.Run();

            //HomophoneDictionary.Run();

            //SpellingCorrector.Run();

            //StopWordDictionary.Run();

            //SynonymDictionary.Run();

            //WordFormsProvider.Run();

            // Scaling ----------------------------------------------------------------------------------------------------

            //ConfiguringSearchNetwork.Run();

            //SearchNetworkDeployment.Run();

            //SearchNetworkNodeEvents.Run();

            //IndexingDocuments.Run();

            //DeletingDocuments.Run();

            //OptimizingShards.Run();

            //SynchronizingShards.Run();

            //WorkingWithAttributes.Run();

            //TextSearchInNetwork.Run();

            //ImageSearchInNetwork.Run();

            //HighlightingResultsInNetwork.Run();

            //GettingDocumentsInNetwork.Run();

            //GettingDocumentTextInNetwork.Run();

            //ManagingDictionariesInNetwork.Run();

            #endregion Advanced Usage ----------------------------------------------------------------------------------------------------

            #region Highlight Search Results in HTML ----------------------------------------------------------------------------------------------------

            //HighlightExample.Run();

            #endregion Highlight Search Results in HTML ----------------------------------------------------------------------------------------------------

            //Console.WriteLine();
            //Console.WriteLine("All done.");
            Console.ReadKey();
        }
    }
}
