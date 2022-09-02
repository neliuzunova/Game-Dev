using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TakeHearts
    {
        // A Test behaves as an ordinary method
        [Test]
        public void TakeHeartsSimplePasses()
        {
            var hmm = new GameObject().AddComponent<HeartSystem>();
            
            Assert.AreEqual(hmm.life, 3);

        }
    }
}
