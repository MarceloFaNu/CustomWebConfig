using System.Configuration;

namespace CustomWebConfig.Models.CustomConfiguration
{
    public class AlternativeSocialMediaElement : ConfigurationElement
    {
        [ConfigurationProperty("name", DefaultValue = "Localhost")]
        public string Name
        {
            get { return (string)this["name"]; }
            set { this["name"] = value; }
        }

        [ConfigurationProperty("value", DefaultValue = "http://127.0.0.1")]
        [RegexStringValidator(@"\w+:\/\/[\w.]+\S*")]
        public string Value
        {
            get { return (string)this["value"]; }
            set { this["value"] = value; }
        }

        [ConfigurationProperty("level", DefaultValue = 1)]
        [IntegerValidator(ExcludeRange = false, MinValue = 1, MaxValue = 10)]
        public int Level
        {
            get { return (int)this["level"]; }
            set { this["level"] = value; }
        }
    }
}