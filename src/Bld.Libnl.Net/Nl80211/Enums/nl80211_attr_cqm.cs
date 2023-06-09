namespace Bld.Libnl.Net.Nl80211.Enums;

public enum nl80211_attr_cqm {
	__NL80211_ATTR_CQM_INVALID,
	NL80211_ATTR_CQM_RSSI_THOLD,
	NL80211_ATTR_CQM_RSSI_HYST,
	NL80211_ATTR_CQM_RSSI_THRESHOLD_EVENT,
	NL80211_ATTR_CQM_PKT_LOSS_EVENT,
	NL80211_ATTR_CQM_TXE_RATE,
	NL80211_ATTR_CQM_TXE_PKTS,
	NL80211_ATTR_CQM_TXE_INTVL,
	NL80211_ATTR_CQM_BEACON_LOSS_EVENT,
	NL80211_ATTR_CQM_RSSI_LEVEL,

	/* keep last */
	__NL80211_ATTR_CQM_AFTER_LAST,
	NL80211_ATTR_CQM_MAX = __NL80211_ATTR_CQM_AFTER_LAST - 1
};
