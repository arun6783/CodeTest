using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Model
{
    public class IndividualWordCounter
    {
        private List<string> _stringToFindIndividualWords;

        public Dictionary<string, int> IndividualWordsAndFrequency { get; private set; }

        public long WordCount
        {
            get { return IndividualWordsAndFrequency.Sum(item => item.Value); }
        }

        public IndividualWordCounter(List<string> stringToFindIndividualWords)
        {
            _stringToFindIndividualWords = stringToFindIndividualWords;
        }

        public void CountUniqueWords()
        {
            IndividualWordsAndFrequency = new Dictionary<string, int>();
            foreach (var stringToFindIndividualWord in _stringToFindIndividualWords)
            {


                MatchCollection matchCollection = Regex.Matches(stringToFindIndividualWord, @"[a-zA-Z0-9\'\-]+",RegexOptions.IgnoreCase);


               // string[] matchCollection = stringToFindIndividualWord.ToLowerInvariant().Replace(Environment.NewLine, " ").Split(new string[] { " ", ",", "!", ";", "#", "*", ".", ":" ,"?","\""}, StringSplitOptions.RemoveEmptyEntries);
                foreach (var word in matchCollection)
                {
                    string key = word.ToString().ToLower();
                    if (IndividualWordsAndFrequency.ContainsKey(key))
                    {
                        int i = IndividualWordsAndFrequency[key];
                        IndividualWordsAndFrequency[key] = i + 1;
                    }
                    else
                    {
                        IndividualWordsAndFrequency.Add(key, 1);
                    }
                }
            }
        }
    }
}