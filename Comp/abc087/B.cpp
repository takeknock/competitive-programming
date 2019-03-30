#include <iostream>

#include "B.h"

void B::solve() {
    // “ü—Í
    int a, b, c, x;

    std::cin >> a >> b >> c >> x;

    int ans = 0;
    for (std::size_t i = 0; i <= a; ++i) {
        for (std::size_t j = 0; j <= b; ++j) {
            for (std::size_t k = 0; k <= c; ++k) {
                int sum = 500 * i + 100 * j + 50 * k;
                if (sum == x)
                    ans++;
            }
        }
    }
    std::cout << ans << std::endl;
}
