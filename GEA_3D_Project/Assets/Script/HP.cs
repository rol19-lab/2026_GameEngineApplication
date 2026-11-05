using UnityEngine;

public class HP : MonoBehaviour
{
    public int currenHp = 7;

    public int maxHp = 10;

    [ContextMenu("Hp 출력")]
    void PrintHp()
    {
        int a = currenHp * 100 / maxHp;

        Debug.Log("Hp : " + a + "%");

        int b = (int)((float)currenHp / maxHp * 100);

        Debug.Log("Hp : " + b + "%");
    }
}
