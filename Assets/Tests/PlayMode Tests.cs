using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class PlayModeTests
    {

        [UnityTest]
        public IEnumerator Character_Available()
        {
            //test if there is a character(The red cube) spawned when the level is loaded
            Application.LoadLevel("Game");
            yield return new WaitForSeconds(1.0f);
            var spawnedCharacter = GameObject.FindWithTag("Player");           
            Assert.IsNotNull(spawnedCharacter);
           
        }
    }
}
