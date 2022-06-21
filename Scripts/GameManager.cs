  using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public Player m_Player;
    public GameObject pauseButton;
    public GameObject pcBombButton;
    public GameObject bombButton;
    public int gemCount;
    private GameObject[] gems;
    public GameObject winnerScreen;
    public GameObject winnerScreenPC;
    private bool soundPlayed = false;

    AudioSource finishAudio;

    public GameObject controlsLeft;
    public GameObject controlsRight;

    public void Awake()
    {
        Time.timeScale = 1;
        winnerScreen.gameObject.SetActive(false);
        winnerScreenPC.gameObject.SetActive(false);
    }
    public void Start()
    {
        finishAudio = GetComponent<AudioSource>();
    }
    public void Update()
    {
        gems = GameObject.FindGameObjectsWithTag("Gem");
        gemCount = gems.Length;


        Winner();
    }

    public void Winner()
    {
        if (gemCount == 0)
        {

            if (!soundPlayed)
            {
                finishAudio.PlayOneShot(finishAudio.clip, 0.6F);
                soundPlayed = true;
            }
            
            m_Player.gameObject.SetActive(false);
            pauseButton.gameObject.SetActive(false);
            pcBombButton.gameObject.SetActive(false);
            bombButton.gameObject.SetActive(false);
            winnerScreen.gameObject.SetActive(true);
            winnerScreenPC.gameObject.SetActive(true);

            controlsLeft.gameObject.SetActive(false);
            controlsRight.gameObject.SetActive(false);
        }
    }
}