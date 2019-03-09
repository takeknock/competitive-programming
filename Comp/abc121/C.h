#pragma once


#include <iostream>
#include <vector>
#include <string>
#include <algorithm>


class Solver {
public:
    void solve();
};


bool pairCompair(const std::pair<long long, long long>& l, const std::pair<long long, long long>& r) {
    return l.first < r.first;
}


void Solver::solve() {
    using namespace std;
    long long n, m;
    cin >> n >> m;
    vector<pair<long long, long long>> store = vector<pair<long long, long long>>();
    for (size_t i = 0; i < n; ++i) {
        long long a, b;
        cin >> a >> b;
        pair<long long, long long> p = pair<long long, long long>(a, b);
        store.push_back(p);
    }
    sort(store.begin(), store.end(), pairCompair);

    long long count = 0;
    long long accum = 0;
    for (size_t i = 0; i < n; ++i) {
        if (count + store[i].second > m) {
            for (size_t j = 0; j < store[i].second; ++j) {
                if (count == m) {
                    break;
                }
                count++;
                accum += store[i].first;
            }
        }
        else {
            count += store[i].second;
            accum += store[i].first * store[i].second;
        }
    }

    cout << accum << endl;
}