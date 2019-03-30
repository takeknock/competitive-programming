#pragma once

#include <iostream>
#include <string>
#include <vector>

class Solver {
public:
    void solve();
    std::vector<std::vector<int> > calcNext(const std::string &S);
    void add(long long &a, long long b);
};
