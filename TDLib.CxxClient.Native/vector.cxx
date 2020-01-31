#include "tdcxxbridge.h"

using namespace td::td_api;

using objptr = object_ptr<BaseObject>;
using objvec = std::vector<objptr>;

EXPORT const objptr* td_bridge_vector_object_data(const objvec *vecptr, int64_t *size) {
	*size = vecptr->size();
	return vecptr->data();
}

EXPORT void td_bridge_vector_object_clear(objvec *vecptr) {
	vecptr->clear();
}

EXPORT void td_bridge_vector_object_emplace_back(objvec *vecptr, BaseObject *obj) {
	vecptr->emplace_back(obj);
}

EXPORT const int32_t* td_bridge_vector_int32_data(const std::vector<int32_t> *vecptr, int64_t *size) {
	*size = vecptr->size();
	return vecptr->data();
}

EXPORT void td_bridge_vector_int32_assign(std::vector<int32_t> *vecptr, int32_t *data, int64_t size) {
	vecptr->assign(data, data + size);
}

EXPORT const int64_t* td_bridge_vector_int64_data(const std::vector<int64_t> *vecptr, int64_t *size) {
	*size = vecptr->size();
	return vecptr->data();
}

EXPORT void td_bridge_vector_int64_assign(std::vector<int64_t> *vecptr, int64_t *data, int64_t size) {
	vecptr->assign(data, data + size);
}

EXPORT int64_t td_bridge_vector_string_size(const std::vector<std::string> *vecptr) {
	return vecptr->size();
}

EXPORT const std::string* td_bridge_vector_string_at(const std::vector<std::string> *vecptr, int64_t index) {
	return &vecptr->at((size_t)index);
}

EXPORT void td_bridge_vector_string_emplace_back(std::vector<std::string> *vecptr, const char *data, int64_t size) {
	vecptr->emplace_back(data, (size_t)size);
}

EXPORT void td_bridge_vector_string_clear(std::vector<std::string> *vecptr) {
	vecptr->clear();
}

EXPORT const objvec *td_bridge_vector_vector_object_at(const std::vector<objvec> *vecptr, int64_t index) {
	return &vecptr->at(index);
}

EXPORT objvec *td_bridge_vector_vector_object_emplace_back(std::vector<objvec> *vecptr) {
	vecptr->emplace_back();
	return &vecptr->back();
}

EXPORT int64_t td_bridge_vector_vector_object_size(const std::vector<objvec> *vecptr) {
	return vecptr->size();
}

EXPORT void td_bridge_vector_vector_object_clear(std::vector<objvec> *vecptr) {
	return vecptr->clear();
}
