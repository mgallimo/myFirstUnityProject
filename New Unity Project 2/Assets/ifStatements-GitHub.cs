using UnityEngine;
using System.Collections;

public class ifStatements : MonoBehaviour {
	private int Awake = 10;
	private int Asleep = 3;
	private int Middle = 5;
	private float A = 3.0f;
	private bool open = false;
	private string name = "Eyes";

	/* And here I will write my understanding of the topic.
	 
	  Today we learned about If Statements and Relational Operators. 
	  If Statements allow you to control your code by deciding on its output.
	  Relational Operators work along side If Statements by making said statements true or false.
	  They and are as follows:
	  
	  Equal To (==) - Output that shows when both variables are equal.
	  For Example:
	  
	  	Int A = 10;
	  	Int B = 4;
	  		If (A == B)
	  		{
	  		Print ("A is equal to B");
	  		}
	  		
	  Not equal to (!=) - Output that shows when both variables are not equal.
	  For Example:
	  
	  		If (A != B)
	  		{
	  		Print ("A is NOT equal to B");
	  		}
	  		
	  Greater than (>) - Output that shows when the first variable entered is greater than the second variable entered.
	  For Example:
	  
	  		If (A > B)
	  		{
	  		Print ("A is greater than B");
	  		}
	  		
	  Less than (<) - Output that shows when the first variable entered is less than the second variable entered.
	  For Example:
	  
	  		If (A < B)
	  		{
	  		Print ("A is less than B");
	  		}
	  		
	  Greater than/Equal to (>=) - Output that shows when the first variable entered is greater than and/or equal to the second variable entered.
	  For Example:
	  
	  	  	If (A >= B)
	  		{
	  		Print ("A is greater than/equal to B");
	  		}
	  		
	  Less than/Equal to (<=) - Output that shows when the first variable entered is less than and/or equal to the second variable entered.
	  For Example:
	  
	  	  	If (A <= B)
	  		{
	  		Print ("A is less than/equal to B");
	  		}

	You can also use the && for an If Statement that was two Relational Operators.
	For example:
	
		Int C = 2;
			If (A < B && B < C)
			{
			Print ("A is less than B, which is less than C");
			}

	 */

	// Use this for initialization
	void Start () {
		if (Awake == Asleep) 
		{
			print ("Well aren't you the multitasker of the year?");
		}
		if (Awake != Asleep) 
		{
			print ("Hello?");
		}
		if (Awake < Asleep) 
		{
			print ("Wake up!");
		}
		if (Awake > Asleep) 
		{
			print ("Go to sleep!");
		}
		if (Awake <= Asleep) 
		{
			print ("I SAID WAKE UP!");
		}
		if (Awake >= Asleep) 
		{
			print ("GO TO SLEEP ALREADY!");
		}
		if (Awake > Middle && Middle > Asleep)
		{
			print ("You have an appointment early tomorrow morning!");
		}
		if (Awake < Middle && Middle < Asleep) 
		{
			print ("You have an appointment to go to this morning!");
		}
		if (Awake < Middle && Middle > Asleep) 
		{
			print ("Two against one isn't fair!");
		}
		if (Awake > Middle && Middle < Asleep) 
		{
			print ("How DID you come across this error?");
		}
	}
}
