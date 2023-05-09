namespace Bld.Libnl.Net.Nl80211.Enums;

public enum nl80211_wowlan_triggers {
	__NL80211_WOWLAN_TRIG_INVALID,
	NL80211_WOWLAN_TRIG_ANY,
	NL80211_WOWLAN_TRIG_DISCONNECT,
	NL80211_WOWLAN_TRIG_MAGIC_PKT,
	NL80211_WOWLAN_TRIG_PKT_PATTERN,
	NL80211_WOWLAN_TRIG_GTK_REKEY_SUPPORTED,
	NL80211_WOWLAN_TRIG_GTK_REKEY_FAILURE,
	NL80211_WOWLAN_TRIG_EAP_IDENT_REQUEST,
	NL80211_WOWLAN_TRIG_4WAY_HANDSHAKE,
	NL80211_WOWLAN_TRIG_RFKILL_RELEASE,
	NL80211_WOWLAN_TRIG_WAKEUP_PKT_80211,
	NL80211_WOWLAN_TRIG_WAKEUP_PKT_80211_LEN,
	NL80211_WOWLAN_TRIG_WAKEUP_PKT_8023,
	NL80211_WOWLAN_TRIG_WAKEUP_PKT_8023_LEN,
	NL80211_WOWLAN_TRIG_TCP_CONNECTION,
	NL80211_WOWLAN_TRIG_WAKEUP_TCP_MATCH,
	NL80211_WOWLAN_TRIG_WAKEUP_TCP_CONNLOST,
	NL80211_WOWLAN_TRIG_WAKEUP_TCP_NOMORETOKENS,
	NL80211_WOWLAN_TRIG_NET_DETECT,
	NL80211_WOWLAN_TRIG_NET_DETECT_RESULTS,

	/* keep last */
	NUM_NL80211_WOWLAN_TRIG,
	MAX_NL80211_WOWLAN_TRIG = NUM_NL80211_WOWLAN_TRIG - 1
};
