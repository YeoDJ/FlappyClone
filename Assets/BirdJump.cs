using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpPower;
    // Start is called before the first frame update
    void Start()
    {
        // 컴포넌트 가져오기
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // 마우스 왼쪽 버튼(0)
        // Vector2(2D), Vector3(3D)
        // Vector2.up == Vector2(0, 1)
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * jumpPower;
        }
    }

    // 충돌했다면 GameOverScene으로 넘어감
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (Score.score > Score.bestScore)
            Score.bestScore = Score.score;
        SceneManager.LoadScene("GameOverScene");
    }
}
