using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PrefabDB", menuName = "ScriptableObjects/PrefabDatabase", order = 1)]
public class PrefabDatabase : ScriptableObject
{
    public GameObject[] prefabList;
}
