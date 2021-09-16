using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text score_text;
    [SerializeField] private string thrash_type;
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
        score_text.text = $"Score: {score}";
    }
}
