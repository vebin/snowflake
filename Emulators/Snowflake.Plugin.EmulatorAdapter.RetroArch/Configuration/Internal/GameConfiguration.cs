using Snowflake.Configuration;
using Snowflake.Configuration.Attributes;

//autogenerated using generate_retroarch.py
namespace Snowflake.Plugin.EmulatorAdapter.RetroArch.Configuration.Internal
{
    public class GameConfiguration : ConfigurationSection
    {
        [ConfigurationOption("game_specific_options", DisplayName = "Game Specific Options", Private = true)]
        public bool GameSpecificOptions { get; set; } = false;

        [ConfigurationOption("bps_pref", DisplayName = "Prefer BPS Patching", Private = true)]
        public bool BpsPref { get; set; } = false;

        [ConfigurationOption("ips_pref", DisplayName = "Prefer IPS Patching", Private = true)]
        public bool IpsPref { get; set; } = false;

        [ConfigurationOption("ups_pref", DisplayName = "Prefer UPS Patching", Private = true)]
        public bool UpsPref { get; set; } = false;


        public GameConfiguration() : base("game", "Game Options")
        {

        }

    }
}
