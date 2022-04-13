using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// namespace ZombicideCard.Data.Interfaces
// {
    public interface ICard
    {
        int CardID { get; set; }
        EnemieActivation BlueAttack { get; set; }
        int BlueAttackCount { get; set;}
        EnemieActivation YellowAttack { get; set; }
        int YellowAttackCount { get; set;}
        EnemieActivation OrangeAttack { get; set; }
        int OrangeAttackCount { get; set;}
        EnemieActivation RedAttack { get; set; }
        int RedAttackCount { get; set;}
        CardType TypeOfEnemy { get; set; }
        BoxSet Box { get; }

    }
// }