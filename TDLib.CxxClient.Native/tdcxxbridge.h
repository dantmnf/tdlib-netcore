#include "td/telegram/td_api.h"
#include "td/telegram/Log.h"
#include "td/telegram/Client.h"

#ifdef _WIN32
#define EXPORT extern "C" __declspec(dllexport)
#else
#define EXPORT extern "C"
#endif

typedef void(__cdecl* FetchObjectCallback)(td::td_api::Object*, int64_t);
