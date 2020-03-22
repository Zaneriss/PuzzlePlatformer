using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class VectorValue : ScriptableObject, ISerializationCallbackReceiver
{

    public Vector2 InitialValue;
    public Vector2 DefaultValue;

    //sets the initial Scriptable object "Player Position" value as the default value

    public void OnAfterDeserialize() { InitialValue = DefaultValue; }

    public void OnBeforeSerialize() { }

}
