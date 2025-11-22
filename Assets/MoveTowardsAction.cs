using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "MoveTowards", story: "MoveTowards [Target] With [Speed]", category: "Action", id: "415a269a41f2f2eacba2900f956f0fe0")]
public partial class MoveTowardsAction : Action
{
    [SerializeReference] public BlackboardVariable<Transform> Target;
    [SerializeReference] public BlackboardVariable<float> Speed;

    protected override Status OnStart()
    {
        return Status.Running;
    }

    protected override Status OnUpdate()
    {
        if (Target?.Value ==null )
        {
            return Status.Failure;
        }
        if (Vector3.Distance(GameObject.transform.position, Target.Value.position) < 0.5f)
        {
            return Status.Success;
        }

        GameObject.transform.position = Vector3.MoveTowards(GameObject.transform.position, Target.Value.position, Speed * Time.deltaTime);
        // ˆÚ“®’†‚Íu“®ì’†v‚ð•Ô‚·
        return Status.Running;
    }

    protected override void OnEnd()
    {
    }
}

