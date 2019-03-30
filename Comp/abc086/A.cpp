#include <iostream>
#include <string>

#include "A.h"

void A::solve() {
    // “ü—Í
    int a, b;
    std::cin >> a >> b;

    std::string ans = (a * b) % 2 ? "Odd" : "Even";
    std::cout << ans << std::endl;

}
