namespace Bld.Libnl.Net.Nl80211.Enums;

public enum nl80211_attrs {
/* don't change the order or add anything between, this is ABI! */
	NL80211_ATTR_UNSPEC,

	NL80211_ATTR_WIPHY,
	NL80211_ATTR_WIPHY_NAME,

	NL80211_ATTR_IFINDEX,
	NL80211_ATTR_IFNAME,
	NL80211_ATTR_IFTYPE,

	NL80211_ATTR_MAC,

	NL80211_ATTR_KEY_DATA,
	NL80211_ATTR_KEY_IDX,
	NL80211_ATTR_KEY_CIPHER,
	NL80211_ATTR_KEY_SEQ,
	NL80211_ATTR_KEY_DEFAULT,

	NL80211_ATTR_BEACON_INTERVAL,
	NL80211_ATTR_DTIM_PERIOD,
	NL80211_ATTR_BEACON_HEAD,
	NL80211_ATTR_BEACON_TAIL,

	NL80211_ATTR_STA_AID,
	NL80211_ATTR_STA_FLAGS,
	NL80211_ATTR_STA_LISTEN_INTERVAL,
	NL80211_ATTR_STA_SUPPORTED_RATES,
	NL80211_ATTR_STA_VLAN,
	NL80211_ATTR_STA_INFO,

	NL80211_ATTR_WIPHY_BANDS,

	NL80211_ATTR_MNTR_FLAGS,

	NL80211_ATTR_MESH_ID,
	NL80211_ATTR_STA_PLINK_ACTION,
	NL80211_ATTR_MPATH_NEXT_HOP,
	NL80211_ATTR_MPATH_INFO,

	NL80211_ATTR_BSS_CTS_PROT,
	NL80211_ATTR_BSS_SHORT_PREAMBLE,
	NL80211_ATTR_BSS_SHORT_SLOT_TIME,

	NL80211_ATTR_HT_CAPABILITY,

	NL80211_ATTR_SUPPORTED_IFTYPES,

	NL80211_ATTR_REG_ALPHA2,
	NL80211_ATTR_REG_RULES,

	NL80211_ATTR_MESH_CONFIG,

	NL80211_ATTR_BSS_BASIC_RATES,

	NL80211_ATTR_WIPHY_TXQ_PARAMS,
	NL80211_ATTR_WIPHY_FREQ,
	NL80211_ATTR_WIPHY_CHANNEL_TYPE,

	NL80211_ATTR_KEY_DEFAULT_MGMT,

	NL80211_ATTR_MGMT_SUBTYPE,
	NL80211_ATTR_IE,

	NL80211_ATTR_MAX_NUM_SCAN_SSIDS,

	NL80211_ATTR_SCAN_FREQUENCIES,
	NL80211_ATTR_SCAN_SSIDS,
	NL80211_ATTR_GENERATION, /* replaces old SCAN_GENERATION */
	NL80211_ATTR_BSS,

	NL80211_ATTR_REG_INITIATOR,
	NL80211_ATTR_REG_TYPE,

	NL80211_ATTR_SUPPORTED_COMMANDS,

	NL80211_ATTR_FRAME,
	NL80211_ATTR_SSID,
	NL80211_ATTR_AUTH_TYPE,
	NL80211_ATTR_REASON_CODE,

	NL80211_ATTR_KEY_TYPE,

	NL80211_ATTR_MAX_SCAN_IE_LEN,
	NL80211_ATTR_CIPHER_SUITES,

	NL80211_ATTR_FREQ_BEFORE,
	NL80211_ATTR_FREQ_AFTER,

	NL80211_ATTR_FREQ_FIXED,


	NL80211_ATTR_WIPHY_RETRY_SHORT,
	NL80211_ATTR_WIPHY_RETRY_LONG,
	NL80211_ATTR_WIPHY_FRAG_THRESHOLD,
	NL80211_ATTR_WIPHY_RTS_THRESHOLD,

	NL80211_ATTR_TIMED_OUT,

	NL80211_ATTR_USE_MFP,

	NL80211_ATTR_STA_FLAGS2,

