using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Encapsul : MonoBehaviour
{
    public TMP_InputField display;

    [SerializeField] TextMeshPro NameString;
    [SerializeField] int gendercount;
    [SerializeField] string _nickName;

    private void Update()
    {
        Person person = new Person();
        person.gender = gendercount;
        person.Gender = _nickName;
        NameString.text = person.Gender;
    }

    public void SetName()
    {
        _nickName = display.text;
    }
}
