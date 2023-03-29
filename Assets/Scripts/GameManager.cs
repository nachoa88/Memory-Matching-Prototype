using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameActive;


    private void Update()
    {
        StartGame();

        /*if (isGameActive && timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            UpdateTimer(timeLeft);
        }
        if (isGameActive && timeLeft < 0)
        {
            Debug.Log("You're out of time");
            GameOver();
        }*/
    }

    public void StartGame()
    {
        isGameActive = true;
        //  StartCoroutine(SpawnTarget());
    }

    /* While game is active spawn a random target
    IEnumerator SpawnTarget()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targetPrefabs.Count);

            if (isGameActive)
            {
                Instantiate(targetPrefabs[index], RandomSpawnPosition(), targetPrefabs[index].transform.rotation);
            }

        }
    }*/


    /*public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        isGameActive = false;
    }*/
}