	NL80211_ATTR_CONTROL_PORT,

	NL80211_ATTR_TESTDATA,

	NL80211_ATTR_PRIVACY,

	NL80211_ATTR_DISCONNECTED_BY_AP,
	NL80211_ATTR_STATUS_CODE,

	NL80211_ATTR_CIPHER_SUITES_PAIRWISE,
	NL80211_ATTR_CIPHER_SUITE_GROUP,
	NL80211_ATTR_WPA_VERSIONS,
	NL80211_ATTR_AKM_SUITES,

	NL80211_ATTR_REQ_IE,
	NL80211_ATTR_RESP_IE,

	NL80211_ATTR_PREV_BSSID,

	NL80211_ATTR_KEY,
	NL80211_ATTR_KEYS,

	NL80211_ATTR_PID,

	NL80211_ATTR_4ADDR,

	NL80211_ATTR_SURVEY_INFO,

	NL80211_ATTR_PMKID,
	NL80211_ATTR_MAX_NUM_PMKIDS,

	NL80211_ATTR_DURATION,

	NL80211_ATTR_COOKIE,

	NL80211_ATTR_WIPHY_COVERAGE_CLASS,

	NL80211_ATTR_TX_RATES,

	NL80211_ATTR_FRAME_MATCH,

	NL80211_ATTR_ACK,

	NL80211_ATTR_PS_STATE,

	NL80211_ATTR_CQM,

	NL80211_ATTR_LOCAL_STATE_CHANGE,

	NL80211_ATTR_AP_ISOLATE,

	NL80211_ATTR_WIPHY_TX_POWER_SETTING,
	NL80211_ATTR_WIPHY_TX_POWER_LEVEL,

	NL80211_ATTR_TX_FRAME_TYPES,
	NL80211_ATTR_RX_FRAME_TYPES,
	NL80211_ATTR_FRAME_TYPE,

	NL80211_ATTR_CONTROL_PORT_ETHERTYPE,
	NL80211_ATTR_CONTROL_PORT_NO_ENCRYPT,

	NL80211_ATTR_SUPPORT_IBSS_RSN,

	NL80211_ATTR_WIPHY_ANTENNA_TX,
	NL80211_ATTR_WIPHY_ANTENNA_RX,

	NL80211_ATTR_MCAST_RATE,

	NL80211_ATTR_OFFCHANNEL_TX_OK,

	NL80211_ATTR_BSS_HT_OPMODE,

	NL80211_ATTR_KEY_DEFAULT_TYPES,

	NL80211_ATTR_MAX_REMAIN_ON_CHANNEL_DURATION,

	NL80211_ATTR_MESH_SETUP,

	NL80211_ATTR_WIPHY_ANTENNA_AVAIL_TX,
	NL80211_ATTR_WIPHY_ANTENNA_AVAIL_RX,

	NL80211_ATTR_SUPPORT_MESH_AUTH,
	NL80211_ATTR_STA_PLINK_STATE,

	NL80211_ATTR_WOWLAN_TRIGGERS,
	NL80211_ATTR_WOWLAN_TRIGGERS_SUPPORTED,

	NL80211_ATTR_SCHED_SCAN_INTERVAL,

	NL80211_ATTR_INTERFACE_COMBINATIONS,
	NL80211_ATTR_SOFTWARE_IFTYPES,

	NL80211_ATTR_REKEY_DATA,

	NL80211_ATTR_MAX_NUM_SCHED_SCAN_SSIDS,
	NL80211_ATTR_MAX_SCHED_SCAN_IE_LEN,

	NL80211_ATTR_SCAN_SUPP_RATES,

	NL80211_ATTR_HIDDEN_SSID,

	NL80211_ATTR_IE_PROBE_RESP,
	NL80211_ATTR_IE_ASSOC_RESP,

	NL80211_ATTR_STA_WME,
	NL80211_ATTR_SUPPORT_AP_UAPSD,

	NL80211_ATTR_ROAM_SUPPORT,

	NL80211_ATTR_SCHED_SCAN_MATCH,
	NL80211_ATTR_MAX_MATCH_SETS,

