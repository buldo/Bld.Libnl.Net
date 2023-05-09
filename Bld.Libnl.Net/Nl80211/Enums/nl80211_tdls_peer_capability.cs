namespace Bld.Libnl.Net.Nl80211.Enums;

public enum nl80211_tdls_peer_capability {
	NL80211_TDLS_PEER_HT = 1<<0,
	NL80211_TDLS_PEER_VHT = 1<<1,
	NL80211_TDLS_PEER_WMM = 1<<2,
	NL80211_TDLS_PEER_HE = 1<<3,
};
