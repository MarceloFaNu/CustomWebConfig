using System;

namespace CustomWebConfig.Models.CustomConfiguration
{
    public class CustomConfigBasicNode
    {
        public string Name  { get; private set; }
        public string Value { get; private set; }
        public int Level    { get; private set; }

        public CustomConfigBasicNode(string name, string value, int level)
        {
            Name = name;
            Value = value;
            Level = level;
        }
    }
}