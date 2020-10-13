﻿namespace PlanningCore3.Utilities.Dtos
{
    public class TextValue
    {
        public TextValue(string text)
        {
            Text = text;
        }
        public TextValue(string text, string value)
        {
            Text = text;
            Value = value;
        }

        public string Text { get; set; }
        public string Value { get; set; }
    }
}
