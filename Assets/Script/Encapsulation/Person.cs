using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person
{
    public int gender; // gender => 1 boy, geder => 2 women, gender => 3 Unknown

    private string _gender;

    public string Gender
    {
        get 
        {
            if (gender == 1)
            {
                return "(Mr.) " + _gender;
            }
            else if (gender == 2)
            {
                return "(Mrs.) " + _gender;
            }
            else
            {
                return "(None) " + _gender;
            }
            
        }
        set { _gender = value; }
    }
}
