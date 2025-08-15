using UnityEngine;

public class Muzic : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private static Muzic instance;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Pastreaza GameObject-ul intre scene
        }
        else
        {
            Destroy(gameObject); // Daca mai exista unul, il distruge
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
