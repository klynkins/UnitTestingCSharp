﻿using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class VideoServiceTests
    {
        [SetUp]
        public void SetUp()
        {

        }
        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
            var _fileReader = new Mock<IFileReader>();
            _fileReader.Setup(fr => fr.Read("video.txt")).Returns("");
            var _videoService = new VideoService(_fileReader.Object);
            var result = _videoService.ReadVideoTitle();
            Assert.That(result, Does.Contain("error").IgnoreCase);
        }
    }
}