	NL80211_ATTR_PMKSA_CANDIDATE,

	NL80211_ATTR_TX_NO_CCK_RATE,

	NL80211_ATTR_TDLS_ACTION,
	NL80211_ATTR_TDLS_DIALOG_TOKEN,
	NL80211_ATTR_TDLS_OPERATION,
	NL80211_ATTR_TDLS_SUPPORT,
	NL80211_ATTR_TDLS_EXTERNAL_SETUP,

	NL80211_ATTR_DEVICE_AP_SME,

	NL80211_ATTR_DONT_WAIT_FOR_ACK,

	NL80211_ATTR_FEATURE_FLAGS,

	NL80211_ATTR_PROBE_RESP_OFFLOAD,

	NL80211_ATTR_PROBE_RESP,

	NL80211_ATTR_DFS_REGION,

	NL80211_ATTR_DISABLE_HT,
	NL80211_ATTR_HT_CAPABILITY_MASK,

	NL80211_ATTR_NOACK_MAP,

	NL80211_ATTR_INACTIVITY_TIMEOUT,

	NL80211_ATTR_RX_SIGNAL_DBM,

	NL80211_ATTR_BG_SCAN_PERIOD,

	NL80211_ATTR_WDEV,

	NL80211_ATTR_USER_REG_HINT_TYPE,

	NL80211_ATTR_CONN_FAILED_REASON,

	NL80211_ATTR_AUTH_DATA,

	NL80211_ATTR_VHT_CAPABILITY,

	NL80211_ATTR_SCAN_FLAGS,

	NL80211_ATTR_CHANNEL_WIDTH,
	NL80211_ATTR_CENTER_FREQ1,
	NL80211_ATTR_CENTER_FREQ2,

	NL80211_ATTR_P2P_CTWINDOW,
	NL80211_ATTR_P2P_OPPPS,

	NL80211_ATTR_LOCAL_MESH_POWER_MODE,

	NL80211_ATTR_ACL_POLICY,

	NL80211_ATTR_MAC_ADDRS,

	NL80211_ATTR_MAC_ACL_MAX,

	NL80211_ATTR_RADAR_EVENT,

	NL80211_ATTR_EXT_CAPA,
	NL80211_ATTR_EXT_CAPA_MASK,

	NL80211_ATTR_STA_CAPABILITY,
	NL80211_ATTR_STA_EXT_CAPABILITY,

	NL80211_ATTR_PROTOCOL_FEATURES,
	NL80211_ATTR_SPLIT_WIPHY_DUMP,

	NL80211_ATTR_DISABLE_VHT,
	NL80211_ATTR_VHT_CAPABILITY_MASK,

	NL80211_ATTR_MDID,
	NL80211_ATTR_IE_RIC,

	NL80211_ATTR_CRIT_PROT_ID,
	NL80211_ATTR_MAX_CRIT_PROT_DURATION,

	NL80211_ATTR_PEER_AID,

	NL80211_ATTR_COALESCE_RULE,

	NL80211_ATTR_CH_SWITCH_COUNT,
	NL80211_ATTR_CH_SWITCH_BLOCK_TX,
	NL80211_ATTR_CSA_IES,
	NL80211_ATTR_CNTDWN_OFFS_BEACON,
	NL80211_ATTR_CNTDWN_OFFS_PRESP,

	NL80211_ATTR_RXMGMT_FLAGS,

	NL80211_ATTR_STA_SUPPORTED_CHANNELS,

	NL80211_ATTR_STA_SUPPORTED_OPER_CLASSES,

	NL80211_ATTR_HANDLE_DFS,

	NL80211_ATTR_SUPPORT_5_MHZ,
	NL80211_ATTR_SUPPORT_10_MHZ,

	NL80211_ATTR_OPMODE_NOTIF,

	NL80211_ATTR_VENDOR_ID,
	NL80211_ATTR_VENDOR_SUBCMD,
	NL80211_ATTR_VENDOR_DATA,
	NL80211_ATTR_VENDOR_EVENTS,

	NL80211_ATTR_QOS_MAP,

