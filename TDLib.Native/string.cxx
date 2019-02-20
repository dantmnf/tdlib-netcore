#include "tdcxxbridge.h"


EXPORT const char* td_bridge_string_data(const std::string *strptr, std::int64_t *size) {
	if (strptr == nullptr) {
		*size = 0;
		return nullptr;
	}
	*size = strptr->size();
	return strptr->data();
}

EXPORT void td_bridge_string_setdata(std::string *strptr, const char *data, std::int64_t size) {
	if (strptr == nullptr) {
		return;
	}
	std::string str2(data, (size_t)size);
	strptr->swap(str2);
}

