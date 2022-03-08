using text.analyzer.data;

namespace text.analyzer.services
{
    public interface IWordRepository
    {
        WordAnalysis Analyse(string text);
    }
}