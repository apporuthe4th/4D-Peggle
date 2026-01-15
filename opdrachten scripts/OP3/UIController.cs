using UnityEngine;
using TMPro;
using Unity.VisualScripting;
public class UIController : MonoBehaviour
{
    Score score;
    [SerializeField] TextMeshProUGUI TextScore;

    private void Start()
    {
        score = GameObject.FindGameObjectWithTag("GameController").GetComponent<Score>();
    }
    private void TextUpdate() {
        TextScore.text = score.currentScore.ToString();


    }

    private void UpdateScore() {
    
    
    }
    void Update()
    {
        TextUpdate();
    }
}
