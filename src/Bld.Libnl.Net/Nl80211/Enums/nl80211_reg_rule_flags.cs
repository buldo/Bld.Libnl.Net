namespace Bld.Libnl.Net.Nl80211.Enums;

public enum nl80211_reg_rule_flags {
	NL80211_RRF_NO_OFDM		= 1<<0,
	NL80211_RRF_NO_CCK		= 1<<1,
	NL80211_RRF_NO_INDOOR		= 1<<2,
	NL80211_RRF_NO_OUTDOOR		= 1<<3,
	NL80211_RRF_DFS			= 1<<4,
	NL80211_RRF_PTP_ONLY		= 1<<5,
	NL80211_RRF_PTMP_ONLY		= 1<<6,
	NL80211_RRF_NO_IR		= 1<<7,
	__NL80211_RRF_NO_IBSS		= 1<<8,
	NL80211_RRF_AUTO_BW		= 1<<11,
	NL80211_RRF_IR_CONCURRENT	= 1<<12,
	NL80211_RRF_NO_HT40MINUS	= 1<<13,
	NL80211_RRF_NO_HT40PLUS		= 1<<14,
	NL80211_RRF_NO_80MHZ		= 1<<15,
	NL80211_RRF_NO_160MHZ		= 1<<16,
	NL80211_RRF_NO_HE		= 1<<17,
	NL80211_RRF_NO_320MHZ		= 1<<18,
};
