using System;
using System.Collections.Generic;
using System.Text;

namespace Level1
{
    public class ParseException : Exception
    {
        public List<string> Lines { get; set; }

        public ParseException(string text, string line)
        {
            Text = text;
            Lines = new List<string>();
            Lines.Add(line);
        }
        public ParseException(string text, List<string> lines)
        {
            Text = text;
            Lines = lines;
        }

        public string Text { get; set; }

        public override string ToString()
        {
            var sb  =new StringBuilder();
            sb.Append(Text);
            foreach (var line in Lines)
            {
                sb.AppendLine("\t" + line);
            }
            return sb.ToString();
        }
    }
}