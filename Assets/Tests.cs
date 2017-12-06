using System.Collections;
using System.Collections.Generic;
using Miyamasu;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tests : MiyamasuTestRunner {

	[MSetup] public IEnumerator Setup () {
		var loadAdditionalScene = SceneManager.LoadSceneAsync("TestTargetScene", LoadSceneMode.Additive);
		while (!loadAdditionalScene.isDone) {
			yield return null;
		}
	}
	[MTeardown] public IEnumerator Teardown () {
		var unloadAdditionalScene = SceneManager.UnloadSceneAsync("TestTargetScene");
		while (!unloadAdditionalScene.isDone) {
			yield return null;
		}
	}

	[MTest] public IEnumerator CheckRunning () {
		var instance = GameObject.FindObjectOfType<TestTargetScript>();

		NotNull(instance);
		IsTrue(instance.Running);

		yield return SendScreenshotToSlack("TestTatgetScene");
	}
}
