using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Card : MonoBehaviour
{
    public GameObject card;
    private GameManager gameManager;
    public bool facedUp;


    private void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        facedUp = false;
    }

   

    private void OnMouseDown()
    {
        StartCoroutine(RotateCard());
       

    }

    public IEnumerator RotateCard()
    {
        
        
        if (gameManager.isGameActive && !facedUp)
        {
            transform.rotation = Quaternion.Euler(-90, 180, 0);
            facedUp = true;
            yield return null;
        }
        else if (gameManager.isGameActive && facedUp)
        {
            transform.rotation = Quaternion.Euler(-90, 0, 0);
            facedUp = false;
            yield return null;
        }



    }
}
