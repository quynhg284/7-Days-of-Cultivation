using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHp = 100, stamina = 100, attack = 10, defense = 5;
    public int hp;
    //Start is called before the first frame update
    void Start()
    {
        hp = maxHp;
    }

    //Update is called once per frame
    void Update()
    {

    }
}
