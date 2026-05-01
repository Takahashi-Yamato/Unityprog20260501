using UnityEngine;

public class Person 
{
    //プロパティの定義
    public string Name { get; set; }
    public int Age { get; set; }

    //メソッドの定義
    public void Great()
    {
         Debug.log("");
    }
}

public class General
{
    public Person person { get; set; }

    General()
    {
        person = new Person();

        person.Name = "takahashi ";
        person.Age = 20;
    }
}