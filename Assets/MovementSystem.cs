using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

public class MovementSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
        Entities.WithAll<Rabbit>().ForEach((ref Translation translation) =>
        {

            if (Input.GetKey(KeyCode.A))
            {
                translation.Value.x -= Time.DeltaTime * 3;
            }

            if (Input.GetKey(KeyCode.D))
            {
                translation.Value.x += Time.DeltaTime * 3;
            }
        });
    }
}
