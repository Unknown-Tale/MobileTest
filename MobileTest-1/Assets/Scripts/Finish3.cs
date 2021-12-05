using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Finish3 : MonoBehaviour
{
    public GameObject FinishText;
	
	void OnTriggerEnter()
    {
        StartCoroutine(CompleteLevel());
    }
	
	IEnumerator CompleteLevel()
	{
		FinishText.GetComponent<Text>().text = "Level Complete!";
		yield return new WaitForSeconds(10);
		SceneManager.LoadScene(0);
	}
}
