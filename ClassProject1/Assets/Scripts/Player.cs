using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private int killCount;
    private string name;

    public Player(string name)
    {
        this.name = name;
    }

    public string getName()
    {
        return this.name;
    }

    public void addKill()
    {
        this.killCount++;
    }

    public int getKillCount()
    {
        return this.killCount;
    }
}
