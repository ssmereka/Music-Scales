using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CIS376_TermProject
{
    class Scale
    {
        public ArrayList getScale(String root, String type)
        {
            ArrayList scale = new ArrayList();

            char scaleType = ' ';         // natural, flat or sharp based scale
            char[] scaleForm;       // The form of the scale or how it is constructed based
            // in wholesteps 'W' or halfsteps 'H'

            if (string.Compare(type, "major", true) == 0)   // If major scale
            {
                scaleForm = new char[] { 'W', 'W', 'H', 'W', 'W', 'W', 'H' };

                switch (root)
                {
                    case "C": scaleType = ' ';
                        break;
                    case "F": scaleType = '♭';
                        break;
                    case "B♭": scaleType = '♭';
                        break;
                    case "E♭": scaleType = '♭';
                        break;
                    case "A♭": scaleType = '♭';
                        break;
                    case "D♭": scaleType = '♭';
                        break;
                    case "G♭": scaleType = '♭';
                        break;
                    case "B": scaleType = '♯';
                        break;
                    case "E": scaleType = '♯';
                        break;
                    case "A": scaleType = '♯';
                        break;
                    case "D": scaleType = '♯';
                        break;
                    case "G": scaleType = '♯';
                        break;
                }
            }
            else if (string.Compare(type, "minor", true) == 0)      // if minor scale
            {
                scaleForm = new char[] { 'W', 'H', 'W', 'W', 'H', 'W', 'W' };

                switch (root)
                {
                    case "A": scaleType = ' ';
                        break;
                    case "D": scaleType = '♭';
                        break;
                    case "G": scaleType = '♭';
                        break;
                    case "C": scaleType = '♭';
                        break;
                    case "F": scaleType = '♭';
                        break;
                    case "B♭": scaleType = '♭';
                        break;
                    case "E♭": scaleType = '♭';
                        break;
                    case "G♯": scaleType = '♯';
                        break;
                    case "C♯": scaleType = '♯';
                        break;
                    case "F♯": scaleType = '♯';
                        break;
                    case "B": scaleType = '♯';
                        break;
                    case "E": scaleType = '♯';
                        break;
                }
            }
            else // error condition
            {
                scale.Add("Invalid Scale Type");
                return scale;
            }


            // Building the scale

            bool special = false;   // special condition for the note Cb in the Eb minor scale and Gb major scale

            if (root == "E♭" || root == "G♭")
                special = true;

            scale.Add(root);

            for (int i = 0; i < scaleForm.Length; i++)
            {
                if (scaleForm[i] == 'W')
                    root = getWholeStep(root, scaleType);
                else
                    root = getHalfStep(root, scaleType);

                if (i < scaleForm.Length - 1)  // Does not add the last note to scale ie the octave
                {
                    if (root == "B" && special) // special case where B = Cb
                        scale.Add("C♭");
                    else 
                        scale.Add(root);
                }
            }

            return scale;
        }

        public string getHalfStep(string note, char scaleType)
        { // getHalfStep returns the half step from note

            string[] musicNotes;        // array of all music notes
            int i;                      // index of note


            if (scaleType == '♭')
                musicNotes = new string[] { "A", "B♭", "B", "C", "D♭", "D", "E♭", "E", "F", "G♭", "G", "A♭" };      // all music notes with flats
            else
                musicNotes = new string[] { "A", "A♯", "B", "C", "C♯", "D", "D♯", "E", "F", "F♯", "G", "G♯" };           // all music notes with sharps

            for (i = 0; i < musicNotes.Length; i++) // finding index of note
                if (musicNotes[i] == note) break;

            i++;    // moving a half step
            if (i >= musicNotes.Length)
                return musicNotes[i - musicNotes.Length];    // circling around in array
            else
                return musicNotes[i];
        }

        public string getWholeStep(string note, char scaleType)
        { // getWholeStep returns the whole step from note

            string[] musicNotes;        // array of all music notes
            int i;                      // index of note


            if (scaleType == '♭')
                musicNotes = new string[] { "A", "B♭", "B", "C", "D♭", "D", "E♭", "E", "F", "G♭", "G", "A♭" };      // all music notes with flats
            else
                musicNotes = new string[] { "A", "A♯", "B", "C", "C♯", "D", "D♯", "E", "F", "F♯", "G", "G♯" };           // all music notes with sharps

            for (i = 0; i < musicNotes.Length; i++) // finding index of note
                if (musicNotes[i] == note) break;

            i += 2;    // moving a half step
            if (i >= musicNotes.Length)
                return musicNotes[i - musicNotes.Length];    // circling around in array
            else
                return musicNotes[i];
        }
    }
}
