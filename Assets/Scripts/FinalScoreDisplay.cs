using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class FinalScoreDisplay : MonoBehaviour
{
    public static FinalScoreDisplay Instance;
    [SerializeField] public TMPro.TextMeshProUGUI hitText;
    [SerializeField] public TMPro.TextMeshProUGUI maxComboText;

    void Start()
    {
        Instance = this;
    }
    private void Update()
    {
        hitText.text = "Total Hits: " + ScoreManager.hits.ToString();
        maxComboText.text = "Max Combo: " + ScoreManager.maxCombo.ToString();
    }
}

