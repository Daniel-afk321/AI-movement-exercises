using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    private int coin = 0;
    public Text coinText;
    public GameObject victory;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Coin")
        {
            coin++;
            coinText.text = coin.ToString();
            Destroy(other.gameObject);
        }
        if (coin == 15)
        {
            victory.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }

    public void quit()
    {
        Application.Quit();
    }
}
