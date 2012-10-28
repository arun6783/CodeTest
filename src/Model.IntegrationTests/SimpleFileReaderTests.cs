using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using NUnit.Framework;
using Rhino.Mocks;

namespace Model.IntegrationTests
{
    public class SimpleFileReaderTests  
    {

        [Test]
        public void ShouldReadFromFileAndReturnString()
        {
            string path = @"testFile.txt";

            var simpleFileReader = new SimpleFileReader(new StreamReader(path));

            var contentFromFile = simpleFileReader.ReadFromFile();

            Assert.That(contentFromFile.Count(),Is.GreaterThan(0));
        }
    }
}
