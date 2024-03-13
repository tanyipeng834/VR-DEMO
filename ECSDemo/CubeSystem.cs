using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;
using Unity.Mathematics;

public partial class CubeSystem : SystemBase
{

    protected override void OnUpdate()
    {
        float deltaTime = SystemAPI.Time.DeltaTime;
        foreach(var(cubeData,transform) in SystemAPI.Query<RefRO<CubeData>, RefRW<LocalTransform>>())
        {
            transform.ValueRW = transform.ValueRO.RotateY(math.radians(cubeData.ValueRO.speed* deltaTime));



        }


    }
}
