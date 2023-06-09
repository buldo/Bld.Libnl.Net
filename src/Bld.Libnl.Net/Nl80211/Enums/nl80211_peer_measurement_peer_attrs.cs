namespace Bld.Libnl.Net.Nl80211.Enums;

public enum nl80211_peer_measurement_peer_attrs {
	__NL80211_PMSR_PEER_ATTR_INVALID,

	NL80211_PMSR_PEER_ATTR_ADDR,
	NL80211_PMSR_PEER_ATTR_CHAN,
	NL80211_PMSR_PEER_ATTR_REQ,
	NL80211_PMSR_PEER_ATTR_RESP,

	/* keep last */
	NUM_NL80211_PMSR_PEER_ATTRS,
	NL80211_PMSR_PEER_ATTR_MAX = NUM_NL80211_PMSR_PEER_ATTRS - 1,
};
