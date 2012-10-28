using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Model
{

    public class SimpleFileReader
    {
        private readonly TextReader _textReader;

        public SimpleFileReader(TextReader textReader)
        {
            _textReader = textReader;
        }

        public List<string> ReadFromFile()
        {
            var lines = new List<string>();
            using (var streamReader = _textReader)
            {
                string line = string.Empty;
                while ((line=streamReader.ReadLine())!=null)
                {
                    lines.Add(line);
                }
            }
            return lines;

        }
    }
}
