using Snowflake.Configuration;
using Snowflake.Configuration.Attributes;

//autogenerated using generate_retroarch.py
namespace Snowflake.Plugin.EmulatorAdapter.RetroArch.Configuration.Internal
{
    /// <summary>
    /// Menu is completely disabled.
    /// </summary>
    public class XmbConfiguration : ConfigurationSection
    {
        [ConfigurationOption("xmb_alpha_factor", DisplayName = "Xmb Alpha Factor", Private = true)]
        public int XmbAlphaFactor { get; set; } = 75;
        [ConfigurationOption("xmb_font", DisplayName = "Xmb Font", Private = true)]
        public string XmbFont { get; set; } = "";
        [ConfigurationOption("xmb_scale_factor", DisplayName = "Xmb Scale Factor", Private = true)]
        public int XmbScaleFactor { get; set; } = 100;
        [ConfigurationOption("xmb_shadows", DisplayName = "Xmb Shadows", Private = true)]
        public bool XmbShadows { get; set; } = false;
        //unknown how xmb theme works.
        [ConfigurationOption("xmb_theme", DisplayName = "Xmb Theme", Private = true)]
        public int XmbTheme { get; set; } = 0;

        public XmbConfiguration() : base("xmb", "Xmb Options")
        {

        }

    }
}
