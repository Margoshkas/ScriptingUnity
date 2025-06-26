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
        // Створення змінної позиції:
        // Vector3 – це спеціальний тип даних для зберігання координат позиції об’єкта.
        Vector3 newPosition;

        // Присвоєння поточної позиції:
        // transform – це компонент, що містить властивість position.
        newPosition = transform.position;

        // Додавання руху вперед (по осі z або x, залежно від напряму)
        newPosition.z += speed * Time.deltaTime;

        // Застосування нової позиції
        transform.position = newPosition;
    }
}
