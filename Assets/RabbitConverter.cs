using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

public class SpriteConversionSystem : GameObjectConversionSystem
{
    protected override void OnUpdate()
    {
        Entities.ForEach((SpriteRenderer renderer) =>
        {
            var e = GetPrimaryEntity(renderer);
            DstEntityManager.AddComponent<CopyTransformToGameObject>(e);
            AddHybridComponent(renderer);

        });
    }
}
