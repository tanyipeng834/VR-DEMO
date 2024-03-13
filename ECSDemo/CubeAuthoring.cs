using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class CubeAuthoring : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 100;
    public class CubeBaker : Baker<CubeAuthoring>
    {
        public override void Bake(CubeAuthoring authoring)
        {
            var entity = GetEntity(TransformUsageFlags.Dynamic);
            AddComponent(entity, new CubeData
            {
                speed = authoring.speed
            });
        }
    }
}
