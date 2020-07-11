﻿using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests.Runtime
{
    public class RuntimeSampleTestScript
    {
        // A Test behaves as an ordinary method
        [Test]
        public void RuntimeSampleTestScriptSimplePasses()
        {
            Assert.Less(1, 2);
            // Use the Assert class to test conditions
        }
        
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator RuntimeSampleTestScriptWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }

        // This test will only build and run if we correctly have assembly references set up correctly to our runtime scripts 
        [UnityTest]
        public IEnumerator RuntimeCreateSampleBehaviour()
        {
            var go = new GameObject();
            go.AddComponent<NewBehaviourScript>();
            yield return null;
        }
    }
}
