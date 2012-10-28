using System;
using System.Globalization;
using System.IO;
using NUnit.Framework;
using Rhino.Mocks;
using System.Linq;

namespace Model.UnitTests
{
    public class SimpleFileReaderTest   
    {
        [Test]
        public void  ShouldReadFromFileAndReturnString()
        {
            string stringToReturn = "This string was returned with" + Environment.NewLine.ToString(CultureInfo.InvariantCulture) + "this is the second line ";
          
            var simpleFileReader = new SimpleFileReader(new StringReader(stringToReturn));

            var contentFromFile = simpleFileReader.ReadFromFile();

            Assert.That(contentFromFile.Aggregate(string.Empty, (current, item) => current + item), Is.EqualTo(stringToReturn.Replace(Environment.NewLine,"")));
        }
    }
}
