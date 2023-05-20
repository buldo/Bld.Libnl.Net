namespace Bld.Libnl.Net.Nl80211.Enums;

public enum nl80211_if_combination_attrs {
	NL80211_IFACE_COMB_UNSPEC,
	NL80211_IFACE_COMB_LIMITS,
	NL80211_IFACE_COMB_MAXNUM,
	NL80211_IFACE_COMB_STA_AP_BI_MATCH,
	NL80211_IFACE_COMB_NUM_CHANNELS,
	NL80211_IFACE_COMB_RADAR_DETECT_WIDTHS,
	NL80211_IFACE_COMB_RADAR_DETECT_REGIONS,
	NL80211_IFACE_COMB_BI_MIN_GCD,

	/* keep last */
	NUM_NL80211_IFACE_COMB,
	MAX_NL80211_IFACE_COMB = NUM_NL80211_IFACE_COMB - 1
};