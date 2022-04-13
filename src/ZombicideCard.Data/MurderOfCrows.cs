using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class MurderOfCrows : ICard
{
    public MurderOfCrows(int id, EnemyActivation blueAtk, int blueCt, EnemyActivation yellowAtk, int yellowCt, EnemyActivation orangeAtk, int orangeCt, EnemyActivation redAtk, int redCt, CardType type)
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
    public EnemyActivation BlueAttack { get; set; }
    public int BlueAttackCount { get; set; }
    public EnemyActivation YellowAttack { get; set; }
    public int YellowAttackCount { get; set; }
    public EnemyActivation OrangeAttack { get; set; }
    public int OrangeAttackCount { get; set; }
    public EnemyActivation RedAttack { get; set; }
    public int RedAttackCount { get; set; }
    public CardType TypeOfEnemy { get; set; }

    public BoxSet Box { get; private set; } = BoxSet.Murder_of_Crows;
}
