using Bld.Libnl.Net.Nl80211.Enums;
using static Bld.Libnl.Net.Nl80211.NetlinkAttributeType;

namespace Bld.Libnl.Net.Nl80211.Policies;

public static partial class NlaPolicies
{
    public static Dictionary<nl80211_attrs, NlaPolicyDescription> nl80211_policy = new()
    {
        [nl80211_attrs.NL80211_ATTR_SUPPORTED_IFTYPES] = new(NLA_NESTED_IFTYPES),
        //[0] = {  .strict_start_type = NL80211_ATTR_HE_OBSS_PD },
        [nl80211_attrs.NL80211_ATTR_WIPHY] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_WIPHY_NAME] = new(NLA_NUL_STRING),
        [nl80211_attrs.NL80211_ATTR_WIPHY_TXQ_PARAMS] = new(NLA_NESTED),

        [nl80211_attrs.NL80211_ATTR_WIPHY_FREQ] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_WIPHY_CHANNEL_TYPE] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_WIPHY_EDMG_CHANNELS] = new(NLA_U8),
        [nl80211_attrs.NL80211_ATTR_WIPHY_EDMG_BW_CONFIG] = new(NLA_U8),

        [nl80211_attrs.NL80211_ATTR_CHANNEL_WIDTH] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_CENTER_FREQ1] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_CENTER_FREQ1_OFFSET] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_CENTER_FREQ2] = new(NLA_U32),

        [nl80211_attrs.NL80211_ATTR_WIPHY_RETRY_SHORT] = new(NLA_U8),
        [nl80211_attrs.NL80211_ATTR_WIPHY_RETRY_LONG] = new(NLA_U8),
        [nl80211_attrs.NL80211_ATTR_WIPHY_FRAG_THRESHOLD] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_WIPHY_RTS_THRESHOLD] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_WIPHY_COVERAGE_CLASS] = new(NLA_U8),
        [nl80211_attrs.NL80211_ATTR_WIPHY_DYN_ACK] = new(NLA_FLAG),

        [nl80211_attrs.NL80211_ATTR_IFTYPE] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_IFINDEX] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_IFNAME] = new(NLA_NUL_STRING),

        [nl80211_attrs.NL80211_ATTR_MAC] = new(NLA_BINARY),
        [nl80211_attrs.NL80211_ATTR_PREV_BSSID] = new(NLA_BINARY),

        [nl80211_attrs.NL80211_ATTR_KEY] = new(NLA_NESTED),
        [nl80211_attrs.NL80211_ATTR_KEY_DATA] = new(NLA_BINARY),
        [nl80211_attrs.NL80211_ATTR_KEY_IDX] = new(NLA_U8),
        [nl80211_attrs.NL80211_ATTR_KEY_CIPHER] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_KEY_DEFAULT] = new(NLA_FLAG),
        [nl80211_attrs.NL80211_ATTR_KEY_SEQ] = new(NLA_BINARY),
        [nl80211_attrs.NL80211_ATTR_KEY_TYPE] = new(NLA_U32),

        [nl80211_attrs.NL80211_ATTR_BEACON_INTERVAL] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_DTIM_PERIOD] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_BEACON_HEAD] = new(NLA_BINARY),
        [nl80211_attrs.NL80211_ATTR_BEACON_TAIL] = new(NLA_BINARY),
        [nl80211_attrs.NL80211_ATTR_STA_AID] = new(NLA_U16),
        [nl80211_attrs.NL80211_ATTR_STA_FLAGS] = new(NLA_NESTED),
        [nl80211_attrs.NL80211_ATTR_STA_LISTEN_INTERVAL] = new(NLA_U16),
        [nl80211_attrs.NL80211_ATTR_STA_SUPPORTED_RATES] = new(NLA_BINARY),
        [nl80211_attrs.NL80211_ATTR_STA_PLINK_ACTION] = new(NLA_U8),
        [nl80211_attrs.NL80211_ATTR_STA_TX_POWER_SETTING] = new(NLA_U8),
        [nl80211_attrs.NL80211_ATTR_STA_TX_POWER] = new(NLA_S16),
        [nl80211_attrs.NL80211_ATTR_STA_VLAN] = new(NLA_U32),
        //[nl80211_attrs.NL80211_ATTR_MNTR_FLAGS] = { /* NLA_NESTED can't be empty */ },
        [nl80211_attrs.NL80211_ATTR_MESH_ID] = new(NLA_BINARY),
        //[nl80211_attrs.NL80211_ATTR_MPATH_NEXT_HOP] = NLA_POLICY_ETH_ADDR_COMPAT,

        /* allow 3 for NUL-termination, we used to declare this NLA_STRING */
        [nl80211_attrs.NL80211_ATTR_REG_ALPHA2] = new(NLA_BINARY),
        [nl80211_attrs.NL80211_ATTR_REG_RULES] = new(NLA_NESTED),

        [nl80211_attrs.NL80211_ATTR_BSS_CTS_PROT] = new(NLA_U8),
        [nl80211_attrs.NL80211_ATTR_BSS_SHORT_PREAMBLE] = new(NLA_U8),
        [nl80211_attrs.NL80211_ATTR_BSS_SHORT_SLOT_TIME] = new(NLA_U8),
        [nl80211_attrs.NL80211_ATTR_BSS_BASIC_RATES] = new(NLA_BINARY),
        [nl80211_attrs.NL80211_ATTR_BSS_HT_OPMODE] = new(NLA_U16),

        [nl80211_attrs.NL80211_ATTR_MESH_CONFIG] = new(NLA_NESTED),
        [nl80211_attrs.NL80211_ATTR_SUPPORT_MESH_AUTH] = new(NLA_FLAG),

        [nl80211_attrs.NL80211_ATTR_HT_CAPABILITY] = new(NLA_BINARY),

        [nl80211_attrs.NL80211_ATTR_MGMT_SUBTYPE] = new(NLA_U8),
        [nl80211_attrs.NL80211_ATTR_IE] = new(NLA_BINARY),
        [nl80211_attrs.NL80211_ATTR_SCAN_FREQUENCIES] = new(NLA_NESTED),
        [nl80211_attrs.NL80211_ATTR_SCAN_SSIDS] = new(NLA_NESTED),

        [nl80211_attrs.NL80211_ATTR_SSID] = new(NLA_BINARY),
        [nl80211_attrs.NL80211_ATTR_AUTH_TYPE] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_REASON_CODE] = new(NLA_U16),
        [nl80211_attrs.NL80211_ATTR_FREQ_FIXED] = new(NLA_FLAG),
        [nl80211_attrs.NL80211_ATTR_TIMED_OUT] = new(NLA_FLAG),
        [nl80211_attrs.NL80211_ATTR_USE_MFP] = new(NLA_U32),
        //[nl80211_attrs.NL80211_ATTR_STA_FLAGS2] = NLA_POLICY_EXACT_LEN_WARN(sizeof(struct nl80211_sta_flag_update)),
        [nl80211_attrs.NL80211_ATTR_CONTROL_PORT] = new(NLA_FLAG),
        [nl80211_attrs.NL80211_ATTR_CONTROL_PORT_ETHERTYPE] = new(NLA_U16),
        [nl80211_attrs.NL80211_ATTR_CONTROL_PORT_NO_ENCRYPT] = new(NLA_FLAG),
        [nl80211_attrs.NL80211_ATTR_CONTROL_PORT_OVER_NL80211] = new(NLA_FLAG),
        [nl80211_attrs.NL80211_ATTR_PRIVACY] = new(NLA_FLAG),
        [nl80211_attrs.NL80211_ATTR_STATUS_CODE] = new(NLA_U16),
        [nl80211_attrs.NL80211_ATTR_CIPHER_SUITE_GROUP] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_WPA_VERSIONS] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_PID] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_4ADDR] = new(NLA_U8),
        //[nl80211_attrs.NL80211_ATTR_PMKID] = NLA_POLICY_EXACT_LEN_WARN(WLAN_PMKID_LEN),
        [nl80211_attrs.NL80211_ATTR_DURATION] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_COOKIE] = new(NLA_U64),
        [nl80211_attrs.NL80211_ATTR_TX_RATES] = new(NLA_NESTED),
        [nl80211_attrs.NL80211_ATTR_FRAME] = new(NLA_BINARY),
        [nl80211_attrs.NL80211_ATTR_FRAME_MATCH] = new(NLA_BINARY),
        [nl80211_attrs.NL80211_ATTR_PS_STATE] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_CQM] = new(NLA_NESTED),
        [nl80211_attrs.NL80211_ATTR_LOCAL_STATE_CHANGE] = new(NLA_FLAG),
        [nl80211_attrs.NL80211_ATTR_AP_ISOLATE] = new(NLA_U8),
        [nl80211_attrs.NL80211_ATTR_WIPHY_TX_POWER_SETTING] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_WIPHY_TX_POWER_LEVEL] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_FRAME_TYPE] = new(NLA_U16),
        [nl80211_attrs.NL80211_ATTR_WIPHY_ANTENNA_TX] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_WIPHY_ANTENNA_RX] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_MCAST_RATE] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_OFFCHANNEL_TX_OK] = new(NLA_FLAG),
        [nl80211_attrs.NL80211_ATTR_KEY_DEFAULT_TYPES] = new(NLA_NESTED),
        [nl80211_attrs.NL80211_ATTR_WOWLAN_TRIGGERS] = new(NLA_NESTED),
        [nl80211_attrs.NL80211_ATTR_STA_PLINK_STATE] = new(NLA_U8),
        [nl80211_attrs.NL80211_ATTR_MEASUREMENT_DURATION] = new(NLA_U16),
        [nl80211_attrs.NL80211_ATTR_MEASUREMENT_DURATION_MANDATORY] = new(NLA_FLAG),
        [nl80211_attrs.NL80211_ATTR_MESH_PEER_AID] = new(NLA_U16),
        [nl80211_attrs.NL80211_ATTR_SCHED_SCAN_INTERVAL] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_REKEY_DATA] = new(NLA_NESTED),
        [nl80211_attrs.NL80211_ATTR_SCAN_SUPP_RATES] = new(NLA_NESTED),
        [nl80211_attrs.NL80211_ATTR_HIDDEN_SSID] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_IE_PROBE_RESP] = new(NLA_BINARY),
        [nl80211_attrs.NL80211_ATTR_IE_ASSOC_RESP] = new(NLA_BINARY),
        [nl80211_attrs.NL80211_ATTR_ROAM_SUPPORT] = new(NLA_FLAG),
        //[nl80211_attrs.NL80211_ATTR_STA_WME] = NLA_POLICY_NESTED(nl80211_sta_wme_policy),
        [nl80211_attrs.NL80211_ATTR_SCHED_SCAN_MATCH] = new(NLA_NESTED),
        [nl80211_attrs.NL80211_ATTR_TX_NO_CCK_RATE] = new(NLA_FLAG),
        [nl80211_attrs.NL80211_ATTR_TDLS_ACTION] = new(NLA_U8),
        [nl80211_attrs.NL80211_ATTR_TDLS_DIALOG_TOKEN] = new(NLA_U8),
        [nl80211_attrs.NL80211_ATTR_TDLS_OPERATION] = new(NLA_U8),
        [nl80211_attrs.NL80211_ATTR_TDLS_SUPPORT] = new(NLA_FLAG),
        [nl80211_attrs.NL80211_ATTR_TDLS_EXTERNAL_SETUP] = new(NLA_FLAG),
        [nl80211_attrs.NL80211_ATTR_TDLS_INITIATOR] = new(NLA_FLAG),
        [nl80211_attrs.NL80211_ATTR_DONT_WAIT_FOR_ACK] = new(NLA_FLAG),
        [nl80211_attrs.NL80211_ATTR_PROBE_RESP] = new(NLA_BINARY),
        [nl80211_attrs.NL80211_ATTR_DFS_REGION] = new(NLA_U8),
        [nl80211_attrs.NL80211_ATTR_DISABLE_HT] = new(NLA_FLAG),
        //[nl80211_attrs.NL80211_ATTR_HT_CAPABILITY_MASK] = new() { Length = NL80211_HT_CAPABILITY_LEN },
        [nl80211_attrs.NL80211_ATTR_NOACK_MAP] = new(NLA_U16),
        [nl80211_attrs.NL80211_ATTR_INACTIVITY_TIMEOUT] = new(NLA_U16),
        [nl80211_attrs.NL80211_ATTR_BG_SCAN_PERIOD] = new(NLA_U16),
        [nl80211_attrs.NL80211_ATTR_WDEV] = new(NLA_U64),
        [nl80211_attrs.NL80211_ATTR_USER_REG_HINT_TYPE] = new(NLA_U32),

        /* need to include at least Auth Transaction and Status Code */
        //[nl80211_attrs.NL80211_ATTR_AUTH_DATA] = NLA_POLICY_MIN_LEN(4),

        //[nl80211_attrs.NL80211_ATTR_VHT_CAPABILITY] = NLA_POLICY_EXACT_LEN_WARN(NL80211_VHT_CAPABILITY_LEN),
        [nl80211_attrs.NL80211_ATTR_SCAN_FLAGS] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_P2P_CTWINDOW] = new(NLA_U8),
        [nl80211_attrs.NL80211_ATTR_P2P_OPPPS] = new(NLA_U8),
        [nl80211_attrs.NL80211_ATTR_LOCAL_MESH_POWER_MODE] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_ACL_POLICY] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_MAC_ADDRS] = new(NLA_NESTED),
        [nl80211_attrs.NL80211_ATTR_STA_CAPABILITY] = new(NLA_U16),
        [nl80211_attrs.NL80211_ATTR_STA_EXT_CAPABILITY] = new(NLA_BINARY),
        [nl80211_attrs.NL80211_ATTR_SPLIT_WIPHY_DUMP] = new(NLA_FLAG),
        [nl80211_attrs.NL80211_ATTR_DISABLE_VHT] = new(NLA_FLAG),
        //[nl80211_attrs.NL80211_ATTR_VHT_CAPABILITY_MASK] = new() { Length = NL80211_VHT_CAPABILITY_LEN, },
        [nl80211_attrs.NL80211_ATTR_MDID] = new(NLA_U16),
        [nl80211_attrs.NL80211_ATTR_IE_RIC] = new(NLA_BINARY),
        [nl80211_attrs.NL80211_ATTR_CRIT_PROT_ID] = new(NLA_U16),
        [nl80211_attrs.NL80211_ATTR_MAX_CRIT_PROT_DURATION] = new(NLA_U16),
        [nl80211_attrs.NL80211_ATTR_PEER_AID] = new(NLA_U16),
        [nl80211_attrs.NL80211_ATTR_CH_SWITCH_COUNT] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_CH_SWITCH_BLOCK_TX] = new(NLA_FLAG),
        [nl80211_attrs.NL80211_ATTR_CSA_IES] = new(NLA_NESTED),
        [nl80211_attrs.NL80211_ATTR_CNTDWN_OFFS_BEACON] = new(NLA_BINARY),
        [nl80211_attrs.NL80211_ATTR_CNTDWN_OFFS_PRESP] = new(NLA_BINARY),
        //[nl80211_attrs.NL80211_ATTR_STA_SUPPORTED_CHANNELS] = NLA_POLICY_MIN_LEN(2),
        /*
         * The value of the Length field of the Supported Operating
         * Classes element is between 2 and 253.
         */
        [nl80211_attrs.NL80211_ATTR_STA_SUPPORTED_OPER_CLASSES] = new(NLA_BINARY),
        [nl80211_attrs.NL80211_ATTR_HANDLE_DFS] = new(NLA_FLAG),
        [nl80211_attrs.NL80211_ATTR_OPMODE_NOTIF] = new(NLA_U8),
        [nl80211_attrs.NL80211_ATTR_VENDOR_ID] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_VENDOR_SUBCMD] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_VENDOR_DATA] = new(NLA_BINARY),
        [nl80211_attrs.NL80211_ATTR_QOS_MAP] = new(NLA_BINARY),
        //[nl80211_attrs.NL80211_ATTR_MAC_HINT] = NLA_POLICY_EXACT_LEN_WARN(ETH_ALEN),
        [nl80211_attrs.NL80211_ATTR_WIPHY_FREQ_HINT] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_TDLS_PEER_CAPABILITY] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_SOCKET_OWNER] = new(NLA_FLAG),
        [nl80211_attrs.NL80211_ATTR_CSA_C_OFFSETS_TX] = new(NLA_BINARY),
        [nl80211_attrs.NL80211_ATTR_USE_RRM] = new(NLA_FLAG),
        [nl80211_attrs.NL80211_ATTR_TSID] = new(NLA_U8),
        [nl80211_attrs.NL80211_ATTR_USER_PRIO] = new(NLA_U8),
        [nl80211_attrs.NL80211_ATTR_ADMITTED_TIME] = new(NLA_U16),
        [nl80211_attrs.NL80211_ATTR_SMPS_MODE] = new(NLA_U8),
        [nl80211_attrs.NL80211_ATTR_OPER_CLASS] = new(NLA_U8),
        //[nl80211_attrs.NL80211_ATTR_MAC_MASK] = NLA_POLICY_EXACT_LEN_WARN(ETH_ALEN),
        [nl80211_attrs.NL80211_ATTR_WIPHY_SELF_MANAGED_REG] = new(NLA_FLAG),
        [nl80211_attrs.NL80211_ATTR_NETNS_FD] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_SCHED_SCAN_DELAY] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_REG_INDOOR] = new(NLA_FLAG),
        [nl80211_attrs.NL80211_ATTR_PBSS] = new(NLA_FLAG),
        [nl80211_attrs.NL80211_ATTR_BSS_SELECT] = new(NLA_NESTED),
        [nl80211_attrs.NL80211_ATTR_STA_SUPPORT_P2P_PS] = new(NLA_U8),
        //[nl80211_attrs.NL80211_ATTR_MU_MIMO_GROUP_DATA] = new() { Length = VHT_MUMIMO_GROUPS_DATA_LEN },
        //[nl80211_attrs.NL80211_ATTR_MU_MIMO_FOLLOW_MAC_ADDR] = NLA_POLICY_EXACT_LEN_WARN(ETH_ALEN),
        [nl80211_attrs.NL80211_ATTR_NAN_MASTER_PREF] = new(NLA_U8),
        [nl80211_attrs.NL80211_ATTR_BANDS] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_NAN_FUNC] = new(NLA_NESTED),
        [nl80211_attrs.NL80211_ATTR_FILS_KEK] = new(NLA_BINARY),
        //[nl80211_attrs.NL80211_ATTR_FILS_NONCES] = NLA_POLICY_EXACT_LEN_WARN(2 * FILS_NONCE_LEN),
        [nl80211_attrs.NL80211_ATTR_MULTICAST_TO_UNICAST_ENABLED] = new(NLA_FLAG),
        //[nl80211_attrs.NL80211_ATTR_BSSID] = NLA_POLICY_EXACT_LEN_WARN(ETH_ALEN),
        [nl80211_attrs.NL80211_ATTR_SCHED_SCAN_RELATIVE_RSSI] = new(NLA_S8),
        //[nl80211_attrs.NL80211_ATTR_SCHED_SCAN_RSSI_ADJUST] = { Length = sizeof(struct nl80211_bss_select_rssi_adjust) },
        [nl80211_attrs.NL80211_ATTR_TIMEOUT_REASON] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_FILS_ERP_USERNAME] = new(NLA_BINARY),
        [nl80211_attrs.NL80211_ATTR_FILS_ERP_REALM] = new(NLA_BINARY),
        [nl80211_attrs.NL80211_ATTR_FILS_ERP_NEXT_SEQ_NUM] = new(NLA_U16),
        [nl80211_attrs.NL80211_ATTR_FILS_ERP_RRK] = new(NLA_BINARY),
        //[nl80211_attrs.NL80211_ATTR_FILS_CACHE_ID] = NLA_POLICY_EXACT_LEN_WARN(2),
        [nl80211_attrs.NL80211_ATTR_PMK] = new(NLA_BINARY),
        //[nl80211_attrs.NL80211_ATTR_PMKR0_NAME] = NLA_POLICY_EXACT_LEN(WLAN_PMK_NAME_LEN),
        [nl80211_attrs.NL80211_ATTR_SCHED_SCAN_MULTI] = new(NLA_FLAG),
        [nl80211_attrs.NL80211_ATTR_EXTERNAL_AUTH_SUPPORT] = new(NLA_FLAG),
        [nl80211_attrs.NL80211_ATTR_TXQ_LIMIT] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_TXQ_MEMORY_LIMIT] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_TXQ_QUANTUM] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_HE_CAPABILITY] = new(NLA_BINARY),
        //[nl80211_attrs.NL80211_ATTR_FTM_RESPONDER] = NLA_POLICY_NESTED(nl80211_ftm_responder_policy),
        [nl80211_attrs.NL80211_ATTR_TIMEOUT] = new(NLA_U32),
        //[nl80211_attrs.NL80211_ATTR_PEER_MEASUREMENTS] = NLA_POLICY_NESTED(nl80211_pmsr_attr_policy),
        [nl80211_attrs.NL80211_ATTR_AIRTIME_WEIGHT] = new(NLA_U16),
        [nl80211_attrs.NL80211_ATTR_SAE_PASSWORD] = new(NLA_BINARY),
        [nl80211_attrs.NL80211_ATTR_TWT_RESPONDER] = new(NLA_FLAG),
        //[nl80211_attrs.NL80211_ATTR_HE_OBSS_PD] = NLA_POLICY_NESTED(he_obss_pd_policy),
        [nl80211_attrs.NL80211_ATTR_VLAN_ID] = new(NLA_U16),
        //[nl80211_attrs.NL80211_ATTR_HE_BSS_COLOR] = NLA_POLICY_NESTED(he_bss_color_policy),
        //[nl80211_attrs.NL80211_ATTR_TID_CONFIG] = NLA_POLICY_NESTED_ARRAY(nl80211_tid_config_attr_policy),
        [nl80211_attrs.NL80211_ATTR_CONTROL_PORT_NO_PREAUTH] = new(NLA_FLAG),
        [nl80211_attrs.NL80211_ATTR_PMK_LIFETIME] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_PMK_REAUTH_THRESHOLD] = new(NLA_U8),
        [nl80211_attrs.NL80211_ATTR_RECEIVE_MULTICAST] = new(NLA_FLAG),
        [nl80211_attrs.NL80211_ATTR_WIPHY_FREQ_OFFSET] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_SCAN_FREQ_KHZ] = new(NLA_NESTED),
        //[nl80211_attrs.NL80211_ATTR_HE_6GHZ_CAPABILITY] = NLA_POLICY_EXACT_LEN(sizeof(struct ieee80211_he_6ghz_capa)),
        //[nl80211_attrs.NL80211_ATTR_FILS_DISCOVERY] = NLA_POLICY_NESTED(nl80211_fils_discovery_policy),
        //[nl80211_attrs.NL80211_ATTR_UNSOL_BCAST_PROBE_RESP] = NLA_POLICY_NESTED(nl80211_unsol_bcast_probe_resp_policy),
        //[nl80211_attrs.NL80211_ATTR_S1G_CAPABILITY] = NLA_POLICY_EXACT_LEN(IEEE80211_S1G_CAPABILITY_LEN),
        //[nl80211_attrs.NL80211_ATTR_S1G_CAPABILITY_MASK] = NLA_POLICY_EXACT_LEN(IEEE80211_S1G_CAPABILITY_LEN),
        [nl80211_attrs.NL80211_ATTR_SAE_PWE] = new(NLA_U8),
        [nl80211_attrs.NL80211_ATTR_RECONNECT_REQUESTED] = new(NLA_REJECT),
        //[nl80211_attrs.NL80211_ATTR_SAR_SPEC] = NLA_POLICY_NESTED(sar_policy),
        [nl80211_attrs.NL80211_ATTR_DISABLE_HE] = new(NLA_FLAG),
        [nl80211_attrs.NL80211_ATTR_OBSS_COLOR_BITMAP] = new(NLA_U64),
        [nl80211_attrs.NL80211_ATTR_COLOR_CHANGE_COUNT] = new(NLA_U8),
        [nl80211_attrs.NL80211_ATTR_COLOR_CHANGE_COLOR] = new(NLA_U8),
        //[nl80211_attrs.NL80211_ATTR_COLOR_CHANGE_ELEMS] = NLA_POLICY_NESTED(nl80211_policy),
        //[nl80211_attrs.NL80211_ATTR_MBSSID_CONFIG] = NLA_POLICY_NESTED(nl80211_mbssid_config_policy),
        [nl80211_attrs.NL80211_ATTR_MBSSID_ELEMS] = new(NLA_NESTED),
        [nl80211_attrs.NL80211_ATTR_RADAR_BACKGROUND] = new(NLA_FLAG),
        [nl80211_attrs.NL80211_ATTR_AP_SETTINGS_FLAGS] = new(NLA_U32),
        [nl80211_attrs.NL80211_ATTR_EHT_CAPABILITY] = new(NLA_BINARY),
        [nl80211_attrs.NL80211_ATTR_DISABLE_EHT] = new(NLA_FLAG),
        //[nl80211_attrs.NL80211_ATTR_MLO_LINKS] = NLA_POLICY_NESTED_ARRAY(nl80211_policy),
        [nl80211_attrs.NL80211_ATTR_MLO_LINK_ID] = new(NLA_U8),
        //[nl80211_attrs.NL80211_ATTR_MLD_ADDR] = NLA_POLICY_EXACT_LEN(ETH_ALEN),
        [nl80211_attrs.NL80211_ATTR_MLO_SUPPORT] = new(NLA_FLAG),
        [nl80211_attrs.NL80211_ATTR_MAX_NUM_AKM_SUITES] = new(NLA_REJECT),
        [nl80211_attrs.NL80211_ATTR_PUNCT_BITMAP] = new(NLA_U32),
    };
}