namespace Bld.Libnl.Net.Nl80211.Enums;

public enum nl80211_crit_proto_id {
	NL80211_CRIT_PROTO_UNSPEC,
	NL80211_CRIT_PROTO_DHCP,
	NL80211_CRIT_PROTO_EAPOL,
	NL80211_CRIT_PROTO_APIPA,
	/* add other protocols before this one */
	NUM_NL80211_CRIT_PROTO
};
