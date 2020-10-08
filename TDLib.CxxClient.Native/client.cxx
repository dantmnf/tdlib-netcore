#include "tdcxxbridge.h"
using namespace td;
using namespace td::td_api;

EXPORT Client *td_bridge_client_create() { return new Client(); }
EXPORT void td_bridge_client_destroy(Client *client) { delete client; }

EXPORT void td_bridge_client_send(Client *client, uint64_t id, td_api::Function *func) {
    Client::Request req {id, object_ptr<Function>(func)};
    client->send(std::move(req));
}

EXPORT void td_bridge_client_receive(Client *client, double timeout, FetchObjectCallback callback) {
    auto result = client->receive(timeout);
    callback(result.object.get(), result.id);
}

EXPORT void td_bridge_client_execute(Client *client, uint64_t inid, td_api::Function *func, FetchObjectCallback callback) {
    Client::Request req {inid, object_ptr<Function>(func)};
    auto result = client->execute(std::move(req));
    callback(result.object.get(), result.id);
}
