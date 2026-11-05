using Unity.VisualScripting;
using UnityEngine;

public class RewardCalc : MonoBehaviour
{
    public int playSeconds = 3725;
    public int gold = 1234;

    public int members = 4;

    public int kills = 7;

    public int expPerKill = 35;

    public int totalDamage = 250;

    public int hits = 20;


    public float expRate = 1.5f;


    public int currenHp = 7;

    public int maxHp = 10;

    [ContextMenu("플레이 시간")]
    void PrintHp()
    {
        int a = playSeconds * 100 / members;

        Debug.Log("플레이 시간 : " + a + "시간");

       

       
    }
}
