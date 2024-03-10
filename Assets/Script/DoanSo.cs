using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoanSo : MonoBehaviour
{
    int max = 1000, min = 0;
    int guess;
    public Text guessText;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }
    //Ham chay game
    void StartGame()
    {
        print("--------------------------------------------------------------------------------------");
        max = 1000;
        min = 0;
        guess = (max + min) / 2;
        print("Game doan so");
        print("Hay lua chon mot so trong dau ban");

        print("So lon nha ban co the chon la: " + max + " va so be nhat co the chon la: " + min);

        print("Neu lon hon " + guess + " nhan phim di len, Neu be hon " + guess + " nhan phim di xuong, Neu bang " + guess + " nhan phim Enter!");

    }
    //Ham cap nhat lai tinh huong sau khi nhan phim
    void NextGame()
    {
        guess = (max + min) / 2;
        print("Neu lon hon " + guess + " nhan phim di len, Neu be hon " + guess + " nhan phim di xuong, Neu bang " + guess + " nhan phim Enter!");
    }
        // Update is called once per frame
        void Update() 
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess; // gan min = 500
            NextGame();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGame();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        { 
            print("PC da thang !!!");
            Start();
        }
    }
}
