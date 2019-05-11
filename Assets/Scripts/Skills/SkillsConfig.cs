using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SkillConfig", menuName = "Skill/Config")]
public class SkillsConfig : ScriptableObject
{
    public float radius;
    public int id;
    public GameObject gameObject;
    public float castTime;
    public float damage;
    public Transform transform;
    public string name;
    public bool withoutDeath;
}
