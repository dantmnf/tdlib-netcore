#include "tdcxxbridge.h"
using namespace td;
using namespace td::td_api;

EXPORT Client *td_bridge_client_create() { return new Client(); }
EXPORT void td_bridge_client_destroy(Client *client) { delete client; }

EXPORT void td_bridge_client_send(Client *client, uint64_t id, td_api::Function *func) {
    Client::Request req {id, object_ptr<Function>(func)};
    client->send(std::move(req));
}

EXPORT Object* td_bridge_client_receive(Client *client, double timeout, uint64_t *id) {
    auto result = client->receive(timeout);
	if (result.object) {
		*id = result.id;
		return result.object.release();
	}
    return nullptr;
}

EXPORT Object* td_bridge_client_execute(td_api::Function *func) {
    Client::Request req {0, object_ptr<Function>(func)};
    auto result = Client::execute(std::move(req));
	if (result.object) {
		return result.object.release();
	}
    return nullptr;
}
