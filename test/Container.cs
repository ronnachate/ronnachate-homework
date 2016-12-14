using Xunit;
using System.Collections.Generic;

namespace Ronnahcate.Homework.Test
{
    public class ContainerTest
    {
        [Fact]
        public void SampleDataTest()
        {
            var sampleData = new List<int> {0, 1, 0, 2, 1, 0, 1, 3, 2, 0, 1, 0, 2};
            Assert.Equal(10, Container.GetContainerSize(sampleData));
        }

        [Fact]
        public void OtherDataTest()
        {
            var testData = new List<int> {3,0,3};
            Assert.Equal(3, Container.GetContainerSize(testData));
            testData = new List<int> {3,0,1};
            Assert.Equal(1, Container.GetContainerSize(testData));
        }

        [Fact]
        public void EmptyListTest()
        {
            var testData = new List<int>();
            Assert.Equal(0, Container.GetContainerSize(testData));
        }
    }
}