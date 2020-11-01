#include "tdcxxbridge.h"

using namespace td::td_api;

EXPORT BaseObject *td_bridge_object_ptr_get(object_ptr<BaseObject> *ptr) {
	return ptr->get();
}

EXPORT void td_bridge_object_ptr_reset(object_ptr<BaseObject> *ptr, BaseObject *obj) {
	return ptr->reset(obj);
}

EXPORT int td_bridge_object_get_id(BaseObject *obj) {
    return obj->get_id();
}

EXPORT void td_bridge_object_destroy(BaseObject *obj) {
    delete obj;
}


