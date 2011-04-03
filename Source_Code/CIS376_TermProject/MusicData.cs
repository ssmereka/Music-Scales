using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CIS376_TermProject
{
    class MusicData
    {//Class allows user to define or lookup application relavent data.

        public ArrayList getMajorRoots()
        {//Post:  Returns ArrayList of possible major root notes
            ArrayList list = new ArrayList();
            list.Add("C");
            list.Add("F");
            list.Add("B" + getFlat());
            list.Add("E" + getFlat());
            list.Add("A" + getFlat());
            list.Add("D" + getFlat());
            list.Add("G" + getFlat());
            list.Add("B");
            list.Add("E");
            list.Add("A");
            list.Add("D");
            list.Add("G");
            return list;
        }

        public ArrayList getMinorRoots()
        {//Post:  Returns ArrayList of possible minor root notes
            ArrayList list = new ArrayList();
            list.Add("A");
            list.Add("D");
            list.Add("G");
            list.Add("C");
            list.Add("F");
            list.Add("B" + getFlat());
            list.Add("E" + getFlat());
            list.Add("G" + getSharp());
            list.Add("C" + getSharp());
            list.Add("F" + getSharp());
            list.Add("B");
            list.Add("E");
            return list;
        }

        public string getFlat()     {  return "♭";    }  //Get Flat returns flat string value
        public string getSharp()    {  return "♯";     }  //Get Sharp returns sharp string value
        public string getNatural()  {  return "♮";    }  //Get Natural returns natural string value 
        public string getST_Major() {  return "Major"; }  //Get Scale Type Major returns major string value
        public string getST_Minor() {  return "Minor"; }  //Get Scale Type Minor returns minor string value
    }
}
