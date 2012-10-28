using System;
using System.Collections.Generic;
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
        public void  ShouldReadFromFileAndReturnArrayOFString()
        {
            string stringToReturn = "This string was returned with" + Environment.NewLine.ToString(CultureInfo.InvariantCulture) + "this is the second line ";
          
            var simpleFileReader = new SimpleFileReader(new StringReader(stringToReturn));

            var contentFromFile = simpleFileReader.ReadFromFile();

            Assert.That(contentFromFile,Is.InstanceOf<List<string>>());
            Assert.That(contentFromFile.Count,Is.GreaterThan(0));
            Assert.That(contentFromFile[0], Is.StringContaining("This string was returned with"));
        }
    }
}
