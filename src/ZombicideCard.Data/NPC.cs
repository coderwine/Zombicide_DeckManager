using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class NPC : ICard
{
    public NPC(int id, EnemyActivation blueAtk, int blueCt, EnemyActivation yellowAtk, int yellowCt, EnemyActivation orangeAtk, int orangeCt, EnemyActivation redAtk, int redCt, CardType type, int boxNumber)
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
        NPCBoxNumber = boxNumber;
    }
    public int CardID { get; set; }
    public EnemyActivation BlueAttack { get; set; }
    public int BlueAttackCount { get; set; }
    public EnemyActivation YellowAttack { get; set; }
    public int YellowAttackCount { get; set; }
    public EnemyActivation OrangeAttack { get; set; }
    public int OrangeAttackCount { get; set; }
    public EnemyActivation RedAttack { get; set; }
    public int RedAttackCount { get; set; }
    public CardType TypeOfEnemy { get; set; }
    public int NPCBoxNumber { get; set; } // There are two different NPC boxes (1 & 2)

    public BoxSet Box { get; private set;} = BoxSet.NPC;
}
