namespace Bld.Libnl.Net.Nl80211;

/// <summary>
/// Message returned as answer of NL80211_CMD_GET_WIPHY command
/// </summary>
/// <remarks>
/// Fields list is that I have on RTL8812AU
/// </remarks>
public class WiphyMessage
{
    /// <summary>
    /// NL80211_ATTR_WIPHY
    /// Id of phy
    /// </summary>
    public uint? Wiphy { get; set; }

    /// <summary>
    /// NL80211_ATTR_WIPHY_NAME
    /// </summary>
    public string? WiphyName { get; set; }

    /// <summary>
    /// NL80211_ATTR_WIPHY_BANDS
    /// </summary>
    public object? WIPHY_BANDS { get; set; }

    /// <summary>
    /// NL80211_ATTR_SUPPORTED_IFTYPES
    /// </summary>
    public object? SUPPORTED_IFTYPES { get; set; }

    /// <summary>
    /// NL80211_ATTR_MAX_NUM_SCAN_SSIDS
    /// </summary>
    public object? MAX_NUM_SCAN_SSIDS { get; set; }

    /// <summary>
    /// NL80211_ATTR_GENERATION
    /// </summary>
    public object? GENERATION { get; set; }

    /// <summary>
    /// NL80211_ATTR_SUPPORTED_COMMANDS
    /// </summary>
    public object? SUPPORTED_COMMANDS { get; set; }

    /// <summary>
    /// NL80211_ATTR_MAX_SCAN_IE_LEN
    /// </summary>
    public object? MAX_SCAN_IE_LEN { get; set; }

    /// <summary>
    /// NL80211_ATTR_CIPHER_SUITES
    /// </summary>
    public object? CIPHER_SUITES { get; set; }

    /// <summary>
    /// NL80211_ATTR_WIPHY_RETRY_SHORT
    /// </summary>
    public object? WIPHY_RETRY_SHORT { get; set; }

    /// <summary>
    /// NL80211_ATTR_WIPHY_RETRY_LONG
    /// </summary>
    public object? WIPHY_RETRY_LONG { get; set; }

    /// <summary>
    /// NL80211_ATTR_WIPHY_FRAG_THRESHOLD
    /// </summary>
    public object? WIPHY_FRAG_THRESHOLD { get; set; }

    /// <summary>
    /// NL80211_ATTR_WIPHY_RTS_THRESHOLD
    /// </summary>
    public object? WIPHY_RTS_THRESHOLD { get; set; }

    /// <summary>
    /// NL80211_ATTR_MAX_NUM_PMKIDS
    /// </summary>
    public object? MAX_NUM_PMKIDS { get; set; }

    /// <summary>
    /// NL80211_ATTR_WIPHY_COVERAGE_CLASS
    /// </summary>
    public object? WIPHY_COVERAGE_CLASS { get; set; }

    /// <summary>
    /// NL80211_ATTR_MAX_REMAIN_ON_CHANNEL_DURATION
    /// </summary>
    public object? MAX_REMAIN_ON_CHANNEL_DURATION { get; set; }

    /// <summary>
    /// NL80211_ATTR_WIPHY_ANTENNA_AVAIL_TX
    /// </summary>
    public object? WIPHY_ANTENNA_AVAIL_TX { get; set; }

    /// <summary>
    /// NL80211_ATTR_WIPHY_ANTENNA_AVAIL_RX
    /// </summary>
    public object? WIPHY_ANTENNA_AVAIL_RX { get; set; }

    /// <summary>
    /// NL80211_ATTR_WOWLAN_TRIGGERS_SUPPORTED
    /// </summary>
    public object? WOWLAN_TRIGGERS_SUPPORTED { get; set; }

    /// <summary>
    /// NL80211_ATTR_INTERFACE_COMBINATIONS
    /// </summary>
    public object? INTERFACE_COMBINATIONS { get; set; }

    /// <summary>
    /// NL80211_ATTR_SOFTWARE_IFTYPES
    /// </summary>
    public object? SOFTWARE_IFTYPES { get; set; }

    /// <summary>
    /// NL80211_ATTR_MAX_NUM_SCHED_SCAN_SSIDS
    /// </summary>
    public object? MAX_NUM_SCHED_SCAN_SSIDS { get; set; }

    /// <summary>
    /// NL80211_ATTR_MAX_SCHED_SCAN_IE_LEN
    /// </summary>
    public object? MAX_SCHED_SCAN_IE_LEN { get; set; }

    /// <summary>
    /// NL80211_ATTR_MAX_MATCH_SETS
    /// </summary>
    public object? MAX_MATCH_SETS { get; set; }

    /// <summary>
    /// NL80211_ATTR_DEVICE_AP_SME
    /// </summary>
    public object? DEVICE_AP_SME { get; set; }

    /// <summary>
    /// NL80211_ATTR_FEATURE_FLAGS
    /// </summary>
    public object? FEATURE_FLAGS { get; set; }

    /// <summary>
    /// NL80211_ATTR_MAC_ACL_MAX
    /// </summary>
    public object? MAC_ACL_MAX { get; set; }
}