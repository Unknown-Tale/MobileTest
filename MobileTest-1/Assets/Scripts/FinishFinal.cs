using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishFinal : MonoBehaviour
{
    public GameObject FinishText;
	
	void OnTriggerEnter()
    {
        StartCoroutine(CompleteLevel());
    }
	
	IEnumerator CompleteLevel()
	{
		FinishText.GetComponent<Text>().text = "Great Job! Now let's do it again!";
		yield return new WaitForSeconds(10);
		SceneManager.LoadScene(0);
	}
}
