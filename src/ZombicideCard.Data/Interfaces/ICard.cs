using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public interface ICard
    {
        int CardID { get; set; }
        EnemyActivation BlueAttack { get; set; }
        int BlueAttackCount { get; set;}
        EnemyActivation YellowAttack { get; set; }
        int YellowAttackCount { get; set;}
        EnemyActivation OrangeAttack { get; set; }
        int OrangeAttackCount { get; set;}
        EnemyActivation RedAttack { get; set; }
        int RedAttackCount { get; set;}
        CardType TypeOfEnemy { get; set; }
        BoxSet Box { get; }

    }