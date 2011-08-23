using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Shouldly;

namespace ShouldlyTypeOfBugExample
{
    [TestFixture]
    public class ShouldlyTypeOfTests
    {
        [Test]
        public void ShouldlyMessage_CanGenerateForOfTypeAssertion()
        {
            Should.Throw<Exception>(() => 2.ShouldBeTypeOf<double>())
                .Message.ShouldBe("() => 2 should be type of System.Double but was System.Int32");
        }
    }
}
