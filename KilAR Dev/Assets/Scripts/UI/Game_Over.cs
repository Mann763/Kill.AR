using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class Game_Over : MonoBehaviour
{
    public TMP_Text Score_GameEnd_Text;

    // Start is called before the first frame update
    void Start()
    {
        Score_GameEnd_Text.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void Back()
    {
        SceneManager.LoadScene(1);
    }
}
