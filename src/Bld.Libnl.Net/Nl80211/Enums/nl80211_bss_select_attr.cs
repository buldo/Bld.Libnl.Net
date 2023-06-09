namespace Bld.Libnl.Net.Nl80211.Enums;

public enum nl80211_bss_select_attr {
	__NL80211_BSS_SELECT_ATTR_INVALID,
	NL80211_BSS_SELECT_ATTR_RSSI,
	NL80211_BSS_SELECT_ATTR_BAND_PREF,
	NL80211_BSS_SELECT_ATTR_RSSI_ADJUST,

	/* keep last */
	__NL80211_BSS_SELECT_ATTR_AFTER_LAST,
	NL80211_BSS_SELECT_ATTR_MAX = __NL80211_BSS_SELECT_ATTR_AFTER_LAST - 1
};
