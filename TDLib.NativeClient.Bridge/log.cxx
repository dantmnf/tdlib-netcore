#include "tdcxxbridge.h"
#include <cstdint>

EXPORT int td_bridge_log_set_file_path(const char *path, int64_t len) {
	return td::Log::set_file_path(std::string(path, (size_t)len));
}

EXPORT void td_bridge_log_set_max_file_size(int64_t len) {
	td::Log::set_max_file_size(len);
}

EXPORT void td_bridge_log_set_verbosity_level(int level) {
	td::Log::set_verbosity_level(level);
}

EXPORT void td_bridge_log_set_fatal_error_callback(td::Log::FatalErrorCallbackPtr callback) {
	td::Log::set_fatal_error_callback(callback);
}
