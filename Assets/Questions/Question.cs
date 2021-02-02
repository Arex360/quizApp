using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Question", menuName = "Question", order = 1)]
public class Question : ScriptableObject
{
   public string question;
   public string option1;
   public string option2;
   public string option3;
   public string option4;
   public Options.Option correct;
   
    
}
