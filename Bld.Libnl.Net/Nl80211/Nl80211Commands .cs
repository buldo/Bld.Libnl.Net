﻿namespace Bld.Libnl.Net.Nl80211;

/**
 * enum nl80211_commands - supported nl80211 commands
 * @NL80211_CMD_SET_WIPHY: set wiphy parameters, needs %NL80211_ATTR_WIPHY or
 *	%NL80211_ATTR_IFINDEX; can be used to set %NL80211_ATTR_WIPHY_NAME,
 *	%NL80211_ATTR_WIPHY_TXQ_PARAMS, %NL80211_ATTR_WIPHY_FREQ,
 *	%NL80211_ATTR_WIPHY_FREQ_OFFSET (and the attributes determining the
 *	channel width; this is used for setting monitor mode channel),
 *	%NL80211_ATTR_WIPHY_RETRY_SHORT, %NL80211_ATTR_WIPHY_RETRY_LONG,
 *	%NL80211_ATTR_WIPHY_FRAG_THRESHOLD, and/or
 *	%NL80211_ATTR_WIPHY_RTS_THRESHOLD.  However, for setting the channel,
 *	see %NL80211_CMD_SET_CHANNEL instead, the support here is for backward
 *	compatibility only.
 * @NL80211_CMD_NEW_WIPHY: Newly created wiphy, response to get request
 *	or rename notification. Has attributes %NL80211_ATTR_WIPHY and
 *	%NL80211_ATTR_WIPHY_NAME.
 * @NL80211_CMD_DEL_WIPHY: Wiphy deleted. Has attributes
 *	%NL80211_ATTR_WIPHY and %NL80211_ATTR_WIPHY_NAME.
 *
 * @NL80211_CMD_GET_INTERFACE: Request an interface's configuration;
 *	either a dump request for all interfaces or a specific get with a
 *	single %NL80211_ATTR_IFINDEX is supported.
 * @NL80211_CMD_SET_INTERFACE: Set type of a virtual interface, requires
 *	%NL80211_ATTR_IFINDEX and %NL80211_ATTR_IFTYPE.
 * @NL80211_CMD_NEW_INTERFACE: Newly created virtual interface or response
 *	to %NL80211_CMD_GET_INTERFACE. Has %NL80211_ATTR_IFINDEX,
 *	%NL80211_ATTR_WIPHY and %NL80211_ATTR_IFTYPE attributes. Can also
 *	be sent from userspace to request creation of a new virtual interface,
 *	then requires attributes %NL80211_ATTR_WIPHY, %NL80211_ATTR_IFTYPE and
 *	%NL80211_ATTR_IFNAME.
 * @NL80211_CMD_DEL_INTERFACE: Virtual interface was deleted, has attributes
 *	%NL80211_ATTR_IFINDEX and %NL80211_ATTR_WIPHY. Can also be sent from
 *	userspace to request deletion of a virtual interface, then requires
 *	attribute %NL80211_ATTR_IFINDEX. If multiple BSSID advertisements are
 *	enabled using %NL80211_ATTR_MBSSID_CONFIG, %NL80211_ATTR_MBSSID_ELEMS,
 *	and if this command is used for the transmitting interface, then all
 *	the non-transmitting interfaces are deleted as well.
 *
 * @NL80211_CMD_GET_KEY: Get sequence counter information for a key specified
 *	by %NL80211_ATTR_KEY_IDX and/or %NL80211_ATTR_MAC. %NL80211_ATTR_MAC
 *	represents peer's MLD address for MLO pairwise key. For MLO group key,
 *	the link is identified by %NL80211_ATTR_MLO_LINK_ID.
 * @NL80211_CMD_SET_KEY: Set key attributes %NL80211_ATTR_KEY_DEFAULT,
 *	%NL80211_ATTR_KEY_DEFAULT_MGMT, or %NL80211_ATTR_KEY_THRESHOLD.
 *	For MLO connection, the link to set default key is identified by
 *	%NL80211_ATTR_MLO_LINK_ID.
 * @NL80211_CMD_NEW_KEY: add a key with given %NL80211_ATTR_KEY_DATA,
 *	%NL80211_ATTR_KEY_IDX, %NL80211_ATTR_MAC, %NL80211_ATTR_KEY_CIPHER,
 *	and %NL80211_ATTR_KEY_SEQ attributes. %NL80211_ATTR_MAC represents
 *	peer's MLD address for MLO pairwise key. The link to add MLO
 *	group key is identified by %NL80211_ATTR_MLO_LINK_ID.
 * @NL80211_CMD_DEL_KEY: delete a key identified by %NL80211_ATTR_KEY_IDX
 *	or %NL80211_ATTR_MAC. %NL80211_ATTR_MAC represents peer's MLD address
 *	for MLO pairwise key. The link to delete group key is identified by
 *	%NL80211_ATTR_MLO_LINK_ID.
 *
 * @NL80211_CMD_GET_BEACON: (not used)
 * @NL80211_CMD_SET_BEACON: change the beacon on an access point interface
 *	using the %NL80211_ATTR_BEACON_HEAD and %NL80211_ATTR_BEACON_TAIL
 *	attributes. For drivers that generate the beacon and probe responses
 *	internally, the following attributes must be provided: %NL80211_ATTR_IE,
 *	%NL80211_ATTR_IE_PROBE_RESP and %NL80211_ATTR_IE_ASSOC_RESP.
 * @NL80211_CMD_START_AP: Start AP operation on an AP interface, parameters
 *	are like for %NL80211_CMD_SET_BEACON, and additionally parameters that
 *	do not change are used, these include %NL80211_ATTR_BEACON_INTERVAL,
 *	%NL80211_ATTR_DTIM_PERIOD, %NL80211_ATTR_SSID,
 *	%NL80211_ATTR_HIDDEN_SSID, %NL80211_ATTR_CIPHERS_PAIRWISE,
 *	%NL80211_ATTR_CIPHER_GROUP, %NL80211_ATTR_WPA_VERSIONS,
 *	%NL80211_ATTR_AKM_SUITES, %NL80211_ATTR_PRIVACY,
 *	%NL80211_ATTR_AUTH_TYPE, %NL80211_ATTR_INACTIVITY_TIMEOUT,
 *	%NL80211_ATTR_ACL_POLICY and %NL80211_ATTR_MAC_ADDRS.
 *	The channel to use can be set on the interface or be given using the
 *	%NL80211_ATTR_WIPHY_FREQ and %NL80211_ATTR_WIPHY_FREQ_OFFSET, and the
 *	attributes determining channel width.
 * @NL80211_CMD_NEW_BEACON: old alias for %NL80211_CMD_START_AP
 * @NL80211_CMD_STOP_AP: Stop AP operation on the given interface
 * @NL80211_CMD_DEL_BEACON: old alias for %NL80211_CMD_STOP_AP
 *
 * @NL80211_CMD_GET_STATION: Get station attributes for station identified by
 *	%NL80211_ATTR_MAC on the interface identified by %NL80211_ATTR_IFINDEX.
 * @NL80211_CMD_SET_STATION: Set station attributes for station identified by
 *	%NL80211_ATTR_MAC on the interface identified by %NL80211_ATTR_IFINDEX.
 * @NL80211_CMD_NEW_STATION: Add a station with given attributes to the
 *	interface identified by %NL80211_ATTR_IFINDEX.
 * @NL80211_CMD_DEL_STATION: Remove a station identified by %NL80211_ATTR_MAC
 *	or, if no MAC address given, all stations, on the interface identified
 *	by %NL80211_ATTR_IFINDEX. For MLD station, MLD address is used in
 *	%NL80211_ATTR_MAC. %NL80211_ATTR_MGMT_SUBTYPE and
 *	%NL80211_ATTR_REASON_CODE can optionally be used to specify which type
 *	of disconnection indication should be sent to the station
 *	(Deauthentication or Disassociation frame and reason code for that
 *	frame).
 *
 * @NL80211_CMD_GET_MPATH: Get mesh path attributes for mesh path to
 * 	destination %NL80211_ATTR_MAC on the interface identified by
 * 	%NL80211_ATTR_IFINDEX.
 * @NL80211_CMD_SET_MPATH:  Set mesh path attributes for mesh path to
 * 	destination %NL80211_ATTR_MAC on the interface identified by
 * 	%NL80211_ATTR_IFINDEX.
 * @NL80211_CMD_NEW_MPATH: Create a new mesh path for the destination given by
 *	%NL80211_ATTR_MAC via %NL80211_ATTR_MPATH_NEXT_HOP.
 * @NL80211_CMD_DEL_MPATH: Delete a mesh path to the destination given by
 *	%NL80211_ATTR_MAC.
 * @NL80211_CMD_NEW_PATH: Add a mesh path with given attributes to the
 *	interface identified by %NL80211_ATTR_IFINDEX.
 * @NL80211_CMD_DEL_PATH: Remove a mesh path identified by %NL80211_ATTR_MAC
 *	or, if no MAC address given, all mesh paths, on the interface identified
 *	by %NL80211_ATTR_IFINDEX.
 * @NL80211_CMD_SET_BSS: Set BSS attributes for BSS identified by
 *	%NL80211_ATTR_IFINDEX.
 *
 * @NL80211_CMD_GET_REG: ask the wireless core to send us its currently set
 *	regulatory domain. If %NL80211_ATTR_WIPHY is specified and the device
 *	has a private regulatory domain, it will be returned. Otherwise, the
 *	global regdomain will be returned.
 *	A device will have a private regulatory domain if it uses the
 *	regulatory_hint() API. Even when a private regdomain is used the channel
 *	information will still be mended according to further hints from
 *	the regulatory core to help with compliance. A dump version of this API
 *	is now available which will returns the global regdomain as well as
 *	all private regdomains of present wiphys (for those that have it).
 *	If a wiphy is self-managed (%NL80211_ATTR_WIPHY_SELF_MANAGED_REG), then
 *	its private regdomain is the only valid one for it. The regulatory
 *	core is not used to help with compliance in this case.
 * @NL80211_CMD_SET_REG: Set current regulatory domain. CRDA sends this command
 *	after being queried by the kernel. CRDA replies by sending a regulatory
 *	domain structure which consists of %NL80211_ATTR_REG_ALPHA set to our
 *	current alpha2 if it found a match. It also provides
 * 	NL80211_ATTR_REG_RULE_FLAGS, and a set of regulatory rules. Each
 * 	regulatory rule is a nested set of attributes  given by
 * 	%NL80211_ATTR_REG_RULE_FREQ_[START|END] and
 * 	%NL80211_ATTR_FREQ_RANGE_MAX_BW with an attached power rule given by
 * 	%NL80211_ATTR_REG_RULE_POWER_MAX_ANT_GAIN and
 * 	%NL80211_ATTR_REG_RULE_POWER_MAX_EIRP.
 * @NL80211_CMD_REQ_SET_REG: ask the wireless core to set the regulatory domain
 * 	to the specified ISO/IEC 3166-1 alpha2 country code. The core will
 * 	store this as a valid request and then query userspace for it.
 *
 * @NL80211_CMD_GET_MESH_CONFIG: Get mesh networking properties for the
 *	interface identified by %NL80211_ATTR_IFINDEX
 *
 * @NL80211_CMD_SET_MESH_CONFIG: Set mesh networking properties for the
 *      interface identified by %NL80211_ATTR_IFINDEX
 *
 * @NL80211_CMD_SET_MGMT_EXTRA_IE: Set extra IEs for management frames. The
 *	interface is identified with %NL80211_ATTR_IFINDEX and the management
 *	frame subtype with %NL80211_ATTR_MGMT_SUBTYPE. The extra IE data to be
 *	added to the end of the specified management frame is specified with
 *	%NL80211_ATTR_IE. If the command succeeds, the requested data will be
 *	added to all specified management frames generated by
 *	kernel/firmware/driver.
 *	Note: This command has been removed and it is only reserved at this
 *	point to avoid re-using existing command number. The functionality this
 *	command was planned for has been provided with cleaner design with the
 *	option to specify additional IEs in NL80211_CMD_TRIGGER_SCAN,
 *	NL80211_CMD_AUTHENTICATE, NL80211_CMD_ASSOCIATE,
 *	NL80211_CMD_DEAUTHENTICATE, and NL80211_CMD_DISASSOCIATE.
 *
 * @NL80211_CMD_GET_SCAN: get scan results
 * @NL80211_CMD_TRIGGER_SCAN: trigger a new scan with the given parameters
 *	%NL80211_ATTR_TX_NO_CCK_RATE is used to decide whether to send the
 *	probe requests at CCK rate or not. %NL80211_ATTR_BSSID can be used to
 *	specify a BSSID to scan for; if not included, the wildcard BSSID will
 *	be used.
 * @NL80211_CMD_NEW_SCAN_RESULTS: scan notification (as a reply to
 *	NL80211_CMD_GET_SCAN and on the "scan" multicast group)
 * @NL80211_CMD_SCAN_ABORTED: scan was aborted, for unspecified reasons,
 *	partial scan results may be available
 *
 * @NL80211_CMD_START_SCHED_SCAN: start a scheduled scan at certain
 *	intervals and certain number of cycles, as specified by
 *	%NL80211_ATTR_SCHED_SCAN_PLANS. If %NL80211_ATTR_SCHED_SCAN_PLANS is
 *	not specified and only %NL80211_ATTR_SCHED_SCAN_INTERVAL is specified,
 *	scheduled scan will run in an infinite loop with the specified interval.
 *	These attributes are mutually exculsive,
 *	i.e. NL80211_ATTR_SCHED_SCAN_INTERVAL must not be passed if
 *	NL80211_ATTR_SCHED_SCAN_PLANS is defined.
 *	If for some reason scheduled scan is aborted by the driver, all scan
 *	plans are canceled (including scan plans that did not start yet).
 *	Like with normal scans, if SSIDs (%NL80211_ATTR_SCAN_SSIDS)
 *	are passed, they are used in the probe requests.  For
 *	broadcast, a broadcast SSID must be passed (ie. an empty
 *	string).  If no SSID is passed, no probe requests are sent and
 *	a passive scan is performed.  %NL80211_ATTR_SCAN_FREQUENCIES,
 *	if passed, define which channels should be scanned; if not
 *	passed, all channels allowed for the current regulatory domain
 *	are used.  Extra IEs can also be passed from the userspace by
 *	using the %NL80211_ATTR_IE attribute.  The first cycle of the
 *	scheduled scan can be delayed by %NL80211_ATTR_SCHED_SCAN_DELAY
 *	is supplied. If the device supports multiple concurrent scheduled
 *	scans, it will allow such when the caller provides the flag attribute
 *	%NL80211_ATTR_SCHED_SCAN_MULTI to indicate user-space support for it.
 * @NL80211_CMD_STOP_SCHED_SCAN: stop a scheduled scan. Returns -ENOENT if
 *	scheduled scan is not running. The caller may assume that as soon
 *	as the call returns, it is safe to start a new scheduled scan again.
 * @NL80211_CMD_SCHED_SCAN_RESULTS: indicates that there are scheduled scan
 *	results available.
 * @NL80211_CMD_SCHED_SCAN_STOPPED: indicates that the scheduled scan has
 *	stopped.  The driver may issue this event at any time during a
 *	scheduled scan.  One reason for stopping the scan is if the hardware
 *	does not support starting an association or a normal scan while running
 *	a scheduled scan.  This event is also sent when the
 *	%NL80211_CMD_STOP_SCHED_SCAN command is received or when the interface
 *	is brought down while a scheduled scan was running.
 *
 * @NL80211_CMD_GET_SURVEY: get survey resuls, e.g. channel occupation
 *      or noise level
 * @NL80211_CMD_NEW_SURVEY_RESULTS: survey data notification (as a reply to
 *	NL80211_CMD_GET_SURVEY and on the "scan" multicast group)
 *
 * @NL80211_CMD_SET_PMKSA: Add a PMKSA cache entry using %NL80211_ATTR_MAC
 *	(for the BSSID), %NL80211_ATTR_PMKID, and optionally %NL80211_ATTR_PMK
 *	(PMK is used for PTKSA derivation in case of FILS shared key offload) or
 *	using %NL80211_ATTR_SSID, %NL80211_ATTR_FILS_CACHE_ID,
 *	%NL80211_ATTR_PMKID, and %NL80211_ATTR_PMK in case of FILS
 *	authentication where %NL80211_ATTR_FILS_CACHE_ID is the identifier
 *	advertized by a FILS capable AP identifying the scope of PMKSA in an
 *	ESS.
 * @NL80211_CMD_DEL_PMKSA: Delete a PMKSA cache entry, using %NL80211_ATTR_MAC
 *	(for the BSSID) and %NL80211_ATTR_PMKID or using %NL80211_ATTR_SSID,
 *	%NL80211_ATTR_FILS_CACHE_ID, and %NL80211_ATTR_PMKID in case of FILS
 *	authentication.
 * @NL80211_CMD_FLUSH_PMKSA: Flush all PMKSA cache entries.
 *
 * @NL80211_CMD_REG_CHANGE: indicates to userspace the regulatory domain
 * 	has been changed and provides details of the request information
 * 	that caused the change such as who initiated the regulatory request
 * 	(%NL80211_ATTR_REG_INITIATOR), the wiphy_idx
 * 	(%NL80211_ATTR_REG_ALPHA2) on which the request was made from if
 * 	the initiator was %NL80211_REGDOM_SET_BY_COUNTRY_IE or
 * 	%NL80211_REGDOM_SET_BY_DRIVER, the type of regulatory domain
 * 	set (%NL80211_ATTR_REG_TYPE), if the type of regulatory domain is
 * 	%NL80211_REG_TYPE_COUNTRY the alpha2 to which we have moved on
 * 	to (%NL80211_ATTR_REG_ALPHA2).
 * @NL80211_CMD_REG_BEACON_HINT: indicates to userspace that an AP beacon
 * 	has been found while world roaming thus enabling active scan or
 * 	any mode of operation that initiates TX (beacons) on a channel
 * 	where we would not have been able to do either before. As an example
 * 	if you are world roaming (regulatory domain set to world or if your
 * 	driver is using a custom world roaming regulatory domain) and while
 * 	doing a passive scan on the 5 GHz band you find an AP there (if not
 * 	on a DFS channel) you will now be able to actively scan for that AP
 * 	or use AP mode on your card on that same channel. Note that this will
 * 	never be used for channels 1-11 on the 2 GHz band as they are always
 * 	enabled world wide. This beacon hint is only sent if your device had
 * 	either disabled active scanning or beaconing on a channel. We send to
 * 	userspace the wiphy on which we removed a restriction from
 * 	(%NL80211_ATTR_WIPHY) and the channel on which this occurred
 * 	before (%NL80211_ATTR_FREQ_BEFORE) and after (%NL80211_ATTR_FREQ_AFTER)
 * 	the beacon hint was processed.
 *
 * @NL80211_CMD_AUTHENTICATE: authentication request and notification.
 *	This command is used both as a command (request to authenticate) and
 *	as an event on the "mlme" multicast group indicating completion of the
 *	authentication process.
 *	When used as a command, %NL80211_ATTR_IFINDEX is used to identify the
 *	interface. %NL80211_ATTR_MAC is used to specify PeerSTAAddress (and
 *	BSSID in case of station mode). %NL80211_ATTR_SSID is used to specify
 *	the SSID (mainly for association, but is included in authentication
 *	request, too, to help BSS selection. %NL80211_ATTR_WIPHY_FREQ +
 *	%NL80211_ATTR_WIPHY_FREQ_OFFSET is used to specify the frequence of the
 *	channel in MHz. %NL80211_ATTR_AUTH_TYPE is used to specify the
 *	authentication type. %NL80211_ATTR_IE is used to define IEs
 *	(VendorSpecificInfo, but also including RSN IE and FT IEs) to be added
 *	to the frame.
 *	When used as an event, this reports reception of an Authentication
 *	frame in station and IBSS modes when the local MLME processed the
 *	frame, i.e., it was for the local STA and was received in correct
 *	state. This is similar to MLME-AUTHENTICATE.confirm primitive in the
 *	MLME SAP interface (kernel providing MLME, userspace SME). The
 *	included %NL80211_ATTR_FRAME attribute contains the management frame
 *	(including both the header and frame body, but not FCS). This event is
 *	also used to indicate if the authentication attempt timed out. In that
 *	case the %NL80211_ATTR_FRAME attribute is replaced with a
 *	%NL80211_ATTR_TIMED_OUT flag (and %NL80211_ATTR_MAC to indicate which
 *	pending authentication timed out).
 * @NL80211_CMD_ASSOCIATE: association request and notification; like
 *	NL80211_CMD_AUTHENTICATE but for Association and Reassociation
 *	(similar to MLME-ASSOCIATE.request, MLME-REASSOCIATE.request,
 *	MLME-ASSOCIATE.confirm or MLME-REASSOCIATE.confirm primitives). The
 *	%NL80211_ATTR_PREV_BSSID attribute is used to specify whether the
 *	request is for the initial association to an ESS (that attribute not
 *	included) or for reassociation within the ESS (that attribute is
 *	included).
 * @NL80211_CMD_DEAUTHENTICATE: deauthentication request and notification; like
 *	NL80211_CMD_AUTHENTICATE but for Deauthentication frames (similar to
 *	MLME-DEAUTHENTICATION.request and MLME-DEAUTHENTICATE.indication
 *	primitives).
 * @NL80211_CMD_DISASSOCIATE: disassociation request and notification; like
 *	NL80211_CMD_AUTHENTICATE but for Disassociation frames (similar to
 *	MLME-DISASSOCIATE.request and MLME-DISASSOCIATE.indication primitives).
 *
 * @NL80211_CMD_MICHAEL_MIC_FAILURE: notification of a locally detected Michael
 *	MIC (part of TKIP) failure; sent on the "mlme" multicast group; the
 *	event includes %NL80211_ATTR_MAC to describe the source MAC address of
 *	the frame with invalid MIC, %NL80211_ATTR_KEY_TYPE to show the key
 *	type, %NL80211_ATTR_KEY_IDX to indicate the key identifier, and
 *	%NL80211_ATTR_KEY_SEQ to indicate the TSC value of the frame; this
 *	event matches with MLME-MICHAELMICFAILURE.indication() primitive
 *
 * @NL80211_CMD_JOIN_IBSS: Join a new IBSS -- given at least an SSID and a
 *	FREQ attribute (for the initial frequency if no peer can be found)
 *	and optionally a MAC (as BSSID) and FREQ_FIXED attribute if those
 *	should be fixed rather than automatically determined. Can only be
 *	executed on a network interface that is UP, and fixed BSSID/FREQ
 *	may be rejected. Another optional parameter is the beacon interval,
 *	given in the %NL80211_ATTR_BEACON_INTERVAL attribute, which if not
 *	given defaults to 100 TU (102.4ms).
 * @NL80211_CMD_LEAVE_IBSS: Leave the IBSS -- no special arguments, the IBSS is
 *	determined by the network interface.
 *
 * @NL80211_CMD_TESTMODE: testmode command, takes a wiphy (or ifindex) attribute
 *	to identify the device, and the TESTDATA blob attribute to pass through
 *	to the driver.
 *
 * @NL80211_CMD_CONNECT: connection request and notification; this command
 *	requests to connect to a specified network but without separating
 *	auth and assoc steps. For this, you need to specify the SSID in a
 *	%NL80211_ATTR_SSID attribute, and can optionally specify the association
 *	IEs in %NL80211_ATTR_IE, %NL80211_ATTR_AUTH_TYPE,
 *	%NL80211_ATTR_USE_MFP, %NL80211_ATTR_MAC, %NL80211_ATTR_WIPHY_FREQ,
 *	%NL80211_ATTR_WIPHY_FREQ_OFFSET, %NL80211_ATTR_CONTROL_PORT,
 *	%NL80211_ATTR_CONTROL_PORT_ETHERTYPE,
 *	%NL80211_ATTR_CONTROL_PORT_NO_ENCRYPT,
 *	%NL80211_ATTR_CONTROL_PORT_OVER_NL80211, %NL80211_ATTR_MAC_HINT, and
 *	%NL80211_ATTR_WIPHY_FREQ_HINT.
 *	If included, %NL80211_ATTR_MAC and %NL80211_ATTR_WIPHY_FREQ are
 *	restrictions on BSS selection, i.e., they effectively prevent roaming
 *	within the ESS. %NL80211_ATTR_MAC_HINT and %NL80211_ATTR_WIPHY_FREQ_HINT
 *	can be included to provide a recommendation of the initial BSS while
 *	allowing the driver to roam to other BSSes within the ESS and also to
 *	ignore this recommendation if the indicated BSS is not ideal. Only one
 *	set of BSSID,frequency parameters is used (i.e., either the enforcing
 *	%NL80211_ATTR_MAC,%NL80211_ATTR_WIPHY_FREQ or the less strict
 *	%NL80211_ATTR_MAC_HINT and %NL80211_ATTR_WIPHY_FREQ_HINT).
 *	Driver shall not modify the IEs specified through %NL80211_ATTR_IE if
 *	%NL80211_ATTR_MAC is included. However, if %NL80211_ATTR_MAC_HINT is
 *	included, these IEs through %NL80211_ATTR_IE are specified by the user
 *	space based on the best possible BSS selected. Thus, if the driver ends
 *	up selecting a different BSS, it can modify these IEs accordingly (e.g.
 *	userspace asks the driver to perform PMKSA caching with BSS1 and the
 *	driver ends up selecting BSS2 with different PMKSA cache entry; RSNIE
 *	has to get updated with the apt PMKID).
 *	%NL80211_ATTR_PREV_BSSID can be used to request a reassociation within
 *	the ESS in case the device is already associated and an association with
 *	a different BSS is desired.
 *	Background scan period can optionally be
 *	specified in %NL80211_ATTR_BG_SCAN_PERIOD,
 *	if not specified default background scan configuration
 *	in driver is used and if period value is 0, bg scan will be disabled.
 *	This attribute is ignored if driver does not support roam scan.
 *	It is also sent as an event, with the BSSID and response IEs when the
 *	connection is established or failed to be established. This can be
 *	determined by the %NL80211_ATTR_STATUS_CODE attribute (0 = success,
 *	non-zero = failure). If %NL80211_ATTR_TIMED_OUT is included in the
 *	event, the connection attempt failed due to not being able to initiate
 *	authentication/association or not receiving a response from the AP.
 *	Non-zero %NL80211_ATTR_STATUS_CODE value is indicated in that case as
 *	well to remain backwards compatible.
 * @NL80211_CMD_ROAM: Notification indicating the card/driver roamed by itself.
 *	When a security association was established on an 802.1X network using
 *	fast transition, this event should be followed by an
 *	%NL80211_CMD_PORT_AUTHORIZED event.
 *	Following a %NL80211_CMD_ROAM event userspace can issue
 *	%NL80211_CMD_GET_SCAN in order to obtain the scan information for the
 *	new BSS the card/driver roamed to.
 * @NL80211_CMD_DISCONNECT: drop a given connection; also used to notify
 *	userspace that a connection was dropped by the AP or due to other
 *	reasons, for this the %NL80211_ATTR_DISCONNECTED_BY_AP and
 *	%NL80211_ATTR_REASON_CODE attributes are used.
 *
 * @NL80211_CMD_SET_WIPHY_NETNS: Set a wiphy's netns. Note that all devices
 *	associated with this wiphy must be down and will follow.
 *
 * @NL80211_CMD_REMAIN_ON_CHANNEL: Request to remain awake on the specified
 *	channel for the specified amount of time. This can be used to do
 *	off-channel operations like transmit a Public Action frame and wait for
 *	a response while being associated to an AP on another channel.
 *	%NL80211_ATTR_IFINDEX is used to specify which interface (and thus
 *	radio) is used. %NL80211_ATTR_WIPHY_FREQ is used to specify the
 *	frequency for the operation.
 *	%NL80211_ATTR_DURATION is used to specify the duration in milliseconds
 *	to remain on the channel. This command is also used as an event to
 *	notify when the requested duration starts (it may take a while for the
 *	driver to schedule this time due to other concurrent needs for the
 *	radio).
 *	When called, this operation returns a cookie (%NL80211_ATTR_COOKIE)
 *	that will be included with any events pertaining to this request;
 *	the cookie is also used to cancel the request.
 * @NL80211_CMD_CANCEL_REMAIN_ON_CHANNEL: This command can be used to cancel a
 *	pending remain-on-channel duration if the desired operation has been
 *	completed prior to expiration of the originally requested duration.
 *	%NL80211_ATTR_WIPHY or %NL80211_ATTR_IFINDEX is used to specify the
 *	radio. The %NL80211_ATTR_COOKIE attribute must be given as well to
 *	uniquely identify the request.
 *	This command is also used as an event to notify when a requested
 *	remain-on-channel duration has expired.
 *
 * @NL80211_CMD_SET_TX_BITRATE_MASK: Set the mask of rates to be used in TX
 *	rate selection. %NL80211_ATTR_IFINDEX is used to specify the interface
 *	and @NL80211_ATTR_TX_RATES the set of allowed rates.
 *
 * @NL80211_CMD_REGISTER_FRAME: Register for receiving certain mgmt frames
 *	(via @NL80211_CMD_FRAME) for processing in userspace. This command
 *	requires an interface index, a frame type attribute (optional for
 *	backward compatibility reasons, if not given assumes action frames)
 *	and a match attribute containing the first few bytes of the frame
 *	that should match, e.g. a single byte for only a category match or
 *	four bytes for vendor frames including the OUI. The registration
 *	cannot be dropped, but is removed automatically when the netlink
 *	socket is closed. Multiple registrations can be made.
 *	The %NL80211_ATTR_RECEIVE_MULTICAST flag attribute can be given if
 *	%NL80211_EXT_FEATURE_MULTICAST_REGISTRATIONS is available, in which
 *	case the registration can also be modified to include/exclude the
 *	flag, rather than requiring unregistration to change it.
 * @NL80211_CMD_REGISTER_ACTION: Alias for @NL80211_CMD_REGISTER_FRAME for
 *	backward compatibility
 * @NL80211_CMD_FRAME: Management frame TX request and RX notification. This
 *	command is used both as a request to transmit a management frame and
 *	as an event indicating reception of a frame that was not processed in
 *	kernel code, but is for us (i.e., which may need to be processed in a
 *	user space application). %NL80211_ATTR_FRAME is used to specify the
 *	frame contents (including header). %NL80211_ATTR_WIPHY_FREQ is used
 *	to indicate on which channel the frame is to be transmitted or was
 *	received. If this channel is not the current channel (remain-on-channel
 *	or the operational channel) the device will switch to the given channel
 *	and transmit the frame, optionally waiting for a response for the time
 *	specified using %NL80211_ATTR_DURATION. When called, this operation
 *	returns a cookie (%NL80211_ATTR_COOKIE) that will be included with the
 *	TX status event pertaining to the TX request.
 *	%NL80211_ATTR_TX_NO_CCK_RATE is used to decide whether to send the
 *	management frames at CCK rate or not in 2GHz band.
 *	%NL80211_ATTR_CSA_C_OFFSETS_TX is an array of offsets to CSA
 *	counters which will be updated to the current value. This attribute
 *	is used during CSA period.
 *	For TX on an MLD, the frequency can be omitted and the link ID be
 *	specified, or if transmitting to a known peer MLD (with MLD addresses
 *	in the frame) both can be omitted and the link will be selected by
 *	lower layers.
 *	For RX notification, %NL80211_ATTR_RX_HW_TIMESTAMP may be included to
 *	indicate the frame RX timestamp and %NL80211_ATTR_TX_HW_TIMESTAMP may
 *	be included to indicate the ack TX timestamp.
 * @NL80211_CMD_FRAME_WAIT_CANCEL: When an off-channel TX was requested, this
 *	command may be used with the corresponding cookie to cancel the wait
 *	time if it is known that it is no longer necessary.  This command is
 *	also sent as an event whenever the driver has completed the off-channel
 *	wait time.
 * @NL80211_CMD_ACTION: Alias for @NL80211_CMD_FRAME for backward compatibility.
 * @NL80211_CMD_FRAME_TX_STATUS: Report TX status of a management frame
 *	transmitted with %NL80211_CMD_FRAME. %NL80211_ATTR_COOKIE identifies
 *	the TX command and %NL80211_ATTR_FRAME includes the contents of the
 *	frame. %NL80211_ATTR_ACK flag is included if the recipient acknowledged
 *	the frame. %NL80211_ATTR_TX_HW_TIMESTAMP may be included to indicate the
 *	tx timestamp and %NL80211_ATTR_RX_HW_TIMESTAMP may be included to
 *	indicate the ack RX timestamp.
 * @NL80211_CMD_ACTION_TX_STATUS: Alias for @NL80211_CMD_FRAME_TX_STATUS for
 *	backward compatibility.
 *
 * @NL80211_CMD_SET_POWER_SAVE: Set powersave, using %NL80211_ATTR_PS_STATE
 * @NL80211_CMD_GET_POWER_SAVE: Get powersave status in %NL80211_ATTR_PS_STATE
 *
 * @NL80211_CMD_SET_CQM: Connection quality monitor configuration. This command
 *	is used to configure connection quality monitoring notification trigger
 *	levels.
 * @NL80211_CMD_NOTIFY_CQM: Connection quality monitor notification. This
 *	command is used as an event to indicate the that a trigger level was
 *	reached.
 * @NL80211_CMD_SET_CHANNEL: Set the channel (using %NL80211_ATTR_WIPHY_FREQ
 *	and the attributes determining channel width) the given interface
 *	(identifed by %NL80211_ATTR_IFINDEX) shall operate on.
 *	In case multiple channels are supported by the device, the mechanism
 *	with which it switches channels is implementation-defined.
 *	When a monitor interface is given, it can only switch channel while
 *	no other interfaces are operating to avoid disturbing the operation
 *	of any other interfaces, and other interfaces will again take
 *	precedence when they are used.
 *
 * @NL80211_CMD_SET_WDS_PEER: Set the MAC address of the peer on a WDS interface
 *	(no longer supported).
 *
 * @NL80211_CMD_SET_MULTICAST_TO_UNICAST: Configure if this AP should perform
 *	multicast to unicast conversion. When enabled, all multicast packets
 *	with ethertype ARP, IPv4 or IPv6 (possibly within an 802.1Q header)
 *	will be sent out to each station once with the destination (multicast)
 *	MAC address replaced by the station's MAC address. Note that this may
 *	break certain expectations of the receiver, e.g. the ability to drop
 *	unicast IP packets encapsulated in multicast L2 frames, or the ability
 *	to not send destination unreachable messages in such cases.
 *	This can only be toggled per BSS. Configure this on an interface of
 *	type %NL80211_IFTYPE_AP. It applies to all its VLAN interfaces
 *	(%NL80211_IFTYPE_AP_VLAN), except for those in 4addr (WDS) mode.
 *	If %NL80211_ATTR_MULTICAST_TO_UNICAST_ENABLED is not present with this
 *	command, the feature is disabled.
 *
 * @NL80211_CMD_JOIN_MESH: Join a mesh. The mesh ID must be given, and initial
 *	mesh config parameters may be given.
 * @NL80211_CMD_LEAVE_MESH: Leave the mesh network -- no special arguments, the
 *	network is determined by the network interface.
 *
 * @NL80211_CMD_UNPROT_DEAUTHENTICATE: Unprotected deauthentication frame
 *	notification. This event is used to indicate that an unprotected
 *	deauthentication frame was dropped when MFP is in use.
 * @NL80211_CMD_UNPROT_DISASSOCIATE: Unprotected disassociation frame
 *	notification. This event is used to indicate that an unprotected
 *	disassociation frame was dropped when MFP is in use.
 *
 * @NL80211_CMD_NEW_PEER_CANDIDATE: Notification on the reception of a
 *      beacon or probe response from a compatible mesh peer.  This is only
 *      sent while no station information (sta_info) exists for the new peer
 *      candidate and when @NL80211_MESH_SETUP_USERSPACE_AUTH,
 *      @NL80211_MESH_SETUP_USERSPACE_AMPE, or
 *      @NL80211_MESH_SETUP_USERSPACE_MPM is set.  On reception of this
 *      notification, userspace may decide to create a new station
 *      (@NL80211_CMD_NEW_STATION).  To stop this notification from
 *      reoccurring, the userspace authentication daemon may want to create the
 *      new station with the AUTHENTICATED flag unset and maybe change it later
 *      depending on the authentication result.
 *
 * @NL80211_CMD_GET_WOWLAN: get Wake-on-Wireless-LAN (WoWLAN) settings.
 * @NL80211_CMD_SET_WOWLAN: set Wake-on-Wireless-LAN (WoWLAN) settings.
 *	Since wireless is more complex than wired ethernet, it supports
 *	various triggers. These triggers can be configured through this
 *	command with the %NL80211_ATTR_WOWLAN_TRIGGERS attribute. For
 *	more background information, see
 *	https://wireless.wiki.kernel.org/en/users/Documentation/WoWLAN.
 *	The @NL80211_CMD_SET_WOWLAN command can also be used as a notification
 *	from the driver reporting the wakeup reason. In this case, the
 *	@NL80211_ATTR_WOWLAN_TRIGGERS attribute will contain the reason
 *	for the wakeup, if it was caused by wireless. If it is not present
 *	in the wakeup notification, the wireless device didn't cause the
 *	wakeup but reports that it was woken up.
 *
 * @NL80211_CMD_SET_REKEY_OFFLOAD: This command is used give the driver
 *	the necessary information for supporting GTK rekey offload. This
 *	feature is typically used during WoWLAN. The configuration data
 *	is contained in %NL80211_ATTR_REKEY_DATA (which is nested and
 *	contains the data in sub-attributes). After rekeying happened,
 *	this command may also be sent by the driver as an MLME event to
 *	inform userspace of the new replay counter.
 *
 * @NL80211_CMD_PMKSA_CANDIDATE: This is used as an event to inform userspace
 *	of PMKSA caching dandidates.
 *
 * @NL80211_CMD_TDLS_OPER: Perform a high-level TDLS command (e.g. link setup).
 *	In addition, this can be used as an event to request userspace to take
 *	actions on TDLS links (set up a new link or tear down an existing one).
 *	In such events, %NL80211_ATTR_TDLS_OPERATION indicates the requested
 *	operation, %NL80211_ATTR_MAC contains the peer MAC address, and
 *	%NL80211_ATTR_REASON_CODE the reason code to be used (only with
 *	%NL80211_TDLS_TEARDOWN).
 * @NL80211_CMD_TDLS_MGMT: Send a TDLS management frame. The
 *	%NL80211_ATTR_TDLS_ACTION attribute determines the type of frame to be
 *	sent. Public Action codes (802.11-2012 8.1.5.1) will be sent as
 *	802.11 management frames, while TDLS action codes (802.11-2012
 *	8.5.13.1) will be encapsulated and sent as data frames. The currently
 *	supported Public Action code is %WLAN_PUB_ACTION_TDLS_DISCOVER_RES
 *	and the currently supported TDLS actions codes are given in
 *	&enum ieee80211_tdls_actioncode.
 *
 * @NL80211_CMD_UNEXPECTED_FRAME: Used by an application controlling an AP
 *	(or GO) interface (i.e. hostapd) to ask for unexpected frames to
 *	implement sending deauth to stations that send unexpected class 3
 *	frames. Also used as the event sent by the kernel when such a frame
 *	is received.
 *	For the event, the %NL80211_ATTR_MAC attribute carries the TA and
 *	other attributes like the interface index are present.
 *	If used as the command it must have an interface index and you can
 *	only unsubscribe from the event by closing the socket. Subscription
 *	is also for %NL80211_CMD_UNEXPECTED_4ADDR_FRAME events.
 *
 * @NL80211_CMD_UNEXPECTED_4ADDR_FRAME: Sent as an event indicating that the
 *	associated station identified by %NL80211_ATTR_MAC sent a 4addr frame
 *	and wasn't already in a 4-addr VLAN. The event will be sent similarly
 *	to the %NL80211_CMD_UNEXPECTED_FRAME event, to the same listener.
 *
 * @NL80211_CMD_PROBE_CLIENT: Probe an associated station on an AP interface
 *	by sending a null data frame to it and reporting when the frame is
 *	acknowleged. This is used to allow timing out inactive clients. Uses
 *	%NL80211_ATTR_IFINDEX and %NL80211_ATTR_MAC. The command returns a
 *	direct reply with an %NL80211_ATTR_COOKIE that is later used to match
 *	up the event with the request. The event includes the same data and
 *	has %NL80211_ATTR_ACK set if the frame was ACKed.
 *
 * @NL80211_CMD_REGISTER_BEACONS: Register this socket to receive beacons from
 *	other BSSes when any interfaces are in AP mode. This helps implement
 *	OLBC handling in hostapd. Beacons are reported in %NL80211_CMD_FRAME
 *	messages. Note that per PHY only one application may register.
 *
 * @NL80211_CMD_SET_NOACK_MAP: sets a bitmap for the individual TIDs whether
 *      No Acknowledgement Policy should be applied.
 *
 * @NL80211_CMD_CH_SWITCH_NOTIFY: An AP or GO may decide to switch channels
 *	independently of the userspace SME, send this event indicating
 *	%NL80211_ATTR_IFINDEX is now on %NL80211_ATTR_WIPHY_FREQ and the
 *	attributes determining channel width.  This indication may also be
 *	sent when a remotely-initiated switch (e.g., when a STA receives a CSA
 *	from the remote AP) is completed;
 *
 * @NL80211_CMD_CH_SWITCH_STARTED_NOTIFY: Notify that a channel switch
 *	has been started on an interface, regardless of the initiator
 *	(ie. whether it was requested from a remote device or
 *	initiated on our own).  It indicates that
 *	%NL80211_ATTR_IFINDEX will be on %NL80211_ATTR_WIPHY_FREQ
 *	after %NL80211_ATTR_CH_SWITCH_COUNT TBTT's.  The userspace may
 *	decide to react to this indication by requesting other
 *	interfaces to change channel as well.
 *
 * @NL80211_CMD_START_P2P_DEVICE: Start the given P2P Device, identified by
 *	its %NL80211_ATTR_WDEV identifier. It must have been created with
 *	%NL80211_CMD_NEW_INTERFACE previously. After it has been started, the
 *	P2P Device can be used for P2P operations, e.g. remain-on-channel and
 *	public action frame TX.
 * @NL80211_CMD_STOP_P2P_DEVICE: Stop the given P2P Device, identified by
 *	its %NL80211_ATTR_WDEV identifier.
 *
 * @NL80211_CMD_CONN_FAILED: connection request to an AP failed; used to
 *	notify userspace that AP has rejected the connection request from a
 *	station, due to particular reason. %NL80211_ATTR_CONN_FAILED_REASON
 *	is used for this.
 *
 * @NL80211_CMD_SET_MCAST_RATE: Change the rate used to send multicast frames
 *	for IBSS or MESH vif.
 *
 * @NL80211_CMD_SET_MAC_ACL: sets ACL for MAC address based access control.
 *	This is to be used with the drivers advertising the support of MAC
 *	address based access control. List of MAC addresses is passed in
 *	%NL80211_ATTR_MAC_ADDRS and ACL policy is passed in
 *	%NL80211_ATTR_ACL_POLICY. Driver will enable ACL with this list, if it
 *	is not already done. The new list will replace any existing list. Driver
 *	will clear its ACL when the list of MAC addresses passed is empty. This
 *	command is used in AP/P2P GO mode. Driver has to make sure to clear its
 *	ACL list during %NL80211_CMD_STOP_AP.
 *
 * @NL80211_CMD_RADAR_DETECT: Start a Channel availability check (CAC). Once
 *	a radar is detected or the channel availability scan (CAC) has finished
 *	or was aborted, or a radar was detected, usermode will be notified with
 *	this event. This command is also used to notify userspace about radars
 *	while operating on this channel.
 *	%NL80211_ATTR_RADAR_EVENT is used to inform about the type of the
 *	event.
 *
 * @NL80211_CMD_GET_PROTOCOL_FEATURES: Get global nl80211 protocol features,
 *	i.e. features for the nl80211 protocol rather than device features.
 *	Returns the features in the %NL80211_ATTR_PROTOCOL_FEATURES bitmap.
 *
 * @NL80211_CMD_UPDATE_FT_IES: Pass down the most up-to-date Fast Transition
 *	Information Element to the WLAN driver
 *
 * @NL80211_CMD_FT_EVENT: Send a Fast transition event from the WLAN driver
 *	to the supplicant. This will carry the target AP's MAC address along
 *	with the relevant Information Elements. This event is used to report
 *	received FT IEs (MDIE, FTIE, RSN IE, TIE, RICIE).
 *
 * @NL80211_CMD_CRIT_PROTOCOL_START: Indicates user-space will start running
 *	a critical protocol that needs more reliability in the connection to
 *	complete.
 *
 * @NL80211_CMD_CRIT_PROTOCOL_STOP: Indicates the connection reliability can
 *	return back to normal.
 *
 * @NL80211_CMD_GET_COALESCE: Get currently supported coalesce rules.
 * @NL80211_CMD_SET_COALESCE: Configure coalesce rules or clear existing rules.
 *
 * @NL80211_CMD_CHANNEL_SWITCH: Perform a channel switch by announcing the
 *	new channel information (Channel Switch Announcement - CSA)
 *	in the beacon for some time (as defined in the
 *	%NL80211_ATTR_CH_SWITCH_COUNT parameter) and then change to the
 *	new channel. Userspace provides the new channel information (using
 *	%NL80211_ATTR_WIPHY_FREQ and the attributes determining channel
 *	width). %NL80211_ATTR_CH_SWITCH_BLOCK_TX may be supplied to inform
 *	other station that transmission must be blocked until the channel
 *	switch is complete.
 *
 * @NL80211_CMD_VENDOR: Vendor-specified command/event. The command is specified
 *	by the %NL80211_ATTR_VENDOR_ID attribute and a sub-command in
 *	%NL80211_ATTR_VENDOR_SUBCMD. Parameter(s) can be transported in
 *	%NL80211_ATTR_VENDOR_DATA.
 *	For feature advertisement, the %NL80211_ATTR_VENDOR_DATA attribute is
 *	used in the wiphy data as a nested attribute containing descriptions
 *	(&struct nl80211_vendor_cmd_info) of the supported vendor commands.
 *	This may also be sent as an event with the same attributes.
 *
 * @NL80211_CMD_SET_QOS_MAP: Set Interworking QoS mapping for IP DSCP values.
 *	The QoS mapping information is included in %NL80211_ATTR_QOS_MAP. If
 *	that attribute is not included, QoS mapping is disabled. Since this
 *	QoS mapping is relevant for IP packets, it is only valid during an
 *	association. This is cleared on disassociation and AP restart.
 *
 * @NL80211_CMD_ADD_TX_TS: Ask the kernel to add a traffic stream for the given
 *	%NL80211_ATTR_TSID and %NL80211_ATTR_MAC with %NL80211_ATTR_USER_PRIO
 *	and %NL80211_ATTR_ADMITTED_TIME parameters.
 *	Note that the action frame handshake with the AP shall be handled by
 *	userspace via the normal management RX/TX framework, this only sets
 *	up the TX TS in the driver/device.
 *	If the admitted time attribute is not added then the request just checks
 *	if a subsequent setup could be successful, the intent is to use this to
 *	avoid setting up a session with the AP when local restrictions would
 *	make that impossible. However, the subsequent "real" setup may still
 *	fail even if the check was successful.
 * @NL80211_CMD_DEL_TX_TS: Remove an existing TS with the %NL80211_ATTR_TSID
 *	and %NL80211_ATTR_MAC parameters. It isn't necessary to call this
 *	before removing a station entry entirely, or before disassociating
 *	or similar, cleanup will happen in the driver/device in this case.
 *
 * @NL80211_CMD_GET_MPP: Get mesh path attributes for mesh proxy path to
 *	destination %NL80211_ATTR_MAC on the interface identified by
 *	%NL80211_ATTR_IFINDEX.
 *
 * @NL80211_CMD_JOIN_OCB: Join the OCB network. The center frequency and
 *	bandwidth of a channel must be given.
 * @NL80211_CMD_LEAVE_OCB: Leave the OCB network -- no special arguments, the
 *	network is determined by the network interface.
 *
 * @NL80211_CMD_TDLS_CHANNEL_SWITCH: Start channel-switching with a TDLS peer,
 *	identified by the %NL80211_ATTR_MAC parameter. A target channel is
 *	provided via %NL80211_ATTR_WIPHY_FREQ and other attributes determining
 *	channel width/type. The target operating class is given via
 *	%NL80211_ATTR_OPER_CLASS.
 *	The driver is responsible for continually initiating channel-switching
 *	operations and returning to the base channel for communication with the
 *	AP.
 * @NL80211_CMD_TDLS_CANCEL_CHANNEL_SWITCH: Stop channel-switching with a TDLS
 *	peer given by %NL80211_ATTR_MAC. Both peers must be on the base channel
 *	when this command completes.
 *
 * @NL80211_CMD_WIPHY_REG_CHANGE: Similar to %NL80211_CMD_REG_CHANGE, but used
 *	as an event to indicate changes for devices with wiphy-specific regdom
 *	management.
 *
 * @NL80211_CMD_ABORT_SCAN: Stop an ongoing scan. Returns -ENOENT if a scan is
 *	not running. The driver indicates the status of the scan through
 *	cfg80211_scan_done().
 *
 * @NL80211_CMD_START_NAN: Start NAN operation, identified by its
 *	%NL80211_ATTR_WDEV interface. This interface must have been
 *	previously created with %NL80211_CMD_NEW_INTERFACE. After it
 *	has been started, the NAN interface will create or join a
 *	cluster. This command must have a valid
 *	%NL80211_ATTR_NAN_MASTER_PREF attribute and optional
 *	%NL80211_ATTR_BANDS attributes.  If %NL80211_ATTR_BANDS is
 *	omitted or set to 0, it means don't-care and the device will
 *	decide what to use.  After this command NAN functions can be
 *	added.
 * @NL80211_CMD_STOP_NAN: Stop the NAN operation, identified by
 *	its %NL80211_ATTR_WDEV interface.
 * @NL80211_CMD_ADD_NAN_FUNCTION: Add a NAN function. The function is defined
 *	with %NL80211_ATTR_NAN_FUNC nested attribute. When called, this
 *	operation returns the strictly positive and unique instance id
 *	(%NL80211_ATTR_NAN_FUNC_INST_ID) and a cookie (%NL80211_ATTR_COOKIE)
 *	of the function upon success.
 *	Since instance ID's can be re-used, this cookie is the right
 *	way to identify the function. This will avoid races when a termination
 *	event is handled by the user space after it has already added a new
 *	function that got the same instance id from the kernel as the one
 *	which just terminated.
 *	This cookie may be used in NAN events even before the command
 *	returns, so userspace shouldn't process NAN events until it processes
 *	the response to this command.
 *	Look at %NL80211_ATTR_SOCKET_OWNER as well.
 * @NL80211_CMD_DEL_NAN_FUNCTION: Delete a NAN function by cookie.
 *	This command is also used as a notification sent when a NAN function is
 *	terminated. This will contain a %NL80211_ATTR_NAN_FUNC_INST_ID
 *	and %NL80211_ATTR_COOKIE attributes.
 * @NL80211_CMD_CHANGE_NAN_CONFIG: Change current NAN
 *	configuration. NAN must be operational (%NL80211_CMD_START_NAN
 *	was executed).  It must contain at least one of the following
 *	attributes: %NL80211_ATTR_NAN_MASTER_PREF,
 *	%NL80211_ATTR_BANDS.  If %NL80211_ATTR_BANDS is omitted, the
 *	current configuration is not changed.  If it is present but
 *	set to zero, the configuration is changed to don't-care
 *	(i.e. the device can decide what to do).
 * @NL80211_CMD_NAN_FUNC_MATCH: Notification sent when a match is reported.
 *	This will contain a %NL80211_ATTR_NAN_MATCH nested attribute and
 *	%NL80211_ATTR_COOKIE.
 *
 * @NL80211_CMD_UPDATE_CONNECT_PARAMS: Update one or more connect parameters
 *	for subsequent roaming cases if the driver or firmware uses internal
 *	BSS selection. This command can be issued only while connected and it
 *	does not result in a change for the current association. Currently,
 *	only the %NL80211_ATTR_IE data is used and updated with this command.
 *
 * @NL80211_CMD_SET_PMK: For offloaded 4-Way handshake, set the PMK or PMK-R0
 *	for the given authenticator address (specified with %NL80211_ATTR_MAC).
 *	When %NL80211_ATTR_PMKR0_NAME is set, %NL80211_ATTR_PMK specifies the
 *	PMK-R0, otherwise it specifies the PMK.
 * @NL80211_CMD_DEL_PMK: For offloaded 4-Way handshake, delete the previously
 *	configured PMK for the authenticator address identified by
 *	%NL80211_ATTR_MAC.
 * @NL80211_CMD_PORT_AUTHORIZED: An event that indicates an 802.1X FT roam was
 *	completed successfully. Drivers that support 4 way handshake offload
 *	should send this event after indicating 802.1X FT assocation with
 *	%NL80211_CMD_ROAM. If the 4 way handshake failed %NL80211_CMD_DISCONNECT
 *	should be indicated instead.
 * @NL80211_CMD_CONTROL_PORT_FRAME: Control Port (e.g. PAE) frame TX request
 *	and RX notification.  This command is used both as a request to transmit
 *	a control port frame and as a notification that a control port frame
 *	has been received. %NL80211_ATTR_FRAME is used to specify the
 *	frame contents.  The frame is the raw EAPoL data, without ethernet or
 *	802.11 headers.
 *	For an MLD transmitter, the %NL80211_ATTR_MLO_LINK_ID may be given and
 *	its effect will depend on the destination: If the destination is known
 *	to be an MLD, this will be used as a hint to select the link to transmit
 *	the frame on. If the destination is not an MLD, this will select both
 *	the link to transmit on and the source address will be set to the link
 *	address of that link.
 *	When used as an event indication %NL80211_ATTR_CONTROL_PORT_ETHERTYPE,
 *	%NL80211_ATTR_CONTROL_PORT_NO_ENCRYPT and %NL80211_ATTR_MAC are added
 *	indicating the protocol type of the received frame; whether the frame
 *	was received unencrypted and the MAC address of the peer respectively.
 *
 * @NL80211_CMD_RELOAD_REGDB: Request that the regdb firmware file is reloaded.
 *
 * @NL80211_CMD_EXTERNAL_AUTH: This interface is exclusively defined for host
 *	drivers that do not define separate commands for authentication and
 *	association, but rely on user space for the authentication to happen.
 *	This interface acts both as the event request (driver to user space)
 *	to trigger the authentication and command response (userspace to
 *	driver) to indicate the authentication status.
 *
 *	User space uses the %NL80211_CMD_CONNECT command to the host driver to
 *	trigger a connection. The host driver selects a BSS and further uses
 *	this interface to offload only the authentication part to the user
 *	space. Authentication frames are passed between the driver and user
 *	space through the %NL80211_CMD_FRAME interface. Host driver proceeds
 *	further with the association after getting successful authentication
 *	status. User space indicates the authentication status through
 *	%NL80211_ATTR_STATUS_CODE attribute in %NL80211_CMD_EXTERNAL_AUTH
 *	command interface.
 *
 *	Host driver sends MLD address of the AP with %NL80211_ATTR_MLD_ADDR in
 *	%NL80211_CMD_EXTERNAL_AUTH event to indicate user space to enable MLO
 *	during the authentication offload in STA mode while connecting to MLD
 *	APs. Host driver should check %NL80211_ATTR_MLO_SUPPORT flag capability
 *	in %NL80211_CMD_CONNECT to know whether the user space supports enabling
 *	MLO during the authentication offload or not.
 *	User space should enable MLO during the authentication only when it
 *	receives the AP MLD address in authentication offload request. User
 *	space shouldn't enable MLO when the authentication offload request
 *	doesn't indicate the AP MLD address even if the AP is MLO capable.
 *	User space should use %NL80211_ATTR_MLD_ADDR as peer's MLD address and
 *	interface address identified by %NL80211_ATTR_IFINDEX as self MLD
 *	address. User space and host driver to use MLD addresses in RA, TA and
 *	BSSID fields of the frames between them, and host driver translates the
 *	MLD addresses to/from link addresses based on the link chosen for the
 *	authentication.
 *
 *	Host driver reports this status on an authentication failure to the
 *	user space through the connect result as the user space would have
 *	initiated the connection through the connect request.
 *
 * @NL80211_CMD_STA_OPMODE_CHANGED: An event that notify station's
 *	ht opmode or vht opmode changes using any of %NL80211_ATTR_SMPS_MODE,
 *	%NL80211_ATTR_CHANNEL_WIDTH,%NL80211_ATTR_NSS attributes with its
 *	address(specified in %NL80211_ATTR_MAC).
 *
 * @NL80211_CMD_GET_FTM_RESPONDER_STATS: Retrieve FTM responder statistics, in
 *	the %NL80211_ATTR_FTM_RESPONDER_STATS attribute.
 *
 * @NL80211_CMD_PEER_MEASUREMENT_START: start a (set of) peer measurement(s)
 *	with the given parameters, which are encapsulated in the nested
 *	%NL80211_ATTR_PEER_MEASUREMENTS attribute. Optionally, MAC address
 *	randomization may be enabled and configured by specifying the
 *	%NL80211_ATTR_MAC and %NL80211_ATTR_MAC_MASK attributes.
 *	If a timeout is requested, use the %NL80211_ATTR_TIMEOUT attribute.
 *	A u64 cookie for further %NL80211_ATTR_COOKIE use is returned in
 *	the netlink extended ack message.
 *
 *	To cancel a measurement, close the socket that requested it.
 *
 *	Measurement results are reported to the socket that requested the
 *	measurement using @NL80211_CMD_PEER_MEASUREMENT_RESULT when they
 *	become available, so applications must ensure a large enough socket
 *	buffer size.
 *
 *	Depending on driver support it may or may not be possible to start
 *	multiple concurrent measurements.
 * @NL80211_CMD_PEER_MEASUREMENT_RESULT: This command number is used for the
 *	result notification from the driver to the requesting socket.
 * @NL80211_CMD_PEER_MEASUREMENT_COMPLETE: Notification only, indicating that
 *	the measurement completed, using the measurement cookie
 *	(%NL80211_ATTR_COOKIE).
 *
 * @NL80211_CMD_NOTIFY_RADAR: Notify the kernel that a radar signal was
 *	detected and reported by a neighboring device on the channel
 *	indicated by %NL80211_ATTR_WIPHY_FREQ and other attributes
 *	determining the width and type.
 *
 * @NL80211_CMD_UPDATE_OWE_INFO: This interface allows the host driver to
 *	offload OWE processing to user space. This intends to support
 *	OWE AKM by the host drivers that implement SME but rely
 *	on the user space for the cryptographic/DH IE processing in AP mode.
 *
 * @NL80211_CMD_PROBE_MESH_LINK: The requirement for mesh link metric
 *	refreshing, is that from one mesh point we be able to send some data
 *	frames to other mesh points which are not currently selected as a
 *	primary traffic path, but which are only 1 hop away. The absence of
 *	the primary path to the chosen node makes it necessary to apply some
 *	form of marking on a chosen packet stream so that the packets can be
 *	properly steered to the selected node for testing, and not by the
 *	regular mesh path lookup. Further, the packets must be of type data
 *	so that the rate control (often embedded in firmware) is used for
 *	rate selection.
 *
 *	Here attribute %NL80211_ATTR_MAC is used to specify connected mesh
 *	peer MAC address and %NL80211_ATTR_FRAME is used to specify the frame
 *	content. The frame is ethernet data.
 *
 * @NL80211_CMD_SET_TID_CONFIG: Data frame TID specific configuration
 *	is passed using %NL80211_ATTR_TID_CONFIG attribute.
 *
 * @NL80211_CMD_UNPROT_BEACON: Unprotected or incorrectly protected Beacon
 *	frame. This event is used to indicate that a received Beacon frame was
 *	dropped because it did not include a valid MME MIC while beacon
 *	protection was enabled (BIGTK configured in station mode).
 *
 * @NL80211_CMD_CONTROL_PORT_FRAME_TX_STATUS: Report TX status of a control
 *	port frame transmitted with %NL80211_CMD_CONTROL_PORT_FRAME.
 *	%NL80211_ATTR_COOKIE identifies the TX command and %NL80211_ATTR_FRAME
 *	includes the contents of the frame. %NL80211_ATTR_ACK flag is included
 *	if the recipient acknowledged the frame.
 *
 * @NL80211_CMD_SET_SAR_SPECS: SAR power limitation configuration is
 *	passed using %NL80211_ATTR_SAR_SPEC. %NL80211_ATTR_WIPHY is used to
 *	specify the wiphy index to be applied to.
 *
 * @NL80211_CMD_OBSS_COLOR_COLLISION: This notification is sent out whenever
 *	mac80211/drv detects a bss color collision.
 *
 * @NL80211_CMD_COLOR_CHANGE_REQUEST: This command is used to indicate that
 *	userspace wants to change the BSS color.
 *
 * @NL80211_CMD_COLOR_CHANGE_STARTED: Notify userland, that a color change has
 *	started
 *
 * @NL80211_CMD_COLOR_CHANGE_ABORTED: Notify userland, that the color change has
 *	been aborted
 *
 * @NL80211_CMD_COLOR_CHANGE_COMPLETED: Notify userland that the color change
 *	has completed
 *
 * @NL80211_CMD_SET_FILS_AAD: Set FILS AAD data to the driver using -
 *	&NL80211_ATTR_MAC - for STA MAC address
 *	&NL80211_ATTR_FILS_KEK - for KEK
 *	&NL80211_ATTR_FILS_NONCES - for FILS Nonces
 *		(STA Nonce 16 bytes followed by AP Nonce 16 bytes)
 *
 * @NL80211_CMD_ASSOC_COMEBACK: notification about an association
 *      temporal rejection with comeback. The event includes %NL80211_ATTR_MAC
 *      to describe the BSSID address of the AP and %NL80211_ATTR_TIMEOUT to
 *      specify the timeout value.
 *
 * @NL80211_CMD_ADD_LINK: Add a new link to an interface. The
 *	%NL80211_ATTR_MLO_LINK_ID attribute is used for the new link.
 * @NL80211_CMD_REMOVE_LINK: Remove a link from an interface. This may come
 *	without %NL80211_ATTR_MLO_LINK_ID as an easy way to remove all links
 *	in preparation for e.g. roaming to a regular (non-MLO) AP.
 *
 * @NL80211_CMD_ADD_LINK_STA: Add a link to an MLD station
 * @NL80211_CMD_MODIFY_LINK_STA: Modify a link of an MLD station
 * @NL80211_CMD_REMOVE_LINK_STA: Remove a link of an MLD station
 *
 * @NL80211_CMD_SET_HW_TIMESTAMP: Enable/disable HW timestamping of Timing
 *	measurement and Fine timing measurement frames. If %NL80211_ATTR_MAC
 *	is included, enable/disable HW timestamping only for frames to/from the
 *	specified MAC address. Otherwise enable/disable HW timestamping for
 *	all TM/FTM frames (including ones that were enabled with specific MAC
 *	address). If %NL80211_ATTR_HW_TIMESTAMP_ENABLED is not included, disable
 *	HW timestamping.
 *	The number of peers that HW timestamping can be enabled for concurrently
 *	is indicated by %NL80211_ATTR_MAX_HW_TIMESTAMP_PEERS.
 *
 * @NL80211_CMD_MAX: highest used command number
 * @__NL80211_CMD_AFTER_LAST: internal use
 */
