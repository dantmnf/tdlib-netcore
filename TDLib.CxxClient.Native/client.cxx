#include "tdcxxbridge.h"
using namespace td;
using namespace td::td_api;

EXPORT Client *td_bridge_client_create() { return new Client(); }
EXPORT void td_bridge_client_destroy(Client *client) { delete client; }

EXPORT void td_bridge_client_send(Client *client, int64_t id, td_api::Function *func) {
    Client::Request req {id, object_ptr<Function>(func)};
    client->send(std::move(req));
}

EXPORT Object *td_bridge_client_receive(Client *client, double timeout, int64_t *id) {
    auto result = client->receive(timeout);
    *id = result.id;
    return result.object.release();
}

EXPORT Object * td_bridge_client_execute(Client *client, int64_t inid, td_api::Function *func, int64_t *outid) {
    Client::Request req {inid, object_ptr<Function>(func)};
    auto result = client->execute(std::move(req));
    *outid = result.id;
    return result.object.release();
}
