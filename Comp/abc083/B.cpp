#include <iostream>
#include "B.h"

void B::solve() {
    // “ü—Í
    int n, a, b;

    std::cin >> n >> a >> b;

    int ans = 0;
    for (std::size_t i = 1; i <= n; ++i) {
        int thisIndex = i;
        int count = 0;
        while (thisIndex != 0) {
            count += thisIndex % 10;
            thisIndex /= 10;
        }
        if (a <= count && count <= b) {
            ans += i;
        }
    }
    std::cout << ans << std::endl;
}