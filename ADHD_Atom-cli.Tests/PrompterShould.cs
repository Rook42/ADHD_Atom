using Xunit;
using System;
using Moq;
using ADHD_Atom_cli;
using System.IO;

namespace ADHD_Atom_cli.Tests
{
    public class PrompterShould
    {
        [Fact]
        public void Return_User_Input()
        {
            // TODO: Refactor so it's not assumed that Prompter uses Console, StringWriter/Reader
            var stringWriter = new StringWriter();
            var stringReader = new StringReader("test");
            Console.SetIn(stringReader);
            var result = Prompter.Prompt("test");

            Assert.Equal("test", result);
        }

    }
}