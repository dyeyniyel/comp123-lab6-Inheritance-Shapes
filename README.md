In this exercise you will be using inheritance to promote code re-use.

![image](https://github.com/dyeyniyel/comp123-lab6-Inheritance-Shapes/assets/158533198/e1fb9fda-eb04-4b4f-8f82-1b167611a2b0)


![image](https://github.com/dyeyniyel/comp123-lab6-Inheritance-Shapes/assets/158533198/5958dc34-7526-4bed-9c34-e73c5e3de1b9)


![image](https://github.com/dyeyniyel/comp123-lab6-Inheritance-Shapes/assets/158533198/44fa690d-7832-45b8-8d4b-96c84dfac256)


![image](https://github.com/dyeyniyel/comp123-lab6-Inheritance-Shapes/assets/158533198/d685800b-f8f8-4e31-9978-69276e2d52d5)


![image](https://github.com/dyeyniyel/comp123-lab6-Inheritance-Shapes/assets/158533198/b1453467-8619-4e70-a265-6d73b42a8c69)


![image](https://github.com/dyeyniyel/comp123-lab6-Inheritance-Shapes/assets/158533198/6e2d3bc5-4f0c-4929-9baf-0e099442e544)

![image](https://github.com/dyeyniyel/comp123-lab6-Inheritance-Shapes/assets/158533198/f8099f3d-928f-49fd-8368-f5c337909e65)

![image](https://github.com/dyeyniyel/comp123-lab6-Inheritance-Shapes/assets/158533198/8c0328a3-5894-4e0d-9b7f-9c8f941adb90)

Test Harness

Copy the following lines to the Main method in the Program.cs file.



//although Shape is an abstract is can be used as a reference type

//any child class of Shape is also a Shape

 List<Shape> shapes = new List<Shape>();



 shapes.Add(new Square("s1", 2));

 shapes.Add(new Rectangle("r1", 2, 3));

 shapes.Add(new Circle("c1", 2));

 shapes.Add(new Triangle("t1", 4, 6));

 shapes.Add(new Ellipse("e1", 2, 3));

 shapes.Add(new Diamond("d1", 2, 3));



 shapes.Add(new Square("s2", 5));

 shapes.Add(new Rectangle("r2", 5, 4));

 shapes.Add(new Circle("c2", 1));

 shapes.Add(new Triangle("t2", 7, 8));



 foreach (var s in shapes)

 {

     Console.WriteLine(s);

 }


 #############################################################################################################################
 My output
 
 ![image](https://github.com/dyeyniyel/comp123-lab6-Inheritance-Shapes/assets/158533198/b71b43de-e462-48b5-a28b-9273d6c77207)



