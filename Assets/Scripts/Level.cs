using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Level
{
    public static Block[,,] GetLevel(int level)
    {
        Block[,,] blocks = new Block[15, 15, 15];
        for (int y = 0; y < 15; y++)
            for (int x = 0; x < 15; x++)
                for (int z = 0; z < 15; z++)
                {
                    //if (x == 0 || y == 0 || z == 0 || x == 14 || y == 14 || z == 14)
                    //{
                    //    blocks[x, y, z] = new Block();
                    //    blocks[x, y, z].type = BlockType.Glass;
                    //}
                    //else
                    {
                        blocks[x, y, z] = new Block();
                        blocks[x, y, z].type = BlockType.Wall;
                    }
                }
        switch (level)
        {
            case -1:
                for (int x = 1; x < 14; x++)
                    for (int y = 1; y < 14; y++)
                        for (int z = 1; z < 14; z++)
                            blocks[x, y, z].type = BlockType.Air;
                blocks[1, 1, 1].type = BlockType.Start;
                blocks[3, 3, 3].type = BlockType.Portal;blocks[3, 3, 3].index = 1;
                blocks[3, 5, 3].type = BlockType.Portal;blocks[3, 5, 3].index = 1;
                break;

            case 0:
                {
                    blocks[1, 1, 1].type = BlockType.Start;
                    blocks[1, 1, 2].type = BlockType.Air;
                    blocks[2, 1, 2].type = BlockType.Exit;
                    blocks[1, 1, 3].type = BlockType.Air;
                    blocks[1, 1, 4].type = BlockType.Air;
                    blocks[2, 1, 4].type = BlockType.Dye; blocks[2, 1, 4].index = 1;
                    blocks[1, 1, 5].type = BlockType.Tunnel; blocks[1, 1, 5].index = 1; blocks[1, 1, 5].index2 = 1;
                    blocks[1, 1, 6].type = BlockType.Air;
                    blocks[1, 1, 7].type = BlockType.Bonus;
                }
                break;
            case 1:
                {
                    blocks[1, 1, 1].type = BlockType.Start;
                    blocks[2, 1, 1].type = BlockType.Air;
                    blocks[3, 1, 1].type = BlockType.Air;
                    blocks[5, 1, 1].type = BlockType.Air;
                    blocks[6, 1, 1].type = BlockType.Air;
                    blocks[7, 1, 1].type = BlockType.Air;
                    blocks[9, 1, 1].type = BlockType.Air;
                    blocks[10, 1, 1].type = BlockType.Air;
                    blocks[11, 1, 1].type = BlockType.Air;
                    blocks[13, 1, 1].type = BlockType.Air;

                    blocks[3, 1, 2].type = BlockType.Air;
                    blocks[4, 1, 2].type = BlockType.Air;
                    blocks[5, 1, 2].type = BlockType.Air;
                    blocks[7, 1, 2].type = BlockType.Air;
                    blocks[8, 1, 2].type = BlockType.Air;
                    blocks[9, 1, 2].type = BlockType.Air;
                    blocks[11, 1, 2].type = BlockType.Air;
                    blocks[13, 1, 2].type = BlockType.Air;

                    blocks[1, 1, 3].type = BlockType.Air;
                    blocks[2, 1, 3].type = BlockType.Air;
                    blocks[3, 1, 3].type = BlockType.Air;
                    blocks[5, 1, 3].type = BlockType.Air;
                    blocks[11, 1, 3].type = BlockType.Air;
                    blocks[13, 1, 3].type = BlockType.Air;

                    blocks[1, 1, 4].type = BlockType.Air;
                    blocks[5, 1, 4].type = BlockType.Air;
                    blocks[6, 1, 4].type = BlockType.Air;
                    blocks[7, 1, 4].type = BlockType.Air;
                    blocks[9, 1, 4].type = BlockType.Air;
                    blocks[10, 1, 4].type = BlockType.Air;
                    blocks[11, 1, 4].type = BlockType.Air;
                    blocks[12, 1, 4].type = BlockType.Air;
                    blocks[13, 1, 4].type = BlockType.Air;

                    blocks[1, 1, 5].type = BlockType.Air;
                    blocks[3, 1, 5].type = BlockType.Air;
                    blocks[4, 1, 5].type = BlockType.Air;
                    blocks[5, 1, 5].type = BlockType.Air;
                    blocks[7, 1, 5].type = BlockType.Air;
                    blocks[9, 1, 5].type = BlockType.Air;
                    blocks[12, 1, 5].type = BlockType.Air;

                    blocks[1, 1, 6].type = BlockType.Air;
                    blocks[3, 1, 6].type = BlockType.Air;
                    blocks[7, 1, 6].type = BlockType.Air;
                    blocks[9, 1, 6].type = BlockType.Air;
                    blocks[10, 1, 6].type = BlockType.Air;
                    blocks[12, 1, 6].type = BlockType.Air;
                    blocks[13, 1, 6].type = BlockType.Air;

                    blocks[1, 1, 7].type = BlockType.Air;
                    blocks[3, 1, 7].type = BlockType.Air;
                    blocks[4, 1, 7].type = BlockType.Air;
                    blocks[5, 1, 7].type = BlockType.Air;
                    blocks[7, 1, 7].type = BlockType.Air;
                    blocks[10, 1, 7].type = BlockType.Air;
                    blocks[13, 1, 7].type = BlockType.Air;

                    blocks[1, 1, 8].type = BlockType.Air;
                    blocks[5, 1, 8].type = BlockType.Air;
                    blocks[7, 1, 8].type = BlockType.Air;
                    blocks[8, 1, 8].type = BlockType.Air;
                    blocks[9, 1, 8].type = BlockType.Air;
                    blocks[10, 1, 8].type = BlockType.Air;
                    blocks[12, 1, 8].type = BlockType.Air;
                    blocks[13, 1, 8].type = BlockType.Air;

                    blocks[1, 1, 9].type = BlockType.Air;
                    blocks[2, 1, 9].type = BlockType.Air;
                    blocks[3, 1, 9].type = BlockType.Air;
                    blocks[12, 1, 9].type = BlockType.Air;

                    blocks[3, 1, 10].type = BlockType.Air;
                    blocks[4, 1, 10].type = BlockType.Air;
                    blocks[5, 1, 10].type = BlockType.Air;
                    blocks[7, 1, 10].type = BlockType.Air;
                    blocks[8, 1, 10].type = BlockType.Air;
                    blocks[9, 1, 10].type = BlockType.Air;
                    blocks[10, 1, 10].type = BlockType.Air;
                    blocks[11, 1, 10].type = BlockType.Air;
                    blocks[12, 1, 10].type = BlockType.Air;
                    blocks[13, 1, 10].type = BlockType.Air;

                    blocks[1, 1, 11].type = BlockType.Air;
                    blocks[3, 1, 11].type = BlockType.Air;
                    blocks[5, 1, 11].type = BlockType.Air;
                    blocks[7, 1, 11].type = BlockType.Air;
                    blocks[13, 1, 11].type = BlockType.Air;

                    blocks[1, 1, 12].type = BlockType.Air;
                    blocks[3, 1, 12].type = BlockType.Air;
                    blocks[7, 1, 12].type = BlockType.Air;
                    blocks[9, 1, 12].type = BlockType.Air;
                    blocks[10, 1, 12].type = BlockType.Air;
                    blocks[11, 1, 12].type = BlockType.Air;

                    blocks[1, 1, 13].type = BlockType.Air;
                    blocks[2, 1, 13].type = BlockType.Air;
                    blocks[3, 1, 13].type = BlockType.Air;
                    blocks[5, 1, 13].type = BlockType.Air;
                    blocks[6, 1, 13].type = BlockType.Air;
                    blocks[7, 1, 13].type = BlockType.Air;
                    blocks[8, 1, 13].type = BlockType.Air;
                    blocks[9, 1, 13].type = BlockType.Air;
                    blocks[11, 1, 13].type = BlockType.Air;
                    blocks[12, 1, 13].type = BlockType.Air;
                    blocks[13, 1, 13].type = BlockType.Exit;
                }
                break;
            case 2:
                {
                    blocks[1, 1, 1].type = BlockType.Start;
                    blocks[2, 1, 1].type = BlockType.Air;
                    for (int z = 1; z <= 7; z++)
                        blocks[3, 1, z].type = BlockType.Air;
                    blocks[4, 1, 7].type = BlockType.Air;
                    blocks[5, 1, 7].type = BlockType.Air;
                    blocks[9, 1, 7].type = BlockType.Air;
                    blocks[10, 1, 7].type = BlockType.Air;
                    for (int z = 7; z <= 13; z++)
                        blocks[11, 1, z].type = BlockType.Air;
                    blocks[12, 1, 13].type = BlockType.Air;
                    blocks[13, 1, 13].type = BlockType.Exit;
                    blocks[14, 1, 13].type = BlockType.Air;

                    for (int x = 5; x <= 9; x++)
                        blocks[x, 2, 7].type = BlockType.Air;
                }
                break;
            case 3:
                {
                    for (int x = 2; x <= 12; x += 5)
                        for (int z = 7; z <= 13; z += 3)
                            for (int _x = -1; _x <= 1; _x++)
                                blocks[x + _x, 1, z].type = BlockType.Air;
                    blocks[3, 2, 7].type = BlockType.Air;
                    blocks[3, 2, 6].type = BlockType.Air;
                    for (int x = 3; x <= 11; x++)
                        blocks[x, 2, 5].type = BlockType.Air;
                    blocks[11, 2, 6].type = BlockType.Air;
                    blocks[11, 2, 7].type = BlockType.Air;
                    for (int x = 8; x <= 11; x++)
                        blocks[x, 2, 8].type = BlockType.Air;
                    blocks[8, 2, 7].type = BlockType.Air;
                    for (int z = 7; z <= 10; z++)
                        blocks[6, 2, z].type = BlockType.Air;
                    blocks[5, 2, 10].type = BlockType.Air;
                    blocks[4, 2, 10].type = BlockType.Air;
                    for (int z = 10; z <= 13; z++)
                        blocks[3, 2, z].type = BlockType.Air;
                    blocks[6, 2, 13].type = BlockType.Air;
                    for (int z = 10; z <= 13; z++)
                        blocks[8, 2, z].type = BlockType.Air;
                    blocks[9, 2, 13].type = BlockType.Air;
                    blocks[10, 2, 13].type = BlockType.Air;
                    for (int z = 10; z <= 13; z++)
                        blocks[11, 2, z].type = BlockType.Air;
                    blocks[1, 1, 7].type = BlockType.Start;
                    blocks[13, 1, 13].type = BlockType.Exit;
                    blocks[14, 1, 13].type = BlockType.Air;
                }
                break;
            case 4:
                {
                    blocks[1, 1, 1].type = BlockType.Air;
                    blocks[3, 1, 1].type = BlockType.Air;
                    blocks[6, 1, 1].type = BlockType.Air;
                    blocks[7, 1, 1].type = BlockType.Air;
                    blocks[8, 1, 1].type = BlockType.Air;
                    blocks[9, 1, 1].type = BlockType.Air;
                    blocks[13, 1, 1].type = BlockType.Air;
                    blocks[1, 1, 2].type = BlockType.Air;
                    blocks[3, 1, 2].type = BlockType.Air;
                    blocks[4, 1, 2].type = BlockType.Air;
                    blocks[5, 1, 2].type = BlockType.Air;
                    blocks[6, 1, 2].type = BlockType.Air;
                    blocks[13, 1, 2].type = BlockType.Air;
                    blocks[1, 1, 3].type = BlockType.Air;
                    blocks[4, 1, 3].type = BlockType.Air;
                    blocks[6, 1, 3].type = BlockType.Air;
                    blocks[8, 1, 3].type = BlockType.Air;
                    blocks[9, 1, 3].type = BlockType.Air;
                    blocks[10, 1, 3].type = BlockType.Air;
                    blocks[11, 1, 3].type = BlockType.Air;
                    blocks[12, 1, 3].type = BlockType.Air;
                    blocks[13, 1, 3].type = BlockType.Air;
                    blocks[1, 1, 4].type = BlockType.Air;
                    blocks[2, 1, 4].type = BlockType.Air;
                    blocks[3, 1, 4].type = BlockType.Air;
                    blocks[4, 1, 4].type = BlockType.Air;
                    blocks[13, 1, 4].type = BlockType.Air;
                    blocks[1, 1, 5].type = BlockType.Air;
                    blocks[4, 1, 5].type = BlockType.Air;
                    blocks[9, 1, 5].type = BlockType.Air;
                    blocks[10, 1, 5].type = BlockType.Air;
                    blocks[11, 1, 5].type = BlockType.Air;
                    blocks[1, 1, 6].type = BlockType.Air;
                    blocks[2, 1, 6].type = BlockType.Air;
                    blocks[4, 1, 6].type = BlockType.Air;
                    blocks[2, 1, 7].type = BlockType.Air;
                    blocks[4, 1, 7].type = BlockType.Air;
                    blocks[5, 1, 7].type = BlockType.Air;
                    blocks[6, 1, 7].type = BlockType.Start;
                    blocks[8, 1, 7].type = BlockType.Exit;
                    blocks[9, 1, 7].type = BlockType.Air;
                    blocks[10, 1, 7].type = BlockType.Air;
                    blocks[1, 1, 8].type = BlockType.Air;
                    blocks[2, 1, 8].type = BlockType.Air;
                    blocks[10, 1, 8].type = BlockType.Air;
                    blocks[12, 1, 8].type = BlockType.Air;
                    blocks[13, 1, 8].type = BlockType.Air;
                    blocks[1, 1, 9].type = BlockType.Air;
                    blocks[4, 1, 9].type = BlockType.Air;
                    blocks[5, 1, 9].type = BlockType.Air;
                    blocks[6, 1, 9].type = BlockType.Air;
                    blocks[7, 1, 9].type = BlockType.Air;
                    blocks[8, 1, 9].type = BlockType.Air;
                    blocks[10, 1, 9].type = BlockType.Air;
                    blocks[12, 1, 9].type = BlockType.Air;
                    blocks[1, 1, 10].type = BlockType.Air;
                    blocks[10, 1, 10].type = BlockType.Air;
                    blocks[12, 1, 10].type = BlockType.Air;
                    blocks[1, 1, 11].type = BlockType.Air;
                    blocks[5, 1, 11].type = BlockType.Air;
                    blocks[6, 1, 11].type = BlockType.Air;
                    blocks[7, 1, 11].type = BlockType.Air;
                    blocks[10, 1, 11].type = BlockType.Air;
                    blocks[12, 1, 11].type = BlockType.Air;
                    blocks[13, 1, 11].type = BlockType.Air;
                    blocks[1, 1, 12].type = BlockType.Air;
                    blocks[13, 1, 12].type = BlockType.Air;
                    blocks[1, 1, 13].type = BlockType.Air;
                    blocks[2, 1, 13].type = BlockType.Air;
                    blocks[3, 1, 13].type = BlockType.Air;
                    blocks[5, 1, 13].type = BlockType.Air;
                    blocks[6, 1, 13].type = BlockType.Air;
                    blocks[7, 1, 13].type = BlockType.Air;
                    blocks[11, 1, 13].type = BlockType.Air;
                    blocks[12, 1, 13].type = BlockType.Air;
                    blocks[13, 1, 13].type = BlockType.Air;
                    blocks[1, 2, 1].type = BlockType.Air;
                    blocks[2, 2, 1].type = BlockType.Air;
                    blocks[3, 2, 1].type = BlockType.Air;
                    blocks[9, 2, 1].type = BlockType.Air;
                    blocks[10, 2, 1].type = BlockType.Air;
                    blocks[11, 2, 1].type = BlockType.Air;
                    blocks[12, 2, 1].type = BlockType.Air;
                    blocks[13, 2, 1].type = BlockType.Air;
                    blocks[8, 2, 3].type = BlockType.Air;
                    blocks[11, 2, 3].type = BlockType.Air;
                    blocks[8, 2, 4].type = BlockType.Air;
                    blocks[11, 2, 4].type = BlockType.Air;
                    blocks[4, 2, 5].type = BlockType.Air;
                    blocks[5, 2, 5].type = BlockType.Air;
                    blocks[6, 2, 5].type = BlockType.Air;
                    blocks[7, 2, 5].type = BlockType.Air;
                    blocks[8, 2, 5].type = BlockType.Air;
                    blocks[11, 2, 5].type = BlockType.Air;
                    blocks[11, 2, 6].type = BlockType.Air;
                    blocks[12, 2, 6].type = BlockType.Air;
                    blocks[13, 2, 6].type = BlockType.Air;
                    blocks[2, 2, 7].type = BlockType.Air;
                    blocks[3, 2, 7].type = BlockType.Air;
                    blocks[4, 2, 7].type = BlockType.Air;
                    blocks[13, 2, 7].type = BlockType.Air;
                    blocks[13, 2, 8].type = BlockType.Air;
                    blocks[5, 2, 9].type = BlockType.Air;
                    blocks[8, 2, 9].type = BlockType.Air;
                    blocks[9, 2, 9].type = BlockType.Air;
                    blocks[10, 2, 9].type = BlockType.Air;
                    blocks[5, 2, 10].type = BlockType.Air;
                    blocks[1, 2, 11].type = BlockType.Air;
                    blocks[2, 2, 11].type = BlockType.Air;
                    blocks[3, 2, 11].type = BlockType.Air;
                    blocks[5, 2, 11].type = BlockType.Air;
                    blocks[7, 2, 11].type = BlockType.Air;
                    blocks[9, 2, 11].type = BlockType.Air;
                    blocks[10, 2, 11].type = BlockType.Air;
                    blocks[3, 2, 12].type = BlockType.Air;
                    blocks[9, 2, 12].type = BlockType.Air;
                    blocks[3, 2, 13].type = BlockType.Air;
                    blocks[4, 2, 13].type = BlockType.Air;
                    blocks[5, 2, 13].type = BlockType.Air;
                    blocks[7, 2, 13].type = BlockType.Air;
                    blocks[9, 2, 13].type = BlockType.Air;
                    blocks[10, 2, 13].type = BlockType.Air;
                    blocks[11, 2, 13].type = BlockType.Air;
                }
                break;
            case 5:
                {
                    blocks[7, 1, 1].type = BlockType.Air;
                    blocks[7, 1, 2].type = BlockType.Air;
                    blocks[7, 1, 3].type = BlockType.Air;
                    blocks[7, 1, 4].type = BlockType.Air;
                    blocks[7, 1, 5].type = BlockType.Air;
                    blocks[7, 1, 6].type = BlockType.Air;
                    blocks[1, 1, 7].type = BlockType.Air;
                    blocks[2, 1, 7].type = BlockType.Air;
                    blocks[3, 1, 7].type = BlockType.Air;
                    blocks[4, 1, 7].type = BlockType.Air;
                    blocks[5, 1, 7].type = BlockType.Air;
                    blocks[6, 1, 7].type = BlockType.Air;
                    blocks[7, 1, 7].type = BlockType.Start;
                    blocks[8, 1, 7].type = BlockType.Air;
                    blocks[9, 1, 7].type = BlockType.Air;
                    blocks[10, 1, 7].type = BlockType.Air;
                    blocks[11, 1, 7].type = BlockType.Air;
                    blocks[12, 1, 7].type = BlockType.Air;
                    blocks[13, 1, 7].type = BlockType.Air;
                    blocks[7, 1, 8].type = BlockType.Air;
                    blocks[7, 1, 9].type = BlockType.Air;
                    blocks[7, 1, 10].type = BlockType.Air;
                    blocks[7, 1, 11].type = BlockType.Air;
                    blocks[7, 1, 12].type = BlockType.Air;
                    blocks[7, 1, 13].type = BlockType.Air;
                    blocks[5, 2, 1].type = BlockType.Air;
                    blocks[6, 2, 1].type = BlockType.Air;
                    blocks[7, 2, 1].type = BlockType.Air;
                    blocks[8, 2, 1].type = BlockType.Air;
                    blocks[9, 2, 1].type = BlockType.Air;
                    blocks[1, 2, 5].type = BlockType.Air;
                    blocks[13, 2, 5].type = BlockType.Air;
                    blocks[1, 2, 6].type = BlockType.Air;
                    blocks[13, 2, 6].type = BlockType.Air;
                    blocks[1, 2, 7].type = BlockType.Air;
                    blocks[13, 2, 7].type = BlockType.Air;
                    blocks[1, 2, 8].type = BlockType.Air;
                    blocks[13, 2, 8].type = BlockType.Air;
                    blocks[1, 2, 9].type = BlockType.Air;
                    blocks[13, 2, 9].type = BlockType.Air;
                    blocks[5, 2, 13].type = BlockType.Air;
                    blocks[6, 2, 13].type = BlockType.Air;
                    blocks[7, 2, 13].type = BlockType.Air;
                    blocks[8, 2, 13].type = BlockType.Air;
                    blocks[9, 2, 13].type = BlockType.Air;
                    blocks[5, 3, 1].type = BlockType.Air;
                    blocks[9, 3, 1].type = BlockType.Air;
                    blocks[5, 3, 2].type = BlockType.Air;
                    blocks[9, 3, 2].type = BlockType.Air;
                    blocks[5, 3, 3].type = BlockType.Air;
                    blocks[9, 3, 3].type = BlockType.Air;
                    blocks[1, 3, 5].type = BlockType.Air;
                    blocks[2, 3, 5].type = BlockType.Air;
                    blocks[3, 3, 5].type = BlockType.Air;
                    blocks[11, 3, 5].type = BlockType.Air;
                    blocks[12, 3, 5].type = BlockType.Air;
                    blocks[13, 3, 5].type = BlockType.Air;
                    blocks[1, 3, 9].type = BlockType.Air;
                    blocks[2, 3, 9].type = BlockType.Air;
                    blocks[3, 3, 9].type = BlockType.Air;
                    blocks[11, 3, 9].type = BlockType.Air;
                    blocks[12, 3, 9].type = BlockType.Air;
                    blocks[13, 3, 9].type = BlockType.Air;
                    blocks[5, 3, 11].type = BlockType.Air;
                    blocks[9, 3, 11].type = BlockType.Air;
                    blocks[5, 3, 12].type = BlockType.Air;
                    blocks[9, 3, 12].type = BlockType.Air;
                    blocks[5, 3, 13].type = BlockType.Air;
                    blocks[9, 3, 13].type = BlockType.Air;
                    blocks[4, 4, 3].type = BlockType.Air;
                    blocks[5, 4, 3].type = BlockType.Air;
                    blocks[6, 4, 3].type = BlockType.Air;
                    blocks[8, 4, 3].type = BlockType.Air;
                    blocks[9, 4, 3].type = BlockType.Air;
                    blocks[10, 4, 3].type = BlockType.Air;
                    blocks[3, 4, 4].type = BlockType.Air;
                    blocks[11, 4, 4].type = BlockType.Air;
                    blocks[3, 4, 5].type = BlockType.Air;
                    blocks[11, 4, 5].type = BlockType.Air;
                    blocks[3, 4, 6].type = BlockType.Air;
                    blocks[11, 4, 6].type = BlockType.Air;
                    blocks[3, 4, 8].type = BlockType.Air;
                    blocks[11, 4, 8].type = BlockType.Air;
                    blocks[3, 4, 9].type = BlockType.Air;
                    blocks[11, 4, 9].type = BlockType.Air;
                    blocks[3, 4, 10].type = BlockType.Air;
                    blocks[11, 4, 10].type = BlockType.Air;
                    blocks[4, 4, 11].type = BlockType.Air;
                    blocks[5, 4, 11].type = BlockType.Air;
                    blocks[6, 4, 11].type = BlockType.Air;
                    blocks[8, 4, 11].type = BlockType.Air;
                    blocks[9, 4, 11].type = BlockType.Air;
                    blocks[10, 4, 11].type = BlockType.Air;
                    blocks[6, 5, 1].type = BlockType.Air;
                    blocks[8, 5, 1].type = BlockType.Air;
                    blocks[6, 5, 2].type = BlockType.Air;
                    blocks[8, 5, 2].type = BlockType.Air;
                    blocks[6, 5, 3].type = BlockType.Air;
                    blocks[8, 5, 3].type = BlockType.Air;
                    blocks[6, 5, 4].type = BlockType.Air;
                    blocks[8, 5, 4].type = BlockType.Air;
                    blocks[6, 5, 5].type = BlockType.Air;
                    blocks[8, 5, 5].type = BlockType.Air;
                    blocks[1, 5, 6].type = BlockType.Air;
                    blocks[2, 5, 6].type = BlockType.Air;
                    blocks[3, 5, 6].type = BlockType.Air;
                    blocks[4, 5, 6].type = BlockType.Air;
                    blocks[5, 5, 6].type = BlockType.Air;
                    blocks[9, 5, 6].type = BlockType.Air;
                    blocks[10, 5, 6].type = BlockType.Air;
                    blocks[11, 5, 6].type = BlockType.Air;
                    blocks[12, 5, 6].type = BlockType.Air;
                    blocks[13, 5, 6].type = BlockType.Air;
                    blocks[1, 5, 8].type = BlockType.Air;
                    blocks[2, 5, 8].type = BlockType.Air;
                    blocks[3, 5, 8].type = BlockType.Air;
                    blocks[4, 5, 8].type = BlockType.Air;
                    blocks[5, 5, 8].type = BlockType.Air;
                    blocks[9, 5, 8].type = BlockType.Air;
                    blocks[10, 5, 8].type = BlockType.Air;
                    blocks[11, 5, 8].type = BlockType.Air;
                    blocks[12, 5, 8].type = BlockType.Air;
                    blocks[13, 5, 8].type = BlockType.Air;
                    blocks[6, 5, 9].type = BlockType.Air;
                    blocks[8, 5, 9].type = BlockType.Air;
                    blocks[6, 5, 10].type = BlockType.Air;
                    blocks[8, 5, 10].type = BlockType.Air;
                    blocks[6, 5, 11].type = BlockType.Air;
                    blocks[8, 5, 11].type = BlockType.Air;
                    blocks[6, 5, 12].type = BlockType.Air;
                    blocks[8, 5, 12].type = BlockType.Air;
                    blocks[6, 5, 13].type = BlockType.Air;
                    blocks[8, 5, 13].type = BlockType.Air;
                    blocks[3, 6, 1].type = BlockType.Air;
                    blocks[4, 6, 1].type = BlockType.Air;
                    blocks[5, 6, 1].type = BlockType.Air;
                    blocks[6, 6, 1].type = BlockType.Air;
                    blocks[8, 6, 1].type = BlockType.Air;
                    blocks[9, 6, 1].type = BlockType.Air;
                    blocks[10, 6, 1].type = BlockType.Air;
                    blocks[11, 6, 1].type = BlockType.Air;
                    blocks[1, 6, 3].type = BlockType.Air;
                    blocks[13, 6, 3].type = BlockType.Air;
                    blocks[1, 6, 4].type = BlockType.Air;
                    blocks[13, 6, 4].type = BlockType.Air;
                    blocks[1, 6, 5].type = BlockType.Air;
                    blocks[6, 6, 5].type = BlockType.Air;
                    blocks[7, 6, 5].type = BlockType.Air;
                    blocks[8, 6, 5].type = BlockType.Air;
                    blocks[13, 6, 5].type = BlockType.Air;
                    blocks[1, 6, 6].type = BlockType.Air;
                    blocks[5, 6, 6].type = BlockType.Air;
                    blocks[9, 6, 6].type = BlockType.Air;
                    blocks[13, 6, 6].type = BlockType.Air;
                    blocks[5, 6, 7].type = BlockType.Air;
                    blocks[9, 6, 7].type = BlockType.Air;
                    blocks[1, 6, 8].type = BlockType.Air;
                    blocks[5, 6, 8].type = BlockType.Air;
                    blocks[9, 6, 8].type = BlockType.Air;
                    blocks[13, 6, 8].type = BlockType.Air;
                    blocks[1, 6, 9].type = BlockType.Air;
                    blocks[6, 6, 9].type = BlockType.Air;
                    blocks[7, 6, 9].type = BlockType.Air;
                    blocks[8, 6, 9].type = BlockType.Air;
                    blocks[13, 6, 9].type = BlockType.Air;
                    blocks[1, 6, 10].type = BlockType.Air;
                    blocks[13, 6, 10].type = BlockType.Air;
                    blocks[1, 6, 11].type = BlockType.Air;
                    blocks[13, 6, 11].type = BlockType.Air;
                    blocks[3, 6, 13].type = BlockType.Air;
                    blocks[4, 6, 13].type = BlockType.Air;
                    blocks[5, 6, 13].type = BlockType.Air;
                    blocks[6, 6, 13].type = BlockType.Air;
                    blocks[8, 6, 13].type = BlockType.Air;
                    blocks[9, 6, 13].type = BlockType.Air;
                    blocks[10, 6, 13].type = BlockType.Air;
                    blocks[11, 6, 13].type = BlockType.Air;
                    blocks[1, 7, 3].type = BlockType.Air;
                    blocks[2, 7, 3].type = BlockType.Air;
                    blocks[3, 7, 3].type = BlockType.Air;
                    blocks[4, 7, 3].type = BlockType.Air;
                    blocks[10, 7, 3].type = BlockType.Air;
                    blocks[11, 7, 3].type = BlockType.Air;
                    blocks[12, 7, 3].type = BlockType.Air;
                    blocks[13, 7, 3].type = BlockType.Air;
                    blocks[1, 7, 11].type = BlockType.Air;
                    blocks[2, 7, 11].type = BlockType.Air;
                    blocks[3, 7, 11].type = BlockType.Air;
                    blocks[4, 7, 11].type = BlockType.Air;
                    blocks[10, 7, 11].type = BlockType.Air;
                    blocks[11, 7, 11].type = BlockType.Air;
                    blocks[12, 7, 11].type = BlockType.Air;
                    blocks[13, 7, 11].type = BlockType.Air;
                    blocks[4, 8, 3].type = BlockType.Air;
                    blocks[10, 8, 3].type = BlockType.Air;
                    blocks[4, 8, 4].type = BlockType.Air;
                    blocks[10, 8, 4].type = BlockType.Air;
                    blocks[4, 8, 5].type = BlockType.Air;
                    blocks[10, 8, 5].type = BlockType.Air;
                    blocks[4, 8, 9].type = BlockType.Air;
                    blocks[10, 8, 9].type = BlockType.Air;
                    blocks[4, 8, 10].type = BlockType.Air;
                    blocks[10, 8, 10].type = BlockType.Air;
                    blocks[4, 8, 11].type = BlockType.Air;
                    blocks[10, 8, 11].type = BlockType.Air;
                    blocks[4, 9, 5].type = BlockType.Air;
                    blocks[5, 9, 5].type = BlockType.Air;
                    blocks[6, 9, 5].type = BlockType.Air;
                    blocks[7, 9, 5].type = BlockType.Exit;
                    blocks[10, 9, 5].type = BlockType.Air;
                    blocks[4, 9, 9].type = BlockType.Air;
                    blocks[10, 9, 9].type = BlockType.Air;
                }
                break;
            case 6:
                {
                    blocks[1, 1, 1].type = BlockType.Air;
                    blocks[2, 1, 1].type = BlockType.Air;
                    blocks[3, 1, 1].type = BlockType.Air;
                    blocks[4, 1, 1].type = BlockType.Air;
                    blocks[5, 1, 1].type = BlockType.Air;
                    blocks[6, 1, 1].type = BlockType.Air;
                    blocks[7, 1, 1].type = BlockType.Air;
                    blocks[8, 1, 1].type = BlockType.Air;
                    blocks[9, 1, 1].type = BlockType.Air;
                    blocks[10, 1, 1].type = BlockType.Air;
                    blocks[11, 1, 1].type = BlockType.Air;
                    blocks[12, 1, 1].type = BlockType.Air;
                    blocks[13, 1, 1].type = BlockType.Air;
                    blocks[1, 1, 2].type = BlockType.Air;
                    blocks[7, 1, 2].type = BlockType.Air;
                    blocks[13, 1, 2].type = BlockType.Air;
                    blocks[1, 1, 3].type = BlockType.Air;
                    blocks[7, 1, 3].type = BlockType.Air;
                    blocks[13, 1, 3].type = BlockType.Air;
                    blocks[1, 1, 4].type = BlockType.Air;
                    blocks[7, 1, 4].type = BlockType.Air;
                    blocks[13, 1, 4].type = BlockType.Air;
                    blocks[1, 1, 5].type = BlockType.Air;
                    blocks[7, 1, 5].type = BlockType.Air;
                    blocks[13, 1, 5].type = BlockType.Air;
                    blocks[1, 1, 6].type = BlockType.Air;
                    blocks[7, 1, 6].type = BlockType.Air;
                    blocks[13, 1, 6].type = BlockType.Air;
                    blocks[1, 1, 7].type = BlockType.Air;
                    blocks[2, 1, 7].type = BlockType.Air;
                    blocks[3, 1, 7].type = BlockType.Air;
                    blocks[4, 1, 7].type = BlockType.Air;
                    blocks[5, 1, 7].type = BlockType.Air;
                    blocks[6, 1, 7].type = BlockType.Air;
                    blocks[7, 1, 7].type = BlockType.Start;
                    blocks[8, 1, 7].type = BlockType.Air;
                    blocks[9, 1, 7].type = BlockType.Air;
                    blocks[10, 1, 7].type = BlockType.Air;
                    blocks[11, 1, 7].type = BlockType.Air;
                    blocks[12, 1, 7].type = BlockType.Air;
                    blocks[13, 1, 7].type = BlockType.Air;
                    blocks[1, 1, 8].type = BlockType.Air;
                    blocks[7, 1, 8].type = BlockType.Air;
                    blocks[13, 1, 8].type = BlockType.Air;
                    blocks[1, 1, 9].type = BlockType.Air;
                    blocks[7, 1, 9].type = BlockType.Air;
                    blocks[13, 1, 9].type = BlockType.Air;
                    blocks[1, 1, 10].type = BlockType.Air;
                    blocks[7, 1, 10].type = BlockType.Air;
                    blocks[13, 1, 10].type = BlockType.Air;
                    blocks[1, 1, 11].type = BlockType.Air;
                    blocks[7, 1, 11].type = BlockType.Air;
                    blocks[13, 1, 11].type = BlockType.Air;
                    blocks[1, 1, 12].type = BlockType.Air;
                    blocks[7, 1, 12].type = BlockType.Air;
                    blocks[13, 1, 12].type = BlockType.Air;
                    blocks[1, 1, 13].type = BlockType.Air;
                    blocks[2, 1, 13].type = BlockType.Air;
                    blocks[3, 1, 13].type = BlockType.Air;
                    blocks[4, 1, 13].type = BlockType.Air;
                    blocks[5, 1, 13].type = BlockType.Air;
                    blocks[6, 1, 13].type = BlockType.Air;
                    blocks[7, 1, 13].type = BlockType.Air;
                    blocks[8, 1, 13].type = BlockType.Air;
                    blocks[9, 1, 13].type = BlockType.Air;
                    blocks[10, 1, 13].type = BlockType.Air;
                    blocks[11, 1, 13].type = BlockType.Air;
                    blocks[12, 1, 13].type = BlockType.Air;
                    blocks[13, 1, 13].type = BlockType.Air;
                    blocks[1, 2, 1].type = BlockType.Air;
                    blocks[13, 2, 1].type = BlockType.Air;
                    blocks[1, 2, 13].type = BlockType.Air;
                    blocks[13, 2, 13].type = BlockType.Air;
                    blocks[1, 3, 1].type = BlockType.Air;
                    blocks[13, 3, 1].type = BlockType.Air;
                    blocks[7, 3, 3].type = BlockType.Air;
                    blocks[8, 3, 3].type = BlockType.Air;
                    blocks[9, 3, 3].type = BlockType.Air;
                    blocks[9, 3, 4].type = BlockType.Air;
                    blocks[3, 3, 5].type = BlockType.Air;
                    blocks[4, 3, 5].type = BlockType.Air;
                    blocks[5, 3, 5].type = BlockType.Air;
                    blocks[6, 3, 5].type = BlockType.Air;
                    blocks[7, 3, 5].type = BlockType.Air;
                    blocks[9, 3, 5].type = BlockType.Air;
                    blocks[3, 3, 6].type = BlockType.Air;
                    blocks[7, 3, 6].type = BlockType.Air;
                    blocks[8, 3, 6].type = BlockType.Air;
                    blocks[9, 3, 6].type = BlockType.Air;
                    blocks[3, 3, 7].type = BlockType.Air;
                    blocks[7, 3, 7].type = BlockType.Air;
                    blocks[9, 3, 7].type = BlockType.Air;
                    blocks[11, 3, 7].type = BlockType.Air;
                    blocks[3, 3, 8].type = BlockType.Air;
                    blocks[4, 3, 8].type = BlockType.Air;
                    blocks[5, 3, 8].type = BlockType.Air;
                    blocks[7, 3, 8].type = BlockType.Air;
                    blocks[9, 3, 8].type = BlockType.Air;
                    blocks[11, 3, 8].type = BlockType.Air;
                    blocks[5, 3, 9].type = BlockType.Air;
                    blocks[6, 3, 9].type = BlockType.Air;
                    blocks[7, 3, 9].type = BlockType.Air;
                    blocks[9, 3, 9].type = BlockType.Air;
                    blocks[10, 3, 9].type = BlockType.Air;
                    blocks[11, 3, 9].type = BlockType.Air;
                    blocks[6, 3, 10].type = BlockType.Air;
                    blocks[11, 3, 10].type = BlockType.Air;
                    blocks[6, 3, 11].type = BlockType.Air;
                    blocks[7, 3, 11].type = BlockType.Air;
                    blocks[8, 3, 11].type = BlockType.Air;
                    blocks[9, 3, 11].type = BlockType.Air;
                    blocks[10, 3, 11].type = BlockType.Air;
                    blocks[11, 3, 11].type = BlockType.Exit;
                    blocks[1, 3, 13].type = BlockType.Air;
                    blocks[13, 3, 13].type = BlockType.Air;
                    blocks[1, 4, 1].type = BlockType.Air;
                    blocks[13, 4, 1].type = BlockType.Air;
                    blocks[7, 4, 3].type = BlockType.Air;
                    blocks[7, 4, 4].type = BlockType.Air;
                    blocks[7, 4, 5].type = BlockType.Air;
                    blocks[3, 4, 7].type = BlockType.Air;
                    blocks[4, 4, 7].type = BlockType.Air;
                    blocks[5, 4, 7].type = BlockType.Air;
                    blocks[7, 4, 7].type = BlockType.Air;
                    blocks[9, 4, 7].type = BlockType.Air;
                    blocks[10, 4, 7].type = BlockType.Air;
                    blocks[11, 4, 7].type = BlockType.Air;
                    blocks[7, 4, 9].type = BlockType.Air;
                    blocks[7, 4, 10].type = BlockType.Air;
                    blocks[7, 4, 11].type = BlockType.Air;
                    blocks[1, 4, 13].type = BlockType.Air;
                    blocks[13, 4, 13].type = BlockType.Air;
                    blocks[1, 5, 1].type = BlockType.Air;
                    blocks[13, 5, 1].type = BlockType.Air;
                    blocks[7, 5, 5].type = BlockType.Air;
                    blocks[5, 5, 7].type = BlockType.Air;
                    blocks[7, 5, 7].type = BlockType.Air;
                    blocks[9, 5, 7].type = BlockType.Air;
                    blocks[7, 5, 9].type = BlockType.Air;
                    blocks[1, 5, 13].type = BlockType.Air;
                    blocks[13, 5, 13].type = BlockType.Air;
                    blocks[1, 5, 1].type = BlockType.Air;
                    blocks[13, 5, 1].type = BlockType.Air;
                    blocks[5, 5, 7].type = BlockType.Air;
                    blocks[7, 5, 7].type = BlockType.Air;
                    blocks[9, 5, 7].type = BlockType.Air;
                    blocks[7, 5, 9].type = BlockType.Air;
                    blocks[1, 5, 13].type = BlockType.Air;
                    blocks[13, 5, 13].type = BlockType.Air;
                    blocks[1, 6, 1].type = BlockType.Air;
                    blocks[13, 6, 1].type = BlockType.Air;
                    blocks[7, 6, 5].type = BlockType.Air;
                    blocks[5, 6, 7].type = BlockType.Air;
                    blocks[9, 6, 7].type = BlockType.Air;
                    blocks[7, 6, 9].type = BlockType.Air;
                    blocks[1, 6, 13].type = BlockType.Air;
                    blocks[13, 6, 13].type = BlockType.Air;
                    blocks[1, 7, 1].type = BlockType.Air;
                    blocks[13, 7, 1].type = BlockType.Air;
                    blocks[7, 7, 5].type = BlockType.Air;
                    blocks[5, 7, 7].type = BlockType.Air;
                    blocks[7, 7, 7].type = BlockType.Air;
                    blocks[9, 7, 7].type = BlockType.Air;
                    blocks[1, 7, 13].type = BlockType.Air;
                    blocks[13, 7, 13].type = BlockType.Air;
                    blocks[1, 8, 1].type = BlockType.Air;
                    blocks[13, 8, 1].type = BlockType.Air;
                    blocks[7, 8, 5].type = BlockType.Air;
                    blocks[5, 8, 7].type = BlockType.Air;
                    blocks[7, 8, 7].type = BlockType.Air;
                    blocks[7, 8, 9].type = BlockType.Air;
                    blocks[1, 8, 13].type = BlockType.Air;
                    blocks[13, 8, 13].type = BlockType.Air;
                    blocks[1, 9, 1].type = BlockType.Air;
                    blocks[13, 9, 1].type = BlockType.Air;
                    blocks[7, 9, 5].type = BlockType.Air;
                    blocks[5, 9, 7].type = BlockType.Air;
                    blocks[7, 9, 7].type = BlockType.Air;
                    blocks[9, 9, 7].type = BlockType.Air;
                    blocks[7, 9, 9].type = BlockType.Air;
                    blocks[1, 9, 13].type = BlockType.Air;
                    blocks[13, 9, 13].type = BlockType.Air;
                    blocks[1, 10, 1].type = BlockType.Air;
                    blocks[7, 10, 1].type = BlockType.Air;
                    blocks[13, 10, 1].type = BlockType.Air;
                    blocks[7, 10, 2].type = BlockType.Air;
                    blocks[7, 10, 3].type = BlockType.Air;
                    blocks[7, 10, 4].type = BlockType.Air;
                    blocks[7, 10, 5].type = BlockType.Air;
                    blocks[1, 10, 7].type = BlockType.Air;
                    blocks[2, 10, 7].type = BlockType.Air;
                    blocks[3, 10, 7].type = BlockType.Air;
                    blocks[4, 10, 7].type = BlockType.Air;
                    blocks[5, 10, 7].type = BlockType.Air;
                    blocks[7, 10, 7].type = BlockType.Air;
                    blocks[9, 10, 7].type = BlockType.Air;
                    blocks[10, 10, 7].type = BlockType.Air;
                    blocks[11, 10, 7].type = BlockType.Air;
                    blocks[12, 10, 7].type = BlockType.Air;
                    blocks[13, 10, 7].type = BlockType.Air;
                    blocks[7, 10, 9].type = BlockType.Air;
                    blocks[7, 10, 10].type = BlockType.Air;
                    blocks[7, 10, 11].type = BlockType.Air;
                    blocks[7, 10, 12].type = BlockType.Air;
                    blocks[1, 10, 13].type = BlockType.Air;
                    blocks[7, 10, 13].type = BlockType.Air;
                    blocks[13, 10, 13].type = BlockType.Air;
                    blocks[1, 11, 1].type = BlockType.Air;
                    blocks[7, 11, 1].type = BlockType.Air;
                    blocks[13, 11, 1].type = BlockType.Air;
                    blocks[1, 11, 7].type = BlockType.Air;
                    blocks[7, 11, 7].type = BlockType.Air;
                    blocks[13, 11, 7].type = BlockType.Air;
                    blocks[1, 11, 13].type = BlockType.Air;
                    blocks[7, 11, 13].type = BlockType.Air;
                    blocks[13, 11, 13].type = BlockType.Air;
                    blocks[1, 12, 1].type = BlockType.Air;
                    blocks[2, 12, 1].type = BlockType.Air;
                    blocks[3, 12, 1].type = BlockType.Air;
                    blocks[4, 12, 1].type = BlockType.Air;
                    blocks[5, 12, 1].type = BlockType.Air;
                    blocks[6, 12, 1].type = BlockType.Air;
                    blocks[7, 12, 1].type = BlockType.Air;
                    blocks[8, 12, 1].type = BlockType.Air;
                    blocks[9, 12, 1].type = BlockType.Air;
                    blocks[10, 12, 1].type = BlockType.Air;
                    blocks[11, 12, 1].type = BlockType.Air;
                    blocks[12, 12, 1].type = BlockType.Air;
                    blocks[13, 12, 1].type = BlockType.Air;
                    blocks[1, 12, 2].type = BlockType.Air;
                    blocks[7, 12, 2].type = BlockType.Air;
                    blocks[13, 12, 2].type = BlockType.Air;
                    blocks[1, 12, 3].type = BlockType.Air;
                    blocks[7, 12, 3].type = BlockType.Air;
                    blocks[13, 12, 3].type = BlockType.Air;
                    blocks[1, 12, 4].type = BlockType.Air;
                    blocks[7, 12, 4].type = BlockType.Air;
                    blocks[13, 12, 4].type = BlockType.Air;
                    blocks[1, 12, 5].type = BlockType.Air;
                    blocks[7, 12, 5].type = BlockType.Air;
                    blocks[13, 12, 5].type = BlockType.Air;
                    blocks[1, 12, 6].type = BlockType.Air;
                    blocks[7, 12, 6].type = BlockType.Air;
                    blocks[13, 12, 6].type = BlockType.Air;
                    blocks[1, 12, 7].type = BlockType.Air;
                    blocks[2, 12, 7].type = BlockType.Air;
                    blocks[3, 12, 7].type = BlockType.Air;
                    blocks[4, 12, 7].type = BlockType.Air;
                    blocks[5, 12, 7].type = BlockType.Air;
                    blocks[6, 12, 7].type = BlockType.Air;
                    blocks[7, 12, 7].type = BlockType.Air;
                    blocks[8, 12, 7].type = BlockType.Air;
                    blocks[9, 12, 7].type = BlockType.Air;
                    blocks[10, 12, 7].type = BlockType.Air;
                    blocks[11, 12, 7].type = BlockType.Air;
                    blocks[12, 12, 7].type = BlockType.Air;
                    blocks[13, 12, 7].type = BlockType.Air;
                    blocks[1, 12, 8].type = BlockType.Air;
                    blocks[7, 12, 8].type = BlockType.Air;
                    blocks[13, 12, 8].type = BlockType.Air;
                    blocks[1, 12, 9].type = BlockType.Air;
                    blocks[7, 12, 9].type = BlockType.Air;
                    blocks[13, 12, 9].type = BlockType.Air;
                    blocks[1, 12, 10].type = BlockType.Air;
                    blocks[7, 12, 10].type = BlockType.Air;
                    blocks[13, 12, 10].type = BlockType.Air;
                    blocks[1, 12, 11].type = BlockType.Air;
                    blocks[7, 12, 11].type = BlockType.Air;
                    blocks[13, 12, 11].type = BlockType.Air;
                    blocks[1, 12, 12].type = BlockType.Air;
                    blocks[7, 12, 12].type = BlockType.Air;
                    blocks[13, 12, 12].type = BlockType.Air;
                    blocks[1, 12, 13].type = BlockType.Air;
                    blocks[2, 12, 13].type = BlockType.Air;
                    blocks[3, 12, 13].type = BlockType.Air;
                    blocks[4, 12, 13].type = BlockType.Air;
                    blocks[5, 12, 13].type = BlockType.Air;
                    blocks[6, 12, 13].type = BlockType.Air;
                    blocks[7, 12, 13].type = BlockType.Air;
                    blocks[8, 12, 13].type = BlockType.Air;
                    blocks[9, 12, 13].type = BlockType.Air;
                    blocks[10, 12, 13].type = BlockType.Air;
                    blocks[11, 12, 13].type = BlockType.Air;
                    blocks[12, 12, 13].type = BlockType.Air;
                    blocks[13, 12, 13].type = BlockType.Air;
                }
                break;
            case 7:
                {
                    for (int x = 1; x <= 13; x++)
                        for (int y = 2; y <= 13; y += 2)
                            for (int z = 1; z <= 13; z++)
                                blocks[x, y, z].type = BlockType.Glass;
                    blocks[1, 1, 1].type = BlockType.Start;
                    blocks[2, 1, 1].type = BlockType.Air;
                    blocks[3, 1, 1].type = BlockType.Air;
                    blocks[4, 1, 1].type = BlockType.Air;
                    blocks[5, 1, 1].type = BlockType.Air;
                    blocks[7, 1, 1].type = BlockType.Air;
                    blocks[8, 1, 1].type = BlockType.Air;
                    blocks[9, 1, 1].type = BlockType.Air;
                    blocks[10, 1, 1].type = BlockType.Air;
                    blocks[11, 1, 1].type = BlockType.Air;
                    blocks[12, 1, 1].type = BlockType.Air;
                    blocks[13, 1, 1].type = BlockType.Air;
                    blocks[1, 1, 2].type = BlockType.Air;
                    blocks[5, 1, 2].type = BlockType.Air;
                    blocks[7, 1, 2].type = BlockType.Air;
                    blocks[9, 1, 2].type = BlockType.Air;
                    blocks[1, 1, 3].type = BlockType.Air;
                    blocks[2, 1, 3].type = BlockType.Air;
                    blocks[3, 1, 3].type = BlockType.Air;
                    blocks[5, 1, 3].type = BlockType.Air;
                    blocks[7, 1, 3].type = BlockType.Air;
                    blocks[9, 1, 3].type = BlockType.Air;
                    blocks[10, 1, 3].type = BlockType.Air;
                    blocks[11, 1, 3].type = BlockType.Air;
                    blocks[12, 1, 3].type = BlockType.Air;
                    blocks[13, 1, 3].type = BlockType.Air;
                    blocks[2, 1, 4].type = BlockType.Air;
                    blocks[5, 1, 4].type = BlockType.Air;
                    blocks[7, 1, 4].type = BlockType.Air;
                    blocks[9, 1, 4].type = BlockType.Air;
                    blocks[1, 1, 5].type = BlockType.Air;
                    blocks[2, 1, 5].type = BlockType.Air;
                    blocks[4, 1, 5].type = BlockType.Air;
                    blocks[5, 1, 5].type = BlockType.Air;
                    blocks[9, 1, 5].type = BlockType.Air;
                    blocks[11, 1, 5].type = BlockType.Air;
                    blocks[12, 1, 5].type = BlockType.Air;
                    blocks[13, 1, 5].type = BlockType.Air;
                    blocks[1, 1, 6].type = BlockType.Air;
                    blocks[7, 1, 6].type = BlockType.Air;
                    blocks[8, 1, 6].type = BlockType.Air;
                    blocks[9, 1, 6].type = BlockType.Air;
                    blocks[13, 1, 6].type = BlockType.Air;
                    blocks[1, 1, 7].type = BlockType.Air;
                    blocks[3, 1, 7].type = BlockType.Air;
                    blocks[4, 1, 7].type = BlockType.Air;
                    blocks[5, 1, 7].type = BlockType.Air;
                    blocks[7, 1, 7].type = BlockType.Air;
                    blocks[11, 1, 7].type = BlockType.Air;
                    blocks[12, 1, 7].type = BlockType.Air;
                    blocks[13, 1, 7].type = BlockType.Air;
                    blocks[1, 1, 8].type = BlockType.Air;
                    blocks[2, 1, 8].type = BlockType.Air;
                    blocks[3, 1, 8].type = BlockType.Air;
                    blocks[5, 1, 8].type = BlockType.Air;
                    blocks[6, 1, 8].type = BlockType.Air;
                    blocks[7, 1, 8].type = BlockType.Air;
                    blocks[9, 1, 8].type = BlockType.Air;
                    blocks[11, 1, 8].type = BlockType.Air;
                    blocks[1, 1, 9].type = BlockType.Air;
                    blocks[7, 1, 9].type = BlockType.Air;
                    blocks[8, 1, 9].type = BlockType.Air;
                    blocks[9, 1, 9].type = BlockType.Air;
                    blocks[11, 1, 9].type = BlockType.Air;
                    blocks[13, 1, 9].type = BlockType.Air;
                    blocks[1, 1, 10].type = BlockType.Air;
                    blocks[3, 1, 10].type = BlockType.Air;
                    blocks[4, 1, 10].type = BlockType.Air;
                    blocks[5, 1, 10].type = BlockType.Air;
                    blocks[11, 1, 10].type = BlockType.Air;
                    blocks[12, 1, 10].type = BlockType.Air;
                    blocks[13, 1, 10].type = BlockType.Air;
                    blocks[1, 1, 11].type = BlockType.Air;
                    blocks[3, 1, 11].type = BlockType.Air;
                    blocks[5, 1, 11].type = BlockType.Air;
                    blocks[6, 1, 11].type = BlockType.Air;
                    blocks[7, 1, 11].type = BlockType.Air;
                    blocks[8, 1, 11].type = BlockType.Air;
                    blocks[9, 1, 11].type = BlockType.Air;
                    blocks[11, 1, 11].type = BlockType.Air;
                    blocks[13, 1, 11].type = BlockType.Air;
                    blocks[3, 1, 12].type = BlockType.Air;
                    blocks[5, 1, 12].type = BlockType.Air;
                    blocks[9, 1, 12].type = BlockType.Air;
                    blocks[11, 1, 12].type = BlockType.Air;
                    blocks[13, 1, 12].type = BlockType.Air;
                    blocks[1, 1, 13].type = BlockType.Air;
                    blocks[2, 1, 13].type = BlockType.Air;
                    blocks[3, 1, 13].type = BlockType.Air;
                    blocks[5, 1, 13].type = BlockType.Air;
                    blocks[6, 1, 13].type = BlockType.Air;
                    blocks[7, 1, 13].type = BlockType.Air;
                    blocks[9, 1, 13].type = BlockType.Air;
                    blocks[10, 1, 13].type = BlockType.Air;
                    blocks[11, 1, 13].type = BlockType.Air;
                    blocks[13, 1, 13].type = BlockType.Exit;
                    blocks[13, 2, 1].type = BlockType.Air;
                    blocks[7, 2, 7].type = BlockType.Air;
                    blocks[1, 2, 13].type = BlockType.Air;
                    blocks[1, 3, 1].type = BlockType.Air;
                    blocks[3, 3, 1].type = BlockType.Air;
                    blocks[4, 3, 1].type = BlockType.Air;
                    blocks[5, 3, 1].type = BlockType.Air;
                    blocks[6, 3, 1].type = BlockType.Air;
                    blocks[7, 3, 1].type = BlockType.Air;
                    blocks[9, 3, 1].type = BlockType.Air;
                    blocks[10, 3, 1].type = BlockType.Air;
                    blocks[11, 3, 1].type = BlockType.Air;
                    blocks[12, 3, 1].type = BlockType.Air;
                    blocks[13, 3, 1].type = BlockType.Air;
                    blocks[1, 3, 2].type = BlockType.Air;
                    blocks[3, 3, 2].type = BlockType.Air;
                    blocks[7, 3, 2].type = BlockType.Air;
                    blocks[8, 3, 2].type = BlockType.Air;
                    blocks[9, 3, 2].type = BlockType.Air;
                    blocks[13, 3, 2].type = BlockType.Air;
                    blocks[1, 3, 3].type = BlockType.Air;
                    blocks[3, 3, 3].type = BlockType.Air;
                    blocks[5, 3, 3].type = BlockType.Air;
                    blocks[11, 3, 3].type = BlockType.Air;
                    blocks[13, 3, 3].type = BlockType.Air;
                    blocks[1, 3, 4].type = BlockType.Air;
                    blocks[2, 3, 4].type = BlockType.Air;
                    blocks[3, 3, 4].type = BlockType.Air;
                    blocks[5, 3, 4].type = BlockType.Air;
                    blocks[7, 3, 4].type = BlockType.Air;
                    blocks[8, 3, 4].type = BlockType.Air;
                    blocks[9, 3, 4].type = BlockType.Air;
                    blocks[11, 3, 4].type = BlockType.Air;
                    blocks[3, 3, 5].type = BlockType.Air;
                    blocks[5, 3, 5].type = BlockType.Air;
                    blocks[7, 3, 5].type = BlockType.Air;
                    blocks[9, 3, 5].type = BlockType.Air;
                    blocks[11, 3, 5].type = BlockType.Air;
                    blocks[12, 3, 5].type = BlockType.Air;
                    blocks[13, 3, 5].type = BlockType.Air;
                    blocks[1, 3, 6].type = BlockType.Air;
                    blocks[5, 3, 6].type = BlockType.Air;
                    blocks[9, 3, 6].type = BlockType.Air;
                    blocks[13, 3, 6].type = BlockType.Air;
                    blocks[1, 3, 7].type = BlockType.Air;
                    blocks[3, 3, 7].type = BlockType.Air;
                    blocks[5, 3, 7].type = BlockType.Air;
                    blocks[6, 3, 7].type = BlockType.Air;
                    blocks[7, 3, 7].type = BlockType.Air;
                    blocks[8, 3, 7].type = BlockType.Air;
                    blocks[9, 3, 7].type = BlockType.Air;
                    blocks[11, 3, 7].type = BlockType.Air;
                    blocks[13, 3, 7].type = BlockType.Air;
                    blocks[1, 3, 8].type = BlockType.Air;
                    blocks[3, 3, 8].type = BlockType.Air;
                    blocks[7, 3, 8].type = BlockType.Air;
                    blocks[11, 3, 8].type = BlockType.Air;
                    blocks[13, 3, 8].type = BlockType.Air;
                    blocks[1, 3, 9].type = BlockType.Air;
                    blocks[2, 3, 9].type = BlockType.Air;
                    blocks[3, 3, 9].type = BlockType.Air;
                    blocks[4, 3, 9].type = BlockType.Air;
                    blocks[5, 3, 9].type = BlockType.Air;
                    blocks[7, 3, 9].type = BlockType.Air;
                    blocks[8, 3, 9].type = BlockType.Air;
                    blocks[9, 3, 9].type = BlockType.Air;
                    blocks[11, 3, 9].type = BlockType.Air;
                    blocks[12, 3, 9].type = BlockType.Air;
                    blocks[13, 3, 9].type = BlockType.Air;
                    blocks[1, 3, 10].type = BlockType.Air;
                    blocks[3, 3, 10].type = BlockType.Air;
                    blocks[5, 3, 10].type = BlockType.Air;
                    blocks[11, 3, 10].type = BlockType.Air;
                    blocks[13, 3, 10].type = BlockType.Air;
                    blocks[1, 3, 11].type = BlockType.Air;
                    blocks[3, 3, 11].type = BlockType.Air;
                    blocks[5, 3, 11].type = BlockType.Air;
                    blocks[6, 3, 11].type = BlockType.Air;
                    blocks[7, 3, 11].type = BlockType.Air;
                    blocks[9, 3, 11].type = BlockType.Air;
                    blocks[10, 3, 11].type = BlockType.Air;
                    blocks[11, 3, 11].type = BlockType.Air;
                    blocks[13, 3, 11].type = BlockType.Air;
                    blocks[3, 3, 12].type = BlockType.Air;
                    blocks[7, 3, 12].type = BlockType.Air;
                    blocks[9, 3, 12].type = BlockType.Air;
                    blocks[13, 3, 12].type = BlockType.Air;
                    blocks[1, 3, 13].type = BlockType.Air;
                    blocks[2, 3, 13].type = BlockType.Air;
                    blocks[3, 3, 13].type = BlockType.Air;
                    blocks[4, 3, 13].type = BlockType.Air;
                    blocks[5, 3, 13].type = BlockType.Air;
                    blocks[7, 3, 13].type = BlockType.Air;
                    blocks[8, 3, 13].type = BlockType.Air;
                    blocks[9, 3, 13].type = BlockType.Air;
                    blocks[11, 3, 13].type = BlockType.Air;
                    blocks[12, 3, 13].type = BlockType.Air;
                    blocks[13, 3, 13].type = BlockType.Air;
                    blocks[1, 4, 1].type = BlockType.Air;
                    blocks[5, 4, 5].type = BlockType.Air;
                    blocks[9, 4, 5].type = BlockType.Air;
                    blocks[5, 4, 9].type = BlockType.Air;
                    blocks[9, 4, 9].type = BlockType.Air;
                    blocks[13, 4, 13].type = BlockType.Air;
                    blocks[1, 5, 1].type = BlockType.Air;
                    blocks[2, 5, 1].type = BlockType.Air;
                    blocks[3, 5, 1].type = BlockType.Air;
                    blocks[5, 5, 1].type = BlockType.Air;
                    blocks[6, 5, 1].type = BlockType.Air;
                    blocks[7, 5, 1].type = BlockType.Air;
                    blocks[9, 5, 1].type = BlockType.Air;
                    blocks[10, 5, 1].type = BlockType.Air;
                    blocks[11, 5, 1].type = BlockType.Air;
                    blocks[12, 5, 1].type = BlockType.Air;
                    blocks[13, 5, 1].type = BlockType.Air;
                    blocks[3, 5, 2].type = BlockType.Air;
                    blocks[5, 5, 2].type = BlockType.Air;
                    blocks[7, 5, 2].type = BlockType.Air;
                    blocks[11, 5, 2].type = BlockType.Air;
                    blocks[13, 5, 2].type = BlockType.Air;
                    blocks[1, 5, 3].type = BlockType.Air;
                    blocks[2, 5, 3].type = BlockType.Air;
                    blocks[3, 5, 3].type = BlockType.Air;
                    blocks[4, 5, 3].type = BlockType.Air;
                    blocks[5, 5, 3].type = BlockType.Air;
                    blocks[7, 5, 3].type = BlockType.Air;
                    blocks[9, 5, 3].type = BlockType.Air;
                    blocks[10, 5, 3].type = BlockType.Air;
                    blocks[11, 5, 3].type = BlockType.Air;
                    blocks[1, 5, 4].type = BlockType.Air;
                    blocks[7, 5, 4].type = BlockType.Air;
                    blocks[9, 5, 4].type = BlockType.Air;
                    blocks[13, 5, 4].type = BlockType.Air;
                    blocks[1, 5, 5].type = BlockType.Air;
                    blocks[3, 5, 5].type = BlockType.Air;
                    blocks[4, 5, 5].type = BlockType.Air;
                    blocks[5, 5, 5].type = BlockType.Air;
                    blocks[7, 5, 5].type = BlockType.Air;
                    blocks[9, 5, 5].type = BlockType.Air;
                    blocks[11, 5, 5].type = BlockType.Air;
                    blocks[13, 5, 5].type = BlockType.Air;
                    blocks[1, 5, 6].type = BlockType.Air;
                    blocks[7, 5, 6].type = BlockType.Air;
                    blocks[11, 5, 6].type = BlockType.Air;
                    blocks[13, 5, 6].type = BlockType.Air;
                    blocks[1, 5, 7].type = BlockType.Air;
                    blocks[3, 5, 7].type = BlockType.Air;
                    blocks[4, 5, 7].type = BlockType.Air;
                    blocks[5, 5, 7].type = BlockType.Air;
                    blocks[6, 5, 7].type = BlockType.Air;
                    blocks[7, 5, 7].type = BlockType.Air;
                    blocks[9, 5, 7].type = BlockType.Air;
                    blocks[10, 5, 7].type = BlockType.Air;
                    blocks[11, 5, 7].type = BlockType.Air;
                    blocks[13, 5, 7].type = BlockType.Air;
                    blocks[3, 5, 8].type = BlockType.Air;
                    blocks[9, 5, 8].type = BlockType.Air;
                    blocks[13, 5, 8].type = BlockType.Air;
                    blocks[1, 5, 9].type = BlockType.Air;
                    blocks[2, 5, 9].type = BlockType.Air;
                    blocks[3, 5, 9].type = BlockType.Air;
                    blocks[5, 5, 9].type = BlockType.Air;
                    blocks[6, 5, 9].type = BlockType.Air;
                    blocks[7, 5, 9].type = BlockType.Air;
                    blocks[8, 5, 9].type = BlockType.Air;
                    blocks[9, 5, 9].type = BlockType.Air;
                    blocks[11, 5, 9].type = BlockType.Air;
                    blocks[12, 5, 9].type = BlockType.Air;
                    blocks[13, 5, 9].type = BlockType.Air;
                    blocks[3, 5, 10].type = BlockType.Air;
                    blocks[7, 5, 10].type = BlockType.Air;
                    blocks[11, 5, 10].type = BlockType.Air;
                    blocks[13, 5, 10].type = BlockType.Air;
                    blocks[1, 5, 11].type = BlockType.Air;
                    blocks[3, 5, 11].type = BlockType.Air;
                    blocks[4, 5, 11].type = BlockType.Air;
                    blocks[5, 5, 11].type = BlockType.Air;
                    blocks[7, 5, 11].type = BlockType.Air;
                    blocks[9, 5, 11].type = BlockType.Air;
                    blocks[10, 5, 11].type = BlockType.Air;
                    blocks[11, 5, 11].type = BlockType.Air;
                    blocks[13, 5, 11].type = BlockType.Air;
                    blocks[1, 5, 12].type = BlockType.Air;
                    blocks[5, 5, 12].type = BlockType.Air;
                    blocks[9, 5, 12].type = BlockType.Air;
                    blocks[11, 5, 12].type = BlockType.Air;
                    blocks[13, 5, 12].type = BlockType.Air;
                    blocks[1, 5, 13].type = BlockType.Air;
                    blocks[2, 5, 13].type = BlockType.Air;
                    blocks[3, 5, 13].type = BlockType.Air;
                    blocks[4, 5, 13].type = BlockType.Air;
                    blocks[5, 5, 13].type = BlockType.Air;
                    blocks[6, 5, 13].type = BlockType.Air;
                    blocks[7, 5, 13].type = BlockType.Air;
                    blocks[8, 5, 13].type = BlockType.Air;
                    blocks[9, 5, 13].type = BlockType.Air;
                    blocks[11, 5, 13].type = BlockType.Air;
                    blocks[13, 5, 13].type = BlockType.Air;
                
}
                break;
            case 8:
                {
                    blocks[1, 1, 1].type = BlockType.Start;
                    blocks[2, 1, 1].type = BlockType.Air;
                    blocks[3, 1, 1].type = BlockType.Air;
                    blocks[4, 1, 1].type = BlockType.Air;
                    blocks[5, 1, 1].type = BlockType.Air;
                    blocks[6, 1, 1].type = BlockType.Air;
                    blocks[7, 1, 1].type = BlockType.Air;
                    blocks[7, 1, 2].type = BlockType.Air;
                    blocks[7, 1, 3].type = BlockType.Air;
                    blocks[7, 1, 5].type = BlockType.Air;
                    blocks[7, 1, 6].type = BlockType.Air;
                    blocks[7, 1, 7].type = BlockType.Air;
                    blocks[7, 1, 8].type = BlockType.Air;
                    blocks[7, 1, 9].type = BlockType.Air;
                    blocks[7, 1, 10].type = BlockType.Air;
                    blocks[7, 1, 11].type = BlockType.Air;
                    blocks[7, 1, 13].type = BlockType.Air;
                    blocks[8, 1, 13].type = BlockType.Air;
                    blocks[9, 1, 13].type = BlockType.Air;
                    blocks[10, 1, 13].type = BlockType.Air;
                    blocks[11, 1, 13].type = BlockType.Air;
                    blocks[12, 1, 13].type = BlockType.Air;
                    blocks[13, 1, 13].type = BlockType.Exit;
                    blocks[7, 2, 3].type = BlockType.Air;
                    blocks[7, 2, 4].type = BlockType.Air;
                    blocks[1, 2, 5].type = BlockType.Air;
                    blocks[2, 2, 5].type = BlockType.Air;
                    blocks[3, 2, 5].type = BlockType.Air;
                    blocks[4, 2, 5].type = BlockType.Air;
                    blocks[5, 2, 5].type = BlockType.Air;
                    blocks[7, 2, 5].type = BlockType.Air;
                    blocks[9, 2, 5].type = BlockType.Air;
                    blocks[10, 2, 5].type = BlockType.Air;
                    blocks[11, 2, 5].type = BlockType.Air;
                    blocks[12, 2, 5].type = BlockType.Air;
                    blocks[13, 2, 5].type = BlockType.Air;
                    blocks[1, 2, 6].type = BlockType.Air;
                    blocks[5, 2, 6].type = BlockType.Air;
                    blocks[9, 2, 6].type = BlockType.Air;
                    blocks[1, 2, 7].type = BlockType.Air;
                    blocks[2, 2, 7].type = BlockType.Air;
                    blocks[3, 2, 7].type = BlockType.Air;
                    blocks[4, 2, 7].type = BlockType.Air;
                    blocks[5, 2, 7].type = BlockType.Air;
                    blocks[9, 2, 7].type = BlockType.Air;
                    blocks[12, 2, 7].type = BlockType.Air;
                    blocks[13, 2, 7].type = BlockType.Air;
                    blocks[1, 2, 8].type = BlockType.Air;
                    blocks[9, 2, 8].type = BlockType.Air;
                    blocks[13, 2, 8].type = BlockType.Air;
                    blocks[1, 2, 9].type = BlockType.Air;
                    blocks[9, 2, 9].type = BlockType.Air;
                    blocks[10, 2, 9].type = BlockType.Air;
                    blocks[11, 2, 9].type = BlockType.Air;
                    blocks[12, 2, 9].type = BlockType.Air;
                    blocks[13, 2, 9].type = BlockType.Air;
                    blocks[7, 2, 11].type = BlockType.Air;
                    blocks[7, 2, 13].type = BlockType.Air;
                    blocks[7, 3, 1].type = BlockType.Air;
                    blocks[7, 3, 2].type = BlockType.Air;
                    blocks[7, 3, 3].type = BlockType.Air;
                    blocks[7, 3, 5].type = BlockType.Air;
                    blocks[7, 3, 7].type = BlockType.Air;
                    blocks[7, 3, 8].type = BlockType.Air;
                    blocks[7, 3, 9].type = BlockType.Air;
                    blocks[7, 3, 11].type = BlockType.Air;
                    blocks[7, 3, 13].type = BlockType.Air;
                    blocks[7, 4, 1].type = BlockType.Air;
                    blocks[1, 4, 5].type = BlockType.Air;
                    blocks[2, 4, 5].type = BlockType.Air;
                    blocks[3, 4, 5].type = BlockType.Air;
                    blocks[4, 4, 5].type = BlockType.Air;
                    blocks[5, 4, 5].type = BlockType.Air;
                    blocks[7, 4, 5].type = BlockType.Air;
                    blocks[9, 4, 5].type = BlockType.Air;
                    blocks[10, 4, 5].type = BlockType.Air;
                    blocks[11, 4, 5].type = BlockType.Air;
                    blocks[12, 4, 5].type = BlockType.Air;
                    blocks[13, 4, 5].type = BlockType.Air;
                    blocks[3, 4, 6].type = BlockType.Air;
                    blocks[9, 4, 6].type = BlockType.Air;
                    blocks[13, 4, 6].type = BlockType.Air;
                    blocks[3, 4, 7].type = BlockType.Air;
                    blocks[7, 4, 7].type = BlockType.Air;
                    blocks[9, 4, 7].type = BlockType.Air;
                    blocks[13, 4, 7].type = BlockType.Air;
                    blocks[3, 4, 8].type = BlockType.Air;
                    blocks[9, 4, 8].type = BlockType.Air;
                    blocks[10, 4, 8].type = BlockType.Air;
                    blocks[11, 4, 8].type = BlockType.Air;
                    blocks[12, 4, 8].type = BlockType.Air;
                    blocks[13, 4, 8].type = BlockType.Air;
                    blocks[1, 4, 9].type = BlockType.Air;
                    blocks[2, 4, 9].type = BlockType.Air;
                    blocks[3, 4, 9].type = BlockType.Air;
                    blocks[4, 4, 9].type = BlockType.Air;
                    blocks[5, 4, 9].type = BlockType.Air;
                    blocks[7, 4, 9].type = BlockType.Air;
                    blocks[9, 4, 9].type = BlockType.Air;
                    blocks[13, 4, 9].type = BlockType.Air;
                    blocks[7, 4, 13].type = BlockType.Air;
                    blocks[7, 5, 1].type = BlockType.Air;
                    blocks[7, 5, 3].type = BlockType.Air;
                    blocks[7, 5, 4].type = BlockType.Air;
                    blocks[7, 5, 5].type = BlockType.Air;
                    blocks[7, 5, 6].type = BlockType.Air;
                    blocks[7, 5, 7].type = BlockType.Air;
                    blocks[7, 5, 9].type = BlockType.Air;
                    blocks[7, 5, 11].type = BlockType.Air;
                    blocks[7, 5, 12].type = BlockType.Air;
                    blocks[7, 5, 13].type = BlockType.Air;
                    blocks[7, 6, 1].type = BlockType.Air;
                    blocks[7, 6, 3].type = BlockType.Air;
                    blocks[1, 6, 5].type = BlockType.Air;
                    blocks[2, 6, 5].type = BlockType.Air;
                    blocks[3, 6, 5].type = BlockType.Air;
                    blocks[4, 6, 5].type = BlockType.Air;
                    blocks[5, 6, 5].type = BlockType.Air;
                    blocks[9, 6, 5].type = BlockType.Air;
                    blocks[13, 6, 5].type = BlockType.Air;
                    blocks[1, 6, 6].type = BlockType.Air;
                    blocks[5, 6, 6].type = BlockType.Air;
                    blocks[9, 6, 6].type = BlockType.Air;
                    blocks[10, 6, 6].type = BlockType.Air;
                    blocks[12, 6, 6].type = BlockType.Air;
                    blocks[13, 6, 6].type = BlockType.Air;
                    blocks[1, 6, 7].type = BlockType.Air;
                    blocks[2, 6, 7].type = BlockType.Air;
                    blocks[3, 6, 7].type = BlockType.Air;
                    blocks[4, 6, 7].type = BlockType.Air;
                    blocks[5, 6, 7].type = BlockType.Air;
                    blocks[9, 6, 7].type = BlockType.Air;
                    blocks[11, 6, 7].type = BlockType.Air;
                    blocks[13, 6, 7].type = BlockType.Air;
                    blocks[1, 6, 8].type = BlockType.Air;
                    blocks[9, 6, 8].type = BlockType.Air;
                    blocks[13, 6, 8].type = BlockType.Air;
                    blocks[1, 6, 9].type = BlockType.Air;
                    blocks[7, 6, 9].type = BlockType.Air;
                    blocks[9, 6, 9].type = BlockType.Air;
                    blocks[13, 6, 9].type = BlockType.Air;
                    blocks[7, 6, 11].type = BlockType.Air;
                    blocks[7, 7, 1].type = BlockType.Air;
                    blocks[7, 7, 3].type = BlockType.Air;
                    blocks[7, 7, 5].type = BlockType.Air;
                    blocks[7, 7, 6].type = BlockType.Air;
                    blocks[7, 7, 7].type = BlockType.Air;
                    blocks[7, 7, 8].type = BlockType.Air;
                    blocks[7, 7, 9].type = BlockType.Air;
                    blocks[7, 7, 11].type = BlockType.Air;
                    blocks[7, 7, 12].type = BlockType.Air;
                    blocks[7, 7, 13].type = BlockType.Air;
                    blocks[1, 8, 5].type = BlockType.Air;
                    blocks[5, 8, 5].type = BlockType.Air;
                    blocks[9, 8, 5].type = BlockType.Air;
                    blocks[10, 8, 5].type = BlockType.Air;
                    blocks[11, 8, 5].type = BlockType.Air;
                    blocks[12, 8, 5].type = BlockType.Air;
                    blocks[13, 8, 5].type = BlockType.Air;
                    blocks[1, 8, 6].type = BlockType.Air;
                    blocks[4, 8, 6].type = BlockType.Air;
                    blocks[9, 8, 6].type = BlockType.Air;
                    blocks[1, 8, 7].type = BlockType.Air;
                    blocks[2, 8, 7].type = BlockType.Air;
                    blocks[3, 8, 7].type = BlockType.Air;
                    blocks[9, 8, 7].type = BlockType.Air;
                    blocks[10, 8, 7].type = BlockType.Air;
                    blocks[11, 8, 7].type = BlockType.Air;
                    blocks[1, 8, 8].type = BlockType.Air;
                    blocks[4, 8, 8].type = BlockType.Air;
                    blocks[7, 8, 8].type = BlockType.Air;
                    blocks[9, 8, 8].type = BlockType.Air;
                    blocks[1, 8, 9].type = BlockType.Air;
                    blocks[5, 8, 9].type = BlockType.Air;
                    blocks[9, 8, 9].type = BlockType.Air;
                    blocks[10, 8, 9].type = BlockType.Air;
                    blocks[11, 8, 9].type = BlockType.Air;
                    blocks[12, 8, 9].type = BlockType.Air;
                    blocks[13, 8, 9].type = BlockType.Air;
                    blocks[7, 8, 13].type = BlockType.Air;
                    blocks[7, 9, 1].type = BlockType.Air;
                    blocks[7, 9, 2].type = BlockType.Air;
                    blocks[7, 9, 4].type = BlockType.Air;
                    blocks[7, 9, 5].type = BlockType.Air;
                    blocks[7, 9, 6].type = BlockType.Air;
                    blocks[7, 9, 8].type = BlockType.Air;
                    blocks[7, 9, 10].type = BlockType.Air;
                    blocks[7, 9, 11].type = BlockType.Air;
                    blocks[7, 9, 12].type = BlockType.Air;
                    blocks[7, 9, 13].type = BlockType.Air;
                    blocks[7, 10, 1].type = BlockType.Air;
                    blocks[7, 10, 4].type = BlockType.Air;
                    blocks[1, 10, 5].type = BlockType.Air;
                    blocks[2, 10, 5].type = BlockType.Air;
                    blocks[3, 10, 5].type = BlockType.Air;
                    blocks[4, 10, 5].type = BlockType.Air;
                    blocks[5, 10, 5].type = BlockType.Air;
                    blocks[9, 10, 5].type = BlockType.Air;
                    blocks[10, 10, 5].type = BlockType.Air;
                    blocks[11, 10, 5].type = BlockType.Air;
                    blocks[12, 10, 5].type = BlockType.Air;
                    blocks[13, 10, 5].type = BlockType.Air;
                    blocks[3, 10, 6].type = BlockType.Air;
                    blocks[7, 10, 6].type = BlockType.Air;
                    blocks[9, 10, 6].type = BlockType.Air;
                    blocks[3, 10, 7].type = BlockType.Air;
                    blocks[7, 10, 7].type = BlockType.Air;
                    blocks[9, 10, 7].type = BlockType.Air;
                    blocks[10, 10, 7].type = BlockType.Air;
                    blocks[11, 10, 7].type = BlockType.Air;
                    blocks[12, 10, 7].type = BlockType.Air;
                    blocks[13, 10, 7].type = BlockType.Air;
                    blocks[3, 10, 8].type = BlockType.Air;
                    blocks[7, 10, 8].type = BlockType.Air;
                    blocks[13, 10, 8].type = BlockType.Air;
                    blocks[1, 10, 9].type = BlockType.Air;
                    blocks[2, 10, 9].type = BlockType.Air;
                    blocks[3, 10, 9].type = BlockType.Air;
                    blocks[4, 10, 9].type = BlockType.Air;
                    blocks[5, 10, 9].type = BlockType.Air;
                    blocks[9, 10, 9].type = BlockType.Air;
                    blocks[10, 10, 9].type = BlockType.Air;
                    blocks[11, 10, 9].type = BlockType.Air;
                    blocks[12, 10, 9].type = BlockType.Air;
                    blocks[13, 10, 9].type = BlockType.Air;
                    blocks[7, 10, 10].type = BlockType.Air;
                    blocks[7, 10, 13].type = BlockType.Air;
                    blocks[7, 11, 1].type = BlockType.Air;
                    blocks[7, 11, 2].type = BlockType.Air;
                    blocks[7, 11, 3].type = BlockType.Air;
                    blocks[7, 11, 4].type = BlockType.Air;
                    blocks[7, 11, 10].type = BlockType.Air;
                    blocks[7, 11, 12].type = BlockType.Air;
                    blocks[7, 11, 13].type = BlockType.Air;
                    blocks[7, 12, 4].type = BlockType.Air;
                    blocks[1, 12, 5].type = BlockType.Air;
                    blocks[5, 12, 5].type = BlockType.Air;
                    blocks[7, 12, 5].type = BlockType.Air;
                    blocks[11, 12, 5].type = BlockType.Air;
                    blocks[1, 12, 6].type = BlockType.Air;
                    blocks[2, 12, 6].type = BlockType.Air;
                    blocks[5, 12, 6].type = BlockType.Air;
                    blocks[7, 12, 6].type = BlockType.Air;
                    blocks[11, 12, 6].type = BlockType.Air;
                    blocks[1, 12, 7].type = BlockType.Air;
                    blocks[3, 12, 7].type = BlockType.Air;
                    blocks[5, 12, 7].type = BlockType.Air;
                    blocks[11, 12, 7].type = BlockType.Air;
                    blocks[1, 12, 8].type = BlockType.Air;
                    blocks[4, 12, 8].type = BlockType.Air;
                    blocks[5, 12, 8].type = BlockType.Air;
                    blocks[7, 12, 8].type = BlockType.Air;
                    blocks[1, 12, 9].type = BlockType.Air;
                    blocks[5, 12, 9].type = BlockType.Air;
                    blocks[7, 12, 9].type = BlockType.Air;
                    blocks[11, 12, 9].type = BlockType.Air;
                    blocks[7, 12, 10].type = BlockType.Air;
                    blocks[7, 13, 1].type = BlockType.Air;
                    blocks[7, 13, 2].type = BlockType.Air;
                    blocks[7, 13, 3].type = BlockType.Air;
                    blocks[7, 13, 4].type = BlockType.Air;
                    blocks[7, 13, 6].type = BlockType.Air;
                    blocks[7, 13, 7].type = BlockType.Air;
                    blocks[7, 13, 8].type = BlockType.Air;
                    blocks[7, 13, 10].type = BlockType.Air;
                    blocks[7, 13, 11].type = BlockType.Air;
                    blocks[7, 13, 12].type = BlockType.Air;
                    blocks[7, 13, 13].type = BlockType.Air;
                }
                break;
            case 9:
                {
                    blocks[9, 1, 3].type = BlockType.Air;
                    blocks[11, 1, 5].type = BlockType.Air;
                    blocks[13, 1, 9].type = BlockType.Air;
                    blocks[13, 1, 13].type = BlockType.Air;
                    blocks[13, 1, 13].type = BlockType.Air;
                    blocks[13, 1, 13].type = BlockType.Air;
                    blocks[13, 1, 13].type = BlockType.Air;
                    blocks[1, 2, 3].type = BlockType.Air;
                    blocks[2, 2, 3].type = BlockType.Air;
                    blocks[9, 2, 3].type = BlockType.Air;
                    blocks[1, 2, 4].type = BlockType.Air;
                    blocks[9, 2, 4].type = BlockType.Air;
                    blocks[1, 2, 5].type = BlockType.Air;
                    blocks[7, 2, 5].type = BlockType.Air;
                    blocks[9, 2, 5].type = BlockType.Air;
                    blocks[10, 2, 5].type = BlockType.Air;
                    blocks[11, 2, 5].type = BlockType.Air;
                    blocks[1, 2, 6].type = BlockType.Air;
                    blocks[7, 2, 6].type = BlockType.Air;
                    blocks[9, 2, 6].type = BlockType.Air;
                    blocks[1, 2, 7].type = BlockType.Air;
                    blocks[5, 2, 7].type = BlockType.Air;
                    blocks[6, 2, 7].type = BlockType.Air;
                    blocks[7, 2, 7].type = BlockType.Air;
                    blocks[9, 2, 7].type = BlockType.Air;
                    blocks[1, 2, 8].type = BlockType.Air;
                    blocks[5, 2, 8].type = BlockType.Air;
                    blocks[1, 2, 9].type = BlockType.Air;
                    blocks[5, 2, 9].type = BlockType.Air;
                    blocks[13, 2, 9].type = BlockType.Air;
                    blocks[1, 2, 10].type = BlockType.Air;
                    blocks[5, 2, 10].type = BlockType.Air;
                    blocks[5, 2, 11].type = BlockType.Air;
                    blocks[4, 2, 13].type = BlockType.Air;
                    blocks[5, 2, 13].type = BlockType.Air;
                    blocks[6, 2, 13].type = BlockType.Air;
                    blocks[7, 2, 13].type = BlockType.Air;
                    blocks[6, 3, 1].type = BlockType.Air;
                    blocks[7, 3, 1].type = BlockType.Air;
                    blocks[8, 3, 1].type = BlockType.Air;
                    blocks[9, 3, 1].type = BlockType.Air;
                    blocks[2, 3, 3].type = BlockType.Air;
                    blocks[4, 3, 3].type = BlockType.Air;
                    blocks[4, 3, 4].type = BlockType.Air;
                    blocks[5, 3, 4].type = BlockType.Air;
                    blocks[4, 3, 5].type = BlockType.Air;
                    blocks[7, 3, 5].type = BlockType.Air;
                    blocks[1, 3, 6].type = BlockType.Air;
                    blocks[2, 3, 6].type = BlockType.Air;
                    blocks[3, 3, 6].type = BlockType.Air;
                    blocks[4, 3, 6].type = BlockType.Air;
                    blocks[9, 3, 7].type = BlockType.Air;
                    blocks[13, 3, 9].type = BlockType.Air;
                    blocks[1, 3, 10].type = BlockType.Air;
                    blocks[1, 3, 11].type = BlockType.Air;
                    blocks[5, 3, 11].type = BlockType.Air;
                    blocks[1, 3, 12].type = BlockType.Air;
                    blocks[1, 3, 13].type = BlockType.Air;
                    blocks[7, 3, 13].type = BlockType.Air;
                    blocks[8, 3, 13].type = BlockType.Air;
                    blocks[9, 3, 13].type = BlockType.Air;
                    blocks[10, 3, 13].type = BlockType.Air;
                    blocks[1, 4, 1].type = BlockType.Air;
                    blocks[2, 4, 1].type = BlockType.Air;
                    blocks[3, 4, 1].type = BlockType.Air;
                    blocks[4, 4, 1].type = BlockType.Air;
                    blocks[5, 4, 1].type = BlockType.Air;
                    blocks[6, 4, 1].type = BlockType.Air;
                    blocks[9, 4, 1].type = BlockType.Air;
                    blocks[4, 4, 2].type = BlockType.Air;
                    blocks[9, 4, 2].type = BlockType.Air;
                    blocks[10, 4, 2].type = BlockType.Air;
                    blocks[11, 4, 2].type = BlockType.Air;
                    blocks[12, 4, 2].type = BlockType.Air;
                    blocks[4, 4, 3].type = BlockType.Air;
                    blocks[7, 4, 3].type = BlockType.Air;
                    blocks[8, 4, 3].type = BlockType.Air;
                    blocks[9, 4, 3].type = BlockType.Air;
                    blocks[9, 4, 4].type = BlockType.Air;
                    blocks[7, 4, 5].type = BlockType.Air;
                    blocks[9, 4, 5].type = BlockType.Air;
                    blocks[9, 4, 6].type = BlockType.Air;
                    blocks[9, 4, 7].type = BlockType.Air;
                    blocks[3, 4, 9].type = BlockType.Air;
                    blocks[4, 4, 9].type = BlockType.Air;
                    blocks[5, 4, 9].type = BlockType.Air;
                    blocks[12, 4, 9].type = BlockType.Air;
                    blocks[13, 4, 9].type = BlockType.Air;
                    blocks[1, 4, 10].type = BlockType.Air;
                    blocks[3, 4, 10].type = BlockType.Air;
                    blocks[12, 4, 10].type = BlockType.Air;
                    blocks[3, 4, 11].type = BlockType.Air;
                    blocks[4, 4, 11].type = BlockType.Air;
                    blocks[5, 4, 11].type = BlockType.Air;
                    blocks[12, 4, 11].type = BlockType.Air;
                    blocks[3, 4, 12].type = BlockType.Air;
                    blocks[12, 4, 12].type = BlockType.Air;
                    blocks[1, 4, 13].type = BlockType.Air;
                    blocks[2, 4, 13].type = BlockType.Air;
                    blocks[3, 4, 13].type = BlockType.Air;
                    blocks[10, 4, 13].type = BlockType.Air;
                    blocks[11, 4, 13].type = BlockType.Air;
                    blocks[12, 4, 13].type = BlockType.Air;
                    blocks[13, 4, 13].type = BlockType.Air;
                    blocks[1, 5, 1].type = BlockType.Air;
                    blocks[10, 5, 2].type = BlockType.Air;
                    blocks[12, 5, 2].type = BlockType.Air;
                    blocks[7, 5, 5].type = BlockType.Air;
                    blocks[5, 5, 9].type = BlockType.Air;
                    blocks[1, 5, 10].type = BlockType.Air;
                    blocks[9, 5, 12].type = BlockType.Air;
                    blocks[13, 5, 13].type = BlockType.Air;
                    blocks[1, 6, 1].type = BlockType.Air;
                    blocks[2, 6, 1].type = BlockType.Air;
                    blocks[3, 6, 1].type = BlockType.Air;
                    blocks[4, 6, 1].type = BlockType.Air;
                    blocks[6, 6, 1].type = BlockType.Air;
                    blocks[7, 6, 1].type = BlockType.Air;
                    blocks[8, 6, 1].type = BlockType.Air;
                    blocks[1, 6, 2].type = BlockType.Air;
                    blocks[4, 6, 2].type = BlockType.Air;
                    blocks[10, 6, 2].type = BlockType.Air;
                    blocks[11, 6, 2].type = BlockType.Air;
                    blocks[12, 6, 2].type = BlockType.Air;
                    blocks[1, 6, 3].type = BlockType.Air;
                    blocks[1, 6, 4].type = BlockType.Air;
                    blocks[3, 6, 4].type = BlockType.Air;
                    blocks[11, 6, 4].type = BlockType.Air;
                    blocks[7, 6, 5].type = BlockType.Air;
                    blocks[11, 6, 5].type = BlockType.Air;
                    blocks[11, 6, 6].type = BlockType.Air;
                    blocks[7, 6, 7].type = BlockType.Start;
                    blocks[8, 6, 7].type = BlockType.Air;
                    blocks[9, 6, 7].type = BlockType.Air;
                    blocks[10, 6, 7].type = BlockType.Air;
                    blocks[11, 6, 7].type = BlockType.Air;
                    blocks[12, 6, 7].type = BlockType.Air;
                    blocks[13, 6, 7].type = BlockType.Air;
                    blocks[9, 6, 8].type = BlockType.Air;
                    blocks[3, 6, 9].type = BlockType.Air;
                    blocks[4, 6, 9].type = BlockType.Air;
                    blocks[5, 6, 9].type = BlockType.Air;
                    blocks[6, 6, 9].type = BlockType.Air;
                    blocks[7, 6, 9].type = BlockType.Air;
                    blocks[9, 6, 9].type = BlockType.Air;
                    blocks[2, 6, 10].type = BlockType.Air;
                    blocks[9, 6, 10].type = BlockType.Air;
                    blocks[11, 6, 10].type = BlockType.Air;
                    blocks[12, 6, 10].type = BlockType.Air;
                    blocks[13, 6, 10].type = BlockType.Air;
                    blocks[11, 6, 11].type = BlockType.Air;
                    blocks[13, 6, 11].type = BlockType.Air;
                    blocks[9, 6, 12].type = BlockType.Air;
                    blocks[10, 6, 12].type = BlockType.Air;
                    blocks[11, 6, 12].type = BlockType.Air;
                    blocks[13, 6, 12].type = BlockType.Air;
                    blocks[13, 6, 13].type = BlockType.Air;
                    blocks[6, 7, 1].type = BlockType.Air;
                    blocks[8, 7, 1].type = BlockType.Air;
                    blocks[4, 7, 2].type = BlockType.Air;
                    blocks[5, 7, 2].type = BlockType.Air;
                    blocks[6, 7, 2].type = BlockType.Air;
                    blocks[8, 7, 2].type = BlockType.Air;
                    blocks[8, 7, 3].type = BlockType.Air;
                    blocks[1, 7, 4].type = BlockType.Air;
                    blocks[2, 7, 4].type = BlockType.Air;
                    blocks[3, 7, 4].type = BlockType.Air;
                    blocks[8, 7, 4].type = BlockType.Air;
                    blocks[9, 7, 4].type = BlockType.Air;
                    blocks[10, 7, 4].type = BlockType.Air;
                    blocks[11, 7, 4].type = BlockType.Air;
                    blocks[7, 7, 5].type = BlockType.Air;
                    blocks[7, 7, 6].type = BlockType.Air;
                    blocks[13, 7, 7].type = BlockType.Air;
                    blocks[9, 7, 10].type = BlockType.Air;
                    blocks[13, 7, 10].type = BlockType.Air;
                    blocks[3, 8, 4].type = BlockType.Air;
                    blocks[5, 8, 4].type = BlockType.Air;
                    blocks[6, 8, 4].type = BlockType.Air;
                    blocks[7, 8, 4].type = BlockType.Air;
                    blocks[8, 8, 4].type = BlockType.Air;
                    blocks[3, 8, 5].type = BlockType.Air;
                    blocks[3, 8, 6].type = BlockType.Air;
                    blocks[7, 8, 6].type = BlockType.Air;
                    blocks[3, 8, 7].type = BlockType.Air;
                    blocks[4, 8, 7].type = BlockType.Air;
                    blocks[5, 8, 7].type = BlockType.Air;
                    blocks[7, 8, 7].type = BlockType.Exit;
                    blocks[10, 8, 7].type = BlockType.Air;
                    blocks[11, 8, 7].type = BlockType.Air;
                    blocks[12, 8, 7].type = BlockType.Air;
                    blocks[13, 8, 7].type = BlockType.Air;
                    blocks[7, 8, 10].type = BlockType.Air;
                    blocks[9, 8, 10].type = BlockType.Air;
                    blocks[10, 8, 10].type = BlockType.Air;
                    blocks[11, 8, 10].type = BlockType.Air;
                    blocks[12, 8, 10].type = BlockType.Air;
                    blocks[13, 8, 10].type = BlockType.Air;
                    blocks[7, 8, 11].type = BlockType.Air;
                    blocks[9, 8, 11].type = BlockType.Air;
                    blocks[7, 8, 12].type = BlockType.Air;
                    blocks[9, 8, 12].type = BlockType.Air;
                    blocks[11, 8, 12].type = BlockType.Air;
                    blocks[7, 8, 13].type = BlockType.Air;
                    blocks[8, 8, 13].type = BlockType.Air;
                    blocks[9, 8, 13].type = BlockType.Air;
                    blocks[11, 8, 13].type = BlockType.Air;
                    blocks[12, 8, 13].type = BlockType.Air;
                    blocks[13, 8, 13].type = BlockType.Air;
                    blocks[5, 9, 4].type = BlockType.Air;
                    blocks[10, 9, 6].type = BlockType.Air;
                    blocks[5, 9, 7].type = BlockType.Air;
                    blocks[10, 9, 7].type = BlockType.Air;
                    blocks[13, 9, 7].type = BlockType.Air;
                    blocks[10, 9, 8].type = BlockType.Air;
                    blocks[7, 9, 10].type = BlockType.Air;
                    blocks[1, 9, 13].type = BlockType.Air;
                    blocks[2, 9, 13].type = BlockType.Air;
                    blocks[3, 9, 13].type = BlockType.Air;
                    blocks[4, 9, 13].type = BlockType.Air;
                    blocks[6, 9, 13].type = BlockType.Air;
                    blocks[7, 9, 13].type = BlockType.Air;
                    blocks[13, 9, 13].type = BlockType.Air;
                    blocks[5, 10, 4].type = BlockType.Air;
                    blocks[10, 10, 6].type = BlockType.Air;
                    blocks[3, 10, 7].type = BlockType.Air;
                    blocks[5, 10, 7].type = BlockType.Air;
                    blocks[13, 10, 7].type = BlockType.Air;
                    blocks[1, 10, 8].type = BlockType.Air;
                    blocks[10, 10, 8].type = BlockType.Air;
                    blocks[13, 10, 8].type = BlockType.Air;
                    blocks[13, 10, 9].type = BlockType.Air;
                    blocks[6, 10, 10].type = BlockType.Air;
                    blocks[7, 10, 10].type = BlockType.Air;
                    blocks[10, 10, 10].type = BlockType.Air;
                    blocks[11, 10, 10].type = BlockType.Air;
                    blocks[12, 10, 10].type = BlockType.Air;
                    blocks[13, 10, 10].type = BlockType.Air;
                    blocks[13, 10, 11].type = BlockType.Air;
                    blocks[10, 10, 12].type = BlockType.Air;
                    blocks[11, 10, 12].type = BlockType.Air;
                    blocks[12, 10, 12].type = BlockType.Air;
                    blocks[13, 10, 12].type = BlockType.Air;
                    blocks[1, 10, 13].type = BlockType.Air;
                    blocks[5, 10, 13].type = BlockType.Air;
                    blocks[13, 10, 13].type = BlockType.Air;
                    blocks[5, 11, 4].type = BlockType.Air;
                    blocks[10, 11, 6].type = BlockType.Air;
                    blocks[3, 11, 7].type = BlockType.Air;
                    blocks[1, 11, 8].type = BlockType.Air;
                    blocks[2, 11, 8].type = BlockType.Air;
                    blocks[3, 11, 8].type = BlockType.Air;
                    blocks[3, 11, 9].type = BlockType.Air;
                    blocks[1, 11, 10].type = BlockType.Air;
                    blocks[2, 11, 10].type = BlockType.Air;
                    blocks[3, 11, 10].type = BlockType.Air;
                    blocks[4, 11, 10].type = BlockType.Air;
                    blocks[10, 11, 10].type = BlockType.Air;
                    blocks[1, 11, 11].type = BlockType.Air;
                    blocks[4, 11, 11].type = BlockType.Air;
                    blocks[1, 11, 12].type = BlockType.Air;
                    blocks[4, 11, 12].type = BlockType.Air;
                    blocks[10, 11, 12].type = BlockType.Air;
                    blocks[3, 11, 13].type = BlockType.Air;
                    blocks[4, 11, 13].type = BlockType.Air;
                    blocks[3, 12, 7].type = BlockType.Air;
                    blocks[8, 12, 11].type = BlockType.Air;
                    blocks[1, 12, 12].type = BlockType.Air;
                    blocks[8, 12, 12].type = BlockType.Air;
                    blocks[10, 12, 12].type = BlockType.Air;
                    blocks[3, 12, 13].type = BlockType.Air;
                    blocks[6, 12, 13].type = BlockType.Air;
                    blocks[7, 12, 13].type = BlockType.Air;
                    blocks[8, 12, 13].type = BlockType.Air;
                    blocks[9, 12, 13].type = BlockType.Air;
                    blocks[10, 12, 13].type = BlockType.Air;
                    blocks[3, 13, 7].type = BlockType.Air;
                    blocks[2, 13, 11].type = BlockType.Air;
                    blocks[3, 13, 11].type = BlockType.Air;
                    blocks[4, 13, 11].type = BlockType.Air;
                    blocks[5, 13, 11].type = BlockType.Air;
                    blocks[6, 13, 11].type = BlockType.Air;
                    blocks[8, 13, 11].type = BlockType.Air;
                    blocks[1, 13, 12].type = BlockType.Air;
                    blocks[2, 13, 12].type = BlockType.Air;
                    blocks[6, 13, 12].type = BlockType.Air;
                    blocks[2, 13, 13].type = BlockType.Air;
                    blocks[3, 13, 13].type = BlockType.Air;
                    blocks[6, 13, 13].type = BlockType.Air;
                    blocks[11, 13, 13].type = BlockType.Air;
                }
                break;
            case 10:
                {
                    for (int x = 0; x <= 11; x++) { blocks[x, 1, 0].type = BlockType.Air; }
                    for (int x = 0; x <= 11; x++) { blocks[x, 1, 1].type = BlockType.Air; }
                    blocks[13, 1, 1].type = BlockType.Exit;
                    blocks[3, 1, 2].type = BlockType.Air;
                    blocks[5, 1, 2].type = BlockType.Air;
                    blocks[6, 1, 2].type = BlockType.Air;
                    blocks[7, 1, 2].type = BlockType.Air;
                    blocks[11, 1, 2].type = BlockType.Air;
                    blocks[0, 1, 3].type = BlockType.Air;
                    blocks[2, 1, 3].type = BlockType.Air;
                    blocks[3, 1, 3].type = BlockType.Air;
                    blocks[5, 1, 3].type = BlockType.Air;
                    blocks[6, 1, 3].type = BlockType.Air;
                    blocks[7, 1, 3].type = BlockType.Air;
                    for (int x = 9; x <= 14; x++) { blocks[x, 1, 3].type = BlockType.Air; }
                    blocks[0, 1, 4].type = BlockType.Air;
                    blocks[2, 1, 4].type = BlockType.Air;
                    blocks[3, 1, 4].type = BlockType.Air;
                    blocks[7, 1, 4].type = BlockType.Air;
                    for (int x = 10; x <= 14; x++) { blocks[x, 1, 4].type = BlockType.Air; }
                    blocks[0, 1, 5].type = BlockType.Air;
                    blocks[2, 1, 5].type = BlockType.Air;
                    blocks[3, 1, 5].type = BlockType.Air;
                    blocks[5, 1, 5].type = BlockType.Air;
                    blocks[7, 1, 5].type = BlockType.Air;
                    for (int x = 9; x <= 14; x++) { blocks[x, 1, 5].type = BlockType.Air; }
                    blocks[0, 1, 6].type = BlockType.Air;
                    blocks[2, 1, 6].type = BlockType.Air;
                    blocks[3, 1, 6].type = BlockType.Air;
                    blocks[5, 1, 6].type = BlockType.Air;
                    blocks[7, 1, 6].type = BlockType.Air;
                    for (int x = 11; x <= 14; x++) { blocks[x, 1, 6].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 1, 7].type = BlockType.Air; }
                    for (int x = 0; x <= 3; x++) { blocks[x, 1, 8].type = BlockType.Air; }
                    for (int x = 7; x <= 11; x++) { blocks[x, 1, 8].type = BlockType.Air; }
                    blocks[14, 1, 8].type = BlockType.Air;
                    for (int x = 0; x <= 3; x++) { blocks[x, 1, 9].type = BlockType.Air; }
                    blocks[5, 1, 9].type = BlockType.Air;
                    blocks[6, 1, 9].type = BlockType.Air;
                    blocks[7, 1, 9].type = BlockType.Air;
                    blocks[10, 1, 9].type = BlockType.Air;
                    blocks[11, 1, 9].type = BlockType.Air;
                    blocks[13, 1, 9].type = BlockType.Air;
                    for (int x = 0; x <= 3; x++) { blocks[x, 1, 10].type = BlockType.Air; }
                    blocks[6, 1, 10].type = BlockType.Air;
                    blocks[7, 1, 10].type = BlockType.Air;
                    blocks[9, 1, 10].type = BlockType.Air;
                    blocks[11, 1, 10].type = BlockType.Air;
                    blocks[13, 1, 10].type = BlockType.Air;
                    for (int x = 0; x <= 3; x++) { blocks[x, 1, 11].type = BlockType.Air; }
                    blocks[5, 1, 11].type = BlockType.Air;
                    blocks[6, 1, 11].type = BlockType.Air;
                    blocks[7, 1, 11].type = BlockType.Air;
                    blocks[9, 1, 11].type = BlockType.Air;
                    blocks[11, 1, 11].type = BlockType.Air;
                    blocks[13, 1, 11].type = BlockType.Air;
                    blocks[3, 1, 12].type = BlockType.Air;
                    blocks[7, 1, 12].type = BlockType.Air;
                    blocks[9, 1, 12].type = BlockType.Air;
                    blocks[11, 1, 12].type = BlockType.Air;
                    blocks[14, 1, 12].type = BlockType.Air;
                    blocks[1, 1, 13].type = BlockType.Start;
                    for (int x = 3; x <= 14; x++) { blocks[x, 1, 13].type = BlockType.Air; }
                    for (int x = 0; x <= 11; x++) { blocks[x, 2, 0].type = BlockType.Air; }
                    for (int x = 0; x <= 11; x++) { blocks[x, 2, 1].type = BlockType.Air; }
                    blocks[13, 2, 1].type = BlockType.Air;
                    for (int x = 0; x <= 11; x++) { blocks[x, 2, 2].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 2, 3].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 2, 4].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 2, 5].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 2, 6].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 2, 7].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 2, 8].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 2, 9].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 2, 10].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 2, 11].type = BlockType.Air; }
                    for (int x = 3; x <= 14; x++) { blocks[x, 2, 12].type = BlockType.Air; }
                    blocks[1, 2, 13].type = BlockType.Air;
                    for (int x = 3; x <= 14; x++) { blocks[x, 2, 13].type = BlockType.Air; }
                    for (int x = 3; x <= 14; x++) { blocks[x, 2, 14].type = BlockType.Air; }
                    for (int x = 0; x <= 11; x++) { blocks[x, 3, 0].type = BlockType.Air; }
                    for (int x = 0; x <= 11; x++) { blocks[x, 3, 1].type = BlockType.Air; }
                    blocks[13, 3, 1].type = BlockType.Air;
                    for (int x = 0; x <= 11; x++) { blocks[x, 3, 2].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 3, 3].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 3, 4].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 3, 5].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 3, 6].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 3, 7].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 3, 8].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 3, 9].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 3, 10].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 3, 11].type = BlockType.Air; }
                    for (int x = 3; x <= 14; x++) { blocks[x, 3, 12].type = BlockType.Air; }
                    blocks[1, 3, 13].type = BlockType.Air;
                    for (int x = 3; x <= 14; x++) { blocks[x, 3, 13].type = BlockType.Air; }
                    for (int x = 3; x <= 14; x++) { blocks[x, 3, 14].type = BlockType.Air; }
                    for (int x = 0; x <= 10; x++) { blocks[x, 4, 0].type = BlockType.Air; }
                    for (int x = 0; x <= 10; x++) { blocks[x, 4, 1].type = BlockType.Air; }
                    blocks[12, 4, 1].type = BlockType.Air;
                    blocks[13, 4, 1].type = BlockType.Air;
                    for (int x = 0; x <= 10; x++) { blocks[x, 4, 2].type = BlockType.Air; }
                    blocks[12, 4, 2].type = BlockType.Air;
                    blocks[13, 4, 2].type = BlockType.Air;
                    for (int x = 0; x <= 10; x++) { blocks[x, 4, 3].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 4, 4].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 4, 5].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 4, 6].type = BlockType.Air; }
                    for (int x = 0; x <= 12; x++) { blocks[x, 4, 7].type = BlockType.Air; }
                    blocks[14, 4, 7].type = BlockType.Air;
                    for (int x = 0; x <= 14; x++) { blocks[x, 4, 8].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 4, 9].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 4, 10].type = BlockType.Air; }
                    for (int x = 4; x <= 14; x++) { blocks[x, 4, 11].type = BlockType.Air; }
                    blocks[1, 4, 12].type = BlockType.Air;
                    blocks[2, 4, 12].type = BlockType.Air;
                    for (int x = 4; x <= 14; x++) { blocks[x, 4, 12].type = BlockType.Air; }
                    blocks[1, 4, 13].type = BlockType.Air;
                    blocks[2, 4, 13].type = BlockType.Air;
                    for (int x = 4; x <= 14; x++) { blocks[x, 4, 13].type = BlockType.Air; }
                    for (int x = 4; x <= 14; x++) { blocks[x, 4, 14].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 5, 0].type = BlockType.Air; }
                    blocks[0, 5, 1].type = BlockType.Air;
                    blocks[14, 5, 1].type = BlockType.Air;
                    blocks[0, 5, 2].type = BlockType.Air;
                    blocks[12, 5, 2].type = BlockType.Air;
                    blocks[14, 5, 2].type = BlockType.Air;
                    blocks[0, 5, 3].type = BlockType.Air;
                    blocks[14, 5, 3].type = BlockType.Air;
                    for (int x = 0; x <= 5; x++) { blocks[x, 5, 4].type = BlockType.Air; }
                    for (int x = 9; x <= 14; x++) { blocks[x, 5, 4].type = BlockType.Air; }
                    for (int x = 0; x <= 5; x++) { blocks[x, 5, 5].type = BlockType.Air; }
                    for (int x = 9; x <= 14; x++) { blocks[x, 5, 5].type = BlockType.Air; }
                    for (int x = 0; x <= 5; x++) { blocks[x, 5, 6].type = BlockType.Air; }
                    for (int x = 9; x <= 14; x++) { blocks[x, 5, 6].type = BlockType.Air; }
                    blocks[0, 5, 7].type = BlockType.Air;
                    blocks[1, 5, 7].type = BlockType.Air;
                    blocks[3, 5, 7].type = BlockType.Air;
                    blocks[4, 5, 7].type = BlockType.Air;
                    blocks[5, 5, 7].type = BlockType.Air;
                    for (int x = 9; x <= 12; x++) { blocks[x, 5, 7].type = BlockType.Air; }
                    blocks[14, 5, 7].type = BlockType.Air;
                    for (int x = 0; x <= 14; x++) { blocks[x, 5, 8].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 5, 9].type = BlockType.Air; }
                    for (int x = 0; x <= 11; x++) { blocks[x, 5, 10].type = BlockType.Air; }
                    blocks[13, 5, 10].type = BlockType.Air;
                    blocks[14, 5, 10].type = BlockType.Air;
                    blocks[0, 5, 11].type = BlockType.Air;
                    for (int x = 7; x <= 11; x++) { blocks[x, 5, 11].type = BlockType.Air; }
                    blocks[13, 5, 11].type = BlockType.Air;
                    blocks[14, 5, 11].type = BlockType.Air;
                    blocks[0, 5, 12].type = BlockType.Air;
                    blocks[2, 5, 12].type = BlockType.Air;
                    for (int x = 7; x <= 11; x++) { blocks[x, 5, 12].type = BlockType.Air; }
                    blocks[13, 5, 12].type = BlockType.Air;
                    blocks[14, 5, 12].type = BlockType.Air;
                    blocks[0, 5, 13].type = BlockType.Air;
                    for (int x = 7; x <= 14; x++) { blocks[x, 5, 13].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 5, 14].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 6, 0].type = BlockType.Air; }
                    blocks[0, 6, 1].type = BlockType.Air;
                    blocks[14, 6, 1].type = BlockType.Air;
                    blocks[0, 6, 2].type = BlockType.Air;
                    for (int x = 2; x <= 12; x++) { blocks[x, 6, 2].type = BlockType.Air; }
                    blocks[14, 6, 2].type = BlockType.Air;
                    blocks[0, 6, 3].type = BlockType.Air;
                    blocks[7, 6, 3].type = BlockType.Air;
                    blocks[14, 6, 3].type = BlockType.Air;
                    for (int x = 0; x <= 5; x++) { blocks[x, 6, 4].type = BlockType.Air; }
                    blocks[7, 6, 4].type = BlockType.Air;
                    for (int x = 9; x <= 14; x++) { blocks[x, 6, 4].type = BlockType.Air; }
                    for (int x = 0; x <= 5; x++) { blocks[x, 6, 5].type = BlockType.Air; }
                    blocks[7, 6, 5].type = BlockType.Air;
                    for (int x = 9; x <= 14; x++) { blocks[x, 6, 5].type = BlockType.Air; }
                    blocks[0, 6, 6].type = BlockType.Air;
                    blocks[1, 6, 6].type = BlockType.Air;
                    blocks[2, 6, 6].type = BlockType.Air;
                    blocks[4, 6, 6].type = BlockType.Air;
                    blocks[5, 6, 6].type = BlockType.Air;
                    blocks[7, 6, 6].type = BlockType.Air;
                    for (int x = 9; x <= 14; x++) { blocks[x, 6, 6].type = BlockType.Air; }
                    blocks[0, 6, 7].type = BlockType.Air;
                    blocks[1, 6, 7].type = BlockType.Air;
                    blocks[3, 6, 7].type = BlockType.Air;
                    blocks[4, 6, 7].type = BlockType.Air;
                    blocks[5, 6, 7].type = BlockType.Air;
                    for (int x = 9; x <= 12; x++) { blocks[x, 6, 7].type = BlockType.Air; }
                    blocks[14, 6, 7].type = BlockType.Air;
                    for (int x = 0; x <= 14; x++) { blocks[x, 6, 8].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 6, 9].type = BlockType.Air; }
                    for (int x = 0; x <= 11; x++) { blocks[x, 6, 10].type = BlockType.Air; }
                    blocks[13, 6, 10].type = BlockType.Air;
                    blocks[14, 6, 10].type = BlockType.Air;
                    blocks[0, 6, 11].type = BlockType.Air;
                    for (int x = 7; x <= 14; x++) { blocks[x, 6, 11].type = BlockType.Air; }
                    blocks[0, 6, 12].type = BlockType.Air;
                    for (int x = 2; x <= 5; x++) { blocks[x, 6, 12].type = BlockType.Air; }
                    for (int x = 7; x <= 11; x++) { blocks[x, 6, 12].type = BlockType.Air; }
                    blocks[13, 6, 12].type = BlockType.Air;
                    blocks[14, 6, 12].type = BlockType.Air;
                    blocks[0, 6, 13].type = BlockType.Air;
                    for (int x = 7; x <= 14; x++) { blocks[x, 6, 13].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 6, 14].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 7, 0].type = BlockType.Air; }
                    blocks[0, 7, 1].type = BlockType.Air;
                    blocks[14, 7, 1].type = BlockType.Air;
                    blocks[0, 7, 2].type = BlockType.Air;
                    blocks[2, 7, 2].type = BlockType.Air;
                    blocks[14, 7, 2].type = BlockType.Air;
                    blocks[0, 7, 3].type = BlockType.Air;
                    blocks[14, 7, 3].type = BlockType.Air;
                    for (int x = 0; x <= 5; x++) { blocks[x, 7, 4].type = BlockType.Air; }
                    blocks[9, 7, 4].type = BlockType.Air;
                    for (int x = 11; x <= 14; x++) { blocks[x, 7, 4].type = BlockType.Air; }
                    blocks[0, 7, 5].type = BlockType.Air;
                    for (int x = 2; x <= 5; x++) { blocks[x, 7, 5].type = BlockType.Air; }
                    blocks[9, 7, 5].type = BlockType.Air;
                    blocks[11, 7, 5].type = BlockType.Air;
                    blocks[13, 7, 5].type = BlockType.Air;
                    blocks[14, 7, 5].type = BlockType.Air;
                    blocks[0, 7, 6].type = BlockType.Air;
                    blocks[1, 7, 6].type = BlockType.Air;
                    blocks[2, 7, 6].type = BlockType.Air;
                    blocks[4, 7, 6].type = BlockType.Air;
                    blocks[5, 7, 6].type = BlockType.Air;
                    blocks[7, 7, 6].type = BlockType.Air;
                    for (int x = 9; x <= 14; x++) { blocks[x, 7, 6].type = BlockType.Air; }
                    blocks[0, 7, 7].type = BlockType.Air;
                    blocks[1, 7, 7].type = BlockType.Air;
                    blocks[3, 7, 7].type = BlockType.Air;
                    blocks[4, 7, 7].type = BlockType.Air;
                    blocks[5, 7, 7].type = BlockType.Air;
                    for (int x = 9; x <= 12; x++) { blocks[x, 7, 7].type = BlockType.Air; }
                    blocks[14, 7, 7].type = BlockType.Air;
                    for (int x = 0; x <= 9; x++) { blocks[x, 7, 8].type = BlockType.Air; }
                    for (int x = 11; x <= 14; x++) { blocks[x, 7, 8].type = BlockType.Air; }
                    blocks[0, 7, 9].type = BlockType.Air;
                    for (int x = 9; x <= 14; x++) { blocks[x, 7, 9].type = BlockType.Air; }
                    for (int x = 0; x <= 4; x++) { blocks[x, 7, 10].type = BlockType.Air; }
                    for (int x = 6; x <= 11; x++) { blocks[x, 7, 10].type = BlockType.Air; }
                    blocks[13, 7, 10].type = BlockType.Air;
                    blocks[14, 7, 10].type = BlockType.Air;
                    blocks[0, 7, 11].type = BlockType.Air;
                    blocks[7, 7, 11].type = BlockType.Air;
                    blocks[8, 7, 11].type = BlockType.Air;
                    for (int x = 10; x <= 14; x++) { blocks[x, 7, 11].type = BlockType.Air; }
                    blocks[5, 7, 12].type = BlockType.Air;
                    blocks[9, 7, 12].type = BlockType.Air;
                    for (int x = 11; x <= 14; x++) { blocks[x, 7, 12].type = BlockType.Air; }
                    blocks[0, 7, 13].type = BlockType.Air;
                    blocks[7, 7, 13].type = BlockType.Air;
                    blocks[8, 7, 13].type = BlockType.Air;
                    for (int x = 10; x <= 14; x++) { blocks[x, 7, 13].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 7, 14].type = BlockType.Air; }
                    blocks[1, 8, 1].type = BlockType.Air;
                    for (int x = 3; x <= 10; x++) { blocks[x, 8, 1].type = BlockType.Air; }
                    blocks[1, 8, 2].type = BlockType.Air;
                    blocks[3, 8, 2].type = BlockType.Air;
                    blocks[6, 8, 2].type = BlockType.Air;
                    blocks[10, 8, 2].type = BlockType.Air;
                    blocks[1, 8, 3].type = BlockType.Air;
                    blocks[2, 8, 3].type = BlockType.Air;
                    blocks[3, 8, 3].type = BlockType.Air;
                    blocks[6, 8, 3].type = BlockType.Air;
                    blocks[7, 8, 3].type = BlockType.Air;
                    blocks[8, 8, 3].type = BlockType.Air;
                    blocks[10, 8, 3].type = BlockType.Air;
                    blocks[8, 8, 4].type = BlockType.Air;
                    blocks[10, 8, 4].type = BlockType.Air;
                    blocks[7, 8, 5].type = BlockType.Air;
                    blocks[8, 8, 5].type = BlockType.Air;
                    blocks[10, 8, 5].type = BlockType.Air;
                    blocks[7, 8, 6].type = BlockType.Air;
                    blocks[12, 8, 7].type = BlockType.Air;
                    for (int x = 1; x <= 8; x++) { blocks[x, 8, 9].type = BlockType.Air; }
                    blocks[5, 8, 10].type = BlockType.Air;
                    blocks[5, 8, 11].type = BlockType.Air;
                    for (int x = 5; x <= 9; x++) { blocks[x, 8, 12].type = BlockType.Air; }
                    blocks[0, 9, 5].type = BlockType.Air;
                    blocks[1, 9, 5].type = BlockType.Air;
                    blocks[2, 9, 5].type = BlockType.Air;
                    blocks[3, 9, 5].type = BlockType.Air;
                    blocks[10, 9, 5].type = BlockType.Air;
                    blocks[3, 9, 6].type = BlockType.Air;
                    blocks[1, 9, 7].type = BlockType.Air;
                    blocks[3, 9, 7].type = BlockType.Air;
                    for (int x = 7; x <= 12; x++) { blocks[x, 9, 7].type = BlockType.Air; }
                    blocks[1, 9, 8].type = BlockType.Air;
                    for (int x = 3; x <= 7; x++) { blocks[x, 9, 8].type = BlockType.Air; }
                    blocks[12, 9, 8].type = BlockType.Air;
                    blocks[1, 9, 9].type = BlockType.Air;
                    blocks[8, 9, 9].type = BlockType.Air;
                    blocks[9, 9, 9].type = BlockType.Air;
                    blocks[10, 9, 9].type = BlockType.Air;
                    blocks[12, 9, 9].type = BlockType.Air;
                    blocks[3, 9, 10].type = BlockType.Air;
                    blocks[4, 9, 10].type = BlockType.Air;
                    blocks[6, 9, 10].type = BlockType.Air;
                    blocks[7, 9, 10].type = BlockType.Air;
                    blocks[12, 9, 10].type = BlockType.Air;
                    for (int x = 0; x <= 4; x++) { blocks[x, 9, 10].type = BlockType.Air; }
                    for (int x = 6; x <= 12; x++) { blocks[x, 9, 10].type = BlockType.Air; }
                    blocks[12, 10, 0].type = BlockType.Air;
                    blocks[13, 10, 0].type = BlockType.Air;
                    blocks[14, 10, 0].type = BlockType.Air;
                    blocks[12, 10, 1].type = BlockType.Air;
                    blocks[13, 10, 1].type = BlockType.Air;
                    blocks[14, 10, 1].type = BlockType.Air;
                    blocks[12, 10, 2].type = BlockType.Air;
                    blocks[13, 10, 2].type = BlockType.Air;
                    blocks[14, 10, 2].type = BlockType.Air;
                    for (int x = 8; x <= 13; x++) { blocks[x, 10, 3].type = BlockType.Air; }
                    blocks[8, 10, 4].type = BlockType.Air;
                    blocks[13, 10, 4].type = BlockType.Air;
                    blocks[0, 10, 5].type = BlockType.Air;
                    blocks[3, 10, 5].type = BlockType.Air;
                    blocks[4, 10, 5].type = BlockType.Air;
                    blocks[8, 10, 5].type = BlockType.Air;
                    blocks[10, 10, 5].type = BlockType.Air;
                    blocks[13, 10, 5].type = BlockType.Air;
                    for (int x = 4; x <= 8; x++) { blocks[x, 10, 6].type = BlockType.Air; }
                    blocks[10, 10, 6].type = BlockType.Air;
                    blocks[11, 10, 6].type = BlockType.Air;
                    blocks[13, 10, 6].type = BlockType.Air;
                    blocks[1, 10, 7].type = BlockType.Air;
                    blocks[13, 10, 7].type = BlockType.Air;
                    blocks[13, 10, 8].type = BlockType.Air;
                    blocks[5, 10, 9].type = BlockType.Air;
                    blocks[10, 10, 9].type = BlockType.Air;
                    blocks[13, 10, 9].type = BlockType.Air;
                    blocks[0, 10, 10].type = BlockType.Air;
                    blocks[1, 10, 10].type = BlockType.Air;
                    blocks[2, 10, 10].type = BlockType.Air;
                    blocks[13, 10, 10].type = BlockType.Air;
                    blocks[13, 10, 11].type = BlockType.Air;
                    blocks[0, 10, 12].type = BlockType.Air;
                    blocks[1, 10, 12].type = BlockType.Air;
                    blocks[2, 10, 12].type = BlockType.Air;
                    blocks[12, 10, 12].type = BlockType.Air;
                    blocks[13, 10, 12].type = BlockType.Air;
                    blocks[14, 10, 12].type = BlockType.Air;
                    blocks[0, 10, 13].type = BlockType.Air;
                    blocks[1, 10, 13].type = BlockType.Air;
                    blocks[2, 10, 13].type = BlockType.Air;
                    blocks[12, 10, 13].type = BlockType.Air;
                    blocks[13, 10, 13].type = BlockType.Air;
                    blocks[14, 10, 13].type = BlockType.Air;
                    for (int x = 0; x <= 14; x++) { blocks[x, 10, 14].type = BlockType.Air; }
                    for (int x = 0; x <= 4; x++) { blocks[x, 11, 1].type = BlockType.Air; }
                    blocks[13, 11, 1].type = BlockType.Air;
                    blocks[0, 11, 2].type = BlockType.Air;
                    blocks[0, 11, 3].type = BlockType.Air;
                    blocks[2, 11, 3].type = BlockType.Air;
                    blocks[3, 11, 3].type = BlockType.Air;
                    blocks[4, 11, 3].type = BlockType.Air;
                    blocks[0, 11, 4].type = BlockType.Air;
                    blocks[2, 11, 4].type = BlockType.Air;
                    blocks[0, 11, 5].type = BlockType.Air;
                    blocks[2, 11, 5].type = BlockType.Air;
                    blocks[2, 11, 6].type = BlockType.Air;
                    blocks[11, 11, 6].type = BlockType.Air;
                    blocks[1, 11, 7].type = BlockType.Air;
                    blocks[2, 11, 7].type = BlockType.Air;
                    blocks[10, 11, 9].type = BlockType.Air;
                    blocks[1, 11, 13].type = BlockType.Air;
                    blocks[13, 11, 13].type = BlockType.Air;
                    blocks[4, 12, 1].type = BlockType.Air;
                    for (int x = 7; x <= 13; x++) { blocks[x, 12, 1].type = BlockType.Air; }
                    blocks[5, 12, 2].type = BlockType.Air;
                    blocks[6, 12, 2].type = BlockType.Air;
                    blocks[7, 12, 2].type = BlockType.Air;
                    blocks[4, 12, 3].type = BlockType.Air;
                    blocks[7, 12, 3].type = BlockType.Air;
                    blocks[12, 12, 3].type = BlockType.Air;
                    blocks[4, 12, 4].type = BlockType.Air;
                    blocks[7, 12, 4].type = BlockType.Air;
                    blocks[7, 12, 5].type = BlockType.Air;
                    blocks[7, 12, 6].type = BlockType.Air;
                    blocks[11, 12, 6].type = BlockType.Air;
                    blocks[5, 12, 7].type = BlockType.Air;
                    blocks[7, 12, 7].type = BlockType.Air;
                    blocks[9, 12, 7].type = BlockType.Air;
                    blocks[11, 12, 7].type = BlockType.Air;
                    blocks[5, 12, 8].type = BlockType.Air;
                    blocks[9, 12, 8].type = BlockType.Air;
                    blocks[11, 12, 8].type = BlockType.Air;
                    blocks[5, 12, 9].type = BlockType.Air;
                    blocks[9, 12, 9].type = BlockType.Air;
                    blocks[11, 12, 9].type = BlockType.Air;
                    blocks[12, 12, 9].type = BlockType.Air;
                    blocks[5, 12, 10].type = BlockType.Air;
                    blocks[9, 12, 10].type = BlockType.Air;
                    blocks[5, 12, 11].type = BlockType.Air;
                    blocks[9, 12, 11].type = BlockType.Air;
                    blocks[5, 12, 12].type = BlockType.Air;
                    blocks[9, 12, 12].type = BlockType.Air;
                    for (int x = 1; x <= 5; x++) { blocks[x, 12, 13].type = BlockType.Air; }
                    for (int x = 9; x <= 13; x++) { blocks[x, 12, 13].type = BlockType.Air; }
                    blocks[12, 13, 3].type = BlockType.Air;
                    blocks[4, 13, 4].type = BlockType.Air;
                    blocks[12, 13, 4].type = BlockType.Air;
                    blocks[5, 13, 5].type = BlockType.Air;
                    blocks[6, 13, 5].type = BlockType.Air;
                    for (int x = 8; x <= 12; x++) { blocks[x, 13, 5].type = BlockType.Air; }
                    blocks[5, 13, 6].type = BlockType.Air;
                    blocks[12, 13, 6].type = BlockType.Air;
                    blocks[5, 13, 7].type = BlockType.Air;
                    blocks[7, 13, 7].type = BlockType.Air;
                    blocks[9, 13, 7].type = BlockType.Air;
                    blocks[12, 13, 7].type = BlockType.Air;
                    blocks[12, 13, 8].type = BlockType.Air;
                    blocks[12, 13, 9].type = BlockType.Air;
                    blocks[3, 14, 3].type = BlockType.Air;
                    blocks[12, 14, 3].type = BlockType.Air;
                    for (int x = 1; x <= 4; x++) { blocks[x, 14, 4].type = BlockType.Air; }
                    blocks[1, 14, 5].type = BlockType.Air;
                    blocks[3, 14, 5].type = BlockType.Air;
                    blocks[6, 14, 5].type = BlockType.Air;
                    blocks[7, 14, 5].type = BlockType.Air;
                    blocks[8, 14, 5].type = BlockType.Air;
                    blocks[1, 14, 6].type = BlockType.Air;
                    blocks[2, 14, 6].type = BlockType.Air;
                    blocks[3, 14, 6].type = BlockType.Air;
                }
                break;
            case 11:
                {
                    blocks[1, 1, 1].type = BlockType.Start;
                    blocks[2, 1, 1].type = BlockType.Air;
                    blocks[3, 1, 1].type = BlockType.Air;
                    blocks[4, 1, 1].type = BlockType.Air;
                    blocks[5, 1, 1].type = BlockType.Air;
                    blocks[6, 1, 1].type = BlockType.Air;
                    blocks[7, 1, 1].type = BlockType.Air;
                    blocks[8, 1, 1].type = BlockType.Air;
                    blocks[10, 1, 1].type = BlockType.Air;
                    blocks[11, 1, 1].type = BlockType.Air;
                    blocks[12, 1, 1].type = BlockType.Air;
                    blocks[13, 1, 1].type = BlockType.Air;
                    blocks[1, 1, 2].type = BlockType.Air;
                    blocks[5, 1, 2].type = BlockType.Air;
                    blocks[7, 1, 2].type = BlockType.Air;
                    blocks[10, 1, 2].type = BlockType.Air;
                    blocks[13, 1, 2].type = BlockType.Air;
                    blocks[1, 1, 3].type = BlockType.Air;
                    blocks[3, 1, 3].type = BlockType.Air;
                    blocks[7, 1, 3].type = BlockType.Air;
                    blocks[9, 1, 3].type = BlockType.Air;
                    blocks[10, 1, 3].type = BlockType.Air;
                    blocks[11, 1, 3].type = BlockType.Air;
                    blocks[13, 1, 3].type = BlockType.Air;
                    blocks[1, 1, 4].type = BlockType.Air;
                    blocks[3, 1, 4].type = BlockType.Air;
                    blocks[5, 1, 4].type = BlockType.Air;
                    blocks[7, 1, 4].type = BlockType.Air;
                    blocks[9, 1, 4].type = BlockType.Air;
                    blocks[13, 1, 4].type = BlockType.Air;
                    blocks[1, 1, 5].type = BlockType.Air;
                    blocks[3, 1, 5].type = BlockType.Air;
                    blocks[4, 1, 5].type = BlockType.Air;
                    blocks[5, 1, 5].type = BlockType.Air;
                    blocks[7, 1, 5].type = BlockType.Air;
                    blocks[8, 1, 5].type = BlockType.Air;
                    blocks[9, 1, 5].type = BlockType.Air;
                    blocks[11, 1, 5].type = BlockType.Air;
                    blocks[12, 1, 5].type = BlockType.Air;
                    blocks[13, 1, 5].type = BlockType.Air;
                    blocks[5, 1, 6].type = BlockType.Air;
                    blocks[11, 1, 6].type = BlockType.Air;
                    blocks[13, 1, 6].type = BlockType.Air;
                    blocks[1, 1, 7].type = BlockType.Air;
                    blocks[2, 1, 7].type = BlockType.Air;
                    blocks[3, 1, 7].type = BlockType.Air;
                    blocks[4, 1, 7].type = BlockType.Air;
                    blocks[5, 1, 7].type = BlockType.Air;
                    blocks[6, 1, 7].type = BlockType.Air;
                    blocks[7, 1, 7].type = BlockType.Air;
                    blocks[8, 1, 7].type = BlockType.Air;
                    blocks[9, 1, 7].type = BlockType.Air;
                    blocks[10, 1, 7].type = BlockType.Air;
                    blocks[11, 1, 7].type = BlockType.Air;
                    blocks[13, 1, 7].type = BlockType.Air;
                    blocks[3, 1, 8].type = BlockType.Air;
                    blocks[7, 1, 8].type = BlockType.Air;
                    blocks[11, 1, 8].type = BlockType.Air;
                    blocks[13, 1, 8].type = BlockType.Air;
                    blocks[1, 1, 9].type = BlockType.Air;
                    blocks[2, 1, 9].type = BlockType.Air;
                    blocks[3, 1, 9].type = BlockType.Air;
                    blocks[5, 1, 9].type = BlockType.Air;
                    blocks[6, 1, 9].type = BlockType.Air;
                    blocks[7, 1, 9].type = BlockType.Air;
                    blocks[8, 1, 9].type = BlockType.Air;
                    blocks[9, 1, 9].type = BlockType.Air;
                    blocks[11, 1, 9].type = BlockType.Air;
                    blocks[13, 1, 9].type = BlockType.Air;
                    blocks[1, 1, 10].type = BlockType.Air;
                    blocks[11, 1, 10].type = BlockType.Air;
                    blocks[13, 1, 10].type = BlockType.Lock; blocks[13, 1, 10].index = 1;
                    blocks[1, 1, 11].type = BlockType.Air;
                    blocks[3, 1, 11].type = BlockType.Key; blocks[3, 1, 11].index = 1;
                    blocks[4, 1, 11].type = BlockType.Air;
                    blocks[5, 1, 11].type = BlockType.Air;
                    blocks[7, 1, 11].type = BlockType.Air;
                    blocks[8, 1, 11].type = BlockType.Air;
                    blocks[9, 1, 11].type = BlockType.Air;
                    blocks[10, 1, 11].type = BlockType.Air;
                    blocks[11, 1, 11].type = BlockType.Air;
                    blocks[13, 1, 11].type = BlockType.Air;
                    blocks[1, 1, 12].type = BlockType.Air;
                    blocks[5, 1, 12].type = BlockType.Air;
                    blocks[7, 1, 12].type = BlockType.Air;
                    blocks[11, 1, 12].type = BlockType.Air;
                    blocks[13, 1, 12].type = BlockType.Air;
                    blocks[1, 1, 13].type = BlockType.Air;
                    blocks[2, 1, 13].type = BlockType.Air;
                    blocks[3, 1, 13].type = BlockType.Air;
                    blocks[4, 1, 13].type = BlockType.Air;
                    blocks[5, 1, 13].type = BlockType.Air;
                    blocks[6, 1, 13].type = BlockType.Air;
                    blocks[7, 1, 13].type = BlockType.Air;
                    blocks[9, 1, 13].type = BlockType.Air;
                    blocks[10, 1, 13].type = BlockType.Air;
                    blocks[11, 1, 13].type = BlockType.Air;
                    blocks[13, 1, 13].type = BlockType.Exit;
                }
                break;
            case 12:
                {
                    blocks[1, 1, 1].type = BlockType.Start;
                    blocks[2, 1, 1].type = BlockType.Air;
                    blocks[3, 1, 1].type = BlockType.Air;
                    blocks[3, 1, 2].type = BlockType.Air;
                    blocks[3, 1, 3].type = BlockType.Air;
                    blocks[3, 1, 4].type = BlockType.Air;
                    blocks[3, 1, 5].type = BlockType.Air;
                    blocks[4, 1, 5].type = BlockType.Air;
                    blocks[5, 1, 5].type = BlockType.Air;
                    blocks[6, 1, 5].type = BlockType.Air;
                    blocks[7, 1, 5].type = BlockType.Air;
                    blocks[7, 1, 9].type = BlockType.Air;
                    blocks[8, 1, 9].type = BlockType.Air;
                    blocks[9, 1, 9].type = BlockType.Lock; blocks[9, 1, 9].index = 1;
                    blocks[10, 1, 9].type = BlockType.Air;
                    blocks[11, 1, 9].type = BlockType.Air;
                    blocks[11, 1, 10].type = BlockType.Air;
                    blocks[11, 1, 11].type = BlockType.Air;
                    blocks[11, 1, 12].type = BlockType.Air;
                    blocks[11, 1, 13].type = BlockType.Air;
                    blocks[12, 1, 13].type = BlockType.Air;
                    blocks[13, 1, 13].type = BlockType.Exit;
                    blocks[7, 2, 5].type = BlockType.Air;
                    blocks[7, 2, 6].type = BlockType.Air;
                    blocks[7, 2, 7].type = BlockType.Key; blocks[7, 2, 7].index = 1;
                    blocks[7, 2, 8].type = BlockType.Air;
                    blocks[7, 2, 9].type = BlockType.Air;
                }
                break;
            case 13:
                {
                    blocks[1, 1, 1].type = BlockType.Start;
                    blocks[5, 1, 1].type = BlockType.Key; blocks[5, 1, 1].index = 1;
                    blocks[6, 1, 1].type = BlockType.Air;
                    blocks[7, 1, 1].type = BlockType.Air;
                    blocks[8, 1, 1].type = BlockType.Air;
                    blocks[9, 1, 1].type = BlockType.Air;
                    blocks[13, 1, 1].type = BlockType.Exit;
                    blocks[1, 1, 2].type = BlockType.Air;
                    blocks[13, 1, 2].type = BlockType.Air;
                    blocks[1, 1, 3].type = BlockType.Air;
                    blocks[5, 1, 3].type = BlockType.Air;
                    blocks[6, 1, 3].type = BlockType.Air;
                    blocks[7, 1, 3].type = BlockType.Air;
                    blocks[8, 1, 3].type = BlockType.Air;
                    blocks[9, 1, 3].type = BlockType.Air;
                    blocks[13, 1, 3].type = BlockType.Lock; blocks[13, 1, 3].index = 1;
                    blocks[1, 1, 4].type = BlockType.Air;
                    blocks[13, 1, 4].type = BlockType.Air;
                    blocks[1, 1, 5].type = BlockType.Air;
                    blocks[5, 1, 5].type = BlockType.Air;
                    blocks[6, 1, 5].type = BlockType.Air;
                    blocks[7, 1, 5].type = BlockType.Air;
                    blocks[8, 1, 5].type = BlockType.Air;
                    blocks[9, 1, 5].type = BlockType.Air;
                    blocks[13, 1, 5].type = BlockType.Key; blocks[13, 1, 5].index = 2;
                    blocks[1, 1, 6].type = BlockType.Air;
                    blocks[13, 1, 6].type = BlockType.Air;
                    blocks[1, 1, 7].type = BlockType.Air;
                    blocks[5, 1, 7].type = BlockType.Air;
                    blocks[6, 1, 7].type = BlockType.Air;
                    blocks[7, 1, 7].type = BlockType.Air;
                    blocks[8, 1, 7].type = BlockType.Air;
                    blocks[9, 1, 7].type = BlockType.Air;
                    blocks[13, 1, 7].type = BlockType.Air;
                    blocks[9, 2, 1].type = BlockType.Air;
                    blocks[9, 2, 2].type = BlockType.Air;
                    blocks[5, 2, 3].type = BlockType.Air;
                    blocks[9, 2, 3].type = BlockType.Air;
                    blocks[5, 2, 4].type = BlockType.Lock; blocks[5, 2, 4].index = 2;
                    blocks[5, 2, 5].type = BlockType.Air;
                    blocks[9, 2, 5].type = BlockType.Air;
                    blocks[9, 2, 6].type = BlockType.Air;
                    blocks[1, 2, 7].type = BlockType.Air;
                    blocks[2, 2, 7].type = BlockType.Air;
                    blocks[3, 2, 7].type = BlockType.Air;
                    blocks[4, 2, 7].type = BlockType.Air;
                    blocks[5, 2, 7].type = BlockType.Air;
                    blocks[9, 2, 7].type = BlockType.Air;
                    blocks[10, 2, 7].type = BlockType.Air;
                    blocks[11, 2, 7].type = BlockType.Air;
                    blocks[12, 2, 7].type = BlockType.Air;
                    blocks[13, 2, 7].type = BlockType.Air;
                }
                break;
            case 14:
                {
                    blocks[1, 1, 1].type = BlockType.Start;
                    blocks[3, 1, 1].type = BlockType.Air;
                    blocks[4, 1, 1].type = BlockType.Air;
                    blocks[5, 1, 1].type = BlockType.Air;
                    blocks[6, 1, 1].type = BlockType.Air;
                    blocks[8, 1, 1].type = BlockType.Air;
                    blocks[9, 1, 1].type = BlockType.Air;
                    blocks[10, 1, 1].type = BlockType.Air;
                    blocks[12, 1, 1].type = BlockType.Air;
                    blocks[13, 1, 1].type = BlockType.Air;
                    blocks[1, 1, 2].type = BlockType.Air;
                    blocks[4, 1, 2].type = BlockType.Air;
                    blocks[6, 1, 2].type = BlockType.Air;
                    blocks[7, 1, 2].type = BlockType.Lock; blocks[7, 1, 2].index = 3;
                    blocks[8, 1, 2].type = BlockType.Air;
                    blocks[10, 1, 2].type = BlockType.Air;
                    blocks[12, 1, 2].type = BlockType.Air;
                    blocks[1, 1, 3].type = BlockType.Air;
                    blocks[2, 1, 3].type = BlockType.Air;
                    blocks[3, 1, 3].type = BlockType.Air;
                    blocks[4, 1, 3].type = BlockType.Air;
                    blocks[10, 1, 3].type = BlockType.Air;
                    blocks[11, 1, 3].type = BlockType.Air;
                    blocks[12, 1, 3].type = BlockType.Air;
                    blocks[3, 1, 4].type = BlockType.Air;
                    blocks[6, 1, 4].type = BlockType.Air;
                    blocks[7, 1, 4].type = BlockType.Air;
                    blocks[8, 1, 4].type = BlockType.Air;
                    blocks[10, 1, 4].type = BlockType.Air;
                    blocks[1, 1, 5].type = BlockType.Air;
                    blocks[2, 1, 5].type = BlockType.Air;
                    blocks[3, 1, 5].type = BlockType.Air;
                    blocks[5, 1, 5].type = BlockType.Air;
                    blocks[6, 1, 5].type = BlockType.Air;
                    blocks[8, 1, 5].type = BlockType.Air;
                    blocks[1, 1, 6].type = BlockType.Air;
                    blocks[5, 1, 6].type = BlockType.Air;
                    blocks[1, 1, 7].type = BlockType.Air;
                    blocks[2, 1, 7].type = BlockType.Air;
                    blocks[3, 1, 7].type = BlockType.Air;
                    blocks[4, 1, 7].type = BlockType.Air;
                    blocks[5, 1, 7].type = BlockType.Air;
                    blocks[6, 1, 7].type = BlockType.Air;
                    blocks[7, 1, 7].type = BlockType.Air;
                    blocks[2, 1, 8].type = BlockType.Air;
                    blocks[4, 1, 8].type = BlockType.Air;
                    blocks[1, 1, 9].type = BlockType.Air;
                    blocks[2, 1, 9].type = BlockType.Air;
                    blocks[4, 1, 9].type = BlockType.Air;
                    blocks[1, 1, 10].type = BlockType.Air;
                    blocks[1, 1, 11].type = BlockType.Air;
                    blocks[2, 1, 11].type = BlockType.Air;
                    blocks[3, 1, 11].type = BlockType.Air;
                    blocks[1, 1, 12].type = BlockType.Air;
                    blocks[1, 1, 13].type = BlockType.Air;
                    blocks[13, 2, 1].type = BlockType.Air;
                    blocks[13, 2, 2].type = BlockType.Air;
                    blocks[13, 2, 3].type = BlockType.Key; blocks[13, 2, 3].index = 2;
                    blocks[10, 2, 4].type = BlockType.Air;
                    blocks[8, 2, 5].type = BlockType.Air;
                    blocks[10, 2, 5].type = BlockType.Air;
                    blocks[11, 2, 5].type = BlockType.Air;
                    blocks[12, 2, 5].type = BlockType.Air;
                    blocks[13, 2, 5].type = BlockType.Air;
                    blocks[13, 2, 6].type = BlockType.Air;
                    blocks[7, 2, 7].type = BlockType.Air;
                    blocks[8, 2, 7].type = BlockType.Air;
                    blocks[9, 2, 7].type = BlockType.Air;
                    blocks[10, 2, 7].type = BlockType.Air;
                    blocks[11, 2, 7].type = BlockType.Air;
                    blocks[13, 2, 7].type = BlockType.Air;
                    blocks[8, 2, 8].type = BlockType.Air;
                    blocks[10, 2, 8].type = BlockType.Air;
                    blocks[4, 2, 9].type = BlockType.Air;
                    blocks[5, 2, 9].type = BlockType.Lock; blocks[5, 2, 9].index = 2;
                    blocks[6, 2, 9].type = BlockType.Air;
                    blocks[8, 2, 9].type = BlockType.Air;
                    blocks[10, 2, 9].type = BlockType.Air;
                    blocks[11, 2, 9].type = BlockType.Air;
                    blocks[6, 2, 10].type = BlockType.Key; blocks[6, 2, 10].index = 1;
                    blocks[3, 2, 11].type = BlockType.Air;
                    blocks[4, 2, 11].type = BlockType.Air;
                    blocks[5, 2, 11].type = BlockType.Lock; blocks[5, 2, 11].index = 2;
                    blocks[6, 2, 11].type = BlockType.Air;
                    blocks[8, 2, 11].type = BlockType.Air;
                    blocks[9, 2, 11].type = BlockType.Air;
                    blocks[10, 2, 11].type = BlockType.Air;
                    blocks[8, 2, 12].type = BlockType.Air;
                    blocks[10, 2, 12].type = BlockType.Air;
                    blocks[1, 2, 13].type = BlockType.Air;
                    blocks[2, 2, 13].type = BlockType.Air;
                    blocks[3, 2, 13].type = BlockType.Air;
                    blocks[4, 2, 13].type = BlockType.Air;
                    blocks[5, 2, 13].type = BlockType.Air;
                    blocks[6, 2, 13].type = BlockType.Air;
                    blocks[7, 2, 13].type = BlockType.Air;
                    blocks[8, 2, 13].type = BlockType.Air;
                    blocks[10, 2, 13].type = BlockType.Key; blocks[10, 2, 13].index = 3;
                    blocks[11, 3, 7].type = BlockType.Air;
                    blocks[13, 3, 7].type = BlockType.Air;
                    blocks[13, 3, 8].type = BlockType.Air;
                    blocks[11, 3, 9].type = BlockType.Air;
                    blocks[12, 3, 9].type = BlockType.Air;
                    blocks[13, 3, 9].type = BlockType.Air;
                    blocks[13, 3, 10].type = BlockType.Lock; blocks[13, 3, 10].index = 1;
                    blocks[12, 3, 11].type = BlockType.Air;
                    blocks[13, 3, 11].type = BlockType.Air;
                    blocks[12, 3, 12].type = BlockType.Air;
                    blocks[12, 3, 13].type = BlockType.Air;
                    blocks[13, 3, 13].type = BlockType.Exit;
                }
                break;
            case 15:
                {
                    blocks[7, 1, 1].type = BlockType.Air;
                    blocks[7, 1, 2].type = BlockType.Air;
                    blocks[7, 1, 3].type = BlockType.Air;
                    blocks[7, 1, 5].type = BlockType.Air;
                    blocks[7, 1, 6].type = BlockType.Air;
                    blocks[1, 1, 7].type = BlockType.Air;
                    blocks[2, 1, 7].type = BlockType.Air;
                    blocks[3, 1, 7].type = BlockType.Air;
                    blocks[5, 1, 7].type = BlockType.Air;
                    blocks[6, 1, 7].type = BlockType.Air;
                    blocks[7, 1, 7].type = BlockType.Start;
                    blocks[8, 1, 7].type = BlockType.Air;
                    blocks[9, 1, 7].type = BlockType.Air;
                    blocks[11, 1, 7].type = BlockType.Air;
                    blocks[12, 1, 7].type = BlockType.Air;
                    blocks[13, 1, 7].type = BlockType.Air;
                    blocks[7, 1, 8].type = BlockType.Air;
                    blocks[7, 1, 9].type = BlockType.Air;
                    blocks[7, 1, 11].type = BlockType.Air;
                    blocks[7, 1, 12].type = BlockType.Air;
                    blocks[7, 1, 13].type = BlockType.Air;
                    blocks[1, 2, 1].type = BlockType.Air;
                    blocks[2, 2, 1].type = BlockType.Air;
                    blocks[3, 2, 1].type = BlockType.Lock; blocks[3, 2, 1].index = 3;
                    blocks[4, 2, 1].type = BlockType.Air;
                    blocks[5, 2, 1].type = BlockType.Air;
                    blocks[7, 2, 1].type = BlockType.Air;
                    blocks[8, 2, 1].type = BlockType.Air;
                    blocks[9, 2, 1].type = BlockType.Air;
                    blocks[10, 2, 1].type = BlockType.Air;
                    blocks[1, 2, 2].type = BlockType.Air;
                    blocks[5, 2, 2].type = BlockType.Air;
                    blocks[10, 2, 2].type = BlockType.Air;
                    blocks[1, 2, 3].type = BlockType.Air;
                    blocks[3, 2, 3].type = BlockType.Air;
                    blocks[4, 2, 3].type = BlockType.Air;
                    blocks[5, 2, 3].type = BlockType.Air;
                    blocks[7, 2, 3].type = BlockType.Air;
                    blocks[10, 2, 3].type = BlockType.Air;
                    blocks[1, 2, 4].type = BlockType.Air;
                    blocks[7, 2, 4].type = BlockType.Air;
                    blocks[10, 2, 4].type = BlockType.Air;
                    blocks[11, 2, 4].type = BlockType.Air;
                    blocks[12, 2, 4].type = BlockType.Key; blocks[12, 2, 4].index = 3;
                    blocks[1, 2, 5].type = BlockType.Air;
                    blocks[2, 2, 5].type = BlockType.Air;
                    blocks[3, 2, 5].type = BlockType.Air;
                    blocks[4, 2, 5].type = BlockType.Air;
                    blocks[5, 2, 5].type = BlockType.Air;
                    blocks[7, 2, 5].type = BlockType.Air;
                    blocks[5, 2, 6].type = BlockType.Air;
                    blocks[1, 2, 7].type = BlockType.Air;
                    blocks[3, 2, 7].type = BlockType.Air;
                    blocks[5, 2, 7].type = BlockType.Air;
                    blocks[9, 2, 7].type = BlockType.Air;
                    blocks[11, 2, 7].type = BlockType.Air;
                    blocks[13, 2, 7].type = BlockType.Air;
                    blocks[7, 2, 9].type = BlockType.Air;
                    blocks[8, 2, 9].type = BlockType.Air;
                    blocks[9, 2, 9].type = BlockType.Air;
                    blocks[9, 2, 10].type = BlockType.Air;
                    blocks[10, 2, 10].type = BlockType.Air;
                    blocks[7, 2, 11].type = BlockType.Air;
                    blocks[10, 2, 11].type = BlockType.Air;
                    blocks[11, 2, 11].type = BlockType.Air;
                    blocks[11, 2, 12].type = BlockType.Air;
                    blocks[12, 2, 12].type = BlockType.Air;
                    blocks[7, 2, 13].type = BlockType.Air;
                    blocks[12, 2, 13].type = BlockType.Air;
                    blocks[13, 2, 13].type = BlockType.Air;
                    blocks[3, 3, 3].type = BlockType.Air;
                    blocks[1, 3, 7].type = BlockType.Air;
                    blocks[3, 3, 7].type = BlockType.Air;
                    blocks[11, 3, 7].type = BlockType.Air;
                    blocks[13, 3, 7].type = BlockType.Air;
                    blocks[1, 3, 8].type = BlockType.Air;
                    blocks[1, 3, 9].type = BlockType.Air;
                    blocks[13, 3, 9].type = BlockType.Key; blocks[13, 3, 9].index = 1;
                    blocks[1, 3, 10].type = BlockType.Air;
                    blocks[13, 3, 10].type = BlockType.Air;
                    blocks[1, 3, 11].type = BlockType.Air;
                    blocks[13, 3, 11].type = BlockType.Lock; blocks[13, 3, 11].index = 2;
                    blocks[1, 3, 12].type = BlockType.Key; blocks[1, 3, 12].index = 2;
                    blocks[13, 3, 12].type = BlockType.Air;
                    blocks[13, 3, 13].type = BlockType.Air;
                    blocks[3, 4, 3].type = BlockType.Air;
                    blocks[4, 4, 3].type = BlockType.Air;
                    blocks[5, 4, 3].type = BlockType.Air;
                    blocks[6, 4, 3].type = BlockType.Air;
                    blocks[7, 4, 3].type = BlockType.Air;
                    blocks[8, 4, 3].type = BlockType.Air;
                    blocks[9, 4, 3].type = BlockType.Air;
                    blocks[10, 4, 3].type = BlockType.Air;
                    blocks[11, 4, 3].type = BlockType.Air;
                    blocks[3, 4, 4].type = BlockType.Air;
                    blocks[7, 4, 4].type = BlockType.Air;
                    blocks[11, 4, 4].type = BlockType.Air;
                    blocks[3, 4, 5].type = BlockType.Air;
                    blocks[11, 4, 5].type = BlockType.Air;
                    blocks[3, 4, 6].type = BlockType.Air;
                    blocks[11, 4, 6].type = BlockType.Air;
                    blocks[3, 4, 7].type = BlockType.Air;
                    blocks[4, 4, 7].type = BlockType.Air;
                    blocks[10, 4, 7].type = BlockType.Air;
                    blocks[11, 4, 7].type = BlockType.Air;
                    blocks[3, 4, 8].type = BlockType.Air;
                    blocks[11, 4, 8].type = BlockType.Air;
                    blocks[3, 4, 9].type = BlockType.Air;
                    blocks[11, 4, 9].type = BlockType.Air;
                    blocks[3, 4, 10].type = BlockType.Air;
                    blocks[7, 4, 10].type = BlockType.Air;
                    blocks[11, 4, 10].type = BlockType.Air;
                    blocks[3, 4, 11].type = BlockType.Air;
                    blocks[4, 4, 11].type = BlockType.Air;
                    blocks[5, 4, 11].type = BlockType.Air;
                    blocks[6, 4, 11].type = BlockType.Air;
                    blocks[7, 4, 11].type = BlockType.Air;
                    blocks[8, 4, 11].type = BlockType.Air;
                    blocks[9, 4, 11].type = BlockType.Air;
                    blocks[10, 4, 11].type = BlockType.Air;
                    blocks[11, 4, 11].type = BlockType.Air;
                    blocks[7, 5, 4].type = BlockType.Air;
                    blocks[7, 5, 5].type = BlockType.Air;
                    blocks[7, 5, 6].type = BlockType.Lock; blocks[7, 5, 6].index = 1;
                    blocks[4, 5, 7].type = BlockType.Air;
                    blocks[5, 5, 7].type = BlockType.Air;
                    blocks[6, 5, 7].type = BlockType.Lock; blocks[6, 5, 7].index = 1;
                    blocks[7, 5, 7].type = BlockType.Exit;
                    blocks[8, 5, 7].type = BlockType.Lock; blocks[8, 5, 7].index = 1;
                    blocks[9, 5, 7].type = BlockType.Air;
                    blocks[10, 5, 7].type = BlockType.Air;
                    blocks[7, 5, 8].type = BlockType.Lock; blocks[7, 5, 8].index = 1;
                    blocks[7, 5, 9].type = BlockType.Air;
                    blocks[7, 5, 10].type = BlockType.Air;
                }
                break;
            case 16:
                {
                    blocks[1, 1, 1].type = BlockType.Air;
                    blocks[2, 1, 1].type = BlockType.Air;
                    blocks[3, 1, 1].type = BlockType.Air;
                    blocks[4, 1, 1].type = BlockType.Air;
                    blocks[5, 1, 1].type = BlockType.Air;
                    blocks[8, 1, 1].type = BlockType.Air;
                    blocks[9, 1, 1].type = BlockType.Air;
                    blocks[11, 1, 1].type = BlockType.Key; blocks[11, 1, 1].index = 3;
                    blocks[12, 1, 1].type = BlockType.Air;
                    blocks[13, 1, 1].type = BlockType.Air;
                    blocks[1, 1, 2].type = BlockType.Air;
                    blocks[5, 1, 2].type = BlockType.Air;
                    blocks[6, 1, 2].type = BlockType.Air;
                    blocks[8, 1, 2].type = BlockType.Air;
                    blocks[3, 1, 3].type = BlockType.Air;
                    blocks[6, 1, 3].type = BlockType.Air;
                    blocks[7, 1, 3].type = BlockType.Air;
                    blocks[8, 1, 3].type = BlockType.Air;
                    blocks[10, 1, 3].type = BlockType.Air;
                    blocks[11, 1, 3].type = BlockType.Air;
                    blocks[12, 1, 3].type = BlockType.Air;
                    blocks[13, 1, 3].type = BlockType.Air;
                    blocks[1, 1, 4].type = BlockType.Air;
                    blocks[2, 1, 4].type = BlockType.Air;
                    blocks[3, 1, 4].type = BlockType.Air;
                    blocks[4, 1, 4].type = BlockType.Key; blocks[4, 1, 4].index = 2;
                    blocks[10, 1, 4].type = BlockType.Air;
                    blocks[1, 1, 5].type = BlockType.Air;
                    blocks[3, 1, 5].type = BlockType.Air;
                    blocks[6, 1, 5].type = BlockType.Air;
                    blocks[7, 1, 5].type = BlockType.Air;
                    blocks[8, 1, 5].type = BlockType.Air;
                    blocks[10, 1, 5].type = BlockType.Air;
                    blocks[13, 1, 5].type = BlockType.Air;
                    blocks[5, 1, 6].type = BlockType.Air;
                    blocks[6, 1, 6].type = BlockType.Air;
                    blocks[8, 1, 6].type = BlockType.Air;
                    blocks[10, 1, 6].type = BlockType.Air;
                    blocks[11, 1, 6].type = BlockType.Key; blocks[11, 1, 6].index = 1;
                    blocks[13, 1, 6].type = BlockType.Air;
                    blocks[1, 1, 7].type = BlockType.Air;
                    blocks[2, 1, 7].type = BlockType.Air;
                    blocks[3, 1, 7].type = BlockType.Air;
                    blocks[4, 1, 7].type = BlockType.Air;
                    blocks[5, 1, 7].type = BlockType.Air;
                    blocks[8, 1, 7].type = BlockType.Air;
                    blocks[1, 1, 8].type = BlockType.Air;
                    blocks[7, 1, 8].type = BlockType.Air;
                    blocks[8, 1, 8].type = BlockType.Air;
                    blocks[10, 1, 8].type = BlockType.Air;
                    blocks[11, 1, 8].type = BlockType.Air;
                    blocks[12, 1, 8].type = BlockType.Air;
                    blocks[13, 1, 8].type = BlockType.Air;
                    blocks[3, 1, 9].type = BlockType.Air;
                    blocks[4, 1, 9].type = BlockType.Air;
                    blocks[5, 1, 9].type = BlockType.Air;
                    blocks[6, 1, 9].type = BlockType.Air;
                    blocks[7, 1, 9].type = BlockType.Air;
                    blocks[11, 1, 9].type = BlockType.Air;
                    blocks[1, 1, 10].type = BlockType.Air;
                    blocks[9, 1, 10].type = BlockType.Air;
                    blocks[11, 1, 10].type = BlockType.Air;
                    blocks[13, 1, 10].type = BlockType.Air;
                    blocks[1, 1, 11].type = BlockType.Air;
                    blocks[2, 1, 11].type = BlockType.Air;
                    blocks[3, 1, 11].type = BlockType.Air;
                    blocks[4, 1, 11].type = BlockType.Air;
                    blocks[5, 1, 11].type = BlockType.Air;
                    blocks[6, 1, 11].type = BlockType.Air;
                    blocks[8, 1, 11].type = BlockType.Air;
                    blocks[9, 1, 11].type = BlockType.Air;
                    blocks[11, 1, 11].type = BlockType.Air;
                    blocks[13, 1, 11].type = BlockType.Air;
                    blocks[1, 1, 12].type = BlockType.Air;
                    blocks[8, 1, 12].type = BlockType.Air;
                    blocks[13, 1, 12].type = BlockType.Air;
                    blocks[1, 1, 13].type = BlockType.Air;
                    blocks[2, 1, 13].type = BlockType.Air;
                    blocks[4, 1, 13].type = BlockType.Air;
                    blocks[5, 1, 13].type = BlockType.Air;
                    blocks[6, 1, 13].type = BlockType.Air;
                    blocks[7, 1, 13].type = BlockType.Air;
                    blocks[8, 1, 13].type = BlockType.Air;
                    blocks[9, 1, 13].type = BlockType.Air;
                    blocks[10, 1, 13].type = BlockType.Air;
                    blocks[11, 1, 13].type = BlockType.Air;
                    blocks[12, 1, 13].type = BlockType.Air;
                    blocks[13, 1, 13].type = BlockType.Air;
                    blocks[13, 2, 1].type = BlockType.Air;
                    blocks[1, 2, 2].type = BlockType.Air;
                    blocks[13, 2, 3].type = BlockType.Air;
                    blocks[1, 2, 5].type = BlockType.Air;
                    blocks[13, 2, 6].type = BlockType.Air;
                    blocks[1, 2, 8].type = BlockType.Air;
                    blocks[13, 2, 8].type = BlockType.Air;
                    blocks[11, 2, 11].type = BlockType.Air;
                    blocks[2, 2, 13].type = BlockType.Air;
                    blocks[4, 2, 13].type = BlockType.Air;
                    blocks[1, 3, 1].type = BlockType.Air;
                    blocks[2, 3, 1].type = BlockType.Air;
                    blocks[3, 3, 1].type = BlockType.Air;
                    blocks[5, 3, 1].type = BlockType.Air;
                    blocks[6, 3, 1].type = BlockType.Air;
                    blocks[7, 3, 1].type = BlockType.Air;
                    blocks[9, 3, 1].type = BlockType.Air;
                    blocks[11, 3, 1].type = BlockType.Air;
                    blocks[12, 3, 1].type = BlockType.Air;
                    blocks[13, 3, 1].type = BlockType.Air;
                    blocks[1, 3, 2].type = BlockType.Air;
                    blocks[3, 3, 2].type = BlockType.Air;
                    blocks[4, 3, 2].type = BlockType.Air;
                    blocks[5, 3, 2].type = BlockType.Air;
                    blocks[7, 3, 2].type = BlockType.Air;
                    blocks[9, 3, 2].type = BlockType.Air;
                    blocks[10, 3, 2].type = BlockType.Air;
                    blocks[11, 3, 2].type = BlockType.Air;
                    blocks[5, 3, 3].type = BlockType.Air;
                    blocks[7, 3, 3].type = BlockType.Air;
                    blocks[8, 3, 3].type = BlockType.Air;
                    blocks[9, 3, 3].type = BlockType.Air;
                    blocks[13, 3, 3].type = BlockType.Air;
                    blocks[1, 3, 4].type = BlockType.Air;
                    blocks[2, 3, 4].type = BlockType.Air;
                    blocks[3, 3, 4].type = BlockType.Air;
                    blocks[5, 3, 4].type = BlockType.Air;
                    blocks[11, 3, 4].type = BlockType.Air;
                    blocks[12, 3, 4].type = BlockType.Air;
                    blocks[13, 3, 4].type = BlockType.Air;
                    blocks[1, 3, 5].type = BlockType.Air;
                    blocks[3, 3, 5].type = BlockType.Air;
                    blocks[5, 3, 5].type = BlockType.Air;
                    blocks[6, 3, 5].type = BlockType.Air;
                    blocks[7, 3, 5].type = BlockType.Air;
                    blocks[8, 3, 5].type = BlockType.Lock; blocks[8, 3, 5].index = 2;
                    blocks[9, 3, 5].type = BlockType.Air;
                    blocks[10, 3, 5].type = BlockType.Air;
                    blocks[11, 3, 5].type = BlockType.Air;
                    blocks[3, 3, 6].type = BlockType.Air;
                    blocks[5, 3, 6].type = BlockType.Air;
                    blocks[11, 3, 6].type = BlockType.Air;
                    blocks[12, 3, 6].type = BlockType.Air;
                    blocks[13, 3, 6].type = BlockType.Air;
                    blocks[1, 3, 7].type = BlockType.Air;
                    blocks[2, 3, 7].type = BlockType.Air;
                    blocks[3, 3, 7].type = BlockType.Air;
                    blocks[5, 3, 7].type = BlockType.Air;
                    blocks[7, 3, 7].type = BlockType.Air;
                    blocks[8, 3, 7].type = BlockType.Air;
                    blocks[9, 3, 7].type = BlockType.Air;
                    blocks[1, 3, 8].type = BlockType.Air;
                    blocks[3, 3, 8].type = BlockType.Air;
                    blocks[5, 3, 8].type = BlockType.Air;
                    blocks[9, 3, 8].type = BlockType.Air;
                    blocks[10, 3, 8].type = BlockType.Air;
                    blocks[11, 3, 8].type = BlockType.Air;
                    blocks[12, 3, 8].type = BlockType.Air;
                    blocks[13, 3, 8].type = BlockType.Air;
                    blocks[3, 3, 9].type = BlockType.Air;
                    blocks[4, 3, 9].type = BlockType.Lock; blocks[4, 3, 9].index = 3;
                    blocks[5, 3, 9].type = BlockType.Air;
                    blocks[6, 3, 9].type = BlockType.Air;
                    blocks[7, 3, 9].type = BlockType.Air;
                    blocks[8, 3, 9].type = BlockType.Air;
                    blocks[9, 3, 9].type = BlockType.Air;
                    blocks[1, 3, 10].type = BlockType.Air;
                    blocks[9, 3, 10].type = BlockType.Air;
                    blocks[11, 3, 10].type = BlockType.Air;
                    blocks[12, 3, 10].type = BlockType.Air;
                    blocks[13, 3, 10].type = BlockType.Air;
                    blocks[1, 3, 11].type = BlockType.Air;
                    blocks[2, 3, 11].type = BlockType.Air;
                    blocks[3, 3, 11].type = BlockType.Air;
                    blocks[4, 3, 11].type = BlockType.Air;
                    blocks[5, 3, 11].type = BlockType.Air;
                    blocks[6, 3, 11].type = BlockType.Air;
                    blocks[7, 3, 11].type = BlockType.Air;
                    blocks[9, 3, 11].type = BlockType.Air;
                    blocks[11, 3, 11].type = BlockType.Air;
                    blocks[13, 3, 11].type = BlockType.Air;
                    blocks[1, 3, 12].type = BlockType.Air;
                    blocks[5, 3, 12].type = BlockType.Air;
                    blocks[7, 3, 12].type = BlockType.Air;
                    blocks[9, 3, 12].type = BlockType.Air;
                    blocks[13, 3, 12].type = BlockType.Air;
                    blocks[1, 3, 13].type = BlockType.Air;
                    blocks[2, 3, 13].type = BlockType.Air;
                    blocks[4, 3, 13].type = BlockType.Air;
                    blocks[5, 3, 13].type = BlockType.Air;
                    blocks[7, 3, 13].type = BlockType.Air;
                    blocks[8, 3, 13].type = BlockType.Air;
                    blocks[9, 3, 13].type = BlockType.Air;
                    blocks[10, 3, 13].type = BlockType.Air;
                    blocks[11, 3, 13].type = BlockType.Air;
                    blocks[12, 3, 13].type = BlockType.Air;
                    blocks[13, 3, 13].type = BlockType.Air;
                    blocks[7, 4, 7].type = BlockType.Air;
                    blocks[5, 5, 2].type = BlockType.Lock; blocks[5, 5, 2].index = 1;
                    blocks[7, 5, 2].type = BlockType.Lock; blocks[7, 5, 2].index = 1;
                    blocks[9, 5, 2].type = BlockType.Lock; blocks[9, 5, 2].index = 1;
                    blocks[5, 5, 3].type = BlockType.Air;
                    blocks[7, 5, 3].type = BlockType.Air;
                    blocks[9, 5, 3].type = BlockType.Air;
                    blocks[5, 5, 4].type = BlockType.Air;
                    blocks[7, 5, 4].type = BlockType.Air;
                    blocks[9, 5, 4].type = BlockType.Air;
                    blocks[2, 5, 5].type = BlockType.Lock; blocks[2, 5, 5].index = 1;
                    blocks[3, 5, 5].type = BlockType.Air;
                    blocks[4, 5, 5].type = BlockType.Air;
                    blocks[5, 5, 5].type = BlockType.Air;
                    blocks[6, 5, 5].type = BlockType.Air;
                    blocks[7, 5, 5].type = BlockType.Air;
                    blocks[8, 5, 5].type = BlockType.Air;
                    blocks[9, 5, 5].type = BlockType.Air;
                    blocks[10, 5, 5].type = BlockType.Air;
                    blocks[11, 5, 5].type = BlockType.Air;
                    blocks[12, 5, 5].type = BlockType.Lock; blocks[12, 5, 5].index = 1;
                    blocks[5, 5, 6].type = BlockType.Air;
                    blocks[9, 5, 6].type = BlockType.Air;
                    blocks[2, 5, 7].type = BlockType.Lock; blocks[2, 5, 7].index = 1;
                    blocks[3, 5, 7].type = BlockType.Air;
                    blocks[4, 5, 7].type = BlockType.Air;
                    blocks[5, 5, 7].type = BlockType.Air;
                    blocks[7, 5, 7].type = BlockType.Start;
                    blocks[9, 5, 7].type = BlockType.Air;
                    blocks[10, 5, 7].type = BlockType.Air;
                    blocks[11, 5, 7].type = BlockType.Air;
                    blocks[12, 5, 7].type = BlockType.Lock; blocks[12, 5, 7].index = 1;
                    blocks[5, 5, 8].type = BlockType.Air;
                    blocks[7, 5, 8].type = BlockType.Air;
                    blocks[9, 5, 8].type = BlockType.Air;
                    blocks[2, 5, 9].type = BlockType.Lock; blocks[2, 5, 9].index = 1;
                    blocks[3, 5, 9].type = BlockType.Air;
                    blocks[4, 5, 9].type = BlockType.Air;
                    blocks[5, 5, 9].type = BlockType.Air;
                    blocks[6, 5, 9].type = BlockType.Air;
                    blocks[7, 5, 9].type = BlockType.Air;
                    blocks[8, 5, 9].type = BlockType.Air;
                    blocks[9, 5, 9].type = BlockType.Air;
                    blocks[10, 5, 9].type = BlockType.Air;
                    blocks[11, 5, 9].type = BlockType.Air;
                    blocks[12, 5, 9].type = BlockType.Lock; blocks[12, 5, 9].index = 1;
                    blocks[5, 5, 10].type = BlockType.Air;
                    blocks[7, 5, 10].type = BlockType.Air;
                    blocks[9, 5, 10].type = BlockType.Air;
                    blocks[5, 5, 11].type = BlockType.Air;
                    blocks[7, 5, 11].type = BlockType.Air;
                    blocks[9, 5, 11].type = BlockType.Air;
                    blocks[5, 5, 12].type = BlockType.Lock; blocks[5, 5, 12].index = 1;
                    blocks[7, 5, 12].type = BlockType.Lock; blocks[7, 5, 12].index = 1;
                    blocks[9, 5, 12].type = BlockType.Lock; blocks[9, 5, 12].index = 1;
                    blocks[2, 6, 5].type = BlockType.Air;
                    blocks[12, 6, 7].type = BlockType.Air;
                    blocks[9, 6, 12].type = BlockType.Air;
                    blocks[1, 7, 1].type = BlockType.Air;
                    blocks[2, 7, 1].type = BlockType.Air;
                    blocks[3, 7, 1].type = BlockType.Air;
                    blocks[5, 7, 1].type = BlockType.Air;
                    blocks[6, 7, 1].type = BlockType.Air;
                    blocks[7, 7, 1].type = BlockType.Air;
                    blocks[8, 7, 1].type = BlockType.Air;
                    blocks[9, 7, 1].type = BlockType.Air;
                    blocks[11, 7, 1].type = BlockType.Air;
                    blocks[12, 7, 1].type = BlockType.Air;
                    blocks[13, 7, 1].type = BlockType.Air;
                    blocks[1, 7, 2].type = BlockType.Air;
                    blocks[3, 7, 2].type = BlockType.Air;
                    blocks[5, 7, 2].type = BlockType.Air;
                    blocks[7, 7, 2].type = BlockType.Air;
                    blocks[9, 7, 2].type = BlockType.Air;
                    blocks[11, 7, 2].type = BlockType.Air;
                    blocks[12, 7, 2].type = BlockType.Air;
                    blocks[13, 7, 2].type = BlockType.Air;
                    blocks[1, 7, 3].type = BlockType.Air;
                    blocks[3, 7, 3].type = BlockType.Air;
                    blocks[4, 7, 3].type = BlockType.Air;
                    blocks[5, 7, 3].type = BlockType.Air;
                    blocks[7, 7, 3].type = BlockType.Air;
                    blocks[9, 7, 3].type = BlockType.Air;
                    blocks[10, 7, 3].type = BlockType.Air;
                    blocks[11, 7, 3].type = BlockType.Air;
                    blocks[12, 7, 3].type = BlockType.Air;
                    blocks[13, 7, 3].type = BlockType.Air;
                    blocks[1, 7, 4].type = BlockType.Air;
                    blocks[4, 7, 4].type = BlockType.Air;
                    blocks[7, 7, 4].type = BlockType.Air;
                    blocks[1, 7, 5].type = BlockType.Air;
                    blocks[2, 7, 5].type = BlockType.Air;
                    blocks[4, 7, 5].type = BlockType.Air;
                    blocks[6, 7, 5].type = BlockType.Air;
                    blocks[7, 7, 5].type = BlockType.Air;
                    blocks[9, 7, 5].type = BlockType.Air;
                    blocks[10, 7, 5].type = BlockType.Air;
                    blocks[12, 7, 5].type = BlockType.Air;
                    blocks[4, 7, 6].type = BlockType.Air;
                    blocks[10, 7, 6].type = BlockType.Air;
                    blocks[12, 7, 6].type = BlockType.Air;
                    blocks[13, 7, 6].type = BlockType.Air;
                    blocks[1, 7, 7].type = BlockType.Air;
                    blocks[2, 7, 7].type = BlockType.Air;
                    blocks[3, 7, 7].type = BlockType.Air;
                    blocks[4, 7, 7].type = BlockType.Air;
                    blocks[5, 7, 7].type = BlockType.Air;
                    blocks[8, 7, 7].type = BlockType.Air;
                    blocks[10, 7, 7].type = BlockType.Air;
                    blocks[12, 7, 7].type = BlockType.Air;
                    blocks[1, 7, 8].type = BlockType.Air;
                    blocks[3, 7, 8].type = BlockType.Air;
                    blocks[5, 7, 8].type = BlockType.Air;
                    blocks[6, 7, 8].type = BlockType.Air;
                    blocks[8, 7, 8].type = BlockType.Air;
                    blocks[9, 7, 8].type = BlockType.Air;
                    blocks[10, 7, 8].type = BlockType.Air;
                    blocks[12, 7, 8].type = BlockType.Air;
                    blocks[13, 7, 8].type = BlockType.Air;
                    blocks[1, 7, 9].type = BlockType.Air;
                    blocks[3, 7, 9].type = BlockType.Air;
                    blocks[5, 7, 9].type = BlockType.Air;
                    blocks[9, 7, 9].type = BlockType.Air;
                    blocks[13, 7, 9].type = BlockType.Air;
                    blocks[1, 7, 10].type = BlockType.Air;
                    blocks[3, 7, 10].type = BlockType.Air;
                    blocks[7, 7, 10].type = BlockType.Air;
                    blocks[8, 7, 10].type = BlockType.Air;
                    blocks[9, 7, 10].type = BlockType.Air;
                    blocks[10, 7, 10].type = BlockType.Air;
                    blocks[11, 7, 10].type = BlockType.Air;
                    blocks[1, 7, 11].type = BlockType.Air;
                    blocks[3, 7, 11].type = BlockType.Air;
                    blocks[4, 7, 11].type = BlockType.Air;
                    blocks[6, 7, 11].type = BlockType.Air;
                    blocks[7, 7, 11].type = BlockType.Air;
                    blocks[11, 7, 11].type = BlockType.Air;
                    blocks[12, 7, 11].type = BlockType.Air;
                    blocks[13, 7, 11].type = BlockType.Air;
                    blocks[1, 7, 12].type = BlockType.Air;
                    blocks[9, 7, 12].type = BlockType.Air;
                    blocks[13, 7, 12].type = BlockType.Air;
                    blocks[1, 7, 13].type = BlockType.Air;
                    blocks[3, 7, 13].type = BlockType.Air;
                    blocks[4, 7, 13].type = BlockType.Air;
                    blocks[5, 7, 13].type = BlockType.Air;
                    blocks[6, 7, 13].type = BlockType.Air;
                    blocks[7, 7, 13].type = BlockType.Air;
                    blocks[8, 7, 13].type = BlockType.Air;
                    blocks[9, 7, 13].type = BlockType.Air;
                    blocks[10, 7, 13].type = BlockType.Air;
                    blocks[11, 7, 13].type = BlockType.Air;
                    blocks[12, 7, 13].type = BlockType.Air;
                    blocks[13, 7, 13].type = BlockType.Air;
                    blocks[12, 8, 2].type = BlockType.Air;
                    blocks[6, 8, 5].type = BlockType.Air;
                    blocks[9, 8, 5].type = BlockType.Air;
                    blocks[12, 8, 5].type = BlockType.Air;
                    blocks[13, 8, 6].type = BlockType.Air;
                    blocks[6, 8, 8].type = BlockType.Air;
                    blocks[13, 8, 9].type = BlockType.Air;
                    blocks[6, 8, 11].type = BlockType.Air;
                    blocks[1, 8, 13].type = BlockType.Air;
                    blocks[3, 8, 13].type = BlockType.Air;
                    blocks[1, 9, 1].type = BlockType.Air;
                    blocks[3, 9, 1].type = BlockType.Air;
                    blocks[4, 9, 1].type = BlockType.Air;
                    blocks[5, 9, 1].type = BlockType.Air;
                    blocks[6, 9, 1].type = BlockType.Air;
                    blocks[7, 9, 1].type = BlockType.Air;
                    blocks[8, 9, 1].type = BlockType.Air;
                    blocks[12, 9, 1].type = BlockType.Air;
                    blocks[3, 9, 2].type = BlockType.Air;
                    blocks[8, 9, 2].type = BlockType.Air;
                    blocks[9, 9, 2].type = BlockType.Air;
                    blocks[10, 9, 2].type = BlockType.Air;
                    blocks[11, 9, 2].type = BlockType.Air;
                    blocks[12, 9, 2].type = BlockType.Air;
                    blocks[13, 9, 2].type = BlockType.Air;
                    blocks[1, 9, 3].type = BlockType.Air;
                    blocks[3, 9, 3].type = BlockType.Air;
                    blocks[5, 9, 3].type = BlockType.Air;
                    blocks[12, 9, 3].type = BlockType.Air;
                    blocks[2, 9, 4].type = BlockType.Air;
                    blocks[3, 9, 4].type = BlockType.Air;
                    blocks[4, 9, 4].type = BlockType.Air;
                    blocks[8, 9, 4].type = BlockType.Air;
                    blocks[9, 9, 4].type = BlockType.Air;
                    blocks[10, 9, 4].type = BlockType.Air;
                    blocks[3, 9, 5].type = BlockType.Air;
                    blocks[6, 9, 5].type = BlockType.Air;
                    blocks[9, 9, 5].type = BlockType.Air;
                    blocks[12, 9, 5].type = BlockType.Air;
                    blocks[1, 9, 6].type = BlockType.Air;
                    blocks[9, 9, 6].type = BlockType.Air;
                    blocks[13, 9, 6].type = BlockType.Air;
                    blocks[1, 9, 7].type = BlockType.Air;
                    blocks[3, 9, 7].type = BlockType.Air;
                    blocks[5, 9, 7].type = BlockType.Air;
                    blocks[8, 9, 7].type = BlockType.Air;
                    blocks[9, 9, 7].type = BlockType.Air;
                    blocks[11, 9, 7].type = BlockType.Air;
                    blocks[12, 9, 7].type = BlockType.Air;
                    blocks[13, 9, 7].type = BlockType.Air;
                    blocks[1, 9, 8].type = BlockType.Air;
                    blocks[5, 9, 8].type = BlockType.Air;
                    blocks[6, 9, 8].type = BlockType.Air;
                    blocks[11, 9, 8].type = BlockType.Air;
                    blocks[3, 9, 9].type = BlockType.Air;
                    blocks[8, 9, 9].type = BlockType.Air;
                    blocks[9, 9, 9].type = BlockType.Air;
                    blocks[10, 9, 9].type = BlockType.Air;
                    blocks[11, 9, 9].type = BlockType.Air;
                    blocks[13, 9, 9].type = BlockType.Air;
                    blocks[1, 9, 10].type = BlockType.Air;
                    blocks[2, 9, 10].type = BlockType.Air;
                    blocks[3, 9, 10].type = BlockType.Air;
                    blocks[5, 9, 10].type = BlockType.Air;
                    blocks[8, 9, 10].type = BlockType.Air;
                    blocks[11, 9, 10].type = BlockType.Air;
                    blocks[1, 9, 11].type = BlockType.Air;
                    blocks[3, 9, 11].type = BlockType.Key; blocks[3, 9, 11].index = 4;
                    blocks[5, 9, 11].type = BlockType.Air;
                    blocks[6, 9, 11].type = BlockType.Air;
                    blocks[8, 9, 11].type = BlockType.Air;
                    blocks[9, 9, 11].type = BlockType.Air;
                    blocks[11, 9, 11].type = BlockType.Air;
                    blocks[12, 9, 11].type = BlockType.Air;
                    blocks[13, 9, 11].type = BlockType.Air;
                    blocks[1, 9, 12].type = BlockType.Air;
                    blocks[9, 9, 12].type = BlockType.Air;
                    blocks[1, 9, 13].type = BlockType.Air;
                    blocks[3, 9, 13].type = BlockType.Air;
                    blocks[4, 9, 13].type = BlockType.Air;
                    blocks[5, 9, 13].type = BlockType.Air;
                    blocks[6, 9, 13].type = BlockType.Air;
                    blocks[7, 9, 13].type = BlockType.Air;
                    blocks[9, 9, 13].type = BlockType.Air;
                    blocks[10, 9, 13].type = BlockType.Air;
                    blocks[11, 9, 13].type = BlockType.Lock; blocks[11, 9, 13].index = 4;
                    blocks[12, 9, 13].type = BlockType.Air;
                    blocks[13, 9, 13].type = BlockType.Exit;
                }
                break;
            case 17:
                {
                    blocks[7, 1, 7].type = BlockType.Start;
                    blocks[7, 2, 7].type = BlockType.Air;
                    blocks[6, 3, 6].type = BlockType.Air;
                    blocks[7, 3, 6].type = BlockType.Air;
                    blocks[8, 3, 6].type = BlockType.Air;
                    blocks[6, 3, 7].type = BlockType.Air;
                    blocks[7, 3, 7].type = BlockType.Air;
                    blocks[8, 3, 7].type = BlockType.Air;
                    blocks[6, 3, 8].type = BlockType.Air;
                    blocks[7, 3, 8].type = BlockType.Air;
                    blocks[8, 3, 8].type = BlockType.Air;
                    blocks[6, 4, 6].type = BlockType.Air;
                    blocks[8, 4, 6].type = BlockType.Air;
                    blocks[6, 4, 8].type = BlockType.Air;
                    blocks[8, 4, 8].type = BlockType.Air;
                    blocks[5, 5, 5].type = BlockType.Air;
                    blocks[6, 5, 5].type = BlockType.Air;
                    blocks[8, 5, 5].type = BlockType.Air;
                    blocks[9, 5, 5].type = BlockType.Air;
                    blocks[5, 5, 6].type = BlockType.Air;
                    blocks[6, 5, 6].type = BlockType.Air;
                    blocks[8, 5, 6].type = BlockType.Air;
                    blocks[9, 5, 6].type = BlockType.Air;
                    blocks[7, 5, 7].type = BlockType.Key; blocks[7, 5, 7].index = 3;
                    blocks[5, 5, 8].type = BlockType.Air;
                    blocks[6, 5, 8].type = BlockType.Air;
                    blocks[8, 5, 8].type = BlockType.Air;
                    blocks[9, 5, 8].type = BlockType.Air;
                    blocks[5, 5, 9].type = BlockType.Air;
                    blocks[6, 5, 9].type = BlockType.Air;
                    blocks[8, 5, 9].type = BlockType.Air;
                    blocks[9, 5, 9].type = BlockType.Air;
                    blocks[5, 6, 5].type = BlockType.Air;
                    blocks[9, 6, 5].type = BlockType.Air;
                    blocks[7, 6, 7].type = BlockType.Air;
                    blocks[5, 6, 9].type = BlockType.Air;
                    blocks[9, 6, 9].type = BlockType.Air;
                    blocks[5, 7, 5].type = BlockType.Air;
                    blocks[6, 7, 5].type = BlockType.Air;
                    blocks[7, 7, 5].type = BlockType.Air;
                    blocks[9, 7, 5].type = BlockType.Air;
                    blocks[5, 7, 6].type = BlockType.Lock; blocks[5, 7, 6].index = 1;
                    blocks[9, 7, 6].type = BlockType.Lock; blocks[9, 7, 6].index = 3;
                    blocks[5, 7, 7].type = BlockType.Key; blocks[5, 7, 7].index = 2;
                    blocks[7, 7, 7].type = BlockType.Air;
                    blocks[9, 7, 7].type = BlockType.Key; blocks[9, 7, 7].index = 4;
                    blocks[7, 7, 8].type = BlockType.Lock; blocks[7, 7, 8].index = 2;
                    blocks[5, 7, 9].type = BlockType.Air;
                    blocks[7, 7, 9].type = BlockType.Air;
                    blocks[8, 7, 9].type = BlockType.Air;
                    blocks[9, 7, 9].type = BlockType.Air;
                    blocks[5, 8, 9].type = BlockType.Air;
                    blocks[4, 9, 4].type = BlockType.Air;
                    blocks[5, 9, 4].type = BlockType.Air;
                    blocks[9, 9, 4].type = BlockType.Air;
                    blocks[10, 9, 4].type = BlockType.Air;
                    blocks[4, 9, 5].type = BlockType.Air;
                    blocks[5, 9, 5].type = BlockType.Air;
                    blocks[6, 9, 5].type = BlockType.Air;
                    blocks[7, 9, 5].type = BlockType.Lock; blocks[7, 9, 5].index = 4;
                    blocks[8, 9, 5].type = BlockType.Air;
                    blocks[9, 9, 5].type = BlockType.Air;
                    blocks[10, 9, 5].type = BlockType.Air;
                    blocks[5, 9, 6].type = BlockType.Air;
                    blocks[9, 9, 6].type = BlockType.Air;
                    blocks[4, 9, 7].type = BlockType.Air;
                    blocks[5, 9, 7].type = BlockType.Air;
                    blocks[7, 9, 7].type = BlockType.Air;
                    blocks[8, 9, 7].type = BlockType.Air;
                    blocks[9, 9, 7].type = BlockType.Air;
                    blocks[10, 9, 7].type = BlockType.Air;
                    blocks[7, 9, 8].type = BlockType.Air;
                    blocks[10, 9, 8].type = BlockType.Air;
                    blocks[4, 9, 9].type = BlockType.Air;
                    blocks[5, 9, 9].type = BlockType.Air;
                    blocks[6, 9, 9].type = BlockType.Air;
                    blocks[7, 9, 9].type = BlockType.Air;
                    blocks[9, 9, 9].type = BlockType.Air;
                    blocks[10, 9, 9].type = BlockType.Air;
                    blocks[4, 9, 10].type = BlockType.Air;
                    blocks[5, 9, 10].type = BlockType.Air;
                    blocks[9, 9, 10].type = BlockType.Key; blocks[9, 9, 10].index = 1;
                    blocks[10, 9, 10].type = BlockType.Air;
                    blocks[4, 10, 4].type = BlockType.Air;
                    blocks[10, 10, 4].type = BlockType.Air;
                    blocks[4, 10, 10].type = BlockType.Air;
                    blocks[10, 10, 10].type = BlockType.Air;
                    blocks[2, 11, 2].type = BlockType.Air;
                    blocks[3, 11, 2].type = BlockType.Air;
                    blocks[4, 11, 2].type = BlockType.Air;
                    blocks[5, 11, 2].type = BlockType.Air;
                    blocks[6, 11, 2].type = BlockType.Air;
                    blocks[8, 11, 2].type = BlockType.Air;
                    blocks[9, 11, 2].type = BlockType.Air;
                    blocks[10, 11, 2].type = BlockType.Air;
                    blocks[11, 11, 2].type = BlockType.Air;
                    blocks[12, 11, 2].type = BlockType.Air;
                    blocks[6, 11, 3].type = BlockType.Air;
                    blocks[8, 11, 3].type = BlockType.Air;
                    blocks[2, 11, 4].type = BlockType.Air;
                    blocks[3, 11, 4].type = BlockType.Air;
                    blocks[4, 11, 4].type = BlockType.Air;
                    blocks[6, 11, 4].type = BlockType.Air;
                    blocks[7, 11, 4].type = BlockType.Air;
                    blocks[8, 11, 4].type = BlockType.Air;
                    blocks[10, 11, 4].type = BlockType.Air;
                    blocks[11, 11, 4].type = BlockType.Air;
                    blocks[12, 11, 4].type = BlockType.Air;
                    blocks[2, 11, 5].type = BlockType.Air;
                    blocks[12, 11, 5].type = BlockType.Air;
                    blocks[2, 11, 6].type = BlockType.Air;
                    blocks[3, 11, 6].type = BlockType.Air;
                    blocks[4, 11, 6].type = BlockType.Air;
                    blocks[7, 11, 6].type = BlockType.Air;
                    blocks[10, 11, 6].type = BlockType.Air;
                    blocks[12, 11, 6].type = BlockType.Air;
                    blocks[4, 11, 7].type = BlockType.Air;
                    blocks[6, 11, 7].type = BlockType.Air;
                    blocks[7, 11, 7].type = BlockType.Exit;
                    blocks[8, 11, 7].type = BlockType.Air;
                    blocks[10, 11, 7].type = BlockType.Air;
                    blocks[2, 11, 8].type = BlockType.Air;
                    blocks[3, 11, 8].type = BlockType.Air;
                    blocks[4, 11, 8].type = BlockType.Air;
                    blocks[7, 11, 8].type = BlockType.Air;
                    blocks[10, 11, 8].type = BlockType.Air;
                    blocks[11, 11, 8].type = BlockType.Air;
                    blocks[12, 11, 8].type = BlockType.Air;
                    blocks[2, 11, 9].type = BlockType.Air;
                    blocks[12, 11, 9].type = BlockType.Air;
                    blocks[2, 11, 10].type = BlockType.Air;
                    blocks[4, 11, 10].type = BlockType.Air;
                    blocks[6, 11, 10].type = BlockType.Air;
                    blocks[7, 11, 10].type = BlockType.Air;
                    blocks[8, 11, 10].type = BlockType.Air;
                    blocks[9, 11, 10].type = BlockType.Air;
                    blocks[10, 11, 10].type = BlockType.Air;
                    blocks[12, 11, 10].type = BlockType.Air;
                    blocks[4, 11, 11].type = BlockType.Air;
                    blocks[10, 11, 11].type = BlockType.Air;
                    blocks[12, 11, 11].type = BlockType.Air;
                    blocks[2, 11, 12].type = BlockType.Air;
                    blocks[3, 11, 12].type = BlockType.Air;
                    blocks[4, 11, 12].type = BlockType.Air;
                    blocks[5, 11, 12].type = BlockType.Air;
                    blocks[6, 11, 12].type = BlockType.Air;
                    blocks[8, 11, 12].type = BlockType.Air;
                    blocks[9, 11, 12].type = BlockType.Air;
                    blocks[10, 11, 12].type = BlockType.Air;
                    blocks[11, 11, 12].type = BlockType.Air;
                    blocks[12, 11, 12].type = BlockType.Air;
                    blocks[2, 12, 2].type = BlockType.Air;
                    blocks[12, 12, 2].type = BlockType.Air;
                    blocks[7, 12, 6].type = BlockType.Air;
                    blocks[10, 12, 6].type = BlockType.Air;
                    blocks[12, 12, 6].type = BlockType.Air;
                    blocks[6, 12, 7].type = BlockType.Air;
                    blocks[8, 12, 7].type = BlockType.Air;
                    blocks[7, 12, 8].type = BlockType.Air;
                    blocks[2, 12, 10].type = BlockType.Air;
                    blocks[2, 13, 2].type = BlockType.Air;
                    blocks[3, 13, 2].type = BlockType.Air;
                    blocks[4, 13, 2].type = BlockType.Air;
                    blocks[5, 13, 2].type = BlockType.Air;
                    blocks[10, 13, 2].type = BlockType.Air;
                    blocks[11, 13, 2].type = BlockType.Air;
                    blocks[12, 13, 2].type = BlockType.Air;
                    blocks[5, 13, 3].type = BlockType.Air;
                    blocks[6, 13, 3].type = BlockType.Air;
                    blocks[7, 13, 3].type = BlockType.Air;
                    blocks[8, 13, 3].type = BlockType.Air;
                    blocks[10, 13, 3].type = BlockType.Air;
                    blocks[2, 13, 4].type = BlockType.Air;
                    blocks[5, 13, 4].type = BlockType.Air;
                    blocks[8, 13, 4].type = BlockType.Air;
                    blocks[10, 13, 4].type = BlockType.Air;
                    blocks[11, 13, 4].type = BlockType.Air;
                    blocks[12, 13, 4].type = BlockType.Air;
                    blocks[2, 13, 5].type = BlockType.Air;
                    blocks[3, 13, 5].type = BlockType.Air;
                    blocks[4, 13, 5].type = BlockType.Air;
                    blocks[5, 13, 5].type = BlockType.Air;
                    blocks[12, 13, 5].type = BlockType.Air;
                    blocks[2, 13, 6].type = BlockType.Air;
                    blocks[4, 13, 6].type = BlockType.Air;
                    blocks[7, 13, 6].type = BlockType.Air;
                    blocks[12, 13, 6].type = BlockType.Air;
                    blocks[4, 13, 7].type = BlockType.Air;
                    blocks[6, 13, 7].type = BlockType.Air;
                    blocks[8, 13, 7].type = BlockType.Air;
                    blocks[9, 13, 7].type = BlockType.Lock; blocks[9, 13, 7].index = 5;
                    blocks[10, 13, 7].type = BlockType.Air;
                    blocks[2, 13, 8].type = BlockType.Key; blocks[2, 13, 8].index = 5;
                    blocks[3, 13, 8].type = BlockType.Air;
                    blocks[4, 13, 8].type = BlockType.Air;
                    blocks[7, 13, 8].type = BlockType.Air;
                    blocks[10, 13, 8].type = BlockType.Air;
                    blocks[12, 13, 8].type = BlockType.Air;
                    blocks[9, 13, 9].type = BlockType.Air;
                    blocks[10, 13, 9].type = BlockType.Air;
                    blocks[11, 13, 9].type = BlockType.Air;
                    blocks[12, 13, 9].type = BlockType.Air;
                    blocks[2, 13, 10].type = BlockType.Air;
                    blocks[3, 13, 10].type = BlockType.Air;
                    blocks[4, 13, 10].type = BlockType.Air;
                    blocks[5, 13, 10].type = BlockType.Air;
                    blocks[6, 13, 10].type = BlockType.Air;
                    blocks[7, 13, 10].type = BlockType.Air;
                    blocks[9, 13, 10].type = BlockType.Air;
                    blocks[11, 13, 10].type = BlockType.Air;
                    blocks[4, 13, 11].type = BlockType.Air;
                    blocks[9, 13, 11].type = BlockType.Air;
                    blocks[11, 13, 11].type = BlockType.Air;
                    blocks[2, 13, 12].type = BlockType.Air;
                    blocks[3, 13, 12].type = BlockType.Air;
                    blocks[4, 13, 12].type = BlockType.Air;
                    blocks[5, 13, 12].type = BlockType.Air;
                    blocks[6, 13, 12].type = BlockType.Air;
                    blocks[7, 13, 12].type = BlockType.Air;
                    blocks[8, 13, 12].type = BlockType.Air;
                    blocks[9, 13, 12].type = BlockType.Air;
                    blocks[10, 13, 12].type = BlockType.Air;
                    blocks[11, 13, 12].type = BlockType.Air;
                    blocks[12, 13, 12].type = BlockType.Air;
                }
                break;
            case 18:
                {
                    for (int x = 0; x <= 14; x++)
                        for (int y = 0; y <= 14; y++)
                            for (int z = 0; z <= 14; z++)
                                blocks[x, y, z].type = BlockType.Air;
                    blocks[7, 0, 7].type = BlockType.Start;
                    blocks[6, 4, 6].type = BlockType.Glass;
                    blocks[7, 4, 6].type = BlockType.Glass;
                    blocks[8, 4, 6].type = BlockType.Glass;
                    blocks[6, 4, 7].type = BlockType.Glass;
                    blocks[7, 4, 7].type = BlockType.Glass;
                    blocks[8, 4, 7].type = BlockType.Glass;
                    blocks[6, 4, 8].type = BlockType.Glass;
                    blocks[7, 4, 8].type = BlockType.Glass;
                    blocks[8, 4, 8].type = BlockType.Glass;
                    blocks[6, 5, 6].type = BlockType.Glass;
                    blocks[7, 5, 6].type = BlockType.Lock; blocks[7, 5, 6].index = 5;
                    blocks[8, 5, 6].type = BlockType.Glass;
                    blocks[6, 5, 7].type = BlockType.Glass;
                    blocks[7, 5, 7].type = BlockType.Exit;
                    blocks[8, 5, 7].type = BlockType.Glass;
                    blocks[6, 5, 8].type = BlockType.Glass;
                    blocks[7, 5, 8].type = BlockType.Glass;
                    blocks[8, 5, 8].type = BlockType.Glass;
                    blocks[1, 5, 11].type = BlockType.Glass;
                    blocks[2, 5, 11].type = BlockType.Glass;
                    blocks[3, 5, 11].type = BlockType.Glass;
                    blocks[1, 5, 12].type = BlockType.Glass;
                    blocks[2, 5, 12].type = BlockType.Glass;
                    blocks[3, 5, 12].type = BlockType.Glass;
                    blocks[1, 5, 13].type = BlockType.Glass;
                    blocks[2, 5, 13].type = BlockType.Glass;
                    blocks[3, 5, 13].type = BlockType.Glass;
                    blocks[10, 6, 3].type = BlockType.Glass;
                    blocks[11, 6, 3].type = BlockType.Glass;
                    blocks[12, 6, 3].type = BlockType.Glass;
                    blocks[10, 6, 4].type = BlockType.Glass;
                    blocks[11, 6, 4].type = BlockType.Glass;
                    blocks[12, 6, 4].type = BlockType.Glass;
                    blocks[10, 6, 5].type = BlockType.Glass;
                    blocks[11, 6, 5].type = BlockType.Glass;
                    blocks[12, 6, 5].type = BlockType.Glass;
                    blocks[6, 6, 6].type = BlockType.Glass;
                    blocks[7, 6, 6].type = BlockType.Glass;
                    blocks[8, 6, 6].type = BlockType.Glass;
                    blocks[6, 6, 7].type = BlockType.Glass;
                    blocks[7, 6, 7].type = BlockType.Glass;
                    blocks[8, 6, 7].type = BlockType.Glass;
                    blocks[6, 6, 8].type = BlockType.Glass;
                    blocks[7, 6, 8].type = BlockType.Glass;
                    blocks[8, 6, 8].type = BlockType.Glass;
                    blocks[1, 6, 11].type = BlockType.Glass;
                    blocks[2, 6, 11].type = BlockType.Glass;
                    blocks[3, 6, 11].type = BlockType.Glass;
                    blocks[1, 6, 12].type = BlockType.Glass;
                    blocks[2, 6, 12].type = BlockType.Key; blocks[2, 6, 12].index = 4;
                    blocks[3, 6, 12].type = BlockType.Lock; blocks[3, 6, 12].index = 1;
                    blocks[1, 6, 13].type = BlockType.Glass;
                    blocks[2, 6, 13].type = BlockType.Glass;
                    blocks[3, 6, 13].type = BlockType.Glass;
                    blocks[10, 7, 3].type = BlockType.Glass;
                    blocks[11, 7, 3].type = BlockType.Glass;
                    blocks[12, 7, 3].type = BlockType.Glass;
                    blocks[10, 7, 4].type = BlockType.Lock; blocks[10, 7, 4].index = 3;
                    blocks[11, 7, 4].type = BlockType.Key; blocks[11, 7, 4].index = 2;
                    blocks[12, 7, 4].type = BlockType.Glass;
                    blocks[10, 7, 5].type = BlockType.Glass;
                    blocks[11, 7, 5].type = BlockType.Glass;
                    blocks[12, 7, 5].type = BlockType.Glass;
                    blocks[1, 7, 11].type = BlockType.Glass;
                    blocks[2, 7, 11].type = BlockType.Glass;
                    blocks[3, 7, 11].type = BlockType.Glass;
                    blocks[1, 7, 12].type = BlockType.Glass;
                    blocks[2, 7, 12].type = BlockType.Glass;
                    blocks[3, 7, 12].type = BlockType.Glass;
                    blocks[1, 7, 13].type = BlockType.Glass;
                    blocks[2, 7, 13].type = BlockType.Glass;
                    blocks[3, 7, 13].type = BlockType.Glass;
                    blocks[1, 8, 1].type = BlockType.Glass;
                    blocks[2, 8, 1].type = BlockType.Glass;
                    blocks[3, 8, 1].type = BlockType.Glass;
                    blocks[1, 8, 2].type = BlockType.Glass;
                    blocks[2, 8, 2].type = BlockType.Glass;
                    blocks[3, 8, 2].type = BlockType.Glass;
                    blocks[1, 8, 3].type = BlockType.Glass;
                    blocks[2, 8, 3].type = BlockType.Glass;
                    blocks[3, 8, 3].type = BlockType.Glass;
                    blocks[10, 8, 3].type = BlockType.Glass;
                    blocks[11, 8, 3].type = BlockType.Glass;
                    blocks[12, 8, 3].type = BlockType.Glass;
                    blocks[10, 8, 4].type = BlockType.Glass;
                    blocks[11, 8, 4].type = BlockType.Glass;
                    blocks[12, 8, 4].type = BlockType.Glass;
                    blocks[10, 8, 5].type = BlockType.Glass;
                    blocks[11, 8, 5].type = BlockType.Glass;
                    blocks[12, 8, 5].type = BlockType.Glass;
                    blocks[1, 9, 1].type = BlockType.Glass;
                    blocks[2, 9, 1].type = BlockType.Glass;
                    blocks[3, 9, 1].type = BlockType.Glass;
                    blocks[1, 9, 2].type = BlockType.Glass;
                    blocks[2, 9, 2].type = BlockType.Key; blocks[2, 9, 2].index = 5;
                    blocks[3, 9, 2].type = BlockType.Glass;
                    blocks[1, 9, 3].type = BlockType.Glass;
                    blocks[2, 9, 3].type = BlockType.Lock; blocks[2, 9, 3].index = 4;
                    blocks[3, 9, 3].type = BlockType.Glass;
                    blocks[1, 10, 1].type = BlockType.Glass;
                    blocks[2, 10, 1].type = BlockType.Glass;
                    blocks[3, 10, 1].type = BlockType.Glass;
                    blocks[1, 10, 2].type = BlockType.Glass;
                    blocks[2, 10, 2].type = BlockType.Glass;
                    blocks[3, 10, 2].type = BlockType.Glass;
                    blocks[1, 10, 3].type = BlockType.Glass;
                    blocks[2, 10, 3].type = BlockType.Glass;
                    blocks[3, 10, 3].type = BlockType.Glass;
                    blocks[2, 11, 8].type = BlockType.Glass;
                    blocks[3, 11, 8].type = BlockType.Glass;
                    blocks[4, 11, 8].type = BlockType.Glass;
                    blocks[2, 11, 9].type = BlockType.Glass;
                    blocks[3, 11, 9].type = BlockType.Glass;
                    blocks[4, 11, 9].type = BlockType.Glass;
                    blocks[2, 11, 10].type = BlockType.Glass;
                    blocks[3, 11, 10].type = BlockType.Glass;
                    blocks[4, 11, 10].type = BlockType.Glass;
                    blocks[2, 12, 8].type = BlockType.Glass;
                    blocks[3, 12, 8].type = BlockType.Glass;
                    blocks[4, 12, 8].type = BlockType.Glass;
                    blocks[2, 12, 9].type = BlockType.Glass;
                    blocks[3, 12, 9].type = BlockType.Key; blocks[3, 12, 9].index = 3;
                    blocks[4, 12, 9].type = BlockType.Glass;
                    blocks[2, 12, 10].type = BlockType.Glass;
                    blocks[3, 12, 10].type = BlockType.Glass;
                    blocks[4, 12, 10].type = BlockType.Glass;
                    blocks[12, 12, 12].type = BlockType.Glass;
                    blocks[13, 12, 12].type = BlockType.Glass;
                    blocks[14, 12, 12].type = BlockType.Glass;
                    blocks[12, 12, 13].type = BlockType.Glass;
                    blocks[13, 12, 13].type = BlockType.Glass;
                    blocks[14, 12, 13].type = BlockType.Glass;
                    blocks[12, 12, 14].type = BlockType.Glass;
                    blocks[13, 12, 14].type = BlockType.Glass;
                    blocks[14, 12, 14].type = BlockType.Glass;
                    blocks[2, 13, 8].type = BlockType.Glass;
                    blocks[3, 13, 8].type = BlockType.Glass;
                    blocks[4, 13, 8].type = BlockType.Glass;
                    blocks[2, 13, 9].type = BlockType.Glass;
                    blocks[4, 13, 9].type = BlockType.Glass;
                    blocks[2, 13, 10].type = BlockType.Glass;
                    blocks[3, 13, 10].type = BlockType.Glass;
                    blocks[4, 13, 10].type = BlockType.Glass;
                    blocks[12, 13, 12].type = BlockType.Glass;
                    blocks[13, 13, 12].type = BlockType.Glass;
                    blocks[14, 13, 12].type = BlockType.Glass;
                    blocks[12, 13, 13].type = BlockType.Lock; blocks[12, 13, 13].index = 2;
                    blocks[13, 13, 13].type = BlockType.Key; blocks[13, 13, 13].index = 1;
                    blocks[14, 13, 13].type = BlockType.Glass;
                    blocks[12, 13, 14].type = BlockType.Glass;
                    blocks[13, 13, 14].type = BlockType.Glass;
                    blocks[14, 13, 14].type = BlockType.Glass;
                    blocks[12, 14, 12].type = BlockType.Glass;
                    blocks[13, 14, 12].type = BlockType.Glass;
                    blocks[14, 14, 12].type = BlockType.Glass;
                    blocks[12, 14, 13].type = BlockType.Glass;
                    blocks[13, 14, 13].type = BlockType.Glass;
                    blocks[14, 14, 13].type = BlockType.Glass;
                    blocks[12, 14, 14].type = BlockType.Glass;
                    blocks[13, 14, 14].type = BlockType.Glass;
                    blocks[14, 14, 14].type = BlockType.Glass;
                }
                break;
            case 19:
                {
                    blocks[7, 1, 1].type = BlockType.Start;
                    blocks[7, 1, 2].type = BlockType.Air;
                    blocks[7, 1, 3].type = BlockType.Air;
                    blocks[7, 1, 4].type = BlockType.Air;
                    blocks[7, 1, 5].type = BlockType.Air;
                    blocks[7, 1, 6].type = BlockType.Air;
                    blocks[7, 1, 7].type = BlockType.Air;
                    blocks[7, 2, 7].type = BlockType.Air;
                    blocks[7, 3, 7].type = BlockType.Air;
                    blocks[7, 4, 7].type = BlockType.Air;
                    blocks[1, 5, 1].type = BlockType.Air;
                    blocks[2, 5, 1].type = BlockType.Air;
                    blocks[3, 5, 1].type = BlockType.Air;
                    blocks[5, 5, 1].type = BlockType.Air;
                    blocks[7, 5, 1].type = BlockType.Air;
                    blocks[8, 5, 1].type = BlockType.Air;
                    blocks[9, 5, 1].type = BlockType.Air;
                    blocks[10, 5, 1].type = BlockType.Air;
                    blocks[11, 5, 1].type = BlockType.Air;
                    blocks[13, 5, 1].type = BlockType.Air;
                    blocks[1, 5, 2].type = BlockType.Air;
                    blocks[3, 5, 2].type = BlockType.Key; blocks[3, 5, 2].index = 3;
                    blocks[5, 5, 2].type = BlockType.Air;
                    blocks[7, 5, 2].type = BlockType.Air;
                    blocks[9, 5, 2].type = BlockType.Air;
                    blocks[11, 5, 2].type = BlockType.Air;
                    blocks[12, 5, 2].type = BlockType.Air;
                    blocks[13, 5, 2].type = BlockType.Air;
                    blocks[1, 5, 3].type = BlockType.Air;
                    blocks[5, 5, 3].type = BlockType.Air;
                    blocks[6, 5, 3].type = BlockType.Air;
                    blocks[7, 5, 3].type = BlockType.Air;
                    blocks[9, 5, 3].type = BlockType.Air;
                    blocks[1, 5, 4].type = BlockType.Air;
                    blocks[2, 5, 4].type = BlockType.Air;
                    blocks[3, 5, 4].type = BlockType.Air;
                    blocks[7, 5, 4].type = BlockType.Air;
                    blocks[11, 5, 4].type = BlockType.Air;
                    blocks[12, 5, 4].type = BlockType.Air;
                    blocks[13, 5, 4].type = BlockType.Air;
                    blocks[3, 5, 5].type = BlockType.Air;
                    blocks[4, 5, 5].type = BlockType.Air;
                    blocks[5, 5, 5].type = BlockType.Air;
                    blocks[7, 5, 5].type = BlockType.Air;
                    blocks[8, 5, 5].type = BlockType.Air;
                    blocks[9, 5, 5].type = BlockType.Air;
                    blocks[10, 5, 5].type = BlockType.Air;
                    blocks[11, 5, 5].type = BlockType.Air;
                    blocks[13, 5, 5].type = BlockType.Air;
                    blocks[1, 5, 6].type = BlockType.Air;
                    blocks[5, 5, 6].type = BlockType.Air;
                    blocks[9, 5, 6].type = BlockType.Air;
                    blocks[13, 5, 6].type = BlockType.Air;
                    blocks[1, 5, 7].type = BlockType.Air;
                    blocks[2, 5, 7].type = BlockType.Air;
                    blocks[3, 5, 7].type = BlockType.Air;
                    blocks[4, 5, 7].type = BlockType.Air;
                    blocks[5, 5, 7].type = BlockType.Air;
                    blocks[6, 5, 7].type = BlockType.Air;
                    blocks[7, 5, 7].type = BlockType.Air;
                    blocks[8, 5, 7].type = BlockType.Air;
                    blocks[9, 5, 7].type = BlockType.Air;
                    blocks[10, 5, 7].type = BlockType.Air;
                    blocks[11, 5, 7].type = BlockType.Air;
                    blocks[13, 5, 7].type = BlockType.Air;
                    blocks[1, 5, 8].type = BlockType.Air;
                    blocks[5, 5, 8].type = BlockType.Lock; blocks[5, 5, 8].index = 4;
                    blocks[9, 5, 8].type = BlockType.Air;
                    blocks[11, 5, 8].type = BlockType.Air;
                    blocks[13, 5, 8].type = BlockType.Air;
                    blocks[3, 5, 9].type = BlockType.Air;
                    blocks[4, 5, 9].type = BlockType.Air;
                    blocks[5, 5, 9].type = BlockType.Air;
                    blocks[7, 5, 9].type = BlockType.Air;
                    blocks[8, 5, 9].type = BlockType.Air;
                    blocks[9, 5, 9].type = BlockType.Air;
                    blocks[11, 5, 9].type = BlockType.Air;
                    blocks[12, 5, 9].type = BlockType.Air;
                    blocks[13, 5, 9].type = BlockType.Air;
                    blocks[1, 5, 10].type = BlockType.Air;
                    blocks[2, 5, 10].type = BlockType.Air;
                    blocks[3, 5, 10].type = BlockType.Air;
                    blocks[7, 5, 10].type = BlockType.Air;
                    blocks[1, 5, 11].type = BlockType.Air;
                    blocks[5, 5, 11].type = BlockType.Air;
                    blocks[6, 5, 11].type = BlockType.Air;
                    blocks[7, 5, 11].type = BlockType.Air;
                    blocks[9, 5, 11].type = BlockType.Air;
                    blocks[11, 5, 11].type = BlockType.Air;
                    blocks[13, 5, 11].type = BlockType.Air;
                    blocks[1, 5, 12].type = BlockType.Air;
                    blocks[3, 5, 12].type = BlockType.Key; blocks[3, 5, 12].index = 5;
                    blocks[5, 5, 12].type = BlockType.Air;
                    blocks[9, 5, 12].type = BlockType.Air;
                    blocks[10, 5, 12].type = BlockType.Air;
                    blocks[11, 5, 12].type = BlockType.Air;
                    blocks[12, 5, 12].type = BlockType.Air;
                    blocks[13, 5, 12].type = BlockType.Air;
                    blocks[1, 5, 13].type = BlockType.Air;
                    blocks[2, 5, 13].type = BlockType.Air;
                    blocks[3, 5, 13].type = BlockType.Air;
                    blocks[5, 5, 13].type = BlockType.Air;
                    blocks[6, 5, 13].type = BlockType.Air;
                    blocks[7, 5, 13].type = BlockType.Air;
                    blocks[8, 5, 13].type = BlockType.Air;
                    blocks[9, 5, 13].type = BlockType.Air;
                    blocks[11, 5, 13].type = BlockType.Air;
                    blocks[13, 5, 13].type = BlockType.Air;
                    blocks[13, 6, 13].type = BlockType.Air;
                    blocks[1, 7, 1].type = BlockType.Key; blocks[1, 7, 1].index = 1;
                    blocks[4, 7, 1].type = BlockType.Air;
                    blocks[5, 7, 1].type = BlockType.Air;
                    blocks[6, 7, 1].type = BlockType.Air;
                    blocks[8, 7, 1].type = BlockType.Air;
                    blocks[9, 7, 1].type = BlockType.Air;
                    blocks[10, 7, 1].type = BlockType.Air;
                    blocks[11, 7, 1].type = BlockType.Air;
                    blocks[12, 7, 1].type = BlockType.Air;
                    blocks[13, 7, 1].type = BlockType.Air;
                    blocks[1, 7, 2].type = BlockType.Air;
                    blocks[2, 7, 2].type = BlockType.Air;
                    blocks[4, 7, 2].type = BlockType.Air;
                    blocks[6, 7, 2].type = BlockType.Air;
                    blocks[13, 7, 2].type = BlockType.Air;
                    blocks[2, 7, 3].type = BlockType.Air;
                    blocks[4, 7, 3].type = BlockType.Air;
                    blocks[5, 7, 3].type = BlockType.Air;
                    blocks[6, 7, 3].type = BlockType.Air;
                    blocks[7, 7, 3].type = BlockType.Air;
                    blocks[8, 7, 3].type = BlockType.Air;
                    blocks[9, 7, 3].type = BlockType.Air;
                    blocks[10, 7, 3].type = BlockType.Air;
                    blocks[11, 7, 3].type = BlockType.Air;
                    blocks[13, 7, 3].type = BlockType.Air;
                    blocks[1, 7, 4].type = BlockType.Air;
                    blocks[2, 7, 4].type = BlockType.Air;
                    blocks[4, 7, 4].type = BlockType.Air;
                    blocks[9, 7, 4].type = BlockType.Air;
                    blocks[11, 7, 4].type = BlockType.Air;
                    blocks[13, 7, 4].type = BlockType.Air;
                    blocks[1, 7, 5].type = BlockType.Air;
                    blocks[6, 7, 5].type = BlockType.Air;
                    blocks[7, 7, 5].type = BlockType.Air;
                    blocks[8, 7, 5].type = BlockType.Air;
                    blocks[9, 7, 5].type = BlockType.Air;
                    blocks[11, 7, 5].type = BlockType.Air;
                    blocks[12, 7, 5].type = BlockType.Air;
                    blocks[13, 7, 5].type = BlockType.Air;
                    blocks[1, 7, 6].type = BlockType.Air;
                    blocks[2, 7, 6].type = BlockType.Air;
                    blocks[4, 7, 6].type = BlockType.Air;
                    blocks[6, 7, 6].type = BlockType.Key; blocks[6, 7, 6].index = 2;
                    blocks[9, 7, 6].type = BlockType.Air;
                    blocks[12, 7, 6].type = BlockType.Air;
                    blocks[2, 7, 7].type = BlockType.Lock; blocks[2, 7, 7].index = 2;
                    blocks[4, 7, 7].type = BlockType.Air;
                    blocks[8, 7, 7].type = BlockType.Air;
                    blocks[9, 7, 7].type = BlockType.Air;
                    blocks[10, 7, 7].type = BlockType.Air;
                    blocks[12, 7, 7].type = BlockType.Lock; blocks[12, 7, 7].index = 3;
                    blocks[1, 7, 8].type = BlockType.Air;
                    blocks[2, 7, 8].type = BlockType.Air;
                    blocks[4, 7, 8].type = BlockType.Air;
                    blocks[5, 7, 8].type = BlockType.Air;
                    blocks[6, 7, 8].type = BlockType.Air;
                    blocks[9, 7, 8].type = BlockType.Air;
                    blocks[12, 7, 8].type = BlockType.Air;
                    blocks[1, 7, 9].type = BlockType.Air;
                    blocks[4, 7, 9].type = BlockType.Air;
                    blocks[6, 7, 9].type = BlockType.Air;
                    blocks[8, 7, 9].type = BlockType.Air;
                    blocks[9, 7, 9].type = BlockType.Air;
                    blocks[11, 7, 9].type = BlockType.Air;
                    blocks[12, 7, 9].type = BlockType.Air;
                    blocks[13, 7, 9].type = BlockType.Air;
                    blocks[1, 7, 10].type = BlockType.Air;
                    blocks[2, 7, 10].type = BlockType.Air;
                    blocks[6, 7, 10].type = BlockType.Air;
                    blocks[11, 7, 10].type = BlockType.Air;
                    blocks[13, 7, 10].type = BlockType.Air;
                    blocks[2, 7, 11].type = BlockType.Air;
                    blocks[3, 7, 11].type = BlockType.Air;
                    blocks[4, 7, 11].type = BlockType.Air;
                    blocks[5, 7, 11].type = BlockType.Air;
                    blocks[6, 7, 11].type = BlockType.Air;
                    blocks[7, 7, 11].type = BlockType.Air;
                    blocks[8, 7, 11].type = BlockType.Air;
                    blocks[9, 7, 11].type = BlockType.Air;
                    blocks[10, 7, 11].type = BlockType.Air;
                    blocks[11, 7, 11].type = BlockType.Air;
                    blocks[12, 7, 11].type = BlockType.Air;
                    blocks[13, 7, 11].type = BlockType.Air;
                    blocks[2, 7, 12].type = BlockType.Air;
                    blocks[6, 7, 12].type = BlockType.Air;
                    blocks[10, 7, 12].type = BlockType.Air;
                    blocks[1, 7, 13].type = BlockType.Air;
                    blocks[2, 7, 13].type = BlockType.Air;
                    blocks[4, 7, 13].type = BlockType.Air;
                    blocks[5, 7, 13].type = BlockType.Air;
                    blocks[6, 7, 13].type = BlockType.Air;
                    blocks[7, 7, 13].type = BlockType.Air;
                    blocks[8, 7, 13].type = BlockType.Air;
                    blocks[10, 7, 13].type = BlockType.Air;
                    blocks[11, 7, 13].type = BlockType.Air;
                    blocks[12, 7, 13].type = BlockType.Air;
                    blocks[13, 7, 13].type = BlockType.Air;
                    blocks[4, 8, 6].type = BlockType.Air;
                    blocks[1, 9, 1].type = BlockType.Air;
                    blocks[2, 9, 1].type = BlockType.Air;
                    blocks[3, 9, 1].type = BlockType.Air;
                    blocks[4, 9, 1].type = BlockType.Air;
                    blocks[5, 9, 1].type = BlockType.Air;
                    blocks[7, 9, 1].type = BlockType.Air;
                    blocks[8, 9, 1].type = BlockType.Air;
                    blocks[9, 9, 1].type = BlockType.Air;
                    blocks[11, 9, 1].type = BlockType.Air;
                    blocks[12, 9, 1].type = BlockType.Air;
                    blocks[13, 9, 1].type = BlockType.Air;
                    blocks[1, 9, 2].type = BlockType.Air;
                    blocks[5, 9, 2].type = BlockType.Air;
                    blocks[8, 9, 2].type = BlockType.Air;
                    blocks[11, 9, 2].type = BlockType.Air;
                    blocks[13, 9, 2].type = BlockType.Air;
                    blocks[1, 9, 3].type = BlockType.Air;
                    blocks[2, 9, 3].type = BlockType.Air;
                    blocks[4, 9, 3].type = BlockType.Air;
                    blocks[5, 9, 3].type = BlockType.Air;
                    blocks[6, 9, 3].type = BlockType.Air;
                    blocks[8, 9, 3].type = BlockType.Air;
                    blocks[10, 9, 3].type = BlockType.Air;
                    blocks[11, 9, 3].type = BlockType.Air;
                    blocks[2, 9, 4].type = BlockType.Air;
                    blocks[4, 9, 4].type = BlockType.Air;
                    blocks[6, 9, 4].type = BlockType.Lock; blocks[6, 9, 4].index = 1;
                    blocks[8, 9, 4].type = BlockType.Air;
                    blocks[10, 9, 4].type = BlockType.Air;
                    blocks[13, 9, 4].type = BlockType.Air;
                    blocks[1, 9, 5].type = BlockType.Air;
                    blocks[2, 9, 5].type = BlockType.Air;
                    blocks[4, 9, 5].type = BlockType.Air;
                    blocks[6, 9, 5].type = BlockType.Air;
                    blocks[7, 9, 5].type = BlockType.Air;
                    blocks[8, 9, 5].type = BlockType.Air;
                    blocks[9, 9, 5].type = BlockType.Air;
                    blocks[10, 9, 5].type = BlockType.Air;
                    blocks[11, 9, 5].type = BlockType.Air;
                    blocks[12, 9, 5].type = BlockType.Air;
                    blocks[13, 9, 5].type = BlockType.Air;
                    blocks[4, 9, 6].type = BlockType.Air;
                    blocks[11, 9, 6].type = BlockType.Air;
                    blocks[13, 9, 6].type = BlockType.Air;
                    blocks[1, 9, 7].type = BlockType.Air;
                    blocks[2, 9, 7].type = BlockType.Air;
                    blocks[6, 9, 7].type = BlockType.Air;
                    blocks[7, 9, 7].type = BlockType.Air;
                    blocks[8, 9, 7].type = BlockType.Air;
                    blocks[9, 9, 7].type = BlockType.Air;
                    blocks[11, 9, 7].type = BlockType.Air;
                    blocks[13, 9, 7].type = BlockType.Key; blocks[13, 9, 7].index = 4;
                    blocks[1, 9, 8].type = BlockType.Air;
                    blocks[4, 9, 8].type = BlockType.Air;
                    blocks[9, 9, 8].type = BlockType.Air;
                    blocks[11, 9, 8].type = BlockType.Air;
                    blocks[13, 9, 8].type = BlockType.Air;
                    blocks[1, 9, 9].type = BlockType.Air;
                    blocks[2, 9, 9].type = BlockType.Air;
                    blocks[3, 9, 9].type = BlockType.Air;
                    blocks[4, 9, 9].type = BlockType.Air;
                    blocks[7, 9, 9].type = BlockType.Air;
                    blocks[9, 9, 9].type = BlockType.Lock; blocks[9, 9, 9].index = 5;
                    blocks[11, 9, 9].type = BlockType.Air;
                    blocks[13, 9, 9].type = BlockType.Air;
                    blocks[2, 9, 10].type = BlockType.Air;
                    blocks[4, 9, 10].type = BlockType.Air;
                    blocks[5, 9, 10].type = BlockType.Air;
                    blocks[6, 9, 10].type = BlockType.Air;
                    blocks[7, 9, 10].type = BlockType.Air;
                    blocks[9, 9, 10].type = BlockType.Air;
                    blocks[11, 9, 10].type = BlockType.Air;
                    blocks[12, 9, 10].type = BlockType.Air;
                    blocks[13, 9, 10].type = BlockType.Air;
                    blocks[1, 9, 11].type = BlockType.Air;
                    blocks[2, 9, 11].type = BlockType.Air;
                    blocks[4, 9, 11].type = BlockType.Air;
                    blocks[6, 9, 11].type = BlockType.Air;
                    blocks[9, 9, 11].type = BlockType.Air;
                    blocks[12, 9, 11].type = BlockType.Air;
                    blocks[1, 9, 12].type = BlockType.Air;
                    blocks[6, 9, 12].type = BlockType.Air;
                    blocks[8, 9, 12].type = BlockType.Air;
                    blocks[9, 9, 12].type = BlockType.Air;
                    blocks[10, 9, 12].type = BlockType.Air;
                    blocks[12, 9, 12].type = BlockType.Air;
                    blocks[1, 9, 13].type = BlockType.Air;
                    blocks[2, 9, 13].type = BlockType.Air;
                    blocks[3, 9, 13].type = BlockType.Air;
                    blocks[4, 9, 13].type = BlockType.Air;
                    blocks[5, 9, 13].type = BlockType.Air;
                    blocks[6, 9, 13].type = BlockType.Air;
                    blocks[7, 9, 13].type = BlockType.Air;
                    blocks[8, 9, 13].type = BlockType.Air;
                    blocks[10, 9, 13].type = BlockType.Air;
                    blocks[11, 9, 13].type = BlockType.Air;
                    blocks[12, 9, 13].type = BlockType.Air;
                    blocks[13, 9, 13].type = BlockType.Air;
                    blocks[7, 10, 7].type = BlockType.Air;
                    blocks[7, 11, 7].type = BlockType.Air;
                    blocks[7, 12, 7].type = BlockType.Air;
                    blocks[7, 13, 7].type = BlockType.Air;
                    blocks[7, 13, 8].type = BlockType.Air;
                    blocks[7, 13, 9].type = BlockType.Air;
                    blocks[7, 13, 10].type = BlockType.Air;
                    blocks[7, 13, 11].type = BlockType.Air;
                    blocks[7, 13, 12].type = BlockType.Air;
                    blocks[7, 13, 13].type = BlockType.Exit;
                }
                break;
            case 20:
                {
                    blocks[13, 1, 1].type = BlockType.Air;
                    blocks[13, 1, 2].type = BlockType.Air;
                    blocks[13, 1, 3].type = BlockType.Air;
                    blocks[13, 1, 4].type = BlockType.Air;
                    blocks[13, 1, 5].type = BlockType.Air;
                    blocks[13, 1, 6].type = BlockType.Air;
                    blocks[13, 1, 7].type = BlockType.Key; blocks[13, 1, 7].index = 3;
                    blocks[13, 1, 8].type = BlockType.Air;
                    blocks[13, 1, 9].type = BlockType.Air;
                    blocks[13, 1, 10].type = BlockType.Air;
                    blocks[13, 1, 11].type = BlockType.Air;
                    blocks[13, 1, 12].type = BlockType.Air;
                    blocks[13, 1, 13].type = BlockType.Air;
                    blocks[13, 2, 1].type = BlockType.Air;
                    blocks[13, 2, 13].type = BlockType.Air;
                    blocks[13, 3, 1].type = BlockType.Air;
                    blocks[11, 3, 3].type = BlockType.Air;
                    blocks[11, 3, 4].type = BlockType.Air;
                    blocks[11, 3, 5].type = BlockType.Air;
                    blocks[11, 3, 6].type = BlockType.Air;
                    blocks[11, 3, 7].type = BlockType.Air;
                    blocks[11, 3, 8].type = BlockType.Air;
                    blocks[11, 3, 9].type = BlockType.Air;
                    blocks[11, 3, 10].type = BlockType.Air;
                    blocks[11, 3, 11].type = BlockType.Air;
                    blocks[13, 3, 13].type = BlockType.Air;
                    blocks[13, 4, 1].type = BlockType.Air;
                    blocks[11, 4, 3].type = BlockType.Air;
                    blocks[11, 4, 11].type = BlockType.Air;
                    blocks[13, 4, 13].type = BlockType.Air;
                    blocks[13, 5, 1].type = BlockType.Air;
                    blocks[11, 5, 3].type = BlockType.Air;
                    blocks[9, 5, 5].type = BlockType.Air;
                    blocks[11, 5, 5].type = BlockType.Air;
                    blocks[13, 5, 5].type = BlockType.Air;
                    blocks[9, 5, 6].type = BlockType.Air;
                    blocks[11, 5, 6].type = BlockType.Air;
                    blocks[13, 5, 6].type = BlockType.Air;
                    blocks[9, 5, 7].type = BlockType.Key; blocks[9, 5, 7].index = 2;
                    blocks[11, 5, 7].type = BlockType.Air;
                    blocks[13, 5, 7].type = BlockType.Air;
                    blocks[9, 5, 8].type = BlockType.Air;
                    blocks[11, 5, 8].type = BlockType.Air;
                    blocks[13, 5, 8].type = BlockType.Air;
                    blocks[9, 5, 9].type = BlockType.Air;
                    blocks[11, 5, 9].type = BlockType.Air;
                    blocks[13, 5, 9].type = BlockType.Air;
                    blocks[11, 5, 11].type = BlockType.Air;
                    blocks[13, 5, 13].type = BlockType.Air;
                    blocks[13, 6, 1].type = BlockType.Air;
                    blocks[11, 6, 3].type = BlockType.Air;
                    blocks[9, 6, 5].type = BlockType.Air;
                    blocks[11, 6, 5].type = BlockType.Air;
                    blocks[13, 6, 5].type = BlockType.Air;
                    blocks[9, 6, 9].type = BlockType.Air;
                    blocks[11, 6, 9].type = BlockType.Air;
                    blocks[13, 6, 9].type = BlockType.Air;
                    blocks[11, 6, 11].type = BlockType.Air;
                    blocks[13, 6, 13].type = BlockType.Air;
                    blocks[1, 7, 1].type = BlockType.Air;
                    blocks[2, 7, 1].type = BlockType.Air;
                    blocks[3, 7, 1].type = BlockType.Air;
                    blocks[4, 7, 1].type = BlockType.Air;
                    blocks[5, 7, 1].type = BlockType.Air;
                    blocks[6, 7, 1].type = BlockType.Air;
                    blocks[7, 7, 1].type = BlockType.Air;
                    blocks[8, 7, 1].type = BlockType.Air;
                    blocks[9, 7, 1].type = BlockType.Air;
                    blocks[10, 7, 1].type = BlockType.Air;
                    blocks[11, 7, 1].type = BlockType.Air;
                    blocks[12, 7, 1].type = BlockType.Air;
                    blocks[13, 7, 1].type = BlockType.Air;
                    blocks[1, 7, 2].type = BlockType.Air;
                    blocks[13, 7, 2].type = BlockType.Air;
                    blocks[1, 7, 3].type = BlockType.Air;
                    blocks[3, 7, 3].type = BlockType.Air;
                    blocks[4, 7, 3].type = BlockType.Air;
                    blocks[5, 7, 3].type = BlockType.Air;
                    blocks[6, 7, 3].type = BlockType.Air;
                    blocks[7, 7, 3].type = BlockType.Air;
                    blocks[8, 7, 3].type = BlockType.Air;
                    blocks[9, 7, 3].type = BlockType.Air;
                    blocks[10, 7, 3].type = BlockType.Air;
                    blocks[11, 7, 3].type = BlockType.Air;
                    blocks[13, 7, 3].type = BlockType.Air;
                    blocks[1, 7, 4].type = BlockType.Air;
                    blocks[3, 7, 4].type = BlockType.Air;
                    blocks[11, 7, 4].type = BlockType.Air;
                    blocks[13, 7, 4].type = BlockType.Air;
                    blocks[1, 7, 5].type = BlockType.Air;
                    blocks[3, 7, 5].type = BlockType.Air;
                    blocks[5, 7, 5].type = BlockType.Air;
                    blocks[6, 7, 5].type = BlockType.Air;
                    blocks[7, 7, 5].type = BlockType.Air;
                    blocks[8, 7, 5].type = BlockType.Air;
                    blocks[9, 7, 5].type = BlockType.Air;
                    blocks[11, 7, 5].type = BlockType.Air;
                    blocks[13, 7, 5].type = BlockType.Air;
                    blocks[1, 7, 6].type = BlockType.Air;
                    blocks[3, 7, 6].type = BlockType.Air;
                    blocks[5, 7, 6].type = BlockType.Air;
                    blocks[1, 7, 7].type = BlockType.Start;
                    blocks[2, 7, 7].type = BlockType.Air;
                    blocks[3, 7, 7].type = BlockType.Air;
                    blocks[4, 7, 7].type = BlockType.Air;
                    blocks[5, 7, 7].type = BlockType.Air;
                    blocks[6, 7, 7].type = BlockType.Air;
                    blocks[7, 7, 7].type = BlockType.Lock; blocks[7, 7, 7].index = 3;
                    blocks[8, 7, 7].type = BlockType.Lock; blocks[8, 7, 7].index = 2;
                    blocks[9, 7, 7].type = BlockType.Lock; blocks[9, 7, 7].index = 1;
                    blocks[10, 7, 7].type = BlockType.Lock; blocks[10, 7, 7].index = 4;
                    blocks[11, 7, 7].type = BlockType.Lock; blocks[11, 7, 7].index = 5;
                    blocks[12, 7, 7].type = BlockType.Air;
                    blocks[13, 7, 7].type = BlockType.Exit;
                    blocks[1, 7, 8].type = BlockType.Air;
                    blocks[3, 7, 8].type = BlockType.Air;
                    blocks[5, 7, 8].type = BlockType.Air;
                    blocks[1, 7, 9].type = BlockType.Air;
                    blocks[3, 7, 9].type = BlockType.Air;
                    blocks[5, 7, 9].type = BlockType.Air;
                    blocks[6, 7, 9].type = BlockType.Air;
                    blocks[7, 7, 9].type = BlockType.Air;
                    blocks[8, 7, 9].type = BlockType.Air;
                    blocks[9, 7, 9].type = BlockType.Air;
                    blocks[11, 7, 9].type = BlockType.Air;
                    blocks[13, 7, 9].type = BlockType.Air;
                    blocks[1, 7, 10].type = BlockType.Air;
                    blocks[3, 7, 10].type = BlockType.Air;
                    blocks[11, 7, 10].type = BlockType.Air;
                    blocks[13, 7, 10].type = BlockType.Air;
                    blocks[1, 7, 11].type = BlockType.Air;
                    blocks[3, 7, 11].type = BlockType.Air;
                    blocks[4, 7, 11].type = BlockType.Air;
                    blocks[5, 7, 11].type = BlockType.Air;
                    blocks[6, 7, 11].type = BlockType.Air;
                    blocks[7, 7, 11].type = BlockType.Air;
                    blocks[8, 7, 11].type = BlockType.Air;
                    blocks[9, 7, 11].type = BlockType.Air;
                    blocks[10, 7, 11].type = BlockType.Air;
                    blocks[11, 7, 11].type = BlockType.Air;
                    blocks[13, 7, 11].type = BlockType.Air;
                    blocks[1, 7, 12].type = BlockType.Air;
                    blocks[13, 7, 12].type = BlockType.Air;
                    blocks[1, 7, 13].type = BlockType.Air;
                    blocks[2, 7, 13].type = BlockType.Air;
                    blocks[3, 7, 13].type = BlockType.Air;
                    blocks[4, 7, 13].type = BlockType.Air;
                    blocks[5, 7, 13].type = BlockType.Air;
                    blocks[6, 7, 13].type = BlockType.Air;
                    blocks[7, 7, 13].type = BlockType.Air;
                    blocks[8, 7, 13].type = BlockType.Air;
                    blocks[9, 7, 13].type = BlockType.Air;
                    blocks[10, 7, 13].type = BlockType.Air;
                    blocks[11, 7, 13].type = BlockType.Air;
                    blocks[12, 7, 13].type = BlockType.Air;
                    blocks[13, 7, 13].type = BlockType.Air;
                    blocks[13, 8, 1].type = BlockType.Air;
                    blocks[11, 8, 3].type = BlockType.Air;
                    blocks[9, 8, 5].type = BlockType.Air;
                    blocks[11, 8, 5].type = BlockType.Air;
                    blocks[13, 8, 5].type = BlockType.Air;
                    blocks[9, 8, 9].type = BlockType.Air;
                    blocks[11, 8, 9].type = BlockType.Air;
                    blocks[13, 8, 9].type = BlockType.Air;
                    blocks[11, 8, 11].type = BlockType.Air;
                    blocks[13, 8, 13].type = BlockType.Air;
                    blocks[13, 9, 1].type = BlockType.Air;
                    blocks[11, 9, 3].type = BlockType.Air;
                    blocks[9, 9, 5].type = BlockType.Air;
                    blocks[11, 9, 5].type = BlockType.Air;
                    blocks[13, 9, 5].type = BlockType.Air;
                    blocks[9, 9, 6].type = BlockType.Air;
                    blocks[11, 9, 6].type = BlockType.Air;
                    blocks[13, 9, 6].type = BlockType.Air;
                    blocks[9, 9, 7].type = BlockType.Air;
                    blocks[11, 9, 7].type = BlockType.Key; blocks[11, 9, 7].index = 1;
                    blocks[13, 9, 7].type = BlockType.Air;
                    blocks[9, 9, 8].type = BlockType.Air;
                    blocks[11, 9, 8].type = BlockType.Air;
                    blocks[13, 9, 8].type = BlockType.Air;
                    blocks[9, 9, 9].type = BlockType.Air;
                    blocks[11, 9, 9].type = BlockType.Air;
                    blocks[13, 9, 9].type = BlockType.Air;
                    blocks[11, 9, 11].type = BlockType.Air;
                    blocks[13, 9, 13].type = BlockType.Air;
                    blocks[13, 10, 1].type = BlockType.Air;
                    blocks[11, 10, 3].type = BlockType.Air;
                    blocks[11, 10, 11].type = BlockType.Air;
                    blocks[13, 10, 13].type = BlockType.Air;
                    blocks[13, 11, 1].type = BlockType.Air;
                    blocks[11, 11, 3].type = BlockType.Air;
                    blocks[11, 11, 4].type = BlockType.Air;
                    blocks[11, 11, 5].type = BlockType.Air;
                    blocks[11, 11, 6].type = BlockType.Air;
                    blocks[11, 11, 7].type = BlockType.Key; blocks[11, 11, 7].index = 4;
                    blocks[11, 11, 8].type = BlockType.Air;
                    blocks[11, 11, 9].type = BlockType.Air;
                    blocks[11, 11, 10].type = BlockType.Air;
                    blocks[11, 11, 11].type = BlockType.Air;
                    blocks[13, 11, 13].type = BlockType.Air;
                    blocks[13, 12, 1].type = BlockType.Air;
                    blocks[13, 12, 13].type = BlockType.Air;
                    blocks[13, 13, 1].type = BlockType.Air;
                    blocks[13, 13, 2].type = BlockType.Air;
                    blocks[13, 13, 3].type = BlockType.Air;
                    blocks[13, 13, 4].type = BlockType.Air;
                    blocks[13, 13, 5].type = BlockType.Air;
                    blocks[13, 13, 6].type = BlockType.Air;
                    blocks[13, 13, 7].type = BlockType.Key; blocks[13, 13, 7].index = 5;
                    blocks[13, 13, 8].type = BlockType.Air;
                    blocks[13, 13, 9].type = BlockType.Air;
                    blocks[13, 13, 10].type = BlockType.Air;
                    blocks[13, 13, 11].type = BlockType.Air;
                    blocks[13, 13, 12].type = BlockType.Air;
                    blocks[13, 13, 13].type = BlockType.Air;
                }
                break;
            case 21:
                {
                    blocks[1, 1, 1].type = BlockType.Start;
                    blocks[2, 1, 1].type = BlockType.Air;
                    blocks[3, 1, 1].type = BlockType.Air;
                    blocks[4, 1, 1].type = BlockType.Air;
                    blocks[5, 1, 1].type = BlockType.Air;
                    blocks[6, 1, 1].type = BlockType.Air;
                    blocks[7, 1, 1].type = BlockType.Air;
                    blocks[8, 1, 1].type = BlockType.Air;
                    blocks[4, 1, 2].type = BlockType.Air;
                    blocks[8, 1, 2].type = BlockType.Air;
                    blocks[1, 1, 3].type = BlockType.Air;
                    blocks[2, 1, 3].type = BlockType.Air;
                    blocks[3, 1, 3].type = BlockType.Air;
                    blocks[4, 1, 3].type = BlockType.Air;
                    blocks[5, 1, 3].type = BlockType.Air;
                    blocks[6, 1, 3].type = BlockType.Air;
                    blocks[8, 1, 3].type = BlockType.Air;
                    blocks[1, 1, 4].type = BlockType.Air;
                    blocks[6, 1, 4].type = BlockType.Air;
                    blocks[8, 1, 4].type = BlockType.Air;
                    blocks[3, 1, 5].type = BlockType.Air;
                    blocks[4, 1, 5].type = BlockType.Air;
                    blocks[5, 1, 5].type = BlockType.Air;
                    blocks[6, 1, 5].type = BlockType.Air;
                    blocks[8, 1, 5].type = BlockType.Air;
                    blocks[9, 1, 5].type = BlockType.Air;
                    blocks[10, 1, 5].type = BlockType.Air;
                    blocks[11, 1, 5].type = BlockType.Air;
                    blocks[12, 1, 5].type = BlockType.Air;
                    blocks[13, 1, 5].type = BlockType.Air;
                    blocks[1, 1, 6].type = BlockType.Air;
                    blocks[3, 1, 6].type = BlockType.Air;
                    blocks[8, 1, 6].type = BlockType.Air;
                    blocks[13, 1, 6].type = BlockType.Air;
                    blocks[1, 1, 7].type = BlockType.Air;
                    blocks[5, 1, 7].type = BlockType.Air;
                    blocks[6, 1, 7].type = BlockType.Air;
                    blocks[7, 1, 7].type = BlockType.Air;
                    blocks[8, 1, 7].type = BlockType.Air;
                    blocks[10, 1, 7].type = BlockType.Air;
                    blocks[11, 1, 7].type = BlockType.Air;
                    blocks[12, 1, 7].type = BlockType.Air;
                    blocks[13, 1, 7].type = BlockType.Air;
                    blocks[1, 1, 8].type = BlockType.Air;
                    blocks[2, 1, 8].type = BlockType.Air;
                    blocks[3, 1, 8].type = BlockType.Air;
                    blocks[4, 1, 8].type = BlockType.Air;
                    blocks[5, 1, 8].type = BlockType.Air;
                    blocks[10, 1, 8].type = BlockType.Air;
                    blocks[4, 1, 9].type = BlockType.Air;
                    blocks[7, 1, 9].type = BlockType.Bonus;
                    blocks[9, 1, 9].type = BlockType.Air;
                    blocks[10, 1, 9].type = BlockType.Air;
                    blocks[11, 1, 9].type = BlockType.Air;
                    blocks[12, 1, 9].type = BlockType.Air;
                    blocks[13, 1, 9].type = BlockType.Air;
                    blocks[1, 1, 10].type = BlockType.Bonus;
                    blocks[2, 1, 10].type = BlockType.Air;
                    blocks[3, 1, 10].type = BlockType.Air;
                    blocks[4, 1, 10].type = BlockType.Air;
                    blocks[5, 1, 10].type = BlockType.Air;
                    blocks[6, 1, 10].type = BlockType.Air;
                    blocks[7, 1, 10].type = BlockType.Air;
                    blocks[9, 1, 10].type = BlockType.Air;
                    blocks[13, 1, 10].type = BlockType.Air;
                    blocks[9, 1, 11].type = BlockType.Air;
                    blocks[11, 1, 11].type = BlockType.Air;
                    blocks[12, 1, 11].type = BlockType.Air;
                    blocks[13, 1, 11].type = BlockType.Air;
                    blocks[7, 1, 12].type = BlockType.Bonus;
                    blocks[8, 1, 12].type = BlockType.Air;
                    blocks[9, 1, 12].type = BlockType.Air;
                    blocks[9, 1, 13].type = BlockType.Air;
                    blocks[10, 1, 13].type = BlockType.Air;
                    blocks[11, 1, 13].type = BlockType.Air;
                    blocks[12, 1, 13].type = BlockType.Air;
                    blocks[13, 1, 13].type = BlockType.Exit;
                }
                break;
            case 22:
                {
                    blocks[1, 1, 1].type = BlockType.Start;
                    blocks[2, 1, 1].type = BlockType.Air;
                    blocks[3, 1, 1].type = BlockType.Air;
                    blocks[5, 1, 1].type = BlockType.Air;
                    blocks[6, 1, 1].type = BlockType.Air;
                    blocks[1, 1, 2].type = BlockType.Air;
                    blocks[3, 1, 2].type = BlockType.Air;
                    blocks[5, 1, 2].type = BlockType.Air;
                    blocks[1, 1, 3].type = BlockType.Air;
                    blocks[3, 1, 3].type = BlockType.Air;
                    blocks[4, 1, 3].type = BlockType.Air;
                    blocks[5, 1, 3].type = BlockType.Air;
                    blocks[1, 1, 4].type = BlockType.Air;
                    blocks[5, 1, 4].type = BlockType.Air;
                    blocks[6, 1, 4].type = BlockType.Air;
                    blocks[1, 1, 5].type = BlockType.Air;
                    blocks[2, 1, 5].type = BlockType.Air;
                    blocks[3, 1, 5].type = BlockType.Air;
                    blocks[11, 1, 5].type = BlockType.Air;
                    blocks[12, 1, 5].type = BlockType.Air;
                    blocks[13, 1, 5].type = BlockType.Bonus;
                    blocks[3, 1, 6].type = BlockType.Air;
                    blocks[4, 1, 6].type = BlockType.Air;
                    blocks[5, 1, 6].type = BlockType.Air;
                    blocks[9, 1, 6].type = BlockType.Air;
                    blocks[10, 1, 6].type = BlockType.Air;
                    blocks[11, 1, 6].type = BlockType.Air;
                    blocks[1, 1, 7].type = BlockType.Air;
                    blocks[2, 1, 7].type = BlockType.Air;
                    blocks[3, 1, 7].type = BlockType.Air;
                    blocks[11, 1, 7].type = BlockType.Air;
                    blocks[13, 1, 7].type = BlockType.Air;
                    blocks[1, 1, 8].type = BlockType.Air;
                    blocks[8, 1, 8].type = BlockType.Air;
                    blocks[9, 1, 8].type = BlockType.Air;
                    blocks[10, 1, 8].type = BlockType.Air;
                    blocks[11, 1, 8].type = BlockType.Air;
                    blocks[13, 1, 8].type = BlockType.Air;
                    blocks[1, 1, 9].type = BlockType.Bonus;
                    blocks[8, 1, 9].type = BlockType.Air;
                    blocks[11, 1, 9].type = BlockType.Air;
                    blocks[12, 1, 9].type = BlockType.Air;
                    blocks[13, 1, 9].type = BlockType.Air;
                    blocks[8, 1, 10].type = BlockType.Air;
                    blocks[13, 1, 10].type = BlockType.Air;
                    blocks[6, 1, 11].type = BlockType.Air;
                    blocks[7, 1, 11].type = BlockType.Air;
                    blocks[8, 1, 11].type = BlockType.Air;
                    blocks[9, 1, 11].type = BlockType.Air;
                    blocks[11, 1, 11].type = BlockType.Air;
                    blocks[12, 1, 11].type = BlockType.Air;
                    blocks[13, 1, 11].type = BlockType.Air;
                    blocks[6, 1, 12].type = BlockType.Air;
                    blocks[11, 1, 12].type = BlockType.Air;
                    blocks[4, 1, 13].type = BlockType.Air;
                    blocks[5, 1, 13].type = BlockType.Air;
                    blocks[6, 1, 13].type = BlockType.Air;
                    blocks[7, 1, 13].type = BlockType.Bonus;
                    blocks[9, 1, 13].type = BlockType.Air;
                    blocks[10, 1, 13].type = BlockType.Air;
                    blocks[11, 1, 13].type = BlockType.Air;
                    blocks[12, 1, 13].type = BlockType.Air;
                    blocks[13, 1, 13].type = BlockType.Exit;
                    blocks[6, 2, 4].type = BlockType.Air;
                    blocks[7, 2, 4].type = BlockType.Air;
                    blocks[7, 2, 5].type = BlockType.Air;
                    blocks[8, 2, 5].type = BlockType.Air;
                    blocks[9, 2, 5].type = BlockType.Air;
                    blocks[5, 2, 6].type = BlockType.Air;
                    blocks[9, 2, 6].type = BlockType.Air;
                    blocks[5, 2, 7].type = BlockType.Air;
                    blocks[6, 2, 7].type = BlockType.Air;
                    blocks[5, 2, 8].type = BlockType.Air;
                    blocks[3, 2, 9].type = BlockType.Air;
                    blocks[4, 2, 9].type = BlockType.Air;
                    blocks[5, 2, 9].type = BlockType.Air;
                    blocks[3, 2, 10].type = BlockType.Air;
                    blocks[1, 2, 11].type = BlockType.Bonus;
                    blocks[3, 2, 11].type = BlockType.Air;
                    blocks[1, 2, 12].type = BlockType.Air;
                    blocks[2, 2, 12].type = BlockType.Air;
                    blocks[3, 2, 12].type = BlockType.Air;
                    blocks[3, 2, 13].type = BlockType.Air;
                    blocks[4, 2, 13].type = BlockType.Air;
                }
                break;
            case 23:
                {
                    blocks[4, 1, 7].type = BlockType.Start;
                    blocks[5, 1, 7].type = BlockType.Air;
                    blocks[6, 1, 7].type = BlockType.Air;
                    blocks[7, 1, 7].type = BlockType.Air;
                    blocks[8, 1, 7].type = BlockType.Lock; blocks[8, 1, 7].index = 1;
                    blocks[9, 1, 7].type = BlockType.Air;
                    blocks[10, 1, 7].type = BlockType.Exit;
                    blocks[2, 2, 1].type = BlockType.Air;
                    blocks[3, 2, 1].type = BlockType.Air;
                    blocks[4, 2, 1].type = BlockType.Air;
                    blocks[5, 2, 1].type = BlockType.Air;
                    blocks[6, 2, 1].type = BlockType.Air;
                    blocks[7, 2, 1].type = BlockType.Air;
                    blocks[9, 2, 1].type = BlockType.Air;
                    blocks[11, 2, 1].type = BlockType.Air;
                    blocks[12, 2, 1].type = BlockType.Air;
                    blocks[1, 2, 2].type = BlockType.Air;
                    blocks[2, 2, 2].type = BlockType.Air;
                    blocks[7, 2, 2].type = BlockType.Air;
                    blocks[8, 2, 2].type = BlockType.Air;
                    blocks[9, 2, 2].type = BlockType.Air;
                    blocks[12, 2, 2].type = BlockType.Air;
                    blocks[4, 2, 3].type = BlockType.Air;
                    blocks[5, 2, 3].type = BlockType.Air;
                    blocks[6, 2, 3].type = BlockType.Air;
                    blocks[7, 2, 3].type = BlockType.Air;
                    blocks[9, 2, 3].type = BlockType.Air;
                    blocks[10, 2, 3].type = BlockType.Air;
                    blocks[11, 2, 3].type = BlockType.Air;
                    blocks[12, 2, 3].type = BlockType.Air;
                    blocks[13, 2, 3].type = BlockType.Air;
                    blocks[1, 2, 4].type = BlockType.Air;
                    blocks[2, 2, 4].type = BlockType.Air;
                    blocks[3, 2, 4].type = BlockType.Air;
                    blocks[4, 2, 4].type = BlockType.Air;
                    blocks[9, 2, 4].type = BlockType.Air;
                    blocks[13, 2, 4].type = BlockType.Air;
                    blocks[1, 2, 5].type = BlockType.Air;
                    blocks[6, 2, 5].type = BlockType.Air;
                    blocks[7, 2, 5].type = BlockType.Air;
                    blocks[9, 2, 5].type = BlockType.Air;
                    blocks[10, 2, 5].type = BlockType.Air;
                    blocks[11, 2, 5].type = BlockType.Air;
                    blocks[13, 2, 5].type = BlockType.Key; blocks[13, 2, 5].index = 1;
                    blocks[1, 2, 6].type = BlockType.Air;
                    blocks[2, 2, 6].type = BlockType.Air;
                    blocks[6, 2, 6].type = BlockType.Air;
                    blocks[2, 2, 7].type = BlockType.Air;
                    blocks[6, 2, 7].type = BlockType.Air;
                    blocks[12, 2, 7].type = BlockType.Air;
                    blocks[13, 2, 7].type = BlockType.Air;
                    blocks[2, 2, 8].type = BlockType.Air;
                    blocks[6, 2, 8].type = BlockType.Air;
                    blocks[13, 2, 8].type = BlockType.Air;
                    blocks[1, 2, 9].type = BlockType.Air;
                    blocks[2, 2, 9].type = BlockType.Air;
                    blocks[3, 2, 9].type = BlockType.Air;
                    blocks[5, 2, 9].type = BlockType.Air;
                    blocks[6, 2, 9].type = BlockType.Air;
                    blocks[7, 2, 9].type = BlockType.Air;
                    blocks[8, 2, 9].type = BlockType.Air;
                    blocks[9, 2, 9].type = BlockType.Air;
                    blocks[13, 2, 9].type = BlockType.Air;
                    blocks[1, 2, 10].type = BlockType.Air;
                    blocks[3, 2, 10].type = BlockType.Air;
                    blocks[4, 2, 10].type = BlockType.Air;
                    blocks[5, 2, 10].type = BlockType.Air;
                    blocks[9, 2, 10].type = BlockType.Air;
                    blocks[11, 2, 10].type = BlockType.Air;
                    blocks[12, 2, 10].type = BlockType.Air;
                    blocks[13, 2, 10].type = BlockType.Air;
                    blocks[4, 2, 11].type = BlockType.Air;
                    blocks[7, 2, 11].type = BlockType.Air;
                    blocks[9, 2, 11].type = BlockType.Air;
                    blocks[11, 2, 11].type = BlockType.Air;
                    blocks[13, 2, 11].type = BlockType.Air;
                    blocks[2, 2, 12].type = BlockType.Air;
                    blocks[3, 2, 12].type = BlockType.Air;
                    blocks[4, 2, 12].type = BlockType.Air;
                    blocks[7, 2, 12].type = BlockType.Air;
                    blocks[8, 2, 12].type = BlockType.Air;
                    blocks[9, 2, 12].type = BlockType.Air;
                    blocks[11, 2, 12].type = BlockType.Air;
                    blocks[13, 2, 12].type = BlockType.Air;
                    blocks[1, 2, 13].type = BlockType.Air;
                    blocks[2, 2, 13].type = BlockType.Air;
                    blocks[4, 2, 13].type = BlockType.Air;
                    blocks[9, 2, 13].type = BlockType.Air;
                    blocks[10, 2, 13].type = BlockType.Air;
                    blocks[11, 2, 13].type = BlockType.Air;
                    blocks[13, 2, 13].type = BlockType.Air;
                    blocks[1, 3, 2].type = BlockType.Air;
                    blocks[8, 3, 7].type = BlockType.Bonus;
                    blocks[9, 3, 7].type = BlockType.Bonus;
                    blocks[10, 3, 7].type = BlockType.Bonus;
                    blocks[11, 3, 7].type = BlockType.Air;
                    blocks[12, 3, 7].type = BlockType.Air;
                    blocks[1, 3, 13].type = BlockType.Air;
                }
                break;
            case 24:
                {
                    blocks[10, 1, 7].type = BlockType.Air;
                    blocks[11, 1, 7].type = BlockType.Air;
                    blocks[11, 1, 8].type = BlockType.Air;
                    blocks[11, 1, 9].type = BlockType.Air;
                    blocks[11, 1, 10].type = BlockType.Lock; blocks[11, 1, 10].index = 3;
                    blocks[11, 1, 11].type = BlockType.Air;
                    blocks[7, 2, 4].type = BlockType.Air;
                    blocks[3, 2, 5].type = BlockType.Air;
                    blocks[4, 2, 5].type = BlockType.Air;
                    blocks[5, 2, 5].type = BlockType.Air;
                    blocks[7, 2, 5].type = BlockType.Air;
                    blocks[3, 2, 6].type = BlockType.Air;
                    blocks[5, 2, 6].type = BlockType.Air;
                    blocks[7, 2, 6].type = BlockType.Air;
                    blocks[1, 2, 7].type = BlockType.Air;
                    blocks[2, 2, 7].type = BlockType.Air;
                    blocks[3, 2, 7].type = BlockType.Air;
                    blocks[5, 2, 7].type = BlockType.Air;
                    blocks[6, 2, 7].type = BlockType.Air;
                    blocks[8, 2, 7].type = BlockType.Air;
                    blocks[9, 2, 7].type = BlockType.Air;
                    blocks[10, 2, 7].type = BlockType.Air;
                    blocks[1, 2, 8].type = BlockType.Air;
                    blocks[7, 2, 8].type = BlockType.Air;
                    blocks[1, 2, 9].type = BlockType.Air;
                    blocks[2, 2, 9].type = BlockType.Air;
                    blocks[3, 2, 9].type = BlockType.Air;
                    blocks[4, 2, 9].type = BlockType.Air;
                    blocks[7, 2, 9].type = BlockType.Air;
                    blocks[4, 2, 10].type = BlockType.Air;
                    blocks[7, 2, 10].type = BlockType.Air;
                    blocks[3, 2, 11].type = BlockType.Air;
                    blocks[4, 2, 11].type = BlockType.Air;
                    blocks[11, 2, 11].type = BlockType.Air;
                    blocks[6, 3, 6].type = BlockType.Air;
                    blocks[7, 3, 6].type = BlockType.Air;
                    blocks[8, 3, 6].type = BlockType.Air;
                    blocks[6, 3, 7].type = BlockType.Air;
                    blocks[8, 3, 7].type = BlockType.Air;
                    blocks[6, 3, 8].type = BlockType.Air;
                    blocks[7, 3, 8].type = BlockType.Air;
                    blocks[8, 3, 8].type = BlockType.Air;
                    blocks[1, 3, 11].type = BlockType.Air;
                    blocks[2, 3, 11].type = BlockType.Air;
                    blocks[3, 3, 11].type = BlockType.Air;
                    blocks[11, 3, 11].type = BlockType.Air;
                    blocks[12, 3, 11].type = BlockType.Air;
                    blocks[13, 3, 11].type = BlockType.Air;
                    blocks[1, 3, 12].type = BlockType.Air;
                    blocks[3, 3, 12].type = BlockType.Air;
                    blocks[11, 3, 12].type = BlockType.Air;
                    blocks[13, 3, 12].type = BlockType.Air;
                    blocks[1, 3, 13].type = BlockType.Air;
                    blocks[2, 3, 13].type = BlockType.Air;
                    blocks[3, 3, 13].type = BlockType.Air;
                    blocks[11, 3, 13].type = BlockType.Air;
                    blocks[12, 3, 13].type = BlockType.Air;
                    blocks[13, 3, 13].type = BlockType.Air;
                    blocks[1, 4, 1].type = BlockType.Air;
                    blocks[2, 4, 1].type = BlockType.Air;
                    blocks[3, 4, 1].type = BlockType.Air;
                    blocks[11, 4, 1].type = BlockType.Air;
                    blocks[12, 4, 1].type = BlockType.Air;
                    blocks[13, 4, 1].type = BlockType.Air;
                    blocks[1, 4, 2].type = BlockType.Air;
                    blocks[2, 4, 2].type = BlockType.Key; blocks[2, 4, 2].index = 3;
                    blocks[3, 4, 2].type = BlockType.Air;
                    blocks[11, 4, 2].type = BlockType.Air;
                    blocks[12, 4, 2].type = BlockType.Bonus;
                    blocks[13, 4, 2].type = BlockType.Air;
                    blocks[1, 4, 3].type = BlockType.Air;
                    blocks[2, 4, 3].type = BlockType.Air;
                    blocks[3, 4, 3].type = BlockType.Air;
                    blocks[11, 4, 3].type = BlockType.Air;
                    blocks[12, 4, 3].type = BlockType.Air;
                    blocks[13, 4, 3].type = BlockType.Air;
                    blocks[6, 4, 6].type = BlockType.Air;
                    blocks[7, 4, 6].type = BlockType.Air;
                    blocks[8, 4, 6].type = BlockType.Air;
                    blocks[6, 4, 7].type = BlockType.Air;
                    blocks[7, 4, 7].type = BlockType.Start;
                    blocks[8, 4, 7].type = BlockType.Air;
                    blocks[6, 4, 8].type = BlockType.Air;
                    blocks[7, 4, 8].type = BlockType.Air;
                    blocks[8, 4, 8].type = BlockType.Air;
                    blocks[1, 4, 11].type = BlockType.Air;
                    blocks[2, 4, 11].type = BlockType.Air;
                    blocks[3, 4, 11].type = BlockType.Air;
                    blocks[11, 4, 11].type = BlockType.Air;
                    blocks[12, 4, 11].type = BlockType.Air;
                    blocks[13, 4, 11].type = BlockType.Air;
                    blocks[1, 4, 12].type = BlockType.Air;
                    blocks[2, 4, 12].type = BlockType.Bonus;
                    blocks[3, 4, 12].type = BlockType.Air;
                    blocks[11, 4, 12].type = BlockType.Air;
                    blocks[12, 4, 12].type = BlockType.Exit;
                    blocks[13, 4, 12].type = BlockType.Air;
                    blocks[1, 4, 13].type = BlockType.Air;
                    blocks[2, 4, 13].type = BlockType.Air;
                    blocks[3, 4, 13].type = BlockType.Air;
                    blocks[11, 4, 13].type = BlockType.Air;
                    blocks[12, 4, 13].type = BlockType.Air;
                    blocks[13, 4, 13].type = BlockType.Air;
                    blocks[1, 5, 1].type = BlockType.Air;
                    blocks[2, 5, 1].type = BlockType.Air;
                    blocks[3, 5, 1].type = BlockType.Air;
                    blocks[11, 5, 1].type = BlockType.Air;
                    blocks[12, 5, 1].type = BlockType.Air;
                    blocks[13, 5, 1].type = BlockType.Air;
                    blocks[1, 5, 2].type = BlockType.Air;
                    blocks[3, 5, 2].type = BlockType.Air;
                    blocks[11, 5, 2].type = BlockType.Air;
                    blocks[13, 5, 2].type = BlockType.Air;
                    blocks[1, 5, 3].type = BlockType.Air;
                    blocks[2, 5, 3].type = BlockType.Air;
                    blocks[3, 5, 3].type = BlockType.Air;
                    blocks[7, 5, 3].type = BlockType.Air;
                    blocks[11, 5, 3].type = BlockType.Air;
                    blocks[12, 5, 3].type = BlockType.Air;
                    blocks[13, 5, 3].type = BlockType.Air;
                    blocks[7, 5, 4].type = BlockType.Air;
                    blocks[7, 5, 5].type = BlockType.Air;
                    blocks[6, 5, 6].type = BlockType.Air;
                    blocks[7, 5, 6].type = BlockType.Air;
                    blocks[8, 5, 6].type = BlockType.Air;
                    blocks[3, 5, 7].type = BlockType.Air;
                    blocks[4, 5, 7].type = BlockType.Air;
                    blocks[5, 5, 7].type = BlockType.Air;
                    blocks[6, 5, 7].type = BlockType.Air;
                    blocks[8, 5, 7].type = BlockType.Air;
                    blocks[9, 5, 7].type = BlockType.Air;
                    blocks[10, 5, 7].type = BlockType.Air;
                    blocks[11, 5, 7].type = BlockType.Air;
                    blocks[6, 5, 8].type = BlockType.Air;
                    blocks[7, 5, 8].type = BlockType.Air;
                    blocks[8, 5, 8].type = BlockType.Air;
                    blocks[7, 5, 9].type = BlockType.Air;
                    blocks[7, 5, 10].type = BlockType.Air;
                    blocks[7, 5, 11].type = BlockType.Air;
                    blocks[7, 6, 1].type = BlockType.Air;
                    blocks[8, 6, 1].type = BlockType.Air;
                    blocks[9, 6, 1].type = BlockType.Air;
                    blocks[7, 6, 2].type = BlockType.Air;
                    blocks[9, 6, 2].type = BlockType.Key; blocks[9, 6, 2].index = 2;
                    blocks[1, 6, 3].type = BlockType.Air;
                    blocks[7, 6, 3].type = BlockType.Air;
                    blocks[13, 6, 3].type = BlockType.Air;
                    blocks[1, 6, 4].type = BlockType.Air;
                    blocks[9, 6, 4].type = BlockType.Air;
                    blocks[10, 6, 4].type = BlockType.Air;
                    blocks[11, 6, 4].type = BlockType.Air;
                    blocks[13, 6, 4].type = BlockType.Air;
                    blocks[1, 6, 5].type = BlockType.Lock; blocks[1, 6, 5].index = 2;
                    blocks[9, 6, 5].type = BlockType.Air;
                    blocks[11, 6, 5].type = BlockType.Air;
                    blocks[13, 6, 5].type = BlockType.Air;
                    blocks[1, 6, 6].type = BlockType.Air;
                    blocks[11, 6, 6].type = BlockType.Air;
                    blocks[13, 6, 6].type = BlockType.Air;
                    blocks[1, 6, 7].type = BlockType.Air;
                    blocks[2, 6, 7].type = BlockType.Air;
                    blocks[3, 6, 7].type = BlockType.Air;
                    blocks[11, 6, 7].type = BlockType.Air;
                    blocks[13, 6, 7].type = BlockType.Air;
                    blocks[3, 6, 8].type = BlockType.Air;
                    blocks[13, 6, 8].type = BlockType.Air;
                    blocks[3, 6, 9].type = BlockType.Air;
                    blocks[4, 6, 9].type = BlockType.Air;
                    blocks[5, 6, 9].type = BlockType.Air;
                    blocks[13, 6, 9].type = BlockType.Air;
                    blocks[3, 6, 10].type = BlockType.Air;
                    blocks[5, 6, 10].type = BlockType.Bonus;
                    blocks[13, 6, 10].type = BlockType.Air;
                    blocks[1, 6, 11].type = BlockType.Air;
                    blocks[2, 6, 11].type = BlockType.Air;
                    blocks[3, 6, 11].type = BlockType.Air;
                    blocks[7, 6, 11].type = BlockType.Air;
                    blocks[8, 6, 11].type = BlockType.Air;
                    blocks[9, 6, 11].type = BlockType.Air;
                    blocks[10, 6, 11].type = BlockType.Air;
                    blocks[11, 6, 11].type = BlockType.Air;
                    blocks[12, 6, 11].type = BlockType.Air;
                    blocks[13, 6, 11].type = BlockType.Air;
                    blocks[1, 6, 12].type = BlockType.Bonus;
                    blocks[3, 6, 12].type = BlockType.Air;
                    blocks[3, 6, 13].type = BlockType.Air;
                }
                break;
            case 25:
                {
                    blocks[1, 1, 1].type = BlockType.Start;
                    blocks[2, 1, 1].type = BlockType.Air;
                    blocks[3, 1, 1].type = BlockType.Key; blocks[3, 1, 1].index = 3;
                    blocks[4, 1, 1].type = BlockType.Air;
                    blocks[5, 1, 1].type = BlockType.Lock; blocks[5, 1, 1].index = 3;
                    blocks[6, 1, 1].type = BlockType.Air;
                    blocks[7, 1, 1].type = BlockType.Air;
                    blocks[11, 1, 1].type = BlockType.Air;
                    blocks[12, 1, 1].type = BlockType.Air;
                    blocks[13, 1, 1].type = BlockType.Exit;
                    blocks[1, 1, 2].type = BlockType.Air;
                    blocks[13, 1, 2].type = BlockType.Air;
                    blocks[1, 1, 3].type = BlockType.Air;
                    blocks[13, 1, 3].type = BlockType.Air;
                    blocks[1, 1, 4].type = BlockType.Air;
                    blocks[1, 1, 5].type = BlockType.Air;
                    blocks[1, 1, 6].type = BlockType.Air;
                    blocks[1, 1, 7].type = BlockType.Air;
                    blocks[7, 2, 1].type = BlockType.Air;
                    blocks[8, 2, 1].type = BlockType.Air;
                    blocks[11, 2, 1].type = BlockType.Air;
                    blocks[8, 2, 2].type = BlockType.Air;
                    blocks[11, 2, 2].type = BlockType.Air;
                    blocks[8, 2, 3].type = BlockType.Air;
                    blocks[13, 2, 3].type = BlockType.Air;
                    blocks[8, 2, 4].type = BlockType.Air;
                    blocks[5, 2, 5].type = BlockType.Air;
                    blocks[6, 2, 5].type = BlockType.Air;
                    blocks[7, 2, 5].type = BlockType.Air;
                    blocks[8, 2, 5].type = BlockType.Air;
                    blocks[1, 2, 7].type = BlockType.Air;
                    blocks[1, 2, 8].type = BlockType.Air;
                    blocks[1, 2, 9].type = BlockType.Air;
                    blocks[1, 2, 10].type = BlockType.Air;
                    blocks[1, 2, 11].type = BlockType.Air;
                    blocks[1, 2, 12].type = BlockType.Air;
                    blocks[1, 2, 13].type = BlockType.Air;
                    blocks[2, 2, 13].type = BlockType.Air;
                    blocks[3, 2, 13].type = BlockType.Air;
                    blocks[4, 2, 13].type = BlockType.Air;
                    blocks[5, 2, 13].type = BlockType.Air;
                    blocks[6, 2, 13].type = BlockType.Air;
                    blocks[7, 2, 13].type = BlockType.Air;
                    blocks[10, 3, 2].type = BlockType.Air;
                    blocks[11, 3, 2].type = BlockType.Air;
                    blocks[13, 3, 3].type = BlockType.Air;
                    blocks[3, 3, 5].type = BlockType.Air;
                    blocks[4, 3, 5].type = BlockType.Air;
                    blocks[5, 3, 5].type = BlockType.Air;
                    blocks[3, 3, 6].type = BlockType.Air;
                    blocks[3, 3, 7].type = BlockType.Air;
                    blocks[7, 3, 7].type = BlockType.Air;
                    blocks[8, 3, 7].type = BlockType.Lock; blocks[8, 3, 7].index = 2;
                    blocks[9, 3, 7].type = BlockType.Air;
                    blocks[10, 3, 7].type = BlockType.Key; blocks[10, 3, 7].index = 1;
                    blocks[11, 3, 7].type = BlockType.Air;
                    blocks[3, 3, 8].type = BlockType.Air;
                    blocks[7, 3, 8].type = BlockType.Air;
                    blocks[3, 3, 9].type = BlockType.Air;
                    blocks[4, 3, 9].type = BlockType.Air;
                    blocks[5, 3, 9].type = BlockType.Key; blocks[5, 3, 9].index = 2;
                    blocks[6, 3, 9].type = BlockType.Air;
                    blocks[7, 3, 9].type = BlockType.Air;
                    blocks[7, 3, 10].type = BlockType.Air;
                    blocks[7, 3, 11].type = BlockType.Air;
                    blocks[7, 3, 12].type = BlockType.Air;
                    blocks[7, 3, 13].type = BlockType.Air;
                    blocks[8, 3, 13].type = BlockType.Air;
                    blocks[9, 3, 13].type = BlockType.Air;
                    blocks[10, 3, 13].type = BlockType.Air;
                    blocks[11, 3, 13].type = BlockType.Air;
                    blocks[12, 3, 13].type = BlockType.Air;
                    blocks[13, 3, 13].type = BlockType.Air;
                    blocks[11, 4, 1].type = BlockType.Air;
                    blocks[12, 4, 1].type = BlockType.Air;
                    blocks[13, 4, 1].type = BlockType.Air;
                    blocks[5, 4, 2].type = BlockType.Air;
                    blocks[6, 4, 2].type = BlockType.Air;
                    blocks[7, 4, 2].type = BlockType.Air;
                    blocks[8, 4, 2].type = BlockType.Lock; blocks[8, 4, 2].index = 5;
                    blocks[9, 4, 2].type = BlockType.Air;
                    blocks[10, 4, 2].type = BlockType.Air;
                    blocks[13, 4, 2].type = BlockType.Air;
                    blocks[11, 4, 3].type = BlockType.Air;
                    blocks[13, 4, 3].type = BlockType.Air;
                    blocks[11, 4, 4].type = BlockType.Air;
                    blocks[11, 4, 5].type = BlockType.Key; blocks[11, 4, 5].index = 4;
                    blocks[11, 4, 6].type = BlockType.Air;
                    blocks[11, 4, 7].type = BlockType.Air;
                    blocks[13, 4, 7].type = BlockType.Air;
                    blocks[13, 4, 8].type = BlockType.Air;
                    blocks[13, 4, 9].type = BlockType.Air;
                    blocks[13, 4, 10].type = BlockType.Air;
                    blocks[13, 4, 11].type = BlockType.Air;
                    blocks[13, 4, 12].type = BlockType.Air;
                    blocks[13, 4, 13].type = BlockType.Air;
                    blocks[11, 5, 1].type = BlockType.Air;
                    blocks[5, 5, 2].type = BlockType.Air;
                    blocks[11, 5, 3].type = BlockType.Air;
                    blocks[13, 5, 5].type = BlockType.Air;
                    blocks[13, 5, 6].type = BlockType.Air;
                    blocks[13, 5, 7].type = BlockType.Air;
                    blocks[11, 6, 1].type = BlockType.Air;
                    blocks[5, 6, 2].type = BlockType.Air;
                    blocks[6, 6, 2].type = BlockType.Air;
                    blocks[7, 6, 2].type = BlockType.Air;
                    blocks[11, 6, 3].type = BlockType.Air;
                    blocks[13, 6, 3].type = BlockType.Air;
                    blocks[3, 6, 4].type = BlockType.Air;
                    blocks[4, 6, 4].type = BlockType.Air;
                    blocks[5, 6, 4].type = BlockType.Air;
                    blocks[6, 6, 4].type = BlockType.Air;
                    blocks[7, 6, 4].type = BlockType.Air;
                    blocks[13, 6, 4].type = BlockType.Air;
                    blocks[7, 6, 5].type = BlockType.Air;
                    blocks[13, 6, 5].type = BlockType.Air;
                    blocks[7, 6, 6].type = BlockType.Air;
                    blocks[7, 6, 7].type = BlockType.Air;
                    blocks[11, 7, 1].type = BlockType.Air;
                    blocks[12, 7, 1].type = BlockType.Air;
                    blocks[13, 7, 1].type = BlockType.Bonus;
                    blocks[7, 7, 2].type = BlockType.Air;
                    blocks[8, 7, 2].type = BlockType.Air;
                    blocks[9, 7, 2].type = BlockType.Air;
                    blocks[13, 7, 2].type = BlockType.Air;
                    blocks[9, 7, 3].type = BlockType.Air;
                    blocks[11, 7, 3].type = BlockType.Air;
                    blocks[13, 7, 3].type = BlockType.Air;
                    blocks[3, 7, 4].type = BlockType.Air;
                    blocks[9, 7, 4].type = BlockType.Air;
                    blocks[3, 7, 5].type = BlockType.Air;
                    blocks[9, 7, 5].type = BlockType.Air;
                    blocks[3, 7, 6].type = BlockType.Air;
                    blocks[9, 7, 6].type = BlockType.Air;
                    blocks[3, 7, 7].type = BlockType.Air;
                    blocks[7, 7, 7].type = BlockType.Air;
                    blocks[9, 7, 7].type = BlockType.Key; blocks[9, 7, 7].index = 5;
                    blocks[3, 7, 8].type = BlockType.Air;
                    blocks[9, 7, 8].type = BlockType.Air;
                    blocks[3, 7, 9].type = BlockType.Air;
                    blocks[9, 7, 9].type = BlockType.Air;
                    blocks[3, 7, 10].type = BlockType.Air;
                    blocks[9, 7, 10].type = BlockType.Air;
                    blocks[10, 7, 10].type = BlockType.Air;
                    blocks[11, 7, 10].type = BlockType.Air;
                    blocks[12, 7, 10].type = BlockType.Air;
                    blocks[5, 8, 3].type = BlockType.Air;
                    blocks[6, 8, 3].type = BlockType.Air;
                    blocks[7, 8, 3].type = BlockType.Air;
                    blocks[8, 8, 3].type = BlockType.Air;
                    blocks[9, 8, 3].type = BlockType.Air;
                    blocks[10, 8, 3].type = BlockType.Air;
                    blocks[11, 8, 3].type = BlockType.Air;
                    blocks[5, 8, 4].type = BlockType.Air;
                    blocks[5, 8, 5].type = BlockType.Lock; blocks[5, 8, 5].index = 1;
                    blocks[5, 8, 6].type = BlockType.Air;
                    blocks[5, 8, 7].type = BlockType.Air;
                    blocks[6, 8, 7].type = BlockType.Air;
                    blocks[7, 8, 7].type = BlockType.Air;
                    blocks[3, 8, 10].type = BlockType.Air;
                    blocks[12, 8, 10].type = BlockType.Air;
                    blocks[10, 9, 6].type = BlockType.Air;
                    blocks[10, 9, 7].type = BlockType.Air;
                    blocks[10, 9, 8].type = BlockType.Air;
                    blocks[11, 9, 8].type = BlockType.Lock; blocks[11, 9, 8].index = 4;
                    blocks[12, 9, 8].type = BlockType.Air;
                    blocks[12, 9, 9].type = BlockType.Air;
                    blocks[3, 9, 10].type = BlockType.Air;
                    blocks[4, 9, 10].type = BlockType.Air;
                    blocks[5, 9, 10].type = BlockType.Air;
                    blocks[6, 9, 10].type = BlockType.Air;
                    blocks[7, 9, 10].type = BlockType.Air;
                    blocks[8, 9, 10].type = BlockType.Air;
                    blocks[9, 9, 10].type = BlockType.Air;
                    blocks[10, 9, 10].type = BlockType.Air;
                    blocks[12, 9, 10].type = BlockType.Air;
                    blocks[10, 9, 11].type = BlockType.Air;
                    blocks[8, 9, 12].type = BlockType.Air;
                    blocks[9, 9, 12].type = BlockType.Air;
                    blocks[10, 9, 12].type = BlockType.Air;
                    blocks[10, 10, 4].type = BlockType.Air;
                    blocks[11, 10, 4].type = BlockType.Air;
                    blocks[12, 10, 4].type = BlockType.Air;
                    blocks[12, 10, 5].type = BlockType.Air;
                    blocks[10, 10, 6].type = BlockType.Air;
                    blocks[11, 10, 6].type = BlockType.Air;
                    blocks[12, 10, 6].type = BlockType.Air;
                    blocks[8, 10, 12].type = BlockType.Air;
                    blocks[4, 11, 2].type = BlockType.Air;
                    blocks[5, 11, 2].type = BlockType.Air;
                    blocks[6, 11, 2].type = BlockType.Air;
                    blocks[7, 11, 2].type = BlockType.Air;
                    blocks[8, 11, 2].type = BlockType.Air;
                    blocks[9, 11, 2].type = BlockType.Air;
                    blocks[10, 11, 2].type = BlockType.Air;
                    blocks[4, 11, 3].type = BlockType.Air;
                    blocks[10, 11, 3].type = BlockType.Air;
                    blocks[4, 11, 4].type = BlockType.Air;
                    blocks[8, 11, 4].type = BlockType.Air;
                    blocks[10, 11, 4].type = BlockType.Air;
                    blocks[8, 11, 5].type = BlockType.Air;
                    blocks[8, 11, 6].type = BlockType.Air;
                    blocks[8, 11, 7].type = BlockType.Air;
                    blocks[8, 11, 8].type = BlockType.Air;
                    blocks[8, 11, 9].type = BlockType.Air;
                    blocks[8, 11, 10].type = BlockType.Air;
                    blocks[8, 11, 11].type = BlockType.Air;
                    blocks[8, 11, 12].type = BlockType.Air;
                    blocks[4, 12, 4].type = BlockType.Air;
                    blocks[5, 12, 4].type = BlockType.Air;
                    blocks[6, 12, 4].type = BlockType.Bonus;
                    blocks[7, 12, 4].type = BlockType.Air;
                    blocks[8, 12, 4].type = BlockType.Air;
                }
                break;
            case 26:
                {
                    for (int x = 0; x <= 14; x++)
                        for (int y = 0; y <= 14; y++)
                            for (int z = 0; z <= 14; z++)
                                blocks[x, y, z].type = BlockType.Air;
                    blocks[6, 0, 5].type = BlockType.Glass;
                    blocks[7, 0, 5].type = BlockType.Glass;
                    blocks[8, 0, 5].type = BlockType.Glass;
                    for (int x = 5; x <= 9; x++) { blocks[x, 0, 6].type = BlockType.Glass; }
                    for (int x = 5; x <= 9; x++) { blocks[x, 0, 7].type = BlockType.Glass; }
                    for (int x = 5; x <= 9; x++) { blocks[x, 0, 8].type = BlockType.Glass; }
                    blocks[6, 0, 9].type = BlockType.Glass;
                    blocks[7, 0, 9].type = BlockType.Glass;
                    blocks[8, 0, 9].type = BlockType.Glass;
                    blocks[6, 1, 3].type = BlockType.Glass;
                    blocks[7, 1, 3].type = BlockType.Glass;
                    blocks[8, 1, 3].type = BlockType.Glass;
                    for (int x = 4; x <= 10; x++) { blocks[x, 1, 4].type = BlockType.Glass; }
                    for (int x = 4; x <= 10; x++) { blocks[x, 1, 5].type = BlockType.Glass; }
                    for (int x = 3; x <= 6; x++) { blocks[x, 1, 6].type = BlockType.Glass; }
                    for (int x = 8; x <= 11; x++) { blocks[x, 1, 6].type = BlockType.Glass; }
                    blocks[3, 1, 7].type = BlockType.Glass;
                    blocks[4, 1, 7].type = BlockType.Glass;
                    blocks[5, 1, 7].type = BlockType.Glass;
                    blocks[8, 1, 7].type = BlockType.Key; blocks[8, 1, 7].index = 3;
                    blocks[9, 1, 7].type = BlockType.Glass;
                    blocks[10, 1, 7].type = BlockType.Glass;
                    blocks[11, 1, 7].type = BlockType.Glass;
                    for (int x = 3; x <= 6; x++) { blocks[x, 1, 8].type = BlockType.Glass; }
                    for (int x = 8; x <= 11; x++) { blocks[x, 1, 8].type = BlockType.Glass; }
                    for (int x = 4; x <= 10; x++) { blocks[x, 1, 9].type = BlockType.Glass; }
                    for (int x = 4; x <= 10; x++) { blocks[x, 1, 10].type = BlockType.Glass; }
                    blocks[6, 1, 11].type = BlockType.Glass;
                    blocks[7, 1, 11].type = BlockType.Glass;
                    blocks[8, 1, 11].type = BlockType.Glass;
                    for (int x = 5; x <= 9; x++) { blocks[x, 2, 2].type = BlockType.Glass; }
                    for (int x = 4; x <= 10; x++) { blocks[x, 2, 3].type = BlockType.Glass; }
                    for (int x = 3; x <= 11; x++) { blocks[x, 2, 4].type = BlockType.Glass; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 2, 5].type = BlockType.Glass; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 2, 6].type = BlockType.Glass; }
                    for (int x = 2; x <= 6; x++) { blocks[x, 2, 7].type = BlockType.Glass; }
                    for (int x = 8; x <= 12; x++) { blocks[x, 2, 7].type = BlockType.Glass; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 2, 8].type = BlockType.Glass; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 2, 9].type = BlockType.Glass; }
                    for (int x = 3; x <= 11; x++) { blocks[x, 2, 10].type = BlockType.Glass; }
                    for (int x = 4; x <= 10; x++) { blocks[x, 2, 11].type = BlockType.Glass; }
                    for (int x = 5; x <= 9; x++) { blocks[x, 2, 12].type = BlockType.Glass; }
                    for (int x = 5; x <= 9; x++) { blocks[x, 3, 1].type = BlockType.Glass; }
                    for (int x = 4; x <= 10; x++) { blocks[x, 3, 2].type = BlockType.Glass; }
                    for (int x = 3; x <= 11; x++) { blocks[x, 3, 3].type = BlockType.Glass; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 3, 4].type = BlockType.Glass; }
                    for (int x = 1; x <= 6; x++) { blocks[x, 3, 5].type = BlockType.Glass; }
                    for (int x = 8; x <= 13; x++) { blocks[x, 3, 5].type = BlockType.Glass; }
                    for (int x = 1; x <= 6; x++) { blocks[x, 3, 6].type = BlockType.Glass; }
                    for (int x = 8; x <= 13; x++) { blocks[x, 3, 6].type = BlockType.Glass; }
                    for (int x = 1; x <= 4; x++) { blocks[x, 3, 7].type = BlockType.Glass; }
                    for (int x = 10; x <= 13; x++) { blocks[x, 3, 7].type = BlockType.Glass; }
                    for (int x = 1; x <= 6; x++) { blocks[x, 3, 8].type = BlockType.Glass; }
                    for (int x = 8; x <= 13; x++) { blocks[x, 3, 8].type = BlockType.Glass; }
                    for (int x = 1; x <= 6; x++) { blocks[x, 3, 9].type = BlockType.Glass; }
                    for (int x = 8; x <= 13; x++) { blocks[x, 3, 9].type = BlockType.Glass; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 3, 10].type = BlockType.Glass; }
                    for (int x = 3; x <= 11; x++) { blocks[x, 3, 11].type = BlockType.Glass; }
                    for (int x = 4; x <= 10; x++) { blocks[x, 3, 12].type = BlockType.Glass; }
                    for (int x = 5; x <= 9; x++) { blocks[x, 3, 13].type = BlockType.Glass; }
                    for (int x = 5; x <= 9; x++) { blocks[x, 4, 1].type = BlockType.Glass; }
                    for (int x = 4; x <= 10; x++) { blocks[x, 4, 2].type = BlockType.Glass; }
                    for (int x = 3; x <= 11; x++) { blocks[x, 4, 3].type = BlockType.Glass; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 4, 4].type = BlockType.Glass; }
                    for (int x = 1; x <= 6; x++) { blocks[x, 4, 5].type = BlockType.Glass; }
                    for (int x = 8; x <= 13; x++) { blocks[x, 4, 5].type = BlockType.Glass; }
                    for (int x = 1; x <= 13; x++) { blocks[x, 4, 6].type = BlockType.Glass; }
                    for (int x = 1; x <= 4; x++) { blocks[x, 4, 7].type = BlockType.Glass; }
                    blocks[6, 4, 7].type = BlockType.Glass;
                    blocks[8, 4, 7].type = BlockType.Glass;
                    for (int x = 10; x <= 13; x++) { blocks[x, 4, 7].type = BlockType.Glass; }
                    for (int x = 1; x <= 13; x++) { blocks[x, 4, 8].type = BlockType.Glass; }
                    for (int x = 1; x <= 6; x++) { blocks[x, 4, 9].type = BlockType.Glass; }
                    for (int x = 8; x <= 13; x++) { blocks[x, 4, 9].type = BlockType.Glass; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 4, 10].type = BlockType.Glass; }
                    for (int x = 3; x <= 11; x++) { blocks[x, 4, 11].type = BlockType.Glass; }
                    for (int x = 4; x <= 10; x++) { blocks[x, 4, 12].type = BlockType.Glass; }
                    for (int x = 5; x <= 9; x++) { blocks[x, 4, 13].type = BlockType.Glass; }
                    for (int x = 5; x <= 9; x++) { blocks[x, 5, 0].type = BlockType.Glass; }
                    for (int x = 4; x <= 10; x++) { blocks[x, 5, 1].type = BlockType.Glass; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 5, 2].type = BlockType.Glass; }
                    for (int x = 1; x <= 6; x++) { blocks[x, 5, 3].type = BlockType.Glass; }
                    for (int x = 8; x <= 13; x++) { blocks[x, 5, 3].type = BlockType.Glass; }
                    for (int x = 1; x <= 6; x++) { blocks[x, 5, 4].type = BlockType.Glass; }
                    for (int x = 8; x <= 13; x++) { blocks[x, 5, 4].type = BlockType.Glass; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 5, 5].type = BlockType.Glass; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 5, 6].type = BlockType.Glass; }
                    blocks[0, 5, 7].type = BlockType.Glass;
                    blocks[1, 5, 7].type = BlockType.Glass;
                    blocks[2, 5, 7].type = BlockType.Glass;
                    blocks[5, 5, 7].type = BlockType.Glass;
                    blocks[6, 5, 7].type = BlockType.Glass;
                    blocks[8, 5, 7].type = BlockType.Glass;
                    blocks[9, 5, 7].type = BlockType.Glass;
                    blocks[10, 5, 7].type = BlockType.Bonus;
                    blocks[12, 5, 7].type = BlockType.Glass;
                    blocks[13, 5, 7].type = BlockType.Glass;
                    blocks[14, 5, 7].type = BlockType.Glass;
                    for (int x = 0; x <= 14; x++) { blocks[x, 5, 8].type = BlockType.Glass; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 5, 9].type = BlockType.Glass; }
                    for (int x = 1; x <= 6; x++) { blocks[x, 5, 10].type = BlockType.Glass; }
                    blocks[7, 5, 10].type = BlockType.Key; blocks[7, 5, 10].index = 5;
                    for (int x = 8; x <= 13; x++) { blocks[x, 5, 10].type = BlockType.Glass; }
                    for (int x = 1; x <= 6; x++) { blocks[x, 5, 11].type = BlockType.Glass; }
                    for (int x = 8; x <= 13; x++) { blocks[x, 5, 11].type = BlockType.Glass; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 5, 12].type = BlockType.Glass; }
                    for (int x = 3; x <= 11; x++) { blocks[x, 5, 13].type = BlockType.Glass; }
                    for (int x = 5; x <= 9; x++) { blocks[x, 5, 14].type = BlockType.Glass; }
                    for (int x = 5; x <= 9; x++) { blocks[x, 6, 0].type = BlockType.Glass; }
                    blocks[4, 6, 1].type = BlockType.Glass;
                    blocks[5, 6, 1].type = BlockType.Glass;
                    blocks[6, 6, 1].type = BlockType.Glass;
                    blocks[8, 6, 1].type = BlockType.Glass;
                    blocks[9, 6, 1].type = BlockType.Glass;
                    blocks[10, 6, 1].type = BlockType.Glass;
                    for (int x = 2; x <= 12; x++) { blocks[x, 6, 2].type = BlockType.Glass; }
                    for (int x = 1; x <= 6; x++) { blocks[x, 6, 3].type = BlockType.Glass; }
                    for (int x = 8; x <= 13; x++) { blocks[x, 6, 3].type = BlockType.Glass; }
                    for (int x = 1; x <= 13; x++) { blocks[x, 6, 4].type = BlockType.Glass; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 6, 5].type = BlockType.Glass; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 6, 6].type = BlockType.Glass; }
                    blocks[0, 6, 7].type = BlockType.Glass;
                    blocks[2, 6, 7].type = BlockType.Glass;
                    blocks[4, 6, 7].type = BlockType.Glass;
                    blocks[5, 6, 7].type = BlockType.Glass;
                    blocks[6, 6, 7].type = BlockType.Glass;
                    blocks[8, 6, 7].type = BlockType.Glass;
                    blocks[9, 6, 7].type = BlockType.Glass;
                    blocks[10, 6, 7].type = BlockType.Glass;
                    blocks[12, 6, 7].type = BlockType.Glass;
                    blocks[14, 6, 7].type = BlockType.Glass;
                    for (int x = 0; x <= 14; x++) { blocks[x, 6, 8].type = BlockType.Glass; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 6, 9].type = BlockType.Glass; }
                    for (int x = 1; x <= 13; x++) { blocks[x, 6, 10].type = BlockType.Glass; }
                    for (int x = 1; x <= 6; x++) { blocks[x, 6, 11].type = BlockType.Glass; }
                    for (int x = 8; x <= 13; x++) { blocks[x, 6, 11].type = BlockType.Glass; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 6, 12].type = BlockType.Glass; }
                    for (int x = 3; x <= 6; x++) { blocks[x, 6, 13].type = BlockType.Glass; }
                    for (int x = 8; x <= 11; x++) { blocks[x, 6, 13].type = BlockType.Glass; }
                    for (int x = 5; x <= 9; x++) { blocks[x, 6, 14].type = BlockType.Glass; }
                    for (int x = 5; x <= 9; x++) { blocks[x, 7, 0].type = BlockType.Glass; }
                    blocks[4, 7, 1].type = BlockType.Glass;
                    blocks[5, 7, 1].type = BlockType.Glass;
                    blocks[9, 7, 1].type = BlockType.Glass;
                    blocks[10, 7, 1].type = BlockType.Glass;
                    blocks[11, 7, 1].type = BlockType.Glass;
                    for (int x = 2; x <= 6; x++) { blocks[x, 7, 2].type = BlockType.Glass; }
                    for (int x = 8; x <= 12; x++) { blocks[x, 7, 2].type = BlockType.Glass; }
                    for (int x = 1; x <= 4; x++) { blocks[x, 7, 3].type = BlockType.Glass; }
                    for (int x = 10; x <= 13; x++) { blocks[x, 7, 3].type = BlockType.Glass; }
                    for (int x = 1; x <= 4; x++) { blocks[x, 7, 4].type = BlockType.Glass; }
                    for (int x = 10; x <= 13; x++) { blocks[x, 7, 4].type = BlockType.Glass; }
                    blocks[0, 7, 5].type = BlockType.Glass;
                    blocks[1, 7, 5].type = BlockType.Glass;
                    blocks[2, 7, 5].type = BlockType.Glass;
                    blocks[5, 7, 5].type = BlockType.Glass;
                    blocks[6, 7, 5].type = BlockType.Glass;
                    blocks[7, 7, 5].type = BlockType.Lock; blocks[7, 7, 5].index = 1;
                    blocks[8, 7, 5].type = BlockType.Glass;
                    blocks[9, 7, 5].type = BlockType.Glass;
                    blocks[11, 7, 5].type = BlockType.Key; blocks[11, 7, 5].index = 2;
                    blocks[12, 7, 5].type = BlockType.Glass;
                    blocks[13, 7, 5].type = BlockType.Glass;
                    blocks[14, 7, 5].type = BlockType.Glass;
                    blocks[0, 7, 6].type = BlockType.Glass;
                    blocks[1, 7, 6].type = BlockType.Bonus;
                    blocks[2, 7, 6].type = BlockType.Glass;
                    blocks[4, 7, 6].type = BlockType.Glass;
                    blocks[5, 7, 6].type = BlockType.Glass;
                    blocks[6, 7, 6].type = BlockType.Glass;
                    blocks[8, 7, 6].type = BlockType.Glass;
                    blocks[9, 7, 6].type = BlockType.Glass;
                    blocks[10, 7, 6].type = BlockType.Glass;
                    blocks[12, 7, 6].type = BlockType.Glass;
                    blocks[14, 7, 6].type = BlockType.Glass;
                    blocks[0, 7, 7].type = BlockType.Glass;
                    blocks[5, 7, 7].type = BlockType.Lock; blocks[5, 7, 7].index = 3;
                    blocks[7, 7, 7].type = BlockType.Start;
                    blocks[9, 7, 7].type = BlockType.Lock; blocks[9, 7, 7].index = 3;
                    blocks[14, 7, 7].type = BlockType.Glass;
                    blocks[0, 7, 8].type = BlockType.Glass;
                    blocks[2, 7, 8].type = BlockType.Glass;
                    blocks[4, 7, 8].type = BlockType.Glass;
                    blocks[5, 7, 8].type = BlockType.Glass;
                    blocks[6, 7, 8].type = BlockType.Glass;
                    blocks[8, 7, 8].type = BlockType.Glass;
                    blocks[9, 7, 8].type = BlockType.Glass;
                    blocks[10, 7, 8].type = BlockType.Glass;
                    blocks[12, 7, 8].type = BlockType.Glass;
                    blocks[14, 7, 8].type = BlockType.Glass;
                    blocks[0, 7, 9].type = BlockType.Glass;
                    blocks[1, 7, 9].type = BlockType.Glass;
                    blocks[2, 7, 9].type = BlockType.Glass;
                    blocks[5, 7, 9].type = BlockType.Glass;
                    blocks[6, 7, 9].type = BlockType.Glass;
                    blocks[7, 7, 9].type = BlockType.Lock; blocks[7, 7, 9].index = 4;
                    blocks[8, 7, 9].type = BlockType.Glass;
                    blocks[9, 7, 9].type = BlockType.Glass;
                    blocks[12, 7, 9].type = BlockType.Glass;
                    blocks[13, 7, 9].type = BlockType.Glass;
                    blocks[14, 7, 9].type = BlockType.Glass;
                    for (int x = 1; x <= 4; x++) { blocks[x, 7, 10].type = BlockType.Glass; }
                    blocks[6, 7, 10].type = BlockType.Glass;
                    blocks[8, 7, 10].type = BlockType.Glass;
                    for (int x = 10; x <= 13; x++) { blocks[x, 7, 10].type = BlockType.Glass; }
                    for (int x = 1; x <= 4; x++) { blocks[x, 7, 11].type = BlockType.Glass; }
                    for (int x = 10; x <= 13; x++) { blocks[x, 7, 11].type = BlockType.Glass; }
                    for (int x = 2; x <= 6; x++) { blocks[x, 7, 12].type = BlockType.Glass; }
                    for (int x = 8; x <= 12; x++) { blocks[x, 7, 12].type = BlockType.Glass; }
                    blocks[3, 7, 13].type = BlockType.Glass;
                    blocks[4, 7, 13].type = BlockType.Glass;
                    blocks[5, 7, 13].type = BlockType.Glass;
                    blocks[9, 7, 13].type = BlockType.Glass;
                    blocks[10, 7, 13].type = BlockType.Glass;
                    blocks[11, 7, 13].type = BlockType.Glass;
                    for (int x = 5; x <= 9; x++) { blocks[x, 7, 14].type = BlockType.Glass; }
                    for (int x = 5; x <= 9; x++) { blocks[x, 8, 0].type = BlockType.Glass; }
                    blocks[4, 8, 1].type = BlockType.Glass;
                    blocks[5, 8, 1].type = BlockType.Glass;
                    blocks[6, 8, 1].type = BlockType.Glass;
                    blocks[8, 8, 1].type = BlockType.Glass;
                    blocks[9, 8, 1].type = BlockType.Glass;
                    blocks[10, 8, 1].type = BlockType.Glass;
                    for (int x = 2; x <= 12; x++) { blocks[x, 8, 2].type = BlockType.Glass; }
                    for (int x = 1; x <= 6; x++) { blocks[x, 8, 3].type = BlockType.Glass; }
                    for (int x = 8; x <= 13; x++) { blocks[x, 8, 3].type = BlockType.Glass; }
                    for (int x = 1; x <= 13; x++) { blocks[x, 8, 4].type = BlockType.Glass; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 8, 5].type = BlockType.Glass; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 8, 6].type = BlockType.Glass; }
                    blocks[0, 8, 7].type = BlockType.Glass;
                    blocks[2, 8, 7].type = BlockType.Glass;
                    blocks[4, 8, 7].type = BlockType.Glass;
                    blocks[5, 8, 7].type = BlockType.Glass;
                    blocks[6, 8, 7].type = BlockType.Glass;
                    blocks[8, 8, 7].type = BlockType.Glass;
                    blocks[9, 8, 7].type = BlockType.Glass;
                    blocks[10, 8, 7].type = BlockType.Glass;
                    blocks[12, 8, 7].type = BlockType.Glass;
                    blocks[14, 8, 7].type = BlockType.Glass;
                    for (int x = 0; x <= 14; x++) { blocks[x, 8, 8].type = BlockType.Glass; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 8, 9].type = BlockType.Glass; }
                    for (int x = 1; x <= 13; x++) { blocks[x, 8, 10].type = BlockType.Glass; }
                    for (int x = 1; x <= 6; x++) { blocks[x, 8, 11].type = BlockType.Glass; }
                    for (int x = 8; x <= 13; x++) { blocks[x, 8, 11].type = BlockType.Glass; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 8, 12].type = BlockType.Glass; }
                    for (int x = 3; x <= 6; x++) { blocks[x, 8, 13].type = BlockType.Glass; }
                    for (int x = 8; x <= 11; x++) { blocks[x, 8, 13].type = BlockType.Glass; }
                    for (int x = 5; x <= 9; x++) { blocks[x, 8, 14].type = BlockType.Glass; }
                    for (int x = 5; x <= 9; x++) { blocks[x, 9, 0].type = BlockType.Glass; }
                    for (int x = 4; x <= 11; x++) { blocks[x, 9, 1].type = BlockType.Glass; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 9, 2].type = BlockType.Glass; }
                    for (int x = 1; x <= 6; x++) { blocks[x, 9, 3].type = BlockType.Glass; }
                    for (int x = 8; x <= 13; x++) { blocks[x, 9, 3].type = BlockType.Glass; }
                    for (int x = 1; x <= 6; x++) { blocks[x, 9, 4].type = BlockType.Glass; }
                    blocks[7, 9, 4].type = BlockType.Key; blocks[7, 9, 4].index = 4;
                    for (int x = 8; x <= 13; x++) { blocks[x, 9, 4].type = BlockType.Glass; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 9, 5].type = BlockType.Glass; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 9, 6].type = BlockType.Glass; }
                    blocks[0, 9, 7].type = BlockType.Glass;
                    blocks[1, 9, 7].type = BlockType.Glass;
                    blocks[2, 9, 7].type = BlockType.Glass;
                    blocks[4, 9, 7].type = BlockType.Key; blocks[4, 9, 7].index = 1;
                    blocks[5, 9, 7].type = BlockType.Glass;
                    blocks[6, 9, 7].type = BlockType.Glass;
                    blocks[8, 9, 7].type = BlockType.Glass;
                    blocks[9, 9, 7].type = BlockType.Glass;
                    blocks[10, 9, 7].type = BlockType.Bonus;
                    blocks[12, 9, 7].type = BlockType.Glass;
                    blocks[13, 9, 7].type = BlockType.Glass;
                    blocks[14, 9, 7].type = BlockType.Glass;
                    for (int x = 0; x <= 14; x++) { blocks[x, 9, 8].type = BlockType.Glass; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 9, 9].type = BlockType.Glass; }
                    for (int x = 1; x <= 6; x++) { blocks[x, 9, 10].type = BlockType.Glass; }
                    for (int x = 8; x <= 13; x++) { blocks[x, 9, 10].type = BlockType.Glass; }
                    for (int x = 1; x <= 6; x++) { blocks[x, 9, 11].type = BlockType.Glass; }
                    for (int x = 8; x <= 13; x++) { blocks[x, 9, 11].type = BlockType.Glass; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 9, 12].type = BlockType.Glass; }
                    for (int x = 3; x <= 11; x++) { blocks[x, 9, 13].type = BlockType.Glass; }
                    for (int x = 5; x <= 9; x++) { blocks[x, 9, 14].type = BlockType.Glass; }
                    for (int x = 5; x <= 9; x++) { blocks[x, 10, 1].type = BlockType.Glass; }
                    for (int x = 4; x <= 10; x++) { blocks[x, 10, 2].type = BlockType.Glass; }
                    for (int x = 3; x <= 11; x++) { blocks[x, 10, 3].type = BlockType.Glass; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 10, 4].type = BlockType.Glass; }
                    for (int x = 1; x <= 6; x++) { blocks[x, 10, 5].type = BlockType.Glass; }
                    for (int x = 8; x <= 13; x++) { blocks[x, 10, 5].type = BlockType.Glass; }
                    for (int x = 1; x <= 13; x++) { blocks[x, 10, 6].type = BlockType.Glass; }
                    for (int x = 1; x <= 4; x++) { blocks[x, 10, 7].type = BlockType.Glass; }
                    blocks[6, 10, 7].type = BlockType.Glass;
                    blocks[8, 10, 7].type = BlockType.Glass;
                    for (int x = 10; x <= 13; x++) { blocks[x, 10, 7].type = BlockType.Glass; }
                    for (int x = 1; x <= 13; x++) { blocks[x, 10, 8].type = BlockType.Glass; }
                    for (int x = 1; x <= 6; x++) { blocks[x, 10, 9].type = BlockType.Glass; }
                    for (int x = 8; x <= 13; x++) { blocks[x, 10, 9].type = BlockType.Glass; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 10, 10].type = BlockType.Glass; }
                    for (int x = 3; x <= 11; x++) { blocks[x, 10, 11].type = BlockType.Glass; }
                    for (int x = 4; x <= 10; x++) { blocks[x, 10, 12].type = BlockType.Glass; }
                    for (int x = 5; x <= 9; x++) { blocks[x, 10, 13].type = BlockType.Glass; }
                    for (int x = 5; x <= 9; x++) { blocks[x, 11, 1].type = BlockType.Glass; }
                    for (int x = 4; x <= 10; x++) { blocks[x, 11, 2].type = BlockType.Glass; }
                    for (int x = 3; x <= 11; x++) { blocks[x, 11, 3].type = BlockType.Glass; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 11, 4].type = BlockType.Glass; }
                    for (int x = 1; x <= 6; x++) { blocks[x, 11, 5].type = BlockType.Glass; }
                    for (int x = 8; x <= 13; x++) { blocks[x, 11, 5].type = BlockType.Glass; }
                    for (int x = 1; x <= 6; x++) { blocks[x, 11, 6].type = BlockType.Glass; }
                    for (int x = 8; x <= 13; x++) { blocks[x, 11, 6].type = BlockType.Glass; }
                    for (int x = 1; x <= 4; x++) { blocks[x, 11, 7].type = BlockType.Glass; }
                    for (int x = 10; x <= 13; x++) { blocks[x, 11, 7].type = BlockType.Glass; }
                    for (int x = 1; x <= 6; x++) { blocks[x, 11, 8].type = BlockType.Glass; }
                    for (int x = 8; x <= 13; x++) { blocks[x, 11, 8].type = BlockType.Glass; }
                    for (int x = 1; x <= 6; x++) { blocks[x, 11, 9].type = BlockType.Glass; }
                    for (int x = 8; x <= 13; x++) { blocks[x, 11, 9].type = BlockType.Glass; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 11, 10].type = BlockType.Glass; }
                    for (int x = 3; x <= 11; x++) { blocks[x, 11, 11].type = BlockType.Glass; }
                    for (int x = 4; x <= 10; x++) { blocks[x, 11, 12].type = BlockType.Glass; }
                    for (int x = 5; x <= 9; x++) { blocks[x, 11, 13].type = BlockType.Glass; }
                    for (int x = 5; x <= 9; x++) { blocks[x, 12, 2].type = BlockType.Glass; }
                    for (int x = 4; x <= 10; x++) { blocks[x, 12, 3].type = BlockType.Glass; }
                    for (int x = 3; x <= 11; x++) { blocks[x, 12, 4].type = BlockType.Glass; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 12, 5].type = BlockType.Glass; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 12, 6].type = BlockType.Glass; }
                    for (int x = 2; x <= 6; x++) { blocks[x, 12, 7].type = BlockType.Glass; }
                    for (int x = 8; x <= 12; x++) { blocks[x, 12, 7].type = BlockType.Glass; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 12, 8].type = BlockType.Glass; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 12, 9].type = BlockType.Glass; }
                    for (int x = 3; x <= 11; x++) { blocks[x, 12, 10].type = BlockType.Glass; }
                    for (int x = 4; x <= 10; x++) { blocks[x, 12, 11].type = BlockType.Glass; }
                    for (int x = 5; x <= 9; x++) { blocks[x, 12, 12].type = BlockType.Glass; }
                    blocks[6, 13, 3].type = BlockType.Glass;
                    blocks[7, 13, 3].type = BlockType.Glass;
                    blocks[8, 13, 3].type = BlockType.Glass;
                    for (int x = 4; x <= 10; x++) { blocks[x, 13, 4].type = BlockType.Glass; }
                    for (int x = 4; x <= 10; x++) { blocks[x, 13, 5].type = BlockType.Glass; }
                    for (int x = 3; x <= 6; x++) { blocks[x, 13, 6].type = BlockType.Glass; }
                    for (int x = 8; x <= 11; x++) { blocks[x, 13, 6].type = BlockType.Glass; }
                    blocks[3, 13, 7].type = BlockType.Glass;
                    blocks[4, 13, 7].type = BlockType.Glass;
                    blocks[5, 13, 7].type = BlockType.Glass;
                    blocks[6, 13, 7].type = BlockType.Bonus;
                    blocks[9, 13, 7].type = BlockType.Glass;
                    blocks[10, 13, 7].type = BlockType.Glass;
                    blocks[11, 13, 7].type = BlockType.Glass;
                    for (int x = 3; x <= 6; x++) { blocks[x, 13, 8].type = BlockType.Glass; }
                    for (int x = 8; x <= 11; x++) { blocks[x, 13, 8].type = BlockType.Glass; }
                    for (int x = 4; x <= 10; x++) { blocks[x, 13, 9].type = BlockType.Glass; }
                    for (int x = 4; x <= 10; x++) { blocks[x, 13, 10].type = BlockType.Glass; }
                    blocks[6, 13, 11].type = BlockType.Glass;
                    blocks[7, 13, 11].type = BlockType.Glass;
                    blocks[8, 13, 11].type = BlockType.Glass;
                    blocks[6, 14, 5].type = BlockType.Glass;
                    blocks[7, 14, 5].type = BlockType.Glass;
                    blocks[8, 14, 5].type = BlockType.Glass;
                    for (int x = 5; x <= 9; x++) { blocks[x, 14, 6].type = BlockType.Glass; }
                    blocks[5, 14, 7].type = BlockType.Glass;
                    blocks[6, 14, 7].type = BlockType.Glass;
                    blocks[8, 14, 7].type = BlockType.Lock; blocks[8, 14, 7].index = 5;
                    blocks[9, 14, 7].type = BlockType.Exit;
                    for (int x = 5; x <= 9; x++) { blocks[x, 14, 8].type = BlockType.Glass; }
                    blocks[6, 14, 9].type = BlockType.Glass;
                    blocks[7, 14, 9].type = BlockType.Glass;
                    blocks[8, 14, 9].type = BlockType.Glass;
                }
                break;
            case 27:
                {
                    for (int x = 1; x <= 13; x++)
                        for (int y = 1; y <= 13; y++)
                            for (int z = 1; z <= 13; z++)
                                blocks[x, y, z].type = BlockType.Air;
                    blocks[1, 1, 1].type = BlockType.Start;
                    blocks[7, 1, 7].type = BlockType.Bonus;
                    for (int x = 2; x <= 12; x++) { blocks[x, 2, 2].type = BlockType.Wall; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 2, 3].type = BlockType.Wall; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 2, 4].type = BlockType.Wall; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 2, 5].type = BlockType.Wall; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 2, 6].type = BlockType.Wall; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 2, 7].type = BlockType.Wall; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 2, 8].type = BlockType.Wall; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 2, 9].type = BlockType.Wall; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 2, 10].type = BlockType.Wall; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 2, 11].type = BlockType.Wall; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 2, 12].type = BlockType.Wall; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 3, 2].type = BlockType.Wall; }
                    blocks[2, 3, 3].type = BlockType.Wall;
                    blocks[7, 3, 3].type = BlockType.Wall;
                    blocks[12, 3, 3].type = BlockType.Wall;
                    blocks[2, 3, 4].type = BlockType.Wall;
                    blocks[7, 3, 4].type = BlockType.Wall;
                    blocks[12, 3, 4].type = BlockType.Wall;
                    blocks[2, 3, 5].type = BlockType.Wall;
                    blocks[5, 3, 5].type = BlockType.Key; blocks[5, 3, 5].index = 2;
                    blocks[7, 3, 5].type = BlockType.Wall;
                    blocks[12, 3, 5].type = BlockType.Wall;
                    blocks[2, 3, 6].type = BlockType.Wall;
                    blocks[7, 3, 6].type = BlockType.Wall;
                    blocks[12, 3, 6].type = BlockType.Wall;
                    blocks[2, 3, 7].type = BlockType.Wall;
                    blocks[7, 3, 7].type = BlockType.Wall;
                    blocks[12, 3, 7].type = BlockType.Wall;
                    blocks[2, 3, 8].type = BlockType.Wall;
                    blocks[7, 3, 8].type = BlockType.Wall;
                    blocks[12, 3, 8].type = BlockType.Wall;
                    blocks[2, 3, 9].type = BlockType.Wall;
                    blocks[7, 3, 9].type = BlockType.Wall;
                    blocks[9, 3, 9].type = BlockType.Bonus;
                    blocks[12, 3, 9].type = BlockType.Wall;
                    blocks[2, 3, 10].type = BlockType.Wall;
                    blocks[7, 3, 10].type = BlockType.Wall;
                    blocks[12, 3, 10].type = BlockType.Wall;
                    blocks[2, 3, 11].type = BlockType.Wall;
                    blocks[7, 3, 11].type = BlockType.Wall;
                    blocks[12, 3, 11].type = BlockType.Wall;
                    for (int x = 2; x <= 12; x++) { blocks[x, 3, 12].type = BlockType.Wall; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 4, 2].type = BlockType.Wall; }
                    blocks[2, 4, 3].type = BlockType.Wall;
                    blocks[7, 4, 3].type = BlockType.Wall;
                    blocks[12, 4, 3].type = BlockType.Wall;
                    blocks[2, 4, 4].type = BlockType.Wall;
                    for (int x = 4; x <= 10; x++) { blocks[x, 4, 4].type = BlockType.Wall; }
                    blocks[12, 4, 4].type = BlockType.Wall;
                    blocks[2, 4, 5].type = BlockType.Wall;
                    for (int x = 4; x <= 10; x++) { blocks[x, 4, 5].type = BlockType.Wall; }
                    blocks[12, 4, 5].type = BlockType.Wall;
                    blocks[2, 4, 6].type = BlockType.Wall;
                    for (int x = 4; x <= 10; x++) { blocks[x, 4, 6].type = BlockType.Wall; }
                    blocks[12, 4, 6].type = BlockType.Wall;
                    blocks[2, 4, 7].type = BlockType.Wall;
                    for (int x = 4; x <= 10; x++) { blocks[x, 4, 7].type = BlockType.Wall; }
                    blocks[12, 4, 7].type = BlockType.Wall;
                    blocks[2, 4, 8].type = BlockType.Wall;
                    for (int x = 4; x <= 10; x++) { blocks[x, 4, 8].type = BlockType.Wall; }
                    blocks[12, 4, 8].type = BlockType.Wall;
                    blocks[2, 4, 9].type = BlockType.Wall;
                    for (int x = 4; x <= 10; x++) { blocks[x, 4, 9].type = BlockType.Wall; }
                    blocks[12, 4, 9].type = BlockType.Wall;
                    blocks[2, 4, 10].type = BlockType.Wall;
                    for (int x = 4; x <= 10; x++) { blocks[x, 4, 10].type = BlockType.Wall; }
                    blocks[12, 4, 10].type = BlockType.Wall;
                    blocks[2, 4, 11].type = BlockType.Wall;
                    blocks[7, 4, 11].type = BlockType.Wall;
                    blocks[9, 4, 11].type = BlockType.Key; blocks[9, 4, 11].index = 1;
                    blocks[12, 4, 11].type = BlockType.Wall;
                    for (int x = 2; x <= 12; x++) { blocks[x, 4, 12].type = BlockType.Wall; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 5, 2].type = BlockType.Wall; }
                    blocks[2, 5, 3].type = BlockType.Wall;
                    blocks[7, 5, 3].type = BlockType.Wall;
                    blocks[12, 5, 3].type = BlockType.Wall;
                    blocks[2, 5, 4].type = BlockType.Wall;
                    for (int x = 4; x <= 10; x++) { blocks[x, 5, 4].type = BlockType.Wall; }
                    blocks[12, 5, 4].type = BlockType.Wall;
                    blocks[2, 5, 5].type = BlockType.Wall;
                    blocks[4, 5, 5].type = BlockType.Wall;
                    blocks[10, 5, 5].type = BlockType.Wall;
                    blocks[12, 5, 5].type = BlockType.Wall;
                    blocks[2, 5, 6].type = BlockType.Wall;
                    blocks[4, 5, 6].type = BlockType.Wall;
                    blocks[10, 5, 6].type = BlockType.Wall;
                    blocks[12, 5, 6].type = BlockType.Wall;
                    blocks[2, 5, 7].type = BlockType.Wall;
                    for (int x = 4; x <= 10; x++) { blocks[x, 5, 7].type = BlockType.Wall; }
                    blocks[12, 5, 7].type = BlockType.Wall;
                    blocks[2, 5, 8].type = BlockType.Wall;
                    blocks[4, 5, 8].type = BlockType.Wall;
                    blocks[10, 5, 8].type = BlockType.Wall;
                    blocks[12, 5, 8].type = BlockType.Wall;
                    blocks[2, 5, 9].type = BlockType.Wall;
                    blocks[4, 5, 9].type = BlockType.Wall;
                    blocks[10, 5, 9].type = BlockType.Wall;
                    blocks[12, 5, 9].type = BlockType.Wall;
                    blocks[2, 5, 10].type = BlockType.Wall;
                    for (int x = 4; x <= 10; x++) { blocks[x, 5, 10].type = BlockType.Wall; }
                    blocks[12, 5, 10].type = BlockType.Wall;
                    blocks[2, 5, 11].type = BlockType.Wall;
                    blocks[7, 5, 11].type = BlockType.Wall;
                    blocks[12, 5, 11].type = BlockType.Wall;
                    for (int x = 2; x <= 12; x++) { blocks[x, 5, 12].type = BlockType.Wall; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 6, 2].type = BlockType.Wall; }
                    blocks[2, 6, 3].type = BlockType.Wall;
                    blocks[7, 6, 3].type = BlockType.Wall;
                    blocks[12, 6, 3].type = BlockType.Wall;
                    blocks[2, 6, 4].type = BlockType.Wall;
                    blocks[4, 6, 4].type = BlockType.Wall;
                    blocks[5, 6, 4].type = BlockType.Wall;
                    blocks[6, 6, 4].type = BlockType.Lock; blocks[6, 6, 4].index = 1;
                    for (int x = 7; x <= 10; x++) { blocks[x, 6, 4].type = BlockType.Wall; }
                    blocks[12, 6, 4].type = BlockType.Wall;
                    blocks[2, 6, 5].type = BlockType.Wall;
                    blocks[4, 6, 5].type = BlockType.Wall;
                    blocks[10, 6, 5].type = BlockType.Wall;
                    blocks[12, 6, 5].type = BlockType.Wall;
                    blocks[2, 6, 6].type = BlockType.Wall;
                    blocks[4, 6, 6].type = BlockType.Wall;
                    blocks[6, 6, 6].type = BlockType.Wall;
                    blocks[7, 6, 6].type = BlockType.Wall;
                    blocks[8, 6, 6].type = BlockType.Wall;
                    blocks[10, 6, 6].type = BlockType.Wall;
                    blocks[12, 6, 6].type = BlockType.Wall;
                    blocks[2, 6, 7].type = BlockType.Wall;
                    for (int x = 4; x <= 10; x++) { blocks[x, 6, 7].type = BlockType.Wall; }
                    blocks[12, 6, 7].type = BlockType.Wall;
                    blocks[2, 6, 8].type = BlockType.Wall;
                    blocks[4, 6, 8].type = BlockType.Wall;
                    blocks[6, 6, 8].type = BlockType.Wall;
                    blocks[7, 6, 8].type = BlockType.Wall;
                    blocks[8, 6, 8].type = BlockType.Wall;
                    blocks[10, 6, 8].type = BlockType.Wall;
                    blocks[12, 6, 8].type = BlockType.Wall;
                    blocks[2, 6, 9].type = BlockType.Wall;
                    blocks[4, 6, 9].type = BlockType.Wall;
                    blocks[10, 6, 9].type = BlockType.Wall;
                    blocks[12, 6, 9].type = BlockType.Wall;
                    blocks[2, 6, 10].type = BlockType.Wall;
                    for (int x = 4; x <= 10; x++) { blocks[x, 6, 10].type = BlockType.Wall; }
                    blocks[12, 6, 10].type = BlockType.Wall;
                    blocks[2, 6, 11].type = BlockType.Wall;
                    blocks[7, 6, 11].type = BlockType.Wall;
                    blocks[12, 6, 11].type = BlockType.Wall;
                    for (int x = 2; x <= 12; x++) { blocks[x, 6, 12].type = BlockType.Wall; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 7, 2].type = BlockType.Wall; }
                    blocks[2, 7, 3].type = BlockType.Wall;
                    blocks[7, 7, 3].type = BlockType.Wall;
                    blocks[12, 7, 3].type = BlockType.Wall;
                    blocks[2, 7, 4].type = BlockType.Wall;
                    for (int x = 4; x <= 10; x++) { blocks[x, 7, 4].type = BlockType.Wall; }
                    blocks[12, 7, 4].type = BlockType.Wall;
                    blocks[2, 7, 5].type = BlockType.Wall;
                    blocks[4, 7, 5].type = BlockType.Wall;
                    blocks[10, 7, 5].type = BlockType.Wall;
                    blocks[12, 7, 5].type = BlockType.Wall;
                    blocks[2, 7, 6].type = BlockType.Wall;
                    blocks[4, 7, 6].type = BlockType.Wall;
                    blocks[6, 7, 6].type = BlockType.Wall;
                    blocks[7, 7, 6].type = BlockType.Lock; blocks[7, 7, 6].index = 5;
                    blocks[8, 7, 6].type = BlockType.Wall;
                    blocks[10, 7, 6].type = BlockType.Wall;
                    blocks[12, 7, 6].type = BlockType.Wall;
                    blocks[2, 7, 7].type = BlockType.Wall;
                    blocks[4, 7, 7].type = BlockType.Wall;
                    blocks[5, 7, 7].type = BlockType.Wall;
                    blocks[6, 7, 7].type = BlockType.Wall;
                    blocks[7, 7, 7].type = BlockType.Exit;
                    blocks[8, 7, 7].type = BlockType.Wall;
                    blocks[9, 7, 7].type = BlockType.Wall;
                    blocks[10, 7, 7].type = BlockType.Wall;
                    blocks[12, 7, 7].type = BlockType.Wall;
                    blocks[2, 7, 8].type = BlockType.Wall;
                    blocks[4, 7, 8].type = BlockType.Wall;
                    blocks[6, 7, 8].type = BlockType.Wall;
                    blocks[7, 7, 8].type = BlockType.Wall;
                    blocks[8, 7, 8].type = BlockType.Wall;
                    blocks[10, 7, 8].type = BlockType.Wall;
                    blocks[12, 7, 8].type = BlockType.Wall;
                    blocks[2, 7, 9].type = BlockType.Wall;
                    blocks[4, 7, 9].type = BlockType.Wall;
                    blocks[10, 7, 9].type = BlockType.Wall;
                    blocks[12, 7, 9].type = BlockType.Wall;
                    blocks[2, 7, 10].type = BlockType.Wall;
                    for (int x = 4; x <= 10; x++) { blocks[x, 7, 10].type = BlockType.Wall; }
                    blocks[12, 7, 10].type = BlockType.Wall;
                    blocks[2, 7, 11].type = BlockType.Wall;
                    blocks[7, 7, 11].type = BlockType.Wall;
                    blocks[12, 7, 11].type = BlockType.Wall;
                    for (int x = 2; x <= 12; x++) { blocks[x, 7, 12].type = BlockType.Wall; }
                    blocks[1, 7, 13].type = BlockType.Bonus;
                    for (int x = 2; x <= 12; x++) { blocks[x, 8, 2].type = BlockType.Wall; }
                    blocks[2, 8, 3].type = BlockType.Wall;
                    blocks[7, 8, 3].type = BlockType.Wall;
                    blocks[12, 8, 3].type = BlockType.Wall;
                    blocks[2, 8, 4].type = BlockType.Wall;
                    for (int x = 4; x <= 10; x++) { blocks[x, 8, 4].type = BlockType.Wall; }
                    blocks[12, 8, 4].type = BlockType.Wall;
                    blocks[2, 8, 5].type = BlockType.Wall;
                    blocks[4, 8, 5].type = BlockType.Wall;
                    blocks[10, 8, 5].type = BlockType.Wall;
                    blocks[12, 8, 5].type = BlockType.Wall;
                    blocks[2, 8, 6].type = BlockType.Wall;
                    blocks[4, 8, 6].type = BlockType.Wall;
                    blocks[6, 8, 6].type = BlockType.Wall;
                    blocks[7, 8, 6].type = BlockType.Wall;
                    blocks[8, 8, 6].type = BlockType.Wall;
                    blocks[10, 8, 6].type = BlockType.Wall;
                    blocks[12, 8, 6].type = BlockType.Wall;
                    blocks[2, 8, 7].type = BlockType.Wall;
                    for (int x = 4; x <= 10; x++) { blocks[x, 8, 7].type = BlockType.Wall; }
                    blocks[12, 8, 7].type = BlockType.Wall;
                    blocks[2, 8, 8].type = BlockType.Wall;
                    blocks[4, 8, 8].type = BlockType.Wall;
                    blocks[6, 8, 8].type = BlockType.Wall;
                    blocks[7, 8, 8].type = BlockType.Wall;
                    blocks[8, 8, 8].type = BlockType.Wall;
                    blocks[10, 8, 8].type = BlockType.Lock; blocks[10, 8, 8].index = 4;
                    blocks[12, 8, 8].type = BlockType.Wall;
                    blocks[2, 8, 9].type = BlockType.Wall;
                    blocks[4, 8, 9].type = BlockType.Wall;
                    blocks[10, 8, 9].type = BlockType.Wall;
                    blocks[12, 8, 9].type = BlockType.Wall;
                    blocks[2, 8, 10].type = BlockType.Wall;
                    for (int x = 4; x <= 10; x++) { blocks[x, 8, 10].type = BlockType.Wall; }
                    blocks[12, 8, 10].type = BlockType.Wall;
                    blocks[2, 8, 11].type = BlockType.Wall;
                    blocks[7, 8, 11].type = BlockType.Wall;
                    blocks[12, 8, 11].type = BlockType.Wall;
                    for (int x = 2; x <= 12; x++) { blocks[x, 8, 12].type = BlockType.Wall; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 9, 2].type = BlockType.Wall; }
                    blocks[2, 9, 3].type = BlockType.Wall;
                    blocks[7, 9, 3].type = BlockType.Wall;
                    blocks[12, 9, 3].type = BlockType.Wall;
                    blocks[2, 9, 4].type = BlockType.Wall;
                    for (int x = 4; x <= 10; x++) { blocks[x, 9, 4].type = BlockType.Wall; }
                    blocks[12, 9, 4].type = BlockType.Wall;
                    blocks[2, 9, 5].type = BlockType.Wall;
                    blocks[4, 9, 5].type = BlockType.Wall;
                    blocks[10, 9, 5].type = BlockType.Wall;
                    blocks[12, 9, 5].type = BlockType.Wall;
                    blocks[2, 9, 6].type = BlockType.Wall;
                    blocks[4, 9, 6].type = BlockType.Wall;
                    blocks[7, 9, 6].type = BlockType.Key; blocks[7, 9, 6].index = 4;
                    blocks[2, 9, 7].type = BlockType.Wall;
                    for (int x = 4; x <= 10; x++) { blocks[x, 9, 7].type = BlockType.Wall; }
                    blocks[12, 9, 7].type = BlockType.Wall;
                    blocks[2, 9, 8].type = BlockType.Wall;
                    blocks[4, 9, 8].type = BlockType.Wall;
                    blocks[7, 9, 8].type = BlockType.Key; blocks[7, 9, 8].index = 5;
                    blocks[10, 9, 8].type = BlockType.Wall;
                    blocks[12, 9, 8].type = BlockType.Wall;
                    blocks[2, 9, 9].type = BlockType.Wall;
                    blocks[4, 9, 9].type = BlockType.Wall;
                    blocks[10, 9, 9].type = BlockType.Wall;
                    blocks[12, 9, 9].type = BlockType.Wall;
                    blocks[2, 9, 10].type = BlockType.Lock; blocks[2, 9, 10].index = 3;
                    for (int x = 4; x <= 10; x++) { blocks[x, 9, 10].type = BlockType.Wall; }
                    blocks[12, 9, 10].type = BlockType.Wall;
                    blocks[2, 9, 11].type = BlockType.Wall;
                    blocks[7, 9, 11].type = BlockType.Wall;
                    blocks[12, 9, 11].type = BlockType.Wall;
                    for (int x = 2; x <= 12; x++) { blocks[x, 9, 12].type = BlockType.Wall; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 10, 2].type = BlockType.Wall; }
                    blocks[2, 10, 3].type = BlockType.Wall;
                    blocks[7, 10, 3].type = BlockType.Wall;
                    blocks[12, 10, 3].type = BlockType.Wall;
                    blocks[2, 10, 4].type = BlockType.Wall;
                    for (int x = 4; x <= 10; x++) { blocks[x, 10, 4].type = BlockType.Wall; }
                    blocks[12, 10, 4].type = BlockType.Wall;
                    blocks[2, 10, 5].type = BlockType.Wall;
                    for (int x = 4; x <= 10; x++) { blocks[x, 10, 5].type = BlockType.Wall; }
                    blocks[12, 10, 5].type = BlockType.Wall;
                    blocks[2, 10, 6].type = BlockType.Wall;
                    for (int x = 4; x <= 10; x++) { blocks[x, 10, 6].type = BlockType.Wall; }
                    blocks[12, 10, 6].type = BlockType.Wall;
                    blocks[2, 10, 7].type = BlockType.Wall;
                    for (int x = 4; x <= 10; x++) { blocks[x, 10, 7].type = BlockType.Wall; }
                    blocks[12, 10, 7].type = BlockType.Wall;
                    blocks[2, 10, 8].type = BlockType.Wall;
                    for (int x = 4; x <= 10; x++) { blocks[x, 10, 8].type = BlockType.Wall; }
                    blocks[12, 10, 8].type = BlockType.Wall;
                    blocks[2, 10, 9].type = BlockType.Wall;
                    for (int x = 4; x <= 10; x++) { blocks[x, 10, 9].type = BlockType.Wall; }
                    blocks[12, 10, 9].type = BlockType.Wall;
                    blocks[2, 10, 10].type = BlockType.Wall;
                    for (int x = 4; x <= 10; x++) { blocks[x, 10, 10].type = BlockType.Wall; }
                    blocks[12, 10, 10].type = BlockType.Wall;
                    blocks[2, 10, 11].type = BlockType.Wall;
                    blocks[7, 10, 11].type = BlockType.Wall;
                    blocks[12, 10, 11].type = BlockType.Wall;
                    for (int x = 2; x <= 12; x++) { blocks[x, 10, 12].type = BlockType.Wall; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 11, 2].type = BlockType.Wall; }
                    blocks[2, 11, 3].type = BlockType.Wall;
                    blocks[7, 11, 3].type = BlockType.Wall;
                    blocks[12, 11, 3].type = BlockType.Wall;
                    blocks[2, 11, 4].type = BlockType.Wall;
                    blocks[7, 11, 4].type = BlockType.Wall;
                    blocks[12, 11, 4].type = BlockType.Lock; blocks[12, 11, 4].index = 2;
                    blocks[2, 11, 5].type = BlockType.Wall;
                    blocks[7, 11, 5].type = BlockType.Wall;
                    blocks[12, 11, 5].type = BlockType.Wall;
                    blocks[2, 11, 6].type = BlockType.Wall;
                    blocks[7, 11, 6].type = BlockType.Wall;
                    blocks[12, 11, 6].type = BlockType.Wall;
                    blocks[2, 11, 7].type = BlockType.Wall;
                    blocks[7, 11, 7].type = BlockType.Wall;
                    blocks[12, 11, 7].type = BlockType.Wall;
                    blocks[2, 11, 8].type = BlockType.Wall;
                    blocks[7, 11, 8].type = BlockType.Wall;
                    blocks[12, 11, 8].type = BlockType.Wall;
                    blocks[2, 11, 9].type = BlockType.Wall;
                    blocks[7, 11, 9].type = BlockType.Wall;
                    blocks[12, 11, 9].type = BlockType.Wall;
                    blocks[2, 11, 10].type = BlockType.Wall;
                    blocks[7, 11, 10].type = BlockType.Wall;
                    blocks[12, 11, 10].type = BlockType.Wall;
                    blocks[2, 11, 11].type = BlockType.Wall;
                    blocks[7, 11, 11].type = BlockType.Wall;
                    blocks[12, 11, 11].type = BlockType.Wall;
                    for (int x = 2; x <= 12; x++) { blocks[x, 11, 12].type = BlockType.Wall; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 12, 2].type = BlockType.Wall; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 12, 3].type = BlockType.Wall; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 12, 4].type = BlockType.Wall; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 12, 5].type = BlockType.Wall; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 12, 6].type = BlockType.Wall; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 12, 7].type = BlockType.Wall; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 12, 8].type = BlockType.Wall; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 12, 9].type = BlockType.Wall; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 12, 10].type = BlockType.Wall; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 12, 11].type = BlockType.Wall; }
                    for (int x = 2; x <= 12; x++) { blocks[x, 12, 12].type = BlockType.Wall; }
                    blocks[7, 13, 7].type = BlockType.Key; blocks[7, 13, 7].index = 3;

                }
                break;
            case 28:
                {
                    blocks[8, 1, 4].type = BlockType.Air;
                    blocks[8, 1, 5].type = BlockType.Air;
                    blocks[8, 1, 6].type = BlockType.Air;
                    blocks[8, 1, 7].type = BlockType.Air;
                    blocks[3, 1, 8].type = BlockType.Bonus;
                    blocks[4, 1, 8].type = BlockType.Bonus;
                    blocks[5, 1, 8].type = BlockType.Air;
                    blocks[6, 1, 8].type = BlockType.Lock; blocks[6, 1, 8].index = 4;
                    blocks[7, 1, 8].type = BlockType.Air;
                    blocks[8, 1, 8].type = BlockType.Air;
                    blocks[8, 1, 9].type = BlockType.Air;
                    blocks[8, 1, 10].type = BlockType.Air;
                    blocks[8, 1, 11].type = BlockType.Air;
                    blocks[8, 1, 12].type = BlockType.Air;
                    blocks[8, 2, 4].type = BlockType.Air;
                    blocks[8, 2, 12].type = BlockType.Air;
                    blocks[9, 2, 12].type = BlockType.Air;
                    blocks[10, 2, 12].type = BlockType.Air;
                    blocks[11, 2, 12].type = BlockType.Air;
                    blocks[12, 2, 12].type = BlockType.Air;
                    blocks[13, 2, 12].type = BlockType.Air;
                    blocks[1, 3, 4].type = BlockType.Air;
                    blocks[8, 3, 4].type = BlockType.Air;
                    blocks[13, 3, 4].type = BlockType.Air;
                    blocks[1, 3, 5].type = BlockType.Air;
                    blocks[13, 3, 5].type = BlockType.Air;
                    blocks[1, 3, 6].type = BlockType.Air;
                    blocks[2, 3, 6].type = BlockType.Lock; blocks[2, 3, 6].index = 3;
                    blocks[3, 3, 6].type = BlockType.Air;
                    blocks[4, 3, 6].type = BlockType.Key; blocks[4, 3, 6].index = 3;
                    blocks[5, 3, 6].type = BlockType.Air;
                    blocks[6, 3, 6].type = BlockType.Air;
                    blocks[8, 3, 6].type = BlockType.Exit;
                    blocks[9, 3, 6].type = BlockType.Air;
                    blocks[10, 3, 6].type = BlockType.Air;
                    blocks[11, 3, 6].type = BlockType.Air;
                    blocks[12, 3, 6].type = BlockType.Lock; blocks[12, 3, 6].index = 1;
                    blocks[13, 3, 6].type = BlockType.Air;
                    blocks[1, 3, 7].type = BlockType.Start;
                    blocks[13, 3, 7].type = BlockType.Air;
                    blocks[1, 3, 8].type = BlockType.Air;
                    blocks[2, 3, 8].type = BlockType.Lock; blocks[2, 3, 8].index = 3;
                    blocks[3, 3, 8].type = BlockType.Air;
                    blocks[4, 3, 8].type = BlockType.Air;
                    blocks[5, 3, 8].type = BlockType.Air;
                    blocks[6, 3, 8].type = BlockType.Air;
                    blocks[8, 3, 8].type = BlockType.Air;
                    blocks[9, 3, 8].type = BlockType.Air;
                    blocks[10, 3, 8].type = BlockType.Key; blocks[10, 3, 8].index = 1;
                    blocks[11, 3, 8].type = BlockType.Air;
                    blocks[12, 3, 8].type = BlockType.Lock; blocks[12, 3, 8].index = 1;
                    blocks[13, 3, 8].type = BlockType.Air;
                    blocks[1, 3, 9].type = BlockType.Air;
                    blocks[13, 3, 9].type = BlockType.Air;
                    blocks[1, 3, 10].type = BlockType.Air;
                    blocks[13, 3, 10].type = BlockType.Air;
                    blocks[13, 3, 12].type = BlockType.Air;
                    blocks[13, 4, 1].type = BlockType.Air;
                    blocks[13, 4, 2].type = BlockType.Air;
                    blocks[13, 4, 3].type = BlockType.Air;
                    blocks[1, 4, 4].type = BlockType.Air;
                    blocks[2, 4, 4].type = BlockType.Air;
                    blocks[3, 4, 4].type = BlockType.Bonus;
                    blocks[8, 4, 4].type = BlockType.Air;
                    blocks[13, 4, 4].type = BlockType.Air;
                    blocks[6, 4, 6].type = BlockType.Air;
                    blocks[6, 4, 8].type = BlockType.Air;
                    blocks[8, 4, 8].type = BlockType.Air;
                    blocks[1, 4, 10].type = BlockType.Air;
                    blocks[2, 4, 10].type = BlockType.Air;
                    blocks[3, 4, 10].type = BlockType.Air;
                    blocks[4, 4, 10].type = BlockType.Air;
                    blocks[5, 4, 10].type = BlockType.Air;
                    blocks[6, 4, 10].type = BlockType.Air;
                    blocks[7, 4, 10].type = BlockType.Air;
                    blocks[8, 4, 10].type = BlockType.Air;
                    blocks[9, 4, 10].type = BlockType.Air;
                    blocks[10, 4, 10].type = BlockType.Air;
                    blocks[13, 4, 10].type = BlockType.Air;
                    blocks[13, 4, 11].type = BlockType.Air;
                    blocks[13, 4, 12].type = BlockType.Air;
                    blocks[11, 5, 1].type = BlockType.Air;
                    blocks[12, 5, 1].type = BlockType.Air;
                    blocks[13, 5, 1].type = BlockType.Air;
                    blocks[7, 5, 2].type = BlockType.Air;
                    blocks[7, 5, 3].type = BlockType.Air;
                    blocks[1, 5, 4].type = BlockType.Air;
                    blocks[6, 5, 4].type = BlockType.Air;
                    blocks[7, 5, 4].type = BlockType.Air;
                    blocks[8, 5, 4].type = BlockType.Air;
                    blocks[6, 5, 5].type = BlockType.Air;
                    blocks[10, 5, 5].type = BlockType.Air;
                    blocks[4, 5, 6].type = BlockType.Air;
                    blocks[6, 5, 6].type = BlockType.Air;
                    blocks[10, 5, 6].type = BlockType.Air;
                    blocks[4, 5, 7].type = BlockType.Air;
                    blocks[10, 5, 7].type = BlockType.Air;
                    blocks[4, 5, 8].type = BlockType.Air;
                    blocks[6, 5, 8].type = BlockType.Air;
                    blocks[8, 5, 8].type = BlockType.Air;
                    blocks[10, 5, 8].type = BlockType.Air;
                    blocks[4, 5, 9].type = BlockType.Air;
                    blocks[10, 5, 9].type = BlockType.Air;
                    blocks[4, 5, 10].type = BlockType.Air;
                    blocks[7, 5, 10].type = BlockType.Air;
                    blocks[10, 5, 10].type = BlockType.Air;
                    blocks[11, 6, 1].type = BlockType.Air;
                    blocks[7, 6, 2].type = BlockType.Air;
                    blocks[11, 6, 2].type = BlockType.Air;
                    blocks[11, 6, 3].type = BlockType.Air;
                    blocks[1, 6, 4].type = BlockType.Air;
                    blocks[10, 6, 5].type = BlockType.Air;
                    blocks[4, 6, 6].type = BlockType.Air;
                    blocks[6, 6, 6].type = BlockType.Air;
                    blocks[6, 6, 8].type = BlockType.Air;
                    blocks[8, 6, 8].type = BlockType.Air;
                    blocks[7, 6, 10].type = BlockType.Air;
                    blocks[7, 7, 2].type = BlockType.Air;
                    blocks[11, 7, 3].type = BlockType.Air;
                    blocks[12, 7, 3].type = BlockType.Air;
                    blocks[13, 7, 3].type = BlockType.Air;
                    blocks[1, 7, 6].type = BlockType.Air;
                    blocks[1, 7, 7].type = BlockType.Air;
                    for (int x = 1; x <= 6; x++) { blocks[x, 7, 8].type = BlockType.Air; }
                    blocks[8, 7, 8].type = BlockType.Air;
                    blocks[9, 7, 8].type = BlockType.Air;
                    blocks[1, 7, 9].type = BlockType.Air;
                    blocks[9, 7, 9].type = BlockType.Air;
                    blocks[1, 7, 10].type = BlockType.Air;
                    blocks[7, 7, 10].type = BlockType.Air;
                    blocks[9, 7, 10].type = BlockType.Air;
                    blocks[9, 7, 11].type = BlockType.Air;
                    blocks[9, 7, 12].type = BlockType.Air;
                    blocks[13, 8, 1].type = BlockType.Air;
                    blocks[7, 8, 2].type = BlockType.Air;
                    blocks[13, 8, 2].type = BlockType.Air;
                    blocks[13, 8, 3].type = BlockType.Air;
                    blocks[1, 8, 4].type = BlockType.Air;
                    blocks[2, 8, 4].type = BlockType.Air;
                    blocks[3, 8, 4].type = BlockType.Bonus;
                    blocks[1, 8, 5].type = BlockType.Air;
                    blocks[1, 8, 6].type = BlockType.Air;
                    blocks[1, 8, 10].type = BlockType.Air;
                    blocks[3, 8, 10].type = BlockType.Bonus;
                    blocks[4, 8, 10].type = BlockType.Air;
                    blocks[7, 8, 10].type = BlockType.Air;
                    blocks[1, 8, 11].type = BlockType.Air;
                    blocks[1, 8, 12].type = BlockType.Air;
                    blocks[2, 8, 12].type = BlockType.Air;
                    blocks[3, 8, 12].type = BlockType.Air;
                    blocks[9, 8, 12].type = BlockType.Air;
                    blocks[11, 9, 1].type = BlockType.Key; blocks[11, 9, 1].index = 2;
                    blocks[12, 9, 1].type = BlockType.Air;
                    blocks[13, 9, 1].type = BlockType.Air;
                    blocks[7, 9, 2].type = BlockType.Air;
                    blocks[7, 9, 3].type = BlockType.Air;
                    blocks[7, 9, 4].type = BlockType.Air;
                    blocks[7, 9, 5].type = BlockType.Air;
                    blocks[7, 9, 6].type = BlockType.Air;
                    blocks[7, 9, 7].type = BlockType.Air;
                    blocks[7, 9, 8].type = BlockType.Air;
                    blocks[7, 9, 9].type = BlockType.Air;
                    blocks[4, 9, 10].type = BlockType.Air;
                    blocks[5, 9, 10].type = BlockType.Air;
                    blocks[7, 9, 10].type = BlockType.Air;
                    blocks[5, 9, 11].type = BlockType.Lock; blocks[5, 9, 11].index = 2;
                    blocks[3, 9, 12].type = BlockType.Air;
                    blocks[4, 9, 12].type = BlockType.Air;
                    blocks[5, 9, 12].type = BlockType.Air;
                    blocks[6, 9, 12].type = BlockType.Lock; blocks[6, 9, 12].index = 2;
                    blocks[7, 9, 12].type = BlockType.Air;
                    blocks[8, 9, 12].type = BlockType.Key; blocks[8, 9, 12].index = 4;
                    blocks[9, 9, 12].type = BlockType.Air;
                }
                break;
            case 29:
                {
                    for (int x = 1; x <= 13; x++)
                        for (int y = 1; y <= 13; y++)
                            for (int z = (x + y) % 2 + 1; z <= 13; z += 2)
                                blocks[x, y, z].type = BlockType.Air;
                    blocks[1, 1, 1].type = BlockType.Start;
                    blocks[2, 1, 1].type = BlockType.Air;
                    blocks[12, 1, 1].type = BlockType.Air;
                    blocks[1, 1, 2].type = BlockType.Air;
                    blocks[7, 1, 2].type = BlockType.Air;
                    blocks[13, 1, 2].type = BlockType.Air;
                    blocks[5, 1, 4].type = BlockType.Air;
                    blocks[4, 1, 5].type = BlockType.Air;
                    blocks[5, 1, 5].type = BlockType.Key; blocks[5, 1, 5].index = 3;
                    blocks[6, 1, 5].type = BlockType.Air;
                    blocks[5, 1, 6].type = BlockType.Air;
                    blocks[10, 1, 7].type = BlockType.Air;
                    blocks[3, 1, 8].type = BlockType.Air;
                    blocks[9, 1, 10].type = BlockType.Air;
                    blocks[1, 1, 12].type = BlockType.Air;
                    blocks[7, 1, 12].type = BlockType.Air;
                    blocks[9, 1, 12].type = BlockType.Air;
                    blocks[13, 1, 12].type = BlockType.Air;
                    blocks[1, 1, 13].type = BlockType.Key; blocks[1, 1, 13].index = 2;
                    blocks[2, 1, 13].type = BlockType.Air;
                    blocks[12, 1, 13].type = BlockType.Air;
                    blocks[13, 1, 13].type = BlockType.Exit;
                    blocks[2, 3, 1].type = BlockType.Air;
                    blocks[4, 3, 1].type = BlockType.Air;
                    blocks[1, 3, 2].type = BlockType.Air;
                    blocks[4, 3, 3].type = BlockType.Air;
                    blocks[5, 3, 3].type = BlockType.Bonus;
                    blocks[1, 3, 4].type = BlockType.Air;
                    blocks[6, 3, 5].type = BlockType.Air;
                    blocks[1, 3, 6].type = BlockType.Air;
                    blocks[3, 3, 6].type = BlockType.Air;
                    blocks[7, 3, 6].type = BlockType.Air;
                    blocks[3, 3, 8].type = BlockType.Air;
                    blocks[4, 3, 9].type = BlockType.Air;
                    blocks[6, 3, 9].type = BlockType.Air;
                    blocks[3, 3, 10].type = BlockType.Air;
                    blocks[2, 3, 11].type = BlockType.Air;
                    blocks[1, 3, 12].type = BlockType.Air;
                    blocks[13, 3, 12].type = BlockType.Air;
                    blocks[12, 3, 13].type = BlockType.Air;
                    blocks[8, 4, 6].type = BlockType.Air;
                    blocks[9, 4, 6].type = BlockType.Lock; blocks[9, 4, 6].index = 2;
                    blocks[10, 4, 6].type = BlockType.Air;
                    blocks[11, 4, 7].type = BlockType.Air;
                    blocks[11, 4, 9].type = BlockType.Air;
                    blocks[13, 4, 9].type = BlockType.Air;
                    blocks[6, 4, 10].type = BlockType.Air;
                    blocks[10, 4, 10].type = BlockType.Air;
                    blocks[12, 4, 10].type = BlockType.Air;
                    blocks[5, 4, 11].type = BlockType.Air;
                    blocks[8, 4, 12].type = BlockType.Air;
                    blocks[5, 4, 13].type = BlockType.Air;
                    blocks[7, 4, 13].type = BlockType.Air;
                    blocks[9, 4, 13].type = BlockType.Air;
                    blocks[11, 4, 13].type = BlockType.Lock; blocks[11, 4, 13].index = 1;
                    blocks[11, 5, 6].type = BlockType.Air;
                    blocks[9, 5, 8].type = BlockType.Air;
                    blocks[10, 5, 9].type = BlockType.Air;
                    blocks[8, 6, 2].type = BlockType.Air;
                    blocks[10, 6, 2].type = BlockType.Air;
                    blocks[12, 6, 2].type = BlockType.Air;
                    blocks[9, 6, 3].type = BlockType.Air;
                    blocks[13, 6, 3].type = BlockType.Air;
                    blocks[9, 6, 5].type = BlockType.Air;
                    blocks[11, 6, 5].type = BlockType.Air;
                    blocks[13, 6, 5].type = BlockType.Air;
                    blocks[13, 6, 6].type = BlockType.Bonus;
                    blocks[9, 6, 9].type = BlockType.Air;
                    blocks[8, 6, 10].type = BlockType.Air;
                    blocks[8, 6, 12].type = BlockType.Air;
                    blocks[7, 7, 2].type = BlockType.Air;
                    blocks[9, 7, 10].type = BlockType.Air;
                    blocks[2, 8, 2].type = BlockType.Air;
                    blocks[4, 8, 2].type = BlockType.Air;
                    blocks[6, 8, 2].type = BlockType.Air;
                    blocks[5, 8, 3].type = BlockType.Air;
                    blocks[2, 8, 4].type = BlockType.Air;
                    blocks[5, 8, 5].type = BlockType.Air;
                    blocks[7, 8, 5].type = BlockType.Air;
                    blocks[9, 8, 5].type = BlockType.Air;
                    blocks[2, 9, 3].type = BlockType.Air;
                    blocks[8, 9, 3].type = BlockType.Air;
                    blocks[1, 9, 4].type = BlockType.Air;
                    blocks[3, 9, 4].type = BlockType.Air;
                    blocks[7, 9, 4].type = BlockType.Air;
                    blocks[2, 9, 5].type = BlockType.Air;
                    blocks[8, 9, 5].type = BlockType.Air;
                    blocks[12, 9, 5].type = BlockType.Air;
                    blocks[3, 9, 6].type = BlockType.Air;
                    blocks[9, 9, 6].type = BlockType.Air;
                    blocks[11, 9, 6].type = BlockType.Air;
                    blocks[13, 9, 6].type = BlockType.Air;
                    blocks[2, 9, 7].type = BlockType.Air;
                    blocks[8, 9, 7].type = BlockType.Air;
                    blocks[12, 9, 7].type = BlockType.Air;
                    blocks[9, 9, 8].type = BlockType.Air;
                    blocks[2, 9, 9].type = BlockType.Air;
                    blocks[4, 9, 9].type = BlockType.Air;
                    blocks[10, 9, 9].type = BlockType.Air;
                    blocks[11, 9, 10].type = BlockType.Air;
                    blocks[2, 9, 11].type = BlockType.Air;
                    blocks[10, 9, 11].type = BlockType.Air;
                    blocks[2, 9, 13].type = BlockType.Air;
                    blocks[4, 9, 13].type = BlockType.Air;
                    blocks[10, 9, 13].type = BlockType.Air;
                    blocks[1, 10, 7].type = BlockType.Air;
                    blocks[11, 10, 9].type = BlockType.Air;
                    blocks[1, 11, 8].type = BlockType.Air;
                    blocks[11, 11, 8].type = BlockType.Air;
                    blocks[12, 11, 9].type = BlockType.Air;
                    blocks[12, 11, 11].type = BlockType.Air;
                    blocks[4, 12, 2].type = BlockType.Air;
                    blocks[6, 12, 2].type = BlockType.Air;
                    blocks[8, 12, 2].type = BlockType.Air;
                    blocks[10, 12, 2].type = BlockType.Air;
                    blocks[12, 12, 2].type = BlockType.Air;
                    blocks[12, 12, 4].type = BlockType.Air;
                    blocks[7, 12, 6].type = BlockType.Bonus;
                    blocks[12, 12, 6].type = BlockType.Air;
                    blocks[1, 12, 7].type = BlockType.Air;
                    blocks[7, 12, 7].type = BlockType.Air;
                    blocks[2, 12, 8].type = BlockType.Air;
                    blocks[12, 12, 8].type = BlockType.Air;
                    blocks[7, 12, 9].type = BlockType.Air;
                    blocks[13, 12, 9].type = BlockType.Air;
                    blocks[2, 12, 10].type = BlockType.Air;
                    blocks[8, 12, 10].type = BlockType.Air;
                    blocks[10, 12, 10].type = BlockType.Air;
                    blocks[12, 12, 10].type = BlockType.Air;
                    blocks[2, 12, 11].type = BlockType.Lock; blocks[2, 12, 11].index = 3;
                    blocks[2, 12, 12].type = BlockType.Air;
                    blocks[10, 12, 12].type = BlockType.Air;
                    blocks[12, 12, 12].type = BlockType.Air;
                    blocks[7, 12, 13].type = BlockType.Air;
                    blocks[9, 12, 13].type = BlockType.Air;
                    blocks[1, 13, 13].type = BlockType.Key; blocks[1, 13, 13].index = 1;
                    blocks[2, 13, 13].type = BlockType.Air;
                    blocks[4, 13, 13].type = BlockType.Air;
                    blocks[5, 13, 13].type = BlockType.Lock; blocks[5, 13, 13].index = 3;
                }
                break;
            case 30:
                {
                    blocks[5, 1, 1].type = BlockType.Air;
                    blocks[7, 1, 1].type = BlockType.Key; blocks[7, 1, 1].index = 1;
                    blocks[9, 1, 1].type = BlockType.Air;
                    blocks[5, 1, 2].type = BlockType.Air;
                    blocks[7, 1, 2].type = BlockType.Air;
                    blocks[9, 1, 2].type = BlockType.Air;
                    blocks[5, 1, 3].type = BlockType.Air;
                    blocks[9, 1, 3].type = BlockType.Air;
                    blocks[5, 1, 4].type = BlockType.Air;
                    blocks[7, 1, 4].type = BlockType.Air;
                    blocks[7, 1, 5].type = BlockType.Air;
                    blocks[9, 1, 5].type = BlockType.Air;
                    blocks[5, 1, 6].type = BlockType.Air;
                    blocks[7, 1, 6].type = BlockType.Air;
                    blocks[5, 1, 7].type = BlockType.Air;
                    blocks[9, 1, 7].type = BlockType.Air;
                    blocks[5, 1, 8].type = BlockType.Air;
                    blocks[7, 1, 8].type = BlockType.Air;
                    blocks[9, 1, 8].type = BlockType.Air;
                    blocks[7, 1, 9].type = BlockType.Air;
                    blocks[9, 1, 9].type = BlockType.Air;
                    blocks[5, 1, 10].type = BlockType.Air;
                    blocks[7, 1, 10].type = BlockType.Air;
                    blocks[5, 1, 11].type = BlockType.Air;
                    blocks[9, 1, 11].type = BlockType.Air;
                    blocks[5, 1, 12].type = BlockType.Air;
                    blocks[9, 1, 12].type = BlockType.Air;
                    blocks[5, 1, 13].type = BlockType.Air;
                    blocks[7, 1, 13].type = BlockType.Air;
                    blocks[9, 1, 13].type = BlockType.Air;
                    blocks[5, 2, 1].type = BlockType.Air;
                    blocks[9, 2, 1].type = BlockType.Air;
                    blocks[7, 2, 2].type = BlockType.Air;
                    blocks[7, 2, 3].type = BlockType.Air;
                    blocks[9, 2, 3].type = BlockType.Air;
                    blocks[5, 2, 4].type = BlockType.Air;
                    blocks[7, 2, 4].type = BlockType.Air;
                    blocks[9, 2, 4].type = BlockType.Bonus;
                    blocks[9, 2, 5].type = BlockType.Air;
                    blocks[7, 2, 6].type = BlockType.Air;
                    blocks[5, 2, 7].type = BlockType.Air;
                    blocks[7, 2, 7].type = BlockType.Lock; blocks[7, 2, 7].index = 2;
                    blocks[9, 2, 7].type = BlockType.Air;
                    blocks[7, 2, 8].type = BlockType.Air;
                    blocks[9, 2, 9].type = BlockType.Air;
                    blocks[5, 2, 10].type = BlockType.Air;
                    blocks[7, 2, 10].type = BlockType.Air;
                    blocks[9, 2, 10].type = BlockType.Air;
                    blocks[7, 2, 11].type = BlockType.Air;
                    blocks[9, 2, 11].type = BlockType.Air;
                    blocks[7, 2, 12].type = BlockType.Air;
                    blocks[5, 2, 13].type = BlockType.Air;
                    blocks[7, 2, 13].type = BlockType.Air;
                    blocks[9, 2, 13].type = BlockType.Air;
                    blocks[5, 3, 1].type = BlockType.Air;
                    blocks[9, 3, 1].type = BlockType.Air;
                    blocks[5, 3, 2].type = BlockType.Key; blocks[5, 3, 2].index = 3;
                    blocks[5, 3, 4].type = BlockType.Air;
                    blocks[5, 3, 5].type = BlockType.Air;
                    blocks[5, 3, 7].type = BlockType.Air;
                    blocks[5, 3, 9].type = BlockType.Air;
                    blocks[9, 3, 9].type = BlockType.Air;
                    blocks[5, 3, 10].type = BlockType.Air;
                    blocks[7, 3, 11].type = BlockType.Air;
                    blocks[5, 3, 12].type = BlockType.Key; blocks[5, 3, 12].index = 5;
                    blocks[5, 3, 13].type = BlockType.Air;
                    blocks[9, 3, 13].type = BlockType.Air;
                    blocks[7, 4, 1].type = BlockType.Air;
                    blocks[9, 4, 1].type = BlockType.Air;
                    blocks[7, 4, 2].type = BlockType.Air;
                    blocks[7, 4, 3].type = BlockType.Air;
                    blocks[9, 4, 3].type = BlockType.Air;
                    blocks[7, 4, 4].type = BlockType.Air;
                    blocks[9, 4, 4].type = BlockType.Air;
                    blocks[5, 4, 5].type = BlockType.Air;
                    blocks[9, 4, 5].type = BlockType.Air;
                    blocks[7, 4, 6].type = BlockType.Air;
                    blocks[8, 4, 6].type = BlockType.Air;
                    blocks[9, 4, 6].type = BlockType.Air;
                    blocks[5, 4, 7].type = BlockType.Air;
                    blocks[7, 4, 7].type = BlockType.Air;
                    blocks[7, 4, 8].type = BlockType.Air;
                    blocks[9, 4, 8].type = BlockType.Air;
                    blocks[5, 4, 9].type = BlockType.Air;
                    blocks[7, 4, 9].type = BlockType.Bonus;
                    blocks[9, 4, 9].type = BlockType.Air;
                    blocks[9, 4, 10].type = BlockType.Air;
                    blocks[7, 4, 11].type = BlockType.Air;
                    blocks[9, 4, 11].type = BlockType.Bonus;
                    blocks[7, 4, 13].type = BlockType.Air;
                    blocks[9, 4, 13].type = BlockType.Air;
                    blocks[5, 5, 1].type = BlockType.Air;
                    blocks[7, 5, 1].type = BlockType.Air;
                    blocks[9, 5, 1].type = BlockType.Air;
                    blocks[5, 5, 2].type = BlockType.Air;
                    blocks[9, 5, 2].type = BlockType.Air;
                    blocks[5, 5, 3].type = BlockType.Air;
                    blocks[7, 5, 3].type = BlockType.Air;
                    blocks[9, 5, 3].type = BlockType.Air;
                    blocks[5, 5, 5].type = BlockType.Air;
                    blocks[5, 5, 6].type = BlockType.Air;
                    blocks[5, 5, 7].type = BlockType.Air;
                    blocks[5, 5, 8].type = BlockType.Air;
                    blocks[7, 5, 8].type = BlockType.Air;
                    blocks[5, 5, 9].type = BlockType.Air;
                    blocks[9, 5, 10].type = BlockType.Air;
                    blocks[5, 5, 11].type = BlockType.Air;
                    blocks[7, 5, 11].type = BlockType.Air;
                    blocks[5, 5, 12].type = BlockType.Air;
                    blocks[5, 5, 13].type = BlockType.Air;
                    blocks[7, 5, 13].type = BlockType.Air;
                    blocks[9, 5, 13].type = BlockType.Air;
                    blocks[7, 6, 1].type = BlockType.Air;
                    blocks[7, 6, 2].type = BlockType.Air;
                    blocks[5, 6, 3].type = BlockType.Air;
                    blocks[7, 6, 3].type = BlockType.Air;
                    blocks[9, 6, 3].type = BlockType.Air;
                    blocks[9, 6, 4].type = BlockType.Lock; blocks[9, 6, 4].index = 1;
                    blocks[7, 6, 5].type = BlockType.Air;
                    blocks[9, 6, 5].type = BlockType.Air;
                    blocks[7, 6, 6].type = BlockType.Key; blocks[7, 6, 6].index = 2;
                    blocks[5, 6, 7].type = BlockType.Air;
                    blocks[9, 6, 7].type = BlockType.Air;
                    blocks[7, 6, 8].type = BlockType.Air;
                    blocks[7, 6, 9].type = BlockType.Air;
                    blocks[7, 6, 10].type = BlockType.Air;
                    blocks[9, 6, 10].type = BlockType.Air;
                    blocks[5, 6, 11].type = BlockType.Air;
                    blocks[7, 6, 11].type = BlockType.Air;
                    blocks[9, 6, 11].type = BlockType.Air;
                    blocks[7, 6, 12].type = BlockType.Air;
                    blocks[9, 6, 12].type = BlockType.Lock; blocks[9, 6, 12].index = 4;
                    blocks[5, 6, 13].type = BlockType.Air;
                    blocks[7, 6, 13].type = BlockType.Air;
                    blocks[9, 6, 13].type = BlockType.Air;
                    blocks[1, 7, 1].type = BlockType.Start;
                    blocks[5, 7, 1].type = BlockType.Air;
                    blocks[9, 7, 1].type = BlockType.Air;
                    blocks[1, 7, 2].type = BlockType.Air;
                    blocks[5, 7, 2].type = BlockType.Air;
                    blocks[1, 7, 3].type = BlockType.Air;
                    blocks[5, 7, 3].type = BlockType.Air;
                    blocks[7, 7, 3].type = BlockType.Air;
                    blocks[1, 7, 4].type = BlockType.Air;
                    blocks[5, 7, 4].type = BlockType.Air;
                    blocks[1, 7, 5].type = BlockType.Air;
                    blocks[5, 7, 5].type = BlockType.Air;
                    blocks[7, 7, 5].type = BlockType.Air;
                    blocks[9, 7, 5].type = BlockType.Air;
                    blocks[1, 7, 6].type = BlockType.Air;
                    blocks[1, 7, 7].type = BlockType.Air;
                    blocks[2, 7, 7].type = BlockType.Air;
                    blocks[3, 7, 7].type = BlockType.Air;
                    blocks[4, 7, 7].type = BlockType.Air;
                    blocks[5, 7, 7].type = BlockType.Air;
                    blocks[9, 7, 7].type = BlockType.Air;
                    blocks[10, 7, 7].type = BlockType.Air;
                    blocks[11, 7, 7].type = BlockType.Air;
                    blocks[12, 7, 7].type = BlockType.Air;
                    blocks[13, 7, 7].type = BlockType.Air;
                    blocks[13, 7, 8].type = BlockType.Air;
                    blocks[5, 7, 9].type = BlockType.Air;
                    blocks[9, 7, 9].type = BlockType.Air;
                    blocks[13, 7, 9].type = BlockType.Air;
                    blocks[5, 7, 10].type = BlockType.Air;
                    blocks[9, 7, 10].type = BlockType.Air;
                    blocks[13, 7, 10].type = BlockType.Air;
                    blocks[5, 7, 11].type = BlockType.Air;
                    blocks[7, 7, 11].type = BlockType.Air;
                    blocks[13, 7, 11].type = BlockType.Air;
                    blocks[13, 7, 12].type = BlockType.Air;
                    blocks[5, 7, 13].type = BlockType.Air;
                    blocks[7, 7, 13].type = BlockType.Air;
                    blocks[9, 7, 13].type = BlockType.Air;
                    blocks[13, 7, 13].type = BlockType.Exit;
                    blocks[5, 8, 1].type = BlockType.Air;
                    blocks[7, 8, 1].type = BlockType.Air;
                    blocks[9, 8, 1].type = BlockType.Air;
                    blocks[9, 8, 2].type = BlockType.Air;
                    blocks[7, 8, 3].type = BlockType.Air;
                    blocks[9, 8, 3].type = BlockType.Air;
                    blocks[9, 8, 4].type = BlockType.Air;
                    blocks[5, 8, 5].type = BlockType.Air;
                    blocks[7, 8, 5].type = BlockType.Air;
                    blocks[9, 8, 5].type = BlockType.Air;
                    blocks[5, 8, 7].type = BlockType.Air;
                    blocks[7, 8, 7].type = BlockType.Air;
                    blocks[9, 8, 7].type = BlockType.Air;
                    blocks[5, 8, 9].type = BlockType.Air;
                    blocks[7, 8, 9].type = BlockType.Air;
                    blocks[7, 8, 11].type = BlockType.Air;
                    blocks[9, 8, 12].type = BlockType.Air;
                    blocks[5, 8, 13].type = BlockType.Air;
                    blocks[7, 8, 13].type = BlockType.Air;
                    blocks[9, 8, 13].type = BlockType.Air;
                    blocks[5, 9, 1].type = BlockType.Air;
                    blocks[7, 9, 1].type = BlockType.Air;
                    blocks[9, 9, 1].type = BlockType.Air;
                    blocks[5, 9, 2].type = BlockType.Air;
                    blocks[5, 9, 3].type = BlockType.Bonus;
                    blocks[7, 9, 3].type = BlockType.Air;
                    blocks[7, 9, 4].type = BlockType.Air;
                    blocks[5, 9, 5].type = BlockType.Air;
                    blocks[7, 9, 5].type = BlockType.Air;
                    blocks[9, 9, 5].type = BlockType.Air;
                    blocks[5, 9, 6].type = BlockType.Air;
                    blocks[7, 9, 6].type = BlockType.Air;
                    blocks[5, 9, 7].type = BlockType.Air;
                    blocks[7, 9, 7].type = BlockType.Air;
                    blocks[9, 9, 7].type = BlockType.Air;
                    blocks[5, 9, 8].type = BlockType.Air;
                    blocks[7, 9, 8].type = BlockType.Air;
                    blocks[9, 9, 8].type = BlockType.Air;
                    blocks[5, 9, 9].type = BlockType.Air;
                    blocks[7, 9, 9].type = BlockType.Air;
                    blocks[9, 9, 9].type = BlockType.Lock; blocks[9, 9, 9].index = 5;
                    blocks[9, 9, 10].type = BlockType.Air;
                    blocks[5, 9, 11].type = BlockType.Air;
                    blocks[7, 9, 11].type = BlockType.Air;
                    blocks[9, 9, 11].type = BlockType.Air;
                    blocks[5, 9, 12].type = BlockType.Air;
                    blocks[9, 9, 12].type = BlockType.Air;
                    blocks[5, 9, 13].type = BlockType.Air;
                    blocks[5, 10, 1].type = BlockType.Air;
                    blocks[7, 10, 1].type = BlockType.Air;
                    blocks[7, 10, 3].type = BlockType.Air;
                    blocks[9, 10, 3].type = BlockType.Air;
                    blocks[9, 10, 4].type = BlockType.Air;
                    blocks[5, 10, 5].type = BlockType.Air;
                    blocks[9, 10, 5].type = BlockType.Air;
                    blocks[5, 10, 7].type = BlockType.Air;
                    blocks[7, 10, 7].type = BlockType.Air;
                    blocks[7, 10, 11].type = BlockType.Air;
                    blocks[5, 10, 12].type = BlockType.Air;
                    blocks[7, 10, 12].type = BlockType.Air;
                    blocks[9, 10, 12].type = BlockType.Air;
                    blocks[7, 10, 13].type = BlockType.Air;
                    blocks[9, 10, 13].type = BlockType.Air;
                    blocks[5, 11, 1].type = BlockType.Air;
                    blocks[7, 11, 1].type = BlockType.Air;
                    blocks[9, 11, 1].type = BlockType.Air;
                    blocks[5, 11, 2].type = BlockType.Air;
                    blocks[9, 11, 2].type = BlockType.Air;
                    blocks[7, 11, 3].type = BlockType.Air;
                    blocks[9, 11, 3].type = BlockType.Air;
                    blocks[5, 11, 4].type = BlockType.Air;
                    blocks[7, 11, 4].type = BlockType.Air;
                    blocks[5, 11, 5].type = BlockType.Air;
                    blocks[7, 11, 5].type = BlockType.Air;
                    blocks[9, 11, 5].type = BlockType.Air;
                    blocks[9, 11, 6].type = BlockType.Air;
                    blocks[5, 11, 7].type = BlockType.Air;
                    blocks[9, 11, 7].type = BlockType.Air;
                    blocks[5, 11, 8].type = BlockType.Air;
                    blocks[9, 11, 8].type = BlockType.Air;
                    blocks[5, 11, 9].type = BlockType.Air;
                    blocks[7, 11, 9].type = BlockType.Air;
                    blocks[9, 11, 9].type = BlockType.Air;
                    blocks[7, 11, 10].type = BlockType.Air;
                    blocks[9, 11, 10].type = BlockType.Air;
                    blocks[5, 11, 11].type = BlockType.Air;
                    blocks[7, 11, 11].type = BlockType.Air;
                    blocks[5, 11, 12].type = BlockType.Air;
                    blocks[5, 11, 13].type = BlockType.Air;
                    blocks[7, 11, 13].type = BlockType.Air;
                    blocks[9, 11, 13].type = BlockType.Air;
                    blocks[7, 12, 1].type = BlockType.Air;
                    blocks[9, 12, 1].type = BlockType.Air;
                    blocks[5, 12, 2].type = BlockType.Air;
                    blocks[5, 12, 4].type = BlockType.Air;
                    blocks[7, 12, 5].type = BlockType.Air;
                    blocks[9, 12, 5].type = BlockType.Air;
                    blocks[7, 12, 6].type = BlockType.Air;
                    blocks[7, 12, 7].type = BlockType.Lock; blocks[7, 12, 7].index = 3;
                    blocks[7, 12, 8].type = BlockType.Air;
                    blocks[5, 12, 9].type = BlockType.Air;
                    blocks[7, 12, 9].type = BlockType.Air;
                    blocks[9, 12, 10].type = BlockType.Air;
                    blocks[7, 12, 11].type = BlockType.Air;
                    blocks[9, 12, 11].type = BlockType.Air;
                    blocks[5, 12, 12].type = BlockType.Air;
                    blocks[9, 12, 12].type = BlockType.Air;
                    blocks[7, 12, 13].type = BlockType.Air;
                    blocks[9, 12, 13].type = BlockType.Air;
                    blocks[5, 13, 1].type = BlockType.Air;
                    blocks[7, 13, 1].type = BlockType.Air;
                    blocks[9, 13, 1].type = BlockType.Air;
                    blocks[5, 13, 2].type = BlockType.Air;
                    blocks[7, 13, 2].type = BlockType.Air;
                    blocks[9, 13, 2].type = BlockType.Air;
                    blocks[7, 13, 3].type = BlockType.Air;
                    blocks[5, 13, 4].type = BlockType.Air;
                    blocks[7, 13, 4].type = BlockType.Air;
                    blocks[9, 13, 4].type = BlockType.Air;
                    blocks[5, 13, 5].type = BlockType.Air;
                    blocks[7, 13, 5].type = BlockType.Air;
                    blocks[9, 13, 5].type = BlockType.Air;
                    blocks[5, 13, 6].type = BlockType.Air;
                    blocks[9, 13, 6].type = BlockType.Air;
                    blocks[5, 13, 7].type = BlockType.Air;
                    blocks[9, 13, 7].type = BlockType.Key; blocks[9, 13, 7].index = 4;
                    blocks[5, 13, 8].type = BlockType.Air;
                    blocks[9, 13, 8].type = BlockType.Air;
                    blocks[5, 13, 9].type = BlockType.Air;
                    blocks[7, 13, 9].type = BlockType.Air;
                    blocks[9, 13, 9].type = BlockType.Air;
                    blocks[7, 13, 10].type = BlockType.Air;
                    blocks[9, 13, 10].type = BlockType.Air;
                    blocks[5, 13, 11].type = BlockType.Air;
                    blocks[7, 13, 11].type = BlockType.Air;
                    blocks[5, 13, 12].type = BlockType.Air;
                    blocks[5, 13, 13].type = BlockType.Air;
                    blocks[6, 13, 13].type = BlockType.Air;
                    blocks[7, 13, 13].type = BlockType.Air;
                    blocks[9, 13, 13].type = BlockType.Air;
                }
                break;
            case 31:
                {
                    blocks[1, 1, 1].type = BlockType.Start;
                    blocks[1, 1, 2].type = BlockType.Air;
                    blocks[1, 1, 3].type = BlockType.Air;
                    blocks[2, 1, 3].type = BlockType.Air;
                    blocks[3, 1, 3].type = BlockType.Dye; blocks[3, 1, 3].index = 1;
                    blocks[11, 1, 3].type = BlockType.Dye; blocks[11, 1, 3].index = 1;
                    blocks[1, 1, 4].type = BlockType.Air;
                    blocks[11, 1, 4].type = BlockType.Air;
                    blocks[1, 1, 5].type = BlockType.Tunnel; blocks[1, 1, 5].index = 1; blocks[1, 1, 5].dir = false; blocks[1, 1, 5].index2 = 1;
                    blocks[9, 1, 5].type = BlockType.Dye; blocks[9, 1, 5].index = 3;
                    blocks[11, 1, 5].type = BlockType.Air;
                    blocks[1, 1, 6].type = BlockType.Air;
                    blocks[9, 1, 6].type = BlockType.Air;
                    blocks[11, 1, 6].type = BlockType.Air;
                    blocks[1, 1, 7].type = BlockType.Air;
                    blocks[2, 1, 7].type = BlockType.Air;
                    blocks[3, 1, 7].type = BlockType.Dye; blocks[3, 1, 7].index = 3;
                    blocks[4, 1, 7].type = BlockType.Air;
                    blocks[5, 1, 7].type = BlockType.Dye; blocks[5, 1, 7].index = 2;
                    blocks[6, 1, 7].type = BlockType.Air;
                    blocks[7, 1, 7].type = BlockType.Dye; blocks[7, 1, 7].index = 1;
                    blocks[8, 1, 7].type = BlockType.Air;
                    blocks[9, 1, 7].type = BlockType.Air;
                    blocks[10, 1, 7].type = BlockType.Air;
                    blocks[11, 1, 7].type = BlockType.Air;
                    blocks[12, 1, 7].type = BlockType.Tunnel; blocks[12, 1, 7].index = 2; blocks[12, 1, 7].dir = true; blocks[12, 1, 7].index2 = 2;
                    blocks[13, 1, 7].type = BlockType.Air;
                    blocks[10, 1, 8].type = BlockType.Air;
                    blocks[13, 1, 8].type = BlockType.Air;
                    blocks[10, 1, 9].type = BlockType.Air;
                    blocks[13, 1, 9].type = BlockType.Air;
                    blocks[10, 1, 10].type = BlockType.Dye; blocks[10, 1, 10].index = 2;
                    blocks[13, 1, 10].type = BlockType.Air;
                    blocks[13, 1, 11].type = BlockType.Air;
                    blocks[13, 1, 12].type = BlockType.Air;
                    blocks[13, 1, 13].type = BlockType.Exit;
                }
                break;
            case 32:
                {
                    blocks[1, 1, 7].type = BlockType.Start;
                    blocks[2, 1, 7].type = BlockType.Air;
                    blocks[3, 1, 7].type = BlockType.Air;
                    blocks[4, 1, 7].type = BlockType.Air;
                    blocks[8, 1, 7].type = BlockType.Air;
                    blocks[9, 1, 7].type = BlockType.Air;
                    blocks[10, 1, 7].type = BlockType.Air;
                    blocks[11, 1, 7].type = BlockType.Tunnel; blocks[11, 1, 7].index = 3; blocks[11, 1, 7].dir = true; blocks[11, 1, 7].index2 = 3;
                    blocks[12, 1, 7].type = BlockType.Air;
                    blocks[13, 1, 7].type = BlockType.Exit;
                    blocks[4, 2, 5].type = BlockType.Air;
                    blocks[5, 2, 5].type = BlockType.Air;
                    blocks[6, 2, 5].type = BlockType.Dye; blocks[6, 2, 5].index = 1;
                    blocks[7, 2, 5].type = BlockType.Air;
                    blocks[8, 2, 5].type = BlockType.Air;
                    blocks[4, 2, 6].type = BlockType.Air;
                    blocks[8, 2, 6].type = BlockType.Air;
                    blocks[4, 2, 7].type = BlockType.Air;
                    blocks[5, 2, 7].type = BlockType.Air;
                    blocks[6, 2, 7].type = BlockType.Bonus;
                    blocks[7, 2, 7].type = BlockType.Air;
                    blocks[8, 2, 7].type = BlockType.Air;
                    blocks[4, 2, 8].type = BlockType.Air;
                    blocks[8, 2, 8].type = BlockType.Air;
                    blocks[4, 2, 9].type = BlockType.Air;
                    blocks[5, 2, 9].type = BlockType.Air;
                    blocks[6, 2, 9].type = BlockType.Dye; blocks[6, 2, 9].index = 3;
                    blocks[7, 2, 9].type = BlockType.Air;
                    blocks[8, 2, 9].type = BlockType.Air;
                }
                break;
            case 33:
                {
                    blocks[10, 1, 7].type = BlockType.Air;
                    blocks[10, 1, 8].type = BlockType.Air;
                    blocks[10, 1, 9].type = BlockType.Dye; blocks[10, 1, 9].index = 2;
                    blocks[10, 1, 10].type = BlockType.Air;
                    blocks[10, 1, 11].type = BlockType.Lock; blocks[10, 1, 11].index = 4;
                    blocks[10, 1, 12].type = BlockType.Air;
                    blocks[10, 1, 13].type = BlockType.Exit;
                    blocks[1, 2, 1].type = BlockType.Start;
                    blocks[2, 2, 1].type = BlockType.Air;
                    blocks[3, 2, 1].type = BlockType.Lock; blocks[3, 2, 1].index = 3;
                    blocks[4, 2, 1].type = BlockType.Air;
                    blocks[5, 2, 1].type = BlockType.Air;
                    blocks[6, 2, 1].type = BlockType.Dye; blocks[6, 2, 1].index = 2;
                    blocks[1, 2, 2].type = BlockType.Air;
                    blocks[6, 2, 2].type = BlockType.Air;
                    blocks[1, 2, 3].type = BlockType.Air;
                    blocks[2, 2, 3].type = BlockType.Air;
                    blocks[3, 2, 3].type = BlockType.Air;
                    blocks[6, 2, 3].type = BlockType.Air;
                    blocks[7, 2, 3].type = BlockType.Air;
                    blocks[8, 2, 3].type = BlockType.Tunnel; blocks[8, 2, 3].index = 2; blocks[8, 2, 3].dir = true; blocks[8, 2, 3].index2 = 3;
                    blocks[9, 2, 3].type = BlockType.Air;
                    blocks[10, 2, 3].type = BlockType.Air;
                    blocks[3, 2, 4].type = BlockType.Air;
                    blocks[6, 2, 4].type = BlockType.Air;
                    blocks[10, 2, 4].type = BlockType.Air;
                    blocks[2, 2, 5].type = BlockType.Air;
                    blocks[3, 2, 5].type = BlockType.Air;
                    blocks[6, 2, 5].type = BlockType.Tunnel; blocks[6, 2, 5].index = 3; blocks[6, 2, 5].dir = false; blocks[6, 2, 5].index2 = 1;
                    blocks[10, 2, 5].type = BlockType.Tunnel; blocks[10, 2, 5].index = 3; blocks[10, 2, 5].dir = false; blocks[10, 2, 5].index2 = 1;
                    blocks[2, 2, 6].type = BlockType.Air;
                    blocks[6, 2, 6].type = BlockType.Key; blocks[6, 2, 6].index = 4;
                    blocks[10, 2, 6].type = BlockType.Air;
                    blocks[2, 2, 7].type = BlockType.Key; blocks[2, 2, 7].index = 3;
                    blocks[6, 2, 7].type = BlockType.Air;
                    blocks[7, 2, 7].type = BlockType.Air;
                    blocks[8, 2, 7].type = BlockType.Tunnel; blocks[8, 2, 7].index = 3; blocks[8, 2, 7].dir = true; blocks[8, 2, 7].index2 = 2;
                    blocks[9, 2, 7].type = BlockType.Air;
                    blocks[10, 2, 7].type = BlockType.Air;
                    blocks[4, 3, 2].type = BlockType.Bonus;
                    blocks[4, 3, 3].type = BlockType.Bonus;
                    blocks[5, 3, 3].type = BlockType.Air;
                    blocks[6, 3, 3].type = BlockType.Air;
                    blocks[10, 3, 3].type = BlockType.Air;
                    blocks[11, 3, 3].type = BlockType.Air;
                    blocks[12, 3, 3].type = BlockType.Dye; blocks[12, 3, 3].index = 3;
                    blocks[4, 3, 4].type = BlockType.Bonus;
                    blocks[4, 3, 7].type = BlockType.Dye; blocks[4, 3, 7].index = 1;
                    blocks[5, 3, 7].type = BlockType.Air;
                    blocks[6, 3, 7].type = BlockType.Air;
                }
                break;
            case 34:
                {
                    blocks[2, 1, 2].type = BlockType.Air;
                    blocks[3, 1, 2].type = BlockType.Air;
                    blocks[4, 1, 2].type = BlockType.Air;
                    blocks[5, 1, 2].type = BlockType.Air;
                    blocks[6, 1, 2].type = BlockType.Air;
                    blocks[7, 1, 2].type = BlockType.Lock; blocks[7, 1, 2].index = 3;
                    blocks[8, 1, 2].type = BlockType.Air;
                    blocks[9, 1, 2].type = BlockType.Air;
                    blocks[10, 1, 2].type = BlockType.Air;
                    blocks[11, 1, 2].type = BlockType.Air;
                    blocks[12, 1, 2].type = BlockType.Air;
                    blocks[12, 1, 5].type = BlockType.Dye; blocks[12, 1, 5].index = 2;
                    blocks[12, 1, 6].type = BlockType.Air;
                    blocks[1, 1, 7].type = BlockType.Key; blocks[1, 1, 7].index = 3;
                    blocks[2, 1, 7].type = BlockType.Air;
                    blocks[3, 1, 7].type = BlockType.Tunnel; blocks[3, 1, 7].index = 1; blocks[3, 1, 7].dir = true; blocks[3, 1, 7].index2 = 1;
                    blocks[4, 1, 7].type = BlockType.Air;
                    blocks[5, 1, 7].type = BlockType.Air;
                    blocks[9, 1, 7].type = BlockType.Air;
                    blocks[10, 1, 7].type = BlockType.Air;
                    blocks[11, 1, 7].type = BlockType.Tunnel; blocks[11, 1, 7].index = 3; blocks[11, 1, 7].dir = true; blocks[11, 1, 7].index2 = 2;
                    blocks[12, 1, 7].type = BlockType.Air;
                    blocks[12, 1, 8].type = BlockType.Air;
                    blocks[12, 1, 9].type = BlockType.Lock; blocks[12, 1, 9].index = 1;
                    blocks[12, 1, 10].type = BlockType.Air;
                    blocks[4, 1, 11].type = BlockType.Dye; blocks[4, 1, 11].index = 3;
                    blocks[12, 1, 11].type = BlockType.Air;
                    blocks[2, 1, 12].type = BlockType.Air;
                    blocks[3, 1, 12].type = BlockType.Air;
                    blocks[4, 1, 12].type = BlockType.Air;
                    blocks[5, 1, 12].type = BlockType.Air;
                    blocks[6, 1, 12].type = BlockType.Air;
                    blocks[12, 1, 12].type = BlockType.Air;
                    blocks[4, 1, 13].type = BlockType.Dye; blocks[4, 1, 13].index = 4;
                    blocks[2, 2, 2].type = BlockType.Air;
                    blocks[12, 2, 2].type = BlockType.Air;
                    blocks[7, 2, 3].type = BlockType.Air;
                    blocks[7, 2, 4].type = BlockType.Air;
                    blocks[7, 2, 5].type = BlockType.Air;
                    blocks[5, 2, 7].type = BlockType.Air;
                    blocks[9, 2, 7].type = BlockType.Air;
                    blocks[7, 2, 9].type = BlockType.Air;
                    blocks[7, 2, 10].type = BlockType.Air;
                    blocks[7, 2, 11].type = BlockType.Air;
                    blocks[2, 2, 12].type = BlockType.Air;
                    blocks[6, 2, 12].type = BlockType.Air;
                    blocks[12, 2, 12].type = BlockType.Air;
                    blocks[1, 3, 1].type = BlockType.Bonus;
                    blocks[2, 3, 1].type = BlockType.Bonus;
                    blocks[1, 3, 2].type = BlockType.Bonus;
                    blocks[2, 3, 2].type = BlockType.Air;
                    blocks[5, 3, 2].type = BlockType.Air;
                    blocks[6, 3, 2].type = BlockType.Air;
                    blocks[7, 3, 2].type = BlockType.Tunnel; blocks[7, 3, 2].index = 3; blocks[7, 3, 2].dir = true; blocks[7, 3, 2].index2 = 4;
                    blocks[8, 3, 2].type = BlockType.Air;
                    blocks[9, 3, 2].type = BlockType.Air;
                    blocks[12, 3, 2].type = BlockType.Air;
                    blocks[2, 3, 5].type = BlockType.Air;
                    blocks[5, 3, 5].type = BlockType.Air;
                    blocks[6, 3, 5].type = BlockType.Air;
                    blocks[7, 3, 5].type = BlockType.Air;
                    blocks[8, 3, 5].type = BlockType.Air;
                    blocks[9, 3, 5].type = BlockType.Air;
                    blocks[12, 3, 5].type = BlockType.Air;
                    blocks[2, 3, 6].type = BlockType.Air;
                    blocks[5, 3, 6].type = BlockType.Air;
                    blocks[6, 3, 6].type = BlockType.Dye; blocks[6, 3, 6].index = 2;
                    blocks[7, 3, 6].type = BlockType.Air;
                    blocks[8, 3, 6].type = BlockType.Dye; blocks[8, 3, 6].index = 1;
                    blocks[9, 3, 6].type = BlockType.Air;
                    blocks[12, 3, 6].type = BlockType.Air;
                    blocks[2, 3, 7].type = BlockType.Key; blocks[2, 3, 7].index = 1;
                    blocks[5, 3, 7].type = BlockType.Air;
                    blocks[6, 3, 7].type = BlockType.Air;
                    blocks[7, 3, 7].type = BlockType.Start;
                    blocks[8, 3, 7].type = BlockType.Air;
                    blocks[9, 3, 7].type = BlockType.Air;
                    blocks[12, 3, 7].type = BlockType.Key; blocks[12, 3, 7].index = 2;
                    blocks[2, 3, 8].type = BlockType.Air;
                    blocks[5, 3, 8].type = BlockType.Air;
                    blocks[6, 3, 8].type = BlockType.Dye; blocks[6, 3, 8].index = 4;
                    blocks[7, 3, 8].type = BlockType.Air;
                    blocks[8, 3, 8].type = BlockType.Dye; blocks[8, 3, 8].index = 3;
                    blocks[9, 3, 8].type = BlockType.Air;
                    blocks[12, 3, 8].type = BlockType.Air;
                    blocks[2, 3, 9].type = BlockType.Air;
                    blocks[5, 3, 9].type = BlockType.Air;
                    blocks[6, 3, 9].type = BlockType.Air;
                    blocks[7, 3, 9].type = BlockType.Air;
                    blocks[8, 3, 9].type = BlockType.Air;
                    blocks[9, 3, 9].type = BlockType.Air;
                    blocks[12, 3, 9].type = BlockType.Air;
                    blocks[2, 3, 12].type = BlockType.Air;
                    blocks[5, 3, 12].type = BlockType.Air;
                    blocks[6, 3, 12].type = BlockType.Air;
                    blocks[7, 3, 12].type = BlockType.Tunnel; blocks[7, 3, 12].index = 4; blocks[7, 3, 12].dir = true; blocks[7, 3, 12].index2 = 2;
                    blocks[8, 3, 12].type = BlockType.Air;
                    blocks[9, 3, 12].type = BlockType.Air;
                    blocks[12, 3, 12].type = BlockType.Air;
                    blocks[13, 3, 12].type = BlockType.Air;
                    blocks[12, 3, 13].type = BlockType.Air;
                    blocks[13, 3, 13].type = BlockType.Exit;
                    blocks[5, 4, 2].type = BlockType.Air;
                    blocks[9, 4, 2].type = BlockType.Air;
                    blocks[10, 4, 2].type = BlockType.Air;
                    blocks[11, 4, 2].type = BlockType.Air;
                    blocks[12, 4, 2].type = BlockType.Air;
                    blocks[5, 4, 3].type = BlockType.Air;
                    blocks[12, 4, 3].type = BlockType.Air;
                    blocks[2, 4, 4].type = BlockType.Air;
                    blocks[3, 4, 4].type = BlockType.Lock; blocks[3, 4, 4].index = 2;
                    blocks[4, 4, 4].type = BlockType.Air;
                    blocks[5, 4, 4].type = BlockType.Air;
                    blocks[12, 4, 4].type = BlockType.Air;
                    blocks[2, 4, 5].type = BlockType.Air;
                    blocks[5, 4, 5].type = BlockType.Air;
                    blocks[9, 4, 5].type = BlockType.Air;
                    blocks[12, 4, 5].type = BlockType.Air;
                    blocks[2, 4, 9].type = BlockType.Air;
                    blocks[5, 4, 9].type = BlockType.Air;
                    blocks[9, 4, 9].type = BlockType.Air;
                    blocks[12, 4, 9].type = BlockType.Air;
                    blocks[2, 4, 10].type = BlockType.Air;
                    blocks[3, 4, 10].type = BlockType.Lock; blocks[3, 4, 10].index = 2;
                    blocks[4, 4, 10].type = BlockType.Air;
                    blocks[5, 4, 10].type = BlockType.Air;
                    blocks[9, 4, 10].type = BlockType.Air;
                    blocks[9, 4, 11].type = BlockType.Air;
                    blocks[2, 4, 12].type = BlockType.Air;
                    blocks[3, 4, 12].type = BlockType.Air;
                    blocks[4, 4, 12].type = BlockType.Air;
                    blocks[5, 4, 12].type = BlockType.Air;
                    blocks[9, 4, 12].type = BlockType.Air;
                    blocks[9, 5, 5].type = BlockType.Air;
                    blocks[12, 5, 9].type = BlockType.Air;
                    for (int x = 9; x <= 12; x++) { blocks[x, 6, 5].type = BlockType.Air; }
                    blocks[12, 6, 6].type = BlockType.Air;
                    blocks[12, 6, 7].type = BlockType.Tunnel; blocks[12, 6, 7].index = 4; blocks[12, 6, 7].dir = false; blocks[12, 6, 7].index2 = 3;
                    blocks[12, 6, 8].type = BlockType.Air;
                    blocks[12, 6, 9].type = BlockType.Air;
                }
                break;
            case 35:
                {
                    blocks[1, 1, 1].type = BlockType.Start;
                    blocks[2, 1, 1].type = BlockType.Air;
                    blocks[3, 1, 1].type = BlockType.Air;
                    blocks[4, 1, 1].type = BlockType.Air;
                    blocks[6, 1, 1].type = BlockType.Air;
                    blocks[8, 1, 1].type = BlockType.Air;
                    blocks[9, 1, 1].type = BlockType.Air;
                    blocks[11, 1, 1].type = BlockType.Air;
                    blocks[12, 1, 1].type = BlockType.Air;
                    blocks[13, 1, 1].type = BlockType.Air;
                    blocks[1, 1, 2].type = BlockType.Air;
                    blocks[4, 1, 2].type = BlockType.Air;
                    blocks[5, 1, 2].type = BlockType.Air;
                    blocks[6, 1, 2].type = BlockType.Air;
                    blocks[8, 1, 2].type = BlockType.Air;
                    blocks[11, 1, 2].type = BlockType.Air;
                    blocks[13, 1, 2].type = BlockType.Air;
                    blocks[1, 1, 3].type = BlockType.Air;
                    blocks[2, 1, 3].type = BlockType.Air;
                    blocks[8, 1, 3].type = BlockType.Air;
                    blocks[9, 1, 3].type = BlockType.Air;
                    blocks[10, 1, 3].type = BlockType.Tunnel; blocks[10, 1, 3].index = 1; blocks[10, 1, 3].dir = true; blocks[10, 1, 3].index2 = 3;
                    blocks[11, 1, 3].type = BlockType.Air;
                    for (int x = 2; x <= 6; x++) { blocks[x, 1, 4].type = BlockType.Air; }
                    blocks[9, 1, 4].type = BlockType.Air;
                    blocks[11, 1, 4].type = BlockType.Air;
                    blocks[12, 1, 4].type = BlockType.Air;
                    blocks[13, 1, 4].type = BlockType.Air;
                    blocks[1, 1, 5].type = BlockType.Air;
                    blocks[2, 1, 5].type = BlockType.Air;
                    blocks[4, 1, 5].type = BlockType.Air;
                    blocks[6, 1, 5].type = BlockType.Air;
                    blocks[7, 1, 5].type = BlockType.Lock; blocks[7, 1, 5].index = 3;
                    blocks[8, 1, 5].type = BlockType.Air;
                    blocks[9, 1, 5].type = BlockType.Air;
                    blocks[13, 1, 5].type = BlockType.Lock; blocks[13, 1, 5].index = 4;
                    blocks[1, 1, 6].type = BlockType.Air;
                    blocks[4, 1, 6].type = BlockType.Air;
                    blocks[8, 1, 6].type = BlockType.Air;
                    blocks[11, 1, 6].type = BlockType.Air;
                    blocks[12, 1, 6].type = BlockType.Air;
                    blocks[13, 1, 6].type = BlockType.Air;
                    blocks[1, 1, 7].type = BlockType.Air;
                    for (int x = 3; x <= 6; x++) { blocks[x, 1, 7].type = BlockType.Air; }
                    blocks[10, 1, 7].type = BlockType.Air;
                    blocks[11, 1, 7].type = BlockType.Air;
                    blocks[13, 1, 7].type = BlockType.Air;
                    blocks[3, 1, 8].type = BlockType.Air;
                    blocks[6, 1, 8].type = BlockType.Air;
                    blocks[7, 1, 8].type = BlockType.Air;
                    blocks[9, 1, 8].type = BlockType.Air;
                    blocks[10, 1, 8].type = BlockType.Air;
                    blocks[13, 1, 8].type = BlockType.Air;
                    for (int x = 1; x <= 4; x++) { blocks[x, 1, 9].type = BlockType.Air; }
                    blocks[7, 1, 9].type = BlockType.Air;
                    blocks[9, 1, 9].type = BlockType.Air;
                    blocks[12, 1, 9].type = BlockType.Air;
                    blocks[13, 1, 9].type = BlockType.Air;
                    blocks[1, 1, 10].type = BlockType.Air;
                    blocks[4, 1, 10].type = BlockType.Air;
                    blocks[5, 1, 10].type = BlockType.Air;
                    blocks[7, 1, 10].type = BlockType.Air;
                    blocks[9, 1, 10].type = BlockType.Air;
                    blocks[10, 1, 10].type = BlockType.Air;
                    blocks[13, 1, 10].type = BlockType.Air;
                    blocks[1, 1, 11].type = BlockType.Air;
                    blocks[2, 1, 11].type = BlockType.Air;
                    blocks[7, 1, 11].type = BlockType.Tunnel; blocks[7, 1, 11].index = 2; blocks[7, 1, 11].dir = false; blocks[7, 1, 11].index2 = 4;
                    blocks[9, 1, 11].type = BlockType.Air;
                    blocks[2, 1, 12].type = BlockType.Air;
                    blocks[3, 1, 12].type = BlockType.Tunnel; blocks[3, 1, 12].index = 3; blocks[3, 1, 12].dir = true; blocks[3, 1, 12].index2 = 2;
                    blocks[4, 1, 12].type = BlockType.Air;
                    blocks[7, 1, 12].type = BlockType.Air;
                    blocks[11, 1, 12].type = BlockType.Air;
                    blocks[12, 1, 12].type = BlockType.Air;
                    blocks[13, 1, 12].type = BlockType.Air;
                    blocks[1, 1, 13].type = BlockType.Air;
                    blocks[2, 1, 13].type = BlockType.Air;
                    blocks[4, 1, 13].type = BlockType.Air;
                    blocks[5, 1, 13].type = BlockType.Air;
                    for (int x = 7; x <= 11; x++) { blocks[x, 1, 13].type = BlockType.Air; }
                    blocks[13, 1, 13].type = BlockType.Air;
                    blocks[6, 2, 1].type = BlockType.Air;
                    blocks[9, 2, 1].type = BlockType.Air;
                    blocks[13, 2, 2].type = BlockType.Air;
                    blocks[8, 2, 6].type = BlockType.Air;
                    blocks[1, 2, 7].type = BlockType.Air;
                    blocks[12, 2, 9].type = BlockType.Air;
                    blocks[5, 2, 10].type = BlockType.Air;
                    blocks[10, 2, 10].type = BlockType.Air;
                    blocks[13, 2, 10].type = BlockType.Air;
                    blocks[9, 2, 11].type = BlockType.Air;
                    blocks[1, 2, 13].type = BlockType.Air;
                    blocks[5, 2, 13].type = BlockType.Air;
                    blocks[13, 2, 13].type = BlockType.Air;
                    blocks[4, 3, 1].type = BlockType.Dye; blocks[4, 3, 1].index = 1;
                    blocks[5, 3, 1].type = BlockType.Air;
                    blocks[6, 3, 1].type = BlockType.Air;
                    blocks[9, 3, 1].type = BlockType.Air;
                    blocks[11, 3, 2].type = BlockType.Dye; blocks[11, 3, 2].index = 5;
                    blocks[12, 3, 2].type = BlockType.Air;
                    blocks[13, 3, 2].type = BlockType.Air;
                    blocks[12, 3, 3].type = BlockType.Dye; blocks[12, 3, 3].index = 3;
                    blocks[1, 3, 5].type = BlockType.Bonus;
                    blocks[10, 3, 5].type = BlockType.Air;
                    blocks[11, 3, 5].type = BlockType.Air;
                    blocks[12, 3, 5].type = BlockType.Air;
                    blocks[1, 3, 6].type = BlockType.Air;
                    blocks[8, 3, 6].type = BlockType.Air;
                    blocks[10, 3, 6].type = BlockType.Air;
                    blocks[11, 3, 6].type = BlockType.Dye; blocks[11, 3, 6].index = 3;
                    blocks[12, 3, 6].type = BlockType.Air;
                    blocks[1, 3, 7].type = BlockType.Air;
                    blocks[10, 3, 7].type = BlockType.Air;
                    blocks[11, 3, 7].type = BlockType.Air;
                    blocks[12, 3, 7].type = BlockType.Air;
                    blocks[11, 3, 8].type = BlockType.Air;
                    blocks[10, 3, 9].type = BlockType.Air;
                    blocks[11, 3, 9].type = BlockType.Air;
                    blocks[12, 3, 9].type = BlockType.Air;
                    blocks[1, 3, 10].type = BlockType.Dye; blocks[1, 3, 10].index = 3;
                    blocks[2, 3, 10].type = BlockType.Air;
                    blocks[3, 3, 10].type = BlockType.Tunnel; blocks[3, 3, 10].index = 3; blocks[3, 3, 10].dir = true; blocks[3, 3, 10].index2 = 1;
                    blocks[4, 3, 10].type = BlockType.Air;
                    blocks[5, 3, 10].type = BlockType.Air;
                    blocks[10, 3, 10].type = BlockType.Air;
                    blocks[13, 3, 10].type = BlockType.Air;
                    blocks[7, 3, 11].type = BlockType.Key; blocks[7, 3, 11].index = 2;
                    blocks[9, 3, 11].type = BlockType.Air;
                    blocks[1, 3, 12].type = BlockType.Air;
                    blocks[2, 3, 12].type = BlockType.Lock; blocks[2, 3, 12].index = 2;
                    blocks[3, 3, 12].type = BlockType.Air;
                    blocks[5, 3, 12].type = BlockType.Air;
                    blocks[7, 3, 12].type = BlockType.Air;
                    blocks[1, 3, 13].type = BlockType.Air;
                    blocks[3, 3, 13].type = BlockType.Key; blocks[3, 3, 13].index = 4;
                    blocks[5, 3, 13].type = BlockType.Air;
                    blocks[7, 3, 13].type = BlockType.Air;
                    for (int x = 9; x <= 13; x++) { blocks[x, 3, 13].type = BlockType.Air; }
                    blocks[0, 4, 0].type = BlockType.Air;
                    blocks[1, 4, 0].type = BlockType.Air;
                    blocks[14, 4, 0].type = BlockType.Air;
                    blocks[0, 4, 1].type = BlockType.Air;
                    blocks[8, 4, 6].type = BlockType.Air;
                    blocks[10, 4, 7].type = BlockType.Air;
                    blocks[7, 4, 10].type = BlockType.Air;
                    blocks[13, 4, 10].type = BlockType.Air;
                    blocks[5, 4, 12].type = BlockType.Air;
                    blocks[6, 4, 12].type = BlockType.Air;
                    blocks[7, 4, 12].type = BlockType.Air;
                    blocks[9, 4, 12].type = BlockType.Air;
                    blocks[10, 4, 12].type = BlockType.Dye; blocks[10, 4, 12].index = 4;
                    blocks[11, 4, 12].type = BlockType.Lock; blocks[11, 4, 12].index = 1;
                    blocks[12, 4, 12].type = BlockType.Key; blocks[12, 4, 12].index = 5;
                    blocks[9, 4, 13].type = BlockType.Air;
                    for (int x = 0; x <= 14; x++) { blocks[x, 5, 0].type = BlockType.Air; }
                    blocks[0, 5, 1].type = BlockType.Air;
                    blocks[1, 5, 1].type = BlockType.Air;
                    blocks[2, 5, 1].type = BlockType.Air;
                    blocks[13, 5, 1].type = BlockType.Air;
                    blocks[14, 5, 1].type = BlockType.Air;
                    blocks[0, 5, 2].type = BlockType.Air;
                    blocks[1, 5, 2].type = BlockType.Air;
                    blocks[14, 5, 2].type = BlockType.Air;
                    blocks[0, 5, 3].type = BlockType.Air;
                    blocks[0, 5, 4].type = BlockType.Air;
                    blocks[8, 5, 6].type = BlockType.Air;
                    blocks[10, 5, 7].type = BlockType.Air;
                    blocks[3, 5, 10].type = BlockType.Key; blocks[3, 5, 10].index = 3;
                    blocks[4, 5, 10].type = BlockType.Air;
                    blocks[5, 5, 10].type = BlockType.Tunnel; blocks[5, 5, 10].index = 3; blocks[5, 5, 10].dir = true; blocks[5, 5, 10].index2 = 3;
                    blocks[6, 5, 10].type = BlockType.Air;
                    blocks[7, 5, 10].type = BlockType.Air;
                    for (int x = 9; x <= 13; x++) { blocks[x, 5, 10].type = BlockType.Air; }
                    blocks[7, 5, 11].type = BlockType.Air;
                    blocks[3, 5, 12].type = BlockType.Dye; blocks[3, 5, 12].index = 2;
                    blocks[4, 5, 12].type = BlockType.Air;
                    blocks[5, 5, 12].type = BlockType.Air;
                    blocks[7, 5, 12].type = BlockType.Air;
                    blocks[0, 5, 13].type = BlockType.Air;
                    blocks[14, 5, 13].type = BlockType.Air;
                    blocks[0, 5, 14].type = BlockType.Air;
                    blocks[1, 5, 14].type = BlockType.Air;
                    blocks[13, 5, 14].type = BlockType.Air;
                    blocks[14, 5, 14].type = BlockType.Air;
                    for (int x = 0; x <= 14; x++) { blocks[x, 6, 0].type = BlockType.Air; }
                    for (int x = 0; x <= 4; x++) { blocks[x, 6, 1].type = BlockType.Air; }
                    for (int x = 10; x <= 14; x++) { blocks[x, 6, 1].type = BlockType.Air; }
                    blocks[0, 6, 2].type = BlockType.Air;
                    blocks[1, 6, 2].type = BlockType.Air;
                    blocks[2, 6, 2].type = BlockType.Air;
                    blocks[12, 6, 2].type = BlockType.Air;
                    blocks[13, 6, 2].type = BlockType.Air;
                    blocks[14, 6, 2].type = BlockType.Air;
                    blocks[0, 6, 3].type = BlockType.Air;
                    blocks[1, 6, 3].type = BlockType.Air;
                    blocks[13, 6, 3].type = BlockType.Air;
                    blocks[14, 6, 3].type = BlockType.Air;
                    blocks[0, 6, 4].type = BlockType.Air;
                    blocks[1, 6, 4].type = BlockType.Air;
                    for (int x = 6; x <= 10; x++) { blocks[x, 6, 4].type = BlockType.Air; }
                    blocks[14, 6, 4].type = BlockType.Air;
                    blocks[0, 6, 5].type = BlockType.Air;
                    blocks[6, 6, 5].type = BlockType.Air;
                    blocks[10, 6, 5].type = BlockType.Air;
                    blocks[14, 6, 5].type = BlockType.Air;
                    blocks[0, 6, 6].type = BlockType.Air;
                    blocks[6, 6, 6].type = BlockType.Tunnel; blocks[6, 6, 6].index = 2; blocks[6, 6, 6].dir = false; blocks[6, 6, 6].index2 = 5;
                    blocks[8, 6, 6].type = BlockType.Air;
                    blocks[0, 6, 7].type = BlockType.Air;
                    blocks[6, 6, 7].type = BlockType.Air;
                    blocks[10, 6, 7].type = BlockType.Air;
                    for (int x = 6; x <= 10; x++) { blocks[x, 6, 8].type = BlockType.Air; }
                    blocks[9, 6, 10].type = BlockType.Air;
                    blocks[0, 6, 11].type = BlockType.Air;
                    blocks[0, 6, 12].type = BlockType.Air;
                    blocks[14, 6, 12].type = BlockType.Air;
                    blocks[0, 6, 13].type = BlockType.Air;
                    blocks[1, 6, 13].type = BlockType.Air;
                    blocks[13, 6, 13].type = BlockType.Air;
                    blocks[14, 6, 13].type = BlockType.Air;
                    blocks[0, 6, 14].type = BlockType.Air;
                    blocks[1, 6, 14].type = BlockType.Air;
                    blocks[2, 6, 14].type = BlockType.Air;
                    for (int x = 11; x <= 14; x++) { blocks[x, 6, 14].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 7, 0].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 7, 1].type = BlockType.Air; }
                    for (int x = 0; x <= 5; x++) { blocks[x, 7, 2].type = BlockType.Air; }
                    for (int x = 11; x <= 14; x++) { blocks[x, 7, 2].type = BlockType.Air; }
                    for (int x = 0; x <= 3; x++) { blocks[x, 7, 3].type = BlockType.Air; }
                    blocks[12, 7, 3].type = BlockType.Air;
                    blocks[13, 7, 3].type = BlockType.Air;
                    blocks[14, 7, 3].type = BlockType.Air;
                    blocks[0, 7, 4].type = BlockType.Air;
                    blocks[1, 7, 4].type = BlockType.Air;
                    blocks[2, 7, 4].type = BlockType.Air;
                    blocks[12, 7, 4].type = BlockType.Air;
                    blocks[13, 7, 4].type = BlockType.Air;
                    blocks[14, 7, 4].type = BlockType.Air;
                    blocks[0, 7, 5].type = BlockType.Air;
                    blocks[1, 7, 5].type = BlockType.Air;
                    blocks[10, 7, 5].type = BlockType.Air;
                    blocks[13, 7, 5].type = BlockType.Air;
                    blocks[14, 7, 5].type = BlockType.Air;
                    blocks[0, 7, 6].type = BlockType.Air;
                    blocks[1, 7, 6].type = BlockType.Air;
                    blocks[8, 7, 6].type = BlockType.Air;
                    blocks[13, 7, 6].type = BlockType.Air;
                    blocks[14, 7, 6].type = BlockType.Air;
                    blocks[0, 7, 7].type = BlockType.Air;
                    blocks[14, 7, 7].type = BlockType.Air;
                    blocks[0, 7, 8].type = BlockType.Air;
                    blocks[14, 7, 8].type = BlockType.Air;
                    blocks[0, 7, 9].type = BlockType.Air;
                    blocks[14, 7, 9].type = BlockType.Air;
                    blocks[0, 7, 10].type = BlockType.Air;
                    blocks[1, 7, 10].type = BlockType.Air;
                    blocks[9, 7, 10].type = BlockType.Air;
                    blocks[10, 7, 10].type = BlockType.Air;
                    blocks[11, 7, 10].type = BlockType.Key; blocks[11, 7, 10].index = 1;
                    blocks[14, 7, 10].type = BlockType.Air;
                    blocks[0, 7, 11].type = BlockType.Air;
                    blocks[1, 7, 11].type = BlockType.Air;
                    blocks[2, 7, 11].type = BlockType.Air;
                    blocks[13, 7, 11].type = BlockType.Air;
                    blocks[14, 7, 11].type = BlockType.Air;
                    for (int x = 0; x <= 4; x++) { blocks[x, 7, 12].type = BlockType.Air; }
                    blocks[12, 7, 12].type = BlockType.Air;
                    blocks[13, 7, 12].type = BlockType.Air;
                    blocks[14, 7, 12].type = BlockType.Air;
                    for (int x = 0; x <= 6; x++) { blocks[x, 7, 13].type = BlockType.Air; }
                    for (int x = 10; x <= 14; x++) { blocks[x, 7, 13].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 7, 14].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 8, 0].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 8, 1].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 8, 2].type = BlockType.Air; }
                    for (int x = 0; x <= 5; x++) { blocks[x, 8, 3].type = BlockType.Air; }
                    for (int x = 10; x <= 14; x++) { blocks[x, 8, 3].type = BlockType.Air; }
                    for (int x = 0; x <= 4; x++) { blocks[x, 8, 4].type = BlockType.Air; }
                    for (int x = 11; x <= 14; x++) { blocks[x, 8, 4].type = BlockType.Air; }
                    for (int x = 0; x <= 3; x++) { blocks[x, 8, 5].type = BlockType.Air; }
                    blocks[10, 8, 5].type = BlockType.Air;
                    blocks[12, 8, 5].type = BlockType.Air;
                    blocks[13, 8, 5].type = BlockType.Air;
                    blocks[14, 8, 5].type = BlockType.Air;
                    blocks[0, 8, 6].type = BlockType.Air;
                    blocks[1, 8, 6].type = BlockType.Air;
                    blocks[2, 8, 6].type = BlockType.Air;
                    blocks[8, 8, 6].type = BlockType.Air;
                    blocks[10, 8, 6].type = BlockType.Air;
                    blocks[13, 8, 6].type = BlockType.Air;
                    blocks[14, 8, 6].type = BlockType.Air;
                    blocks[0, 8, 7].type = BlockType.Air;
                    blocks[1, 8, 7].type = BlockType.Air;
                    blocks[2, 8, 7].type = BlockType.Air;
                    for (int x = 10; x <= 14; x++) { blocks[x, 8, 7].type = BlockType.Air; }
                    blocks[0, 8, 8].type = BlockType.Air;
                    blocks[1, 8, 8].type = BlockType.Air;
                    blocks[2, 8, 8].type = BlockType.Air;
                    blocks[13, 8, 8].type = BlockType.Air;
                    blocks[14, 8, 8].type = BlockType.Air;
                    for (int x = 0; x <= 3; x++) { blocks[x, 8, 9].type = BlockType.Air; }
                    blocks[13, 8, 9].type = BlockType.Air;
                    blocks[14, 8, 9].type = BlockType.Air;
                    for (int x = 0; x <= 4; x++) { blocks[x, 8, 10].type = BlockType.Air; }
                    blocks[12, 8, 10].type = BlockType.Air;
                    blocks[13, 8, 10].type = BlockType.Air;
                    blocks[14, 8, 10].type = BlockType.Air;
                    for (int x = 0; x <= 5; x++) { blocks[x, 8, 11].type = BlockType.Air; }
                    for (int x = 11; x <= 14; x++) { blocks[x, 8, 11].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 8, 12].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 8, 13].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 8, 14].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 9, 0].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 9, 1].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 9, 2].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 9, 3].type = BlockType.Air; }
                    for (int x = 0; x <= 6; x++) { blocks[x, 9, 4].type = BlockType.Air; }
                    for (int x = 10; x <= 14; x++) { blocks[x, 9, 4].type = BlockType.Air; }
                    for (int x = 0; x <= 5; x++) { blocks[x, 9, 5].type = BlockType.Air; }
                    for (int x = 11; x <= 14; x++) { blocks[x, 9, 5].type = BlockType.Air; }
                    for (int x = 0; x <= 4; x++) { blocks[x, 9, 6].type = BlockType.Air; }
                    blocks[8, 9, 6].type = BlockType.Air;
                    for (int x = 11; x <= 14; x++) { blocks[x, 9, 6].type = BlockType.Air; }
                    for (int x = 0; x <= 4; x++) { blocks[x, 9, 7].type = BlockType.Air; }
                    blocks[8, 9, 7].type = BlockType.Lock; blocks[8, 9, 7].index = 5;
                    blocks[12, 9, 7].type = BlockType.Air;
                    blocks[13, 9, 7].type = BlockType.Air;
                    blocks[14, 9, 7].type = BlockType.Air;
                    for (int x = 0; x <= 5; x++) { blocks[x, 9, 8].type = BlockType.Air; }
                    blocks[8, 9, 8].type = BlockType.Exit;
                    blocks[12, 9, 8].type = BlockType.Air;
                    blocks[13, 9, 8].type = BlockType.Air;
                    blocks[14, 9, 8].type = BlockType.Air;
                    for (int x = 0; x <= 6; x++) { blocks[x, 9, 9].type = BlockType.Air; }
                    for (int x = 11; x <= 14; x++) { blocks[x, 9, 9].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 9, 10].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 9, 11].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 9, 12].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 9, 13].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 9, 14].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 10, 0].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 10, 1].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 10, 2].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 10, 3].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 10, 4].type = BlockType.Air; }
                    for (int x = 0; x <= 5; x++) { blocks[x, 10, 5].type = BlockType.Air; }
                    for (int x = 9; x <= 14; x++) { blocks[x, 10, 5].type = BlockType.Air; }
                    for (int x = 0; x <= 4; x++) { blocks[x, 10, 6].type = BlockType.Air; }
                    for (int x = 10; x <= 14; x++) { blocks[x, 10, 6].type = BlockType.Air; }
                    for (int x = 0; x <= 4; x++) { blocks[x, 10, 7].type = BlockType.Air; }
                    for (int x = 10; x <= 14; x++) { blocks[x, 10, 7].type = BlockType.Air; }
                    for (int x = 0; x <= 5; x++) { blocks[x, 10, 8].type = BlockType.Air; }
                    for (int x = 10; x <= 14; x++) { blocks[x, 10, 8].type = BlockType.Air; }
                    for (int x = 0; x <= 6; x++) { blocks[x, 10, 9].type = BlockType.Air; }
                    for (int x = 11; x <= 14; x++) { blocks[x, 10, 9].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 10, 10].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 10, 11].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 10, 12].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 10, 13].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 10, 14].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 11, 0].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 11, 1].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 11, 2].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 11, 3].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 11, 4].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 11, 5].type = BlockType.Air; }
                    for (int x = 0; x <= 6; x++) { blocks[x, 11, 6].type = BlockType.Air; }
                    blocks[7, 11, 6].type = BlockType.Bonus;
                    blocks[9, 11, 6].type = BlockType.Bonus;
                    for (int x = 10; x <= 14; x++) { blocks[x, 11, 6].type = BlockType.Air; }
                    for (int x = 0; x <= 6; x++) { blocks[x, 11, 7].type = BlockType.Air; }
                    for (int x = 10; x <= 14; x++) { blocks[x, 11, 7].type = BlockType.Air; }
                    for (int x = 0; x <= 6; x++) { blocks[x, 11, 8].type = BlockType.Air; }
                    blocks[7, 11, 8].type = BlockType.Bonus;
                    blocks[9, 11, 8].type = BlockType.Bonus;
                    for (int x = 10; x <= 14; x++) { blocks[x, 11, 8].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 11, 9].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 11, 10].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 11, 11].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 11, 12].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 11, 13].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 11, 14].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 12, 0].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 12, 1].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 12, 2].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 12, 3].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 12, 4].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 12, 5].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 12, 6].type = BlockType.Air; }
                    for (int x = 0; x <= 7; x++) { blocks[x, 12, 7].type = BlockType.Air; }
                    blocks[8, 12, 7].type = BlockType.Dye; blocks[7, 12, 7].index = 2;
                    for (int x = 9; x <= 14; x++) { blocks[x, 12, 7].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 12, 8].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 12, 9].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 12, 10].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 12, 11].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 12, 12].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 12, 13].type = BlockType.Air; }
                    for (int x = 0; x <= 14; x++) { blocks[x, 11, 14].type = BlockType.Air; }

                }
                break;
            case 36:
                {
                    blocks[1, 1, 1].type = BlockType.Dye; blocks[1, 1, 1].index = 2;
                    blocks[2, 1, 1].type = BlockType.Air;
                    blocks[3, 1, 1].type = BlockType.Air;
                    blocks[4, 1, 1].type = BlockType.Tunnel; blocks[4, 1, 1].index = 2; blocks[4, 1, 1].dir = true; blocks[4, 1, 1].index2 = 3;
                    blocks[5, 1, 1].type = BlockType.Air;
                    blocks[6, 1, 1].type = BlockType.Tunnel; blocks[6, 1, 1].index = 2; blocks[6, 1, 1].dir = true; blocks[6, 1, 1].index2 = 3;
                    blocks[7, 1, 1].type = BlockType.Air;
                    blocks[8, 1, 1].type = BlockType.Tunnel; blocks[8, 1, 1].index = 2; blocks[8, 1, 1].dir = true; blocks[8, 1, 1].index2 = 3;
                    blocks[9, 1, 1].type = BlockType.Dye; blocks[9, 1, 1].index = 3;
                    blocks[10, 1, 1].type = BlockType.Tunnel; blocks[10, 1, 1].index = 2; blocks[10, 1, 1].dir = true; blocks[10, 1, 1].index2 = 5;
                    blocks[11, 1, 1].type = BlockType.Air;
                    blocks[12, 1, 1].type = BlockType.Air;
                    blocks[13, 1, 1].type = BlockType.Dye; blocks[13, 1, 1].index = 5;
                    blocks[1, 1, 2].type = BlockType.Air;
                    blocks[2, 1, 2].type = BlockType.Start;
                    blocks[3, 1, 2].type = BlockType.Air;
                    blocks[5, 1, 2].type = BlockType.Tunnel; blocks[5, 1, 2].index = 1; blocks[5, 1, 2].dir = false; blocks[5, 1, 2].index2 = 3;
                    blocks[7, 1, 2].type = BlockType.Tunnel; blocks[7, 1, 2].index = 3; blocks[7, 1, 2].dir = false; blocks[7, 1, 2].index2 = 3;
                    blocks[9, 1, 2].type = BlockType.Tunnel; blocks[9, 1, 2].index = 3; blocks[9, 1, 2].dir = false; blocks[9, 1, 2].index2 = 5;
                    blocks[11, 1, 2].type = BlockType.Air;
                    blocks[12, 1, 2].type = BlockType.Bonus;
                    blocks[13, 1, 2].type = BlockType.Air;
                    blocks[1, 1, 3].type = BlockType.Air;
                    blocks[2, 1, 3].type = BlockType.Air;
                    blocks[3, 1, 3].type = BlockType.Air;
                    blocks[4, 1, 3].type = BlockType.Tunnel; blocks[4, 1, 3].index = 2; blocks[4, 1, 3].dir = true; blocks[4, 1, 3].index2 = 1;
                    blocks[5, 1, 3].type = BlockType.Dye; blocks[5, 1, 3].index = 3;
                    blocks[6, 1, 3].type = BlockType.Tunnel; blocks[6, 1, 3].index = 2; blocks[6, 1, 3].dir = true; blocks[6, 1, 3].index2 = 3;
                    blocks[7, 1, 3].type = BlockType.Dye; blocks[7, 1, 3].index = 2;
                    blocks[8, 1, 3].type = BlockType.Tunnel; blocks[8, 1, 3].index = 3; blocks[8, 1, 3].dir = true; blocks[8, 1, 3].index2 = 3;
                    blocks[9, 1, 3].type = BlockType.Air;
                    blocks[10, 1, 3].type = BlockType.Tunnel; blocks[10, 1, 3].index = 4; blocks[10, 1, 3].dir = true; blocks[10, 1, 3].index2 = 5;
                    blocks[11, 1, 3].type = BlockType.Air;
                    blocks[12, 1, 3].type = BlockType.Air;
                    blocks[13, 1, 3].type = BlockType.Air;
                    blocks[1, 1, 4].type = BlockType.Tunnel; blocks[1, 1, 4].index = 2; blocks[1, 1, 4].dir = false; blocks[1, 1, 4].index2 = 3;
                    blocks[3, 1, 4].type = BlockType.Tunnel; blocks[3, 1, 4].index = 2; blocks[3, 1, 4].dir = false; blocks[3, 1, 4].index2 = 2;
                    blocks[5, 1, 4].type = BlockType.Tunnel; blocks[5, 1, 4].index = 3; blocks[5, 1, 4].dir = false; blocks[5, 1, 4].index2 = 3;
                    blocks[7, 1, 4].type = BlockType.Tunnel; blocks[7, 1, 4].index = 2; blocks[7, 1, 4].dir = false; blocks[7, 1, 4].index2 = 2;
                    blocks[9, 1, 4].type = BlockType.Tunnel; blocks[9, 1, 4].index = 5; blocks[9, 1, 4].dir = false; blocks[9, 1, 4].index2 = 5;
                    blocks[11, 1, 4].type = BlockType.Tunnel; blocks[11, 1, 4].index = 5; blocks[11, 1, 4].dir = false; blocks[11, 1, 4].index2 = 3;
                    blocks[13, 1, 4].type = BlockType.Tunnel; blocks[13, 1, 4].index = 5; blocks[13, 1, 4].dir = false; blocks[13, 1, 4].index2 = 2;
                    blocks[1, 1, 5].type = BlockType.Air;
                    blocks[2, 1, 5].type = BlockType.Tunnel; blocks[2, 1, 5].index = 2; blocks[2, 1, 5].dir = true; blocks[2, 1, 5].index2 = 3;
                    blocks[3, 1, 5].type = BlockType.Air;
                    blocks[4, 1, 5].type = BlockType.Tunnel; blocks[4, 1, 5].index = 3; blocks[4, 1, 5].dir = true; blocks[4, 1, 5].index2 = 4;
                    blocks[5, 1, 5].type = BlockType.Air;
                    blocks[6, 1, 5].type = BlockType.Tunnel; blocks[6, 1, 5].index = 3; blocks[6, 1, 5].dir = true; blocks[6, 1, 5].index2 = 3;
                    blocks[7, 1, 5].type = BlockType.Air;
                    blocks[8, 1, 5].type = BlockType.Tunnel; blocks[8, 1, 5].index = 3; blocks[8, 1, 5].dir = true; blocks[8, 1, 5].index2 = 1;
                    blocks[9, 1, 5].type = BlockType.Dye; blocks[9, 1, 5].index = 5;
                    blocks[10, 1, 5].type = BlockType.Tunnel; blocks[10, 1, 5].index = 2; blocks[10, 1, 5].dir = true; blocks[10, 1, 5].index2 = 3;
                    blocks[11, 1, 5].type = BlockType.Dye; blocks[11, 1, 5].index = 3;
                    blocks[12, 1, 5].type = BlockType.Tunnel; blocks[12, 1, 5].index = 3; blocks[12, 1, 5].dir = true; blocks[12, 1, 5].index2 = 5;
                    blocks[13, 1, 5].type = BlockType.Air;
                    blocks[1, 1, 6].type = BlockType.Tunnel; blocks[1, 1, 6].index = 3; blocks[1, 1, 6].dir = false; blocks[1, 1, 6].index2 = 3;
                    blocks[3, 1, 6].type = BlockType.Tunnel; blocks[3, 1, 6].index = 5; blocks[3, 1, 6].dir = false; blocks[3, 1, 6].index2 = 2;
                    blocks[5, 1, 6].type = BlockType.Tunnel; blocks[5, 1, 6].index = 1; blocks[5, 1, 6].dir = false; blocks[5, 1, 6].index2 = 5;
                    blocks[7, 1, 6].type = BlockType.Tunnel; blocks[7, 1, 6].index = 2; blocks[7, 1, 6].dir = false; blocks[7, 1, 6].index2 = 2;
                    blocks[9, 1, 6].type = BlockType.Tunnel; blocks[9, 1, 6].index = 3; blocks[9, 1, 6].dir = false; blocks[9, 1, 6].index2 = 2;
                    blocks[11, 1, 6].type = BlockType.Tunnel; blocks[11, 1, 6].index = 3; blocks[11, 1, 6].dir = false; blocks[11, 1, 6].index2 = 4;
                    blocks[13, 1, 6].type = BlockType.Tunnel; blocks[13, 1, 6].index = 3; blocks[13, 1, 6].dir = false; blocks[13, 1, 6].index2 = 5;
                    blocks[1, 1, 7].type = BlockType.Dye; blocks[1, 1, 7].index = 3;
                    blocks[2, 1, 7].type = BlockType.Tunnel; blocks[2, 1, 7].index = 3; blocks[2, 1, 7].dir = true; blocks[2, 1, 7].index2 = 2;
                    blocks[3, 1, 7].type = BlockType.Dye; blocks[3, 1, 7].index = 2;
                    blocks[4, 1, 7].type = BlockType.Tunnel; blocks[4, 1, 7].index = 3; blocks[4, 1, 7].dir = true; blocks[4, 1, 7].index2 = 3;
                    blocks[5, 1, 7].type = BlockType.Air;
                    blocks[6, 1, 7].type = BlockType.Tunnel; blocks[6, 1, 7].index = 1; blocks[6, 1, 7].dir = true; blocks[6, 1, 7].index2 = 3;
                    blocks[7, 1, 7].type = BlockType.Air;
                    blocks[8, 1, 7].type = BlockType.Tunnel; blocks[8, 1, 7].index = 2; blocks[8, 1, 7].dir = true; blocks[8, 1, 7].index2 = 3;
                    blocks[9, 1, 7].type = BlockType.Bonus;
                    blocks[10, 1, 7].type = BlockType.Tunnel; blocks[10, 1, 7].index = 3; blocks[10, 1, 7].dir = true; blocks[10, 1, 7].index2 = 3;
                    blocks[11, 1, 7].type = BlockType.Dye; blocks[11, 1, 7].index = 4;
                    blocks[12, 1, 7].type = BlockType.Tunnel; blocks[12, 1, 7].index = 3; blocks[12, 1, 7].dir = true; blocks[12, 1, 7].index2 = 1;
                    blocks[13, 1, 7].type = BlockType.Air;
                    blocks[1, 1, 8].type = BlockType.Tunnel; blocks[1, 1, 8].index = 3; blocks[1, 1, 8].dir = false; blocks[1, 1, 8].index2 = 3;
                    blocks[3, 1, 8].type = BlockType.Tunnel; blocks[3, 1, 8].index = 3; blocks[3, 1, 8].dir = false; blocks[3, 1, 8].index2 = 3;
                    blocks[5, 1, 8].type = BlockType.Tunnel; blocks[5, 1, 8].index = 3; blocks[5, 1, 8].dir = false; blocks[5, 1, 8].index2 = 3;
                    blocks[7, 1, 8].type = BlockType.Tunnel; blocks[7, 1, 8].index = 2; blocks[7, 1, 8].dir = false; blocks[7, 1, 8].index2 = 3;
                    blocks[9, 1, 8].type = BlockType.Tunnel; blocks[9, 1, 8].index = 3; blocks[9, 1, 8].dir = false; blocks[9, 1, 8].index2 = 1;
                    blocks[11, 1, 8].type = BlockType.Tunnel; blocks[11, 1, 8].index = 4; blocks[11, 1, 8].dir = false; blocks[11, 1, 8].index2 = 4;
                    blocks[13, 1, 8].type = BlockType.Tunnel; blocks[13, 1, 8].index = 3; blocks[13, 1, 8].dir = false; blocks[13, 1, 8].index2 = 1;
                    blocks[1, 1, 9].type = BlockType.Air;
                    blocks[2, 1, 9].type = BlockType.Tunnel; blocks[2, 1, 9].index = 3; blocks[2, 1, 9].dir = true; blocks[2, 1, 9].index2 = 3;
                    blocks[3, 1, 9].type = BlockType.Air;
                    blocks[4, 1, 9].type = BlockType.Tunnel; blocks[4, 1, 9].index = 3; blocks[4, 1, 9].dir = true; blocks[4, 1, 9].index2 = 5;
                    blocks[5, 1, 9].type = BlockType.Dye; blocks[5, 1, 9].index = 3;
                    blocks[6, 1, 9].type = BlockType.Tunnel; blocks[6, 1, 9].index = 3; blocks[6, 1, 9].dir = true; blocks[6, 1, 9].index2 = 4;
                    blocks[7, 1, 9].type = BlockType.Dye; blocks[7, 1, 9].index = 4;
                    blocks[8, 1, 9].type = BlockType.Tunnel; blocks[8, 1, 9].index = 3; blocks[8, 1, 9].dir = true; blocks[8, 1, 9].index2 = 2;
                    blocks[9, 1, 9].type = BlockType.Air;
                    blocks[10, 1, 9].type = BlockType.Tunnel; blocks[10, 1, 9].index = 2; blocks[10, 1, 9].dir = true; blocks[10, 1, 9].index2 = 2;
                    blocks[11, 1, 9].type = BlockType.Air;
                    blocks[12, 1, 9].type = BlockType.Tunnel; blocks[12, 1, 9].index = 2; blocks[12, 1, 9].dir = true; blocks[12, 1, 9].index2 = 3;
                    blocks[13, 1, 9].type = BlockType.Dye; blocks[13, 1, 9].index = 1;
                    blocks[1, 1, 10].type = BlockType.Tunnel; blocks[1, 1, 10].index = 1; blocks[1, 1, 10].dir = false; blocks[1, 1, 10].index2 = 3;
                    blocks[3, 1, 10].type = BlockType.Tunnel; blocks[3, 1, 10].index = 3; blocks[3, 1, 10].dir = false; blocks[3, 1, 10].index2 = 3;
                    blocks[5, 1, 10].type = BlockType.Tunnel; blocks[5, 1, 10].index = 2; blocks[5, 1, 10].dir = false; blocks[5, 1, 10].index2 = 4;
                    blocks[7, 1, 10].type = BlockType.Tunnel; blocks[7, 1, 10].index = 3; blocks[7, 1, 10].dir = false; blocks[7, 1, 10].index2 = 1;
                    blocks[9, 1, 10].type = BlockType.Tunnel; blocks[9, 1, 10].index = 3; blocks[9, 1, 10].dir = false; blocks[9, 1, 10].index2 = 2;
                    blocks[11, 1, 10].type = BlockType.Tunnel; blocks[11, 1, 10].index = 4; blocks[11, 1, 10].dir = false; blocks[11, 1, 10].index2 = 1;
                    blocks[13, 1, 10].type = BlockType.Tunnel; blocks[13, 1, 10].index = 3; blocks[13, 1, 10].dir = false; blocks[13, 1, 10].index2 = 1;
                    blocks[1, 1, 11].type = BlockType.Air;
                    blocks[2, 1, 11].type = BlockType.Air;
                    blocks[3, 1, 11].type = BlockType.Air;
                    blocks[4, 1, 11].type = BlockType.Tunnel; blocks[4, 1, 11].index = 3; blocks[4, 1, 11].dir = true; blocks[4, 1, 11].index2 = 3;
                    blocks[5, 1, 11].type = BlockType.Dye; blocks[5, 1, 11].index = 4;
                    blocks[6, 1, 11].type = BlockType.Tunnel; blocks[6, 1, 11].index = 3; blocks[6, 1, 11].dir = true; blocks[6, 1, 11].index2 = 1;
                    blocks[7, 1, 11].type = BlockType.Air;
                    blocks[8, 1, 11].type = BlockType.Tunnel; blocks[8, 1, 11].index = 1; blocks[8, 1, 11].dir = true; blocks[8, 1, 11].index2 = 3;
                    blocks[9, 1, 11].type = BlockType.Dye; blocks[9, 1, 11].index = 2;
                    blocks[10, 1, 11].type = BlockType.Tunnel; blocks[10, 1, 11].index = 3; blocks[10, 1, 11].dir = true; blocks[10, 1, 11].index2 = 1;
                    blocks[11, 1, 11].type = BlockType.Air;
                    blocks[12, 1, 11].type = BlockType.Air;
                    blocks[13, 1, 11].type = BlockType.Air;
                    blocks[1, 1, 12].type = BlockType.Air;
                    blocks[2, 1, 12].type = BlockType.Bonus;
                    blocks[3, 1, 12].type = BlockType.Air;
                    blocks[5, 1, 12].type = BlockType.Tunnel; blocks[5, 1, 12].index = 4; blocks[5, 1, 12].dir = false; blocks[5, 1, 12].index2 = 3;
                    blocks[7, 1, 12].type = BlockType.Tunnel; blocks[7, 1, 12].index = 3; blocks[7, 1, 12].dir = false; blocks[7, 1, 12].index2 = 1;
                    blocks[9, 1, 12].type = BlockType.Tunnel; blocks[9, 1, 12].index = 2; blocks[9, 1, 12].dir = false; blocks[9, 1, 12].index2 = 2;
                    blocks[11, 1, 12].type = BlockType.Air;
                    blocks[12, 1, 12].type = BlockType.Exit;
                    blocks[13, 1, 12].type = BlockType.Air;
                    blocks[1, 1, 13].type = BlockType.Dye; blocks[1, 1, 13].index = 3;
                    blocks[2, 1, 13].type = BlockType.Air;
                    blocks[3, 1, 13].type = BlockType.Air;
                    blocks[4, 1, 13].type = BlockType.Tunnel; blocks[4, 1, 13].index = 3; blocks[4, 1, 13].dir = true; blocks[4, 1, 13].index2 = 4;
                    blocks[5, 1, 13].type = BlockType.Air;
                    blocks[6, 1, 13].type = BlockType.Tunnel; blocks[6, 1, 13].index = 3; blocks[6, 1, 13].dir = true; blocks[6, 1, 13].index2 = 3;
                    blocks[7, 1, 13].type = BlockType.Dye; blocks[7, 1, 13].index = 1;
                    blocks[8, 1, 13].type = BlockType.Tunnel; blocks[8, 1, 13].index = 5; blocks[8, 1, 13].dir = true; blocks[8, 1, 13].index2 = 1;
                    blocks[9, 1, 13].type = BlockType.Air;
                    blocks[10, 1, 13].type = BlockType.Tunnel; blocks[10, 1, 13].index = 3; blocks[10, 1, 13].dir = true; blocks[10, 1, 13].index2 = 1;
                    blocks[11, 1, 13].type = BlockType.Air;
                    blocks[12, 1, 13].type = BlockType.Air;
                    blocks[13, 1, 13].type = BlockType.Dye; blocks[13, 1, 13].index = 1;

                    for (int x = 0; x <= 14; x++) for (int y = 3; y <= 14; y++) for (int z = 0; z <= 14; z++) blocks[x, y, z].type = BlockType.Air;
                }
                break;
            case 37:
                {
                    blocks[3, 1, 5].type = BlockType.Air;
                    blocks[3, 1, 6].type = BlockType.Air;
                    for (int x = 1; x <= 5; x++) { blocks[x, 1, 7].type = BlockType.Air; }
                    blocks[3, 1, 8].type = BlockType.Air;
                    blocks[3, 1, 9].type = BlockType.Air;
                    blocks[3, 2, 5].type = BlockType.Air;
                    blocks[1, 2, 7].type = BlockType.Air;
                    blocks[3, 2, 7].type = BlockType.Air;
                    blocks[5, 2, 7].type = BlockType.Air;
                    blocks[3, 2, 9].type = BlockType.Air;
                    blocks[3, 3, 4].type = BlockType.Bonus;
                    blocks[3, 3, 5].type = BlockType.Air;
                    blocks[1, 3, 7].type = BlockType.Air;
                    blocks[3, 3, 7].type = BlockType.Air;
                    blocks[5, 3, 7].type = BlockType.Air;
                    blocks[6, 3, 7].type = BlockType.Dye; blocks[6, 3, 7].index = 3;
                    blocks[3, 3, 9].type = BlockType.Air;
                    blocks[3, 3, 5].type = BlockType.Air;
                    blocks[1, 3, 7].type = BlockType.Air;
                    blocks[3, 3, 7].type = BlockType.Air;
                    blocks[5, 3, 7].type = BlockType.Air;
                    blocks[3, 3, 9].type = BlockType.Air;
                    blocks[3, 4, 5].type = BlockType.Air;
                    blocks[1, 4, 7].type = BlockType.Air;
                    blocks[3, 4, 7].type = BlockType.Air;
                    blocks[5, 4, 7].type = BlockType.Air;
                    blocks[3, 4, 9].type = BlockType.Air;
                    blocks[7, 5, 1].type = BlockType.Air;
                    blocks[8, 5, 1].type = BlockType.Air;
                    blocks[9, 5, 1].type = BlockType.Air;
                    blocks[9, 5, 2].type = BlockType.Air;
                    blocks[10, 5, 2].type = BlockType.Air;
                    blocks[11, 5, 2].type = BlockType.Dye; blocks[11, 5, 2].index = 3;
                    blocks[3, 5, 4].type = BlockType.Key; blocks[3, 5, 4].index = 1;
                    blocks[3, 5, 5].type = BlockType.Air;
                    blocks[1, 5, 7].type = BlockType.Air;
                    blocks[3, 5, 7].type = BlockType.Air;
                    blocks[5, 5, 7].type = BlockType.Air;
                    blocks[3, 5, 9].type = BlockType.Air;
                    blocks[1, 6, 1].type = BlockType.Air;
                    blocks[2, 6, 1].type = BlockType.Air;
                    blocks[3, 6, 1].type = BlockType.Lock; blocks[3, 6, 1].index = 5;
                    blocks[4, 6, 1].type = BlockType.Air;
                    blocks[5, 6, 1].type = BlockType.Air;
                    blocks[7, 6, 1].type = BlockType.Air;
                    blocks[1, 6, 2].type = BlockType.Air;
                    blocks[1, 6, 3].type = BlockType.Air;
                    blocks[2, 6, 3].type = BlockType.Air;
                    blocks[3, 6, 3].type = BlockType.Exit;
                    blocks[8, 6, 4].type = BlockType.Air;
                    blocks[9, 6, 4].type = BlockType.Air;
                    blocks[10, 6, 4].type = BlockType.Tunnel; blocks[10, 6, 4].index = 3; blocks[10, 6, 4].dir = true; blocks[10, 6, 4].index2 = 5;
                    blocks[11, 6, 4].type = BlockType.Air;
                    blocks[12, 6, 4].type = BlockType.Air;
                    blocks[8, 6, 5].type = BlockType.Air;
                    blocks[12, 6, 5].type = BlockType.Air;
                    blocks[6, 6, 6].type = BlockType.Air;
                    blocks[8, 6, 6].type = BlockType.Air;
                    blocks[12, 6, 6].type = BlockType.Air;
                    blocks[1, 6, 7].type = BlockType.Air;
                    blocks[3, 6, 7].type = BlockType.Air;
                    blocks[5, 6, 7].type = BlockType.Air;
                    blocks[6, 6, 8].type = BlockType.Air;
                    blocks[8, 6, 8].type = BlockType.Air;
                    blocks[12, 6, 8].type = BlockType.Air;
                    blocks[3, 6, 9].type = BlockType.Air;
                    blocks[8, 6, 9].type = BlockType.Air;
                    blocks[12, 6, 9].type = BlockType.Air;
                    blocks[8, 6, 10].type = BlockType.Air;
                    blocks[9, 6, 10].type = BlockType.Air;
                    blocks[10, 6, 10].type = BlockType.Tunnel; blocks[10, 6, 10].index = 1; blocks[10, 6, 10].dir = true; blocks[10, 6, 10].index2 = 3;
                    blocks[11, 6, 10].type = BlockType.Air;
                    blocks[12, 6, 10].type = BlockType.Air;
                    for (int x = 5; x <= 8; x++) { blocks[x, 7, 1].type = BlockType.Air; }
                    blocks[9, 7, 1].type = BlockType.Lock; blocks[9, 7, 1].index = 5;
                    blocks[10, 7, 1].type = BlockType.Air;
                    blocks[11, 7, 1].type = BlockType.Air;
                    blocks[2, 7, 5].type = BlockType.Dye; blocks[2, 7, 5].index = 1;
                    blocks[3, 7, 5].type = BlockType.Air;
                    blocks[4, 7, 5].type = BlockType.Key; blocks[4, 7, 5].index = 5;
                    blocks[6, 7, 6].type = BlockType.Air;
                    blocks[8, 7, 6].type = BlockType.Air;
                    blocks[12, 7, 6].type = BlockType.Air;
                    blocks[3, 7, 7].type = BlockType.Air;
                    blocks[12, 7, 7].type = BlockType.Dye; blocks[12, 7, 7].index = 5;
                    blocks[6, 7, 8].type = BlockType.Air;
                    blocks[8, 7, 8].type = BlockType.Air;
                    blocks[12, 7, 8].type = BlockType.Air;
                    blocks[1, 8, 1].type = BlockType.Air;
                    blocks[2, 8, 1].type = BlockType.Tunnel; blocks[2, 8, 1].index = 5; blocks[2, 8, 1].dir = true; blocks[2, 8, 1].index2 = 3;
                    blocks[3, 8, 1].type = BlockType.Air;
                    blocks[7, 8, 1].type = BlockType.Air;
                    blocks[11, 8, 1].type = BlockType.Air;
                    blocks[12, 8, 1].type = BlockType.Air;
                    blocks[13, 8, 1].type = BlockType.Air;
                    blocks[1, 8, 2].type = BlockType.Air;
                    blocks[1, 8, 3].type = BlockType.Air;
                    blocks[2, 8, 3].type = BlockType.Tunnel; blocks[2, 8, 3].index = 1; blocks[2, 8, 3].dir = true; blocks[2, 8, 3].index2 = 5;
                    blocks[3, 8, 3].type = BlockType.Air;
                    blocks[1, 8, 4].type = BlockType.Air;
                    blocks[1, 8, 5].type = BlockType.Air;
                    blocks[2, 8, 5].type = BlockType.Tunnel; blocks[2, 8, 5].index = 4; blocks[2, 8, 5].dir = true; blocks[2, 8, 5].index2 = 1;
                    blocks[3, 8, 5].type = BlockType.Air;
                    blocks[1, 8, 6].type = BlockType.Air;
                    blocks[6, 8, 6].type = BlockType.Air;
                    blocks[7, 8, 6].type = BlockType.Air;
                    blocks[8, 8, 6].type = BlockType.Air;
                    blocks[1, 8, 7].type = BlockType.Air;
                    blocks[2, 8, 7].type = BlockType.Tunnel; blocks[2, 8, 7].index = 2; blocks[2, 8, 7].dir = true; blocks[2, 8, 7].index2 = 3;
                    blocks[3, 8, 7].type = BlockType.Air;
                    blocks[6, 8, 7].type = BlockType.Air;
                    blocks[7, 8, 7].type = BlockType.Start;
                    blocks[8, 8, 7].type = BlockType.Air;
                    blocks[1, 8, 8].type = BlockType.Air;
                    blocks[6, 8, 8].type = BlockType.Air;
                    blocks[7, 8, 8].type = BlockType.Air;
                    blocks[8, 8, 8].type = BlockType.Air;
                    blocks[1, 8, 9].type = BlockType.Air;
                    blocks[1, 8, 10].type = BlockType.Air;
                    blocks[1, 8, 11].type = BlockType.Lock; blocks[1, 8, 11].index = 2;
                    blocks[1, 8, 12].type = BlockType.Air;
                    blocks[1, 8, 13].type = BlockType.Dye; blocks[1, 8, 13].index = 4;
                    for (int x = 3; x <= 7; x++) { blocks[x, 9, 1].type = BlockType.Air; }
                    blocks[3, 9, 3].type = BlockType.Air;
                    blocks[4, 9, 3].type = BlockType.Air;
                    blocks[5, 9, 3].type = BlockType.Air;
                    blocks[6, 9, 3].type = BlockType.Lock; blocks[6, 9, 3].index = 1;
                    blocks[7, 9, 3].type = BlockType.Air;
                    blocks[8, 9, 3].type = BlockType.Lock; blocks[8, 9, 3].index = 3;
                    blocks[9, 9, 3].type = BlockType.Air;
                    blocks[10, 9, 3].type = BlockType.Air;
                    blocks[11, 9, 3].type = BlockType.Air;
                    blocks[6, 9, 6].type = BlockType.Air;
                    blocks[8, 9, 6].type = BlockType.Air;
                    blocks[6, 9, 8].type = BlockType.Air;
                    blocks[8, 9, 8].type = BlockType.Air;
                    blocks[1, 9, 9].type = BlockType.Air;
                    blocks[4, 9, 9].type = BlockType.Air;
                    blocks[4, 9, 10].type = BlockType.Air;
                    blocks[4, 9, 11].type = BlockType.Bonus;
                    blocks[3, 9, 12].type = BlockType.Air;
                    blocks[3, 9, 13].type = BlockType.Key; blocks[3, 9, 13].index = 3;
                    for (int x = 4; x <= 7; x++) { blocks[x, 9, 13].type = BlockType.Air; }
                    blocks[8, 9, 13].type = BlockType.Dye; blocks[8, 9, 13].index = 1;
                    for (int x = 9; x <= 13; x++) { blocks[x, 9, 13].type = BlockType.Air; }
                    blocks[11, 10, 1].type = BlockType.Air;
                    blocks[11, 10, 2].type = BlockType.Air;
                    blocks[11, 10, 3].type = BlockType.Air;
                    for (int x = 2; x <= 6; x++) { blocks[x, 10, 4].type = BlockType.Air; }
                    blocks[11, 10, 4].type = BlockType.Air;
                    blocks[2, 10, 5].type = BlockType.Air;
                    blocks[6, 10, 5].type = BlockType.Air;
                    blocks[11, 10, 5].type = BlockType.Air;
                    blocks[2, 10, 6].type = BlockType.Air;
                    blocks[4, 10, 6].type = BlockType.Air;
                    blocks[6, 10, 6].type = BlockType.Air;
                    blocks[8, 10, 6].type = BlockType.Air;
                    blocks[11, 10, 6].type = BlockType.Air;
                    blocks[2, 10, 7].type = BlockType.Air;
                    blocks[4, 10, 7].type = BlockType.Air;
                    blocks[10, 10, 7].type = BlockType.Air;
                    blocks[11, 10, 7].type = BlockType.Air;
                    blocks[12, 10, 7].type = BlockType.Air;
                    blocks[4, 10, 8].type = BlockType.Air;
                    blocks[6, 10, 8].type = BlockType.Air;
                    blocks[8, 10, 8].type = BlockType.Air;
                    blocks[11, 10, 8].type = BlockType.Air;
                    for (int x = 1; x <= 4; x++) { blocks[x, 10, 9].type = BlockType.Air; }
                    blocks[11, 10, 9].type = BlockType.Tunnel; blocks[11, 10, 9].index = 3; blocks[11, 10, 9].dir = false; blocks[11, 10, 9].index2 = 5;
                    blocks[1, 10, 10].type = BlockType.Air;
                    blocks[11, 10, 10].type = BlockType.Air;
                    blocks[1, 10, 11].type = BlockType.Air;
                    blocks[11, 10, 11].type = BlockType.Air;
                    blocks[1, 10, 12].type = BlockType.Air;
                    blocks[2, 10, 12].type = BlockType.Air;
                    blocks[3, 10, 12].type = BlockType.Air;
                    blocks[11, 10, 12].type = BlockType.Air;
                    blocks[13, 10, 12].type = BlockType.Air;
                    blocks[13, 10, 13].type = BlockType.Air;
                    for (int x = 9; x <= 13; x++) { blocks[x, 11, 1].type = BlockType.Air; }
                    blocks[11, 11, 5].type = BlockType.Air;
                    blocks[3, 11, 6].type = BlockType.Air;
                    blocks[4, 11, 6].type = BlockType.Air;
                    blocks[2, 11, 7].type = BlockType.Air;
                    blocks[3, 11, 7].type = BlockType.Air;
                    blocks[9, 11, 7].type = BlockType.Dye; blocks[9, 11, 7].index = 3;
                    blocks[10, 11, 7].type = BlockType.Air;
                    blocks[12, 11, 7].type = BlockType.Air;
                    blocks[13, 11, 7].type = BlockType.Dye; blocks[13, 11, 7].index = 2;
                    blocks[11, 11, 12].type = BlockType.Air;
                    blocks[9, 12, 1].type = BlockType.Air;
                    blocks[13, 12, 1].type = BlockType.Air;
                    blocks[11, 12, 5].type = BlockType.Air;
                    blocks[11, 12, 6].type = BlockType.Air;
                    blocks[11, 12, 7].type = BlockType.Tunnel; blocks[11, 12, 7].index = 1; blocks[11, 12, 7].dir = false; blocks[11, 12, 7].index2 = 1;
                    blocks[10, 12, 8].type = BlockType.Air;
                    blocks[11, 12, 8].type = BlockType.Air;
                    blocks[12, 12, 8].type = BlockType.Air;
                    blocks[10, 12, 9].type = BlockType.Dye; blocks[10, 12, 9].index = 3;
                    blocks[12, 12, 9].type = BlockType.Dye; blocks[12, 12, 9].index = 5;
                    blocks[10, 12, 10].type = BlockType.Air;
                    blocks[11, 12, 10].type = BlockType.Key; blocks[11, 12, 10].index = 2;
                    blocks[12, 12, 10].type = BlockType.Air;
                    blocks[11, 12, 11].type = BlockType.Air;
                    blocks[11, 12, 12].type = BlockType.Air;
                    for (int x = 9; x <= 13; x++) { blocks[x, 13, 1].type = BlockType.Air; }
                }
                break;
            case 41:
                {
                    for (int x = 0; x <= 14; x++) for (int y = 3; y <= 14; y++) for (int z = 0; z <= 14; z++)
                                blocks[x, y, z].type = BlockType.Air;
                    blocks[1, 1, 1].type = BlockType.Start;
                    blocks[11, 1, 1].type = BlockType.Air;
                    blocks[12, 1, 1].type = BlockType.Air;
                    blocks[13, 1, 1].type = BlockType.Air;
                    blocks[1, 1, 2].type = BlockType.Air;
                    blocks[11, 1, 2].type = BlockType.Air;
                    blocks[13, 1, 2].type = BlockType.Air;
                    blocks[1, 1, 3].type = BlockType.Air;
                    blocks[3, 1, 3].type = BlockType.Air;
                    blocks[4, 1, 3].type = BlockType.Air;
                    blocks[11, 1, 3].type = BlockType.Air;
                    blocks[13, 1, 3].type = BlockType.Lever;
                    blocks[1, 1, 4].type = BlockType.Air;
                    blocks[2, 1, 4].type = BlockType.Air;
                    blocks[3, 1, 4].type = BlockType.Air;
                    blocks[11, 1, 4].type = BlockType.Air;
                    blocks[1, 1, 5].type = BlockType.Air;
                    blocks[3, 1, 5].type = BlockType.Air;
                    blocks[4, 1, 5].type = BlockType.Air;
                    blocks[5, 1, 5].type = BlockType.Air;
                    blocks[11, 1, 5].type = BlockType.Air;
                    blocks[13, 1, 5].type = BlockType.Air;
                    blocks[5, 1, 6].type = BlockType.Air;
                    blocks[9, 1, 6].type = BlockType.Air;
                    blocks[10, 1, 6].type = BlockType.Air;
                    blocks[11, 1, 6].type = BlockType.Air;
                    blocks[13, 1, 6].type = BlockType.Air;
                    for (int x = 1; x <= 5; x++) { blocks[x, 1, 7].type = BlockType.Air; }
                    blocks[7, 1, 7].type = BlockType.Train; blocks[7, 1, 7].index = 3; blocks[7, 1, 7].index2 = 4;
                    blocks[8, 1, 7].type = BlockType.Air;
                    blocks[9, 1, 7].type = BlockType.Air;
                    blocks[11, 1, 7].type = BlockType.Air;
                    blocks[13, 1, 7].type = BlockType.Air;
                    blocks[1, 1, 8].type = BlockType.Air;
                    blocks[3, 1, 8].type = BlockType.Air;
                    blocks[7, 1, 8].type = BlockType.Air;
                    blocks[9, 1, 8].type = BlockType.Air;
                    blocks[11, 1, 8].type = BlockType.Air;
                    blocks[12, 1, 8].type = BlockType.Air;
                    blocks[13, 1, 8].type = BlockType.Air;
                    blocks[1, 1, 9].type = BlockType.Air;
                    for (int x = 3; x <= 7; x++) { blocks[x, 1, 9].type = BlockType.Air; }
                    blocks[9, 1, 9].type = BlockType.Air;
                    blocks[13, 1, 9].type = BlockType.Train; blocks[13, 1, 9].index = 1; blocks[13, 1, 9].index2 = 3;
                    blocks[1, 1, 10].type = BlockType.Air;
                    blocks[7, 1, 10].type = BlockType.Air;
                    blocks[9, 1, 10].type = BlockType.Air;
                    blocks[10, 1, 10].type = BlockType.Air;
                    blocks[11, 1, 10].type = BlockType.Air;
                    blocks[13, 1, 10].type = BlockType.Air;
                    blocks[1, 1, 11].type = BlockType.Air;
                    blocks[7, 1, 11].type = BlockType.Air;
                    blocks[9, 1, 11].type = BlockType.Air;
                    blocks[11, 1, 11].type = BlockType.Air;
                    blocks[13, 1, 11].type = BlockType.Air;
                    blocks[1, 1, 12].type = BlockType.Air;
                    blocks[2, 1, 12].type = BlockType.Air;
                    blocks[3, 1, 12].type = BlockType.Air;
                    blocks[5, 1, 12].type = BlockType.Air;
                    blocks[7, 1, 12].type = BlockType.Air;
                    blocks[9, 1, 12].type = BlockType.Air;
                    blocks[11, 1, 12].type = BlockType.Air;
                    blocks[3, 1, 13].type = BlockType.Lever;
                    blocks[5, 1, 13].type = BlockType.Air;
                    blocks[6, 1, 13].type = BlockType.Air;
                    blocks[7, 1, 13].type = BlockType.Air;
                    blocks[9, 1, 13].type = BlockType.Train; blocks[9, 1, 13].index = 2; blocks[9, 1, 13].index2 = 2;
                    blocks[10, 1, 13].type = BlockType.Air;
                    blocks[11, 1, 13].type = BlockType.Air;
                    blocks[12, 1, 13].type = BlockType.Air;
                    blocks[13, 1, 13].type = BlockType.Exit;
                }
                break;
            case 42:
                {
                    blocks[1, 1, 1].type = BlockType.Start;
                    blocks[2, 1, 1].type = BlockType.Air;
                    blocks[3, 1, 1].type = BlockType.Air;
                    blocks[3, 1, 2].type = BlockType.Air;
                    blocks[3, 1, 3].type = BlockType.Air;
                    blocks[3, 1, 4].type = BlockType.Air;
                    blocks[3, 1, 5].type = BlockType.Air;
                    blocks[3, 1, 6].type = BlockType.Air;
                    blocks[4, 1, 6].type = BlockType.Air;
                    blocks[5, 1, 6].type = BlockType.Air;
                    blocks[3, 1, 7].type = BlockType.Air;
                    blocks[3, 1, 8].type = BlockType.Air;
                    blocks[3, 1, 9].type = BlockType.Lock; blocks[3, 1, 9].index = 3;
                    blocks[3, 1, 10].type = BlockType.Air;
                    for (int x = 3; x <= 13; x++) { blocks[x, 1, 11].type = BlockType.Air; }
                    blocks[8, 1, 12].type = BlockType.Train; blocks[8, 1, 12].index = 1; blocks[8, 1, 12].index2 = 2;
                    blocks[13, 1, 12].type = BlockType.Air;
                    blocks[8, 1, 13].type = BlockType.Air;
                    blocks[13, 1, 13].type = BlockType.Exit;
                    for (int x = 5; x <= 12; x++) { blocks[x, 2, 6].type = BlockType.Air; }
                    blocks[13, 2, 6].type = BlockType.Lever;
                    blocks[9, 2, 7].type = BlockType.Air;
                    blocks[5, 2, 8].type = BlockType.Train; blocks[5, 2, 8].index = 3; blocks[5, 2, 8].index2 = 2;
                    blocks[9, 2, 8].type = BlockType.Train; blocks[9, 2, 8].index = 2; blocks[9, 2, 8].index2 = 2;
                    blocks[10, 2, 8].type = BlockType.Air;
                    blocks[11, 2, 8].type = BlockType.Air;
                    blocks[5, 2, 9].type = BlockType.Air;
                    blocks[7, 2, 9].type = BlockType.Air;
                    blocks[8, 2, 9].type = BlockType.Train; blocks[8, 2, 9].index = 0; blocks[8, 2, 9].index2 = 2;
                    blocks[9, 2, 9].type = BlockType.Air;
                    blocks[4, 2, 10].type = BlockType.Key; blocks[4, 2, 10].index = 3;
                    for (int x = 5; x <= 12; x++) { blocks[x, 2, 10].type = BlockType.Air; }
                    blocks[13, 2, 10].type = BlockType.Lever;
                }
                break;
            case 43:
                {
                    blocks[1, 1, 1].type = BlockType.Start;
                    blocks[2, 1, 1].type = BlockType.Air;
                    blocks[3, 1, 1].type = BlockType.Air;
                    for (int x = 5; x <= 8; x++) { blocks[x, 1, 1].type = BlockType.Air; }
                    blocks[9, 1, 1].type = BlockType.Lever;
                    blocks[11, 1, 1].type = BlockType.Bonus;
                    blocks[1, 1, 2].type = BlockType.Air;
                    blocks[11, 1, 2].type = BlockType.Air;
                    blocks[1, 1, 3].type = BlockType.Air;
                    blocks[3, 1, 3].type = BlockType.Exit;
                    blocks[11, 1, 3].type = BlockType.Air;
                    blocks[3, 1, 4].type = BlockType.Air;
                    blocks[1, 1, 5].type = BlockType.Air;
                    blocks[3, 1, 5].type = BlockType.Air;
                    blocks[7, 1, 5].type = BlockType.Air;
                    blocks[8, 1, 5].type = BlockType.Air;
                    blocks[9, 1, 5].type = BlockType.Air;
                    blocks[11, 1, 5].type = BlockType.Air;
                    blocks[9, 1, 6].type = BlockType.Air;
                    blocks[11, 1, 6].type = BlockType.Air;
                    blocks[1, 1, 7].type = BlockType.Air;
                    blocks[3, 1, 7].type = BlockType.Air;
                    blocks[4, 1, 7].type = BlockType.Air;
                    blocks[5, 1, 7].type = BlockType.Lock; blocks[5, 1, 7].index = 2;
                    blocks[6, 1, 7].type = BlockType.Air;
                    blocks[7, 1, 7].type = BlockType.Air;
                    blocks[9, 1, 7].type = BlockType.Air;
                    blocks[11, 1, 7].type = BlockType.Key; blocks[11, 1, 7].index = 1;
                    blocks[3, 2, 1].type = BlockType.Air;
                    blocks[4, 2, 1].type = BlockType.Train; blocks[4, 2, 1].index = 3; blocks[4, 2, 1].index2 = 2;
                    blocks[5, 2, 1].type = BlockType.Air;
                    blocks[7, 2, 1].type = BlockType.Air;
                    blocks[4, 2, 2].type = BlockType.Air;
                    blocks[7, 2, 2].type = BlockType.Air;
                    blocks[1, 2, 3].type = BlockType.Air;
                    blocks[4, 2, 3].type = BlockType.Air;
                    blocks[6, 2, 3].type = BlockType.Train; blocks[6, 2, 3].index = 2; blocks[6, 2, 3].index2 = 2;
                    blocks[7, 2, 3].type = BlockType.Air;
                    blocks[8, 2, 3].type = BlockType.Air;
                    blocks[9, 2, 3].type = BlockType.Air;
                    blocks[11, 2, 3].type = BlockType.Air;
                    blocks[1, 2, 4].type = BlockType.Air;
                    blocks[7, 2, 4].type = BlockType.Air;
                    blocks[11, 2, 4].type = BlockType.Air;
                    blocks[1, 2, 5].type = BlockType.Air;
                    blocks[3, 2, 5].type = BlockType.Air;
                    blocks[7, 2, 5].type = BlockType.Air;
                    blocks[9, 2, 5].type = BlockType.Air;
                    blocks[10, 2, 5].type = BlockType.Air;
                    blocks[11, 2, 5].type = BlockType.Air;
                    blocks[1, 2, 6].type = BlockType.Air;
                    blocks[3, 2, 6].type = BlockType.Air;
                    blocks[4, 2, 6].type = BlockType.Train; blocks[4, 2, 6].index = 0; blocks[4, 2, 6].index2 = 2;
                    blocks[5, 2, 6].type = BlockType.Air;
                    blocks[1, 2, 7].type = BlockType.Lever;
                    blocks[3, 2, 7].type = BlockType.Air;
                    blocks[7, 2, 7].type = BlockType.Air;
                    blocks[8, 2, 7].type = BlockType.Air;
                    blocks[9, 2, 7].type = BlockType.Air;
                    blocks[11, 3, 1].type = BlockType.Lever;
                    blocks[11, 3, 2].type = BlockType.Lock; blocks[11, 3, 2].index = 1;
                    blocks[11, 3, 3].type = BlockType.Air;
                    blocks[11, 3, 5].type = BlockType.Air;
                    blocks[11, 3, 6].type = BlockType.Air;
                    blocks[11, 3, 7].type = BlockType.Key; blocks[11, 3, 7].index = 2;
                }
                break;
            case 44:
                {
                    blocks[1, 1, 3].type = BlockType.Lever;
                    blocks[2, 1, 3].type = BlockType.Air;
                    blocks[3, 1, 3].type = BlockType.Air;
                    blocks[3, 2, 3].type = BlockType.Air;
                    blocks[5, 2, 8].type = BlockType.Air;
                    blocks[6, 2, 8].type = BlockType.Dye; blocks[6, 2, 8].index = 1;
                    blocks[7, 2, 8].type = BlockType.Air;
                    blocks[3, 2, 9].type = BlockType.Air;
                    blocks[4, 2, 9].type = BlockType.Air;
                    blocks[5, 2, 9].type = BlockType.Air;
                    blocks[6, 2, 9].type = BlockType.Dye; blocks[6, 2, 9].index = 2;
                    blocks[7, 2, 9].type = BlockType.Air;
                    blocks[8, 2, 9].type = BlockType.Lock; blocks[8, 2, 9].index = 4;
                    blocks[9, 2, 9].type = BlockType.Air;
                    blocks[10, 2, 9].type = BlockType.Exit;
                    blocks[5, 2, 10].type = BlockType.Air;
                    blocks[6, 2, 10].type = BlockType.Dye; blocks[6, 2, 10].index = 3;
                    blocks[7, 2, 10].type = BlockType.Air;
                    blocks[1, 3, 1].type = BlockType.Start;
                    blocks[2, 3, 1].type = BlockType.Air;
                    blocks[3, 3, 1].type = BlockType.Dye; blocks[3, 3, 1].index = 1;
                    blocks[1, 3, 2].type = BlockType.Air;
                    blocks[3, 3, 2].type = BlockType.Air;
                    blocks[1, 3, 3].type = BlockType.Dye; blocks[1, 3, 3].index = 4;
                    blocks[2, 3, 3].type = BlockType.Air;
                    blocks[3, 3, 3].type = BlockType.Air;
                    blocks[4, 3, 3].type = BlockType.Air;
                    blocks[5, 3, 3].type = BlockType.Tunnel; blocks[5, 3, 3].index = 1; blocks[5, 3, 3].dir = true; blocks[5, 3, 3].index2 = 3;
                    blocks[6, 3, 3].type = BlockType.Air;
                    blocks[7, 3, 3].type = BlockType.Air;
                    blocks[3, 3, 4].type = BlockType.Air;
                    blocks[3, 3, 5].type = BlockType.Tunnel; blocks[3, 3, 5].index = 3; blocks[3, 3, 5].dir = false; blocks[3, 3, 5].index2 = 2;
                    blocks[3, 3, 6].type = BlockType.Air;
                    blocks[3, 3, 7].type = BlockType.Air;
                    blocks[3, 3, 9].type = BlockType.Air;
                    blocks[3, 4, 3].type = BlockType.Air;
                    blocks[7, 4, 3].type = BlockType.Air;
                    blocks[7, 4, 4].type = BlockType.Air;
                    blocks[7, 4, 5].type = BlockType.Dye; blocks[7, 4, 5].index = 3;
                    blocks[7, 4, 6].type = BlockType.Air;
                    blocks[9, 4, 6].type = BlockType.Lever;
                    blocks[3, 4, 7].type = BlockType.Air;
                    blocks[6, 4, 7].type = BlockType.Train; blocks[6, 4, 7].index = 2; blocks[6, 4, 7].index2 = 2;
                    blocks[7, 4, 7].type = BlockType.Air;
                    blocks[8, 4, 7].type = BlockType.Air;
                    blocks[9, 4, 7].type = BlockType.Air;
                    blocks[10, 4, 7].type = BlockType.Train; blocks[10, 4, 7].index = 1; blocks[10, 4, 7].index2 = 2;
                    blocks[11, 4, 7].type = BlockType.Air;
                    blocks[12, 4, 7].type = BlockType.Air;
                    blocks[13, 4, 7].type = BlockType.Bonus;
                    blocks[3, 4, 8].type = BlockType.Air;
                    blocks[10, 4, 8].type = BlockType.Air;
                    blocks[3, 4, 9].type = BlockType.Air;
                    blocks[6, 4, 9].type = BlockType.Air;
                    blocks[8, 4, 9].type = BlockType.Train; blocks[8, 4, 9].index = 3; blocks[8, 4, 9].index2 = 2;
                    blocks[10, 4, 9].type = BlockType.Bonus;
                    blocks[11, 4, 9].type = BlockType.Air;
                    blocks[8, 4, 10].type = BlockType.Air;
                    blocks[10, 4, 10].type = BlockType.Air;
                    blocks[4, 4, 11].type = BlockType.Air;
                    blocks[5, 4, 11].type = BlockType.Air;
                    blocks[6, 4, 11].type = BlockType.Air;
                    blocks[7, 4, 11].type = BlockType.Key; blocks[7, 4, 11].index = 4;
                    blocks[8, 4, 11].type = BlockType.Air;
                    blocks[9, 4, 11].type = BlockType.Air;
                    blocks[10, 4, 11].type = BlockType.Air;
                    blocks[6, 4, 12].type = BlockType.Train; blocks[6, 4, 12].index = 1; blocks[6, 4, 12].index2 = 2;
                    blocks[6, 4, 13].type = BlockType.Air;
                    blocks[3, 5, 1].type = BlockType.Bonus;
                    blocks[3, 5, 2].type = BlockType.Air;
                    blocks[1, 5, 3].type = BlockType.Bonus;
                    blocks[2, 5, 3].type = BlockType.Air;
                    blocks[3, 5, 3].type = BlockType.Air;
                    blocks[4, 5, 7].type = BlockType.Air;
                    blocks[5, 5, 7].type = BlockType.Air;
                    blocks[6, 5, 7].type = BlockType.Air;
                    blocks[4, 5, 8].type = BlockType.Air;
                    blocks[4, 5, 9].type = BlockType.Air;
                    blocks[5, 5, 9].type = BlockType.Air;
                    blocks[6, 5, 9].type = BlockType.Air;
                    blocks[4, 5, 10].type = BlockType.Air;
                    blocks[4, 5, 11].type = BlockType.Air;
                    blocks[6, 6, 9].type = BlockType.Air;
                    blocks[7, 6, 9].type = BlockType.Air;
                    blocks[8, 6, 9].type = BlockType.Lever;
                }
                break;
            case 45:
                {
                    blocks[1, 1, 1].type = BlockType.Start;
                    blocks[2, 1, 1].type = BlockType.Air;
                    blocks[3, 1, 1].type = BlockType.Lever;
                    blocks[4, 1, 1].type = BlockType.Air;
                    blocks[5, 1, 1].type = BlockType.Train; blocks[5, 1, 1].index = 3; blocks[5, 1, 1].index2 = 3;
                    for (int x = 6; x <= 13; x++) { blocks[x, 1, 1].type = BlockType.Air; }
                    blocks[5, 1, 2].type = BlockType.Air;
                    blocks[6, 1, 2].type = BlockType.Air;
                    blocks[8, 1, 2].type = BlockType.Air;
                    blocks[9, 1, 2].type = BlockType.Air;
                    blocks[10, 1, 2].type = BlockType.Bonus;
                    blocks[12, 1, 2].type = BlockType.Air;
                    blocks[13, 1, 2].type = BlockType.Air;
                    for (int x = 1; x <= 6; x++) { blocks[x, 1, 3].type = BlockType.Air; }
                    blocks[7, 1, 3].type = BlockType.Train; blocks[7, 1, 3].index = 3; blocks[7, 1, 3].index2 = 3;
                    blocks[8, 1, 3].type = BlockType.Air;
                    blocks[9, 1, 3].type = BlockType.Air;
                    blocks[10, 1, 3].type = BlockType.Air;
                    blocks[11, 1, 3].type = BlockType.Train; blocks[11, 1, 3].index = 3; blocks[11, 1, 3].index2 = 3;
                    blocks[12, 1, 3].type = BlockType.Air;
                    blocks[13, 1, 3].type = BlockType.Air;
                    blocks[1, 1, 4].type = BlockType.Air;
                    blocks[2, 1, 4].type = BlockType.Air;
                    blocks[4, 1, 4].type = BlockType.Train; blocks[4, 1, 4].index = 2; blocks[4, 1, 4].index2 = 3;
                    blocks[5, 1, 4].type = BlockType.Air;
                    blocks[6, 1, 4].type = BlockType.Air;
                    blocks[7, 1, 4].type = BlockType.Air;
                    blocks[8, 1, 4].type = BlockType.Train; blocks[8, 1, 4].index = 2; blocks[8, 1, 4].index2 = 3;
                    for (int x = 9; x <= 13; x++) { blocks[x, 1, 4].type = BlockType.Air; }
                    for (int x = 1; x <= 4; x++) { blocks[x, 1, 5].type = BlockType.Air; }
                    blocks[5, 1, 5].type = BlockType.Train; blocks[5, 1, 5].index = 3; blocks[5, 1, 5].index2 = 3;
                    blocks[6, 1, 5].type = BlockType.Air;
                    blocks[7, 1, 5].type = BlockType.Air;
                    blocks[8, 1, 5].type = BlockType.Air;
                    blocks[9, 1, 5].type = BlockType.Train; blocks[9, 1, 5].index = 1; blocks[9, 1, 5].index2 = 3;
                    for (int x = 10; x <= 13; x++) { blocks[x, 1, 5].type = BlockType.Air; }
                    for (int x = 1; x <= 5; x++) { blocks[x, 1, 6].type = BlockType.Air; }
                    blocks[6, 1, 6].type = BlockType.Train; blocks[6, 1, 6].index = 0; blocks[6, 1, 6].index2 = 3;
                    for (int x = 7; x <= 11; x++) { blocks[x, 1, 6].type = BlockType.Air; }
                    blocks[12, 1, 6].type = BlockType.Key; blocks[12, 1, 6].index = 2;
                    blocks[13, 1, 6].type = BlockType.Air;
                    for (int x = 1; x <= 13; x++) { blocks[x, 1, 7].type = BlockType.Air; }
                    blocks[1, 1, 8].type = BlockType.Air;
                    blocks[2, 1, 8].type = BlockType.Air;
                    blocks[3, 1, 8].type = BlockType.Train; blocks[3, 1, 8].index = 1; blocks[3, 1, 8].index2 = 3;
                    blocks[4, 1, 8].type = BlockType.Train; blocks[4, 1, 8].index = 0; blocks[4, 1, 8].index2 = 3;
                    blocks[5, 1, 8].type = BlockType.Air;
                    blocks[6, 1, 8].type = BlockType.Air;
                    blocks[8, 1, 8].type = BlockType.Air;
                    for (int x = 10; x <= 13; x++) { blocks[x, 1, 8].type = BlockType.Air; }
                    blocks[1, 1, 9].type = BlockType.Air;
                    blocks[2, 1, 9].type = BlockType.Air;
                    blocks[3, 1, 9].type = BlockType.Air;
                    for (int x = 5; x <= 13; x++) { blocks[x, 1, 9].type = BlockType.Air; }
                    blocks[1, 1, 10].type = BlockType.Air;
                    blocks[2, 1, 10].type = BlockType.Air;
                    blocks[3, 1, 10].type = BlockType.Air;
                    blocks[4, 1, 10].type = BlockType.Train; blocks[4, 1, 10].index = 3; blocks[4, 1, 10].index2 = 2;
                    for (int x = 5; x <= 13; x++) { blocks[x, 1, 10].type = BlockType.Air; }
                    blocks[1, 1, 11].type = BlockType.Train; blocks[1, 1, 11].index = 2; blocks[1, 1, 11].index2 = 3;
                    for (int x = 2; x <= 13; x++) { blocks[x, 1, 11].type = BlockType.Air; }
                    blocks[1, 1, 12].type = BlockType.Air;
                    blocks[2, 1, 12].type = BlockType.Air;
                    blocks[3, 1, 12].type = BlockType.Air;
                    blocks[4, 1, 12].type = BlockType.Train; blocks[4, 1, 12].index = 0; blocks[4, 1, 12].index2 = 2;
                    blocks[5, 1, 12].type = BlockType.Air;
                    blocks[7, 1, 12].type = BlockType.Air;
                    blocks[8, 1, 12].type = BlockType.Air;
                    for (int x = 1; x <= 8; x++) { blocks[x, 1, 13].type = BlockType.Air; }
                    blocks[9, 1, 13].type = BlockType.Lock; blocks[9, 1, 13].index = 2;
                    blocks[10, 1, 13].type = BlockType.Air;
                    blocks[11, 1, 13].type = BlockType.Tunnel; blocks[11, 1, 13].index = 1; blocks[11, 1, 13].dir = true; blocks[11, 1, 13].index2 = 1;
                    blocks[12, 1, 13].type = BlockType.Air;
                    blocks[13, 1, 13].type = BlockType.Exit;
                    blocks[13, 2, 1].type = BlockType.Air;
                    blocks[8, 2, 2].type = BlockType.Air;
                    blocks[4, 2, 5].type = BlockType.Air;
                    blocks[2, 2, 10].type = BlockType.Air;
                    blocks[7, 2, 10].type = BlockType.Air;
                    blocks[12, 2, 10].type = BlockType.Air;
                    blocks[13, 3, 1].type = BlockType.Air;
                    blocks[13, 3, 2].type = BlockType.Air;
                    blocks[8, 3, 3].type = BlockType.Air;
                    blocks[9, 3, 3].type = BlockType.Air;
                    blocks[10, 3, 3].type = BlockType.Lock; blocks[10, 3, 3].index = 4;
                    blocks[11, 3, 3].type = BlockType.Air;
                    blocks[12, 3, 3].type = BlockType.Air;
                    blocks[13, 3, 3].type = BlockType.Air;
                    blocks[8, 3, 4].type = BlockType.Air;
                    blocks[12, 3, 4].type = BlockType.Air;
                    blocks[2, 3, 5].type = BlockType.Air;
                    blocks[8, 3, 5].type = BlockType.Air;
                    blocks[10, 3, 5].type = BlockType.Air;
                    blocks[12, 3, 5].type = BlockType.Air;
                    blocks[2, 3, 6].type = BlockType.Air;
                    blocks[8, 3, 6].type = BlockType.Air;
                    blocks[10, 3, 6].type = BlockType.Air;
                    blocks[12, 3, 6].type = BlockType.Air;
                    blocks[13, 3, 6].type = BlockType.Air;
                    blocks[2, 3, 7].type = BlockType.Bonus;
                    blocks[5, 3, 7].type = BlockType.Air;
                    blocks[8, 3, 7].type = BlockType.Air;
                    blocks[10, 3, 7].type = BlockType.Air;
                    blocks[2, 3, 8].type = BlockType.Bonus;
                    blocks[5, 3, 8].type = BlockType.Air;
                    for (int x = 8; x <= 13; x++) { blocks[x, 3, 8].type = BlockType.Air; }
                    blocks[2, 3, 9].type = BlockType.Air;
                    blocks[5, 3, 9].type = BlockType.Air;
                    blocks[10, 3, 9].type = BlockType.Air;
                    blocks[12, 3, 9].type = BlockType.Air;
                    blocks[2, 3, 10].type = BlockType.Air;
                    blocks[5, 3, 10].type = BlockType.Air;
                    blocks[6, 3, 10].type = BlockType.Air;
                    blocks[7, 3, 10].type = BlockType.Air;
                    blocks[10, 3, 10].type = BlockType.Air;
                    blocks[12, 3, 10].type = BlockType.Air;
                    blocks[5, 4, 3].type = BlockType.Air;
                    blocks[6, 4, 3].type = BlockType.Air;
                    blocks[7, 4, 3].type = BlockType.Air;
                    for (int x = 2; x <= 5; x++) { blocks[x, 4, 5].type = BlockType.Air; }
                    blocks[6, 4, 5].type = BlockType.Tunnel; blocks[6, 4, 5].index = 3; blocks[6, 4, 5].dir = true; blocks[6, 4, 5].index2 = 3;
                    for (int x = 7; x <= 10; x++) { blocks[x, 4, 5].type = BlockType.Air; }
                    blocks[5, 4, 7].type = BlockType.Air;
                    blocks[8, 4, 10].type = BlockType.Key; blocks[8, 4, 10].index = 4;
                    blocks[9, 4, 10].type = BlockType.Air;
                    blocks[10, 4, 10].type = BlockType.Air;
                    blocks[5, 5, 3].type = BlockType.Air;
                    blocks[5, 5, 7].type = BlockType.Air;
                    for (int x = 3; x <= 7; x++) { blocks[x, 6, 3].type = BlockType.Air; }
                    blocks[5, 6, 4].type = BlockType.Air;
                    blocks[5, 6, 5].type = BlockType.Air;
                    blocks[5, 6, 6].type = BlockType.Air;
                    blocks[5, 6, 7].type = BlockType.Air;
                    blocks[1, 7, 3].type = BlockType.Air;
                    blocks[2, 7, 3].type = BlockType.Air;
                    blocks[3, 7, 3].type = BlockType.Air;
                    blocks[7, 7, 3].type = BlockType.Air;
                    blocks[8, 7, 3].type = BlockType.Air;
                    blocks[9, 7, 3].type = BlockType.Dye; blocks[9, 7, 3].index = 1;
                }
                break;
            default:
                break;
        }
        {
            for (int x = 1; x <= 13; x++) for (int y = 1; y <= 13; y++) for (int z = 1; z <= 13; z++)
                    {
                        if (blocks[x, y, z].type == BlockType.Wall &&
                            (blocks[x - 1, y, z].type != BlockType.Wall && blocks[x + 1, y, z].type != BlockType.Wall && blocks[x - 1, y, z].type != BlockType.Glass && blocks[x + 1, y, z].type != BlockType.Glass ||
                            blocks[x, y - 1, z].type != BlockType.Wall && blocks[x, y + 1, z].type != BlockType.Wall && blocks[x, y - 1, z].type != BlockType.Glass && blocks[x, y + 1, z].type != BlockType.Glass ||
                            blocks[x, y, z - 1].type != BlockType.Wall && blocks[x, y, z + 1].type != BlockType.Wall && blocks[x, y, z - 1].type != BlockType.Glass && blocks[x, y, z + 1].type != BlockType.Glass))
                        {
                            blocks[x, y, z].type = BlockType.Glass;
                        }
                    }
            for (int y = 1; y <= 13; y++) for (int z = 1; z <= 13; z++)
                {
                    if (blocks[0, y, z].type == BlockType.Wall &&
                            (blocks[1, y, z].type != BlockType.Wall && blocks[1, y, z].type != BlockType.Glass ||
                            blocks[0, y - 1, z].type != BlockType.Wall && blocks[0, y + 1, z].type != BlockType.Wall && blocks[0, y - 1, z].type != BlockType.Glass && blocks[0, y + 1, z].type != BlockType.Glass ||
                            blocks[0, y, z - 1].type != BlockType.Wall && blocks[0, y, z + 1].type != BlockType.Wall && blocks[0, y, z - 1].type != BlockType.Glass && blocks[0, y, z + 1].type != BlockType.Glass))
                    {
                        blocks[0, y, z].type = BlockType.Glass;
                    }
                }
            for (int y = 1; y <= 13; y++) for (int z = 1; z <= 13; z++)
                {
                    if (blocks[14, y, z].type == BlockType.Wall &&
                            (blocks[13, y, z].type != BlockType.Wall && blocks[13, y, z].type != BlockType.Glass ||
                            blocks[14, y - 1, z].type != BlockType.Wall && blocks[14, y + 1, z].type != BlockType.Wall && blocks[14, y - 1, z].type != BlockType.Glass && blocks[14, y + 1, z].type != BlockType.Glass ||
                            blocks[14, y, z - 1].type != BlockType.Wall && blocks[14, y, z + 1].type != BlockType.Wall && blocks[14, y, z - 1].type != BlockType.Glass && blocks[14, y, z + 1].type != BlockType.Glass))
                    {
                        blocks[14, y, z].type = BlockType.Glass;
                    }
                }
            for (int x = 1; x <= 13; x++) for (int z = 1; z <= 13; z++)
                {
                    if (blocks[x, 0, z].type == BlockType.Wall &&
                        (blocks[x - 1, 0, z].type != BlockType.Wall && blocks[x + 1, 0, z].type != BlockType.Wall && blocks[x - 1, 0, z].type != BlockType.Glass && blocks[x + 1, 0, z].type != BlockType.Glass ||
                        blocks[x, 1, z].type != BlockType.Wall && blocks[x, 1, z].type != BlockType.Glass ||
                        blocks[x, 0, z - 1].type != BlockType.Wall && blocks[x, 0, z + 1].type != BlockType.Wall && blocks[x, 0, z - 1].type != BlockType.Glass && blocks[x, 0, z + 1].type != BlockType.Glass))
                    {
                        blocks[x, 0, z].type = BlockType.Glass;
                    }
                    if (blocks[x, 14, z].type == BlockType.Wall &&
                            (blocks[x - 1, 14, z].type != BlockType.Wall && blocks[x + 1, 14, z].type != BlockType.Wall && blocks[x - 1, 14, z].type != BlockType.Glass && blocks[x + 1, 14, z].type != BlockType.Glass ||
                            blocks[x, 13, z].type != BlockType.Wall && blocks[x, 13, z].type != BlockType.Glass ||
                            blocks[x, 14, z - 1].type != BlockType.Wall && blocks[x, 14, z + 1].type != BlockType.Wall && blocks[x, 14, z - 1].type != BlockType.Glass && blocks[x, 14, z + 1].type != BlockType.Glass))
                    {
                        blocks[x, 14, z].type = BlockType.Glass;
                    }
                }
        }
        return blocks;
    }

}

public enum BlockType
{
    Air,
    Wall,
    Start,
    Exit,
    Glass,
    Key,
    Lock,
    Bonus,
    Dye,
    Tunnel,
    Lever,
    Train,
    Portal,
    Switch
}

public class Block
{
    public BlockType type;
    public int index; //for train is its direction
    public bool dir; //is horizontal
    public int index2; //for train is its length
}