using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Model.UnitTests
{
    public class UniqueWordCounterTest
    {
        [Test]
        public void ShouldCountIndividualWordsAndHowManyTimesTheWordsIsRepeatedFromAGivenString()
        {
            string findIndividualWordsString = "Father had been away in the country for three or four days.  All" + Environment.NewLine.ToString() + 
                                               "Peter's hopes for the curing of his afflicted Engine were now fixed" + Environment.NewLine.ToString() + 
                                               "on his Father, for Father was most wonderfully clever with his" + Environment.NewLine.ToString() + 
                                               "fingers.  He could mend all sorts of things.  He had often acted as" + Environment.NewLine.ToString() + 
                                               "veterinary surgeon to the wooden rocking-horse; once he had saved" + Environment.NewLine.ToString() + 
                                               "its life when all human aid was despaired of, and the poor creature" + Environment.NewLine.ToString() + 
                                               "was given up for lost, and even the carpenter said he didn't see his" + Environment.NewLine.ToString() + 
                                               "way to do anything.  And it was Father who mended the doll's cradle" + Environment.NewLine.ToString() + 
                                               "when no one else could; and with a little glue and some bits of wood" + Environment.NewLine.ToString() + 
                                               "and a pen-knife made all the Noah's Ark beasts as strong on their" + Environment.NewLine.ToString() + 
                                               "All right, said Father; fire away!" + Environment.NewLine.ToString() + 
                                               "pins as ever they were, if not stronger.";


            var individualWordCounter = new IndividualWordCounter(new List<string>(){findIndividualWordsString });

            individualWordCounter.CountUniqueWords();

            Assert.That(individualWordCounter.WordCount, Is.EqualTo(141));
            Assert.That(individualWordCounter.IndividualWordsAndFrequency.ContainsKey("father"), Is.EqualTo(true));
            Assert.That(individualWordCounter.IndividualWordsAndFrequency["father"], Is.EqualTo(5));
        }
    }
}