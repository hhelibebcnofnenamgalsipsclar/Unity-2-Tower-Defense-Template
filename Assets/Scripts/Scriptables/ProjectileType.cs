using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "Projectiles", menuName = "CostomObjects/Projectile")]
public class ProjectileType : ScriptableObject
{
    // Start is called before the first frame update
    public int damage;
    public float size;
    public float speed;
    public Color color = Color.black;

    public Sprite sprite;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
