namespace Bld.Libnl.Net.Nl80211.Enums;

public enum nl80211_iface_limit_attrs {
	NL80211_IFACE_LIMIT_UNSPEC,
	NL80211_IFACE_LIMIT_MAX,
	NL80211_IFACE_LIMIT_TYPES,

	/* keep last */
	NUM_NL80211_IFACE_LIMIT,
	MAX_NL80211_IFACE_LIMIT = NUM_NL80211_IFACE_LIMIT - 1
};
