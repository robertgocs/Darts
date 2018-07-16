using DTO;
using System;
using Xunit;

namespace DTOTest
{
    public class ThrowTest
    {
        [Theory]
        [InlineData(20, 3)]
        [InlineData(10, 2)]
        [InlineData(2, 1)]
        [InlineData(25, 1)]
        [InlineData(25, 2)]
        [InlineData(0,1)]
        public void TestThrowBasic(int sector, int multiplayer)
        {
            var t = new DartThrow(sector, multiplayer);

            Assert.Equal(sector * multiplayer, t.GetScore());
        }

        [Theory]
        [InlineData(30)]
        [InlineData(-1)]
        public void TestThrowSectorException(int sector)
        {
            Exception ex = Assert.Throws<ArgumentOutOfRangeException>(() => new DartThrow(sector, 1));
        }

        [Theory]
        [InlineData(20,4)]
        [InlineData(25,3)]
        [InlineData(1, 0)]
        public void TestThrowMultiplayerException(int sector, int multyplayer)
        {
            Exception ex = Assert.Throws<ArgumentOutOfRangeException>(() => new DartThrow(sector, multyplayer));
        }
    }
}
