using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class GridManager : MonoBehaviour
{
    public int columnLenght;
    public int rowLenght;
    public float x_Space;
    public float y_Space;
    public float x_Start;
    public float y_Start;
    public float z_Start;
    public List<GameObject> cardPrefabs;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < columnLenght * rowLenght; i++) 
        {
            int index = Random.Range(0, cardPrefabs.Count);
            Instantiate(cardPrefabs[index], new Vector3(x_Start + (x_Space * (i % columnLenght)), y_Start + (-y_Space * (i / columnLenght)), z_Start + (0)), Quaternion.Euler(270, 0, 0));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
