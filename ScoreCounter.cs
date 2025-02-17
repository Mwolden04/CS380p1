using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using TMPro;

public class ScoreCounter : MonoBehaviour
{
    [Header("Dynamic")]
    public int score = 0;

    private Text  uiText;

    void Start(){
        uiText = GetComponent<Text>();
        //uiText = GameObject.Find("ScoreCounter").GetComponent<Text >();
        
        if (uiText == null){
            Debug.LogError("UI Text not assigned!");
        }
    }

    void Update(){
        uiText.text = score.ToString("#,0"); 
    }
}
