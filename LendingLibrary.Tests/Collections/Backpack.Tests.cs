using LendingLibrary.Collections;
using System;
using Xunit;

namespace LendingLibrary.Tests.Collections
{
    public class BackpackTests
    {
        [Fact]
        public void Backpack_starts_empty()
        {
            //Arrange /Act
            Backpack<string> bag = new Backpack<string>();

            //Assert

            Assert.Empty(bag);
        }
        
        [Fact]
        public void Backpack_can_pack_something()
        {
            //Arrange
            Backpack<string> bag = new Backpack<string>();

            string item1 = "Water Bottle";
            string item2 = "Lipgloss";

            //Act
            bag.Pack(item1);

            //Assert
            Assert.Equal(new[] { item1 }, bag);

            //Act
            bag.Pack(item2);

            //Assert
            Assert.Equal(new[] { item1, item2 }, bag);
        }
    }
}
