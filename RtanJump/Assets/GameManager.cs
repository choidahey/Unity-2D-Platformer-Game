using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager I;     // ���� ��ü���� �� �ϳ��� ����(�̱���)
    public int Score;

    private void Awake()  //start���� �� ����
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
        SceneManager.LoadScene(0); //ù��° ���� �ҷ���(�ε���)
    }
    public void WinGame()
    {
        GameOver_();
    }



}
