using UnityEngine;
using System.Collections;

public class variablesAndOperators : MonoBehaviour {
	private float pi = 3.1415f;
	private float radius = 3.536235f;
	private float length = 1;
	private float width = 1;
	private float base = 1;
	private float height = 1;

	// Use this for initialization
	void Start () {
		//Find the diameter of a circle
		float diameter = 2 * radius;
		print ("The diameter of the circle with radius " + radius + " is " + diameter);

		//Find the circumference of a circle
		float circumference = 2 * pi * radius;
		print ("The circumference of the circle with radius " + radius + " is " + diameter);

		//Find the area of a circle
		float area = pi * radius
		print ("The area of the circle with radius " + radius + " is " + diameter);

		//Find the perimeter of a rectangle
		float perimeter = 2 * (length + width);
		print ("The perimeter of the rectangle with length " + length + " and width " + width " is " perimeter);

		//Find the area of a rectangle
		float area = length * width
		print ("The area of the rectangle with length " + length + " and width " + width " is " area);

		//Find the area of a triangle
		float area = (height * base) / 2
		print ("The area of the triangle with base " + base + " and height " + height + " is " + area);
	}
}
