﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemy
{
    bool IsDown { get; set; }
    bool PlayerInSight { get; set; }
    Rigidbody EnemyRigidBody { get; set; }


    bool PlayerInSightCheck();
}
