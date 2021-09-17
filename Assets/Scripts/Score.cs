using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text score_text;
    [SerializeField] private string thrash_type;
    [SerializeField] private string thrash_type_text;
    private int score = 0;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(thrash_type))
        {
            score++;
            SetScoreText();
            Destroy(other.gameObject);
        }
    }
    
    void SetScoreText()
    {
        score_text.text = $"{thrash_type_text}: {score}";
    }
}
