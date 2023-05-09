namespace Bld.Libnl.Net.Nl80211.Enums;

public enum nl80211_peer_measurement_attrs {
	__NL80211_PMSR_ATTR_INVALID,

	NL80211_PMSR_ATTR_MAX_PEERS,
	NL80211_PMSR_ATTR_REPORT_AP_TSF,
	NL80211_PMSR_ATTR_RANDOMIZE_MAC_ADDR,
	NL80211_PMSR_ATTR_TYPE_CAPA,
	NL80211_PMSR_ATTR_PEERS,

	/* keep last */
	NUM_NL80211_PMSR_ATTR,
	NL80211_PMSR_ATTR_MAX = NUM_NL80211_PMSR_ATTR - 1
};
