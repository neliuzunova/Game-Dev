using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TakeHeart
    {
        [UnityTest]
        public IEnumerator TakeHeartWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            
            //var hmm = new GameObject().AddComponent<HeartSystem>();
            //var myObj = Substitute.For<HeartSystem>();
            
            yield return null;
            //Assert.AreEqual(hmm.life, 3);
            
        }
    }
}
