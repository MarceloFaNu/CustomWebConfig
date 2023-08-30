using System.Configuration;
using System.Reflection;

namespace CustomWebConfig.Models.CustomConfiguration
{
    public static class UsefulUrls
    {
        public static AlternativeSocialMedia AlternativeSocialMediaConfigurationObject { get; private set; }

        private static UsefulUrlsSection _usefullUrlsSection = ConfigurationManager.GetSection("usefulUrls") as UsefulUrlsSection;

        public static void SetAlternativeSocialMediaConfiguration()
        {
            var alternativeSocialMedia = _usefullUrlsSection.AlternativeSocialMedia;

            if (AlternativeSocialMediaConfigurationObject == null)
            {
                AlternativeSocialMediaConfigurationObject = new AlternativeSocialMedia();

                for (int i = 0; i < alternativeSocialMedia.Count; i++)
                {
                    PropertyInfo alternativeSocialMediaCurrentProperty = AlternativeSocialMediaConfigurationObject
                        .GetType().GetProperty(alternativeSocialMedia[i].Name);

                    if (alternativeSocialMediaCurrentProperty != null)
                    {
                        var alternativeSocialMediaCurrentObject = new CustomConfigBasicNode(
                            alternativeSocialMedia[i].Name,
                            alternativeSocialMedia[i].Value,
                            alternativeSocialMedia[i].Level);

                        alternativeSocialMediaCurrentProperty
                            .SetValue(AlternativeSocialMediaConfigurationObject, alternativeSocialMediaCurrentObject, null);
                    }
                }
            }
        }
    }
}