namespace Bld.Libnl.Net.Nl80211.Enums;

public enum nl80211_tx_rate_attributes {
	__NL80211_TXRATE_INVALID,
	NL80211_TXRATE_LEGACY,
	NL80211_TXRATE_HT,
	NL80211_TXRATE_VHT,
	NL80211_TXRATE_GI,
	NL80211_TXRATE_HE,
	NL80211_TXRATE_HE_GI,
	NL80211_TXRATE_HE_LTF,

	/* keep last */
	__NL80211_TXRATE_AFTER_LAST,
	NL80211_TXRATE_MAX = __NL80211_TXRATE_AFTER_LAST - 1
};
