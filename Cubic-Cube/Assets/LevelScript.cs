using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class PlayerScript : MonoBehaviour
{
    void Start()
    {
        //tralalelo tralala THE GOAT
    }


    public Rigidbody player;
    public float speed;
    public Transform PlayerT;

    public Transform Obstacols;

    public GameObject Win_Canvas;
    public GameObject MiniMenu;
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.D))
        {
            player.AddForce(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.AddForce(0, 0, -speed * Time.deltaTime);
        }

        if (PlayerT.position.y<=-1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        Obstacols.Translate(10f * Time.deltaTime, 0, 0);


    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacol"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (collision.gameObject.CompareTag("win"))
        {
            Win_Canvas.SetActive(true);
            MiniMenu.SetActive(false);
            Time.timeScale = 0f;

        }
    }
    ///////////////////////////////////////////////////




}