	NL80211_ATTR_MAC_HINT,
	NL80211_ATTR_WIPHY_FREQ_HINT,

	NL80211_ATTR_MAX_AP_ASSOC_STA,

	NL80211_ATTR_TDLS_PEER_CAPABILITY,

	NL80211_ATTR_SOCKET_OWNER,

	NL80211_ATTR_CSA_C_OFFSETS_TX,
	NL80211_ATTR_MAX_CSA_COUNTERS,

	NL80211_ATTR_TDLS_INITIATOR,

	NL80211_ATTR_USE_RRM,

	NL80211_ATTR_WIPHY_DYN_ACK,

	NL80211_ATTR_TSID,
	NL80211_ATTR_USER_PRIO,
	NL80211_ATTR_ADMITTED_TIME,

	NL80211_ATTR_SMPS_MODE,

	NL80211_ATTR_OPER_CLASS,

	NL80211_ATTR_MAC_MASK,

	NL80211_ATTR_WIPHY_SELF_MANAGED_REG,

	NL80211_ATTR_EXT_FEATURES,

	NL80211_ATTR_SURVEY_RADIO_STATS,

	NL80211_ATTR_NETNS_FD,

	NL80211_ATTR_SCHED_SCAN_DELAY,

	NL80211_ATTR_REG_INDOOR,

	NL80211_ATTR_MAX_NUM_SCHED_SCAN_PLANS,
	NL80211_ATTR_MAX_SCAN_PLAN_INTERVAL,
	NL80211_ATTR_MAX_SCAN_PLAN_ITERATIONS,
	NL80211_ATTR_SCHED_SCAN_PLANS,

	NL80211_ATTR_PBSS,

	NL80211_ATTR_BSS_SELECT,

	NL80211_ATTR_STA_SUPPORT_P2P_PS,

	NL80211_ATTR_PAD,

	NL80211_ATTR_IFTYPE_EXT_CAPA,

	NL80211_ATTR_MU_MIMO_GROUP_DATA,
	NL80211_ATTR_MU_MIMO_FOLLOW_MAC_ADDR,

	NL80211_ATTR_SCAN_START_TIME_TSF,
	NL80211_ATTR_SCAN_START_TIME_TSF_BSSID,
	NL80211_ATTR_MEASUREMENT_DURATION,
	NL80211_ATTR_MEASUREMENT_DURATION_MANDATORY,

	NL80211_ATTR_MESH_PEER_AID,

	NL80211_ATTR_NAN_MASTER_PREF,
	NL80211_ATTR_BANDS,
	NL80211_ATTR_NAN_FUNC,
	NL80211_ATTR_NAN_MATCH,

	NL80211_ATTR_FILS_KEK,
	NL80211_ATTR_FILS_NONCES,

	NL80211_ATTR_MULTICAST_TO_UNICAST_ENABLED,

	NL80211_ATTR_BSSID,

	NL80211_ATTR_SCHED_SCAN_RELATIVE_RSSI,
	NL80211_ATTR_SCHED_SCAN_RSSI_ADJUST,

	NL80211_ATTR_TIMEOUT_REASON,

	NL80211_ATTR_FILS_ERP_USERNAME,
	NL80211_ATTR_FILS_ERP_REALM,
	NL80211_ATTR_FILS_ERP_NEXT_SEQ_NUM,
	NL80211_ATTR_FILS_ERP_RRK,
	NL80211_ATTR_FILS_CACHE_ID,

	NL80211_ATTR_PMK,

	NL80211_ATTR_SCHED_SCAN_MULTI,
	NL80211_ATTR_SCHED_SCAN_MAX_REQS,

	NL80211_ATTR_WANT_1X_4WAY_HS,
	NL80211_ATTR_PMKR0_NAME,
	NL80211_ATTR_PORT_AUTHORIZED,

	NL80211_ATTR_EXTERNAL_AUTH_ACTION,
	NL80211_ATTR_EXTERNAL_AUTH_SUPPORT,

	NL80211_ATTR_NSS,
	NL80211_ATTR_ACK_SIGNAL,

