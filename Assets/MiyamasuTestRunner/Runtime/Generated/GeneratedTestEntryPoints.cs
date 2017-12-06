
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.TestTools;
using Miyamasu;
public class Tests_Miyamasu {
    [UnityTest] public IEnumerator CheckRunning() {
        var instance = new Tests();
        instance.SetInfo("Tests", "CheckRunning");
        
        yield return instance.Setup();
        var startDate = DateTime.Now;
        yield return instance.CheckRunning();
        instance.MarkAsPassed((DateTime.Now - startDate).ToString());

        
        yield return instance.Teardown();
    }
}