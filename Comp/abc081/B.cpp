
#include <iostream>
#include <string>

#include "B.h"

void B::solve() {
    // “ü—Í
    int n;

    std::cin >> n;

    int ans = 1000000;
    for (std::size_t i = 0; i < n; ++i) {
        int count = 0;
        int tmp;
        std::cin >> tmp;
        while (tmp % 2 == 0) {
            tmp /= 2;
            count++;
        }
        ans = ans > count ? count : ans;
    }

    std::cout << ans << std::endl;
}