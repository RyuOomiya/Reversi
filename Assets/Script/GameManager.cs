using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int[,] _board = new int[8, 8];
    [SerializeField] Stone _stone;

    private void Start()
    {
        //‰Šúİ’è
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if ((i == 3 && j == 3) || (i == 4 && j == 4))
                {
                    _board[i, j] = -1;
                    _stone.PutStone(i, j, -1);
                }
                if ((i == 3 && j == 4) || (i == 4 && j == 3))
                {
                    _board[i, j] = 1;
                    _stone.PutStone(i, j, 1);
                }
                _board[i, j] = 0;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
