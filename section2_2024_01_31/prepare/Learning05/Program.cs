using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello Learning05 World!");

        FileFun.Run();

        // var people = new List<Person> {
        //     new Student("id1", "Student1", "Software Engineering"),
        //     new Employee("id2", "Employee2", "CSEE")
        // };

        // foreach (var person in people) {
        //     person.Display();
        // }



        // // Example 2: Vehicle
        // var vehicles = new List<Vehicle> {
        //     new Car("Honda", "Accord", 10, 33),
        //     new Truck("Toyota", "Tundra", 20, 15, false),
        //     new Truck("Toyota", "Tundra", 20, 15, true)
        // };

        // foreach (var vehicle in vehicles) {
        //     System.Console.WriteLine($"{vehicle.Display()}: {vehicle.RangeInMiles()} miles remaining");
        // }


        // // Example 3: Shapes and Area
        // var shapes = new List<Shape> {
        //     new Circle("red", 34),
        //     new Square("blue", 22)
        // };

        // foreach (var shape in shapes) {
        //     System.Console.WriteLine($"Area of Shape is: {shape.Area()}");
        // }

    }
}

public class Person {
    public static readonly string DELIMITER = "~";

    private string _id;
    protected string _name;

    public Person(string id, string name) {
        _id = id;
        _name = name;
    }
    
    public virtual void Display() {
        Console.Write($"{_name}\t{_id}");
    }

    public Person(string values) {
        var personValues = values.Split(DELIMITER);
        _id = personValues[0];
        _name = personValues[1];
    }

    public virtual string Serialize() {
        return $"{_id}{DELIMITER}{_name}";
    }
}

// Student
public class Student: Person {
    private string _major;
    private string _phone;

    public Student(string studentId, string studentName, string major, string phone) : base(studentId, studentName) {
        _major = major;
        _phone = phone;
    }
    
    public override string Serialize() {
        return base.Serialize() + $"{DELIMITER}{DELIMITER}{_major}{DELIMITER}{_phone}";
    }

    public Student(string values): base(values.Split($"{Person.DELIMITER}{Person.DELIMITER}")[0]) {
        var studentValues = values.Split($"{Person.DELIMITER}{Person.DELIMITER}")[1].Split(Person.DELIMITER);
        _major = studentValues[0];
        _phone = studentValues[1];
    }

    public override void Display() {
        System.Console.Write("Student:\t");
        base.Display();
        Console.WriteLine($"\t{_major}\t{_phone}");
    }
}

// Employee
public class Employee: Person {
    private string _department;

    public Employee(string id, string name, string department) : base(id, name) {
        _department = department;
    }

    // Override Display to show department
    public override string Serialize() {
        return base.Serialize() + $"{DELIMITER}{DELIMITER}{_department}";
    }

    public Employee(string values): base(values.Split($"{Person.DELIMITER}{Person.DELIMITER}")[0]) {
        var employeeValues = values.Split($"{Person.DELIMITER}{Person.DELIMITER}")[1].Split(Person.DELIMITER);
        _department = employeeValues[0];
    }

    public override void Display() {
        System.Console.Write("Employee:\t");
        base.Display();
        Console.WriteLine($"\t{_department}");
    }
}




public class Vehicle {
    private string _make;
    private string _model;
    private int _gallons;
    private int _milePerGallon;

    public Vehicle(string make, string model, int gallons, int milesPerGallon) {
        _make = make;
        _model = model;
        _gallons = gallons;
        _milePerGallon = milesPerGallon;
    }

    public string Display() {
        return $"{_make} {_model}";
    }

    public int RangeInMiles() {
        return _milePerGallon * _gallons;
    }
}

public class Car: Vehicle {
    public Car(string make, string model, int gallons, int milesPerGallon) : base(make, model, gallons, milesPerGallon) {

    }
}

public class Truck: Vehicle {
    private bool _isTowing;

    public Truck(string make, string model, int gallons, int milesPerGallon, bool isTowing) : base(make, model, gallons, milesPerGallon) {
        _isTowing = isTowing;
    }

    // Update Display to indicate if they are towing


    // Override RangeInMiles to account for isTowing
}








public class Shape {
    private string _color;

    public Shape(string color) {
        _color = color;
    }
}


public class Circle: Shape {
    private float _radius;

    public Circle(string color, float radius) : base(color) {
        _radius = radius;
    }

    public float Area() {
        float pi = (float)3.14;
        return pi * _radius * _radius;
    }
}


public class Square: Shape {
    private float _sideLength;

    public Square(string color, float sideLength) : base(color) {
        _sideLength = sideLength;
    }

    public float Area() {
        return _sideLength * _sideLength;
    }
}