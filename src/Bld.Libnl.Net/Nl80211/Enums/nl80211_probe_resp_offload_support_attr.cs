namespace Bld.Libnl.Net.Nl80211.Enums;

public enum nl80211_probe_resp_offload_support_attr {
	NL80211_PROBE_RESP_OFFLOAD_SUPPORT_WPS =	1<<0,
	NL80211_PROBE_RESP_OFFLOAD_SUPPORT_WPS2 =	1<<1,
	NL80211_PROBE_RESP_OFFLOAD_SUPPORT_P2P =	1<<2,
	NL80211_PROBE_RESP_OFFLOAD_SUPPORT_80211U =	1<<3,
};
