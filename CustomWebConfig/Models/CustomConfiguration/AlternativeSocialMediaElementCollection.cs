using System.Configuration;

namespace CustomWebConfig.Models.CustomConfiguration
{
    [ConfigurationCollection(typeof(AlternativeSocialMediaElement))]
    public class AlternativeSocialMediaElementCollection : ConfigurationElementCollection
    {
        public AlternativeSocialMediaElement this[int index]
        {
            get
            {
                return (AlternativeSocialMediaElement)BaseGet(index);
            }
            set
            {
                if (BaseGet(index) != null)
                    BaseRemoveAt(index);

                BaseAdd(index, value);
            }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new AlternativeSocialMediaElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((AlternativeSocialMediaElement)element).Name;
        }
    }
}