	NL80211_ATTR_CONTROL_PORT_OVER_NL80211,

	NL80211_ATTR_TXQ_STATS,
	NL80211_ATTR_TXQ_LIMIT,
	NL80211_ATTR_TXQ_MEMORY_LIMIT,
	NL80211_ATTR_TXQ_QUANTUM,

	NL80211_ATTR_HE_CAPABILITY,

	NL80211_ATTR_FTM_RESPONDER,

	NL80211_ATTR_FTM_RESPONDER_STATS,

	NL80211_ATTR_TIMEOUT,

	NL80211_ATTR_PEER_MEASUREMENTS,

	NL80211_ATTR_AIRTIME_WEIGHT,
	NL80211_ATTR_STA_TX_POWER_SETTING,
	NL80211_ATTR_STA_TX_POWER,

	NL80211_ATTR_SAE_PASSWORD,

	NL80211_ATTR_TWT_RESPONDER,

	NL80211_ATTR_HE_OBSS_PD,

	NL80211_ATTR_WIPHY_EDMG_CHANNELS,
	NL80211_ATTR_WIPHY_EDMG_BW_CONFIG,

	NL80211_ATTR_VLAN_ID,

	NL80211_ATTR_HE_BSS_COLOR,

	NL80211_ATTR_IFTYPE_AKM_SUITES,

	NL80211_ATTR_TID_CONFIG,

	NL80211_ATTR_CONTROL_PORT_NO_PREAUTH,

	NL80211_ATTR_PMK_LIFETIME,
	NL80211_ATTR_PMK_REAUTH_THRESHOLD,

	NL80211_ATTR_RECEIVE_MULTICAST,
	NL80211_ATTR_WIPHY_FREQ_OFFSET,
	NL80211_ATTR_CENTER_FREQ1_OFFSET,
	NL80211_ATTR_SCAN_FREQ_KHZ,

	NL80211_ATTR_HE_6GHZ_CAPABILITY,

	NL80211_ATTR_FILS_DISCOVERY,

	NL80211_ATTR_UNSOL_BCAST_PROBE_RESP,

	NL80211_ATTR_S1G_CAPABILITY,
	NL80211_ATTR_S1G_CAPABILITY_MASK,

	NL80211_ATTR_SAE_PWE,

	NL80211_ATTR_RECONNECT_REQUESTED,

	NL80211_ATTR_SAR_SPEC,

	NL80211_ATTR_DISABLE_HE,

	NL80211_ATTR_OBSS_COLOR_BITMAP,

	NL80211_ATTR_COLOR_CHANGE_COUNT,
	NL80211_ATTR_COLOR_CHANGE_COLOR,
	NL80211_ATTR_COLOR_CHANGE_ELEMS,

	NL80211_ATTR_MBSSID_CONFIG,
	NL80211_ATTR_MBSSID_ELEMS,

	NL80211_ATTR_RADAR_BACKGROUND,

	NL80211_ATTR_AP_SETTINGS_FLAGS,

	NL80211_ATTR_EHT_CAPABILITY,

	NL80211_ATTR_DISABLE_EHT,

	NL80211_ATTR_MLO_LINKS,
	NL80211_ATTR_MLO_LINK_ID,
	NL80211_ATTR_MLD_ADDR,

	NL80211_ATTR_MLO_SUPPORT,

	NL80211_ATTR_MAX_NUM_AKM_SUITES,

	NL80211_ATTR_EML_CAPABILITY,
	NL80211_ATTR_MLD_CAPA_AND_OPS,

	NL80211_ATTR_TX_HW_TIMESTAMP,
	NL80211_ATTR_RX_HW_TIMESTAMP,
	NL80211_ATTR_TD_BITMAP,

	NL80211_ATTR_PUNCT_BITMAP,

	/* add attributes here, update the policy in nl80211.c */

	__NL80211_ATTR_AFTER_LAST,
	NUM_NL80211_ATTR = __NL80211_ATTR_AFTER_LAST,
	NL80211_ATTR_MAX = __NL80211_ATTR_AFTER_LAST - 1
};
