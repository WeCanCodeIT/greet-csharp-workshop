using System;
using Xunit;

namespace Greet.Tests
{
    public class ProgramTests
    {
        // 1: Write a method Greet(name) that interpolates name in a simple greeting. 
        // For example, when name is "Bob", the method should return a string
        // "Hello, Bob.".

        [Fact]
        public void Greet_Should_Return_Greeting()
        {
            // Act
            string greeting = Program.Greet("Bob");

            // Assert
            Assert.Equal("Hello, Bob", greeting);

        }

        // 2: Handle nulls by introducing a stand-in. 
        // For example, when name is null, then the method should
        // return the string "Hello, my friend."

        [Fact]
        public void Greet_Should_Return_myfriend_for_null()
        {
            string greeting = Program.Greet("");

            Assert.Equal("Hello, my friend", greeting);
        }

        // 3: Handle shouting. When name is all uppercase, then
        // the method should shout back to the user. For example, 
        // when name is "JERRY" then the method should return the string "HELLO JERRY!"

        [Fact]
        public void Greet_Should_Return_Shout_for_All_Caps()
        {
            string greeting = Program.Greet("JERRY");

            Assert.Equal("HELLO JERRY!", greeting);

        }
    }
}
