using UnityEngine;

public class SongManager : MonoBehaviour
{
    public static SongManager Instance; //can be accessed from other classes
    public AudioSource audioSource; //song itself
    public float songDelayInSeconds; //Delay if needed
    public int inputDelayInMilliseconds; //in case of problem with keyboard
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public string fileLocation;
    public float noteTime; //time note is shown on the screen
    public float noteSpawnY;
    public float notePressY;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
