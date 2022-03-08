using text.analyzer.data;

namespace text.analyzer.services
{
    public class WordRepository : IWordRepository
    {
        public WordAnalysis Analyse(string text)
        {
            var splitText = text.Split(' ');
            var splitTextUnique = splitText.Distinct().ToArray();

            return new WordAnalysis
            {
                NumberOfWords = splitText.Length,
                Words = splitText,
                NumberOfUniqueWords = splitTextUnique.Length,
                UniqueWords = splitTextUnique,
            };
        }
    }
}