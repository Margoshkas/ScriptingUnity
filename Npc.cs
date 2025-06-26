using UnityEngine;

public class Npc : MonoBehaviour
{
    public int health = 5;
    public int level = 1;
    public float speed = 1.2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = 8;
        level = 5;

        health += level;
        print("Здоров'я " + health);
    }

    // Update is called once per frame
    void Update()
    {
    
        Vector3 newPosition;
        newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
