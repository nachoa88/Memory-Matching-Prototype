using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class GridManager : MonoBehaviour
{
    private int columnLenght = 8;
    private int rowLenght = 3;

    [Header("Grid X, Y & Z positions")]
    [SerializeField] float x_Space;
    [SerializeField] float y_Space;
    [SerializeField] float x_Start;
    [SerializeField] float y_Start;
    [SerializeField] float z_Start;
    
    public List<GameObject> cardPrefabs;
    
    // Start is called before the first frame update
    void Start()
    {
        // The two for loops add the counting of columns & rows.
        for (int x = 0; x < columnLenght; x++)
        {
            for (int y = 0; y < rowLenght; y++)
            {
                int index = Random.Range(0, cardPrefabs.Count);
                Instantiate(cardPrefabs[index], new Vector3(x_Start + (x_Space * x), y_Start + (y_Space * y), z_Start), Quaternion.Euler(270, 0, 0));
                // The remove card is necessary for the Instantiate method not being able to clone more than once each object from the list.
                cardPrefabs.RemoveAt(index);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
