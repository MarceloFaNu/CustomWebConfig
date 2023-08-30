using CustomWebConfig.Models.CustomConfiguration;
using System;

namespace CustomWebConfig
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Label7.Text = UsefulUrls.AlternativeSocialMediaConfigurationObject.IConnectFx.Name;
            this.Label8.Text = UsefulUrls.AlternativeSocialMediaConfigurationObject.IConnectFx.Value;
            this.Label9.Text = UsefulUrls.AlternativeSocialMediaConfigurationObject.IConnectFx.Level.ToString();

            this.Label10.Text = UsefulUrls.AlternativeSocialMediaConfigurationObject.DTube.Name;
            this.Label11.Text = UsefulUrls.AlternativeSocialMediaConfigurationObject.DTube.Value;
            this.Label12.Text = UsefulUrls.AlternativeSocialMediaConfigurationObject.DTube.Level.ToString();

            this.Label13.Text = UsefulUrls.AlternativeSocialMediaConfigurationObject.Gab.Name;
            this.Label14.Text = UsefulUrls.AlternativeSocialMediaConfigurationObject.Gab.Value;
            this.Label15.Text = UsefulUrls.AlternativeSocialMediaConfigurationObject.Gab.Level.ToString();

            this.Label16.Text = UsefulUrls.AlternativeSocialMediaConfigurationObject.Rumble.Name;
            this.Label17.Text = UsefulUrls.AlternativeSocialMediaConfigurationObject.Rumble.Value;
            this.Label18.Text = UsefulUrls.AlternativeSocialMediaConfigurationObject.Rumble.Level.ToString();
        }
    }
}