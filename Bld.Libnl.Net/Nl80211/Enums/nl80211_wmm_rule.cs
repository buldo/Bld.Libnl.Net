namespace Bld.Libnl.Net.Nl80211.Enums;

public enum nl80211_wmm_rule {
	__NL80211_WMMR_INVALID,
	NL80211_WMMR_CW_MIN,
	NL80211_WMMR_CW_MAX,
	NL80211_WMMR_AIFSN,
	NL80211_WMMR_TXOP,

	/* keep last */
	__NL80211_WMMR_LAST,
	NL80211_WMMR_MAX = __NL80211_WMMR_LAST - 1
};
