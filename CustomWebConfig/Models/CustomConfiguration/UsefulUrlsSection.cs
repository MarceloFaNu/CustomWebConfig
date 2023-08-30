using System.Configuration;

namespace CustomWebConfig.Models.CustomConfiguration
{
    // Extend the ConfigurationSection class.  Your class
    // name should match your section name and be postfixed with "Section"
    public class UsefulUrlsSection : ConfigurationSection
    {
        //Decorate the property with the XML tag for your collection
        [ConfigurationProperty("alternativeSocialMedia")]
        public AlternativeSocialMediaElementCollection AlternativeSocialMedia
        {
            get { return (AlternativeSocialMediaElementCollection)this["alternativeSocialMedia"]; }
        }
    }
}