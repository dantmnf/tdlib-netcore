#include "tdcxxbridge.h"

#include "offsets.h"

EXPORT const uint32_t *td_bridge_offset_table(uint32_t *length) {
	*length = (uint32_t)(sizeof(td_bridge_offsets)/sizeof(td_bridge_offsets[0]));
	return td_bridge_offsets;
}
