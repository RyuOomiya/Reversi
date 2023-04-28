using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField] GameObject _cell;
    GameObject[,] _board = new GameObject[8, 8];
    void Start()
    {
        //ÉIÉZÉçî’ê∂ê¨
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                _board[i, j] = Instantiate(_cell, new Vector3(i * 1.1f, 0.1f, j * 1.1f), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
