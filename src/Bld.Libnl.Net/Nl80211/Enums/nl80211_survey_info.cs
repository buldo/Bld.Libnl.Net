namespace Bld.Libnl.Net.Nl80211.Enums;

public enum nl80211_survey_info {
	__NL80211_SURVEY_INFO_INVALID,
	NL80211_SURVEY_INFO_FREQUENCY,
	NL80211_SURVEY_INFO_NOISE,
	NL80211_SURVEY_INFO_IN_USE,
	NL80211_SURVEY_INFO_TIME,
	NL80211_SURVEY_INFO_TIME_BUSY,
	NL80211_SURVEY_INFO_TIME_EXT_BUSY,
	NL80211_SURVEY_INFO_TIME_RX,
	NL80211_SURVEY_INFO_TIME_TX,
	NL80211_SURVEY_INFO_TIME_SCAN,
	NL80211_SURVEY_INFO_PAD,
	NL80211_SURVEY_INFO_TIME_BSS_RX,
	NL80211_SURVEY_INFO_FREQUENCY_OFFSET,

	/* keep last */
	__NL80211_SURVEY_INFO_AFTER_LAST,
	NL80211_SURVEY_INFO_MAX = __NL80211_SURVEY_INFO_AFTER_LAST - 1
};