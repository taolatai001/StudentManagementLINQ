﻿using System;

public class Student
{
    public int Id { get; set; }    
    public string Name { get; set; }
    public int Age { get; set; }  

    public Student(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Age: {Age}";
    }
}

