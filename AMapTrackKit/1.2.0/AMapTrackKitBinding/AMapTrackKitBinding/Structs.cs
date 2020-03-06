using ObjCRuntime;

namespace AMapTrackKit
{

	[Native]
	public enum AMapTrackErrorCode : long
	{
		CodeUnknow = 100,
		CodeInvalidOption = 101,
		CodeServiceStarted = 102,
		CodeServiceStopped = 103,
		CodeGatherStarted = 104,
		CodeGatherStopped = 105,
		CodeLocationAuthFailed = 106,
		CodeLocateError = 107,
		NoResponseData = 1800,
		InvalidProtocol = 1801,
		TimeOut = 1802,
		BadURL = 1803,
		CannotFindHost = 1804,
		CannotConnectToHost = 1805,
		NotConnectedToInternet = 1806,
		Cancelled = 1807,
		BadCustomDictionary = 2031,
		Ok = 10000,
		InvalidUserKey = 10001,
		ServiceNotAvailable = 10002,
		DailyQueryOverLimit = 10003,
		TooFrequently = 10004,
		InvalidUserIP = 10005,
		InvalidUserDomain = 10006,
		InvalidSignature = 10007,
		InvalidUserSCode = 10008,
		UserKeyNotMatch = 10009,
		IPQueryOverLimit = 10010,
		NotSupportHttps = 10011,
		InsufficientPrivileges = 10012,
		UserKeyRecycled = 10013,
		QPSHasExceededLimit = 10014,
		GatewayTimeout = 10015,
		ServerIsBusy = 10016,
		ResourceUnavailable = 10017,
		InvalidParams = 20000,
		MissingRequiredParams = 20001,
		IllegalRequest = 20002,
		ServiceUnknown = 20003,
		DuplicatedElement = 20009,
		ElementNotExist = 20010,
		ServiceNotExist = 20050,
		TerminalNotExist = 20051,
		UploadPointPartlyError = 20100,
		UploadPointError = 20101,
		CountOverLimit = 20150
	}

	[Native]
	public enum AMapTrackRecoupMode : ulong
	{
		None = 0,
		Driving = 1
	}
}

