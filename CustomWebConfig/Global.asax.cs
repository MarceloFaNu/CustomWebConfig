using CustomWebConfig.Models.CustomConfiguration;
using System;

namespace CustomWebConfig
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            UsefulUrls.SetAlternativeSocialMediaConfiguration();
        }
    }
}