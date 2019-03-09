#pragma once

#include <iostream>
#include <vector>

class Solver {
public:
    void solve();
};

void Solver::solve() {
    int a;
    int b;
    int k;
    std::cin >> a >> b >> k;

    int min;
    std::vector<int> commonDivisors = std::vector<int>();
    if (a > b) min = b;
    else min = a;

    for (int i = 1; i <= min; ++i) {
        if (!(a % i) && !(b % i)) {
            commonDivisors.push_back(i);
        }
    }

    std::size_t index = commonDivisors.size() - k;
    //for (auto e : commonDivisors) {
    //    std::cout << e << std::endl;
    //}
    std::cout << commonDivisors[index] << std::endl;
}