namespace NaroCppCore.Occ.CDF
{
	public enum CDFRetrievableStatus{
		CDF_RS_OK,
		CDF_RS_AlreadyRetrievedAndModified,
		CDF_RS_AlreadyRetrieved,
		CDF_RS_UnknownDocument,
		CDF_RS_NoDriver,
		CDF_RS_UnknownFileDriver,
		CDF_RS_WrongResource,
		CDF_RS_OpenError,
		CDF_RS_NoVersion,
		CDF_RS_NoModel,
		CDF_RS_NoSchema,
		CDF_RS_NoDocument,
		CDF_RS_ExtensionFailure,
		CDF_RS_WrongStreamMode,
		CDF_RS_FormatFailure,
		CDF_RS_TypeFailure,
		CDF_RS_TypeNotFoundInSchema,
		CDF_RS_UnrecognizedFileFormat,
		CDF_RS_MakeFailure,
		CDF_RS_PermissionDenied,
		CDF_RS_DriverFailure,
	}
}
