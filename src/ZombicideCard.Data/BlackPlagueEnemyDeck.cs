using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class BlackPlagueEnemyDeck : ICard
{
    public BlackPlagueEnemyDeck(int id, string blueAtk, int blueCt, string yellowAtk, int yellowCt, string orangeAtk, int orangeCt, string redAtk, int redCt, string type)
    {
        CardID = id;
        BlueAttack = blueAtk;
        BlueAttackCount = blueCt;
        YellowAttack = yellowAtk;
        YellowAttackCount = yellowCt;
        OrangeAttack = orangeAtk;
        OrangeAttackCount = orangeCt;
        RedAttack = redAtk;
        RedAttackCount = redCt;
        TypeOfEnemy = type;
    }
    public int CardID { get; set; }
    public string BlueAttack { get; set; }
    public int BlueAttackCount { get; set; }
    public string YellowAttack { get; set; }
    public int YellowAttackCount { get; set; }
    public string OrangeAttack { get; set; }
    public int OrangeAttackCount { get; set; }
    public string RedAttack { get; set; }
    public int RedAttackCount { get; set; }
    public string TypeOfEnemy { get; set; }
    public string Box { get; private set; } = "Black Plague";
}
