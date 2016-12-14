using Xunit;
using Ronnahcate.Homework;
using System.Collections.Generic;

namespace Ronnahcate.Homework.Test
{
    public class ContainerTest
    {
        [Fact]
        public void SampleDataTest()
        {
            var sampleData = new List<int> { 0, 1, 0, 2, 1, 0, 1, 3, 2, 0, 1, 0, 2};
            Assert.Equal(10, Container.GetContainerSize(sampleData));
        }
    }
}