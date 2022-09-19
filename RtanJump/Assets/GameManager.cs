using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager I;     // 게임 전체에서 단 하나만 존재(싱글톤)
    public int Score;

    private void Awake()  //start보다 앞 과정
    {
        I = this;
    }
    public void AddScore(int score)
    {
        Score = Score + score;
        Debug.Log(Score.ToString());
    }

    public void GameOver()
    {
        Invoke("GameOver_", 2);
    }
    void GameOver_()
    {
        SceneManager.LoadScene(0); //첫번째 씬을 불러옴(로드함)
    }
    public void WinGame()
    {
        GameOver_();
    }



}
