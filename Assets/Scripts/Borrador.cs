using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "Data", menuName = "SpaceShip", order = 1)]   //lo de "2" es el nombre que yo quiera

public class SpashipData : ScriptableObject
{

    public string spaceshipName;
    [Range(0, 3.0f)]
    public int shield = 2;
    [Range(0, 3.0f)]
    public int speed = 2;
    [Range(0, 3.0f)]
    public int heat = 1;


}