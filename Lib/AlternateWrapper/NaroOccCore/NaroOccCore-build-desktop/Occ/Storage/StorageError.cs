namespace NaroCppCore.Occ.Storage
{
	public enum StorageError{
		Storage_VSOk,
		Storage_VSOpenError,
		Storage_VSModeError,
		Storage_VSCloseError,
		Storage_VSAlreadyOpen,
		Storage_VSNotOpen,
		Storage_VSSectionNotFound,
		Storage_VSWriteError,
		Storage_VSFormatError,
		Storage_VSUnknownType,
		Storage_VSTypeMismatch,
		Storage_VSInternalError,
		Storage_VSExtCharParityError,
		Storage_VSWrongFileDriver,
	}
}
