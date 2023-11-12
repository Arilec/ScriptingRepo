
using System.Globalization;
using UnityEngine;
using TMPro;
using UnityEngine.Events;


[RequireComponent(typeof(TextMeshProUGUI))]
public class TextLabelBehavior : MonoBehaviour
{
    private TextMeshProUGUI scoreText; //keeps UI element
    public UnityEvent startEvent;
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        startEvent.Invoke();
    }

    public void UpdateScoreText(FloatData score) //updates score UI text with float
    {
        scoreText.text = score.value.ToString(CultureInfo.InvariantCulture);
    }

    public void UpdateScoreText(IntData score)// updates score UI text with Int
    {
        scoreText.text = score.value.ToString(CultureInfo.InvariantCulture);
    }
}
