using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    public float timeRemaining;
    public TextMeshProUGUI timeText;
    public GameObject EndScreen;
    public TextMeshProUGUI EndText;

    public GameObject EndCamera;

    bool gameOver;
    

    private void Start()
    {
        EndCamera.SetActive(false);
        EndScreen.SetActive(false);
        gameOver = false;
        
    }

    private void Update()
    {
        if (!gameOver)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                timeRemaining = 0;
                EndText.text = "Cheese Lost";
                EndScreen.SetActive(true);

                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;

                EndCamera.SetActive(true);
            }
            timeText.text = "Time: " + Mathf.Round(timeRemaining).ToString();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        gameOver = true;
        EndText.text = "Cheese Acquired";
        EndScreen.SetActive(true);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        EndCamera.SetActive(true);
    }

}
