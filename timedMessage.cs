using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class timedMessage : MonoBehaviour
{
    [Header("Dynamic")]
    public int score = 0;

    private Text  uiText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        uiText = GetComponent<Text>();
        StartCoroutine(Continue());
    }

    // Update is called once per frame
    private IEnumerator Continue()
    {
        
        //Sets up rounds around lives. Every round, you get one less life. Game ends after round 4

        uiText.text = "Round 1";
        yield return new WaitForSeconds(30);
        //test
        ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
        apScript.AppleMissed();

        uiText.text = "Round 2";
        yield return new WaitForSeconds(30);
        apScript.AppleMissed();

        uiText.text = "Round 3";
        yield return new WaitForSeconds(30);
        apScript.AppleMissed();

        uiText.text = "Round 4";
        yield return new WaitForSeconds(30);
        apScript.AppleMissed(); //Will end game no matter what
    }
}
