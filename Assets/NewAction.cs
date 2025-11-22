using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;
using Unity.VisualScripting;
using MonoBehaviour = UnityEngine.MonoBehaviour;


[Serializable, GeneratePropertyBag]
[NodeDescription(name: "New Action", story: "Agent attacks [Target]", category: "Action", id: "f6b49bf7d3a9b498a3a396303829970a")]
public partial class NewAction : Action
{
    [SerializeReference] public BlackboardVariable<GameObject> Target;
    [CreateProperty]Player t;
    protected override Status OnStart()
    {
        //GameObject.GetComponent<>    
        Target.Value.GetComponent<Player>().HP -= 10;
        return Status.Running;
    }

    protected override Status OnUpdate()
    {
        return Status.Success;
    }

    protected override void OnEnd()
    {
    }
}

