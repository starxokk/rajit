using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SampleNameSpace
{
    public class SimpleScript : MonoBehaviour

    {
        private string username;
        public string userName
        {
            get { return username; }
            set
            {
                var s = "";
                foreach (var c in value)
                {
                    if (char.IsUpper(c))
                        s += char.ToLower(c);
                    else if (char.IsLetter(c) || char.IsDigit(c))
                        s += c;
                    else
                        Debug.LogError("Username Not Accepted special character");
                    
                }
                username = s;if 
            }

        }
        private void OnGUI()
        {
            GUI.Label(new Rect(10,100,100,50),username);
        }

    }

}