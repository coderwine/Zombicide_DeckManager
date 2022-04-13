using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Guestbox : ICard
{
    public Guestbox(int id, EnemieActivation blueAtk, int blueCt, EnemieActivation yellowAtk, int yellowCt, EnemieActivation orangeAtk, int orangeCt, EnemieActivation redAtk, int redCt, CardType type, string name)
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
        GuestName = name;
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
    public string GuestName { get; set; }

    public BoxSet Box { get; private set;} = BoxSet.Guestbox;
}
