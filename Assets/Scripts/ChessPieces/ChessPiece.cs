
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum ChessPieceType
{
    None = 0,
    Pawn = 1,
    Rook = 2,
    Knight = 3,
    Bishop = 4,
    Queen = 5,
    King = 6
}


public class ChessPiece : MonoBehaviour
{ //chess piece class
    public int team;
    public int currX;
    public int currY;
    public ChessPieceType type;
    public Vector3 desPosition;
    public Vector3 desScale;
}