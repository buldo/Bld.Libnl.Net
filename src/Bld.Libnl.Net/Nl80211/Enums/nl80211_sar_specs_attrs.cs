namespace Bld.Libnl.Net.Nl80211.Enums;

public enum nl80211_sar_specs_attrs {
	__NL80211_SAR_ATTR_SPECS_INVALID,

	NL80211_SAR_ATTR_SPECS_POWER,
	NL80211_SAR_ATTR_SPECS_RANGE_INDEX,
	NL80211_SAR_ATTR_SPECS_START_FREQ,
	NL80211_SAR_ATTR_SPECS_END_FREQ,

	__NL80211_SAR_ATTR_SPECS_LAST,
	NL80211_SAR_ATTR_SPECS_MAX = __NL80211_SAR_ATTR_SPECS_LAST - 1,
};
