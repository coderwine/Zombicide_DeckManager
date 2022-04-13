using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class NPC : ICard
{
    public NPC(int id, EnemieActivation blueAtk, int blueCt, EnemieActivation yellowAtk, int yellowCt, EnemieActivation orangeAtk, int orangeCt, EnemieActivation redAtk, int redCt, CardType type, int boxNumber)
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
    public EnemieActivation BlueAttack { get; set; }
    public int BlueAttackCount { get; set; }
    public EnemieActivation YellowAttack { get; set; }
    public int YellowAttackCount { get; set; }
    public EnemieActivation OrangeAttack { get; set; }
    public int OrangeAttackCount { get; set; }
    public EnemieActivation RedAttack { get; set; }
    public int RedAttackCount { get; set; }
    public CardType TypeOfEnemy { get; set; }
    public int NPCBoxNumber { get; set; } // There are two different NPC boxes (1 & 2)

    public BoxSet Box { get; private set;} = BoxSet.NPC;
}
