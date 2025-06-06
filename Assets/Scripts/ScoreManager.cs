using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public AudioSource hitSFX;
    public AudioSource missSFX;
    public TMPro.TextMeshPro scoreText;
    public TMPro.TextMeshPro missText;
    [SerializeField] public TMPro.TextMeshPro hitText;
    static public int comboScore;
    static public int maxCombo;
    static public int misses;
    static public int hits;
    void Start()
    {
        Instance = this;
        comboScore = 0;
        misses = 0;
        maxCombo = 0;
    }
    public static void Hit()
    {
        comboScore += 1;
        Instance.hitSFX.Play();
        hits++;
    }
    public static void Miss()
    {
        if (comboScore > maxCombo) {
            maxCombo = comboScore;
        }
        comboScore = 0;
        Instance.missSFX.Play();
        misses++;    
    }
    private void Update()
    {
        scoreText.text = "Score " + comboScore.ToString();
        missText.text = "Misses " + misses.ToString();

        if (misses > 9) {
            SceneManager.LoadScene("Failure");
        }
    }
}