namespace Bld.Libnl.Net.Nl80211.Enums;

public enum nl80211_frequency_attr {
	__NL80211_FREQUENCY_ATTR_INVALID,
	NL80211_FREQUENCY_ATTR_FREQ,
	NL80211_FREQUENCY_ATTR_DISABLED,
	NL80211_FREQUENCY_ATTR_NO_IR,
	__NL80211_FREQUENCY_ATTR_NO_IBSS,
	NL80211_FREQUENCY_ATTR_RADAR,
	NL80211_FREQUENCY_ATTR_MAX_TX_POWER,
	NL80211_FREQUENCY_ATTR_DFS_STATE,
	NL80211_FREQUENCY_ATTR_DFS_TIME,
	NL80211_FREQUENCY_ATTR_NO_HT40_MINUS,
	NL80211_FREQUENCY_ATTR_NO_HT40_PLUS,
	NL80211_FREQUENCY_ATTR_NO_80MHZ,
	NL80211_FREQUENCY_ATTR_NO_160MHZ,
	NL80211_FREQUENCY_ATTR_DFS_CAC_TIME,
	NL80211_FREQUENCY_ATTR_INDOOR_ONLY,
	NL80211_FREQUENCY_ATTR_IR_CONCURRENT,
	NL80211_FREQUENCY_ATTR_NO_20MHZ,
	NL80211_FREQUENCY_ATTR_NO_10MHZ,
	NL80211_FREQUENCY_ATTR_WMM,
	NL80211_FREQUENCY_ATTR_NO_HE,
	NL80211_FREQUENCY_ATTR_OFFSET,
	NL80211_FREQUENCY_ATTR_1MHZ,
	NL80211_FREQUENCY_ATTR_2MHZ,
	NL80211_FREQUENCY_ATTR_4MHZ,
	NL80211_FREQUENCY_ATTR_8MHZ,
	NL80211_FREQUENCY_ATTR_16MHZ,
	NL80211_FREQUENCY_ATTR_NO_320MHZ,
	NL80211_FREQUENCY_ATTR_NO_EHT,

	/* keep last */
	__NL80211_FREQUENCY_ATTR_AFTER_LAST,
	NL80211_FREQUENCY_ATTR_MAX = __NL80211_FREQUENCY_ATTR_AFTER_LAST - 1
};