namespace Bld.Libnl.Net.Nl80211.Enums;

public enum nl80211_nan_srf_attributes {
	__NL80211_NAN_SRF_INVALID,
	NL80211_NAN_SRF_INCLUDE,
	NL80211_NAN_SRF_BF,
	NL80211_NAN_SRF_BF_IDX,
	NL80211_NAN_SRF_MAC_ADDRS,

	/* keep last */
	NUM_NL80211_NAN_SRF_ATTR,
	NL80211_NAN_SRF_ATTR_MAX = NUM_NL80211_NAN_SRF_ATTR - 1,
};
