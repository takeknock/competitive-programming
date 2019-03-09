#pragma once


#include <iostream>

class A {
public:
    void solve();
};

void A::solve() {
    int a, b, c;
    std::cin >> a >> b >> c;

    int ans = b / a > c ? c : b / a;
    std::cout << ans << std::endl;
}
