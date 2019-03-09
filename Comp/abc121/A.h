#pragma once
#include <iostream>

class Solver {
public:
    void solve();
};

void Solver::solve() {
    int H, W, sh, sw;
    std::cin >> H >> W >> sh >> sw;
    std::cout << (H - sh) * (W - sw) << std::endl;
}