public enum Nl80211Command : byte
/* don't change the order or add anything between, this is ABI! */
{
    /// <summary>
    /// unspecified command to catch errors
    /// </summary>
    NL80211_CMD_UNSPEC,

    /// <summary>
    /// Request information about a wiphy or dump request to get a list of all present wiphys.
    /// can dump
    /// </summary>
    NL80211_CMD_GET_WIPHY,
    NL80211_CMD_SET_WIPHY,
    NL80211_CMD_NEW_WIPHY,
    NL80211_CMD_DEL_WIPHY,

    NL80211_CMD_GET_INTERFACE,  /* can dump */
    NL80211_CMD_SET_INTERFACE,
    NL80211_CMD_NEW_INTERFACE,
    NL80211_CMD_DEL_INTERFACE,

    NL80211_CMD_GET_KEY,
    NL80211_CMD_SET_KEY,
    NL80211_CMD_NEW_KEY,
    NL80211_CMD_DEL_KEY,

    NL80211_CMD_GET_BEACON,
    NL80211_CMD_SET_BEACON,
    NL80211_CMD_START_AP,
    NL80211_CMD_NEW_BEACON = NL80211_CMD_START_AP,
    NL80211_CMD_STOP_AP,
    NL80211_CMD_DEL_BEACON = NL80211_CMD_STOP_AP,

    NL80211_CMD_GET_STATION,
    NL80211_CMD_SET_STATION,
    NL80211_CMD_NEW_STATION,
    NL80211_CMD_DEL_STATION,

    NL80211_CMD_GET_MPATH,
    NL80211_CMD_SET_MPATH,
    NL80211_CMD_NEW_MPATH,
    NL80211_CMD_DEL_MPATH,

    NL80211_CMD_SET_BSS,

    NL80211_CMD_SET_REG,
    NL80211_CMD_REQ_SET_REG,

    NL80211_CMD_GET_MESH_CONFIG,
    NL80211_CMD_SET_MESH_CONFIG,

    NL80211_CMD_SET_MGMT_EXTRA_IE /* reserved; not used */,

    NL80211_CMD_GET_REG,

    NL80211_CMD_GET_SCAN,
    NL80211_CMD_TRIGGER_SCAN,
    NL80211_CMD_NEW_SCAN_RESULTS,
    NL80211_CMD_SCAN_ABORTED,

    NL80211_CMD_REG_CHANGE,

    NL80211_CMD_AUTHENTICATE,
    NL80211_CMD_ASSOCIATE,
    NL80211_CMD_DEAUTHENTICATE,
    NL80211_CMD_DISASSOCIATE,

    NL80211_CMD_MICHAEL_MIC_FAILURE,

    NL80211_CMD_REG_BEACON_HINT,

    NL80211_CMD_JOIN_IBSS,
    NL80211_CMD_LEAVE_IBSS,

    NL80211_CMD_TESTMODE,

    NL80211_CMD_CONNECT,
    NL80211_CMD_ROAM,
    NL80211_CMD_DISCONNECT,

    NL80211_CMD_SET_WIPHY_NETNS,

    NL80211_CMD_GET_SURVEY,
    NL80211_CMD_NEW_SURVEY_RESULTS,

    NL80211_CMD_SET_PMKSA,
    NL80211_CMD_DEL_PMKSA,
    NL80211_CMD_FLUSH_PMKSA,

    NL80211_CMD_REMAIN_ON_CHANNEL,
    NL80211_CMD_CANCEL_REMAIN_ON_CHANNEL,

    NL80211_CMD_SET_TX_BITRATE_MASK,

    NL80211_CMD_REGISTER_FRAME,
    NL80211_CMD_REGISTER_ACTION = NL80211_CMD_REGISTER_FRAME,
    NL80211_CMD_FRAME,
    NL80211_CMD_ACTION = NL80211_CMD_FRAME,
    NL80211_CMD_FRAME_TX_STATUS,
    NL80211_CMD_ACTION_TX_STATUS = NL80211_CMD_FRAME_TX_STATUS,

    NL80211_CMD_SET_POWER_SAVE,
    NL80211_CMD_GET_POWER_SAVE,

    NL80211_CMD_SET_CQM,
    NL80211_CMD_NOTIFY_CQM,

    NL80211_CMD_SET_CHANNEL,
    NL80211_CMD_SET_WDS_PEER,

    NL80211_CMD_FRAME_WAIT_CANCEL,

    NL80211_CMD_JOIN_MESH,
    NL80211_CMD_LEAVE_MESH,

    NL80211_CMD_UNPROT_DEAUTHENTICATE,
    NL80211_CMD_UNPROT_DISASSOCIATE,

    NL80211_CMD_NEW_PEER_CANDIDATE,

    NL80211_CMD_GET_WOWLAN,
    NL80211_CMD_SET_WOWLAN,

    NL80211_CMD_START_SCHED_SCAN,
    NL80211_CMD_STOP_SCHED_SCAN,
    NL80211_CMD_SCHED_SCAN_RESULTS,
    NL80211_CMD_SCHED_SCAN_STOPPED,

    NL80211_CMD_SET_REKEY_OFFLOAD,

    NL80211_CMD_PMKSA_CANDIDATE,

    NL80211_CMD_TDLS_OPER,
    NL80211_CMD_TDLS_MGMT,

    NL80211_CMD_UNEXPECTED_FRAME,

    NL80211_CMD_PROBE_CLIENT,

    NL80211_CMD_REGISTER_BEACONS,

    NL80211_CMD_UNEXPECTED_4ADDR_FRAME,

    NL80211_CMD_SET_NOACK_MAP,

    NL80211_CMD_CH_SWITCH_NOTIFY,

    NL80211_CMD_START_P2P_DEVICE,
    NL80211_CMD_STOP_P2P_DEVICE,

    NL80211_CMD_CONN_FAILED,

    NL80211_CMD_SET_MCAST_RATE,

    NL80211_CMD_SET_MAC_ACL,

    NL80211_CMD_RADAR_DETECT,

    NL80211_CMD_GET_PROTOCOL_FEATURES,

    NL80211_CMD_UPDATE_FT_IES,
    NL80211_CMD_FT_EVENT,

    NL80211_CMD_CRIT_PROTOCOL_START,
    NL80211_CMD_CRIT_PROTOCOL_STOP,

    NL80211_CMD_GET_COALESCE,
    NL80211_CMD_SET_COALESCE,

    NL80211_CMD_CHANNEL_SWITCH,

    NL80211_CMD_VENDOR,

    NL80211_CMD_SET_QOS_MAP,

    NL80211_CMD_ADD_TX_TS,
    NL80211_CMD_DEL_TX_TS,

    NL80211_CMD_GET_MPP,

    NL80211_CMD_JOIN_OCB,
    NL80211_CMD_LEAVE_OCB,

    NL80211_CMD_CH_SWITCH_STARTED_NOTIFY,

    NL80211_CMD_TDLS_CHANNEL_SWITCH,
    NL80211_CMD_TDLS_CANCEL_CHANNEL_SWITCH,

    NL80211_CMD_WIPHY_REG_CHANGE,

    NL80211_CMD_ABORT_SCAN,

    NL80211_CMD_START_NAN,
    NL80211_CMD_STOP_NAN,
    NL80211_CMD_ADD_NAN_FUNCTION,
    NL80211_CMD_DEL_NAN_FUNCTION,
    NL80211_CMD_CHANGE_NAN_CONFIG,
    NL80211_CMD_NAN_MATCH,

    NL80211_CMD_SET_MULTICAST_TO_UNICAST,

    NL80211_CMD_UPDATE_CONNECT_PARAMS,

    NL80211_CMD_SET_PMK,
    NL80211_CMD_DEL_PMK,

    NL80211_CMD_PORT_AUTHORIZED,

    NL80211_CMD_RELOAD_REGDB,

    NL80211_CMD_EXTERNAL_AUTH,

    NL80211_CMD_STA_OPMODE_CHANGED,

    NL80211_CMD_CONTROL_PORT_FRAME,

    NL80211_CMD_GET_FTM_RESPONDER_STATS,

    NL80211_CMD_PEER_MEASUREMENT_START,
    NL80211_CMD_PEER_MEASUREMENT_RESULT,
    NL80211_CMD_PEER_MEASUREMENT_COMPLETE,

    NL80211_CMD_NOTIFY_RADAR,

    NL80211_CMD_UPDATE_OWE_INFO,

    NL80211_CMD_PROBE_MESH_LINK,

    NL80211_CMD_SET_TID_CONFIG,

    NL80211_CMD_UNPROT_BEACON,

    NL80211_CMD_CONTROL_PORT_FRAME_TX_STATUS,

    NL80211_CMD_SET_SAR_SPECS,

    NL80211_CMD_OBSS_COLOR_COLLISION,

    NL80211_CMD_COLOR_CHANGE_REQUEST,

    NL80211_CMD_COLOR_CHANGE_STARTED,
    NL80211_CMD_COLOR_CHANGE_ABORTED,
    NL80211_CMD_COLOR_CHANGE_COMPLETED,

    NL80211_CMD_SET_FILS_AAD,

    NL80211_CMD_ASSOC_COMEBACK,

    NL80211_CMD_ADD_LINK,
    NL80211_CMD_REMOVE_LINK,

    NL80211_CMD_ADD_LINK_STA,
    NL80211_CMD_MODIFY_LINK_STA,
    NL80211_CMD_REMOVE_LINK_STA,

    NL80211_CMD_SET_HW_TIMESTAMP,

    /* add new commands above here */

    /* used to define NL80211_CMD_MAX below */
    __NL80211_CMD_AFTER_LAST,
    NL80211_CMD_MAX = __NL80211_CMD_AFTER_LAST - 1
}