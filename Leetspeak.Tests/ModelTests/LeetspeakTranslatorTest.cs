using Microsoft.VisualStudio.TestTools.UnitTesting;
using Changer;

namespace Program.Tests
{
    [TestClass]
    public class LeetspeakTest
    {
        [TestMethod]
        public void Translate_EToThree_3()
        {
            LeetspeakTranslator test3 = new LeetspeakTranslator();
            Assert.AreEqual("3", test3.Translate("e"));
        }
        [TestMethod]
        public void Translate_OToZero_0()
        {
            LeetspeakTranslator test0 = new LeetspeakTranslator();
            Assert.AreEqual("0", test0.Translate("o"));
        }
        [TestMethod]
        public void Translate_IToOne_1()
        {
            LeetspeakTranslator test1 = new LeetspeakTranslator();
            Assert.AreEqual("1", test1.Translate("I"));
        }
        [TestMethod]
        public void Translate_TToSeven_7()
        {
            LeetspeakTranslator test7 = new LeetspeakTranslator();
            Assert.AreEqual("7", test7.Translate("t"));
        }
        [TestMethod]
        public void Translate_Phrase_LeetPhrase()
        {
            LeetspeakTranslator testPhrase = new LeetspeakTranslator();
            Assert.AreEqual("D0n'7 y0u l0v3 7h3z3 'S7ring' 3x3rciz3z? 1 d0!", testPhrase.Translate("Don't you love these 'String' exercises? I do!"));
        }
    }
}