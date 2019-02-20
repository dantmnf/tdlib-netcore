#include <iostream>

extern "C" __declspec(dllimport) void *td_bridge_client_create();

int main() {
	auto ptr = td_bridge_client_create();
	std::cout << ptr << std::endl;
}