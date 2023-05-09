namespace Bld.Libnl.Net.Nl80211.Enums;

public enum nl80211_ext_feature_index {
	NL80211_EXT_FEATURE_VHT_IBSS,
	NL80211_EXT_FEATURE_RRM,
	NL80211_EXT_FEATURE_MU_MIMO_AIR_SNIFFER,
	NL80211_EXT_FEATURE_SCAN_START_TIME,
	NL80211_EXT_FEATURE_BSS_PARENT_TSF,
	NL80211_EXT_FEATURE_SET_SCAN_DWELL,
	NL80211_EXT_FEATURE_BEACON_RATE_LEGACY,
	NL80211_EXT_FEATURE_BEACON_RATE_HT,
	NL80211_EXT_FEATURE_BEACON_RATE_VHT,
	NL80211_EXT_FEATURE_FILS_STA,
	NL80211_EXT_FEATURE_MGMT_TX_RANDOM_TA,
	NL80211_EXT_FEATURE_MGMT_TX_RANDOM_TA_CONNECTED,
	NL80211_EXT_FEATURE_SCHED_SCAN_RELATIVE_RSSI,
	NL80211_EXT_FEATURE_CQM_RSSI_LIST,
	NL80211_EXT_FEATURE_FILS_SK_OFFLOAD,
	NL80211_EXT_FEATURE_4WAY_HANDSHAKE_STA_PSK,
	NL80211_EXT_FEATURE_4WAY_HANDSHAKE_STA_1X,
	NL80211_EXT_FEATURE_FILS_MAX_CHANNEL_TIME,
	NL80211_EXT_FEATURE_ACCEPT_BCAST_PROBE_RESP,
	NL80211_EXT_FEATURE_OCE_PROBE_REQ_HIGH_TX_RATE,
	NL80211_EXT_FEATURE_OCE_PROBE_REQ_DEFERRAL_SUPPRESSION,
	NL80211_EXT_FEATURE_MFP_OPTIONAL,
	NL80211_EXT_FEATURE_LOW_SPAN_SCAN,
	NL80211_EXT_FEATURE_LOW_POWER_SCAN,
	NL80211_EXT_FEATURE_HIGH_ACCURACY_SCAN,
	NL80211_EXT_FEATURE_DFS_OFFLOAD,
	NL80211_EXT_FEATURE_CONTROL_PORT_OVER_NL80211,
	NL80211_EXT_FEATURE_ACK_SIGNAL_SUPPORT,
	/* we renamed this - stay compatible */
	NL80211_EXT_FEATURE_DATA_ACK_SIGNAL_SUPPORT = NL80211_EXT_FEATURE_ACK_SIGNAL_SUPPORT,
	NL80211_EXT_FEATURE_TXQS,
	NL80211_EXT_FEATURE_SCAN_RANDOM_SN,
	NL80211_EXT_FEATURE_SCAN_MIN_PREQ_CONTENT,
	NL80211_EXT_FEATURE_CAN_REPLACE_PTK0,
	NL80211_EXT_FEATURE_ENABLE_FTM_RESPONDER,
	NL80211_EXT_FEATURE_AIRTIME_FAIRNESS,
	NL80211_EXT_FEATURE_AP_PMKSA_CACHING,
	NL80211_EXT_FEATURE_SCHED_SCAN_BAND_SPECIFIC_RSSI_THOLD,
	NL80211_EXT_FEATURE_EXT_KEY_ID,
	NL80211_EXT_FEATURE_STA_TX_PWR,
	NL80211_EXT_FEATURE_SAE_OFFLOAD,
	NL80211_EXT_FEATURE_VLAN_OFFLOAD,
	NL80211_EXT_FEATURE_AQL,
	NL80211_EXT_FEATURE_BEACON_PROTECTION,
	NL80211_EXT_FEATURE_CONTROL_PORT_NO_PREAUTH,
	NL80211_EXT_FEATURE_PROTECTED_TWT,
	NL80211_EXT_FEATURE_DEL_IBSS_STA,
	NL80211_EXT_FEATURE_MULTICAST_REGISTRATIONS,
	NL80211_EXT_FEATURE_BEACON_PROTECTION_CLIENT,
	NL80211_EXT_FEATURE_SCAN_FREQ_KHZ,
	NL80211_EXT_FEATURE_CONTROL_PORT_OVER_NL80211_TX_STATUS,
	NL80211_EXT_FEATURE_OPERATING_CHANNEL_VALIDATION,
	NL80211_EXT_FEATURE_4WAY_HANDSHAKE_AP_PSK,
	NL80211_EXT_FEATURE_SAE_OFFLOAD_AP,
	NL80211_EXT_FEATURE_FILS_DISCOVERY,
	NL80211_EXT_FEATURE_UNSOL_BCAST_PROBE_RESP,
	NL80211_EXT_FEATURE_BEACON_RATE_HE,
	NL80211_EXT_FEATURE_SECURE_LTF,
	NL80211_EXT_FEATURE_SECURE_RTT,
	NL80211_EXT_FEATURE_PROT_RANGE_NEGO_AND_MEASURE,
	NL80211_EXT_FEATURE_BSS_COLOR,
	NL80211_EXT_FEATURE_FILS_CRYPTO_OFFLOAD,
	NL80211_EXT_FEATURE_RADAR_BACKGROUND,
	NL80211_EXT_FEATURE_POWERED_ADDR_CHANGE,
	NL80211_EXT_FEATURE_PUNCT,
	NL80211_EXT_FEATURE_SECURE_NAN,

	/* add new features before the definition below */
	NUM_NL80211_EXT_FEATURES,
	MAX_NL80211_EXT_FEATURES = NUM_NL80211_EXT_FEATURES - 1
};