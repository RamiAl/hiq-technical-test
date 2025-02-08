using System.Text.RegularExpressions;

namespace Backend.Services
{
    public static class TextProcessor
    {
        /// <summary>
        /// Processes text content by identifying the most frequent word and surrounding it with 'foo' and 'bar'.
        /// </summary>
        /// <param name="content">Text to process.</param>
        /// <returns>Processed text.</returns>
        public static string ProcessContent(string content)
        {
            // Split into words
            var words = Regex
                .Split(content, @"\W+")
                .Where(w => !string.IsNullOrWhiteSpace(w))
                .Select(w => w.ToLower())
                .ToList();

            // If no words, return original content
            if (!words.Any()) return content;

            // Find the most frequent word
            var mostUsedWord = words
                .GroupBy(w => w)
                .OrderByDescending(g => g.Count())
                .First().Key;

            // Replace occurrences with 'foo<word>bar'
            var pattern = $@"\b{mostUsedWord}\b";
            var replacement = $"foo{mostUsedWord}bar";

            return Regex.Replace(content, pattern, replacement, RegexOptions.IgnoreCase);
        }
    }
}
