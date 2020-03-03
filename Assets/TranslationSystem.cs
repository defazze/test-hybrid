using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

public class TranslationSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
        Entities.ForEach((Transform transform, ref Translation translation) =>
        {
            transform.position = new Vector3(translation.Value.x, translation.Value.y, translation.Value.z);
        });
    }
}
