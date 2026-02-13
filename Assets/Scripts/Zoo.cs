using UnityEngine;
using System.Collections.Generic;
public class Zoo : MonoBehaviour
{
    public List<Animal> animals = new List<Animal>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Animal newCat = new Animal("cat", "tiger", 5);
        animals.Add(newCat);


        for (int i = 0; i < animals.Count; i++)
        {
            Debug.Log(animals[i].name);
        }


        //animals.Add("snake");
        //animals.Remove("gorrila");

        //string selectedAnimal = animals[3];
        //Debug.Log(selectedAnimal);
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}

public class Animal
{
    public string name;
    public int age;
    public string type;
    public int size;
    public Color colour;
    public string sex;
   
    public Animal(string inType ,string inName, int inAge)
    {
        type = inType;
        name = inName;
        age = inAge;
    }
}