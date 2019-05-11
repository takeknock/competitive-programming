#include <iostream>
#include <string>

#include "C.h"

void C::solve() {
    // “ü—Í
    long long n, a[5];

    std::cin >> n >> a[0] >> a[1] >> a[2] >> a[3] >> a[4];
    long long min = 1e+16;
    for (auto t : a) {
        min = min > t ? t : min;
    }
    long long additional = n % min == 0 ? n / min - 1 : n / min;
    long long ans = min >= n ? 5 : 5 + additional;
    std::cout << ans << std::endl;
}