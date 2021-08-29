using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyBirds : MonoBehaviour
{
    Rigidbody2D rg;
    public GameObject gameOverObj;
    public float speed;

    private void Start()
    {
        Time.timeScale = 1;
        rg = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // 0 là chuột trái; 1 là con lăng; 2 là chuột phải
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            rg.AddForce(Vector2.up * speed);
        }
    }
    
    public void ResetGame()
    {
        SceneManager.LoadScene(0);
    }

    void GameOver()
    {
        gameOverObj.SetActive(true);
        Time.timeScale = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameOver();
    }
}
