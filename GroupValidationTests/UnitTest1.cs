using NUnit.Framework;
using GroupValidation;

namespace GroupValidationTests
{
    [TestFixture]
    public class Tests
    { 
        [TestCase(null,"1")]
        [TestCase("1",null)]
        [TestOf(typeof(Group))]
        [Ignore ("because")]
        public void VerifyThatOblectIsNullWhenPropertyIsNull(string value, string value2)
        {
            Group createdGroup = Group.CreateGroup(value, value2, out string error);
            Assert.IsNull(createdGroup);
            
        }
    }
}