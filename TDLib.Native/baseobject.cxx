#include "tdcxxbridge.h"

using namespace td::td_api;


EXPORT int td_bridge_object_get_id(BaseObject *obj) {
    return obj->get_id();
}

EXPORT void td_bridge_object_destroy(BaseObject *obj) {
    delete obj;
}


