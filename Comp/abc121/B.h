#pragma once

#include <iostream>
#include <vector>
#include <string>
#include <algorithm>

class Solver {
public:
    void solve();
};

void Solver::solve() {
    using namespace std;
    int n, m, c;
    std::cin >> n >> m >> c;
    std::vector<int> b = std::vector<int>();
    for (std::size_t i = 0; i < m; ++i) {
        int t;
        std::cin >> t;
        b.push_back(t);
    }

    int count = 0;
    for (size_t i = 0; i < n; ++i) {
        int result = 0;
        for (size_t j = 0; j < m; ++j) {
            int a;
            cin >> a;
            result += a * b[j];
        }
        if ((result + c) > 0)
            count++;

    }
    cout << count << endl;


}