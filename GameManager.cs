using UnityEngine;
using TMPro;
using Mono.Cecil.Cil;
public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI Points_P1;
    public TextMeshProUGUI Points_P2;
    public int point = 1;
    public int Current_points_P1;
    public int Current_points_P2;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Points_P1.text = "0";
        Points_P2.text = "0";

    }

    // Update is called once per frame
    void Update()
    {
        Points_P1.text = "" + Current_points_P1;
        Points_P2.text = "" + Current_points_P2;

    }

    public void AddPoint_P1()
    {
        Current_points_P1 += point;
    }
    public void AddPoint_P2()
    {
        Current_points_P2 += point;
    }
}
