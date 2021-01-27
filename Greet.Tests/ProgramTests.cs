using System;
using Xunit;

namespace Greet.Tests
{
    public class ProgramTests
    {
        // 1: Write a method Greet(name) that interpolates name in a simple greeting. 
        // For example, when name is "Bob", the method should return a string
        // "Hello, Bob.".

        // Call the test Greet_Should_Return_Greeting()

        [Fact]

        public void Greet_Should_Return_Greeting()
        {
            // Arrange: set the stage for our test


            // Act: call the method we want to test
            string greeting = Program.Greet("Bob");


            // Assert: prove it did what we expected
            Assert.Equal("Hello Bob", greeting);

        }

        // 2: Handle nulls by introducing a stand-in. 
        // For example, when name is null, then the method should
        // return the string "Hello, my friend."

        // Call the test Greet_Should_Return_Myfriend_for_Null()

        [Fact]
        public void Greet_Should_Return_Myfriend_for_Null()
        {
            // Arrange: set the stage for our test

            // Act: call the method we want to test
            string greeting = Program.Greet("");

            // Assert: prove it did what we expected
            Assert.Equal("Hello, my friend", greeting);

        }

        // 3: Handle shouting. When name is all uppercase, then
        // the method should shout back to the user. For example, 
        // when name is "JERRY" then the method should return the string "HELLO JERRY!"

        // Call the test Greet_Should_Return_Shout_for_All_Caps()

        [Fact]
        public void Greet_Should_Return_Shout_for_All_Caps()
        {
            // Arrange: set the stage for our test



            // Act: call the method we want to test
            string greeting = Program.Greet("JERRY");


            // Assert: prove it did what we expected
            Assert.Equal("HELLO JERRY", greeting);

        }
    }
}
